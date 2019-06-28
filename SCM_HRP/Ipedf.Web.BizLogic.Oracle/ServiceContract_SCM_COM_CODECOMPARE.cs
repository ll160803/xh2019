
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
	[ServiceKnownType(typeof(EntityObject_SCM_COM_CODECOMPARE))]	
	public partial interface ServiceContract_SCM_COM_CODECOMPARE: IServiceContractLocal<EntityObject_SCM_COM_CODECOMPARE, CauseObject_SCM_COM_CODECOMPARE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_COM_CODECOMPARE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_COM_CODECOMPARE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_COM_CODECOMPARE obj);
		[OperationContract]
		EntityObject_SCM_COM_CODECOMPARE Get(EntityObject_SCM_COM_CODECOMPARE obj);
		[OperationContract]
		DisplayObject_SCM_COM_CODECOMPARE[] List();
		[OperationContract]
		DisplayObject_SCM_COM_CODECOMPARE[] Query(CauseObject_SCM_COM_CODECOMPARE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_COM_CODECOMPARE cause);
		[OperationContract]
		DisplayObject_SCM_COM_CODECOMPARE[] Query(CauseObject_SCM_COM_CODECOMPARE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_COM_CODECOMPARE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_COM_CODECOMPARE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_COM_CODECOMPARE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_COM_CODECOMPARE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_COM_CODECOMPARE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_COM_CODECOMPARE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_COM_CODECOMPARE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_COM_CODECOMPARE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_COM_CODECOMPARE obj);
        [OperationContract]
        EntityObject_SCM_COM_CODECOMPARE Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_COM_CODECOMPARE[] saveEntities, EntityObject_SCM_COM_CODECOMPARE[] updateEntities, EntityObject_SCM_COM_CODECOMPARE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_COM_CODECOMPARE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_COM_CODECOMPARE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_COM_CODECOMPARE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
