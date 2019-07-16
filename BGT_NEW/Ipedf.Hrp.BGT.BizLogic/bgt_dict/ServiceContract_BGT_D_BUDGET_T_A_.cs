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
    public partial interface ServiceContract_BGT_D_BUDGET_T_A
    {
        [OperationContract]
        BizLogicMsg ImportDataService(EntityObject_BGT_D_BUDGET_T obj, DataTable data);
        [OperationContract]
        List<string> CheckImportService(EntityObject_BGT_D_BUDGET_T obj, DataTable data);
    }
}
