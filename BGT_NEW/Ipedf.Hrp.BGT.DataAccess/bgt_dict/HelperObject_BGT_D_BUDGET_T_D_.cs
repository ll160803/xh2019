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
	public partial class HelperObject_BGT_D_BUDGET_T_D
	{


        public static DisplayObject_BGT_D_BUDGET_T_D[] Query2(CauseObject_BGT_D_BUDGET_T_D cause)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  BGT_D_BUDGET_T_D.ID, BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID, BGT_D_BUDGET_T_D.CONSULT, BGT_D_BUDGET_T_D.BASE_ID, BGT_D_BUDGET_T_D.ITEM_ID, BGT_D_BUDGET_T_D.CALCULATE_INDEX, BGT_D_BUDGET_T_D.PREPARE_METHOD_ID, BGT_D_BUDGET_T_D.CALCULATE_FORMULA, COM_TYPE_CALCULATE_METHOD_ID.NAME as CALCULATE_METHOD_ID_NAME, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, COM_TYPE_PREPARE_METHOD_ID.NAME as PREPARE_METHOD_ID_NAME from BGT_D_BUDGET_T_D left join COM_TYPE   COM_TYPE_CALCULATE_METHOD_ID on BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID = COM_TYPE_CALCULATE_METHOD_ID.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on BGT_D_BUDGET_T_D.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID left join COM_TYPE   COM_TYPE_PREPARE_METHOD_ID on BGT_D_BUDGET_T_D.PREPARE_METHOD_ID = COM_TYPE_PREPARE_METHOD_ID.ID where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_BGT_D_BUDGET_T_D dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_D_BUDGET_T_D();
                if (!sqlReader.IsDBNull(0))
                    dataObj.ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.CALCULATE_METHOD_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.CONSULT = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.BASE_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.ITEM_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.CALCULATE_INDEX = sqlReader.GetDecimal(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.PREPARE_METHOD_ID = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.CALCULATE_FORMULA = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.CALCULATE_METHOD_ID_NAME = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.ITEM_ID_NAME = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.PREPARE_METHOD_ID_NAME = sqlReader.GetString(10);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_BGT_D_BUDGET_T_D[] objs = new DisplayObject_BGT_D_BUDGET_T_D[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_BGT_D_BUDGET_T_D_EXT[] QueryPlanExt(CauseObject_BGT_D_BUDGET_T_D cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = @" select  BGT_D_BUDGET_T_D.ID, 
                                     BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID, 
                                     BGT_D_BUDGET_T_D.CONSULT, 
                                     BGT_D_BUDGET_T_D.BASE_ID, 
                                     BGT_D_BUDGET_T_D.ITEM_ID, 
                                     BGT_D_BUDGET_T_D.CALCULATE_INDEX, 
                                     BGT_D_BUDGET_T_D.PREPARE_METHOD_ID, 
                                     BGT_D_BUDGET_T_D.CALCULATE_FORMULA, 
                                     COM_TYPE_CALCULATE_METHOD_ID.NAME as CALCULATE_METHOD_ID_NAME, 
                                     BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, 
                                     COM_TYPE_PREPARE_METHOD_ID.NAME as PREPARE_METHOD_ID_NAME, 
                                     u.unit_id as UNIT_ID, 
                                     u.unit_id_name as UNIT_ID_NAME  
                                     from BGT_D_BUDGET_T_D 
                                     left join COM_TYPE   COM_TYPE_CALCULATE_METHOD_ID 
                                     on BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID = COM_TYPE_CALCULATE_METHOD_ID.ID 
                                     left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID 
                                     on BGT_D_BUDGET_T_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID 
                                     left join COM_TYPE   COM_TYPE_PREPARE_METHOD_ID 
                                     on BGT_D_BUDGET_T_D.PREPARE_METHOD_ID = COM_TYPE_PREPARE_METHOD_ID.ID 
                                     left join ( select t.id as item_id, c.id as unit_id, c.name as unit_id_name 
                                         from com_type c, bgt_d_plan_item t 
                                         where c.parent_id = '0001' 
                                         and t.unit_id = c.id) u
                                     on u.item_id = BGT_D_BUDGET_T_D.ITEM_ID
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_BUDGET_T_D", paging, order, sSql, parameters, connection);
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
            DisplayObject_BGT_D_BUDGET_T_D_EXT dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_D_BUDGET_T_D_EXT();
                if (!sqlReader.IsDBNull(0))
                    dataObj.ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.CALCULATE_METHOD_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.CONSULT = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.BASE_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.ITEM_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.CALCULATE_INDEX = sqlReader.GetDecimal(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.PREPARE_METHOD_ID = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.CALCULATE_FORMULA = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.CALCULATE_METHOD_ID_NAME = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.ITEM_ID_NAME = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.PREPARE_METHOD_ID_NAME = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.UNIT_ID = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.UNIT_ID_NAME = sqlReader.GetString(12);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_BGT_D_BUDGET_T_D_EXT[] objs = new DisplayObject_BGT_D_BUDGET_T_D_EXT[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_BGT_D_BUDGET_T_D_EXT[] QueryFinanceExt(CauseObject_BGT_D_BUDGET_T_D cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = @" select  BGT_D_BUDGET_T_D.ID, 
                                     BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID, 
                                     BGT_D_BUDGET_T_D.CONSULT, 
                                     BGT_D_BUDGET_T_D.BASE_ID, 
                                     BGT_D_BUDGET_T_D.ITEM_ID, 
                                     BGT_D_BUDGET_T_D.CALCULATE_INDEX, 
                                     BGT_D_BUDGET_T_D.PREPARE_METHOD_ID, 
                                     BGT_D_BUDGET_T_D.CALCULATE_FORMULA, 
                                     COM_TYPE_CALCULATE_METHOD_ID.NAME as CALCULATE_METHOD_ID_NAME, 
                                     BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, 
                                     COM_TYPE_PREPARE_METHOD_ID.NAME as PREPARE_METHOD_ID_NAME,  
                                     '0001000x' as UNIT_ID, 
                                     '元' as UNIT_ID_NAME   
                                     from BGT_D_BUDGET_T_D 
                                     left join COM_TYPE   COM_TYPE_CALCULATE_METHOD_ID 
                                     on BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID = COM_TYPE_CALCULATE_METHOD_ID.ID 
                                     left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID 
                                     on BGT_D_BUDGET_T_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID 
                                     left join COM_TYPE   COM_TYPE_PREPARE_METHOD_ID 
                                     on BGT_D_BUDGET_T_D.PREPARE_METHOD_ID = COM_TYPE_PREPARE_METHOD_ID.ID 
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_BUDGET_T_D", paging, order, sSql, parameters, connection);
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
            DisplayObject_BGT_D_BUDGET_T_D_EXT dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_D_BUDGET_T_D_EXT();
                if (!sqlReader.IsDBNull(0))
                    dataObj.ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.CALCULATE_METHOD_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.CONSULT = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.BASE_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.ITEM_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.CALCULATE_INDEX = sqlReader.GetDecimal(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.PREPARE_METHOD_ID = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.CALCULATE_FORMULA = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.CALCULATE_METHOD_ID_NAME = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.ITEM_ID_NAME = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.PREPARE_METHOD_ID_NAME = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.UNIT_ID = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.UNIT_ID_NAME = sqlReader.GetString(12);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_BGT_D_BUDGET_T_D_EXT[] objs = new DisplayObject_BGT_D_BUDGET_T_D_EXT[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
	}
}
