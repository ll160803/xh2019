
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
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_CPN_INC_MEDICAL))]	
	public partial interface ServiceContract_BGT_B_CPN_INC_MEDICAL: IServiceContractLocal<EntityObject_BGT_B_CPN_INC_MEDICAL, CauseObject_BGT_B_CPN_INC_MEDICAL>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_CPN_INC_MEDICAL obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_CPN_INC_MEDICAL obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_CPN_INC_MEDICAL obj);
		[OperationContract]
		EntityObject_BGT_B_CPN_INC_MEDICAL Get(EntityObject_BGT_B_CPN_INC_MEDICAL obj);
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_MEDICAL[] List();
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_MEDICAL[] Query(CauseObject_BGT_B_CPN_INC_MEDICAL cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_CPN_INC_MEDICAL cause);
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_MEDICAL[] Query(CauseObject_BGT_B_CPN_INC_MEDICAL cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_CPN_INC_MEDICAL[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_CPN_INC_MEDICAL[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_CPN_INC_MEDICAL[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_CPN_INC_MEDICAL obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_CPN_INC_MEDICAL obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_CPN_INC_MEDICAL obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_CPN_INC_MEDICAL obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_CPN_INC_MEDICAL obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_CPN_INC_MEDICAL obj);
        [OperationContract]
        EntityObject_BGT_B_CPN_INC_MEDICAL Load(string id , out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id, out EntityObject_COM_TYPE com_type_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_INC_MEDICAL[] saveEntities, EntityObject_BGT_B_CPN_INC_MEDICAL[] updateEntities, EntityObject_BGT_B_CPN_INC_MEDICAL[] deleteEntities);
        decimal[] QuerySUM(CauseObject_BGT_B_CPN_INC_MEDICAL cause);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_B_CPN_INC_MEDICAL saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_CPN_INC_MEDICAL deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_INC_MEDICAL updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
