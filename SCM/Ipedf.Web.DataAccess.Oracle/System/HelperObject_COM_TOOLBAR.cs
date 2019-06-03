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
	[CauseObject(typeof(CauseObject_COM_TOOLBAR))]
	public partial class HelperObject_COM_TOOLBAR
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_TOOLBAR obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_TOOLBAR( TEXT, HANDLER, ICONCLS, DISPLAYINDEX, ID, COMMETS) values ( :TEXT, :HANDLER, :ICONCLS, :DISPLAYINDEX, :ID, :COMMETS)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[6];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":TEXT";
			parameters[0].Size = 20;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.TEXT == null ? String.Empty:obj.TEXT;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":HANDLER";
			parameters[1].Size = 20;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.HANDLER == null ? String.Empty:obj.HANDLER;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ICONCLS";
			parameters[2].Size = 20;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.ICONCLS == null ? String.Empty:obj.ICONCLS;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":DISPLAYINDEX";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.DISPLAYINDEX;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":COMMETS";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.COMMETS == null ? String.Empty:obj.COMMETS;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_TOOLBAR obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_TOOLBAR set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_TOOLBAR obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_TOOLBAR where  ID = :ID ";
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
		public static EntityObject_COM_TOOLBAR Get(EntityObject_COM_TOOLBAR obj)
		{
			
			//平台自动生成代码
			string sSql = "select  TEXT, HANDLER, ICONCLS, DISPLAYINDEX, ID, COMMETS from COM_TOOLBAR where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TEXT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.HANDLER = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ICONCLS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAYINDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMETS = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_TOOLBAR[] objs = new EntityObject_COM_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_TOOLBAR Get(EntityObject_COM_TOOLBAR obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  TEXT, HANDLER, ICONCLS, DISPLAYINDEX, ID, COMMETS from COM_TOOLBAR where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TEXT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.HANDLER = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ICONCLS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAYINDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMETS = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_TOOLBAR[] objs = new EntityObject_COM_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_TOOLBAR[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_TOOLBAR.TEXT, COM_TOOLBAR.HANDLER, COM_TOOLBAR.ICONCLS, COM_TOOLBAR.DISPLAYINDEX, COM_TOOLBAR.ID, COM_TOOLBAR.COMMETS from COM_TOOLBAR where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TEXT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.HANDLER = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ICONCLS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAYINDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMETS = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_TOOLBAR[] objs = new DisplayObject_COM_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_TOOLBAR cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.TEXT))
			{
				strBuf.Append(" And COM_TOOLBAR.TEXT ").Append((cause.TEXT.StartsWith("%") || cause.TEXT.EndsWith("%")) ? " like " : " = ").Append(" :TEXT");
				param = new OracleParameter();
				param.ParameterName =":TEXT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.TEXT;
				paramList.Add(param);
			}
			if (cause.HasINValue("TEXT"))
			{
				strBuf.Append(cause.GetINSQL("COM_TOOLBAR", "TEXT"));
			}
			if(!string.IsNullOrEmpty(cause.HANDLER))
			{
				strBuf.Append(" And COM_TOOLBAR.HANDLER ").Append((cause.HANDLER.StartsWith("%") || cause.HANDLER.EndsWith("%")) ? " like " : " = ").Append(" :HANDLER");
				param = new OracleParameter();
				param.ParameterName =":HANDLER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.HANDLER;
				paramList.Add(param);
			}
			if (cause.HasINValue("HANDLER"))
			{
				strBuf.Append(cause.GetINSQL("COM_TOOLBAR", "HANDLER"));
			}
			if(!string.IsNullOrEmpty(cause.ICONCLS))
			{
				strBuf.Append(" And COM_TOOLBAR.ICONCLS ").Append((cause.ICONCLS.StartsWith("%") || cause.ICONCLS.EndsWith("%")) ? " like " : " = ").Append(" :ICONCLS");
				param = new OracleParameter();
				param.ParameterName =":ICONCLS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.ICONCLS;
				paramList.Add(param);
			}
			if (cause.HasINValue("ICONCLS"))
			{
				strBuf.Append(cause.GetINSQL("COM_TOOLBAR", "ICONCLS"));
			}
			if(cause.DISPLAYINDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_TOOLBAR.DISPLAYINDEX = :DISPLAYINDEX");
				param = new OracleParameter();
				param.ParameterName =":DISPLAYINDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DISPLAYINDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("DISPLAYINDEX"))
			{
				strBuf.Append(cause.GetINSQL("COM_TOOLBAR", "DISPLAYINDEX"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And COM_TOOLBAR.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_TOOLBAR", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMETS))
			{
				strBuf.Append(" And COM_TOOLBAR.COMMETS ").Append((cause.COMMETS.StartsWith("%") || cause.COMMETS.EndsWith("%")) ? " like " : " = ").Append(" :COMMETS");
				param = new OracleParameter();
				param.ParameterName =":COMMETS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.COMMETS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMETS"))
			{
				strBuf.Append(cause.GetINSQL("COM_TOOLBAR", "COMMETS"));
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
		public static DisplayObject_COM_TOOLBAR[] Query(CauseObject_COM_TOOLBAR cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_TOOLBAR.TEXT, COM_TOOLBAR.HANDLER, COM_TOOLBAR.ICONCLS, COM_TOOLBAR.DISPLAYINDEX, COM_TOOLBAR.ID, COM_TOOLBAR.COMMETS from COM_TOOLBAR where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TEXT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.HANDLER = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ICONCLS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAYINDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMETS = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_TOOLBAR[] objs = new DisplayObject_COM_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_TOOLBAR cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_TOOLBAR where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_TOOLBAR[] Query(CauseObject_COM_TOOLBAR cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_TOOLBAR.TEXT, COM_TOOLBAR.HANDLER, COM_TOOLBAR.ICONCLS, COM_TOOLBAR.DISPLAYINDEX, COM_TOOLBAR.ID, COM_TOOLBAR.COMMETS from COM_TOOLBAR where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TEXT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.HANDLER = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ICONCLS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAYINDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMETS = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_TOOLBAR[] objs = new DisplayObject_COM_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_TOOLBAR[] Query(CauseObject_COM_TOOLBAR cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_TOOLBAR.TEXT, COM_TOOLBAR.HANDLER, COM_TOOLBAR.ICONCLS, COM_TOOLBAR.DISPLAYINDEX, COM_TOOLBAR.ID, COM_TOOLBAR.COMMETS from COM_TOOLBAR where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_TOOLBAR",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TEXT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.HANDLER = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ICONCLS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAYINDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMETS = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_TOOLBAR[] objs = new DisplayObject_COM_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_TOOLBAR[] Query(CauseObject_COM_TOOLBAR cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_TOOLBAR.TEXT, COM_TOOLBAR.HANDLER, COM_TOOLBAR.ICONCLS, COM_TOOLBAR.DISPLAYINDEX, COM_TOOLBAR.ID, COM_TOOLBAR.COMMETS from COM_TOOLBAR where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_TOOLBAR",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_TOOLBAR dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_TOOLBAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TEXT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.HANDLER = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ICONCLS = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAYINDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMETS = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_TOOLBAR[] objs = new DisplayObject_COM_TOOLBAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_TOOLBAR obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("TEXT"))
			{
				strBuf.Add("  COM_TOOLBAR.TEXT = :TEXT");
				param = new OracleParameter();
				param.ParameterName = ":TEXT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.TEXT) ? string.Empty : obj.TEXT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("HANDLER"))
			{
				strBuf.Add("  COM_TOOLBAR.HANDLER = :HANDLER");
				param = new OracleParameter();
				param.ParameterName = ":HANDLER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.HANDLER) ? string.Empty : obj.HANDLER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ICONCLS"))
			{
				strBuf.Add("  COM_TOOLBAR.ICONCLS = :ICONCLS");
				param = new OracleParameter();
				param.ParameterName = ":ICONCLS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.ICONCLS) ? string.Empty : obj.ICONCLS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DISPLAYINDEX"))
			{
				strBuf.Add("  COM_TOOLBAR.DISPLAYINDEX = :DISPLAYINDEX");
				param = new OracleParameter();
				param.ParameterName = ":DISPLAYINDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DISPLAYINDEX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMETS"))
			{
				strBuf.Add("  COM_TOOLBAR.COMMETS = :COMMETS");
				param = new OracleParameter();
				param.ParameterName = ":COMMETS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.COMMETS) ? string.Empty : obj.COMMETS;
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
