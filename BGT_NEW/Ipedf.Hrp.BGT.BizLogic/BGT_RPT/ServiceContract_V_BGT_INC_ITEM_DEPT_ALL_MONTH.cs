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
	public partial interface ServiceContract_V_BGT_INC_ITEM_DEPT_ALL_MONTH
	{	
		[OperationContract]
		DisplayObject_V_BGT_INC_ITEM_DEPT_ALL_MONTH[] List();
		[OperationContract]
		DisplayObject_V_BGT_INC_ITEM_DEPT_ALL_MONTH[] Query(CauseObject_V_BGT_INC_ITEM_DEPT_ALL_MONTH cause);
		[OperationContract]
		DisplayObject_V_BGT_INC_ITEM_DEPT_ALL_MONTH[] Query(CauseObject_V_BGT_INC_ITEM_DEPT_ALL_MONTH cause,PagingParamter paging,OrderByParameter order);

	}
}
