
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
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_V_BGT_D_BUDGET_DEPT_USER))]	
	public partial interface ServiceContract_V_BGT_D_BUDGET_DEPT_USER: IServiceContractLocal<EntityObject_V_BGT_D_BUDGET_DEPT_USER, CauseObject_V_BGT_D_BUDGET_DEPT_USER>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj);
		[OperationContract]
		EntityObject_V_BGT_D_BUDGET_DEPT_USER Get(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj);
		[OperationContract]
		DisplayObject_V_BGT_D_BUDGET_DEPT_USER[] List();
		[OperationContract]
		DisplayObject_V_BGT_D_BUDGET_DEPT_USER[] Query(CauseObject_V_BGT_D_BUDGET_DEPT_USER cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_BGT_D_BUDGET_DEPT_USER cause);
		[OperationContract]
		DisplayObject_V_BGT_D_BUDGET_DEPT_USER[] Query(CauseObject_V_BGT_D_BUDGET_DEPT_USER cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_BGT_D_BUDGET_DEPT_USER[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_BGT_D_BUDGET_DEPT_USER[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_BGT_D_BUDGET_DEPT_USER[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj);
        [OperationContract]
        EntityObject_V_BGT_D_BUDGET_DEPT_USER Load(string id , out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_D_BUDGET_DEPT_USER[] saveEntities, EntityObject_V_BGT_D_BUDGET_DEPT_USER[] updateEntities, EntityObject_V_BGT_D_BUDGET_DEPT_USER[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_BGT_D_BUDGET_DEPT_USER saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_BGT_D_BUDGET_DEPT_USER deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_D_BUDGET_DEPT_USER updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
