
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
	[ServiceKnownType(typeof(EntityObject_V_SCM_D_MATER_PIC_COM_FILE))]	
	public partial interface ServiceContract_V_SCM_D_MATER_PIC_COM_FILE: IServiceContractLocal<EntityObject_V_SCM_D_MATER_PIC_COM_FILE, CauseObject_V_SCM_D_MATER_PIC_COM_FILE>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj);
		[OperationContract]
		EntityObject_V_SCM_D_MATER_PIC_COM_FILE Get(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj);
		[OperationContract]
		DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[] List();
		[OperationContract]
		DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[] Query(CauseObject_V_SCM_D_MATER_PIC_COM_FILE cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_V_SCM_D_MATER_PIC_COM_FILE cause);
		[OperationContract]
		DisplayObject_V_SCM_D_MATER_PIC_COM_FILE[] Query(CauseObject_V_SCM_D_MATER_PIC_COM_FILE cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_V_SCM_D_MATER_PIC_COM_FILE[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_V_SCM_D_MATER_PIC_COM_FILE[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_V_SCM_D_MATER_PIC_COM_FILE[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_V_SCM_D_MATER_PIC_COM_FILE obj);
        [OperationContract]
        EntityObject_V_SCM_D_MATER_PIC_COM_FILE Load(string id );
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_D_MATER_PIC_COM_FILE[] saveEntities, EntityObject_V_SCM_D_MATER_PIC_COM_FILE[] updateEntities, EntityObject_V_SCM_D_MATER_PIC_COM_FILE[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		BizLogicMsg CommitSave(EntityObject_V_SCM_D_MATER_PIC_COM_FILE saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        BizLogicMsg CommitDelete(EntityObject_V_SCM_D_MATER_PIC_COM_FILE deleteBaseEntity);
        [OperationContract]
        BizLogicMsg CommitUpdate(EntityObject_V_SCM_D_MATER_PIC_COM_FILE updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
