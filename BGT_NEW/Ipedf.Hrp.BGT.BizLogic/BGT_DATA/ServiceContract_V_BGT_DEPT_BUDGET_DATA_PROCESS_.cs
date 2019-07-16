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

	public partial interface ServiceContract_V_BGT_DEPT_BUDGET_DATA_PROCESS
	{		
		[OperationContract]
		BizLogicMsg UndoSubmitDeptPlanBudgetData(DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] deptBudgetData);
        [OperationContract]
        BizLogicMsg UndoSubmitDeptPayBudgetData(DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] deptBudgetData);
        [OperationContract]
        BizLogicMsg UndoSubmitDeptIncomeBudgetData(DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] deptBudgetData);
	}
}
