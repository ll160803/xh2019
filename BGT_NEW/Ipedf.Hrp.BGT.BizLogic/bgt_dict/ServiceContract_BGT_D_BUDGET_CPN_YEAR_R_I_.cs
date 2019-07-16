#define NESTING
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

	public partial interface ServiceContract_BGT_D_BUDGET_CPN_YEAR_R_I
	{		
		DisplayObject_BGT_D_BUDGET_CPN_YEAR_R_I[] Query2(CauseObject_BGT_D_BUDGET_CPN_YEAR_R_I cause);		
	}
}
