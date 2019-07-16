
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
	
	public partial interface ServiceContract_BGT_B_BUDGET_PROJ_CO
	{
        [OperationContract]
        EntityObject_BGT_D_BUDGET_YEAR GetRecentlyBudgetYear(string projectId);
		
	}
}
