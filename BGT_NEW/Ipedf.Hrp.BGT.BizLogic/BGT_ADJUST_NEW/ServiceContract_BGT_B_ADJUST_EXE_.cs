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
	public partial interface ServiceContract_BGT_B_ADJUST_EXE
	{
        BizLogicMsg CommitSaveMainAndSub(EntityObject_BGT_B_ADJUST_EXE updateBaseEntity, EntityObject_BGT_B_ADJUST_EXE_D[] saveDetailEntities);
	}
}
