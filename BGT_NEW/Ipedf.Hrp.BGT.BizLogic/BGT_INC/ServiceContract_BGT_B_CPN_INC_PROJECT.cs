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
    [ServiceKnownType(typeof(EntityObject_BGT_B_CPN_INC_PROJECT_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_CPN_INC_PROJECT))]	
	public partial interface ServiceContract_BGT_B_CPN_INC_PROJECT: IServiceContractLocal<EntityObject_BGT_B_CPN_INC_PROJECT, CauseObject_BGT_B_CPN_INC_PROJECT>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_CPN_INC_PROJECT obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_CPN_INC_PROJECT obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_CPN_INC_PROJECT obj);
		[OperationContract]
		EntityObject_BGT_B_CPN_INC_PROJECT Get(EntityObject_BGT_B_CPN_INC_PROJECT obj);
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_PROJECT[] List();
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_PROJECT[] Query(CauseObject_BGT_B_CPN_INC_PROJECT cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_CPN_INC_PROJECT cause);
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_PROJECT[] Query(CauseObject_BGT_B_CPN_INC_PROJECT cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_CPN_INC_PROJECT[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_CPN_INC_PROJECT[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_CPN_INC_PROJECT[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_CPN_INC_PROJECT obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_CPN_INC_PROJECT obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_CPN_INC_PROJECT obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_CPN_INC_PROJECT obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_CPN_INC_PROJECT obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_CPN_INC_PROJECT obj);
        [OperationContract]
        EntityObject_BGT_B_CPN_INC_PROJECT Load(string id , out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_COM_USER dept_user_id, out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_INC_PROJECT[] saveEntities, EntityObject_BGT_B_CPN_INC_PROJECT[] updateEntities, EntityObject_BGT_B_CPN_INC_PROJECT[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_B_CPN_INC_PROJECT saveBaseEntity, EntityObject_BGT_B_CPN_INC_PROJECT_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_CPN_INC_PROJECT deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_INC_PROJECT updateBaseEntity, EntityObject_BGT_B_CPN_INC_PROJECT_D[] saveDetailEntities, EntityObject_BGT_B_CPN_INC_PROJECT_D[] updateDetailEntities, EntityObject_BGT_B_CPN_INC_PROJECT_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
