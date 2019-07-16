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
    public partial interface ServiceContract_V_BGT_INC_BUDGET_DATA
    {
        [OperationContract]
        DisplayObject_V_BGT_INC_BUDGET_DATA_EXT[] QueryExt(CauseObject_V_BGT_INC_BUDGET_DATA cause, PagingParamter paging, OrderByParameter order);
    }
}
