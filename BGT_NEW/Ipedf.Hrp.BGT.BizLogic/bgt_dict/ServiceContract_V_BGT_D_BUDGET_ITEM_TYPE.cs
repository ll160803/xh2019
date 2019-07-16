
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
	
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE))]	
	public partial interface ServiceContract_V_BGT_D_BUDGET_ITEM_TYPE: IServiceContractLocal<EntityObject_V_BGT_D_BUDGET_ITEM_TYPE, CauseObject_V_BGT_D_BUDGET_ITEM_TYPE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE obj);
		[OperationContract]
		EntityObject_V_BGT_D_BUDGET_ITEM_TYPE Get(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE obj);
		[OperationContract]
		DisplayObject_V_BGT_D_BUDGET_ITEM_TYPE[] List();
		[OperationContract]
		DisplayObject_V_BGT_D_BUDGET_ITEM_TYPE[] Query(CauseObject_V_BGT_D_BUDGET_ITEM_TYPE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_BGT_D_BUDGET_ITEM_TYPE cause);
		[OperationContract]
		DisplayObject_V_BGT_D_BUDGET_ITEM_TYPE[] Query(CauseObject_V_BGT_D_BUDGET_ITEM_TYPE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE obj);
        [OperationContract]
        EntityObject_V_BGT_D_BUDGET_ITEM_TYPE Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE[] saveEntities, EntityObject_V_BGT_D_BUDGET_ITEM_TYPE[] updateEntities, EntityObject_V_BGT_D_BUDGET_ITEM_TYPE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_D_BUDGET_ITEM_TYPE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
