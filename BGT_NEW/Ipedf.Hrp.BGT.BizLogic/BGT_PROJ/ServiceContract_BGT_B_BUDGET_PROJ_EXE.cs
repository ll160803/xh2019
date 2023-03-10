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
    [ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_PROJ_EXE_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_PROJ))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_PROJ_EXE))]	
	public partial interface ServiceContract_BGT_B_BUDGET_PROJ_EXE: IServiceContractLocal<EntityObject_BGT_B_BUDGET_PROJ_EXE, CauseObject_BGT_B_BUDGET_PROJ_EXE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_BUDGET_PROJ_EXE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_BUDGET_PROJ_EXE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_BUDGET_PROJ_EXE obj);
		[OperationContract]
		EntityObject_BGT_B_BUDGET_PROJ_EXE Get(EntityObject_BGT_B_BUDGET_PROJ_EXE obj);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_PROJ_EXE[] List();
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_PROJ_EXE[] Query(CauseObject_BGT_B_BUDGET_PROJ_EXE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_BUDGET_PROJ_EXE cause);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_PROJ_EXE[] Query(CauseObject_BGT_B_BUDGET_PROJ_EXE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_BUDGET_PROJ_EXE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_BUDGET_PROJ_EXE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_BUDGET_PROJ_EXE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_BUDGET_PROJ_EXE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_BUDGET_PROJ_EXE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_BUDGET_PROJ_EXE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_BUDGET_PROJ_EXE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_BUDGET_PROJ_EXE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_BUDGET_PROJ_EXE obj);
        [OperationContract]
        EntityObject_BGT_B_BUDGET_PROJ_EXE Load(string id , out EntityObject_BGT_B_BUDGET_PROJ project_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_PROJ_EXE[] saveEntities, EntityObject_BGT_B_BUDGET_PROJ_EXE[] updateEntities, EntityObject_BGT_B_BUDGET_PROJ_EXE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_B_BUDGET_PROJ_EXE saveBaseEntity, EntityObject_BGT_B_BUDGET_PROJ_EXE_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_BUDGET_PROJ_EXE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_PROJ_EXE updateBaseEntity, EntityObject_BGT_B_BUDGET_PROJ_EXE_D[] saveDetailEntities, EntityObject_BGT_B_BUDGET_PROJ_EXE_D[] updateDetailEntities, EntityObject_BGT_B_BUDGET_PROJ_EXE_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
