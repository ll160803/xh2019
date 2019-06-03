
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
	[ServiceKnownType(typeof(EntityObject_COM_DATA))]	
	public partial interface ServiceContract_COM_DATA: IServiceContractLocal<EntityObject_COM_DATA, CauseObject_COM_DATA>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_DATA obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_DATA obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_DATA obj);
		[OperationContract]
		EntityObject_COM_DATA Get(EntityObject_COM_DATA obj);
		[OperationContract]
		DisplayObject_COM_DATA[] List();
		[OperationContract]
		DisplayObject_COM_DATA[] Query(CauseObject_COM_DATA cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_DATA cause);
		[OperationContract]
		DisplayObject_COM_DATA[] Query(CauseObject_COM_DATA cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_DATA[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_DATA[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_DATA[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_DATA obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_DATA obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_DATA obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_DATA obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_DATA obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_DATA obj);
        [OperationContract]
        EntityObject_COM_DATA Load(string id );
        [OperationContract]
        void CommitUpdate(EntityObject_COM_DATA[] saveEntities, EntityObject_COM_DATA[] updateEntities, EntityObject_COM_DATA[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_COM_DATA saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_COM_DATA deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_DATA updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
