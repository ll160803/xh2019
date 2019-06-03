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
	public partial interface ServiceContract_V_SCM_B_QUERYPRICE_GYS
	{	
		[OperationContract]
		DisplayObject_V_SCM_B_QUERYPRICE_GYS[] List();
		[OperationContract]
		DisplayObject_V_SCM_B_QUERYPRICE_GYS[] Query(CauseObject_V_SCM_B_QUERYPRICE_GYS cause);
		[OperationContract]
		DisplayObject_V_SCM_B_QUERYPRICE_GYS[] Query(CauseObject_V_SCM_B_QUERYPRICE_GYS cause,PagingParamter paging,OrderByParameter order);

	}
}
