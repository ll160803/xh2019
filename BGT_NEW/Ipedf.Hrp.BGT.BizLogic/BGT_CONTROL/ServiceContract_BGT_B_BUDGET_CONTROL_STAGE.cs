
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
	[ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_CONTROL_STAGE))]	
	public partial interface ServiceContract_BGT_B_BUDGET_CONTROL_STAGE: IServiceContractLocal<EntityObject_BGT_B_BUDGET_CONTROL_STAGE, CauseObject_BGT_B_BUDGET_CONTROL_STAGE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_BUDGET_CONTROL_STAGE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_BUDGET_CONTROL_STAGE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_BUDGET_CONTROL_STAGE obj);
		[OperationContract]
		EntityObject_BGT_B_BUDGET_CONTROL_STAGE Get(EntityObject_BGT_B_BUDGET_CONTROL_STAGE obj);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_CONTROL_STAGE[] List();
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_CONTROL_STAGE[] Query(CauseObject_BGT_B_BUDGET_CONTROL_STAGE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_BUDGET_CONTROL_STAGE cause);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_CONTROL_STAGE[] Query(CauseObject_BGT_B_BUDGET_CONTROL_STAGE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_BUDGET_CONTROL_STAGE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_BUDGET_CONTROL_STAGE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_BUDGET_CONTROL_STAGE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_BUDGET_CONTROL_STAGE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_BUDGET_CONTROL_STAGE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_BUDGET_CONTROL_STAGE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_BUDGET_CONTROL_STAGE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_BUDGET_CONTROL_STAGE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_BUDGET_CONTROL_STAGE obj);
        [OperationContract]
        EntityObject_BGT_B_BUDGET_CONTROL_STAGE Load(string id , out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_CONTROL_STAGE[] saveEntities, EntityObject_BGT_B_BUDGET_CONTROL_STAGE[] updateEntities, EntityObject_BGT_B_BUDGET_CONTROL_STAGE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_B_BUDGET_CONTROL_STAGE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_BUDGET_CONTROL_STAGE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_CONTROL_STAGE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
