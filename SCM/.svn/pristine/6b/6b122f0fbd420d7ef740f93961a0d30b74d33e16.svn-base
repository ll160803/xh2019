
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
		
[ServiceKnownType(typeof(EntityObject_COM_DATA))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_STRATEGY))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_COM_USER_M_DATA))]	
	public partial interface ServiceContract_COM_USER_M_DATA: IServiceContractLocal<EntityObject_COM_USER_M_DATA, CauseObject_COM_USER_M_DATA>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_USER_M_DATA obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_USER_M_DATA obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_USER_M_DATA obj);
		[OperationContract]
		EntityObject_COM_USER_M_DATA Get(EntityObject_COM_USER_M_DATA obj);
		[OperationContract]
		DisplayObject_COM_USER_M_DATA[] List();
		[OperationContract]
		DisplayObject_COM_USER_M_DATA[] Query(CauseObject_COM_USER_M_DATA cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_USER_M_DATA cause);
		[OperationContract]
		DisplayObject_COM_USER_M_DATA[] Query(CauseObject_COM_USER_M_DATA cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_USER_M_DATA[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_USER_M_DATA[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_USER_M_DATA[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_USER_M_DATA obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_USER_M_DATA obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_USER_M_DATA obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_USER_M_DATA obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_USER_M_DATA obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_USER_M_DATA obj);
        [OperationContract]
        EntityObject_COM_USER_M_DATA Load(string id , out EntityObject_COM_DATA data_id, out EntityObject_COM_USER user_id, out EntityObject_COM_STRATEGY strategy_id);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_USER_M_DATA[] saveEntities, EntityObject_COM_USER_M_DATA[] updateEntities, EntityObject_COM_USER_M_DATA[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_COM_USER_M_DATA saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_COM_USER_M_DATA deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_USER_M_DATA updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
