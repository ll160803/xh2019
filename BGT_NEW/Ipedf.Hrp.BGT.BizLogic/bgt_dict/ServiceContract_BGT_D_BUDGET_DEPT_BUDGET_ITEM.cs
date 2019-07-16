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

    [ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_ITEM))]
    [ServiceContract]
    [ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM))]
    public partial interface ServiceContract_BGT_D_BUDGET_DEPT_BUDGET_ITEM : IServiceContractLocal<EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM, CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM>
    {
        [OperationContract]
        BizLogicMsg Save(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj);
        [OperationContract]
        BizLogicMsg Update(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj);
        [OperationContract]
        BizLogicMsg Delete(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj);
        [OperationContract]
        EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM Get(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj);
        [OperationContract]
        DisplayObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] List();
        [OperationContract]
        DisplayObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] Query(CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM cause);
        [OperationContract]
        BizLogicMsg Delete(CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM cause);
        [OperationContract]
        DisplayObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] Query(CauseObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM cause, PagingParamter paging, OrderByParameter order);
        [OperationContract]
        BizLogicMsg BatchSave(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] objs);
        [OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] objs);
        [OperationContract]
        BizLogicMsg BatchDeleteEct(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM obj);
        [OperationContract]
        EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM Load(string id, out EntityObject_BGT_D_BUDGET_ITEM BUDGET_ITEM_ID);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] saveEntities, EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] updateEntities, EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM[] deleteEntities);
        #region Relation Blok
#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_DEPT_BUDGET_ITEM updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
#endif
        #endregion
    }
}
