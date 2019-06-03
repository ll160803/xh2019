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
	public partial interface ServiceContract_V_SCM_B_QUOTEDPRICE
	{	
		[OperationContract]
		DisplayObject_V_SCM_B_QUOTEDPRICE[] List();
		[OperationContract]
		DisplayObject_V_SCM_B_QUOTEDPRICE[] Query(CauseObject_V_SCM_B_QUOTEDPRICE cause);
		[OperationContract]
		DisplayObject_V_SCM_B_QUOTEDPRICE[] Query(CauseObject_V_SCM_B_QUOTEDPRICE cause,PagingParamter paging,OrderByParameter order);

	}
}
