
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
	[ServiceKnownType(typeof(EntityObject_V_SCM_D_SUPPLIERPLAN))]	
	public partial interface ServiceContract_V_SCM_D_SUPPLIERPLAN: IServiceContractLocal<EntityObject_V_SCM_D_SUPPLIERPLAN, CauseObject_V_SCM_D_SUPPLIERPLAN>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_SCM_D_SUPPLIERPLAN obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_SCM_D_SUPPLIERPLAN obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_SCM_D_SUPPLIERPLAN obj);
		[OperationContract]
		EntityObject_V_SCM_D_SUPPLIERPLAN Get(EntityObject_V_SCM_D_SUPPLIERPLAN obj);
		[OperationContract]
		DisplayObject_V_SCM_D_SUPPLIERPLAN[] List();
		[OperationContract]
		DisplayObject_V_SCM_D_SUPPLIERPLAN[] Query(CauseObject_V_SCM_D_SUPPLIERPLAN cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_SCM_D_SUPPLIERPLAN cause);
		[OperationContract]
		DisplayObject_V_SCM_D_SUPPLIERPLAN[] Query(CauseObject_V_SCM_D_SUPPLIERPLAN cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_SCM_D_SUPPLIERPLAN[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_SCM_D_SUPPLIERPLAN[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_SCM_D_SUPPLIERPLAN[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_SCM_D_SUPPLIERPLAN obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_SCM_D_SUPPLIERPLAN obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_SCM_D_SUPPLIERPLAN obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_SCM_D_SUPPLIERPLAN obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_SCM_D_SUPPLIERPLAN obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_SCM_D_SUPPLIERPLAN obj);
        [OperationContract]
        EntityObject_V_SCM_D_SUPPLIERPLAN Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_D_SUPPLIERPLAN[] saveEntities, EntityObject_V_SCM_D_SUPPLIERPLAN[] updateEntities, EntityObject_V_SCM_D_SUPPLIERPLAN[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_SCM_D_SUPPLIERPLAN saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_SCM_D_SUPPLIERPLAN deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_D_SUPPLIERPLAN updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
