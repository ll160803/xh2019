
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
	[ServiceKnownType(typeof(EntityObject_V_COM_QUERY_MENUS))]	
	public partial interface ServiceContract_V_COM_QUERY_MENUS: IServiceContractLocal<EntityObject_V_COM_QUERY_MENUS, CauseObject_V_COM_QUERY_MENUS>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_COM_QUERY_MENUS obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_COM_QUERY_MENUS obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_COM_QUERY_MENUS obj);
		[OperationContract]
		EntityObject_V_COM_QUERY_MENUS Get(EntityObject_V_COM_QUERY_MENUS obj);
		[OperationContract]
		DisplayObject_V_COM_QUERY_MENUS[] List();
		[OperationContract]
		DisplayObject_V_COM_QUERY_MENUS[] Query(CauseObject_V_COM_QUERY_MENUS cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_COM_QUERY_MENUS cause);
		[OperationContract]
		DisplayObject_V_COM_QUERY_MENUS[] Query(CauseObject_V_COM_QUERY_MENUS cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_COM_QUERY_MENUS[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_COM_QUERY_MENUS[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_COM_QUERY_MENUS[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_COM_QUERY_MENUS obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_COM_QUERY_MENUS obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_COM_QUERY_MENUS obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_COM_QUERY_MENUS obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_COM_QUERY_MENUS obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_COM_QUERY_MENUS obj);
        [OperationContract]
        EntityObject_V_COM_QUERY_MENUS Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_COM_QUERY_MENUS[] saveEntities, EntityObject_V_COM_QUERY_MENUS[] updateEntities, EntityObject_V_COM_QUERY_MENUS[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_COM_QUERY_MENUS saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_COM_QUERY_MENUS deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_COM_QUERY_MENUS updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
