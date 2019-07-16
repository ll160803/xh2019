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
namespace Ipedf.Web.ServiceContract
{
	#if NESTING
    [ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_PLAN_MON_FACT_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_PLAN_MON_FACT))]	
	public partial interface ServiceContract_BGT_B_DEPT_PLAN_MON_FACT: IServiceContractLocal<EntityObject_BGT_B_DEPT_PLAN_MON_FACT, CauseObject_BGT_B_DEPT_PLAN_MON_FACT>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_DEPT_PLAN_MON_FACT obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_DEPT_PLAN_MON_FACT obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_DEPT_PLAN_MON_FACT obj);
		[OperationContract]
		EntityObject_BGT_B_DEPT_PLAN_MON_FACT Get(EntityObject_BGT_B_DEPT_PLAN_MON_FACT obj);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_PLAN_MON_FACT[] List();
		[OperationContract]
		DisplayObject_BGT_B_DEPT_PLAN_MON_FACT[] Query(CauseObject_BGT_B_DEPT_PLAN_MON_FACT cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_DEPT_PLAN_MON_FACT cause);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_PLAN_MON_FACT[] Query(CauseObject_BGT_B_DEPT_PLAN_MON_FACT cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_DEPT_PLAN_MON_FACT[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_DEPT_PLAN_MON_FACT[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_DEPT_PLAN_MON_FACT[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_DEPT_PLAN_MON_FACT obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_DEPT_PLAN_MON_FACT obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_DEPT_PLAN_MON_FACT obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_DEPT_PLAN_MON_FACT obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_DEPT_PLAN_MON_FACT obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_DEPT_PLAN_MON_FACT obj);
        [OperationContract]
        EntityObject_BGT_B_DEPT_PLAN_MON_FACT Load(string id , out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_PLAN_MON_FACT[] saveEntities, EntityObject_BGT_B_DEPT_PLAN_MON_FACT[] updateEntities, EntityObject_BGT_B_DEPT_PLAN_MON_FACT[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_B_DEPT_PLAN_MON_FACT saveBaseEntity, EntityObject_BGT_B_DEPT_PLAN_MON_FACT_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_DEPT_PLAN_MON_FACT deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_PLAN_MON_FACT updateBaseEntity, EntityObject_BGT_B_DEPT_PLAN_MON_FACT_D[] saveDetailEntities, EntityObject_BGT_B_DEPT_PLAN_MON_FACT_D[] updateDetailEntities, EntityObject_BGT_B_DEPT_PLAN_MON_FACT_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
