
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
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H))]	
	public partial interface ServiceContract_BGT_B_DEPT_PAY_YEAY_D_FUND_H: IServiceContractLocal<EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H, CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj);
		[OperationContract]
		EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H Get(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] List();
		[OperationContract]
		DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] Query(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H cause);
		[OperationContract]
		DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] Query(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H obj);
        [OperationContract]
        EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H Load(string id , out EntityObject_COM_TYPE step_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] saveEntities, EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] updateEntities, EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND_H updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
