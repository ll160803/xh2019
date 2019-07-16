
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
	public partial class BizLogicObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND
	{
        public decimal[] QuerySUM(CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause)
        {
            if (LocalMode)
            {
                return HelperObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.QuerySUM(cause);
            }
            else
            {
                using (ServiceManager<ServiceContract_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND> smgr = new ServiceManager<ServiceContract_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND>(ServiceUri))
                {
                    return smgr.Service.QuerySUM(cause);
                }
            }
        }
	}
}
