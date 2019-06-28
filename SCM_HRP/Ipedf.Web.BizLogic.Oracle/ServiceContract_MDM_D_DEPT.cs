
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
	[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]	
	public partial interface ServiceContract_MDM_D_DEPT: IServiceContractLocal<EntityObject_MDM_D_DEPT, CauseObject_MDM_D_DEPT>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MDM_D_DEPT obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MDM_D_DEPT obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MDM_D_DEPT obj);
		[OperationContract]
		EntityObject_MDM_D_DEPT Get(EntityObject_MDM_D_DEPT obj);
		[OperationContract]
		DisplayObject_MDM_D_DEPT[] List();
		[OperationContract]
		DisplayObject_MDM_D_DEPT[] Query(CauseObject_MDM_D_DEPT cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MDM_D_DEPT cause);
		[OperationContract]
		DisplayObject_MDM_D_DEPT[] Query(CauseObject_MDM_D_DEPT cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MDM_D_DEPT[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MDM_D_DEPT[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MDM_D_DEPT[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MDM_D_DEPT obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MDM_D_DEPT obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MDM_D_DEPT obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MDM_D_DEPT obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MDM_D_DEPT obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MDM_D_DEPT obj);
        [OperationContract]
        EntityObject_MDM_D_DEPT Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MDM_D_DEPT[] saveEntities, EntityObject_MDM_D_DEPT[] updateEntities, EntityObject_MDM_D_DEPT[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_MDM_D_DEPT saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_MDM_D_DEPT deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_MDM_D_DEPT updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
