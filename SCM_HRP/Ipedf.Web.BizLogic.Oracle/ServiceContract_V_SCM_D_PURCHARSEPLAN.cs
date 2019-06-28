
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
	[ServiceKnownType(typeof(EntityObject_V_SCM_D_PURCHARSEPLAN))]	
	public partial interface ServiceContract_V_SCM_D_PURCHARSEPLAN: IServiceContractLocal<EntityObject_V_SCM_D_PURCHARSEPLAN, CauseObject_V_SCM_D_PURCHARSEPLAN>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_SCM_D_PURCHARSEPLAN obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_SCM_D_PURCHARSEPLAN obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_SCM_D_PURCHARSEPLAN obj);
		[OperationContract]
		EntityObject_V_SCM_D_PURCHARSEPLAN Get(EntityObject_V_SCM_D_PURCHARSEPLAN obj);
		[OperationContract]
		DisplayObject_V_SCM_D_PURCHARSEPLAN[] List();
		[OperationContract]
		DisplayObject_V_SCM_D_PURCHARSEPLAN[] Query(CauseObject_V_SCM_D_PURCHARSEPLAN cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_SCM_D_PURCHARSEPLAN cause);
		[OperationContract]
		DisplayObject_V_SCM_D_PURCHARSEPLAN[] Query(CauseObject_V_SCM_D_PURCHARSEPLAN cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_SCM_D_PURCHARSEPLAN[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_SCM_D_PURCHARSEPLAN[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_SCM_D_PURCHARSEPLAN[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_SCM_D_PURCHARSEPLAN obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_SCM_D_PURCHARSEPLAN obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_SCM_D_PURCHARSEPLAN obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_SCM_D_PURCHARSEPLAN obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_SCM_D_PURCHARSEPLAN obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_SCM_D_PURCHARSEPLAN obj);
        [OperationContract]
        EntityObject_V_SCM_D_PURCHARSEPLAN Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_D_PURCHARSEPLAN[] saveEntities, EntityObject_V_SCM_D_PURCHARSEPLAN[] updateEntities, EntityObject_V_SCM_D_PURCHARSEPLAN[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_SCM_D_PURCHARSEPLAN saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_SCM_D_PURCHARSEPLAN deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_D_PURCHARSEPLAN updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
