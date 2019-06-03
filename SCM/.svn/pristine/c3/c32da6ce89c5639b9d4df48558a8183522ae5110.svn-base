
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
	[ServiceKnownType(typeof(EntityObject_SCM_B_QUERYPRICE_PRODUCT))]	
	public partial interface ServiceContract_SCM_B_QUERYPRICE_PRODUCT: IServiceContractLocal<EntityObject_SCM_B_QUERYPRICE_PRODUCT, CauseObject_SCM_B_QUERYPRICE_PRODUCT>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj);
		[OperationContract]
		EntityObject_SCM_B_QUERYPRICE_PRODUCT Get(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj);
		[OperationContract]
		DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] List();
		[OperationContract]
		DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] Query(CauseObject_SCM_B_QUERYPRICE_PRODUCT cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_B_QUERYPRICE_PRODUCT cause);
		[OperationContract]
		DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] Query(CauseObject_SCM_B_QUERYPRICE_PRODUCT cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_B_QUERYPRICE_PRODUCT[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_B_QUERYPRICE_PRODUCT[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_B_QUERYPRICE_PRODUCT[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj);
        [OperationContract]
        EntityObject_SCM_B_QUERYPRICE_PRODUCT Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_QUERYPRICE_PRODUCT[] saveEntities, EntityObject_SCM_B_QUERYPRICE_PRODUCT[] updateEntities, EntityObject_SCM_B_QUERYPRICE_PRODUCT[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_B_QUERYPRICE_PRODUCT saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_B_QUERYPRICE_PRODUCT deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_QUERYPRICE_PRODUCT updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
