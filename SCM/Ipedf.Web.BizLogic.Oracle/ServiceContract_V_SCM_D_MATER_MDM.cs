
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
	[ServiceKnownType(typeof(EntityObject_V_SCM_D_MATER_MDM))]	
	public partial interface ServiceContract_V_SCM_D_MATER_MDM: IServiceContractLocal<EntityObject_V_SCM_D_MATER_MDM, CauseObject_V_SCM_D_MATER_MDM>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_SCM_D_MATER_MDM obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_SCM_D_MATER_MDM obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_SCM_D_MATER_MDM obj);
		[OperationContract]
		EntityObject_V_SCM_D_MATER_MDM Get(EntityObject_V_SCM_D_MATER_MDM obj);
		[OperationContract]
		DisplayObject_V_SCM_D_MATER_MDM[] List();
		[OperationContract]
		DisplayObject_V_SCM_D_MATER_MDM[] Query(CauseObject_V_SCM_D_MATER_MDM cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_SCM_D_MATER_MDM cause);
		[OperationContract]
		DisplayObject_V_SCM_D_MATER_MDM[] Query(CauseObject_V_SCM_D_MATER_MDM cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_SCM_D_MATER_MDM[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_SCM_D_MATER_MDM[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_SCM_D_MATER_MDM[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_SCM_D_MATER_MDM obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_SCM_D_MATER_MDM obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_SCM_D_MATER_MDM obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_SCM_D_MATER_MDM obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_SCM_D_MATER_MDM obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_SCM_D_MATER_MDM obj);
        [OperationContract]
        EntityObject_V_SCM_D_MATER_MDM Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_D_MATER_MDM[] saveEntities, EntityObject_V_SCM_D_MATER_MDM[] updateEntities, EntityObject_V_SCM_D_MATER_MDM[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_SCM_D_MATER_MDM saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_SCM_D_MATER_MDM deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_D_MATER_MDM updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
