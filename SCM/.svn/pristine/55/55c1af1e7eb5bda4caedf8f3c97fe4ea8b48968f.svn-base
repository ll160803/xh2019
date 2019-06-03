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
	[CauseObject(typeof(CauseObject_SITE_USER_ACCOUNT_TRADE))]
	public partial class HelperObject_SITE_USER_ACCOUNT_TRADE
	{		
		#region Method Blok
		public static int Save(EntityObject_SITE_USER_ACCOUNT_TRADE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into SITE_USER_ACCOUNT_TRADE( ID, ACCOUNT_ID, ORDER_ID, TRADE_DATE, MONEY, TRADE_TYPE) values ( :ID, :ACCOUNT_ID, :ORDER_ID, :TRADE_DATE, :MONEY, :TRADE_TYPE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[6];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ACCOUNT_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ACCOUNT_ID == null ? String.Empty:obj.ACCOUNT_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ORDER_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ORDER_ID == null ? String.Empty:obj.ORDER_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":TRADE_DATE";
			parameters[3].Size = 7;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[3].Value = obj.TRADE_DATE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":MONEY";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.MONEY;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":TRADE_TYPE";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.TRADE_TYPE == null ? String.Empty:obj.TRADE_TYPE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SITE_USER_ACCOUNT_TRADE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SITE_USER_ACCOUNT_TRADE set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SITE_USER_ACCOUNT_TRADE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SITE_USER_ACCOUNT_TRADE where  ID = :ID ";
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
		public static EntityObject_SITE_USER_ACCOUNT_TRADE Get(EntityObject_SITE_USER_ACCOUNT_TRADE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, ACCOUNT_ID, ORDER_ID, TRADE_DATE, MONEY, TRADE_TYPE from SITE_USER_ACCOUNT_TRADE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SITE_USER_ACCOUNT_TRADE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SITE_USER_ACCOUNT_TRADE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ACCOUNT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ORDER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TRADE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TRADE_TYPE = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SITE_USER_ACCOUNT_TRADE[] objs = new EntityObject_SITE_USER_ACCOUNT_TRADE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_SITE_USER_ACCOUNT_TRADE Get(EntityObject_SITE_USER_ACCOUNT_TRADE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, ACCOUNT_ID, ORDER_ID, TRADE_DATE, MONEY, TRADE_TYPE from SITE_USER_ACCOUNT_TRADE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SITE_USER_ACCOUNT_TRADE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SITE_USER_ACCOUNT_TRADE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ACCOUNT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ORDER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TRADE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TRADE_TYPE = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SITE_USER_ACCOUNT_TRADE[] objs = new EntityObject_SITE_USER_ACCOUNT_TRADE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SITE_USER_ACCOUNT_TRADE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SITE_USER_ACCOUNT_TRADE.ID, SITE_USER_ACCOUNT_TRADE.ACCOUNT_ID, SITE_USER_ACCOUNT_TRADE.ORDER_ID, SITE_USER_ACCOUNT_TRADE.TRADE_DATE, SITE_USER_ACCOUNT_TRADE.MONEY, SITE_USER_ACCOUNT_TRADE.TRADE_TYPE, SITE_USER_ACCOUNT.NAME as SITE_USER_ACCOUNT_NAME, SITE_ORDER.CODE as SITE_ORDER_NAME, COM_TYPE.NAME as COM_TYPE_NAME from SITE_USER_ACCOUNT_TRADE left join SITE_USER_ACCOUNT   SITE_USER_ACCOUNT on SITE_USER_ACCOUNT_TRADE.ACCOUNT_ID = SITE_USER_ACCOUNT.ID left join SITE_ORDER   SITE_ORDER on SITE_USER_ACCOUNT_TRADE.ORDER_ID = SITE_ORDER.ID left join COM_TYPE   COM_TYPE on SITE_USER_ACCOUNT_TRADE.TRADE_TYPE = COM_TYPE.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SITE_USER_ACCOUNT_TRADE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_USER_ACCOUNT_TRADE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ACCOUNT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ORDER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TRADE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TRADE_TYPE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SITE_USER_ACCOUNT_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SITE_ORDER_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_USER_ACCOUNT_TRADE[] objs = new DisplayObject_SITE_USER_ACCOUNT_TRADE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SITE_USER_ACCOUNT_TRADE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And SITE_USER_ACCOUNT_TRADE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER_ACCOUNT_TRADE", "ID"));
			}
			if(cause.ACCOUNT_ID!= string.Empty)
			{
				strBuf.Append(" And SITE_USER_ACCOUNT_TRADE.ACCOUNT_ID ").Append((cause.ACCOUNT_ID.StartsWith("%") || cause.ACCOUNT_ID.EndsWith("%")) ? " like " : " = ").Append(" :ACCOUNT_ID");
				param = new OracleParameter();
				param.ParameterName =":ACCOUNT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ACCOUNT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCOUNT_ID"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER_ACCOUNT_TRADE", "ACCOUNT_ID"));
			}
			if(cause.ORDER_ID!= string.Empty)
			{
				strBuf.Append(" And SITE_USER_ACCOUNT_TRADE.ORDER_ID ").Append((cause.ORDER_ID.StartsWith("%") || cause.ORDER_ID.EndsWith("%")) ? " like " : " = ").Append(" :ORDER_ID");
				param = new OracleParameter();
				param.ParameterName =":ORDER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ORDER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ORDER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER_ACCOUNT_TRADE", "ORDER_ID"));
			}
			if(cause.TRADE_DATE!= null)
			{
				if (cause.TRADE_DATE.Begin != null)
				{
					strBuf.Append(" And SITE_USER_ACCOUNT_TRADE.TRADE_DATE >= :TRADE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":TRADE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.TRADE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.TRADE_DATE.End != null)
				{
					strBuf.Append(" And SITE_USER_ACCOUNT_TRADE.TRADE_DATE < :TRADE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":TRADE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.TRADE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("TRADE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER_ACCOUNT_TRADE", "TRADE_DATE"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SITE_USER_ACCOUNT_TRADE.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName =":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER_ACCOUNT_TRADE", "MONEY"));
			}
			if(cause.TRADE_TYPE!= string.Empty)
			{
				strBuf.Append(" And SITE_USER_ACCOUNT_TRADE.TRADE_TYPE ").Append((cause.TRADE_TYPE.StartsWith("%") || cause.TRADE_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :TRADE_TYPE");
				param = new OracleParameter();
				param.ParameterName =":TRADE_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.TRADE_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("TRADE_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER_ACCOUNT_TRADE", "TRADE_TYPE"));
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
		public static DisplayObject_SITE_USER_ACCOUNT_TRADE[] Query(CauseObject_SITE_USER_ACCOUNT_TRADE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SITE_USER_ACCOUNT_TRADE.ID, SITE_USER_ACCOUNT_TRADE.ACCOUNT_ID, SITE_USER_ACCOUNT_TRADE.ORDER_ID, SITE_USER_ACCOUNT_TRADE.TRADE_DATE, SITE_USER_ACCOUNT_TRADE.MONEY, SITE_USER_ACCOUNT_TRADE.TRADE_TYPE, SITE_USER_ACCOUNT.NAME as SITE_USER_ACCOUNT_NAME, SITE_ORDER.CODE as SITE_ORDER_NAME, COM_TYPE.NAME as COM_TYPE_NAME from SITE_USER_ACCOUNT_TRADE left join SITE_USER_ACCOUNT   SITE_USER_ACCOUNT on SITE_USER_ACCOUNT_TRADE.ACCOUNT_ID = SITE_USER_ACCOUNT.ID left join SITE_ORDER   SITE_ORDER on SITE_USER_ACCOUNT_TRADE.ORDER_ID = SITE_ORDER.ID left join COM_TYPE   COM_TYPE on SITE_USER_ACCOUNT_TRADE.TRADE_TYPE = COM_TYPE.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SITE_USER_ACCOUNT_TRADE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_USER_ACCOUNT_TRADE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ACCOUNT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ORDER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TRADE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TRADE_TYPE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SITE_USER_ACCOUNT_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SITE_ORDER_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_USER_ACCOUNT_TRADE[] objs = new DisplayObject_SITE_USER_ACCOUNT_TRADE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_SITE_USER_ACCOUNT_TRADE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SITE_USER_ACCOUNT_TRADE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_SITE_USER_ACCOUNT_TRADE[] Query(CauseObject_SITE_USER_ACCOUNT_TRADE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SITE_USER_ACCOUNT_TRADE.ID, SITE_USER_ACCOUNT_TRADE.ACCOUNT_ID, SITE_USER_ACCOUNT_TRADE.ORDER_ID, SITE_USER_ACCOUNT_TRADE.TRADE_DATE, SITE_USER_ACCOUNT_TRADE.MONEY, SITE_USER_ACCOUNT_TRADE.TRADE_TYPE, SITE_USER_ACCOUNT.NAME as SITE_USER_ACCOUNT_NAME, SITE_ORDER.CODE as SITE_ORDER_NAME, COM_TYPE.NAME as COM_TYPE_NAME from SITE_USER_ACCOUNT_TRADE left join SITE_USER_ACCOUNT   SITE_USER_ACCOUNT on SITE_USER_ACCOUNT_TRADE.ACCOUNT_ID = SITE_USER_ACCOUNT.ID left join SITE_ORDER   SITE_ORDER on SITE_USER_ACCOUNT_TRADE.ORDER_ID = SITE_ORDER.ID left join COM_TYPE   COM_TYPE on SITE_USER_ACCOUNT_TRADE.TRADE_TYPE = COM_TYPE.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SITE_USER_ACCOUNT_TRADE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_USER_ACCOUNT_TRADE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ACCOUNT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ORDER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TRADE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TRADE_TYPE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SITE_USER_ACCOUNT_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SITE_ORDER_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SITE_USER_ACCOUNT_TRADE[] objs = new DisplayObject_SITE_USER_ACCOUNT_TRADE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SITE_USER_ACCOUNT_TRADE[] Query(CauseObject_SITE_USER_ACCOUNT_TRADE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SITE_USER_ACCOUNT_TRADE.ID, SITE_USER_ACCOUNT_TRADE.ACCOUNT_ID, SITE_USER_ACCOUNT_TRADE.ORDER_ID, SITE_USER_ACCOUNT_TRADE.TRADE_DATE, SITE_USER_ACCOUNT_TRADE.MONEY, SITE_USER_ACCOUNT_TRADE.TRADE_TYPE, SITE_USER_ACCOUNT.NAME as SITE_USER_ACCOUNT_NAME, SITE_ORDER.CODE as SITE_ORDER_NAME, COM_TYPE.NAME as COM_TYPE_NAME from SITE_USER_ACCOUNT_TRADE left join SITE_USER_ACCOUNT   SITE_USER_ACCOUNT on SITE_USER_ACCOUNT_TRADE.ACCOUNT_ID = SITE_USER_ACCOUNT.ID left join SITE_ORDER   SITE_ORDER on SITE_USER_ACCOUNT_TRADE.ORDER_ID = SITE_ORDER.ID left join COM_TYPE   COM_TYPE on SITE_USER_ACCOUNT_TRADE.TRADE_TYPE = COM_TYPE.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SITE_USER_ACCOUNT_TRADE",paging, order, sSql, parameters, connection);
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
			DisplayObject_SITE_USER_ACCOUNT_TRADE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_USER_ACCOUNT_TRADE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ACCOUNT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ORDER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TRADE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TRADE_TYPE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SITE_USER_ACCOUNT_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SITE_ORDER_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_USER_ACCOUNT_TRADE[] objs = new DisplayObject_SITE_USER_ACCOUNT_TRADE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SITE_USER_ACCOUNT_TRADE[] Query(CauseObject_SITE_USER_ACCOUNT_TRADE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SITE_USER_ACCOUNT_TRADE.ID, SITE_USER_ACCOUNT_TRADE.ACCOUNT_ID, SITE_USER_ACCOUNT_TRADE.ORDER_ID, SITE_USER_ACCOUNT_TRADE.TRADE_DATE, SITE_USER_ACCOUNT_TRADE.MONEY, SITE_USER_ACCOUNT_TRADE.TRADE_TYPE, SITE_USER_ACCOUNT.NAME as SITE_USER_ACCOUNT_NAME, SITE_ORDER.CODE as SITE_ORDER_NAME, COM_TYPE.NAME as COM_TYPE_NAME from SITE_USER_ACCOUNT_TRADE left join SITE_USER_ACCOUNT   SITE_USER_ACCOUNT on SITE_USER_ACCOUNT_TRADE.ACCOUNT_ID = SITE_USER_ACCOUNT.ID left join SITE_ORDER   SITE_ORDER on SITE_USER_ACCOUNT_TRADE.ORDER_ID = SITE_ORDER.ID left join COM_TYPE   COM_TYPE on SITE_USER_ACCOUNT_TRADE.TRADE_TYPE = COM_TYPE.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SITE_USER_ACCOUNT_TRADE",paging, order, sSql, parameters, trans);
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
			DisplayObject_SITE_USER_ACCOUNT_TRADE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_USER_ACCOUNT_TRADE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ACCOUNT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ORDER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TRADE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TRADE_TYPE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SITE_USER_ACCOUNT_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SITE_ORDER_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SITE_USER_ACCOUNT_TRADE[] objs = new DisplayObject_SITE_USER_ACCOUNT_TRADE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SITE_USER_ACCOUNT_TRADE obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ACCOUNT_ID"))
			{
				strBuf.Add("  SITE_USER_ACCOUNT_TRADE.ACCOUNT_ID = :ACCOUNT_ID");
				param = new OracleParameter();
				param.ParameterName = ":ACCOUNT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ACCOUNT_ID) ? string.Empty : obj.ACCOUNT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ORDER_ID"))
			{
				strBuf.Add("  SITE_USER_ACCOUNT_TRADE.ORDER_ID = :ORDER_ID");
				param = new OracleParameter();
				param.ParameterName = ":ORDER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ORDER_ID) ? string.Empty : obj.ORDER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TRADE_DATE"))
			{
				strBuf.Add("  SITE_USER_ACCOUNT_TRADE.TRADE_DATE = :TRADE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":TRADE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.TRADE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  SITE_USER_ACCOUNT_TRADE.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName = ":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TRADE_TYPE"))
			{
				strBuf.Add("  SITE_USER_ACCOUNT_TRADE.TRADE_TYPE = :TRADE_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":TRADE_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.TRADE_TYPE) ? string.Empty : obj.TRADE_TYPE;
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
