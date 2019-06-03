
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
		
[ServiceKnownType(typeof(EntityObject_COM_SYSTEM))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_COM_MODULE))]	
	public partial interface ServiceContract_COM_MODULE: IServiceContractLocal<EntityObject_COM_MODULE, CauseObject_COM_MODULE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_MODULE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_MODULE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_MODULE obj);
		[OperationContract]
		EntityObject_COM_MODULE Get(EntityObject_COM_MODULE obj);
		[OperationContract]
		DisplayObject_COM_MODULE[] List();
		[OperationContract]
		DisplayObject_COM_MODULE[] Query(CauseObject_COM_MODULE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_MODULE cause);
		[OperationContract]
		DisplayObject_COM_MODULE[] Query(CauseObject_COM_MODULE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_MODULE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_MODULE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_MODULE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_MODULE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_MODULE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_MODULE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_MODULE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_MODULE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_MODULE obj);
        [OperationContract]
        EntityObject_COM_MODULE Load(string id , out EntityObject_COM_SYSTEM system_id);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_MODULE[] saveEntities, EntityObject_COM_MODULE[] updateEntities, EntityObject_COM_MODULE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_COM_MODULE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_COM_MODULE deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_MODULE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
