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
    public partial class HelperObject_BGT_B_BUDGET_CONTROL_D
    {
        public static DisplayObject_BGT_B_BUDGET_CONTROL_D_EXT[] QueryExt(CauseObject_BGT_B_BUDGET_CONTROL_D cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = @" select  BGT_B_BUDGET_CONTROL_D.ID, 
                                     BGT_B_BUDGET_CONTROL_D.TYPE_ID, 
                                     BGT_B_BUDGET_CONTROL_D.SLIDING_SCALES, 
                                     BGT_B_BUDGET_CONTROL_D.BASE_ID, 
                                     BGT_B_BUDGET_CONTROL_D.ITEM_ID, 
                                     BGT_B_BUDGET_CONTROL_D.EDITION_ID, 
                                     BGT_B_BUDGET_CONTROL_D.COMMENTS, 
                                     COM_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, 
                                     BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, 
                                     COM_TYPE_EDITION_ID.NAME as EDITION_ID_NAME,  
                                     '0001000x' as UNIT_ID, 
                                     '元' as UNIT_ID_NAME   
                                     from BGT_B_BUDGET_CONTROL_D 
                                     left join COM_TYPE   COM_TYPE_TYPE_ID 
                                     on BGT_B_BUDGET_CONTROL_D.TYPE_ID = COM_TYPE_TYPE_ID.ID 
                                     left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID 
                                     on BGT_B_BUDGET_CONTROL_D.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID 
                                     left join COM_TYPE   COM_TYPE_EDITION_ID 
                                     on BGT_B_BUDGET_CONTROL_D.EDITION_ID = COM_TYPE_EDITION_ID.ID 
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_BUDGET_CONTROL_D", paging, order, sSql, parameters, connection);
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
            DisplayObject_BGT_B_BUDGET_CONTROL_D_EXT dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_B_BUDGET_CONTROL_D_EXT();
                if (!sqlReader.IsDBNull(0))
                    dataObj.ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.TYPE_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.SLIDING_SCALES = sqlReader.GetDecimal(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.BASE_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.ITEM_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.EDITION_ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.COMMENTS = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.TYPE_ID_NAME = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.ITEM_ID_NAME = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.EDITION_ID_NAME = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.UNIT_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.UNIT_ID_NAME = sqlReader.GetString(11);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_BGT_B_BUDGET_CONTROL_D_EXT[] objs = new DisplayObject_BGT_B_BUDGET_CONTROL_D_EXT[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
    }
}
