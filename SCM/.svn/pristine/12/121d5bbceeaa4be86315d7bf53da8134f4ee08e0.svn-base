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
	[CauseObject(typeof(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL))]
	public partial class HelperObject_V_SCM_B_QUOTEDPRICE_DETAIL
	{		
		#region Method Blok
		public static int Save(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_SCM_B_QUOTEDPRICE_DETAIL( COM_FILE_ID, COM_FILE_ID_S_NAME, QUERY_STATE, MNAME, GYSACCOUNT, AMOUNT, SPEC, CODE, STATE_NAME, CREATE_TIME, COM_FILE_ID_NAME, QUOTED_PRICE, PRODUCT_NAME, GYSPYM, MSTATE, SUPPLY_AMOUNT, MATNR_ID, MDEPT_ID_NAME, GYSLABEL, STATE, MSTATE_NAME, MDEPT_ID, TXZ01, QUERY_DATE, ID, QUERY_TYPE, QUERY_TYPE_NAME, BASE_ID, MATNR, END_DATE, COMMENTS_D, COMMENTS, GYSNAME, HOSPITAL_NAME, MSEHT, MCOMMENTS, MCODE, MID, PRICE, QUERY_STATE_NAME) values ( :COM_FILE_ID, :COM_FILE_ID_S_NAME, :QUERY_STATE, :MNAME, :GYSACCOUNT, :AMOUNT, :SPEC, :CODE, :STATE_NAME, :CREATE_TIME, :COM_FILE_ID_NAME, :QUOTED_PRICE, :PRODUCT_NAME, :GYSPYM, :MSTATE, :SUPPLY_AMOUNT, :MATNR_ID, :MDEPT_ID_NAME, :GYSLABEL, :STATE, :MSTATE_NAME, :MDEPT_ID, :TXZ01, :QUERY_DATE, :ID, :QUERY_TYPE, :QUERY_TYPE_NAME, :BASE_ID, :MATNR, :END_DATE, :COMMENTS_D, :COMMENTS, :GYSNAME, :HOSPITAL_NAME, :MSEHT, :MCOMMENTS, :MCODE, :MID, :PRICE, :QUERY_STATE_NAME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[40];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":COM_FILE_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.COM_FILE_ID == null ? String.Empty:obj.COM_FILE_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":COM_FILE_ID_S_NAME";
			parameters[1].Size = 100;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.COM_FILE_ID_S_NAME == null ? String.Empty:obj.COM_FILE_ID_S_NAME;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":QUERY_STATE";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.QUERY_STATE == null ? String.Empty:obj.QUERY_STATE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":MNAME";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.MNAME == null ? String.Empty:obj.MNAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":GYSACCOUNT";
			parameters[4].Size = 20;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.GYSACCOUNT == null ? String.Empty:obj.GYSACCOUNT;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":AMOUNT";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.AMOUNT;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":SPEC";
			parameters[6].Size = 100;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CODE";
			parameters[7].Size = 12;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":STATE_NAME";
			parameters[8].Size = 6;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.STATE_NAME == null ? String.Empty:obj.STATE_NAME;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":CREATE_TIME";
			parameters[9].Size = 7;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[9].Value = obj.CREATE_TIME;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":COM_FILE_ID_NAME";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.COM_FILE_ID_NAME == null ? String.Empty:obj.COM_FILE_ID_NAME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":QUOTED_PRICE";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.QUOTED_PRICE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":PRODUCT_NAME";
			parameters[12].Size = 100;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.PRODUCT_NAME == null ? String.Empty:obj.PRODUCT_NAME;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":GYSPYM";
			parameters[13].Size = 20;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.GYSPYM == null ? String.Empty:obj.GYSPYM;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":MSTATE";
			parameters[14].Size = 22;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[14].Value = obj.MSTATE;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":SUPPLY_AMOUNT";
			parameters[15].Size = 22;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[15].Value = obj.SUPPLY_AMOUNT;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":MATNR_ID";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.MATNR_ID == null ? String.Empty:obj.MATNR_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":MDEPT_ID_NAME";
			parameters[17].Size = 50;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[17].Value = obj.MDEPT_ID_NAME == null ? String.Empty:obj.MDEPT_ID_NAME;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":GYSLABEL";
			parameters[18].Size = 20;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.GYSLABEL == null ? String.Empty:obj.GYSLABEL;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":STATE";
			parameters[19].Size = 22;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[19].Value = obj.STATE;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":MSTATE_NAME";
			parameters[20].Size = 6;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[20].Value = obj.MSTATE_NAME == null ? String.Empty:obj.MSTATE_NAME;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":MDEPT_ID";
			parameters[21].Size = 36;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[21].Value = obj.MDEPT_ID == null ? String.Empty:obj.MDEPT_ID;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":TXZ01";
			parameters[22].Size = 200;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[22].Value = obj.TXZ01 == null ? String.Empty:obj.TXZ01;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":QUERY_DATE";
			parameters[23].Size = 7;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[23].Value = obj.QUERY_DATE;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":ID";
			parameters[24].Size = 36;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[24].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":QUERY_TYPE";
			parameters[25].Size = 36;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[25].Value = obj.QUERY_TYPE == null ? String.Empty:obj.QUERY_TYPE;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":QUERY_TYPE_NAME";
			parameters[26].Size = 50;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[26].Value = obj.QUERY_TYPE_NAME == null ? String.Empty:obj.QUERY_TYPE_NAME;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":BASE_ID";
			parameters[27].Size = 36;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[27].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":MATNR";
			parameters[28].Size = 50;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[28].Value = obj.MATNR == null ? String.Empty:obj.MATNR;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":END_DATE";
			parameters[29].Size = 7;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[29].Value = obj.END_DATE;
			parameters[30] = new OracleParameter();
			parameters[30].ParameterName =":COMMENTS_D";
			parameters[30].Size = 500;
			parameters[30].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[30].Value = obj.COMMENTS_D == null ? String.Empty:obj.COMMENTS_D;
			parameters[31] = new OracleParameter();
			parameters[31].ParameterName =":COMMENTS";
			parameters[31].Size = 500;
			parameters[31].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[31].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[32] = new OracleParameter();
			parameters[32].ParameterName =":GYSNAME";
			parameters[32].Size = 100;
			parameters[32].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[32].Value = obj.GYSNAME == null ? String.Empty:obj.GYSNAME;
			parameters[33] = new OracleParameter();
			parameters[33].ParameterName =":HOSPITAL_NAME";
			parameters[33].Size = 100;
			parameters[33].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[33].Value = obj.HOSPITAL_NAME == null ? String.Empty:obj.HOSPITAL_NAME;
			parameters[34] = new OracleParameter();
			parameters[34].ParameterName =":MSEHT";
			parameters[34].Size = 10;
			parameters[34].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[34].Value = obj.MSEHT == null ? String.Empty:obj.MSEHT;
			parameters[35] = new OracleParameter();
			parameters[35].ParameterName =":MCOMMENTS";
			parameters[35].Size = 300;
			parameters[35].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[35].Value = obj.MCOMMENTS == null ? String.Empty:obj.MCOMMENTS;
			parameters[36] = new OracleParameter();
			parameters[36].ParameterName =":MCODE";
			parameters[36].Size = 12;
			parameters[36].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[36].Value = obj.MCODE == null ? String.Empty:obj.MCODE;
			parameters[37] = new OracleParameter();
			parameters[37].ParameterName =":MID";
			parameters[37].Size = 36;
			parameters[37].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[37].Value = obj.MID == null ? String.Empty:obj.MID;
			parameters[38] = new OracleParameter();
			parameters[38].ParameterName =":PRICE";
			parameters[38].Size = 22;
			parameters[38].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[38].Value = obj.PRICE;
			parameters[39] = new OracleParameter();
			parameters[39].ParameterName =":QUERY_STATE_NAME";
			parameters[39].Size = 50;
			parameters[39].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[39].Value = obj.QUERY_STATE_NAME == null ? String.Empty:obj.QUERY_STATE_NAME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_SCM_B_QUOTEDPRICE_DETAIL set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_SCM_B_QUOTEDPRICE_DETAIL where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL Get(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj)
		{
			
			//平台自动生成代码
			string sSql = "select  COM_FILE_ID, COM_FILE_ID_S_NAME, QUERY_STATE, MNAME, GYSACCOUNT, AMOUNT, SPEC, CODE, STATE_NAME, CREATE_TIME, COM_FILE_ID_NAME, QUOTED_PRICE, PRODUCT_NAME, GYSPYM, MSTATE, SUPPLY_AMOUNT, MATNR_ID, MDEPT_ID_NAME, GYSLABEL, STATE, MSTATE_NAME, MDEPT_ID, TXZ01, QUERY_DATE, ID, QUERY_TYPE, QUERY_TYPE_NAME, BASE_ID, MATNR, END_DATE, COMMENTS_D, COMMENTS, GYSNAME, HOSPITAL_NAME, MSEHT, MCOMMENTS, MCODE, MID, PRICE, QUERY_STATE_NAME from V_SCM_B_QUOTEDPRICE_DETAIL where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COM_FILE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COM_FILE_ID_S_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COM_FILE_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSPYM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MSTATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MDEPT_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYSLABEL = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MSTATE_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MDEPT_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.TXZ01 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BASE_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MATNR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.END_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS_D = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.GYSNAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.HOSPITAL_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MSEHT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.MCOMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.MCODE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PRICE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] objs = new EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL Get(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  COM_FILE_ID, COM_FILE_ID_S_NAME, QUERY_STATE, MNAME, GYSACCOUNT, AMOUNT, SPEC, CODE, STATE_NAME, CREATE_TIME, COM_FILE_ID_NAME, QUOTED_PRICE, PRODUCT_NAME, GYSPYM, MSTATE, SUPPLY_AMOUNT, MATNR_ID, MDEPT_ID_NAME, GYSLABEL, STATE, MSTATE_NAME, MDEPT_ID, TXZ01, QUERY_DATE, ID, QUERY_TYPE, QUERY_TYPE_NAME, BASE_ID, MATNR, END_DATE, COMMENTS_D, COMMENTS, GYSNAME, HOSPITAL_NAME, MSEHT, MCOMMENTS, MCODE, MID, PRICE, QUERY_STATE_NAME from V_SCM_B_QUOTEDPRICE_DETAIL where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COM_FILE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COM_FILE_ID_S_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COM_FILE_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSPYM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MSTATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MDEPT_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYSLABEL = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MSTATE_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MDEPT_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.TXZ01 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BASE_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MATNR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.END_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS_D = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.GYSNAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.HOSPITAL_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MSEHT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.MCOMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.MCODE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PRICE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[] objs = new EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID, V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_S_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE, V_SCM_B_QUOTEDPRICE_DETAIL.MNAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSACCOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.AMOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.SPEC, V_SCM_B_QUOTEDPRICE_DETAIL.CODE, V_SCM_B_QUOTEDPRICE_DETAIL.STATE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.CREATE_TIME, V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.QUOTED_PRICE, V_SCM_B_QUOTEDPRICE_DETAIL.PRODUCT_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSPYM, V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE, V_SCM_B_QUOTEDPRICE_DETAIL.SUPPLY_AMOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.MATNR_ID, V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSLABEL, V_SCM_B_QUOTEDPRICE_DETAIL.STATE, V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID, V_SCM_B_QUOTEDPRICE_DETAIL.TXZ01, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_DATE, V_SCM_B_QUOTEDPRICE_DETAIL.ID, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.BASE_ID, V_SCM_B_QUOTEDPRICE_DETAIL.MATNR, V_SCM_B_QUOTEDPRICE_DETAIL.END_DATE, V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS_D, V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS, V_SCM_B_QUOTEDPRICE_DETAIL.GYSNAME, V_SCM_B_QUOTEDPRICE_DETAIL.HOSPITAL_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.MSEHT, V_SCM_B_QUOTEDPRICE_DETAIL.MCOMMENTS, V_SCM_B_QUOTEDPRICE_DETAIL.MCODE, V_SCM_B_QUOTEDPRICE_DETAIL.MID, V_SCM_B_QUOTEDPRICE_DETAIL.PRICE, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE_NAME from V_SCM_B_QUOTEDPRICE_DETAIL where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COM_FILE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COM_FILE_ID_S_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COM_FILE_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSPYM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MSTATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MDEPT_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYSLABEL = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MSTATE_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MDEPT_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.TXZ01 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BASE_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MATNR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.END_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS_D = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.GYSNAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.HOSPITAL_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MSEHT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.MCOMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.MCODE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PRICE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] objs = new DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.COM_FILE_ID))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID ").Append((cause.COM_FILE_ID.StartsWith("%") || cause.COM_FILE_ID.EndsWith("%")) ? " like " : " = ").Append(" :COM_FILE_ID");
				param = new OracleParameter();
				param.ParameterName =":COM_FILE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.COM_FILE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("COM_FILE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "COM_FILE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COM_FILE_ID_S_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_S_NAME ").Append((cause.COM_FILE_ID_S_NAME.StartsWith("%") || cause.COM_FILE_ID_S_NAME.EndsWith("%")) ? " like " : " = ").Append(" :COM_FILE_ID_S_NAME");
				param = new OracleParameter();
				param.ParameterName =":COM_FILE_ID_S_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.COM_FILE_ID_S_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("COM_FILE_ID_S_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "COM_FILE_ID_S_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.QUERY_STATE))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE ").Append((cause.QUERY_STATE.StartsWith("%") || cause.QUERY_STATE.EndsWith("%")) ? " like " : " = ").Append(" :QUERY_STATE");
				param = new OracleParameter();
				param.ParameterName =":QUERY_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.QUERY_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUERY_STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "QUERY_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.MNAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.MNAME ").Append((cause.MNAME.StartsWith("%") || cause.MNAME.EndsWith("%")) ? " like " : " = ").Append(" :MNAME");
				param = new OracleParameter();
				param.ParameterName =":MNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("MNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "MNAME"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "GYSACCOUNT"));
			}
			if(cause.AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.AMOUNT = :AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :SPEC");
				param = new OracleParameter();
				param.ParameterName =":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.STATE_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.STATE_NAME ").Append((cause.STATE_NAME.StartsWith("%") || cause.STATE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :STATE_NAME");
				param = new OracleParameter();
				param.ParameterName =":STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = cause.STATE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "STATE_NAME"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.COM_FILE_ID_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_NAME ").Append((cause.COM_FILE_ID_NAME.StartsWith("%") || cause.COM_FILE_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :COM_FILE_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":COM_FILE_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.COM_FILE_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("COM_FILE_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "COM_FILE_ID_NAME"));
			}
			if(cause.QUOTED_PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.QUOTED_PRICE = :QUOTED_PRICE");
				param = new OracleParameter();
				param.ParameterName =":QUOTED_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.QUOTED_PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUOTED_PRICE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "QUOTED_PRICE"));
			}
			if(!string.IsNullOrEmpty(cause.PRODUCT_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.PRODUCT_NAME ").Append((cause.PRODUCT_NAME.StartsWith("%") || cause.PRODUCT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :PRODUCT_NAME");
				param = new OracleParameter();
				param.ParameterName =":PRODUCT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.PRODUCT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRODUCT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "PRODUCT_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.GYSPYM))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.GYSPYM ").Append((cause.GYSPYM.StartsWith("%") || cause.GYSPYM.EndsWith("%")) ? " like " : " = ").Append(" :GYSPYM");
				param = new OracleParameter();
				param.ParameterName =":GYSPYM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.GYSPYM;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSPYM"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "GYSPYM"));
			}
			if(cause.MSTATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE = :MSTATE");
				param = new OracleParameter();
				param.ParameterName =":MSTATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MSTATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSTATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "MSTATE"));
			}
			if(cause.SUPPLY_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.SUPPLY_AMOUNT = :SUPPLY_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":SUPPLY_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.SUPPLY_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("SUPPLY_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "SUPPLY_AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR_ID))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.MATNR_ID ").Append((cause.MATNR_ID.StartsWith("%") || cause.MATNR_ID.EndsWith("%")) ? " like " : " = ").Append(" :MATNR_ID");
				param = new OracleParameter();
				param.ParameterName =":MATNR_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MATNR_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "MATNR_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MDEPT_ID_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID_NAME ").Append((cause.MDEPT_ID_NAME.StartsWith("%") || cause.MDEPT_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :MDEPT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":MDEPT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MDEPT_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("MDEPT_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "MDEPT_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.GYSLABEL))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.GYSLABEL ").Append((cause.GYSLABEL.StartsWith("%") || cause.GYSLABEL.EndsWith("%")) ? " like " : " = ").Append(" :GYSLABEL");
				param = new OracleParameter();
				param.ParameterName =":GYSLABEL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.GYSLABEL;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSLABEL"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "GYSLABEL"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.MSTATE_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE_NAME ").Append((cause.MSTATE_NAME.StartsWith("%") || cause.MSTATE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :MSTATE_NAME");
				param = new OracleParameter();
				param.ParameterName =":MSTATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = cause.MSTATE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSTATE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "MSTATE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.MDEPT_ID))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID ").Append((cause.MDEPT_ID.StartsWith("%") || cause.MDEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :MDEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":MDEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MDEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MDEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "MDEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.TXZ01))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :TXZ01");
				param = new OracleParameter();
				param.ParameterName =":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.TXZ01;
				paramList.Add(param);
			}
			if (cause.HasINValue("TXZ01"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "TXZ01"));
			}
			if(cause.QUERY_DATE!= null)
			{
				if (cause.QUERY_DATE.Begin != null)
				{
					strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_DATE >= :QUERY_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":QUERY_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.QUERY_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.QUERY_DATE.End != null)
				{
					strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_DATE < :QUERY_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":QUERY_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.QUERY_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("QUERY_DATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "QUERY_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.QUERY_TYPE))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE ").Append((cause.QUERY_TYPE.StartsWith("%") || cause.QUERY_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :QUERY_TYPE");
				param = new OracleParameter();
				param.ParameterName =":QUERY_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.QUERY_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUERY_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "QUERY_TYPE"));
			}
			if(!string.IsNullOrEmpty(cause.QUERY_TYPE_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE_NAME ").Append((cause.QUERY_TYPE_NAME.StartsWith("%") || cause.QUERY_TYPE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :QUERY_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName =":QUERY_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.QUERY_TYPE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUERY_TYPE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "QUERY_TYPE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :MATNR");
				param = new OracleParameter();
				param.ParameterName =":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MATNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "MATNR"));
			}
			if(cause.END_DATE!= null)
			{
				if (cause.END_DATE.Begin != null)
				{
					strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.END_DATE >= :END_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":END_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.END_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.END_DATE.End != null)
				{
					strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.END_DATE < :END_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":END_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.END_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("END_DATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "END_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS_D))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS_D ").Append((cause.COMMENTS_D.StartsWith("%") || cause.COMMENTS_D.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS_D");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS_D";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.COMMENTS_D;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS_D"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "COMMENTS_D"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.GYSNAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :GYSNAME");
				param = new OracleParameter();
				param.ParameterName =":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.GYSNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "GYSNAME"));
			}
			if(!string.IsNullOrEmpty(cause.HOSPITAL_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.HOSPITAL_NAME ").Append((cause.HOSPITAL_NAME.StartsWith("%") || cause.HOSPITAL_NAME.EndsWith("%")) ? " like " : " = ").Append(" :HOSPITAL_NAME");
				param = new OracleParameter();
				param.ParameterName =":HOSPITAL_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.HOSPITAL_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("HOSPITAL_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "HOSPITAL_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.MSEHT))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.MSEHT ").Append((cause.MSEHT.StartsWith("%") || cause.MSEHT.EndsWith("%")) ? " like " : " = ").Append(" :MSEHT");
				param = new OracleParameter();
				param.ParameterName =":MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.MSEHT;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSEHT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "MSEHT"));
			}
			if(!string.IsNullOrEmpty(cause.MCOMMENTS))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.MCOMMENTS ").Append((cause.MCOMMENTS.StartsWith("%") || cause.MCOMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :MCOMMENTS");
				param = new OracleParameter();
				param.ParameterName =":MCOMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.MCOMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("MCOMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "MCOMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.MCODE))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.MCODE ").Append((cause.MCODE.StartsWith("%") || cause.MCODE.EndsWith("%")) ? " like " : " = ").Append(" :MCODE");
				param = new OracleParameter();
				param.ParameterName =":MCODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = cause.MCODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MCODE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "MCODE"));
			}
			if(!string.IsNullOrEmpty(cause.MID))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.MID ").Append((cause.MID.StartsWith("%") || cause.MID.EndsWith("%")) ? " like " : " = ").Append(" :MID");
				param = new OracleParameter();
				param.ParameterName =":MID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "MID"));
			}
			if(cause.PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName =":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRICE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "PRICE"));
			}
			if(!string.IsNullOrEmpty(cause.QUERY_STATE_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE_NAME ").Append((cause.QUERY_STATE_NAME.StartsWith("%") || cause.QUERY_STATE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :QUERY_STATE_NAME");
				param = new OracleParameter();
				param.ParameterName =":QUERY_STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.QUERY_STATE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUERY_STATE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE_DETAIL", "QUERY_STATE_NAME"));
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
		public static DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] Query(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID, V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_S_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE, V_SCM_B_QUOTEDPRICE_DETAIL.MNAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSACCOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.AMOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.SPEC, V_SCM_B_QUOTEDPRICE_DETAIL.CODE, V_SCM_B_QUOTEDPRICE_DETAIL.STATE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.CREATE_TIME, V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.QUOTED_PRICE, V_SCM_B_QUOTEDPRICE_DETAIL.PRODUCT_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSPYM, V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE, V_SCM_B_QUOTEDPRICE_DETAIL.SUPPLY_AMOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.MATNR_ID, V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSLABEL, V_SCM_B_QUOTEDPRICE_DETAIL.STATE, V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID, V_SCM_B_QUOTEDPRICE_DETAIL.TXZ01, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_DATE, V_SCM_B_QUOTEDPRICE_DETAIL.ID, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.BASE_ID, V_SCM_B_QUOTEDPRICE_DETAIL.MATNR, V_SCM_B_QUOTEDPRICE_DETAIL.END_DATE, V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS_D, V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS, V_SCM_B_QUOTEDPRICE_DETAIL.GYSNAME, V_SCM_B_QUOTEDPRICE_DETAIL.HOSPITAL_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.MSEHT, V_SCM_B_QUOTEDPRICE_DETAIL.MCOMMENTS, V_SCM_B_QUOTEDPRICE_DETAIL.MCODE, V_SCM_B_QUOTEDPRICE_DETAIL.MID, V_SCM_B_QUOTEDPRICE_DETAIL.PRICE, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE_NAME from V_SCM_B_QUOTEDPRICE_DETAIL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COM_FILE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COM_FILE_ID_S_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COM_FILE_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSPYM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MSTATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MDEPT_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYSLABEL = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MSTATE_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MDEPT_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.TXZ01 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BASE_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MATNR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.END_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS_D = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.GYSNAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.HOSPITAL_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MSEHT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.MCOMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.MCODE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PRICE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] objs = new DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_SCM_B_QUOTEDPRICE_DETAIL where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] Query(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID, V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_S_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE, V_SCM_B_QUOTEDPRICE_DETAIL.MNAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSACCOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.AMOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.SPEC, V_SCM_B_QUOTEDPRICE_DETAIL.CODE, V_SCM_B_QUOTEDPRICE_DETAIL.STATE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.CREATE_TIME, V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.QUOTED_PRICE, V_SCM_B_QUOTEDPRICE_DETAIL.PRODUCT_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSPYM, V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE, V_SCM_B_QUOTEDPRICE_DETAIL.SUPPLY_AMOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.MATNR_ID, V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSLABEL, V_SCM_B_QUOTEDPRICE_DETAIL.STATE, V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID, V_SCM_B_QUOTEDPRICE_DETAIL.TXZ01, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_DATE, V_SCM_B_QUOTEDPRICE_DETAIL.ID, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.BASE_ID, V_SCM_B_QUOTEDPRICE_DETAIL.MATNR, V_SCM_B_QUOTEDPRICE_DETAIL.END_DATE, V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS_D, V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS, V_SCM_B_QUOTEDPRICE_DETAIL.GYSNAME, V_SCM_B_QUOTEDPRICE_DETAIL.HOSPITAL_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.MSEHT, V_SCM_B_QUOTEDPRICE_DETAIL.MCOMMENTS, V_SCM_B_QUOTEDPRICE_DETAIL.MCODE, V_SCM_B_QUOTEDPRICE_DETAIL.MID, V_SCM_B_QUOTEDPRICE_DETAIL.PRICE, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE_NAME from V_SCM_B_QUOTEDPRICE_DETAIL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COM_FILE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COM_FILE_ID_S_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COM_FILE_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSPYM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MSTATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MDEPT_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYSLABEL = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MSTATE_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MDEPT_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.TXZ01 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BASE_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MATNR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.END_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS_D = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.GYSNAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.HOSPITAL_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MSEHT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.MCOMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.MCODE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PRICE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] objs = new DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] Query(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID, V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_S_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE, V_SCM_B_QUOTEDPRICE_DETAIL.MNAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSACCOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.AMOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.SPEC, V_SCM_B_QUOTEDPRICE_DETAIL.CODE, V_SCM_B_QUOTEDPRICE_DETAIL.STATE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.CREATE_TIME, V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.QUOTED_PRICE, V_SCM_B_QUOTEDPRICE_DETAIL.PRODUCT_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSPYM, V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE, V_SCM_B_QUOTEDPRICE_DETAIL.SUPPLY_AMOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.MATNR_ID, V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSLABEL, V_SCM_B_QUOTEDPRICE_DETAIL.STATE, V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID, V_SCM_B_QUOTEDPRICE_DETAIL.TXZ01, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_DATE, V_SCM_B_QUOTEDPRICE_DETAIL.ID, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.BASE_ID, V_SCM_B_QUOTEDPRICE_DETAIL.MATNR, V_SCM_B_QUOTEDPRICE_DETAIL.END_DATE, V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS_D, V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS, V_SCM_B_QUOTEDPRICE_DETAIL.GYSNAME, V_SCM_B_QUOTEDPRICE_DETAIL.HOSPITAL_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.MSEHT, V_SCM_B_QUOTEDPRICE_DETAIL.MCOMMENTS, V_SCM_B_QUOTEDPRICE_DETAIL.MCODE, V_SCM_B_QUOTEDPRICE_DETAIL.MID, V_SCM_B_QUOTEDPRICE_DETAIL.PRICE, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE_NAME from V_SCM_B_QUOTEDPRICE_DETAIL where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_B_QUOTEDPRICE_DETAIL",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COM_FILE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COM_FILE_ID_S_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COM_FILE_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSPYM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MSTATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MDEPT_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYSLABEL = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MSTATE_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MDEPT_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.TXZ01 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BASE_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MATNR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.END_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS_D = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.GYSNAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.HOSPITAL_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MSEHT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.MCOMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.MCODE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PRICE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] objs = new DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] Query(CauseObject_V_SCM_B_QUOTEDPRICE_DETAIL cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID, V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_S_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE, V_SCM_B_QUOTEDPRICE_DETAIL.MNAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSACCOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.AMOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.SPEC, V_SCM_B_QUOTEDPRICE_DETAIL.CODE, V_SCM_B_QUOTEDPRICE_DETAIL.STATE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.CREATE_TIME, V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.QUOTED_PRICE, V_SCM_B_QUOTEDPRICE_DETAIL.PRODUCT_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSPYM, V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE, V_SCM_B_QUOTEDPRICE_DETAIL.SUPPLY_AMOUNT, V_SCM_B_QUOTEDPRICE_DETAIL.MATNR_ID, V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.GYSLABEL, V_SCM_B_QUOTEDPRICE_DETAIL.STATE, V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID, V_SCM_B_QUOTEDPRICE_DETAIL.TXZ01, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_DATE, V_SCM_B_QUOTEDPRICE_DETAIL.ID, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.BASE_ID, V_SCM_B_QUOTEDPRICE_DETAIL.MATNR, V_SCM_B_QUOTEDPRICE_DETAIL.END_DATE, V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS_D, V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS, V_SCM_B_QUOTEDPRICE_DETAIL.GYSNAME, V_SCM_B_QUOTEDPRICE_DETAIL.HOSPITAL_NAME, V_SCM_B_QUOTEDPRICE_DETAIL.MSEHT, V_SCM_B_QUOTEDPRICE_DETAIL.MCOMMENTS, V_SCM_B_QUOTEDPRICE_DETAIL.MCODE, V_SCM_B_QUOTEDPRICE_DETAIL.MID, V_SCM_B_QUOTEDPRICE_DETAIL.PRICE, V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE_NAME from V_SCM_B_QUOTEDPRICE_DETAIL where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_B_QUOTEDPRICE_DETAIL",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COM_FILE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COM_FILE_ID_S_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MNAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COM_FILE_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSPYM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MSTATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MDEPT_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYSLABEL = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MSTATE_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MDEPT_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.TXZ01 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BASE_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.MATNR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.END_DATE = sqlReader.GetDateTime(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS_D = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.COMMENTS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.GYSNAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.HOSPITAL_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MSEHT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.MCOMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.MCODE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.PRICE = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[] objs = new DisplayObject_V_SCM_B_QUOTEDPRICE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_SCM_B_QUOTEDPRICE_DETAIL obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("COM_FILE_ID"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID = :COM_FILE_ID");
				param = new OracleParameter();
				param.ParameterName = ":COM_FILE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.COM_FILE_ID) ? string.Empty : obj.COM_FILE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COM_FILE_ID_S_NAME"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_S_NAME = :COM_FILE_ID_S_NAME");
				param = new OracleParameter();
				param.ParameterName = ":COM_FILE_ID_S_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.COM_FILE_ID_S_NAME) ? string.Empty : obj.COM_FILE_ID_S_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("QUERY_STATE"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE = :QUERY_STATE");
				param = new OracleParameter();
				param.ParameterName = ":QUERY_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.QUERY_STATE) ? string.Empty : obj.QUERY_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MNAME"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.MNAME = :MNAME");
				param = new OracleParameter();
				param.ParameterName = ":MNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MNAME) ? string.Empty : obj.MNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.GYSACCOUNT = :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AMOUNT"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.AMOUNT = :AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.SPEC = :SPEC");
				param = new OracleParameter();
				param.ParameterName = ":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE_NAME"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.STATE_NAME = :STATE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = string.IsNullOrEmpty(obj.STATE_NAME) ? string.Empty : obj.STATE_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COM_FILE_ID_NAME"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.COM_FILE_ID_NAME = :COM_FILE_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":COM_FILE_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.COM_FILE_ID_NAME) ? string.Empty : obj.COM_FILE_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("QUOTED_PRICE"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.QUOTED_PRICE = :QUOTED_PRICE");
				param = new OracleParameter();
				param.ParameterName = ":QUOTED_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.QUOTED_PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRODUCT_NAME"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.PRODUCT_NAME = :PRODUCT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":PRODUCT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.PRODUCT_NAME) ? string.Empty : obj.PRODUCT_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSPYM"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.GYSPYM = :GYSPYM");
				param = new OracleParameter();
				param.ParameterName = ":GYSPYM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.GYSPYM) ? string.Empty : obj.GYSPYM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MSTATE"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE = :MSTATE");
				param = new OracleParameter();
				param.ParameterName = ":MSTATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MSTATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SUPPLY_AMOUNT"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.SUPPLY_AMOUNT = :SUPPLY_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":SUPPLY_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.SUPPLY_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATNR_ID"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.MATNR_ID = :MATNR_ID");
				param = new OracleParameter();
				param.ParameterName = ":MATNR_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MATNR_ID) ? string.Empty : obj.MATNR_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MDEPT_ID_NAME"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID_NAME = :MDEPT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":MDEPT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MDEPT_ID_NAME) ? string.Empty : obj.MDEPT_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSLABEL"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.GYSLABEL = :GYSLABEL");
				param = new OracleParameter();
				param.ParameterName = ":GYSLABEL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.GYSLABEL) ? string.Empty : obj.GYSLABEL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MSTATE_NAME"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.MSTATE_NAME = :MSTATE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":MSTATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = string.IsNullOrEmpty(obj.MSTATE_NAME) ? string.Empty : obj.MSTATE_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MDEPT_ID"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.MDEPT_ID = :MDEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":MDEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MDEPT_ID) ? string.Empty : obj.MDEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TXZ01"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.TXZ01 = :TXZ01");
				param = new OracleParameter();
				param.ParameterName = ":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.TXZ01) ? string.Empty : obj.TXZ01;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("QUERY_DATE"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_DATE = :QUERY_DATE");
				param = new OracleParameter();
				param.ParameterName = ":QUERY_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.QUERY_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("QUERY_TYPE"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE = :QUERY_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":QUERY_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.QUERY_TYPE) ? string.Empty : obj.QUERY_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("QUERY_TYPE_NAME"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_TYPE_NAME = :QUERY_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":QUERY_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.QUERY_TYPE_NAME) ? string.Empty : obj.QUERY_TYPE_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATNR"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.MATNR = :MATNR");
				param = new OracleParameter();
				param.ParameterName = ":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MATNR) ? string.Empty : obj.MATNR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("END_DATE"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.END_DATE = :END_DATE");
				param = new OracleParameter();
				param.ParameterName = ":END_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.END_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS_D"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS_D = :COMMENTS_D");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS_D";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS_D) ? string.Empty : obj.COMMENTS_D;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSNAME"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.GYSNAME = :GYSNAME");
				param = new OracleParameter();
				param.ParameterName = ":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.GYSNAME) ? string.Empty : obj.GYSNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("HOSPITAL_NAME"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.HOSPITAL_NAME = :HOSPITAL_NAME");
				param = new OracleParameter();
				param.ParameterName = ":HOSPITAL_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.HOSPITAL_NAME) ? string.Empty : obj.HOSPITAL_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MSEHT"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.MSEHT = :MSEHT");
				param = new OracleParameter();
				param.ParameterName = ":MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.MSEHT) ? string.Empty : obj.MSEHT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MCOMMENTS"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.MCOMMENTS = :MCOMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":MCOMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.MCOMMENTS) ? string.Empty : obj.MCOMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MCODE"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.MCODE = :MCODE");
				param = new OracleParameter();
				param.ParameterName = ":MCODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = string.IsNullOrEmpty(obj.MCODE) ? string.Empty : obj.MCODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MID"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.MID = :MID");
				param = new OracleParameter();
				param.ParameterName = ":MID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MID) ? string.Empty : obj.MID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRICE"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName = ":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("QUERY_STATE_NAME"))
			{
				strBuf.Add("  V_SCM_B_QUOTEDPRICE_DETAIL.QUERY_STATE_NAME = :QUERY_STATE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":QUERY_STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.QUERY_STATE_NAME) ? string.Empty : obj.QUERY_STATE_NAME;
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
