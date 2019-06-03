
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
		
[ServiceKnownType(typeof(EntityObject_SCM_D_SENDDEPART))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_SCM_D_SUPPLYPLAN))]	
	public partial interface ServiceContract_SCM_D_SUPPLYPLAN: IServiceContractLocal<EntityObject_SCM_D_SUPPLYPLAN, CauseObject_SCM_D_SUPPLYPLAN>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_D_SUPPLYPLAN obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_D_SUPPLYPLAN obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_D_SUPPLYPLAN obj);
		[OperationContract]
		EntityObject_SCM_D_SUPPLYPLAN Get(EntityObject_SCM_D_SUPPLYPLAN obj);
		[OperationContract]
		DisplayObject_SCM_D_SUPPLYPLAN[] List();
		[OperationContract]
		DisplayObject_SCM_D_SUPPLYPLAN[] Query(CauseObject_SCM_D_SUPPLYPLAN cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_D_SUPPLYPLAN cause);
		[OperationContract]
		DisplayObject_SCM_D_SUPPLYPLAN[] Query(CauseObject_SCM_D_SUPPLYPLAN cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_D_SUPPLYPLAN[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_D_SUPPLYPLAN[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_D_SUPPLYPLAN[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_D_SUPPLYPLAN obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_D_SUPPLYPLAN obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_D_SUPPLYPLAN obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_D_SUPPLYPLAN obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_D_SUPPLYPLAN obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_D_SUPPLYPLAN obj);
        [OperationContract]
        EntityObject_SCM_D_SUPPLYPLAN Load(string id , out EntityObject_SCM_D_SENDDEPART send_depart);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_SUPPLYPLAN[] saveEntities, EntityObject_SCM_D_SUPPLYPLAN[] updateEntities, EntityObject_SCM_D_SUPPLYPLAN[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_D_SUPPLYPLAN saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_D_SUPPLYPLAN deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_SUPPLYPLAN updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
