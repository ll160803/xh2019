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
    public partial interface ServiceContract_BGT_B_CPN_HIS_DATA
    {
        [OperationContract]
        BizLogicMsg ImportPlanService(EntityObject_BGT_B_CPN_HIS_DATA obj, DataTable data);
        [OperationContract]
        List<string> CheckPlanService(EntityObject_BGT_B_CPN_HIS_DATA obj, DataTable data);
        [OperationContract]
        BizLogicMsg ImportIncomeService(EntityObject_BGT_B_CPN_HIS_DATA obj, DataTable data);
        [OperationContract]
        List<string> CheckIncomeService(EntityObject_BGT_B_CPN_HIS_DATA obj, DataTable data);
        [OperationContract]
        BizLogicMsg ImportPayService(EntityObject_BGT_B_CPN_HIS_DATA obj, DataTable data);
        [OperationContract]
        List<string> CheckPayService(EntityObject_BGT_B_CPN_HIS_DATA obj, DataTable data);
    }
}
