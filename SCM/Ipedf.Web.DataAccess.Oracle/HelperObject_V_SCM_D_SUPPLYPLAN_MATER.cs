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
	[CauseObject(typeof(CauseObject_V_SCM_D_SUPPLYPLAN_MATER))]
	public partial class HelperObject_V_SCM_D_SUPPLYPLAN_MATER
	{		
		#region Method Blok
		public static int Save(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_SCM_D_SUPPLYPLAN_MATER( MATER_ID, ID, CHARG) values ( :MATER_ID, :ID, :CHARG)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[3];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":MATER_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.MATER_ID == null ? String.Empty:obj.MATER_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CHARG";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.CHARG == null ? String.Empty:obj.CHARG;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_SCM_D_SUPPLYPLAN_MATER set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_SCM_D_SUPPLYPLAN_MATER where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_SCM_D_SUPPLYPLAN_MATER Get(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj)
		{
			
			//平台自动生成代码
			string sSql = "select  MATER_ID, ID, CHARG from V_SCM_D_SUPPLYPLAN_MATER where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_D_SUPPLYPLAN_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_D_SUPPLYPLAN_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MATER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CHARG = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_SCM_D_SUPPLYPLAN_MATER[] objs = new EntityObject_V_SCM_D_SUPPLYPLAN_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_SCM_D_SUPPLYPLAN_MATER Get(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  MATER_ID, ID, CHARG from V_SCM_D_SUPPLYPLAN_MATER where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_D_SUPPLYPLAN_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_D_SUPPLYPLAN_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MATER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CHARG = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_SCM_D_SUPPLYPLAN_MATER[] objs = new EntityObject_V_SCM_D_SUPPLYPLAN_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_SCM_D_SUPPLYPLAN_MATER.MATER_ID, V_SCM_D_SUPPLYPLAN_MATER.ID, V_SCM_D_SUPPLYPLAN_MATER.CHARG from V_SCM_D_SUPPLYPLAN_MATER where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_SCM_D_SUPPLYPLAN_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SUPPLYPLAN_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MATER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CHARG = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[] objs = new DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_SCM_D_SUPPLYPLAN_MATER cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.MATER_ID))
			{
				strBuf.Append(" And V_SCM_D_SUPPLYPLAN_MATER.MATER_ID ").Append((cause.MATER_ID.StartsWith("%") || cause.MATER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MATER_ID");
				param = new OracleParameter();
				param.ParameterName =":MATER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MATER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLYPLAN_MATER", "MATER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_SCM_D_SUPPLYPLAN_MATER.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLYPLAN_MATER", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.CHARG))
			{
				strBuf.Append(" And V_SCM_D_SUPPLYPLAN_MATER.CHARG ").Append((cause.CHARG.StartsWith("%") || cause.CHARG.EndsWith("%")) ? " like " : " = ").Append(" :CHARG");
				param = new OracleParameter();
				param.ParameterName =":CHARG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CHARG;
				paramList.Add(param);
			}
			if (cause.HasINValue("CHARG"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLYPLAN_MATER", "CHARG"));
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
		public static DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[] Query(CauseObject_V_SCM_D_SUPPLYPLAN_MATER cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_D_SUPPLYPLAN_MATER.MATER_ID, V_SCM_D_SUPPLYPLAN_MATER.ID, V_SCM_D_SUPPLYPLAN_MATER.CHARG from V_SCM_D_SUPPLYPLAN_MATER where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_D_SUPPLYPLAN_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SUPPLYPLAN_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MATER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CHARG = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[] objs = new DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_SCM_D_SUPPLYPLAN_MATER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_SCM_D_SUPPLYPLAN_MATER where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[] Query(CauseObject_V_SCM_D_SUPPLYPLAN_MATER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_D_SUPPLYPLAN_MATER.MATER_ID, V_SCM_D_SUPPLYPLAN_MATER.ID, V_SCM_D_SUPPLYPLAN_MATER.CHARG from V_SCM_D_SUPPLYPLAN_MATER where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_D_SUPPLYPLAN_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SUPPLYPLAN_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MATER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CHARG = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[] objs = new DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[] Query(CauseObject_V_SCM_D_SUPPLYPLAN_MATER cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_D_SUPPLYPLAN_MATER.MATER_ID, V_SCM_D_SUPPLYPLAN_MATER.ID, V_SCM_D_SUPPLYPLAN_MATER.CHARG from V_SCM_D_SUPPLYPLAN_MATER where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_D_SUPPLYPLAN_MATER",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_SCM_D_SUPPLYPLAN_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SUPPLYPLAN_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MATER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CHARG = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[] objs = new DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[] Query(CauseObject_V_SCM_D_SUPPLYPLAN_MATER cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_D_SUPPLYPLAN_MATER.MATER_ID, V_SCM_D_SUPPLYPLAN_MATER.ID, V_SCM_D_SUPPLYPLAN_MATER.CHARG from V_SCM_D_SUPPLYPLAN_MATER where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_D_SUPPLYPLAN_MATER",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_SCM_D_SUPPLYPLAN_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SUPPLYPLAN_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MATER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CHARG = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[] objs = new DisplayObject_V_SCM_D_SUPPLYPLAN_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_SCM_D_SUPPLYPLAN_MATER obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("MATER_ID"))
			{
				strBuf.Add("  V_SCM_D_SUPPLYPLAN_MATER.MATER_ID = :MATER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MATER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MATER_ID) ? string.Empty : obj.MATER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_SCM_D_SUPPLYPLAN_MATER.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CHARG"))
			{
				strBuf.Add("  V_SCM_D_SUPPLYPLAN_MATER.CHARG = :CHARG");
				param = new OracleParameter();
				param.ParameterName = ":CHARG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CHARG) ? string.Empty : obj.CHARG;
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
