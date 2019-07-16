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
    [ServiceKnownType(typeof(EntityObject_BGT_B_CPN_INC_PERSON_FEE_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_CPN_INC_PERSON_FEE))]	
	public partial interface ServiceContract_BGT_B_CPN_INC_PERSON_FEE: IServiceContractLocal<EntityObject_BGT_B_CPN_INC_PERSON_FEE, CauseObject_BGT_B_CPN_INC_PERSON_FEE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_CPN_INC_PERSON_FEE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_CPN_INC_PERSON_FEE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_CPN_INC_PERSON_FEE obj);
		[OperationContract]
		EntityObject_BGT_B_CPN_INC_PERSON_FEE Get(EntityObject_BGT_B_CPN_INC_PERSON_FEE obj);
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_PERSON_FEE[] List();
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_PERSON_FEE[] Query(CauseObject_BGT_B_CPN_INC_PERSON_FEE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_CPN_INC_PERSON_FEE cause);
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_PERSON_FEE[] Query(CauseObject_BGT_B_CPN_INC_PERSON_FEE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_CPN_INC_PERSON_FEE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_CPN_INC_PERSON_FEE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_CPN_INC_PERSON_FEE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_CPN_INC_PERSON_FEE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_CPN_INC_PERSON_FEE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_CPN_INC_PERSON_FEE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_CPN_INC_PERSON_FEE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_CPN_INC_PERSON_FEE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_CPN_INC_PERSON_FEE obj);
        [OperationContract]
        EntityObject_BGT_B_CPN_INC_PERSON_FEE Load(string id , out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_INC_PERSON_FEE[] saveEntities, EntityObject_BGT_B_CPN_INC_PERSON_FEE[] updateEntities, EntityObject_BGT_B_CPN_INC_PERSON_FEE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_B_CPN_INC_PERSON_FEE saveBaseEntity, EntityObject_BGT_B_CPN_INC_PERSON_FEE_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_CPN_INC_PERSON_FEE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_INC_PERSON_FEE updateBaseEntity, EntityObject_BGT_B_CPN_INC_PERSON_FEE_D[] saveDetailEntities, EntityObject_BGT_B_CPN_INC_PERSON_FEE_D[] updateDetailEntities, EntityObject_BGT_B_CPN_INC_PERSON_FEE_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
