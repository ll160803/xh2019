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
    [ServiceKnownType(typeof(EntityObject_BGT_D_MGR_DEPT_ITEM_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_ITEM))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_D_MGR_DEPT_ITEM))]	
	public partial interface ServiceContract_BGT_D_MGR_DEPT_ITEM: IServiceContractLocal<EntityObject_BGT_D_MGR_DEPT_ITEM, CauseObject_BGT_D_MGR_DEPT_ITEM>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_MGR_DEPT_ITEM obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_MGR_DEPT_ITEM obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_MGR_DEPT_ITEM obj);
		[OperationContract]
		EntityObject_BGT_D_MGR_DEPT_ITEM Get(EntityObject_BGT_D_MGR_DEPT_ITEM obj);
		[OperationContract]
		DisplayObject_BGT_D_MGR_DEPT_ITEM[] List();
		[OperationContract]
		DisplayObject_BGT_D_MGR_DEPT_ITEM[] Query(CauseObject_BGT_D_MGR_DEPT_ITEM cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_MGR_DEPT_ITEM cause);
		[OperationContract]
		DisplayObject_BGT_D_MGR_DEPT_ITEM[] Query(CauseObject_BGT_D_MGR_DEPT_ITEM cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_MGR_DEPT_ITEM[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_MGR_DEPT_ITEM[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_MGR_DEPT_ITEM[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_MGR_DEPT_ITEM obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_MGR_DEPT_ITEM obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_MGR_DEPT_ITEM obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_MGR_DEPT_ITEM obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_MGR_DEPT_ITEM obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_MGR_DEPT_ITEM obj);
        [OperationContract]
        EntityObject_BGT_D_MGR_DEPT_ITEM Load(string id , out EntityObject_BGT_D_BUDGET_ITEM item_id, out EntityObject_BGT_D_BUDGET_DEPT mgr_dept_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_MGR_DEPT_ITEM[] saveEntities, EntityObject_BGT_D_MGR_DEPT_ITEM[] updateEntities, EntityObject_BGT_D_MGR_DEPT_ITEM[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_D_MGR_DEPT_ITEM saveBaseEntity, EntityObject_BGT_D_MGR_DEPT_ITEM_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_D_MGR_DEPT_ITEM deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_MGR_DEPT_ITEM updateBaseEntity, EntityObject_BGT_D_MGR_DEPT_ITEM_D[] saveDetailEntities, EntityObject_BGT_D_MGR_DEPT_ITEM_D[] updateDetailEntities, EntityObject_BGT_D_MGR_DEPT_ITEM_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
