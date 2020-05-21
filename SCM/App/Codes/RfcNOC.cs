using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SAP.Middleware.Connector;
using System.Data;
using Ipedf.App.Models;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Ipedf.App.Codes
{
    public class RfcNOC
    {
        /// <summary>
        /// 连接字符串 连接SAP
        /// </summary>
        /// <returns></returns>
        private RfcConfigParameters GetConfigParams()
        {

            RfcConfigParameters configParams = new RfcConfigParameters();


            // Name property is neccessary, otherwise, NonInvalidParameterException will be thrown

            configParams.Add(RfcConfigParameters.Name, "ECC");

            configParams.Add(RfcConfigParameters.AppServerHost, "192.168.64.26:3600");
            //configParams.Add(RfcConfigParameters.MessageServerHost, "192.168.64.26");
            //configParams.Add(RfcConfigParameters.LogonGroup, "P01");

            configParams.Add(RfcConfigParameters.SystemNumber, "01"); // instance number

            //configParams.Add(RfcConfigParameters.SystemID, "P01");


            configParams.Add(RfcConfigParameters.User, "COM_SCM");

            configParams.Add(RfcConfigParameters.Password, "822019");

            configParams.Add(RfcConfigParameters.Client, "800");

            configParams.Add(RfcConfigParameters.Language, "ZH");

            configParams.Add(RfcConfigParameters.PoolSize, "5");

            configParams.Add(RfcConfigParameters.PeakConnectionsLimit, "10");

            configParams.Add(RfcConfigParameters.IdleTimeout, "30");


            return configParams;

        }

        public RfcDestination GetDestination()
        {

            //  RfcConfigParameters configParams = this.GetConfigParams();

            RfcDestination dest = RfcDestinationManager.GetDestination("ECC");//在Webconfig里面配置

            //RfcDestination dest = RfcDestinationManager.GetDestination(configParams);//在Webconfig里面配置
            return dest;

        }


        /// <summary>
        /// 获取供应商对应的采购订单列表
        /// </summary>
        /// <param name="LIFNR">供应商号</param>
        /// <param name="startDate">开始日期默认前一周</param>
        /// <param name="endDate">结束日期，默认当前日期</param>
        /// <param name="fuName">执行函数名称</param>
        public List<Purchase> GetPurcharseList(string userID, string LIFNR, string LIFNRNAME, string startDate, string endDate, string fuName = "ZMM00_FM_SCMPURCHORDGET")
        {
            LogHelper.Info("GetPurcharseList begin");
            var list = new List<Purchase>();
            RfcDestination destination;
            try
            {

                destination = this.GetDestination();

                RfcRepository rfcrep = destination.Repository;
                IRfcFunction myfun = null;
                myfun = rfcrep.CreateFunction(fuName);
                //  myfun.SetValue("IS_SELCOND", "0");//SAP里面的传入参数
                if (myfun == null)
                    LogHelper.Info(fuName + " is null");
                IRfcStructure IrfStruct = myfun.GetStructure("IS_SELCOND");
                if (IrfStruct == null)
                    LogHelper.Info("IrfStruct is null");
                IrfStruct.SetValue("LIFNR", LIFNR);
                IrfStruct.SetValue("ZBEDATL", startDate);
                IrfStruct.SetValue("ZBEDATH", endDate);
                myfun.SetValue("IS_SELCOND", IrfStruct);
                //提前实例化一个空的表结构出来
                myfun.Invoke(destination);//执行
                LogHelper.Info(fuName + "myfun.Invoke succeed");
                IRfcTable rfcReturn = myfun.GetTable("OT_PURCHINFO"); //此处返回类型为Structure 如果是Single类型 则直接调用myfun.GetString("RETURN");
                if (rfcReturn == null)
                    LogHelper.Info("rfcReturn is null");
                LogHelper.Info(string.Format("rfcReturn.Count is {0}", rfcReturn.Count.ToString()));
                for (int i = 0; i < rfcReturn.Count; i++)
                {
                    rfcReturn.CurrentIndex = i;
                    LogHelper.Info(string.Format("index is {0}", i.ToString()));
                    Purchase pur = new Purchase
                    {
                        BEDAT = rfcReturn.GetString("BEDAT"),
                        EBELP = rfcReturn.GetString("EBELP"),
                        EBELN = rfcReturn.GetString("EBELN"),
                        EINDT = rfcReturn.GetString("EINDT"),
                        LGORT = rfcReturn.GetString("LGORT"),
                        LIFNR = rfcReturn.GetString("LIFNR"),
                        MATNR = rfcReturn.GetString("MATNR"),
                        MSEHT = rfcReturn.GetString("MSEHT"),
                        MEINS = rfcReturn.GetString("MEINS"),
                        MENGE = Convert.ToDecimal(string.IsNullOrEmpty(rfcReturn.GetString("MENGE")) ? "0" : rfcReturn.GetString("MENGE")),
                        NAME1 = rfcReturn.GetString("NAME1"),
                        NETPR = rfcReturn.GetString("NETPR"),
                        TXZ01 = rfcReturn.GetString("TXZ01"),
                        WERKS = rfcReturn.GetString("WERKS"),
                        WERKST = rfcReturn.GetString("WERKST"),
                        ID = rfcReturn.GetString("EBELN") + rfcReturn.GetString("EBELP")
                    };
                    LogHelper.Info(string.Format("pur.BEDAT is {0},pur.EBELP is {1},pur.EBELN is {2},pur.EINDT is {3},pur.LGORT is {4},pur.LIFNR is {5},pur.MATNR is {6},pur.MSEHT is {7},pur.MEINS is {8},pur.NAME1 is {9},pur.NETPR is {10},pur.TXZ01 is {11},pur.WERKS is {12},pur.WERKST is {13},pur.ID is {14}",
                        pur.BEDAT.ToString(), pur.EBELP.ToString(),
                       pur.EBELN.ToString(), pur.EINDT.ToString(), pur.LGORT.ToString(), pur.LIFNR.ToString(), pur.MATNR.ToString(), pur.MSEHT.ToString(), pur.MEINS.ToString()
                       , pur.NAME1.ToString(), pur.NETPR.ToString(), pur.TXZ01.ToString(), pur.WERKS.ToString(), pur.WERKST.ToString(), pur.ID.ToString()));

                    list.Add(pur);
                }
                LogHelper.Info("list fill succeed ,GetPurcharseList end");
            }
            catch (Exception ex)
            {

                LogHelper.Error(ex);
            }
            finally
            {
                destination = null;
            }

            return list;
        }
        public List<BackFromSAP_SubPlan> SendSupplyPlan(string userID, List<EntityObject_SCM_D_SUPPLYPLAN> listEntitys, string Lifnr, string NAME1, string ZPSTA, string ZUPFG, string fuName = "ZMM00_FM_SCMSUPLANSEND")
        {
            var flag = System.Web.Configuration.WebConfigurationManager.AppSettings["web_switch"];//两种不同的调用方式
            if (flag != "1")
            {
                return SendSupplyPlan_RFC(userID, listEntitys, Lifnr, NAME1, ZPSTA, ZUPFG, fuName);
            }
            else
            {
                return SendSupplyPlan_Service(userID, listEntitys, Lifnr, NAME1, ZPSTA, ZUPFG, fuName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listEntitys"></param>
        /// <param name="Lifnr"></param>
        /// <param name="NAME1"></param>
        /// <param name="ZPSTA">0是新建1是确认</param>
        /// <param name="ZUPFG">C是新建U修改D删除</param>
        /// <param name="fuName"></param>
        /// <returns></returns>
        public List<BackFromSAP_SubPlan> SendSupplyPlan_RFC(string userID, List<EntityObject_SCM_D_SUPPLYPLAN> listEntitys, string Lifnr, string NAME1, string ZPSTA, string ZUPFG, string fuName = "ZMM00_FM_SCMSUPLANSEND")
        {
            LogHelper.Info("SendSupplyPlan(发送计划) begin", 1);
            var list = new List<BackFromSAP_SubPlan>();
            RfcDestination destination;
            try
            {
                destination = this.GetDestination();

                RfcRepository rfcrep = destination.Repository;
                IRfcFunction myfun = null;
                myfun = rfcrep.CreateFunction(fuName);
                //  myfun.SetValue("IS_SELCOND", "0");//SAP里面的传入参数
                if (myfun == null)
                {
                    LogHelper.Info("ZMM00_FM_SCMSUPLANSEND is NULL");
                    return list;
                }
                IRfcTable IrfTable_IT_SUPLAN = myfun.GetTable("IT_SUPLAN");
                foreach (var entity in listEntitys)
                {
                    IrfTable_IT_SUPLAN.Insert();
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZGYJH", entity.CODE);//供应计划号 对应 CODE字段
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("EBELN", entity.EBELN);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("EBELP", entity.GYJH);

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("MATNR", entity.MATNR);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("TXZ01", entity.TXZ01);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("LIFNR", entity.GYSACCOUNT);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("NAME1", entity.GYSNAME);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("WERKS", entity.WERKS);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("LGORT", entity.LGORT);

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("MENGE", entity.MENGE.ToString());
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("MEINS", entity.MEINS);

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("CHARG", entity.CHARG);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZHSDAT", entity.HSDAT == null ? "" : entity.HSDAT.Value.ToString("yyyyMMdd"));

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZVFDAT", entity.VFDAT.ToString("yyyyMMdd"));
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZFPHM", entity.FPHM);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("BARCODE", entity.FPBM);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZFPJR", entity.FPJR.ToString());
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZFPRQ", entity.FPRQ == null ? "" : entity.FPRQ.Value.ToString("yyyyMMdd"));

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZPSTA", ZPSTA);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZUPFG", ZUPFG);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZBTXT", entity.COMMENTS);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZJYR", ZPSTA == "1" ? userID : "");

                    //总务
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZLXR", entity.LINK_PERSON);//联系人
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("KOSTL", entity.SEND_DEPART);//科室编码
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZSPTM", entity.MATER_CODE);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZTEL", entity.LINK_TELEPHONE);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZSHQD", entity.SEND_ORDER_CODE);//送货清单

                    LogHelper.Info(string.Format("ZGYJH:{0},EBELN:{1},EBELP:{2},MATNR:{3},LIFNR:{4}", entity.CODE, entity.EBELN, entity.GYJH, entity.MATNR, entity.GYSACCOUNT), 1);
                }

                myfun.SetValue("IT_SUPLAN", IrfTable_IT_SUPLAN);
                //提前实例化一个空的表结构出来
                myfun.Invoke(destination);//执行

                IRfcTable rfcReturn = myfun.GetTable("OT_RETURN"); //此处返回类型为Structure 如果是Single类型 则直接调用myfun.GetString("RETURN");
                if (rfcReturn == null)
                {
                    LogHelper.Info("OT_RETURN is NULL");
                    return list;
                }
                LogHelper.Info("上传SAP，调用成功。");
                for (int i = 0; i < rfcReturn.Count; i++)
                {
                    rfcReturn.CurrentIndex = i;
                    BackFromSAP_SubPlan pur = new BackFromSAP_SubPlan
                    {
                        MESS = rfcReturn.GetString("MESS"),
                        MSTYPE = rfcReturn.GetString("MSTYP"),
                        ZGYJH = rfcReturn.GetString("ZGYJH")


                    };
                    list.Add(pur);
                }
                //try
                //{
                //    BizLogicObject_COM_LOG.Proxy.Save(new EntityObject_COM_LOG
                //    {
                //        USER_ID = userID,
                //        LOG_TIME = DateTime.Now,
                //        COMMAND = "上传供应计划接口",
                //        MESSAGE = NAME1 + "上传供应计划成功",
                //        TYPE = 3

                //    });
                //}
                //catch (Exception ex)
                //{
                //}
                LogHelper.Info("SendSupplyPlan(发送计划) END SUCCESS!", 1);
            }
            catch (Exception ex)
            {
                LogHelper.Info("SendSupplyPlan(发送计划)出现问题：" + ex.Message, 1);
                //try
                //{
                //    BizLogicObject_COM_LOG.Proxy.Save(new EntityObject_COM_LOG
                //    {
                //        USER_ID = userID,
                //        LOG_TIME = DateTime.Now,
                //        COMMAND = "上传供应计划接口",
                //        MESSAGE = NAME1 + "上传供应计划失败:" + ex.Message,
                //        TYPE = 3

                //    });
                //}
                //catch (Exception ex2)
                //{

                //}
                BackFromSAP_SubPlan pur = new BackFromSAP_SubPlan
                {
                    MESS = ex.Message,
                    MSTYPE = "H",
                    ZGYJH = ""


                };
                list.Add(pur);

            }
            finally
            {
                destination = null;
            }

            return list;
        }

        public List<BackFromSAP_SubPlan> SendSupplyPlan_Service(string userID, List<EntityObject_SCM_D_SUPPLYPLAN> listEntitys, string Lifnr, string NAME1, string ZPSTA, string ZUPFG, string fuName = "ZMM00_FM_SCMSUPLANSEND")
        {
            LogHelper.Info("SendSupplyPlan(发送计划) begin");
            var list = new List<BackFromSAP_SubPlan>();

            try
            {
                System.Net.NetworkCredential c = new System.Net.NetworkCredential(System.Web.Configuration.WebConfigurationManager.AppSettings["Sap_User"], System.Web.Configuration.WebConfigurationManager.AppSettings["Sap_Password"]);
                ServiceFromSAP.service client = new ServiceFromSAP.service();
                client.Credentials = c;

                List<ServiceFromSAP.Zmm00S020> listZmm = new List<ServiceFromSAP.Zmm00S020>();
                var count = listEntitys.Count;
                ServiceFromSAP.Zmm00S022[] arrZmm = new ServiceFromSAP.Zmm00S022[count];
                foreach (var item in listEntitys)
                {
                    listZmm.Add(new ServiceFromSAP.Zmm00S020
                    {
                        #region 数据配对
                        Barcode = item.FPBM,
                        Charg = item.CHARG,
                        Ebeln = item.EBELN,
                        Ebelp = item.GYJH,
                        Lgort = item.LGORT,
                        Lifnr = Lifnr,
                        Matnr = item.MATNR,
                        Meins = item.MEINS,
                        Menge = item.MENGE.ToString(),
                        Mseht = item.MSEHT,
                        Name1 = NAME1,
                        Txz01 = item.TXZ01,
                        Werks = item.WERKS,
                        Zfphm = item.FPHM,
                        Zfpjr = item.FPJR.ToString(),
                        Zfprq = item.FPRQ == null ? "" : item.FPRQ.Value.ToString("yyyy-MM-dd"),
                        Zgyjh = item.CODE,
                        Zhsdat = item.HSDAT == null ? "" : item.HSDAT.Value.ToString("yyyy-MM-dd"),
                        Zpsta = ZPSTA,
                        Zupfg = ZUPFG,
                        Zvfdat = item.VFDAT.ToString("yyyy-MM-dd"),
                        Zbtxt = item.COMMENTS
                        #endregion
                    });

                }
                var response = client.Zmm00FmScmsuplansend(new ServiceFromSAP.Zmm00FmScmsuplansend
                  {
                      ItSuplan = listZmm.ToArray(),
                      OtReturn = arrZmm
                  });
                foreach (var backInfo in response.OtReturn)
                {
                    list.Add(new BackFromSAP_SubPlan
                    {
                        MESS = backInfo.Mess,
                        MSTYPE = backInfo.Mstyp,
                        ZGYJH = backInfo.Zgyjh
                    });
                }
            }
            catch (Exception ex)
            {
                BackFromSAP_SubPlan pur = new BackFromSAP_SubPlan
                {
                    MESS = ex.Message,
                    MSTYPE = "H",
                    ZGYJH = ""


                };
                list.Add(pur);
            }
            finally
            {

            }

            return list;
        }

        public void SendUploadInfo_RFC(string GysName, string matnr, string charge, string serverName, string I_Type, string fuName = "ZMM00_FM_SCM003")
        {
            LogHelper.Info("SendUploadInfo_RFC(发送附件信息) begin", 1);
            var list = new List<BackFromSAP_SubPlan>();
            RfcDestination destination;
            try
            {
                destination = this.GetDestination();

                RfcRepository rfcrep = destination.Repository;
       
         IRfcFunction myfun = null;
                myfun = rfcrep.CreateFunction(fuName);
                //  myfun.SetValue("IS_SELCOND", "0");//SAP里面的传入参数
                if (myfun == null)
                {
                    LogHelper.Info("ZMM00_FM_SCM003 is NULL");
                }


                myfun.SetValue("I_OBJECT", GysName.Trim() + matnr.Trim() + charge.Trim());
                myfun.SetValue("I_FILENAME", serverName);
                myfun.SetValue("I_MODE", I_Type);
                //提前实例化一个空的表结构出来
                myfun.Invoke(destination);//执行


                LogHelper.Info("上传文件，调用成功。");

                LogHelper.Info("SendUploadInfo_RFC(发送附件信息) END SUCCESS!", 1);
            }
            catch (Exception ex)
            {
                LogHelper.Info("SendUploadInfo_RFC(发送附件信息)出现问题：" + ex.Message, 1);
            }
            finally
            {
                destination = null;
            }


        }

        public void SendVendorInfo_RFC(string LIFNR,string tel,string NACHN,string NAME1,string fuName = "ZMM00_FM_DHHM")
        {
            LogHelper.Info("ZMM00_FM_DHHM(发送供应商信息) begin", 1);
            RfcDestination destination;
            try
            {
                destination = this.GetDestination();

                RfcRepository rfcrep = destination.Repository;

                IRfcFunction myfun = null;
                myfun = rfcrep.CreateFunction(fuName);
                //  myfun.SetValue("IS_SELCOND", "0");//SAP里面的传入参数
                if (myfun == null)
                {
                    LogHelper.Info("ZMM00_FM_DHHM is NULL");
                }


                myfun.SetValue("LIFNR", LIFNR);
                myfun.SetValue("tel", tel);
                myfun.SetValue("NACHN", NACHN);
                myfun.SetValue("NAME1", NAME1);
                //提前实例化一个空的表结构出来
                myfun.Invoke(destination);//执行


                LogHelper.Info("发送供应商信息 。");

                LogHelper.Info("ZMM00_FM_DHHM(发送供应商信息) END SUCCESS!", 1);
            }
            catch (Exception ex)
            {
                LogHelper.Info("ZMM00_FM_DHHM(发送供应商信息)出现问题：" + ex.Message, 1);
            }
            finally
            {
                destination = null;
            }
        }
    }
}