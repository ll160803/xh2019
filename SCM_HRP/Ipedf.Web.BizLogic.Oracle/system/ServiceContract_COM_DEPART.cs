
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
		
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
	public partial interface ServiceContract_COM_DEPART: IServiceContractLocal<EntityObject_COM_DEPART, CauseObject_COM_DEPART>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_DEPART obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_DEPART obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_DEPART obj);
		[OperationContract]
		EntityObject_COM_DEPART Get(EntityObject_COM_DEPART obj);
		[OperationContract]
		DisplayObject_COM_DEPART[] List();
		[OperationContract]
		DisplayObject_COM_DEPART[] Query(CauseObject_COM_DEPART cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_DEPART cause);
		[OperationContract]
		DisplayObject_COM_DEPART[] Query(CauseObject_COM_DEPART cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_DEPART[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_DEPART[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_DEPART[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_DEPART obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_DEPART obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_DEPART obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_DEPART obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_DEPART obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_DEPART obj);
        [OperationContract]
        EntityObject_COM_DEPART Load(string id , out EntityObject_COM_DEPART parent_id, out EntityObject_COM_USER head_user_id);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_DEPART[] saveEntities, EntityObject_COM_DEPART[] updateEntities, EntityObject_COM_DEPART[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_COM_DEPART saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_COM_DEPART deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_DEPART updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
