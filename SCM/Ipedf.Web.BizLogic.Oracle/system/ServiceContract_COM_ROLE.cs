
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
	[ServiceKnownType(typeof(EntityObject_COM_ROLE))]	
	public partial interface ServiceContract_COM_ROLE: IServiceContractLocal<EntityObject_COM_ROLE, CauseObject_COM_ROLE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_ROLE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_ROLE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_ROLE obj);
		[OperationContract]
		EntityObject_COM_ROLE Get(EntityObject_COM_ROLE obj);
		[OperationContract]
		DisplayObject_COM_ROLE[] List();
		[OperationContract]
		DisplayObject_COM_ROLE[] Query(CauseObject_COM_ROLE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_ROLE cause);
		[OperationContract]
		DisplayObject_COM_ROLE[] Query(CauseObject_COM_ROLE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_ROLE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_ROLE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_ROLE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_ROLE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_ROLE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_ROLE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_ROLE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_ROLE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_ROLE obj);
        [OperationContract]
        EntityObject_COM_ROLE Load(string id );
        [OperationContract]
        void CommitUpdate(EntityObject_COM_ROLE[] saveEntities, EntityObject_COM_ROLE[] updateEntities, EntityObject_COM_ROLE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_COM_ROLE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_COM_ROLE deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_ROLE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
