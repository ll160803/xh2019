
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
	[ServiceKnownType(typeof(EntityObject_SCM_B_QUOTEDPRICE))]	
	public partial interface ServiceContract_SCM_B_QUOTEDPRICE: IServiceContractLocal<EntityObject_SCM_B_QUOTEDPRICE, CauseObject_SCM_B_QUOTEDPRICE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_B_QUOTEDPRICE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_B_QUOTEDPRICE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_B_QUOTEDPRICE obj);
		[OperationContract]
		EntityObject_SCM_B_QUOTEDPRICE Get(EntityObject_SCM_B_QUOTEDPRICE obj);
		[OperationContract]
		DisplayObject_SCM_B_QUOTEDPRICE[] List();
		[OperationContract]
		DisplayObject_SCM_B_QUOTEDPRICE[] Query(CauseObject_SCM_B_QUOTEDPRICE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_B_QUOTEDPRICE cause);
		[OperationContract]
		DisplayObject_SCM_B_QUOTEDPRICE[] Query(CauseObject_SCM_B_QUOTEDPRICE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_B_QUOTEDPRICE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_B_QUOTEDPRICE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_B_QUOTEDPRICE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_B_QUOTEDPRICE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_B_QUOTEDPRICE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_B_QUOTEDPRICE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_B_QUOTEDPRICE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_B_QUOTEDPRICE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_B_QUOTEDPRICE obj);
        [OperationContract]
        EntityObject_SCM_B_QUOTEDPRICE Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_QUOTEDPRICE[] saveEntities, EntityObject_SCM_B_QUOTEDPRICE[] updateEntities, EntityObject_SCM_B_QUOTEDPRICE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_B_QUOTEDPRICE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_B_QUOTEDPRICE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_QUOTEDPRICE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
