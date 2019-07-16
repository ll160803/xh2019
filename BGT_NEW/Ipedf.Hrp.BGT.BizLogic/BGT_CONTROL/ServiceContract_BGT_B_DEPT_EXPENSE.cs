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
    [ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_EXPENSE_D))]
	#endif
		
[ServiceKnownType(typeof(EntityObject_COM_DEPART))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]	
[ServiceKnownType(typeof(EntityObject_COM_USER))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_EXPENSE))]	
	public partial interface ServiceContract_BGT_B_DEPT_EXPENSE: IServiceContractLocal<EntityObject_BGT_B_DEPT_EXPENSE, CauseObject_BGT_B_DEPT_EXPENSE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_DEPT_EXPENSE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_DEPT_EXPENSE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_DEPT_EXPENSE obj);
		[OperationContract]
		EntityObject_BGT_B_DEPT_EXPENSE Get(EntityObject_BGT_B_DEPT_EXPENSE obj);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_EXPENSE[] List();
		[OperationContract]
		DisplayObject_BGT_B_DEPT_EXPENSE[] Query(CauseObject_BGT_B_DEPT_EXPENSE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_DEPT_EXPENSE cause);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_EXPENSE[] Query(CauseObject_BGT_B_DEPT_EXPENSE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_DEPT_EXPENSE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_DEPT_EXPENSE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_DEPT_EXPENSE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_DEPT_EXPENSE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_DEPT_EXPENSE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_DEPT_EXPENSE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_DEPT_EXPENSE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_DEPT_EXPENSE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_DEPT_EXPENSE obj);
        [OperationContract]
        EntityObject_BGT_B_DEPT_EXPENSE Load(string id , out EntityObject_COM_DEPART apply_dept_id, out EntityObject_COM_USER apply_user_id, out EntityObject_COM_USER pay_user_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_EXPENSE[] saveEntities, EntityObject_BGT_B_DEPT_EXPENSE[] updateEntities, EntityObject_BGT_B_DEPT_EXPENSE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
        BizLogicMsg CommitSave(EntityObject_BGT_B_DEPT_EXPENSE saveBaseEntity, EntityObject_BGT_B_DEPT_EXPENSE_D[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_DEPT_EXPENSE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_EXPENSE updateBaseEntity, EntityObject_BGT_B_DEPT_EXPENSE_D[] saveDetailEntities, EntityObject_BGT_B_DEPT_EXPENSE_D[] updateDetailEntities, EntityObject_BGT_B_DEPT_EXPENSE_D[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
