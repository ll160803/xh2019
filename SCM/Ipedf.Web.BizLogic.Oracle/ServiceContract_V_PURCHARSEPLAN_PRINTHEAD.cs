
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
	[ServiceKnownType(typeof(EntityObject_V_PURCHARSEPLAN_PRINTHEAD))]	
	public partial interface ServiceContract_V_PURCHARSEPLAN_PRINTHEAD: IServiceContractLocal<EntityObject_V_PURCHARSEPLAN_PRINTHEAD, CauseObject_V_PURCHARSEPLAN_PRINTHEAD>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj);
		[OperationContract]
		EntityObject_V_PURCHARSEPLAN_PRINTHEAD Get(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj);
		[OperationContract]
		DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[] List();
		[OperationContract]
		DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[] Query(CauseObject_V_PURCHARSEPLAN_PRINTHEAD cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_PURCHARSEPLAN_PRINTHEAD cause);
		[OperationContract]
		DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[] Query(CauseObject_V_PURCHARSEPLAN_PRINTHEAD cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_PURCHARSEPLAN_PRINTHEAD[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_PURCHARSEPLAN_PRINTHEAD[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_PURCHARSEPLAN_PRINTHEAD[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj);
        [OperationContract]
        EntityObject_V_PURCHARSEPLAN_PRINTHEAD Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_PURCHARSEPLAN_PRINTHEAD[] saveEntities, EntityObject_V_PURCHARSEPLAN_PRINTHEAD[] updateEntities, EntityObject_V_PURCHARSEPLAN_PRINTHEAD[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_PURCHARSEPLAN_PRINTHEAD saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_PURCHARSEPLAN_PRINTHEAD deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_PURCHARSEPLAN_PRINTHEAD updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
