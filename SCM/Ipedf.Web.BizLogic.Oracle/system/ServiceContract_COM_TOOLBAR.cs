
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
	[ServiceKnownType(typeof(EntityObject_COM_TOOLBAR))]	
	public partial interface ServiceContract_COM_TOOLBAR: IServiceContractLocal<EntityObject_COM_TOOLBAR, CauseObject_COM_TOOLBAR>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_TOOLBAR obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_TOOLBAR obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_TOOLBAR obj);
		[OperationContract]
		EntityObject_COM_TOOLBAR Get(EntityObject_COM_TOOLBAR obj);
		[OperationContract]
		DisplayObject_COM_TOOLBAR[] List();
		[OperationContract]
		DisplayObject_COM_TOOLBAR[] Query(CauseObject_COM_TOOLBAR cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_TOOLBAR cause);
		[OperationContract]
		DisplayObject_COM_TOOLBAR[] Query(CauseObject_COM_TOOLBAR cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_TOOLBAR[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_TOOLBAR[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_TOOLBAR[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_TOOLBAR obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_TOOLBAR obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_TOOLBAR obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_TOOLBAR obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_TOOLBAR obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_TOOLBAR obj);
        [OperationContract]
        EntityObject_COM_TOOLBAR Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_COM_TOOLBAR[] saveEntities, EntityObject_COM_TOOLBAR[] updateEntities, EntityObject_COM_TOOLBAR[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_COM_TOOLBAR saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_COM_TOOLBAR deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_COM_TOOLBAR updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
