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
	[CauseObject(typeof(CauseObject_V_SCM_D_PURCHARSEPLAN))]
	public partial class HelperObject_V_SCM_D_PURCHARSEPLAN
	{		
		#region Method Blok
		public static int Save(EntityObject_V_SCM_D_PURCHARSEPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_SCM_D_PURCHARSEPLAN( PKG_AMOUNT, FREEUSE2, FREEUSE3, FACTORY, BEDAT, FREEUSE1, NAME, STATUS, BSART, SEND_DEPART_NAME, LINK_PERSON, SPEC, CODE, MENGE, CREATE_TIME, NETPR, HSDAT, SEND_ORDER_CODE, MEINS, SEND_DEPART, WERKST, EEIND, UNINFORMED_STATE, LGORT, TXZ01, LINK_TELEPHONE, FPRQ, ORDER_MENGE, ID, CHARG, PKG_NUMBER, WERKS, INFORMED_STATE, MATNR, FPHM, COMMENTS, GYSNAME, MSEHT, GYSACCOUNT, EBELN, FPBM, GYJH, FPJR, MATER_CODE, VFDAT) values ( :PKG_AMOUNT, :FREEUSE2, :FREEUSE3, :FACTORY, :BEDAT, :FREEUSE1, :NAME, :STATUS, :BSART, :SEND_DEPART_NAME, :LINK_PERSON, :SPEC, :CODE, :MENGE, :CREATE_TIME, :NETPR, :HSDAT, :SEND_ORDER_CODE, :MEINS, :SEND_DEPART, :WERKST, :EEIND, :UNINFORMED_STATE, :LGORT, :TXZ01, :LINK_TELEPHONE, :FPRQ, :ORDER_MENGE, :ID, :CHARG, :PKG_NUMBER, :WERKS, :INFORMED_STATE, :MATNR, :FPHM, :COMMENTS, :GYSNAME, :MSEHT, :GYSACCOUNT, :EBELN, :FPBM, :GYJH, :FPJR, :MATER_CODE, :VFDAT)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[45];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":PKG_AMOUNT";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.PKG_AMOUNT;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":FREEUSE2";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.FREEUSE2 == null ? String.Empty:obj.FREEUSE2;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":FREEUSE3";
			parameters[2].Size = 100;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.FREEUSE3 == null ? String.Empty:obj.FREEUSE3;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":FACTORY";
			parameters[3].Size = 100;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.FACTORY == null ? String.Empty:obj.FACTORY;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":BEDAT";
			parameters[4].Size = 10;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.BEDAT == null ? String.Empty:obj.BEDAT;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":FREEUSE1";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.FREEUSE1 == null ? String.Empty:obj.FREEUSE1;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":NAME";
			parameters[6].Size = 200;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":STATUS";
			parameters[7].Size = 1;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.STATUS == null ? String.Empty:obj.STATUS;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":BSART";
			parameters[8].Size = 4;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.BSART == null ? String.Empty:obj.BSART;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":SEND_DEPART_NAME";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.SEND_DEPART_NAME == null ? String.Empty:obj.SEND_DEPART_NAME;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":LINK_PERSON";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.LINK_PERSON == null ? String.Empty:obj.LINK_PERSON;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":SPEC";
			parameters[11].Size = 200;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":CODE";
			parameters[12].Size = 50;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":MENGE";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.MENGE;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":CREATE_TIME";
			parameters[14].Size = 7;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[14].Value = obj.CREATE_TIME;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":NETPR";
			parameters[15].Size = 20;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.NETPR == null ? String.Empty:obj.NETPR;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":HSDAT";
			parameters[16].Size = 7;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[16].Value = obj.HSDAT;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":SEND_ORDER_CODE";
			parameters[17].Size = 20;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[17].Value = obj.SEND_ORDER_CODE == null ? String.Empty:obj.SEND_ORDER_CODE;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":MEINS";
			parameters[18].Size = 50;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.MEINS == null ? String.Empty:obj.MEINS;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":SEND_DEPART";
			parameters[19].Size = 36;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[19].Value = obj.SEND_DEPART == null ? String.Empty:obj.SEND_DEPART;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":WERKST";
			parameters[20].Size = 200;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[20].Value = obj.WERKST == null ? String.Empty:obj.WERKST;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":EEIND";
			parameters[21].Size = 10;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[21].Value = obj.EEIND == null ? String.Empty:obj.EEIND;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":UNINFORMED_STATE";
			parameters[22].Size = 1;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[22].Value = obj.UNINFORMED_STATE == null ? String.Empty:obj.UNINFORMED_STATE;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":LGORT";
			parameters[23].Size = 200;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[23].Value = obj.LGORT == null ? String.Empty:obj.LGORT;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":TXZ01";
			parameters[24].Size = 200;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[24].Value = obj.TXZ01 == null ? String.Empty:obj.TXZ01;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":LINK_TELEPHONE";
			parameters[25].Size = 50;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[25].Value = obj.LINK_TELEPHONE == null ? String.Empty:obj.LINK_TELEPHONE;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":FPRQ";
			parameters[26].Size = 7;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[26].Value = obj.FPRQ;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":ORDER_MENGE";
			parameters[27].Size = 22;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[27].Value = obj.ORDER_MENGE;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":ID";
			parameters[28].Size = 36;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[28].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":CHARG";
			parameters[29].Size = 50;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[29].Value = obj.CHARG == null ? String.Empty:obj.CHARG;
			parameters[30] = new OracleParameter();
			parameters[30].ParameterName =":PKG_NUMBER";
			parameters[30].Size = 22;
			parameters[30].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[30].Value = obj.PKG_NUMBER;
			parameters[31] = new OracleParameter();
			parameters[31].ParameterName =":WERKS";
			parameters[31].Size = 40;
			parameters[31].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[31].Value = obj.WERKS == null ? String.Empty:obj.WERKS;
			parameters[32] = new OracleParameter();
			parameters[32].ParameterName =":INFORMED_STATE";
			parameters[32].Size = 1;
			parameters[32].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[32].Value = obj.INFORMED_STATE == null ? String.Empty:obj.INFORMED_STATE;
			parameters[33] = new OracleParameter();
			parameters[33].ParameterName =":MATNR";
			parameters[33].Size = 50;
			parameters[33].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[33].Value = obj.MATNR == null ? String.Empty:obj.MATNR;
			parameters[34] = new OracleParameter();
			parameters[34].ParameterName =":FPHM";
			parameters[34].Size = 20;
			parameters[34].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[34].Value = obj.FPHM == null ? String.Empty:obj.FPHM;
			parameters[35] = new OracleParameter();
			parameters[35].ParameterName =":COMMENTS";
			parameters[35].Size = 200;
			parameters[35].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[35].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[36] = new OracleParameter();
			parameters[36].ParameterName =":GYSNAME";
			parameters[36].Size = 50;
			parameters[36].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[36].Value = obj.GYSNAME == null ? String.Empty:obj.GYSNAME;
			parameters[37] = new OracleParameter();
			parameters[37].ParameterName =":MSEHT";
			parameters[37].Size = 50;
			parameters[37].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[37].Value = obj.MSEHT == null ? String.Empty:obj.MSEHT;
			parameters[38] = new OracleParameter();
			parameters[38].ParameterName =":GYSACCOUNT";
			parameters[38].Size = 50;
			parameters[38].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[38].Value = obj.GYSACCOUNT == null ? String.Empty:obj.GYSACCOUNT;
			parameters[39] = new OracleParameter();
			parameters[39].ParameterName =":EBELN";
			parameters[39].Size = 200;
			parameters[39].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[39].Value = obj.EBELN == null ? String.Empty:obj.EBELN;
			parameters[40] = new OracleParameter();
			parameters[40].ParameterName =":FPBM";
			parameters[40].Size = 200;
			parameters[40].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[40].Value = obj.FPBM == null ? String.Empty:obj.FPBM;
			parameters[41] = new OracleParameter();
			parameters[41].ParameterName =":GYJH";
			parameters[41].Size = 200;
			parameters[41].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[41].Value = obj.GYJH == null ? String.Empty:obj.GYJH;
			parameters[42] = new OracleParameter();
			parameters[42].ParameterName =":FPJR";
			parameters[42].Size = 22;
			parameters[42].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[42].Value = obj.FPJR;
			parameters[43] = new OracleParameter();
			parameters[43].ParameterName =":MATER_CODE";
			parameters[43].Size = 100;
			parameters[43].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[43].Value = obj.MATER_CODE == null ? String.Empty:obj.MATER_CODE;
			parameters[44] = new OracleParameter();
			parameters[44].ParameterName =":VFDAT";
			parameters[44].Size = 7;
			parameters[44].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[44].Value = obj.VFDAT;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_SCM_D_PURCHARSEPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_SCM_D_PURCHARSEPLAN set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_SCM_D_PURCHARSEPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_SCM_D_PURCHARSEPLAN where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_SCM_D_PURCHARSEPLAN Get(EntityObject_V_SCM_D_PURCHARSEPLAN obj)
		{
			
			//平台自动生成代码
			string sSql = "select  PKG_AMOUNT, FREEUSE2, FREEUSE3, FACTORY, BEDAT, FREEUSE1, NAME, STATUS, BSART, SEND_DEPART_NAME, LINK_PERSON, SPEC, CODE, MENGE, CREATE_TIME, NETPR, HSDAT, SEND_ORDER_CODE, MEINS, SEND_DEPART, WERKST, EEIND, UNINFORMED_STATE, LGORT, TXZ01, LINK_TELEPHONE, FPRQ, ORDER_MENGE, ID, CHARG, PKG_NUMBER, WERKS, INFORMED_STATE, MATNR, FPHM, COMMENTS, GYSNAME, MSEHT, GYSACCOUNT, EBELN, FPBM, GYJH, FPJR, MATER_CODE, VFDAT from V_SCM_D_PURCHARSEPLAN where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_D_PURCHARSEPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_D_PURCHARSEPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FREEUSE2 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE3 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FACTORY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATUS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BSART = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SPEC = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MENGE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.HSDAT = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SEND_DEPART = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WERKST = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.EEIND = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.LGORT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.TXZ01 = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FPRQ = sqlReader.GetDateTime(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CHARG = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.WERKS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MATNR = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.FPHM = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.COMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.GYSNAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MSEHT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.EBELN = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.FPBM = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.GYJH = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.FPJR = sqlReader.GetDecimal(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.MATER_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.VFDAT = sqlReader.GetDateTime(44);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_SCM_D_PURCHARSEPLAN[] objs = new EntityObject_V_SCM_D_PURCHARSEPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_SCM_D_PURCHARSEPLAN Get(EntityObject_V_SCM_D_PURCHARSEPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  PKG_AMOUNT, FREEUSE2, FREEUSE3, FACTORY, BEDAT, FREEUSE1, NAME, STATUS, BSART, SEND_DEPART_NAME, LINK_PERSON, SPEC, CODE, MENGE, CREATE_TIME, NETPR, HSDAT, SEND_ORDER_CODE, MEINS, SEND_DEPART, WERKST, EEIND, UNINFORMED_STATE, LGORT, TXZ01, LINK_TELEPHONE, FPRQ, ORDER_MENGE, ID, CHARG, PKG_NUMBER, WERKS, INFORMED_STATE, MATNR, FPHM, COMMENTS, GYSNAME, MSEHT, GYSACCOUNT, EBELN, FPBM, GYJH, FPJR, MATER_CODE, VFDAT from V_SCM_D_PURCHARSEPLAN where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_D_PURCHARSEPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_D_PURCHARSEPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FREEUSE2 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE3 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FACTORY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATUS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BSART = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SPEC = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MENGE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.HSDAT = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SEND_DEPART = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WERKST = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.EEIND = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.LGORT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.TXZ01 = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FPRQ = sqlReader.GetDateTime(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CHARG = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.WERKS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MATNR = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.FPHM = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.COMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.GYSNAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MSEHT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.EBELN = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.FPBM = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.GYJH = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.FPJR = sqlReader.GetDecimal(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.MATER_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.VFDAT = sqlReader.GetDateTime(44);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_SCM_D_PURCHARSEPLAN[] objs = new EntityObject_V_SCM_D_PURCHARSEPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_SCM_D_PURCHARSEPLAN[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_SCM_D_PURCHARSEPLAN.PKG_AMOUNT, V_SCM_D_PURCHARSEPLAN.FREEUSE2, V_SCM_D_PURCHARSEPLAN.FREEUSE3, V_SCM_D_PURCHARSEPLAN.FACTORY, V_SCM_D_PURCHARSEPLAN.BEDAT, V_SCM_D_PURCHARSEPLAN.FREEUSE1, V_SCM_D_PURCHARSEPLAN.NAME, V_SCM_D_PURCHARSEPLAN.STATUS, V_SCM_D_PURCHARSEPLAN.BSART, V_SCM_D_PURCHARSEPLAN.SEND_DEPART_NAME, V_SCM_D_PURCHARSEPLAN.LINK_PERSON, V_SCM_D_PURCHARSEPLAN.SPEC, V_SCM_D_PURCHARSEPLAN.CODE, V_SCM_D_PURCHARSEPLAN.MENGE, V_SCM_D_PURCHARSEPLAN.CREATE_TIME, V_SCM_D_PURCHARSEPLAN.NETPR, V_SCM_D_PURCHARSEPLAN.HSDAT, V_SCM_D_PURCHARSEPLAN.SEND_ORDER_CODE, V_SCM_D_PURCHARSEPLAN.MEINS, V_SCM_D_PURCHARSEPLAN.SEND_DEPART, V_SCM_D_PURCHARSEPLAN.WERKST, V_SCM_D_PURCHARSEPLAN.EEIND, V_SCM_D_PURCHARSEPLAN.UNINFORMED_STATE, V_SCM_D_PURCHARSEPLAN.LGORT, V_SCM_D_PURCHARSEPLAN.TXZ01, V_SCM_D_PURCHARSEPLAN.LINK_TELEPHONE, V_SCM_D_PURCHARSEPLAN.FPRQ, V_SCM_D_PURCHARSEPLAN.ORDER_MENGE, V_SCM_D_PURCHARSEPLAN.ID, V_SCM_D_PURCHARSEPLAN.CHARG, V_SCM_D_PURCHARSEPLAN.PKG_NUMBER, V_SCM_D_PURCHARSEPLAN.WERKS, V_SCM_D_PURCHARSEPLAN.INFORMED_STATE, V_SCM_D_PURCHARSEPLAN.MATNR, V_SCM_D_PURCHARSEPLAN.FPHM, V_SCM_D_PURCHARSEPLAN.COMMENTS, V_SCM_D_PURCHARSEPLAN.GYSNAME, V_SCM_D_PURCHARSEPLAN.MSEHT, V_SCM_D_PURCHARSEPLAN.GYSACCOUNT, V_SCM_D_PURCHARSEPLAN.EBELN, V_SCM_D_PURCHARSEPLAN.FPBM, V_SCM_D_PURCHARSEPLAN.GYJH, V_SCM_D_PURCHARSEPLAN.FPJR, V_SCM_D_PURCHARSEPLAN.MATER_CODE, V_SCM_D_PURCHARSEPLAN.VFDAT from V_SCM_D_PURCHARSEPLAN where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_SCM_D_PURCHARSEPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_PURCHARSEPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FREEUSE2 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE3 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FACTORY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATUS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BSART = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SPEC = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MENGE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.HSDAT = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SEND_DEPART = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WERKST = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.EEIND = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.LGORT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.TXZ01 = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FPRQ = sqlReader.GetDateTime(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CHARG = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.WERKS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MATNR = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.FPHM = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.COMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.GYSNAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MSEHT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.EBELN = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.FPBM = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.GYJH = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.FPJR = sqlReader.GetDecimal(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.MATER_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.VFDAT = sqlReader.GetDateTime(44);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_PURCHARSEPLAN[] objs = new DisplayObject_V_SCM_D_PURCHARSEPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_SCM_D_PURCHARSEPLAN cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.PKG_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.PKG_AMOUNT = :PKG_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":PKG_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PKG_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("PKG_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "PKG_AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE2))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.FREEUSE2 ").Append((cause.FREEUSE2.StartsWith("%") || cause.FREEUSE2.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE2");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 50;
				param.Value = cause.FREEUSE2;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE2"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "FREEUSE2"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE3))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.FREEUSE3 ").Append((cause.FREEUSE3.StartsWith("%") || cause.FREEUSE3.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE3");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 100;
				param.Value = cause.FREEUSE3;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE3"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "FREEUSE3"));
			}
			if(!string.IsNullOrEmpty(cause.FACTORY))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.FACTORY ").Append((cause.FACTORY.StartsWith("%") || cause.FACTORY.EndsWith("%")) ? " like " : " = ").Append(" :FACTORY");
				param = new OracleParameter();
				param.ParameterName =":FACTORY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.FACTORY;
				paramList.Add(param);
			}
			if (cause.HasINValue("FACTORY"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "FACTORY"));
			}
			if(!string.IsNullOrEmpty(cause.BEDAT))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.BEDAT ").Append((cause.BEDAT.StartsWith("%") || cause.BEDAT.EndsWith("%")) ? " like " : " = ").Append(" :BEDAT");
				param = new OracleParameter();
				param.ParameterName =":BEDAT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.BEDAT;
				paramList.Add(param);
			}
			if (cause.HasINValue("BEDAT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "BEDAT"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE1))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.FREEUSE1 ").Append((cause.FREEUSE1.StartsWith("%") || cause.FREEUSE1.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE1");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FREEUSE1;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE1"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "FREEUSE1"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.STATUS))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.STATUS ").Append((cause.STATUS.StartsWith("%") || cause.STATUS.EndsWith("%")) ? " like " : " = ").Append(" :STATUS");
				param = new OracleParameter();
				param.ParameterName =":STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.BSART))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.BSART ").Append((cause.BSART.StartsWith("%") || cause.BSART.EndsWith("%")) ? " like " : " = ").Append(" :BSART");
				param = new OracleParameter();
				param.ParameterName =":BSART";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 4;
				param.Value = cause.BSART;
				paramList.Add(param);
			}
			if (cause.HasINValue("BSART"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "BSART"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_DEPART_NAME))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.SEND_DEPART_NAME ").Append((cause.SEND_DEPART_NAME.StartsWith("%") || cause.SEND_DEPART_NAME.EndsWith("%")) ? " like " : " = ").Append(" :SEND_DEPART_NAME");
				param = new OracleParameter();
				param.ParameterName =":SEND_DEPART_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SEND_DEPART_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_DEPART_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "SEND_DEPART_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.LINK_PERSON))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.LINK_PERSON ").Append((cause.LINK_PERSON.StartsWith("%") || cause.LINK_PERSON.EndsWith("%")) ? " like " : " = ").Append(" :LINK_PERSON");
				param = new OracleParameter();
				param.ParameterName =":LINK_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.LINK_PERSON;
				paramList.Add(param);
			}
			if (cause.HasINValue("LINK_PERSON"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "LINK_PERSON"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :SPEC");
				param = new OracleParameter();
				param.ParameterName =":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "CODE"));
			}
			if(cause.MENGE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.MENGE = :MENGE");
				param = new OracleParameter();
				param.ParameterName =":MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MENGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MENGE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "MENGE"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.NETPR))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.NETPR ").Append((cause.NETPR.StartsWith("%") || cause.NETPR.EndsWith("%")) ? " like " : " = ").Append(" :NETPR");
				param = new OracleParameter();
				param.ParameterName =":NETPR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.NETPR;
				paramList.Add(param);
			}
			if (cause.HasINValue("NETPR"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "NETPR"));
			}
			if(cause.HSDAT!= null)
			{
				if (cause.HSDAT.Begin != null)
				{
					strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.HSDAT >= :HSDAT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":HSDAT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.HSDAT.Begin;
					paramList.Add(param);
				}
				if (cause.HSDAT.End != null)
				{
					strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.HSDAT < :HSDAT_END");
					param = new OracleParameter();
					param.ParameterName = ":HSDAT_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.HSDAT.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("HSDAT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "HSDAT"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_ORDER_CODE))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.SEND_ORDER_CODE ").Append((cause.SEND_ORDER_CODE.StartsWith("%") || cause.SEND_ORDER_CODE.EndsWith("%")) ? " like " : " = ").Append(" :SEND_ORDER_CODE");
				param = new OracleParameter();
				param.ParameterName =":SEND_ORDER_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.SEND_ORDER_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_ORDER_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "SEND_ORDER_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.MEINS))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.MEINS ").Append((cause.MEINS.StartsWith("%") || cause.MEINS.EndsWith("%")) ? " like " : " = ").Append(" :MEINS");
				param = new OracleParameter();
				param.ParameterName =":MEINS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MEINS;
				paramList.Add(param);
			}
			if (cause.HasINValue("MEINS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "MEINS"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_DEPART))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.SEND_DEPART ").Append((cause.SEND_DEPART.StartsWith("%") || cause.SEND_DEPART.EndsWith("%")) ? " like " : " = ").Append(" :SEND_DEPART");
				param = new OracleParameter();
				param.ParameterName =":SEND_DEPART";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SEND_DEPART;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_DEPART"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "SEND_DEPART"));
			}
			if(!string.IsNullOrEmpty(cause.WERKST))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.WERKST ").Append((cause.WERKST.StartsWith("%") || cause.WERKST.EndsWith("%")) ? " like " : " = ").Append(" :WERKST");
				param = new OracleParameter();
				param.ParameterName =":WERKST";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.WERKST;
				paramList.Add(param);
			}
			if (cause.HasINValue("WERKST"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "WERKST"));
			}
			if(!string.IsNullOrEmpty(cause.EEIND))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.EEIND ").Append((cause.EEIND.StartsWith("%") || cause.EEIND.EndsWith("%")) ? " like " : " = ").Append(" :EEIND");
				param = new OracleParameter();
				param.ParameterName =":EEIND";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.EEIND;
				paramList.Add(param);
			}
			if (cause.HasINValue("EEIND"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "EEIND"));
			}
			if(!string.IsNullOrEmpty(cause.UNINFORMED_STATE))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.UNINFORMED_STATE ").Append((cause.UNINFORMED_STATE.StartsWith("%") || cause.UNINFORMED_STATE.EndsWith("%")) ? " like " : " = ").Append(" :UNINFORMED_STATE");
				param = new OracleParameter();
				param.ParameterName =":UNINFORMED_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = cause.UNINFORMED_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNINFORMED_STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "UNINFORMED_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.LGORT))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.LGORT ").Append((cause.LGORT.StartsWith("%") || cause.LGORT.EndsWith("%")) ? " like " : " = ").Append(" :LGORT");
				param = new OracleParameter();
				param.ParameterName =":LGORT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.LGORT;
				paramList.Add(param);
			}
			if (cause.HasINValue("LGORT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "LGORT"));
			}
			if(!string.IsNullOrEmpty(cause.TXZ01))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :TXZ01");
				param = new OracleParameter();
				param.ParameterName =":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.TXZ01;
				paramList.Add(param);
			}
			if (cause.HasINValue("TXZ01"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "TXZ01"));
			}
			if(!string.IsNullOrEmpty(cause.LINK_TELEPHONE))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.LINK_TELEPHONE ").Append((cause.LINK_TELEPHONE.StartsWith("%") || cause.LINK_TELEPHONE.EndsWith("%")) ? " like " : " = ").Append(" :LINK_TELEPHONE");
				param = new OracleParameter();
				param.ParameterName =":LINK_TELEPHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.LINK_TELEPHONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("LINK_TELEPHONE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "LINK_TELEPHONE"));
			}
			if(cause.FPRQ!= null)
			{
				if (cause.FPRQ.Begin != null)
				{
					strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.FPRQ >= :FPRQ_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":FPRQ_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.FPRQ.Begin;
					paramList.Add(param);
				}
				if (cause.FPRQ.End != null)
				{
					strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.FPRQ < :FPRQ_END");
					param = new OracleParameter();
					param.ParameterName = ":FPRQ_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.FPRQ.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("FPRQ"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "FPRQ"));
			}
			if(cause.ORDER_MENGE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.ORDER_MENGE = :ORDER_MENGE");
				param = new OracleParameter();
				param.ParameterName =":ORDER_MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ORDER_MENGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ORDER_MENGE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "ORDER_MENGE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.CHARG))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.CHARG ").Append((cause.CHARG.StartsWith("%") || cause.CHARG.EndsWith("%")) ? " like " : " = ").Append(" :CHARG");
				param = new OracleParameter();
				param.ParameterName =":CHARG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CHARG;
				paramList.Add(param);
			}
			if (cause.HasINValue("CHARG"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "CHARG"));
			}
			if(cause.PKG_NUMBER!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.PKG_NUMBER = :PKG_NUMBER");
				param = new OracleParameter();
				param.ParameterName =":PKG_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PKG_NUMBER;
				paramList.Add(param);
			}
			if (cause.HasINValue("PKG_NUMBER"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "PKG_NUMBER"));
			}
			if(!string.IsNullOrEmpty(cause.WERKS))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.WERKS ").Append((cause.WERKS.StartsWith("%") || cause.WERKS.EndsWith("%")) ? " like " : " = ").Append(" :WERKS");
				param = new OracleParameter();
				param.ParameterName =":WERKS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 40;
				param.Value = cause.WERKS;
				paramList.Add(param);
			}
			if (cause.HasINValue("WERKS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "WERKS"));
			}
			if(!string.IsNullOrEmpty(cause.INFORMED_STATE))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.INFORMED_STATE ").Append((cause.INFORMED_STATE.StartsWith("%") || cause.INFORMED_STATE.EndsWith("%")) ? " like " : " = ").Append(" :INFORMED_STATE");
				param = new OracleParameter();
				param.ParameterName =":INFORMED_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = cause.INFORMED_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("INFORMED_STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "INFORMED_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :MATNR");
				param = new OracleParameter();
				param.ParameterName =":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MATNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "MATNR"));
			}
			if(!string.IsNullOrEmpty(cause.FPHM))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.FPHM ").Append((cause.FPHM.StartsWith("%") || cause.FPHM.EndsWith("%")) ? " like " : " = ").Append(" :FPHM");
				param = new OracleParameter();
				param.ParameterName =":FPHM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.FPHM;
				paramList.Add(param);
			}
			if (cause.HasINValue("FPHM"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "FPHM"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.GYSNAME))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :GYSNAME");
				param = new OracleParameter();
				param.ParameterName =":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "GYSNAME"));
			}
			if(!string.IsNullOrEmpty(cause.MSEHT))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.MSEHT ").Append((cause.MSEHT.StartsWith("%") || cause.MSEHT.EndsWith("%")) ? " like " : " = ").Append(" :MSEHT");
				param = new OracleParameter();
				param.ParameterName =":MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MSEHT;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSEHT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "MSEHT"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.EBELN))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.EBELN ").Append((cause.EBELN.StartsWith("%") || cause.EBELN.EndsWith("%")) ? " like " : " = ").Append(" :EBELN");
				param = new OracleParameter();
				param.ParameterName =":EBELN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.EBELN;
				paramList.Add(param);
			}
			if (cause.HasINValue("EBELN"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "EBELN"));
			}
			if(!string.IsNullOrEmpty(cause.FPBM))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.FPBM ").Append((cause.FPBM.StartsWith("%") || cause.FPBM.EndsWith("%")) ? " like " : " = ").Append(" :FPBM");
				param = new OracleParameter();
				param.ParameterName =":FPBM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.FPBM;
				paramList.Add(param);
			}
			if (cause.HasINValue("FPBM"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "FPBM"));
			}
			if(!string.IsNullOrEmpty(cause.GYJH))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.GYJH ").Append((cause.GYJH.StartsWith("%") || cause.GYJH.EndsWith("%")) ? " like " : " = ").Append(" :GYJH");
				param = new OracleParameter();
				param.ParameterName =":GYJH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.GYJH;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYJH"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "GYJH"));
			}
			if(cause.FPJR!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.FPJR = :FPJR");
				param = new OracleParameter();
				param.ParameterName =":FPJR";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.FPJR;
				paramList.Add(param);
			}
			if (cause.HasINValue("FPJR"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "FPJR"));
			}
			if(!string.IsNullOrEmpty(cause.MATER_CODE))
			{
				strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.MATER_CODE ").Append((cause.MATER_CODE.StartsWith("%") || cause.MATER_CODE.EndsWith("%")) ? " like " : " = ").Append(" :MATER_CODE");
				param = new OracleParameter();
				param.ParameterName =":MATER_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.MATER_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATER_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "MATER_CODE"));
			}
			if(cause.VFDAT!= null)
			{
				if (cause.VFDAT.Begin != null)
				{
					strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.VFDAT >= :VFDAT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":VFDAT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.VFDAT.Begin;
					paramList.Add(param);
				}
				if (cause.VFDAT.End != null)
				{
					strBuf.Append(" And V_SCM_D_PURCHARSEPLAN.VFDAT < :VFDAT_END");
					param = new OracleParameter();
					param.ParameterName = ":VFDAT_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.VFDAT.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("VFDAT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_PURCHARSEPLAN", "VFDAT"));
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
		public static DisplayObject_V_SCM_D_PURCHARSEPLAN[] Query(CauseObject_V_SCM_D_PURCHARSEPLAN cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_D_PURCHARSEPLAN.PKG_AMOUNT, V_SCM_D_PURCHARSEPLAN.FREEUSE2, V_SCM_D_PURCHARSEPLAN.FREEUSE3, V_SCM_D_PURCHARSEPLAN.FACTORY, V_SCM_D_PURCHARSEPLAN.BEDAT, V_SCM_D_PURCHARSEPLAN.FREEUSE1, V_SCM_D_PURCHARSEPLAN.NAME, V_SCM_D_PURCHARSEPLAN.STATUS, V_SCM_D_PURCHARSEPLAN.BSART, V_SCM_D_PURCHARSEPLAN.SEND_DEPART_NAME, V_SCM_D_PURCHARSEPLAN.LINK_PERSON, V_SCM_D_PURCHARSEPLAN.SPEC, V_SCM_D_PURCHARSEPLAN.CODE, V_SCM_D_PURCHARSEPLAN.MENGE, V_SCM_D_PURCHARSEPLAN.CREATE_TIME, V_SCM_D_PURCHARSEPLAN.NETPR, V_SCM_D_PURCHARSEPLAN.HSDAT, V_SCM_D_PURCHARSEPLAN.SEND_ORDER_CODE, V_SCM_D_PURCHARSEPLAN.MEINS, V_SCM_D_PURCHARSEPLAN.SEND_DEPART, V_SCM_D_PURCHARSEPLAN.WERKST, V_SCM_D_PURCHARSEPLAN.EEIND, V_SCM_D_PURCHARSEPLAN.UNINFORMED_STATE, V_SCM_D_PURCHARSEPLAN.LGORT, V_SCM_D_PURCHARSEPLAN.TXZ01, V_SCM_D_PURCHARSEPLAN.LINK_TELEPHONE, V_SCM_D_PURCHARSEPLAN.FPRQ, V_SCM_D_PURCHARSEPLAN.ORDER_MENGE, V_SCM_D_PURCHARSEPLAN.ID, V_SCM_D_PURCHARSEPLAN.CHARG, V_SCM_D_PURCHARSEPLAN.PKG_NUMBER, V_SCM_D_PURCHARSEPLAN.WERKS, V_SCM_D_PURCHARSEPLAN.INFORMED_STATE, V_SCM_D_PURCHARSEPLAN.MATNR, V_SCM_D_PURCHARSEPLAN.FPHM, V_SCM_D_PURCHARSEPLAN.COMMENTS, V_SCM_D_PURCHARSEPLAN.GYSNAME, V_SCM_D_PURCHARSEPLAN.MSEHT, V_SCM_D_PURCHARSEPLAN.GYSACCOUNT, V_SCM_D_PURCHARSEPLAN.EBELN, V_SCM_D_PURCHARSEPLAN.FPBM, V_SCM_D_PURCHARSEPLAN.GYJH, V_SCM_D_PURCHARSEPLAN.FPJR, V_SCM_D_PURCHARSEPLAN.MATER_CODE, V_SCM_D_PURCHARSEPLAN.VFDAT from V_SCM_D_PURCHARSEPLAN where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_D_PURCHARSEPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_PURCHARSEPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FREEUSE2 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE3 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FACTORY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATUS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BSART = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SPEC = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MENGE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.HSDAT = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SEND_DEPART = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WERKST = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.EEIND = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.LGORT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.TXZ01 = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FPRQ = sqlReader.GetDateTime(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CHARG = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.WERKS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MATNR = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.FPHM = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.COMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.GYSNAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MSEHT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.EBELN = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.FPBM = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.GYJH = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.FPJR = sqlReader.GetDecimal(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.MATER_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.VFDAT = sqlReader.GetDateTime(44);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_PURCHARSEPLAN[] objs = new DisplayObject_V_SCM_D_PURCHARSEPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_SCM_D_PURCHARSEPLAN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_SCM_D_PURCHARSEPLAN where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_SCM_D_PURCHARSEPLAN[] Query(CauseObject_V_SCM_D_PURCHARSEPLAN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_D_PURCHARSEPLAN.PKG_AMOUNT, V_SCM_D_PURCHARSEPLAN.FREEUSE2, V_SCM_D_PURCHARSEPLAN.FREEUSE3, V_SCM_D_PURCHARSEPLAN.FACTORY, V_SCM_D_PURCHARSEPLAN.BEDAT, V_SCM_D_PURCHARSEPLAN.FREEUSE1, V_SCM_D_PURCHARSEPLAN.NAME, V_SCM_D_PURCHARSEPLAN.STATUS, V_SCM_D_PURCHARSEPLAN.BSART, V_SCM_D_PURCHARSEPLAN.SEND_DEPART_NAME, V_SCM_D_PURCHARSEPLAN.LINK_PERSON, V_SCM_D_PURCHARSEPLAN.SPEC, V_SCM_D_PURCHARSEPLAN.CODE, V_SCM_D_PURCHARSEPLAN.MENGE, V_SCM_D_PURCHARSEPLAN.CREATE_TIME, V_SCM_D_PURCHARSEPLAN.NETPR, V_SCM_D_PURCHARSEPLAN.HSDAT, V_SCM_D_PURCHARSEPLAN.SEND_ORDER_CODE, V_SCM_D_PURCHARSEPLAN.MEINS, V_SCM_D_PURCHARSEPLAN.SEND_DEPART, V_SCM_D_PURCHARSEPLAN.WERKST, V_SCM_D_PURCHARSEPLAN.EEIND, V_SCM_D_PURCHARSEPLAN.UNINFORMED_STATE, V_SCM_D_PURCHARSEPLAN.LGORT, V_SCM_D_PURCHARSEPLAN.TXZ01, V_SCM_D_PURCHARSEPLAN.LINK_TELEPHONE, V_SCM_D_PURCHARSEPLAN.FPRQ, V_SCM_D_PURCHARSEPLAN.ORDER_MENGE, V_SCM_D_PURCHARSEPLAN.ID, V_SCM_D_PURCHARSEPLAN.CHARG, V_SCM_D_PURCHARSEPLAN.PKG_NUMBER, V_SCM_D_PURCHARSEPLAN.WERKS, V_SCM_D_PURCHARSEPLAN.INFORMED_STATE, V_SCM_D_PURCHARSEPLAN.MATNR, V_SCM_D_PURCHARSEPLAN.FPHM, V_SCM_D_PURCHARSEPLAN.COMMENTS, V_SCM_D_PURCHARSEPLAN.GYSNAME, V_SCM_D_PURCHARSEPLAN.MSEHT, V_SCM_D_PURCHARSEPLAN.GYSACCOUNT, V_SCM_D_PURCHARSEPLAN.EBELN, V_SCM_D_PURCHARSEPLAN.FPBM, V_SCM_D_PURCHARSEPLAN.GYJH, V_SCM_D_PURCHARSEPLAN.FPJR, V_SCM_D_PURCHARSEPLAN.MATER_CODE, V_SCM_D_PURCHARSEPLAN.VFDAT from V_SCM_D_PURCHARSEPLAN where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_D_PURCHARSEPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_PURCHARSEPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FREEUSE2 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE3 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FACTORY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATUS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BSART = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SPEC = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MENGE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.HSDAT = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SEND_DEPART = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WERKST = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.EEIND = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.LGORT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.TXZ01 = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FPRQ = sqlReader.GetDateTime(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CHARG = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.WERKS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MATNR = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.FPHM = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.COMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.GYSNAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MSEHT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.EBELN = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.FPBM = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.GYJH = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.FPJR = sqlReader.GetDecimal(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.MATER_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.VFDAT = sqlReader.GetDateTime(44);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_D_PURCHARSEPLAN[] objs = new DisplayObject_V_SCM_D_PURCHARSEPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_D_PURCHARSEPLAN[] Query(CauseObject_V_SCM_D_PURCHARSEPLAN cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_D_PURCHARSEPLAN.PKG_AMOUNT, V_SCM_D_PURCHARSEPLAN.FREEUSE2, V_SCM_D_PURCHARSEPLAN.FREEUSE3, V_SCM_D_PURCHARSEPLAN.FACTORY, V_SCM_D_PURCHARSEPLAN.BEDAT, V_SCM_D_PURCHARSEPLAN.FREEUSE1, V_SCM_D_PURCHARSEPLAN.NAME, V_SCM_D_PURCHARSEPLAN.STATUS, V_SCM_D_PURCHARSEPLAN.BSART, V_SCM_D_PURCHARSEPLAN.SEND_DEPART_NAME, V_SCM_D_PURCHARSEPLAN.LINK_PERSON, V_SCM_D_PURCHARSEPLAN.SPEC, V_SCM_D_PURCHARSEPLAN.CODE, V_SCM_D_PURCHARSEPLAN.MENGE, V_SCM_D_PURCHARSEPLAN.CREATE_TIME, V_SCM_D_PURCHARSEPLAN.NETPR, V_SCM_D_PURCHARSEPLAN.HSDAT, V_SCM_D_PURCHARSEPLAN.SEND_ORDER_CODE, V_SCM_D_PURCHARSEPLAN.MEINS, V_SCM_D_PURCHARSEPLAN.SEND_DEPART, V_SCM_D_PURCHARSEPLAN.WERKST, V_SCM_D_PURCHARSEPLAN.EEIND, V_SCM_D_PURCHARSEPLAN.UNINFORMED_STATE, V_SCM_D_PURCHARSEPLAN.LGORT, V_SCM_D_PURCHARSEPLAN.TXZ01, V_SCM_D_PURCHARSEPLAN.LINK_TELEPHONE, V_SCM_D_PURCHARSEPLAN.FPRQ, V_SCM_D_PURCHARSEPLAN.ORDER_MENGE, V_SCM_D_PURCHARSEPLAN.ID, V_SCM_D_PURCHARSEPLAN.CHARG, V_SCM_D_PURCHARSEPLAN.PKG_NUMBER, V_SCM_D_PURCHARSEPLAN.WERKS, V_SCM_D_PURCHARSEPLAN.INFORMED_STATE, V_SCM_D_PURCHARSEPLAN.MATNR, V_SCM_D_PURCHARSEPLAN.FPHM, V_SCM_D_PURCHARSEPLAN.COMMENTS, V_SCM_D_PURCHARSEPLAN.GYSNAME, V_SCM_D_PURCHARSEPLAN.MSEHT, V_SCM_D_PURCHARSEPLAN.GYSACCOUNT, V_SCM_D_PURCHARSEPLAN.EBELN, V_SCM_D_PURCHARSEPLAN.FPBM, V_SCM_D_PURCHARSEPLAN.GYJH, V_SCM_D_PURCHARSEPLAN.FPJR, V_SCM_D_PURCHARSEPLAN.MATER_CODE, V_SCM_D_PURCHARSEPLAN.VFDAT from V_SCM_D_PURCHARSEPLAN where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_D_PURCHARSEPLAN",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_SCM_D_PURCHARSEPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_PURCHARSEPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FREEUSE2 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE3 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FACTORY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATUS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BSART = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SPEC = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MENGE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.HSDAT = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SEND_DEPART = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WERKST = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.EEIND = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.LGORT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.TXZ01 = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FPRQ = sqlReader.GetDateTime(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CHARG = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.WERKS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MATNR = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.FPHM = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.COMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.GYSNAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MSEHT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.EBELN = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.FPBM = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.GYJH = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.FPJR = sqlReader.GetDecimal(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.MATER_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.VFDAT = sqlReader.GetDateTime(44);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_PURCHARSEPLAN[] objs = new DisplayObject_V_SCM_D_PURCHARSEPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_D_PURCHARSEPLAN[] Query(CauseObject_V_SCM_D_PURCHARSEPLAN cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_D_PURCHARSEPLAN.PKG_AMOUNT, V_SCM_D_PURCHARSEPLAN.FREEUSE2, V_SCM_D_PURCHARSEPLAN.FREEUSE3, V_SCM_D_PURCHARSEPLAN.FACTORY, V_SCM_D_PURCHARSEPLAN.BEDAT, V_SCM_D_PURCHARSEPLAN.FREEUSE1, V_SCM_D_PURCHARSEPLAN.NAME, V_SCM_D_PURCHARSEPLAN.STATUS, V_SCM_D_PURCHARSEPLAN.BSART, V_SCM_D_PURCHARSEPLAN.SEND_DEPART_NAME, V_SCM_D_PURCHARSEPLAN.LINK_PERSON, V_SCM_D_PURCHARSEPLAN.SPEC, V_SCM_D_PURCHARSEPLAN.CODE, V_SCM_D_PURCHARSEPLAN.MENGE, V_SCM_D_PURCHARSEPLAN.CREATE_TIME, V_SCM_D_PURCHARSEPLAN.NETPR, V_SCM_D_PURCHARSEPLAN.HSDAT, V_SCM_D_PURCHARSEPLAN.SEND_ORDER_CODE, V_SCM_D_PURCHARSEPLAN.MEINS, V_SCM_D_PURCHARSEPLAN.SEND_DEPART, V_SCM_D_PURCHARSEPLAN.WERKST, V_SCM_D_PURCHARSEPLAN.EEIND, V_SCM_D_PURCHARSEPLAN.UNINFORMED_STATE, V_SCM_D_PURCHARSEPLAN.LGORT, V_SCM_D_PURCHARSEPLAN.TXZ01, V_SCM_D_PURCHARSEPLAN.LINK_TELEPHONE, V_SCM_D_PURCHARSEPLAN.FPRQ, V_SCM_D_PURCHARSEPLAN.ORDER_MENGE, V_SCM_D_PURCHARSEPLAN.ID, V_SCM_D_PURCHARSEPLAN.CHARG, V_SCM_D_PURCHARSEPLAN.PKG_NUMBER, V_SCM_D_PURCHARSEPLAN.WERKS, V_SCM_D_PURCHARSEPLAN.INFORMED_STATE, V_SCM_D_PURCHARSEPLAN.MATNR, V_SCM_D_PURCHARSEPLAN.FPHM, V_SCM_D_PURCHARSEPLAN.COMMENTS, V_SCM_D_PURCHARSEPLAN.GYSNAME, V_SCM_D_PURCHARSEPLAN.MSEHT, V_SCM_D_PURCHARSEPLAN.GYSACCOUNT, V_SCM_D_PURCHARSEPLAN.EBELN, V_SCM_D_PURCHARSEPLAN.FPBM, V_SCM_D_PURCHARSEPLAN.GYJH, V_SCM_D_PURCHARSEPLAN.FPJR, V_SCM_D_PURCHARSEPLAN.MATER_CODE, V_SCM_D_PURCHARSEPLAN.VFDAT from V_SCM_D_PURCHARSEPLAN where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_D_PURCHARSEPLAN",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_SCM_D_PURCHARSEPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_PURCHARSEPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FREEUSE2 = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE3 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FACTORY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATUS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BSART = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SPEC = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MENGE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.HSDAT = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.SEND_DEPART = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.WERKST = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.EEIND = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.LGORT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.TXZ01 = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FPRQ = sqlReader.GetDateTime(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CHARG = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.WERKS = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.MATNR = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.FPHM = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.COMMENTS = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.GYSNAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.MSEHT = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.EBELN = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.FPBM = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.GYJH = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.FPJR = sqlReader.GetDecimal(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.MATER_CODE = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.VFDAT = sqlReader.GetDateTime(44);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_D_PURCHARSEPLAN[] objs = new DisplayObject_V_SCM_D_PURCHARSEPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_SCM_D_PURCHARSEPLAN obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("PKG_AMOUNT"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.PKG_AMOUNT = :PKG_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":PKG_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PKG_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE2"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.FREEUSE2 = :FREEUSE2");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE2) ? string.Empty : obj.FREEUSE2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE3"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.FREEUSE3 = :FREEUSE3");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE3) ? string.Empty : obj.FREEUSE3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FACTORY"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.FACTORY = :FACTORY");
				param = new OracleParameter();
				param.ParameterName = ":FACTORY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.FACTORY) ? string.Empty : obj.FACTORY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BEDAT"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.BEDAT = :BEDAT");
				param = new OracleParameter();
				param.ParameterName = ":BEDAT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.BEDAT) ? string.Empty : obj.BEDAT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE1"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.FREEUSE1 = :FREEUSE1");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE1) ? string.Empty : obj.FREEUSE1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATUS"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.STATUS = :STATUS");
				param = new OracleParameter();
				param.ParameterName = ":STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.STATUS) ? string.Empty : obj.STATUS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BSART"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.BSART = :BSART");
				param = new OracleParameter();
				param.ParameterName = ":BSART";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 4;
				param.Value = string.IsNullOrEmpty(obj.BSART) ? string.Empty : obj.BSART;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEND_DEPART_NAME"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.SEND_DEPART_NAME = :SEND_DEPART_NAME");
				param = new OracleParameter();
				param.ParameterName = ":SEND_DEPART_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SEND_DEPART_NAME) ? string.Empty : obj.SEND_DEPART_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LINK_PERSON"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.LINK_PERSON = :LINK_PERSON");
				param = new OracleParameter();
				param.ParameterName = ":LINK_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.LINK_PERSON) ? string.Empty : obj.LINK_PERSON;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.SPEC = :SPEC");
				param = new OracleParameter();
				param.ParameterName = ":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MENGE"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.MENGE = :MENGE");
				param = new OracleParameter();
				param.ParameterName = ":MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MENGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NETPR"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.NETPR = :NETPR");
				param = new OracleParameter();
				param.ParameterName = ":NETPR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.NETPR) ? string.Empty : obj.NETPR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("HSDAT"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.HSDAT = :HSDAT");
				param = new OracleParameter();
				param.ParameterName = ":HSDAT";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.HSDAT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEND_ORDER_CODE"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.SEND_ORDER_CODE = :SEND_ORDER_CODE");
				param = new OracleParameter();
				param.ParameterName = ":SEND_ORDER_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.SEND_ORDER_CODE) ? string.Empty : obj.SEND_ORDER_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MEINS"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.MEINS = :MEINS");
				param = new OracleParameter();
				param.ParameterName = ":MEINS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MEINS) ? string.Empty : obj.MEINS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEND_DEPART"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.SEND_DEPART = :SEND_DEPART");
				param = new OracleParameter();
				param.ParameterName = ":SEND_DEPART";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.SEND_DEPART) ? string.Empty : obj.SEND_DEPART;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WERKST"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.WERKST = :WERKST");
				param = new OracleParameter();
				param.ParameterName = ":WERKST";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.WERKST) ? string.Empty : obj.WERKST;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EEIND"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.EEIND = :EEIND");
				param = new OracleParameter();
				param.ParameterName = ":EEIND";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.EEIND) ? string.Empty : obj.EEIND;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("UNINFORMED_STATE"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.UNINFORMED_STATE = :UNINFORMED_STATE");
				param = new OracleParameter();
				param.ParameterName = ":UNINFORMED_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.UNINFORMED_STATE) ? string.Empty : obj.UNINFORMED_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LGORT"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.LGORT = :LGORT");
				param = new OracleParameter();
				param.ParameterName = ":LGORT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.LGORT) ? string.Empty : obj.LGORT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TXZ01"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.TXZ01 = :TXZ01");
				param = new OracleParameter();
				param.ParameterName = ":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.TXZ01) ? string.Empty : obj.TXZ01;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LINK_TELEPHONE"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.LINK_TELEPHONE = :LINK_TELEPHONE");
				param = new OracleParameter();
				param.ParameterName = ":LINK_TELEPHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.LINK_TELEPHONE) ? string.Empty : obj.LINK_TELEPHONE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FPRQ"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.FPRQ = :FPRQ");
				param = new OracleParameter();
				param.ParameterName = ":FPRQ";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.FPRQ;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ORDER_MENGE"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.ORDER_MENGE = :ORDER_MENGE");
				param = new OracleParameter();
				param.ParameterName = ":ORDER_MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ORDER_MENGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CHARG"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.CHARG = :CHARG");
				param = new OracleParameter();
				param.ParameterName = ":CHARG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CHARG) ? string.Empty : obj.CHARG;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PKG_NUMBER"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.PKG_NUMBER = :PKG_NUMBER");
				param = new OracleParameter();
				param.ParameterName = ":PKG_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PKG_NUMBER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WERKS"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.WERKS = :WERKS");
				param = new OracleParameter();
				param.ParameterName = ":WERKS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 40;
				param.Value = string.IsNullOrEmpty(obj.WERKS) ? string.Empty : obj.WERKS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INFORMED_STATE"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.INFORMED_STATE = :INFORMED_STATE");
				param = new OracleParameter();
				param.ParameterName = ":INFORMED_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.INFORMED_STATE) ? string.Empty : obj.INFORMED_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATNR"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.MATNR = :MATNR");
				param = new OracleParameter();
				param.ParameterName = ":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MATNR) ? string.Empty : obj.MATNR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FPHM"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.FPHM = :FPHM");
				param = new OracleParameter();
				param.ParameterName = ":FPHM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.FPHM) ? string.Empty : obj.FPHM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSNAME"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.GYSNAME = :GYSNAME");
				param = new OracleParameter();
				param.ParameterName = ":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYSNAME) ? string.Empty : obj.GYSNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MSEHT"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.MSEHT = :MSEHT");
				param = new OracleParameter();
				param.ParameterName = ":MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MSEHT) ? string.Empty : obj.MSEHT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.GYSACCOUNT = :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EBELN"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.EBELN = :EBELN");
				param = new OracleParameter();
				param.ParameterName = ":EBELN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.EBELN) ? string.Empty : obj.EBELN;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FPBM"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.FPBM = :FPBM");
				param = new OracleParameter();
				param.ParameterName = ":FPBM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.FPBM) ? string.Empty : obj.FPBM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYJH"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.GYJH = :GYJH");
				param = new OracleParameter();
				param.ParameterName = ":GYJH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.GYJH) ? string.Empty : obj.GYJH;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FPJR"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.FPJR = :FPJR");
				param = new OracleParameter();
				param.ParameterName = ":FPJR";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.FPJR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATER_CODE"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.MATER_CODE = :MATER_CODE");
				param = new OracleParameter();
				param.ParameterName = ":MATER_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.MATER_CODE) ? string.Empty : obj.MATER_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("VFDAT"))
			{
				strBuf.Add("  V_SCM_D_PURCHARSEPLAN.VFDAT = :VFDAT");
				param = new OracleParameter();
				param.ParameterName = ":VFDAT";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.VFDAT;
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
