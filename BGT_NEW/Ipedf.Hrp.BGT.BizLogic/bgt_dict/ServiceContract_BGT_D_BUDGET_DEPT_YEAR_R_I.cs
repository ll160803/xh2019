
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
		
[ServiceKnownType(typeof(EntityObject_BILL_WORK_FLOW))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_PLAN_ITEM))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I))]	
	public partial interface ServiceContract_BGT_D_BUDGET_DEPT_YEAR_R_I: IServiceContractLocal<EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I, CauseObject_BGT_D_BUDGET_DEPT_YEAR_R_I>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I obj);
		[OperationContract]
		EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I Get(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I obj);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I[] List();
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I[] Query(CauseObject_BGT_D_BUDGET_DEPT_YEAR_R_I cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_DEPT_YEAR_R_I cause);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I[] Query(CauseObject_BGT_D_BUDGET_DEPT_YEAR_R_I cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I obj);
        [OperationContract]
        EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I Load(string id , out EntityObject_BILL_WORK_FLOW base_id, out EntityObject_COM_TYPE resolve_method_id, out EntityObject_BGT_D_PLAN_ITEM item_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I[] saveEntities, EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I[] updateEntities, EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
