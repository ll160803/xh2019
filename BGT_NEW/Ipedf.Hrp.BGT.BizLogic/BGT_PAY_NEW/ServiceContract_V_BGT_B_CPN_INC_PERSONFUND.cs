
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
	[ServiceKnownType(typeof(EntityObject_V_BGT_B_CPN_INC_PERSONFUND))]	
	public partial interface ServiceContract_V_BGT_B_CPN_INC_PERSONFUND: IServiceContractLocal<EntityObject_V_BGT_B_CPN_INC_PERSONFUND, CauseObject_V_BGT_B_CPN_INC_PERSONFUND>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj);
		[OperationContract]
		EntityObject_V_BGT_B_CPN_INC_PERSONFUND Get(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj);
		[OperationContract]
		DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[] List();
		[OperationContract]
		DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[] Query(CauseObject_V_BGT_B_CPN_INC_PERSONFUND cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_BGT_B_CPN_INC_PERSONFUND cause);
		[OperationContract]
		DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[] Query(CauseObject_V_BGT_B_CPN_INC_PERSONFUND cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_BGT_B_CPN_INC_PERSONFUND[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_BGT_B_CPN_INC_PERSONFUND[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_BGT_B_CPN_INC_PERSONFUND[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj);
        [OperationContract]
        EntityObject_V_BGT_B_CPN_INC_PERSONFUND Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_B_CPN_INC_PERSONFUND[] saveEntities, EntityObject_V_BGT_B_CPN_INC_PERSONFUND[] updateEntities, EntityObject_V_BGT_B_CPN_INC_PERSONFUND[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_BGT_B_CPN_INC_PERSONFUND saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_BGT_B_CPN_INC_PERSONFUND deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_B_CPN_INC_PERSONFUND updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
