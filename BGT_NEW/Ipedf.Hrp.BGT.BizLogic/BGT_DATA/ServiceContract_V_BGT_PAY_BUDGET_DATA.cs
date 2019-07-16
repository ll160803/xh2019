
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
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_ITEM))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_V_BGT_PAY_BUDGET_DATA))]	
	public partial interface ServiceContract_V_BGT_PAY_BUDGET_DATA: IServiceContractLocal<EntityObject_V_BGT_PAY_BUDGET_DATA, CauseObject_V_BGT_PAY_BUDGET_DATA>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_BGT_PAY_BUDGET_DATA obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_BGT_PAY_BUDGET_DATA obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_BGT_PAY_BUDGET_DATA obj);
		[OperationContract]
		EntityObject_V_BGT_PAY_BUDGET_DATA Get(EntityObject_V_BGT_PAY_BUDGET_DATA obj);
		[OperationContract]
		DisplayObject_V_BGT_PAY_BUDGET_DATA[] List();
		[OperationContract]
		DisplayObject_V_BGT_PAY_BUDGET_DATA[] Query(CauseObject_V_BGT_PAY_BUDGET_DATA cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_BGT_PAY_BUDGET_DATA cause);
		[OperationContract]
		DisplayObject_V_BGT_PAY_BUDGET_DATA[] Query(CauseObject_V_BGT_PAY_BUDGET_DATA cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_BGT_PAY_BUDGET_DATA[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_BGT_PAY_BUDGET_DATA[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_BGT_PAY_BUDGET_DATA[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_BGT_PAY_BUDGET_DATA obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_BGT_PAY_BUDGET_DATA obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_BGT_PAY_BUDGET_DATA obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_BGT_PAY_BUDGET_DATA obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_BGT_PAY_BUDGET_DATA obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_BGT_PAY_BUDGET_DATA obj);
        [OperationContract]
        EntityObject_V_BGT_PAY_BUDGET_DATA Load(string id , out EntityObject_BGT_D_BUDGET_ITEM item_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_PAY_BUDGET_DATA[] saveEntities, EntityObject_V_BGT_PAY_BUDGET_DATA[] updateEntities, EntityObject_V_BGT_PAY_BUDGET_DATA[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_V_BGT_PAY_BUDGET_DATA saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_V_BGT_PAY_BUDGET_DATA deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_PAY_BUDGET_DATA updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
