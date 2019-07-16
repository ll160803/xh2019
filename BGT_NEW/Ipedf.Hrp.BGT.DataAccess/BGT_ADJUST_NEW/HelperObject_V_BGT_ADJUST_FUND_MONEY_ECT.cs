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
	[CauseObject(typeof(CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT))]
	public partial class HelperObject_V_BGT_ADJUST_FUND_MONEY_ECT
	{		
		#region Method Blok
		public static int Save(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_BGT_ADJUST_FUND_MONEY_ECT( FUND_CODE, ID, USERNAME, BUDGET_DEPT_ID_NAME, BGT_D_BUDGET_ITEM_ID_NAME, STATE, BUDGET_YEAR, CHANGE_MONEY, BUDGET_DEPT_ID, BUDGET_YEAR_ID, ADJUST_ID, BGT_D_BUDGET_ITEM_ID) values ( :FUND_CODE, :ID, :USERNAME, :BUDGET_DEPT_ID_NAME, :BGT_D_BUDGET_ITEM_ID_NAME, :STATE, :BUDGET_YEAR, :CHANGE_MONEY, :BUDGET_DEPT_ID, :BUDGET_YEAR_ID, :ADJUST_ID, :BGT_D_BUDGET_ITEM_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[12];
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
			parameters[2].ParameterName =":USERNAME";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.USERNAME == null ? String.Empty:obj.USERNAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":BUDGET_DEPT_ID_NAME";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.BUDGET_DEPT_ID_NAME == null ? String.Empty:obj.BUDGET_DEPT_ID_NAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":BGT_D_BUDGET_ITEM_ID_NAME";
			parameters[4].Size = 200;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.BGT_D_BUDGET_ITEM_ID_NAME == null ? String.Empty:obj.BGT_D_BUDGET_ITEM_ID_NAME;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":STATE";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.STATE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":BUDGET_YEAR";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CHANGE_MONEY";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.CHANGE_MONEY;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":BUDGET_DEPT_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.BUDGET_DEPT_ID == null ? String.Empty:obj.BUDGET_DEPT_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":BUDGET_YEAR_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.BUDGET_YEAR_ID == null ? String.Empty:obj.BUDGET_YEAR_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":ADJUST_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.ADJUST_ID == null ? String.Empty:obj.ADJUST_ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":BGT_D_BUDGET_ITEM_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.BGT_D_BUDGET_ITEM_ID == null ? String.Empty:obj.BGT_D_BUDGET_ITEM_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_BGT_ADJUST_FUND_MONEY_ECT set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj,CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_BGT_ADJUST_FUND_MONEY_ECT set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_BGT_ADJUST_FUND_MONEY_ECT where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_BGT_ADJUST_FUND_MONEY_ECT where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT Get(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj)
		{
			
			//平台自动生成代码
			string sSql = "select  FUND_CODE, ID, USERNAME, BUDGET_DEPT_ID_NAME, BGT_D_BUDGET_ITEM_ID_NAME, STATE, BUDGET_YEAR, CHANGE_MONEY, BUDGET_DEPT_ID, BUDGET_YEAR_ID, ADJUST_ID, BGT_D_BUDGET_ITEM_ID from V_BGT_ADJUST_FUND_MONEY_ECT where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USERNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ADJUST_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT[] objs = new EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT Get(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  FUND_CODE, ID, USERNAME, BUDGET_DEPT_ID_NAME, BGT_D_BUDGET_ITEM_ID_NAME, STATE, BUDGET_YEAR, CHANGE_MONEY, BUDGET_DEPT_ID, BUDGET_YEAR_ID, ADJUST_ID, BGT_D_BUDGET_ITEM_ID from V_BGT_ADJUST_FUND_MONEY_ECT where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USERNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ADJUST_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT[] objs = new EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_BGT_ADJUST_FUND_MONEY_ECT.FUND_CODE, V_BGT_ADJUST_FUND_MONEY_ECT.ID, V_BGT_ADJUST_FUND_MONEY_ECT.USERNAME, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID_NAME, V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_ADJUST_FUND_MONEY_ECT.STATE, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR, V_BGT_ADJUST_FUND_MONEY_ECT.CHANGE_MONEY, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR_ID, V_BGT_ADJUST_FUND_MONEY_ECT.ADJUST_ID, V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID from V_BGT_ADJUST_FUND_MONEY_ECT where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USERNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ADJUST_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] objs = new DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.FUND_CODE))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY_ECT.FUND_CODE ").Append((cause.FUND_CODE.StartsWith("%") || cause.FUND_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_FUND_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_FUND_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FUND_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUND_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY_ECT", "FUND_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY_ECT.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY_ECT", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.USERNAME))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY_ECT.USERNAME ").Append((cause.USERNAME.StartsWith("%") || cause.USERNAME.EndsWith("%")) ? " like " : " = ").Append(" :C_USERNAME");
				param = new OracleParameter();
				param.ParameterName =":C_USERNAME";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USERNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("USERNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY_ECT", "USERNAME"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_DEPT_ID_NAME))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID_NAME ").Append((cause.BUDGET_DEPT_ID_NAME.StartsWith("%") || cause.BUDGET_DEPT_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_BUDGET_DEPT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_BUDGET_DEPT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BUDGET_DEPT_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_DEPT_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY_ECT", "BUDGET_DEPT_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BGT_D_BUDGET_ITEM_ID_NAME))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID_NAME ").Append((cause.BGT_D_BUDGET_ITEM_ID_NAME.StartsWith("%") || cause.BGT_D_BUDGET_ITEM_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_BGT_D_BUDGET_ITEM_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_BGT_D_BUDGET_ITEM_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.BGT_D_BUDGET_ITEM_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BGT_D_BUDGET_ITEM_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY_ECT", "BGT_D_BUDGET_ITEM_ID_NAME"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY_ECT.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY_ECT", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :C_BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":C_BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY_ECT", "BUDGET_YEAR"));
			}
			if(cause.CHANGE_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY_ECT.CHANGE_MONEY = :C_CHANGE_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_CHANGE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CHANGE_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("CHANGE_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY_ECT", "CHANGE_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_DEPT_ID))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID ").Append((cause.BUDGET_DEPT_ID.StartsWith("%") || cause.BUDGET_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY_ECT", "BUDGET_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR_ID))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR_ID ").Append((cause.BUDGET_YEAR_ID.StartsWith("%") || cause.BUDGET_YEAR_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BUDGET_YEAR_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BUDGET_YEAR_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY_ECT", "BUDGET_YEAR_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ADJUST_ID))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY_ECT.ADJUST_ID ").Append((cause.ADJUST_ID.StartsWith("%") || cause.ADJUST_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ADJUST_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ADJUST_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ADJUST_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADJUST_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY_ECT", "ADJUST_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BGT_D_BUDGET_ITEM_ID))
			{
				strBuf.Append(" And V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID ").Append((cause.BGT_D_BUDGET_ITEM_ID.StartsWith("%") || cause.BGT_D_BUDGET_ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BGT_D_BUDGET_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BGT_D_BUDGET_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BGT_D_BUDGET_ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BGT_D_BUDGET_ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_ADJUST_FUND_MONEY_ECT", "BGT_D_BUDGET_ITEM_ID"));
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
		public static DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] Query(CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_ADJUST_FUND_MONEY_ECT.FUND_CODE, V_BGT_ADJUST_FUND_MONEY_ECT.ID, V_BGT_ADJUST_FUND_MONEY_ECT.USERNAME, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID_NAME, V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_ADJUST_FUND_MONEY_ECT.STATE, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR, V_BGT_ADJUST_FUND_MONEY_ECT.CHANGE_MONEY, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR_ID, V_BGT_ADJUST_FUND_MONEY_ECT.ADJUST_ID, V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID from V_BGT_ADJUST_FUND_MONEY_ECT where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USERNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ADJUST_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] objs = new DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] Query(CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_ADJUST_FUND_MONEY_ECT.FUND_CODE, V_BGT_ADJUST_FUND_MONEY_ECT.ID, V_BGT_ADJUST_FUND_MONEY_ECT.USERNAME, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID_NAME, V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_ADJUST_FUND_MONEY_ECT.STATE, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR, V_BGT_ADJUST_FUND_MONEY_ECT.CHANGE_MONEY, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR_ID, V_BGT_ADJUST_FUND_MONEY_ECT.ADJUST_ID, V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID from V_BGT_ADJUST_FUND_MONEY_ECT where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USERNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ADJUST_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] objs = new DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] Query(CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_ADJUST_FUND_MONEY_ECT.FUND_CODE, V_BGT_ADJUST_FUND_MONEY_ECT.ID, V_BGT_ADJUST_FUND_MONEY_ECT.USERNAME, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID_NAME, V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_ADJUST_FUND_MONEY_ECT.STATE, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR, V_BGT_ADJUST_FUND_MONEY_ECT.CHANGE_MONEY, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR_ID, V_BGT_ADJUST_FUND_MONEY_ECT.ADJUST_ID, V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID from V_BGT_ADJUST_FUND_MONEY_ECT where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_ADJUST_FUND_MONEY_ECT",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USERNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ADJUST_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] objs = new DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] Query(CauseObject_V_BGT_ADJUST_FUND_MONEY_ECT cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_ADJUST_FUND_MONEY_ECT.FUND_CODE, V_BGT_ADJUST_FUND_MONEY_ECT.ID, V_BGT_ADJUST_FUND_MONEY_ECT.USERNAME, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID_NAME, V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_ADJUST_FUND_MONEY_ECT.STATE, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR, V_BGT_ADJUST_FUND_MONEY_ECT.CHANGE_MONEY, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID, V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR_ID, V_BGT_ADJUST_FUND_MONEY_ECT.ADJUST_ID, V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID from V_BGT_ADJUST_FUND_MONEY_ECT where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_ADJUST_FUND_MONEY_ECT",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUND_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USERNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CHANGE_MONEY = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BUDGET_YEAR_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ADJUST_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[] objs = new DisplayObject_V_BGT_ADJUST_FUND_MONEY_ECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_BGT_ADJUST_FUND_MONEY_ECT obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("FUND_CODE"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY_ECT.FUND_CODE = :U_FUND_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_FUND_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FUND_CODE) ? string.Empty : obj.FUND_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY_ECT.ID = :U_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USERNAME"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY_ECT.USERNAME = :U_USERNAME");
				param = new OracleParameter();
				param.ParameterName = ":U_USERNAME";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USERNAME) ? string.Empty : obj.USERNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_DEPT_ID_NAME"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID_NAME = :U_BUDGET_DEPT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_BUDGET_DEPT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_DEPT_ID_NAME) ? string.Empty : obj.BUDGET_DEPT_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BGT_D_BUDGET_ITEM_ID_NAME"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID_NAME = :U_BGT_D_BUDGET_ITEM_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_BGT_D_BUDGET_ITEM_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.BGT_D_BUDGET_ITEM_ID_NAME) ? string.Empty : obj.BGT_D_BUDGET_ITEM_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY_ECT.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR = :U_BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":U_BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CHANGE_MONEY"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY_ECT.CHANGE_MONEY = :U_CHANGE_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_CHANGE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CHANGE_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_DEPT_ID"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_DEPT_ID = :U_BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_DEPT_ID) ? string.Empty : obj.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR_ID"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY_ECT.BUDGET_YEAR_ID = :U_BUDGET_YEAR_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BUDGET_YEAR_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR_ID) ? string.Empty : obj.BUDGET_YEAR_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ADJUST_ID"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY_ECT.ADJUST_ID = :U_ADJUST_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ADJUST_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ADJUST_ID) ? string.Empty : obj.ADJUST_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BGT_D_BUDGET_ITEM_ID"))
			{
				strBuf.Add("  V_BGT_ADJUST_FUND_MONEY_ECT.BGT_D_BUDGET_ITEM_ID = :U_BGT_D_BUDGET_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BGT_D_BUDGET_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BGT_D_BUDGET_ITEM_ID) ? string.Empty : obj.BGT_D_BUDGET_ITEM_ID;
				paramList.Add(param);
			}
			//pk here
			if(appendpk)
			{
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		#endregion 
	}
}
