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
    public partial class HelperObject_SCM_B_PRICEADJUST
    {
        public static int Save(EntityObject_SCM_B_PRICEADJUST obj, IDbTransaction trans)
        {

            //平台自动生成代码
            if (string.IsNullOrEmpty(obj.ID))
            {
                obj.ID = Guid.NewGuid().ToString();
            }
            string sSql = "insert into SCM_B_PRICEADJUST( CREATE_DATE, COMMENTS, SPEC, ID, CREATE_USER_ID, MATNR_ID, ADJUST_PRICE, CREATE_TIME, STATE, DATA_ORGANISE_ID, NAME, CREATE_DEPART_ID, CODE, MATNR, TXZ01, GYSACCOUNT, GYSNAME, OLD_PRICE, MSEHT) values ( :CREATE_DATE, :COMMENTS, :SPEC, :ID, :CREATE_USER_ID, :MATNR_ID, :ADJUST_PRICE, :CREATE_TIME, :STATE, :DATA_ORGANISE_ID, :NAME, :CREATE_DEPART_ID, :CODE, :MATNR, :TXZ01, :GYSACCOUNT, :GYSNAME, :OLD_PRICE, :MSEHT)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[19];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":CREATE_DATE";
            parameters[0].Size = 7;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.DateTime;
            parameters[0].Value = obj.CREATE_DATE;
            parameters[1] = new OracleParameter();
            parameters[1].ParameterName = ":COMMENTS";
            parameters[1].Size = 300;
            parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[1].Value = obj.COMMENTS == null ? String.Empty : obj.COMMENTS;
            parameters[2] = new OracleParameter();
            parameters[2].ParameterName = ":SPEC";
            parameters[2].Size = 100;
            parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[2].Value = obj.SPEC == null ? String.Empty : obj.SPEC;
            parameters[3] = new OracleParameter();
            parameters[3].ParameterName = ":ID";
            parameters[3].Size = 36;
            parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[3].Value = obj.ID == null ? String.Empty : obj.ID;
            parameters[4] = new OracleParameter();
            parameters[4].ParameterName = ":CREATE_USER_ID";
            parameters[4].Size = 36;
            parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[4].Value = obj.CREATE_USER_ID == null ? String.Empty : obj.CREATE_USER_ID;
            parameters[5] = new OracleParameter();
            parameters[5].ParameterName = ":MATNR_ID";
            parameters[5].Size = 36;
            parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[5].Value = obj.MATNR_ID == null ? String.Empty : obj.MATNR_ID;
            parameters[6] = new OracleParameter();
            parameters[6].ParameterName = ":ADJUST_PRICE";
            parameters[6].Size = 22;
            parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[6].Value = obj.ADJUST_PRICE;
            parameters[7] = new OracleParameter();
            parameters[7].ParameterName = ":CREATE_TIME";
            parameters[7].Size = 7;
            parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
            parameters[7].Value = obj.CREATE_TIME;
            parameters[8] = new OracleParameter();
            parameters[8].ParameterName = ":STATE";
            parameters[8].Size = 22;
            parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[8].Value = obj.STATE;
            parameters[9] = new OracleParameter();
            parameters[9].ParameterName = ":DATA_ORGANISE_ID";
            parameters[9].Size = 36;
            parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[9].Value = obj.DATA_ORGANISE_ID == null ? String.Empty : obj.DATA_ORGANISE_ID;
            parameters[10] = new OracleParameter();
            parameters[10].ParameterName = ":NAME";
            parameters[10].Size = 50;
            parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[10].Value = obj.NAME == null ? String.Empty : obj.NAME;
            parameters[11] = new OracleParameter();
            parameters[11].ParameterName = ":CREATE_DEPART_ID";
            parameters[11].Size = 36;
            parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[11].Value = obj.CREATE_DEPART_ID == null ? String.Empty : obj.CREATE_DEPART_ID;
            parameters[12] = new OracleParameter();
            parameters[12].ParameterName = ":CODE";
            parameters[12].Size = 12;
            parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[12].Value = obj.CODE == null ? String.Empty : obj.CODE;
            parameters[13] = new OracleParameter();
            parameters[13].ParameterName = ":MATNR";
            parameters[13].Size = 50;
            parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[13].Value = obj.MATNR == null ? String.Empty : obj.MATNR;
            parameters[14] = new OracleParameter();
            parameters[14].ParameterName = ":TXZ01";
            parameters[14].Size = 200;
            parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[14].Value = obj.TXZ01 == null ? String.Empty : obj.TXZ01;
            parameters[15] = new OracleParameter();
            parameters[15].ParameterName = ":GYSACCOUNT";
            parameters[15].Size = 20;
            parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[15].Value = obj.GYSACCOUNT == null ? String.Empty : obj.GYSACCOUNT;
            parameters[16] = new OracleParameter();
            parameters[16].ParameterName = ":GYSNAME";
            parameters[16].Size = 100;
            parameters[16].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[16].Value = obj.GYSNAME == null ? String.Empty : obj.GYSNAME;
            parameters[17] = new OracleParameter();
            parameters[17].ParameterName = ":OLD_PRICE";
            parameters[17].Size = 22;
            parameters[17].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[17].Value = obj.OLD_PRICE;
            parameters[18] = new OracleParameter();
            parameters[18].ParameterName = ":MSEHT";
            parameters[18].Size = 10;
            parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[18].Value = obj.MSEHT == null ? String.Empty : obj.MSEHT;
            #endregion
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }

        public static DisplayObject_SCM_B_PRICEADJUST[] QueryPost(CauseObject_SCM_B_PRICEADJUST cause)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  SCM_B_PRICEADJUST.CREATE_DATE, SCM_B_PRICEADJUST.COMMENTS, SCM_B_PRICEADJUST.SPEC, SCM_B_PRICEADJUST.ID, SCM_B_PRICEADJUST.CREATE_USER_ID, SCM_B_PRICEADJUST.MODIFY_USER_ID, SCM_B_PRICEADJUST.MATNR_ID, SCM_B_PRICEADJUST.ADJUST_PRICE, SCM_B_PRICEADJUST.CREATE_TIME, SCM_B_PRICEADJUST.STATE, SCM_B_PRICEADJUST.DATA_ORGANISE_ID, SCM_B_PRICEADJUST.NAME, SCM_B_PRICEADJUST.CREATE_DEPART_ID, SCM_B_PRICEADJUST.CODE, SCM_B_PRICEADJUST.MATNR, SCM_B_PRICEADJUST.TXZ01, SCM_B_PRICEADJUST.GYSACCOUNT, SCM_B_PRICEADJUST.MODIFY_TIME, SCM_B_PRICEADJUST.GYSNAME, SCM_B_PRICEADJUST.OLD_PRICE, SCM_B_PRICEADJUST.MSEHT, SCM_B_PRICEADJUST.MODIFY_DEPART_ID,(SELECT COUNT(*) FROM SCM_B_QUERYPRICE WHERE ADJUSTPRICE_ID = SCM_B_PRICEADJUST.ID) IS_QUERYPRICE from SCM_B_PRICEADJUST where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_SCM_B_PRICEADJUST dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_B_PRICEADJUST();
                if (!sqlReader.IsDBNull(0))
                    dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.COMMENTS = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.SPEC = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.MATNR_ID = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.ADJUST_PRICE = sqlReader.GetDecimal(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.STATE = sqlReader.GetDecimal(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.NAME = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.CODE = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.MATNR = sqlReader.GetString(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.TXZ01 = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.GYSACCOUNT = sqlReader.GetString(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.GYSNAME = sqlReader.GetString(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.OLD_PRICE = sqlReader.GetDecimal(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.MSEHT = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.IS_QUERYPRICE = sqlReader.GetDecimal(22);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SCM_B_PRICEADJUST[] objs = new DisplayObject_SCM_B_PRICEADJUST[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }

        public static DisplayObject_SCM_B_PRICEADJUST[] QueryPost(CauseObject_SCM_B_PRICEADJUST cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  SCM_B_PRICEADJUST.CREATE_DATE, SCM_B_PRICEADJUST.COMMENTS, SCM_B_PRICEADJUST.SPEC, SCM_B_PRICEADJUST.ID, SCM_B_PRICEADJUST.CREATE_USER_ID, SCM_B_PRICEADJUST.MODIFY_USER_ID, SCM_B_PRICEADJUST.MATNR_ID, SCM_B_PRICEADJUST.ADJUST_PRICE, SCM_B_PRICEADJUST.CREATE_TIME, SCM_B_PRICEADJUST.STATE, SCM_B_PRICEADJUST.DATA_ORGANISE_ID, SCM_B_PRICEADJUST.NAME, SCM_B_PRICEADJUST.CREATE_DEPART_ID, SCM_B_PRICEADJUST.CODE, SCM_B_PRICEADJUST.MATNR, SCM_B_PRICEADJUST.TXZ01, SCM_B_PRICEADJUST.GYSACCOUNT, SCM_B_PRICEADJUST.MODIFY_TIME, SCM_B_PRICEADJUST.GYSNAME, SCM_B_PRICEADJUST.OLD_PRICE, SCM_B_PRICEADJUST.MSEHT, SCM_B_PRICEADJUST.MODIFY_DEPART_ID,(SELECT COUNT(*) FROM SCM_B_QUERYPRICE WHERE ADJUSTPRICE_ID = SCM_B_PRICEADJUST.ID) IS_QUERYPRICE from SCM_B_PRICEADJUST where (1=1)";
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_PRICEADJUST", paging, order, sSql, parameters, connection);
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
            DisplayObject_SCM_B_PRICEADJUST dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_B_PRICEADJUST();
                if (!sqlReader.IsDBNull(0))
                    dataObj.CREATE_DATE = sqlReader.GetDateTime(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.COMMENTS = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.SPEC = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.MATNR_ID = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.ADJUST_PRICE = sqlReader.GetDecimal(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.STATE = sqlReader.GetDecimal(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.NAME = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.CODE = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.MATNR = sqlReader.GetString(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.TXZ01 = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.GYSACCOUNT = sqlReader.GetString(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.GYSNAME = sqlReader.GetString(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.OLD_PRICE = sqlReader.GetDecimal(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.MSEHT = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.IS_QUERYPRICE = sqlReader.GetDecimal(22);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SCM_B_PRICEADJUST[] objs = new DisplayObject_SCM_B_PRICEADJUST[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
    }
}
