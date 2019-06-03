#define NESTING
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
    [ServiceKnownType(typeof(EntityObject_COM_CODE_DETAIL))]
	#endif
	
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_COM_CODE))]	
	public partial interface ServiceContract_COM_CODE: IServiceContractLocal<EntityObject_COM_CODE, CauseObject_COM_CODE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_CODE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_CODE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_CODE obj);
		[OperationContract]
		EntityObject_COM_CODE Get(EntityObject_COM_CODE obj);
		[OperationContract]
		DisplayObject_COM_CODE[] List();
		[OperationContract]
		DisplayObject_COM_CODE[] Query(CauseObject_COM_CODE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_CODE cause);
		[OperationContract]
		DisplayObject_COM_CODE[] Query(CauseObject_COM_CODE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_CODE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_CODE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_CODE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_CODE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_CODE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_CODE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_CODE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_CODE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_CODE obj);
        [OperationContract]
        EntityObject_COM_CODE Load(string id );
        [OperationContract]
        void CommitUpdate(EntityObject_COM_CODE[] saveEntities, EntityObject_COM_CODE[] updateEntities, EntityObject_COM_CODE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_COM_CODE saveBaseEntity, EntityObject_COM_CODE_DETAIL[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_COM_CODE deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_CODE updateBaseEntity, EntityObject_COM_CODE_DETAIL[] saveDetailEntities, EntityObject_COM_CODE_DETAIL[] updateDetailEntities, EntityObject_COM_CODE_DETAIL[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
