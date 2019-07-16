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
    [ServiceKnownType(typeof(EntityObject_BGT_B_CPN_INC_BASIC_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_CPN_INC_BASIC))]	
	public partial interface ServiceContract_BGT_B_CPN_INC_BASIC: IServiceContractLocal<EntityObject_BGT_B_CPN_INC_BASIC, CauseObject_BGT_B_CPN_INC_BASIC>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_CPN_INC_BASIC obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_CPN_INC_BASIC obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_CPN_INC_BASIC obj);
		[OperationContract]
		EntityObject_BGT_B_CPN_INC_BASIC Get(EntityObject_BGT_B_CPN_INC_BASIC obj);
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_BASIC[] List();
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_BASIC[] Query(CauseObject_BGT_B_CPN_INC_BASIC cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_CPN_INC_BASIC cause);
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_BASIC[] Query(CauseObject_BGT_B_CPN_INC_BASIC cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_CPN_INC_BASIC[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_CPN_INC_BASIC[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_CPN_INC_BASIC[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_CPN_INC_BASIC obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_CPN_INC_BASIC obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_CPN_INC_BASIC obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_CPN_INC_BASIC obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_CPN_INC_BASIC obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_CPN_INC_BASIC obj);
        [OperationContract]
        EntityObject_BGT_B_CPN_INC_BASIC Load(string id , out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_COM_USER dept_user_id, out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_INC_BASIC[] saveEntities, EntityObject_BGT_B_CPN_INC_BASIC[] updateEntities, EntityObject_BGT_B_CPN_INC_BASIC[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_B_CPN_INC_BASIC saveBaseEntity, EntityObject_BGT_B_CPN_INC_BASIC_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_CPN_INC_BASIC deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_INC_BASIC updateBaseEntity, EntityObject_BGT_B_CPN_INC_BASIC_D[] saveDetailEntities, EntityObject_BGT_B_CPN_INC_BASIC_D[] updateDetailEntities, EntityObject_BGT_B_CPN_INC_BASIC_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
