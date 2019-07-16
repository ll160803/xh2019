
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

	public partial interface ServiceContract_BGT_D_BUDGET_DEPT
	{	
		
		[OperationContract]
		DisplayObject_BGT_D_BUDGET_DEPT[] GetBusinessBudgetDepartByDept(string departId);
        [OperationContract]
        DisplayObject_BGT_D_BUDGET_DEPT[] GetFunctionBudgetDepartByDept(string departId);
        [OperationContract]
        DisplayObject_BGT_D_BUDGET_DEPT[] GetFunctionBudgetDepartByDept(string departName,string budgetYear);

        /// <summary>
        /// 不明确
        /// </summary>
        /// <param name="departId"></param>
        /// <param name="Stage">1是编制2是执行3是归档</param>
        /// <returns></returns>
        [OperationContract]
        DisplayObject_BGT_D_BUDGET_DEPT[] GetBusinessBudgetDepartByDept(string departId,decimal Stage);
        /// <summary>
        /// 根据当前用户所在部门ID获取职能部门ID
        /// </summary>
        /// <param name="departId"></param>
        /// <param name="Stage">1是编制2是执行3是归档</param>
        /// <returns></returns>
        [OperationContract]
        DisplayObject_BGT_D_BUDGET_DEPT[] GetFunctionBudgetDepartByDept(string departId, decimal Stage);
        [OperationContract]
        BizLogicMsg ImportDataService(string budgetYear, DataTable data);
        [OperationContract]
        List<string> CheckImportService(DataTable data);
	}
}
