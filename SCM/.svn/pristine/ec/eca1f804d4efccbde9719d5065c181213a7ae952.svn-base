
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
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_SCM_B_QUERYPRICE))]	
	public partial interface ServiceContract_SCM_B_QUERYPRICE: IServiceContractLocal<EntityObject_SCM_B_QUERYPRICE, CauseObject_SCM_B_QUERYPRICE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_B_QUERYPRICE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_B_QUERYPRICE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_B_QUERYPRICE obj);
		[OperationContract]
		EntityObject_SCM_B_QUERYPRICE Get(EntityObject_SCM_B_QUERYPRICE obj);
		[OperationContract]
		DisplayObject_SCM_B_QUERYPRICE Get(DisplayObject_SCM_B_QUERYPRICE obj);
		[OperationContract]
		DisplayObject_SCM_B_QUERYPRICE[] List();
		[OperationContract]
		DisplayObject_SCM_B_QUERYPRICE[] Query(CauseObject_SCM_B_QUERYPRICE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_B_QUERYPRICE cause);
		[OperationContract]
		DisplayObject_SCM_B_QUERYPRICE[] Query(CauseObject_SCM_B_QUERYPRICE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_B_QUERYPRICE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_B_QUERYPRICE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_B_QUERYPRICE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_B_QUERYPRICE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_B_QUERYPRICE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_B_QUERYPRICE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_B_QUERYPRICE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_B_QUERYPRICE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_B_QUERYPRICE obj);
        [OperationContract]
        EntityObject_SCM_B_QUERYPRICE Load(string id , out EntityObject_COM_DEPART dept_id, out EntityObject_COM_TYPE query_state, out EntityObject_COM_TYPE query_type);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_QUERYPRICE[] saveEntities, EntityObject_SCM_B_QUERYPRICE[] updateEntities, EntityObject_SCM_B_QUERYPRICE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_B_QUERYPRICE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_B_QUERYPRICE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_QUERYPRICE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
