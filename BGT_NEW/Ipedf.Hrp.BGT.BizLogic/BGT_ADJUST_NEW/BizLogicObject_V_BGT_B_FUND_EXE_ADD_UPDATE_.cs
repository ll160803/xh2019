
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
	
	public partial class BizLogicObject_V_BGT_B_FUND_EXE_ADD_UPDATE
	{
        public decimal[] QuerySUM(CauseObject_V_BGT_B_FUND_EXE_ADD_UPDATE cause)
        {
            if (LocalMode)
            {
                return HelperObject_V_BGT_B_FUND_EXE_ADD_UPDATE.QuerySUM(cause);
            }
            else
            {
                using (ServiceManager<ServiceContract_V_BGT_B_FUND_EXE_ADD_UPDATE> smgr = new ServiceManager<ServiceContract_V_BGT_B_FUND_EXE_ADD_UPDATE>(ServiceUri))
                {
                    return smgr.Service.QuerySUM(cause);
                }
            }
        }

       
	}
}
