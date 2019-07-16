﻿using System;
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
	[CauseObject(typeof(CauseObject_V_BGT_PLAN_BUDGET_DATA))]	
	public partial class HelperObject_V_BGT_PLAN_BUDGET_DATA
	{		
		#region Method Blok
		public static DisplayObject_V_BGT_PLAN_BUDGET_DATA[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_BGT_PLAN_BUDGET_DATA.UNIT_ID, V_BGT_PLAN_BUDGET_DATA.DEPT_VALUE, V_BGT_PLAN_BUDGET_DATA.BUDGET_DATA_ID, V_BGT_PLAN_BUDGET_DATA.ITEM_ID, V_BGT_PLAN_BUDGET_DATA.DIFF_VALUE, V_BGT_PLAN_BUDGET_DATA.BUDGET_YEAR, V_BGT_PLAN_BUDGET_DATA.CPN_VALUE, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PLAN_BUDGET_DATA left join COM_TYPE   COM_TYPE_UNIT_ID on V_BGT_PLAN_BUDGET_DATA.UNIT_ID = COM_TYPE_UNIT_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on V_BGT_PLAN_BUDGET_DATA.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PLAN_BUDGET_DATA.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_BGT_PLAN_BUDGET_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PLAN_BUDGET_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.UNIT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_VALUE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_DATA_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ITEM_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DIFF_VALUE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CPN_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_PLAN_BUDGET_DATA[] objs = new DisplayObject_V_BGT_PLAN_BUDGET_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_BGT_PLAN_BUDGET_DATA cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.UNIT_ID!= string.Empty)
			{
				strBuf.Append(" And V_BGT_PLAN_BUDGET_DATA.UNIT_ID ").Append((cause.UNIT_ID.StartsWith("%") || cause.UNIT_ID.EndsWith("%")) ? " like " : " = ").Append(" :UNIT_ID");
				param = new OracleParameter();
				param.ParameterName =":UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.UNIT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNIT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_BUDGET_DATA", "UNIT_ID"));
			}
			if(cause.DEPT_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_BUDGET_DATA.DEPT_VALUE = :DEPT_VALUE");
				param = new OracleParameter();
				param.ParameterName =":DEPT_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DEPT_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_BUDGET_DATA", "DEPT_VALUE"));
			}
			if(cause.BUDGET_DATA_ID!= string.Empty)
			{
				strBuf.Append(" And V_BGT_PLAN_BUDGET_DATA.BUDGET_DATA_ID ").Append((cause.BUDGET_DATA_ID.StartsWith("%") || cause.BUDGET_DATA_ID.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_DATA_ID");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_DATA_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_DATA_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_DATA_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_BUDGET_DATA", "BUDGET_DATA_ID"));
			}
			if(cause.ITEM_ID!= string.Empty)
			{
				strBuf.Append(" And V_BGT_PLAN_BUDGET_DATA.ITEM_ID ").Append((cause.ITEM_ID.StartsWith("%") || cause.ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_BUDGET_DATA", "ITEM_ID"));
			}
			if(cause.DIFF_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_BUDGET_DATA.DIFF_VALUE = :DIFF_VALUE");
				param = new OracleParameter();
				param.ParameterName =":DIFF_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DIFF_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DIFF_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_BUDGET_DATA", "DIFF_VALUE"));
			}
			if(cause.BUDGET_YEAR!= string.Empty)
			{
				strBuf.Append(" And V_BGT_PLAN_BUDGET_DATA.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_BUDGET_DATA", "BUDGET_YEAR"));
			}
			if(cause.CPN_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_BUDGET_DATA.CPN_VALUE = :CPN_VALUE");
				param = new OracleParameter();
				param.ParameterName =":CPN_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CPN_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CPN_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_BUDGET_DATA", "CPN_VALUE"));
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
		public static DisplayObject_V_BGT_PLAN_BUDGET_DATA[] Query(CauseObject_V_BGT_PLAN_BUDGET_DATA cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_PLAN_BUDGET_DATA.UNIT_ID, V_BGT_PLAN_BUDGET_DATA.DEPT_VALUE, V_BGT_PLAN_BUDGET_DATA.BUDGET_DATA_ID, V_BGT_PLAN_BUDGET_DATA.ITEM_ID, V_BGT_PLAN_BUDGET_DATA.DIFF_VALUE, V_BGT_PLAN_BUDGET_DATA.BUDGET_YEAR, V_BGT_PLAN_BUDGET_DATA.CPN_VALUE, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PLAN_BUDGET_DATA left join COM_TYPE   COM_TYPE_UNIT_ID on V_BGT_PLAN_BUDGET_DATA.UNIT_ID = COM_TYPE_UNIT_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on V_BGT_PLAN_BUDGET_DATA.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PLAN_BUDGET_DATA.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_PLAN_BUDGET_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PLAN_BUDGET_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.UNIT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_VALUE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_DATA_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ITEM_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DIFF_VALUE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CPN_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_PLAN_BUDGET_DATA[] objs = new DisplayObject_V_BGT_PLAN_BUDGET_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_PLAN_BUDGET_DATA[] Query(CauseObject_V_BGT_PLAN_BUDGET_DATA cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_PLAN_BUDGET_DATA.UNIT_ID, V_BGT_PLAN_BUDGET_DATA.DEPT_VALUE, V_BGT_PLAN_BUDGET_DATA.BUDGET_DATA_ID, V_BGT_PLAN_BUDGET_DATA.ITEM_ID, V_BGT_PLAN_BUDGET_DATA.DIFF_VALUE, V_BGT_PLAN_BUDGET_DATA.BUDGET_YEAR, V_BGT_PLAN_BUDGET_DATA.CPN_VALUE, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PLAN_BUDGET_DATA left join COM_TYPE   COM_TYPE_UNIT_ID on V_BGT_PLAN_BUDGET_DATA.UNIT_ID = COM_TYPE_UNIT_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on V_BGT_PLAN_BUDGET_DATA.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PLAN_BUDGET_DATA.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_PLAN_BUDGET_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PLAN_BUDGET_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.UNIT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_VALUE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_DATA_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ITEM_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DIFF_VALUE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CPN_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_PLAN_BUDGET_DATA[] objs = new DisplayObject_V_BGT_PLAN_BUDGET_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_PLAN_BUDGET_DATA[] Query(CauseObject_V_BGT_PLAN_BUDGET_DATA cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_PLAN_BUDGET_DATA.UNIT_ID, V_BGT_PLAN_BUDGET_DATA.DEPT_VALUE, V_BGT_PLAN_BUDGET_DATA.BUDGET_DATA_ID, V_BGT_PLAN_BUDGET_DATA.ITEM_ID, V_BGT_PLAN_BUDGET_DATA.DIFF_VALUE, V_BGT_PLAN_BUDGET_DATA.BUDGET_YEAR, V_BGT_PLAN_BUDGET_DATA.CPN_VALUE, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PLAN_BUDGET_DATA left join COM_TYPE   COM_TYPE_UNIT_ID on V_BGT_PLAN_BUDGET_DATA.UNIT_ID = COM_TYPE_UNIT_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on V_BGT_PLAN_BUDGET_DATA.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PLAN_BUDGET_DATA.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_PLAN_BUDGET_DATA",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_BGT_PLAN_BUDGET_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PLAN_BUDGET_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.UNIT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_VALUE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_DATA_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ITEM_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DIFF_VALUE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CPN_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_PLAN_BUDGET_DATA[] objs = new DisplayObject_V_BGT_PLAN_BUDGET_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_PLAN_BUDGET_DATA[] Query(CauseObject_V_BGT_PLAN_BUDGET_DATA cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_PLAN_BUDGET_DATA.UNIT_ID, V_BGT_PLAN_BUDGET_DATA.DEPT_VALUE, V_BGT_PLAN_BUDGET_DATA.BUDGET_DATA_ID, V_BGT_PLAN_BUDGET_DATA.ITEM_ID, V_BGT_PLAN_BUDGET_DATA.DIFF_VALUE, V_BGT_PLAN_BUDGET_DATA.BUDGET_YEAR, V_BGT_PLAN_BUDGET_DATA.CPN_VALUE, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PLAN_BUDGET_DATA left join COM_TYPE   COM_TYPE_UNIT_ID on V_BGT_PLAN_BUDGET_DATA.UNIT_ID = COM_TYPE_UNIT_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on V_BGT_PLAN_BUDGET_DATA.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PLAN_BUDGET_DATA.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_PLAN_BUDGET_DATA",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_BGT_PLAN_BUDGET_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PLAN_BUDGET_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.UNIT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_VALUE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_DATA_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ITEM_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DIFF_VALUE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CPN_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_PLAN_BUDGET_DATA[] objs = new DisplayObject_V_BGT_PLAN_BUDGET_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
