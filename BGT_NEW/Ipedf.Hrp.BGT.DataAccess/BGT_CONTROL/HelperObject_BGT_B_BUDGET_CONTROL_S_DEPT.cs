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
	[CauseObject(typeof(CauseObject_BGT_B_BUDGET_CONTROL_S_DEPT))]
	public partial class HelperObject_BGT_B_BUDGET_CONTROL_S_DEPT
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_B_BUDGET_CONTROL_S_DEPT( ID, DEPT_ID, IS_EDIT, STAGE) values ( :ID, :DEPT_ID, :IS_EDIT, :STAGE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[4];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":DEPT_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.DEPT_ID == null ? String.Empty:obj.DEPT_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":IS_EDIT";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.IS_EDIT;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":STAGE";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.STAGE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_BUDGET_CONTROL_S_DEPT set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_BUDGET_CONTROL_S_DEPT where  ID = :ID ";
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
		public static EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT Get(EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, DEPT_ID, IS_EDIT, STAGE from BGT_B_BUDGET_CONTROL_S_DEPT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_EDIT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAGE = sqlReader.GetDecimal(3);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT[] objs = new EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT Get(EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, DEPT_ID, IS_EDIT, STAGE from BGT_B_BUDGET_CONTROL_S_DEPT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_EDIT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAGE = sqlReader.GetDecimal(3);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT[] objs = new EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_BUDGET_CONTROL_S_DEPT.ID, BGT_B_BUDGET_CONTROL_S_DEPT.DEPT_ID, BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT, BGT_B_BUDGET_CONTROL_S_DEPT.STAGE, BGT_D_BUDGET_DEPT_DEPT_ID.NAME as DEPT_ID_NAME, (case  when BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT = 1 then '是' when BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT = 2 then '否' else '' end ) as IS_EDIT_NAME from BGT_B_BUDGET_CONTROL_S_DEPT left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_DEPT_ID on BGT_B_BUDGET_CONTROL_S_DEPT.DEPT_ID = BGT_D_BUDGET_DEPT_DEPT_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_EDIT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAGE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_EDIT_NAME = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[] objs = new DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_BUDGET_CONTROL_S_DEPT cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_S_DEPT.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_S_DEPT", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_ID))
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_S_DEPT.DEPT_ID ").Append((cause.DEPT_ID.StartsWith("%") || cause.DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_S_DEPT", "DEPT_ID"));
			}
			if(cause.IS_EDIT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT = :IS_EDIT");
				param = new OracleParameter();
				param.ParameterName =":IS_EDIT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_EDIT;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_EDIT"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_S_DEPT", "IS_EDIT"));
			}
			if(cause.STAGE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_S_DEPT.STAGE = :STAGE");
				param = new OracleParameter();
				param.ParameterName =":STAGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STAGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAGE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_S_DEPT", "STAGE"));
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
		public static DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[] Query(CauseObject_BGT_B_BUDGET_CONTROL_S_DEPT cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_CONTROL_S_DEPT.ID, BGT_B_BUDGET_CONTROL_S_DEPT.DEPT_ID, BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT, BGT_B_BUDGET_CONTROL_S_DEPT.STAGE, BGT_D_BUDGET_DEPT_DEPT_ID.NAME as DEPT_ID_NAME, (case  when BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT = 1 then '是' when BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT = 2 then '否' else '' end ) as IS_EDIT_NAME from BGT_B_BUDGET_CONTROL_S_DEPT left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_DEPT_ID on BGT_B_BUDGET_CONTROL_S_DEPT.DEPT_ID = BGT_D_BUDGET_DEPT_DEPT_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_EDIT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAGE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_EDIT_NAME = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[] objs = new DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_BUDGET_CONTROL_S_DEPT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_BUDGET_CONTROL_S_DEPT where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[] Query(CauseObject_BGT_B_BUDGET_CONTROL_S_DEPT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_CONTROL_S_DEPT.ID, BGT_B_BUDGET_CONTROL_S_DEPT.DEPT_ID, BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT, BGT_B_BUDGET_CONTROL_S_DEPT.STAGE, BGT_D_BUDGET_DEPT_DEPT_ID.NAME as DEPT_ID_NAME, (case  when BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT = 1 then '是' when BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT = 2 then '否' else '' end ) as IS_EDIT_NAME from BGT_B_BUDGET_CONTROL_S_DEPT left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_DEPT_ID on BGT_B_BUDGET_CONTROL_S_DEPT.DEPT_ID = BGT_D_BUDGET_DEPT_DEPT_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_EDIT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAGE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_EDIT_NAME = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[] objs = new DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[] Query(CauseObject_BGT_B_BUDGET_CONTROL_S_DEPT cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_CONTROL_S_DEPT.ID, BGT_B_BUDGET_CONTROL_S_DEPT.DEPT_ID, BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT, BGT_B_BUDGET_CONTROL_S_DEPT.STAGE, BGT_D_BUDGET_DEPT_DEPT_ID.NAME as DEPT_ID_NAME, (case  when BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT = 1 then '是' when BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT = 2 then '否' else '' end ) as IS_EDIT_NAME from BGT_B_BUDGET_CONTROL_S_DEPT left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_DEPT_ID on BGT_B_BUDGET_CONTROL_S_DEPT.DEPT_ID = BGT_D_BUDGET_DEPT_DEPT_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_BUDGET_CONTROL_S_DEPT",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_EDIT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAGE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_EDIT_NAME = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[] objs = new DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[] Query(CauseObject_BGT_B_BUDGET_CONTROL_S_DEPT cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_CONTROL_S_DEPT.ID, BGT_B_BUDGET_CONTROL_S_DEPT.DEPT_ID, BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT, BGT_B_BUDGET_CONTROL_S_DEPT.STAGE, BGT_D_BUDGET_DEPT_DEPT_ID.NAME as DEPT_ID_NAME, (case  when BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT = 1 then '是' when BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT = 2 then '否' else '' end ) as IS_EDIT_NAME from BGT_B_BUDGET_CONTROL_S_DEPT left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_DEPT_ID on BGT_B_BUDGET_CONTROL_S_DEPT.DEPT_ID = BGT_D_BUDGET_DEPT_DEPT_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_BUDGET_CONTROL_S_DEPT",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEPT_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_EDIT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAGE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_EDIT_NAME = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[] objs = new DisplayObject_BGT_B_BUDGET_CONTROL_S_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_BUDGET_CONTROL_S_DEPT obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("DEPT_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_S_DEPT.DEPT_ID = :DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_ID) ? string.Empty : obj.DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_EDIT"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_S_DEPT.IS_EDIT = :IS_EDIT");
				param = new OracleParameter();
				param.ParameterName = ":IS_EDIT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_EDIT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STAGE"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_S_DEPT.STAGE = :STAGE");
				param = new OracleParameter();
				param.ParameterName = ":STAGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STAGE;
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
