
using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Web.ServiceContract;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
using Ipedf.Wcf.ClientProxy;
using Ipedf.Common;
using System.Collections.Generic;
using System.Text;
namespace Ipedf.Web.BizLogic
{

	public partial class BizLogicObject_BGT_D_BUDGET_ITEM
	{
        public BizLogicMsg AppendByAccountItem(string parentId, string[] account)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {

                        try
                        {
                            //加载父项
                            EntityObject_BGT_D_BUDGET_ITEM parentItem = new EntityObject_BGT_D_BUDGET_ITEM();
                            parentItem.ID = parentId;
                            parentItem = HelperObject_BGT_D_BUDGET_ITEM.Get(parentItem, transaction);
                            //加载会计科目集合
                            CauseObject_BGT_D_ACCOUNT_ITEM pAccount = new CauseObject_BGT_D_ACCOUNT_ITEM();
                            foreach (string item in account)
                            {
                                pAccount.SetINValue("ID", item);
                            }
                            //创建预算科目集合
                            DisplayObject_BGT_D_ACCOUNT_ITEM[] items = HelperObject_BGT_D_ACCOUNT_ITEM.Query(pAccount, transaction);
                            foreach (DisplayObject_BGT_D_ACCOUNT_ITEM item in items)
                            {
                                EntityObject_BGT_D_BUDGET_ITEM newBudget = new EntityObject_BGT_D_BUDGET_ITEM();
                                newBudget.PARENT_ID = parentItem.ID;
                                newBudget.BUDGET_YEAR = parentItem.BUDGET_YEAR;
                                newBudget.IMPORT_TYPE_ID = parentItem.IMPORT_TYPE_ID;
                                newBudget.DATA_TYPE_ID = parentItem.DATA_TYPE_ID;
                                newBudget.ITEM_TYPE_ID = parentItem.ITEM_TYPE_ID;
                                newBudget.PREPARE_PATTERN_ID = parentItem.PREPARE_PATTERN_ID;
                                newBudget.USAGE_ID = parentItem.USAGE_ID;
                                newBudget.IS_CARRYOVER = (decimal)是否状态.否;
                                newBudget.IS_END = (decimal)是否状态.否;
                                newBudget.IS_MERGE = (decimal)是否状态.否;
                                newBudget.CODE = item.CODE;
                                newBudget.NAME = item.NAME;
                                HelperObject_BGT_D_BUDGET_ITEM.Save(newBudget, transaction);
                            }
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.AppendByAccountItem(parentId, account);
                }
            }
        }
        public List<string> CheckImportService(DataTable data)
        {
            if (LocalMode)
            {
                List<string> colMsg = null;
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            colMsg = CheckImportImpl(data, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            colMsg = new List<string>();
                            colMsg.Add("Failed");
                            throw new Exception("读取数据失败, 请检查重试.");
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return colMsg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.CheckImportService(data);
                }
            }
        }
        public BizLogicMsg ImportDataService(string budgetYear, string parentID, DataTable data)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {

                        try
                        {
                            ImportDataImpl(budgetYear, parentID, data, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_ITEM> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_ITEM>(ServiceUri))
                {
                    return smgr.Service.ImportDataService(budgetYear, parentID, data);
                }
            }
        }
        private List<string> CheckImportImpl(DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据保存结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量

            Dictionary<string, decimal> dicIsInfo = new Dictionary<string, decimal>();         //用于保存是否相关参考信息
            Dictionary<string, string> dicItemType = new Dictionary<string, string>();         //用于保存科目类别
            Dictionary<string, string> dicImpType = new Dictionary<string, string>();          //用于保存编制方式
            Dictionary<string, string> dicDataType = new Dictionary<string, string>();         //用于保存数据类型
            Dictionary<string, string> dicUsage = new Dictionary<string, string>();            //用于保存适用范围
            Dictionary<string, string> dicPrePattern = new Dictionary<string, string>();       //用于保存编制模式

            dicIsInfo.Add("是", (decimal)Ipedf.Common.是否状态.是);
            dicIsInfo.Add("否", (decimal)Ipedf.Common.是否状态.否);

            CauseObject_COM_TYPE pItemType = new CauseObject_COM_TYPE();
            pItemType.PARENT_ID = "0018";
            EntityObject_COM_TYPE[] itemTypes = HelperObject_COM_TYPE.Query(pItemType, transaction);
            foreach (EntityObject_COM_TYPE itemType in itemTypes)
            {
                dicItemType.Add(itemType.NAME, itemType.ID);
            }
            CauseObject_COM_TYPE pImpType = new CauseObject_COM_TYPE();
            pImpType.PARENT_ID = "0019";
            EntityObject_COM_TYPE[] impTypes = HelperObject_COM_TYPE.Query(pImpType, transaction);
            foreach (EntityObject_COM_TYPE impType in impTypes)
            {
                dicImpType.Add(impType.NAME, impType.ID);
            }
            CauseObject_COM_TYPE pdataType = new CauseObject_COM_TYPE();
            pdataType.PARENT_ID = "0021";
            EntityObject_COM_TYPE[] dataTypes = HelperObject_COM_TYPE.Query(pdataType, transaction);
            foreach (EntityObject_COM_TYPE dataType in dataTypes)
            {
                dicDataType.Add(dataType.NAME, dataType.ID);
            }
            CauseObject_COM_TYPE pUsage = new CauseObject_COM_TYPE();
            pUsage.PARENT_ID = "0020";
            EntityObject_COM_TYPE[] usages = HelperObject_COM_TYPE.Query(pUsage, transaction);
            foreach (EntityObject_COM_TYPE usage in usages)
            {
                dicUsage.Add(usage.NAME, usage.ID);
            }
            CauseObject_COM_TYPE pPrePattern = new CauseObject_COM_TYPE();
            pPrePattern.PARENT_ID = "0017";
            EntityObject_COM_TYPE[] prePatterns = HelperObject_COM_TYPE.Query(pPrePattern, transaction);
            foreach (EntityObject_COM_TYPE prePattern in prePatterns)
            {
                dicPrePattern.Add(prePattern.NAME, prePattern.ID);
            }

            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第三列数据 科室科目类别
                if (dataRow[2] == null || string.IsNullOrEmpty(dataRow[2].ToString().Trim()))
                {
                    errNum++;
                    strResult.Append("科目类别未填写 ");
                }
                else
                {
                    string itemName = dataRow[2].ToString().Trim();
                    if (!dicItemType.ContainsKey(itemName))
                    {
                        errNum++;
                        strResult.Append("科目类别不存在 ");
                    }
                }
                //检测第四列数据 编制方式
                if (dataRow[3] == null || string.IsNullOrEmpty(dataRow[3].ToString().Trim()))
                {
                    errNum++;
                    strResult.Append("编制方式未填写 ");
                }
                else
                {
                    string itemName = dataRow[3].ToString().Trim();
                    if (!dicImpType.ContainsKey(itemName))
                    {
                        errNum++;
                        strResult.Append("编制方式不存在 ");
                    }
                }
                //检测第五列数据 数据类型
                if (dataRow[4] == null || string.IsNullOrEmpty(dataRow[4].ToString().Trim()))
                {
                    errNum++;
                    strResult.Append("数据类型未填写 ");
                }
                else
                {
                    string itemName = dataRow[4].ToString().Trim();
                    if (!dicDataType.ContainsKey(itemName))
                    {
                        errNum++;
                        strResult.Append("数据类型不存在 ");
                    }
                }
                //检测第六列数据 适用范围
                if (dataRow[5] == null || string.IsNullOrEmpty(dataRow[5].ToString().Trim()))
                {
                    errNum++;
                    strResult.Append("适用范围未填写 ");
                }
                else
                {
                    string itemName = dataRow[5].ToString().Trim();
                    if (!dicUsage.ContainsKey(itemName))
                    {
                        errNum++;
                        strResult.Append("适用范围不存在 ");
                    }
                }
                //检测第七列数据 编制模式
                if (dataRow[6] == null || string.IsNullOrEmpty(dataRow[6].ToString().Trim()))
                {
                    errNum++;
                    strResult.Append("编制模式未填写 ");
                }
                else
                {
                    string itemName = dataRow[6].ToString().Trim();
                    if (!dicPrePattern.ContainsKey(itemName))
                    {
                        errNum++;
                        strResult.Append("编制模式不存在 ");
                    }
                }
                //检测第八列数据 是否结转
                if (dataRow[7] == null || string.IsNullOrEmpty(dataRow[7].ToString().Trim()))
                {
                    errNum++;
                    strResult.Append("是否结转未填写 ");
                }
                else
                {
                    string itemName = dataRow[7].ToString().Trim();
                    if (!dicIsInfo.ContainsKey(itemName))
                    {
                        errNum++;
                        strResult.Append("是否结转填写有误 ");
                    }
                }
                //检测第九列数据 是否合并科目
                if (dataRow[8] == null || string.IsNullOrEmpty(dataRow[8].ToString().Trim()))
                {
                    errNum++;
                    strResult.Append("是否合并科目未填写 ");
                }
                else
                {
                    string itemName = dataRow[8].ToString().Trim();
                    if (!dicIsInfo.ContainsKey(itemName))
                    {
                        errNum++;
                        strResult.Append("是否合并科目填写有误 ");
                    }
                }
                //检测第十列数据 是否末级
                if (dataRow[9] == null || string.IsNullOrEmpty(dataRow[9].ToString().Trim()))
                {
                    errNum++;
                    strResult.Append("是否末级未填写 ");
                }
                else
                {
                    string itemName = dataRow[9].ToString().Trim();
                    if (!dicIsInfo.ContainsKey(itemName))
                    {
                        errNum++;
                        strResult.Append("是否末级填写有误 ");
                    }
                }
                //查看最终错误数量
                if (errNum != 0)
                {
                    colMsg[0] = "Failed";
                    colMsg.Add(strResult.ToString());
                    errNum = 0;
                }
            }
            return colMsg;
        }
        private void ImportDataImpl(string budgetYear, string parentID, DataTable data, IDbTransaction transaction)
        {
            Dictionary<string, decimal> dicIsInfo = new Dictionary<string, decimal>();         //用于保存是否相关参考信息
            Dictionary<string, string> dicItemType = new Dictionary<string, string>();         //用于保存科目类别
            Dictionary<string, string> dicImpType = new Dictionary<string, string>();          //用于保存编制方式
            Dictionary<string, string> dicDataType = new Dictionary<string, string>();         //用于保存数据类型
            Dictionary<string, string> dicUsage = new Dictionary<string, string>();            //用于保存适用范围
            Dictionary<string, string> dicPrePattern = new Dictionary<string, string>();       //用于保存编制模式

            dicIsInfo.Add("是", (decimal)Ipedf.Common.是否状态.是);
            dicIsInfo.Add("否", (decimal)Ipedf.Common.是否状态.否);

            CauseObject_COM_TYPE pItemType = new CauseObject_COM_TYPE();
            pItemType.PARENT_ID = "0018";
            EntityObject_COM_TYPE[] itemTypes = HelperObject_COM_TYPE.Query(pItemType, transaction);
            foreach (EntityObject_COM_TYPE itemType in itemTypes)
            {
                dicItemType.Add(itemType.NAME, itemType.ID);
            }
            CauseObject_COM_TYPE pImpType = new CauseObject_COM_TYPE();
            pImpType.PARENT_ID = "0019";
            EntityObject_COM_TYPE[] impTypes = HelperObject_COM_TYPE.Query(pImpType, transaction);
            foreach (EntityObject_COM_TYPE impType in impTypes)
            {
                dicImpType.Add(impType.NAME, impType.ID);
            }
            CauseObject_COM_TYPE pdataType = new CauseObject_COM_TYPE();
            pdataType.PARENT_ID = "0021";
            EntityObject_COM_TYPE[] dataTypes = HelperObject_COM_TYPE.Query(pdataType, transaction);
            foreach (EntityObject_COM_TYPE dataType in dataTypes)
            {
                dicDataType.Add(dataType.NAME, dataType.ID);
            }
            CauseObject_COM_TYPE pUsage = new CauseObject_COM_TYPE();
            pUsage.PARENT_ID = "0020";
            EntityObject_COM_TYPE[] usages = HelperObject_COM_TYPE.Query(pUsage, transaction);
            foreach (EntityObject_COM_TYPE usage in usages)
            {
                dicUsage.Add(usage.NAME, usage.ID);
            }
            CauseObject_COM_TYPE pPrePattern = new CauseObject_COM_TYPE();
            pPrePattern.PARENT_ID = "0017";
            EntityObject_COM_TYPE[] prePatterns = HelperObject_COM_TYPE.Query(pPrePattern, transaction);
            foreach (EntityObject_COM_TYPE prePattern in prePatterns)
            {
                dicPrePattern.Add(prePattern.NAME, prePattern.ID);
            }

            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_D_BUDGET_ITEM bgtItem = new EntityObject_BGT_D_BUDGET_ITEM();
                SystemLogic.Proxy.AuditAdd(bgtItem);
                bgtItem.BUDGET_YEAR = budgetYear;
                bgtItem.PARENT_ID = parentID;
                bgtItem.CODE = data.Rows[i][0].ToString().Trim();
                bgtItem.NAME = data.Rows[i][1].ToString().Trim();
                bgtItem.ITEM_TYPE_ID = dicItemType[data.Rows[i][2].ToString().Trim()];
                bgtItem.IMPORT_TYPE_ID = dicImpType[data.Rows[i][3].ToString().Trim()];
                bgtItem.DATA_TYPE_ID = dicDataType[data.Rows[i][4].ToString().Trim()];
                bgtItem.USAGE_ID = dicUsage[data.Rows[i][5].ToString().Trim()];
                bgtItem.PREPARE_PATTERN_ID = dicPrePattern[data.Rows[i][6].ToString().Trim()];
                bgtItem.IS_CARRYOVER = dicIsInfo[data.Rows[i][7].ToString().Trim()];
                bgtItem.IS_MERGE = dicIsInfo[data.Rows[i][8].ToString().Trim()];
                bgtItem.IS_END = dicIsInfo[data.Rows[i][9].ToString().Trim()];
                HelperObject_BGT_D_BUDGET_ITEM.Save(bgtItem, transaction);
            }
        }
	}
}
