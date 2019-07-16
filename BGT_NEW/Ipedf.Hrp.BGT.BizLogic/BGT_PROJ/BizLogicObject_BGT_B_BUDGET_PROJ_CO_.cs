
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
	public partial class BizLogicObject_BGT_B_BUDGET_PROJ_CO
	{
        public EntityObject_BGT_D_BUDGET_YEAR GetRecentlyBudgetYear(string projectId)
        {
            
            if (LocalMode)
			{
                return HelperObject_BGT_B_BUDGET_PROJ_CO.GetRecentlyBudgetYear(projectId);														
            }
            else
            {
				using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_CO> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_CO>(ServiceUri))
                {
                    return smgr.Service.GetRecentlyBudgetYear(projectId);
                }
            }
        }

        public BizLogicMsg Archive(EntityObject_BGT_B_BUDGET_PROJ_CO obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                string outmsg = string.Empty;
                try
                {
                    HelperObject_BGT_B_BUDGET_PROJ_CO.ArchiveProjectCOData(obj.ID, out outmsg);
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
                using (ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_CO> smgr = new ServiceManager<ServiceContract_BGT_B_BUDGET_PROJ_CO>(ServiceUri))
                {
                    return smgr.Service.Archive(obj);
                }
            }
        }       
	}
}
