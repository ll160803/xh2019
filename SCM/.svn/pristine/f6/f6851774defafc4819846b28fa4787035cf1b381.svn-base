
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
		
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
	public partial interface ServiceContract_COM_TYPE: IServiceContractLocal<EntityObject_COM_TYPE, CauseObject_COM_TYPE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_TYPE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_TYPE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_TYPE obj);
		[OperationContract]
		EntityObject_COM_TYPE Get(EntityObject_COM_TYPE obj);
		[OperationContract]
		DisplayObject_COM_TYPE[] List();
		[OperationContract]
		DisplayObject_COM_TYPE[] Query(CauseObject_COM_TYPE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_TYPE cause);
		[OperationContract]
		DisplayObject_COM_TYPE[] Query(CauseObject_COM_TYPE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_TYPE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_TYPE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_TYPE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_TYPE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_TYPE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_TYPE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_TYPE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_TYPE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_TYPE obj);
        [OperationContract]
        EntityObject_COM_TYPE Load(string id , out EntityObject_COM_TYPE parent_id);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_TYPE[] saveEntities, EntityObject_COM_TYPE[] updateEntities, EntityObject_COM_TYPE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_COM_TYPE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_COM_TYPE deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_TYPE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
