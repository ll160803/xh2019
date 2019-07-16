using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.Entity;
namespace Ipedf.Web.DataAccess
{
    public partial class HelperObject_V_BGT_INC_BUDGET_DATA
    {
        public static DisplayObject_V_BGT_INC_BUDGET_DATA_EXT[] QueryExt(CauseObject_V_BGT_INC_BUDGET_DATA cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = @" select  V_BGT_INC_BUDGET_DATA.BUDGET_DATA_ID, 
                                     V_BGT_INC_BUDGET_DATA.ITEM_ID, 
                                     V_BGT_INC_BUDGET_DATA.DEPT_VALUE, 
                                     V_BGT_INC_BUDGET_DATA.DIFF_VALUE, 
                                     V_BGT_INC_BUDGET_DATA.BUDGET_YEAR, 
                                     V_BGT_INC_BUDGET_DATA.CPN_VALUE, 
                                     BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, 
                                     BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME,  
                                     '0001000x' as UNIT_ID, 
                                     '元' as UNIT_ID_NAME 
                                     from V_BGT_INC_BUDGET_DATA 
                                     left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID 
                                     on V_BGT_INC_BUDGET_DATA.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID 
                                     left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR 
                                     on V_BGT_INC_BUDGET_DATA.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID 
                                     where (1=1)";
            string sCauseSql = PrepareCause(cause, out parameters);
            sSql += sCauseSql;
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            if (paging != null)
            {
                string countSql = string.Empty;
                if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
                {
                    countSql = "Select Count(*) From (" + sSql + ") t";
                }
                else
                {
                    countSql = "Select Count(*) From (" + sSql + ") t";
                }
                if (paging.TotalRecords == 0)
                {
                    paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection);
                }
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_INC_BUDGET_DATA", paging, order, sSql, parameters, connection);
            }
            else if (order != null)
            {
                sSql += order.ToString();
                sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            }
            else
            {
                sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            }
            DisplayObject_V_BGT_INC_BUDGET_DATA_EXT dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_V_BGT_INC_BUDGET_DATA_EXT();
                if (!sqlReader.IsDBNull(0))
                    dataObj.BUDGET_DATA_ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ITEM_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.DEPT_VALUE = sqlReader.GetDecimal(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.DIFF_VALUE = sqlReader.GetDecimal(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.BUDGET_YEAR = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.CPN_VALUE = sqlReader.GetDecimal(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.ITEM_ID_NAME = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.UNIT_ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.UNIT_ID_NAME = sqlReader.GetString(9);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_V_BGT_INC_BUDGET_DATA_EXT[] objs = new DisplayObject_V_BGT_INC_BUDGET_DATA_EXT[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
    }
}
