#define NESTING
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
    [ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_PROJ_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_PROJ))]	
	public partial interface ServiceContract_BGT_B_BUDGET_PROJ: IServiceContractLocal<EntityObject_BGT_B_BUDGET_PROJ, CauseObject_BGT_B_BUDGET_PROJ>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_BUDGET_PROJ obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_BUDGET_PROJ obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_BUDGET_PROJ obj);
		[OperationContract]
		EntityObject_BGT_B_BUDGET_PROJ Get(EntityObject_BGT_B_BUDGET_PROJ obj);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_PROJ[] List();
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_PROJ[] Query(CauseObject_BGT_B_BUDGET_PROJ cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_BUDGET_PROJ cause);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_PROJ[] Query(CauseObject_BGT_B_BUDGET_PROJ cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_BUDGET_PROJ[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_BUDGET_PROJ[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_BUDGET_PROJ[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_BUDGET_PROJ obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_BUDGET_PROJ obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_BUDGET_PROJ obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_BUDGET_PROJ obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_BUDGET_PROJ obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_BUDGET_PROJ obj);
        [OperationContract]
        EntityObject_BGT_B_BUDGET_PROJ Load(string id , out EntityObject_COM_USER proj_user_id, out EntityObject_COM_USER finance_user_id, out EntityObject_COM_TYPE nature_id, out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id, out EntityObject_COM_TYPE biz_state, out EntityObject_COM_USER apply_user_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_COM_TYPE type_id, out EntityObject_COM_USER reply_user_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_PROJ[] saveEntities, EntityObject_BGT_B_BUDGET_PROJ[] updateEntities, EntityObject_BGT_B_BUDGET_PROJ[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_B_BUDGET_PROJ saveBaseEntity, EntityObject_BGT_B_BUDGET_PROJ_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_BUDGET_PROJ deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_PROJ updateBaseEntity, EntityObject_BGT_B_BUDGET_PROJ_D[] saveDetailEntities, EntityObject_BGT_B_BUDGET_PROJ_D[] updateDetailEntities, EntityObject_BGT_B_BUDGET_PROJ_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
