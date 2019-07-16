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
    [ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_CONTROL_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_CONTROL))]	
	public partial interface ServiceContract_BGT_B_BUDGET_CONTROL: IServiceContractLocal<EntityObject_BGT_B_BUDGET_CONTROL, CauseObject_BGT_B_BUDGET_CONTROL>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_BUDGET_CONTROL obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_BUDGET_CONTROL obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_BUDGET_CONTROL obj);
		[OperationContract]
		EntityObject_BGT_B_BUDGET_CONTROL Get(EntityObject_BGT_B_BUDGET_CONTROL obj);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_CONTROL[] List();
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_CONTROL[] Query(CauseObject_BGT_B_BUDGET_CONTROL cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_BUDGET_CONTROL cause);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_CONTROL[] Query(CauseObject_BGT_B_BUDGET_CONTROL cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_BUDGET_CONTROL[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_BUDGET_CONTROL[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_BUDGET_CONTROL[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_BUDGET_CONTROL obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_BUDGET_CONTROL obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_BUDGET_CONTROL obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_BUDGET_CONTROL obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_BUDGET_CONTROL obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_BUDGET_CONTROL obj);
        [OperationContract]
        EntityObject_BGT_B_BUDGET_CONTROL Load(string id , out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_CONTROL[] saveEntities, EntityObject_BGT_B_BUDGET_CONTROL[] updateEntities, EntityObject_BGT_B_BUDGET_CONTROL[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_B_BUDGET_CONTROL saveBaseEntity, EntityObject_BGT_B_BUDGET_CONTROL_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_BUDGET_CONTROL deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_CONTROL updateBaseEntity, EntityObject_BGT_B_BUDGET_CONTROL_D[] saveDetailEntities, EntityObject_BGT_B_BUDGET_CONTROL_D[] updateDetailEntities, EntityObject_BGT_B_BUDGET_CONTROL_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
