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
   public partial class HelperObject_SCM_B_QUOTEDPRICE_D
    {
        public static EntityObject_SCM_B_QUOTEDPRICE_D Get(EntityObject_SCM_B_QUOTEDPRICE_D obj)
        {

            //平台自动生成代码
            string sSql = "select  COMMENTS_D, HOSPITAL_NAME, BASE_ID, DISPLAY_INDEX, COM_FILE_ID, ID, PRICE from SCM_B_QUOTEDPRICE_D where  (1=1) ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[0];
            #endregion
            #region Push Block
            EntityObject_SCM_B_QUOTEDPRICE_D dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new EntityObject_SCM_B_QUOTEDPRICE_D();
                if (!sqlReader.IsDBNull(0))
                    dataObj.COMMENTS_D = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.HOSPITAL_NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.BASE_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.COM_FILE_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.PRICE = sqlReader.GetDecimal(6);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            EntityObject_SCM_B_QUOTEDPRICE_D[] objs = new EntityObject_SCM_B_QUOTEDPRICE_D[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
        public static EntityObject_SCM_B_QUOTEDPRICE_D Get(EntityObject_SCM_B_QUOTEDPRICE_D obj, IDbTransaction trans)
        {

            //平台自动生成代码
            string sSql = "select  COMMENTS_D, HOSPITAL_NAME, BASE_ID, DISPLAY_INDEX, COM_FILE_ID, ID, PRICE from SCM_B_QUOTEDPRICE_D where  (1=1) ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[0];
            #endregion
            #region Push Block
            EntityObject_SCM_B_QUOTEDPRICE_D dataObj = null;
            ArrayList objArray = new ArrayList();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            while (sqlReader.Read())
            {
                dataObj = new EntityObject_SCM_B_QUOTEDPRICE_D();
                if (!sqlReader.IsDBNull(0))
                    dataObj.COMMENTS_D = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.HOSPITAL_NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.BASE_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.COM_FILE_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.PRICE = sqlReader.GetDecimal(6);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            EntityObject_SCM_B_QUOTEDPRICE_D[] objs = new EntityObject_SCM_B_QUOTEDPRICE_D[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
        public static DisplayObject_SCM_B_QUOTEDPRICE_D[] List()
        {

            //平台自动生成代码
            string sSql = " select  SCM_B_QUOTEDPRICE_D.COMMENTS_D, SCM_B_QUOTEDPRICE_D.HOSPITAL_NAME, SCM_B_QUOTEDPRICE_D.BASE_ID, SCM_B_QUOTEDPRICE_D.DISPLAY_INDEX, SCM_B_QUOTEDPRICE_D.COM_FILE_ID, SCM_B_QUOTEDPRICE_D.ID, SCM_B_QUOTEDPRICE_D.PRICE, COM_FILE_COM_FILE_ID.CLIENT_NAME as COM_FILE_ID_NAME,COM_FILE_COM_FILE_ID.SERVER_NAME as COM_FILE_ID_S_NAME from SCM_B_QUOTEDPRICE_D left join COM_FILE   COM_FILE_COM_FILE_ID on SCM_B_QUOTEDPRICE_D.COM_FILE_ID = COM_FILE_COM_FILE_ID.ID where (1=1)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[0];
            #endregion
            #region Push Block
            DisplayObject_SCM_B_QUOTEDPRICE_D dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_B_QUOTEDPRICE_D();
                if (!sqlReader.IsDBNull(0))
                    dataObj.COMMENTS_D = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.HOSPITAL_NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.BASE_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.COM_FILE_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.PRICE = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.COM_FILE_ID_NAME = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.COM_FILE_ID_S_NAME = sqlReader.GetString(8);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SCM_B_QUOTEDPRICE_D[] objs = new DisplayObject_SCM_B_QUOTEDPRICE_D[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_SCM_B_QUOTEDPRICE_D[] Query(CauseObject_SCM_B_QUOTEDPRICE_D cause)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  SCM_B_QUOTEDPRICE_D.COMMENTS_D, SCM_B_QUOTEDPRICE_D.HOSPITAL_NAME, SCM_B_QUOTEDPRICE_D.BASE_ID, SCM_B_QUOTEDPRICE_D.DISPLAY_INDEX, SCM_B_QUOTEDPRICE_D.COM_FILE_ID, SCM_B_QUOTEDPRICE_D.ID, SCM_B_QUOTEDPRICE_D.PRICE, COM_FILE_COM_FILE_ID.CLIENT_NAME as COM_FILE_ID_NAME,COM_FILE_COM_FILE_ID.SERVER_NAME as COM_FILE_ID_S_NAME from SCM_B_QUOTEDPRICE_D left join COM_FILE   COM_FILE_COM_FILE_ID on SCM_B_QUOTEDPRICE_D.COM_FILE_ID = COM_FILE_COM_FILE_ID.ID where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_SCM_B_QUOTEDPRICE_D dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_B_QUOTEDPRICE_D();
                if (!sqlReader.IsDBNull(0))
                    dataObj.COMMENTS_D = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.HOSPITAL_NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.BASE_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.COM_FILE_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.PRICE = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.COM_FILE_ID_NAME = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.COM_FILE_ID_S_NAME = sqlReader.GetString(8);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SCM_B_QUOTEDPRICE_D[] objs = new DisplayObject_SCM_B_QUOTEDPRICE_D[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_SCM_B_QUOTEDPRICE_D[] Query(CauseObject_SCM_B_QUOTEDPRICE_D cause, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  SCM_B_QUOTEDPRICE_D.COMMENTS_D, SCM_B_QUOTEDPRICE_D.HOSPITAL_NAME, SCM_B_QUOTEDPRICE_D.BASE_ID, SCM_B_QUOTEDPRICE_D.DISPLAY_INDEX, SCM_B_QUOTEDPRICE_D.COM_FILE_ID, SCM_B_QUOTEDPRICE_D.ID, SCM_B_QUOTEDPRICE_D.PRICE, COM_FILE_COM_FILE_ID.CLIENT_NAME as COM_FILE_ID_NAME,COM_FILE_COM_FILE_ID.SERVER_NAME as COM_FILE_ID_S_NAME from SCM_B_QUOTEDPRICE_D left join COM_FILE   COM_FILE_COM_FILE_ID on SCM_B_QUOTEDPRICE_D.COM_FILE_ID = COM_FILE_COM_FILE_ID.ID where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_SCM_B_QUOTEDPRICE_D dataObj = null;
            ArrayList objArray = new ArrayList();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_B_QUOTEDPRICE_D();
                if (!sqlReader.IsDBNull(0))
                    dataObj.COMMENTS_D = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.HOSPITAL_NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.BASE_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.COM_FILE_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.PRICE = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.COM_FILE_ID_NAME = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.COM_FILE_ID_S_NAME = sqlReader.GetString(8);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_SCM_B_QUOTEDPRICE_D[] objs = new DisplayObject_SCM_B_QUOTEDPRICE_D[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_SCM_B_QUOTEDPRICE_D[] Query(CauseObject_SCM_B_QUOTEDPRICE_D cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  SCM_B_QUOTEDPRICE_D.COMMENTS_D, SCM_B_QUOTEDPRICE_D.HOSPITAL_NAME, SCM_B_QUOTEDPRICE_D.BASE_ID, SCM_B_QUOTEDPRICE_D.DISPLAY_INDEX, SCM_B_QUOTEDPRICE_D.COM_FILE_ID, SCM_B_QUOTEDPRICE_D.ID, SCM_B_QUOTEDPRICE_D.PRICE, COM_FILE_COM_FILE_ID.CLIENT_NAME as COM_FILE_ID_NAME,COM_FILE_COM_FILE_ID.SERVER_NAME as COM_FILE_ID_S_NAME from SCM_B_QUOTEDPRICE_D left join COM_FILE   COM_FILE_COM_FILE_ID on SCM_B_QUOTEDPRICE_D.COM_FILE_ID = COM_FILE_COM_FILE_ID.ID where (1=1)";
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_QUOTEDPRICE_D", paging, order, sSql, parameters, connection);
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
            DisplayObject_SCM_B_QUOTEDPRICE_D dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_B_QUOTEDPRICE_D();
                if (!sqlReader.IsDBNull(0))
                    dataObj.COMMENTS_D = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.HOSPITAL_NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.BASE_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.COM_FILE_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.PRICE = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.COM_FILE_ID_NAME = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.COM_FILE_ID_S_NAME = sqlReader.GetString(8);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SCM_B_QUOTEDPRICE_D[] objs = new DisplayObject_SCM_B_QUOTEDPRICE_D[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_SCM_B_QUOTEDPRICE_D[] Query(CauseObject_SCM_B_QUOTEDPRICE_D cause, PagingParamter paging, OrderByParameter order, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  SCM_B_QUOTEDPRICE_D.COMMENTS_D, SCM_B_QUOTEDPRICE_D.HOSPITAL_NAME, SCM_B_QUOTEDPRICE_D.BASE_ID, SCM_B_QUOTEDPRICE_D.DISPLAY_INDEX, SCM_B_QUOTEDPRICE_D.COM_FILE_ID, SCM_B_QUOTEDPRICE_D.ID, SCM_B_QUOTEDPRICE_D.PRICE, COM_FILE_COM_FILE_ID.CLIENT_NAME as COM_FILE_ID_NAME,COM_FILE_COM_FILE_ID.SERVER_NAME as COM_FILE_ID_S_NAME from SCM_B_QUOTEDPRICE_D left join COM_FILE   COM_FILE_COM_FILE_ID on SCM_B_QUOTEDPRICE_D.COM_FILE_ID = COM_FILE_COM_FILE_ID.ID where (1=1)";
            string sCauseSql = PrepareCause(cause, out parameters);
            sSql += sCauseSql;
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
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
                    paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer || IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.Db2 ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
                }
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_QUOTEDPRICE_D", paging, order, sSql, parameters, trans);
            }
            else if (order != null)
            {
                sSql += order.ToString();
                sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            }
            else
            {
                sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            }
            DisplayObject_SCM_B_QUOTEDPRICE_D dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_B_QUOTEDPRICE_D();
                if (!sqlReader.IsDBNull(0))
                    dataObj.COMMENTS_D = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.HOSPITAL_NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.BASE_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.COM_FILE_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.PRICE = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.COM_FILE_ID_NAME = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.COM_FILE_ID_S_NAME = sqlReader.GetString(8);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_SCM_B_QUOTEDPRICE_D[] objs = new DisplayObject_SCM_B_QUOTEDPRICE_D[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
    }
}
