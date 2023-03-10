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

	public partial class HelperObject_BGT_D_BUDGET_DEPT_YEAR_R_I
	{
        public static DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I[] Query2(CauseObject_BGT_D_BUDGET_DEPT_YEAR_R_I cause)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  BGT_D_BUDGET_DEPT_YEAR_R_I.RESOLVE_METHOD_ID, BGT_D_BUDGET_DEPT_YEAR_R_I.BASE_ID, BGT_D_BUDGET_DEPT_YEAR_R_I.ID, BGT_D_BUDGET_DEPT_YEAR_R_I.ITEM_ID, COM_TYPE_RESOLVE_METHOD_ID.NAME as RESOLVE_METHOD_ID_NAME, BILL_WORK_FLOW_BASE_ID.ID as BASE_ID_NAME, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from BGT_D_BUDGET_DEPT_YEAR_R_I left join COM_TYPE   COM_TYPE_RESOLVE_METHOD_ID on BGT_D_BUDGET_DEPT_YEAR_R_I.RESOLVE_METHOD_ID = COM_TYPE_RESOLVE_METHOD_ID.ID left join BILL_WORK_FLOW   BILL_WORK_FLOW_BASE_ID on BGT_D_BUDGET_DEPT_YEAR_R_I.BASE_ID = BILL_WORK_FLOW_BASE_ID.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on BGT_D_BUDGET_DEPT_YEAR_R_I.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I();
                if (!sqlReader.IsDBNull(0))
                    dataObj.RESOLVE_METHOD_ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.BASE_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ITEM_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.RESOLVE_METHOD_ID_NAME = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.BASE_ID_NAME = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.ITEM_ID_NAME = sqlReader.GetString(6);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I[] objs = new DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
	}
}
