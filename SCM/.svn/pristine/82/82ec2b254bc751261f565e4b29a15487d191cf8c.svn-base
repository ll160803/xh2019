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
	[CauseObject(typeof(CauseObject_V_COM_QUERY_DATA_LINK))]	
	public partial class HelperObject_V_COM_QUERY_DATA_LINK
	{		
		#region Method Blok
		public static DisplayObject_V_COM_QUERY_DATA_LINK[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_COM_QUERY_DATA_LINK.CREATE_DEPART_ID, V_COM_QUERY_DATA_LINK.DEFAULT_PAGE_URL, V_COM_QUERY_DATA_LINK.NAME, V_COM_QUERY_DATA_LINK.CREATE_TIME, V_COM_QUERY_DATA_LINK.DATA_ORGANISE_ID, V_COM_QUERY_DATA_LINK.DATA_INSTANCE_CODE, V_COM_QUERY_DATA_LINK.ID, V_COM_QUERY_DATA_LINK.CREATE_USER_ID, V_COM_QUERY_DATA_LINK.DATA_INSTANCE_ID, V_COM_QUERY_DATA_LINK.PARENT_DATA_ID, V_COM_QUERY_DATA_LINK.PARENT_INSTANCE_ID, COM_DEPART.NAME as COM_DEPART_NAME, COM_USER.NAME as COM_USER_NAME from V_COM_QUERY_DATA_LINK left join COM_DEPART   COM_DEPART on V_COM_QUERY_DATA_LINK.CREATE_DEPART_ID = COM_DEPART.ID left join COM_USER   COM_USER on V_COM_QUERY_DATA_LINK.CREATE_USER_ID = COM_USER.DEPART_ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_COM_QUERY_DATA_LINK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_DATA_LINK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DATA_INSTANCE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_INSTANCE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_DATA_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PARENT_INSTANCE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_DEPART_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_DATA_LINK[] objs = new DisplayObject_V_COM_QUERY_DATA_LINK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_COM_QUERY_DATA_LINK cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.CREATE_DEPART_ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_DATA_LINK.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if(cause.DEFAULT_PAGE_URL!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_DATA_LINK.DEFAULT_PAGE_URL ").Append((cause.DEFAULT_PAGE_URL.StartsWith("%") || cause.DEFAULT_PAGE_URL.EndsWith("%")) ? " like " : " = ").Append(" :DEFAULT_PAGE_URL");
				param = new OracleParameter();
				param.ParameterName =":DEFAULT_PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.DEFAULT_PAGE_URL;
				paramList.Add(param);
			}
			if(cause.NAME!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_DATA_LINK.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And V_COM_QUERY_DATA_LINK.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And V_COM_QUERY_DATA_LINK.CREATE_TIME < :CREATE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.End;
					paramList.Add(param);
				}
			}
			if(cause.DATA_ORGANISE_ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_DATA_LINK.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if(cause.DATA_INSTANCE_CODE!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_DATA_LINK.DATA_INSTANCE_CODE ").Append((cause.DATA_INSTANCE_CODE.StartsWith("%") || cause.DATA_INSTANCE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :DATA_INSTANCE_CODE");
				param = new OracleParameter();
				param.ParameterName =":DATA_INSTANCE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DATA_INSTANCE_CODE;
				paramList.Add(param);
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_DATA_LINK.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if(cause.CREATE_USER_ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_DATA_LINK.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if(cause.DATA_INSTANCE_ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_DATA_LINK.DATA_INSTANCE_ID ").Append((cause.DATA_INSTANCE_ID.StartsWith("%") || cause.DATA_INSTANCE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_INSTANCE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_INSTANCE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_INSTANCE_ID;
				paramList.Add(param);
			}
			if(cause.PARENT_DATA_ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_DATA_LINK.PARENT_DATA_ID ").Append((cause.PARENT_DATA_ID.StartsWith("%") || cause.PARENT_DATA_ID.EndsWith("%")) ? " like " : " = ").Append(" :PARENT_DATA_ID");
				param = new OracleParameter();
				param.ParameterName =":PARENT_DATA_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PARENT_DATA_ID;
				paramList.Add(param);
			}
			if(cause.PARENT_INSTANCE_ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_DATA_LINK.PARENT_INSTANCE_ID ").Append((cause.PARENT_INSTANCE_ID.StartsWith("%") || cause.PARENT_INSTANCE_ID.EndsWith("%")) ? " like " : " = ").Append(" :PARENT_INSTANCE_ID");
				param = new OracleParameter();
				param.ParameterName =":PARENT_INSTANCE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PARENT_INSTANCE_ID;
				paramList.Add(param);
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return strBuf.ToString();


		}
		public static DisplayObject_V_COM_QUERY_DATA_LINK[] Query(CauseObject_V_COM_QUERY_DATA_LINK cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_DATA_LINK.CREATE_DEPART_ID, V_COM_QUERY_DATA_LINK.DEFAULT_PAGE_URL, V_COM_QUERY_DATA_LINK.NAME, V_COM_QUERY_DATA_LINK.CREATE_TIME, V_COM_QUERY_DATA_LINK.DATA_ORGANISE_ID, V_COM_QUERY_DATA_LINK.DATA_INSTANCE_CODE, V_COM_QUERY_DATA_LINK.ID, V_COM_QUERY_DATA_LINK.CREATE_USER_ID, V_COM_QUERY_DATA_LINK.DATA_INSTANCE_ID, V_COM_QUERY_DATA_LINK.PARENT_DATA_ID, V_COM_QUERY_DATA_LINK.PARENT_INSTANCE_ID, COM_DEPART.NAME as COM_DEPART_NAME, COM_USER.NAME as COM_USER_NAME from V_COM_QUERY_DATA_LINK left join COM_DEPART   COM_DEPART on V_COM_QUERY_DATA_LINK.CREATE_DEPART_ID = COM_DEPART.ID left join COM_USER   COM_USER on V_COM_QUERY_DATA_LINK.CREATE_USER_ID = COM_USER.DEPART_ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_COM_QUERY_DATA_LINK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_DATA_LINK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DATA_INSTANCE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_INSTANCE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_DATA_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PARENT_INSTANCE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_DEPART_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_DATA_LINK[] objs = new DisplayObject_V_COM_QUERY_DATA_LINK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_DATA_LINK[] Query(CauseObject_V_COM_QUERY_DATA_LINK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_DATA_LINK.CREATE_DEPART_ID, V_COM_QUERY_DATA_LINK.DEFAULT_PAGE_URL, V_COM_QUERY_DATA_LINK.NAME, V_COM_QUERY_DATA_LINK.CREATE_TIME, V_COM_QUERY_DATA_LINK.DATA_ORGANISE_ID, V_COM_QUERY_DATA_LINK.DATA_INSTANCE_CODE, V_COM_QUERY_DATA_LINK.ID, V_COM_QUERY_DATA_LINK.CREATE_USER_ID, V_COM_QUERY_DATA_LINK.DATA_INSTANCE_ID, V_COM_QUERY_DATA_LINK.PARENT_DATA_ID, V_COM_QUERY_DATA_LINK.PARENT_INSTANCE_ID, COM_DEPART.NAME as COM_DEPART_NAME, COM_USER.NAME as COM_USER_NAME from V_COM_QUERY_DATA_LINK left join COM_DEPART   COM_DEPART on V_COM_QUERY_DATA_LINK.CREATE_DEPART_ID = COM_DEPART.ID left join COM_USER   COM_USER on V_COM_QUERY_DATA_LINK.CREATE_USER_ID = COM_USER.DEPART_ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_COM_QUERY_DATA_LINK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_DATA_LINK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DATA_INSTANCE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_INSTANCE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_DATA_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PARENT_INSTANCE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_DEPART_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_DATA_LINK[] objs = new DisplayObject_V_COM_QUERY_DATA_LINK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_DATA_LINK[] Query(CauseObject_V_COM_QUERY_DATA_LINK cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_DATA_LINK.CREATE_DEPART_ID, V_COM_QUERY_DATA_LINK.DEFAULT_PAGE_URL, V_COM_QUERY_DATA_LINK.NAME, V_COM_QUERY_DATA_LINK.CREATE_TIME, V_COM_QUERY_DATA_LINK.DATA_ORGANISE_ID, V_COM_QUERY_DATA_LINK.DATA_INSTANCE_CODE, V_COM_QUERY_DATA_LINK.ID, V_COM_QUERY_DATA_LINK.CREATE_USER_ID, V_COM_QUERY_DATA_LINK.DATA_INSTANCE_ID, V_COM_QUERY_DATA_LINK.PARENT_DATA_ID, V_COM_QUERY_DATA_LINK.PARENT_INSTANCE_ID, COM_DEPART.NAME as COM_DEPART_NAME, COM_USER.NAME as COM_USER_NAME from V_COM_QUERY_DATA_LINK left join COM_DEPART   COM_DEPART on V_COM_QUERY_DATA_LINK.CREATE_DEPART_ID = COM_DEPART.ID left join COM_USER   COM_USER on V_COM_QUERY_DATA_LINK.CREATE_USER_ID = COM_USER.DEPART_ID where (1=1)";
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
					countSql = "Select Count(*) From V_COM_QUERY_DATA_LINK Where (1=1)" + sCauseSql;
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_COM_QUERY_DATA_LINK",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_COM_QUERY_DATA_LINK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_DATA_LINK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DATA_INSTANCE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_INSTANCE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_DATA_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PARENT_INSTANCE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_DEPART_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_DATA_LINK[] objs = new DisplayObject_V_COM_QUERY_DATA_LINK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_DATA_LINK[] Query(CauseObject_V_COM_QUERY_DATA_LINK cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_DATA_LINK.CREATE_DEPART_ID, V_COM_QUERY_DATA_LINK.DEFAULT_PAGE_URL, V_COM_QUERY_DATA_LINK.NAME, V_COM_QUERY_DATA_LINK.CREATE_TIME, V_COM_QUERY_DATA_LINK.DATA_ORGANISE_ID, V_COM_QUERY_DATA_LINK.DATA_INSTANCE_CODE, V_COM_QUERY_DATA_LINK.ID, V_COM_QUERY_DATA_LINK.CREATE_USER_ID, V_COM_QUERY_DATA_LINK.DATA_INSTANCE_ID, V_COM_QUERY_DATA_LINK.PARENT_DATA_ID, V_COM_QUERY_DATA_LINK.PARENT_INSTANCE_ID, COM_DEPART.NAME as COM_DEPART_NAME, COM_USER.NAME as COM_USER_NAME from V_COM_QUERY_DATA_LINK left join COM_DEPART   COM_DEPART on V_COM_QUERY_DATA_LINK.CREATE_DEPART_ID = COM_DEPART.ID left join COM_USER   COM_USER on V_COM_QUERY_DATA_LINK.CREATE_USER_ID = COM_USER.DEPART_ID where (1=1)";
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
					countSql = "Select Count(*) From V_COM_QUERY_DATA_LINK Where (1=1)" + sCauseSql;
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer || IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.Db2? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_COM_QUERY_DATA_LINK",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_COM_QUERY_DATA_LINK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_DATA_LINK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DATA_INSTANCE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_INSTANCE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_DATA_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PARENT_INSTANCE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_DEPART_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_DATA_LINK[] objs = new DisplayObject_V_COM_QUERY_DATA_LINK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
