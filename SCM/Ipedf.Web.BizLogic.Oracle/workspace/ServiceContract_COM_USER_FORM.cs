
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
		
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_FORM))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_COM_USER_FORM))]	
	public partial interface ServiceContract_COM_USER_FORM: IServiceContractLocal<EntityObject_COM_USER_FORM, CauseObject_COM_USER_FORM>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_USER_FORM obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_USER_FORM obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_USER_FORM obj);
		[OperationContract]
		EntityObject_COM_USER_FORM Get(EntityObject_COM_USER_FORM obj);
		[OperationContract]
		DisplayObject_COM_USER_FORM[] List();
		[OperationContract]
		DisplayObject_COM_USER_FORM[] Query(CauseObject_COM_USER_FORM cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_USER_FORM cause);
		[OperationContract]
		DisplayObject_COM_USER_FORM[] Query(CauseObject_COM_USER_FORM cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_USER_FORM[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_USER_FORM[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_USER_FORM[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_USER_FORM obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_USER_FORM obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_USER_FORM obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_USER_FORM obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_USER_FORM obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_USER_FORM obj);
        [OperationContract]
        EntityObject_COM_USER_FORM Load(string id , out EntityObject_COM_USER user_id, out EntityObject_COM_FORM form_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_COM_USER_FORM[] saveEntities, EntityObject_COM_USER_FORM[] updateEntities, EntityObject_COM_USER_FORM[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_COM_USER_FORM saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_COM_USER_FORM deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_COM_USER_FORM updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
