
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
		
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_COM_USER))]	
	public partial interface ServiceContract_COM_USER: IServiceContractLocal<EntityObject_COM_USER, CauseObject_COM_USER>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_USER obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_USER obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_USER obj);
		[OperationContract]
		EntityObject_COM_USER Get(EntityObject_COM_USER obj);
		[OperationContract]
		DisplayObject_COM_USER[] List();
		[OperationContract]
		DisplayObject_COM_USER[] Query(CauseObject_COM_USER cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_USER cause);
		[OperationContract]
		DisplayObject_COM_USER[] Query(CauseObject_COM_USER cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_USER[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_USER[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_USER[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_USER obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_USER obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_USER obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_USER obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_USER obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_USER obj);
        [OperationContract]
        EntityObject_COM_USER Load(string id , out EntityObject_COM_DEPART depart_id);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_USER[] saveEntities, EntityObject_COM_USER[] updateEntities, EntityObject_COM_USER[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_COM_USER saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_COM_USER deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_USER updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
