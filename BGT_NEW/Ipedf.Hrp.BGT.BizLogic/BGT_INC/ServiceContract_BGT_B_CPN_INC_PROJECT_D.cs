
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
	[ServiceKnownType(typeof(EntityObject_BGT_B_CPN_INC_PROJECT_D))]	
	public partial interface ServiceContract_BGT_B_CPN_INC_PROJECT_D: IServiceContractLocal<EntityObject_BGT_B_CPN_INC_PROJECT_D, CauseObject_BGT_B_CPN_INC_PROJECT_D>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_CPN_INC_PROJECT_D obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_CPN_INC_PROJECT_D obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_CPN_INC_PROJECT_D obj);
		[OperationContract]
		EntityObject_BGT_B_CPN_INC_PROJECT_D Get(EntityObject_BGT_B_CPN_INC_PROJECT_D obj);
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_PROJECT_D[] List();
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_PROJECT_D[] Query(CauseObject_BGT_B_CPN_INC_PROJECT_D cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_CPN_INC_PROJECT_D cause);
		[OperationContract]
		DisplayObject_BGT_B_CPN_INC_PROJECT_D[] Query(CauseObject_BGT_B_CPN_INC_PROJECT_D cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_CPN_INC_PROJECT_D[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_CPN_INC_PROJECT_D[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_CPN_INC_PROJECT_D[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_CPN_INC_PROJECT_D obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_CPN_INC_PROJECT_D obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_CPN_INC_PROJECT_D obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_CPN_INC_PROJECT_D obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_CPN_INC_PROJECT_D obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_CPN_INC_PROJECT_D obj);
        [OperationContract]
        EntityObject_BGT_B_CPN_INC_PROJECT_D Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_INC_PROJECT_D[] saveEntities, EntityObject_BGT_B_CPN_INC_PROJECT_D[] updateEntities, EntityObject_BGT_B_CPN_INC_PROJECT_D[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_B_CPN_INC_PROJECT_D saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_CPN_INC_PROJECT_D deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_CPN_INC_PROJECT_D updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
