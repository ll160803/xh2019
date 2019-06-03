
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
		
[ServiceKnownType(typeof(EntityObject_SCM_D_MATER))]
	[ServiceContract]
	[ServiceKnownType(typeof(EntityObject_SCM_D_GYS_MATER_PIC))]	
	public partial interface ServiceContract_SCM_D_GYS_MATER_PIC: IServiceContractLocal<EntityObject_SCM_D_GYS_MATER_PIC, CauseObject_SCM_D_GYS_MATER_PIC>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_SCM_D_GYS_MATER_PIC obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_SCM_D_GYS_MATER_PIC obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_SCM_D_GYS_MATER_PIC obj);
		[OperationContract]
		EntityObject_SCM_D_GYS_MATER_PIC Get(EntityObject_SCM_D_GYS_MATER_PIC obj);
		[OperationContract]
		DisplayObject_SCM_D_GYS_MATER_PIC[] List();
		[OperationContract]
		DisplayObject_SCM_D_GYS_MATER_PIC[] Query(CauseObject_SCM_D_GYS_MATER_PIC cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_SCM_D_GYS_MATER_PIC cause);
		[OperationContract]
		DisplayObject_SCM_D_GYS_MATER_PIC[] Query(CauseObject_SCM_D_GYS_MATER_PIC cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_SCM_D_GYS_MATER_PIC[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_SCM_D_GYS_MATER_PIC[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_SCM_D_GYS_MATER_PIC[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_SCM_D_GYS_MATER_PIC obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_SCM_D_GYS_MATER_PIC obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_SCM_D_GYS_MATER_PIC obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_SCM_D_GYS_MATER_PIC obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_SCM_D_GYS_MATER_PIC obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_SCM_D_GYS_MATER_PIC obj);
        [OperationContract]
        EntityObject_SCM_D_GYS_MATER_PIC Load(string id , out EntityObject_SCM_D_MATER mater_id);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_GYS_MATER_PIC[] saveEntities, EntityObject_SCM_D_GYS_MATER_PIC[] updateEntities, EntityObject_SCM_D_GYS_MATER_PIC[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_SCM_D_GYS_MATER_PIC saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_SCM_D_GYS_MATER_PIC deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_SCM_D_GYS_MATER_PIC updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
