
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
		
[ServiceKnownType(typeof(EntityObject_COM_USER))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT_USER))]	
	public partial interface ServiceContract_BGT_D_BUDGET_DEPT_USER: IServiceContractLocal<EntityObject_BGT_D_BUDGET_DEPT_USER, CauseObject_BGT_D_BUDGET_DEPT_USER>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_BUDGET_DEPT_USER obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_BUDGET_DEPT_USER obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_DEPT_USER obj);
		[OperationContract]
		EntityObject_BGT_D_BUDGET_DEPT_USER Get(EntityObject_BGT_D_BUDGET_DEPT_USER obj);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_DEPT_USER[] List();
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_DEPT_USER[] Query(CauseObject_BGT_D_BUDGET_DEPT_USER cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_DEPT_USER cause);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_DEPT_USER[] Query(CauseObject_BGT_D_BUDGET_DEPT_USER cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_DEPT_USER[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_DEPT_USER[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_DEPT_USER[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_DEPT_USER obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_DEPT_USER obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_DEPT_USER obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_DEPT_USER obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_DEPT_USER obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_DEPT_USER obj);
        [OperationContract]
        EntityObject_BGT_D_BUDGET_DEPT_USER Load(string id , out EntityObject_COM_USER user_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_DEPT_USER[] saveEntities, EntityObject_BGT_D_BUDGET_DEPT_USER[] updateEntities, EntityObject_BGT_D_BUDGET_DEPT_USER[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_D_BUDGET_DEPT_USER saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_D_BUDGET_DEPT_USER deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_DEPT_USER updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
