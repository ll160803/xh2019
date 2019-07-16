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
	[CauseObject(typeof(CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND))]
	public partial class HelperObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND
	{		
		#region Method Blok
		public static int Save(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_BGT_BGT_B_DEPT_PAY_YEAR_FUND( ITEM_NAME, FUND_MONEY, FUND_TYPE_ID_NAME, BUDGET_YEAR_NAME, IS_ATTACH, BGT_D_BUDGET_ITEM_ID, STATE_NAME, ID, BUDGET_DEPT_ID_NAME, STATE, MODIFY_DEPT_ID, IS_PERFORMANCE, DATA_ORGANISE_ID, CODE, DEPT_USER_ID, IS_FIXED, CREATE_USER_ID, BUDGET_DEPT_ID, CREATE_DEPT_ID, IS_FIXED_NAME, FREE_FIELD3, FREE_FIELD2, FUND_TYPE_ID, CREATE_TIME, DEPT_USER_ID_NAME, NAME, BUDGET_YEAR, FINANCE_IDEA, DECALRE_CAUSE, COMMENTS, BGT_D_BUDGET_ITEM_ID_NAME, CONTROL_MONEY, IS_PERFORMANCE_NAME, FREE_FIELD) values ( :ITEM_NAME, :FUND_MONEY, :FUND_TYPE_ID_NAME, :BUDGET_YEAR_NAME, :IS_ATTACH, :BGT_D_BUDGET_ITEM_ID, :STATE_NAME, :ID, :BUDGET_DEPT_ID_NAME, :STATE, :MODIFY_DEPT_ID, :IS_PERFORMANCE, :DATA_ORGANISE_ID, :CODE, :DEPT_USER_ID, :IS_FIXED, :CREATE_USER_ID, :BUDGET_DEPT_ID, :CREATE_DEPT_ID, :IS_FIXED_NAME, :FREE_FIELD3, :FREE_FIELD2, :FUND_TYPE_ID, :CREATE_TIME, :DEPT_USER_ID_NAME, :NAME, :BUDGET_YEAR, :FINANCE_IDEA, :DECALRE_CAUSE, :COMMENTS, :BGT_D_BUDGET_ITEM_ID_NAME, :CONTROL_MONEY, :IS_PERFORMANCE_NAME, :FREE_FIELD)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[34];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ITEM_NAME";
			parameters[0].Size = 200;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.ITEM_NAME == null ? String.Empty:obj.ITEM_NAME;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":FUND_MONEY";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.FUND_MONEY;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":FUND_TYPE_ID_NAME";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.FUND_TYPE_ID_NAME == null ? String.Empty:obj.FUND_TYPE_ID_NAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":BUDGET_YEAR_NAME";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.BUDGET_YEAR_NAME == null ? String.Empty:obj.BUDGET_YEAR_NAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":IS_ATTACH";
			parameters[4].Size = 2;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.IS_ATTACH == null ? String.Empty:obj.IS_ATTACH;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":BGT_D_BUDGET_ITEM_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.BGT_D_BUDGET_ITEM_ID == null ? String.Empty:obj.BGT_D_BUDGET_ITEM_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":STATE_NAME";
			parameters[6].Size = 6;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.STATE_NAME == null ? String.Empty:obj.STATE_NAME;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":BUDGET_DEPT_ID_NAME";
			parameters[8].Size = 50;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.BUDGET_DEPT_ID_NAME == null ? String.Empty:obj.BUDGET_DEPT_ID_NAME;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":STATE";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.STATE;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":MODIFY_DEPT_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":IS_PERFORMANCE";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.IS_PERFORMANCE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":DATA_ORGANISE_ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":CODE";
			parameters[13].Size = 50;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":DEPT_USER_ID";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.DEPT_USER_ID == null ? String.Empty:obj.DEPT_USER_ID;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":IS_FIXED";
			parameters[15].Size = 22;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[15].Value = obj.IS_FIXED;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":CREATE_USER_ID";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":BUDGET_DEPT_ID";
			parameters[17].Size = 36;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[17].Value = obj.BUDGET_DEPT_ID == null ? String.Empty:obj.BUDGET_DEPT_ID;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":CREATE_DEPT_ID";
			parameters[18].Size = 36;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[18].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":IS_FIXED_NAME";
			parameters[19].Size = 2;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.IS_FIXED_NAME == null ? String.Empty:obj.IS_FIXED_NAME;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":FREE_FIELD3";
			parameters[20].Size = 10;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[20].Value = obj.FREE_FIELD3 == null ? String.Empty:obj.FREE_FIELD3;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":FREE_FIELD2";
			parameters[21].Size = 200;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[21].Value = obj.FREE_FIELD2 == null ? String.Empty:obj.FREE_FIELD2;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":FUND_TYPE_ID";
			parameters[22].Size = 36;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[22].Value = obj.FUND_TYPE_ID == null ? String.Empty:obj.FUND_TYPE_ID;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":CREATE_TIME";
			parameters[23].Size = 7;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[23].Value = obj.CREATE_TIME;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":DEPT_USER_ID_NAME";
			parameters[24].Size = 50;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[24].Value = obj.DEPT_USER_ID_NAME == null ? String.Empty:obj.DEPT_USER_ID_NAME;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":NAME";
			parameters[25].Size = 100;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[25].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":BUDGET_YEAR";
			parameters[26].Size = 36;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[26].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":FINANCE_IDEA";
			parameters[27].Size = 500;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[27].Value = obj.FINANCE_IDEA == null ? String.Empty:obj.FINANCE_IDEA;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":DECALRE_CAUSE";
			parameters[28].Size = 2000;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[28].Value = obj.DECALRE_CAUSE == null ? String.Empty:obj.DECALRE_CAUSE;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":COMMENTS";
			parameters[29].Size = 200;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[29].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[30] = new OracleParameter();
			parameters[30].ParameterName =":BGT_D_BUDGET_ITEM_ID_NAME";
			parameters[30].Size = 100;
			parameters[30].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[30].Value = obj.BGT_D_BUDGET_ITEM_ID_NAME == null ? String.Empty:obj.BGT_D_BUDGET_ITEM_ID_NAME;
			parameters[31] = new OracleParameter();
			parameters[31].ParameterName =":CONTROL_MONEY";
			parameters[31].Size = 22;
			parameters[31].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[31].Value = obj.CONTROL_MONEY;
			parameters[32] = new OracleParameter();
			parameters[32].ParameterName =":IS_PERFORMANCE_NAME";
			parameters[32].Size = 2;
			parameters[32].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[32].Value = obj.IS_PERFORMANCE_NAME == null ? String.Empty:obj.IS_PERFORMANCE_NAME;
			parameters[33] = new OracleParameter();
			parameters[33].ParameterName =":FREE_FIELD";
			parameters[33].Size = 50;
			parameters[33].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[33].Value = obj.FREE_FIELD == null ? String.Empty:obj.FREE_FIELD;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_BGT_BGT_B_DEPT_PAY_YEAR_FUND set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_BGT_BGT_B_DEPT_PAY_YEAR_FUND where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND Get(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ITEM_NAME, FUND_MONEY, FUND_TYPE_ID_NAME, BUDGET_YEAR_NAME, IS_ATTACH, BGT_D_BUDGET_ITEM_ID, STATE_NAME, ID, BUDGET_DEPT_ID_NAME, STATE, MODIFY_DEPT_ID, IS_PERFORMANCE, DATA_ORGANISE_ID, MODIFY_TIME, CODE, DEPT_USER_ID, IS_FIXED, CREATE_USER_ID, BUDGET_DEPT_ID, CREATE_DEPT_ID, IS_FIXED_NAME, FREE_FIELD3, FREE_FIELD2, FUND_TYPE_ID, CREATE_TIME, DEPT_USER_ID_NAME, NAME, BUDGET_YEAR, MODIFY_USER_ID, FINANCE_IDEA, DECALRE_CAUSE, COMMENTS, BGT_D_BUDGET_ITEM_ID_NAME, CONTROL_MONEY, IS_PERFORMANCE_NAME, FREE_FIELD from V_BGT_BGT_B_DEPT_PAY_YEAR_FUND where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FUND_TYPE_ID_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ATTACH = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_FIXED_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.DEPT_USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IS_PERFORMANCE_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FREE_FIELD = sqlReader.GetString(35);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] objs = new EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND Get(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ITEM_NAME, FUND_MONEY, FUND_TYPE_ID_NAME, BUDGET_YEAR_NAME, IS_ATTACH, BGT_D_BUDGET_ITEM_ID, STATE_NAME, ID, BUDGET_DEPT_ID_NAME, STATE, MODIFY_DEPT_ID, IS_PERFORMANCE, DATA_ORGANISE_ID, MODIFY_TIME, CODE, DEPT_USER_ID, IS_FIXED, CREATE_USER_ID, BUDGET_DEPT_ID, CREATE_DEPT_ID, IS_FIXED_NAME, FREE_FIELD3, FREE_FIELD2, FUND_TYPE_ID, CREATE_TIME, DEPT_USER_ID_NAME, NAME, BUDGET_YEAR, MODIFY_USER_ID, FINANCE_IDEA, DECALRE_CAUSE, COMMENTS, BGT_D_BUDGET_ITEM_ID_NAME, CONTROL_MONEY, IS_PERFORMANCE_NAME, FREE_FIELD from V_BGT_BGT_B_DEPT_PAY_YEAR_FUND where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FUND_TYPE_ID_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ATTACH = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_FIXED_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.DEPT_USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IS_PERFORMANCE_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FREE_FIELD = sqlReader.GetString(35);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] objs = new EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ITEM_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_MONEY, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_ATTACH, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DATA_ORGANISE_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_TIME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CODE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD3, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD2, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_TIME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FINANCE_IDEA, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DECALRE_CAUSE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.COMMENTS, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CONTROL_MONEY, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD from V_BGT_BGT_B_DEPT_PAY_YEAR_FUND where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FUND_TYPE_ID_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ATTACH = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_FIXED_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.DEPT_USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IS_PERFORMANCE_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FREE_FIELD = sqlReader.GetString(35);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] objs = new DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ITEM_NAME))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ITEM_NAME ").Append((cause.ITEM_NAME.StartsWith("%") || cause.ITEM_NAME.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_NAME");
				param = new OracleParameter();
				param.ParameterName =":ITEM_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.ITEM_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "ITEM_NAME"));
			}
			if(cause.FUND_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_MONEY = :FUND_MONEY");
				param = new OracleParameter();
				param.ParameterName =":FUND_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.FUND_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUND_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "FUND_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.FUND_TYPE_ID_NAME))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID_NAME ").Append((cause.FUND_TYPE_ID_NAME.StartsWith("%") || cause.FUND_TYPE_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :FUND_TYPE_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":FUND_TYPE_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FUND_TYPE_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUND_TYPE_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "FUND_TYPE_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR_NAME))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR_NAME ").Append((cause.BUDGET_YEAR_NAME.StartsWith("%") || cause.BUDGET_YEAR_NAME.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR_NAME");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BUDGET_YEAR_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "BUDGET_YEAR_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.IS_ATTACH))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_ATTACH ").Append((cause.IS_ATTACH.StartsWith("%") || cause.IS_ATTACH.EndsWith("%")) ? " like " : " = ").Append(" :IS_ATTACH");
				param = new OracleParameter();
				param.ParameterName =":IS_ATTACH";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = cause.IS_ATTACH;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_ATTACH"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "IS_ATTACH"));
			}
			if(!string.IsNullOrEmpty(cause.BGT_D_BUDGET_ITEM_ID))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID ").Append((cause.BGT_D_BUDGET_ITEM_ID.StartsWith("%") || cause.BGT_D_BUDGET_ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :BGT_D_BUDGET_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":BGT_D_BUDGET_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BGT_D_BUDGET_ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BGT_D_BUDGET_ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "BGT_D_BUDGET_ITEM_ID"));
			}
			if(!string.IsNullOrEmpty(cause.STATE_NAME))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE_NAME ").Append((cause.STATE_NAME.StartsWith("%") || cause.STATE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :STATE_NAME");
				param = new OracleParameter();
				param.ParameterName =":STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = cause.STATE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "STATE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_DEPT_ID_NAME))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID_NAME ").Append((cause.BUDGET_DEPT_ID_NAME.StartsWith("%") || cause.BUDGET_DEPT_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_DEPT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_DEPT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BUDGET_DEPT_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_DEPT_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "BUDGET_DEPT_ID_NAME"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "MODIFY_DEPT_ID"));
			}
			if(cause.IS_PERFORMANCE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE = :IS_PERFORMANCE");
				param = new OracleParameter();
				param.ParameterName =":IS_PERFORMANCE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_PERFORMANCE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_PERFORMANCE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "IS_PERFORMANCE"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "DATA_ORGANISE_ID"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_TIME < :MODIFY_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("MODIFY_TIME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_USER_ID))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID ").Append((cause.DEPT_USER_ID.StartsWith("%") || cause.DEPT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :DEPT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":DEPT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "DEPT_USER_ID"));
			}
			if(cause.IS_FIXED!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED = :IS_FIXED");
				param = new OracleParameter();
				param.ParameterName =":IS_FIXED";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_FIXED;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_FIXED"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "IS_FIXED"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_DEPT_ID))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID ").Append((cause.BUDGET_DEPT_ID.StartsWith("%") || cause.BUDGET_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "BUDGET_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "CREATE_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.IS_FIXED_NAME))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED_NAME ").Append((cause.IS_FIXED_NAME.StartsWith("%") || cause.IS_FIXED_NAME.EndsWith("%")) ? " like " : " = ").Append(" :IS_FIXED_NAME");
				param = new OracleParameter();
				param.ParameterName =":IS_FIXED_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = cause.IS_FIXED_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_FIXED_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "IS_FIXED_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD3))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD3 ").Append((cause.FREE_FIELD3.StartsWith("%") || cause.FREE_FIELD3.EndsWith("%")) ? " like " : " = ").Append(" :FREE_FIELD3");
				param = new OracleParameter();
				param.ParameterName =":FREE_FIELD3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.FREE_FIELD3;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD3"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "FREE_FIELD3"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD2))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD2 ").Append((cause.FREE_FIELD2.StartsWith("%") || cause.FREE_FIELD2.EndsWith("%")) ? " like " : " = ").Append(" :FREE_FIELD2");
				param = new OracleParameter();
				param.ParameterName =":FREE_FIELD2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.FREE_FIELD2;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD2"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "FREE_FIELD2"));
			}
			if(!string.IsNullOrEmpty(cause.FUND_TYPE_ID))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID ").Append((cause.FUND_TYPE_ID.StartsWith("%") || cause.FUND_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :FUND_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":FUND_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.FUND_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUND_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "FUND_TYPE_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_TIME < :CREATE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_TIME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_USER_ID_NAME))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID_NAME ").Append((cause.DEPT_USER_ID_NAME.StartsWith("%") || cause.DEPT_USER_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :DEPT_USER_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":DEPT_USER_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DEPT_USER_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_USER_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "DEPT_USER_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "BUDGET_YEAR"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_IDEA))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FINANCE_IDEA ").Append((cause.FINANCE_IDEA.StartsWith("%") || cause.FINANCE_IDEA.EndsWith("%")) ? " like " : " = ").Append(" :FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName =":FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_IDEA"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "FINANCE_IDEA"));
			}
			if(!string.IsNullOrEmpty(cause.DECALRE_CAUSE))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DECALRE_CAUSE ").Append((cause.DECALRE_CAUSE.StartsWith("%") || cause.DECALRE_CAUSE.EndsWith("%")) ? " like " : " = ").Append(" :DECALRE_CAUSE");
				param = new OracleParameter();
				param.ParameterName =":DECALRE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2000;
				param.Value = cause.DECALRE_CAUSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DECALRE_CAUSE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "DECALRE_CAUSE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.BGT_D_BUDGET_ITEM_ID_NAME))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID_NAME ").Append((cause.BGT_D_BUDGET_ITEM_ID_NAME.StartsWith("%") || cause.BGT_D_BUDGET_ITEM_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :BGT_D_BUDGET_ITEM_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":BGT_D_BUDGET_ITEM_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.BGT_D_BUDGET_ITEM_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BGT_D_BUDGET_ITEM_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "BGT_D_BUDGET_ITEM_ID_NAME"));
			}
			if(cause.CONTROL_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CONTROL_MONEY = :CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName =":CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CONTROL_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTROL_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "CONTROL_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.IS_PERFORMANCE_NAME))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE_NAME ").Append((cause.IS_PERFORMANCE_NAME.StartsWith("%") || cause.IS_PERFORMANCE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :IS_PERFORMANCE_NAME");
				param = new OracleParameter();
				param.ParameterName =":IS_PERFORMANCE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = cause.IS_PERFORMANCE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_PERFORMANCE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "IS_PERFORMANCE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD))
			{
				strBuf.Append(" And V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD ").Append((cause.FREE_FIELD.StartsWith("%") || cause.FREE_FIELD.EndsWith("%")) ? " like " : " = ").Append(" :FREE_FIELD");
				param = new OracleParameter();
				param.ParameterName =":FREE_FIELD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FREE_FIELD;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND", "FREE_FIELD"));
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
		public static DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] Query(CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
            string sSql = " select  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ITEM_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_MONEY, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_ATTACH, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DATA_ORGANISE_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_TIME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CODE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD3, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD2, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_TIME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FINANCE_IDEA, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DECALRE_CAUSE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.COMMENTS, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CONTROL_MONEY, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD,V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_MONEY1,V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CONTROL_MONEY1 from V_BGT_BGT_B_DEPT_PAY_YEAR_FUND where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FUND_TYPE_ID_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ATTACH = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_FIXED_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.DEPT_USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IS_PERFORMANCE_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FREE_FIELD = sqlReader.GetString(35);
                if (!sqlReader.IsDBNull(36))
                    dataObj.FUND_MONEY1 = sqlReader.GetDecimal(36);
                if (!sqlReader.IsDBNull(37))
                    dataObj.CONTROL_MONEY1 = sqlReader.GetDecimal(37);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] objs = new DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_BGT_BGT_B_DEPT_PAY_YEAR_FUND where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] Query(CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ITEM_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_MONEY, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_ATTACH, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DATA_ORGANISE_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_TIME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CODE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD3, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD2, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_TIME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FINANCE_IDEA, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DECALRE_CAUSE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.COMMENTS, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CONTROL_MONEY, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD from V_BGT_BGT_B_DEPT_PAY_YEAR_FUND where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FUND_TYPE_ID_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ATTACH = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_FIXED_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.DEPT_USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IS_PERFORMANCE_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FREE_FIELD = sqlReader.GetString(35);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] objs = new DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] Query(CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
            string sSql = " select  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ITEM_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_MONEY, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_ATTACH, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DATA_ORGANISE_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_TIME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CODE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD3, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD2, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_TIME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FINANCE_IDEA, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DECALRE_CAUSE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.COMMENTS, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CONTROL_MONEY, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD,V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_MONEY1,V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CONTROL_MONEY1,V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FINANCE_IDEA1,V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ISAGREE,V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DECALRE_CAUSE1 from V_BGT_BGT_B_DEPT_PAY_YEAR_FUND where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FUND_TYPE_ID_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ATTACH = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_FIXED_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.DEPT_USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IS_PERFORMANCE_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FREE_FIELD = sqlReader.GetString(35);
                if (!sqlReader.IsDBNull(36))
                    dataObj.FUND_MONEY1 = sqlReader.GetDecimal(36);
                if (!sqlReader.IsDBNull(37))
                    dataObj.CONTROL_MONEY1 = sqlReader.GetDecimal(37);
                if (!sqlReader.IsDBNull(38))
                    dataObj.FINANCE_IDEA1 = sqlReader.GetString(38);
                if (!sqlReader.IsDBNull(39))
                    dataObj.ISAGREE = sqlReader.GetString(39);
                if (!sqlReader.IsDBNull(40))
                    dataObj.DECALRE_CAUSE1 = sqlReader.GetString(40);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] objs = new DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] Query(CauseObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ITEM_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_MONEY, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_ATTACH, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DATA_ORGANISE_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_TIME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CODE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_DEPT_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD3, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD2, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_TIME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_USER_ID, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FINANCE_IDEA, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DECALRE_CAUSE, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.COMMENTS, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CONTROL_MONEY, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE_NAME, V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD from V_BGT_BGT_B_DEPT_PAY_YEAR_FUND where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_BGT_B_DEPT_PAY_YEAR_FUND",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FUND_TYPE_ID_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ATTACH = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CODE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_FIXED_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.DEPT_USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IS_PERFORMANCE_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FREE_FIELD = sqlReader.GetString(35);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[] objs = new DisplayObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_BGT_BGT_B_DEPT_PAY_YEAR_FUND obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ITEM_NAME"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ITEM_NAME = :ITEM_NAME");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.ITEM_NAME) ? string.Empty : obj.ITEM_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FUND_MONEY"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_MONEY = :FUND_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":FUND_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.FUND_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FUND_TYPE_ID_NAME"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID_NAME = :FUND_TYPE_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":FUND_TYPE_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FUND_TYPE_ID_NAME) ? string.Empty : obj.FUND_TYPE_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR_NAME"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR_NAME = :BUDGET_YEAR_NAME");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_YEAR_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR_NAME) ? string.Empty : obj.BUDGET_YEAR_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_ATTACH"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_ATTACH = :IS_ATTACH");
				param = new OracleParameter();
				param.ParameterName = ":IS_ATTACH";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = string.IsNullOrEmpty(obj.IS_ATTACH) ? string.Empty : obj.IS_ATTACH;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BGT_D_BUDGET_ITEM_ID"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID = :BGT_D_BUDGET_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":BGT_D_BUDGET_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BGT_D_BUDGET_ITEM_ID) ? string.Empty : obj.BGT_D_BUDGET_ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE_NAME"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE_NAME = :STATE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = string.IsNullOrEmpty(obj.STATE_NAME) ? string.Empty : obj.STATE_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_DEPT_ID_NAME"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID_NAME = :BUDGET_DEPT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_DEPT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_DEPT_ID_NAME) ? string.Empty : obj.BUDGET_DEPT_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_DEPT_ID = :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_PERFORMANCE"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE = :IS_PERFORMANCE");
				param = new OracleParameter();
				param.ParameterName = ":IS_PERFORMANCE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_PERFORMANCE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_USER_ID"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID = :DEPT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":DEPT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_USER_ID) ? string.Empty : obj.DEPT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_FIXED"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED = :IS_FIXED");
				param = new OracleParameter();
				param.ParameterName = ":IS_FIXED";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_FIXED;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_DEPT_ID"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_DEPT_ID = :BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_DEPT_ID) ? string.Empty : obj.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CREATE_DEPT_ID = :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_FIXED_NAME"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_FIXED_NAME = :IS_FIXED_NAME");
				param = new OracleParameter();
				param.ParameterName = ":IS_FIXED_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = string.IsNullOrEmpty(obj.IS_FIXED_NAME) ? string.Empty : obj.IS_FIXED_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD3"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD3 = :FREE_FIELD3");
				param = new OracleParameter();
				param.ParameterName = ":FREE_FIELD3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD3) ? string.Empty : obj.FREE_FIELD3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD2"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD2 = :FREE_FIELD2");
				param = new OracleParameter();
				param.ParameterName = ":FREE_FIELD2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD2) ? string.Empty : obj.FREE_FIELD2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FUND_TYPE_ID"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FUND_TYPE_ID = :FUND_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":FUND_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.FUND_TYPE_ID) ? string.Empty : obj.FUND_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_USER_ID_NAME"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DEPT_USER_ID_NAME = :DEPT_USER_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":DEPT_USER_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.DEPT_USER_ID_NAME) ? string.Empty : obj.DEPT_USER_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BUDGET_YEAR = :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_IDEA"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FINANCE_IDEA = :FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName = ":FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_IDEA) ? string.Empty : obj.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DECALRE_CAUSE"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.DECALRE_CAUSE = :DECALRE_CAUSE");
				param = new OracleParameter();
				param.ParameterName = ":DECALRE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2000;
				param.Value = string.IsNullOrEmpty(obj.DECALRE_CAUSE) ? string.Empty : obj.DECALRE_CAUSE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BGT_D_BUDGET_ITEM_ID_NAME"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.BGT_D_BUDGET_ITEM_ID_NAME = :BGT_D_BUDGET_ITEM_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":BGT_D_BUDGET_ITEM_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.BGT_D_BUDGET_ITEM_ID_NAME) ? string.Empty : obj.BGT_D_BUDGET_ITEM_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONTROL_MONEY"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.CONTROL_MONEY = :CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CONTROL_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_PERFORMANCE_NAME"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.IS_PERFORMANCE_NAME = :IS_PERFORMANCE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":IS_PERFORMANCE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = string.IsNullOrEmpty(obj.IS_PERFORMANCE_NAME) ? string.Empty : obj.IS_PERFORMANCE_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD"))
			{
				strBuf.Add("  V_BGT_BGT_B_DEPT_PAY_YEAR_FUND.FREE_FIELD = :FREE_FIELD");
				param = new OracleParameter();
				param.ParameterName = ":FREE_FIELD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD) ? string.Empty : obj.FREE_FIELD;
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
