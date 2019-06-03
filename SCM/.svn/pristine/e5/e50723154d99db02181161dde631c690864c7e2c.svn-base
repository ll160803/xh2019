
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
	[ServiceKnownType(typeof(EntityObject_V_SCM_D_SALERETURN))]	
	public partial interface ServiceContract_V_SCM_D_SALERETURN: IServiceContractLocal<EntityObject_V_SCM_D_SALERETURN, CauseObject_V_SCM_D_SALERETURN>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_SCM_D_SALERETURN obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_SCM_D_SALERETURN obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_SCM_D_SALERETURN obj);
		[OperationContract]
		EntityObject_V_SCM_D_SALERETURN Get(EntityObject_V_SCM_D_SALERETURN obj);
		[OperationContract]
		DisplayObject_V_SCM_D_SALERETURN[] List();
		[OperationContract]
		DisplayObject_V_SCM_D_SALERETURN[] Query(CauseObject_V_SCM_D_SALERETURN cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_SCM_D_SALERETURN cause);
		[OperationContract]
		DisplayObject_V_SCM_D_SALERETURN[] Query(CauseObject_V_SCM_D_SALERETURN cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_SCM_D_SALERETURN[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_SCM_D_SALERETURN[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_SCM_D_SALERETURN[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_SCM_D_SALERETURN obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_SCM_D_SALERETURN obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_SCM_D_SALERETURN obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_SCM_D_SALERETURN obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_SCM_D_SALERETURN obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_SCM_D_SALERETURN obj);
        [OperationContract]
        EntityObject_V_SCM_D_SALERETURN Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_D_SALERETURN[] saveEntities, EntityObject_V_SCM_D_SALERETURN[] updateEntities, EntityObject_V_SCM_D_SALERETURN[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_SCM_D_SALERETURN saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_SCM_D_SALERETURN deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_D_SALERETURN updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
