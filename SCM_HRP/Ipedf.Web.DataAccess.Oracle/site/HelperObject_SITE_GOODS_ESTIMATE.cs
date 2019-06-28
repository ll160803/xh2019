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
	[CauseObject(typeof(CauseObject_SITE_GOODS_ESTIMATE))]
	public partial class HelperObject_SITE_GOODS_ESTIMATE
	{		
		#region Method Blok
		public static int Save(EntityObject_SITE_GOODS_ESTIMATE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into SITE_GOODS_ESTIMATE( ID, GOODS_ID, USER_ID, ESTIMATE_DATE, SUMMARY, GRADE) values ( :ID, :GOODS_ID, :USER_ID, :ESTIMATE_DATE, :SUMMARY, :GRADE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[6];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":GOODS_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.GOODS_ID == null ? String.Empty:obj.GOODS_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":USER_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ESTIMATE_DATE";
			parameters[3].Size = 7;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[3].Value = obj.ESTIMATE_DATE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":SUMMARY";
			parameters[4].Size = 1024;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.SUMMARY == null ? String.Empty:obj.SUMMARY;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":GRADE";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.GRADE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SITE_GOODS_ESTIMATE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SITE_GOODS_ESTIMATE set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SITE_GOODS_ESTIMATE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SITE_GOODS_ESTIMATE where  ID = :ID ";
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
		public static EntityObject_SITE_GOODS_ESTIMATE Get(EntityObject_SITE_GOODS_ESTIMATE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, GOODS_ID, USER_ID, ESTIMATE_DATE, SUMMARY, GRADE from SITE_GOODS_ESTIMATE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SITE_GOODS_ESTIMATE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SITE_GOODS_ESTIMATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GOODS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ESTIMATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SUMMARY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GRADE = sqlReader.GetDecimal(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SITE_GOODS_ESTIMATE[] objs = new EntityObject_SITE_GOODS_ESTIMATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_SITE_GOODS_ESTIMATE Get(EntityObject_SITE_GOODS_ESTIMATE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, GOODS_ID, USER_ID, ESTIMATE_DATE, SUMMARY, GRADE from SITE_GOODS_ESTIMATE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SITE_GOODS_ESTIMATE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SITE_GOODS_ESTIMATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GOODS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ESTIMATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SUMMARY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GRADE = sqlReader.GetDecimal(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SITE_GOODS_ESTIMATE[] objs = new EntityObject_SITE_GOODS_ESTIMATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SITE_GOODS_ESTIMATE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SITE_GOODS_ESTIMATE.ID, SITE_GOODS_ESTIMATE.GOODS_ID, SITE_GOODS_ESTIMATE.USER_ID, SITE_GOODS_ESTIMATE.ESTIMATE_DATE, SITE_GOODS_ESTIMATE.SUMMARY, SITE_GOODS_ESTIMATE.GRADE, SITE_GOODS.NAME as SITE_GOODS_NAME, SITE_USER.NICKNAME as SITE_USER_NAME from SITE_GOODS_ESTIMATE left join SITE_GOODS   SITE_GOODS on SITE_GOODS_ESTIMATE.GOODS_ID = SITE_GOODS.ID left join SITE_USER   SITE_USER on SITE_GOODS_ESTIMATE.USER_ID = SITE_USER.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SITE_GOODS_ESTIMATE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_GOODS_ESTIMATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GOODS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ESTIMATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SUMMARY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GRADE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SITE_GOODS_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SITE_USER_NICKNAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_GOODS_ESTIMATE[] objs = new DisplayObject_SITE_GOODS_ESTIMATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SITE_GOODS_ESTIMATE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And SITE_GOODS_ESTIMATE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS_ESTIMATE", "ID"));
			}
			if(cause.GOODS_ID!= string.Empty)
			{
				strBuf.Append(" And SITE_GOODS_ESTIMATE.GOODS_ID ").Append((cause.GOODS_ID.StartsWith("%") || cause.GOODS_ID.EndsWith("%")) ? " like " : " = ").Append(" :GOODS_ID");
				param = new OracleParameter();
				param.ParameterName =":GOODS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.GOODS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("GOODS_ID"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS_ESTIMATE", "GOODS_ID"));
			}
			if(cause.USER_ID!= string.Empty)
			{
				strBuf.Append(" And SITE_GOODS_ESTIMATE.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :USER_ID");
				param = new OracleParameter();
				param.ParameterName =":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS_ESTIMATE", "USER_ID"));
			}
			if(cause.ESTIMATE_DATE!= null)
			{
				if (cause.ESTIMATE_DATE.Begin != null)
				{
					strBuf.Append(" And SITE_GOODS_ESTIMATE.ESTIMATE_DATE >= :ESTIMATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":ESTIMATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ESTIMATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.ESTIMATE_DATE.End != null)
				{
					strBuf.Append(" And SITE_GOODS_ESTIMATE.ESTIMATE_DATE < :ESTIMATE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":ESTIMATE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ESTIMATE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("ESTIMATE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS_ESTIMATE", "ESTIMATE_DATE"));
			}
			if(cause.SUMMARY!= string.Empty)
			{
				strBuf.Append(" And SITE_GOODS_ESTIMATE.SUMMARY ").Append((cause.SUMMARY.StartsWith("%") || cause.SUMMARY.EndsWith("%")) ? " like " : " = ").Append(" :SUMMARY");
				param = new OracleParameter();
				param.ParameterName =":SUMMARY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1024;
				param.Value = cause.SUMMARY;
				paramList.Add(param);
			}
			if (cause.HasINValue("SUMMARY"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS_ESTIMATE", "SUMMARY"));
			}
			if(cause.GRADE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SITE_GOODS_ESTIMATE.GRADE = :GRADE");
				param = new OracleParameter();
				param.ParameterName =":GRADE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.GRADE;
				paramList.Add(param);
			}
			if (cause.HasINValue("GRADE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS_ESTIMATE", "GRADE"));
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
		public static DisplayObject_SITE_GOODS_ESTIMATE[] Query(CauseObject_SITE_GOODS_ESTIMATE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SITE_GOODS_ESTIMATE.ID, SITE_GOODS_ESTIMATE.GOODS_ID, SITE_GOODS_ESTIMATE.USER_ID, SITE_GOODS_ESTIMATE.ESTIMATE_DATE, SITE_GOODS_ESTIMATE.SUMMARY, SITE_GOODS_ESTIMATE.GRADE, SITE_GOODS.NAME as SITE_GOODS_NAME, SITE_USER.NICKNAME as SITE_USER_NAME from SITE_GOODS_ESTIMATE left join SITE_GOODS   SITE_GOODS on SITE_GOODS_ESTIMATE.GOODS_ID = SITE_GOODS.ID left join SITE_USER   SITE_USER on SITE_GOODS_ESTIMATE.USER_ID = SITE_USER.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SITE_GOODS_ESTIMATE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_GOODS_ESTIMATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GOODS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ESTIMATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SUMMARY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GRADE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SITE_GOODS_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SITE_USER_NICKNAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_GOODS_ESTIMATE[] objs = new DisplayObject_SITE_GOODS_ESTIMATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_SITE_GOODS_ESTIMATE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SITE_GOODS_ESTIMATE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_SITE_GOODS_ESTIMATE[] Query(CauseObject_SITE_GOODS_ESTIMATE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SITE_GOODS_ESTIMATE.ID, SITE_GOODS_ESTIMATE.GOODS_ID, SITE_GOODS_ESTIMATE.USER_ID, SITE_GOODS_ESTIMATE.ESTIMATE_DATE, SITE_GOODS_ESTIMATE.SUMMARY, SITE_GOODS_ESTIMATE.GRADE, SITE_GOODS.NAME as SITE_GOODS_NAME, SITE_USER.NICKNAME as SITE_USER_NAME from SITE_GOODS_ESTIMATE left join SITE_GOODS   SITE_GOODS on SITE_GOODS_ESTIMATE.GOODS_ID = SITE_GOODS.ID left join SITE_USER   SITE_USER on SITE_GOODS_ESTIMATE.USER_ID = SITE_USER.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SITE_GOODS_ESTIMATE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_GOODS_ESTIMATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GOODS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ESTIMATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SUMMARY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GRADE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SITE_GOODS_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SITE_USER_NICKNAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SITE_GOODS_ESTIMATE[] objs = new DisplayObject_SITE_GOODS_ESTIMATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SITE_GOODS_ESTIMATE[] Query(CauseObject_SITE_GOODS_ESTIMATE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SITE_GOODS_ESTIMATE.ID, SITE_GOODS_ESTIMATE.GOODS_ID, SITE_GOODS_ESTIMATE.USER_ID, SITE_GOODS_ESTIMATE.ESTIMATE_DATE, SITE_GOODS_ESTIMATE.SUMMARY, SITE_GOODS_ESTIMATE.GRADE, SITE_GOODS.NAME as SITE_GOODS_NAME, SITE_USER.NICKNAME as SITE_USER_NAME from SITE_GOODS_ESTIMATE left join SITE_GOODS   SITE_GOODS on SITE_GOODS_ESTIMATE.GOODS_ID = SITE_GOODS.ID left join SITE_USER   SITE_USER on SITE_GOODS_ESTIMATE.USER_ID = SITE_USER.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SITE_GOODS_ESTIMATE",paging, order, sSql, parameters, connection);
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
			DisplayObject_SITE_GOODS_ESTIMATE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_GOODS_ESTIMATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GOODS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ESTIMATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SUMMARY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GRADE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SITE_GOODS_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SITE_USER_NICKNAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_GOODS_ESTIMATE[] objs = new DisplayObject_SITE_GOODS_ESTIMATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SITE_GOODS_ESTIMATE[] Query(CauseObject_SITE_GOODS_ESTIMATE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SITE_GOODS_ESTIMATE.ID, SITE_GOODS_ESTIMATE.GOODS_ID, SITE_GOODS_ESTIMATE.USER_ID, SITE_GOODS_ESTIMATE.ESTIMATE_DATE, SITE_GOODS_ESTIMATE.SUMMARY, SITE_GOODS_ESTIMATE.GRADE, SITE_GOODS.NAME as SITE_GOODS_NAME, SITE_USER.NICKNAME as SITE_USER_NAME from SITE_GOODS_ESTIMATE left join SITE_GOODS   SITE_GOODS on SITE_GOODS_ESTIMATE.GOODS_ID = SITE_GOODS.ID left join SITE_USER   SITE_USER on SITE_GOODS_ESTIMATE.USER_ID = SITE_USER.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SITE_GOODS_ESTIMATE",paging, order, sSql, parameters, trans);
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
			DisplayObject_SITE_GOODS_ESTIMATE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_GOODS_ESTIMATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GOODS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ESTIMATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SUMMARY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GRADE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SITE_GOODS_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SITE_USER_NICKNAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SITE_GOODS_ESTIMATE[] objs = new DisplayObject_SITE_GOODS_ESTIMATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SITE_GOODS_ESTIMATE obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("GOODS_ID"))
			{
				strBuf.Add("  SITE_GOODS_ESTIMATE.GOODS_ID = :GOODS_ID");
				param = new OracleParameter();
				param.ParameterName = ":GOODS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.GOODS_ID) ? string.Empty : obj.GOODS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  SITE_GOODS_ESTIMATE.USER_ID = :USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ESTIMATE_DATE"))
			{
				strBuf.Add("  SITE_GOODS_ESTIMATE.ESTIMATE_DATE = :ESTIMATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":ESTIMATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.ESTIMATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SUMMARY"))
			{
				strBuf.Add("  SITE_GOODS_ESTIMATE.SUMMARY = :SUMMARY");
				param = new OracleParameter();
				param.ParameterName = ":SUMMARY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1024;
				param.Value = string.IsNullOrEmpty(obj.SUMMARY) ? string.Empty : obj.SUMMARY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GRADE"))
			{
				strBuf.Add("  SITE_GOODS_ESTIMATE.GRADE = :GRADE");
				param = new OracleParameter();
				param.ParameterName = ":GRADE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.GRADE;
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
