
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
	[ServiceKnownType(typeof(EntityObject_V_BGT_ADJUST_TO_SAP))]	
	public partial interface ServiceContract_V_BGT_ADJUST_TO_SAP: IServiceContractLocal<EntityObject_V_BGT_ADJUST_TO_SAP, CauseObject_V_BGT_ADJUST_TO_SAP>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_BGT_ADJUST_TO_SAP obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_BGT_ADJUST_TO_SAP obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_BGT_ADJUST_TO_SAP obj);
		[OperationContract]
		EntityObject_V_BGT_ADJUST_TO_SAP Get(EntityObject_V_BGT_ADJUST_TO_SAP obj);
		[OperationContract]
		DisplayObject_V_BGT_ADJUST_TO_SAP[] List();
		[OperationContract]
		DisplayObject_V_BGT_ADJUST_TO_SAP[] Query(CauseObject_V_BGT_ADJUST_TO_SAP cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_BGT_ADJUST_TO_SAP cause);
		[OperationContract]
		DisplayObject_V_BGT_ADJUST_TO_SAP[] Query(CauseObject_V_BGT_ADJUST_TO_SAP cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_BGT_ADJUST_TO_SAP[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_BGT_ADJUST_TO_SAP[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_BGT_ADJUST_TO_SAP[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_BGT_ADJUST_TO_SAP obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_BGT_ADJUST_TO_SAP obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_BGT_ADJUST_TO_SAP obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_BGT_ADJUST_TO_SAP obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_BGT_ADJUST_TO_SAP obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_BGT_ADJUST_TO_SAP obj);
        [OperationContract]
        EntityObject_V_BGT_ADJUST_TO_SAP Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_ADJUST_TO_SAP[] saveEntities, EntityObject_V_BGT_ADJUST_TO_SAP[] updateEntities, EntityObject_V_BGT_ADJUST_TO_SAP[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_BGT_ADJUST_TO_SAP saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_BGT_ADJUST_TO_SAP deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_ADJUST_TO_SAP updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
