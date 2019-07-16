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
using System.Text;
using System.Collections.Generic;
namespace Ipedf.Web.BizLogic
{
    public partial class BizLogicObject_BGT_B_BUDGET_ADJUST
    {
        /*
        public List<string> CheckPlanService(EntityObject_BGT_B_DEPT_MON_ADJUST obj, DataTable data)
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
                            colMsg = CheckPlanImpl(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_MON_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_MON_ADJUST>(ServiceUri))
                {
                    return smgr.Service.CheckPlanService(obj, data);
                }
            }
        }
        public BizLogicMsg ImportPlanService(EntityObject_BGT_B_DEPT_MON_ADJUST obj, DataTable data)
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
                            ImportPlanImpl(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_MON_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_MON_ADJUST>(ServiceUri))
                {
                    return smgr.Service.ImportPlanService(obj, data);
                }
            }
        }
        private List<string> CheckPlanImpl(EntityObject_BGT_B_DEPT_MON_ADJUST obj, DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据保存结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量
            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第一列数据 预算项目
                if (dataRow[0] == null || string.IsNullOrEmpty(dataRow[0].ToString().Trim()))
                {
                    strResult.Append("预算项目未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[0].ToString().Trim();
                    CauseObject_BGT_D_PLAN_ITEM pItem = new CauseObject_BGT_D_PLAN_ITEM();
                    pItem.NAME = itemName;
                    pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                    pItem.IS_DISABLE = (decimal)Ipedf.Common.是否状态.否;
                    EntityObject_BGT_D_PLAN_ITEM[] items = HelperObject_BGT_D_PLAN_ITEM.Query(pItem, transaction);
                    if (items == null || items.Length == 0)        //需要在预算项目表做预算年度与预算项目名称唯一约束保证查询结果无数据或只有一条数据
                    {
                        errNum++;
                        strResult.Append("预算项目不存在 ");
                    }
                }
                //对月份数据进行检测
                for (int j = 1; j < data.Columns.Count - 1; j++)
                {
                    decimal res = 0;
                    if (!decimal.TryParse((dataRow[j] == null || string.IsNullOrEmpty(dataRow[j].ToString().Trim())) ? "0" : dataRow[j].ToString().Trim(), out res))
                    {
                        errNum++;
                        strResult.Append(j + "月数据有误 ");
                    }
                }
                if (errNum != 0)
                {
                    colMsg[0] = "Failed";
                    colMsg.Add(strResult.ToString());
                    errNum = 0;
                }
            }
            return colMsg;
        }
        private void ImportPlanImpl(EntityObject_BGT_B_DEPT_MON_ADJUST obj, DataTable data, IDbTransaction transaction)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_B_DEPT_MON_ADJUST_D cpnHisD = new EntityObject_BGT_B_DEPT_MON_ADJUST_D();
                SystemLogic.Proxy.AuditAdd(cpnHisD);
                cpnHisD.BASE_ID = obj.ID;
                CauseObject_BGT_D_PLAN_ITEM pItem = new CauseObject_BGT_D_PLAN_ITEM();
                pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                pItem.NAME = data.Rows[i][0].ToString().Trim();
                pItem.IS_DISABLE = (decimal)Ipedf.Common.是否状态.否;
                EntityObject_BGT_D_PLAN_ITEM[] items = HelperObject_BGT_D_PLAN_ITEM.Query(pItem, transaction);
                cpnHisD.ITEM_ID = items[0].ID;
                cpnHisD.M_1_VALUE = ResolveDataCellNumber(data.Rows[i][1]);
                cpnHisD.M_2_VALUE = ResolveDataCellNumber(data.Rows[i][2]);
                cpnHisD.M_3_VALUE = ResolveDataCellNumber(data.Rows[i][3]);
                cpnHisD.M_4_VALUE = ResolveDataCellNumber(data.Rows[i][4]);
                cpnHisD.M_5_VALUE = ResolveDataCellNumber(data.Rows[i][5]);
                cpnHisD.M_6_VALUE = ResolveDataCellNumber(data.Rows[i][6]);
                cpnHisD.M_7_VALUE = ResolveDataCellNumber(data.Rows[i][7]);
                cpnHisD.M_8_VALUE = ResolveDataCellNumber(data.Rows[i][8]);
                cpnHisD.M_9_VALUE = ResolveDataCellNumber(data.Rows[i][9]);
                cpnHisD.M_10_VALUE = ResolveDataCellNumber(data.Rows[i][10]);
                cpnHisD.M_11_VALUE = ResolveDataCellNumber(data.Rows[i][11]);
                cpnHisD.M_12_VALUE = ResolveDataCellNumber(data.Rows[i][12]);
                HelperObject_BGT_B_CPN_HIS_DATA_D.Save(cpnHisD, transaction);
            }
        }
        public List<string> CheckIncomeService(EntityObject_BGT_B_DEPT_MON_ADJUST obj, DataTable data)
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
                            colMsg = CheckIncomeImpl(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_MON_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_MON_ADJUST>(ServiceUri))
                {
                    return smgr.Service.CheckIncomeService(obj, data);
                }
            }
        }
        public BizLogicMsg ImportIncomeService(EntityObject_BGT_B_DEPT_MON_ADJUST obj, DataTable data)
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
                            ImportIncomeImpl(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_MON_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_MON_ADJUST>(ServiceUri))
                {
                    return smgr.Service.ImportIncomeService(obj, data);
                }
            }
        }
        private List<string> CheckIncomeImpl(EntityObject_BGT_B_DEPT_MON_ADJUST obj, DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据保存结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量
            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第一列数据 预算项目
                if (dataRow[0] == null || string.IsNullOrEmpty(dataRow[0].ToString().Trim()))
                {
                    strResult.Append("收入科目未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[0].ToString().Trim();
                    CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                    pItem.ITEM_TYPE_ID = "00180004";//收入科目
                    pItem.NAME = itemName;
                    pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                    pItem.IS_END = (decimal)是否状态.是;
                    EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                    if (items == null || items.Length == 0)        //需要在预算项目表做预算年度与预算项目名称唯一约束保证查询结果无数据或只有一条数据
                    {
                        errNum++;
                        strResult.Append("收入科目不存在 ");
                    }
                }
                //对月份数据进行检测
                for (int j = 1; j < data.Columns.Count - 1; j++)
                {
                    decimal res = 0;
                    if (!decimal.TryParse((dataRow[j] == null || string.IsNullOrEmpty(dataRow[j].ToString().Trim())) ? "0" : dataRow[j].ToString().Trim(), out res))
                    {
                        errNum++;
                        strResult.Append(j + "月数据有误 ");
                    }
                }
                if (errNum != 0)
                {
                    colMsg[0] = "Failed";
                    colMsg.Add(strResult.ToString());
                    errNum = 0;
                }
            }
            return colMsg;
        }
        private void ImportIncomeImpl(EntityObject_BGT_B_DEPT_MON_ADJUST obj, DataTable data, IDbTransaction transaction)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_B_DEPT_MON_ADJUST_D cpnHisD = new EntityObject_BGT_B_DEPT_MON_ADJUST_D();
                SystemLogic.Proxy.AuditAdd(cpnHisD);
                cpnHisD.BASE_ID = obj.ID;
                CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                pItem.ITEM_TYPE_ID = "00180004";//收入科目
                pItem.NAME = data.Rows[i][0].ToString().Trim();
                pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                pItem.IS_END = (decimal)是否状态.是;
                EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                cpnHisD.ITEM_ID = items[0].ID;
                cpnHisD.M_1_VALUE = ResolveDataCellNumber(data.Rows[i][1]);
                cpnHisD.M_2_VALUE = ResolveDataCellNumber(data.Rows[i][2]);
                cpnHisD.M_3_VALUE = ResolveDataCellNumber(data.Rows[i][3]);
                cpnHisD.M_4_VALUE = ResolveDataCellNumber(data.Rows[i][4]);
                cpnHisD.M_5_VALUE = ResolveDataCellNumber(data.Rows[i][5]);
                cpnHisD.M_6_VALUE = ResolveDataCellNumber(data.Rows[i][6]);
                cpnHisD.M_7_VALUE = ResolveDataCellNumber(data.Rows[i][7]);
                cpnHisD.M_8_VALUE = ResolveDataCellNumber(data.Rows[i][8]);
                cpnHisD.M_9_VALUE = ResolveDataCellNumber(data.Rows[i][9]);
                cpnHisD.M_10_VALUE = ResolveDataCellNumber(data.Rows[i][10]);
                cpnHisD.M_11_VALUE = ResolveDataCellNumber(data.Rows[i][11]);
                cpnHisD.M_12_VALUE = ResolveDataCellNumber(data.Rows[i][12]);
                HelperObject_BGT_B_CPN_HIS_DATA_D.Save(cpnHisD, transaction);
            }
        }
        public List<string> CheckPayService(EntityObject_BGT_B_DEPT_MON_ADJUST obj, DataTable data)
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
                            colMsg = CheckPayImpl(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_MON_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_MON_ADJUST>(ServiceUri))
                {
                    return smgr.Service.CheckPayService(obj, data);
                }
            }
        }
        public BizLogicMsg ImportPayService(EntityObject_BGT_B_DEPT_MON_ADJUST obj, DataTable data)
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
                            ImportPayImpl(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_MON_ADJUST> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_MON_ADJUST>(ServiceUri))
                {
                    return smgr.Service.ImportPayService(obj, data);
                }
            }
        }
        private List<string> CheckPayImpl(EntityObject_BGT_B_DEPT_MON_ADJUST obj, DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据保存结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量
            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第一列数据 预算项目
                if (dataRow[0] == null || string.IsNullOrEmpty(dataRow[0].ToString().Trim()))
                {
                    strResult.Append("支出科目未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[0].ToString().Trim();
                    CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                    pItem.ITEM_TYPE_ID = "00180005";//支出科目
                    pItem.NAME = itemName;
                    pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                    pItem.IS_END = (decimal)是否状态.是;
                    EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                    if (items == null || items.Length == 0)        //需要在预算项目表做预算年度与预算项目名称唯一约束保证查询结果无数据或只有一条数据
                    {
                        errNum++;
                        strResult.Append("支出科目不存在 ");
                    }
                }
                //对月份数据进行检测
                for (int j = 1; j < data.Columns.Count - 1; j++)
                {
                    decimal res = 0;
                    if (!decimal.TryParse((dataRow[j] == null || string.IsNullOrEmpty(dataRow[j].ToString().Trim())) ? "0" : dataRow[j].ToString().Trim(), out res))
                    {
                        errNum++;
                        strResult.Append(j + "月数据有误 ");
                    }
                }
                if (errNum != 0)
                {
                    colMsg[0] = "Failed";
                    colMsg.Add(strResult.ToString());
                    errNum = 0;
                }
            }
            return colMsg;
        }
        private void ImportPayImpl(EntityObject_BGT_B_DEPT_MON_ADJUST obj, DataTable data, IDbTransaction transaction)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_B_DEPT_MON_ADJUST_D cpnHisD = new EntityObject_BGT_B_DEPT_MON_ADJUST_D();
                SystemLogic.Proxy.AuditAdd(cpnHisD);
                cpnHisD.BASE_ID = obj.ID;
                CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                pItem.ITEM_TYPE_ID = "00180005";//支出科目
                pItem.NAME = data.Rows[i][0].ToString().Trim();
                pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                pItem.IS_END = (decimal)是否状态.是;
                EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                cpnHisD.ITEM_ID = items[0].ID;
                cpnHisD.M_1_VALUE = ResolveDataCellNumber(data.Rows[i][1]);
                cpnHisD.M_2_VALUE = ResolveDataCellNumber(data.Rows[i][2]);
                cpnHisD.M_3_VALUE = ResolveDataCellNumber(data.Rows[i][3]);
                cpnHisD.M_4_VALUE = ResolveDataCellNumber(data.Rows[i][4]);
                cpnHisD.M_5_VALUE = ResolveDataCellNumber(data.Rows[i][5]);
                cpnHisD.M_6_VALUE = ResolveDataCellNumber(data.Rows[i][6]);
                cpnHisD.M_7_VALUE = ResolveDataCellNumber(data.Rows[i][7]);
                cpnHisD.M_8_VALUE = ResolveDataCellNumber(data.Rows[i][8]);
                cpnHisD.M_9_VALUE = ResolveDataCellNumber(data.Rows[i][9]);
                cpnHisD.M_10_VALUE = ResolveDataCellNumber(data.Rows[i][10]);
                cpnHisD.M_11_VALUE = ResolveDataCellNumber(data.Rows[i][11]);
                cpnHisD.M_12_VALUE = ResolveDataCellNumber(data.Rows[i][12]);
                HelperObject_BGT_B_CPN_HIS_DATA_D.Save(cpnHisD, transaction);
            }
        }
        private decimal ResolveDataCellNumber(object dataCell)
        {
            return decimal.Parse((dataCell == null || string.IsNullOrEmpty(dataCell.ToString().Trim())) ? "0" : dataCell.ToString().Trim());
        }
        */
    }
}
