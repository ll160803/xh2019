using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.Common;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using System.Data;
using System.Reflection;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace Ipedf.Hrp.BGT.Utility
{
    public class InputUtility
    {
        /// <summary>
        /// 通过当前用户所在部门获取对应的预算部门信息(不却分业务和职能科室)
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string GetBudgetDeptByUser(EntityObject_COM_USER user)
        {
            CauseObject_BGT_D_BUDGET_DEPT p = new CauseObject_BGT_D_BUDGET_DEPT();
            p.DEPT_ID = user.DEPART_ID;
            p.BUDGET_YEAR = GetCurrentBudgetYear();
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Query(p);
            return depts.Length == 0 ? null : depts[0].ID;
        }
        /// <summary>
        /// 通过当前用户所在部门获取对应的预算部门信息(仅限职能科室)
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string GetFunctionBudgetDeptByUser(EntityObject_COM_USER user)
        {
            CauseObject_BGT_D_BUDGET_DEPT p = new CauseObject_BGT_D_BUDGET_DEPT();
            p.DEPT_ID = user.DEPART_ID;
            p.BUDGET_YEAR = GetCurrentBudgetYear();
            p.IS_FUNCTION = (decimal)是否状态.是;
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Query(p);
            return depts.Length == 0 ? null : depts[0].ID;
        }
        /// <summary>
        /// 通过当前用户所在部门获取对应的预算部门信息(仅限业务科室)
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string GetBusinessBudgetDeptByUser(EntityObject_COM_USER user)
        {
            CauseObject_BGT_D_BUDGET_DEPT p = new CauseObject_BGT_D_BUDGET_DEPT();
            p.DEPT_ID = user.DEPART_ID;
            p.BUDGET_YEAR = GetCurrentBudgetYear();
            p.IS_FUNCTION = (decimal)是否状态.否;
            DisplayObject_BGT_D_BUDGET_DEPT[] depts = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Query(p);
            return depts.Length == 0 ? null : depts[0].ID;
        }
        /// <summary>
        /// 获取当前默认可用预算年
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentBudgetYear()
        {
            return BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.GetCurrentBudgetYear(1);
        }
    }
}
