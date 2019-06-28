﻿
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
	[ServiceKnownType(typeof(EntityObject_COM_SYSTEM))]	
	public partial interface ServiceContract_COM_SYSTEM: IServiceContractLocal<EntityObject_COM_SYSTEM, CauseObject_COM_SYSTEM>
	{	
		[OperationContract]
		BizLogicMsg Save(EntityObject_COM_SYSTEM obj);
		[OperationContract]
		BizLogicMsg Update(EntityObject_COM_SYSTEM obj);
		[OperationContract]
		BizLogicMsg Delete(EntityObject_COM_SYSTEM obj);
		[OperationContract]
		EntityObject_COM_SYSTEM Get(EntityObject_COM_SYSTEM obj);
		[OperationContract]
		DisplayObject_COM_SYSTEM[] List();
		[OperationContract]
		DisplayObject_COM_SYSTEM[] Query(CauseObject_COM_SYSTEM cause);
		[OperationContract]
		BizLogicMsg Delete(CauseObject_COM_SYSTEM cause);
		[OperationContract]
		DisplayObject_COM_SYSTEM[] Query(CauseObject_COM_SYSTEM cause,PagingParamter paging,OrderByParameter order);
		[OperationContract]
		BizLogicMsg BatchSave(EntityObject_COM_SYSTEM[] objs);
		[OperationContract]
        BizLogicMsg BatchUpdate(EntityObject_COM_SYSTEM[] objs);
        [OperationContract]
        BizLogicMsg BatchDelete(EntityObject_COM_SYSTEM[] objs);
        [OperationContract]
        BizLogicMsg Cancel(EntityObject_COM_SYSTEM obj);
        [OperationContract]
        BizLogicMsg Audit(EntityObject_COM_SYSTEM obj);
        [OperationContract]
        BizLogicMsg UndoAudit(EntityObject_COM_SYSTEM obj);
        [OperationContract]
        BizLogicMsg Archive(EntityObject_COM_SYSTEM obj);
        [OperationContract]
        BizLogicMsg Submit(EntityObject_COM_SYSTEM obj);
        [OperationContract]
        BizLogicMsg UndoSubmit(EntityObject_COM_SYSTEM obj);
        [OperationContract]
        EntityObject_COM_SYSTEM Load(string id );
        [OperationContract]
        void CommitUpdate(EntityObject_COM_SYSTEM[] saveEntities, EntityObject_COM_SYSTEM[] updateEntities, EntityObject_COM_SYSTEM[] deleteEntities);
        #region Relation Blok
		#if NESTING
		[OperationContract]
		void CommitSave(EntityObject_COM_SYSTEM saveBaseEntity, EntityObject_[] saveDetailEntities);
		[OperationContract]
        void CommitDelete(EntityObject_COM_SYSTEM deleteBaseEntity);
        [OperationContract]
        void CommitUpdate(EntityObject_COM_SYSTEM updateBaseEntity, EntityObject_[] saveDetailEntities, EntityObject_[] updateDetailEntities, EntityObject_[] deleteDetailEntities);
        #endif
		#endregion 
	}
}
