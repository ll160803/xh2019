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
    [ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_PROJ_CO_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_PROJ))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_BUDGET_PROJ_CO))]	
	public partial interface ServiceContract_BGT_B_BUDGET_PROJ_CO: IServiceContractLocal<EntityObject_BGT_B_BUDGET_PROJ_CO, CauseObject_BGT_B_BUDGET_PROJ_CO>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_BUDGET_PROJ_CO obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_BUDGET_PROJ_CO obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_BUDGET_PROJ_CO obj);
		[OperationContract]
		EntityObject_BGT_B_BUDGET_PROJ_CO Get(EntityObject_BGT_B_BUDGET_PROJ_CO obj);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_PROJ_CO[] List();
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_PROJ_CO[] Query(CauseObject_BGT_B_BUDGET_PROJ_CO cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_BUDGET_PROJ_CO cause);
		[OperationContract]
		DisplayObject_BGT_B_BUDGET_PROJ_CO[] Query(CauseObject_BGT_B_BUDGET_PROJ_CO cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_BUDGET_PROJ_CO[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_BUDGET_PROJ_CO[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_BUDGET_PROJ_CO[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_BUDGET_PROJ_CO obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_BUDGET_PROJ_CO obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_BUDGET_PROJ_CO obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_BUDGET_PROJ_CO obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_BUDGET_PROJ_CO obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_BUDGET_PROJ_CO obj);
        [OperationContract]
        EntityObject_BGT_B_BUDGET_PROJ_CO Load(string id , out EntityObject_BGT_B_BUDGET_PROJ project_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_PROJ_CO[] saveEntities, EntityObject_BGT_B_BUDGET_PROJ_CO[] updateEntities, EntityObject_BGT_B_BUDGET_PROJ_CO[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_B_BUDGET_PROJ_CO saveBaseEntity, EntityObject_BGT_B_BUDGET_PROJ_CO_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_BUDGET_PROJ_CO deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_BUDGET_PROJ_CO updateBaseEntity, EntityObject_BGT_B_BUDGET_PROJ_CO_D[] saveDetailEntities, EntityObject_BGT_B_BUDGET_PROJ_CO_D[] updateDetailEntities, EntityObject_BGT_B_BUDGET_PROJ_CO_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
