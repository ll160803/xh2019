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
	public partial interface ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL
	{
        [OperationContract]
        DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] Query_U(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause, bool IsOrder, PagingParamter paging, OrderByParameter order);
	}
}
