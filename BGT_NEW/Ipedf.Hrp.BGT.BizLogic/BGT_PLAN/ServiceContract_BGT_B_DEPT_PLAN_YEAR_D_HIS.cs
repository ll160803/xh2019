
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
		
[ServiceKnownType(typeof(EntityObject_BILL_WORK_FLOW))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_PLAN_ITEM))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS))]	
	public partial interface ServiceContract_BGT_B_DEPT_PLAN_YEAR_D_HIS: IServiceContractLocal<EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS, CauseObject_BGT_B_DEPT_PLAN_YEAR_D_HIS>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS obj);
		[OperationContract]
		EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS Get(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS obj);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_PLAN_YEAR_D_HIS[] List();
		[OperationContract]
		DisplayObject_BGT_B_DEPT_PLAN_YEAR_D_HIS[] Query(CauseObject_BGT_B_DEPT_PLAN_YEAR_D_HIS cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_DEPT_PLAN_YEAR_D_HIS cause);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_PLAN_YEAR_D_HIS[] Query(CauseObject_BGT_B_DEPT_PLAN_YEAR_D_HIS cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS obj);
        [OperationContract]
        EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS Load(string id , out EntityObject_BILL_WORK_FLOW base_id, out EntityObject_BGT_D_PLAN_ITEM item_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS[] saveEntities, EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS[] updateEntities, EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_PLAN_YEAR_D_HIS updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
