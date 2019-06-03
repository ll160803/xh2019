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
	[CauseObject(typeof(CauseObject_COM_USER_M_DATA))]
	public partial class HelperObject_COM_USER_M_DATA
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_USER_M_DATA obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_USER_M_DATA( DATA_ID, USER_ID, STRATEGY_ID, DATA_LIMIT, ID) values ( :DATA_ID, :USER_ID, :STRATEGY_ID, :DATA_LIMIT, :ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[5];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":DATA_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.DATA_ID == null ? String.Empty:obj.DATA_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":USER_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":STRATEGY_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.STRATEGY_ID == null ? String.Empty:obj.STRATEGY_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":DATA_LIMIT";
			parameters[3].Size = 200;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.DATA_LIMIT == null ? String.Empty:obj.DATA_LIMIT;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ID == null ? String.Empty:obj.ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_USER_M_DATA obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_USER_M_DATA set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_USER_M_DATA obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_USER_M_DATA where  ID = :ID ";
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
		public static EntityObject_COM_USER_M_DATA Get(EntityObject_COM_USER_M_DATA obj)
		{
			
			//平台自动生成代码
			string sSql = "select  DATA_ID, USER_ID, STRATEGY_ID, DATA_LIMIT, ID from COM_USER_M_DATA where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_USER_M_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_USER_M_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_USER_M_DATA[] objs = new EntityObject_COM_USER_M_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_USER_M_DATA Get(EntityObject_COM_USER_M_DATA obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  DATA_ID, USER_ID, STRATEGY_ID, DATA_LIMIT, ID from COM_USER_M_DATA where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_USER_M_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_USER_M_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_USER_M_DATA[] objs = new EntityObject_COM_USER_M_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_USER_M_DATA[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_USER_M_DATA.DATA_ID, COM_USER_M_DATA.USER_ID, COM_USER_M_DATA.STRATEGY_ID, COM_USER_M_DATA.DATA_LIMIT, COM_USER_M_DATA.ID, COM_DATA.COMMENTS as COM_DATA_NAME, COM_USER.NAME as COM_USER_NAME, COM_STRATEGY.STRATEGY_NAME as COM_STRATEGY_NAME from COM_USER_M_DATA left join COM_DATA   COM_DATA on COM_USER_M_DATA.DATA_ID = COM_DATA.ID left join COM_USER   COM_USER on COM_USER_M_DATA.USER_ID = COM_USER.ID left join COM_STRATEGY   COM_STRATEGY on COM_USER_M_DATA.STRATEGY_ID = COM_STRATEGY.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_USER_M_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER_M_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COM_DATA_COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COM_STRATEGY_STRATEGY_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_USER_M_DATA[] objs = new DisplayObject_COM_USER_M_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_USER_M_DATA cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.DATA_ID!= string.Empty)
			{
				strBuf.Append(" And COM_USER_M_DATA.DATA_ID ").Append((cause.DATA_ID.StartsWith("%") || cause.DATA_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER_M_DATA", "DATA_ID"));
			}
			if(cause.USER_ID!= string.Empty)
			{
				strBuf.Append(" And COM_USER_M_DATA.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :USER_ID");
				param = new OracleParameter();
				param.ParameterName =":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER_M_DATA", "USER_ID"));
			}
			if(cause.STRATEGY_ID!= string.Empty)
			{
				strBuf.Append(" And COM_USER_M_DATA.STRATEGY_ID ").Append((cause.STRATEGY_ID.StartsWith("%") || cause.STRATEGY_ID.EndsWith("%")) ? " like " : " = ").Append(" :STRATEGY_ID");
				param = new OracleParameter();
				param.ParameterName =":STRATEGY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STRATEGY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STRATEGY_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER_M_DATA", "STRATEGY_ID"));
			}
			if(cause.DATA_LIMIT!= string.Empty)
			{
				strBuf.Append(" And COM_USER_M_DATA.DATA_LIMIT ").Append((cause.DATA_LIMIT.StartsWith("%") || cause.DATA_LIMIT.EndsWith("%")) ? " like " : " = ").Append(" :DATA_LIMIT");
				param = new OracleParameter();
				param.ParameterName =":DATA_LIMIT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.DATA_LIMIT;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_LIMIT"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER_M_DATA", "DATA_LIMIT"));
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And COM_USER_M_DATA.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER_M_DATA", "ID"));
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
		public static DisplayObject_COM_USER_M_DATA[] Query(CauseObject_COM_USER_M_DATA cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_USER_M_DATA.DATA_ID, COM_USER_M_DATA.USER_ID, COM_USER_M_DATA.STRATEGY_ID, COM_USER_M_DATA.DATA_LIMIT, COM_USER_M_DATA.ID, COM_DATA.COMMENTS as COM_DATA_NAME, COM_USER.NAME as COM_USER_NAME, COM_STRATEGY.STRATEGY_NAME as COM_STRATEGY_NAME from COM_USER_M_DATA left join COM_DATA   COM_DATA on COM_USER_M_DATA.DATA_ID = COM_DATA.ID left join COM_USER   COM_USER on COM_USER_M_DATA.USER_ID = COM_USER.ID left join COM_STRATEGY   COM_STRATEGY on COM_USER_M_DATA.STRATEGY_ID = COM_STRATEGY.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_USER_M_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER_M_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COM_DATA_COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COM_STRATEGY_STRATEGY_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_USER_M_DATA[] objs = new DisplayObject_COM_USER_M_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_USER_M_DATA cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_USER_M_DATA where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_USER_M_DATA[] Query(CauseObject_COM_USER_M_DATA cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_USER_M_DATA.DATA_ID, COM_USER_M_DATA.USER_ID, COM_USER_M_DATA.STRATEGY_ID, COM_USER_M_DATA.DATA_LIMIT, COM_USER_M_DATA.ID, COM_DATA.COMMENTS as COM_DATA_NAME, COM_USER.NAME as COM_USER_NAME, COM_STRATEGY.STRATEGY_NAME as COM_STRATEGY_NAME from COM_USER_M_DATA left join COM_DATA   COM_DATA on COM_USER_M_DATA.DATA_ID = COM_DATA.ID left join COM_USER   COM_USER on COM_USER_M_DATA.USER_ID = COM_USER.ID left join COM_STRATEGY   COM_STRATEGY on COM_USER_M_DATA.STRATEGY_ID = COM_STRATEGY.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_USER_M_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER_M_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COM_DATA_COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COM_STRATEGY_STRATEGY_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_USER_M_DATA[] objs = new DisplayObject_COM_USER_M_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_USER_M_DATA[] Query(CauseObject_COM_USER_M_DATA cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_USER_M_DATA.DATA_ID, COM_USER_M_DATA.USER_ID, COM_USER_M_DATA.STRATEGY_ID, COM_USER_M_DATA.DATA_LIMIT, COM_USER_M_DATA.ID, COM_DATA.COMMENTS as COM_DATA_NAME, COM_USER.NAME as COM_USER_NAME, COM_STRATEGY.STRATEGY_NAME as COM_STRATEGY_NAME from COM_USER_M_DATA left join COM_DATA   COM_DATA on COM_USER_M_DATA.DATA_ID = COM_DATA.ID left join COM_USER   COM_USER on COM_USER_M_DATA.USER_ID = COM_USER.ID left join COM_STRATEGY   COM_STRATEGY on COM_USER_M_DATA.STRATEGY_ID = COM_STRATEGY.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_USER_M_DATA",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_USER_M_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER_M_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COM_DATA_COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COM_STRATEGY_STRATEGY_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_USER_M_DATA[] objs = new DisplayObject_COM_USER_M_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_USER_M_DATA[] Query(CauseObject_COM_USER_M_DATA cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_USER_M_DATA.DATA_ID, COM_USER_M_DATA.USER_ID, COM_USER_M_DATA.STRATEGY_ID, COM_USER_M_DATA.DATA_LIMIT, COM_USER_M_DATA.ID, COM_DATA.COMMENTS as COM_DATA_NAME, COM_USER.NAME as COM_USER_NAME, COM_STRATEGY.STRATEGY_NAME as COM_STRATEGY_NAME from COM_USER_M_DATA left join COM_DATA   COM_DATA on COM_USER_M_DATA.DATA_ID = COM_DATA.ID left join COM_USER   COM_USER on COM_USER_M_DATA.USER_ID = COM_USER.ID left join COM_STRATEGY   COM_STRATEGY on COM_USER_M_DATA.STRATEGY_ID = COM_STRATEGY.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_USER_M_DATA",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_USER_M_DATA dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER_M_DATA();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_LIMIT = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COM_DATA_COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COM_STRATEGY_STRATEGY_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_USER_M_DATA[] objs = new DisplayObject_COM_USER_M_DATA[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_USER_M_DATA obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("DATA_ID"))
			{
				strBuf.Add("  COM_USER_M_DATA.DATA_ID = :DATA_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ID) ? string.Empty : obj.DATA_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  COM_USER_M_DATA.USER_ID = :USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STRATEGY_ID"))
			{
				strBuf.Add("  COM_USER_M_DATA.STRATEGY_ID = :STRATEGY_ID");
				param = new OracleParameter();
				param.ParameterName = ":STRATEGY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.STRATEGY_ID) ? string.Empty : obj.STRATEGY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_LIMIT"))
			{
				strBuf.Add("  COM_USER_M_DATA.DATA_LIMIT = :DATA_LIMIT");
				param = new OracleParameter();
				param.ParameterName = ":DATA_LIMIT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.DATA_LIMIT) ? string.Empty : obj.DATA_LIMIT;
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
