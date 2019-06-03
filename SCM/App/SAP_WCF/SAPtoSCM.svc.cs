using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ipedf.Web.Entity;
using Ipedf.App.Codes;
using Ipedf.Web.BizLogic;
using Ipedf.App.Models;
using Ipedf.Core;

namespace Ipedf.App.SAP_WCF
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SAPtoSCM”。
    public class SAPtoSCM : ISAPtoSCM
    {
        ///// <summary>
        ///// 获取采购订单
        ///// </summary>
        ///// <param name="purcharseList"></param>
        ///// <param name="Flag"></param>
        ///// <returns></returns>
        //public bool GetPucharseFromSap(List<Sap_PurchasePlan> purcharseList, string Flag)
        //{
        //    LogHelper.Info("从SAP获取订单开始");

        //    var listDepart = BizLogicObject_SCM_D_SENDDEPART.Proxy.Query(new CauseObject_SCM_D_SENDDEPART { });
        //    if (purcharseList.Count > 0)
        //    {
        //        if (Flag == "U")
        //        {
        //            LogHelper.Info("从SAP更新订单开始");
        //            var cause = new CauseObject_SCM_D_PURCHARSEPLAN();
        //            List<EntityObject_SCM_D_PURCHARSEPLAN> list_Update = new List<EntityObject_SCM_D_PURCHARSEPLAN>();
        //            List<EntityObject_SCM_D_PURCHARSEPLAN> list_Delete = new List<EntityObject_SCM_D_PURCHARSEPLAN>();
        //            foreach (var item in purcharseList)
        //            {
        //               // LogHelper.Info("KOSTL:"+item.KOSTL);
        //                cause.SetCustomCondition(" and SCM_D_PURCHARSEPLAN.EBELN='" + item.EBELN.Trim() + "' AND SCM_D_PURCHARSEPLAN.EBELP='" + item.EBELP.Trim() + "' ");
        //                var ens = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.Query(cause).FirstOrDefault();
        //                if (item.LOEKZ == "L")
        //                {
        //                    if (ens != null)
        //                    {
        //                        list_Delete.Add(ens);
        //                    }
        //                }
        //                else
        //                {
        //                    if (ens != null)
        //                    {
        //                        ens.EBELN = item.EBELN;
        //                        ens.BEDAT = item.BEDAT;
        //                        ens.EBELP = item.EBELP;
        //                        ens.EINDT = item.EINDT;
        //                        ens.LGORT = item.LGORT;
        //                        ens.LIFNR = item.LIFNR;
        //                        ens.MATNR = item.MATNR;
        //                        ens.MENGE = item.MENGE;
        //                        ens.MSEHT = item.MSEHT;
        //                        ens.NAME = item.NAME;
        //                        ens.STATUS = "0";
        //                        ens.NETPR = item.NETPR.Replace(",", "");
        //                        ens.WERKS = item.WERKS;
        //                        ens.WERKST = item.WERKST;
        //                        ens.TXZ01 = item.TXZ01;
        //                        ens.MEINS = item.MEINS;
        //                        ens.BSART = item.BSART;
        //                        if (item.BSART == "Z004")
        //                        {
        //                            ens.SEND_DEAPRT_NAME = item.REMARK;//西院的药品订单 接收科室放在订单备注里
        //                        }
        //                        else
        //                        {
        //                            if (!string.IsNullOrEmpty(item.KOSTL))//采购订单含有送货科室编码
        //                            {
        //                                var depart = listDepart.FirstOrDefault(p => p.CODE.Trim() == item.KOSTL.Trim());
        //                                if (depart != null)
        //                                {
        //                                    ens.SEND_DEAPRT_ID = depart.CODE;
        //                                    ens.SEND_DEAPRT_NAME = depart.NAME;
        //                                }
        //                            }
        //                        }
        //                        list_Update.Add(ens);

        //                    }
        //                }
        //            }
        //            var msg = new BizLogicMsg(true, "");
        //            if (list_Update.Count > 0)
        //            {
        //                msg = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.BatchUpdate(list_Update.ToArray());
        //                if (msg.Succeed)
        //                {
        //                    LogHelper.Info("更新订单成功！");
        //                }
        //                else
        //                {
        //                    LogHelper.Info("更新订单失败！，原因：" + msg.Exception.Message);
        //                }
        //            }
        //            var msg_D = new BizLogicMsg(true, "");
        //            if (list_Delete.Count > 0)
        //            {
        //                msg_D = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.BatchDelete(list_Delete.ToArray());
        //                if (msg_D.Succeed)
        //                {
        //                    LogHelper.Info("删除订单成功！");
        //                }
        //                else
        //                {
        //                    LogHelper.Info("删除订单失败！，原因：" + msg.Exception.Message);
        //                }
        //            }
        //            return msg.Succeed&&msg_D.Succeed;

        //        }
        //        else 
        //        {
        //            List<EntityObject_SCM_D_PURCHARSEPLAN> list_purchase_C = new List<EntityObject_SCM_D_PURCHARSEPLAN>();
        //            foreach (var item in purcharseList)
        //            {
        //                // LogHelper.Info("KOSTL:" + item.KOSTL);
        //                var entity = new EntityObject_SCM_D_PURCHARSEPLAN
        //                {
        //                    EBELN = item.EBELN,
        //                    BEDAT = item.BEDAT,
        //                    EBELP = item.EBELP,
        //                    EINDT = item.EINDT,
        //                    LGORT = item.LGORT,
        //                    LIFNR = item.LIFNR,
        //                    MATNR = item.MATNR,
        //                    MENGE = item.MENGE,
        //                    MSEHT = item.MSEHT,
        //                    NAME = item.NAME,
        //                    STATUS = "0",
        //                    NETPR = item.NETPR.Replace(",", ""),
        //                    WERKS = item.WERKS,
        //                    WERKST = item.WERKST,
        //                    TXZ01 = item.TXZ01,
        //                    MEINS = item.MEINS,
        //                    BSART = item.BSART,

        //                    ID = Guid.NewGuid().ToString()
        //                };
        //                if (item.BSART == "Z004")
        //                {
        //                    entity.SEND_DEAPRT_NAME = item.REMARK;//西院的药品订单 接收科室放在订单备注里
        //                }
        //                else
        //                {
        //                    if (!string.IsNullOrEmpty(item.KOSTL))//采购订单含有送货科室编码
        //                    {
        //                        var depart = listDepart.FirstOrDefault(p => p.CODE.Trim() == item.KOSTL.Trim());
        //                        if (depart != null)
        //                        {
        //                            entity.SEND_DEAPRT_ID = depart.CODE;
        //                            entity.SEND_DEAPRT_NAME = depart.NAME;
        //                        }
        //                    }
        //                }
                        
        //                var purStr = string.Format("EBELN:{0},BEDAT:{1},EBELP:{2},EINDT:{3},LGORT:{4},LIFNR:{5},MATNR:{6},MENGE:{7},MSEHT:{8},NETPR:{9},WERKS:{10},BSART2017:{11}",
        //                    item.EBELN, item.BEDAT, item.EBELP, item.EINDT, item.LGORT, item.LIFNR, item.MATNR, item.MENGE.ToString(), item.MSEHT, item.NETPR, item.WERKS, item.BSART);
        //                LogHelper.Info(purStr);
        //                list_purchase_C.Add(entity);
        //            }
        //            if (list_purchase_C.Count > 0)
        //            {
        //                try
        //                {
        //                    var msg = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.BatchSave(list_purchase_C.ToArray());
        //                    if (msg.Succeed)
        //                    {
        //                        LogHelper.Info("获取订单成功！");
        //                    }
        //                    else
        //                    {
        //                        LogHelper.Info("获取订单失败！，原因：" + msg.Exception.Message);
        //                    }
        //                    return msg.Succeed;
        //                }
        //                catch (Exception ex)
        //                {
        //                    LogHelper.Error(ex);
        //                }
        //            }
        //        }
               
        //    }
        //    return false;

        //}

        /// <summary>
        /// 获取采购订单
        /// </summary>
        /// <param name="purcharseList"></param>
        /// <param name="Flag"></param>
        /// <returns></returns>
        public bool GetPucharseFromSap(List<Sap_PurchasePlan> purcharseList, string Flag)
        {
            LogHelper.Info("从SAP获取订单开始");

            var listDepart = BizLogicObject_SCM_D_SENDDEPART.Proxy.Query(new CauseObject_SCM_D_SENDDEPART { });
            if (purcharseList.Count > 0)
            {
                LogHelper.Info("从SAP更新订单开始");
                var cause = new CauseObject_SCM_D_PURCHARSEPLAN();
                List<EntityObject_SCM_D_PURCHARSEPLAN> list_Update = new List<EntityObject_SCM_D_PURCHARSEPLAN>();
                List<EntityObject_SCM_D_PURCHARSEPLAN> list_Delete = new List<EntityObject_SCM_D_PURCHARSEPLAN>();
                List<EntityObject_SCM_D_PURCHARSEPLAN> list_purchase_C = new List<EntityObject_SCM_D_PURCHARSEPLAN>();
                foreach (var item in purcharseList)
                {
                    Flag = CheckFlag(item.EBELN, item.EBELP);
                    // LogHelper.Info("KOSTL:"+item.KOSTL);
                    if (Flag == "U")
                    {
                        cause.SetCustomCondition(" and SCM_D_PURCHARSEPLAN.EBELN='" + item.EBELN.Trim() + "' AND SCM_D_PURCHARSEPLAN.EBELP='" + item.EBELP.Trim() + "' ");
                        var ens = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.Query(cause).FirstOrDefault();
                        if (item.LOEKZ == "L")
                        {
                            if (ens != null)
                            {
                                list_Delete.Add(ens);
                            }
                        }
                        else
                        {
                            if (ens != null)
                            {
                                ens.EBELN = item.EBELN;
                                ens.BEDAT = item.BEDAT;
                                ens.EBELP = item.EBELP;
                                ens.EINDT = item.EINDT;
                                ens.LGORT = item.LGORT;
                                ens.LIFNR = item.LIFNR;
                                ens.MATNR = item.MATNR;
                                ens.MENGE = item.MENGE;
                                ens.MSEHT = item.MSEHT;
                                ens.NAME = item.NAME;
                                ens.STATUS = "0";
                                ens.NETPR = item.NETPR.Replace(",", "");
                                ens.WERKS = item.WERKS;
                                ens.WERKST = item.WERKST;
                                ens.TXZ01 = item.TXZ01;
                                ens.MEINS = item.MEINS;
                                ens.BSART = item.BSART;
                                ens.SEND_DEAPRT_CONTACT = item.CONTACT;
                                ens.SEND_DEAPRT_PHONE = item.PHONE;
                                ens.COMMENTS = item.COMMENTS;
                                if (item.BSART == "Z004")
                                {
                                    ens.SEND_DEAPRT_NAME = item.REMARK;//西院的药品订单 接收科室放在订单备注里
                                }
                                else
                                {
                                    if (!string.IsNullOrEmpty(item.KOSTL))//采购订单含有送货科室编码
                                    {
                                        var depart = listDepart.FirstOrDefault(p => p.CODE.Trim() == item.KOSTL.Trim());
                                        if (depart != null)
                                        {
                                            ens.SEND_DEAPRT_ID = depart.CODE;
                                            ens.SEND_DEAPRT_NAME = depart.NAME;
                                        }
                                    }
                                }
                                list_Update.Add(ens);

                            }
                        }
                    }
                    else if (Flag == "C")
                    { 
                        var entity = new EntityObject_SCM_D_PURCHARSEPLAN
                        {
                            EBELN = item.EBELN,
                            BEDAT = item.BEDAT,
                            EBELP = item.EBELP,
                            EINDT = item.EINDT,
                            LGORT = item.LGORT,
                            LIFNR = item.LIFNR,
                            MATNR = item.MATNR,
                            MENGE = item.MENGE,
                            MSEHT = item.MSEHT,
                            NAME = item.NAME,
                            STATUS = "0",
                            NETPR = item.NETPR.Replace(",", ""),
                            WERKS = item.WERKS,
                            WERKST = item.WERKST,
                            TXZ01 = item.TXZ01,
                            MEINS = item.MEINS,
                            BSART = item.BSART,
                            SEND_DEAPRT_CONTACT = item.CONTACT,
                            SEND_DEAPRT_PHONE = item.PHONE,
                            COMMENTS = item.COMMENTS,
                            ID = Guid.NewGuid().ToString()
                        };
                        if (item.BSART == "Z004")
                        {
                            entity.SEND_DEAPRT_NAME = item.REMARK;//西院的药品订单 接收科室放在订单备注里
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(item.KOSTL))//采购订单含有送货科室编码
                            {
                                var depart = listDepart.FirstOrDefault(p => p.CODE.Trim() == item.KOSTL.Trim());
                                if (depart != null)
                                {
                                    entity.SEND_DEAPRT_ID = depart.CODE;
                                    entity.SEND_DEAPRT_NAME = depart.NAME;
                                }
                            }
                        }
                        
                        var purStr = string.Format("EBELN:{0},BEDAT:{1},EBELP:{2},EINDT:{3},LGORT:{4},LIFNR:{5},MATNR:{6},MENGE:{7},MSEHT:{8},NETPR:{9},WERKS:{10},BSART2017:{11}",
                            item.EBELN, item.BEDAT, item.EBELP, item.EINDT, item.LGORT, item.LIFNR, item.MATNR, item.MENGE.ToString(), item.MSEHT, item.NETPR, item.WERKS, item.BSART);
                        LogHelper.Info(purStr);
                        list_purchase_C.Add(entity);
                    }
                    
                }
                var msg = new BizLogicMsg(true, "");
                if (list_purchase_C.Count > 0)
                {
                    try
                    {
                        msg = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.BatchSave(list_purchase_C.ToArray());
                        if (msg.Succeed)
                        {
                            LogHelper.Info("获取订单成功！");
                        }
                        else
                        {
                            LogHelper.Info("获取订单失败！，原因：" + msg.Exception.Message);
                        }
                        //return msg.Succeed;
                    }
                    catch (Exception ex)
                    {
                        LogHelper.Error(ex);
                    }
                }
                if (list_Update.Count > 0)
                {
                    msg = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.BatchUpdate(list_Update.ToArray());
                    if (msg.Succeed)
                    {
                        LogHelper.Info("更新订单成功！");
                    }
                    else
                    {
                        LogHelper.Info("更新订单失败！，原因：" + msg.Exception.Message);
                    }
                }
                var msg_D = new BizLogicMsg(true, "");
                if (list_Delete.Count > 0)
                {
                    msg_D = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.BatchDelete(list_Delete.ToArray());
                    if (msg_D.Succeed)
                    {
                        LogHelper.Info("删除订单成功！");
                    }
                    else
                    {
                        LogHelper.Info("删除订单失败！，原因：" + msg.Exception.Message);
                    }
                }
                return msg.Succeed && msg_D.Succeed;

            }
            return false;

        }

        public bool GetMaterFromSap(List<SAP_MATER> materList, string Flag)
        {
            LogHelper.Info("从SAP获取物料开始");

            if (materList.Count > 0)
            {

                LogHelper.Info("从SAP更新物料开始");
                var cause = new CauseObject_SCM_D_MATER();
                List<EntityObject_SCM_D_MATER> list_Update = new List<EntityObject_SCM_D_MATER>();
                List<EntityObject_SCM_D_MATER> list_purchase_C = new List<EntityObject_SCM_D_MATER>();
                foreach (var item in materList)
                {
                    #region 数据重复排查
                    //if (list_Update.Count(p => p.GYSACCOUNT == item.GYSACCOUNT.Trim() && p.MATNR == item.MATNR.Trim()) > 0 || list_purchase_C.Count(p => p.GYSACCOUNT == item.GYSACCOUNT.Trim() && p.MATNR == item.MATNR.Trim()) > 0)
                    //{
                    //    continue;
                    //}
                    #endregion
                    cause.SetCustomCondition(" and SCM_D_MATER.GYSACCOUNT='" + item.GYSACCOUNT.Trim() + "' and   SCM_D_MATER.MATNR='" + item.MATNR.Trim() + "' ");
                    var ens = BizLogicObject_SCM_D_MATER.Proxy.Query(cause).FirstOrDefault();
                    if (ens != null)
                    {
                        ens.MATNR = item.MATNR.Trim();
                        ens.GYSACCOUNT = item.GYSACCOUNT.Trim();
                        ens.PRODUCE_AREA = item.PRODUCE_AREA == null ? "" : item.PRODUCE_AREA.Trim();
                        ens.SPEC = item.SPEC == null ? "" : item.SPEC.Trim();
                        ens.SPELL_CODE = item.SPELL_CODE == null ? "" : item.SPELL_CODE.Trim();
                        ens.BKLAS = item.BKLAS == null ? "" : item.BKLAS.Trim();
                        list_Update.Add(ens);
                    }
                    else
                    {
                        var entity = new EntityObject_SCM_D_MATER
                        {
                            GYSACCOUNT = item.GYSACCOUNT.Trim(),
                            PRODUCE_AREA = item.PRODUCE_AREA == null ? "" : item.PRODUCE_AREA.Trim(),
                            SPELL_CODE = item.SPELL_CODE == null ? "" : item.SPELL_CODE.Trim(),
                            SPEC = item.SPEC == null ? "" : item.SPEC.Trim(),
                            TXZ01 = item.TXZ01.Trim(),
                            MATNR = item.MATNR.Trim(),
                            BKLAS = item.BKLAS == null ? "" : item.BKLAS.Trim(),
                            ID = Guid.NewGuid().ToString()


                        };
                        var purStr = string.Format("GYSACCOUNT:{0},PRODUCE_AREA:{1},SPEC:{2},TXZ01:{3},MATNR:{4},SPELL_CODE",
                            item.GYSACCOUNT, item.PRODUCE_AREA, item.SPEC, item.TXZ01, item.MATNR, item.SPELL_CODE);
                        LogHelper.Info(purStr, 1);
                        list_purchase_C.Add(entity);
                    }
                }
                var msg = new Core.BizLogicMsg { Succeed = true };
                if (list_Update.Count > 0)
                {
                    msg = BizLogicObject_SCM_D_MATER.Proxy.BatchUpdate(list_Update.ToArray());
                    if (msg.Succeed)
                    {
                        LogHelper.Info("更新物料成功！", 1);
                    }
                    else
                    {
                        LogHelper.Info("更新物料失败！，原因：" + msg.Exception.Message, 1);
                    }
                }
                if (list_purchase_C.Count > 0)
                {
                    msg = BizLogicObject_SCM_D_MATER.Proxy.BatchSave(list_purchase_C.ToArray());
                    if (msg.Succeed)
                    {
                        LogHelper.Info("获取物料成功！", 1);
                    }
                    else
                    {
                        LogHelper.Info("获取物料失败！，原因：" + msg.Exception.Message, 1);
                    }
                }
                return msg.Succeed;



            }
            return false;

        }
        public bool ChangeStausFromSap(List<Sap_Supply> codeList, string status)
        {
            LogHelper.Info("从SAP更改供应计划状态");
            try
            {
                if (codeList.Count > 0)
                {

                    var arr = codeList.Select(p => "'" + p.Code + "'").ToArray();
                    string IDS = String.Join(", ", arr);
                    var cause = new CauseObject_SCM_D_SUPPLYPLAN();
                    cause.SetCustomCondition(string.Format(" and SCM_D_SUPPLYPLAN.CODE in ({0})", IDS));
                    var list_supplyplan_U = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause);
                    foreach (var item in list_supplyplan_U)
                    {
                        item.STATUS = status;
                        item.SetUpdate("STATUS");
                    }
                    var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.BatchUpdate(list_supplyplan_U);
                    if (msg.Succeed)
                    {
                        LogHelper.Info("从SAP更改供应计划状态成功！");
                        return true;

                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
            }
            return false;
        }

        public bool ModifyMdmStatusFromSap(List<string> accountCodeList, string status)
        {
            LogHelper.Info("从SAP更改用户状态");
            try
            {
                if (accountCodeList.Count > 0)
                {

                    string accounts = String.Join(", ", accountCodeList);
                    var cause = new CauseObject_COM_USER();
                    cause.SetCustomCondition(string.Format(" and COM_USER.ACCOUNT in ({0})", accounts));
                    var list_com_user = BizLogicObject_COM_USER.Proxy.Query(cause);
                    foreach (var item in list_com_user)
                    {
                        item.IS_USABLE = 1;
                    }
                    var msg = BizLogicObject_COM_USER.Proxy.BatchUpdate(list_com_user);
                    if (msg.Succeed)
                    {
                        LogHelper.Info("从SAP更改用户状态成功！");
                        var cause_mdm = new CauseObject_MDM_D_DEPT();
                        cause_mdm.SetCustomCondition(string.Format(" and COM_USER.CODE in ({0})", accounts));
                        List<DisplayObject_MDM_D_DEPT> updateDetailEntities = BizLogicObject_MDM_D_DEPT.Proxy.Query(cause_mdm).ToList();
                        foreach (var item in updateDetailEntities)
                        {
                            item.STATE = 1;
                        }
                        msg = BizLogicObject_MDM_D_DEPT.Proxy.BatchUpdate(updateDetailEntities.ToArray());
                        if (msg.Succeed)
                        {
                            LogHelper.Info("从SAP更改MDM状态成功！");
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
            }
            return false;
        }

        /// <summary>
        /// 获取hrp物料
        /// </summary>
        /// <param name="materList"></param>
        /// <param name="Flag"></param>
        /// <returns></returns>
        public bool GetHrpMaterFromSap(List<HRP_MATER> materList, string Flag)
        {
            LogHelper.Info("从SAP获取物料开始");
            if (Flag == "D")
            {
                var cause = new CauseObject_SCM_D_HRPMATER();
                List<EntityObject_SCM_D_HRPMATER> delete_Update = new List<EntityObject_SCM_D_HRPMATER>();
                if (materList.Count > 0)
                {
                    foreach (var item in materList)
                    {
                        cause.SetCustomCondition(" and SCM_D_HRPMATER.MATNR='" + item.MATNR.Trim() + "'");
                        var ens = BizLogicObject_SCM_D_HRPMATER.Proxy.Query(cause).FirstOrDefault();
                        if (ens != null)
                        {
                            delete_Update.Add(ens);
                        }
                    }
                    var msg = new Core.BizLogicMsg { Succeed = true };
                    msg = BizLogicObject_SCM_D_HRPMATER.Proxy.BatchDelete(delete_Update.ToArray());
                    if (msg.Succeed)
                    {
                        LogHelper.Info("更新物料成功！", 1);
                    }
                    else
                    {
                        LogHelper.Info("更新物料失败！，原因：" + msg.Exception.Message, 1);
                    }
                    return msg.Succeed;
                }
            }
            else
            {
                if (materList.Count > 0)
                {

                    LogHelper.Info("从SAP更新订单开始");
                    var cause = new CauseObject_SCM_D_HRPMATER();
                    List<EntityObject_SCM_D_HRPMATER> list_Update = new List<EntityObject_SCM_D_HRPMATER>();
                    List<EntityObject_SCM_D_HRPMATER> list_purchase_C = new List<EntityObject_SCM_D_HRPMATER>();
                    foreach (var item in materList)
                    {
                        #region 数据重复排查
                        //if (list_Update.Count(p => p.GYSACCOUNT == item.GYSACCOUNT.Trim() && p.MATNR == item.MATNR.Trim()) > 0 || list_purchase_C.Count(p => p.GYSACCOUNT == item.GYSACCOUNT.Trim() && p.MATNR == item.MATNR.Trim()) > 0)
                        //{
                        //    continue;
                        //}
                        #endregion
                        cause.SetCustomCondition(" and SCM_D_HRPMATER.MATNR='" + item.MATNR.Trim() + "'");
                        var ens = BizLogicObject_SCM_D_HRPMATER.Proxy.Query(cause).FirstOrDefault();
                        if (ens != null)
                        {
                            ens.MATNR = item.MATNR.Trim();
                            ens.MAKTX = item.MAKTX.Trim();
                            ens.MEINS = item.MEINS == null ? "" : item.MEINS.Trim();
                            ens.MSEHT = item.MSEHT == null ? "" : item.MSEHT.Trim();
                            ens.MTART = item.MTART == null ? "" : item.MTART.Trim();
                            ens.NORMT = item.NORMT == null ? "" : item.NORMT.Trim();
                            ens.ZEINR = item.ZEINR == null ? "" : item.ZEINR.Trim();
                            ens.BKLAS = item.BKLAS == null ? "" : item.BKLAS.Trim();
                            list_Update.Add(ens);
                        }
                        else
                        {
                            var entity = new EntityObject_SCM_D_HRPMATER
                            {
                                MATNR = item.MATNR.Trim(),
                                MAKTX = item.MAKTX.Trim(),
                                MEINS = item.MEINS == null ? "" : item.MEINS.Trim(),
                                MSEHT = item.MSEHT == null ? "" : item.MSEHT.Trim(),
                                MTART = item.MTART == null ? "" : item.MTART.Trim(),
                                NORMT = item.NORMT == null ? "" : item.NORMT.Trim(),
                                ZEINR = item.ZEINR == null ? "" : item.ZEINR.Trim(),
                                BKLAS = item.BKLAS == null ? "" : item.BKLAS.Trim(),
                                ID = Guid.NewGuid().ToString()


                            };
                            var purStr = string.Format("MATNR:{0},MAKTX:{1},MEINS:{2},MSEHT:{3},MTART:{4},ZEINR",
                                item.MATNR, item.MAKTX, item.MEINS, item.MSEHT, item.MTART, item.ZEINR);
                            LogHelper.Info(purStr, 1);
                            list_purchase_C.Add(entity);
                        }
                    }
                    var msg = new Core.BizLogicMsg { Succeed = true };
                    if (list_Update.Count > 0)
                    {
                        msg = BizLogicObject_SCM_D_HRPMATER.Proxy.BatchUpdate(list_Update.ToArray());
                        if (msg.Succeed)
                        {
                            LogHelper.Info("更新物料成功！", 1);
                        }
                        else
                        {
                            LogHelper.Info("更新物料失败！，原因：" + msg.Exception.Message, 1);
                        }
                    }
                    if (list_purchase_C.Count > 0)
                    {
                        msg = BizLogicObject_SCM_D_HRPMATER.Proxy.BatchSave(list_purchase_C.ToArray());
                        if (msg.Succeed)
                        {
                            LogHelper.Info("获取物料成功！", 1);
                        }
                        else
                        {
                            LogHelper.Info("获取物料失败！，原因：" + msg.Exception.Message, 1);
                        }
                    }
                    return msg.Succeed;



                }
            }
            
            return false;

        }

        /// <summary>
        /// 统一对外接口
        /// </summary>
        /// <param name="XML">不含表头</param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string SERVICE(string XML, string key)
        {
            //   string msg_xml = "";
            var headxml = "<?xml version=\"1.0\" encoding=\"utf-8\"?> ";
            if (key == "SAP_DEPART")
            {
                ROOT root = XmlUtil.Deserialize(typeof(ROOT), headxml + XML) as ROOT;
                LogHelper.Info("从SAP获取物料开始");
                var materList = root.BODY.LIST;
                if (materList.Count > 0)
                {

                    LogHelper.Info("从SAP更新订单开始");
                    var cause = new CauseObject_SCM_D_SENDDEPART();
                    List<EntityObject_SCM_D_SENDDEPART> list_Update = new List<EntityObject_SCM_D_SENDDEPART>();
                    List<EntityObject_SCM_D_SENDDEPART> list_purchase_C = new List<EntityObject_SCM_D_SENDDEPART>();
                    foreach (var item in materList)
                    {
                        #region 数据重复排查
                        //if (list_Update.Count(p => p.GYSACCOUNT == item.GYSACCOUNT.Trim() && p.MATNR == item.MATNR.Trim()) > 0 || list_purchase_C.Count(p => p.GYSACCOUNT == item.GYSACCOUNT.Trim() && p.MATNR == item.MATNR.Trim()) > 0)
                        //{
                        //    continue;
                        //}
                        #endregion
                        cause.SetCustomCondition(" and SCM_D_SENDDEPART.CODE='" + item.ID.Trim() + "'");
                        var ens = BizLogicObject_SCM_D_SENDDEPART.Proxy.Query(cause).FirstOrDefault();
                        if (ens != null)
                        {
                            ens.CODE = item.ID.Trim();
                            ens.NAME = item.MC.Trim();
                            ens.SPELL_CODE = item.PYM == null ? "" : item.PYM.Trim();
                            ens.COMMENTS = item.MS;
                            list_Update.Add(ens);
                        }
                        else
                        {
                            var entity = new EntityObject_SCM_D_SENDDEPART
                            {
                                CODE = item.ID.Trim(),
                                NAME = item.MC.Trim(),
                                SPELL_CODE = item.PYM == null ? "" : item.PYM.Trim(),
                                COMMENTS = item.MS,
                                ID = Guid.NewGuid().ToString()


                            };
                            var purStr = string.Format("CODE:{0},NAME:{1},SPELL_CODE:{2},COMMENTS:{3}",
                                item.ID, item.MC, item.PYM, item.MS);
                            LogHelper.Info(purStr, 1);
                            list_purchase_C.Add(entity);
                        }
                    }
                    var msg = new Core.BizLogicMsg { Succeed = true };
                    if (list_Update.Count > 0)
                    {
                        msg = BizLogicObject_SCM_D_SENDDEPART.Proxy.BatchUpdate(list_Update.ToArray());
                        if (msg.Succeed)
                        {
                            LogHelper.Info("更新物料成功！", 1);
                        }
                        else
                        {
                            LogHelper.Info("更新物料失败！，原因：" + msg.Exception.Message, 1);
                        }
                    }
                    if (list_purchase_C.Count > 0)
                    {
                        msg = BizLogicObject_SCM_D_SENDDEPART.Proxy.BatchSave(list_purchase_C.ToArray());
                        if (msg.Succeed)
                        {
                            LogHelper.Info("获取物料成功！", 1);
                        }
                        else
                        {
                            LogHelper.Info("获取物料失败！，原因：" + msg.Exception.Message, 1);
                        }
                    }
                    return "SUCCESS";



                }
                return "FALSE";

            }
            return "FALSE";
        }

        public string CheckFlag(string EBELN, string EBELP)
        {
            var cause = new CauseObject_SCM_D_PURCHARSEPLAN();
            cause.SetCustomCondition(" and SCM_D_PURCHARSEPLAN.EBELN='" + EBELN.Trim() + "' AND SCM_D_PURCHARSEPLAN.EBELP='" + EBELP.Trim() + "' ");
            var ens = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.Query(cause).FirstOrDefault();
            if (ens != null)
            {
                return "U";
            }
            else
            {
                return "C";
            }
        }
    }
}
