
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
	[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_T_D))]	
	public partial interface ServiceContract_BGT_D_BUDGET_T_D
	{	

		[OperationContract]
        DisplayObject_BGT_D_BUDGET_T_D[] Query2(CauseObject_BGT_D_BUDGET_T_D cause);
        [OperationContract]
        DisplayObject_BGT_D_BUDGET_T_D_EXT[] QueryPlanExt(CauseObject_BGT_D_BUDGET_T_D cause, PagingParamter paging, OrderByParameter order);
        [OperationContract]
        DisplayObject_BGT_D_BUDGET_T_D_EXT[] QueryFinanceExt(CauseObject_BGT_D_BUDGET_T_D cause, PagingParamter paging, OrderByParameter order);
	
	}
}
