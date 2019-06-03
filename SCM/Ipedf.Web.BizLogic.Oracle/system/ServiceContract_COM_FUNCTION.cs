
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
		
[ServiceKnownType(typeof(EntityObject_COM_MODULE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_COM_FUNCTION))]	
	public partial interface ServiceContract_COM_FUNCTION: IServiceContractLocal<EntityObject_COM_FUNCTION, CauseObject_COM_FUNCTION>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_FUNCTION obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_FUNCTION obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_FUNCTION obj);
		[OperationContract]
		EntityObject_COM_FUNCTION Get(EntityObject_COM_FUNCTION obj);
		[OperationContract]
		DisplayObject_COM_FUNCTION[] List();
		[OperationContract]
		DisplayObject_COM_FUNCTION[] Query(CauseObject_COM_FUNCTION cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_FUNCTION cause);
		[OperationContract]
		DisplayObject_COM_FUNCTION[] Query(CauseObject_COM_FUNCTION cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_FUNCTION[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_FUNCTION[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_FUNCTION[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_FUNCTION obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_FUNCTION obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_FUNCTION obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_FUNCTION obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_FUNCTION obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_FUNCTION obj);
        [OperationContract]
        EntityObject_COM_FUNCTION Load(string id , out EntityObject_COM_MODULE module_id);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_FUNCTION[] saveEntities, EntityObject_COM_FUNCTION[] updateEntities, EntityObject_COM_FUNCTION[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_COM_FUNCTION saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_COM_FUNCTION deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_FUNCTION updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
