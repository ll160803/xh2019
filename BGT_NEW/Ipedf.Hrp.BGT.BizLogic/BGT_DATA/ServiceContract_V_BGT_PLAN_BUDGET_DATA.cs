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
	[ServiceContract]
	public partial interface ServiceContract_V_BGT_PLAN_BUDGET_DATA
	{	
		[OperationContract]
		DisplayObject_V_BGT_PLAN_BUDGET_DATA[] List();
		[OperationContract]
		DisplayObject_V_BGT_PLAN_BUDGET_DATA[] Query(CauseObject_V_BGT_PLAN_BUDGET_DATA cause);
		[OperationContract]
		DisplayObject_V_BGT_PLAN_BUDGET_DATA[] Query(CauseObject_V_BGT_PLAN_BUDGET_DATA cause,PagingParamter paging,OrderByParameter order);

	}
}
