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
	public partial class BizLogicObject_BGT_B_DEPT_PAY_MON_FACT
	{
        public BizLogicMsg Archive(EntityObject_BGT_B_DEPT_PAY_MON_FACT obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                string outmsg = string.Empty;
                try
                {
                    HelperObject_BGT_B_DEPT_PAY_MON_FACT.ApplyFactData(obj.ID, out outmsg);
                }
                catch (Exception expt)
                {
                    msg = new BizLogicMsg(false, expt.Message);
                    Error(expt);
                }
                finally
                { }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_MON_FACT> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_MON_FACT>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }

        public BizLogicMsg PrepareItemList(EntityObject_BGT_B_DEPT_PAY_MON_FACT obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                string outmsg = string.Empty;
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            //先删除
                            CauseObject_BGT_B_DEPT_PAY_MON_FACT_D pdelete = new CauseObject_BGT_B_DEPT_PAY_MON_FACT_D();
                            pdelete.BASE_ID = obj.ID;
                            HelperObject_BGT_B_DEPT_PAY_MON_FACT_D.Delete(pdelete, transaction);
                            //再新增
                            CauseObject_BGT_B_DEPT_MON_EXE_D pSource = new CauseObject_BGT_B_DEPT_MON_EXE_D();
                            pSource.SetCustomCondition(string.Format(" and BGT_B_DEPT_MON_EXE_D.BASE_ID in(select t.id from BGT_B_DEPT_MON_EXE t where t.BUDGET_DEPT_ID='{0}' and t.BUDGET_CONTENTS_ID = '{1}' and t.BUDGET_YEAR = (select id from BGT_D_BUDGET_YEAR where BUDGET_YEAR = substr('{2}',0,4) ))", obj.BUDGET_DEPT_ID, "00120003", obj.FINANCE_CYCLE));//支出预算
                            DisplayObject_BGT_B_DEPT_MON_EXE_D[] items = HelperObject_BGT_B_DEPT_MON_EXE_D.Query(pSource, transaction);
                            foreach (EntityObject_BGT_B_DEPT_MON_EXE_D item in items)
                            {
                                EntityObject_BGT_B_DEPT_PAY_MON_FACT_D factd = new EntityObject_BGT_B_DEPT_PAY_MON_FACT_D();
                                factd.BASE_ID = obj.ID;//关联主表
                                factd.ITEM_ID = item.ITEM_ID;
                                HelperObject_BGT_B_DEPT_PAY_MON_FACT_D.Save(factd, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_MON_FACT> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_MON_FACT>(ServiceUri))
                {
                    return smgr.Service.PrepareItemList(obj);
                }
            }
        }
        public List<string> CheckImportService(string budgetYear, DataTable data)
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
                            colMsg = CheckImportImpl(budgetYear, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_MON_FACT> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_MON_FACT>(ServiceUri))
                {
                    return smgr.Service.CheckImportService(budgetYear, data);
                }
            }
        }
        public BizLogicMsg ImportDataService(EntityObject_BGT_B_DEPT_PAY_MON_FACT obj, string budgetYear, DataTable data)
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
                            ImportDataImpl(obj, budgetYear, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_DEPT_PAY_MON_FACT> smgr = new ServiceManager<ServiceContract_BGT_B_DEPT_PAY_MON_FACT>(ServiceUri))
                {
                    return smgr.Service.ImportDataService(obj, budgetYear, data);
                }
            }
        }
        private List<string> CheckImportImpl(string budgetYear, DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据保存结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量

            Dictionary<string, string> dicSource = new Dictionary<string, string>();    //用于保存数据来源类型

            CauseObject_COM_TYPE pSource = new CauseObject_COM_TYPE();
            pSource.PARENT_ID = "0015";
            EntityObject_COM_TYPE[] sourceTypes = HelperObject_COM_TYPE.Query(pSource, transaction);
            foreach (EntityObject_COM_TYPE sourceType in sourceTypes)
            {
                dicSource.Add(sourceType.NAME, sourceType.ID);
            }

            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第一列数据 支出科目
                if (dataRow[0] == null || string.IsNullOrEmpty(dataRow[0].ToString().Trim()))
                {
                    strResult.Append("支出科目未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[0].ToString().Trim();
                    CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                    pItem.NAME = itemName;
                    pItem.ITEM_TYPE_ID = "00180005";//支出科目
                    pItem.BUDGET_YEAR = budgetYear;
                    pItem.IS_END = (decimal)Ipedf.Common.是否状态.是;
                    EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                    if (items == null || items.Length == 0)        //需要在预算项目表做预算年度与预算项目名称唯一约束保证查询结果无数据或只有一条数据
                    {
                        errNum++;
                        strResult.Append("科目名称不存在 ");
                    }
                }
                //检测第二列数据 执行数量
                decimal res = 0;
                if (!decimal.TryParse((dataRow[1] == null || string.IsNullOrEmpty(dataRow[1].ToString().Trim())) ? "0" : dataRow[1].ToString().Trim(), out res))
                {
                    errNum++;
                    strResult.Append("执行数量有误 ");
                }
                //检测第三列数据 数据来源
                if (dataRow[2] == null || string.IsNullOrEmpty(dataRow[2].ToString().Trim()))
                {
                    strResult.Append("数据来源未填写");
                    errNum++;
                }
                else
                {
                    if (!dicSource.ContainsKey(data.Rows[i][2].ToString().Trim()))
                    {
                        errNum++;
                        strResult.Append("数据来源不存在 ");
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
        private void ImportDataImpl(EntityObject_BGT_B_DEPT_PAY_MON_FACT obj, string budgetYear, DataTable data, IDbTransaction transaction)
        {
            Dictionary<string, string> dicSource = new Dictionary<string, string>();    //用于保存数据来源类型

            CauseObject_COM_TYPE pSource = new CauseObject_COM_TYPE();
            pSource.PARENT_ID = "0015";
            EntityObject_COM_TYPE[] sourceTypes = HelperObject_COM_TYPE.Query(pSource, transaction);
            foreach (EntityObject_COM_TYPE sourceType in sourceTypes)
            {
                dicSource.Add(sourceType.NAME, sourceType.ID);
            }

            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_B_DEPT_PAY_MON_FACT_D factD = new EntityObject_BGT_B_DEPT_PAY_MON_FACT_D();
                SystemLogic.Proxy.AuditAdd(factD);
                factD.BASE_ID = obj.ID;
                CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                pItem.NAME = data.Rows[i][0].ToString().Trim();
                pItem.ITEM_TYPE_ID = "00180005";//支出科目
                pItem.BUDGET_YEAR = budgetYear;
                pItem.IS_END = (decimal)Ipedf.Common.是否状态.是;
                EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                factD.ITEM_ID = items[0].ID;
                factD.FACT_VALUE = ResolveDataCellNumber(data.Rows[i][1]);
                factD.SOURCE_TYPE_ID = dicSource[data.Rows[i][2].ToString().Trim()];
                HelperObject_BGT_B_DEPT_PAY_MON_FACT_D.Save(factD, transaction);
            }
        }
        private decimal ResolveDataCellNumber(object dataCell)
        {
            return decimal.Parse((dataCell == null || string.IsNullOrEmpty(dataCell.ToString().Trim())) ? "0" : dataCell.ToString().Trim());
        }
	}
}
