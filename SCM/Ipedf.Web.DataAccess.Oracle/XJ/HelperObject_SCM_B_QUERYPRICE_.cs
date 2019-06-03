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
	public partial class HelperObject_SCM_B_QUERYPRICE
	{
        public static int Save_E(EntityObject_SCM_B_QUERYPRICE obj, IDbTransaction trans)
        {

            //平台自动生成代码
            obj.ID = Guid.NewGuid().ToString();
            string sSql = "insert into SCM_B_QUERYPRICE( DEPT_ID, COMMENTS, QUERY_STATE, SPEC, ID, CREATE_USER_ID, MATNR_ID, END_DATE, STATE, QUERY_DATE, DATA_ORGANISE_ID, QUERY_TYPE, NAME, CODE, MSEHT, TXZ01, CREATE_TIME, MATNR, AMOUNT, CREATE_DEPART_ID,ADJUSTPRICE_ID) values ( :DEPT_ID, :COMMENTS, :QUERY_STATE, :SPEC, :ID, :CREATE_USER_ID, :MATNR_ID, :END_DATE, :STATE, :QUERY_DATE, :DATA_ORGANISE_ID, :QUERY_TYPE, :NAME, scm_b_queryprice_seq.nextval, :MSEHT, :TXZ01, :CREATE_TIME, :MATNR, :AMOUNT, :CREATE_DEPART_ID, :ADJUSTPRICE_ID)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[20];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":DEPT_ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.DEPT_ID == null ? String.Empty : obj.DEPT_ID;
            parameters[1] = new OracleParameter();
            parameters[1].ParameterName = ":COMMENTS";
            parameters[1].Size = 300;
            parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[1].Value = obj.COMMENTS == null ? String.Empty : obj.COMMENTS;
            parameters[2] = new OracleParameter();
            parameters[2].ParameterName = ":QUERY_STATE";
            parameters[2].Size = 36;
            parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[2].Value = obj.QUERY_STATE == null ? String.Empty : obj.QUERY_STATE;
            parameters[3] = new OracleParameter();
            parameters[3].ParameterName = ":SPEC";
            parameters[3].Size = 100;
            parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[3].Value = obj.SPEC == null ? String.Empty : obj.SPEC;
            parameters[4] = new OracleParameter();
            parameters[4].ParameterName = ":ID";
            parameters[4].Size = 36;
            parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[4].Value = obj.ID == null ? String.Empty : obj.ID;
            parameters[5] = new OracleParameter();
            parameters[5].ParameterName = ":CREATE_USER_ID";
            parameters[5].Size = 36;
            parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[5].Value = obj.CREATE_USER_ID == null ? String.Empty : obj.CREATE_USER_ID;
            parameters[6] = new OracleParameter();
            parameters[6].ParameterName = ":MATNR_ID";
            parameters[6].Size = 36;
            parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[6].Value = obj.MATNR_ID == null ? String.Empty : obj.MATNR_ID;
            parameters[7] = new OracleParameter();
            parameters[7].ParameterName = ":END_DATE";
            parameters[7].Size = 7;
            parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
            parameters[7].Value = obj.END_DATE;
            parameters[8] = new OracleParameter();
            parameters[8].ParameterName = ":STATE";
            parameters[8].Size = 22;
            parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[8].Value = obj.STATE;
            parameters[9] = new OracleParameter();
            parameters[9].ParameterName = ":QUERY_DATE";
            parameters[9].Size = 7;
            parameters[9].OracleType = System.Data.OracleClient.OracleType.DateTime;
            parameters[9].Value = obj.QUERY_DATE;
            parameters[10] = new OracleParameter();
            parameters[10].ParameterName = ":DATA_ORGANISE_ID";
            parameters[10].Size = 36;
            parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[10].Value = obj.DATA_ORGANISE_ID == null ? String.Empty : obj.DATA_ORGANISE_ID;
            parameters[11] = new OracleParameter();
            parameters[11].ParameterName = ":QUERY_TYPE";
            parameters[11].Size = 36;
            parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[11].Value = obj.QUERY_TYPE == null ? String.Empty : obj.QUERY_TYPE;
            parameters[12] = new OracleParameter();
            parameters[12].ParameterName = ":NAME";
            parameters[12].Size = 50;
            parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[12].Value = obj.NAME == null ? String.Empty : obj.NAME;
            //parameters[13] = new OracleParameter();
            //parameters[13].ParameterName = ":CODE";
            //parameters[13].Size = 12;
            //parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
            //parameters[13].Value = obj.CODE == null ? String.Empty : obj.CODE;
            parameters[13] = new OracleParameter();
            parameters[13].ParameterName = ":MSEHT";
            parameters[13].Size = 10;
            parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[13].Value = obj.MSEHT == null ? String.Empty : obj.MSEHT;
            parameters[14] = new OracleParameter();
            parameters[14].ParameterName = ":TXZ01";
            parameters[14].Size = 200;
            parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[14].Value = obj.TXZ01 == null ? String.Empty : obj.TXZ01;
            parameters[15] = new OracleParameter();
            parameters[15].ParameterName = ":CREATE_TIME";
            parameters[15].Size = 7;
            parameters[15].OracleType = System.Data.OracleClient.OracleType.DateTime;
            parameters[15].Value = obj.CREATE_TIME;
            parameters[16] = new OracleParameter();
            parameters[16].ParameterName = ":MATNR";
            parameters[16].Size = 50;
            parameters[16].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[16].Value = obj.MATNR == null ? String.Empty : obj.MATNR;
            parameters[17] = new OracleParameter();
            parameters[17].ParameterName = ":AMOUNT";
            parameters[17].Size = 22;
            parameters[17].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[17].Value = obj.AMOUNT;
            parameters[18] = new OracleParameter();
            parameters[18].ParameterName = ":CREATE_DEPART_ID";
            parameters[18].Size = 36;
            parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[18].Value = obj.CREATE_DEPART_ID == null ? String.Empty : obj.CREATE_DEPART_ID;
            parameters[19] = new OracleParameter();
            parameters[19].ParameterName = ":ADJUSTPRICE_ID";
            parameters[19].Size = 36;
            parameters[19].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[19].Value = obj.ADJUSTPRICE_ID == null ? String.Empty : obj.ADJUSTPRICE_ID;
            #endregion
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }

		public static DisplayObject_SCM_B_QUERYPRICE_I[] Query_I(CauseObject_SCM_B_QUERYPRICE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
            string sSql = " select  SCM_B_QUERYPRICE.COMMENTS, SCM_B_QUERYPRICE.QUERY_STATE, SCM_B_QUERYPRICE.SPEC, SCM_B_QUERYPRICE.ID, SCM_B_QUERYPRICE.CREATE_USER_ID, SCM_B_QUERYPRICE.MODIFY_USER_ID, SCM_B_QUERYPRICE.MATNR_ID, SCM_B_QUERYPRICE.END_DATE, SCM_B_QUERYPRICE.DEPT_ID, SCM_B_QUERYPRICE.CODE, SCM_B_QUERYPRICE.CREATE_TIME, SCM_B_QUERYPRICE.STATE, SCM_B_QUERYPRICE.DATA_ORGANISE_ID, SCM_B_QUERYPRICE.MODIFY_DEPART_ID, SCM_B_QUERYPRICE.NAME, SCM_B_QUERYPRICE.CREATE_DEPART_ID, SCM_B_QUERYPRICE.QUERY_DATE, SCM_B_QUERYPRICE.MATNR, SCM_B_QUERYPRICE.TXZ01, SCM_B_QUERYPRICE.MODIFY_TIME, SCM_B_QUERYPRICE.AMOUNT, SCM_B_QUERYPRICE.MSEHT, SCM_B_QUERYPRICE.QUERY_TYPE, COM_TYPE_QUERY_STATE.NAME as QUERY_STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, (case  when SCM_B_QUERYPRICE.STATE = 0 then '默认值' when SCM_B_QUERYPRICE.STATE = 1 then '编辑中' when SCM_B_QUERYPRICE.STATE = 2 then '已提交' when SCM_B_QUERYPRICE.STATE = 3 then '已审核' when SCM_B_QUERYPRICE.STATE = 4 then '已归档' when SCM_B_QUERYPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_QUERY_TYPE.NAME as QUERY_TYPE_NAME,PRODUCTS.PRODUCT_NAME,QUERYPRICE_D_ALL.ALLCOUNT,QUERYPRICE_D_ACT.ACTCOUNT,SCM_D_HRPMATER.ZEINR,SCM_B_QUERYPRICE.ADJUSTPRICE_ID from SCM_B_QUERYPRICE INNER JOIN SCM_D_HRPMATER ON SCM_D_HRPMATER.ID = SCM_B_QUERYPRICE.MATNR_ID LEFT JOIN (SELECT D.BASE_ID,COUNT(*) ALLCOUNT FROM SCM_B_QUERYPRICE_D D INNER JOIN SCM_B_QUERYPRICE P ON D.BASE_ID = P.ID GROUP BY D.BASE_ID) QUERYPRICE_D_ALL ON QUERYPRICE_D_ALL.BASE_ID = SCM_B_QUERYPRICE.ID LEFT JOIN (SELECT BASE_ID,COUNT(*) ACTCOUNT FROM (SELECT BASE_ID,GYSACCOUNT FROM SCM_B_QUOTEDPRICE WHERE STATE = 2 GROUP BY BASE_ID,GYSACCOUNT) GYSAT  GROUP BY BASE_ID) QUERYPRICE_D_ACT ON QUERYPRICE_D_ACT.BASE_ID = SCM_B_QUERYPRICE.ID left join (select BASE_ID,wm_concat(PRODUCT_NAME) PRODUCT_NAME from SCM_B_QUERYPRICE_PRODUCT group by BASE_ID) PRODUCTS ON PRODUCTS.BASE_ID = SCM_B_QUERYPRICE.ID left join COM_TYPE   COM_TYPE_QUERY_STATE on SCM_B_QUERYPRICE.QUERY_STATE = COM_TYPE_QUERY_STATE.ID left join COM_DEPART   COM_DEPART_DEPT_ID on SCM_B_QUERYPRICE.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_QUERY_TYPE on SCM_B_QUERYPRICE.QUERY_TYPE = COM_TYPE_QUERY_TYPE.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
            DisplayObject_SCM_B_QUERYPRICE_I dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
                dataObj = new DisplayObject_SCM_B_QUERYPRICE_I();
                if (!sqlReader.IsDBNull(0))
                    dataObj.COMMENTS = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.QUERY_STATE = sqlReader.GetString(1);
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
                {
                    dataObj.END_DATE = sqlReader.GetDateTime(7);
                    dataObj.END_DATES = sqlReader.GetDateTime(7).ToString("yyyy-MM-dd");
                }
                if (!sqlReader.IsDBNull(8))
                    dataObj.DEPT_ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.CODE = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.STATE = sqlReader.GetDecimal(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.NAME = sqlReader.GetString(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                {
                    dataObj.QUERY_DATE = sqlReader.GetDateTime(16);
                    dataObj.QUERY_DATES = sqlReader.GetDateTime(16).ToString("yyyy-MM-dd");
                }
                if (!sqlReader.IsDBNull(17))
                    dataObj.MATNR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.TXZ01 = sqlReader.GetString(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.AMOUNT = sqlReader.GetDecimal(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.MSEHT = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.QUERY_TYPE = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.QUERY_STATE_NAME = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.DEPT_ID_NAME = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.STATE_NAME = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.PRODUCT_NAME = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.ALLCOUNT = sqlReader.GetDecimal(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.ACTCOUNT = sqlReader.GetDecimal(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.ZEINR = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.ADJUSTPRICE_ID = sqlReader.GetString(30);
                objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
            DisplayObject_SCM_B_QUERYPRICE_I[] objs = new DisplayObject_SCM_B_QUERYPRICE_I[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
        public static DisplayObject_SCM_B_QUERYPRICE_I[] Query_I(CauseObject_SCM_B_QUERYPRICE cause, PagingParamter paging, OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
            string sSql = " select  SCM_B_QUERYPRICE.COMMENTS, SCM_B_QUERYPRICE.QUERY_STATE, SCM_B_QUERYPRICE.SPEC, SCM_B_QUERYPRICE.ID, SCM_B_QUERYPRICE.CREATE_USER_ID, SCM_B_QUERYPRICE.MODIFY_USER_ID, SCM_B_QUERYPRICE.MATNR_ID, SCM_B_QUERYPRICE.END_DATE, SCM_B_QUERYPRICE.DEPT_ID, SCM_B_QUERYPRICE.CODE, SCM_B_QUERYPRICE.CREATE_TIME, SCM_B_QUERYPRICE.STATE, SCM_B_QUERYPRICE.DATA_ORGANISE_ID, SCM_B_QUERYPRICE.MODIFY_DEPART_ID, SCM_B_QUERYPRICE.NAME, SCM_B_QUERYPRICE.CREATE_DEPART_ID, SCM_B_QUERYPRICE.QUERY_DATE, SCM_B_QUERYPRICE.MATNR, SCM_B_QUERYPRICE.TXZ01, SCM_B_QUERYPRICE.MODIFY_TIME, SCM_B_QUERYPRICE.AMOUNT, SCM_B_QUERYPRICE.MSEHT, SCM_B_QUERYPRICE.QUERY_TYPE, COM_TYPE_QUERY_STATE.NAME as QUERY_STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, (case  when SCM_B_QUERYPRICE.STATE = 0 then '默认值' when SCM_B_QUERYPRICE.STATE = 1 then '编辑中' when SCM_B_QUERYPRICE.STATE = 2 then '已提交' when SCM_B_QUERYPRICE.STATE = 3 then '已审核' when SCM_B_QUERYPRICE.STATE = 4 then '已归档' when SCM_B_QUERYPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_QUERY_TYPE.NAME as QUERY_TYPE_NAME,PRODUCTS.PRODUCT_NAME,QUERYPRICE_D_ALL.ALLCOUNT,QUERYPRICE_D_ACT.ACTCOUNT,SCM_D_HRPMATER.ZEINR,SCM_B_QUERYPRICE.ADJUSTPRICE_ID from SCM_B_QUERYPRICE INNER JOIN SCM_D_HRPMATER ON SCM_D_HRPMATER.ID = SCM_B_QUERYPRICE.MATNR_ID LEFT JOIN (SELECT D.BASE_ID,COUNT(*) ALLCOUNT FROM SCM_B_QUERYPRICE_D D INNER JOIN SCM_B_QUERYPRICE P ON D.BASE_ID = P.ID GROUP BY D.BASE_ID) QUERYPRICE_D_ALL ON QUERYPRICE_D_ALL.BASE_ID = SCM_B_QUERYPRICE.ID LEFT JOIN (SELECT BASE_ID,COUNT(*) ACTCOUNT FROM (SELECT BASE_ID,GYSACCOUNT FROM SCM_B_QUOTEDPRICE WHERE STATE = 2 GROUP BY BASE_ID,GYSACCOUNT) GYSAT  GROUP BY BASE_ID) QUERYPRICE_D_ACT ON QUERYPRICE_D_ACT.BASE_ID = SCM_B_QUERYPRICE.ID left join (select BASE_ID,wm_concat(PRODUCT_NAME) PRODUCT_NAME from SCM_B_QUERYPRICE_PRODUCT group by BASE_ID) PRODUCTS ON PRODUCTS.BASE_ID = SCM_B_QUERYPRICE.ID left join COM_TYPE   COM_TYPE_QUERY_STATE on SCM_B_QUERYPRICE.QUERY_STATE = COM_TYPE_QUERY_STATE.ID left join COM_DEPART   COM_DEPART_DEPT_ID on SCM_B_QUERYPRICE.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_QUERY_TYPE on SCM_B_QUERYPRICE.QUERY_TYPE = COM_TYPE_QUERY_TYPE.ID where (1=1)";

			string sCauseSql = PrepareCause(cause,out parameters);
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_QUERYPRICE",paging, order, sSql, parameters, connection);
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
            DisplayObject_SCM_B_QUERYPRICE_I dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
                dataObj = new DisplayObject_SCM_B_QUERYPRICE_I();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.QUERY_STATE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPEC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MATNR_ID = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                {
                    dataObj.END_DATE = sqlReader.GetDateTime(7);
                    dataObj.END_DATES = sqlReader.GetDateTime(7).ToString("yyyy-MM-dd");
                }
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.STATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                {
                    dataObj.QUERY_DATE = sqlReader.GetDateTime(16);
                    dataObj.QUERY_DATES = sqlReader.GetDateTime(16).ToString("yyyy-MM-dd");
                }
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MATNR = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.TXZ01 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.STATE_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.PRODUCT_NAME = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.ALLCOUNT = sqlReader.GetDecimal(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.ACTCOUNT = sqlReader.GetDecimal(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.ZEINR = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.ADJUSTPRICE_ID = sqlReader.GetString(30);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
            DisplayObject_SCM_B_QUERYPRICE_I[] objs = new DisplayObject_SCM_B_QUERYPRICE_I[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
        }
	}
}
