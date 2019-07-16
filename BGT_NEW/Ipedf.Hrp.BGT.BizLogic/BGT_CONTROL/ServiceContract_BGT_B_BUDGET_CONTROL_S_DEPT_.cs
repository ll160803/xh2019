
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

	public partial interface ServiceContract_BGT_B_BUDGET_CONTROL_S_DEPT
	{
        BizLogicMsg SetBudgetDeptEdit(List<string> IDS, decimal Stage);
        BizLogicMsg SetBudgetDeptEdit_All(decimal Stage, int Flag);
        bool IsEditByButdgeDept(string butdge_dpt_id, int Stage);
        bool IsEditByButdgeDept(string butdge_dpt_id, string budget_year, int Stage);
	}
}
