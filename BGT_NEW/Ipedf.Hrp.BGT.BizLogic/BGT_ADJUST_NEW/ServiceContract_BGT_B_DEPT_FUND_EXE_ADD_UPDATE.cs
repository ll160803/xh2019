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
    [ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_ITEM))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE))]	
	public partial interface ServiceContract_BGT_B_DEPT_FUND_EXE_ADD_UPDATE: IServiceContractLocal<EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE, CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj);
		[OperationContract]
		EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE Get(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] List();
		[OperationContract]
		DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] Query(CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cause);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] Query(CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj);
        [OperationContract]
        EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE Load(string id , out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_BGT_D_BUDGET_ITEM bgt_d_budget_item_id, out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id, out EntityObject_COM_TYPE fund_type_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] saveEntities, EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] updateEntities, EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE saveBaseEntity, EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE updateBaseEntity, EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] saveDetailEntities, EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] updateDetailEntities, EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
