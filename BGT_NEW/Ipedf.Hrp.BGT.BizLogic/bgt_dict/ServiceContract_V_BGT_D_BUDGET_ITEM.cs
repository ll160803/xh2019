
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
	[ServiceKnownType(typeof(EntityObject_V_BGT_D_BUDGET_ITEM))]	
	public partial interface ServiceContract_V_BGT_D_BUDGET_ITEM: IServiceContractLocal<EntityObject_V_BGT_D_BUDGET_ITEM, CauseObject_V_BGT_D_BUDGET_ITEM>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_BGT_D_BUDGET_ITEM obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_BGT_D_BUDGET_ITEM obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_BGT_D_BUDGET_ITEM obj);
		[OperationContract]
		EntityObject_V_BGT_D_BUDGET_ITEM Get(EntityObject_V_BGT_D_BUDGET_ITEM obj);
		[OperationContract]
		DisplayObject_V_BGT_D_BUDGET_ITEM[] List();
		[OperationContract]
		DisplayObject_V_BGT_D_BUDGET_ITEM[] Query(CauseObject_V_BGT_D_BUDGET_ITEM cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_BGT_D_BUDGET_ITEM cause);
		[OperationContract]
		DisplayObject_V_BGT_D_BUDGET_ITEM[] Query(CauseObject_V_BGT_D_BUDGET_ITEM cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_BGT_D_BUDGET_ITEM[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_BGT_D_BUDGET_ITEM[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_BGT_D_BUDGET_ITEM[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_BGT_D_BUDGET_ITEM obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_BGT_D_BUDGET_ITEM obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_BGT_D_BUDGET_ITEM obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_BGT_D_BUDGET_ITEM obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_BGT_D_BUDGET_ITEM obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_BGT_D_BUDGET_ITEM obj);
        [OperationContract]
        EntityObject_V_BGT_D_BUDGET_ITEM Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_D_BUDGET_ITEM[] saveEntities, EntityObject_V_BGT_D_BUDGET_ITEM[] updateEntities, EntityObject_V_BGT_D_BUDGET_ITEM[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_BGT_D_BUDGET_ITEM saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_BGT_D_BUDGET_ITEM deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_D_BUDGET_ITEM updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
