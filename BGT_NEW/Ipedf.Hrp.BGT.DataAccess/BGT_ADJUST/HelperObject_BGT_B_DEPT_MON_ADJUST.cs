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
	[CauseObject(typeof(CauseObject_BGT_B_DEPT_MON_ADJUST))]
	public partial class HelperObject_BGT_B_DEPT_MON_ADJUST
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_DEPT_MON_ADJUST obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_B_DEPT_MON_ADJUST( BUDGET_DEPT_ID, BUDGET_CONTENTS_ID, ID, IS_FUNCTION, ADJUST_ID, STATE) values ( :BUDGET_DEPT_ID, :BUDGET_CONTENTS_ID, :ID, :IS_FUNCTION, :ADJUST_ID, :STATE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[6];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":BUDGET_DEPT_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.BUDGET_DEPT_ID == null ? String.Empty:obj.BUDGET_DEPT_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":BUDGET_CONTENTS_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.BUDGET_CONTENTS_ID == null ? String.Empty:obj.BUDGET_CONTENTS_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":IS_FUNCTION";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.IS_FUNCTION;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ADJUST_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ADJUST_ID == null ? String.Empty:obj.ADJUST_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":STATE";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.STATE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_DEPT_MON_ADJUST obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_DEPT_MON_ADJUST set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_DEPT_MON_ADJUST obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_DEPT_MON_ADJUST where  ID = :ID ";
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
		public static EntityObject_BGT_B_DEPT_MON_ADJUST Get(EntityObject_BGT_B_DEPT_MON_ADJUST obj)
		{
			
			//平台自动生成代码
			string sSql = "select  BUDGET_DEPT_ID, BUDGET_CONTENTS_ID, ID, IS_FUNCTION, ADJUST_ID, STATE from BGT_B_DEPT_MON_ADJUST where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_DEPT_MON_ADJUST dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_DEPT_MON_ADJUST();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BUDGET_CONTENTS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ADJUST_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_DEPT_MON_ADJUST[] objs = new EntityObject_BGT_B_DEPT_MON_ADJUST[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_DEPT_MON_ADJUST Get(EntityObject_BGT_B_DEPT_MON_ADJUST obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  BUDGET_DEPT_ID, BUDGET_CONTENTS_ID, ID, IS_FUNCTION, ADJUST_ID, STATE from BGT_B_DEPT_MON_ADJUST where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_DEPT_MON_ADJUST dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_DEPT_MON_ADJUST();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BUDGET_CONTENTS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ADJUST_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_DEPT_MON_ADJUST[] objs = new EntityObject_BGT_B_DEPT_MON_ADJUST[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_DEPT_MON_ADJUST[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_DEPT_MON_ADJUST.BUDGET_DEPT_ID, BGT_B_DEPT_MON_ADJUST.BUDGET_CONTENTS_ID, BGT_B_DEPT_MON_ADJUST.ID, BGT_B_DEPT_MON_ADJUST.IS_FUNCTION, BGT_B_DEPT_MON_ADJUST.ADJUST_ID, BGT_B_DEPT_MON_ADJUST.STATE, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, BGT_B_BUDGET_ADJUST_ADJUST_ID.ADJUST_CODE as ADJUST_ID_NAME, (case  when BGT_B_DEPT_MON_ADJUST.STATE = 0 then '默认值' when BGT_B_DEPT_MON_ADJUST.STATE = 1 then '编辑中' when BGT_B_DEPT_MON_ADJUST.STATE = 2 then '已提交' when BGT_B_DEPT_MON_ADJUST.STATE = 3 then '已审核' when BGT_B_DEPT_MON_ADJUST.STATE = 4 then '已归档' when BGT_B_DEPT_MON_ADJUST.STATE = 9 then '已作废' else '' end ) as STATE_NAME from BGT_B_DEPT_MON_ADJUST left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_DEPT_MON_ADJUST.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join BGT_B_BUDGET_ADJUST   BGT_B_BUDGET_ADJUST_ADJUST_ID on BGT_B_DEPT_MON_ADJUST.ADJUST_ID = BGT_B_BUDGET_ADJUST_ADJUST_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_DEPT_MON_ADJUST dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_MON_ADJUST();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BUDGET_CONTENTS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ADJUST_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADJUST_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATE_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_DEPT_MON_ADJUST[] objs = new DisplayObject_BGT_B_DEPT_MON_ADJUST[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_DEPT_MON_ADJUST cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.BUDGET_DEPT_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_DEPT_MON_ADJUST.BUDGET_DEPT_ID ").Append((cause.BUDGET_DEPT_ID.StartsWith("%") || cause.BUDGET_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_MON_ADJUST", "BUDGET_DEPT_ID"));
			}
			if(cause.BUDGET_CONTENTS_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_DEPT_MON_ADJUST.BUDGET_CONTENTS_ID ").Append((cause.BUDGET_CONTENTS_ID.StartsWith("%") || cause.BUDGET_CONTENTS_ID.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_CONTENTS_ID");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_CONTENTS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_CONTENTS_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_CONTENTS_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_MON_ADJUST", "BUDGET_CONTENTS_ID"));
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_DEPT_MON_ADJUST.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_MON_ADJUST", "ID"));
			}
			if(cause.IS_FUNCTION!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_MON_ADJUST.IS_FUNCTION = :IS_FUNCTION");
				param = new OracleParameter();
				param.ParameterName =":IS_FUNCTION";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_FUNCTION;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_FUNCTION"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_MON_ADJUST", "IS_FUNCTION"));
			}
			if(cause.ADJUST_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_DEPT_MON_ADJUST.ADJUST_ID ").Append((cause.ADJUST_ID.StartsWith("%") || cause.ADJUST_ID.EndsWith("%")) ? " like " : " = ").Append(" :ADJUST_ID");
				param = new OracleParameter();
				param.ParameterName =":ADJUST_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ADJUST_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADJUST_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_MON_ADJUST", "ADJUST_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_MON_ADJUST.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_MON_ADJUST", "STATE"));
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
		public static DisplayObject_BGT_B_DEPT_MON_ADJUST[] Query(CauseObject_BGT_B_DEPT_MON_ADJUST cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_MON_ADJUST.BUDGET_DEPT_ID, BGT_B_DEPT_MON_ADJUST.BUDGET_CONTENTS_ID, BGT_B_DEPT_MON_ADJUST.ID, BGT_B_DEPT_MON_ADJUST.IS_FUNCTION, BGT_B_DEPT_MON_ADJUST.ADJUST_ID, BGT_B_DEPT_MON_ADJUST.STATE, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, BGT_B_BUDGET_ADJUST_ADJUST_ID.ADJUST_CODE as ADJUST_ID_NAME, (case  when BGT_B_DEPT_MON_ADJUST.STATE = 0 then '默认值' when BGT_B_DEPT_MON_ADJUST.STATE = 1 then '编辑中' when BGT_B_DEPT_MON_ADJUST.STATE = 2 then '已提交' when BGT_B_DEPT_MON_ADJUST.STATE = 3 then '已审核' when BGT_B_DEPT_MON_ADJUST.STATE = 4 then '已归档' when BGT_B_DEPT_MON_ADJUST.STATE = 9 then '已作废' else '' end ) as STATE_NAME from BGT_B_DEPT_MON_ADJUST left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_DEPT_MON_ADJUST.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join BGT_B_BUDGET_ADJUST   BGT_B_BUDGET_ADJUST_ADJUST_ID on BGT_B_DEPT_MON_ADJUST.ADJUST_ID = BGT_B_BUDGET_ADJUST_ADJUST_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_DEPT_MON_ADJUST dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_MON_ADJUST();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BUDGET_CONTENTS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ADJUST_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADJUST_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATE_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_DEPT_MON_ADJUST[] objs = new DisplayObject_BGT_B_DEPT_MON_ADJUST[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_DEPT_MON_ADJUST cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_DEPT_MON_ADJUST where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_DEPT_MON_ADJUST[] Query(CauseObject_BGT_B_DEPT_MON_ADJUST cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_MON_ADJUST.BUDGET_DEPT_ID, BGT_B_DEPT_MON_ADJUST.BUDGET_CONTENTS_ID, BGT_B_DEPT_MON_ADJUST.ID, BGT_B_DEPT_MON_ADJUST.IS_FUNCTION, BGT_B_DEPT_MON_ADJUST.ADJUST_ID, BGT_B_DEPT_MON_ADJUST.STATE, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, BGT_B_BUDGET_ADJUST_ADJUST_ID.ADJUST_CODE as ADJUST_ID_NAME, (case  when BGT_B_DEPT_MON_ADJUST.STATE = 0 then '默认值' when BGT_B_DEPT_MON_ADJUST.STATE = 1 then '编辑中' when BGT_B_DEPT_MON_ADJUST.STATE = 2 then '已提交' when BGT_B_DEPT_MON_ADJUST.STATE = 3 then '已审核' when BGT_B_DEPT_MON_ADJUST.STATE = 4 then '已归档' when BGT_B_DEPT_MON_ADJUST.STATE = 9 then '已作废' else '' end ) as STATE_NAME from BGT_B_DEPT_MON_ADJUST left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_DEPT_MON_ADJUST.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join BGT_B_BUDGET_ADJUST   BGT_B_BUDGET_ADJUST_ADJUST_ID on BGT_B_DEPT_MON_ADJUST.ADJUST_ID = BGT_B_BUDGET_ADJUST_ADJUST_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_DEPT_MON_ADJUST dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_MON_ADJUST();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BUDGET_CONTENTS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ADJUST_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADJUST_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATE_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_DEPT_MON_ADJUST[] objs = new DisplayObject_BGT_B_DEPT_MON_ADJUST[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_DEPT_MON_ADJUST[] Query(CauseObject_BGT_B_DEPT_MON_ADJUST cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_MON_ADJUST.BUDGET_DEPT_ID, BGT_B_DEPT_MON_ADJUST.BUDGET_CONTENTS_ID, BGT_B_DEPT_MON_ADJUST.ID, BGT_B_DEPT_MON_ADJUST.IS_FUNCTION, BGT_B_DEPT_MON_ADJUST.ADJUST_ID, BGT_B_DEPT_MON_ADJUST.STATE, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, BGT_B_BUDGET_ADJUST_ADJUST_ID.ADJUST_CODE as ADJUST_ID_NAME, (case  when BGT_B_DEPT_MON_ADJUST.STATE = 0 then '默认值' when BGT_B_DEPT_MON_ADJUST.STATE = 1 then '编辑中' when BGT_B_DEPT_MON_ADJUST.STATE = 2 then '已提交' when BGT_B_DEPT_MON_ADJUST.STATE = 3 then '已审核' when BGT_B_DEPT_MON_ADJUST.STATE = 4 then '已归档' when BGT_B_DEPT_MON_ADJUST.STATE = 9 then '已作废' else '' end ) as STATE_NAME from BGT_B_DEPT_MON_ADJUST left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_DEPT_MON_ADJUST.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join BGT_B_BUDGET_ADJUST   BGT_B_BUDGET_ADJUST_ADJUST_ID on BGT_B_DEPT_MON_ADJUST.ADJUST_ID = BGT_B_BUDGET_ADJUST_ADJUST_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_DEPT_MON_ADJUST",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_DEPT_MON_ADJUST dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_MON_ADJUST();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BUDGET_CONTENTS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ADJUST_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADJUST_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATE_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_DEPT_MON_ADJUST[] objs = new DisplayObject_BGT_B_DEPT_MON_ADJUST[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_DEPT_MON_ADJUST[] Query(CauseObject_BGT_B_DEPT_MON_ADJUST cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_MON_ADJUST.BUDGET_DEPT_ID, BGT_B_DEPT_MON_ADJUST.BUDGET_CONTENTS_ID, BGT_B_DEPT_MON_ADJUST.ID, BGT_B_DEPT_MON_ADJUST.IS_FUNCTION, BGT_B_DEPT_MON_ADJUST.ADJUST_ID, BGT_B_DEPT_MON_ADJUST.STATE, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, BGT_B_BUDGET_ADJUST_ADJUST_ID.ADJUST_CODE as ADJUST_ID_NAME, (case  when BGT_B_DEPT_MON_ADJUST.STATE = 0 then '默认值' when BGT_B_DEPT_MON_ADJUST.STATE = 1 then '编辑中' when BGT_B_DEPT_MON_ADJUST.STATE = 2 then '已提交' when BGT_B_DEPT_MON_ADJUST.STATE = 3 then '已审核' when BGT_B_DEPT_MON_ADJUST.STATE = 4 then '已归档' when BGT_B_DEPT_MON_ADJUST.STATE = 9 then '已作废' else '' end ) as STATE_NAME from BGT_B_DEPT_MON_ADJUST left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_DEPT_MON_ADJUST.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join BGT_B_BUDGET_ADJUST   BGT_B_BUDGET_ADJUST_ADJUST_ID on BGT_B_DEPT_MON_ADJUST.ADJUST_ID = BGT_B_BUDGET_ADJUST_ADJUST_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_DEPT_MON_ADJUST",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_DEPT_MON_ADJUST dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_MON_ADJUST();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BUDGET_CONTENTS_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ADJUST_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADJUST_ID_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATE_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_DEPT_MON_ADJUST[] objs = new DisplayObject_BGT_B_DEPT_MON_ADJUST[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_DEPT_MON_ADJUST obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("BUDGET_DEPT_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_MON_ADJUST.BUDGET_DEPT_ID = :BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_DEPT_ID) ? string.Empty : obj.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_CONTENTS_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_MON_ADJUST.BUDGET_CONTENTS_ID = :BUDGET_CONTENTS_ID");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_CONTENTS_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_CONTENTS_ID) ? string.Empty : obj.BUDGET_CONTENTS_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_FUNCTION"))
			{
				strBuf.Add("  BGT_B_DEPT_MON_ADJUST.IS_FUNCTION = :IS_FUNCTION");
				param = new OracleParameter();
				param.ParameterName = ":IS_FUNCTION";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_FUNCTION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ADJUST_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_MON_ADJUST.ADJUST_ID = :ADJUST_ID");
				param = new OracleParameter();
				param.ParameterName = ":ADJUST_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ADJUST_ID) ? string.Empty : obj.ADJUST_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  BGT_B_DEPT_MON_ADJUST.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
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
