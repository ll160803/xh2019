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
	[CauseObject(typeof(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND))]
	public partial class HelperObject_BGT_B_DEPT_PAY_YEAY_D_FUND
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
            string sSql = "insert into BGT_B_DEPT_PAY_YEAY_D_FUND( ACCOUNT_ITEM_ID, ID, COMPLETE_TIME, FINANCE_IDEA, BUILDING_NAME, FUND_NAME, PRICE, AMOUNT, MONEY, BASE_ID, FREE_FIELD, FREE_FIELD3, FREE_FIELD2, ASSET_ID, DECLARE_CAUSE, ASSET_NAME, BGT_D_ACCOUNT_ITEM_ID, CONTROL_MONEY, MONEY1, CONTROL_MONEY1) values ( :ACCOUNT_ITEM_ID, :ID, :COMPLETE_TIME, :FINANCE_IDEA, :BUILDING_NAME, :FUND_NAME, :PRICE, :AMOUNT, :MONEY, :BASE_ID, :FREE_FIELD, :FREE_FIELD3, :FREE_FIELD2, :ASSET_ID, :DECLARE_CAUSE, :ASSET_NAME, :BGT_D_ACCOUNT_ITEM_ID, :CONTROL_MONEY, :MONEY1, :CONTROL_MONEY1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[20];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ACCOUNT_ITEM_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ACCOUNT_ITEM_ID == null ? String.Empty:obj.ACCOUNT_ITEM_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":COMPLETE_TIME";
			parameters[2].Size = 7;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[2].Value = obj.COMPLETE_TIME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":FINANCE_IDEA";
			parameters[3].Size = 500;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.FINANCE_IDEA == null ? String.Empty:obj.FINANCE_IDEA;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":BUILDING_NAME";
			parameters[4].Size = 220;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.BUILDING_NAME == null ? String.Empty:obj.BUILDING_NAME;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":FUND_NAME";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.FUND_NAME == null ? String.Empty:obj.FUND_NAME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":PRICE";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.PRICE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":AMOUNT";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.AMOUNT;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":MONEY";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.MONEY;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":BASE_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":FREE_FIELD";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.FREE_FIELD == null ? String.Empty:obj.FREE_FIELD;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":FREE_FIELD3";
			parameters[11].Size = 10;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.FREE_FIELD3 == null ? String.Empty:obj.FREE_FIELD3;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":FREE_FIELD2";
			parameters[12].Size = 200;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.FREE_FIELD2 == null ? String.Empty:obj.FREE_FIELD2;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":ASSET_ID";
			parameters[13].Size = 36;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.ASSET_ID == null ? String.Empty:obj.ASSET_ID;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":DECLARE_CAUSE";
			parameters[14].Size = 200;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.DECLARE_CAUSE == null ? String.Empty:obj.DECLARE_CAUSE;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":ASSET_NAME";
			parameters[15].Size = 100;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.ASSET_NAME == null ? String.Empty:obj.ASSET_NAME;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":BGT_D_ACCOUNT_ITEM_ID";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.BGT_D_ACCOUNT_ITEM_ID == null ? String.Empty:obj.BGT_D_ACCOUNT_ITEM_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":CONTROL_MONEY";
			parameters[17].Size = 22;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[17].Value = obj.CONTROL_MONEY;
            parameters[18] = new OracleParameter();
            parameters[18].ParameterName = ":MONEY1";
            parameters[18].Size = 22;
            parameters[18].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[18].Value = obj.MONEY1;
            parameters[19] = new OracleParameter();
            parameters[19].ParameterName = ":CONTROL_MONEY1";
            parameters[19].Size = 22;
            parameters[19].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[19].Value = obj.CONTROL_MONEY1;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_DEPT_PAY_YEAY_D_FUND set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_DEPT_PAY_YEAY_D_FUND where  ID = :ID ";
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
		public static EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND Get(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ACCOUNT_ITEM_ID, ID, COMPLETE_TIME, FINANCE_IDEA, BUILDING_NAME, FUND_NAME, PRICE, AMOUNT, MONEY, BASE_ID, FREE_FIELD, FREE_FIELD3, FREE_FIELD2, ASSET_ID, DECLARE_CAUSE, ASSET_NAME, BGT_D_ACCOUNT_ITEM_ID, CONTROL_MONEY from BGT_B_DEPT_PAY_YEAY_D_FUND where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FUND_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREE_FIELD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSET_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] objs = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND Get(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ACCOUNT_ITEM_ID, ID, COMPLETE_TIME, FINANCE_IDEA, BUILDING_NAME, FUND_NAME, PRICE, AMOUNT, MONEY, BASE_ID, FREE_FIELD, FREE_FIELD3, FREE_FIELD2, ASSET_ID, DECLARE_CAUSE, ASSET_NAME, BGT_D_ACCOUNT_ITEM_ID, CONTROL_MONEY from BGT_B_DEPT_PAY_YEAY_D_FUND where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FUND_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREE_FIELD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSET_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] objs = new EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.ID, BGT_B_DEPT_PAY_YEAY_D_FUND.COMPLETE_TIME, BGT_B_DEPT_PAY_YEAY_D_FUND.FINANCE_IDEA, BGT_B_DEPT_PAY_YEAY_D_FUND.BUILDING_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.FUND_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.PRICE, BGT_B_DEPT_PAY_YEAY_D_FUND.AMOUNT, BGT_B_DEPT_PAY_YEAY_D_FUND.MONEY, BGT_B_DEPT_PAY_YEAY_D_FUND.BASE_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD3, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD2, BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.DECLARE_CAUSE, BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.CONTROL_MONEY, BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE.NAME as ACCOUNT_ITEM_ID_NAME, BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU.NAME as BGT_D_ACCOUNT_ITEM_ID_NAME from BGT_B_DEPT_PAY_YEAY_D_FUND left join BGT_D_ACCOUNT_ITEM   BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE on BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID = BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE.ID left join BGT_D_ACCOUNT_ITEM   BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU on BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID = BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FUND_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREE_FIELD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSET_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ACCOUNT_ITEM_ID_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] objs = new DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ACCOUNT_ITEM_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID ").Append((cause.ACCOUNT_ITEM_ID.StartsWith("%") || cause.ACCOUNT_ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :ACCOUNT_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":ACCOUNT_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ACCOUNT_ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCOUNT_ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "ACCOUNT_ITEM_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "ID"));
			}
			if(cause.COMPLETE_TIME!= null)
			{
				if (cause.COMPLETE_TIME.Begin != null)
				{
					strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.COMPLETE_TIME >= :COMPLETE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":COMPLETE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.COMPLETE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.COMPLETE_TIME.End != null)
				{
					strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.COMPLETE_TIME < :COMPLETE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "COMPLETE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_IDEA))
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.FINANCE_IDEA ").Append((cause.FINANCE_IDEA.StartsWith("%") || cause.FINANCE_IDEA.EndsWith("%")) ? " like " : " = ").Append(" :FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName =":FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_IDEA"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "FINANCE_IDEA"));
			}
			if(!string.IsNullOrEmpty(cause.BUILDING_NAME))
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.BUILDING_NAME ").Append((cause.BUILDING_NAME.StartsWith("%") || cause.BUILDING_NAME.EndsWith("%")) ? " like " : " = ").Append(" :BUILDING_NAME");
				param = new OracleParameter();
				param.ParameterName =":BUILDING_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 220;
				param.Value = cause.BUILDING_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUILDING_NAME"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "BUILDING_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.FUND_NAME))
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.FUND_NAME ").Append((cause.FUND_NAME.StartsWith("%") || cause.FUND_NAME.EndsWith("%")) ? " like " : " = ").Append(" :FUND_NAME");
				param = new OracleParameter();
				param.ParameterName =":FUND_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FUND_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUND_NAME"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "FUND_NAME"));
			}
			if(cause.PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName =":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRICE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "PRICE"));
			}
			if(cause.AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.AMOUNT = :AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "AMOUNT"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName =":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD))
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD ").Append((cause.FREE_FIELD.StartsWith("%") || cause.FREE_FIELD.EndsWith("%")) ? " like " : " = ").Append(" :FREE_FIELD");
				param = new OracleParameter();
				param.ParameterName =":FREE_FIELD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FREE_FIELD;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "FREE_FIELD"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD3))
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD3 ").Append((cause.FREE_FIELD3.StartsWith("%") || cause.FREE_FIELD3.EndsWith("%")) ? " like " : " = ").Append(" :FREE_FIELD3");
				param = new OracleParameter();
				param.ParameterName =":FREE_FIELD3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.FREE_FIELD3;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD3"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "FREE_FIELD3"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD2))
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD2 ").Append((cause.FREE_FIELD2.StartsWith("%") || cause.FREE_FIELD2.EndsWith("%")) ? " like " : " = ").Append(" :FREE_FIELD2");
				param = new OracleParameter();
				param.ParameterName =":FREE_FIELD2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.FREE_FIELD2;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD2"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "FREE_FIELD2"));
			}
			if(!string.IsNullOrEmpty(cause.ASSET_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_ID ").Append((cause.ASSET_ID.StartsWith("%") || cause.ASSET_ID.EndsWith("%")) ? " like " : " = ").Append(" :ASSET_ID");
				param = new OracleParameter();
				param.ParameterName =":ASSET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ASSET_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "ASSET_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DECLARE_CAUSE))
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.DECLARE_CAUSE ").Append((cause.DECLARE_CAUSE.StartsWith("%") || cause.DECLARE_CAUSE.EndsWith("%")) ? " like " : " = ").Append(" :DECLARE_CAUSE");
				param = new OracleParameter();
				param.ParameterName =":DECLARE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.DECLARE_CAUSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DECLARE_CAUSE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "DECLARE_CAUSE"));
			}
			if(!string.IsNullOrEmpty(cause.ASSET_NAME))
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_NAME ").Append((cause.ASSET_NAME.StartsWith("%") || cause.ASSET_NAME.EndsWith("%")) ? " like " : " = ").Append(" :ASSET_NAME");
				param = new OracleParameter();
				param.ParameterName =":ASSET_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.ASSET_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ASSET_NAME"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "ASSET_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BGT_D_ACCOUNT_ITEM_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID ").Append((cause.BGT_D_ACCOUNT_ITEM_ID.StartsWith("%") || cause.BGT_D_ACCOUNT_ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :BGT_D_ACCOUNT_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":BGT_D_ACCOUNT_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BGT_D_ACCOUNT_ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BGT_D_ACCOUNT_ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "BGT_D_ACCOUNT_ITEM_ID"));
			}
			if(cause.CONTROL_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_PAY_YEAY_D_FUND.CONTROL_MONEY = :CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName =":CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CONTROL_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTROL_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_PAY_YEAY_D_FUND", "CONTROL_MONEY"));
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
		public static DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] Query(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
            string sSql = " select  BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.ID, BGT_B_DEPT_PAY_YEAY_D_FUND.COMPLETE_TIME, BGT_B_DEPT_PAY_YEAY_D_FUND.FINANCE_IDEA, BGT_B_DEPT_PAY_YEAY_D_FUND.BUILDING_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.FUND_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.PRICE, BGT_B_DEPT_PAY_YEAY_D_FUND.AMOUNT, BGT_B_DEPT_PAY_YEAY_D_FUND.MONEY, BGT_B_DEPT_PAY_YEAY_D_FUND.BASE_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD3, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD2, BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.DECLARE_CAUSE, BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.CONTROL_MONEY, BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE.NAME as ACCOUNT_ITEM_ID_NAME, BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU.NAME as BGT_D_ACCOUNT_ITEM_ID_NAME,BGT_B_DEPT_PAY_YEAY_D_FUND.MONEY1,BGT_B_DEPT_PAY_YEAY_D_FUND.CONTROL_MONEY1, BGT_B_DEPT_PAY_YEAY_D_FUND.FINANCE_IDEA1 from BGT_B_DEPT_PAY_YEAY_D_FUND left join BGT_D_ACCOUNT_ITEM   BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE on BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID = BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE.ID left join BGT_D_ACCOUNT_ITEM   BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU on BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID = BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FUND_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREE_FIELD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSET_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ACCOUNT_ITEM_ID_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID_NAME = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.MONEY1 = sqlReader.GetDecimal(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.CONTROL_MONEY1 = sqlReader.GetDecimal(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.FINANCE_IDEA1 = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] objs = new DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_DEPT_PAY_YEAY_D_FUND where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] Query(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.ID, BGT_B_DEPT_PAY_YEAY_D_FUND.COMPLETE_TIME, BGT_B_DEPT_PAY_YEAY_D_FUND.FINANCE_IDEA, BGT_B_DEPT_PAY_YEAY_D_FUND.BUILDING_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.FUND_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.PRICE, BGT_B_DEPT_PAY_YEAY_D_FUND.AMOUNT, BGT_B_DEPT_PAY_YEAY_D_FUND.MONEY, BGT_B_DEPT_PAY_YEAY_D_FUND.BASE_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD3, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD2, BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.DECLARE_CAUSE, BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.CONTROL_MONEY, BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE.NAME as ACCOUNT_ITEM_ID_NAME, BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU.NAME as BGT_D_ACCOUNT_ITEM_ID_NAME from BGT_B_DEPT_PAY_YEAY_D_FUND left join BGT_D_ACCOUNT_ITEM   BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE on BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID = BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE.ID left join BGT_D_ACCOUNT_ITEM   BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU on BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID = BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FUND_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREE_FIELD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSET_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ACCOUNT_ITEM_ID_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] objs = new DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] Query(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.ID, BGT_B_DEPT_PAY_YEAY_D_FUND.COMPLETE_TIME, BGT_B_DEPT_PAY_YEAY_D_FUND.FINANCE_IDEA, BGT_B_DEPT_PAY_YEAY_D_FUND.BUILDING_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.FUND_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.PRICE, BGT_B_DEPT_PAY_YEAY_D_FUND.AMOUNT, BGT_B_DEPT_PAY_YEAY_D_FUND.MONEY, BGT_B_DEPT_PAY_YEAY_D_FUND.BASE_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD3, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD2, BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.DECLARE_CAUSE, BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.CONTROL_MONEY, BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE.NAME as ACCOUNT_ITEM_ID_NAME, BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU.NAME as BGT_D_ACCOUNT_ITEM_ID_NAME from BGT_B_DEPT_PAY_YEAY_D_FUND left join BGT_D_ACCOUNT_ITEM   BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE on BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID = BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE.ID left join BGT_D_ACCOUNT_ITEM   BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU on BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID = BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_DEPT_PAY_YEAY_D_FUND",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FUND_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREE_FIELD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSET_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ACCOUNT_ITEM_ID_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] objs = new DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] Query(CauseObject_BGT_B_DEPT_PAY_YEAY_D_FUND cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.ID, BGT_B_DEPT_PAY_YEAY_D_FUND.COMPLETE_TIME, BGT_B_DEPT_PAY_YEAY_D_FUND.FINANCE_IDEA, BGT_B_DEPT_PAY_YEAY_D_FUND.BUILDING_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.FUND_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.PRICE, BGT_B_DEPT_PAY_YEAY_D_FUND.AMOUNT, BGT_B_DEPT_PAY_YEAY_D_FUND.MONEY, BGT_B_DEPT_PAY_YEAY_D_FUND.BASE_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD3, BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD2, BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.DECLARE_CAUSE, BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_NAME, BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID, BGT_B_DEPT_PAY_YEAY_D_FUND.CONTROL_MONEY, BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE.NAME as ACCOUNT_ITEM_ID_NAME, BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU.NAME as BGT_D_ACCOUNT_ITEM_ID_NAME from BGT_B_DEPT_PAY_YEAY_D_FUND left join BGT_D_ACCOUNT_ITEM   BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE on BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID = BGT_D_ACCOUNT_ITEM_ACCOUNT_ITE.ID left join BGT_D_ACCOUNT_ITEM   BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU on BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID = BGT_D_ACCOUNT_ITEM_BGT_D_ACCOU.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_DEPT_PAY_YEAY_D_FUND",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT_ITEM_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.COMPLETE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUILDING_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FUND_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRICE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BASE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREE_FIELD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ASSET_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ASSET_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ACCOUNT_ITEM_ID_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.BGT_D_ACCOUNT_ITEM_ID_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[] objs = new DisplayObject_BGT_B_DEPT_PAY_YEAY_D_FUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_DEPT_PAY_YEAY_D_FUND obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ACCOUNT_ITEM_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.ACCOUNT_ITEM_ID = :ACCOUNT_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":ACCOUNT_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ACCOUNT_ITEM_ID) ? string.Empty : obj.ACCOUNT_ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMPLETE_TIME"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.COMPLETE_TIME = :COMPLETE_TIME");
				param = new OracleParameter();
				param.ParameterName = ":COMPLETE_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.COMPLETE_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_IDEA"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.FINANCE_IDEA = :FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName = ":FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_IDEA) ? string.Empty : obj.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUILDING_NAME"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.BUILDING_NAME = :BUILDING_NAME");
				param = new OracleParameter();
				param.ParameterName = ":BUILDING_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 220;
				param.Value = string.IsNullOrEmpty(obj.BUILDING_NAME) ? string.Empty : obj.BUILDING_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FUND_NAME"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.FUND_NAME = :FUND_NAME");
				param = new OracleParameter();
				param.ParameterName = ":FUND_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FUND_NAME) ? string.Empty : obj.FUND_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRICE"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName = ":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AMOUNT"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.AMOUNT = :AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName = ":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD = :FREE_FIELD");
				param = new OracleParameter();
				param.ParameterName = ":FREE_FIELD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD) ? string.Empty : obj.FREE_FIELD;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD3"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD3 = :FREE_FIELD3");
				param = new OracleParameter();
				param.ParameterName = ":FREE_FIELD3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD3) ? string.Empty : obj.FREE_FIELD3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD2"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.FREE_FIELD2 = :FREE_FIELD2");
				param = new OracleParameter();
				param.ParameterName = ":FREE_FIELD2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD2) ? string.Empty : obj.FREE_FIELD2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSET_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_ID = :ASSET_ID");
				param = new OracleParameter();
				param.ParameterName = ":ASSET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ASSET_ID) ? string.Empty : obj.ASSET_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DECLARE_CAUSE"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.DECLARE_CAUSE = :DECLARE_CAUSE");
				param = new OracleParameter();
				param.ParameterName = ":DECLARE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.DECLARE_CAUSE) ? string.Empty : obj.DECLARE_CAUSE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ASSET_NAME"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.ASSET_NAME = :ASSET_NAME");
				param = new OracleParameter();
				param.ParameterName = ":ASSET_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.ASSET_NAME) ? string.Empty : obj.ASSET_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BGT_D_ACCOUNT_ITEM_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.BGT_D_ACCOUNT_ITEM_ID = :BGT_D_ACCOUNT_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":BGT_D_ACCOUNT_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BGT_D_ACCOUNT_ITEM_ID) ? string.Empty : obj.BGT_D_ACCOUNT_ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONTROL_MONEY"))
			{
				strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.CONTROL_MONEY = :CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CONTROL_MONEY;
				paramList.Add(param);
			}
            if (!obj.IsNotUpdate("MONEY1"))
            {
                strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.MONEY1 = :MONEY1");
                param = new OracleParameter();
                param.ParameterName = ":MONEY1";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.MONEY1;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("CONTROL_MONEY1"))
            {
                strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.CONTROL_MONEY1 = :CONTROL_MONEY1");
                param = new OracleParameter();
                param.ParameterName = ":CONTROL_MONEY1";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.CONTROL_MONEY1;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("FINANCE_IDEA1"))
            {
                strBuf.Add("  BGT_B_DEPT_PAY_YEAY_D_FUND.FINANCE_IDEA1 = :FINANCE_IDEA1");
                param = new OracleParameter();
                param.ParameterName = ":FINANCE_IDEA1";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 2000;
                param.Value = obj.FINANCE_IDEA1;
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
