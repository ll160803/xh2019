
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
		
[ServiceKnownType(typeof(EntityObject_BGT_B_CPN_PLAN_YEAR))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_PLAN_ITEM))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_CPN_PLAN_YEAR_D))]	
	public partial interface ServiceContract_BGT_B_CPN_PLAN_YEAR_D: IServiceContractLocal<EntityObject_BGT_B_CPN_PLAN_YEAR_D, CauseObject_BGT_B_CPN_PLAN_YEAR_D>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_CPN_PLAN_YEAR_D obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_CPN_PLAN_YEAR_D obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_CPN_PLAN_YEAR_D obj);
		[OperationContract]
		EntityObject_BGT_B_CPN_PLAN_YEAR_D Get(EntityObject_BGT_B_CPN_PLAN_YEAR_D obj);
		[OperationContract]
		DisplayObject_BGT_B_CPN_PLAN_YEAR_D[] List();
		[OperationContract]
		DisplayObject_BGT_B_CPN_PLAN_YEAR_D[] Query(CauseObject_BGT_B_CPN_PLAN_YEAR_D cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_CPN_PLAN_YEAR_D cause);
		[OperationContract]
		DisplayObject_BGT_B_CPN_PLAN_YEAR_D[] Query(CauseObject_BGT_B_CPN_PLAN_YEAR_D cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_CPN_PLAN_YEAR_D[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_CPN_PLAN_YEAR_D[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_CPN_PLAN_YEAR_D[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_CPN_PLAN_YEAR_D obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_CPN_PLAN_YEAR_D obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_CPN_PLAN_YEAR_D obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_CPN_PLAN_YEAR_D obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_CPN_PLAN_YEAR_D obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_CPN_PLAN_YEAR_D obj);
        [OperationContract]
        EntityObject_BGT_B_CPN_PLAN_YEAR_D Load(string id , out EntityObject_BGT_B_CPN_PLAN_YEAR base_id, out EntityObject_BGT_D_PLAN_ITEM item_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_PLAN_YEAR_D[] saveEntities, EntityObject_BGT_B_CPN_PLAN_YEAR_D[] updateEntities, EntityObject_BGT_B_CPN_PLAN_YEAR_D[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_BGT_B_CPN_PLAN_YEAR_D saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_BGT_B_CPN_PLAN_YEAR_D deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_PLAN_YEAR_D updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
