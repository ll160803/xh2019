
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
	[ServiceKnownType(typeof(EntityObject_COM_STRATEGY))]	
	public partial interface ServiceContract_COM_STRATEGY: IServiceContractLocal<EntityObject_COM_STRATEGY, CauseObject_COM_STRATEGY>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_STRATEGY obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_STRATEGY obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_STRATEGY obj);
		[OperationContract]
		EntityObject_COM_STRATEGY Get(EntityObject_COM_STRATEGY obj);
		[OperationContract]
		DisplayObject_COM_STRATEGY[] List();
		[OperationContract]
		DisplayObject_COM_STRATEGY[] Query(CauseObject_COM_STRATEGY cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_STRATEGY cause);
		[OperationContract]
		DisplayObject_COM_STRATEGY[] Query(CauseObject_COM_STRATEGY cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_STRATEGY[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_STRATEGY[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_STRATEGY[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_STRATEGY obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_STRATEGY obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_STRATEGY obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_STRATEGY obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_STRATEGY obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_STRATEGY obj);
        [OperationContract]
        EntityObject_COM_STRATEGY Load(string id );
        [OperationContract]
        void CommitUpdate(EntityObject_COM_STRATEGY[] saveEntities, EntityObject_COM_STRATEGY[] updateEntities, EntityObject_COM_STRATEGY[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_COM_STRATEGY saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_COM_STRATEGY deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_STRATEGY updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
