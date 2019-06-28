using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ipedf.Web.Entity;
using Ipedf.App.Codes;
using Ipedf.Web.BizLogic;

namespace Ipedf.App.SAP_WCF
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SAPtoSCM”。
    public class SAPtoSCM : ISAPtoSCM
    {
        public bool GetPucharseFromSap(List<Sap_PurchasePlan> purcharseList, string Flag)
        {
            LogHelper.Info("从SAP获取订单开始");

            if (purcharseList.Count > 0)
            {
                if (Flag == "U")
                {
                    LogHelper.Info("从SAP更新订单开始");
                    var cause = new CauseObject_SCM_D_PURCHARSEPLAN();
                    List<EntityObject_SCM_D_PURCHARSEPLAN> list_Update = new List<EntityObject_SCM_D_PURCHARSEPLAN>();
                    foreach (var item in purcharseList)
                    {

                        cause.SetCustomCondition(" and EBELN='" + item.EBELN.Trim() + "' AND EBELP='" + item.EBELP.Trim() + "' ");
                        var ens = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.Query(cause).FirstOrDefault();
                        if (ens != null)
                        {
                            ens.EBELN = item.EBELN;
                            ens.BEDAT = item.BEDAT;
                            ens.EBELP = item.EBELP;
                            ens.EINDT = item.EINDT;
                            ens.LGORT = item.LGORT;
                            ens.LIFNR = item.LIFNR;
                            ens.MATNR = item.MATNR;
                            ens.MENGE = Convert.ToDecimal(item.MENGE);
                            ens.MSEHT = item.MSEHT;
                            ens.NAME = item.NAME;
                            ens.STATUS = "0";
                            ens.NETPR = item.NETPR.Replace(",", "");
                            ens.WERKS = item.WERKS;
                            ens.WERKST = item.WERKST;
                            ens.TXZ01 = item.TXZ01;
                            ens.MEINS = item.MEINS;
                            ens.FREEUSE1 = item.COMMENTS;//备注
                            ens.FREEUSE2 = item.PRODUCTFACTORY;//生产厂商
                            ens.FREEUSE3 = item.SPEC;
                            list_Update.Add(ens);
                        }
                    }
                    var msg = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.BatchUpdate(list_Update.ToArray());
                    if (msg.Succeed)
                    {
                        LogHelper.Info("更新订单成功！");
                    }
                    else
                    {
                        LogHelper.Info("更新订单失败！，原因：" + msg.Exception.Message);
                    }
                    return msg.Succeed;

                }
                else
                {
                    List<EntityObject_SCM_D_PURCHARSEPLAN> list_purchase_C = new List<EntityObject_SCM_D_PURCHARSEPLAN>();
                    foreach (var item in purcharseList)
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
                            MENGE = Convert.ToDecimal(item.MENGE),
                            MSEHT = item.MSEHT,
                            NAME = item.NAME,
                            STATUS = "0",
                            NETPR = item.NETPR.Replace(",", ""),
                            WERKS = item.WERKS,
                            WERKST = item.WERKST,
                            TXZ01 = item.TXZ01,
                            MEINS = item.MEINS,
                            FREEUSE1 = item.COMMENTS,//备注

                            FREEUSE2 = item.PRODUCTFACTORY,//生产厂商
                            FREEUSE3 = item.SPEC,
                            ID = Guid.NewGuid().ToString()


                        };
                        var purStr = string.Format("EBELN:{0},BEDAT:{1},EBELP:{2},EINDT:{3},LGORT:{4},LIFNR:{5},MATNR:{6},MENGE:{7},MSEHT:{8},NETPR:{9},WERKS:{10},MEINS:{11},备注:{12},生产厂商:{13},规格:{14}",
                            item.EBELN, item.BEDAT, item.EBELP, item.EINDT, item.LGORT, item.LIFNR, item.MATNR, item.MENGE.ToString(), item.MSEHT, item.NETPR, item.WERKS, item.MEINS, item.COMMENTS,item.PRODUCTFACTORY,item.SPEC);
                        LogHelper.Info(purStr);
                        list_purchase_C.Add(entity);
                    }
                    if (list_purchase_C.Count > 0)
                    {
                        try
                        {
                            var msg = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.BatchSave(list_purchase_C.ToArray());
                            if (msg.Succeed)
                            {
                                LogHelper.Info("获取订单成功！");
                            }
                            else
                            {
                                LogHelper.Info("获取订单失败！，原因：" + msg.Exception.Message);
                            }
                            return msg.Succeed;
                        }
                        catch (Exception ex)
                        {
                            LogHelper.Error(ex);
                        }
                    }
                }
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
                    cause.SetCustomCondition(string.Format(" and CODE in ({0})", IDS));
                    var list_supplyplan_U = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Query(cause);
                    foreach (var item in list_supplyplan_U)
                    {
                        item.STATUS = status;
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

        public bool GetDrugFromHIS(List<HIS_DRUG> drugList, string Flag)
        {
            LogHelper.Info("从HIS中获取药品开始", 1);

            if (drugList.Count > 0)
            {
                try
                {
                    if (Flag == "C")
                    {
                        List<EntityObject_SCM_COM_DRUG> list_add = new List<EntityObject_SCM_COM_DRUG>();
                        foreach (var item in drugList)
                        {
                            list_add.Add(new EntityObject_SCM_COM_DRUG
                            {
                                CODE = item.CODE,
                                FACTORY = item.FACTORY,
                                DELETEFLAG = 0,//0是未删除 1是删除的
                                ID = Guid.NewGuid().ToString(),
                                MRJJ = Convert.ToDecimal(item.MRJJ),
                                NAME = item.NAME,
                                SPEC = item.SPEC
                            });
                            LogHelper.Info(string.Format("CODE:{0},MRJJ:{1},NAME:{2},SPEC:{3}", item.CODE, item.MRJJ, item.NAME, item.SPEC), 1);
                        }
                        var msg = BizLogicObject_SCM_COM_DRUG.Proxy.BatchSave(list_add.ToArray());
                        if (msg.Succeed == false)
                        {
                            LogHelper.Error(msg.Exception);
                        }
                        else
                        {
                            LogHelper.Info("HIS中获取药品成功", 1);
                        }
                        return msg.Succeed;
                    }
                    else if (Flag == "U")
                    {
                        List<EntityObject_SCM_COM_DRUG> list_update = new List<EntityObject_SCM_COM_DRUG>();
                        var arr = drugList.Select(p => "'" + p.CODE + "'").ToArray();
                        string IDS = String.Join(", ", arr);
                        var cause = new CauseObject_SCM_COM_DRUG();
                        cause.DELETEFLAG = 0;//0是未删 1是删除
                        cause.SetCustomCondition(string.Format(" and CODE in ({0})", IDS));
                        var list_com_drug_U = BizLogicObject_SCM_COM_DRUG.Proxy.Query(cause);
                        foreach (var item in list_com_drug_U)
                        {
                            var in_Item = drugList.Where(p => p.CODE == item.CODE).FirstOrDefault();
                            item.CODE = in_Item.CODE;
                            item.FACTORY = in_Item.FACTORY;
                            item.MRJJ = Convert.ToDecimal(in_Item.MRJJ);
                            item.NAME = in_Item.NAME;
                        }
                        var msg = BizLogicObject_SCM_COM_DRUG.Proxy.BatchUpdate(list_com_drug_U.ToArray());
                        if (msg.Succeed == false)
                        {
                            LogHelper.Error(msg.Exception);
                        }
                        else
                        {
                            LogHelper.Info("HIS中药品更新成功", 1);
                        }
                        return msg.Succeed;
                    }
                    else// 删除数据 D
                    {
                        List<EntityObject_SCM_COM_DRUG> list_update = new List<EntityObject_SCM_COM_DRUG>();
                        var arr = drugList.Select(p => "'" + p.CODE + "'").ToArray();
                        string IDS = String.Join(", ", arr);
                        LogHelper.Info("HIS中删除的数据为" + IDS, 1);
                        var cause = new CauseObject_SCM_COM_DRUG();
                        cause.DELETEFLAG = 0;//0是未删 1是删除
                        var list_com_drug_D = BizLogicObject_SCM_COM_DRUG.Proxy.Query(cause);
                        foreach (var item in list_com_drug_D)
                        {
                            item.DELETEFLAG = 1;
                        }
                        var msg = BizLogicObject_SCM_COM_DRUG.Proxy.BatchUpdate(list_com_drug_D.ToArray());
                        if (msg.Succeed == false)
                        {
                            LogHelper.Error(msg.Exception);
                        }
                        else
                        {
                            LogHelper.Info("HIS中删除成功", 1);
                        }
                        return msg.Succeed;
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Error(ex);
                }
            }
            return false;
        }

    }
}
