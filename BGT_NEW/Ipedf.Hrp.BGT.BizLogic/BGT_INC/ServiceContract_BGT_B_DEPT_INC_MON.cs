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
    [ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_INC_MON_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_INC_MON))]	
	public partial interface ServiceContract_BGT_B_DEPT_INC_MON: IServiceContractLocal<EntityObject_BGT_B_DEPT_INC_MON, CauseObject_BGT_B_DEPT_INC_MON>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_DEPT_INC_MON obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_DEPT_INC_MON obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_DEPT_INC_MON obj);
		[OperationContract]
		EntityObject_BGT_B_DEPT_INC_MON Get(EntityObject_BGT_B_DEPT_INC_MON obj);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_INC_MON[] List();
		[OperationContract]
		DisplayObject_BGT_B_DEPT_INC_MON[] Query(CauseObject_BGT_B_DEPT_INC_MON cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_DEPT_INC_MON cause);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_INC_MON[] Query(CauseObject_BGT_B_DEPT_INC_MON cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_DEPT_INC_MON[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_DEPT_INC_MON[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_DEPT_INC_MON[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_DEPT_INC_MON obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_DEPT_INC_MON obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_DEPT_INC_MON obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_DEPT_INC_MON obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_DEPT_INC_MON obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_DEPT_INC_MON obj);
        [OperationContract]
        EntityObject_BGT_B_DEPT_INC_MON Load(string id , out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_INC_MON[] saveEntities, EntityObject_BGT_B_DEPT_INC_MON[] updateEntities, EntityObject_BGT_B_DEPT_INC_MON[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_B_DEPT_INC_MON saveBaseEntity, EntityObject_BGT_B_DEPT_INC_MON_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_DEPT_INC_MON deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_INC_MON updateBaseEntity, EntityObject_BGT_B_DEPT_INC_MON_D[] saveDetailEntities, EntityObject_BGT_B_DEPT_INC_MON_D[] updateDetailEntities, EntityObject_BGT_B_DEPT_INC_MON_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
