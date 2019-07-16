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
    [ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_T_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_T))]	
	public partial interface ServiceContract_BGT_D_BUDGET_T: IServiceContractLocal<EntityObject_BGT_D_BUDGET_T, CauseObject_BGT_D_BUDGET_T>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_BUDGET_T obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_BUDGET_T obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_T obj);
		[OperationContract]
		EntityObject_BGT_D_BUDGET_T Get(EntityObject_BGT_D_BUDGET_T obj);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_T[] List();
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_T[] Query(CauseObject_BGT_D_BUDGET_T cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_T cause);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_T[] Query(CauseObject_BGT_D_BUDGET_T cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_T[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_T[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_T[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_T obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_T obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_T obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_T obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_T obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_T obj);
        [OperationContract]
        EntityObject_BGT_D_BUDGET_T Load(string id , out EntityObject_COM_TYPE templet_type_id, out EntityObject_COM_TYPE budget_contents_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_T[] saveEntities, EntityObject_BGT_D_BUDGET_T[] updateEntities, EntityObject_BGT_D_BUDGET_T[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_D_BUDGET_T saveBaseEntity, EntityObject_BGT_D_BUDGET_T_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_D_BUDGET_T deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_T updateBaseEntity, EntityObject_BGT_D_BUDGET_T_D[] saveDetailEntities, EntityObject_BGT_D_BUDGET_T_D[] updateDetailEntities, EntityObject_BGT_D_BUDGET_T_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
