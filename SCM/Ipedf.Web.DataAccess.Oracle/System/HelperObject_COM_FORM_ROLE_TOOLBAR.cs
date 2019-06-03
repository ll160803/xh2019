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
	[CauseObject(typeof(CauseObject_COM_FORM_ROLE_TOOLBAR))]
	public partial class HelperObject_COM_FORM_ROLE_TOOLBAR
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_FORM_ROLE_TOOLBAR obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_FORM_ROLE_TOOLBAR( ROLE_ID, ID, TOOLBAR_ID, FORM_ID) values ( :ROLE_ID, :ID, :TOOLBAR_ID, :FORM_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[4];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ROLE_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ROLE_ID == null ? String.Empty:obj.ROLE_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":TOOLBAR_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.TOOLBAR_ID == null ? String.Empty:obj.TOOLBAR_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":FORM_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.FORM_ID == null ? String.Empty:obj.FORM_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_FORM_ROLE_TOOLBAR obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_FORM_ROLE_TOOLBAR set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_FORM_ROLE_TOOLBAR obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_FORM_ROLE_TOOLBAR where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_COM_FORM_ROLE_TOOLBAR Get(EntityObject_COM_FORM_ROLE_TOOLBAR obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ROLE_ID, ID, TOOLBAR_ID, FORM_ID from COM_FORM_ROLE_TOOLBAR where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_FORM_ROLE_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_FORM_ROLE_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ROLE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TOOLBAR_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FORM_ID = sqlReader.GetString(3);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_FORM_ROLE_TOOLBAR[] objs = new EntityObject_COM_FORM_ROLE_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_FORM_ROLE_TOOLBAR Get(EntityObject_COM_FORM_ROLE_TOOLBAR obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ROLE_ID, ID, TOOLBAR_ID, FORM_ID from COM_FORM_ROLE_TOOLBAR where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_FORM_ROLE_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_FORM_ROLE_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ROLE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TOOLBAR_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FORM_ID = sqlReader.GetString(3);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_FORM_ROLE_TOOLBAR[] objs = new EntityObject_COM_FORM_ROLE_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_FORM_ROLE_TOOLBAR[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_FORM_ROLE_TOOLBAR.ROLE_ID, COM_FORM_ROLE_TOOLBAR.ID, COM_FORM_ROLE_TOOLBAR.TOOLBAR_ID, COM_FORM_ROLE_TOOLBAR.FORM_ID from COM_FORM_ROLE_TOOLBAR where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_FORM_ROLE_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FORM_ROLE_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ROLE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TOOLBAR_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FORM_ID = sqlReader.GetString(3);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_FORM_ROLE_TOOLBAR[] objs = new DisplayObject_COM_FORM_ROLE_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_FORM_ROLE_TOOLBAR cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ROLE_ID))
			{
				strBuf.Append(" And COM_FORM_ROLE_TOOLBAR.ROLE_ID ").Append((cause.ROLE_ID.StartsWith("%") || cause.ROLE_ID.EndsWith("%")) ? " like " : " = ").Append(" :ROLE_ID");
				param = new OracleParameter();
				param.ParameterName =":ROLE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ROLE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ROLE_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_FORM_ROLE_TOOLBAR", "ROLE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And COM_FORM_ROLE_TOOLBAR.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_FORM_ROLE_TOOLBAR", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.TOOLBAR_ID))
			{
				strBuf.Append(" And COM_FORM_ROLE_TOOLBAR.TOOLBAR_ID ").Append((cause.TOOLBAR_ID.StartsWith("%") || cause.TOOLBAR_ID.EndsWith("%")) ? " like " : " = ").Append(" :TOOLBAR_ID");
				param = new OracleParameter();
				param.ParameterName =":TOOLBAR_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.TOOLBAR_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TOOLBAR_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_FORM_ROLE_TOOLBAR", "TOOLBAR_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FORM_ID))
			{
				strBuf.Append(" And COM_FORM_ROLE_TOOLBAR.FORM_ID ").Append((cause.FORM_ID.StartsWith("%") || cause.FORM_ID.EndsWith("%")) ? " like " : " = ").Append(" :FORM_ID");
				param = new OracleParameter();
				param.ParameterName =":FORM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.FORM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("FORM_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_FORM_ROLE_TOOLBAR", "FORM_ID"));
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
		public static DisplayObject_COM_FORM_ROLE_TOOLBAR[] Query(CauseObject_COM_FORM_ROLE_TOOLBAR cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_FORM_ROLE_TOOLBAR.ROLE_ID, COM_FORM_ROLE_TOOLBAR.ID, COM_FORM_ROLE_TOOLBAR.TOOLBAR_ID, COM_FORM_ROLE_TOOLBAR.FORM_ID from COM_FORM_ROLE_TOOLBAR where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_FORM_ROLE_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FORM_ROLE_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ROLE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TOOLBAR_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FORM_ID = sqlReader.GetString(3);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_FORM_ROLE_TOOLBAR[] objs = new DisplayObject_COM_FORM_ROLE_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_FORM_ROLE_TOOLBAR cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_FORM_ROLE_TOOLBAR where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_FORM_ROLE_TOOLBAR[] Query(CauseObject_COM_FORM_ROLE_TOOLBAR cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_FORM_ROLE_TOOLBAR.ROLE_ID, COM_FORM_ROLE_TOOLBAR.ID, COM_FORM_ROLE_TOOLBAR.TOOLBAR_ID, COM_FORM_ROLE_TOOLBAR.FORM_ID from COM_FORM_ROLE_TOOLBAR where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_FORM_ROLE_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FORM_ROLE_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ROLE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TOOLBAR_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FORM_ID = sqlReader.GetString(3);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_FORM_ROLE_TOOLBAR[] objs = new DisplayObject_COM_FORM_ROLE_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_FORM_ROLE_TOOLBAR[] Query(CauseObject_COM_FORM_ROLE_TOOLBAR cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_FORM_ROLE_TOOLBAR.ROLE_ID, COM_FORM_ROLE_TOOLBAR.ID, COM_FORM_ROLE_TOOLBAR.TOOLBAR_ID, COM_FORM_ROLE_TOOLBAR.FORM_ID from COM_FORM_ROLE_TOOLBAR where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_FORM_ROLE_TOOLBAR",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_FORM_ROLE_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FORM_ROLE_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ROLE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TOOLBAR_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FORM_ID = sqlReader.GetString(3);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_FORM_ROLE_TOOLBAR[] objs = new DisplayObject_COM_FORM_ROLE_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_FORM_ROLE_TOOLBAR[] Query(CauseObject_COM_FORM_ROLE_TOOLBAR cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_FORM_ROLE_TOOLBAR.ROLE_ID, COM_FORM_ROLE_TOOLBAR.ID, COM_FORM_ROLE_TOOLBAR.TOOLBAR_ID, COM_FORM_ROLE_TOOLBAR.FORM_ID from COM_FORM_ROLE_TOOLBAR where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_FORM_ROLE_TOOLBAR",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_FORM_ROLE_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FORM_ROLE_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ROLE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TOOLBAR_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FORM_ID = sqlReader.GetString(3);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_FORM_ROLE_TOOLBAR[] objs = new DisplayObject_COM_FORM_ROLE_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_FORM_ROLE_TOOLBAR obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ROLE_ID"))
			{
				strBuf.Add("  COM_FORM_ROLE_TOOLBAR.ROLE_ID = :ROLE_ID");
				param = new OracleParameter();
				param.ParameterName = ":ROLE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ROLE_ID) ? string.Empty : obj.ROLE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TOOLBAR_ID"))
			{
				strBuf.Add("  COM_FORM_ROLE_TOOLBAR.TOOLBAR_ID = :TOOLBAR_ID");
				param = new OracleParameter();
				param.ParameterName = ":TOOLBAR_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.TOOLBAR_ID) ? string.Empty : obj.TOOLBAR_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FORM_ID"))
			{
				strBuf.Add("  COM_FORM_ROLE_TOOLBAR.FORM_ID = :FORM_ID");
				param = new OracleParameter();
				param.ParameterName = ":FORM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.FORM_ID) ? string.Empty : obj.FORM_ID;
				paramList.Add(param);
			}
			//pk here
			param = new OracleParameter();
			param.ParameterName = ":ID";
			param.OracleType = System.Data.OracleClient.OracleType.Char;
			param.Size = 36;
			param.Value = obj.ID;
			paramList.Add(param);
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		#endregion 
	}
}
