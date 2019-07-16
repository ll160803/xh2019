﻿#define NESTING
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
    [ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_MON_ADJUST_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]	
[ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_ADJUST))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_MON_ADJUST))]	
	public partial interface ServiceContract_BGT_B_DEPT_MON_ADJUST: IServiceContractLocal<EntityObject_BGT_B_DEPT_MON_ADJUST, CauseObject_BGT_B_DEPT_MON_ADJUST>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_DEPT_MON_ADJUST obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_DEPT_MON_ADJUST obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_DEPT_MON_ADJUST obj);
		[OperationContract]
		EntityObject_BGT_B_DEPT_MON_ADJUST Get(EntityObject_BGT_B_DEPT_MON_ADJUST obj);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_MON_ADJUST[] List();
		[OperationContract]
		DisplayObject_BGT_B_DEPT_MON_ADJUST[] Query(CauseObject_BGT_B_DEPT_MON_ADJUST cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_DEPT_MON_ADJUST cause);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_MON_ADJUST[] Query(CauseObject_BGT_B_DEPT_MON_ADJUST cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_DEPT_MON_ADJUST[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_DEPT_MON_ADJUST[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_DEPT_MON_ADJUST[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_DEPT_MON_ADJUST obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_DEPT_MON_ADJUST obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_DEPT_MON_ADJUST obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_DEPT_MON_ADJUST obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_DEPT_MON_ADJUST obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_DEPT_MON_ADJUST obj);
        [OperationContract]
        EntityObject_BGT_B_DEPT_MON_ADJUST Load(string id , out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id, out EntityObject_BGT_B_BUDGET_ADJUST adjust_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_MON_ADJUST[] saveEntities, EntityObject_BGT_B_DEPT_MON_ADJUST[] updateEntities, EntityObject_BGT_B_DEPT_MON_ADJUST[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_B_DEPT_MON_ADJUST saveBaseEntity, EntityObject_BGT_B_DEPT_MON_ADJUST_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_DEPT_MON_ADJUST deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_MON_ADJUST updateBaseEntity, EntityObject_BGT_B_DEPT_MON_ADJUST_D[] saveDetailEntities, EntityObject_BGT_B_DEPT_MON_ADJUST_D[] updateDetailEntities, EntityObject_BGT_B_DEPT_MON_ADJUST_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
