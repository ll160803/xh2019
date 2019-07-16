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
	[CauseObject(typeof(CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS))]	
	public partial class HelperObject_V_BGT_DEPT_BUDGET_DATA_PROCESS
	{		
		#region Method Blok
		public static DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_BGT_DEPT_BUDGET_DATA_PROCESS.DEPT_NAME, V_BGT_DEPT_BUDGET_DATA_PROCESS.STATUS, V_BGT_DEPT_BUDGET_DATA_PROCESS.DEPT_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.BUDGET_YEAR, V_BGT_DEPT_BUDGET_DATA_PROCESS.TEMPLET_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.BUDGET_CONTENTS_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.CREATE_DATE from V_BGT_DEPT_BUDGET_DATA_PROCESS where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DEPT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STATUS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TEMPLET_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BUDGET_CONTENTS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] objs = new DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.DEPT_NAME))
			{
				strBuf.Append(" And V_BGT_DEPT_BUDGET_DATA_PROCESS.DEPT_NAME ").Append((cause.DEPT_NAME.StartsWith("%") || cause.DEPT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPT_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_DEPT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DEPT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_DEPT_BUDGET_DATA_PROCESS", "DEPT_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.STATUS))
			{
				strBuf.Append(" And V_BGT_DEPT_BUDGET_DATA_PROCESS.STATUS ").Append((cause.STATUS.StartsWith("%") || cause.STATUS.EndsWith("%")) ? " like " : " = ").Append(" :C_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_DEPT_BUDGET_DATA_PROCESS", "STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_ID))
			{
				strBuf.Append(" And V_BGT_DEPT_BUDGET_DATA_PROCESS.DEPT_ID ").Append((cause.DEPT_ID.StartsWith("%") || cause.DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_DEPT_BUDGET_DATA_PROCESS", "DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR))
			{
				strBuf.Append(" And V_BGT_DEPT_BUDGET_DATA_PROCESS.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :C_BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":C_BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_DEPT_BUDGET_DATA_PROCESS", "BUDGET_YEAR"));
			}
			if(!string.IsNullOrEmpty(cause.TEMPLET_ID))
			{
				strBuf.Append(" And V_BGT_DEPT_BUDGET_DATA_PROCESS.TEMPLET_ID ").Append((cause.TEMPLET_ID.StartsWith("%") || cause.TEMPLET_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_TEMPLET_ID");
				param = new OracleParameter();
				param.ParameterName =":C_TEMPLET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.TEMPLET_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TEMPLET_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_DEPT_BUDGET_DATA_PROCESS", "TEMPLET_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_CONTENTS_ID))
			{
				strBuf.Append(" And V_BGT_DEPT_BUDGET_DATA_PROCESS.BUDGET_CONTENTS_ID ").Append((cause.BUDGET_CONTENTS_ID.StartsWith("%") || cause.BUDGET_CONTENTS_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BUDGET_CONTENTS_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BUDGET_CONTENTS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_CONTENTS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_CONTENTS_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_DEPT_BUDGET_DATA_PROCESS", "BUDGET_CONTENTS_ID"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And V_BGT_DEPT_BUDGET_DATA_PROCESS.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And V_BGT_DEPT_BUDGET_DATA_PROCESS.CREATE_DATE < :C_CREATE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_DEPT_BUDGET_DATA_PROCESS", "CREATE_DATE"));
			}
			if (!string.IsNullOrEmpty(cause.GetCustomCondition())) 
			{ 
				strBuf.Append(cause.GetCustomCondition()); 
			} 
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return strBuf.ToString();


		}		
		public static DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] Query(CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_DEPT_BUDGET_DATA_PROCESS.DEPT_NAME, V_BGT_DEPT_BUDGET_DATA_PROCESS.STATUS, V_BGT_DEPT_BUDGET_DATA_PROCESS.DEPT_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.BUDGET_YEAR, V_BGT_DEPT_BUDGET_DATA_PROCESS.TEMPLET_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.BUDGET_CONTENTS_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.CREATE_DATE from V_BGT_DEPT_BUDGET_DATA_PROCESS where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DEPT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STATUS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TEMPLET_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BUDGET_CONTENTS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] objs = new DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] Query(CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_DEPT_BUDGET_DATA_PROCESS.DEPT_NAME, V_BGT_DEPT_BUDGET_DATA_PROCESS.STATUS, V_BGT_DEPT_BUDGET_DATA_PROCESS.DEPT_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.BUDGET_YEAR, V_BGT_DEPT_BUDGET_DATA_PROCESS.TEMPLET_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.BUDGET_CONTENTS_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.CREATE_DATE from V_BGT_DEPT_BUDGET_DATA_PROCESS where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DEPT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STATUS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TEMPLET_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BUDGET_CONTENTS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] objs = new DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] Query(CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_DEPT_BUDGET_DATA_PROCESS.DEPT_NAME, V_BGT_DEPT_BUDGET_DATA_PROCESS.STATUS, V_BGT_DEPT_BUDGET_DATA_PROCESS.DEPT_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.BUDGET_YEAR, V_BGT_DEPT_BUDGET_DATA_PROCESS.TEMPLET_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.BUDGET_CONTENTS_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.CREATE_DATE from V_BGT_DEPT_BUDGET_DATA_PROCESS where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_DEPT_BUDGET_DATA_PROCESS",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DEPT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STATUS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TEMPLET_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BUDGET_CONTENTS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] objs = new DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] Query(CauseObject_V_BGT_DEPT_BUDGET_DATA_PROCESS cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_DEPT_BUDGET_DATA_PROCESS.DEPT_NAME, V_BGT_DEPT_BUDGET_DATA_PROCESS.STATUS, V_BGT_DEPT_BUDGET_DATA_PROCESS.DEPT_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.BUDGET_YEAR, V_BGT_DEPT_BUDGET_DATA_PROCESS.TEMPLET_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.BUDGET_CONTENTS_ID, V_BGT_DEPT_BUDGET_DATA_PROCESS.CREATE_DATE from V_BGT_DEPT_BUDGET_DATA_PROCESS where (1=1)";
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
					countSql = "Select Count(*) From (" + sSql + ") t";
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer || IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.Db2? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_DEPT_BUDGET_DATA_PROCESS",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DEPT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STATUS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TEMPLET_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BUDGET_CONTENTS_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[] objs = new DisplayObject_V_BGT_DEPT_BUDGET_DATA_PROCESS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
