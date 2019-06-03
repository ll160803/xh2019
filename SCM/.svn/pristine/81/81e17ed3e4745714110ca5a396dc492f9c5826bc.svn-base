
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
	[ServiceKnownType(typeof(EntityObject_SCM_D_SENDDEPART))]	
	public partial interface ServiceContract_SCM_D_SENDDEPART: IServiceContractLocal<EntityObject_SCM_D_SENDDEPART, CauseObject_SCM_D_SENDDEPART>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_D_SENDDEPART obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_D_SENDDEPART obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_D_SENDDEPART obj);
		[OperationContract]
		EntityObject_SCM_D_SENDDEPART Get(EntityObject_SCM_D_SENDDEPART obj);
		[OperationContract]
		DisplayObject_SCM_D_SENDDEPART[] List();
		[OperationContract]
		DisplayObject_SCM_D_SENDDEPART[] Query(CauseObject_SCM_D_SENDDEPART cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_D_SENDDEPART cause);
		[OperationContract]
		DisplayObject_SCM_D_SENDDEPART[] Query(CauseObject_SCM_D_SENDDEPART cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_D_SENDDEPART[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_D_SENDDEPART[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_D_SENDDEPART[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_D_SENDDEPART obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_D_SENDDEPART obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_D_SENDDEPART obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_D_SENDDEPART obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_D_SENDDEPART obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_D_SENDDEPART obj);
        [OperationContract]
        EntityObject_SCM_D_SENDDEPART Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_SENDDEPART[] saveEntities, EntityObject_SCM_D_SENDDEPART[] updateEntities, EntityObject_SCM_D_SENDDEPART[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_D_SENDDEPART saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_D_SENDDEPART deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_SENDDEPART updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
