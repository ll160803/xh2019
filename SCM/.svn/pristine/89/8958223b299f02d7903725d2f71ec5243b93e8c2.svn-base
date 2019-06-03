
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
	[ServiceKnownType(typeof(EntityObject_COM_CODE_DETAIL))]	
	public partial interface ServiceContract_COM_CODE_DETAIL: IServiceContractLocal<EntityObject_COM_CODE_DETAIL, CauseObject_COM_CODE_DETAIL>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_CODE_DETAIL obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_CODE_DETAIL obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_CODE_DETAIL obj);
		[OperationContract]
		EntityObject_COM_CODE_DETAIL Get(EntityObject_COM_CODE_DETAIL obj);
		[OperationContract]
		DisplayObject_COM_CODE_DETAIL[] List();
		[OperationContract]
		DisplayObject_COM_CODE_DETAIL[] Query(CauseObject_COM_CODE_DETAIL cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_CODE_DETAIL cause);
		[OperationContract]
		DisplayObject_COM_CODE_DETAIL[] Query(CauseObject_COM_CODE_DETAIL cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_CODE_DETAIL[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_CODE_DETAIL[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_CODE_DETAIL[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_CODE_DETAIL obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_CODE_DETAIL obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_CODE_DETAIL obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_CODE_DETAIL obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_CODE_DETAIL obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_CODE_DETAIL obj);
        [OperationContract]
        EntityObject_COM_CODE_DETAIL Load(string id );
        [OperationContract]
        void CommitUpdate(EntityObject_COM_CODE_DETAIL[] saveEntities, EntityObject_COM_CODE_DETAIL[] updateEntities, EntityObject_COM_CODE_DETAIL[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_COM_CODE_DETAIL saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_COM_CODE_DETAIL deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_CODE_DETAIL updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
