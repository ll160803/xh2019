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
using System.Collections.Generic;
using System.Text;
namespace Ipedf.Web.BizLogic
{
    public partial class BizLogicObject_BGT_D_BUDGET_T_A
    {
        public List<string> CheckImportService(EntityObject_BGT_D_BUDGET_T obj, DataTable data)
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
                            colMsg = CheckImportImpl(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.CheckImportService(obj, data);
                }
            }
        }
        public BizLogicMsg ImportDataService(EntityObject_BGT_D_BUDGET_T obj, DataTable data)
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
                            ImportDataImpl(obj, data, transaction);
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
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_A> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_A>(ServiceUri))
                {
                    return smgr.Service.ImportDataService(obj, data);
                }
            }
        }
        private List<string> CheckImportImpl(EntityObject_BGT_D_BUDGET_T obj, DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据检测结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量
            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第一列数据 预算科室
                if (dataRow[0] == null || string.IsNullOrEmpty(dataRow[0].ToString().Trim()))
                {
                    strResult.Append("预算科室未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[0].ToString().Trim();
                    CauseObject_BGT_D_BUDGET_DEPT pItem = new CauseObject_BGT_D_BUDGET_DEPT();
                    pItem.NAME = itemName;
                    pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                    EntityObject_BGT_D_BUDGET_DEPT[] items = HelperObject_BGT_D_BUDGET_DEPT.Query(pItem, transaction);
                    if (items == null || items.Length == 0)        //需要在预算项目表做预算年度与预算项目名称唯一约束保证查询结果无数据或只有一条数据
                    {
                        errNum++;
                        strResult.Append("预算科室不存在 ");
                    }
                }
            }
            return colMsg;
        }
        private void ImportDataImpl(EntityObject_BGT_D_BUDGET_T obj, DataTable data, IDbTransaction transaction)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_D_BUDGET_T_A bgtA = new EntityObject_BGT_D_BUDGET_T_A();
                SystemLogic.Proxy.AuditAdd(bgtA);
                bgtA.BASE_ID = obj.ID;
                CauseObject_BGT_D_BUDGET_DEPT pItem = new CauseObject_BGT_D_BUDGET_DEPT();
                pItem.NAME = data.Rows[i][0].ToString().Trim();
                pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                EntityObject_BGT_D_BUDGET_DEPT[] items = HelperObject_BGT_D_BUDGET_DEPT.Query(pItem, transaction);
                bgtA.BUDGET_DEPT_ID = items[0].ID;
                HelperObject_BGT_D_BUDGET_T_A.Save(bgtA, transaction);
            }
        }
        private decimal ResolveDataCellNumber(object dataCell)
        {
            return decimal.Parse((dataCell == null || string.IsNullOrEmpty(dataCell.ToString().Trim())) ? "0" : dataCell.ToString().Trim());
        }
    }
}
