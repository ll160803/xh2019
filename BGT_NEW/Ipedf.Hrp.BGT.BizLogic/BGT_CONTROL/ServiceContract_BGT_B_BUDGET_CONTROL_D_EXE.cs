
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
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_ITEM))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE))]	
	public partial interface ServiceContract_BGT_B_BUDGET_CONTROL_D_EXE: IServiceContractLocal<EntityObject_BGT_B_BUDGET_CONTROL_D_EXE, CauseObject_BGT_B_BUDGET_CONTROL_D_EXE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj);
		[OperationContract]
		EntityObject_BGT_B_BUDGET_CONTROL_D_EXE Get(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] List();
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] Query(CauseObject_BGT_B_BUDGET_CONTROL_D_EXE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_BUDGET_CONTROL_D_EXE cause);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] Query(CauseObject_BGT_B_BUDGET_CONTROL_D_EXE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj);
        [OperationContract]
        EntityObject_BGT_B_BUDGET_CONTROL_D_EXE Load(string id , out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id, out EntityObject_BGT_D_BUDGET_ITEM item_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE[] saveEntities, EntityObject_BGT_B_BUDGET_CONTROL_D_EXE[] updateEntities, EntityObject_BGT_B_BUDGET_CONTROL_D_EXE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
