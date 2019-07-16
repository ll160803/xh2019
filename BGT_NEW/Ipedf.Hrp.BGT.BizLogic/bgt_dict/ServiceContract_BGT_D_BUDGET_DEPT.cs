
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
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]	
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_COM_TYPE))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]	
	public partial interface ServiceContract_BGT_D_BUDGET_DEPT: IServiceContractLocal<EntityObject_BGT_D_BUDGET_DEPT, CauseObject_BGT_D_BUDGET_DEPT>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_D_BUDGET_DEPT obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_D_BUDGET_DEPT obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_DEPT obj);
		[OperationContract]
		EntityObject_BGT_D_BUDGET_DEPT Get(EntityObject_BGT_D_BUDGET_DEPT obj);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_DEPT[] List();
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_DEPT[] Query(CauseObject_BGT_D_BUDGET_DEPT cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_DEPT cause);
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_DEPT[] Query(CauseObject_BGT_D_BUDGET_DEPT cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_DEPT[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_DEPT[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_DEPT[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_DEPT obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_DEPT obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_DEPT obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_DEPT obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_DEPT obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_DEPT obj);
        [OperationContract]
        EntityObject_BGT_D_BUDGET_DEPT Load(string id , out EntityObject_BGT_D_BUDGET_YEAR budget_year, out EntityObject_COM_TYPE dept_property_id, out EntityObject_COM_DEPART dept_id, out EntityObject_COM_TYPE dept_type_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_DEPT[] saveEntities, EntityObject_BGT_D_BUDGET_DEPT[] updateEntities, EntityObject_BGT_D_BUDGET_DEPT[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_BGT_D_BUDGET_DEPT saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_BGT_D_BUDGET_DEPT deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_DEPT updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
