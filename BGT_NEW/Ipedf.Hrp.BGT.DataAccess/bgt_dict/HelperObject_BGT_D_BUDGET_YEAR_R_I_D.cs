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
	[CauseObject(typeof(CauseObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D))]
	public partial class HelperObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_D_BUDGET_DEPT_YEAR_R_I_D( BUDGET_MONTH, ADJUST_SCALE, BASE_ID, ID) values ( :BUDGET_MONTH, :ADJUST_SCALE, :BASE_ID, :ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[4];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":BUDGET_MONTH";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.BUDGET_MONTH == null ? String.Empty:obj.BUDGET_MONTH;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ADJUST_SCALE";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.ADJUST_SCALE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":BASE_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.ID == null ? String.Empty:obj.ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_D_BUDGET_DEPT_YEAR_R_I_D set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_D_BUDGET_DEPT_YEAR_R_I_D where  ID = :ID ";
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
		public static EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D Get(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  BUDGET_MONTH, ADJUST_SCALE, BASE_ID, ID from BGT_D_BUDGET_DEPT_YEAR_R_I_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_MONTH = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ADJUST_SCALE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[] objs = new EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D Get(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  BUDGET_MONTH, ADJUST_SCALE, BASE_ID, ID from BGT_D_BUDGET_DEPT_YEAR_R_I_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_MONTH = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ADJUST_SCALE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[] objs = new EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_D_BUDGET_DEPT_YEAR_R_I_D.BUDGET_MONTH, BGT_D_BUDGET_DEPT_YEAR_R_I_D.ADJUST_SCALE, BGT_D_BUDGET_DEPT_YEAR_R_I_D.BASE_ID, BGT_D_BUDGET_DEPT_YEAR_R_I_D.ID, BGT_D_BUDGET_MONTH_BUDGET_MONT.BUDGET_MONTH as BUDGET_MONTH_NAME, BGT_D_BUDGET_DEPT_YEAR_R_ID.ID as BASE_ID_NAME from BGT_D_BUDGET_DEPT_YEAR_R_I_D left join BGT_D_BUDGET_MONTH   BGT_D_BUDGET_MONTH_BUDGET_MONT on BGT_D_BUDGET_DEPT_YEAR_R_I_D.BUDGET_MONTH = BGT_D_BUDGET_MONTH_BUDGET_MONT.ID left join BGT_D_BUDGET_DEPT_YEAR_R_I   BGT_D_BUDGET_DEPT_YEAR_R_ID on BGT_D_BUDGET_DEPT_YEAR_R_I_D.BASE_ID = BGT_D_BUDGET_DEPT_YEAR_R_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_MONTH = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ADJUST_SCALE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_MONTH_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[] objs = new DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.BUDGET_MONTH!= string.Empty)
			{
				strBuf.Append(" And BGT_D_BUDGET_DEPT_YEAR_R_I_D.BUDGET_MONTH ").Append((cause.BUDGET_MONTH.StartsWith("%") || cause.BUDGET_MONTH.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_MONTH");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_MONTH";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_MONTH;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_MONTH"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_DEPT_YEAR_R_I_D", "BUDGET_MONTH"));
			}
			if(cause.ADJUST_SCALE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_D_BUDGET_DEPT_YEAR_R_I_D.ADJUST_SCALE = :ADJUST_SCALE");
				param = new OracleParameter();
				param.ParameterName =":ADJUST_SCALE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ADJUST_SCALE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADJUST_SCALE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_DEPT_YEAR_R_I_D", "ADJUST_SCALE"));
			}
			if(cause.BASE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_BUDGET_DEPT_YEAR_R_I_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_DEPT_YEAR_R_I_D", "BASE_ID"));
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_BUDGET_DEPT_YEAR_R_I_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_DEPT_YEAR_R_I_D", "ID"));
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
		public static DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[] Query(CauseObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_D_BUDGET_DEPT_YEAR_R_I_D.BUDGET_MONTH, BGT_D_BUDGET_DEPT_YEAR_R_I_D.ADJUST_SCALE, BGT_D_BUDGET_DEPT_YEAR_R_I_D.BASE_ID, BGT_D_BUDGET_DEPT_YEAR_R_I_D.ID, BGT_D_BUDGET_MONTH_BUDGET_MONT.BUDGET_MONTH as BUDGET_MONTH_NAME, BGT_D_BUDGET_DEPT_YEAR_R_ID.ID as BASE_ID_NAME from BGT_D_BUDGET_DEPT_YEAR_R_I_D left join BGT_D_BUDGET_MONTH   BGT_D_BUDGET_MONTH_BUDGET_MONT on BGT_D_BUDGET_DEPT_YEAR_R_I_D.BUDGET_MONTH = BGT_D_BUDGET_MONTH_BUDGET_MONT.ID left join BGT_D_BUDGET_DEPT_YEAR_R_I   BGT_D_BUDGET_DEPT_YEAR_R_ID on BGT_D_BUDGET_DEPT_YEAR_R_I_D.BASE_ID = BGT_D_BUDGET_DEPT_YEAR_R_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_MONTH = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ADJUST_SCALE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_MONTH_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[] objs = new DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_D_BUDGET_DEPT_YEAR_R_I_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[] Query(CauseObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_D_BUDGET_DEPT_YEAR_R_I_D.BUDGET_MONTH, BGT_D_BUDGET_DEPT_YEAR_R_I_D.ADJUST_SCALE, BGT_D_BUDGET_DEPT_YEAR_R_I_D.BASE_ID, BGT_D_BUDGET_DEPT_YEAR_R_I_D.ID, BGT_D_BUDGET_MONTH_BUDGET_MONT.BUDGET_MONTH as BUDGET_MONTH_NAME, BGT_D_BUDGET_DEPT_YEAR_R_ID.ID as BASE_ID_NAME from BGT_D_BUDGET_DEPT_YEAR_R_I_D left join BGT_D_BUDGET_MONTH   BGT_D_BUDGET_MONTH_BUDGET_MONT on BGT_D_BUDGET_DEPT_YEAR_R_I_D.BUDGET_MONTH = BGT_D_BUDGET_MONTH_BUDGET_MONT.ID left join BGT_D_BUDGET_DEPT_YEAR_R_I   BGT_D_BUDGET_DEPT_YEAR_R_ID on BGT_D_BUDGET_DEPT_YEAR_R_I_D.BASE_ID = BGT_D_BUDGET_DEPT_YEAR_R_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_MONTH = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ADJUST_SCALE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_MONTH_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[] objs = new DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[] Query(CauseObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_D_BUDGET_DEPT_YEAR_R_I_D.BUDGET_MONTH, BGT_D_BUDGET_DEPT_YEAR_R_I_D.ADJUST_SCALE, BGT_D_BUDGET_DEPT_YEAR_R_I_D.BASE_ID, BGT_D_BUDGET_DEPT_YEAR_R_I_D.ID, BGT_D_BUDGET_MONTH_BUDGET_MONT.BUDGET_MONTH as BUDGET_MONTH_NAME, BGT_D_BUDGET_DEPT_YEAR_R_ID.ID as BASE_ID_NAME from BGT_D_BUDGET_DEPT_YEAR_R_I_D left join BGT_D_BUDGET_MONTH   BGT_D_BUDGET_MONTH_BUDGET_MONT on BGT_D_BUDGET_DEPT_YEAR_R_I_D.BUDGET_MONTH = BGT_D_BUDGET_MONTH_BUDGET_MONT.ID left join BGT_D_BUDGET_DEPT_YEAR_R_I   BGT_D_BUDGET_DEPT_YEAR_R_ID on BGT_D_BUDGET_DEPT_YEAR_R_I_D.BASE_ID = BGT_D_BUDGET_DEPT_YEAR_R_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_BUDGET_DEPT_YEAR_R_I_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_MONTH = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ADJUST_SCALE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_MONTH_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[] objs = new DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[] Query(CauseObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_D_BUDGET_DEPT_YEAR_R_I_D.BUDGET_MONTH, BGT_D_BUDGET_DEPT_YEAR_R_I_D.ADJUST_SCALE, BGT_D_BUDGET_DEPT_YEAR_R_I_D.BASE_ID, BGT_D_BUDGET_DEPT_YEAR_R_I_D.ID, BGT_D_BUDGET_MONTH_BUDGET_MONT.BUDGET_MONTH as BUDGET_MONTH_NAME, BGT_D_BUDGET_DEPT_YEAR_R_ID.ID as BASE_ID_NAME from BGT_D_BUDGET_DEPT_YEAR_R_I_D left join BGT_D_BUDGET_MONTH   BGT_D_BUDGET_MONTH_BUDGET_MONT on BGT_D_BUDGET_DEPT_YEAR_R_I_D.BUDGET_MONTH = BGT_D_BUDGET_MONTH_BUDGET_MONT.ID left join BGT_D_BUDGET_DEPT_YEAR_R_I   BGT_D_BUDGET_DEPT_YEAR_R_ID on BGT_D_BUDGET_DEPT_YEAR_R_I_D.BASE_ID = BGT_D_BUDGET_DEPT_YEAR_R_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_BUDGET_DEPT_YEAR_R_I_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_MONTH = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ADJUST_SCALE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_MONTH_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[] objs = new DisplayObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I_D obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("BUDGET_MONTH"))
			{
				strBuf.Add("  BGT_D_BUDGET_DEPT_YEAR_R_I_D.BUDGET_MONTH = :BUDGET_MONTH");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_MONTH";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_MONTH) ? string.Empty : obj.BUDGET_MONTH;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ADJUST_SCALE"))
			{
				strBuf.Add("  BGT_D_BUDGET_DEPT_YEAR_R_I_D.ADJUST_SCALE = :ADJUST_SCALE");
				param = new OracleParameter();
				param.ParameterName = ":ADJUST_SCALE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ADJUST_SCALE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  BGT_D_BUDGET_DEPT_YEAR_R_I_D.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
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
