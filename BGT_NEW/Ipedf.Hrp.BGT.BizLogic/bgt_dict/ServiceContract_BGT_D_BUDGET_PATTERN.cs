
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
		
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_PATTERN))]	
	public partial interface ServiceContract_BGT_D_BUDGET_PATTERN: IServiceContractLocal<EntityObject_BGT_D_BUDGET_PATTERN, CauseObject_BGT_D_BUDGET_PATTERN>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_BUDGET_PATTERN obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_BUDGET_PATTERN obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_PATTERN obj);
		[OperationContract]
		EntityObject_BGT_D_BUDGET_PATTERN Get(EntityObject_BGT_D_BUDGET_PATTERN obj);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_PATTERN[] List();
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_PATTERN[] Query(CauseObject_BGT_D_BUDGET_PATTERN cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_PATTERN cause);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_PATTERN[] Query(CauseObject_BGT_D_BUDGET_PATTERN cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_PATTERN[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_PATTERN[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_PATTERN[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_PATTERN obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_PATTERN obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_PATTERN obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_PATTERN obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_PATTERN obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_PATTERN obj);
        [OperationContract]
        EntityObject_BGT_D_BUDGET_PATTERN Load(string id , out EntityObject_COM_TYPE pay_pattern_entry_id, out EntityObject_COM_TYPE income_pattern_id, out EntityObject_COM_TYPE income_level_id, out EntityObject_COM_TYPE plan_pattern_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_COM_TYPE pay_pattern_id, out EntityObject_COM_TYPE pay_level_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_PATTERN[] saveEntities, EntityObject_BGT_D_BUDGET_PATTERN[] updateEntities, EntityObject_BGT_D_BUDGET_PATTERN[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_D_BUDGET_PATTERN saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_D_BUDGET_PATTERN deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_PATTERN updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
