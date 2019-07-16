
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
namespace Ipedf.Web.BizLogic
{

    public partial class BizLogicObject_BGT_B_BUDGET_PROJ_ADJUST_D 
    {
        public BizLogicMsg BatchSave(EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D[] objs)
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
                            foreach (EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D obj in objs)
                            {
                                SystemLogic.Proxy.AuditAdd(obj);
                            }
                            int amount = 0;

                            //平台自动生成代码
                            foreach (EntityObject_BGT_B_BUDGET_PROJ_ADJUST_D obj in objs)
                            {
                                amount += HelperObject_BGT_B_BUDGET_PROJ_ADJUST_D.Save(obj, transaction);
                                //更新调整前金额
                                HelperObject_BGT_B_BUDGET_PROJ_ADJUST_D.PrepareBaseBudgetValue(obj, transaction);
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
                using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST_D> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_ADJUST_D>(ServiceUri))
                {
                    return smgr.Service.BatchSave(objs);
                }
            }
        }
    }
}
