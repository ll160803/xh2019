
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
		
[ServiceKnownType(typeof(EntityObject_MTR_D_MTR))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_MDM_D_DEPT))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_MTR_B_OUTSTOCK_D))]	
	public partial interface ServiceContract_MTR_B_OUTSTOCK_D: IServiceContractLocal<EntityObject_MTR_B_OUTSTOCK_D, CauseObject_MTR_B_OUTSTOCK_D>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_MTR_B_OUTSTOCK_D obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_MTR_B_OUTSTOCK_D obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_MTR_B_OUTSTOCK_D obj);
		[OperationContract]
		EntityObject_MTR_B_OUTSTOCK_D Get(EntityObject_MTR_B_OUTSTOCK_D obj);
		[OperationContract]
		DisplayObject_MTR_B_OUTSTOCK_D[] List();
		[OperationContract]
		DisplayObject_MTR_B_OUTSTOCK_D[] Query(CauseObject_MTR_B_OUTSTOCK_D cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_MTR_B_OUTSTOCK_D cause);
		[OperationContract]
		DisplayObject_MTR_B_OUTSTOCK_D[] Query(CauseObject_MTR_B_OUTSTOCK_D cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_MTR_B_OUTSTOCK_D[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_MTR_B_OUTSTOCK_D[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_MTR_B_OUTSTOCK_D[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_MTR_B_OUTSTOCK_D obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_MTR_B_OUTSTOCK_D obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_MTR_B_OUTSTOCK_D obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_MTR_B_OUTSTOCK_D obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_MTR_B_OUTSTOCK_D obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_MTR_B_OUTSTOCK_D obj);
        [OperationContract]
        EntityObject_MTR_B_OUTSTOCK_D Load(string id , out EntityObject_MTR_D_MTR mater_id, out EntityObject_COM_TYPE unit_id, out EntityObject_MDM_D_DEPT prd_id);
        [OperationContract]
        void CommitUpdate(EntityObject_MTR_B_OUTSTOCK_D[] saveEntities, EntityObject_MTR_B_OUTSTOCK_D[] updateEntities, EntityObject_MTR_B_OUTSTOCK_D[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_MTR_B_OUTSTOCK_D saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_MTR_B_OUTSTOCK_D deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_MTR_B_OUTSTOCK_D updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
