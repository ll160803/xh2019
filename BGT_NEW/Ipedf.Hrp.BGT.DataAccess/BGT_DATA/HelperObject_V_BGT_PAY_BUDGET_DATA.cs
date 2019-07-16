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
	[CauseObject(typeof(CauseObject_V_BGT_PAY_BUDGET_DATA))]
	public partial class HelperObject_V_BGT_PAY_BUDGET_DATA
	{		
		#region Method Blok
		public static int Save(EntityObject_V_BGT_PAY_BUDGET_DATA obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "insert into V_BGT_PAY_BUDGET_DATA( BUDGET_DATA_ID, ITEM_ID, DEPT_VALUE, DIFF_VALUE, BUDGET_YEAR, CPN_VALUE) values ( :BUDGET_DATA_ID, :ITEM_ID, :DEPT_VALUE, :DIFF_VALUE, :BUDGET_YEAR, :CPN_VALUE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[6];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":BUDGET_DATA_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.BUDGET_DATA_ID == null ? String.Empty:obj.BUDGET_DATA_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ITEM_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ITEM_ID == null ? String.Empty:obj.ITEM_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":DEPT_VALUE";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.DEPT_VALUE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":DIFF_VALUE";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.DIFF_VALUE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":BUDGET_YEAR";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":CPN_VALUE";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.CPN_VALUE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_BGT_PAY_BUDGET_DATA obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_BGT_PAY_BUDGET_DATA set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_BGT_PAY_BUDGET_DATA obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_BGT_PAY_BUDGET_DATA where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_BGT_PAY_BUDGET_DATA Get(EntityObject_V_BGT_PAY_BUDGET_DATA obj)
		{
			
			//平台自动生成代码
			string sSql = "select  BUDGET_DATA_ID, ITEM_ID, DEPT_VALUE, DIFF_VALUE, BUDGET_YEAR, CPN_VALUE from V_BGT_PAY_BUDGET_DATA where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_PAY_BUDGET_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_PAY_BUDGET_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DIFF_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CPN_VALUE = sqlReader.GetDecimal(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_BGT_PAY_BUDGET_DATA[] objs = new EntityObject_V_BGT_PAY_BUDGET_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_BGT_PAY_BUDGET_DATA Get(EntityObject_V_BGT_PAY_BUDGET_DATA obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  BUDGET_DATA_ID, ITEM_ID, DEPT_VALUE, DIFF_VALUE, BUDGET_YEAR, CPN_VALUE from V_BGT_PAY_BUDGET_DATA where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_PAY_BUDGET_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_PAY_BUDGET_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DIFF_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CPN_VALUE = sqlReader.GetDecimal(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_BGT_PAY_BUDGET_DATA[] objs = new EntityObject_V_BGT_PAY_BUDGET_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_BGT_PAY_BUDGET_DATA[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_BGT_PAY_BUDGET_DATA.BUDGET_DATA_ID, V_BGT_PAY_BUDGET_DATA.ITEM_ID, V_BGT_PAY_BUDGET_DATA.DEPT_VALUE, V_BGT_PAY_BUDGET_DATA.DIFF_VALUE, V_BGT_PAY_BUDGET_DATA.BUDGET_YEAR, V_BGT_PAY_BUDGET_DATA.CPN_VALUE, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PAY_BUDGET_DATA left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on V_BGT_PAY_BUDGET_DATA.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PAY_BUDGET_DATA.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_BGT_PAY_BUDGET_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PAY_BUDGET_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DIFF_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CPN_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_PAY_BUDGET_DATA[] objs = new DisplayObject_V_BGT_PAY_BUDGET_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_BGT_PAY_BUDGET_DATA cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.BUDGET_DATA_ID!= string.Empty)
			{
				strBuf.Append(" And V_BGT_PAY_BUDGET_DATA.BUDGET_DATA_ID ").Append((cause.BUDGET_DATA_ID.StartsWith("%") || cause.BUDGET_DATA_ID.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_DATA_ID");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_DATA_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_DATA_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_DATA_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PAY_BUDGET_DATA", "BUDGET_DATA_ID"));
			}
			if(cause.ITEM_ID!= string.Empty)
			{
				strBuf.Append(" And V_BGT_PAY_BUDGET_DATA.ITEM_ID ").Append((cause.ITEM_ID.StartsWith("%") || cause.ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PAY_BUDGET_DATA", "ITEM_ID"));
			}
			if(cause.DEPT_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PAY_BUDGET_DATA.DEPT_VALUE = :DEPT_VALUE");
				param = new OracleParameter();
				param.ParameterName =":DEPT_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DEPT_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PAY_BUDGET_DATA", "DEPT_VALUE"));
			}
			if(cause.DIFF_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PAY_BUDGET_DATA.DIFF_VALUE = :DIFF_VALUE");
				param = new OracleParameter();
				param.ParameterName =":DIFF_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DIFF_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DIFF_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PAY_BUDGET_DATA", "DIFF_VALUE"));
			}
			if(cause.BUDGET_YEAR!= string.Empty)
			{
				strBuf.Append(" And V_BGT_PAY_BUDGET_DATA.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PAY_BUDGET_DATA", "BUDGET_YEAR"));
			}
			if(cause.CPN_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PAY_BUDGET_DATA.CPN_VALUE = :CPN_VALUE");
				param = new OracleParameter();
				param.ParameterName =":CPN_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CPN_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CPN_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PAY_BUDGET_DATA", "CPN_VALUE"));
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
		public static DisplayObject_V_BGT_PAY_BUDGET_DATA[] Query(CauseObject_V_BGT_PAY_BUDGET_DATA cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_PAY_BUDGET_DATA.BUDGET_DATA_ID, V_BGT_PAY_BUDGET_DATA.ITEM_ID, V_BGT_PAY_BUDGET_DATA.DEPT_VALUE, V_BGT_PAY_BUDGET_DATA.DIFF_VALUE, V_BGT_PAY_BUDGET_DATA.BUDGET_YEAR, V_BGT_PAY_BUDGET_DATA.CPN_VALUE, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PAY_BUDGET_DATA left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on V_BGT_PAY_BUDGET_DATA.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PAY_BUDGET_DATA.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_PAY_BUDGET_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PAY_BUDGET_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DIFF_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CPN_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_PAY_BUDGET_DATA[] objs = new DisplayObject_V_BGT_PAY_BUDGET_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_BGT_PAY_BUDGET_DATA cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_BGT_PAY_BUDGET_DATA where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_BGT_PAY_BUDGET_DATA[] Query(CauseObject_V_BGT_PAY_BUDGET_DATA cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_PAY_BUDGET_DATA.BUDGET_DATA_ID, V_BGT_PAY_BUDGET_DATA.ITEM_ID, V_BGT_PAY_BUDGET_DATA.DEPT_VALUE, V_BGT_PAY_BUDGET_DATA.DIFF_VALUE, V_BGT_PAY_BUDGET_DATA.BUDGET_YEAR, V_BGT_PAY_BUDGET_DATA.CPN_VALUE, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PAY_BUDGET_DATA left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on V_BGT_PAY_BUDGET_DATA.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PAY_BUDGET_DATA.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_PAY_BUDGET_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PAY_BUDGET_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DIFF_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CPN_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_PAY_BUDGET_DATA[] objs = new DisplayObject_V_BGT_PAY_BUDGET_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_PAY_BUDGET_DATA[] Query(CauseObject_V_BGT_PAY_BUDGET_DATA cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_PAY_BUDGET_DATA.BUDGET_DATA_ID, V_BGT_PAY_BUDGET_DATA.ITEM_ID, V_BGT_PAY_BUDGET_DATA.DEPT_VALUE, V_BGT_PAY_BUDGET_DATA.DIFF_VALUE, V_BGT_PAY_BUDGET_DATA.BUDGET_YEAR, V_BGT_PAY_BUDGET_DATA.CPN_VALUE, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PAY_BUDGET_DATA left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on V_BGT_PAY_BUDGET_DATA.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PAY_BUDGET_DATA.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_PAY_BUDGET_DATA",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_BGT_PAY_BUDGET_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PAY_BUDGET_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DIFF_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CPN_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_PAY_BUDGET_DATA[] objs = new DisplayObject_V_BGT_PAY_BUDGET_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_PAY_BUDGET_DATA[] Query(CauseObject_V_BGT_PAY_BUDGET_DATA cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_PAY_BUDGET_DATA.BUDGET_DATA_ID, V_BGT_PAY_BUDGET_DATA.ITEM_ID, V_BGT_PAY_BUDGET_DATA.DEPT_VALUE, V_BGT_PAY_BUDGET_DATA.DIFF_VALUE, V_BGT_PAY_BUDGET_DATA.BUDGET_YEAR, V_BGT_PAY_BUDGET_DATA.CPN_VALUE, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PAY_BUDGET_DATA left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on V_BGT_PAY_BUDGET_DATA.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PAY_BUDGET_DATA.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_PAY_BUDGET_DATA",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_BGT_PAY_BUDGET_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PAY_BUDGET_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DIFF_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CPN_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_PAY_BUDGET_DATA[] objs = new DisplayObject_V_BGT_PAY_BUDGET_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_BGT_PAY_BUDGET_DATA obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("BUDGET_DATA_ID"))
			{
				strBuf.Add("  V_BGT_PAY_BUDGET_DATA.BUDGET_DATA_ID = :BUDGET_DATA_ID");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_DATA_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_DATA_ID) ? string.Empty : obj.BUDGET_DATA_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_ID"))
			{
				strBuf.Add("  V_BGT_PAY_BUDGET_DATA.ITEM_ID = :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_ID) ? string.Empty : obj.ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_VALUE"))
			{
				strBuf.Add("  V_BGT_PAY_BUDGET_DATA.DEPT_VALUE = :DEPT_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":DEPT_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DEPT_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DIFF_VALUE"))
			{
				strBuf.Add("  V_BGT_PAY_BUDGET_DATA.DIFF_VALUE = :DIFF_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":DIFF_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DIFF_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  V_BGT_PAY_BUDGET_DATA.BUDGET_YEAR = :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CPN_VALUE"))
			{
				strBuf.Add("  V_BGT_PAY_BUDGET_DATA.CPN_VALUE = :CPN_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":CPN_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CPN_VALUE;
				paramList.Add(param);
			}
			//pk here
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		#endregion 
	}
}
