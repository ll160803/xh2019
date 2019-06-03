
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
	[ServiceKnownType(typeof(EntityObject_SCM_B_SENDINFO))]	
	public partial interface ServiceContract_SCM_B_SENDINFO: IServiceContractLocal<EntityObject_SCM_B_SENDINFO, CauseObject_SCM_B_SENDINFO>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_B_SENDINFO obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_B_SENDINFO obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_B_SENDINFO obj);
		[OperationContract]
		EntityObject_SCM_B_SENDINFO Get(EntityObject_SCM_B_SENDINFO obj);
		[OperationContract]
		DisplayObject_SCM_B_SENDINFO[] List();
		[OperationContract]
		DisplayObject_SCM_B_SENDINFO[] Query(CauseObject_SCM_B_SENDINFO cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_B_SENDINFO cause);
		[OperationContract]
		DisplayObject_SCM_B_SENDINFO[] Query(CauseObject_SCM_B_SENDINFO cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_B_SENDINFO[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_B_SENDINFO[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_B_SENDINFO[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_B_SENDINFO obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_B_SENDINFO obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_B_SENDINFO obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_B_SENDINFO obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_B_SENDINFO obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_B_SENDINFO obj);
        [OperationContract]
        EntityObject_SCM_B_SENDINFO Load(string id , out EntityObject_SCM_D_SENDDEPART send_depart);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_SENDINFO[] saveEntities, EntityObject_SCM_B_SENDINFO[] updateEntities, EntityObject_SCM_B_SENDINFO[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_B_SENDINFO saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_B_SENDINFO deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_B_SENDINFO updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
