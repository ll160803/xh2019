
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
	public partial interface ServiceContract_SCM_B_PRICEADJUST
	{
		[OperationContract]
		DisplayObject_SCM_B_PRICEADJUST[] QueryPost(CauseObject_SCM_B_PRICEADJUST cause,PagingParamter paging,OrderByParameter order);

        [OperationContract]
        DisplayObject_SCM_B_PRICEADJUST[] QueryPost(CauseObject_SCM_B_PRICEADJUST cause);
	}
}
