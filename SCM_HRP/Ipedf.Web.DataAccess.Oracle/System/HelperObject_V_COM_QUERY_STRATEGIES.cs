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
	[CauseObject(typeof(CauseObject_V_COM_QUERY_STRATEGIES))]
	public partial class HelperObject_V_COM_QUERY_STRATEGIES
	{		
		#region Method Blok
		public static int Save(EntityObject_V_COM_QUERY_STRATEGIES obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "insert into V_COM_QUERY_STRATEGIES( DATA_LIMIT, STRATEGY_TYPE, USER_ID, DATAOBJECT, STRATEGY_CUSTOMCONDITION) values ( :DATA_LIMIT, :STRATEGY_TYPE, :USER_ID, :DATAOBJECT, :STRATEGY_CUSTOMCONDITION)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[5];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":DATA_LIMIT";
			parameters[0].Size = 200;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.DATA_LIMIT == null ? String.Empty:obj.DATA_LIMIT;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":STRATEGY_TYPE";
			parameters[1].Size = 200;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.STRATEGY_TYPE == null ? String.Empty:obj.STRATEGY_TYPE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":USER_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":DATAOBJECT";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.DATAOBJECT == null ? String.Empty:obj.DATAOBJECT;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":STRATEGY_CUSTOMCONDITION";
			parameters[4].Size = 200;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.STRATEGY_CUSTOMCONDITION == null ? String.Empty:obj.STRATEGY_CUSTOMCONDITION;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_COM_QUERY_STRATEGIES obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_COM_QUERY_STRATEGIES set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_COM_QUERY_STRATEGIES obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_COM_QUERY_STRATEGIES where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_COM_QUERY_STRATEGIES Get(EntityObject_V_COM_QUERY_STRATEGIES obj)
		{
			
			//平台自动生成代码
			string sSql = "select  DATA_LIMIT, STRATEGY_TYPE, USER_ID, DATAOBJECT, STRATEGY_CUSTOMCONDITION from V_COM_QUERY_STRATEGIES where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_COM_QUERY_STRATEGIES dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_COM_QUERY_STRATEGIES();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATAOBJECT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_COM_QUERY_STRATEGIES[] objs = new EntityObject_V_COM_QUERY_STRATEGIES[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_COM_QUERY_STRATEGIES Get(EntityObject_V_COM_QUERY_STRATEGIES obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  DATA_LIMIT, STRATEGY_TYPE, USER_ID, DATAOBJECT, STRATEGY_CUSTOMCONDITION from V_COM_QUERY_STRATEGIES where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_COM_QUERY_STRATEGIES dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_COM_QUERY_STRATEGIES();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATAOBJECT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_COM_QUERY_STRATEGIES[] objs = new EntityObject_V_COM_QUERY_STRATEGIES[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_COM_QUERY_STRATEGIES[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_COM_QUERY_STRATEGIES.DATA_LIMIT, V_COM_QUERY_STRATEGIES.STRATEGY_TYPE, V_COM_QUERY_STRATEGIES.USER_ID, V_COM_QUERY_STRATEGIES.DATAOBJECT, V_COM_QUERY_STRATEGIES.STRATEGY_CUSTOMCONDITION from V_COM_QUERY_STRATEGIES where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_COM_QUERY_STRATEGIES dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_STRATEGIES();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATAOBJECT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_STRATEGIES[] objs = new DisplayObject_V_COM_QUERY_STRATEGIES[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_COM_QUERY_STRATEGIES cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.DATA_LIMIT!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_STRATEGIES.DATA_LIMIT ").Append((cause.DATA_LIMIT.StartsWith("%") || cause.DATA_LIMIT.EndsWith("%")) ? " like " : " = ").Append(" :DATA_LIMIT");
				param = new OracleParameter();
				param.ParameterName =":DATA_LIMIT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.DATA_LIMIT;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_LIMIT"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_STRATEGIES", "DATA_LIMIT"));
			}
			if(cause.STRATEGY_TYPE!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_STRATEGIES.STRATEGY_TYPE ").Append((cause.STRATEGY_TYPE.StartsWith("%") || cause.STRATEGY_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :STRATEGY_TYPE");
				param = new OracleParameter();
				param.ParameterName =":STRATEGY_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.STRATEGY_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STRATEGY_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_STRATEGIES", "STRATEGY_TYPE"));
			}
			if(cause.USER_ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_STRATEGIES.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :USER_ID");
				param = new OracleParameter();
				param.ParameterName =":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_STRATEGIES", "USER_ID"));
			}
			if(cause.DATAOBJECT!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_STRATEGIES.DATAOBJECT ").Append((cause.DATAOBJECT.StartsWith("%") || cause.DATAOBJECT.EndsWith("%")) ? " like " : " = ").Append(" :DATAOBJECT");
				param = new OracleParameter();
				param.ParameterName =":DATAOBJECT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DATAOBJECT;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATAOBJECT"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_STRATEGIES", "DATAOBJECT"));
			}
			if(cause.STRATEGY_CUSTOMCONDITION!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_STRATEGIES.STRATEGY_CUSTOMCONDITION ").Append((cause.STRATEGY_CUSTOMCONDITION.StartsWith("%") || cause.STRATEGY_CUSTOMCONDITION.EndsWith("%")) ? " like " : " = ").Append(" :STRATEGY_CUSTOMCONDITION");
				param = new OracleParameter();
				param.ParameterName =":STRATEGY_CUSTOMCONDITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.STRATEGY_CUSTOMCONDITION;
				paramList.Add(param);
			}
			if (cause.HasINValue("STRATEGY_CUSTOMCONDITION"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_STRATEGIES", "STRATEGY_CUSTOMCONDITION"));
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
		public static DisplayObject_V_COM_QUERY_STRATEGIES[] Query(CauseObject_V_COM_QUERY_STRATEGIES cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_STRATEGIES.DATA_LIMIT, V_COM_QUERY_STRATEGIES.STRATEGY_TYPE, V_COM_QUERY_STRATEGIES.USER_ID, V_COM_QUERY_STRATEGIES.DATAOBJECT, V_COM_QUERY_STRATEGIES.STRATEGY_CUSTOMCONDITION from V_COM_QUERY_STRATEGIES where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_COM_QUERY_STRATEGIES dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_STRATEGIES();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATAOBJECT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_STRATEGIES[] objs = new DisplayObject_V_COM_QUERY_STRATEGIES[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_COM_QUERY_STRATEGIES cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_COM_QUERY_STRATEGIES where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_COM_QUERY_STRATEGIES[] Query(CauseObject_V_COM_QUERY_STRATEGIES cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_STRATEGIES.DATA_LIMIT, V_COM_QUERY_STRATEGIES.STRATEGY_TYPE, V_COM_QUERY_STRATEGIES.USER_ID, V_COM_QUERY_STRATEGIES.DATAOBJECT, V_COM_QUERY_STRATEGIES.STRATEGY_CUSTOMCONDITION from V_COM_QUERY_STRATEGIES where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_COM_QUERY_STRATEGIES dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_STRATEGIES();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATAOBJECT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_STRATEGIES[] objs = new DisplayObject_V_COM_QUERY_STRATEGIES[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_STRATEGIES[] Query(CauseObject_V_COM_QUERY_STRATEGIES cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_STRATEGIES.DATA_LIMIT, V_COM_QUERY_STRATEGIES.STRATEGY_TYPE, V_COM_QUERY_STRATEGIES.USER_ID, V_COM_QUERY_STRATEGIES.DATAOBJECT, V_COM_QUERY_STRATEGIES.STRATEGY_CUSTOMCONDITION from V_COM_QUERY_STRATEGIES where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_COM_QUERY_STRATEGIES",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_COM_QUERY_STRATEGIES dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_STRATEGIES();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATAOBJECT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_STRATEGIES[] objs = new DisplayObject_V_COM_QUERY_STRATEGIES[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_STRATEGIES[] Query(CauseObject_V_COM_QUERY_STRATEGIES cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_STRATEGIES.DATA_LIMIT, V_COM_QUERY_STRATEGIES.STRATEGY_TYPE, V_COM_QUERY_STRATEGIES.USER_ID, V_COM_QUERY_STRATEGIES.DATAOBJECT, V_COM_QUERY_STRATEGIES.STRATEGY_CUSTOMCONDITION from V_COM_QUERY_STRATEGIES where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_COM_QUERY_STRATEGIES",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_COM_QUERY_STRATEGIES dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_STRATEGIES();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATAOBJECT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_STRATEGIES[] objs = new DisplayObject_V_COM_QUERY_STRATEGIES[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_COM_QUERY_STRATEGIES obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("DATA_LIMIT"))
			{
				strBuf.Add("  V_COM_QUERY_STRATEGIES.DATA_LIMIT = :DATA_LIMIT");
				param = new OracleParameter();
				param.ParameterName = ":DATA_LIMIT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.DATA_LIMIT) ? string.Empty : obj.DATA_LIMIT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STRATEGY_TYPE"))
			{
				strBuf.Add("  V_COM_QUERY_STRATEGIES.STRATEGY_TYPE = :STRATEGY_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":STRATEGY_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.STRATEGY_TYPE) ? string.Empty : obj.STRATEGY_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  V_COM_QUERY_STRATEGIES.USER_ID = :USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATAOBJECT"))
			{
				strBuf.Add("  V_COM_QUERY_STRATEGIES.DATAOBJECT = :DATAOBJECT");
				param = new OracleParameter();
				param.ParameterName = ":DATAOBJECT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.DATAOBJECT) ? string.Empty : obj.DATAOBJECT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STRATEGY_CUSTOMCONDITION"))
			{
				strBuf.Add("  V_COM_QUERY_STRATEGIES.STRATEGY_CUSTOMCONDITION = :STRATEGY_CUSTOMCONDITION");
				param = new OracleParameter();
				param.ParameterName = ":STRATEGY_CUSTOMCONDITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.STRATEGY_CUSTOMCONDITION) ? string.Empty : obj.STRATEGY_CUSTOMCONDITION;
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
