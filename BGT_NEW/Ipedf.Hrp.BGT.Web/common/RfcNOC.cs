using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SAP.Middleware.Connector;
using System.Data;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;

namespace Ipedf.Hrp.Web.common
{
    public class RfcNOC
    {
        /// <summary>
        /// 连接字符串 连接SAP 暂未使用
        /// </summary>
        /// <returns></returns>
        private RfcConfigParameters GetConfigParams()
        {

            RfcConfigParameters configParams = new RfcConfigParameters();


            // Name property is neccessary, otherwise, NonInvalidParameterException will be thrown

            configParams.Add(RfcConfigParameters.Name, "ECC");

            configParams.Add(RfcConfigParameters.AppServerHost, "192.168.64.29:3600");
            //configParams.Add(RfcConfigParameters.AppServerHost, "192.168.64.26:3600");
            //configParams.Add(RfcConfigParameters.MessageServerHost, "192.168.64.26");
            //configParams.Add(RfcConfigParameters.LogonGroup, "P01");

            configParams.Add(RfcConfigParameters.SystemNumber, "01"); // instance number

            configParams.Add(RfcConfigParameters.SystemID, "D01");


            configParams.Add(RfcConfigParameters.User, "COM_SCM");

            configParams.Add(RfcConfigParameters.Password, "822019");

            configParams.Add(RfcConfigParameters.Client, "300");

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
        /// 经费从编制区进入执行区
        /// </summary>
        /// <param name="listEntitys"></param>
        /// <param name="budget_year"></param>
        /// <param name="bussType"></param>
        /// <param name="orderType"></param>
        /// <param name="fuName"></param>
        /// <returns></returns>
        public List<BackFromSap> SendSAPFund_RFC(List<DisplayObject_BGT_B_DEPT_PAY_YEAR_FUND> listEntitys, string budget_year, string bussType, string orderType, string fuName)
        {
            LogHelper.Info("SendSAPFund_RFC(发送预算经费) begin", 1);
            var list = new List<BackFromSap>();
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
                    LogHelper.Info("ZFI02_FM_YS001 is NULL");
                    return list;
                }
                IRfcTable IrfTable_IT_SUPLAN = myfun.GetTable("CT_DATA");
                foreach (var entity in listEntitys)
                {
                    if (string.IsNullOrEmpty(entity.CODE)) continue;
                    IrfTable_IT_SUPLAN.Insert();
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("GJAHR", budget_year);//供应计划号 对应 CODE字段
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZJFID", entity.CODE);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZJFYSE", entity.CONTROL_MONEY1.ToString());//控制经费金额

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZFI_JFYWLX", bussType);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("YSBMMC", entity.BUDGET_DEPT_ID_NAME);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("YSJFMC", entity.BGT_D_BUDGET_ITEM_ID_NAME);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER0", entity.DEPT_USER_ID);//负责人
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER1", "");//经费来源
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER2", "");//备注
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER3", "");//国际编码

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER5", "");//申请日期 8位

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER7", "");//工作开始
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER8", "");//工作结束

                    LogHelper.Info(string.Format("GJAHR:{0},ZGFID:{1},ZGFYSE:{2},ZFI_JFYWLX:{3},YSBMMC:{4},YSJFMC:{5}", budget_year, entity.CODE, entity.FUND_MONEY.ToString(), bussType, entity.BUDGET_DEPT_ID_NAME, entity.BGT_D_BUDGET_ITEM_ID_NAME));
                }

                myfun.SetValue("CT_DATA", IrfTable_IT_SUPLAN);
                //提前实例化一个空的表结构出来
                myfun.Invoke(destination);//执行

                IRfcTable rfcReturn = myfun.GetTable("CT_DATA"); //此处返回类型为Structure 如果是Single类型 则直接调用myfun.GetString("RETURN");
                if (rfcReturn == null)
                {
                    LogHelper.Info("CT_DATA is NULL");
                    return list;
                }
                LogHelper.Info("上传SAP，调用成功。");
                for (int i = 0; i < rfcReturn.Count; i++)
                {
                    rfcReturn.CurrentIndex = i;
                    BackFromSap pur = new BackFromSap
                    {
                        Mess = rfcReturn.GetString("MSGTY"),
                        IsSuccess = rfcReturn.GetString("MSGTX") == "E" ? false : true
                    };
                    list.Add(pur);
                }

                LogHelper.Info("SendSAPFund_RFC(发送经费) END SUCCESS!", 1);
            }
            catch (Exception ex)
            {
                LogHelper.Info("SendSAPFund_RFC(发送经费)出现问题：" + ex.Message, 1);

                BackFromSap pur = new BackFromSap
                {
                    Mess = ex.Message,
                    IsSuccess = false


                };
                list.Add(pur);

            }
            finally
            {
                destination = null;
            }

            return list;
        }

        /// <summary>
        /// 经费金额变更 发送SAP
        /// </summary>
        /// <param name="listEntitys"></param>
        /// <param name="budget_year"></param>
        /// <param name="bussType"></param>
        /// <param name="orderType"></param>
        /// <param name="fuName"></param>
        /// <returns></returns>
        public List<BackFromSap> SendSAPUpdateFund_RFC(List<DisplayObject_V_BGT_ADJUST_TO_SAP> listEntitys, string bussType, string orderType, string fuName)
        {
            LogHelper.Info("SendSAPUpdateFund_RFC(发送预算经费变更) begin", 1);
            var list = new List<BackFromSap>();
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
                    LogHelper.Info("ZFI02_FM_YS001 is NULL");
                    return list;
                }
                IRfcTable IrfTable_IT_SUPLAN = myfun.GetTable("CT_DATA");
                foreach (var entity in listEntitys)
                {
                    if (string.IsNullOrEmpty(entity.FUND_CODE)) continue;
                    IrfTable_IT_SUPLAN.Insert();
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("GJAHR", entity.BUDGET_YEAR);//供应计划号 对应 CODE字段
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZJFID", entity.FUND_CODE);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZJFYSE", entity.CHANGE_MONEY.ToString());//控制经费金额变更后金额

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZFI_JFYWLX", bussType);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("YSBMMC", entity.BUDGET_DEPT_ID_NAME);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("YSJFMC", entity.BGT_D_BUDGET_ITEM_ID_NAME);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER0", entity.USERNAME);//负责人
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER1", "");//经费来源
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER2", "");//备注
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER3", "");//国际编码

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER5", DateTime.Now.ToString("yyyyMMdd"));//申请日期 8位

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER7", "");//工作开始
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER8", "");//工作结束

                    LogHelper.Info(string.Format("GJAHR:{0},ZGFID:{1},ZGFYSE:{2},ZFI_JFYWLX:{3},YSBMMC:{4},YSJFMC:{5}", entity.BUDGET_YEAR, entity.FUND_CODE, entity.CHANGE_MONEY.ToString(), bussType, entity.BUDGET_DEPT_ID_NAME, entity.BGT_D_BUDGET_ITEM_ID_NAME));
                }

                myfun.SetValue("CT_DATA", IrfTable_IT_SUPLAN);
                //提前实例化一个空的表结构出来
                myfun.Invoke(destination);//执行

                IRfcTable rfcReturn = myfun.GetTable("CT_DATA"); //此处返回类型为Structure 如果是Single类型 则直接调用myfun.GetString("RETURN");
                if (rfcReturn == null)
                {
                    LogHelper.Info("CT_DATA is NULL");
                    return list;
                }
                LogHelper.Info("上传SAP，调用成功。");
                for (int i = 0; i < rfcReturn.Count; i++)
                {
                    rfcReturn.CurrentIndex = i;
                    BackFromSap pur = new BackFromSap
                    {
                        Mess = rfcReturn.GetString("MSGTY"),
                        IsSuccess = rfcReturn.GetString("MSGTX") == "E" ? false : true
                    };
                    list.Add(pur);
                }

                LogHelper.Info("SendSAPUpdateFund_RFC(发送经费变更) END SUCCESS!", 1);
            }
            catch (Exception ex)
            {
                LogHelper.Info("SendSAPUpdateFund_RFC(发送经费变更)出现问题：" + ex.Message, 1);

                BackFromSap pur = new BackFromSap
                {
                    Mess = ex.Message,
                    IsSuccess = false


                };
                list.Add(pur);

            }
            finally
            {
                destination = null;
            }

            return list;
        }

        public List<BackFromSap> SendSAP_NewAdd_Fund_RFC(List<DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE> listEntitys, string budget_year, string bussType, string orderType, string fuName)
        {
            LogHelper.Info("SendSAPFund_RFC(发送预算经费) begin", 1);
            var list = new List<BackFromSap>();
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
                    LogHelper.Info("ZFI02_FM_YS001 is NULL");
                    return list;
                }
                IRfcTable IrfTable_IT_SUPLAN = myfun.GetTable("CT_DATA");
                foreach (var entity in listEntitys)
                {
                    if (string.IsNullOrEmpty(entity.CODE)) continue;
                    IrfTable_IT_SUPLAN.Insert();
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("GJAHR", budget_year);//供应计划号 对应 CODE字段
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZJFID", entity.CODE);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZJFYSE", entity.FUND_MONEY.ToString());//控制经费金额

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZFI_JFYWLX", bussType);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("YSBMMC", entity.BUDGET_DEPT_ID_NAME);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("YSJFMC", entity.BGT_D_BUDGET_ITEM_ID_NAME);
                    string UserName = string.IsNullOrEmpty(entity.DEPT_USER_ID) ? string.Empty : BizLogicObject_COM_USER.Proxy.Get(new EntityObject_COM_USER() { ID = entity.DEPT_USER_ID }).NAME;
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER0", UserName);//负责人
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER1", "");//经费来源
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER2", "");//备注
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER3", "");//国际编码

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER5", "");//申请日期 8位

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER7", "");//工作开始
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER8", "");//工作结束

                    LogHelper.Info(string.Format("GJAHR:{0},ZGFID:{1},ZGFYSE:{2},ZFI_JFYWLX:{3},YSBMMC:{4},YSJFMC:{5}", budget_year, entity.CODE, entity.FUND_MONEY.ToString(), bussType, entity.BUDGET_DEPT_ID_NAME, entity.BGT_D_BUDGET_ITEM_ID_NAME));
                }

                myfun.SetValue("CT_DATA", IrfTable_IT_SUPLAN);
                //提前实例化一个空的表结构出来
                myfun.Invoke(destination);//执行

                IRfcTable rfcReturn = myfun.GetTable("CT_DATA"); //此处返回类型为Structure 如果是Single类型 则直接调用myfun.GetString("RETURN");
                if (rfcReturn == null)
                {
                    LogHelper.Info("CT_DATA is NULL");
                    return list;
                }
                LogHelper.Info("上传SAP，调用成功。");
                for (int i = 0; i < rfcReturn.Count; i++)
                {
                    rfcReturn.CurrentIndex = i;
                    BackFromSap pur = new BackFromSap
                    {
                        Mess = rfcReturn.GetString("MSGTY"),
                        IsSuccess = rfcReturn.GetString("MSGTX") == "E" ? false : true
                    };
                    list.Add(pur);
                }

                LogHelper.Info("SendSAPFund_RFC(发送经费) END SUCCESS!", 1);
            }
            catch (Exception ex)
            {
                LogHelper.Info("SendSAPFund_RFC(发送经费)出现问题：" + ex.Message, 1);

                BackFromSap pur = new BackFromSap
                {
                    Mess = ex.Message,
                    IsSuccess = false


                };
                list.Add(pur);

            }
            finally
            {
                destination = null;
            }

            return list;
        }
        /// <summary>
        /// 人员经费
        /// </summary>
        /// <param name="listEntitys"></param>
        /// <param name="budget_year"></param>
        /// <param name="bussType"></param>
        /// <param name="orderType"></param>
        /// <param name="fuName"></param>
        /// <returns></returns>
        public List<BackFromSap> SendSAPPersonFund_RFC(List<DisplayObject_V_BGT_B_CPN_INC_PERSONFUND> listEntitys, string budget_year, string bussType, string orderType, string fuName)
        {
            LogHelper.Info("SendSAPFund_RFC(发送预算经费) begin", 1);
            var list = new List<BackFromSap>();
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
                    LogHelper.Info("ZFI02_FM_YS001 is NULL");
                    return list;
                }
                IRfcTable IrfTable_IT_SUPLAN = myfun.GetTable("CT_DATA");
                foreach (var entity in listEntitys)
                {
                    if (string.IsNullOrEmpty(entity.CODE)) continue;
                    IrfTable_IT_SUPLAN.Insert();
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("GJAHR", budget_year);//供应计划号 对应 CODE字段
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZJFID", entity.CODE);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZJFYSE", entity.MONEY.ToString());

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZFI_JFYWLX", bussType);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("YSBMMC", entity.DEPT_NAME);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("YSJFMC", entity.NAME);
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER0", entity.ADDRESS);//负责人
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER1", "");//经费来源
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER2", "");//备注
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER3", "");//国际编码

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER5", "");//申请日期 8位

                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER7", "");//工作开始
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("USER8", "");//工作结束

                    LogHelper.Info(string.Format("GJAHR:{0},ZGFID:{1},ZGFYSE:{2},ZFI_JFYWLX:{3},YSBMMC:{4},YSJFMC:{5}", budget_year, entity.CODE, entity.MONEY.ToString(), bussType, entity.DEPT_NAME, entity.NAME));
                }

                myfun.SetValue("CT_DATA", IrfTable_IT_SUPLAN);
                //提前实例化一个空的表结构出来
                myfun.Invoke(destination);//执行

                IRfcTable rfcReturn = myfun.GetTable("CT_DATA"); //此处返回类型为Structure 如果是Single类型 则直接调用myfun.GetString("RETURN");
                if (rfcReturn == null)
                {
                    LogHelper.Info("CT_DATA is NULL");
                    return list;
                }
                LogHelper.Info("上传SAP，调用成功。");
                for (int i = 0; i < rfcReturn.Count; i++)
                {
                    rfcReturn.CurrentIndex = i;
                    BackFromSap pur = new BackFromSap
                    {
                        Mess = rfcReturn.GetString("MSGTY"),
                        IsSuccess = rfcReturn.GetString("MSGTX") == "E" ? false : true
                    };
                    list.Add(pur);
                }

                LogHelper.Info("SendSAPFund_RFC(发送经费) END SUCCESS!", 1);
            }
            catch (Exception ex)
            {
                LogHelper.Info("SendSAPFund_RFC(发送经费)出现问题：" + ex.Message, 1);

                BackFromSap pur = new BackFromSap
                {
                    Mess = ex.Message,
                    IsSuccess = false


                };
                list.Add(pur);

            }
            finally
            {
                destination = null;
            }

            return list;
        }
        /// <summary>
        /// 获取此经费代码 已经支出金额
        /// </summary>
        /// <param name="budgetYear"></param>
        /// <param name="codes"></param>
        /// <returns></returns>
        public List<FundMoneyAndCode> GetFundLeft(string budgetYear, List<string> codes)
        {
            LogHelper.Info("GetFundLeft(获取经费余额) begin", 1);
            var list = new List<FundMoneyAndCode>();
            RfcDestination destination;
            try
            {
                destination = this.GetDestination();

                RfcRepository rfcrep = destination.Repository;
                IRfcFunction myfun = null;
                myfun = rfcrep.CreateFunction("RFC: ZFI02_FM_YS002");
                //  myfun.SetValue("IS_SELCOND", "0");//SAP里面的传入参数
                if (myfun == null)
                {
                    LogHelper.Info("RFC: ZFI02_FM_YS002 is NULL");
                    return list;
                }
                IRfcTable IrfTable_IT_SUPLAN = myfun.GetTable("CT_DATA");
                foreach (var code in codes)
                {
                    IrfTable_IT_SUPLAN.Insert();
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("ZJFID", code);//供应计划号 对应 CODE字段


                    LogHelper.Info(string.Format("ZJFID:{0}", code));
                }

                myfun.SetValue("CT_DATA", IrfTable_IT_SUPLAN);
                //提前实例化一个空的表结构出来
                myfun.Invoke(destination);//执行

                IRfcTable rfcReturn = myfun.GetTable("CT_DATA"); //此处返回类型为Structure 如果是Single类型 则直接调用myfun.GetString("RETURN");
                if (rfcReturn == null)
                {
                    LogHelper.Info("CT_DATA is NULL");
                    return list;
                }
                LogHelper.Info("上传SAP，调用成功。");
                for (int i = 0; i < rfcReturn.Count; i++)
                {
                    rfcReturn.CurrentIndex = i;
                    var fundMoney = 0m;
                    if (!string.IsNullOrEmpty(rfcReturn.GetString("DMBTR")))
                    {
                        fundMoney = Convert.ToDecimal(rfcReturn.GetString("DMBTR"));
                    }
                    FundMoneyAndCode pur = new FundMoneyAndCode
                    {
                        Code = rfcReturn.GetString("ZJFID"),
                        FundMoney = fundMoney
                    };
                    list.Add(pur);
                }

                LogHelper.Info("GetFundLeft(获取经费) END SUCCESS!", 1);
            }
            catch (Exception ex)
            {
                LogHelper.Info("GetFundLeft(回去经费)出现问题：" + ex.Message, 1);

                //FundMoneyAndCode pur = new FundMoneyAndCode
                //{
                //    FundMoney = 0,
                //    Code = ""


                //};
                //list.Add(pur);

            }
            finally
            {
                destination = null;
            }

            return list;
        }
        /// <summary>
        /// 获取预算执行情况
        /// </summary>
        /// <param name="budgetYear"></param>
        /// <param name="ZFI02_S_YSBM"></param>
        /// <returns></returns>
        public DataTable GetZFI02_FM_IF_BMYS(string budgetYear, List<ZFI02_S_YSBM> ZFI02_S_YSBM,string BegDate,string EndDate)
        {
            LogHelper.Info("GetZFI02_FM_IF_BMYS(获取预算执行情况) begin", 1);
            DataTable list = new DataTable();
            RfcDestination destination;
            try
            {
                destination = this.GetDestination();

                RfcRepository rfcrep = destination.Repository;
                IRfcFunction myfun = null;
                myfun = rfcrep.CreateFunction("ZFI02_FM_IF_BMYS");
                //  myfun.SetValue("IS_SELCOND", "0");//SAP里面的传入参数
                if (myfun == null)
                {
                    LogHelper.Info("ZFI02_FM_IF_BMYS is NULL");
                    return list;
                }
                IRfcTable IrfTable_IT_SUPLAN = myfun.GetTable("IT_YSBM");
                foreach (var code in ZFI02_S_YSBM)
                {
                    IrfTable_IT_SUPLAN.Insert();
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("YSBM", code.YSBM);//供应计划号 对应 CODE字段


                    LogHelper.Info(string.Format("YSBM:{0}", code.YSBM));
                }
                //myfun.SetValue("IV_GJAHR", budgetYear);
                string BEG= "";
                string END = "";
                if (!string.IsNullOrEmpty(BegDate))
                {
                    BEG = BegDate;
                }
                else
                {
                    BEG = budgetYear + "0101";
                }
                if (!string.IsNullOrEmpty(EndDate))
                {
                    END = EndDate;
                }
                else
                {
                    END = budgetYear + "1231";
                }
                myfun.SetValue("IV_BEGDA", BEG);
                myfun.SetValue("IV_ENDDA", END);
                myfun.SetValue("IT_YSBM", IrfTable_IT_SUPLAN);
                //提前实例化一个空的表结构出来
                myfun.Invoke(destination);//执行

                IRfcTable rfcReturn = myfun.GetTable("OT_BMHZ"); //此处返回类型为Structure 如果是Single类型 则直接调用myfun.GetString("RETURN");
                list = GetDataTable(rfcReturn);

                LogHelper.Info("GetZFI02_FM_IF_BMYS(获取预算执行情况) END SUCCESS!", 1);
            }
            catch (Exception ex)
            {
                LogHelper.Info("GetZFI02_FM_IF_BMYS(获取预算执行情况)出现问题：" + ex.Message, 1);

                //FundMoneyAndCode pur = new FundMoneyAndCode
                //{
                //    FundMoney = 0,
                //    Code = ""


                //};
                //list.Add(pur);

            }
            finally
            {
                destination = null;
            }

            return list;
        }

        public DataTable GetZFI02_FM_IF_JFSZJY(string BEG,string END, DisplayObject_V_BGT_D_BUDGET_ITEM[] bdb)
        {
            LogHelper.Info("GetZFI02_FM_IF_JFSZJY(获取经费收支结余表) begin", 1);
            DataTable list = new DataTable();
            RfcDestination destination;
            try
            {
                destination = this.GetDestination();

                RfcRepository rfcrep = destination.Repository;
                IRfcFunction myfun = null;
                myfun = rfcrep.CreateFunction("ZFI02_FM_IF_JFSZJY");
                //  myfun.SetValue("IS_SELCOND", "0");//SAP里面的传入参数
                if (myfun == null)
                {
                    LogHelper.Info("ZFI02_FM_IF_JFSZJY is NULL");
                    return list;
                }
                IRfcTable IrfTable_IT_SUPLAN = myfun.GetTable("IT_JFDM");
                foreach (var code in bdb)
                {
                    IrfTable_IT_SUPLAN.Insert();
                    IrfTable_IT_SUPLAN.CurrentRow.SetValue("AUFEX", code.CODE);//供应计划号 对应 CODE字段


                    LogHelper.Info(string.Format("AUFEX:{0}", code.CODE));
                }
                myfun.SetValue("IV_BEGDA", BEG);
                myfun.SetValue("IV_ENDDA", END);
                myfun.SetValue("IT_JFDM", IrfTable_IT_SUPLAN);
                //提前实例化一个空的表结构出来
                myfun.Invoke(destination);//执行

                IRfcTable rfcReturn = myfun.GetTable("OT_JFSZJY"); //此处返回类型为Structure 如果是Single类型 则直接调用myfun.GetString("RETURN");
                list = GetDataTable(rfcReturn);

                LogHelper.Info("GetZFI02_FM_IF_JFSZJY(获取预算执行情况) END SUCCESS!", 1);
            }
            catch (Exception ex)
            {
                LogHelper.Info("GetZFI02_FM_IF_JFSZJY(获取经费收支结余表)出现问题：" + ex.Message, 1);

                //FundMoneyAndCode pur = new FundMoneyAndCode
                //{
                //    FundMoney = 0,
                //    Code = ""


                //};
                //list.Add(pur);

            }
            finally
            {
                destination = null;
            }

            return list;
        }

        /// <summary>
        /// 获取ADO.NET DataTable
        /// </summary>
        /// <param name="IrfTable">IrfTable</param>
        /// <returns>ADO.NET DataTable</returns>
        public static DataTable GetDataTable(IRfcTable IrfTable)
        {
            DataTable dt = new DataTable("AUFK");

            //遍历元素个数，循环添加列
            for (int i = 0; i < IrfTable.ElementCount; i++)
            {
                string columnName = IrfTable.GetElementMetadata(i).Name;
                dt.Columns.Add(columnName);
            }

            ////循环把IRfcTable里面的数据放入Table里面，因为类型不同，不可直接使用。

            for (int m = 0; m < IrfTable.RowCount; m++)
            {
                IrfTable.CurrentIndex = m;
                DataRow dr = dt.NewRow();

                for (int n = 0; n < IrfTable.CurrentRow.Metadata.FieldCount; n++)
                {
                    string colName = IrfTable.GetElementMetadata(n).Name;
                    dr[colName] = IrfTable.CurrentRow.GetString(colName);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}