
using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web.ServiceContract
{
	
	public partial interface ServiceContract_V_BGT_B_FUND_EXE_ADD_UPDATE
	{
        decimal[] QuerySUM(CauseObject_V_BGT_B_FUND_EXE_ADD_UPDATE cause);
	}
}
