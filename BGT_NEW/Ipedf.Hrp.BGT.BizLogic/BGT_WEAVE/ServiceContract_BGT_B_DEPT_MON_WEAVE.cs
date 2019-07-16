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
    [ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_MON_WEAVE_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_MON_WEAVE))]	
	public partial interface ServiceContract_BGT_B_DEPT_MON_WEAVE: IServiceContractLocal<EntityObject_BGT_B_DEPT_MON_WEAVE, CauseObject_BGT_B_DEPT_MON_WEAVE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_DEPT_MON_WEAVE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_DEPT_MON_WEAVE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_DEPT_MON_WEAVE obj);
		[OperationContract]
		EntityObject_BGT_B_DEPT_MON_WEAVE Get(EntityObject_BGT_B_DEPT_MON_WEAVE obj);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_MON_WEAVE[] List();
		[OperationContract]
		DisplayObject_BGT_B_DEPT_MON_WEAVE[] Query(CauseObject_BGT_B_DEPT_MON_WEAVE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_DEPT_MON_WEAVE cause);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_MON_WEAVE[] Query(CauseObject_BGT_B_DEPT_MON_WEAVE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_DEPT_MON_WEAVE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_DEPT_MON_WEAVE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_DEPT_MON_WEAVE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_DEPT_MON_WEAVE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_DEPT_MON_WEAVE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_DEPT_MON_WEAVE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_DEPT_MON_WEAVE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_DEPT_MON_WEAVE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_DEPT_MON_WEAVE obj);
        [OperationContract]
        EntityObject_BGT_B_DEPT_MON_WEAVE Load(string id , out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        void CommitUpdate(EntityObject_BGT_B_DEPT_MON_WEAVE[] saveEntities, EntityObject_BGT_B_DEPT_MON_WEAVE[] updateEntities, EntityObject_BGT_B_DEPT_MON_WEAVE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_BGT_B_DEPT_MON_WEAVE saveBaseEntity, EntityObject_BGT_B_DEPT_MON_WEAVE_D[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_BGT_B_DEPT_MON_WEAVE deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_BGT_B_DEPT_MON_WEAVE updateBaseEntity, EntityObject_BGT_B_DEPT_MON_WEAVE_D[] saveDetailEntities, EntityObject_BGT_B_DEPT_MON_WEAVE_D[] updateDetailEntities, EntityObject_BGT_B_DEPT_MON_WEAVE_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
