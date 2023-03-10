using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ipedf.App.Models;
using Ipedf.Core;
using Ipedf.Web.BizLogic;
using Ipedf.App.Codes;
using Ipedf.Web.Entity;

namespace Ipedf.App
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SCM_XH”。
    public class SCM_XH : ISCM_XH
    {
        public void DoWork()
        {
        }
        /// <summary>
        /// 供应商获取采购订单计划
        /// </summary>
        /// <param name="userName">供应商账号</param>
        /// <param name="password">登录scm密码</param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public WcfMess_XH ExportPurchasePlan(string userName, string password, DateTime startTime, DateTime endTime)
        {
            WcfMess_XH Msg = new WcfMess_XH();
            LogHelper.Info("用户：" + userName + "开始时间：" + startTime.ToString("yyyy-MM-dd") + "结束时间：" + endTime.ToString("yyyy-MM-dd"), 1);
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                Msg.IsSuccess = false;
                Msg.Mess = "参数有误";
                Msg.PurchasePlans = null;
                return Msg;
            }
            try
            {
                var accountCode = userName.Trim().Replace("'", "");
                var en_MDM = BizLogicObject_MDM_D_DEPT.Proxy.Query(new CauseObject_MDM_D_DEPT { CODE = accountCode }).FirstOrDefault();
                if (en_MDM != null && en_MDM.FAX == "1")
                {
                    BizLogicMsg retMsg = SystemLogic.Proxy.Login(userName.Trim().Replace("'", ""), password.Trim().Replace("'", ""));
                    if (retMsg.Succeed)
                    {
                        RfcNOC rnc = new RfcNOC();
                        CauseObject_SCM_D_PURCHARSEPLAN cause = new CauseObject_SCM_D_PURCHARSEPLAN();
                        cause.LIFNR = userName.Trim().Replace("'", "");
                        cause.STATUS = "0";
                        cause.SetCustomCondition(string.Format(" and BEDAT >='{0}' and BEDAT<='{1}'", startTime.ToString("yyyy-MM-dd"), endTime.ToString("yyyy-MM-dd")));

                        var pageIng = new PagingParamter { PageIndex = 0, PageSize = int.MaxValue };


                        var list = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.Query(cause, pageIng, new OrderByParameter { Asc = true, OrderBy = "EBELN,EBELP" });
                        //   var list = rnc.GetPurcharseList("", userName.Trim().Replace("'", ""), "", startTime.ToString("yyyy-MM-dd"), endTime.ToString("yyyy-MM-dd"));
                        var reList = new List<Purchase>();
                        foreach (var item in list)
                        {
                            var v_lgort = item.LGORT;//库位表述
                            var v_name = item.NAME;
                            if (item.BSART == "Z004" && item.WERKS == "2200")// hsc 2019 07 05 去除限制
                            {
                                // var v_lgort2 = Ipedf.Web.Common.SendCode.GetDepartCode(item.SEND_DEAPRT_NAME ?? "");
                                v_name = item.SEND_DEAPRT_NAME ?? "药库";
                            }
                            reList.Add(new Purchase
                            {
                                ID = item.EBELN + item.EBELP,
                                BEDAT = item.BEDAT,
                                EBELN = item.EBELN,
                                EBELP = item.EBELP,
                                EINDT = item.EINDT,
                                LGORT = v_lgort,
                                LIFNR = item.LIFNR,
                                MATNR = item.MATNR,
                                MEINS = item.MEINS,
                                MENGE = item.MENGE,
                                MSEHT = item.MSEHT,
                                NAME1 = v_name,
                                NETPR = item.NETPR,
                                TXZ01 = item.TXZ01,
                                WERKST = item.WERKST,
                                WERKS = item.WERKS


                            });
                            LogHelper.Info(string.Format("item.BEDAT is {0},item.EBELP is {1},item.EBELN is {2},item.EINDT is {3},item.LGORT is {4},item.LIFNR is {5},item.MATNR is {6},item.MSEHT is {7},item.MEINS is {8},item.NAME1 is {9},item.NETPR is {10},item.TXZ01 is {11},item.WERKS is {12},item.WERKST is {13},item.ID is {14}",
                           item.BEDAT.ToString(), item.EBELP.ToString(),
                          item.EBELN.ToString(), item.EINDT.ToString(), item.LGORT.ToString(), item.LIFNR.ToString(), item.MATNR.ToString(), item.MSEHT.ToString(), item.MEINS.ToString()
                          , item.NAME ?? "", item.NETPR.ToString(), item.TXZ01.ToString(), item.WERKS.ToString(), item.WERKST.ToString(), item.ID.ToString()));

                        }
                        Msg.PurchasePlans = reList;
                        Msg.IsSuccess = true;
                        Msg.Mess = "";
                        return Msg;
                    }
                    else
                    {
                        Msg.IsSuccess = false;
                        Msg.Mess = "您的用户名或密码有误";
                        Msg.PurchasePlans = null;
                        return Msg;
                    }
                }
                else
                {
                    Msg.IsSuccess = false;
                    Msg.Mess = "您的接口尚未开通";
                    Msg.PurchasePlans = null;
                    return Msg;
                }
            }
            catch (Exception ex)
            {
                Msg.IsSuccess = false;
                Msg.Mess = "SCM接口出错";
                Msg.PurchasePlans = null;
                return Msg;
            }
        }
        /// <summary>
        /// 发票号与供应计划一一对应
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool IsExistFphm(string WERKS, string LGORT, string FPHM, string ID, string gysAccount)
        {
            if (WERKS == "2000" & (LGORT == "1001" || LGORT == "1008"))
            {
                return true;
            }
            if (WERKS == "2200" & (LGORT == "1002" || LGORT == "1005"))
            {
                return true;
            }
            if (WERKS == "2100")
            {
                return true;
            }
            var cause = new CauseObject_SCM_D_SUPPLYPLAN();
            cause.FPHM = FPHM.Trim();
            cause.GYSACCOUNT = gysAccount;
            if (!string.IsNullOrEmpty(ID))
            {
                cause.SetCustomCondition(" and SCM_D_SUPPLYPLAN.ID !='" + ID + "'");
            }
            var list = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause);
            if (list.Count() > 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 上传供应计划
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="PlanDetails"></param>
        /// <returns></returns>
        public List<WcfPlan_XH> ImportSupplyPlan(string userName, string password, string trueName, List<PlanDetail> PlanDetails)
        {
            LogHelper.Info("用户：" + userName + "上传供应计划", 1);
            List<WcfPlan_XH> ListMess = new List<WcfPlan_XH>();
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                WcfPlan_XH Msg = new WcfPlan_XH();
                Msg.IsSuccess = false;
                Msg.MESS = "参数有误";
                Msg.ID = "";
                ListMess.Add(Msg);
                return ListMess;
            }

            BizLogicMsg retMsg = SystemLogic.Proxy.Login(userName.Trim().Replace("'", ""), password.Trim().Replace("'", ""));
            if (retMsg.Succeed)
            {
                var IsLimit = SupplierLimit.IsSettingLimit(userName.Trim()) ? 0 : 1;//是否验收合格证书上传 0是不限制 1限制
                List<EntityObject_SCM_D_SUPPLYPLAN> list_supp_C = new List<EntityObject_SCM_D_SUPPLYPLAN>();
                //  List<EntityObject_SCM_D_SUPPLYPLAN> list_supp_U = new List<EntityObject_SCM_D_SUPPLYPLAN>();
                List<EntityObject_SCM_D_SUPPLYPLAN> list_supp_D = new List<EntityObject_SCM_D_SUPPLYPLAN>();
                #region 数据验证
                foreach (var item in PlanDetails)
                {
                    if (string.IsNullOrEmpty(item.ID) || item.ID.Length < 32)
                    {
                        ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "ID字段不能为空", IsSuccess = false });
                        continue;
                    }
                    if (string.IsNullOrEmpty(item.EBELN))
                    {
                        ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "EBELN字段不能为空", IsSuccess = false });
                        continue;
                    }
                    //if (string.IsNullOrEmpty(item.GYSACCOUNT))
                    //{
                    //    ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "GYSACCOUNT(供应商账号)字段不能为空", IsSuccess = false });
                    //    continue;
                    //}
                    //if (string.IsNullOrEmpty(item.GYSNAME))
                    //{
                    //    ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "GYSNAME(供应商名称)字段不能为空", IsSuccess = false });
                    //    continue;
                    //}
                    if (string.IsNullOrEmpty(item.GYJH))
                    {
                        ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "GYJH字段不能为空", IsSuccess = false });
                        continue;
                    }
                    if (item.ORDER_MENGE <= 0)
                    {
                        ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "ORDER_MENGE数值必须大于0", IsSuccess = false });
                        continue;
                    }
                    if (item.MENGE <= 0)
                    {
                        ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "MENGE数值必须大于0", IsSuccess = false });
                        continue;
                    }
                    if (string.IsNullOrEmpty(item.FLAG) || !"C U D".Contains(item.FLAG.Trim()))
                    {
                        ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "FALG字段不能为空或非正确值(C,U,D)", IsSuccess = false });
                        continue;
                    }
                    if (item.PKG_AMOUNT < 0)
                    {
                        ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "PKG_AMOUNT数值必须大于等于0", IsSuccess = false });
                        continue;
                    }
                    if (item.PKG_NUMBER < 0)
                    {
                        ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "PKG_NUMBER数值必须大于等于0", IsSuccess = false });
                        continue;
                    }
                    if (item.FPJR <= 0)
                    {
                        ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "FPJR数值必须大于0", IsSuccess = false });
                        continue;
                    }

                    DateTime now = DateTime.Now;
                    if (item.VFDAT < now.AddMonths(6))
                    {
                        ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "药品剩余效期不足6个月", IsSuccess = false });
                        continue;
                    }
                    if (!IsExistFphm(item.WERKS, item.LGORT, item.FPHM, item.ID, userName.Trim().Replace("'", "")))
                    {
                        ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "发票号码已经存在", IsSuccess = false });
                        continue;
                    }

                    EntityObject_SCM_D_SUPPLYPLAN entity = new EntityObject_SCM_D_SUPPLYPLAN();
                    if (item.FLAG == "U" || item.FLAG == "D")
                    {
                        entity = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Get(new EntityObject_SCM_D_SUPPLYPLAN { ID = item.ID });
                        if (entity == null)
                        {
                            ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "不存在的供应计划！", IsSuccess = false });
                            continue;
                        }
                        if (entity.STATUS == "1")
                        {
                            ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "已经收货供应计划，不能修改！", IsSuccess = false });
                            continue;
                        }
                        //缺货验证
                        //var listFiles1 = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.Query(new CauseObject_SCM_D_PURCHARSEPLAN
                        //{
                        //    EBELN = entity.EBELN,
                        //    EBELP = entity.GYJH

                        //});
                        //if (listFiles1.Length > 0)
                        //{
                        //    if (listFiles1[0].MENGE > item.MENGE)
                        //    {
                        //        if (string.IsNullOrEmpty(item.OUT_CAUSE))
                        //        {
                        //            ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "请填写缺货原因！", IsSuccess = false });
                        //            continue;
                        //        }
                        //        if (string.IsNullOrEmpty(item.OUT_DATE.ToString()))
                        //        {
                        //            ListMess.Add(new WcfPlan_XH { ID = item.ID, MESS = "请填写补货日期！", IsSuccess = false });
                        //        }
                        //    }
                        //}
                    }
                    else
                    {
                        if (item.WERKS == "2200")
                        {
                            var plan = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.Query(new CauseObject_SCM_D_PURCHARSEPLAN { EBELN = item.EBELN.Trim(), EBELP = item.GYJH.Trim() }).FirstOrDefault();
                            if (plan != null)
                            {
                                entity.LGORT = plan.LGORT;
                            }
                        }
                        else
                        {
                            entity.LGORT = item.LGORT;
                        }

                        entity.EBELN = item.EBELN;//订单号
                        entity.GYJH = item.GYJH;//项目号
                        entity.WERKS = item.WERKS;
                        entity.WERKST = item.WERKST;
                        entity.MSEHT = item.MSEHT;
                        entity.NETPR = item.NETPR;
                        entity.MATNR = item.MATNR;
                        entity.MEINS = item.MEINS;
                        entity.MENGE = item.MENGE;
                    }
                    entity.BEDAT = item.BEDAT.ToString("yyyyMMdd");
                    entity.CHARG = item.CHARG;
                    entity.COMMENTS = item.COMMENTS;

                    entity.EEIND = item.EEIND.ToString("yyyyMMdd");
                    entity.FPBM = item.FPBM;
                    entity.FPHM = item.FPHM;
                    entity.FPJR = item.FPJR;
                    entity.FPRQ = item.FPRQ;

                    entity.GYSACCOUNT = userName.Trim().Replace("'", "");
                    entity.GYSNAME = trueName.Trim();
                    entity.HSDAT = item.HSDAT;
                    entity.ID = item.ID;



                    entity.ORDER_MENGE = item.ORDER_MENGE;
                    entity.PKG_AMOUNT = item.PKG_AMOUNT;
                    entity.PKG_NUMBER = item.PKG_NUMBER;
                    entity.TXZ01 = item.TXZ01;
                    entity.VFDAT = item.VFDAT;
                    entity.OUT_CAUSE = item.OUT_CAUSE;
                    entity.OUT_DATE = string.IsNullOrEmpty(item.OUT_DATE.ToString()) ? DateTime.MinValue : item.OUT_DATE;

                    entity.BSART = "Z004";//hsc 2017 06 08 如果总务需要做接口 需要做更多修改

                    if (item.FLAG == "C")
                    {
                        entity.STATUS = "0";//0新建 1确认
                        entity.INFORMED_STATE = "0";//整包装 初始状态为0
                        entity.UNINFORMED_STATE = "0";//散包装 初始状态为0
                        // list_supp_C.Add(entity);
                        try
                        {
                            var IsAllow = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.IsAllowAdd(item.EBELN, item.GYJH, item.MENGE, userName.Trim().Replace("'", ""), item.MATNR, item.CHARG, IsLimit, "");

                            if (IsAllow != -1)
                            {

                                if (IsAllow == 1)
                                {
                                    var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Save(entity);
                                    if (string.IsNullOrEmpty(entity.CODE))
                                    {
                                        WcfPlan_XH Msg = new WcfPlan_XH();
                                        Msg.IsSuccess = false;
                                        Msg.MESS = msg.Exception.Message;
                                        Msg.ID = entity.ID;
                                        Msg.CODE = "";
                                        ListMess.Add(Msg);
                                    }
                                    else
                                    {
                                        list_supp_C.Add(entity);//上传SAP
                                    }
                                }
                                else if (IsAllow == 2)
                                {
                                    WcfPlan_XH Msg = new WcfPlan_XH();
                                    Msg.IsSuccess = false;
                                    Msg.MESS = "没有对应的药品验收报告！";
                                    Msg.ID = entity.ID;
                                    Msg.CODE = "";
                                    ListMess.Add(Msg);
                                }
                                else
                                {
                                    WcfPlan_XH Msg = new WcfPlan_XH();
                                    Msg.IsSuccess = false;
                                    Msg.MESS = "供应总数量超出订单数量！";
                                    Msg.ID = entity.ID;
                                    Msg.CODE = "";
                                    ListMess.Add(Msg);
                                }
                            }
                            else
                            {
                                WcfPlan_XH Msg = new WcfPlan_XH();
                                Msg.IsSuccess = false;
                                Msg.MESS = "不存在的订单";
                                Msg.ID = entity.ID;
                                Msg.CODE = "";
                                ListMess.Add(Msg);
                            }
                        }
                        catch (Exception ex)
                        {
                            WcfPlan_XH Msg = new WcfPlan_XH();
                            Msg.IsSuccess = false;
                            Msg.MESS = ex.Message;
                            Msg.ID = entity.ID;
                            Msg.CODE = "";
                            ListMess.Add(Msg);
                        }
                    }
                    else if (item.FLAG == "U")
                    {
                        try
                        {
                            var IsAllow = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.IsAllowAdd(item.EBELN, item.GYJH, item.MENGE, userName.Trim().Replace("'", ""), item.MATNR, item.CHARG, IsLimit, entity.ID);
                            if (IsAllow == 1)
                            {


                                var mg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Update(entity);
                                if (!mg.Succeed)
                                {
                                    WcfPlan_XH Msg = new WcfPlan_XH();
                                    Msg.IsSuccess = false;
                                    Msg.MESS = "更新数据有误";
                                    Msg.ID = entity.ID;
                                    Msg.CODE = "";
                                    ListMess.Add(Msg);
                                }
                                else
                                {
                                    WcfPlan_XH Msg = new WcfPlan_XH();
                                    Msg.IsSuccess = true;
                                    Msg.MESS = "更新数据成功";
                                    Msg.ID = entity.ID;
                                    Msg.CODE = entity.CODE;
                                    ListMess.Add(Msg);
                                }
                            }
                            else if (IsAllow == 2)
                            {
                                WcfPlan_XH Msg = new WcfPlan_XH();
                                Msg.IsSuccess = false;
                                Msg.MESS = "没有对应的药品验收报告！";
                                Msg.ID = entity.ID;
                                Msg.CODE = "";
                                ListMess.Add(Msg);
                            }
                            else
                            {
                                WcfPlan_XH Msg = new WcfPlan_XH();
                                Msg.IsSuccess = false;
                                Msg.MESS = "更新超出订单数量";
                                Msg.ID = entity.ID;
                                Msg.CODE = "";
                                ListMess.Add(Msg);
                            }
                        }
                        catch (Exception ex)
                        {
                            WcfPlan_XH Msg = new WcfPlan_XH();
                            Msg.IsSuccess = false;
                            Msg.MESS = "更新数据有误,错误信息:" + ex.Message;
                            Msg.ID = entity.ID;
                            Msg.CODE = "";
                            ListMess.Add(Msg);
                        }
                        //list_supp_U.Add(entity);
                    }
                    else
                    {
                        list_supp_D.Add(entity);

                    }

                }
                #endregion

                RfcNOC rnc = new RfcNOC();
                #region 删除供应计划
                if (list_supp_D.Count > 0)
                {
                    //var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.BatchSave(list_supp_C.ToArray());

                    var List_Back = rnc.SendSupplyPlan("", list_supp_D, userName, trueName, "0", "D");//SAP返回的列表
                    foreach (var back in List_Back)
                    {
                        var de_entity = list_supp_D.Where(p => p.CODE == back.ZGYJH).FirstOrDefault();
                        if (back.MSTYPE == "S")
                        {

                            var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Delete(de_entity);
                            if (msg.Succeed)
                            {

                                WcfPlan_XH Msg = new WcfPlan_XH();
                                Msg.IsSuccess = true;
                                Msg.MESS = "删除数据成功";
                                Msg.ID = de_entity.ID;
                                Msg.CODE = "";
                                ListMess.Add(Msg);

                            }
                            else
                            {
                                WcfPlan_XH Msg = new WcfPlan_XH();
                                Msg.IsSuccess = false;
                                Msg.MESS = "删除数据失败";
                                Msg.ID = de_entity.ID;
                                Msg.CODE = "";
                                ListMess.Add(Msg);
                            }
                        }
                        else
                        {
                            WcfPlan_XH Msg = new WcfPlan_XH();
                            Msg.IsSuccess = false;
                            Msg.MESS = "删除数据失败";
                            Msg.ID = de_entity.ID;
                            Msg.CODE = "";
                            ListMess.Add(Msg);
                        }
                    }

                }

                #endregion

                #region 增加供应计划
                if (list_supp_C.Count > 0)
                {
                    //var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.BatchSave(list_supp_C.ToArray());
                    try
                    {
                        var List_Back = rnc.SendSupplyPlan("", list_supp_C, userName, trueName, "0", "C");//SAP返回的列表
                        if (List_Back.Count == 0 || List_Back[0].MSTYPE != "S")
                        {
                            foreach (var en in list_supp_C)
                            {
                                BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Delete(en);//上传SAP失败后 删除数据
                                WcfPlan_XH Msg = new WcfPlan_XH();
                                Msg.IsSuccess = false;
                                Msg.MESS = "增加数据失败,错误消息：" + (List_Back.Count > 0 ? List_Back[0].MESS : "无");
                                Msg.ID = en.ID;
                                Msg.CODE = "";
                                ListMess.Add(Msg);
                            }
                        }
                        else
                        {
                            foreach (var back in List_Back)
                            {
                                var c_entity = list_supp_C.Where(p => p.CODE == back.ZGYJH).FirstOrDefault();
                                WcfPlan_XH Msg = new WcfPlan_XH();
                                if (back.MSTYPE == "S")
                                {

                                    Msg.IsSuccess = true;
                                    Msg.MESS = "增加数据成功";
                                    Msg.ID = c_entity.ID;
                                    Msg.CODE = c_entity.CODE;
                                    ListMess.Add(Msg);
                                }
                                else
                                {
                                    BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Delete(c_entity);//上传SAP失败后 删除数据

                                    Msg.IsSuccess = false;
                                    Msg.MESS = "增加数据失败";
                                    Msg.ID = c_entity.ID;
                                    Msg.CODE = "";
                                    ListMess.Add(Msg);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        foreach (var en in list_supp_C)
                        {
                            BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Delete(en);//上传SAP失败后 删除数据
                            WcfPlan_XH Msg = new WcfPlan_XH();
                            Msg.IsSuccess = false;
                            Msg.MESS = "增加数据失败,错误消息：" + ex.Message;
                            Msg.ID = en.ID;
                            Msg.CODE = "";
                            ListMess.Add(Msg);
                        }
                    }

                }

                #endregion
            }
            else
            {
                WcfPlan_XH Msg = new WcfPlan_XH();
                Msg.IsSuccess = false;
                Msg.MESS = "没有操作权限";
                Msg.ID = "";
                Msg.CODE = "";
                ListMess.Add(Msg);
                return ListMess;
            }
            return ListMess;
        }
    }
}
