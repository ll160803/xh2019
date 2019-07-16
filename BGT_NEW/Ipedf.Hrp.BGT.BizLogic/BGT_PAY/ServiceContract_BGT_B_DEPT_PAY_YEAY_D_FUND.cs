
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
		
[ServiceKnownType(typeof(EntityObject_BGT_D_ACCOUNT_ITEM))]	
[ServiceKnownType(typeof(EntityObject_BGT_D_ACCOUNT_ITEM))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND))]	
	public partial interface ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND: IServiceContractLocal<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND, CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj);
		[OperationContract]
		EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND Get(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] List();
		[OperationContract]
		DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] Query(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] Query(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj);
        [OperationContract]
        EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND Load(string id , out EntityObject_BGT_D_ACCOUNT_ITEM account_item_id, out EntityObject_BGT_D_ACCOUNT_ITEM bgt_d_account_item_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] saveEntities, EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] updateEntities, EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
