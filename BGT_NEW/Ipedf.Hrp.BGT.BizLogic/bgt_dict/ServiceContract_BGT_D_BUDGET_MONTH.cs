
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
	[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_MONTH))]	
	public partial interface ServiceContract_BGT_D_BUDGET_MONTH: IServiceContractLocal<EntityObject_BGT_D_BUDGET_MONTH, CauseObject_BGT_D_BUDGET_MONTH>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_BUDGET_MONTH obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_BUDGET_MONTH obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_MONTH obj);
		[OperationContract]
		EntityObject_BGT_D_BUDGET_MONTH Get(EntityObject_BGT_D_BUDGET_MONTH obj);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_MONTH[] List();
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_MONTH[] Query(CauseObject_BGT_D_BUDGET_MONTH cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_MONTH cause);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_MONTH[] Query(CauseObject_BGT_D_BUDGET_MONTH cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_MONTH[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_MONTH[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_MONTH[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_MONTH obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_MONTH obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_MONTH obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_MONTH obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_MONTH obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_MONTH obj);
        [OperationContract]
        EntityObject_BGT_D_BUDGET_MONTH Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_MONTH[] saveEntities, EntityObject_BGT_D_BUDGET_MONTH[] updateEntities, EntityObject_BGT_D_BUDGET_MONTH[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_BGT_D_BUDGET_MONTH saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_BGT_D_BUDGET_MONTH deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_MONTH updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
