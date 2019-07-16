
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
	[ServiceKnownType(typeof(EntityObject_V_BGT_ADJUST_FUND_MONEY))]	
	public partial interface ServiceContract_V_BGT_ADJUST_FUND_MONEY: IServiceContractLocal<EntityObject_V_BGT_ADJUST_FUND_MONEY, CauseObject_V_BGT_ADJUST_FUND_MONEY>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_BGT_ADJUST_FUND_MONEY obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_BGT_ADJUST_FUND_MONEY obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_BGT_ADJUST_FUND_MONEY obj);
		[OperationContract]
		EntityObject_V_BGT_ADJUST_FUND_MONEY Get(EntityObject_V_BGT_ADJUST_FUND_MONEY obj);
		[OperationContract]
		DisplayObject_V_BGT_ADJUST_FUND_MONEY[] List();
		[OperationContract]
		DisplayObject_V_BGT_ADJUST_FUND_MONEY[] Query(CauseObject_V_BGT_ADJUST_FUND_MONEY cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_BGT_ADJUST_FUND_MONEY cause);
		[OperationContract]
		DisplayObject_V_BGT_ADJUST_FUND_MONEY[] Query(CauseObject_V_BGT_ADJUST_FUND_MONEY cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_BGT_ADJUST_FUND_MONEY[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_BGT_ADJUST_FUND_MONEY[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_BGT_ADJUST_FUND_MONEY[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_BGT_ADJUST_FUND_MONEY obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_BGT_ADJUST_FUND_MONEY obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_BGT_ADJUST_FUND_MONEY obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_BGT_ADJUST_FUND_MONEY obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_BGT_ADJUST_FUND_MONEY obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_BGT_ADJUST_FUND_MONEY obj);
        [OperationContract]
        EntityObject_V_BGT_ADJUST_FUND_MONEY Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_ADJUST_FUND_MONEY[] saveEntities, EntityObject_V_BGT_ADJUST_FUND_MONEY[] updateEntities, EntityObject_V_BGT_ADJUST_FUND_MONEY[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_BGT_ADJUST_FUND_MONEY saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_BGT_ADJUST_FUND_MONEY deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_ADJUST_FUND_MONEY updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
