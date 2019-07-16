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
    public partial class HelperObject_BGT_B_DEPT_PAY_YEAR_D
    {
        public static DisplayObject_BGT_B_DEPT_PAY_YEAR_D_EXT[] QueryExt(CauseObject_BGT_B_DEPT_PAY_YEAR_D cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = @" select  BGT_B_DEPT_PAY_YEAR_D.ITEM_VALUE, 
                                     BGT_B_DEPT_PAY_YEAR_D.TEMPLET_ITEM_ID, 
                                     BGT_B_DEPT_PAY_YEAR_D.BASE_ID, 
                                     BGT_B_DEPT_PAY_YEAR_D.ID, 
                                     BGT_B_DEPT_PAY_YEAR_D.MGR_DEPT_ID, 
                                     BGT_B_DEPT_PAY_YEAR_D.ITEM_ID, 
                                     BILL_WORK_FLOW_BASE_ID.ID as BASE_ID_NAME, 
                                     BGT_D_BUDGET_DEPT_MGR_DEPT_ID.NAME as MGR_DEPT_ID_NAME, 
                                     BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME,  
                                     '0001000x' as UNIT_ID, 
                                     '元' as UNIT_ID_NAME   
                                     from BGT_B_DEPT_PAY_YEAR_D 
                                     left join BILL_WORK_FLOW   BILL_WORK_FLOW_BASE_ID 
                                     on BGT_B_DEPT_PAY_YEAR_D.BASE_ID = BILL_WORK_FLOW_BASE_ID.ID 
                                     left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_MGR_DEPT_ID 
                                     on BGT_B_DEPT_PAY_YEAR_D.MGR_DEPT_ID = BGT_D_BUDGET_DEPT_MGR_DEPT_ID.ID 
                                     left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID 
                                     on BGT_B_DEPT_PAY_YEAR_D.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID 
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_DEPT_PAY_YEAR_D", paging, order, sSql, parameters, connection);
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
            DisplayObject_BGT_B_DEPT_PAY_YEAR_D_EXT dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_B_DEPT_PAY_YEAR_D_EXT();
                if (!sqlReader.IsDBNull(0))
                    dataObj.ITEM_VALUE = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.TEMPLET_ITEM_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.BASE_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.MGR_DEPT_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.ITEM_ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.BASE_ID_NAME = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.MGR_DEPT_ID_NAME = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.ITEM_ID_NAME = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.UNIT_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.UNIT_ID_NAME = sqlReader.GetString(10);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_BGT_B_DEPT_PAY_YEAR_D_EXT[] objs = new DisplayObject_BGT_B_DEPT_PAY_YEAR_D_EXT[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
    }
}
