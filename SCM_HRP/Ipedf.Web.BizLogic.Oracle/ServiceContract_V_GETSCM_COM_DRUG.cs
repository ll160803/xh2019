
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
	[ServiceKnownType(typeof(EntityObject_V_GETSCM_COM_DRUG))]	
	public partial interface ServiceContract_V_GETSCM_COM_DRUG: IServiceContractLocal<EntityObject_V_GETSCM_COM_DRUG, CauseObject_V_GETSCM_COM_DRUG>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_GETSCM_COM_DRUG obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_GETSCM_COM_DRUG obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_GETSCM_COM_DRUG obj);
		[OperationContract]
		EntityObject_V_GETSCM_COM_DRUG Get(EntityObject_V_GETSCM_COM_DRUG obj);
		[OperationContract]
		DisplayObject_V_GETSCM_COM_DRUG[] List();
		[OperationContract]
		DisplayObject_V_GETSCM_COM_DRUG[] Query(CauseObject_V_GETSCM_COM_DRUG cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_GETSCM_COM_DRUG cause);
		[OperationContract]
		DisplayObject_V_GETSCM_COM_DRUG[] Query(CauseObject_V_GETSCM_COM_DRUG cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_GETSCM_COM_DRUG[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_GETSCM_COM_DRUG[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_GETSCM_COM_DRUG[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_GETSCM_COM_DRUG obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_GETSCM_COM_DRUG obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_GETSCM_COM_DRUG obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_GETSCM_COM_DRUG obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_GETSCM_COM_DRUG obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_GETSCM_COM_DRUG obj);
        [OperationContract]
        EntityObject_V_GETSCM_COM_DRUG Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_GETSCM_COM_DRUG[] saveEntities, EntityObject_V_GETSCM_COM_DRUG[] updateEntities, EntityObject_V_GETSCM_COM_DRUG[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_GETSCM_COM_DRUG saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_GETSCM_COM_DRUG deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_GETSCM_COM_DRUG updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
