
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
		
[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_SCM_D_PURCHARSEPLAN))]	
	public partial interface ServiceContract_SCM_D_PURCHARSEPLAN: IServiceContractLocal<EntityObject_SCM_D_PURCHARSEPLAN, CauseObject_SCM_D_PURCHARSEPLAN>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_D_PURCHARSEPLAN obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_D_PURCHARSEPLAN obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_D_PURCHARSEPLAN obj);
		[OperationContract]
		EntityObject_SCM_D_PURCHARSEPLAN Get(EntityObject_SCM_D_PURCHARSEPLAN obj);
		[OperationContract]
		DisplayObject_SCM_D_PURCHARSEPLAN[] List();
		[OperationContract]
		DisplayObject_SCM_D_PURCHARSEPLAN[] Query(CauseObject_SCM_D_PURCHARSEPLAN cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_D_PURCHARSEPLAN cause);
		[OperationContract]
		DisplayObject_SCM_D_PURCHARSEPLAN[] Query(CauseObject_SCM_D_PURCHARSEPLAN cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_D_PURCHARSEPLAN[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_D_PURCHARSEPLAN[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_D_PURCHARSEPLAN[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_D_PURCHARSEPLAN obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_D_PURCHARSEPLAN obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_D_PURCHARSEPLAN obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_D_PURCHARSEPLAN obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_D_PURCHARSEPLAN obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_D_PURCHARSEPLAN obj);
        [OperationContract]
        EntityObject_SCM_D_PURCHARSEPLAN Load(string id , out EntityObject_MDM_D_DEPT lifnr);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_PURCHARSEPLAN[] saveEntities, EntityObject_SCM_D_PURCHARSEPLAN[] updateEntities, EntityObject_SCM_D_PURCHARSEPLAN[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_D_PURCHARSEPLAN saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_D_PURCHARSEPLAN deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_PURCHARSEPLAN updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
