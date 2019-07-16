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
    [ServiceKnownType(typeof(EntityObject_BGT_B_CPN_HIS_DATA_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_CPN_HIS_DATA))]	
	public partial interface ServiceContract_BGT_B_CPN_HIS_DATA: IServiceContractLocal<EntityObject_BGT_B_CPN_HIS_DATA, CauseObject_BGT_B_CPN_HIS_DATA>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_CPN_HIS_DATA obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_CPN_HIS_DATA obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_CPN_HIS_DATA obj);
		[OperationContract]
		EntityObject_BGT_B_CPN_HIS_DATA Get(EntityObject_BGT_B_CPN_HIS_DATA obj);
		[OperationContract]
		DisplayObject_BGT_B_CPN_HIS_DATA[] List();
		[OperationContract]
		DisplayObject_BGT_B_CPN_HIS_DATA[] Query(CauseObject_BGT_B_CPN_HIS_DATA cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_CPN_HIS_DATA cause);
		[OperationContract]
		DisplayObject_BGT_B_CPN_HIS_DATA[] Query(CauseObject_BGT_B_CPN_HIS_DATA cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_CPN_HIS_DATA[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_CPN_HIS_DATA[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_CPN_HIS_DATA[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_CPN_HIS_DATA obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_CPN_HIS_DATA obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_CPN_HIS_DATA obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_CPN_HIS_DATA obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_CPN_HIS_DATA obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_CPN_HIS_DATA obj);
        [OperationContract]
        EntityObject_BGT_B_CPN_HIS_DATA Load(string id , out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_HIS_DATA[] saveEntities, EntityObject_BGT_B_CPN_HIS_DATA[] updateEntities, EntityObject_BGT_B_CPN_HIS_DATA[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_B_CPN_HIS_DATA saveBaseEntity, EntityObject_BGT_B_CPN_HIS_DATA_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_CPN_HIS_DATA deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_HIS_DATA updateBaseEntity, EntityObject_BGT_B_CPN_HIS_DATA_D[] saveDetailEntities, EntityObject_BGT_B_CPN_HIS_DATA_D[] updateDetailEntities, EntityObject_BGT_B_CPN_HIS_DATA_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
