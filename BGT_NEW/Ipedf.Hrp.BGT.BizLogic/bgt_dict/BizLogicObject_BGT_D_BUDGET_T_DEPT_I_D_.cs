
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

	public partial class BizLogicObject_BGT_D_BUDGET_T_DEPT_I_D
	{
        public DisplayObject_BGT_D_BUDGET_T_DEPT_I_D[] Query2(CauseObject_BGT_D_BUDGET_T_DEPT_I_D cause)
        {
            if (LocalMode)
            {
                SystemLogic.Proxy.AuditQuery(cause);

                //平台自动生成代码
                return HelperObject_BGT_D_BUDGET_T_DEPT_I_D.Query2(cause);
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T_DEPT_I_D> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T_DEPT_I_D>(ServiceUri))
                {
                    return smgr.Service.Query2(cause);
                }
            }
        }
	}
}
