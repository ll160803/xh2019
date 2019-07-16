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
	[CauseObject(typeof(CauseObject_V_BGT_FIRST_UP))]
	public partial class HelperObject_V_BGT_FIRST_UP
	{		
		#region Method Blok
		public static int Save(EntityObject_V_BGT_FIRST_UP obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_BGT_FIRST_UP( F_FREE_FIELD2, F_AMOUNT, F_COMPLETE_TIME, BUILDING_NAME, F_ACCOUNT_ITEM_ID, F_BGT_D_ACCOUNT_ITEM_ID, ID, F_FINANCE_IDEA, COMPLETE_TIME, BGT_D_ACCOUNT_ITEM_ID, F_ASSET_NAME, ASSET_ID, F_BUILDING_NAME, F_MONEY, F_FUND_NAME, ASSET_NAME, AMOUNT, DECLARE_CAUSE, F_FREE_FIELD, F_ASSET_ID, F_CONTROL_MONEY, FREE_FIELD3, FREE_FIELD2, ACCOUNT_ITEM_ID, F_PRICE, MONEY, FUND_NAME, F_DECLARE_CAUSE, F_FREE_FIELD3, PRICE, FINANCE_IDEA, BASE_ID, CONTROL_MONEY, FREE_FIELD) values ( :F_FREE_FIELD2, :F_AMOUNT, :F_COMPLETE_TIME, :BUILDING_NAME, :F_ACCOUNT_ITEM_ID, :F_BGT_D_ACCOUNT_ITEM_ID, :ID, :F_FINANCE_IDEA, :COMPLETE_TIME, :BGT_D_ACCOUNT_ITEM_ID, :F_ASSET_NAME, :ASSET_ID, :F_BUILDING_NAME, :F_MONEY, :F_FUND_NAME, :ASSET_NAME, :AMOUNT, :DECLARE_CAUSE, :F_FREE_FIELD, :F_ASSET_ID, :F_CONTROL_MONEY, :FREE_FIELD3, :FREE_FIELD2, :ACCOUNT_ITEM_ID, :F_PRICE, :MONEY, :FUND_NAME, :F_DECLARE_CAUSE, :F_FREE_FIELD3, :PRICE, :FINANCE_IDEA, :BASE_ID, :CONTROL_MONEY, :FREE_FIELD)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[34];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":F_FREE_FIELD2";
			parameters[0].Size = 200;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.F_FREE_FIELD2 == null ? String.Empty:obj.F_FREE_FIELD2;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":F_AMOUNT";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.F_AMOUNT;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":F_COMPLETE_TIME";
			parameters[2].Size = 7;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[2].Value = obj.F_COMPLETE_TIME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":BUILDING_NAME";
			parameters[3].Size = 220;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.BUILDING_NAME == null ? String.Empty:obj.BUILDING_NAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":F_ACCOUNT_ITEM_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.F_ACCOUNT_ITEM_ID == null ? String.Empty:obj.F_ACCOUNT_ITEM_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":F_BGT_D_ACCOUNT_ITEM_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.F_BGT_D_ACCOUNT_ITEM_ID == null ? String.Empty:obj.F_BGT_D_ACCOUNT_ITEM_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":F_FINANCE_IDEA";
			parameters[7].Size = 800;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.F_FINANCE_IDEA == null ? String.Empty:obj.F_FINANCE_IDEA;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":COMPLETE_TIME";
			parameters[8].Size = 7;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[8].Value = obj.COMPLETE_TIME;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":BGT_D_ACCOUNT_ITEM_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.BGT_D_ACCOUNT_ITEM_ID == null ? String.Empty:obj.BGT_D_ACCOUNT_ITEM_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":F_ASSET_NAME";
			parameters[10].Size = 100;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.F_ASSET_NAME == null ? String.Empty:obj.F_ASSET_NAME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":ASSET_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.ASSET_ID == null ? String.Empty:obj.ASSET_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":F_BUILDING_NAME";
			parameters[12].Size = 220;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.F_BUILDING_NAME == null ? String.Empty:obj.F_BUILDING_NAME;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":F_MONEY";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.F_MONEY;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":F_FUND_NAME";
			parameters[14].Size = 220;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.F_FUND_NAME == null ? String.Empty:obj.F_FUND_NAME;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":ASSET_NAME";
			parameters[15].Size = 100;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.ASSET_NAME == null ? String.Empty:obj.ASSET_NAME;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":AMOUNT";
			parameters[16].Size = 22;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[16].Value = obj.AMOUNT;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":DECLARE_CAUSE";
			parameters[17].Size = 800;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[17].Value = obj.DECLARE_CAUSE == null ? String.Empty:obj.DECLARE_CAUSE;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":F_FREE_FIELD";
			parameters[18].Size = 50;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.F_FREE_FIELD == null ? String.Empty:obj.F_FREE_FIELD;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":F_ASSET_ID";
			parameters[19].Size = 36;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[19].Value = obj.F_ASSET_ID == null ? String.Empty:obj.F_ASSET_ID;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":F_CONTROL_MONEY";
			parameters[20].Size = 22;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[20].Value = obj.F_CONTROL_MONEY;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":FREE_FIELD3";
			parameters[21].Size = 10;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[21].Value = obj.FREE_FIELD3 == null ? String.Empty:obj.FREE_FIELD3;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":FREE_FIELD2";
			parameters[22].Size = 200;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[22].Value = obj.FREE_FIELD2 == null ? String.Empty:obj.FREE_FIELD2;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":ACCOUNT_ITEM_ID";
			parameters[23].Size = 36;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[23].Value = obj.ACCOUNT_ITEM_ID == null ? String.Empty:obj.ACCOUNT_ITEM_ID;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":F_PRICE";
			parameters[24].Size = 22;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[24].Value = obj.F_PRICE;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":MONEY";
			parameters[25].Size = 22;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[25].Value = obj.MONEY;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":FUND_NAME";
			parameters[26].Size = 220;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[26].Value = obj.FUND_NAME == null ? String.Empty:obj.FUND_NAME;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":F_DECLARE_CAUSE";
			parameters[27].Size = 800;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[27].Value = obj.F_DECLARE_CAUSE == null ? String.Empty:obj.F_DECLARE_CAUSE;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":F_FREE_FIELD3";
			parameters[28].Size = 10;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[28].Value = obj.F_FREE_FIELD3 == null ? String.Empty:obj.F_FREE_FIELD3;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":PRICE";
			parameters[29].Size = 22;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[29].Value = obj.PRICE;
			parameters[30] = new OracleParameter();
			parameters[30].ParameterName =":FINANCE_IDEA";
			parameters[30].Size = 800;
			parameters[30].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[30].Value = obj.FINANCE_IDEA == null ? String.Empty:obj.FINANCE_IDEA;
			parameters[31] = new OracleParameter();
			parameters[31].ParameterName =":BASE_ID";
			parameters[31].Size = 36;
			parameters[31].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[31].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[32] = new OracleParameter();
			parameters[32].ParameterName =":CONTROL_MONEY";
			parameters[32].Size = 22;
			parameters[32].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[32].Value = obj.CONTROL_MONEY;
			parameters[33] = new OracleParameter();
			parameters[33].ParameterName =":FREE_FIELD";
			parameters[33].Size = 50;
			parameters[33].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[33].Value = obj.FREE_FIELD == null ? String.Empty:obj.FREE_FIELD;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_BGT_FIRST_UP obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_BGT_FIRST_UP set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_BGT_FIRST_UP obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_BGT_FIRST_UP where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_BGT_FIRST_UP Get(EntityObject_V_BGT_FIRST_UP obj)
		{
			
			//平台自动生成代码
			string sSql = "select  F_FREE_FIELD2, F_AMOUNT, F_COMPLETE_TIME, BUILDING_NAME, F_ACCOUNT_ITEM_ID, F_BGT_D_ACCOUNT_ITEM_ID, ID, F_FINANCE_IDEA, COMPLETE_TIME, BGT_D_ACCOUNT_ITEM_ID, F_ASSET_NAME, ASSET_ID, F_BUILDING_NAME, F_MONEY, F_FUND_NAME, ASSET_NAME, AMOUNT, DECLARE_CAUSE, F_FREE_FIELD, F_ASSET_ID, F_CONTROL_MONEY, FREE_FIELD3, FREE_FIELD2, ACCOUNT_ITEM_ID, F_PRICE, MONEY, FUND_NAME, F_DECLARE_CAUSE, F_FREE_FIELD3, PRICE, FINANCE_IDEA, BASE_ID, CONTROL_MONEY, FREE_FIELD from V_BGT_FIRST_UP where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_FIRST_UP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_FIRST_UP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.F_FREE_FIELD2 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.F_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.F_COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.F_ACCOUNT_ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.F_BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.F_FINANCE_IDEA = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.F_ASSET_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ASSET_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.F_BUILDING_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.F_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.F_FUND_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.F_FREE_FIELD = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.F_ASSET_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.F_CONTROL_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.F_PRICE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MONEY = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FUND_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.F_DECLARE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.F_FREE_FIELD3 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PRICE = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.BASE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.FREE_FIELD = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_BGT_FIRST_UP[] objs = new EntityObject_V_BGT_FIRST_UP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_BGT_FIRST_UP Get(EntityObject_V_BGT_FIRST_UP obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  F_FREE_FIELD2, F_AMOUNT, F_COMPLETE_TIME, BUILDING_NAME, F_ACCOUNT_ITEM_ID, F_BGT_D_ACCOUNT_ITEM_ID, ID, F_FINANCE_IDEA, COMPLETE_TIME, BGT_D_ACCOUNT_ITEM_ID, F_ASSET_NAME, ASSET_ID, F_BUILDING_NAME, F_MONEY, F_FUND_NAME, ASSET_NAME, AMOUNT, DECLARE_CAUSE, F_FREE_FIELD, F_ASSET_ID, F_CONTROL_MONEY, FREE_FIELD3, FREE_FIELD2, ACCOUNT_ITEM_ID, F_PRICE, MONEY, FUND_NAME, F_DECLARE_CAUSE, F_FREE_FIELD3, PRICE, FINANCE_IDEA, BASE_ID, CONTROL_MONEY, FREE_FIELD from V_BGT_FIRST_UP where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_FIRST_UP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_FIRST_UP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.F_FREE_FIELD2 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.F_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.F_COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.F_ACCOUNT_ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.F_BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.F_FINANCE_IDEA = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.F_ASSET_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ASSET_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.F_BUILDING_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.F_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.F_FUND_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.F_FREE_FIELD = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.F_ASSET_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.F_CONTROL_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.F_PRICE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MONEY = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FUND_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.F_DECLARE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.F_FREE_FIELD3 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PRICE = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.BASE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.FREE_FIELD = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_BGT_FIRST_UP[] objs = new EntityObject_V_BGT_FIRST_UP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_BGT_FIRST_UP[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_BGT_FIRST_UP.F_FREE_FIELD2, V_BGT_FIRST_UP.F_AMOUNT, V_BGT_FIRST_UP.F_COMPLETE_TIME, V_BGT_FIRST_UP.BUILDING_NAME, V_BGT_FIRST_UP.F_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_BGT_D_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.ID, V_BGT_FIRST_UP.F_FINANCE_IDEA, V_BGT_FIRST_UP.COMPLETE_TIME, V_BGT_FIRST_UP.BGT_D_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_ASSET_NAME, V_BGT_FIRST_UP.ASSET_ID, V_BGT_FIRST_UP.F_BUILDING_NAME, V_BGT_FIRST_UP.F_MONEY, V_BGT_FIRST_UP.F_FUND_NAME, V_BGT_FIRST_UP.ASSET_NAME, V_BGT_FIRST_UP.AMOUNT, V_BGT_FIRST_UP.DECLARE_CAUSE, V_BGT_FIRST_UP.F_FREE_FIELD, V_BGT_FIRST_UP.F_ASSET_ID, V_BGT_FIRST_UP.F_CONTROL_MONEY, V_BGT_FIRST_UP.FREE_FIELD3, V_BGT_FIRST_UP.FREE_FIELD2, V_BGT_FIRST_UP.ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_PRICE, V_BGT_FIRST_UP.MONEY, V_BGT_FIRST_UP.FUND_NAME, V_BGT_FIRST_UP.F_DECLARE_CAUSE, V_BGT_FIRST_UP.F_FREE_FIELD3, V_BGT_FIRST_UP.PRICE, V_BGT_FIRST_UP.FINANCE_IDEA, V_BGT_FIRST_UP.BASE_ID, V_BGT_FIRST_UP.CONTROL_MONEY, V_BGT_FIRST_UP.FREE_FIELD from V_BGT_FIRST_UP where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_BGT_FIRST_UP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_FIRST_UP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.F_FREE_FIELD2 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.F_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.F_COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.F_ACCOUNT_ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.F_BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.F_FINANCE_IDEA = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.F_ASSET_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ASSET_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.F_BUILDING_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.F_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.F_FUND_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.F_FREE_FIELD = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.F_ASSET_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.F_CONTROL_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.F_PRICE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MONEY = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FUND_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.F_DECLARE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.F_FREE_FIELD3 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PRICE = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.BASE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.FREE_FIELD = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_FIRST_UP[] objs = new DisplayObject_V_BGT_FIRST_UP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_BGT_FIRST_UP cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.F_FREE_FIELD2))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_FREE_FIELD2 ").Append((cause.F_FREE_FIELD2.StartsWith("%") || cause.F_FREE_FIELD2.EndsWith("%")) ? " like " : " = ").Append(" :F_FREE_FIELD2");
				param = new OracleParameter();
				param.ParameterName =":F_FREE_FIELD2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.F_FREE_FIELD2;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_FREE_FIELD2"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_FREE_FIELD2"));
			}
			if(cause.F_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_AMOUNT = :F_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":F_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.F_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_AMOUNT"));
			}
			if(cause.F_COMPLETE_TIME!= null)
			{
				if (cause.F_COMPLETE_TIME.Begin != null)
				{
					strBuf.Append(" And V_BGT_FIRST_UP.F_COMPLETE_TIME >= :F_COMPLETE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":F_COMPLETE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.F_COMPLETE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.F_COMPLETE_TIME.End != null)
				{
					strBuf.Append(" And V_BGT_FIRST_UP.F_COMPLETE_TIME < :F_COMPLETE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":F_COMPLETE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.F_COMPLETE_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("F_COMPLETE_TIME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_COMPLETE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.BUILDING_NAME))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.BUILDING_NAME ").Append((cause.BUILDING_NAME.StartsWith("%") || cause.BUILDING_NAME.EndsWith("%")) ? " like " : " = ").Append(" :BUILDING_NAME");
				param = new OracleParameter();
				param.ParameterName =":BUILDING_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 220;
				param.Value = cause.BUILDING_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUILDING_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "BUILDING_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.F_ACCOUNT_ITEM_ID))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_ACCOUNT_ITEM_ID ").Append((cause.F_ACCOUNT_ITEM_ID.StartsWith("%") || cause.F_ACCOUNT_ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :F_ACCOUNT_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":F_ACCOUNT_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.F_ACCOUNT_ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_ACCOUNT_ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_ACCOUNT_ITEM_ID"));
			}
			if(!string.IsNullOrEmpty(cause.F_BGT_D_ACCOUNT_ITEM_ID))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_BGT_D_ACCOUNT_ITEM_ID ").Append((cause.F_BGT_D_ACCOUNT_ITEM_ID.StartsWith("%") || cause.F_BGT_D_ACCOUNT_ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :F_BGT_D_ACCOUNT_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":F_BGT_D_ACCOUNT_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.F_BGT_D_ACCOUNT_ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_BGT_D_ACCOUNT_ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_BGT_D_ACCOUNT_ITEM_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.F_FINANCE_IDEA))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_FINANCE_IDEA ").Append((cause.F_FINANCE_IDEA.StartsWith("%") || cause.F_FINANCE_IDEA.EndsWith("%")) ? " like " : " = ").Append(" :F_FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName =":F_FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 800;
				param.Value = cause.F_FINANCE_IDEA;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_FINANCE_IDEA"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_FINANCE_IDEA"));
			}
			if(cause.COMPLETE_TIME!= null)
			{
				if (cause.COMPLETE_TIME.Begin != null)
				{
					strBuf.Append(" And V_BGT_FIRST_UP.COMPLETE_TIME >= :COMPLETE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":COMPLETE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.COMPLETE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.COMPLETE_TIME.End != null)
				{
					strBuf.Append(" And V_BGT_FIRST_UP.COMPLETE_TIME < :COMPLETE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":COMPLETE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.COMPLETE_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("COMPLETE_TIME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "COMPLETE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.BGT_D_ACCOUNT_ITEM_ID))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.BGT_D_ACCOUNT_ITEM_ID ").Append((cause.BGT_D_ACCOUNT_ITEM_ID.StartsWith("%") || cause.BGT_D_ACCOUNT_ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :BGT_D_ACCOUNT_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":BGT_D_ACCOUNT_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BGT_D_ACCOUNT_ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BGT_D_ACCOUNT_ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "BGT_D_ACCOUNT_ITEM_ID"));
			}
			if(!string.IsNullOrEmpty(cause.F_ASSET_NAME))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_ASSET_NAME ").Append((cause.F_ASSET_NAME.StartsWith("%") || cause.F_ASSET_NAME.EndsWith("%")) ? " like " : " = ").Append(" :F_ASSET_NAME");
				param = new OracleParameter();
				param.ParameterName =":F_ASSET_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.F_ASSET_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_ASSET_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_ASSET_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ASSET_ID))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.ASSET_ID ").Append((cause.ASSET_ID.StartsWith("%") || cause.ASSET_ID.EndsWith("%")) ? " like " : " = ").Append(" :ASSET_ID");
				param = new OracleParameter();
				param.ParameterName =":ASSET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSET_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "ASSET_ID"));
			}
			if(!string.IsNullOrEmpty(cause.F_BUILDING_NAME))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_BUILDING_NAME ").Append((cause.F_BUILDING_NAME.StartsWith("%") || cause.F_BUILDING_NAME.EndsWith("%")) ? " like " : " = ").Append(" :F_BUILDING_NAME");
				param = new OracleParameter();
				param.ParameterName =":F_BUILDING_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 220;
				param.Value = cause.F_BUILDING_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_BUILDING_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_BUILDING_NAME"));
			}
			if(cause.F_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_MONEY = :F_MONEY");
				param = new OracleParameter();
				param.ParameterName =":F_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.F_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.F_FUND_NAME))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_FUND_NAME ").Append((cause.F_FUND_NAME.StartsWith("%") || cause.F_FUND_NAME.EndsWith("%")) ? " like " : " = ").Append(" :F_FUND_NAME");
				param = new OracleParameter();
				param.ParameterName =":F_FUND_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 220;
				param.Value = cause.F_FUND_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_FUND_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_FUND_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ASSET_NAME))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.ASSET_NAME ").Append((cause.ASSET_NAME.StartsWith("%") || cause.ASSET_NAME.EndsWith("%")) ? " like " : " = ").Append(" :ASSET_NAME");
				param = new OracleParameter();
				param.ParameterName =":ASSET_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.ASSET_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "ASSET_NAME"));
			}
			if(cause.AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_FIRST_UP.AMOUNT = :AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.DECLARE_CAUSE))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.DECLARE_CAUSE ").Append((cause.DECLARE_CAUSE.StartsWith("%") || cause.DECLARE_CAUSE.EndsWith("%")) ? " like " : " = ").Append(" :DECLARE_CAUSE");
				param = new OracleParameter();
				param.ParameterName =":DECLARE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 800;
				param.Value = cause.DECLARE_CAUSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DECLARE_CAUSE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "DECLARE_CAUSE"));
			}
			if(!string.IsNullOrEmpty(cause.F_FREE_FIELD))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_FREE_FIELD ").Append((cause.F_FREE_FIELD.StartsWith("%") || cause.F_FREE_FIELD.EndsWith("%")) ? " like " : " = ").Append(" :F_FREE_FIELD");
				param = new OracleParameter();
				param.ParameterName =":F_FREE_FIELD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.F_FREE_FIELD;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_FREE_FIELD"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_FREE_FIELD"));
			}
			if(!string.IsNullOrEmpty(cause.F_ASSET_ID))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_ASSET_ID ").Append((cause.F_ASSET_ID.StartsWith("%") || cause.F_ASSET_ID.EndsWith("%")) ? " like " : " = ").Append(" :F_ASSET_ID");
				param = new OracleParameter();
				param.ParameterName =":F_ASSET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.F_ASSET_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_ASSET_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_ASSET_ID"));
			}
			if(cause.F_CONTROL_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_CONTROL_MONEY = :F_CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName =":F_CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.F_CONTROL_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_CONTROL_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_CONTROL_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD3))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.FREE_FIELD3 ").Append((cause.FREE_FIELD3.StartsWith("%") || cause.FREE_FIELD3.EndsWith("%")) ? " like " : " = ").Append(" :FREE_FIELD3");
				param = new OracleParameter();
				param.ParameterName =":FREE_FIELD3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.FREE_FIELD3;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD3"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "FREE_FIELD3"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD2))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.FREE_FIELD2 ").Append((cause.FREE_FIELD2.StartsWith("%") || cause.FREE_FIELD2.EndsWith("%")) ? " like " : " = ").Append(" :FREE_FIELD2");
				param = new OracleParameter();
				param.ParameterName =":FREE_FIELD2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.FREE_FIELD2;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD2"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "FREE_FIELD2"));
			}
			if(!string.IsNullOrEmpty(cause.ACCOUNT_ITEM_ID))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.ACCOUNT_ITEM_ID ").Append((cause.ACCOUNT_ITEM_ID.StartsWith("%") || cause.ACCOUNT_ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :ACCOUNT_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":ACCOUNT_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ACCOUNT_ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCOUNT_ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "ACCOUNT_ITEM_ID"));
			}
			if(cause.F_PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_PRICE = :F_PRICE");
				param = new OracleParameter();
				param.ParameterName =":F_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.F_PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_PRICE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_PRICE"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_FIRST_UP.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName =":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.FUND_NAME))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.FUND_NAME ").Append((cause.FUND_NAME.StartsWith("%") || cause.FUND_NAME.EndsWith("%")) ? " like " : " = ").Append(" :FUND_NAME");
				param = new OracleParameter();
				param.ParameterName =":FUND_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 220;
				param.Value = cause.FUND_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUND_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "FUND_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.F_DECLARE_CAUSE))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_DECLARE_CAUSE ").Append((cause.F_DECLARE_CAUSE.StartsWith("%") || cause.F_DECLARE_CAUSE.EndsWith("%")) ? " like " : " = ").Append(" :F_DECLARE_CAUSE");
				param = new OracleParameter();
				param.ParameterName =":F_DECLARE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 800;
				param.Value = cause.F_DECLARE_CAUSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_DECLARE_CAUSE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_DECLARE_CAUSE"));
			}
			if(!string.IsNullOrEmpty(cause.F_FREE_FIELD3))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.F_FREE_FIELD3 ").Append((cause.F_FREE_FIELD3.StartsWith("%") || cause.F_FREE_FIELD3.EndsWith("%")) ? " like " : " = ").Append(" :F_FREE_FIELD3");
				param = new OracleParameter();
				param.ParameterName =":F_FREE_FIELD3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.F_FREE_FIELD3;
				paramList.Add(param);
			}
			if (cause.HasINValue("F_FREE_FIELD3"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "F_FREE_FIELD3"));
			}
			if(cause.PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_FIRST_UP.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName =":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRICE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "PRICE"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_IDEA))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.FINANCE_IDEA ").Append((cause.FINANCE_IDEA.StartsWith("%") || cause.FINANCE_IDEA.EndsWith("%")) ? " like " : " = ").Append(" :FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName =":FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 800;
				param.Value = cause.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_IDEA"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "FINANCE_IDEA"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "BASE_ID"));
			}
			if(cause.CONTROL_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_FIRST_UP.CONTROL_MONEY = :CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName =":CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CONTROL_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTROL_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "CONTROL_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD))
			{
				strBuf.Append(" And V_BGT_FIRST_UP.FREE_FIELD ").Append((cause.FREE_FIELD.StartsWith("%") || cause.FREE_FIELD.EndsWith("%")) ? " like " : " = ").Append(" :FREE_FIELD");
				param = new OracleParameter();
				param.ParameterName =":FREE_FIELD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FREE_FIELD;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_FIRST_UP", "FREE_FIELD"));
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
		public static DisplayObject_V_BGT_FIRST_UP[] Query(CauseObject_V_BGT_FIRST_UP cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_FIRST_UP.F_FREE_FIELD2, V_BGT_FIRST_UP.F_AMOUNT, V_BGT_FIRST_UP.F_COMPLETE_TIME, V_BGT_FIRST_UP.BUILDING_NAME, V_BGT_FIRST_UP.F_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_BGT_D_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.ID, V_BGT_FIRST_UP.F_FINANCE_IDEA, V_BGT_FIRST_UP.COMPLETE_TIME, V_BGT_FIRST_UP.BGT_D_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_ASSET_NAME, V_BGT_FIRST_UP.ASSET_ID, V_BGT_FIRST_UP.F_BUILDING_NAME, V_BGT_FIRST_UP.F_MONEY, V_BGT_FIRST_UP.F_FUND_NAME, V_BGT_FIRST_UP.ASSET_NAME, V_BGT_FIRST_UP.AMOUNT, V_BGT_FIRST_UP.DECLARE_CAUSE, V_BGT_FIRST_UP.F_FREE_FIELD, V_BGT_FIRST_UP.F_ASSET_ID, V_BGT_FIRST_UP.F_CONTROL_MONEY, V_BGT_FIRST_UP.FREE_FIELD3, V_BGT_FIRST_UP.FREE_FIELD2, V_BGT_FIRST_UP.ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_PRICE, V_BGT_FIRST_UP.MONEY, V_BGT_FIRST_UP.FUND_NAME, V_BGT_FIRST_UP.F_DECLARE_CAUSE, V_BGT_FIRST_UP.F_FREE_FIELD3, V_BGT_FIRST_UP.PRICE, V_BGT_FIRST_UP.FINANCE_IDEA, V_BGT_FIRST_UP.BASE_ID, V_BGT_FIRST_UP.CONTROL_MONEY, V_BGT_FIRST_UP.FREE_FIELD from V_BGT_FIRST_UP where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_FIRST_UP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_FIRST_UP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.F_FREE_FIELD2 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.F_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.F_COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.F_ACCOUNT_ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.F_BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.F_FINANCE_IDEA = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.F_ASSET_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ASSET_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.F_BUILDING_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.F_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.F_FUND_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.F_FREE_FIELD = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.F_ASSET_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.F_CONTROL_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.F_PRICE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MONEY = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FUND_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.F_DECLARE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.F_FREE_FIELD3 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PRICE = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.BASE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.FREE_FIELD = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_FIRST_UP[] objs = new DisplayObject_V_BGT_FIRST_UP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_BGT_FIRST_UP cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_BGT_FIRST_UP where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_BGT_FIRST_UP[] Query(CauseObject_V_BGT_FIRST_UP cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_FIRST_UP.F_FREE_FIELD2, V_BGT_FIRST_UP.F_AMOUNT, V_BGT_FIRST_UP.F_COMPLETE_TIME, V_BGT_FIRST_UP.BUILDING_NAME, V_BGT_FIRST_UP.F_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_BGT_D_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.ID, V_BGT_FIRST_UP.F_FINANCE_IDEA, V_BGT_FIRST_UP.COMPLETE_TIME, V_BGT_FIRST_UP.BGT_D_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_ASSET_NAME, V_BGT_FIRST_UP.ASSET_ID, V_BGT_FIRST_UP.F_BUILDING_NAME, V_BGT_FIRST_UP.F_MONEY, V_BGT_FIRST_UP.F_FUND_NAME, V_BGT_FIRST_UP.ASSET_NAME, V_BGT_FIRST_UP.AMOUNT, V_BGT_FIRST_UP.DECLARE_CAUSE, V_BGT_FIRST_UP.F_FREE_FIELD, V_BGT_FIRST_UP.F_ASSET_ID, V_BGT_FIRST_UP.F_CONTROL_MONEY, V_BGT_FIRST_UP.FREE_FIELD3, V_BGT_FIRST_UP.FREE_FIELD2, V_BGT_FIRST_UP.ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_PRICE, V_BGT_FIRST_UP.MONEY, V_BGT_FIRST_UP.FUND_NAME, V_BGT_FIRST_UP.F_DECLARE_CAUSE, V_BGT_FIRST_UP.F_FREE_FIELD3, V_BGT_FIRST_UP.PRICE, V_BGT_FIRST_UP.FINANCE_IDEA, V_BGT_FIRST_UP.BASE_ID, V_BGT_FIRST_UP.CONTROL_MONEY, V_BGT_FIRST_UP.FREE_FIELD from V_BGT_FIRST_UP where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_FIRST_UP dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_FIRST_UP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.F_FREE_FIELD2 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.F_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.F_COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.F_ACCOUNT_ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.F_BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.F_FINANCE_IDEA = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.F_ASSET_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ASSET_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.F_BUILDING_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.F_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.F_FUND_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.F_FREE_FIELD = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.F_ASSET_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.F_CONTROL_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.F_PRICE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MONEY = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FUND_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.F_DECLARE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.F_FREE_FIELD3 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PRICE = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.BASE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.FREE_FIELD = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_FIRST_UP[] objs = new DisplayObject_V_BGT_FIRST_UP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_FIRST_UP[] Query(CauseObject_V_BGT_FIRST_UP cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_FIRST_UP.F_FREE_FIELD2, V_BGT_FIRST_UP.F_AMOUNT, V_BGT_FIRST_UP.F_COMPLETE_TIME, V_BGT_FIRST_UP.BUILDING_NAME, V_BGT_FIRST_UP.F_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_BGT_D_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.ID, V_BGT_FIRST_UP.F_FINANCE_IDEA, V_BGT_FIRST_UP.COMPLETE_TIME, V_BGT_FIRST_UP.BGT_D_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_ASSET_NAME, V_BGT_FIRST_UP.ASSET_ID, V_BGT_FIRST_UP.F_BUILDING_NAME, V_BGT_FIRST_UP.F_MONEY, V_BGT_FIRST_UP.F_FUND_NAME, V_BGT_FIRST_UP.ASSET_NAME, V_BGT_FIRST_UP.AMOUNT, V_BGT_FIRST_UP.DECLARE_CAUSE, V_BGT_FIRST_UP.F_FREE_FIELD, V_BGT_FIRST_UP.F_ASSET_ID, V_BGT_FIRST_UP.F_CONTROL_MONEY, V_BGT_FIRST_UP.FREE_FIELD3, V_BGT_FIRST_UP.FREE_FIELD2, V_BGT_FIRST_UP.ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_PRICE, V_BGT_FIRST_UP.MONEY, V_BGT_FIRST_UP.FUND_NAME, V_BGT_FIRST_UP.F_DECLARE_CAUSE, V_BGT_FIRST_UP.F_FREE_FIELD3, V_BGT_FIRST_UP.PRICE, V_BGT_FIRST_UP.FINANCE_IDEA, V_BGT_FIRST_UP.BASE_ID, V_BGT_FIRST_UP.CONTROL_MONEY, V_BGT_FIRST_UP.FREE_FIELD from V_BGT_FIRST_UP where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_FIRST_UP",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_BGT_FIRST_UP dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_FIRST_UP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.F_FREE_FIELD2 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.F_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.F_COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.F_ACCOUNT_ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.F_BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.F_FINANCE_IDEA = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.F_ASSET_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ASSET_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.F_BUILDING_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.F_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.F_FUND_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.F_FREE_FIELD = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.F_ASSET_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.F_CONTROL_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.F_PRICE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MONEY = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FUND_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.F_DECLARE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.F_FREE_FIELD3 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PRICE = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.BASE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.FREE_FIELD = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_FIRST_UP[] objs = new DisplayObject_V_BGT_FIRST_UP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_FIRST_UP[] Query(CauseObject_V_BGT_FIRST_UP cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_FIRST_UP.F_FREE_FIELD2, V_BGT_FIRST_UP.F_AMOUNT, V_BGT_FIRST_UP.F_COMPLETE_TIME, V_BGT_FIRST_UP.BUILDING_NAME, V_BGT_FIRST_UP.F_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_BGT_D_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.ID, V_BGT_FIRST_UP.F_FINANCE_IDEA, V_BGT_FIRST_UP.COMPLETE_TIME, V_BGT_FIRST_UP.BGT_D_ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_ASSET_NAME, V_BGT_FIRST_UP.ASSET_ID, V_BGT_FIRST_UP.F_BUILDING_NAME, V_BGT_FIRST_UP.F_MONEY, V_BGT_FIRST_UP.F_FUND_NAME, V_BGT_FIRST_UP.ASSET_NAME, V_BGT_FIRST_UP.AMOUNT, V_BGT_FIRST_UP.DECLARE_CAUSE, V_BGT_FIRST_UP.F_FREE_FIELD, V_BGT_FIRST_UP.F_ASSET_ID, V_BGT_FIRST_UP.F_CONTROL_MONEY, V_BGT_FIRST_UP.FREE_FIELD3, V_BGT_FIRST_UP.FREE_FIELD2, V_BGT_FIRST_UP.ACCOUNT_ITEM_ID, V_BGT_FIRST_UP.F_PRICE, V_BGT_FIRST_UP.MONEY, V_BGT_FIRST_UP.FUND_NAME, V_BGT_FIRST_UP.F_DECLARE_CAUSE, V_BGT_FIRST_UP.F_FREE_FIELD3, V_BGT_FIRST_UP.PRICE, V_BGT_FIRST_UP.FINANCE_IDEA, V_BGT_FIRST_UP.BASE_ID, V_BGT_FIRST_UP.CONTROL_MONEY, V_BGT_FIRST_UP.FREE_FIELD from V_BGT_FIRST_UP where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_FIRST_UP",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_BGT_FIRST_UP dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_FIRST_UP();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.F_FREE_FIELD2 = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.F_AMOUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.F_COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.F_ACCOUNT_ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.F_BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.F_FINANCE_IDEA = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.F_ASSET_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ASSET_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.F_BUILDING_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.F_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.F_FUND_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.F_FREE_FIELD = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.F_ASSET_ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.F_CONTROL_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.F_PRICE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MONEY = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FUND_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.F_DECLARE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.F_FREE_FIELD3 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PRICE = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.BASE_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.FREE_FIELD = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_FIRST_UP[] objs = new DisplayObject_V_BGT_FIRST_UP[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_BGT_FIRST_UP obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("F_FREE_FIELD2"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_FREE_FIELD2 = :F_FREE_FIELD2");
				param = new OracleParameter();
				param.ParameterName = ":F_FREE_FIELD2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.F_FREE_FIELD2) ? string.Empty : obj.F_FREE_FIELD2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_AMOUNT"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_AMOUNT = :F_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":F_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.F_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_COMPLETE_TIME"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_COMPLETE_TIME = :F_COMPLETE_TIME");
				param = new OracleParameter();
				param.ParameterName = ":F_COMPLETE_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.F_COMPLETE_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUILDING_NAME"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.BUILDING_NAME = :BUILDING_NAME");
				param = new OracleParameter();
				param.ParameterName = ":BUILDING_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 220;
				param.Value = string.IsNullOrEmpty(obj.BUILDING_NAME) ? string.Empty : obj.BUILDING_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_ACCOUNT_ITEM_ID"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_ACCOUNT_ITEM_ID = :F_ACCOUNT_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":F_ACCOUNT_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.F_ACCOUNT_ITEM_ID) ? string.Empty : obj.F_ACCOUNT_ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_BGT_D_ACCOUNT_ITEM_ID"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_BGT_D_ACCOUNT_ITEM_ID = :F_BGT_D_ACCOUNT_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":F_BGT_D_ACCOUNT_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.F_BGT_D_ACCOUNT_ITEM_ID) ? string.Empty : obj.F_BGT_D_ACCOUNT_ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_FINANCE_IDEA"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_FINANCE_IDEA = :F_FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName = ":F_FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 800;
				param.Value = string.IsNullOrEmpty(obj.F_FINANCE_IDEA) ? string.Empty : obj.F_FINANCE_IDEA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMPLETE_TIME"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.COMPLETE_TIME = :COMPLETE_TIME");
				param = new OracleParameter();
				param.ParameterName = ":COMPLETE_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.COMPLETE_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BGT_D_ACCOUNT_ITEM_ID"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.BGT_D_ACCOUNT_ITEM_ID = :BGT_D_ACCOUNT_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":BGT_D_ACCOUNT_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BGT_D_ACCOUNT_ITEM_ID) ? string.Empty : obj.BGT_D_ACCOUNT_ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_ASSET_NAME"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_ASSET_NAME = :F_ASSET_NAME");
				param = new OracleParameter();
				param.ParameterName = ":F_ASSET_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.F_ASSET_NAME) ? string.Empty : obj.F_ASSET_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSET_ID"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.ASSET_ID = :ASSET_ID");
				param = new OracleParameter();
				param.ParameterName = ":ASSET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSET_ID) ? string.Empty : obj.ASSET_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_BUILDING_NAME"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_BUILDING_NAME = :F_BUILDING_NAME");
				param = new OracleParameter();
				param.ParameterName = ":F_BUILDING_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 220;
				param.Value = string.IsNullOrEmpty(obj.F_BUILDING_NAME) ? string.Empty : obj.F_BUILDING_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_MONEY"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_MONEY = :F_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":F_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.F_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_FUND_NAME"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_FUND_NAME = :F_FUND_NAME");
				param = new OracleParameter();
				param.ParameterName = ":F_FUND_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 220;
				param.Value = string.IsNullOrEmpty(obj.F_FUND_NAME) ? string.Empty : obj.F_FUND_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSET_NAME"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.ASSET_NAME = :ASSET_NAME");
				param = new OracleParameter();
				param.ParameterName = ":ASSET_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.ASSET_NAME) ? string.Empty : obj.ASSET_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AMOUNT"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.AMOUNT = :AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DECLARE_CAUSE"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.DECLARE_CAUSE = :DECLARE_CAUSE");
				param = new OracleParameter();
				param.ParameterName = ":DECLARE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 800;
				param.Value = string.IsNullOrEmpty(obj.DECLARE_CAUSE) ? string.Empty : obj.DECLARE_CAUSE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_FREE_FIELD"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_FREE_FIELD = :F_FREE_FIELD");
				param = new OracleParameter();
				param.ParameterName = ":F_FREE_FIELD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.F_FREE_FIELD) ? string.Empty : obj.F_FREE_FIELD;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_ASSET_ID"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_ASSET_ID = :F_ASSET_ID");
				param = new OracleParameter();
				param.ParameterName = ":F_ASSET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.F_ASSET_ID) ? string.Empty : obj.F_ASSET_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_CONTROL_MONEY"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_CONTROL_MONEY = :F_CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":F_CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.F_CONTROL_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD3"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.FREE_FIELD3 = :FREE_FIELD3");
				param = new OracleParameter();
				param.ParameterName = ":FREE_FIELD3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD3) ? string.Empty : obj.FREE_FIELD3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD2"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.FREE_FIELD2 = :FREE_FIELD2");
				param = new OracleParameter();
				param.ParameterName = ":FREE_FIELD2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD2) ? string.Empty : obj.FREE_FIELD2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ACCOUNT_ITEM_ID"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.ACCOUNT_ITEM_ID = :ACCOUNT_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":ACCOUNT_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ACCOUNT_ITEM_ID) ? string.Empty : obj.ACCOUNT_ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_PRICE"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_PRICE = :F_PRICE");
				param = new OracleParameter();
				param.ParameterName = ":F_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.F_PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName = ":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FUND_NAME"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.FUND_NAME = :FUND_NAME");
				param = new OracleParameter();
				param.ParameterName = ":FUND_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 220;
				param.Value = string.IsNullOrEmpty(obj.FUND_NAME) ? string.Empty : obj.FUND_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_DECLARE_CAUSE"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_DECLARE_CAUSE = :F_DECLARE_CAUSE");
				param = new OracleParameter();
				param.ParameterName = ":F_DECLARE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 800;
				param.Value = string.IsNullOrEmpty(obj.F_DECLARE_CAUSE) ? string.Empty : obj.F_DECLARE_CAUSE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("F_FREE_FIELD3"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.F_FREE_FIELD3 = :F_FREE_FIELD3");
				param = new OracleParameter();
				param.ParameterName = ":F_FREE_FIELD3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.F_FREE_FIELD3) ? string.Empty : obj.F_FREE_FIELD3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRICE"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName = ":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_IDEA"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.FINANCE_IDEA = :FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName = ":FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 800;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_IDEA) ? string.Empty : obj.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONTROL_MONEY"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.CONTROL_MONEY = :CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CONTROL_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD"))
			{
				strBuf.Add("  V_BGT_FIRST_UP.FREE_FIELD = :FREE_FIELD");
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
