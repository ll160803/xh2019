using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ipedf.Core;
using Ipedf.Web.BizLogic;
using Ipedf.Web.Entity;
using Ipedf.App.Models;
using Ipedf.App.Codes;

namespace Ipedf.App.Controllers
{
    public class APPController : ApiController
    {
        [HttpGet]
        public string LoginSAP(string account, string password)
        {
            Models.MessModel mess = new Models.MessModel();
            try
            {
                BizLogicMsg retMsg = SystemLogic.Proxy.Login(account, password);

                mess.IsSuccess = retMsg.Succeed;
                mess.Mess = retMsg.Message;

                try
                {
                    BizLogicObject_COM_LOG.Proxy.Save(new EntityObject_COM_LOG
                    {
                        LOG_TIME = DateTime.Now,
                        COMMAND = "PDA登录接口",
                        MESSAGE = account + "：PDA登录成功",
                        TYPE = 3

                    });
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
                mess.IsSuccess = false;
                mess.Mess = ex.Message;

                try
                {
                    BizLogicObject_COM_LOG.Proxy.Save(new EntityObject_COM_LOG
                    {
                        LOG_TIME = DateTime.Now,
                        COMMAND = "PDA登录接口",
                        MESSAGE = account + "：PDA登录失败:" + ex.Message,
                        TYPE = 3

                    });
                }
                catch (Exception ex2)
                {
                }
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(mess);
        }

        [HttpGet]
        public string GetSupplyPlanByGYJH(string gyjh)
        {

            WcfMessModel model = new WcfMessModel();

            if (gyjh.Trim().Length != 12)
            {
                model.IsSuccess = false;
                model.Mess = "错误的供应计划号!";
                model.SCM_D_SUPPLYPLAN = null;
                return Newtonsoft.Json.JsonConvert.SerializeObject(model);
            }

            try
            {
                PagingParamter paging = new PagingParamter();

                paging.PageIndex = 0;
                paging.PageSize = 1;

                OrderByParameter OrderByPara = new OrderByParameter();
                OrderByPara.Asc = true;
                OrderByPara.OrderBy = "CODE";
                CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
                //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
                //c_Get.GenerateWhere(cause, search);

                cause.CODE = gyjh;

                var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, paging, OrderByPara);
                if (dataSource.Length > 0)
                {
                    model.IsSuccess = true;
                    model.Mess = "获取成功!";
                    model.SCM_D_SUPPLYPLAN = dataSource.FirstOrDefault();
                }
                else
                {
                    model.IsSuccess = false;
                    model.Mess = "供应计划号不存在!";
                    model.SCM_D_SUPPLYPLAN = null;

                }
                try
                {
                    BizLogicObject_COM_LOG.Proxy.Save(new EntityObject_COM_LOG
                    {
                        LOG_TIME = DateTime.Now,
                        COMMAND = "PDA获取供应计划",
                        MESSAGE = gyjh + "：PDA获取供应计划成功",
                        TYPE = 3

                    });
                }
                catch (Exception ex2)
                {
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Mess = ex.Message;
                model.SCM_D_SUPPLYPLAN = null;

                try
                {
                    BizLogicObject_COM_LOG.Proxy.Save(new EntityObject_COM_LOG
                    {
                        LOG_TIME = DateTime.Now,
                        COMMAND = "PDA获取供应计划",
                        MESSAGE = gyjh + "：PDA获取供应计划失败:" + ex.Message,
                        TYPE = 3

                    });
                }
                catch (Exception ex2)
                {
                }
            }

            return Newtonsoft.Json.JsonConvert.SerializeObject(model);
        }


        [HttpGet]
        public string SupplyPlan_MakeSure(string Code, string gysAccount, string gysName, string num, string amount)
        {
           string gyjh = Code;
            Models.MessModel mess = new MessModel();
            try
            {

                PagingParamter paging = new PagingParamter();

                paging.PageIndex = 0;
                paging.PageSize = 1;

                OrderByParameter OrderByPara = new OrderByParameter();
                OrderByPara.Asc = true;
                OrderByPara.OrderBy = "CODE";
                CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
                //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
                //c_Get.GenerateWhere(cause, search);

                cause.CODE = gyjh;

                var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, paging, OrderByPara);

                var entity = dataSource.FirstOrDefault();
                if (entity == null)
                {
                    mess = new Models.MessModel
                    {
                        IsSuccess = false,
                        Mess = "此供应计划(" + gyjh + ")不存在"
                    };
                    return Newtonsoft.Json.JsonConvert.SerializeObject(mess);
                }
                if (entity.STATUS == "1")
                {
                    mess = new Models.MessModel
                    {
                        IsSuccess = false,
                        Mess = "此供应计划(" + gyjh + ")已经收货确认，请不要重复提交！"//在做扫描的时候，这种信息不再调用接口，或者显示已经收货
                    };
                    return Newtonsoft.Json.JsonConvert.SerializeObject(mess);
                }
                EntityObject_SCM_D_SUPPLYPLAN curObj = new EntityObject_SCM_D_SUPPLYPLAN();
                curObj.ID = entity.ID;
                curObj = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Get(curObj);

                curObj.STATUS = "1";//确认收货
                //int flag = 0;//0 是不提交SAP  1是提交SAP
                //if (Convert.ToDecimal(amount) == curObj.MENGE)
                //{
                //    flag = 1;
                //    curObj.UNINFORMED_STATE = "1";
                //    curObj.INFORMED_STATE = "1";
                //}
                //else
                //{
                //    if (int.Parse(num) > 0)//收的是整装货，如果之前散装货已经收了，则上传SAP
                //    {
                //        curObj.INFORMED_STATE = "1";
                //        if (curObj.UNINFORMED_STATE == "1")
                //        {
                //            flag = 1;
                //        }
                //    }
                //    else//收的是散装货，如果之前整装已经收了，则上传SAP
                //    {
                //        curObj.UNINFORMED_STATE = "1";
                //        if (curObj.INFORMED_STATE == "1")
                //        {
                //            flag = 1;
                //        }
                //    }
                //}
                var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Update(curObj);
                if (msg.Succeed)
                {

                    RfcNOC rnc = new RfcNOC();
                    var listEntity = new List<EntityObject_SCM_D_SUPPLYPLAN>();
                    listEntity.Add(curObj);
                    var List_Back = rnc.SendSupplyPlan("", listEntity, gysAccount, gysName, "1", "U");//SAP返回的列表 1是确认
                    if (List_Back.Count > 0 && List_Back[0].MSTYPE == "S")
                    {

                        mess = new Models.MessModel
                        {
                            IsSuccess = true,
                            Mess = "此供应计划(" + gyjh + ")收货确认成功！"

                        };
                        return Newtonsoft.Json.JsonConvert.SerializeObject(mess);
                    }
                    else
                    {
                        curObj.STATUS = "0";
                        var mg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Update(curObj);//上传SAP失败后 把本地的数据状态 改为 未收货
                        if (List_Back.Count > 0 && List_Back[0].MSTYPE == "H")//调用SAP出错的信息 H是自定义的错误信息
                        {
                            mess = new Models.MessModel
                            {
                                IsSuccess = false,
                                Mess = List_Back[0].MESS

                            };
                            return Newtonsoft.Json.JsonConvert.SerializeObject(mess);
                        }
                        mess = new Models.MessModel
                        {
                            IsSuccess = false,
                            Mess = "此供应计划(" + gyjh + ")上传SAP失败！"

                        };
                        return Newtonsoft.Json.JsonConvert.SerializeObject(mess);

                    }

                }

            }
            catch (Exception ex)
            {

                mess = new Models.MessModel
                {
                    IsSuccess = false,
                    Mess = "收货失败！失败原因：" + ex.Message

                };
                return Newtonsoft.Json.JsonConvert.SerializeObject(mess);
            }
            mess = new Models.MessModel
             {
                 IsSuccess = false,
                 Mess = "收货失败！出现异常错误！"

             };
            return Newtonsoft.Json.JsonConvert.SerializeObject(mess);
        }
    }
}
