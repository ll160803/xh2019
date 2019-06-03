
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
	[ServiceKnownType(typeof(EntityObject_SCM_D_REPORT))]	
	public partial interface ServiceContract_SCM_D_REPORT: IServiceContractLocal<EntityObject_SCM_D_REPORT, CauseObject_SCM_D_REPORT>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_D_REPORT obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_D_REPORT obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_D_REPORT obj);
		[OperationContract]
		EntityObject_SCM_D_REPORT Get(EntityObject_SCM_D_REPORT obj);
		[OperationContract]
		DisplayObject_SCM_D_REPORT[] List();
		[OperationContract]
		DisplayObject_SCM_D_REPORT[] Query(CauseObject_SCM_D_REPORT cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_D_REPORT cause);
		[OperationContract]
		DisplayObject_SCM_D_REPORT[] Query(CauseObject_SCM_D_REPORT cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_D_REPORT[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_D_REPORT[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_D_REPORT[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_D_REPORT obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_D_REPORT obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_D_REPORT obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_D_REPORT obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_D_REPORT obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_D_REPORT obj);
        [OperationContract]
        EntityObject_SCM_D_REPORT Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_REPORT[] saveEntities, EntityObject_SCM_D_REPORT[] updateEntities, EntityObject_SCM_D_REPORT[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_D_REPORT saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_D_REPORT deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_REPORT updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
