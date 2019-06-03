
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
	[ServiceKnownType(typeof(EntityObject_SCM_B_SENDORDER))]	
	public partial interface ServiceContract_SCM_B_SENDORDER: IServiceContractLocal<EntityObject_SCM_B_SENDORDER, CauseObject_SCM_B_SENDORDER>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_B_SENDORDER obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_B_SENDORDER obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_B_SENDORDER obj);
		[OperationContract]
		EntityObject_SCM_B_SENDORDER Get(EntityObject_SCM_B_SENDORDER obj);
		[OperationContract]
		DisplayObject_SCM_B_SENDORDER[] List();
		[OperationContract]
		DisplayObject_SCM_B_SENDORDER[] Query(CauseObject_SCM_B_SENDORDER cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_B_SENDORDER cause);
		[OperationContract]
		DisplayObject_SCM_B_SENDORDER[] Query(CauseObject_SCM_B_SENDORDER cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_B_SENDORDER[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_B_SENDORDER[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_B_SENDORDER[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_B_SENDORDER obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_B_SENDORDER obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_B_SENDORDER obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_B_SENDORDER obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_B_SENDORDER obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_B_SENDORDER obj);
        [OperationContract]
        EntityObject_SCM_B_SENDORDER Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_SENDORDER[] saveEntities, EntityObject_SCM_B_SENDORDER[] updateEntities, EntityObject_SCM_B_SENDORDER[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_B_SENDORDER saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_B_SENDORDER deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_SENDORDER updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
