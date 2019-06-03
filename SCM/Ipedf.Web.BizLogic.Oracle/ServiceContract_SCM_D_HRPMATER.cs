
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
	[ServiceKnownType(typeof(EntityObject_SCM_D_HRPMATER))]	
	public partial interface ServiceContract_SCM_D_HRPMATER: IServiceContractLocal<EntityObject_SCM_D_HRPMATER, CauseObject_SCM_D_HRPMATER>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_D_HRPMATER obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_D_HRPMATER obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_D_HRPMATER obj);
		[OperationContract]
		EntityObject_SCM_D_HRPMATER Get(EntityObject_SCM_D_HRPMATER obj);
		[OperationContract]
		DisplayObject_SCM_D_HRPMATER[] List();
		[OperationContract]
		DisplayObject_SCM_D_HRPMATER[] Query(CauseObject_SCM_D_HRPMATER cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_D_HRPMATER cause);
		[OperationContract]
		DisplayObject_SCM_D_HRPMATER[] Query(CauseObject_SCM_D_HRPMATER cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_D_HRPMATER[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_D_HRPMATER[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_D_HRPMATER[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_D_HRPMATER obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_D_HRPMATER obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_D_HRPMATER obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_D_HRPMATER obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_D_HRPMATER obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_D_HRPMATER obj);
        [OperationContract]
        EntityObject_SCM_D_HRPMATER Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_HRPMATER[] saveEntities, EntityObject_SCM_D_HRPMATER[] updateEntities, EntityObject_SCM_D_HRPMATER[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_D_HRPMATER saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_D_HRPMATER deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_HRPMATER updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
