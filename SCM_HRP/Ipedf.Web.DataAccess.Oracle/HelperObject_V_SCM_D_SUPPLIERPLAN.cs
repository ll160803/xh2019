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
	[CauseObject(typeof(CauseObject_V_SCM_D_SUPPLIERPLAN))]
	public partial class HelperObject_V_SCM_D_SUPPLIERPLAN
	{		
		#region Method Blok
		public static int Save(EntityObject_V_SCM_D_SUPPLIERPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_SCM_D_SUPPLIERPLAN( FPHM, WERKS, FPBM, TXZ01, FPJR, LGORT, ID, HSDAT, PKG_NUMBER, EBELN, MEINS, ORDER_MENGE, STATUS, FPRQ, NETPR, FREEUSE3, FACTORY, CODE, GYJH, WERKST, FREEUSE1, MENGE, CHARG, MSEHT, MATNR, GYSACCOUNT, UNINFORMED_STATE, CREATE_TIME, NAME, GYSNAME, PKG_AMOUNT, SPEC, FREEUSE2, COMMENTS, BEDAT, VFDAT, INFORMED_STATE, EEIND) values ( :FPHM, :WERKS, :FPBM, :TXZ01, :FPJR, :LGORT, :ID, :HSDAT, :PKG_NUMBER, :EBELN, :MEINS, :ORDER_MENGE, :STATUS, :FPRQ, :NETPR, :FREEUSE3, :FACTORY, :CODE, :GYJH, :WERKST, :FREEUSE1, :MENGE, :CHARG, :MSEHT, :MATNR, :GYSACCOUNT, :UNINFORMED_STATE, :CREATE_TIME, :NAME, :GYSNAME, :PKG_AMOUNT, :SPEC, :FREEUSE2, :COMMENTS, :BEDAT, :VFDAT, :INFORMED_STATE, :EEIND)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[38];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":FPHM";
			parameters[0].Size = 20;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.FPHM == null ? String.Empty:obj.FPHM;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":WERKS";
			parameters[1].Size = 40;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.WERKS == null ? String.Empty:obj.WERKS;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":FPBM";
			parameters[2].Size = 200;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.FPBM == null ? String.Empty:obj.FPBM;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":TXZ01";
			parameters[3].Size = 200;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.TXZ01 == null ? String.Empty:obj.TXZ01;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":FPJR";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.FPJR;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":LGORT";
			parameters[5].Size = 200;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.LGORT == null ? String.Empty:obj.LGORT;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":HSDAT";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.HSDAT;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":PKG_NUMBER";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.PKG_NUMBER;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":EBELN";
			parameters[9].Size = 200;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.EBELN == null ? String.Empty:obj.EBELN;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":MEINS";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.MEINS == null ? String.Empty:obj.MEINS;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":ORDER_MENGE";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.ORDER_MENGE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":STATUS";
			parameters[12].Size = 1;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.STATUS == null ? String.Empty:obj.STATUS;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":FPRQ";
			parameters[13].Size = 7;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[13].Value = obj.FPRQ;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":NETPR";
			parameters[14].Size = 20;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.NETPR == null ? String.Empty:obj.NETPR;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":FREEUSE3";
			parameters[15].Size = 100;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[15].Value = obj.FREEUSE3 == null ? String.Empty:obj.FREEUSE3;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":FACTORY";
			parameters[16].Size = 100;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[16].Value = obj.FACTORY == null ? String.Empty:obj.FACTORY;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":CODE";
			parameters[17].Size = 50;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[17].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":GYJH";
			parameters[18].Size = 200;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.GYJH == null ? String.Empty:obj.GYJH;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":WERKST";
			parameters[19].Size = 200;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.WERKST == null ? String.Empty:obj.WERKST;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":FREEUSE1";
			parameters[20].Size = 10;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[20].Value = obj.FREEUSE1 == null ? String.Empty:obj.FREEUSE1;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":MENGE";
			parameters[21].Size = 22;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[21].Value = obj.MENGE;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":CHARG";
			parameters[22].Size = 50;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[22].Value = obj.CHARG == null ? String.Empty:obj.CHARG;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":MSEHT";
			parameters[23].Size = 50;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[23].Value = obj.MSEHT == null ? String.Empty:obj.MSEHT;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":MATNR";
			parameters[24].Size = 50;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[24].Value = obj.MATNR == null ? String.Empty:obj.MATNR;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":GYSACCOUNT";
			parameters[25].Size = 50;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[25].Value = obj.GYSACCOUNT == null ? String.Empty:obj.GYSACCOUNT;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":UNINFORMED_STATE";
			parameters[26].Size = 1;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[26].Value = obj.UNINFORMED_STATE == null ? String.Empty:obj.UNINFORMED_STATE;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":CREATE_TIME";
			parameters[27].Size = 7;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[27].Value = obj.CREATE_TIME;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":NAME";
			parameters[28].Size = 200;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[28].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":GYSNAME";
			parameters[29].Size = 50;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[29].Value = obj.GYSNAME == null ? String.Empty:obj.GYSNAME;
			parameters[30] = new OracleParameter();
			parameters[30].ParameterName =":PKG_AMOUNT";
			parameters[30].Size = 22;
			parameters[30].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[30].Value = obj.PKG_AMOUNT;
			parameters[31] = new OracleParameter();
			parameters[31].ParameterName =":SPEC";
			parameters[31].Size = 200;
			parameters[31].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[31].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[32] = new OracleParameter();
			parameters[32].ParameterName =":FREEUSE2";
			parameters[32].Size = 50;
			parameters[32].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[32].Value = obj.FREEUSE2 == null ? String.Empty:obj.FREEUSE2;
			parameters[33] = new OracleParameter();
			parameters[33].ParameterName =":COMMENTS";
			parameters[33].Size = 1000;
			parameters[33].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[33].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[34] = new OracleParameter();
			parameters[34].ParameterName =":BEDAT";
			parameters[34].Size = 10;
			parameters[34].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[34].Value = obj.BEDAT == null ? String.Empty:obj.BEDAT;
			parameters[35] = new OracleParameter();
			parameters[35].ParameterName =":VFDAT";
			parameters[35].Size = 7;
			parameters[35].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[35].Value = obj.VFDAT;
			parameters[36] = new OracleParameter();
			parameters[36].ParameterName =":INFORMED_STATE";
			parameters[36].Size = 1;
			parameters[36].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[36].Value = obj.INFORMED_STATE == null ? String.Empty:obj.INFORMED_STATE;
			parameters[37] = new OracleParameter();
			parameters[37].ParameterName =":EEIND";
			parameters[37].Size = 10;
			parameters[37].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[37].Value = obj.EEIND == null ? String.Empty:obj.EEIND;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_SCM_D_SUPPLIERPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_SCM_D_SUPPLIERPLAN set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_SCM_D_SUPPLIERPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_SCM_D_SUPPLIERPLAN where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_SCM_D_SUPPLIERPLAN Get(EntityObject_V_SCM_D_SUPPLIERPLAN obj)
		{
			
			//平台自动生成代码
			string sSql = "select  FPHM, WERKS, FPBM, TXZ01, FPJR, LGORT, ID, HSDAT, PKG_NUMBER, EBELN, MEINS, ORDER_MENGE, STATUS, FPRQ, NETPR, FREEUSE3, FACTORY, CODE, GYJH, WERKST, FREEUSE1, MENGE, CHARG, MSEHT, MATNR, GYSACCOUNT, UNINFORMED_STATE, CREATE_TIME, NAME, GYSNAME, PKG_AMOUNT, SPEC, FREEUSE2, COMMENTS, BEDAT, VFDAT, INFORMED_STATE, EEIND from V_SCM_D_SUPPLIERPLAN where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_D_SUPPLIERPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_D_SUPPLIERPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FPHM = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.WERKS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPBM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TXZ01 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FPJR = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LGORT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EBELN = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MEINS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATUS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPRQ = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NETPR = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREEUSE3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FACTORY = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYJH = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.WERKST = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FREEUSE1 = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MENGE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CHARG = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MSEHT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.GYSNAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.SPEC = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.FREEUSE2 = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.COMMENTS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.BEDAT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.VFDAT = sqlReader.GetDateTime(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EEIND = sqlReader.GetString(37);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_SCM_D_SUPPLIERPLAN[] objs = new EntityObject_V_SCM_D_SUPPLIERPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_SCM_D_SUPPLIERPLAN Get(EntityObject_V_SCM_D_SUPPLIERPLAN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  FPHM, WERKS, FPBM, TXZ01, FPJR, LGORT, ID, HSDAT, PKG_NUMBER, EBELN, MEINS, ORDER_MENGE, STATUS, FPRQ, NETPR, FREEUSE3, FACTORY, CODE, GYJH, WERKST, FREEUSE1, MENGE, CHARG, MSEHT, MATNR, GYSACCOUNT, UNINFORMED_STATE, CREATE_TIME, NAME, GYSNAME, PKG_AMOUNT, SPEC, FREEUSE2, COMMENTS, BEDAT, VFDAT, INFORMED_STATE, EEIND from V_SCM_D_SUPPLIERPLAN where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_D_SUPPLIERPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_D_SUPPLIERPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FPHM = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.WERKS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPBM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TXZ01 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FPJR = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LGORT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EBELN = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MEINS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATUS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPRQ = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NETPR = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREEUSE3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FACTORY = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYJH = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.WERKST = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FREEUSE1 = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MENGE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CHARG = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MSEHT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.GYSNAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.SPEC = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.FREEUSE2 = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.COMMENTS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.BEDAT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.VFDAT = sqlReader.GetDateTime(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EEIND = sqlReader.GetString(37);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_SCM_D_SUPPLIERPLAN[] objs = new EntityObject_V_SCM_D_SUPPLIERPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_SCM_D_SUPPLIERPLAN[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_SCM_D_SUPPLIERPLAN.FPHM, V_SCM_D_SUPPLIERPLAN.WERKS, V_SCM_D_SUPPLIERPLAN.FPBM, V_SCM_D_SUPPLIERPLAN.TXZ01, V_SCM_D_SUPPLIERPLAN.FPJR, V_SCM_D_SUPPLIERPLAN.LGORT, V_SCM_D_SUPPLIERPLAN.ID, V_SCM_D_SUPPLIERPLAN.HSDAT, V_SCM_D_SUPPLIERPLAN.PKG_NUMBER, V_SCM_D_SUPPLIERPLAN.EBELN, V_SCM_D_SUPPLIERPLAN.MEINS, V_SCM_D_SUPPLIERPLAN.ORDER_MENGE, V_SCM_D_SUPPLIERPLAN.STATUS, V_SCM_D_SUPPLIERPLAN.FPRQ, V_SCM_D_SUPPLIERPLAN.NETPR, V_SCM_D_SUPPLIERPLAN.FREEUSE3, V_SCM_D_SUPPLIERPLAN.FACTORY, V_SCM_D_SUPPLIERPLAN.CODE, V_SCM_D_SUPPLIERPLAN.GYJH, V_SCM_D_SUPPLIERPLAN.WERKST, V_SCM_D_SUPPLIERPLAN.FREEUSE1, V_SCM_D_SUPPLIERPLAN.MENGE, V_SCM_D_SUPPLIERPLAN.CHARG, V_SCM_D_SUPPLIERPLAN.MSEHT, V_SCM_D_SUPPLIERPLAN.MATNR, V_SCM_D_SUPPLIERPLAN.GYSACCOUNT, V_SCM_D_SUPPLIERPLAN.UNINFORMED_STATE, V_SCM_D_SUPPLIERPLAN.CREATE_TIME, V_SCM_D_SUPPLIERPLAN.NAME, V_SCM_D_SUPPLIERPLAN.GYSNAME, V_SCM_D_SUPPLIERPLAN.PKG_AMOUNT, V_SCM_D_SUPPLIERPLAN.SPEC, V_SCM_D_SUPPLIERPLAN.FREEUSE2, V_SCM_D_SUPPLIERPLAN.COMMENTS, V_SCM_D_SUPPLIERPLAN.BEDAT, V_SCM_D_SUPPLIERPLAN.VFDAT, V_SCM_D_SUPPLIERPLAN.INFORMED_STATE, V_SCM_D_SUPPLIERPLAN.EEIND from V_SCM_D_SUPPLIERPLAN where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_SCM_D_SUPPLIERPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SUPPLIERPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FPHM = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.WERKS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPBM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TXZ01 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FPJR = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LGORT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EBELN = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MEINS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATUS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPRQ = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NETPR = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREEUSE3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FACTORY = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYJH = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.WERKST = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FREEUSE1 = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MENGE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CHARG = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MSEHT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.GYSNAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.SPEC = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.FREEUSE2 = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.COMMENTS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.BEDAT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.VFDAT = sqlReader.GetDateTime(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EEIND = sqlReader.GetString(37);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_SUPPLIERPLAN[] objs = new DisplayObject_V_SCM_D_SUPPLIERPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_SCM_D_SUPPLIERPLAN cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.FPHM))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.FPHM ").Append((cause.FPHM.StartsWith("%") || cause.FPHM.EndsWith("%")) ? " like " : " = ").Append(" :FPHM");
				param = new OracleParameter();
				param.ParameterName =":FPHM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.FPHM;
				paramList.Add(param);
			}
			if (cause.HasINValue("FPHM"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "FPHM"));
			}
			if(!string.IsNullOrEmpty(cause.WERKS))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.WERKS ").Append((cause.WERKS.StartsWith("%") || cause.WERKS.EndsWith("%")) ? " like " : " = ").Append(" :WERKS");
				param = new OracleParameter();
				param.ParameterName =":WERKS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 40;
				param.Value = cause.WERKS;
				paramList.Add(param);
			}
			if (cause.HasINValue("WERKS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "WERKS"));
			}
			if(!string.IsNullOrEmpty(cause.FPBM))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.FPBM ").Append((cause.FPBM.StartsWith("%") || cause.FPBM.EndsWith("%")) ? " like " : " = ").Append(" :FPBM");
				param = new OracleParameter();
				param.ParameterName =":FPBM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.FPBM;
				paramList.Add(param);
			}
			if (cause.HasINValue("FPBM"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "FPBM"));
			}
			if(!string.IsNullOrEmpty(cause.TXZ01))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :TXZ01");
				param = new OracleParameter();
				param.ParameterName =":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.TXZ01;
				paramList.Add(param);
			}
			if (cause.HasINValue("TXZ01"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "TXZ01"));
			}
			if(cause.FPJR!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.FPJR = :FPJR");
				param = new OracleParameter();
				param.ParameterName =":FPJR";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.FPJR;
				paramList.Add(param);
			}
			if (cause.HasINValue("FPJR"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "FPJR"));
			}
			if(!string.IsNullOrEmpty(cause.LGORT))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.LGORT ").Append((cause.LGORT.StartsWith("%") || cause.LGORT.EndsWith("%")) ? " like " : " = ").Append(" :LGORT");
				param = new OracleParameter();
				param.ParameterName =":LGORT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.LGORT;
				paramList.Add(param);
			}
			if (cause.HasINValue("LGORT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "LGORT"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "ID"));
			}
			if(cause.HSDAT!= null)
			{
				if (cause.HSDAT.Begin != null)
				{
					strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.HSDAT >= :HSDAT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":HSDAT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.HSDAT.Begin;
					paramList.Add(param);
				}
				if (cause.HSDAT.End != null)
				{
					strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.HSDAT < :HSDAT_END");
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
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "HSDAT"));
			}
			if(cause.PKG_NUMBER!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.PKG_NUMBER = :PKG_NUMBER");
				param = new OracleParameter();
				param.ParameterName =":PKG_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PKG_NUMBER;
				paramList.Add(param);
			}
			if (cause.HasINValue("PKG_NUMBER"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "PKG_NUMBER"));
			}
			if(!string.IsNullOrEmpty(cause.EBELN))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.EBELN ").Append((cause.EBELN.StartsWith("%") || cause.EBELN.EndsWith("%")) ? " like " : " = ").Append(" :EBELN");
				param = new OracleParameter();
				param.ParameterName =":EBELN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.EBELN;
				paramList.Add(param);
			}
			if (cause.HasINValue("EBELN"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "EBELN"));
			}
			if(!string.IsNullOrEmpty(cause.MEINS))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.MEINS ").Append((cause.MEINS.StartsWith("%") || cause.MEINS.EndsWith("%")) ? " like " : " = ").Append(" :MEINS");
				param = new OracleParameter();
				param.ParameterName =":MEINS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MEINS;
				paramList.Add(param);
			}
			if (cause.HasINValue("MEINS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "MEINS"));
			}
			if(cause.ORDER_MENGE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.ORDER_MENGE = :ORDER_MENGE");
				param = new OracleParameter();
				param.ParameterName =":ORDER_MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ORDER_MENGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ORDER_MENGE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "ORDER_MENGE"));
			}
			if(!string.IsNullOrEmpty(cause.STATUS))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.STATUS ").Append((cause.STATUS.StartsWith("%") || cause.STATUS.EndsWith("%")) ? " like " : " = ").Append(" :STATUS");
				param = new OracleParameter();
				param.ParameterName =":STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "STATUS"));
			}
			if(cause.FPRQ!= null)
			{
				if (cause.FPRQ.Begin != null)
				{
					strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.FPRQ >= :FPRQ_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":FPRQ_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.FPRQ.Begin;
					paramList.Add(param);
				}
				if (cause.FPRQ.End != null)
				{
					strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.FPRQ < :FPRQ_END");
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
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "FPRQ"));
			}
			if(!string.IsNullOrEmpty(cause.NETPR))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.NETPR ").Append((cause.NETPR.StartsWith("%") || cause.NETPR.EndsWith("%")) ? " like " : " = ").Append(" :NETPR");
				param = new OracleParameter();
				param.ParameterName =":NETPR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.NETPR;
				paramList.Add(param);
			}
			if (cause.HasINValue("NETPR"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "NETPR"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE3))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.FREEUSE3 ").Append((cause.FREEUSE3.StartsWith("%") || cause.FREEUSE3.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE3");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 100;
				param.Value = cause.FREEUSE3;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE3"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "FREEUSE3"));
			}
			if(!string.IsNullOrEmpty(cause.FACTORY))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.FACTORY ").Append((cause.FACTORY.StartsWith("%") || cause.FACTORY.EndsWith("%")) ? " like " : " = ").Append(" :FACTORY");
				param = new OracleParameter();
				param.ParameterName =":FACTORY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.FACTORY;
				paramList.Add(param);
			}
			if (cause.HasINValue("FACTORY"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "FACTORY"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.GYJH))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.GYJH ").Append((cause.GYJH.StartsWith("%") || cause.GYJH.EndsWith("%")) ? " like " : " = ").Append(" :GYJH");
				param = new OracleParameter();
				param.ParameterName =":GYJH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.GYJH;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYJH"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "GYJH"));
			}
			if(!string.IsNullOrEmpty(cause.WERKST))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.WERKST ").Append((cause.WERKST.StartsWith("%") || cause.WERKST.EndsWith("%")) ? " like " : " = ").Append(" :WERKST");
				param = new OracleParameter();
				param.ParameterName =":WERKST";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.WERKST;
				paramList.Add(param);
			}
			if (cause.HasINValue("WERKST"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "WERKST"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE1))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.FREEUSE1 ").Append((cause.FREEUSE1.StartsWith("%") || cause.FREEUSE1.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE1");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.FREEUSE1;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE1"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "FREEUSE1"));
			}
			if(cause.MENGE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.MENGE = :MENGE");
				param = new OracleParameter();
				param.ParameterName =":MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MENGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MENGE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "MENGE"));
			}
			if(!string.IsNullOrEmpty(cause.CHARG))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.CHARG ").Append((cause.CHARG.StartsWith("%") || cause.CHARG.EndsWith("%")) ? " like " : " = ").Append(" :CHARG");
				param = new OracleParameter();
				param.ParameterName =":CHARG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CHARG;
				paramList.Add(param);
			}
			if (cause.HasINValue("CHARG"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "CHARG"));
			}
			if(!string.IsNullOrEmpty(cause.MSEHT))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.MSEHT ").Append((cause.MSEHT.StartsWith("%") || cause.MSEHT.EndsWith("%")) ? " like " : " = ").Append(" :MSEHT");
				param = new OracleParameter();
				param.ParameterName =":MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MSEHT;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSEHT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "MSEHT"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :MATNR");
				param = new OracleParameter();
				param.ParameterName =":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MATNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "MATNR"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.UNINFORMED_STATE))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.UNINFORMED_STATE ").Append((cause.UNINFORMED_STATE.StartsWith("%") || cause.UNINFORMED_STATE.EndsWith("%")) ? " like " : " = ").Append(" :UNINFORMED_STATE");
				param = new OracleParameter();
				param.ParameterName =":UNINFORMED_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = cause.UNINFORMED_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNINFORMED_STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "UNINFORMED_STATE"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.GYSNAME))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :GYSNAME");
				param = new OracleParameter();
				param.ParameterName =":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "GYSNAME"));
			}
			if(cause.PKG_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.PKG_AMOUNT = :PKG_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":PKG_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PKG_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("PKG_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "PKG_AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :SPEC");
				param = new OracleParameter();
				param.ParameterName =":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE2))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.FREEUSE2 ").Append((cause.FREEUSE2.StartsWith("%") || cause.FREEUSE2.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE2");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 50;
				param.Value = cause.FREEUSE2;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE2"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "FREEUSE2"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.BEDAT))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.BEDAT ").Append((cause.BEDAT.StartsWith("%") || cause.BEDAT.EndsWith("%")) ? " like " : " = ").Append(" :BEDAT");
				param = new OracleParameter();
				param.ParameterName =":BEDAT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.BEDAT;
				paramList.Add(param);
			}
			if (cause.HasINValue("BEDAT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "BEDAT"));
			}
			if(cause.VFDAT!= null)
			{
				if (cause.VFDAT.Begin != null)
				{
					strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.VFDAT >= :VFDAT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":VFDAT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.VFDAT.Begin;
					paramList.Add(param);
				}
				if (cause.VFDAT.End != null)
				{
					strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.VFDAT < :VFDAT_END");
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
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "VFDAT"));
			}
			if(!string.IsNullOrEmpty(cause.INFORMED_STATE))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.INFORMED_STATE ").Append((cause.INFORMED_STATE.StartsWith("%") || cause.INFORMED_STATE.EndsWith("%")) ? " like " : " = ").Append(" :INFORMED_STATE");
				param = new OracleParameter();
				param.ParameterName =":INFORMED_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = cause.INFORMED_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("INFORMED_STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "INFORMED_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.EEIND))
			{
				strBuf.Append(" And V_SCM_D_SUPPLIERPLAN.EEIND ").Append((cause.EEIND.StartsWith("%") || cause.EEIND.EndsWith("%")) ? " like " : " = ").Append(" :EEIND");
				param = new OracleParameter();
				param.ParameterName =":EEIND";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.EEIND;
				paramList.Add(param);
			}
			if (cause.HasINValue("EEIND"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SUPPLIERPLAN", "EEIND"));
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
		public static DisplayObject_V_SCM_D_SUPPLIERPLAN[] Query(CauseObject_V_SCM_D_SUPPLIERPLAN cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_D_SUPPLIERPLAN.FPHM, V_SCM_D_SUPPLIERPLAN.WERKS, V_SCM_D_SUPPLIERPLAN.FPBM, V_SCM_D_SUPPLIERPLAN.TXZ01, V_SCM_D_SUPPLIERPLAN.FPJR, V_SCM_D_SUPPLIERPLAN.LGORT, V_SCM_D_SUPPLIERPLAN.ID, V_SCM_D_SUPPLIERPLAN.HSDAT, V_SCM_D_SUPPLIERPLAN.PKG_NUMBER, V_SCM_D_SUPPLIERPLAN.EBELN, V_SCM_D_SUPPLIERPLAN.MEINS, V_SCM_D_SUPPLIERPLAN.ORDER_MENGE, V_SCM_D_SUPPLIERPLAN.STATUS, V_SCM_D_SUPPLIERPLAN.FPRQ, V_SCM_D_SUPPLIERPLAN.NETPR, V_SCM_D_SUPPLIERPLAN.FREEUSE3, V_SCM_D_SUPPLIERPLAN.FACTORY, V_SCM_D_SUPPLIERPLAN.CODE, V_SCM_D_SUPPLIERPLAN.GYJH, V_SCM_D_SUPPLIERPLAN.WERKST, V_SCM_D_SUPPLIERPLAN.FREEUSE1, V_SCM_D_SUPPLIERPLAN.MENGE, V_SCM_D_SUPPLIERPLAN.CHARG, V_SCM_D_SUPPLIERPLAN.MSEHT, V_SCM_D_SUPPLIERPLAN.MATNR, V_SCM_D_SUPPLIERPLAN.GYSACCOUNT, V_SCM_D_SUPPLIERPLAN.UNINFORMED_STATE, V_SCM_D_SUPPLIERPLAN.CREATE_TIME, V_SCM_D_SUPPLIERPLAN.NAME, V_SCM_D_SUPPLIERPLAN.GYSNAME, V_SCM_D_SUPPLIERPLAN.PKG_AMOUNT, V_SCM_D_SUPPLIERPLAN.SPEC, V_SCM_D_SUPPLIERPLAN.FREEUSE2, V_SCM_D_SUPPLIERPLAN.COMMENTS, V_SCM_D_SUPPLIERPLAN.BEDAT, V_SCM_D_SUPPLIERPLAN.VFDAT, V_SCM_D_SUPPLIERPLAN.INFORMED_STATE, V_SCM_D_SUPPLIERPLAN.EEIND from V_SCM_D_SUPPLIERPLAN where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_D_SUPPLIERPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SUPPLIERPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FPHM = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.WERKS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPBM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TXZ01 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FPJR = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LGORT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EBELN = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MEINS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATUS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPRQ = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NETPR = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREEUSE3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FACTORY = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYJH = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.WERKST = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FREEUSE1 = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MENGE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CHARG = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MSEHT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.GYSNAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.SPEC = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.FREEUSE2 = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.COMMENTS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.BEDAT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.VFDAT = sqlReader.GetDateTime(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EEIND = sqlReader.GetString(37);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_SUPPLIERPLAN[] objs = new DisplayObject_V_SCM_D_SUPPLIERPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_SCM_D_SUPPLIERPLAN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_SCM_D_SUPPLIERPLAN where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_SCM_D_SUPPLIERPLAN[] Query(CauseObject_V_SCM_D_SUPPLIERPLAN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_D_SUPPLIERPLAN.FPHM, V_SCM_D_SUPPLIERPLAN.WERKS, V_SCM_D_SUPPLIERPLAN.FPBM, V_SCM_D_SUPPLIERPLAN.TXZ01, V_SCM_D_SUPPLIERPLAN.FPJR, V_SCM_D_SUPPLIERPLAN.LGORT, V_SCM_D_SUPPLIERPLAN.ID, V_SCM_D_SUPPLIERPLAN.HSDAT, V_SCM_D_SUPPLIERPLAN.PKG_NUMBER, V_SCM_D_SUPPLIERPLAN.EBELN, V_SCM_D_SUPPLIERPLAN.MEINS, V_SCM_D_SUPPLIERPLAN.ORDER_MENGE, V_SCM_D_SUPPLIERPLAN.STATUS, V_SCM_D_SUPPLIERPLAN.FPRQ, V_SCM_D_SUPPLIERPLAN.NETPR, V_SCM_D_SUPPLIERPLAN.FREEUSE3, V_SCM_D_SUPPLIERPLAN.FACTORY, V_SCM_D_SUPPLIERPLAN.CODE, V_SCM_D_SUPPLIERPLAN.GYJH, V_SCM_D_SUPPLIERPLAN.WERKST, V_SCM_D_SUPPLIERPLAN.FREEUSE1, V_SCM_D_SUPPLIERPLAN.MENGE, V_SCM_D_SUPPLIERPLAN.CHARG, V_SCM_D_SUPPLIERPLAN.MSEHT, V_SCM_D_SUPPLIERPLAN.MATNR, V_SCM_D_SUPPLIERPLAN.GYSACCOUNT, V_SCM_D_SUPPLIERPLAN.UNINFORMED_STATE, V_SCM_D_SUPPLIERPLAN.CREATE_TIME, V_SCM_D_SUPPLIERPLAN.NAME, V_SCM_D_SUPPLIERPLAN.GYSNAME, V_SCM_D_SUPPLIERPLAN.PKG_AMOUNT, V_SCM_D_SUPPLIERPLAN.SPEC, V_SCM_D_SUPPLIERPLAN.FREEUSE2, V_SCM_D_SUPPLIERPLAN.COMMENTS, V_SCM_D_SUPPLIERPLAN.BEDAT, V_SCM_D_SUPPLIERPLAN.VFDAT, V_SCM_D_SUPPLIERPLAN.INFORMED_STATE, V_SCM_D_SUPPLIERPLAN.EEIND from V_SCM_D_SUPPLIERPLAN where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_D_SUPPLIERPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SUPPLIERPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FPHM = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.WERKS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPBM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TXZ01 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FPJR = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LGORT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EBELN = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MEINS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATUS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPRQ = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NETPR = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREEUSE3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FACTORY = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYJH = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.WERKST = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FREEUSE1 = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MENGE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CHARG = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MSEHT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.GYSNAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.SPEC = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.FREEUSE2 = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.COMMENTS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.BEDAT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.VFDAT = sqlReader.GetDateTime(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EEIND = sqlReader.GetString(37);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_D_SUPPLIERPLAN[] objs = new DisplayObject_V_SCM_D_SUPPLIERPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_D_SUPPLIERPLAN[] Query(CauseObject_V_SCM_D_SUPPLIERPLAN cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_D_SUPPLIERPLAN.FPHM, V_SCM_D_SUPPLIERPLAN.WERKS, V_SCM_D_SUPPLIERPLAN.FPBM, V_SCM_D_SUPPLIERPLAN.TXZ01, V_SCM_D_SUPPLIERPLAN.FPJR, V_SCM_D_SUPPLIERPLAN.LGORT, V_SCM_D_SUPPLIERPLAN.ID, V_SCM_D_SUPPLIERPLAN.HSDAT, V_SCM_D_SUPPLIERPLAN.PKG_NUMBER, V_SCM_D_SUPPLIERPLAN.EBELN, V_SCM_D_SUPPLIERPLAN.MEINS, V_SCM_D_SUPPLIERPLAN.ORDER_MENGE, V_SCM_D_SUPPLIERPLAN.STATUS, V_SCM_D_SUPPLIERPLAN.FPRQ, V_SCM_D_SUPPLIERPLAN.NETPR, V_SCM_D_SUPPLIERPLAN.FREEUSE3, V_SCM_D_SUPPLIERPLAN.FACTORY, V_SCM_D_SUPPLIERPLAN.CODE, V_SCM_D_SUPPLIERPLAN.GYJH, V_SCM_D_SUPPLIERPLAN.WERKST, V_SCM_D_SUPPLIERPLAN.FREEUSE1, V_SCM_D_SUPPLIERPLAN.MENGE, V_SCM_D_SUPPLIERPLAN.CHARG, V_SCM_D_SUPPLIERPLAN.MSEHT, V_SCM_D_SUPPLIERPLAN.MATNR, V_SCM_D_SUPPLIERPLAN.GYSACCOUNT, V_SCM_D_SUPPLIERPLAN.UNINFORMED_STATE, V_SCM_D_SUPPLIERPLAN.CREATE_TIME, V_SCM_D_SUPPLIERPLAN.NAME, V_SCM_D_SUPPLIERPLAN.GYSNAME, V_SCM_D_SUPPLIERPLAN.PKG_AMOUNT, V_SCM_D_SUPPLIERPLAN.SPEC, V_SCM_D_SUPPLIERPLAN.FREEUSE2, V_SCM_D_SUPPLIERPLAN.COMMENTS, V_SCM_D_SUPPLIERPLAN.BEDAT, V_SCM_D_SUPPLIERPLAN.VFDAT, V_SCM_D_SUPPLIERPLAN.INFORMED_STATE, V_SCM_D_SUPPLIERPLAN.EEIND from V_SCM_D_SUPPLIERPLAN where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_D_SUPPLIERPLAN",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_SCM_D_SUPPLIERPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SUPPLIERPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FPHM = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.WERKS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPBM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TXZ01 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FPJR = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LGORT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EBELN = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MEINS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATUS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPRQ = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NETPR = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREEUSE3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FACTORY = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYJH = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.WERKST = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FREEUSE1 = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MENGE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CHARG = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MSEHT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.GYSNAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.SPEC = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.FREEUSE2 = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.COMMENTS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.BEDAT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.VFDAT = sqlReader.GetDateTime(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EEIND = sqlReader.GetString(37);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_SUPPLIERPLAN[] objs = new DisplayObject_V_SCM_D_SUPPLIERPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_D_SUPPLIERPLAN[] Query(CauseObject_V_SCM_D_SUPPLIERPLAN cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_D_SUPPLIERPLAN.FPHM, V_SCM_D_SUPPLIERPLAN.WERKS, V_SCM_D_SUPPLIERPLAN.FPBM, V_SCM_D_SUPPLIERPLAN.TXZ01, V_SCM_D_SUPPLIERPLAN.FPJR, V_SCM_D_SUPPLIERPLAN.LGORT, V_SCM_D_SUPPLIERPLAN.ID, V_SCM_D_SUPPLIERPLAN.HSDAT, V_SCM_D_SUPPLIERPLAN.PKG_NUMBER, V_SCM_D_SUPPLIERPLAN.EBELN, V_SCM_D_SUPPLIERPLAN.MEINS, V_SCM_D_SUPPLIERPLAN.ORDER_MENGE, V_SCM_D_SUPPLIERPLAN.STATUS, V_SCM_D_SUPPLIERPLAN.FPRQ, V_SCM_D_SUPPLIERPLAN.NETPR, V_SCM_D_SUPPLIERPLAN.FREEUSE3, V_SCM_D_SUPPLIERPLAN.FACTORY, V_SCM_D_SUPPLIERPLAN.CODE, V_SCM_D_SUPPLIERPLAN.GYJH, V_SCM_D_SUPPLIERPLAN.WERKST, V_SCM_D_SUPPLIERPLAN.FREEUSE1, V_SCM_D_SUPPLIERPLAN.MENGE, V_SCM_D_SUPPLIERPLAN.CHARG, V_SCM_D_SUPPLIERPLAN.MSEHT, V_SCM_D_SUPPLIERPLAN.MATNR, V_SCM_D_SUPPLIERPLAN.GYSACCOUNT, V_SCM_D_SUPPLIERPLAN.UNINFORMED_STATE, V_SCM_D_SUPPLIERPLAN.CREATE_TIME, V_SCM_D_SUPPLIERPLAN.NAME, V_SCM_D_SUPPLIERPLAN.GYSNAME, V_SCM_D_SUPPLIERPLAN.PKG_AMOUNT, V_SCM_D_SUPPLIERPLAN.SPEC, V_SCM_D_SUPPLIERPLAN.FREEUSE2, V_SCM_D_SUPPLIERPLAN.COMMENTS, V_SCM_D_SUPPLIERPLAN.BEDAT, V_SCM_D_SUPPLIERPLAN.VFDAT, V_SCM_D_SUPPLIERPLAN.INFORMED_STATE, V_SCM_D_SUPPLIERPLAN.EEIND from V_SCM_D_SUPPLIERPLAN where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_D_SUPPLIERPLAN",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_SCM_D_SUPPLIERPLAN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SUPPLIERPLAN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FPHM = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.WERKS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPBM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TXZ01 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FPJR = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LGORT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HSDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PKG_NUMBER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EBELN = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MEINS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATUS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPRQ = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NETPR = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREEUSE3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FACTORY = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CODE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.GYJH = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.WERKST = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FREEUSE1 = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MENGE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CHARG = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MSEHT = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.UNINFORMED_STATE = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.GYSNAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.SPEC = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.FREEUSE2 = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.COMMENTS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.BEDAT = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.VFDAT = sqlReader.GetDateTime(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.INFORMED_STATE = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.EEIND = sqlReader.GetString(37);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_D_SUPPLIERPLAN[] objs = new DisplayObject_V_SCM_D_SUPPLIERPLAN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_SCM_D_SUPPLIERPLAN obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("FPHM"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.FPHM = :FPHM");
				param = new OracleParameter();
				param.ParameterName = ":FPHM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.FPHM) ? string.Empty : obj.FPHM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WERKS"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.WERKS = :WERKS");
				param = new OracleParameter();
				param.ParameterName = ":WERKS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 40;
				param.Value = string.IsNullOrEmpty(obj.WERKS) ? string.Empty : obj.WERKS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FPBM"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.FPBM = :FPBM");
				param = new OracleParameter();
				param.ParameterName = ":FPBM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.FPBM) ? string.Empty : obj.FPBM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TXZ01"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.TXZ01 = :TXZ01");
				param = new OracleParameter();
				param.ParameterName = ":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.TXZ01) ? string.Empty : obj.TXZ01;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FPJR"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.FPJR = :FPJR");
				param = new OracleParameter();
				param.ParameterName = ":FPJR";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.FPJR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LGORT"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.LGORT = :LGORT");
				param = new OracleParameter();
				param.ParameterName = ":LGORT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.LGORT) ? string.Empty : obj.LGORT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("HSDAT"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.HSDAT = :HSDAT");
				param = new OracleParameter();
				param.ParameterName = ":HSDAT";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.HSDAT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PKG_NUMBER"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.PKG_NUMBER = :PKG_NUMBER");
				param = new OracleParameter();
				param.ParameterName = ":PKG_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PKG_NUMBER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EBELN"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.EBELN = :EBELN");
				param = new OracleParameter();
				param.ParameterName = ":EBELN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.EBELN) ? string.Empty : obj.EBELN;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MEINS"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.MEINS = :MEINS");
				param = new OracleParameter();
				param.ParameterName = ":MEINS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MEINS) ? string.Empty : obj.MEINS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ORDER_MENGE"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.ORDER_MENGE = :ORDER_MENGE");
				param = new OracleParameter();
				param.ParameterName = ":ORDER_MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ORDER_MENGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATUS"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.STATUS = :STATUS");
				param = new OracleParameter();
				param.ParameterName = ":STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.STATUS) ? string.Empty : obj.STATUS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FPRQ"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.FPRQ = :FPRQ");
				param = new OracleParameter();
				param.ParameterName = ":FPRQ";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.FPRQ;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NETPR"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.NETPR = :NETPR");
				param = new OracleParameter();
				param.ParameterName = ":NETPR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.NETPR) ? string.Empty : obj.NETPR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE3"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.FREEUSE3 = :FREEUSE3");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE3) ? string.Empty : obj.FREEUSE3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FACTORY"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.FACTORY = :FACTORY");
				param = new OracleParameter();
				param.ParameterName = ":FACTORY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.FACTORY) ? string.Empty : obj.FACTORY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYJH"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.GYJH = :GYJH");
				param = new OracleParameter();
				param.ParameterName = ":GYJH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.GYJH) ? string.Empty : obj.GYJH;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WERKST"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.WERKST = :WERKST");
				param = new OracleParameter();
				param.ParameterName = ":WERKST";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.WERKST) ? string.Empty : obj.WERKST;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE1"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.FREEUSE1 = :FREEUSE1");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE1) ? string.Empty : obj.FREEUSE1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MENGE"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.MENGE = :MENGE");
				param = new OracleParameter();
				param.ParameterName = ":MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MENGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CHARG"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.CHARG = :CHARG");
				param = new OracleParameter();
				param.ParameterName = ":CHARG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CHARG) ? string.Empty : obj.CHARG;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MSEHT"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.MSEHT = :MSEHT");
				param = new OracleParameter();
				param.ParameterName = ":MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MSEHT) ? string.Empty : obj.MSEHT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATNR"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.MATNR = :MATNR");
				param = new OracleParameter();
				param.ParameterName = ":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MATNR) ? string.Empty : obj.MATNR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.GYSACCOUNT = :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("UNINFORMED_STATE"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.UNINFORMED_STATE = :UNINFORMED_STATE");
				param = new OracleParameter();
				param.ParameterName = ":UNINFORMED_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.UNINFORMED_STATE) ? string.Empty : obj.UNINFORMED_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSNAME"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.GYSNAME = :GYSNAME");
				param = new OracleParameter();
				param.ParameterName = ":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYSNAME) ? string.Empty : obj.GYSNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PKG_AMOUNT"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.PKG_AMOUNT = :PKG_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":PKG_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PKG_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.SPEC = :SPEC");
				param = new OracleParameter();
				param.ParameterName = ":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE2"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.FREEUSE2 = :FREEUSE2");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE2) ? string.Empty : obj.FREEUSE2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BEDAT"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.BEDAT = :BEDAT");
				param = new OracleParameter();
				param.ParameterName = ":BEDAT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.BEDAT) ? string.Empty : obj.BEDAT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("VFDAT"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.VFDAT = :VFDAT");
				param = new OracleParameter();
				param.ParameterName = ":VFDAT";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.VFDAT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INFORMED_STATE"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.INFORMED_STATE = :INFORMED_STATE");
				param = new OracleParameter();
				param.ParameterName = ":INFORMED_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.INFORMED_STATE) ? string.Empty : obj.INFORMED_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EEIND"))
			{
				strBuf.Add("  V_SCM_D_SUPPLIERPLAN.EEIND = :EEIND");
				param = new OracleParameter();
				param.ParameterName = ":EEIND";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.EEIND) ? string.Empty : obj.EEIND;
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
