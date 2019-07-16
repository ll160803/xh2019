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
    public partial interface ServiceContract_BGT_B_DEPT_PAY_YEAR_FUND
    {
        [OperationContract]
        BizLogicMsg ImportService1(EntityObject_BGT_B_DEPT_PAY_YEAR_FUND obj, DataTable data);
        [OperationContract]
        List<string> CheckService1(EntityObject_BGT_B_DEPT_PAY_YEAR_FUND obj, DataTable data);
        [OperationContract]
        BizLogicMsg ImportService2(EntityObject_BGT_B_DEPT_PAY_YEAR_FUND obj, DataTable data);
        [OperationContract]
        List<string> CheckService2(EntityObject_BGT_B_DEPT_PAY_YEAR_FUND obj, DataTable data);
        [OperationContract]
        BizLogicMsg ImportService3(EntityObject_BGT_B_DEPT_PAY_YEAR_FUND obj, DataTable data);
        [OperationContract]
        List<string> CheckService3(EntityObject_BGT_B_DEPT_PAY_YEAR_FUND obj, DataTable data);

    }
}
