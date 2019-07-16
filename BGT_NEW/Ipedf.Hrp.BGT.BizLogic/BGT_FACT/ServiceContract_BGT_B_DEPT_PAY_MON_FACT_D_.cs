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
    public partial interface ServiceContract_BGT_B_DEPT_PAY_MON_FACT_D
    {
        [OperationContract]
        DisplayObject_BGT_B_DEPT_PAY_MON_FACT_D_EXT[] QueryExt(CauseObject_BGT_B_DEPT_PAY_MON_FACT_D cause, PagingParamter paging, OrderByParameter order);
    }
}
