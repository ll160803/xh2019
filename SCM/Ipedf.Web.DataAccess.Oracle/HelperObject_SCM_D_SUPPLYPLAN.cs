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
	[CauseObject(typeof(CauseObject_SCM_D_SUPPLYPLAN))]
	public partial class HelperObject_SCM_D_SUPPLYPLAN
	{		
		#region Method Blok
        //public static int Save(EntityObject_SCM_D_SUPPLYPLAN obj,IDbTransaction trans)
        //{
			
        //    //平台自动生成代码
        //    obj.ID= Guid.NewGuid().ToString();
        //    string sSql = "insert into SCM_D_SUPPLYPLAN( PKG_AMOUNT, NAME, FREEUSE2, FREEUSE3, BEDAT, FPJR, HSDAT, STATUS, DATA_ORGANISE_ID, LINK_PERSON, CODE, BSART, CREATE_TIME, NETPR, SEND_ORDER_CODE, FPBM, MEINS, CHARG, SEND_DEPART, WERKST, FREEUSE1, EEIND, STATE, UNINFORMED_STATE, INFORMED_STATE, LGORT, TXZ01, LINK_TELEPHONE, FPRQ, ID, MENGE, PKG_NUMBER, ORDER_MENGE, CREATE_USER_ID, FPHM, COMMENTS, GYSNAME, CREATE_DEPART_ID, MSEHT, GYSACCOUNT, EBELN, WERKS, GYJH, MATNR, MATER_CODE, VFDAT) values ( :PKG_AMOUNT, :NAME, :FREEUSE2, :FREEUSE3, :BEDAT, :FPJR, :HSDAT, :STATUS, :DATA_ORGANISE_ID, :LINK_PERSON, :CODE, :BSART, :CREATE_TIME, :NETPR, :SEND_ORDER_CODE, :FPBM, :MEINS, :CHARG, :SEND_DEPART, :WERKST, :FREEUSE1, :EEIND, :STATE, :UNINFORMED_STATE, :INFORMED_STATE, :LGORT, :TXZ01, :LINK_TELEPHONE, :FPRQ, :ID, :MENGE, :PKG_NUMBER, :ORDER_MENGE, :CREATE_USER_ID, :FPHM, :COMMENTS, :GYSNAME, :CREATE_DEPART_ID, :MSEHT, :GYSACCOUNT, :EBELN, :WERKS, :GYJH, :MATNR, :MATER_CODE, :VFDAT)";
        //    #region Parameters Block
        //    OracleParameter[] parameters = new OracleParameter[46];
        //    parameters[0] = new OracleParameter();
        //    parameters[0].ParameterName =":PKG_AMOUNT";
        //    parameters[0].Size = 22;
        //    parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
        //    parameters[0].Value = obj.PKG_AMOUNT;
        //    parameters[1] = new OracleParameter();
        //    parameters[1].ParameterName =":NAME";
        //    parameters[1].Size = 50;
        //    parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[1].Value = obj.NAME == null ? String.Empty:obj.NAME;
        //    parameters[2] = new OracleParameter();
        //    parameters[2].ParameterName =":FREEUSE2";
        //    parameters[2].Size = 50;
        //    parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[2].Value = obj.FREEUSE2 == null ? String.Empty:obj.FREEUSE2;
        //    parameters[3] = new OracleParameter();
        //    parameters[3].ParameterName =":FREEUSE3";
        //    parameters[3].Size = 100;
        //    parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[3].Value = obj.FREEUSE3 == null ? String.Empty:obj.FREEUSE3;
        //    parameters[4] = new OracleParameter();
        //    parameters[4].ParameterName =":BEDAT";
        //    parameters[4].Size = 8;
        //    parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[4].Value = obj.BEDAT == null ? String.Empty:obj.BEDAT;
        //    parameters[5] = new OracleParameter();
        //    parameters[5].ParameterName =":FPJR";
        //    parameters[5].Size = 22;
        //    parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
        //    parameters[5].Value = obj.FPJR;
        //    parameters[6] = new OracleParameter();
        //    parameters[6].ParameterName =":HSDAT";
        //    parameters[6].Size = 7;
        //    parameters[6].OracleType = System.Data.OracleClient.OracleType.DateTime;
        //    parameters[6].Value = obj.HSDAT;
        //    parameters[7] = new OracleParameter();
        //    parameters[7].ParameterName =":STATUS";
        //    parameters[7].Size = 1;
        //    parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[7].Value = obj.STATUS == null ? String.Empty:obj.STATUS;
        //    parameters[8] = new OracleParameter();
        //    parameters[8].ParameterName =":DATA_ORGANISE_ID";
        //    parameters[8].Size = 36;
        //    parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[8].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
        //    parameters[9] = new OracleParameter();
        //    parameters[9].ParameterName =":LINK_PERSON";
        //    parameters[9].Size = 50;
        //    parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[9].Value = obj.LINK_PERSON == null ? String.Empty:obj.LINK_PERSON;
        //    parameters[10] = new OracleParameter();
        //    parameters[10].ParameterName =":CODE";
        //    parameters[10].Size = 50;
        //    parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[10].Value = obj.CODE == null ? String.Empty:obj.CODE;
        //    parameters[11] = new OracleParameter();
        //    parameters[11].ParameterName =":BSART";
        //    parameters[11].Size = 4;
        //    parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[11].Value = obj.BSART == null ? String.Empty:obj.BSART;
        //    parameters[12] = new OracleParameter();
        //    parameters[12].ParameterName =":CREATE_TIME";
        //    parameters[12].Size = 7;
        //    parameters[12].OracleType = System.Data.OracleClient.OracleType.DateTime;
        //    parameters[12].Value = obj.CREATE_TIME;
        //    parameters[13] = new OracleParameter();
        //    parameters[13].ParameterName =":NETPR";
        //    parameters[13].Size = 20;
        //    parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[13].Value = obj.NETPR == null ? String.Empty:obj.NETPR;
        //    parameters[14] = new OracleParameter();
        //    parameters[14].ParameterName =":SEND_ORDER_CODE";
        //    parameters[14].Size = 20;
        //    parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[14].Value = obj.SEND_ORDER_CODE == null ? String.Empty:obj.SEND_ORDER_CODE;
        //    parameters[15] = new OracleParameter();
        //    parameters[15].ParameterName =":FPBM";
        //    parameters[15].Size = 200;
        //    parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[15].Value = obj.FPBM == null ? String.Empty:obj.FPBM;
        //    parameters[16] = new OracleParameter();
        //    parameters[16].ParameterName =":MEINS";
        //    parameters[16].Size = 50;
        //    parameters[16].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[16].Value = obj.MEINS == null ? String.Empty:obj.MEINS;
        //    parameters[17] = new OracleParameter();
        //    parameters[17].ParameterName =":CHARG";
        //    parameters[17].Size = 50;
        //    parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[17].Value = obj.CHARG == null ? String.Empty:obj.CHARG;
        //    parameters[18] = new OracleParameter();
        //    parameters[18].ParameterName =":SEND_DEPART";
        //    parameters[18].Size = 36;
        //    parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[18].Value = obj.SEND_DEPART == null ? String.Empty:obj.SEND_DEPART;
        //    parameters[19] = new OracleParameter();
        //    parameters[19].ParameterName =":WERKST";
        //    parameters[19].Size = 50;
        //    parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[19].Value = obj.WERKST == null ? String.Empty:obj.WERKST;
        //    parameters[20] = new OracleParameter();
        //    parameters[20].ParameterName =":FREEUSE1";
        //    parameters[20].Size = 10;
        //    parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[20].Value = obj.FREEUSE1 == null ? String.Empty:obj.FREEUSE1;
        //    parameters[21] = new OracleParameter();
        //    parameters[21].ParameterName =":EEIND";
        //    parameters[21].Size = 8;
        //    parameters[21].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[21].Value = obj.EEIND == null ? String.Empty:obj.EEIND;
        //    parameters[22] = new OracleParameter();
        //    parameters[22].ParameterName =":STATE";
        //    parameters[22].Size = 22;
        //    parameters[22].OracleType = System.Data.OracleClient.OracleType.Number;
        //    parameters[22].Value = obj.STATE;
        //    parameters[23] = new OracleParameter();
        //    parameters[23].ParameterName =":UNINFORMED_STATE";
        //    parameters[23].Size = 1;
        //    parameters[23].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[23].Value = obj.UNINFORMED_STATE == null ? String.Empty:obj.UNINFORMED_STATE;
        //    parameters[24] = new OracleParameter();
        //    parameters[24].ParameterName =":INFORMED_STATE";
        //    parameters[24].Size = 1;
        //    parameters[24].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[24].Value = obj.INFORMED_STATE == null ? String.Empty:obj.INFORMED_STATE;
        //    parameters[25] = new OracleParameter();
        //    parameters[25].ParameterName =":LGORT";
        //    parameters[25].Size = 200;
        //    parameters[25].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[25].Value = obj.LGORT == null ? String.Empty:obj.LGORT;
        //    parameters[26] = new OracleParameter();
        //    parameters[26].ParameterName =":TXZ01";
        //    parameters[26].Size = 200;
        //    parameters[26].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[26].Value = obj.TXZ01 == null ? String.Empty:obj.TXZ01;
        //    parameters[27] = new OracleParameter();
        //    parameters[27].ParameterName =":LINK_TELEPHONE";
        //    parameters[27].Size = 50;
        //    parameters[27].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[27].Value = obj.LINK_TELEPHONE == null ? String.Empty:obj.LINK_TELEPHONE;
        //    parameters[28] = new OracleParameter();
        //    parameters[28].ParameterName =":FPRQ";
        //    parameters[28].Size = 7;
        //    parameters[28].OracleType = System.Data.OracleClient.OracleType.DateTime;
        //    parameters[28].Value = obj.FPRQ;
        //    parameters[29] = new OracleParameter();
        //    parameters[29].ParameterName =":ID";
        //    parameters[29].Size = 36;
        //    parameters[29].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[29].Value = obj.ID == null ? String.Empty:obj.ID;
        //    parameters[30] = new OracleParameter();
        //    parameters[30].ParameterName =":MENGE";
        //    parameters[30].Size = 22;
        //    parameters[30].OracleType = System.Data.OracleClient.OracleType.Number;
        //    parameters[30].Value = obj.MENGE;
        //    parameters[31] = new OracleParameter();
        //    parameters[31].ParameterName =":PKG_NUMBER";
        //    parameters[31].Size = 22;
        //    parameters[31].OracleType = System.Data.OracleClient.OracleType.Number;
        //    parameters[31].Value = obj.PKG_NUMBER;
        //    parameters[32] = new OracleParameter();
        //    parameters[32].ParameterName =":ORDER_MENGE";
        //    parameters[32].Size = 22;
        //    parameters[32].OracleType = System.Data.OracleClient.OracleType.Number;
        //    parameters[32].Value = obj.ORDER_MENGE;
        //    parameters[33] = new OracleParameter();
        //    parameters[33].ParameterName =":CREATE_USER_ID";
        //    parameters[33].Size = 36;
        //    parameters[33].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[33].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
        //    parameters[34] = new OracleParameter();
        //    parameters[34].ParameterName =":FPHM";
        //    parameters[34].Size = 20;
        //    parameters[34].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[34].Value = obj.FPHM == null ? String.Empty:obj.FPHM;
        //    parameters[35] = new OracleParameter();
        //    parameters[35].ParameterName =":COMMENTS";
        //    parameters[35].Size = 200;
        //    parameters[35].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[35].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
        //    parameters[36] = new OracleParameter();
        //    parameters[36].ParameterName =":GYSNAME";
        //    parameters[36].Size = 50;
        //    parameters[36].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[36].Value = obj.GYSNAME == null ? String.Empty:obj.GYSNAME;
        //    parameters[37] = new OracleParameter();
        //    parameters[37].ParameterName =":CREATE_DEPART_ID";
        //    parameters[37].Size = 36;
        //    parameters[37].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[37].Value = obj.CREATE_DEPART_ID == null ? String.Empty:obj.CREATE_DEPART_ID;
        //    parameters[38] = new OracleParameter();
        //    parameters[38].ParameterName =":MSEHT";
        //    parameters[38].Size = 50;
        //    parameters[38].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[38].Value = obj.MSEHT == null ? String.Empty:obj.MSEHT;
        //    parameters[39] = new OracleParameter();
        //    parameters[39].ParameterName =":GYSACCOUNT";
        //    parameters[39].Size = 50;
        //    parameters[39].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[39].Value = obj.GYSACCOUNT == null ? String.Empty:obj.GYSACCOUNT;
        //    parameters[40] = new OracleParameter();
        //    parameters[40].ParameterName =":EBELN";
        //    parameters[40].Size = 50;
        //    parameters[40].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[40].Value = obj.EBELN == null ? String.Empty:obj.EBELN;
        //    parameters[41] = new OracleParameter();
        //    parameters[41].ParameterName =":WERKS";
        //    parameters[41].Size = 40;
        //    parameters[41].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[41].Value = obj.WERKS == null ? String.Empty:obj.WERKS;
        //    parameters[42] = new OracleParameter();
        //    parameters[42].ParameterName =":GYJH";
        //    parameters[42].Size = 13;
        //    parameters[42].OracleType = System.Data.OracleClient.OracleType.Char;
        //    parameters[42].Value = obj.GYJH == null ? String.Empty:obj.GYJH;
        //    parameters[43] = new OracleParameter();
        //    parameters[43].ParameterName =":MATNR";
        //    parameters[43].Size = 50;
        //    parameters[43].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[43].Value = obj.MATNR == null ? String.Empty:obj.MATNR;
        //    parameters[44] = new OracleParameter();
        //    parameters[44].ParameterName =":MATER_CODE";
        //    parameters[44].Size = 100;
        //    parameters[44].OracleType = System.Data.OracleClient.OracleType.VarChar;
        //    parameters[44].Value = obj.MATER_CODE == null ? String.Empty:obj.MATER_CODE;
        //    parameters[45] = new OracleParameter();
        //    parameters[45].ParameterName =":VFDAT";
        //    parameters[45].Size = 7;
        //    parameters[45].OracleType = System.Data.OracleClient.OracleType.DateTime;
        //    parameters[45].Value = obj.VFDAT;
        //    #endregion 
        //    return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
        //}
		public static int Update(EntityObject_SCM_D_SUPPLYPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_D_SUPPLYPLAN set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SCM_D_SUPPLYPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SCM_D_SUPPLYPLAN where  ID = :ID ";
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
		public static EntityObject_SCM_D_SUPPLYPLAN Get(EntityObject_SCM_D_SUPPLYPLAN obj)
		{
			
			//平台自动生成代码
			string sSql = "select  PKG_AMOUNT, NAME, FREEUSE2, FREEUSE3, BEDAT, FPJR, MODIFY_DEPART_ID, HSDAT, STATUS, DATA_ORGANISE_ID, LINK_PERSON, CODE, BSART, MODIFY_TIME, CREATE_TIME, NETPR, SEND_ORDER_CODE, FPBM, MEINS, CHARG, SEND_DEPART, WERKST, FREEUSE1, EEIND, STATE, UNINFORMED_STATE, INFORMED_STATE, LGORT, TXZ01, LINK_TELEPHONE, FPRQ, ID, MENGE, PKG_NUMBER, MODIFY_USER_ID, ORDER_MENGE, CREATE_USER_ID, FPHM, COMMENTS, GYSNAME, CREATE_DEPART_ID, MSEHT, GYSACCOUNT, EBELN, WERKS, GYJH, MATNR, MATER_CODE, VFDAT from SCM_D_SUPPLYPLAN where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_D_SUPPLYPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_D_SUPPLYPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE2 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FPJR = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATUS = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FPBM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CHARG = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SEND_DEPART = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.WERKST = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREEUSE1 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.EEIND = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.LGORT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.TXZ01 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FPRQ = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MENGE = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.FPHM = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.COMMENTS = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.GYSNAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.MSEHT = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.EBELN = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.WERKS = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.GYJH = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MATNR = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.MATER_CODE = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.VFDAT = sqlReader.GetDateTime(48);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SCM_D_SUPPLYPLAN[] objs = new EntityObject_SCM_D_SUPPLYPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_SCM_D_SUPPLYPLAN Get(EntityObject_SCM_D_SUPPLYPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  PKG_AMOUNT, NAME, FREEUSE2, FREEUSE3, BEDAT, FPJR, MODIFY_DEPART_ID, HSDAT, STATUS, DATA_ORGANISE_ID, LINK_PERSON, CODE, BSART, MODIFY_TIME, CREATE_TIME, NETPR, SEND_ORDER_CODE, FPBM, MEINS, CHARG, SEND_DEPART, WERKST, FREEUSE1, EEIND, STATE, UNINFORMED_STATE, INFORMED_STATE, LGORT, TXZ01, LINK_TELEPHONE, FPRQ, ID, MENGE, PKG_NUMBER, MODIFY_USER_ID, ORDER_MENGE, CREATE_USER_ID, FPHM, COMMENTS, GYSNAME, CREATE_DEPART_ID, MSEHT, GYSACCOUNT, EBELN, WERKS, GYJH, MATNR, MATER_CODE, VFDAT from SCM_D_SUPPLYPLAN where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_D_SUPPLYPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_D_SUPPLYPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE2 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FPJR = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATUS = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FPBM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CHARG = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SEND_DEPART = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.WERKST = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREEUSE1 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.EEIND = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.LGORT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.TXZ01 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FPRQ = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MENGE = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.FPHM = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.COMMENTS = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.GYSNAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.MSEHT = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.EBELN = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.WERKS = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.GYJH = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MATNR = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.MATER_CODE = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.VFDAT = sqlReader.GetDateTime(48);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SCM_D_SUPPLYPLAN[] objs = new EntityObject_SCM_D_SUPPLYPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_D_SUPPLYPLAN[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SCM_D_SUPPLYPLAN.PKG_AMOUNT, SCM_D_SUPPLYPLAN.NAME, SCM_D_SUPPLYPLAN.FREEUSE2, SCM_D_SUPPLYPLAN.FREEUSE3, SCM_D_SUPPLYPLAN.BEDAT, SCM_D_SUPPLYPLAN.FPJR, SCM_D_SUPPLYPLAN.MODIFY_DEPART_ID, SCM_D_SUPPLYPLAN.HSDAT, SCM_D_SUPPLYPLAN.STATUS, SCM_D_SUPPLYPLAN.DATA_ORGANISE_ID, SCM_D_SUPPLYPLAN.LINK_PERSON, SCM_D_SUPPLYPLAN.CODE, SCM_D_SUPPLYPLAN.BSART, SCM_D_SUPPLYPLAN.MODIFY_TIME, SCM_D_SUPPLYPLAN.CREATE_TIME, SCM_D_SUPPLYPLAN.NETPR, SCM_D_SUPPLYPLAN.SEND_ORDER_CODE, SCM_D_SUPPLYPLAN.FPBM, SCM_D_SUPPLYPLAN.MEINS, SCM_D_SUPPLYPLAN.CHARG, SCM_D_SUPPLYPLAN.SEND_DEPART, SCM_D_SUPPLYPLAN.WERKST, SCM_D_SUPPLYPLAN.FREEUSE1, SCM_D_SUPPLYPLAN.EEIND, SCM_D_SUPPLYPLAN.STATE, SCM_D_SUPPLYPLAN.UNINFORMED_STATE, SCM_D_SUPPLYPLAN.INFORMED_STATE, SCM_D_SUPPLYPLAN.LGORT, SCM_D_SUPPLYPLAN.TXZ01, SCM_D_SUPPLYPLAN.LINK_TELEPHONE, SCM_D_SUPPLYPLAN.FPRQ, SCM_D_SUPPLYPLAN.ID, SCM_D_SUPPLYPLAN.MENGE, SCM_D_SUPPLYPLAN.PKG_NUMBER, SCM_D_SUPPLYPLAN.MODIFY_USER_ID, SCM_D_SUPPLYPLAN.ORDER_MENGE, SCM_D_SUPPLYPLAN.CREATE_USER_ID, SCM_D_SUPPLYPLAN.FPHM, SCM_D_SUPPLYPLAN.COMMENTS, SCM_D_SUPPLYPLAN.GYSNAME, SCM_D_SUPPLYPLAN.CREATE_DEPART_ID, SCM_D_SUPPLYPLAN.MSEHT, SCM_D_SUPPLYPLAN.GYSACCOUNT, SCM_D_SUPPLYPLAN.EBELN, SCM_D_SUPPLYPLAN.WERKS, SCM_D_SUPPLYPLAN.GYJH, SCM_D_SUPPLYPLAN.MATNR, SCM_D_SUPPLYPLAN.MATER_CODE, SCM_D_SUPPLYPLAN.VFDAT, SCM_D_SENDDEPART_SEND_DEPART.NAME as SEND_DEPART_NAME from SCM_D_SUPPLYPLAN left join SCM_D_SENDDEPART   SCM_D_SENDDEPART_SEND_DEPART on SCM_D_SUPPLYPLAN.SEND_DEPART = SCM_D_SENDDEPART_SEND_DEPART.CODE where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SCM_D_SUPPLYPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_SUPPLYPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE2 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FPJR = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATUS = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FPBM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CHARG = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SEND_DEPART = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.WERKST = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREEUSE1 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.EEIND = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.LGORT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.TXZ01 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FPRQ = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MENGE = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.FPHM = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.COMMENTS = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.GYSNAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.MSEHT = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.EBELN = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.WERKS = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.GYJH = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MATNR = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.MATER_CODE = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.VFDAT = sqlReader.GetDateTime(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(49);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_D_SUPPLYPLAN[] objs = new DisplayObject_SCM_D_SUPPLYPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SCM_D_SUPPLYPLAN cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.PKG_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.PKG_AMOUNT = :PKG_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":PKG_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PKG_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("PKG_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "PKG_AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE2))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.FREEUSE2 ").Append((cause.FREEUSE2.StartsWith("%") || cause.FREEUSE2.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE2");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 50;
				param.Value = cause.FREEUSE2;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE2"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FREEUSE2"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE3))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.FREEUSE3 ").Append((cause.FREEUSE3.StartsWith("%") || cause.FREEUSE3.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE3");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 100;
				param.Value = cause.FREEUSE3;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE3"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FREEUSE3"));
			}
			if(!string.IsNullOrEmpty(cause.BEDAT))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.BEDAT ").Append((cause.BEDAT.StartsWith("%") || cause.BEDAT.EndsWith("%")) ? " like " : " = ").Append(" :BEDAT");
				param = new OracleParameter();
				param.ParameterName =":BEDAT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 8;
				param.Value = cause.BEDAT;
				paramList.Add(param);
			}
			if (cause.HasINValue("BEDAT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "BEDAT"));
			}
			if(cause.FPJR!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.FPJR = :FPJR");
				param = new OracleParameter();
				param.ParameterName =":FPJR";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.FPJR;
				paramList.Add(param);
			}
			if (cause.HasINValue("FPJR"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FPJR"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MODIFY_DEPART_ID"));
			}
			if(cause.HSDAT!= null)
			{
				if (cause.HSDAT.Begin != null)
				{
					strBuf.Append(" And SCM_D_SUPPLYPLAN.HSDAT >= :HSDAT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":HSDAT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.HSDAT.Begin;
					paramList.Add(param);
				}
				if (cause.HSDAT.End != null)
				{
					strBuf.Append(" And SCM_D_SUPPLYPLAN.HSDAT < :HSDAT_END");
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
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "HSDAT"));
			}
			if(!string.IsNullOrEmpty(cause.STATUS))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.STATUS ").Append((cause.STATUS.StartsWith("%") || cause.STATUS.EndsWith("%")) ? " like " : " = ").Append(" :STATUS");
				param = new OracleParameter();
				param.ParameterName =":STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.LINK_PERSON))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.LINK_PERSON ").Append((cause.LINK_PERSON.StartsWith("%") || cause.LINK_PERSON.EndsWith("%")) ? " like " : " = ").Append(" :LINK_PERSON");
				param = new OracleParameter();
				param.ParameterName =":LINK_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.LINK_PERSON;
				paramList.Add(param);
			}
			if (cause.HasINValue("LINK_PERSON"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "LINK_PERSON"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.BSART))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.BSART ").Append((cause.BSART.StartsWith("%") || cause.BSART.EndsWith("%")) ? " like " : " = ").Append(" :BSART");
				param = new OracleParameter();
				param.ParameterName =":BSART";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 4;
				param.Value = cause.BSART;
				paramList.Add(param);
			}
			if (cause.HasINValue("BSART"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "BSART"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_D_SUPPLYPLAN.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And SCM_D_SUPPLYPLAN.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MODIFY_TIME"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_D_SUPPLYPLAN.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And SCM_D_SUPPLYPLAN.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.NETPR))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.NETPR ").Append((cause.NETPR.StartsWith("%") || cause.NETPR.EndsWith("%")) ? " like " : " = ").Append(" :NETPR");
				param = new OracleParameter();
				param.ParameterName =":NETPR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.NETPR;
				paramList.Add(param);
			}
			if (cause.HasINValue("NETPR"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "NETPR"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_ORDER_CODE))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.SEND_ORDER_CODE ").Append((cause.SEND_ORDER_CODE.StartsWith("%") || cause.SEND_ORDER_CODE.EndsWith("%")) ? " like " : " = ").Append(" :SEND_ORDER_CODE");
				param = new OracleParameter();
				param.ParameterName =":SEND_ORDER_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.SEND_ORDER_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_ORDER_CODE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "SEND_ORDER_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.FPBM))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.FPBM ").Append((cause.FPBM.StartsWith("%") || cause.FPBM.EndsWith("%")) ? " like " : " = ").Append(" :FPBM");
				param = new OracleParameter();
				param.ParameterName =":FPBM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.FPBM;
				paramList.Add(param);
			}
			if (cause.HasINValue("FPBM"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FPBM"));
			}
			if(!string.IsNullOrEmpty(cause.MEINS))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.MEINS ").Append((cause.MEINS.StartsWith("%") || cause.MEINS.EndsWith("%")) ? " like " : " = ").Append(" :MEINS");
				param = new OracleParameter();
				param.ParameterName =":MEINS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MEINS;
				paramList.Add(param);
			}
			if (cause.HasINValue("MEINS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MEINS"));
			}
			if(!string.IsNullOrEmpty(cause.CHARG))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.CHARG ").Append((cause.CHARG.StartsWith("%") || cause.CHARG.EndsWith("%")) ? " like " : " = ").Append(" :CHARG");
				param = new OracleParameter();
				param.ParameterName =":CHARG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CHARG;
				paramList.Add(param);
			}
			if (cause.HasINValue("CHARG"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "CHARG"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_DEPART))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.SEND_DEPART ").Append((cause.SEND_DEPART.StartsWith("%") || cause.SEND_DEPART.EndsWith("%")) ? " like " : " = ").Append(" :SEND_DEPART");
				param = new OracleParameter();
				param.ParameterName =":SEND_DEPART";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SEND_DEPART;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_DEPART"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "SEND_DEPART"));
			}
			if(!string.IsNullOrEmpty(cause.WERKST))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.WERKST ").Append((cause.WERKST.StartsWith("%") || cause.WERKST.EndsWith("%")) ? " like " : " = ").Append(" :WERKST");
				param = new OracleParameter();
				param.ParameterName =":WERKST";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.WERKST;
				paramList.Add(param);
			}
			if (cause.HasINValue("WERKST"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "WERKST"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE1))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.FREEUSE1 ").Append((cause.FREEUSE1.StartsWith("%") || cause.FREEUSE1.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE1");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.FREEUSE1;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE1"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FREEUSE1"));
			}
			if(!string.IsNullOrEmpty(cause.EEIND))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.EEIND ").Append((cause.EEIND.StartsWith("%") || cause.EEIND.EndsWith("%")) ? " like " : " = ").Append(" :EEIND");
				param = new OracleParameter();
				param.ParameterName =":EEIND";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 8;
				param.Value = cause.EEIND;
				paramList.Add(param);
			}
			if (cause.HasINValue("EEIND"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "EEIND"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.UNINFORMED_STATE))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.UNINFORMED_STATE ").Append((cause.UNINFORMED_STATE.StartsWith("%") || cause.UNINFORMED_STATE.EndsWith("%")) ? " like " : " = ").Append(" :UNINFORMED_STATE");
				param = new OracleParameter();
				param.ParameterName =":UNINFORMED_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = cause.UNINFORMED_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNINFORMED_STATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "UNINFORMED_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.INFORMED_STATE))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.INFORMED_STATE ").Append((cause.INFORMED_STATE.StartsWith("%") || cause.INFORMED_STATE.EndsWith("%")) ? " like " : " = ").Append(" :INFORMED_STATE");
				param = new OracleParameter();
				param.ParameterName =":INFORMED_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = cause.INFORMED_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("INFORMED_STATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "INFORMED_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.LGORT))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.LGORT ").Append((cause.LGORT.StartsWith("%") || cause.LGORT.EndsWith("%")) ? " like " : " = ").Append(" :LGORT");
				param = new OracleParameter();
				param.ParameterName =":LGORT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.LGORT;
				paramList.Add(param);
			}
			if (cause.HasINValue("LGORT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "LGORT"));
			}
			if(!string.IsNullOrEmpty(cause.TXZ01))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :TXZ01");
				param = new OracleParameter();
				param.ParameterName =":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.TXZ01;
				paramList.Add(param);
			}
			if (cause.HasINValue("TXZ01"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "TXZ01"));
			}
			if(!string.IsNullOrEmpty(cause.LINK_TELEPHONE))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.LINK_TELEPHONE ").Append((cause.LINK_TELEPHONE.StartsWith("%") || cause.LINK_TELEPHONE.EndsWith("%")) ? " like " : " = ").Append(" :LINK_TELEPHONE");
				param = new OracleParameter();
				param.ParameterName =":LINK_TELEPHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.LINK_TELEPHONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("LINK_TELEPHONE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "LINK_TELEPHONE"));
			}
			if(cause.FPRQ!= null)
			{
				if (cause.FPRQ.Begin != null)
				{
					strBuf.Append(" And SCM_D_SUPPLYPLAN.FPRQ >= :FPRQ_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":FPRQ_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.FPRQ.Begin;
					paramList.Add(param);
				}
				if (cause.FPRQ.End != null)
				{
					strBuf.Append(" And SCM_D_SUPPLYPLAN.FPRQ < :FPRQ_END");
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
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FPRQ"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "ID"));
			}
			if(cause.MENGE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.MENGE = :MENGE");
				param = new OracleParameter();
				param.ParameterName =":MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MENGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MENGE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MENGE"));
			}
			if(cause.PKG_NUMBER!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.PKG_NUMBER = :PKG_NUMBER");
				param = new OracleParameter();
				param.ParameterName =":PKG_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PKG_NUMBER;
				paramList.Add(param);
			}
			if (cause.HasINValue("PKG_NUMBER"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "PKG_NUMBER"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MODIFY_USER_ID"));
			}
			if(cause.ORDER_MENGE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.ORDER_MENGE = :ORDER_MENGE");
				param = new OracleParameter();
				param.ParameterName =":ORDER_MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ORDER_MENGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ORDER_MENGE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "ORDER_MENGE"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FPHM))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.FPHM ").Append((cause.FPHM.StartsWith("%") || cause.FPHM.EndsWith("%")) ? " like " : " = ").Append(" :FPHM");
				param = new OracleParameter();
				param.ParameterName =":FPHM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.FPHM;
				paramList.Add(param);
			}
			if (cause.HasINValue("FPHM"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FPHM"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.GYSNAME))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :GYSNAME");
				param = new OracleParameter();
				param.ParameterName =":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSNAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "GYSNAME"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "CREATE_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MSEHT))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.MSEHT ").Append((cause.MSEHT.StartsWith("%") || cause.MSEHT.EndsWith("%")) ? " like " : " = ").Append(" :MSEHT");
				param = new OracleParameter();
				param.ParameterName =":MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MSEHT;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSEHT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MSEHT"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.EBELN))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.EBELN ").Append((cause.EBELN.StartsWith("%") || cause.EBELN.EndsWith("%")) ? " like " : " = ").Append(" :EBELN");
				param = new OracleParameter();
				param.ParameterName =":EBELN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.EBELN;
				paramList.Add(param);
			}
			if (cause.HasINValue("EBELN"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "EBELN"));
			}
			if(!string.IsNullOrEmpty(cause.WERKS))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.WERKS ").Append((cause.WERKS.StartsWith("%") || cause.WERKS.EndsWith("%")) ? " like " : " = ").Append(" :WERKS");
				param = new OracleParameter();
				param.ParameterName =":WERKS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 40;
				param.Value = cause.WERKS;
				paramList.Add(param);
			}
			if (cause.HasINValue("WERKS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "WERKS"));
			}
			if(!string.IsNullOrEmpty(cause.GYJH))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.GYJH ").Append((cause.GYJH.StartsWith("%") || cause.GYJH.EndsWith("%")) ? " like " : " = ").Append(" :GYJH");
				param = new OracleParameter();
				param.ParameterName =":GYJH";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 13;
				param.Value = cause.GYJH;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYJH"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "GYJH"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :MATNR");
				param = new OracleParameter();
				param.ParameterName =":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MATNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MATNR"));
			}
			if(!string.IsNullOrEmpty(cause.MATER_CODE))
			{
				strBuf.Append(" And SCM_D_SUPPLYPLAN.MATER_CODE ").Append((cause.MATER_CODE.StartsWith("%") || cause.MATER_CODE.EndsWith("%")) ? " like " : " = ").Append(" :MATER_CODE");
				param = new OracleParameter();
				param.ParameterName =":MATER_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.MATER_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATER_CODE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MATER_CODE"));
			}
			if(cause.VFDAT!= null)
			{
				if (cause.VFDAT.Begin != null)
				{
					strBuf.Append(" And SCM_D_SUPPLYPLAN.VFDAT >= :VFDAT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":VFDAT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.VFDAT.Begin;
					paramList.Add(param);
				}
				if (cause.VFDAT.End != null)
				{
					strBuf.Append(" And SCM_D_SUPPLYPLAN.VFDAT < :VFDAT_END");
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
				strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "VFDAT"));
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
		public static DisplayObject_SCM_D_SUPPLYPLAN[] Query(CauseObject_SCM_D_SUPPLYPLAN cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_D_SUPPLYPLAN.PKG_AMOUNT, SCM_D_SUPPLYPLAN.NAME, SCM_D_SUPPLYPLAN.FREEUSE2, SCM_D_SUPPLYPLAN.FREEUSE3, SCM_D_SUPPLYPLAN.BEDAT, SCM_D_SUPPLYPLAN.FPJR, SCM_D_SUPPLYPLAN.MODIFY_DEPART_ID, SCM_D_SUPPLYPLAN.HSDAT, SCM_D_SUPPLYPLAN.STATUS, SCM_D_SUPPLYPLAN.DATA_ORGANISE_ID, SCM_D_SUPPLYPLAN.LINK_PERSON, SCM_D_SUPPLYPLAN.CODE, SCM_D_SUPPLYPLAN.BSART, SCM_D_SUPPLYPLAN.MODIFY_TIME, SCM_D_SUPPLYPLAN.CREATE_TIME, SCM_D_SUPPLYPLAN.NETPR, SCM_D_SUPPLYPLAN.SEND_ORDER_CODE, SCM_D_SUPPLYPLAN.FPBM, SCM_D_SUPPLYPLAN.MEINS, SCM_D_SUPPLYPLAN.CHARG, SCM_D_SUPPLYPLAN.SEND_DEPART, SCM_D_SUPPLYPLAN.WERKST, SCM_D_SUPPLYPLAN.FREEUSE1, SCM_D_SUPPLYPLAN.EEIND, SCM_D_SUPPLYPLAN.STATE, SCM_D_SUPPLYPLAN.UNINFORMED_STATE, SCM_D_SUPPLYPLAN.INFORMED_STATE, SCM_D_SUPPLYPLAN.LGORT, SCM_D_SUPPLYPLAN.TXZ01, SCM_D_SUPPLYPLAN.LINK_TELEPHONE, SCM_D_SUPPLYPLAN.FPRQ, SCM_D_SUPPLYPLAN.ID, SCM_D_SUPPLYPLAN.MENGE, SCM_D_SUPPLYPLAN.PKG_NUMBER, SCM_D_SUPPLYPLAN.MODIFY_USER_ID, SCM_D_SUPPLYPLAN.ORDER_MENGE, SCM_D_SUPPLYPLAN.CREATE_USER_ID, SCM_D_SUPPLYPLAN.FPHM, SCM_D_SUPPLYPLAN.COMMENTS, SCM_D_SUPPLYPLAN.GYSNAME, SCM_D_SUPPLYPLAN.CREATE_DEPART_ID, SCM_D_SUPPLYPLAN.MSEHT, SCM_D_SUPPLYPLAN.GYSACCOUNT, SCM_D_SUPPLYPLAN.EBELN, SCM_D_SUPPLYPLAN.WERKS, SCM_D_SUPPLYPLAN.GYJH, SCM_D_SUPPLYPLAN.MATNR, SCM_D_SUPPLYPLAN.MATER_CODE, SCM_D_SUPPLYPLAN.VFDAT, SCM_D_SENDDEPART_SEND_DEPART.NAME as SEND_DEPART_NAME from SCM_D_SUPPLYPLAN left join SCM_D_SENDDEPART   SCM_D_SENDDEPART_SEND_DEPART on SCM_D_SUPPLYPLAN.SEND_DEPART = SCM_D_SENDDEPART_SEND_DEPART.CODE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_D_SUPPLYPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_SUPPLYPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE2 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FPJR = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATUS = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FPBM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CHARG = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SEND_DEPART = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.WERKST = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREEUSE1 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.EEIND = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.LGORT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.TXZ01 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FPRQ = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MENGE = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.FPHM = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.COMMENTS = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.GYSNAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.MSEHT = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.EBELN = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.WERKS = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.GYJH = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MATNR = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.MATER_CODE = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.VFDAT = sqlReader.GetDateTime(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(49);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_D_SUPPLYPLAN[] objs = new DisplayObject_SCM_D_SUPPLYPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_SCM_D_SUPPLYPLAN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SCM_D_SUPPLYPLAN where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_SCM_D_SUPPLYPLAN[] Query(CauseObject_SCM_D_SUPPLYPLAN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_D_SUPPLYPLAN.PKG_AMOUNT, SCM_D_SUPPLYPLAN.NAME, SCM_D_SUPPLYPLAN.FREEUSE2, SCM_D_SUPPLYPLAN.FREEUSE3, SCM_D_SUPPLYPLAN.BEDAT, SCM_D_SUPPLYPLAN.FPJR, SCM_D_SUPPLYPLAN.MODIFY_DEPART_ID, SCM_D_SUPPLYPLAN.HSDAT, SCM_D_SUPPLYPLAN.STATUS, SCM_D_SUPPLYPLAN.DATA_ORGANISE_ID, SCM_D_SUPPLYPLAN.LINK_PERSON, SCM_D_SUPPLYPLAN.CODE, SCM_D_SUPPLYPLAN.BSART, SCM_D_SUPPLYPLAN.MODIFY_TIME, SCM_D_SUPPLYPLAN.CREATE_TIME, SCM_D_SUPPLYPLAN.NETPR, SCM_D_SUPPLYPLAN.SEND_ORDER_CODE, SCM_D_SUPPLYPLAN.FPBM, SCM_D_SUPPLYPLAN.MEINS, SCM_D_SUPPLYPLAN.CHARG, SCM_D_SUPPLYPLAN.SEND_DEPART, SCM_D_SUPPLYPLAN.WERKST, SCM_D_SUPPLYPLAN.FREEUSE1, SCM_D_SUPPLYPLAN.EEIND, SCM_D_SUPPLYPLAN.STATE, SCM_D_SUPPLYPLAN.UNINFORMED_STATE, SCM_D_SUPPLYPLAN.INFORMED_STATE, SCM_D_SUPPLYPLAN.LGORT, SCM_D_SUPPLYPLAN.TXZ01, SCM_D_SUPPLYPLAN.LINK_TELEPHONE, SCM_D_SUPPLYPLAN.FPRQ, SCM_D_SUPPLYPLAN.ID, SCM_D_SUPPLYPLAN.MENGE, SCM_D_SUPPLYPLAN.PKG_NUMBER, SCM_D_SUPPLYPLAN.MODIFY_USER_ID, SCM_D_SUPPLYPLAN.ORDER_MENGE, SCM_D_SUPPLYPLAN.CREATE_USER_ID, SCM_D_SUPPLYPLAN.FPHM, SCM_D_SUPPLYPLAN.COMMENTS, SCM_D_SUPPLYPLAN.GYSNAME, SCM_D_SUPPLYPLAN.CREATE_DEPART_ID, SCM_D_SUPPLYPLAN.MSEHT, SCM_D_SUPPLYPLAN.GYSACCOUNT, SCM_D_SUPPLYPLAN.EBELN, SCM_D_SUPPLYPLAN.WERKS, SCM_D_SUPPLYPLAN.GYJH, SCM_D_SUPPLYPLAN.MATNR, SCM_D_SUPPLYPLAN.MATER_CODE, SCM_D_SUPPLYPLAN.VFDAT, SCM_D_SENDDEPART_SEND_DEPART.NAME as SEND_DEPART_NAME from SCM_D_SUPPLYPLAN left join SCM_D_SENDDEPART   SCM_D_SENDDEPART_SEND_DEPART on SCM_D_SUPPLYPLAN.SEND_DEPART = SCM_D_SENDDEPART_SEND_DEPART.CODE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_D_SUPPLYPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_SUPPLYPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE2 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FPJR = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATUS = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FPBM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CHARG = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SEND_DEPART = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.WERKST = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREEUSE1 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.EEIND = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.LGORT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.TXZ01 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FPRQ = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MENGE = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.FPHM = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.COMMENTS = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.GYSNAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.MSEHT = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.EBELN = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.WERKS = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.GYJH = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MATNR = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.MATER_CODE = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.VFDAT = sqlReader.GetDateTime(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(49);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_D_SUPPLYPLAN[] objs = new DisplayObject_SCM_D_SUPPLYPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_D_SUPPLYPLAN[] Query(CauseObject_SCM_D_SUPPLYPLAN cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
            string sSql = " select  SCM_D_SUPPLYPLAN.PKG_AMOUNT, SCM_D_SUPPLYPLAN.NAME, SCM_D_SUPPLYPLAN.FREEUSE2, SCM_D_SUPPLYPLAN.FREEUSE3, SCM_D_SUPPLYPLAN.BEDAT, SCM_D_SUPPLYPLAN.FPJR, SCM_D_SUPPLYPLAN.MODIFY_DEPART_ID, SCM_D_SUPPLYPLAN.HSDAT, SCM_D_SUPPLYPLAN.STATUS, SCM_D_SUPPLYPLAN.DATA_ORGANISE_ID, SCM_D_SUPPLYPLAN.LINK_PERSON, SCM_D_SUPPLYPLAN.CODE, SCM_D_SUPPLYPLAN.BSART, SCM_D_SUPPLYPLAN.MODIFY_TIME, SCM_D_SUPPLYPLAN.CREATE_TIME, SCM_D_SUPPLYPLAN.NETPR, SCM_D_SUPPLYPLAN.SEND_ORDER_CODE, SCM_D_SUPPLYPLAN.FPBM, SCM_D_SUPPLYPLAN.MEINS, SCM_D_SUPPLYPLAN.CHARG, SCM_D_SUPPLYPLAN.SEND_DEPART, SCM_D_SUPPLYPLAN.WERKST, SCM_D_SUPPLYPLAN.FREEUSE1, SCM_D_SUPPLYPLAN.EEIND, SCM_D_SUPPLYPLAN.STATE, SCM_D_SUPPLYPLAN.UNINFORMED_STATE, SCM_D_SUPPLYPLAN.INFORMED_STATE, SCM_D_SUPPLYPLAN.LGORT, SCM_D_SUPPLYPLAN.TXZ01, SCM_D_SUPPLYPLAN.LINK_TELEPHONE, SCM_D_SUPPLYPLAN.FPRQ, SCM_D_SUPPLYPLAN.ID, SCM_D_SUPPLYPLAN.MENGE, SCM_D_SUPPLYPLAN.PKG_NUMBER, SCM_D_SUPPLYPLAN.MODIFY_USER_ID, SCM_D_SUPPLYPLAN.ORDER_MENGE, SCM_D_SUPPLYPLAN.CREATE_USER_ID, SCM_D_SUPPLYPLAN.FPHM, SCM_D_SUPPLYPLAN.COMMENTS, SCM_D_SUPPLYPLAN.GYSNAME, SCM_D_SUPPLYPLAN.CREATE_DEPART_ID, SCM_D_SUPPLYPLAN.MSEHT, SCM_D_SUPPLYPLAN.GYSACCOUNT, SCM_D_SUPPLYPLAN.EBELN, SCM_D_SUPPLYPLAN.WERKS, SCM_D_SUPPLYPLAN.GYJH, SCM_D_SUPPLYPLAN.MATNR, SCM_D_SUPPLYPLAN.MATER_CODE, SCM_D_SUPPLYPLAN.VFDAT, SCM_D_SENDDEPART_SEND_DEPART.NAME as SEND_DEPART_NAME,CASE WHEN OUT_CAUSE = '1' THEN '库存不足' WHEN OUT_CAUSE = '2' THEN '厂家停产' WHEN OUT_CAUSE = '3' THEN '补足上批交货' WHEN OUT_CAUSE = '4' THEN '批次拆分' ELSE '' END  AS OUT_CAUSE,SCM_D_SUPPLYPLAN.OUT_DATE from SCM_D_SUPPLYPLAN left join SCM_D_SENDDEPART   SCM_D_SENDDEPART_SEND_DEPART on SCM_D_SUPPLYPLAN.SEND_DEPART = SCM_D_SENDDEPART_SEND_DEPART.CODE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_D_SUPPLYPLAN",paging, order, sSql, parameters, connection);
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
			DisplayObject_SCM_D_SUPPLYPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_SUPPLYPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE2 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FPJR = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATUS = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FPBM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CHARG = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SEND_DEPART = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.WERKST = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREEUSE1 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.EEIND = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.LGORT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.TXZ01 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FPRQ = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MENGE = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.FPHM = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.COMMENTS = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.GYSNAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.MSEHT = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.EBELN = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.WERKS = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.GYJH = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MATNR = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.MATER_CODE = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.VFDAT = sqlReader.GetDateTime(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(49);
                if (!sqlReader.IsDBNull(50))
                    dataObj.OUT_CAUSE = sqlReader.GetString(50);
                if (!sqlReader.IsDBNull(51))
                    dataObj.OUT_DATE = sqlReader.GetDateTime(51);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_D_SUPPLYPLAN[] objs = new DisplayObject_SCM_D_SUPPLYPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_D_SUPPLYPLAN[] Query(CauseObject_SCM_D_SUPPLYPLAN cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_D_SUPPLYPLAN.PKG_AMOUNT, SCM_D_SUPPLYPLAN.NAME, SCM_D_SUPPLYPLAN.FREEUSE2, SCM_D_SUPPLYPLAN.FREEUSE3, SCM_D_SUPPLYPLAN.BEDAT, SCM_D_SUPPLYPLAN.FPJR, SCM_D_SUPPLYPLAN.MODIFY_DEPART_ID, SCM_D_SUPPLYPLAN.HSDAT, SCM_D_SUPPLYPLAN.STATUS, SCM_D_SUPPLYPLAN.DATA_ORGANISE_ID, SCM_D_SUPPLYPLAN.LINK_PERSON, SCM_D_SUPPLYPLAN.CODE, SCM_D_SUPPLYPLAN.BSART, SCM_D_SUPPLYPLAN.MODIFY_TIME, SCM_D_SUPPLYPLAN.CREATE_TIME, SCM_D_SUPPLYPLAN.NETPR, SCM_D_SUPPLYPLAN.SEND_ORDER_CODE, SCM_D_SUPPLYPLAN.FPBM, SCM_D_SUPPLYPLAN.MEINS, SCM_D_SUPPLYPLAN.CHARG, SCM_D_SUPPLYPLAN.SEND_DEPART, SCM_D_SUPPLYPLAN.WERKST, SCM_D_SUPPLYPLAN.FREEUSE1, SCM_D_SUPPLYPLAN.EEIND, SCM_D_SUPPLYPLAN.STATE, SCM_D_SUPPLYPLAN.UNINFORMED_STATE, SCM_D_SUPPLYPLAN.INFORMED_STATE, SCM_D_SUPPLYPLAN.LGORT, SCM_D_SUPPLYPLAN.TXZ01, SCM_D_SUPPLYPLAN.LINK_TELEPHONE, SCM_D_SUPPLYPLAN.FPRQ, SCM_D_SUPPLYPLAN.ID, SCM_D_SUPPLYPLAN.MENGE, SCM_D_SUPPLYPLAN.PKG_NUMBER, SCM_D_SUPPLYPLAN.MODIFY_USER_ID, SCM_D_SUPPLYPLAN.ORDER_MENGE, SCM_D_SUPPLYPLAN.CREATE_USER_ID, SCM_D_SUPPLYPLAN.FPHM, SCM_D_SUPPLYPLAN.COMMENTS, SCM_D_SUPPLYPLAN.GYSNAME, SCM_D_SUPPLYPLAN.CREATE_DEPART_ID, SCM_D_SUPPLYPLAN.MSEHT, SCM_D_SUPPLYPLAN.GYSACCOUNT, SCM_D_SUPPLYPLAN.EBELN, SCM_D_SUPPLYPLAN.WERKS, SCM_D_SUPPLYPLAN.GYJH, SCM_D_SUPPLYPLAN.MATNR, SCM_D_SUPPLYPLAN.MATER_CODE, SCM_D_SUPPLYPLAN.VFDAT, SCM_D_SENDDEPART_SEND_DEPART.NAME as SEND_DEPART_NAME from SCM_D_SUPPLYPLAN left join SCM_D_SENDDEPART   SCM_D_SENDDEPART_SEND_DEPART on SCM_D_SUPPLYPLAN.SEND_DEPART = SCM_D_SENDDEPART_SEND_DEPART.CODE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_D_SUPPLYPLAN",paging, order, sSql, parameters, trans);
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
			DisplayObject_SCM_D_SUPPLYPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_SUPPLYPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE2 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FPJR = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATUS = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.LINK_PERSON = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SEND_ORDER_CODE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FPBM = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MEINS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CHARG = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SEND_DEPART = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.WERKST = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.FREEUSE1 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.EEIND = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.LGORT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.TXZ01 = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.FPRQ = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.MENGE = sqlReader.GetDecimal(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.FPHM = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.COMMENTS = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.GYSNAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.MSEHT = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.EBELN = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.WERKS = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.GYJH = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.MATNR = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.MATER_CODE = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.VFDAT = sqlReader.GetDateTime(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(49);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_D_SUPPLYPLAN[] objs = new DisplayObject_SCM_D_SUPPLYPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		#endregion 
	}
}
