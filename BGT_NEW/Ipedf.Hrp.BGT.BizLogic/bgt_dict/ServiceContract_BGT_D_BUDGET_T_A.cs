
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
    [ServiceKnownType(typeof(EntityObject_))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_T))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_T_A))]	
	public partial interface ServiceContract_BGT_D_BUDGET_T_A: IServiceContractLocal<EntityObject_BGT_D_BUDGET_T_A, CauseObject_BGT_D_BUDGET_T_A>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_BUDGET_T_A obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_BUDGET_T_A obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_T_A obj);
		[OperationContract]
		EntityObject_BGT_D_BUDGET_T_A Get(EntityObject_BGT_D_BUDGET_T_A obj);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_T_A[] List();
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_T_A[] Query(CauseObject_BGT_D_BUDGET_T_A cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_T_A cause);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_T_A[] Query(CauseObject_BGT_D_BUDGET_T_A cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_T_A[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_T_A[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_T_A[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_T_A obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_T_A obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_T_A obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_T_A obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_T_A obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_T_A obj);
        [OperationContract]
        EntityObject_BGT_D_BUDGET_T_A Load(string id , out EntityObject_BGT_D_BUDGET_T base_id, out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_T_A[] saveEntities, EntityObject_BGT_D_BUDGET_T_A[] updateEntities, EntityObject_BGT_D_BUDGET_T_A[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_BGT_D_BUDGET_T_A saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_BGT_D_BUDGET_T_A deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_T_A updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
