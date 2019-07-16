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

	public partial class HelperObject_BGT_B_CPN_HIS_DATA_D
	{
        public static DisplayObject_BGT_B_CPN_HIS_DATA_D[] Query2(CauseObject_BGT_B_CPN_HIS_DATA_D cause)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  BGT_B_CPN_HIS_DATA_D.M_4_VALUE, BGT_B_CPN_HIS_DATA_D.M_7_VALUE, BGT_B_CPN_HIS_DATA_D.ID, BGT_B_CPN_HIS_DATA_D.M_8_VALUE, BGT_B_CPN_HIS_DATA_D.BASE_ID, BGT_B_CPN_HIS_DATA_D.M_6_VALUE, BGT_B_CPN_HIS_DATA_D.M_5_VALUE, BGT_B_CPN_HIS_DATA_D.M_10_VALUE, BGT_B_CPN_HIS_DATA_D.ITEM_ID, BGT_B_CPN_HIS_DATA_D.M_9_VALUE, BGT_B_CPN_HIS_DATA_D.M_2_VALUE, BGT_B_CPN_HIS_DATA_D.M_11_VALUE, BGT_B_CPN_HIS_DATA_D.M_3_VALUE, BGT_B_CPN_HIS_DATA_D.M_12_VALUE, BGT_B_CPN_HIS_DATA_D.M_1_VALUE, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from BGT_B_CPN_HIS_DATA_D left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on BGT_B_CPN_HIS_DATA_D.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_BGT_B_CPN_HIS_DATA_D dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_B_CPN_HIS_DATA_D();
                if (!sqlReader.IsDBNull(0))
                    dataObj.M_4_VALUE = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.M_7_VALUE = sqlReader.GetDecimal(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.M_8_VALUE = sqlReader.GetDecimal(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.BASE_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.M_6_VALUE = sqlReader.GetDecimal(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.M_5_VALUE = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.M_10_VALUE = sqlReader.GetDecimal(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.ITEM_ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.M_9_VALUE = sqlReader.GetDecimal(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.M_2_VALUE = sqlReader.GetDecimal(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.M_11_VALUE = sqlReader.GetDecimal(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.M_3_VALUE = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.M_12_VALUE = sqlReader.GetDecimal(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.M_1_VALUE = sqlReader.GetDecimal(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_BGT_B_CPN_HIS_DATA_D[] objs = new DisplayObject_BGT_B_CPN_HIS_DATA_D[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT[] QueryPlanExt(CauseObject_BGT_B_CPN_HIS_DATA_D cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = @" select  BGT_B_CPN_HIS_DATA_D.M_4_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.ID, 
                                    BGT_B_CPN_HIS_DATA_D.M_8_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.BASE_ID, 
                                    BGT_B_CPN_HIS_DATA_D.M_6_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_5_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_10_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.ITEM_ID, 
                                    BGT_B_CPN_HIS_DATA_D.M_9_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_2_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_11_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_3_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_12_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_7_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_1_VALUE, 
                                    BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, 
                                    u.unit_id as UNIT_ID, 
                                    u.unit_id_name as UNIT_ID_NAME
                                    from BGT_B_CPN_HIS_DATA_D 
                                    left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID 
                                    on BGT_B_CPN_HIS_DATA_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID 
                                    left join ( select t.id as item_id, c.id as unit_id, c.name as unit_id_name 
                                        from com_type c, bgt_d_plan_item t 
                                        where c.parent_id = '0001' 
                                        and t.unit_id = c.id) u
                                    on u.item_id = BGT_B_CPN_HIS_DATA_D.ITEM_ID
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_CPN_HIS_DATA_D", paging, order, sSql, parameters, connection);
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
            DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT();
                if (!sqlReader.IsDBNull(0))
                    dataObj.M_4_VALUE = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.M_8_VALUE = sqlReader.GetDecimal(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.BASE_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.M_6_VALUE = sqlReader.GetDecimal(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.M_5_VALUE = sqlReader.GetDecimal(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.M_10_VALUE = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.ITEM_ID = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.M_9_VALUE = sqlReader.GetDecimal(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.M_2_VALUE = sqlReader.GetDecimal(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.M_11_VALUE = sqlReader.GetDecimal(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.M_3_VALUE = sqlReader.GetDecimal(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.M_12_VALUE = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.M_7_VALUE = sqlReader.GetDecimal(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.M_1_VALUE = sqlReader.GetDecimal(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.UNIT_ID = sqlReader.GetString(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.UNIT_ID_NAME = sqlReader.GetString(17);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT[] objs = new DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT[] QueryFinanceExt(CauseObject_BGT_B_CPN_HIS_DATA_D cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = @" select  BGT_B_CPN_HIS_DATA_D.M_4_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.ID, 
                                    BGT_B_CPN_HIS_DATA_D.M_8_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.BASE_ID, 
                                    BGT_B_CPN_HIS_DATA_D.M_6_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_5_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_10_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.ITEM_ID, 
                                    BGT_B_CPN_HIS_DATA_D.M_9_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_2_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_11_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_3_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_12_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_7_VALUE, 
                                    BGT_B_CPN_HIS_DATA_D.M_1_VALUE, 
                                    BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, 
                                    '0001000x' as UNIT_ID, 
                                    '元' as UNIT_ID_NAME  
                                    from BGT_B_CPN_HIS_DATA_D 
                                    left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID 
                                    on BGT_B_CPN_HIS_DATA_D.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID 
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_CPN_HIS_DATA_D", paging, order, sSql, parameters, connection);
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
            DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT();
                if (!sqlReader.IsDBNull(0))
                    dataObj.M_4_VALUE = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.M_8_VALUE = sqlReader.GetDecimal(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.BASE_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.M_6_VALUE = sqlReader.GetDecimal(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.M_5_VALUE = sqlReader.GetDecimal(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.M_10_VALUE = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.ITEM_ID = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.M_9_VALUE = sqlReader.GetDecimal(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.M_2_VALUE = sqlReader.GetDecimal(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.M_11_VALUE = sqlReader.GetDecimal(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.M_3_VALUE = sqlReader.GetDecimal(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.M_12_VALUE = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.M_7_VALUE = sqlReader.GetDecimal(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.M_1_VALUE = sqlReader.GetDecimal(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.UNIT_ID = sqlReader.GetString(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.UNIT_ID_NAME = sqlReader.GetString(17);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT[] objs = new DisplayObject_BGT_B_CPN_HIS_DATA_D_EXT[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
	}
}
