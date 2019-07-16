
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
	[ServiceKnownType(typeof(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE))]	
	public partial interface ServiceContract_V_BGT_B_FUND_EXE_ADD_UPDATE: IServiceContractLocal<EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE, CauseObject_V_BGT_B_FUND_EXE_ADD_UPDATE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE obj);
		[OperationContract]
		EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE Get(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE obj);
		[OperationContract]
		DisplayObject_V_BGT_B_FUND_EXE_ADD_UPDATE[] List();
		[OperationContract]
		DisplayObject_V_BGT_B_FUND_EXE_ADD_UPDATE[] Query(CauseObject_V_BGT_B_FUND_EXE_ADD_UPDATE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_BGT_B_FUND_EXE_ADD_UPDATE cause);
		[OperationContract]
		DisplayObject_V_BGT_B_FUND_EXE_ADD_UPDATE[] Query(CauseObject_V_BGT_B_FUND_EXE_ADD_UPDATE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE obj);
        [OperationContract]
        EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE[] saveEntities, EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE[] updateEntities, EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_B_FUND_EXE_ADD_UPDATE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
