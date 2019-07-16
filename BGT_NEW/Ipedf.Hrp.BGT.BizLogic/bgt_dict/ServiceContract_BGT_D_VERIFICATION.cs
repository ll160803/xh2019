
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
		
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_D_VERIFICATION))]	
	public partial interface ServiceContract_BGT_D_VERIFICATION: IServiceContractLocal<EntityObject_BGT_D_VERIFICATION, CauseObject_BGT_D_VERIFICATION>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_VERIFICATION obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_VERIFICATION obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_VERIFICATION obj);
		[OperationContract]
		EntityObject_BGT_D_VERIFICATION Get(EntityObject_BGT_D_VERIFICATION obj);
		[OperationContract]
		DisplayObject_BGT_D_VERIFICATION[] List();
		[OperationContract]
		DisplayObject_BGT_D_VERIFICATION[] Query(CauseObject_BGT_D_VERIFICATION cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_VERIFICATION cause);
		[OperationContract]
		DisplayObject_BGT_D_VERIFICATION[] Query(CauseObject_BGT_D_VERIFICATION cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_VERIFICATION[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_VERIFICATION[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_VERIFICATION[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_VERIFICATION obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_VERIFICATION obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_VERIFICATION obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_VERIFICATION obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_VERIFICATION obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_VERIFICATION obj);
        [OperationContract]
        EntityObject_BGT_D_VERIFICATION Load(string id , out EntityObject_COM_TYPE import_type_id, out EntityObject_COM_TYPE source_type_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_COM_TYPE item_type_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_VERIFICATION[] saveEntities, EntityObject_BGT_D_VERIFICATION[] updateEntities, EntityObject_BGT_D_VERIFICATION[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_BGT_D_VERIFICATION saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_BGT_D_VERIFICATION deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_VERIFICATION updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
