using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Ipedf.Core;
using Ipedf.Web.DataAccess;
using Ipedf.Wcf.ClientProxy;
using Ipedf.Web.ServiceContract;

namespace Ipedf.Web.BizLogic
{
    public partial class BizLogicObject_SCM_D_PURCHARSEPLAN
    {
        // private  object abc = new object();//锁定只有一个进程可以访问到它
        public int IsAllowAdd(string EBELN, string EBELP, decimal MENGE, string gysaccount, string matnr, string charge, decimal Flag, string ID)
        {
            int IsAllow = -1;
            if (LocalMode)
            {

                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            //lock (abc)
                            //{
                            IsAllow = HelperObject_SCM_D_PURCHARSEPLAN.IsAllowAdd(EBELN, EBELP, MENGE, gysaccount, matnr, charge, Flag, ID);

                            // }
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return IsAllow;
            }
            else
            {
                using (ServiceManager<ServiceContract_SCM_D_PURCHARSEPLAN> smgr = new ServiceManager<ServiceContract_SCM_D_PURCHARSEPLAN>(ServiceUri))
                {
                    return smgr.Service.IsAllowAdd(EBELN, EBELP, MENGE, gysaccount, matnr, charge, Flag, ID);
                }
            }
        }
    }
}
