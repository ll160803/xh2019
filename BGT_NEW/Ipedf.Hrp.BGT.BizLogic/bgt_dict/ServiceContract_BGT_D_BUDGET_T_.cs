#define NESTING
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
#if NESTING
    [ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_T_A))]
#endif
    [ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_T))]
    public partial interface ServiceContract_BGT_D_BUDGET_T : IServiceContractLocal<EntityObject_BGT_D_BUDGET_T, CauseObject_BGT_D_BUDGET_T>
    {
        #region Relation Blok
#if NESTING
        [OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_D_BUDGET_T saveBaseEntity, EntityObject_BGT_D_BUDGET_T_A[] saveDetailEntities);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_T updateBaseEntity, EntityObject_BGT_D_BUDGET_T_A[] saveDetailEntities, EntityObject_BGT_D_BUDGET_T_A[] updateDetailEntities, EntityObject_BGT_D_BUDGET_T_A[] deleteDetailEntities);
#endif
        #endregion
        BizLogicMsg Calculate(EntityObject_BGT_D_BUDGET_T obj);
        [OperationContract]
        BizLogicMsg ImportPlanService(EntityObject_BGT_D_BUDGET_T obj, DataTable data);
        [OperationContract]
        List<string> CheckPlanService(EntityObject_BGT_D_BUDGET_T obj, DataTable data);
        [OperationContract]
        BizLogicMsg ImportIncomeService(EntityObject_BGT_D_BUDGET_T obj, DataTable data);
        [OperationContract]
        List<string> CheckIncomeService(EntityObject_BGT_D_BUDGET_T obj, DataTable data);
        [OperationContract]
        BizLogicMsg ImportPayService(EntityObject_BGT_D_BUDGET_T obj, DataTable data);
        [OperationContract]
        List<string> CheckPayService(EntityObject_BGT_D_BUDGET_T obj, DataTable data);
        [OperationContract]
        BizLogicMsg CopyNew(EntityObject_BGT_D_BUDGET_T entity);
    }
}
