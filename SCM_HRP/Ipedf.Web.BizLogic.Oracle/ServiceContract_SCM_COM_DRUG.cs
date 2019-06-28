
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
	[ServiceKnownType(typeof(EntityObject_SCM_COM_DRUG))]	
	public partial interface ServiceContract_SCM_COM_DRUG: IServiceContractLocal<EntityObject_SCM_COM_DRUG, CauseObject_SCM_COM_DRUG>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_COM_DRUG obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_COM_DRUG obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_COM_DRUG obj);
		[OperationContract]
		EntityObject_SCM_COM_DRUG Get(EntityObject_SCM_COM_DRUG obj);
		[OperationContract]
		DisplayObject_SCM_COM_DRUG[] List();
		[OperationContract]
		DisplayObject_SCM_COM_DRUG[] Query(CauseObject_SCM_COM_DRUG cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_COM_DRUG cause);
		[OperationContract]
		DisplayObject_SCM_COM_DRUG[] Query(CauseObject_SCM_COM_DRUG cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_COM_DRUG[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_COM_DRUG[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_COM_DRUG[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_COM_DRUG obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_COM_DRUG obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_COM_DRUG obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_COM_DRUG obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_COM_DRUG obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_COM_DRUG obj);
        [OperationContract]
        EntityObject_SCM_COM_DRUG Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_COM_DRUG[] saveEntities, EntityObject_SCM_COM_DRUG[] updateEntities, EntityObject_SCM_COM_DRUG[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_COM_DRUG saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_COM_DRUG deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_COM_DRUG updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
