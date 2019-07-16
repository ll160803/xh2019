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
	[CauseObject(typeof(CauseObject_BGT_D_BUDGET_T_D))]
	public partial class HelperObject_BGT_D_BUDGET_T_D
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_D_BUDGET_T_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_D_BUDGET_T_D( ID, CALCULATE_METHOD_ID, CONSULT, BASE_ID, ITEM_ID, CALCULATE_INDEX, PREPARE_METHOD_ID, CALCULATE_FORMULA) values ( :ID, :CALCULATE_METHOD_ID, :CONSULT, :BASE_ID, :ITEM_ID, :CALCULATE_INDEX, :PREPARE_METHOD_ID, :CALCULATE_FORMULA)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[8];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":CALCULATE_METHOD_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.CALCULATE_METHOD_ID == null ? String.Empty:obj.CALCULATE_METHOD_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CONSULT";
			parameters[2].Size = 200;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.CONSULT == null ? String.Empty:obj.CONSULT;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":BASE_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ITEM_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ITEM_ID == null ? String.Empty:obj.ITEM_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":CALCULATE_INDEX";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.CALCULATE_INDEX;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":PREPARE_METHOD_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.PREPARE_METHOD_ID == null ? String.Empty:obj.PREPARE_METHOD_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CALCULATE_FORMULA";
			parameters[7].Size = 200;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.CALCULATE_FORMULA == null ? String.Empty:obj.CALCULATE_FORMULA;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_D_BUDGET_T_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_D_BUDGET_T_D set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_D_BUDGET_T_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_D_BUDGET_T_D where  ID = :ID ";
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
		public static EntityObject_BGT_D_BUDGET_T_D Get(EntityObject_BGT_D_BUDGET_T_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, CALCULATE_METHOD_ID, CONSULT, BASE_ID, ITEM_ID, CALCULATE_INDEX, PREPARE_METHOD_ID, CALCULATE_FORMULA from BGT_D_BUDGET_T_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_D_BUDGET_T_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_D_BUDGET_T_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CALCULATE_METHOD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CONSULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CALCULATE_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREPARE_METHOD_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CALCULATE_FORMULA = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_D_BUDGET_T_D[] objs = new EntityObject_BGT_D_BUDGET_T_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_D_BUDGET_T_D Get(EntityObject_BGT_D_BUDGET_T_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, CALCULATE_METHOD_ID, CONSULT, BASE_ID, ITEM_ID, CALCULATE_INDEX, PREPARE_METHOD_ID, CALCULATE_FORMULA from BGT_D_BUDGET_T_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_D_BUDGET_T_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_D_BUDGET_T_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CALCULATE_METHOD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CONSULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CALCULATE_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREPARE_METHOD_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CALCULATE_FORMULA = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_D_BUDGET_T_D[] objs = new EntityObject_BGT_D_BUDGET_T_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_D_BUDGET_T_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_D_BUDGET_T_D.ID, BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID, BGT_D_BUDGET_T_D.CONSULT, BGT_D_BUDGET_T_D.BASE_ID, BGT_D_BUDGET_T_D.ITEM_ID, BGT_D_BUDGET_T_D.CALCULATE_INDEX, BGT_D_BUDGET_T_D.PREPARE_METHOD_ID, BGT_D_BUDGET_T_D.CALCULATE_FORMULA, COM_TYPE_CALCULATE_METHOD_ID.NAME as CALCULATE_METHOD_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, COM_TYPE_PREPARE_METHOD_ID.NAME as PREPARE_METHOD_ID_NAME from BGT_D_BUDGET_T_D left join COM_TYPE   COM_TYPE_CALCULATE_METHOD_ID on BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID = COM_TYPE_CALCULATE_METHOD_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_D_BUDGET_T_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join COM_TYPE   COM_TYPE_PREPARE_METHOD_ID on BGT_D_BUDGET_T_D.PREPARE_METHOD_ID = COM_TYPE_PREPARE_METHOD_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_D_BUDGET_T_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_T_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CALCULATE_METHOD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CONSULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CALCULATE_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREPARE_METHOD_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CALCULATE_FORMULA = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CALCULATE_METHOD_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PREPARE_METHOD_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_BUDGET_T_D[] objs = new DisplayObject_BGT_D_BUDGET_T_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_D_BUDGET_T_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_BUDGET_T_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_T_D", "ID"));
			}
			if(cause.CALCULATE_METHOD_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID ").Append((cause.CALCULATE_METHOD_ID.StartsWith("%") || cause.CALCULATE_METHOD_ID.EndsWith("%")) ? " like " : " = ").Append(" :CALCULATE_METHOD_ID");
				param = new OracleParameter();
				param.ParameterName =":CALCULATE_METHOD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CALCULATE_METHOD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CALCULATE_METHOD_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_T_D", "CALCULATE_METHOD_ID"));
			}
			if(cause.CONSULT!= string.Empty)
			{
				strBuf.Append(" And BGT_D_BUDGET_T_D.CONSULT ").Append((cause.CONSULT.StartsWith("%") || cause.CONSULT.EndsWith("%")) ? " like " : " = ").Append(" :CONSULT");
				param = new OracleParameter();
				param.ParameterName =":CONSULT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.CONSULT;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONSULT"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_T_D", "CONSULT"));
			}
			if(cause.BASE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_BUDGET_T_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_T_D", "BASE_ID"));
			}
			if(cause.ITEM_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_BUDGET_T_D.ITEM_ID ").Append((cause.ITEM_ID.StartsWith("%") || cause.ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_T_D", "ITEM_ID"));
			}
			if(cause.CALCULATE_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_D_BUDGET_T_D.CALCULATE_INDEX = :CALCULATE_INDEX");
				param = new OracleParameter();
				param.ParameterName =":CALCULATE_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CALCULATE_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("CALCULATE_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_T_D", "CALCULATE_INDEX"));
			}
			if(cause.PREPARE_METHOD_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_BUDGET_T_D.PREPARE_METHOD_ID ").Append((cause.PREPARE_METHOD_ID.StartsWith("%") || cause.PREPARE_METHOD_ID.EndsWith("%")) ? " like " : " = ").Append(" :PREPARE_METHOD_ID");
				param = new OracleParameter();
				param.ParameterName =":PREPARE_METHOD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PREPARE_METHOD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PREPARE_METHOD_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_T_D", "PREPARE_METHOD_ID"));
			}
			if(cause.CALCULATE_FORMULA!= string.Empty)
			{
				strBuf.Append(" And BGT_D_BUDGET_T_D.CALCULATE_FORMULA ").Append((cause.CALCULATE_FORMULA.StartsWith("%") || cause.CALCULATE_FORMULA.EndsWith("%")) ? " like " : " = ").Append(" :CALCULATE_FORMULA");
				param = new OracleParameter();
				param.ParameterName =":CALCULATE_FORMULA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.CALCULATE_FORMULA;
				paramList.Add(param);
			}
			if (cause.HasINValue("CALCULATE_FORMULA"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_T_D", "CALCULATE_FORMULA"));
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
		public static DisplayObject_BGT_D_BUDGET_T_D[] Query(CauseObject_BGT_D_BUDGET_T_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_D_BUDGET_T_D.ID, BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID, BGT_D_BUDGET_T_D.CONSULT, BGT_D_BUDGET_T_D.BASE_ID, BGT_D_BUDGET_T_D.ITEM_ID, BGT_D_BUDGET_T_D.CALCULATE_INDEX, BGT_D_BUDGET_T_D.PREPARE_METHOD_ID, BGT_D_BUDGET_T_D.CALCULATE_FORMULA, COM_TYPE_CALCULATE_METHOD_ID.NAME as CALCULATE_METHOD_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, COM_TYPE_PREPARE_METHOD_ID.NAME as PREPARE_METHOD_ID_NAME from BGT_D_BUDGET_T_D left join COM_TYPE   COM_TYPE_CALCULATE_METHOD_ID on BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID = COM_TYPE_CALCULATE_METHOD_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_D_BUDGET_T_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join COM_TYPE   COM_TYPE_PREPARE_METHOD_ID on BGT_D_BUDGET_T_D.PREPARE_METHOD_ID = COM_TYPE_PREPARE_METHOD_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_D_BUDGET_T_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_T_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CALCULATE_METHOD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CONSULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CALCULATE_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREPARE_METHOD_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CALCULATE_FORMULA = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CALCULATE_METHOD_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PREPARE_METHOD_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_BUDGET_T_D[] objs = new DisplayObject_BGT_D_BUDGET_T_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_D_BUDGET_T_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_D_BUDGET_T_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_D_BUDGET_T_D[] Query(CauseObject_BGT_D_BUDGET_T_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_D_BUDGET_T_D.ID, BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID, BGT_D_BUDGET_T_D.CONSULT, BGT_D_BUDGET_T_D.BASE_ID, BGT_D_BUDGET_T_D.ITEM_ID, BGT_D_BUDGET_T_D.CALCULATE_INDEX, BGT_D_BUDGET_T_D.PREPARE_METHOD_ID, BGT_D_BUDGET_T_D.CALCULATE_FORMULA, COM_TYPE_CALCULATE_METHOD_ID.NAME as CALCULATE_METHOD_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, COM_TYPE_PREPARE_METHOD_ID.NAME as PREPARE_METHOD_ID_NAME from BGT_D_BUDGET_T_D left join COM_TYPE   COM_TYPE_CALCULATE_METHOD_ID on BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID = COM_TYPE_CALCULATE_METHOD_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_D_BUDGET_T_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join COM_TYPE   COM_TYPE_PREPARE_METHOD_ID on BGT_D_BUDGET_T_D.PREPARE_METHOD_ID = COM_TYPE_PREPARE_METHOD_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_D_BUDGET_T_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_T_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CALCULATE_METHOD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CONSULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CALCULATE_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREPARE_METHOD_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CALCULATE_FORMULA = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CALCULATE_METHOD_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PREPARE_METHOD_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_D_BUDGET_T_D[] objs = new DisplayObject_BGT_D_BUDGET_T_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_D_BUDGET_T_D[] Query(CauseObject_BGT_D_BUDGET_T_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_D_BUDGET_T_D.ID, BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID, BGT_D_BUDGET_T_D.CONSULT, BGT_D_BUDGET_T_D.BASE_ID, BGT_D_BUDGET_T_D.ITEM_ID, BGT_D_BUDGET_T_D.CALCULATE_INDEX, BGT_D_BUDGET_T_D.PREPARE_METHOD_ID, BGT_D_BUDGET_T_D.CALCULATE_FORMULA, COM_TYPE_CALCULATE_METHOD_ID.NAME as CALCULATE_METHOD_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, COM_TYPE_PREPARE_METHOD_ID.NAME as PREPARE_METHOD_ID_NAME from BGT_D_BUDGET_T_D left join COM_TYPE   COM_TYPE_CALCULATE_METHOD_ID on BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID = COM_TYPE_CALCULATE_METHOD_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_D_BUDGET_T_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join COM_TYPE   COM_TYPE_PREPARE_METHOD_ID on BGT_D_BUDGET_T_D.PREPARE_METHOD_ID = COM_TYPE_PREPARE_METHOD_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_BUDGET_T_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_D_BUDGET_T_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_T_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CALCULATE_METHOD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CONSULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CALCULATE_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREPARE_METHOD_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CALCULATE_FORMULA = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CALCULATE_METHOD_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PREPARE_METHOD_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_BUDGET_T_D[] objs = new DisplayObject_BGT_D_BUDGET_T_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_D_BUDGET_T_D[] Query(CauseObject_BGT_D_BUDGET_T_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_D_BUDGET_T_D.ID, BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID, BGT_D_BUDGET_T_D.CONSULT, BGT_D_BUDGET_T_D.BASE_ID, BGT_D_BUDGET_T_D.ITEM_ID, BGT_D_BUDGET_T_D.CALCULATE_INDEX, BGT_D_BUDGET_T_D.PREPARE_METHOD_ID, BGT_D_BUDGET_T_D.CALCULATE_FORMULA, COM_TYPE_CALCULATE_METHOD_ID.NAME as CALCULATE_METHOD_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, COM_TYPE_PREPARE_METHOD_ID.NAME as PREPARE_METHOD_ID_NAME from BGT_D_BUDGET_T_D left join COM_TYPE   COM_TYPE_CALCULATE_METHOD_ID on BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID = COM_TYPE_CALCULATE_METHOD_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_D_BUDGET_T_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join COM_TYPE   COM_TYPE_PREPARE_METHOD_ID on BGT_D_BUDGET_T_D.PREPARE_METHOD_ID = COM_TYPE_PREPARE_METHOD_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_BUDGET_T_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_D_BUDGET_T_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_T_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CALCULATE_METHOD_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CONSULT = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CALCULATE_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PREPARE_METHOD_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CALCULATE_FORMULA = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CALCULATE_METHOD_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PREPARE_METHOD_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_D_BUDGET_T_D[] objs = new DisplayObject_BGT_D_BUDGET_T_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_D_BUDGET_T_D obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CALCULATE_METHOD_ID"))
			{
				strBuf.Add("  BGT_D_BUDGET_T_D.CALCULATE_METHOD_ID = :CALCULATE_METHOD_ID");
				param = new OracleParameter();
				param.ParameterName = ":CALCULATE_METHOD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CALCULATE_METHOD_ID) ? string.Empty : obj.CALCULATE_METHOD_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONSULT"))
			{
				strBuf.Add("  BGT_D_BUDGET_T_D.CONSULT = :CONSULT");
				param = new OracleParameter();
				param.ParameterName = ":CONSULT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.CONSULT) ? string.Empty : obj.CONSULT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  BGT_D_BUDGET_T_D.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_ID"))
			{
				strBuf.Add("  BGT_D_BUDGET_T_D.ITEM_ID = :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_ID) ? string.Empty : obj.ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CALCULATE_INDEX"))
			{
				strBuf.Add("  BGT_D_BUDGET_T_D.CALCULATE_INDEX = :CALCULATE_INDEX");
				param = new OracleParameter();
				param.ParameterName = ":CALCULATE_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CALCULATE_INDEX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PREPARE_METHOD_ID"))
			{
				strBuf.Add("  BGT_D_BUDGET_T_D.PREPARE_METHOD_ID = :PREPARE_METHOD_ID");
				param = new OracleParameter();
				param.ParameterName = ":PREPARE_METHOD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PREPARE_METHOD_ID) ? string.Empty : obj.PREPARE_METHOD_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CALCULATE_FORMULA"))
			{
				strBuf.Add("  BGT_D_BUDGET_T_D.CALCULATE_FORMULA = :CALCULATE_FORMULA");
				param = new OracleParameter();
				param.ParameterName = ":CALCULATE_FORMULA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.CALCULATE_FORMULA) ? string.Empty : obj.CALCULATE_FORMULA;
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
