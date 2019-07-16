#define NESTING
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
    [ServiceKnownType(typeof(EntityObject_BGT_B_PAY_PERSON_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_YEAR))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_PAY_PERSON))]	
	public partial interface ServiceContract_BGT_B_PAY_PERSON: IServiceContractLocal<EntityObject_BGT_B_PAY_PERSON, CauseObject_BGT_B_PAY_PERSON>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_PAY_PERSON obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_PAY_PERSON obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_PAY_PERSON obj);
		[OperationContract]
		EntityObject_BGT_B_PAY_PERSON Get(EntityObject_BGT_B_PAY_PERSON obj);
		[OperationContract]
		DisplayObject_BGT_B_PAY_PERSON[] List();
		[OperationContract]
		DisplayObject_BGT_B_PAY_PERSON[] Query(CauseObject_BGT_B_PAY_PERSON cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_PAY_PERSON cause);
		[OperationContract]
		DisplayObject_BGT_B_PAY_PERSON[] Query(CauseObject_BGT_B_PAY_PERSON cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_PAY_PERSON[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_PAY_PERSON[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_PAY_PERSON[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_PAY_PERSON obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_PAY_PERSON obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_PAY_PERSON obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_PAY_PERSON obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_PAY_PERSON obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_PAY_PERSON obj);
        [OperationContract]
        EntityObject_BGT_B_PAY_PERSON Load(string id , out EntityObject_BGT_D_BUDGET_DEPT budget_dept_id, out EntityObject_BGT_D_BUDGET_YEAR budget_year);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_PAY_PERSON[] saveEntities, EntityObject_BGT_B_PAY_PERSON[] updateEntities, EntityObject_BGT_B_PAY_PERSON[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_B_PAY_PERSON saveBaseEntity, EntityObject_BGT_B_PAY_PERSON_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_PAY_PERSON deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_PAY_PERSON updateBaseEntity, EntityObject_BGT_B_PAY_PERSON_D[] saveDetailEntities, EntityObject_BGT_B_PAY_PERSON_D[] updateDetailEntities, EntityObject_BGT_B_PAY_PERSON_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
