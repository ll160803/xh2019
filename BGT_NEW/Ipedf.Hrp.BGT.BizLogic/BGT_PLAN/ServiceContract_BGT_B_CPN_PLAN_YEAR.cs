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
    [ServiceKnownType(typeof(EntityObject_BGT_B_CPN_PLAN_YEAR_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_T))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_CPN_PLAN_YEAR))]	
	public partial interface ServiceContract_BGT_B_CPN_PLAN_YEAR: IServiceContractLocal<EntityObject_BGT_B_CPN_PLAN_YEAR, CauseObject_BGT_B_CPN_PLAN_YEAR>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_CPN_PLAN_YEAR obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_CPN_PLAN_YEAR obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_CPN_PLAN_YEAR obj);
		[OperationContract]
		EntityObject_BGT_B_CPN_PLAN_YEAR Get(EntityObject_BGT_B_CPN_PLAN_YEAR obj);
		[OperationContract]
		DisplayObject_BGT_B_CPN_PLAN_YEAR[] List();
		[OperationContract]
		DisplayObject_BGT_B_CPN_PLAN_YEAR[] Query(CauseObject_BGT_B_CPN_PLAN_YEAR cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_CPN_PLAN_YEAR cause);
		[OperationContract]
		DisplayObject_BGT_B_CPN_PLAN_YEAR[] Query(CauseObject_BGT_B_CPN_PLAN_YEAR cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_CPN_PLAN_YEAR[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_CPN_PLAN_YEAR[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_CPN_PLAN_YEAR[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_CPN_PLAN_YEAR obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_CPN_PLAN_YEAR obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_CPN_PLAN_YEAR obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_CPN_PLAN_YEAR obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_CPN_PLAN_YEAR obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_CPN_PLAN_YEAR obj);
        [OperationContract]
        EntityObject_BGT_B_CPN_PLAN_YEAR Load(string id , out EntityObject_BGT_D_BUDGET_T templet_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_PLAN_YEAR[] saveEntities, EntityObject_BGT_B_CPN_PLAN_YEAR[] updateEntities, EntityObject_BGT_B_CPN_PLAN_YEAR[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_B_CPN_PLAN_YEAR saveBaseEntity, EntityObject_BGT_B_CPN_PLAN_YEAR_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_CPN_PLAN_YEAR deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_PLAN_YEAR updateBaseEntity, EntityObject_BGT_B_CPN_PLAN_YEAR_D[] saveDetailEntities, EntityObject_BGT_B_CPN_PLAN_YEAR_D[] updateDetailEntities, EntityObject_BGT_B_CPN_PLAN_YEAR_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
