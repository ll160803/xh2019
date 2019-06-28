using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ipedf.Core;
using Ipedf.Web.BizLogic;
using Ipedf.Web.Entity;
using Ipedf.App.Codes;
using Ipedf.App.Models;
using System.IO;
using System.Xml.Serialization;
using System.Web.Script.Serialization;

namespace Ipedf.App
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SCM_WCF”。
    public class SCM_WCF : ISCM_WCF
    {
        public void DoWork()
        {
        }


        public Models.MessModel LoginSAP(string account, string password)
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
            return mess;
        }


        public WcfMessModel GetSupplyPlanByGYJH(string gyjh)
        {

            WcfMessModel model = new WcfMessModel();

            if (gyjh.Trim().Length != 12)
            {
                model.IsSuccess = false;
                model.Mess = "错误的供应计划号!";
                model.SCM_D_SUPPLYPLAN = null;
                return model;
            }

            try
            {
                PagingParamter paging = new PagingParamter();

                paging.PageIndex = 0;
                paging.PageSize = 1;

                OrderByParameter OrderByPara = new OrderByParameter();
                OrderByPara.Asc = true;
                OrderByPara.OrderBy = "CODE";
                CauseObject_V_SCM_D_SUPPLIERPLAN cause = new CauseObject_V_SCM_D_SUPPLIERPLAN();
                //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
                //c_Get.GenerateWhere(cause, search);

                cause.CODE = gyjh;

                var dataSource = BizLogicObject_V_SCM_D_SUPPLIERPLAN.Proxy.Query(cause, paging, OrderByPara);
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

            return model;
        }


        public Models.MessModel SupplyPlan_MakeSure(string gyjh, string userCode)
        {
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
                    return new Models.MessModel
                    {
                        IsSuccess = false,
                        Mess = "此供应计划(" + gyjh + ")不存在"
                    };
                }
                if (entity.STATUS == "1")
                {
                    return new Models.MessModel
                    {
                        IsSuccess = false,
                        Mess = "此供应计划(" + gyjh + ")已经收货确认，请不要重复提交！"//在做扫描的时候，这种信息不再调用接口，或者显示已经收货
                    };
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
                    var listEntity = new List<DisplayObject_V_SCM_D_SUPPLIERPLAN>();
                    var v_en = BizLogicObject_V_SCM_D_SUPPLIERPLAN.Proxy.Query(new CauseObject_V_SCM_D_SUPPLIERPLAN { ID = curObj.ID }).FirstOrDefault();
                    listEntity.Add(v_en);
                    var List_Back = rnc.SendSupplyPlan_HIS_PDA(listEntity, userCode);//SAP返回的列表 1是确认
                    if (List_Back.Count > 0 && List_Back[0].MSTYPE == "S")
                    {

                        return new Models.MessModel
                        {
                            IsSuccess = true,
                            Mess = "此供应计划(" + gyjh + ")收货确认成功！"

                        };

                    }
                    else
                    {
                        curObj.STATUS = "0";
                        var mg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Update(curObj);//上传SAP失败后 把本地的数据状态 改为 未收货
                        if (List_Back.Count > 0 && List_Back[0].MSTYPE == "H")//调用SAP出错的信息 H是自定义的错误信息
                        {
                            return new Models.MessModel
                            {
                                IsSuccess = false,
                                Mess = List_Back[0].MESS

                            };
                        }
                        return new Models.MessModel
                        {
                            IsSuccess = false,
                            Mess = "此供应计划(" + gyjh + ")上传HIS失败！"

                        };

                    }

                }

            }
            catch (Exception ex)
            {

                return new Models.MessModel
                {
                    IsSuccess = false,
                    Mess = "收货失败！失败原因：" + ex.Message

                };
            }
            return new Models.MessModel
            {
                IsSuccess = false,
                Mess = "收货失败！出现异常错误！"

            };
        }

        /// <summary>
        /// 分批获取没有收获供应计划的数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public DisplayObject_SCM_D_SUPPLYPLAN[] GetSupplyPlans(int page, int rows)
        {
            try
            {
                LogHelper.Info("离线下载供应计划开始", 1);
                PagingParamter paging = new PagingParamter();

                paging.PageIndex = page;
                paging.PageSize = rows;

                OrderByParameter OrderByPara = new OrderByParameter();
                OrderByPara.Asc = true;
                OrderByPara.OrderBy = "CODE";
                CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
                //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
                //c_Get.GenerateWhere(cause, search);

                cause.STATUS = "0";

                var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, paging, OrderByPara);
                LogHelper.Info("离线下载供应计划结束", 1);
                return dataSource;
            }
            catch (Exception ex)
            {
                LogHelper.Info("出现错误");
                LogHelper.Error(ex);
            }
            return null;
        }

        /// <summary>
        /// 批量上传
        /// </summary>
        /// <param name="listCode"></param>
        /// <param name="userCode"></param>
        /// <returns></returns>
        public MessModel SupplyPlan_MakeSureBatch(List<string> listCode2, string userCode)
        {
            var listCode = listCode2.Distinct().ToList();//去除重复的
            List<EntityObject_SCM_D_SUPPLYPLAN> list_Update = new List<EntityObject_SCM_D_SUPPLYPLAN>();
            List<DisplayObject_V_SCM_D_SUPPLIERPLAN> list_Update_V = new List<DisplayObject_V_SCM_D_SUPPLIERPLAN>();
            if (listCode.Count > 0)
            {
                CauseObject_V_SCM_D_SUPPLIERPLAN cause = new CauseObject_V_SCM_D_SUPPLIERPLAN();
                var codes = string.Join(",", listCode.Select(p => "'" + p + "'"));

                cause.SetCustomCondition("and STATUS!='1' and CODE in (" + codes + ")");
                list_Update_V = BizLogicObject_V_SCM_D_SUPPLIERPLAN.Proxy.Query(cause).ToList<DisplayObject_V_SCM_D_SUPPLIERPLAN>();
                RfcNOC rnc = new RfcNOC();
                var listBack = rnc.SendSupplyPlan_HIS_PDA(list_Update_V, userCode);
                if (listBack.Count > 0)
                {
                    var succ_Entity = listBack.FirstOrDefault();
                    // var updateEntitys = list_Update.Where(p => succ_Entitys.Contains(p.CODE));
                    if (succ_Entity.MSTYPE == "S")
                    {
                        CauseObject_SCM_D_SUPPLYPLAN cause2 = new CauseObject_SCM_D_SUPPLYPLAN();
                        cause2.SetCustomCondition(" and CODE in (" + codes + ")");
                        list_Update = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause2).ToList<EntityObject_SCM_D_SUPPLYPLAN>();
                        List<EntityObject_SCM_D_SUPPLYPLAN> updateList = new List<EntityObject_SCM_D_SUPPLYPLAN>();
                        foreach (var item_up in list_Update)
                        {
                            if (item_up.STATUS != "1")//未收货的做确认收货 
                            {
                                item_up.STATUS = "1";//确认收货
                                updateList.Add(item_up);
                            }
                        }
                        var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.BatchUpdate(updateList.ToArray());
                        if (msg.Succeed)
                        {

                            return new MessModel { IsSuccess = true, Mess = "全部上传成功" };
                        }
                        else
                        {
                            return new MessModel { IsSuccess = false, Mess = "上传HIS成功,修改SCM供应计划状态失败" };
                        }

                    }
                    else
                    {
                        return new MessModel { IsSuccess = false, Mess = "上传HIS失败" + succ_Entity.MESS };
                    }
                }
                else
                {
                    return new MessModel { IsSuccess = false, Mess = "全部上传HIS失败" };
                }
            }
            else
            {
                return new MessModel { IsSuccess = false, Mess = "上传数量为0" };
            }
        }


        //下载XML文件  
        public string DownLoadFile()
        {

            string result = "";


            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "CODE";
            CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
            //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
            //c_Get.GenerateWhere(cause, search);

            cause.STATUS = "0";

            var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, null, OrderByPara).ToList();
            LogHelper.Info("获取到数据");
            MemoryStream Stream = new MemoryStream();
            XmlSerializer xml = new XmlSerializer(typeof(List<DisplayObject_SCM_D_SUPPLYPLAN>));
            try
            {
                //序列化对象
                xml.Serialize(Stream, dataSource);
            }
            catch (InvalidOperationException ex)
            {
                LogHelper.Error(ex);
            }


            Stream.Position = 0;  //重要，不为0的话，客户端读取有问题  
            StreamReader sr = new StreamReader(Stream);
            result = sr.ReadToEnd();
            Stream.Flush();
            sr.Close();
            Stream.Close();
            return result;
        }
        /// <summary>
        /// 下载Json字符串
        /// </summary>
        /// <returns></returns>
        public string DownLoadJsonFile()
        {

            string result = "";


            OrderByParameter OrderByPara = new OrderByParameter();
            OrderByPara.Asc = true;
            OrderByPara.OrderBy = "CODE";
            CauseObject_SCM_D_SUPPLYPLAN cause = new CauseObject_SCM_D_SUPPLYPLAN();
            //GetWhere<CauseObject_SCM_D_SUPPLYPLAN> c_Get = new GetWhere<CauseObject_SCM_D_SUPPLYPLAN>();
            //c_Get.GenerateWhere(cause, search);

            cause.STATUS = "0";

            var dataSource = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause, null, OrderByPara).ToList();
            LogHelper.Info("获取到供应计划JSON数据", 1);
            MemoryStream Stream = new MemoryStream();
            JavaScriptSerializer serializer = new JavaScriptSerializer() { MaxJsonLength = Int32.MaxValue };
            try
            {
                //序列化对象
                result = serializer.Serialize(dataSource);
            }
            catch (InvalidOperationException ex)
            {
                LogHelper.Error(ex);
            }



            return result;
        }

    }
}
