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
	[CauseObject(typeof(CauseObject_V_BGT_ADJUST_TO_SAP))]
	public partial class HelperObject_V_BGT_ADJUST_TO_SAP
	{		
		#region Method Blok
		public static int Save(EntityObject_V_BGT_ADJUST_TO_SAP obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_BGT_ADJUST_TO_SAP( CHANGE_MONEY, FUND_CODE, ID, USERNAME, BUDGET_DEPT_ID_NAME, BGT_D_BUDGET_ITEM_ID_NAME, BUDGET_YEAR, BUDGET_YEAR_ID, BUDGET_DEPT_ID, ADJUST_ID) values ( :CHANGE_MONEY, :FUND_CODE, :ID, :USERNAME, :BUDGET_DEPT_ID_NAME, :BGT_D_BUDGET_ITEM_ID_NAME, :BUDGET_YEAR, :BUDGET_YEAR_ID, :BUDGET_DEPT_ID, :ADJUST_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[10];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CHANGE_MONEY";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.CHANGE_MONEY;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":FUND_CODE";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.FUND_CODE == null ? String.Empty:obj.FUND_CODE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":USERNAME";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.USERNAME == null ? String.Empty:obj.USERNAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":BUDGET_DEPT_ID_NAME";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.BUDGET_DEPT_ID_NAME == null ? String.Empty:obj.BUDGET_DEPT_ID_NAME;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":BGT_D_BUDGET_ITEM_ID_NAME";
			parameters[5].Size = 100;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.BGT_D_BUDGET_ITEM_ID_NAME == null ? String.Empty:obj.BGT_D_BUDGET_ITEM_ID_NAME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":BUDGET_YEAR";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":BUDGET_YEAR_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.BUDGET_YEAR_ID == null ? String.Empty:obj.BUDGET_YEAR_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":BUDGET_DEPT_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.BUDGET_DEPT_ID == null ? String.Empty:obj.BUDGET_DEPT_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":ADJUST_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.ADJUST_ID == null ? String.Empty:obj.ADJUST_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_BGT_ADJUST_TO_SAP obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_BGT_ADJUST_TO_SAP set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_BGT_ADJUST_TO_SAP obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_BGT_ADJUST_TO_SAP where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_BGT_ADJUST_TO_SAP Get(EntityObject_V_BGT_ADJUST_TO_SAP obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CHANGE_MONEY, FUND_CODE, ID, USERNAME, BUDGET_DEPT_ID_NAME, BGT_D_BUDGET_ITEM_ID_NAME, BUDGET_YEAR, BUDGET_YEAR_ID, BUDGET_DEPT_ID, ADJUST_ID from V_BGT_ADJUST_TO_SAP where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_ADJUST_TO_SAP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_ADJUST_TO_SAP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USERNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ADJUST_ID = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_BGT_ADJUST_TO_SAP[] objs = new EntityObject_V_BGT_ADJUST_TO_SAP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_BGT_ADJUST_TO_SAP Get(EntityObject_V_BGT_ADJUST_TO_SAP obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CHANGE_MONEY, FUND_CODE, ID, USERNAME, BUDGET_DEPT_ID_NAME, BGT_D_BUDGET_ITEM_ID_NAME, BUDGET_YEAR, BUDGET_YEAR_ID, BUDGET_DEPT_ID, ADJUST_ID from V_BGT_ADJUST_TO_SAP where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_ADJUST_TO_SAP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_ADJUST_TO_SAP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USERNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ADJUST_ID = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_BGT_ADJUST_TO_SAP[] objs = new EntityObject_V_BGT_ADJUST_TO_SAP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_BGT_ADJUST_TO_SAP[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_BGT_ADJUST_TO_SAP.CHANGE_MONEY, V_BGT_ADJUST_TO_SAP.FUND_CODE, V_BGT_ADJUST_TO_SAP.ID, V_BGT_ADJUST_TO_SAP.USERNAME, V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID_NAME, V_BGT_ADJUST_TO_SAP.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_ADJUST_TO_SAP.BUDGET_YEAR, V_BGT_ADJUST_TO_SAP.BUDGET_YEAR_ID, V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID, V_BGT_ADJUST_TO_SAP.ADJUST_ID from V_BGT_ADJUST_TO_SAP where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_BGT_ADJUST_TO_SAP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_TO_SAP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USERNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ADJUST_ID = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_ADJUST_TO_SAP[] objs = new DisplayObject_V_BGT_ADJUST_TO_SAP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_BGT_ADJUST_TO_SAP cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.CHANGE_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_ADJUST_TO_SAP.CHANGE_MONEY = :CHANGE_MONEY");
				param = new OracleParameter();
				param.ParameterName =":CHANGE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CHANGE_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("CHANGE_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_TO_SAP", "CHANGE_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.FUND_CODE))
			{
				strBuf.Append(" And V_BGT_ADJUST_TO_SAP.FUND_CODE ").Append((cause.FUND_CODE.StartsWith("%") || cause.FUND_CODE.EndsWith("%")) ? " like " : " = ").Append(" :FUND_CODE");
				param = new OracleParameter();
				param.ParameterName =":FUND_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FUND_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUND_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_TO_SAP", "FUND_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_BGT_ADJUST_TO_SAP.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_TO_SAP", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.USERNAME))
			{
				strBuf.Append(" And V_BGT_ADJUST_TO_SAP.USERNAME ").Append((cause.USERNAME.StartsWith("%") || cause.USERNAME.EndsWith("%")) ? " like " : " = ").Append(" :USERNAME");
				param = new OracleParameter();
				param.ParameterName =":USERNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.USERNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("USERNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_TO_SAP", "USERNAME"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_DEPT_ID_NAME))
			{
				strBuf.Append(" And V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID_NAME ").Append((cause.BUDGET_DEPT_ID_NAME.StartsWith("%") || cause.BUDGET_DEPT_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_DEPT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_DEPT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BUDGET_DEPT_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_DEPT_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_TO_SAP", "BUDGET_DEPT_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BGT_D_BUDGET_ITEM_ID_NAME))
			{
				strBuf.Append(" And V_BGT_ADJUST_TO_SAP.BGT_D_BUDGET_ITEM_ID_NAME ").Append((cause.BGT_D_BUDGET_ITEM_ID_NAME.StartsWith("%") || cause.BGT_D_BUDGET_ITEM_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :BGT_D_BUDGET_ITEM_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":BGT_D_BUDGET_ITEM_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.BGT_D_BUDGET_ITEM_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BGT_D_BUDGET_ITEM_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_TO_SAP", "BGT_D_BUDGET_ITEM_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR))
			{
				strBuf.Append(" And V_BGT_ADJUST_TO_SAP.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_TO_SAP", "BUDGET_YEAR"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR_ID))
			{
				strBuf.Append(" And V_BGT_ADJUST_TO_SAP.BUDGET_YEAR_ID ").Append((cause.BUDGET_YEAR_ID.StartsWith("%") || cause.BUDGET_YEAR_ID.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR_ID");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_TO_SAP", "BUDGET_YEAR_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_DEPT_ID))
			{
				strBuf.Append(" And V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID ").Append((cause.BUDGET_DEPT_ID.StartsWith("%") || cause.BUDGET_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_TO_SAP", "BUDGET_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ADJUST_ID))
			{
				strBuf.Append(" And V_BGT_ADJUST_TO_SAP.ADJUST_ID ").Append((cause.ADJUST_ID.StartsWith("%") || cause.ADJUST_ID.EndsWith("%")) ? " like " : " = ").Append(" :ADJUST_ID");
				param = new OracleParameter();
				param.ParameterName =":ADJUST_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ADJUST_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADJUST_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_TO_SAP", "ADJUST_ID"));
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
		public static DisplayObject_V_BGT_ADJUST_TO_SAP[] Query(CauseObject_V_BGT_ADJUST_TO_SAP cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_ADJUST_TO_SAP.CHANGE_MONEY, V_BGT_ADJUST_TO_SAP.FUND_CODE, V_BGT_ADJUST_TO_SAP.ID, V_BGT_ADJUST_TO_SAP.USERNAME, V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID_NAME, V_BGT_ADJUST_TO_SAP.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_ADJUST_TO_SAP.BUDGET_YEAR, V_BGT_ADJUST_TO_SAP.BUDGET_YEAR_ID, V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID, V_BGT_ADJUST_TO_SAP.ADJUST_ID from V_BGT_ADJUST_TO_SAP where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_ADJUST_TO_SAP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_TO_SAP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USERNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ADJUST_ID = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_ADJUST_TO_SAP[] objs = new DisplayObject_V_BGT_ADJUST_TO_SAP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_BGT_ADJUST_TO_SAP cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_BGT_ADJUST_TO_SAP where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_BGT_ADJUST_TO_SAP[] Query(CauseObject_V_BGT_ADJUST_TO_SAP cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_ADJUST_TO_SAP.CHANGE_MONEY, V_BGT_ADJUST_TO_SAP.FUND_CODE, V_BGT_ADJUST_TO_SAP.ID, V_BGT_ADJUST_TO_SAP.USERNAME, V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID_NAME, V_BGT_ADJUST_TO_SAP.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_ADJUST_TO_SAP.BUDGET_YEAR, V_BGT_ADJUST_TO_SAP.BUDGET_YEAR_ID, V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID, V_BGT_ADJUST_TO_SAP.ADJUST_ID from V_BGT_ADJUST_TO_SAP where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_ADJUST_TO_SAP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_TO_SAP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USERNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ADJUST_ID = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_ADJUST_TO_SAP[] objs = new DisplayObject_V_BGT_ADJUST_TO_SAP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_ADJUST_TO_SAP[] Query(CauseObject_V_BGT_ADJUST_TO_SAP cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_ADJUST_TO_SAP.CHANGE_MONEY, V_BGT_ADJUST_TO_SAP.FUND_CODE, V_BGT_ADJUST_TO_SAP.ID, V_BGT_ADJUST_TO_SAP.USERNAME, V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID_NAME, V_BGT_ADJUST_TO_SAP.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_ADJUST_TO_SAP.BUDGET_YEAR, V_BGT_ADJUST_TO_SAP.BUDGET_YEAR_ID, V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID, V_BGT_ADJUST_TO_SAP.ADJUST_ID from V_BGT_ADJUST_TO_SAP where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_ADJUST_TO_SAP",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_BGT_ADJUST_TO_SAP dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_TO_SAP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USERNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ADJUST_ID = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_ADJUST_TO_SAP[] objs = new DisplayObject_V_BGT_ADJUST_TO_SAP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_ADJUST_TO_SAP[] Query(CauseObject_V_BGT_ADJUST_TO_SAP cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_ADJUST_TO_SAP.CHANGE_MONEY, V_BGT_ADJUST_TO_SAP.FUND_CODE, V_BGT_ADJUST_TO_SAP.ID, V_BGT_ADJUST_TO_SAP.USERNAME, V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID_NAME, V_BGT_ADJUST_TO_SAP.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_ADJUST_TO_SAP.BUDGET_YEAR, V_BGT_ADJUST_TO_SAP.BUDGET_YEAR_ID, V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID, V_BGT_ADJUST_TO_SAP.ADJUST_ID from V_BGT_ADJUST_TO_SAP where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_ADJUST_TO_SAP",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_BGT_ADJUST_TO_SAP dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_TO_SAP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USERNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ADJUST_ID = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_ADJUST_TO_SAP[] objs = new DisplayObject_V_BGT_ADJUST_TO_SAP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_BGT_ADJUST_TO_SAP obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CHANGE_MONEY"))
			{
				strBuf.Add("  V_BGT_ADJUST_TO_SAP.CHANGE_MONEY = :CHANGE_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":CHANGE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CHANGE_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FUND_CODE"))
			{
				strBuf.Add("  V_BGT_ADJUST_TO_SAP.FUND_CODE = :FUND_CODE");
				param = new OracleParameter();
				param.ParameterName = ":FUND_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FUND_CODE) ? string.Empty : obj.FUND_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_BGT_ADJUST_TO_SAP.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USERNAME"))
			{
				strBuf.Add("  V_BGT_ADJUST_TO_SAP.USERNAME = :USERNAME");
				param = new OracleParameter();
				param.ParameterName = ":USERNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.USERNAME) ? string.Empty : obj.USERNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_DEPT_ID_NAME"))
			{
				strBuf.Add("  V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID_NAME = :BUDGET_DEPT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_DEPT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_DEPT_ID_NAME) ? string.Empty : obj.BUDGET_DEPT_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BGT_D_BUDGET_ITEM_ID_NAME"))
			{
				strBuf.Add("  V_BGT_ADJUST_TO_SAP.BGT_D_BUDGET_ITEM_ID_NAME = :BGT_D_BUDGET_ITEM_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":BGT_D_BUDGET_ITEM_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.BGT_D_BUDGET_ITEM_ID_NAME) ? string.Empty : obj.BGT_D_BUDGET_ITEM_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  V_BGT_ADJUST_TO_SAP.BUDGET_YEAR = :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR_ID"))
			{
				strBuf.Add("  V_BGT_ADJUST_TO_SAP.BUDGET_YEAR_ID = :BUDGET_YEAR_ID");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_YEAR_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR_ID) ? string.Empty : obj.BUDGET_YEAR_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_DEPT_ID"))
			{
				strBuf.Add("  V_BGT_ADJUST_TO_SAP.BUDGET_DEPT_ID = :BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_DEPT_ID) ? string.Empty : obj.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ADJUST_ID"))
			{
				strBuf.Add("  V_BGT_ADJUST_TO_SAP.ADJUST_ID = :ADJUST_ID");
				param = new OracleParameter();
				param.ParameterName = ":ADJUST_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ADJUST_ID) ? string.Empty : obj.ADJUST_ID;
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
