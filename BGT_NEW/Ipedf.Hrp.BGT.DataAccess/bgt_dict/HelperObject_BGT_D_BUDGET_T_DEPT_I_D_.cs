using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Web.DataAccess
{

	public partial class HelperObject_BGT_D_BUDGET_T_DEPT_I_D
	{
        public static DisplayObject_BGT_D_BUDGET_T_DEPT_I_D[] Query2(CauseObject_BGT_D_BUDGET_T_DEPT_I_D cause)
        {
            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  BGT_D_BUDGET_T_DEPT_I_D.BUDGET_YEAR_VALUE, BGT_D_BUDGET_T_DEPT_I_D.INCREASE_SCALE, BGT_D_BUDGET_T_DEPT_I_D.BASE_ID, BGT_D_BUDGET_T_DEPT_I_D.ID, BGT_D_BUDGET_T_DEPT_I_D.LAST_YEAR_VALUE, BGT_D_BUDGET_T_DEPT_I_D.ITEM_ID, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from BGT_D_BUDGET_T_DEPT_I_D left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_D_BUDGET_T_DEPT_I_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_BGT_D_BUDGET_T_DEPT_I_D dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_D_BUDGET_T_DEPT_I_D();
                if (!sqlReader.IsDBNull(0))
                    dataObj.BUDGET_YEAR_VALUE = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.INCREASE_SCALE = sqlReader.GetDecimal(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.BASE_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.LAST_YEAR_VALUE = sqlReader.GetDecimal(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.ITEM_ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.ITEM_ID_NAME = sqlReader.GetString(6);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_BGT_D_BUDGET_T_DEPT_I_D[] objs = new DisplayObject_BGT_D_BUDGET_T_DEPT_I_D[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
	}
}
