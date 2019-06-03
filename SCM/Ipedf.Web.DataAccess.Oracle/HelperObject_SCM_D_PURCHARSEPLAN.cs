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
	[CauseObject(typeof(CauseObject_SCM_D_PURCHARSEPLAN))]
	public partial class HelperObject_SCM_D_PURCHARSEPLAN
	{		
		#region Method Blok
        public static int Save(EntityObject_SCM_D_PURCHARSEPLAN obj, IDbTransaction trans)
        {

            //平台自动生成代码
            obj.ID = Guid.NewGuid().ToString();
            string sSql = "insert into SCM_D_PURCHARSEPLAN( MSEHT, NAME, FREEUSE2, FREEUSE3, BEDAT, FREEUSE1, LIFNR, STATUS, DATA_ORGANISE_ID, SEND_DEAPRT_NAME, CODE, BSART, CREATE_TIME, SEND_DEAPRT_ID, MEINS, WERKST, STATE, EINDT, LGORT, TXZ01, SUREMENGE, CREATE_USER_ID, ID, MENGE, WERKS, EBELP, ALLMENGE, COMMENTS, CREATE_DEPART_ID, NETPR, EBELN, MATNR,SEND_DEAPRT_CONTACT,SEND_DEAPRT_PHONE) values ( :MSEHT, :NAME, :FREEUSE2, :FREEUSE3, :BEDAT, :FREEUSE1, :LIFNR, :STATUS, :DATA_ORGANISE_ID, :SEND_DEAPRT_NAME, :CODE, :BSART, :CREATE_TIME, :SEND_DEAPRT_ID, :MEINS, :WERKST, :STATE, :EINDT, :LGORT, :TXZ01, :SUREMENGE, :CREATE_USER_ID, :ID, :MENGE, :WERKS, :EBELP, :ALLMENGE, :COMMENTS, :CREATE_DEPART_ID, :NETPR, :EBELN, :MATNR,:SEND_DEAPRT_CONTACT,:SEND_DEAPRT_PHONE)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[34];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":MSEHT";
            parameters[0].Size = 50;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[0].Value = obj.MSEHT == null ? String.Empty : obj.MSEHT;
            parameters[1] = new OracleParameter();
            parameters[1].ParameterName = ":NAME";
            parameters[1].Size = 200;
            parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[1].Value = obj.NAME == null ? String.Empty : obj.NAME;
            parameters[2] = new OracleParameter();
            parameters[2].ParameterName = ":FREEUSE2";
            parameters[2].Size = 100;
            parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[2].Value = obj.FREEUSE2 == null ? String.Empty : obj.FREEUSE2;
            parameters[3] = new OracleParameter();
            parameters[3].ParameterName = ":FREEUSE3";
            parameters[3].Size = 200;
            parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[3].Value = obj.FREEUSE3 == null ? String.Empty : obj.FREEUSE3;
            parameters[4] = new OracleParameter();
            parameters[4].ParameterName = ":BEDAT";
            parameters[4].Size = 10;
            parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[4].Value = obj.BEDAT == null ? String.Empty : obj.BEDAT;
            parameters[5] = new OracleParameter();
            parameters[5].ParameterName = ":FREEUSE1";
            parameters[5].Size = 50;
            parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[5].Value = obj.FREEUSE1 == null ? String.Empty : obj.FREEUSE1;
            parameters[6] = new OracleParameter();
            parameters[6].ParameterName = ":LIFNR";
            parameters[6].Size = 50;
            parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[6].Value = obj.LIFNR == null ? String.Empty : obj.LIFNR;
            parameters[7] = new OracleParameter();
            parameters[7].ParameterName = ":STATUS";
            parameters[7].Size = 1;
            parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[7].Value = obj.STATUS == null ? String.Empty : obj.STATUS;
            parameters[8] = new OracleParameter();
            parameters[8].ParameterName = ":DATA_ORGANISE_ID";
            parameters[8].Size = 36;
            parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[8].Value = obj.DATA_ORGANISE_ID == null ? String.Empty : obj.DATA_ORGANISE_ID;
            parameters[9] = new OracleParameter();
            parameters[9].ParameterName = ":SEND_DEAPRT_NAME";
            parameters[9].Size = 50;
            parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[9].Value = obj.SEND_DEAPRT_NAME == null ? String.Empty : obj.SEND_DEAPRT_NAME;
            parameters[10] = new OracleParameter();
            parameters[10].ParameterName = ":CODE";
            parameters[10].Size = 50;
            parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[10].Value = obj.CODE == null ? String.Empty : obj.CODE;
            parameters[11] = new OracleParameter();
            parameters[11].ParameterName = ":BSART";
            parameters[11].Size = 4;
            parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[11].Value = obj.BSART == null ? String.Empty : obj.BSART;
            parameters[12] = new OracleParameter();
            parameters[12].ParameterName = ":CREATE_TIME";
            parameters[12].Size = 7;
            parameters[12].OracleType = System.Data.OracleClient.OracleType.DateTime;
            parameters[12].Value = obj.CREATE_TIME;
            parameters[13] = new OracleParameter();
            parameters[13].ParameterName = ":SEND_DEAPRT_ID";
            parameters[13].Size = 36;
            parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[13].Value = obj.SEND_DEAPRT_ID == null ? String.Empty : obj.SEND_DEAPRT_ID;
            parameters[14] = new OracleParameter();
            parameters[14].ParameterName = ":MEINS";
            parameters[14].Size = 50;
            parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[14].Value = obj.MEINS == null ? String.Empty : obj.MEINS;
            parameters[15] = new OracleParameter();
            parameters[15].ParameterName = ":WERKST";
            parameters[15].Size = 200;
            parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[15].Value = obj.WERKST == null ? String.Empty : obj.WERKST;
            parameters[16] = new OracleParameter();
            parameters[16].ParameterName = ":STATE";
            parameters[16].Size = 22;
            parameters[16].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[16].Value = obj.STATE;
            parameters[17] = new OracleParameter();
            parameters[17].ParameterName = ":EINDT";
            parameters[17].Size = 10;
            parameters[17].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[17].Value = obj.EINDT == null ? String.Empty : obj.EINDT;
            parameters[18] = new OracleParameter();
            parameters[18].ParameterName = ":LGORT";
            parameters[18].Size = 200;
            parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[18].Value = obj.LGORT == null ? String.Empty : obj.LGORT;
            parameters[19] = new OracleParameter();
            parameters[19].ParameterName = ":TXZ01";
            parameters[19].Size = 200;
            parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[19].Value = obj.TXZ01 == null ? String.Empty : obj.TXZ01;
            parameters[20] = new OracleParameter();
            parameters[20].ParameterName = ":SUREMENGE";
            parameters[20].Size = 22;
            parameters[20].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[20].Value = obj.SUREMENGE;
            parameters[21] = new OracleParameter();
            parameters[21].ParameterName = ":CREATE_USER_ID";
            parameters[21].Size = 36;
            parameters[21].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[21].Value = obj.CREATE_USER_ID == null ? String.Empty : obj.CREATE_USER_ID;
            parameters[22] = new OracleParameter();
            parameters[22].ParameterName = ":ID";
            parameters[22].Size = 36;
            parameters[22].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[22].Value = obj.ID == null ? String.Empty : obj.ID;
            parameters[23] = new OracleParameter();
            parameters[23].ParameterName = ":MENGE";
            parameters[23].Size = 22;
            parameters[23].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[23].Value = obj.MENGE;
            parameters[24] = new OracleParameter();
            parameters[24].ParameterName = ":WERKS";
            parameters[24].Size = 40;
            parameters[24].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[24].Value = obj.WERKS == null ? String.Empty : obj.WERKS;
            parameters[25] = new OracleParameter();
            parameters[25].ParameterName = ":EBELP";
            parameters[25].Size = 200;
            parameters[25].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[25].Value = obj.EBELP == null ? String.Empty : obj.EBELP;
            parameters[26] = new OracleParameter();
            parameters[26].ParameterName = ":ALLMENGE";
            parameters[26].Size = 22;
            parameters[26].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[26].Value = obj.ALLMENGE;
            parameters[27] = new OracleParameter();
            parameters[27].ParameterName = ":COMMENTS";
            parameters[27].Size = 1000;
            parameters[27].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[27].Value = obj.COMMENTS == null ? String.Empty : obj.COMMENTS;
            parameters[28] = new OracleParameter();
            parameters[28].ParameterName = ":CREATE_DEPART_ID";
            parameters[28].Size = 36;
            parameters[28].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[28].Value = obj.CREATE_DEPART_ID == null ? String.Empty : obj.CREATE_DEPART_ID;
            parameters[29] = new OracleParameter();
            parameters[29].ParameterName = ":NETPR";
            parameters[29].Size = 20;
            parameters[29].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[29].Value = obj.NETPR == null ? String.Empty : obj.NETPR;
            parameters[30] = new OracleParameter();
            parameters[30].ParameterName = ":EBELN";
            parameters[30].Size = 200;
            parameters[30].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[30].Value = obj.EBELN == null ? String.Empty : obj.EBELN;
            parameters[31] = new OracleParameter();
            parameters[31].ParameterName = ":MATNR";
            parameters[31].Size = 50;
            parameters[31].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[31].Value = obj.MATNR == null ? String.Empty : obj.MATNR;
            parameters[32] = new OracleParameter();
            parameters[32].ParameterName = ":SEND_DEAPRT_CONTACT";
            parameters[32].Size = 255;
            parameters[32].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[32].Value = obj.SEND_DEAPRT_CONTACT == null ? String.Empty : obj.SEND_DEAPRT_CONTACT;
            parameters[33] = new OracleParameter();
            parameters[33].ParameterName = ":SEND_DEAPRT_PHONE";
            parameters[33].Size = 255;
            parameters[33].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[33].Value = obj.SEND_DEAPRT_PHONE == null ? String.Empty : obj.SEND_DEAPRT_PHONE;
            #endregion
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
		public static int Update(EntityObject_SCM_D_PURCHARSEPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_D_PURCHARSEPLAN set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SCM_D_PURCHARSEPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SCM_D_PURCHARSEPLAN where  ID = :ID ";
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
		public static EntityObject_SCM_D_PURCHARSEPLAN Get(EntityObject_SCM_D_PURCHARSEPLAN obj)
		{
			
			//平台自动生成代码
			string sSql = "select  MSEHT, NAME, FREEUSE2, FREEUSE3, BEDAT, FREEUSE1, MODIFY_TIME, LIFNR, STATUS, MODIFY_DEPART_ID, DATA_ORGANISE_ID, SEND_DEAPRT_NAME, CODE, BSART, CREATE_TIME, MODIFY_USER_ID, SEND_DEAPRT_ID, MEINS, WERKST, STATE, EINDT, LGORT, TXZ01, SUREMENGE, CREATE_USER_ID, ID, MENGE, WERKS, EBELP, ALLMENGE, COMMENTS, CREATE_DEPART_ID, NETPR, EBELN, MATNR from SCM_D_PURCHARSEPLAN where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_D_PURCHARSEPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_D_PURCHARSEPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MSEHT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE2 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.LIFNR = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATUS = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_DEAPRT_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BSART = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SEND_DEAPRT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MEINS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.WERKST = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EINDT = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.LGORT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.TXZ01 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.SUREMENGE = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MENGE = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.WERKS = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.EBELP = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ALLMENGE = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.NETPR = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.EBELN = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MATNR = sqlReader.GetString(34);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SCM_D_PURCHARSEPLAN[] objs = new EntityObject_SCM_D_PURCHARSEPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_SCM_D_PURCHARSEPLAN Get(EntityObject_SCM_D_PURCHARSEPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  MSEHT, NAME, FREEUSE2, FREEUSE3, BEDAT, FREEUSE1, MODIFY_TIME, LIFNR, STATUS, MODIFY_DEPART_ID, DATA_ORGANISE_ID, SEND_DEAPRT_NAME, CODE, BSART, CREATE_TIME, MODIFY_USER_ID, SEND_DEAPRT_ID, MEINS, WERKST, STATE, EINDT, LGORT, TXZ01, SUREMENGE, CREATE_USER_ID, ID, MENGE, WERKS, EBELP, ALLMENGE, COMMENTS, CREATE_DEPART_ID, NETPR, EBELN, MATNR from SCM_D_PURCHARSEPLAN where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_D_PURCHARSEPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_D_PURCHARSEPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MSEHT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE2 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.LIFNR = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STATUS = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_DEAPRT_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.BSART = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SEND_DEAPRT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MEINS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.WERKST = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EINDT = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.LGORT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.TXZ01 = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.SUREMENGE = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MENGE = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.WERKS = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.EBELP = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.ALLMENGE = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.NETPR = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.EBELN = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.MATNR = sqlReader.GetString(34);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SCM_D_PURCHARSEPLAN[] objs = new EntityObject_SCM_D_PURCHARSEPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		
		public static string PrepareCause(CauseObject_SCM_D_PURCHARSEPLAN cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.MSEHT))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.MSEHT ").Append((cause.MSEHT.StartsWith("%") || cause.MSEHT.EndsWith("%")) ? " like " : " = ").Append(" :MSEHT");
				param = new OracleParameter();
				param.ParameterName =":MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MSEHT;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSEHT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "MSEHT"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE2))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.FREEUSE2 ").Append((cause.FREEUSE2.StartsWith("%") || cause.FREEUSE2.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE2");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.FREEUSE2;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE2"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "FREEUSE2"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE3))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.FREEUSE3 ").Append((cause.FREEUSE3.StartsWith("%") || cause.FREEUSE3.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE3");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.FREEUSE3;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE3"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "FREEUSE3"));
			}
			if(!string.IsNullOrEmpty(cause.BEDAT))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.BEDAT ").Append((cause.BEDAT.StartsWith("%") || cause.BEDAT.EndsWith("%")) ? " like " : " = ").Append(" :BEDAT");
				param = new OracleParameter();
				param.ParameterName =":BEDAT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.BEDAT;
				paramList.Add(param);
			}
			if (cause.HasINValue("BEDAT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "BEDAT"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE1))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.FREEUSE1 ").Append((cause.FREEUSE1.StartsWith("%") || cause.FREEUSE1.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE1");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FREEUSE1;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE1"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "FREEUSE1"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_D_PURCHARSEPLAN.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And SCM_D_PURCHARSEPLAN.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.LIFNR))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.LIFNR ").Append((cause.LIFNR.StartsWith("%") || cause.LIFNR.EndsWith("%")) ? " like " : " = ").Append(" :LIFNR");
				param = new OracleParameter();
				param.ParameterName =":LIFNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.LIFNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("LIFNR"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "LIFNR"));
			}
			if(!string.IsNullOrEmpty(cause.STATUS))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.STATUS ").Append((cause.STATUS.StartsWith("%") || cause.STATUS.EndsWith("%")) ? " like " : " = ").Append(" :STATUS");
				param = new OracleParameter();
				param.ParameterName =":STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "MODIFY_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_DEAPRT_NAME))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.SEND_DEAPRT_NAME ").Append((cause.SEND_DEAPRT_NAME.StartsWith("%") || cause.SEND_DEAPRT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :SEND_DEAPRT_NAME");
				param = new OracleParameter();
				param.ParameterName =":SEND_DEAPRT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SEND_DEAPRT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_DEAPRT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "SEND_DEAPRT_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.BSART))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.BSART ").Append((cause.BSART.StartsWith("%") || cause.BSART.EndsWith("%")) ? " like " : " = ").Append(" :BSART");
				param = new OracleParameter();
				param.ParameterName =":BSART";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 4;
				param.Value = cause.BSART;
				paramList.Add(param);
			}
			if (cause.HasINValue("BSART"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "BSART"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_D_PURCHARSEPLAN.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And SCM_D_PURCHARSEPLAN.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_DEAPRT_ID))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.SEND_DEAPRT_ID ").Append((cause.SEND_DEAPRT_ID.StartsWith("%") || cause.SEND_DEAPRT_ID.EndsWith("%")) ? " like " : " = ").Append(" :SEND_DEAPRT_ID");
				param = new OracleParameter();
				param.ParameterName =":SEND_DEAPRT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SEND_DEAPRT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_DEAPRT_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "SEND_DEAPRT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MEINS))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.MEINS ").Append((cause.MEINS.StartsWith("%") || cause.MEINS.EndsWith("%")) ? " like " : " = ").Append(" :MEINS");
				param = new OracleParameter();
				param.ParameterName =":MEINS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MEINS;
				paramList.Add(param);
			}
			if (cause.HasINValue("MEINS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "MEINS"));
			}
			if(!string.IsNullOrEmpty(cause.WERKST))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.WERKST ").Append((cause.WERKST.StartsWith("%") || cause.WERKST.EndsWith("%")) ? " like " : " = ").Append(" :WERKST");
				param = new OracleParameter();
				param.ParameterName =":WERKST";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.WERKST;
				paramList.Add(param);
			}
			if (cause.HasINValue("WERKST"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "WERKST"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.EINDT))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.EINDT ").Append((cause.EINDT.StartsWith("%") || cause.EINDT.EndsWith("%")) ? " like " : " = ").Append(" :EINDT");
				param = new OracleParameter();
				param.ParameterName =":EINDT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.EINDT;
				paramList.Add(param);
			}
			if (cause.HasINValue("EINDT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "EINDT"));
			}
			if(!string.IsNullOrEmpty(cause.LGORT))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.LGORT ").Append((cause.LGORT.StartsWith("%") || cause.LGORT.EndsWith("%")) ? " like " : " = ").Append(" :LGORT");
				param = new OracleParameter();
				param.ParameterName =":LGORT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.LGORT;
				paramList.Add(param);
			}
			if (cause.HasINValue("LGORT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "LGORT"));
			}
			if(!string.IsNullOrEmpty(cause.TXZ01))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :TXZ01");
				param = new OracleParameter();
				param.ParameterName =":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.TXZ01;
				paramList.Add(param);
			}
			if (cause.HasINValue("TXZ01"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "TXZ01"));
			}
			if(cause.SUREMENGE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.SUREMENGE = :SUREMENGE");
				param = new OracleParameter();
				param.ParameterName =":SUREMENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.SUREMENGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SUREMENGE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "SUREMENGE"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "ID"));
			}
			if(cause.MENGE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.MENGE = :MENGE");
				param = new OracleParameter();
				param.ParameterName =":MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MENGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MENGE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "MENGE"));
			}
			if(!string.IsNullOrEmpty(cause.WERKS))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.WERKS ").Append((cause.WERKS.StartsWith("%") || cause.WERKS.EndsWith("%")) ? " like " : " = ").Append(" :WERKS");
				param = new OracleParameter();
				param.ParameterName =":WERKS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 40;
				param.Value = cause.WERKS;
				paramList.Add(param);
			}
			if (cause.HasINValue("WERKS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "WERKS"));
			}
			if(!string.IsNullOrEmpty(cause.EBELP))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.EBELP ").Append((cause.EBELP.StartsWith("%") || cause.EBELP.EndsWith("%")) ? " like " : " = ").Append(" :EBELP");
				param = new OracleParameter();
				param.ParameterName =":EBELP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.EBELP;
				paramList.Add(param);
			}
			if (cause.HasINValue("EBELP"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "EBELP"));
			}
			if(cause.ALLMENGE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.ALLMENGE = :ALLMENGE");
				param = new OracleParameter();
				param.ParameterName =":ALLMENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ALLMENGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ALLMENGE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "ALLMENGE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "CREATE_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NETPR))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.NETPR ").Append((cause.NETPR.StartsWith("%") || cause.NETPR.EndsWith("%")) ? " like " : " = ").Append(" :NETPR");
				param = new OracleParameter();
				param.ParameterName =":NETPR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.NETPR;
				paramList.Add(param);
			}
			if (cause.HasINValue("NETPR"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "NETPR"));
			}
			if(!string.IsNullOrEmpty(cause.EBELN))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.EBELN ").Append((cause.EBELN.StartsWith("%") || cause.EBELN.EndsWith("%")) ? " like " : " = ").Append(" :EBELN");
				param = new OracleParameter();
				param.ParameterName =":EBELN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.EBELN;
				paramList.Add(param);
			}
			if (cause.HasINValue("EBELN"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "EBELN"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR))
			{
				strBuf.Append(" And SCM_D_PURCHARSEPLAN.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :MATNR");
				param = new OracleParameter();
				param.ParameterName =":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MATNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_PURCHARSEPLAN", "MATNR"));
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
		
		public static int Delete(CauseObject_SCM_D_PURCHARSEPLAN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SCM_D_PURCHARSEPLAN where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
	
		public static string PrepareUpdate(EntityObject_SCM_D_PURCHARSEPLAN obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("MSEHT"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.MSEHT = :MSEHT");
				param = new OracleParameter();
				param.ParameterName = ":MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MSEHT) ? string.Empty : obj.MSEHT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE2"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.FREEUSE2 = :FREEUSE2");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE2) ? string.Empty : obj.FREEUSE2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE3"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.FREEUSE3 = :FREEUSE3");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE3) ? string.Empty : obj.FREEUSE3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BEDAT"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.BEDAT = :BEDAT");
				param = new OracleParameter();
				param.ParameterName = ":BEDAT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.BEDAT) ? string.Empty : obj.BEDAT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE1"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.FREEUSE1 = :FREEUSE1");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE1) ? string.Empty : obj.FREEUSE1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LIFNR"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.LIFNR = :LIFNR");
				param = new OracleParameter();
				param.ParameterName = ":LIFNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.LIFNR) ? string.Empty : obj.LIFNR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATUS"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.STATUS = :STATUS");
				param = new OracleParameter();
				param.ParameterName = ":STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.STATUS) ? string.Empty : obj.STATUS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.MODIFY_DEPART_ID = :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEND_DEAPRT_NAME"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.SEND_DEAPRT_NAME = :SEND_DEAPRT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":SEND_DEAPRT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SEND_DEAPRT_NAME) ? string.Empty : obj.SEND_DEAPRT_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BSART"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.BSART = :BSART");
				param = new OracleParameter();
				param.ParameterName = ":BSART";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 4;
				param.Value = string.IsNullOrEmpty(obj.BSART) ? string.Empty : obj.BSART;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEND_DEAPRT_ID"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.SEND_DEAPRT_ID = :SEND_DEAPRT_ID");
				param = new OracleParameter();
				param.ParameterName = ":SEND_DEAPRT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.SEND_DEAPRT_ID) ? string.Empty : obj.SEND_DEAPRT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MEINS"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.MEINS = :MEINS");
				param = new OracleParameter();
				param.ParameterName = ":MEINS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MEINS) ? string.Empty : obj.MEINS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WERKST"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.WERKST = :WERKST");
				param = new OracleParameter();
				param.ParameterName = ":WERKST";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.WERKST) ? string.Empty : obj.WERKST;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EINDT"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.EINDT = :EINDT");
				param = new OracleParameter();
				param.ParameterName = ":EINDT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.EINDT) ? string.Empty : obj.EINDT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LGORT"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.LGORT = :LGORT");
				param = new OracleParameter();
				param.ParameterName = ":LGORT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.LGORT) ? string.Empty : obj.LGORT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TXZ01"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.TXZ01 = :TXZ01");
				param = new OracleParameter();
				param.ParameterName = ":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.TXZ01) ? string.Empty : obj.TXZ01;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SUREMENGE"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.SUREMENGE = :SUREMENGE");
				param = new OracleParameter();
				param.ParameterName = ":SUREMENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.SUREMENGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MENGE"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.MENGE = :MENGE");
				param = new OracleParameter();
				param.ParameterName = ":MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MENGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WERKS"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.WERKS = :WERKS");
				param = new OracleParameter();
				param.ParameterName = ":WERKS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 40;
				param.Value = string.IsNullOrEmpty(obj.WERKS) ? string.Empty : obj.WERKS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EBELP"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.EBELP = :EBELP");
				param = new OracleParameter();
				param.ParameterName = ":EBELP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.EBELP) ? string.Empty : obj.EBELP;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ALLMENGE"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.ALLMENGE = :ALLMENGE");
				param = new OracleParameter();
				param.ParameterName = ":ALLMENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ALLMENGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NETPR"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.NETPR = :NETPR");
				param = new OracleParameter();
				param.ParameterName = ":NETPR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.NETPR) ? string.Empty : obj.NETPR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EBELN"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.EBELN = :EBELN");
				param = new OracleParameter();
				param.ParameterName = ":EBELN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.EBELN) ? string.Empty : obj.EBELN;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATNR"))
			{
				strBuf.Add("  SCM_D_PURCHARSEPLAN.MATNR = :MATNR");
				param = new OracleParameter();
				param.ParameterName = ":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MATNR) ? string.Empty : obj.MATNR;
				paramList.Add(param);
			}
            if (!obj.IsNotUpdate("SEND_DEAPRT_CONTACT"))
            {
                strBuf.Add("  SCM_D_PURCHARSEPLAN.SEND_DEAPRT_CONTACT = :SEND_DEAPRT_CONTACT");
                param = new OracleParameter();
                param.ParameterName = ":SEND_DEAPRT_CONTACT";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 250;
                param.Value = string.IsNullOrEmpty(obj.SEND_DEAPRT_CONTACT) ? string.Empty : obj.SEND_DEAPRT_CONTACT;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("SEND_DEAPRT_PHONE"))
            {
                strBuf.Add("  SCM_D_PURCHARSEPLAN.SEND_DEAPRT_PHONE = :SEND_DEAPRT_PHONE");
                param = new OracleParameter();
                param.ParameterName = ":SEND_DEAPRT_PHONE";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 250;
                param.Value = string.IsNullOrEmpty(obj.SEND_DEAPRT_PHONE) ? string.Empty : obj.SEND_DEAPRT_PHONE;
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
