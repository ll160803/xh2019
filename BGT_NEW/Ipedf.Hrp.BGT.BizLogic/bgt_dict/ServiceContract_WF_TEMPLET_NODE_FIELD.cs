
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
		
[ServiceKnownType(typeof(EntityObject_PAAS_OBJECT_FIELD))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_WF_TEMPLET_NODE_FIELD))]	
	public partial interface ServiceContract_WF_TEMPLET_NODE_FIELD: IServiceContractLocal<EntityObject_WF_TEMPLET_NODE_FIELD, CauseObject_WF_TEMPLET_NODE_FIELD>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_WF_TEMPLET_NODE_FIELD obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_WF_TEMPLET_NODE_FIELD obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_WF_TEMPLET_NODE_FIELD obj);
		[OperationContract]
		EntityObject_WF_TEMPLET_NODE_FIELD Get(EntityObject_WF_TEMPLET_NODE_FIELD obj);
		[OperationContract]
		DisplayObject_WF_TEMPLET_NODE_FIELD[] List();
		[OperationContract]
		DisplayObject_WF_TEMPLET_NODE_FIELD[] Query(CauseObject_WF_TEMPLET_NODE_FIELD cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_WF_TEMPLET_NODE_FIELD cause);
		[OperationContract]
		DisplayObject_WF_TEMPLET_NODE_FIELD[] Query(CauseObject_WF_TEMPLET_NODE_FIELD cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_WF_TEMPLET_NODE_FIELD[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_WF_TEMPLET_NODE_FIELD[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_WF_TEMPLET_NODE_FIELD[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_WF_TEMPLET_NODE_FIELD obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_WF_TEMPLET_NODE_FIELD obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_WF_TEMPLET_NODE_FIELD obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_WF_TEMPLET_NODE_FIELD obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_WF_TEMPLET_NODE_FIELD obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_WF_TEMPLET_NODE_FIELD obj);
        [OperationContract]
        EntityObject_WF_TEMPLET_NODE_FIELD Load(string id , out EntityObject_PAAS_OBJECT_FIELD field_id);
        [OperationContract]
        void CommitUpdate(EntityObject_WF_TEMPLET_NODE_FIELD[] saveEntities, EntityObject_WF_TEMPLET_NODE_FIELD[] updateEntities, EntityObject_WF_TEMPLET_NODE_FIELD[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_WF_TEMPLET_NODE_FIELD saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_WF_TEMPLET_NODE_FIELD deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_WF_TEMPLET_NODE_FIELD updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
