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
	[CauseObject(typeof(CauseObject_V_GETPERSON))]
	public partial class HelperObject_V_GETPERSON
	{		
		#region Method Blok
		public static int Save(EntityObject_V_GETPERSON obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_GETPERSON( ACCOUNT, PASSWORD, ROLEID, ROLENAME, ID, NAME, DEPARTMENTID) values ( :ACCOUNT, :PASSWORD, :ROLEID, :ROLENAME, :ID, :NAME, :DEPARTMENTID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[7];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ACCOUNT";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.ACCOUNT == null ? String.Empty:obj.ACCOUNT;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":PASSWORD";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.PASSWORD == null ? String.Empty:obj.PASSWORD;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ROLEID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ROLEID == null ? String.Empty:obj.ROLEID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ROLENAME";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.ROLENAME == null ? String.Empty:obj.ROLENAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":NAME";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":DEPARTMENTID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.DEPARTMENTID == null ? String.Empty:obj.DEPARTMENTID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_GETPERSON obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_GETPERSON set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_GETPERSON obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_GETPERSON where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_GETPERSON Get(EntityObject_V_GETPERSON obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ACCOUNT, PASSWORD, ROLEID, ROLENAME, ID, NAME, DEPARTMENTID from V_GETPERSON where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_GETPERSON dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_GETPERSON();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PASSWORD = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ROLEID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ROLENAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPARTMENTID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_GETPERSON[] objs = new EntityObject_V_GETPERSON[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_GETPERSON Get(EntityObject_V_GETPERSON obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ACCOUNT, PASSWORD, ROLEID, ROLENAME, ID, NAME, DEPARTMENTID from V_GETPERSON where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_GETPERSON dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_GETPERSON();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PASSWORD = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ROLEID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ROLENAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPARTMENTID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_GETPERSON[] objs = new EntityObject_V_GETPERSON[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_GETPERSON[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_GETPERSON.ACCOUNT, V_GETPERSON.PASSWORD, V_GETPERSON.ROLEID, V_GETPERSON.ROLENAME, V_GETPERSON.ID, V_GETPERSON.NAME, V_GETPERSON.DEPARTMENTID from V_GETPERSON where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_GETPERSON dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_GETPERSON();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PASSWORD = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ROLEID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ROLENAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPARTMENTID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_GETPERSON[] objs = new DisplayObject_V_GETPERSON[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_GETPERSON cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ACCOUNT))
			{
				strBuf.Append(" And V_GETPERSON.ACCOUNT ").Append((cause.ACCOUNT.StartsWith("%") || cause.ACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :ACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_GETPERSON", "ACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.PASSWORD))
			{
				strBuf.Append(" And V_GETPERSON.PASSWORD ").Append((cause.PASSWORD.StartsWith("%") || cause.PASSWORD.EndsWith("%")) ? " like " : " = ").Append(" :PASSWORD");
				param = new OracleParameter();
				param.ParameterName =":PASSWORD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PASSWORD;
				paramList.Add(param);
			}
			if (cause.HasINValue("PASSWORD"))
			{
				strBuf.Append(cause.GetINSQL("V_GETPERSON", "PASSWORD"));
			}
			if(!string.IsNullOrEmpty(cause.ROLEID))
			{
				strBuf.Append(" And V_GETPERSON.ROLEID ").Append((cause.ROLEID.StartsWith("%") || cause.ROLEID.EndsWith("%")) ? " like " : " = ").Append(" :ROLEID");
				param = new OracleParameter();
				param.ParameterName =":ROLEID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ROLEID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ROLEID"))
			{
				strBuf.Append(cause.GetINSQL("V_GETPERSON", "ROLEID"));
			}
			if(!string.IsNullOrEmpty(cause.ROLENAME))
			{
				strBuf.Append(" And V_GETPERSON.ROLENAME ").Append((cause.ROLENAME.StartsWith("%") || cause.ROLENAME.EndsWith("%")) ? " like " : " = ").Append(" :ROLENAME");
				param = new OracleParameter();
				param.ParameterName =":ROLENAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ROLENAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ROLENAME"))
			{
				strBuf.Append(cause.GetINSQL("V_GETPERSON", "ROLENAME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_GETPERSON.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_GETPERSON", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_GETPERSON.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_GETPERSON", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.DEPARTMENTID))
			{
				strBuf.Append(" And V_GETPERSON.DEPARTMENTID ").Append((cause.DEPARTMENTID.StartsWith("%") || cause.DEPARTMENTID.EndsWith("%")) ? " like " : " = ").Append(" :DEPARTMENTID");
				param = new OracleParameter();
				param.ParameterName =":DEPARTMENTID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPARTMENTID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPARTMENTID"))
			{
				strBuf.Append(cause.GetINSQL("V_GETPERSON", "DEPARTMENTID"));
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
		public static DisplayObject_V_GETPERSON[] Query(CauseObject_V_GETPERSON cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_GETPERSON.ACCOUNT, V_GETPERSON.PASSWORD, V_GETPERSON.ROLEID, V_GETPERSON.ROLENAME, V_GETPERSON.ID, V_GETPERSON.NAME, V_GETPERSON.DEPARTMENTID from V_GETPERSON where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_GETPERSON dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_GETPERSON();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PASSWORD = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ROLEID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ROLENAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPARTMENTID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_GETPERSON[] objs = new DisplayObject_V_GETPERSON[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_GETPERSON cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_GETPERSON where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_GETPERSON[] Query(CauseObject_V_GETPERSON cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_GETPERSON.ACCOUNT, V_GETPERSON.PASSWORD, V_GETPERSON.ROLEID, V_GETPERSON.ROLENAME, V_GETPERSON.ID, V_GETPERSON.NAME, V_GETPERSON.DEPARTMENTID from V_GETPERSON where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_GETPERSON dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_GETPERSON();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PASSWORD = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ROLEID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ROLENAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPARTMENTID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_GETPERSON[] objs = new DisplayObject_V_GETPERSON[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_GETPERSON[] Query(CauseObject_V_GETPERSON cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_GETPERSON.ACCOUNT, V_GETPERSON.PASSWORD, V_GETPERSON.ROLEID, V_GETPERSON.ROLENAME, V_GETPERSON.ID, V_GETPERSON.NAME, V_GETPERSON.DEPARTMENTID from V_GETPERSON where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_GETPERSON",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_GETPERSON dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_GETPERSON();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PASSWORD = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ROLEID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ROLENAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPARTMENTID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_GETPERSON[] objs = new DisplayObject_V_GETPERSON[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_GETPERSON[] Query(CauseObject_V_GETPERSON cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_GETPERSON.ACCOUNT, V_GETPERSON.PASSWORD, V_GETPERSON.ROLEID, V_GETPERSON.ROLENAME, V_GETPERSON.ID, V_GETPERSON.NAME, V_GETPERSON.DEPARTMENTID from V_GETPERSON where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_GETPERSON",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_GETPERSON dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_GETPERSON();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PASSWORD = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ROLEID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ROLENAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DEPARTMENTID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_GETPERSON[] objs = new DisplayObject_V_GETPERSON[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_GETPERSON obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ACCOUNT"))
			{
				strBuf.Add("  V_GETPERSON.ACCOUNT = :ACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ACCOUNT) ? string.Empty : obj.ACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PASSWORD"))
			{
				strBuf.Add("  V_GETPERSON.PASSWORD = :PASSWORD");
				param = new OracleParameter();
				param.ParameterName = ":PASSWORD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PASSWORD) ? string.Empty : obj.PASSWORD;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ROLEID"))
			{
				strBuf.Add("  V_GETPERSON.ROLEID = :ROLEID");
				param = new OracleParameter();
				param.ParameterName = ":ROLEID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ROLEID) ? string.Empty : obj.ROLEID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ROLENAME"))
			{
				strBuf.Add("  V_GETPERSON.ROLENAME = :ROLENAME");
				param = new OracleParameter();
				param.ParameterName = ":ROLENAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ROLENAME) ? string.Empty : obj.ROLENAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_GETPERSON.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_GETPERSON.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPARTMENTID"))
			{
				strBuf.Add("  V_GETPERSON.DEPARTMENTID = :DEPARTMENTID");
				param = new OracleParameter();
				param.ParameterName = ":DEPARTMENTID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPARTMENTID) ? string.Empty : obj.DEPARTMENTID;
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
