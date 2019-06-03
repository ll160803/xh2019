
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
		
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_SCM_B_SALERETURN))]	
	public partial interface ServiceContract_SCM_B_SALERETURN: IServiceContractLocal<EntityObject_SCM_B_SALERETURN, CauseObject_SCM_B_SALERETURN>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_B_SALERETURN obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_B_SALERETURN obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_B_SALERETURN obj);
		[OperationContract]
		EntityObject_SCM_B_SALERETURN Get(EntityObject_SCM_B_SALERETURN obj);
		[OperationContract]
		DisplayObject_SCM_B_SALERETURN[] List();
		[OperationContract]
		DisplayObject_SCM_B_SALERETURN[] Query(CauseObject_SCM_B_SALERETURN cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_B_SALERETURN cause);
		[OperationContract]
		DisplayObject_SCM_B_SALERETURN[] Query(CauseObject_SCM_B_SALERETURN cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_B_SALERETURN[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_B_SALERETURN[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_B_SALERETURN[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_B_SALERETURN obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_B_SALERETURN obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_B_SALERETURN obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_B_SALERETURN obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_B_SALERETURN obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_B_SALERETURN obj);
        [OperationContract]
        EntityObject_SCM_B_SALERETURN Load(string id , out EntityObject_COM_DEPART dept_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_SALERETURN[] saveEntities, EntityObject_SCM_B_SALERETURN[] updateEntities, EntityObject_SCM_B_SALERETURN[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_B_SALERETURN saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_B_SALERETURN deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_SALERETURN updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
