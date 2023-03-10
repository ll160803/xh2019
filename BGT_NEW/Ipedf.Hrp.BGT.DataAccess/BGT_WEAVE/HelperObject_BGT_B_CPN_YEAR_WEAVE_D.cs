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
	[CauseObject(typeof(CauseObject_BGT_B_CPN_YEAR_WEAVE_D))]
	public partial class HelperObject_BGT_B_CPN_YEAR_WEAVE_D
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_CPN_YEAR_WEAVE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_B_CPN_YEAR_WEAVE_D( ID, CONSULT, BASE_ID, ITEM_VALUE, BUDGET_BASE, ITEM_ID, UNIT_ID, ITEM_TYPE_ID, TEMPLET_ITEM_ID) values ( :ID, :CONSULT, :BASE_ID, :ITEM_VALUE, :BUDGET_BASE, :ITEM_ID, :UNIT_ID, :ITEM_TYPE_ID, :TEMPLET_ITEM_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[9];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":CONSULT";
			parameters[1].Size = 200;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.CONSULT == null ? String.Empty:obj.CONSULT;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":BASE_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ITEM_VALUE";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.ITEM_VALUE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":BUDGET_BASE";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.BUDGET_BASE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ITEM_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.ITEM_ID == null ? String.Empty:obj.ITEM_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":UNIT_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.UNIT_ID == null ? String.Empty:obj.UNIT_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ITEM_TYPE_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.ITEM_TYPE_ID == null ? String.Empty:obj.ITEM_TYPE_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":TEMPLET_ITEM_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.TEMPLET_ITEM_ID == null ? String.Empty:obj.TEMPLET_ITEM_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_CPN_YEAR_WEAVE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_CPN_YEAR_WEAVE_D set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_CPN_YEAR_WEAVE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_CPN_YEAR_WEAVE_D where  ID = :ID ";
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
		public static EntityObject_BGT_B_CPN_YEAR_WEAVE_D Get(EntityObject_BGT_B_CPN_YEAR_WEAVE_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, CONSULT, BASE_ID, ITEM_VALUE, BUDGET_BASE, ITEM_ID, UNIT_ID, ITEM_TYPE_ID, TEMPLET_ITEM_ID from BGT_B_CPN_YEAR_WEAVE_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_CPN_YEAR_WEAVE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_CPN_YEAR_WEAVE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONSULT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ITEM_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_BASE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.UNIT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.TEMPLET_ITEM_ID = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_CPN_YEAR_WEAVE_D[] objs = new EntityObject_BGT_B_CPN_YEAR_WEAVE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_CPN_YEAR_WEAVE_D Get(EntityObject_BGT_B_CPN_YEAR_WEAVE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, CONSULT, BASE_ID, ITEM_VALUE, BUDGET_BASE, ITEM_ID, UNIT_ID, ITEM_TYPE_ID, TEMPLET_ITEM_ID from BGT_B_CPN_YEAR_WEAVE_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_CPN_YEAR_WEAVE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_CPN_YEAR_WEAVE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONSULT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ITEM_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_BASE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.UNIT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.TEMPLET_ITEM_ID = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_CPN_YEAR_WEAVE_D[] objs = new EntityObject_BGT_B_CPN_YEAR_WEAVE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_CPN_YEAR_WEAVE_D.ID, BGT_B_CPN_YEAR_WEAVE_D.CONSULT, BGT_B_CPN_YEAR_WEAVE_D.BASE_ID, BGT_B_CPN_YEAR_WEAVE_D.ITEM_VALUE, BGT_B_CPN_YEAR_WEAVE_D.BUDGET_BASE, BGT_B_CPN_YEAR_WEAVE_D.ITEM_ID, BGT_B_CPN_YEAR_WEAVE_D.UNIT_ID, BGT_B_CPN_YEAR_WEAVE_D.ITEM_TYPE_ID, BGT_B_CPN_YEAR_WEAVE_D.TEMPLET_ITEM_ID, BILL_WORK_FLOW_BASE_ID.ID as BASE_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from BGT_B_CPN_YEAR_WEAVE_D left join BILL_WORK_FLOW   BILL_WORK_FLOW_BASE_ID on BGT_B_CPN_YEAR_WEAVE_D.BASE_ID = BILL_WORK_FLOW_BASE_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_B_CPN_YEAR_WEAVE_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_CPN_YEAR_WEAVE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_YEAR_WEAVE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONSULT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ITEM_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_BASE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.UNIT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.TEMPLET_ITEM_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[] objs = new DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_CPN_YEAR_WEAVE_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_YEAR_WEAVE_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_YEAR_WEAVE_D", "ID"));
			}
			if(cause.CONSULT!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_YEAR_WEAVE_D.CONSULT ").Append((cause.CONSULT.StartsWith("%") || cause.CONSULT.EndsWith("%")) ? " like " : " = ").Append(" :CONSULT");
				param = new OracleParameter();
				param.ParameterName =":CONSULT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.CONSULT;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONSULT"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_YEAR_WEAVE_D", "CONSULT"));
			}
			if(cause.BASE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_YEAR_WEAVE_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_YEAR_WEAVE_D", "BASE_ID"));
			}
			if(cause.ITEM_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_YEAR_WEAVE_D.ITEM_VALUE = :ITEM_VALUE");
				param = new OracleParameter();
				param.ParameterName =":ITEM_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ITEM_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_YEAR_WEAVE_D", "ITEM_VALUE"));
			}
			if(cause.BUDGET_BASE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_YEAR_WEAVE_D.BUDGET_BASE = :BUDGET_BASE");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_BASE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.BUDGET_BASE;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_BASE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_YEAR_WEAVE_D", "BUDGET_BASE"));
			}
			if(cause.ITEM_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_YEAR_WEAVE_D.ITEM_ID ").Append((cause.ITEM_ID.StartsWith("%") || cause.ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_YEAR_WEAVE_D", "ITEM_ID"));
			}
			if(cause.UNIT_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_YEAR_WEAVE_D.UNIT_ID ").Append((cause.UNIT_ID.StartsWith("%") || cause.UNIT_ID.EndsWith("%")) ? " like " : " = ").Append(" :UNIT_ID");
				param = new OracleParameter();
				param.ParameterName =":UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.UNIT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNIT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_YEAR_WEAVE_D", "UNIT_ID"));
			}
			if(cause.ITEM_TYPE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_YEAR_WEAVE_D.ITEM_TYPE_ID ").Append((cause.ITEM_TYPE_ID.StartsWith("%") || cause.ITEM_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_YEAR_WEAVE_D", "ITEM_TYPE_ID"));
			}
			if(cause.TEMPLET_ITEM_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_YEAR_WEAVE_D.TEMPLET_ITEM_ID ").Append((cause.TEMPLET_ITEM_ID.StartsWith("%") || cause.TEMPLET_ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :TEMPLET_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":TEMPLET_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.TEMPLET_ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TEMPLET_ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_YEAR_WEAVE_D", "TEMPLET_ITEM_ID"));
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
		public static DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[] Query(CauseObject_BGT_B_CPN_YEAR_WEAVE_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_YEAR_WEAVE_D.ID, BGT_B_CPN_YEAR_WEAVE_D.CONSULT, BGT_B_CPN_YEAR_WEAVE_D.BASE_ID, BGT_B_CPN_YEAR_WEAVE_D.ITEM_VALUE, BGT_B_CPN_YEAR_WEAVE_D.BUDGET_BASE, BGT_B_CPN_YEAR_WEAVE_D.ITEM_ID, BGT_B_CPN_YEAR_WEAVE_D.UNIT_ID, BGT_B_CPN_YEAR_WEAVE_D.ITEM_TYPE_ID, BGT_B_CPN_YEAR_WEAVE_D.TEMPLET_ITEM_ID, BILL_WORK_FLOW_BASE_ID.ID as BASE_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from BGT_B_CPN_YEAR_WEAVE_D left join BILL_WORK_FLOW   BILL_WORK_FLOW_BASE_ID on BGT_B_CPN_YEAR_WEAVE_D.BASE_ID = BILL_WORK_FLOW_BASE_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_B_CPN_YEAR_WEAVE_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_CPN_YEAR_WEAVE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_YEAR_WEAVE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONSULT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ITEM_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_BASE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.UNIT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.TEMPLET_ITEM_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[] objs = new DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_CPN_YEAR_WEAVE_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_CPN_YEAR_WEAVE_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[] Query(CauseObject_BGT_B_CPN_YEAR_WEAVE_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_YEAR_WEAVE_D.ID, BGT_B_CPN_YEAR_WEAVE_D.CONSULT, BGT_B_CPN_YEAR_WEAVE_D.BASE_ID, BGT_B_CPN_YEAR_WEAVE_D.ITEM_VALUE, BGT_B_CPN_YEAR_WEAVE_D.BUDGET_BASE, BGT_B_CPN_YEAR_WEAVE_D.ITEM_ID, BGT_B_CPN_YEAR_WEAVE_D.UNIT_ID, BGT_B_CPN_YEAR_WEAVE_D.ITEM_TYPE_ID, BGT_B_CPN_YEAR_WEAVE_D.TEMPLET_ITEM_ID, BILL_WORK_FLOW_BASE_ID.ID as BASE_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from BGT_B_CPN_YEAR_WEAVE_D left join BILL_WORK_FLOW   BILL_WORK_FLOW_BASE_ID on BGT_B_CPN_YEAR_WEAVE_D.BASE_ID = BILL_WORK_FLOW_BASE_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_B_CPN_YEAR_WEAVE_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_CPN_YEAR_WEAVE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_YEAR_WEAVE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONSULT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ITEM_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_BASE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.UNIT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.TEMPLET_ITEM_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[] objs = new DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[] Query(CauseObject_BGT_B_CPN_YEAR_WEAVE_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_YEAR_WEAVE_D.ID, BGT_B_CPN_YEAR_WEAVE_D.CONSULT, BGT_B_CPN_YEAR_WEAVE_D.BASE_ID, BGT_B_CPN_YEAR_WEAVE_D.ITEM_VALUE, BGT_B_CPN_YEAR_WEAVE_D.BUDGET_BASE, BGT_B_CPN_YEAR_WEAVE_D.ITEM_ID, BGT_B_CPN_YEAR_WEAVE_D.UNIT_ID, BGT_B_CPN_YEAR_WEAVE_D.ITEM_TYPE_ID, BGT_B_CPN_YEAR_WEAVE_D.TEMPLET_ITEM_ID, BILL_WORK_FLOW_BASE_ID.ID as BASE_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from BGT_B_CPN_YEAR_WEAVE_D left join BILL_WORK_FLOW   BILL_WORK_FLOW_BASE_ID on BGT_B_CPN_YEAR_WEAVE_D.BASE_ID = BILL_WORK_FLOW_BASE_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_B_CPN_YEAR_WEAVE_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_CPN_YEAR_WEAVE_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_CPN_YEAR_WEAVE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_YEAR_WEAVE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONSULT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ITEM_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_BASE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.UNIT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.TEMPLET_ITEM_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[] objs = new DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[] Query(CauseObject_BGT_B_CPN_YEAR_WEAVE_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_YEAR_WEAVE_D.ID, BGT_B_CPN_YEAR_WEAVE_D.CONSULT, BGT_B_CPN_YEAR_WEAVE_D.BASE_ID, BGT_B_CPN_YEAR_WEAVE_D.ITEM_VALUE, BGT_B_CPN_YEAR_WEAVE_D.BUDGET_BASE, BGT_B_CPN_YEAR_WEAVE_D.ITEM_ID, BGT_B_CPN_YEAR_WEAVE_D.UNIT_ID, BGT_B_CPN_YEAR_WEAVE_D.ITEM_TYPE_ID, BGT_B_CPN_YEAR_WEAVE_D.TEMPLET_ITEM_ID, BILL_WORK_FLOW_BASE_ID.ID as BASE_ID_NAME, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from BGT_B_CPN_YEAR_WEAVE_D left join BILL_WORK_FLOW   BILL_WORK_FLOW_BASE_ID on BGT_B_CPN_YEAR_WEAVE_D.BASE_ID = BILL_WORK_FLOW_BASE_ID.ID left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_B_CPN_YEAR_WEAVE_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_CPN_YEAR_WEAVE_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_CPN_YEAR_WEAVE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_YEAR_WEAVE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONSULT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ITEM_VALUE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_BASE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.UNIT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.TEMPLET_ITEM_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[] objs = new DisplayObject_BGT_B_CPN_YEAR_WEAVE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_CPN_YEAR_WEAVE_D obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CONSULT"))
			{
				strBuf.Add("  BGT_B_CPN_YEAR_WEAVE_D.CONSULT = :CONSULT");
				param = new OracleParameter();
				param.ParameterName = ":CONSULT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.CONSULT) ? string.Empty : obj.CONSULT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  BGT_B_CPN_YEAR_WEAVE_D.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_VALUE"))
			{
				strBuf.Add("  BGT_B_CPN_YEAR_WEAVE_D.ITEM_VALUE = :ITEM_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ITEM_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_BASE"))
			{
				strBuf.Add("  BGT_B_CPN_YEAR_WEAVE_D.BUDGET_BASE = :BUDGET_BASE");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_BASE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.BUDGET_BASE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_ID"))
			{
				strBuf.Add("  BGT_B_CPN_YEAR_WEAVE_D.ITEM_ID = :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_ID) ? string.Empty : obj.ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("UNIT_ID"))
			{
				strBuf.Add("  BGT_B_CPN_YEAR_WEAVE_D.UNIT_ID = :UNIT_ID");
				param = new OracleParameter();
				param.ParameterName = ":UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.UNIT_ID) ? string.Empty : obj.UNIT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_TYPE_ID"))
			{
				strBuf.Add("  BGT_B_CPN_YEAR_WEAVE_D.ITEM_TYPE_ID = :ITEM_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_TYPE_ID) ? string.Empty : obj.ITEM_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TEMPLET_ITEM_ID"))
			{
				strBuf.Add("  BGT_B_CPN_YEAR_WEAVE_D.TEMPLET_ITEM_ID = :TEMPLET_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":TEMPLET_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.TEMPLET_ITEM_ID) ? string.Empty : obj.TEMPLET_ITEM_ID;
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
