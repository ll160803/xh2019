
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
		
[ServiceKnownType(typeof(EntityObject_COM_FILE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_SCM_B_QUOTEDPRICE_D))]	
	public partial interface ServiceContract_SCM_B_QUOTEDPRICE_D: IServiceContractLocal<EntityObject_SCM_B_QUOTEDPRICE_D, CauseObject_SCM_B_QUOTEDPRICE_D>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_B_QUOTEDPRICE_D obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_B_QUOTEDPRICE_D obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_B_QUOTEDPRICE_D obj);
		[OperationContract]
		EntityObject_SCM_B_QUOTEDPRICE_D Get(EntityObject_SCM_B_QUOTEDPRICE_D obj);
		[OperationContract]
		DisplayObject_SCM_B_QUOTEDPRICE_D[] List();
		[OperationContract]
		DisplayObject_SCM_B_QUOTEDPRICE_D[] Query(CauseObject_SCM_B_QUOTEDPRICE_D cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_B_QUOTEDPRICE_D cause);
		[OperationContract]
		DisplayObject_SCM_B_QUOTEDPRICE_D[] Query(CauseObject_SCM_B_QUOTEDPRICE_D cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_B_QUOTEDPRICE_D[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_B_QUOTEDPRICE_D[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_B_QUOTEDPRICE_D[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_B_QUOTEDPRICE_D obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_B_QUOTEDPRICE_D obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_B_QUOTEDPRICE_D obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_B_QUOTEDPRICE_D obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_B_QUOTEDPRICE_D obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_B_QUOTEDPRICE_D obj);
        [OperationContract]
        EntityObject_SCM_B_QUOTEDPRICE_D Load(string id , out EntityObject_COM_FILE com_file_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_QUOTEDPRICE_D[] saveEntities, EntityObject_SCM_B_QUOTEDPRICE_D[] updateEntities, EntityObject_SCM_B_QUOTEDPRICE_D[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_B_QUOTEDPRICE_D saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_B_QUOTEDPRICE_D deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_QUOTEDPRICE_D updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
