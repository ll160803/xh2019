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
	[CauseObject(typeof(CauseObject_V_COM_QUERY_CODE))]	
	public partial class HelperObject_V_COM_QUERY_CODE
	{		
		#region Method Blok
		public static DisplayObject_V_COM_QUERY_CODE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_COM_QUERY_CODE.NAME, V_COM_QUERY_CODE.DATA_ORGANISE_ID, V_COM_QUERY_CODE.ID, V_COM_QUERY_CODE.CODE, V_COM_QUERY_CODE.CODE_ID, V_COM_QUERY_CODE.CODE_WIDTH, V_COM_QUERY_CODE.CODE_INDEX, V_COM_QUERY_CODE.STATE, V_COM_QUERY_CODE.CODE_VALUE, V_COM_QUERY_CODE.CODE_TYPE from V_COM_QUERY_CODE where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_COM_QUERY_CODE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_CODE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE_WIDTH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE_VALUE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE_TYPE = sqlReader.GetDecimal(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_CODE[] objs = new DisplayObject_V_COM_QUERY_CODE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_COM_QUERY_CODE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.NAME!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_CODE.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if(cause.DATA_ORGANISE_ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_CODE.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_CODE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if(cause.CODE!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_CODE.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if(cause.CODE_ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_CODE.CODE_ID ").Append((cause.CODE_ID.StartsWith("%") || cause.CODE_ID.EndsWith("%")) ? " like " : " = ").Append(" :CODE_ID");
				param = new OracleParameter();
				param.ParameterName =":CODE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CODE_ID;
				paramList.Add(param);
			}
			if(cause.CODE_WIDTH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_COM_QUERY_CODE.CODE_WIDTH = :CODE_WIDTH");
				param = new OracleParameter();
				param.ParameterName =":CODE_WIDTH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CODE_WIDTH;
				paramList.Add(param);
			}
			if(cause.CODE_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_COM_QUERY_CODE.CODE_INDEX = :CODE_INDEX");
				param = new OracleParameter();
				param.ParameterName =":CODE_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CODE_INDEX;
				paramList.Add(param);
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_COM_QUERY_CODE.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if(cause.CODE_VALUE!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_CODE.CODE_VALUE ").Append((cause.CODE_VALUE.StartsWith("%") || cause.CODE_VALUE.EndsWith("%")) ? " like " : " = ").Append(" :CODE_VALUE");
				param = new OracleParameter();
				param.ParameterName =":CODE_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE_VALUE;
				paramList.Add(param);
			}
			if(cause.CODE_TYPE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_COM_QUERY_CODE.CODE_TYPE = :CODE_TYPE");
				param = new OracleParameter();
				param.ParameterName =":CODE_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CODE_TYPE;
				paramList.Add(param);
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return strBuf.ToString();


		}
		public static DisplayObject_V_COM_QUERY_CODE[] Query(CauseObject_V_COM_QUERY_CODE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_CODE.NAME, V_COM_QUERY_CODE.DATA_ORGANISE_ID, V_COM_QUERY_CODE.ID, V_COM_QUERY_CODE.CODE, V_COM_QUERY_CODE.CODE_ID, V_COM_QUERY_CODE.CODE_WIDTH, V_COM_QUERY_CODE.CODE_INDEX, V_COM_QUERY_CODE.STATE, V_COM_QUERY_CODE.CODE_VALUE, V_COM_QUERY_CODE.CODE_TYPE from V_COM_QUERY_CODE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_COM_QUERY_CODE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_CODE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE_WIDTH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE_VALUE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE_TYPE = sqlReader.GetDecimal(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_CODE[] objs = new DisplayObject_V_COM_QUERY_CODE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_CODE[] Query(CauseObject_V_COM_QUERY_CODE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_CODE.NAME, V_COM_QUERY_CODE.DATA_ORGANISE_ID, V_COM_QUERY_CODE.ID, V_COM_QUERY_CODE.CODE, V_COM_QUERY_CODE.CODE_ID, V_COM_QUERY_CODE.CODE_WIDTH, V_COM_QUERY_CODE.CODE_INDEX, V_COM_QUERY_CODE.STATE, V_COM_QUERY_CODE.CODE_VALUE, V_COM_QUERY_CODE.CODE_TYPE from V_COM_QUERY_CODE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_COM_QUERY_CODE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_CODE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE_WIDTH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE_VALUE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE_TYPE = sqlReader.GetDecimal(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_CODE[] objs = new DisplayObject_V_COM_QUERY_CODE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_CODE[] Query(CauseObject_V_COM_QUERY_CODE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_CODE.NAME, V_COM_QUERY_CODE.DATA_ORGANISE_ID, V_COM_QUERY_CODE.ID, V_COM_QUERY_CODE.CODE, V_COM_QUERY_CODE.CODE_ID, V_COM_QUERY_CODE.CODE_WIDTH, V_COM_QUERY_CODE.CODE_INDEX, V_COM_QUERY_CODE.STATE, V_COM_QUERY_CODE.CODE_VALUE, V_COM_QUERY_CODE.CODE_TYPE from V_COM_QUERY_CODE where (1=1)";
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
					countSql = "Select Count(*) From V_COM_QUERY_CODE Where (1=1)" + sCauseSql;
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_COM_QUERY_CODE",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_COM_QUERY_CODE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_CODE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE_WIDTH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE_VALUE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE_TYPE = sqlReader.GetDecimal(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_CODE[] objs = new DisplayObject_V_COM_QUERY_CODE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_CODE[] Query(CauseObject_V_COM_QUERY_CODE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_CODE.NAME, V_COM_QUERY_CODE.DATA_ORGANISE_ID, V_COM_QUERY_CODE.ID, V_COM_QUERY_CODE.CODE, V_COM_QUERY_CODE.CODE_ID, V_COM_QUERY_CODE.CODE_WIDTH, V_COM_QUERY_CODE.CODE_INDEX, V_COM_QUERY_CODE.STATE, V_COM_QUERY_CODE.CODE_VALUE, V_COM_QUERY_CODE.CODE_TYPE from V_COM_QUERY_CODE where (1=1)";
			string sCauseSql = PrepareCause(cause,out parameters);
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
					countSql = "Select Count(*) From V_COM_QUERY_CODE Where (1=1)" + sCauseSql;
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer || IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.Db2? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_COM_QUERY_CODE",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_COM_QUERY_CODE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_CODE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE_WIDTH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE_VALUE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CODE_TYPE = sqlReader.GetDecimal(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_CODE[] objs = new DisplayObject_V_COM_QUERY_CODE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
