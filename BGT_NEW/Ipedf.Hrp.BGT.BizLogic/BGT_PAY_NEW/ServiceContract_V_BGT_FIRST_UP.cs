
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
	[ServiceKnownType(typeof(EntityObject_V_BGT_FIRST_UP))]	
	public partial interface ServiceContract_V_BGT_FIRST_UP: IServiceContractLocal<EntityObject_V_BGT_FIRST_UP, CauseObject_V_BGT_FIRST_UP>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_BGT_FIRST_UP obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_BGT_FIRST_UP obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_BGT_FIRST_UP obj);
		[OperationContract]
		EntityObject_V_BGT_FIRST_UP Get(EntityObject_V_BGT_FIRST_UP obj);
		[OperationContract]
		DisplayObject_V_BGT_FIRST_UP[] List();
		[OperationContract]
		DisplayObject_V_BGT_FIRST_UP[] Query(CauseObject_V_BGT_FIRST_UP cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_BGT_FIRST_UP cause);
		[OperationContract]
		DisplayObject_V_BGT_FIRST_UP[] Query(CauseObject_V_BGT_FIRST_UP cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_BGT_FIRST_UP[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_BGT_FIRST_UP[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_BGT_FIRST_UP[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_BGT_FIRST_UP obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_BGT_FIRST_UP obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_BGT_FIRST_UP obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_BGT_FIRST_UP obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_BGT_FIRST_UP obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_BGT_FIRST_UP obj);
        [OperationContract]
        EntityObject_V_BGT_FIRST_UP Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_FIRST_UP[] saveEntities, EntityObject_V_BGT_FIRST_UP[] updateEntities, EntityObject_V_BGT_FIRST_UP[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_BGT_FIRST_UP saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_BGT_FIRST_UP deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_FIRST_UP updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
