
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
	[ServiceKnownType(typeof(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL))]	
	public partial interface ServiceContract_V_SCM_B_QUOTEDPRICE_DETAIL: IServiceContractLocal<EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL, CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj);
		[OperationContract]
		EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL Get(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj);
		[OperationContract]
		DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] List();
		[OperationContract]
		DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] Query(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause);
		[OperationContract]
		DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] Query(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj);
        [OperationContract]
        EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] saveEntities, EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] updateEntities, EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
