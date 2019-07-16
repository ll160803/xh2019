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
	public partial interface ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS
	{	
		[OperationContract]
		DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] List();
		[OperationContract]
		DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] Query(CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS cause);
		[OperationContract]
		DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] Query(CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS cause,PagingParamter paging,OrderByParameter order);

	}
}
