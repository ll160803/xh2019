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
using System.Collections.Generic;
namespace Ipedf.Web.ServiceContract
{
	
	public partial interface ServiceContract_BGT_B_DEPT_PLAN_MON
	{	
        [OperationContract]
        BizLogicMsg Calculate(EntityObject_BGT_B_DEPT_PLAN_MON obj);
        [OperationContract]
        BizLogicMsg ImportDataService(EntityObject_BGT_B_DEPT_PLAN_MON obj, DataTable data);
        [OperationContract]
        List<string> CheckImportService(EntityObject_BGT_B_DEPT_PLAN_MON obj, DataTable data);
	}
}
