
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
		
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_D_PLAN_ITEM))]	
	public partial interface ServiceContract_BGT_D_PLAN_ITEM: IServiceContractLocal<EntityObject_BGT_D_PLAN_ITEM, CauseObject_BGT_D_PLAN_ITEM>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_PLAN_ITEM obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_PLAN_ITEM obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_PLAN_ITEM obj);
		[OperationContract]
		EntityObject_BGT_D_PLAN_ITEM Get(EntityObject_BGT_D_PLAN_ITEM obj);
		[OperationContract]
		DisplayObject_BGT_D_PLAN_ITEM[] List();
		[OperationContract]
		DisplayObject_BGT_D_PLAN_ITEM[] Query(CauseObject_BGT_D_PLAN_ITEM cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_PLAN_ITEM cause);
		[OperationContract]
		DisplayObject_BGT_D_PLAN_ITEM[] Query(CauseObject_BGT_D_PLAN_ITEM cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_PLAN_ITEM[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_PLAN_ITEM[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_PLAN_ITEM[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_PLAN_ITEM obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_PLAN_ITEM obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_PLAN_ITEM obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_PLAN_ITEM obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_PLAN_ITEM obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_PLAN_ITEM obj);
        [OperationContract]
        EntityObject_BGT_D_PLAN_ITEM Load(string id , out EntityObject_COM_TYPE prepare_pattern_id, out EntityObject_COM_TYPE import_type_id, out EntityObject_COM_TYPE advice_classify_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_COM_TYPE item_classify_id, out EntityObject_COM_TYPE data_type_id, out EntityObject_COM_TYPE item_type_id, out EntityObject_COM_TYPE unit_id, out EntityObject_COM_TYPE source_type_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_PLAN_ITEM[] saveEntities, EntityObject_BGT_D_PLAN_ITEM[] updateEntities, EntityObject_BGT_D_PLAN_ITEM[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_BGT_D_PLAN_ITEM saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_BGT_D_PLAN_ITEM deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_PLAN_ITEM updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
