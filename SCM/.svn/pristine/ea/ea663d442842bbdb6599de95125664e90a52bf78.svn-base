
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
	[ServiceKnownType(typeof(EntityObject_V_GETPERSON))]	
	public partial interface ServiceContract_V_GETPERSON: IServiceContractLocal<EntityObject_V_GETPERSON, CauseObject_V_GETPERSON>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_GETPERSON obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_GETPERSON obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_GETPERSON obj);
		[OperationContract]
		EntityObject_V_GETPERSON Get(EntityObject_V_GETPERSON obj);
		[OperationContract]
		DisplayObject_V_GETPERSON[] List();
		[OperationContract]
		DisplayObject_V_GETPERSON[] Query(CauseObject_V_GETPERSON cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_GETPERSON cause);
		[OperationContract]
		DisplayObject_V_GETPERSON[] Query(CauseObject_V_GETPERSON cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_GETPERSON[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_GETPERSON[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_GETPERSON[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_GETPERSON obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_GETPERSON obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_GETPERSON obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_GETPERSON obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_GETPERSON obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_GETPERSON obj);
        [OperationContract]
        EntityObject_V_GETPERSON Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_GETPERSON[] saveEntities, EntityObject_V_GETPERSON[] updateEntities, EntityObject_V_GETPERSON[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_GETPERSON saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_GETPERSON deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_GETPERSON updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
