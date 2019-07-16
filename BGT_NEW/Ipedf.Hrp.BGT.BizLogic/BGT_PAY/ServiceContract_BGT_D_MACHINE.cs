
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
	[ServiceKnownType(typeof(EntityObject_BGT_D_MACHINE))]	
	public partial interface ServiceContract_BGT_D_MACHINE: IServiceContractLocal<EntityObject_BGT_D_MACHINE, CauseObject_BGT_D_MACHINE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_MACHINE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_MACHINE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_MACHINE obj);
		[OperationContract]
		EntityObject_BGT_D_MACHINE Get(EntityObject_BGT_D_MACHINE obj);
		[OperationContract]
		DisplayObject_BGT_D_MACHINE[] List();
		[OperationContract]
		DisplayObject_BGT_D_MACHINE[] Query(CauseObject_BGT_D_MACHINE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_MACHINE cause);
		[OperationContract]
		DisplayObject_BGT_D_MACHINE[] Query(CauseObject_BGT_D_MACHINE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_MACHINE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_MACHINE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_MACHINE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_MACHINE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_MACHINE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_MACHINE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_MACHINE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_MACHINE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_MACHINE obj);
        [OperationContract]
        EntityObject_BGT_D_MACHINE Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_MACHINE[] saveEntities, EntityObject_BGT_D_MACHINE[] updateEntities, EntityObject_BGT_D_MACHINE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_D_MACHINE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_D_MACHINE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_MACHINE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
