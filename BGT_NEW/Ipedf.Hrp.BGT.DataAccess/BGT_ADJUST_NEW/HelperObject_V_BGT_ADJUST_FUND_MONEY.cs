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
	[CauseObject(typeof(CauseObject_V_BGT_ADJUST_FUND_MONEY))]
	public partial class HelperObject_V_BGT_ADJUST_FUND_MONEY
	{		
		#region Method Blok
		public static int Save(EntityObject_V_BGT_ADJUST_FUND_MONEY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_BGT_ADJUST_FUND_MONEY( FUND_CODE, ID, BASE_ID, NAME, BUDGET_YEAR, CHANGE_CAUSE, CHANGE_MONEY, REF_TAB_ID, EXE_MONEY) values ( :FUND_CODE, :ID, :BASE_ID, :NAME, :BUDGET_YEAR, :CHANGE_CAUSE, :CHANGE_MONEY, :REF_TAB_ID, :EXE_MONEY)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[9];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":FUND_CODE";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.FUND_CODE == null ? String.Empty:obj.FUND_CODE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":BASE_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":NAME";
			parameters[3].Size = 100;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":BUDGET_YEAR";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":CHANGE_CAUSE";
			parameters[5].Size = 500;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.CHANGE_CAUSE == null ? String.Empty:obj.CHANGE_CAUSE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":CHANGE_MONEY";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.CHANGE_MONEY;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":REF_TAB_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.REF_TAB_ID == null ? String.Empty:obj.REF_TAB_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":EXE_MONEY";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.EXE_MONEY;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_BGT_ADJUST_FUND_MONEY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_BGT_ADJUST_FUND_MONEY set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_BGT_ADJUST_FUND_MONEY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_BGT_ADJUST_FUND_MONEY where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_BGT_ADJUST_FUND_MONEY Get(EntityObject_V_BGT_ADJUST_FUND_MONEY obj)
		{
			
			//平台自动生成代码
			string sSql = "select  FUND_CODE, ID, BASE_ID, NAME, BUDGET_YEAR, CHANGE_CAUSE, CHANGE_MONEY, REF_TAB_ID, EXE_MONEY from V_BGT_ADJUST_FUND_MONEY where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_ADJUST_FUND_MONEY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_ADJUST_FUND_MONEY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CHANGE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXE_MONEY = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_BGT_ADJUST_FUND_MONEY[] objs = new EntityObject_V_BGT_ADJUST_FUND_MONEY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_BGT_ADJUST_FUND_MONEY Get(EntityObject_V_BGT_ADJUST_FUND_MONEY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  FUND_CODE, ID, BASE_ID, NAME, BUDGET_YEAR, CHANGE_CAUSE, CHANGE_MONEY, REF_TAB_ID, EXE_MONEY from V_BGT_ADJUST_FUND_MONEY where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_ADJUST_FUND_MONEY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_ADJUST_FUND_MONEY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CHANGE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXE_MONEY = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_BGT_ADJUST_FUND_MONEY[] objs = new EntityObject_V_BGT_ADJUST_FUND_MONEY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_BGT_ADJUST_FUND_MONEY[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_BGT_ADJUST_FUND_MONEY.FUND_CODE, V_BGT_ADJUST_FUND_MONEY.ID, V_BGT_ADJUST_FUND_MONEY.BASE_ID, V_BGT_ADJUST_FUND_MONEY.NAME, V_BGT_ADJUST_FUND_MONEY.BUDGET_YEAR, V_BGT_ADJUST_FUND_MONEY.CHANGE_CAUSE, V_BGT_ADJUST_FUND_MONEY.CHANGE_MONEY, V_BGT_ADJUST_FUND_MONEY.REF_TAB_ID, V_BGT_ADJUST_FUND_MONEY.EXE_MONEY from V_BGT_ADJUST_FUND_MONEY where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_BGT_ADJUST_FUND_MONEY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_FUND_MONEY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CHANGE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXE_MONEY = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_ADJUST_FUND_MONEY[] objs = new DisplayObject_V_BGT_ADJUST_FUND_MONEY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_BGT_ADJUST_FUND_MONEY cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.FUND_CODE))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY.FUND_CODE ").Append((cause.FUND_CODE.StartsWith("%") || cause.FUND_CODE.EndsWith("%")) ? " like " : " = ").Append(" :FUND_CODE");
				param = new OracleParameter();
				param.ParameterName =":FUND_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FUND_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUND_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY", "FUND_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY", "BUDGET_YEAR"));
			}
			if(!string.IsNullOrEmpty(cause.CHANGE_CAUSE))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY.CHANGE_CAUSE ").Append((cause.CHANGE_CAUSE.StartsWith("%") || cause.CHANGE_CAUSE.EndsWith("%")) ? " like " : " = ").Append(" :CHANGE_CAUSE");
				param = new OracleParameter();
				param.ParameterName =":CHANGE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.CHANGE_CAUSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CHANGE_CAUSE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY", "CHANGE_CAUSE"));
			}
			if(cause.CHANGE_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY.CHANGE_MONEY = :CHANGE_MONEY");
				param = new OracleParameter();
				param.ParameterName =":CHANGE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CHANGE_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("CHANGE_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY", "CHANGE_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_ID))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY.REF_TAB_ID ").Append((cause.REF_TAB_ID.StartsWith("%") || cause.REF_TAB_ID.EndsWith("%")) ? " like " : " = ").Append(" :REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName =":REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_TAB_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY", "REF_TAB_ID"));
			}
			if(cause.EXE_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY.EXE_MONEY = :EXE_MONEY");
				param = new OracleParameter();
				param.ParameterName =":EXE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.EXE_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("EXE_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY", "EXE_MONEY"));
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
		public static DisplayObject_V_BGT_ADJUST_FUND_MONEY[] Query(CauseObject_V_BGT_ADJUST_FUND_MONEY cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_ADJUST_FUND_MONEY.FUND_CODE, V_BGT_ADJUST_FUND_MONEY.ID, V_BGT_ADJUST_FUND_MONEY.BASE_ID, V_BGT_ADJUST_FUND_MONEY.NAME, V_BGT_ADJUST_FUND_MONEY.BUDGET_YEAR, V_BGT_ADJUST_FUND_MONEY.CHANGE_CAUSE, V_BGT_ADJUST_FUND_MONEY.CHANGE_MONEY, V_BGT_ADJUST_FUND_MONEY.REF_TAB_ID, V_BGT_ADJUST_FUND_MONEY.EXE_MONEY from V_BGT_ADJUST_FUND_MONEY where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_ADJUST_FUND_MONEY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_FUND_MONEY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CHANGE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXE_MONEY = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_ADJUST_FUND_MONEY[] objs = new DisplayObject_V_BGT_ADJUST_FUND_MONEY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_BGT_ADJUST_FUND_MONEY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_BGT_ADJUST_FUND_MONEY where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_BGT_ADJUST_FUND_MONEY[] Query(CauseObject_V_BGT_ADJUST_FUND_MONEY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_ADJUST_FUND_MONEY.FUND_CODE, V_BGT_ADJUST_FUND_MONEY.ID, V_BGT_ADJUST_FUND_MONEY.BASE_ID, V_BGT_ADJUST_FUND_MONEY.NAME, V_BGT_ADJUST_FUND_MONEY.BUDGET_YEAR, V_BGT_ADJUST_FUND_MONEY.CHANGE_CAUSE, V_BGT_ADJUST_FUND_MONEY.CHANGE_MONEY, V_BGT_ADJUST_FUND_MONEY.REF_TAB_ID, V_BGT_ADJUST_FUND_MONEY.EXE_MONEY from V_BGT_ADJUST_FUND_MONEY where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_ADJUST_FUND_MONEY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_FUND_MONEY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CHANGE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXE_MONEY = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_ADJUST_FUND_MONEY[] objs = new DisplayObject_V_BGT_ADJUST_FUND_MONEY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_ADJUST_FUND_MONEY[] Query(CauseObject_V_BGT_ADJUST_FUND_MONEY cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_ADJUST_FUND_MONEY.FUND_CODE, V_BGT_ADJUST_FUND_MONEY.ID, V_BGT_ADJUST_FUND_MONEY.BASE_ID, V_BGT_ADJUST_FUND_MONEY.NAME, V_BGT_ADJUST_FUND_MONEY.BUDGET_YEAR, V_BGT_ADJUST_FUND_MONEY.CHANGE_CAUSE, V_BGT_ADJUST_FUND_MONEY.CHANGE_MONEY, V_BGT_ADJUST_FUND_MONEY.REF_TAB_ID, V_BGT_ADJUST_FUND_MONEY.EXE_MONEY from V_BGT_ADJUST_FUND_MONEY where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_ADJUST_FUND_MONEY",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_BGT_ADJUST_FUND_MONEY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_FUND_MONEY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CHANGE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXE_MONEY = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_ADJUST_FUND_MONEY[] objs = new DisplayObject_V_BGT_ADJUST_FUND_MONEY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_ADJUST_FUND_MONEY[] Query(CauseObject_V_BGT_ADJUST_FUND_MONEY cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_ADJUST_FUND_MONEY.FUND_CODE, V_BGT_ADJUST_FUND_MONEY.ID, V_BGT_ADJUST_FUND_MONEY.BASE_ID, V_BGT_ADJUST_FUND_MONEY.NAME, V_BGT_ADJUST_FUND_MONEY.BUDGET_YEAR, V_BGT_ADJUST_FUND_MONEY.CHANGE_CAUSE, V_BGT_ADJUST_FUND_MONEY.CHANGE_MONEY, V_BGT_ADJUST_FUND_MONEY.REF_TAB_ID, V_BGT_ADJUST_FUND_MONEY.EXE_MONEY from V_BGT_ADJUST_FUND_MONEY where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_ADJUST_FUND_MONEY",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_BGT_ADJUST_FUND_MONEY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_FUND_MONEY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CHANGE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EXE_MONEY = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_ADJUST_FUND_MONEY[] objs = new DisplayObject_V_BGT_ADJUST_FUND_MONEY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_BGT_ADJUST_FUND_MONEY obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("FUND_CODE"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY.FUND_CODE = :FUND_CODE");
				param = new OracleParameter();
				param.ParameterName = ":FUND_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FUND_CODE) ? string.Empty : obj.FUND_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY.BUDGET_YEAR = :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CHANGE_CAUSE"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY.CHANGE_CAUSE = :CHANGE_CAUSE");
				param = new OracleParameter();
				param.ParameterName = ":CHANGE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.CHANGE_CAUSE) ? string.Empty : obj.CHANGE_CAUSE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CHANGE_MONEY"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY.CHANGE_MONEY = :CHANGE_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":CHANGE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CHANGE_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_ID"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY.REF_TAB_ID = :REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName = ":REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_ID) ? string.Empty : obj.REF_TAB_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EXE_MONEY"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY.EXE_MONEY = :EXE_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":EXE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.EXE_MONEY;
				paramList.Add(param);
			}
			//pk here
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		#endregion 
	}
}
