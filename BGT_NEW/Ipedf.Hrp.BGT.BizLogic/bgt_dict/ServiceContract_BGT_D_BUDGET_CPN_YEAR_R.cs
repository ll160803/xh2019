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
    [ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_CPN_YEAR_R))]	
	public partial interface ServiceContract_BGT_D_BUDGET_CPN_YEAR_R: IServiceContractLocal<EntityObject_BGT_D_BUDGET_CPN_YEAR_R, CauseObject_BGT_D_BUDGET_CPN_YEAR_R>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_BUDGET_CPN_YEAR_R obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_BUDGET_CPN_YEAR_R obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_CPN_YEAR_R obj);
		[OperationContract]
		EntityObject_BGT_D_BUDGET_CPN_YEAR_R Get(EntityObject_BGT_D_BUDGET_CPN_YEAR_R obj);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_CPN_YEAR_R[] List();
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_CPN_YEAR_R[] Query(CauseObject_BGT_D_BUDGET_CPN_YEAR_R cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_CPN_YEAR_R cause);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_CPN_YEAR_R[] Query(CauseObject_BGT_D_BUDGET_CPN_YEAR_R cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_CPN_YEAR_R[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_CPN_YEAR_R[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_CPN_YEAR_R[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_CPN_YEAR_R obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_CPN_YEAR_R obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_CPN_YEAR_R obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_CPN_YEAR_R obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_CPN_YEAR_R obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_CPN_YEAR_R obj);
        [OperationContract]
        EntityObject_BGT_D_BUDGET_CPN_YEAR_R Load(string id , out EntityObject_COM_TYPE budget_contents_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_CPN_YEAR_R[] saveEntities, EntityObject_BGT_D_BUDGET_CPN_YEAR_R[] updateEntities, EntityObject_BGT_D_BUDGET_CPN_YEAR_R[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_D_BUDGET_CPN_YEAR_R saveBaseEntity, EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_D_BUDGET_CPN_YEAR_R deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_CPN_YEAR_R updateBaseEntity, EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I[] saveDetailEntities, EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I[] updateDetailEntities, EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
