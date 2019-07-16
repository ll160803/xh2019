
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
	[ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_ADJUST))]	
	public partial interface ServiceContract_BGT_B_BUDGET_ADJUST: IServiceContractLocal<EntityObject_BGT_B_BUDGET_ADJUST, CauseObject_BGT_B_BUDGET_ADJUST>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_BUDGET_ADJUST obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_BUDGET_ADJUST obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_BUDGET_ADJUST obj);
		[OperationContract]
		EntityObject_BGT_B_BUDGET_ADJUST Get(EntityObject_BGT_B_BUDGET_ADJUST obj);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_ADJUST[] List();
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_ADJUST[] Query(CauseObject_BGT_B_BUDGET_ADJUST cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_BUDGET_ADJUST cause);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_ADJUST[] Query(CauseObject_BGT_B_BUDGET_ADJUST cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_BUDGET_ADJUST[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_BUDGET_ADJUST[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_BUDGET_ADJUST[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_BUDGET_ADJUST obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_BUDGET_ADJUST obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_BUDGET_ADJUST obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_BUDGET_ADJUST obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_BUDGET_ADJUST obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_BUDGET_ADJUST obj);
        [OperationContract]
        EntityObject_BGT_B_BUDGET_ADJUST Load(string id , out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_ADJUST[] saveEntities, EntityObject_BGT_B_BUDGET_ADJUST[] updateEntities, EntityObject_BGT_B_BUDGET_ADJUST[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_BGT_B_BUDGET_ADJUST saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_BGT_B_BUDGET_ADJUST deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_ADJUST updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
