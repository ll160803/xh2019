
using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
using System.Collections.Generic;
namespace Ipedf.Web.ServiceContract
{
	public partial interface ServiceContract_SCM_B_QUERYPRICE
	{
        [OperationContract]
        DisplayObject_SCM_B_QUERYPRICE_E Get_U(DisplayObject_SCM_B_QUERYPRICE obj);

        [OperationContract]
        BizLogicMsg UpdateState(string date, string[] itemIds, int type);

        [OperationContract]
        DisplayObject_SCM_B_QUERYPRICE_E[] Query_E(CauseObject_SCM_B_QUERYPRICE cause);

        DisplayObject_SCM_B_QUERYPRICE_E[] Query_E(CauseObject_SCM_B_QUERYPRICE cause, PagingParamter paging, OrderByParameter order);

        [OperationContract]
        BizLogicMsg UpdatePost(List<EntityObject_SCM_B_QUERYPRICE_U> listEntity, bool IsSubmit, List<DisplayObject_SCM_B_QUERYPRICE_E> resultDisplay);

        [OperationContract]
        BizLogicMsg DeletePost(EntityObject_SCM_B_QUERYPRICE[] itemEntity);

        [OperationContract]
        DisplayObject_SCM_B_QUERYPRICE_I[] Query_I(CauseObject_SCM_B_QUERYPRICE cause);

        [OperationContract]
        DisplayObject_SCM_B_QUERYPRICE_I[] Query_I(CauseObject_SCM_B_QUERYPRICE cause, PagingParamter paging, OrderByParameter order);
	}
}
