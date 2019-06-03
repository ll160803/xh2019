
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
	[ServiceKnownType(typeof(EntityObject_SCM_B_PRICEADJUST))]	
	public partial interface ServiceContract_SCM_B_PRICEADJUST: IServiceContractLocal<EntityObject_SCM_B_PRICEADJUST, CauseObject_SCM_B_PRICEADJUST>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_B_PRICEADJUST obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_B_PRICEADJUST obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_B_PRICEADJUST obj);
		[OperationContract]
		EntityObject_SCM_B_PRICEADJUST Get(EntityObject_SCM_B_PRICEADJUST obj);
		[OperationContract]
		DisplayObject_SCM_B_PRICEADJUST[] List();
		[OperationContract]
		DisplayObject_SCM_B_PRICEADJUST[] Query(CauseObject_SCM_B_PRICEADJUST cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_B_PRICEADJUST cause);
		[OperationContract]
		DisplayObject_SCM_B_PRICEADJUST[] Query(CauseObject_SCM_B_PRICEADJUST cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_B_PRICEADJUST[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_B_PRICEADJUST[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_B_PRICEADJUST[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_B_PRICEADJUST obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_B_PRICEADJUST obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_B_PRICEADJUST obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_B_PRICEADJUST obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_B_PRICEADJUST obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_B_PRICEADJUST obj);
        [OperationContract]
        EntityObject_SCM_B_PRICEADJUST Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_PRICEADJUST[] saveEntities, EntityObject_SCM_B_PRICEADJUST[] updateEntities, EntityObject_SCM_B_PRICEADJUST[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_B_PRICEADJUST saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_B_PRICEADJUST deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_PRICEADJUST updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
