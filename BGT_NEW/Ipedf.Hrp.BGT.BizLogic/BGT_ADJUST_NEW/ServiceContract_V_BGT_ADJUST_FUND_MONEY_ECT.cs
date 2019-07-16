
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
	
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT))]	
	public partial interface ServiceContract_V_BGT_ADJUST_FUND_MONEY_ECT: IServiceContractLocal<EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT, CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj);
		[OperationContract]
		EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT Get(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj);
		[OperationContract]
		DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] List();
		[OperationContract]
		DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] Query(CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT cause);
		[OperationContract]
		DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] Query(CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj);
        [OperationContract]
        EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT[] saveEntities, EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT[] updateEntities, EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
