using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.ServiceContract;
using Ipedf.Web.DataAccess;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.Wcf.ClientProxy;
namespace Ipedf.Web.BizLogic
{
	public partial class BizLogicObject_V_BGT_DEPT_BUDGET_DATA_PROCESS
    {
        public BizLogicMsg UndoSubmitDeptPlanBudgetData(DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] deptBudgetData)
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
                            foreach (DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS dd in deptBudgetData)
                            {
                                HelperObject_BGT_B_BUDGET_DATA.UndoSubmitPlanData(dd.DEPT_ID, dd.BUDGET_YEAR, dd.TEMPLET_ID, transaction);
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
                using (ServiceManager<ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS> smgr = new ServiceManager<ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS>(ServiceUri))
                {
                    return smgr.Service.UndoSubmitDeptPlanBudgetData(deptBudgetData);
                }
            }
        }
        public BizLogicMsg UndoSubmitDeptIncomeBudgetData(DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] deptBudgetData)
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
                            foreach (DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS dd in deptBudgetData)
                            {
                                HelperObject_BGT_B_BUDGET_DATA.UndoSubmitIncomeData(dd.DEPT_ID, dd.BUDGET_YEAR, dd.TEMPLET_ID, transaction);
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
                using (ServiceManager<ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS> smgr = new ServiceManager<ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS>(ServiceUri))
                {
                    return smgr.Service.UndoSubmitDeptIncomeBudgetData(deptBudgetData);
                }
            }
        }
        public BizLogicMsg UndoSubmitDeptPayBudgetData(DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] deptBudgetData)
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
                            foreach (DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS dd in deptBudgetData)
                            {
                                HelperObject_BGT_B_BUDGET_DATA.UndoSubmitPayData(dd.DEPT_ID, dd.BUDGET_YEAR, dd.TEMPLET_ID, transaction);
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
                using (ServiceManager<ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS> smgr = new ServiceManager<ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS>(ServiceUri))
                {
                    return smgr.Service.UndoSubmitDeptPayBudgetData(deptBudgetData);
                }
            }
        }
	}
}
