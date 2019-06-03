
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
	[ServiceKnownType(typeof(EntityObject_V_SCM_D_SUPPLYPLAN_MATER))]	
	public partial interface ServiceContract_V_SCM_D_SUPPLYPLAN_MATER: IServiceContractLocal<EntityObject_V_SCM_D_SUPPLYPLAN_MATER, CauseObject_V_SCM_D_SUPPLYPLAN_MATER>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj);
		[OperationContract]
		EntityObject_V_SCM_D_SUPPLYPLAN_MATER Get(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj);
		[OperationContract]
		DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[] List();
		[OperationContract]
		DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[] Query(CauseObject_V_SCM_D_SUPPLYPLAN_MATER cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_SCM_D_SUPPLYPLAN_MATER cause);
		[OperationContract]
		DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[] Query(CauseObject_V_SCM_D_SUPPLYPLAN_MATER cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_SCM_D_SUPPLYPLAN_MATER[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_SCM_D_SUPPLYPLAN_MATER[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_SCM_D_SUPPLYPLAN_MATER[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj);
        [OperationContract]
        EntityObject_V_SCM_D_SUPPLYPLAN_MATER Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_D_SUPPLYPLAN_MATER[] saveEntities, EntityObject_V_SCM_D_SUPPLYPLAN_MATER[] updateEntities, EntityObject_V_SCM_D_SUPPLYPLAN_MATER[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_SCM_D_SUPPLYPLAN_MATER saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_SCM_D_SUPPLYPLAN_MATER deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_D_SUPPLYPLAN_MATER updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
