
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
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_T))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_PLAN_ITEM))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_T_DEPT_I))]	
	public partial interface ServiceContract_BGT_D_BUDGET_T_DEPT_I: IServiceContractLocal<EntityObject_BGT_D_BUDGET_T_DEPT_I, CauseObject_BGT_D_BUDGET_T_DEPT_I>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_BUDGET_T_DEPT_I obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_BUDGET_T_DEPT_I obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_T_DEPT_I obj);
		[OperationContract]
		EntityObject_BGT_D_BUDGET_T_DEPT_I Get(EntityObject_BGT_D_BUDGET_T_DEPT_I obj);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_T_DEPT_I[] List();
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_T_DEPT_I[] Query(CauseObject_BGT_D_BUDGET_T_DEPT_I cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_T_DEPT_I cause);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_T_DEPT_I[] Query(CauseObject_BGT_D_BUDGET_T_DEPT_I cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_T_DEPT_I[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_T_DEPT_I[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_T_DEPT_I[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_T_DEPT_I obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_T_DEPT_I obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_T_DEPT_I obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_T_DEPT_I obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_T_DEPT_I obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_T_DEPT_I obj);
        [OperationContract]
        EntityObject_BGT_D_BUDGET_T_DEPT_I Load(string id , out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id, out EntityObject_BGT_D_BUDGET_T base_id, out EntityObject_BGT_D_PLAN_ITEM item_id);
        [OperationContract]
        void CommitUpdate(EntityObject_BGT_D_BUDGET_T_DEPT_I[] saveEntities, EntityObject_BGT_D_BUDGET_T_DEPT_I[] updateEntities, EntityObject_BGT_D_BUDGET_T_DEPT_I[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_BGT_D_BUDGET_T_DEPT_I saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_BGT_D_BUDGET_T_DEPT_I deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_BGT_D_BUDGET_T_DEPT_I updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
