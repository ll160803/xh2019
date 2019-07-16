
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
	[ServiceKnownType(typeof(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND))]	
	public partial interface ServiceContract_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND: IServiceContractLocal<EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND, CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj);
		[OperationContract]
		EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND Get(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj);
		[OperationContract]
		DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] List();
		[OperationContract]
		DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] Query(CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause);
		[OperationContract]
		DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] Query(CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj);
        [OperationContract]
        EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] saveEntities, EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] updateEntities, EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
