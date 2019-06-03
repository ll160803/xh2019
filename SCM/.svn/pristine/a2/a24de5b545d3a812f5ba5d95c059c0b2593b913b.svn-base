
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
	[ServiceKnownType(typeof(EntityObject_SCM_D_MATER))]	
	public partial interface ServiceContract_SCM_D_MATER: IServiceContractLocal<EntityObject_SCM_D_MATER, CauseObject_SCM_D_MATER>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_D_MATER obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_D_MATER obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_D_MATER obj);
		[OperationContract]
		EntityObject_SCM_D_MATER Get(EntityObject_SCM_D_MATER obj);
		[OperationContract]
		DisplayObject_SCM_D_MATER[] List();
		[OperationContract]
		DisplayObject_SCM_D_MATER[] Query(CauseObject_SCM_D_MATER cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_D_MATER cause);
		[OperationContract]
		DisplayObject_SCM_D_MATER[] Query(CauseObject_SCM_D_MATER cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_D_MATER[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_D_MATER[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_D_MATER[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_D_MATER obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_D_MATER obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_D_MATER obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_D_MATER obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_D_MATER obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_D_MATER obj);
        [OperationContract]
        EntityObject_SCM_D_MATER Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_MATER[] saveEntities, EntityObject_SCM_D_MATER[] updateEntities, EntityObject_SCM_D_MATER[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_D_MATER saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_D_MATER deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_MATER updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
