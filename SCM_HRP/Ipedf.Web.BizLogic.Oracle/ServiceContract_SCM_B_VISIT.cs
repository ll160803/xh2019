
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
	[ServiceKnownType(typeof(EntityObject_SCM_B_VISIT))]	
	public partial interface ServiceContract_SCM_B_VISIT: IServiceContractLocal<EntityObject_SCM_B_VISIT, CauseObject_SCM_B_VISIT>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_B_VISIT obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_B_VISIT obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_B_VISIT obj);
		[OperationContract]
		EntityObject_SCM_B_VISIT Get(EntityObject_SCM_B_VISIT obj);
		[OperationContract]
		DisplayObject_SCM_B_VISIT[] List();
		[OperationContract]
		DisplayObject_SCM_B_VISIT[] Query(CauseObject_SCM_B_VISIT cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_B_VISIT cause);
		[OperationContract]
		DisplayObject_SCM_B_VISIT[] Query(CauseObject_SCM_B_VISIT cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_B_VISIT[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_B_VISIT[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_B_VISIT[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_B_VISIT obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_B_VISIT obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_B_VISIT obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_B_VISIT obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_B_VISIT obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_B_VISIT obj);
        [OperationContract]
        EntityObject_SCM_B_VISIT Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_VISIT[] saveEntities, EntityObject_SCM_B_VISIT[] updateEntities, EntityObject_SCM_B_VISIT[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_B_VISIT saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_B_VISIT deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_VISIT updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
