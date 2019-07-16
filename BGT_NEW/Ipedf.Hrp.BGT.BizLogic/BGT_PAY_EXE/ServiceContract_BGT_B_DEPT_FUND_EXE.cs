
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
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_ITEM))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_FUND_EXE))]	
	public partial interface ServiceContract_BGT_B_DEPT_FUND_EXE: IServiceContractLocal<EntityObject_BGT_B_DEPT_FUND_EXE, CauseObject_BGT_B_DEPT_FUND_EXE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_DEPT_FUND_EXE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_DEPT_FUND_EXE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_DEPT_FUND_EXE obj);
		[OperationContract]
		EntityObject_BGT_B_DEPT_FUND_EXE Get(EntityObject_BGT_B_DEPT_FUND_EXE obj);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_FUND_EXE[] List();
		[OperationContract]
		DisplayObject_BGT_B_DEPT_FUND_EXE[] Query(CauseObject_BGT_B_DEPT_FUND_EXE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_DEPT_FUND_EXE cause);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_FUND_EXE[] Query(CauseObject_BGT_B_DEPT_FUND_EXE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_DEPT_FUND_EXE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_DEPT_FUND_EXE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_DEPT_FUND_EXE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_DEPT_FUND_EXE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_DEPT_FUND_EXE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_DEPT_FUND_EXE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_DEPT_FUND_EXE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_DEPT_FUND_EXE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_DEPT_FUND_EXE obj);
        [OperationContract]
        EntityObject_BGT_B_DEPT_FUND_EXE Load(string id , out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_BGT_D_BUDGET_ITEM bgt_d_budget_item_id, out EntityObject_COM_TYPE fund_type_id, out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_FUND_EXE[] saveEntities, EntityObject_BGT_B_DEPT_FUND_EXE[] updateEntities, EntityObject_BGT_B_DEPT_FUND_EXE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_B_DEPT_FUND_EXE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_DEPT_FUND_EXE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_FUND_EXE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
