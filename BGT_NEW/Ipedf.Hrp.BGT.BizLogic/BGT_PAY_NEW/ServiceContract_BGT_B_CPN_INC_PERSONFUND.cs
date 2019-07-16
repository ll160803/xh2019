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
    [ServiceKnownType(typeof(EntityObject_BGT_B_CPN_INC_PF_D_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_CPN_INC_PERSONFUND))]	
	public partial interface ServiceContract_BGT_B_CPN_INC_PERSONFUND: IServiceContractLocal<EntityObject_BGT_B_CPN_INC_PERSONFUND, CauseObject_BGT_B_CPN_INC_PERSONFUND>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_CPN_INC_PERSONFUND obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_CPN_INC_PERSONFUND obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_CPN_INC_PERSONFUND obj);
		[OperationContract]
		EntityObject_BGT_B_CPN_INC_PERSONFUND Get(EntityObject_BGT_B_CPN_INC_PERSONFUND obj);
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_PERSONFUND[] List();
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_PERSONFUND[] Query(CauseObject_BGT_B_CPN_INC_PERSONFUND cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_CPN_INC_PERSONFUND cause);
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_PERSONFUND[] Query(CauseObject_BGT_B_CPN_INC_PERSONFUND cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_CPN_INC_PERSONFUND[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_CPN_INC_PERSONFUND[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_CPN_INC_PERSONFUND[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_CPN_INC_PERSONFUND obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_CPN_INC_PERSONFUND obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_CPN_INC_PERSONFUND obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_CPN_INC_PERSONFUND obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_CPN_INC_PERSONFUND obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_CPN_INC_PERSONFUND obj);
        [OperationContract]
        EntityObject_BGT_B_CPN_INC_PERSONFUND Load(string id , out EntityObject_COM_DEPART dept_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_INC_PERSONFUND[] saveEntities, EntityObject_BGT_B_CPN_INC_PERSONFUND[] updateEntities, EntityObject_BGT_B_CPN_INC_PERSONFUND[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_B_CPN_INC_PERSONFUND saveBaseEntity, EntityObject_BGT_B_CPN_INC_PF_D_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_CPN_INC_PERSONFUND deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_INC_PERSONFUND updateBaseEntity, EntityObject_BGT_B_CPN_INC_PF_D_D[] saveDetailEntities, EntityObject_BGT_B_CPN_INC_PF_D_D[] updateDetailEntities, EntityObject_BGT_B_CPN_INC_PF_D_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
