
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
	[ServiceKnownType(typeof(EntityObject_COM_PARAMETER))]	
	public partial interface ServiceContract_COM_PARAMETER: IServiceContractLocal<EntityObject_COM_PARAMETER, CauseObject_COM_PARAMETER>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_PARAMETER obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_PARAMETER obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_PARAMETER obj);
		[OperationContract]
		EntityObject_COM_PARAMETER Get(EntityObject_COM_PARAMETER obj);
		[OperationContract]
		DisplayObject_COM_PARAMETER[] List();
		[OperationContract]
		DisplayObject_COM_PARAMETER[] Query(CauseObject_COM_PARAMETER cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_PARAMETER cause);
		[OperationContract]
		DisplayObject_COM_PARAMETER[] Query(CauseObject_COM_PARAMETER cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_PARAMETER[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_PARAMETER[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_PARAMETER[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_PARAMETER obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_PARAMETER obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_PARAMETER obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_PARAMETER obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_PARAMETER obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_PARAMETER obj);
        [OperationContract]
        EntityObject_COM_PARAMETER Load(string id );
        [OperationContract]
        void CommitUpdate(EntityObject_COM_PARAMETER[] saveEntities, EntityObject_COM_PARAMETER[] updateEntities, EntityObject_COM_PARAMETER[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_COM_PARAMETER saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_COM_PARAMETER deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_PARAMETER updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
