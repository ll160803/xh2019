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

	[ServiceKnownType(typeof(EntityObject_BGT_D_BUDGET_T_DEPT_I_D))]	
	public partial interface ServiceContract_BGT_D_BUDGET_T_DEPT_I_D
	{
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_T_DEPT_I_D[] Query2(CauseObject_BGT_D_BUDGET_T_DEPT_I_D cause);		
	}
}
