
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
		
[ServiceKnownType(typeof(EntityObject_BGT_D_ACCOUNT_ITEM))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_ITEM))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_ACCOUNT))]	
	public partial interface ServiceContract_BGT_D_BUDGET_ACCOUNT: IServiceContractLocal<EntityObject_BGT_D_BUDGET_ACCOUNT, CauseObject_BGT_D_BUDGET_ACCOUNT>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_BUDGET_ACCOUNT obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_BUDGET_ACCOUNT obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_ACCOUNT obj);
		[OperationContract]
		EntityObject_BGT_D_BUDGET_ACCOUNT Get(EntityObject_BGT_D_BUDGET_ACCOUNT obj);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_ACCOUNT[] List();
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_ACCOUNT[] Query(CauseObject_BGT_D_BUDGET_ACCOUNT cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_ACCOUNT cause);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_ACCOUNT[] Query(CauseObject_BGT_D_BUDGET_ACCOUNT cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_ACCOUNT[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_ACCOUNT[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_ACCOUNT[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_ACCOUNT obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_ACCOUNT obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_ACCOUNT obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_ACCOUNT obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_ACCOUNT obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_ACCOUNT obj);
        [OperationContract]
        EntityObject_BGT_D_BUDGET_ACCOUNT Load(string id , out EntityObject_BGT_D_ACCOUNT_ITEM account_item_id, out EntityObject_BGT_D_BUDGET_ITEM budget_item_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_ACCOUNT[] saveEntities, EntityObject_BGT_D_BUDGET_ACCOUNT[] updateEntities, EntityObject_BGT_D_BUDGET_ACCOUNT[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_BGT_D_BUDGET_ACCOUNT saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_BGT_D_BUDGET_ACCOUNT deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_ACCOUNT updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
