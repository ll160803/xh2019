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
	[CauseObject(typeof(CauseObject_MDM_D_DEPT))]
	public partial class HelperObject_MDM_D_DEPT
	{		
		#region Method Blok
		public static int Save(EntityObject_MDM_D_DEPT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MDM_D_DEPT( SHORT_NAME, PHONE, CREATE_TIME, FAX, LINK_PERSON, ID, ADDRESS, DATA_ORGANISE_ID, BALANCE_TYPE_ID, REGISTER_FUND, MODIFY_DEPT_ID, URL, CODE, EMAIL, LAW_PERSON, TAX_NUMBER, DEPT_TYPE_ID, STATE, TAX_HEAD, BANK_ADDRESS, CREATE_USER_ID, COMMENTS, SERVICES, NAME, BANK_NAME, BANK_NUMBER, CREATE_DEPT_ID, CONTRACT_START, CONTRACT_END) values ( :SHORT_NAME, :PHONE, :CREATE_TIME, :FAX, :LINK_PERSON, :ID, :ADDRESS, :DATA_ORGANISE_ID, :BALANCE_TYPE_ID, :REGISTER_FUND, :MODIFY_DEPT_ID, :URL, :CODE, :EMAIL, :LAW_PERSON, :TAX_NUMBER, :DEPT_TYPE_ID, :STATE, :TAX_HEAD, :BANK_ADDRESS, :CREATE_USER_ID, :COMMENTS, :SERVICES, :NAME, :BANK_NAME, :BANK_NUMBER, :CREATE_DEPT_ID, :CONTRACT_START, :CONTRACT_END)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[29];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":SHORT_NAME";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.SHORT_NAME == null ? String.Empty:obj.SHORT_NAME;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":PHONE";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.PHONE == null ? String.Empty:obj.PHONE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CREATE_TIME";
			parameters[2].Size = 7;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[2].Value = obj.CREATE_TIME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":FAX";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.FAX == null ? String.Empty:obj.FAX;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":LINK_PERSON";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.LINK_PERSON == null ? String.Empty:obj.LINK_PERSON;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ADDRESS";
			parameters[6].Size = 200;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.ADDRESS == null ? String.Empty:obj.ADDRESS;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":DATA_ORGANISE_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":BALANCE_TYPE_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.BALANCE_TYPE_ID == null ? String.Empty:obj.BALANCE_TYPE_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":REGISTER_FUND";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.REGISTER_FUND;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":MODIFY_DEPT_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":URL";
			parameters[11].Size = 50;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.URL == null ? String.Empty:obj.URL;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":CODE";
			parameters[12].Size = 50;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":EMAIL";
			parameters[13].Size = 50;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.EMAIL == null ? String.Empty:obj.EMAIL;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":LAW_PERSON";
			parameters[14].Size = 50;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.LAW_PERSON == null ? String.Empty:obj.LAW_PERSON;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":TAX_NUMBER";
			parameters[15].Size = 50;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.TAX_NUMBER == null ? String.Empty:obj.TAX_NUMBER;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":DEPT_TYPE_ID";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.DEPT_TYPE_ID == null ? String.Empty:obj.DEPT_TYPE_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":STATE";
			parameters[17].Size = 22;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[17].Value = obj.STATE;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":TAX_HEAD";
			parameters[18].Size = 50;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.TAX_HEAD == null ? String.Empty:obj.TAX_HEAD;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":BANK_ADDRESS";
			parameters[19].Size = 200;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.BANK_ADDRESS == null ? String.Empty:obj.BANK_ADDRESS;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":CREATE_USER_ID";
			parameters[20].Size = 36;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[20].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":COMMENTS";
			parameters[21].Size = 200;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[21].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":SERVICES";
			parameters[22].Size = 200;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[22].Value = obj.SERVICES == null ? String.Empty:obj.SERVICES;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":NAME";
			parameters[23].Size = 50;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[23].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":BANK_NAME";
			parameters[24].Size = 50;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[24].Value = obj.BANK_NAME == null ? String.Empty:obj.BANK_NAME;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":BANK_NUMBER";
			parameters[25].Size = 50;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[25].Value = obj.BANK_NUMBER == null ? String.Empty:obj.BANK_NUMBER;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":CREATE_DEPT_ID";
			parameters[26].Size = 36;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[26].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;

            parameters[27] = new OracleParameter();
            parameters[27].ParameterName = ":CONTRACT_START";
            parameters[27].Size = 7;
            parameters[27].OracleType = System.Data.OracleClient.OracleType.DateTime;
            parameters[27].Value = obj.CONTRACT_START == null ? new System.DateTime(1,1,1) : obj.CONTRACT_START;

            parameters[28] = new OracleParameter();
            parameters[28].ParameterName = ":CONTRACT_END";
            parameters[28].Size = 7;
            parameters[28].OracleType = System.Data.OracleClient.OracleType.DateTime;
            parameters[28].Value = obj.CONTRACT_END == null ? new System.DateTime(1, 1, 1) : obj.CONTRACT_END;

            #endregion
            return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MDM_D_DEPT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MDM_D_DEPT set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MDM_D_DEPT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MDM_D_DEPT where  ID = :ID ";
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
		public static EntityObject_MDM_D_DEPT Get(EntityObject_MDM_D_DEPT obj)
		{
			
			//平台自动生成代码
			string sSql = "select  SHORT_NAME, PHONE, CREATE_TIME, FAX, MODIFY_TIME, LINK_PERSON, ID, ADDRESS, DATA_ORGANISE_ID, BALANCE_TYPE_ID, REGISTER_FUND, MODIFY_DEPT_ID, URL, CODE, EMAIL, LAW_PERSON, MODIFY_USER_ID, TAX_NUMBER, DEPT_TYPE_ID, STATE, TAX_HEAD, BANK_ADDRESS, CREATE_USER_ID, COMMENTS, SERVICES, NAME, BANK_NAME, BANK_NUMBER, CREATE_DEPT_ID, CONTRACT_START, CONTRACT_END from MDM_D_DEPT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MDM_D_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MDM_D_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SHORT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PHONE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FAX = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BALANCE_TYPE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REGISTER_FUND = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.EMAIL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.LAW_PERSON = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TAX_NUMBER = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.TAX_HEAD = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.BANK_ADDRESS = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.COMMENTS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.SERVICES = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.BANK_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BANK_NUMBER = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.CONTRACT_START = sqlReader.GetDateTime(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.CONTRACT_END = sqlReader.GetDateTime(30);
                objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MDM_D_DEPT[] objs = new EntityObject_MDM_D_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_MDM_D_DEPT Get(EntityObject_MDM_D_DEPT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  SHORT_NAME, PHONE, CREATE_TIME, FAX, MODIFY_TIME, LINK_PERSON, ID, ADDRESS, DATA_ORGANISE_ID, BALANCE_TYPE_ID, REGISTER_FUND, MODIFY_DEPT_ID, URL, CODE, EMAIL, LAW_PERSON, MODIFY_USER_ID, TAX_NUMBER, DEPT_TYPE_ID, STATE, TAX_HEAD, BANK_ADDRESS, CREATE_USER_ID, COMMENTS, SERVICES, NAME, BANK_NAME, BANK_NUMBER, CREATE_DEPT_ID, CONTRACT_START, CONTRACT_END from MDM_D_DEPT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MDM_D_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MDM_D_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SHORT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PHONE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FAX = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BALANCE_TYPE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REGISTER_FUND = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.EMAIL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.LAW_PERSON = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TAX_NUMBER = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.TAX_HEAD = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.BANK_ADDRESS = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.COMMENTS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.SERVICES = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.BANK_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BANK_NUMBER = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.CONTRACT_START = sqlReader.GetDateTime(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.CONTRACT_END = sqlReader.GetDateTime(30);
                objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MDM_D_DEPT[] objs = new EntityObject_MDM_D_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MDM_D_DEPT[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MDM_D_DEPT.SHORT_NAME, MDM_D_DEPT.PHONE, MDM_D_DEPT.CREATE_TIME, MDM_D_DEPT.FAX, MDM_D_DEPT.MODIFY_TIME, MDM_D_DEPT.LINK_PERSON, MDM_D_DEPT.ID, MDM_D_DEPT.ADDRESS, MDM_D_DEPT.DATA_ORGANISE_ID, MDM_D_DEPT.BALANCE_TYPE_ID, MDM_D_DEPT.REGISTER_FUND, MDM_D_DEPT.MODIFY_DEPT_ID, MDM_D_DEPT.URL, MDM_D_DEPT.CODE, MDM_D_DEPT.EMAIL, MDM_D_DEPT.LAW_PERSON, MDM_D_DEPT.MODIFY_USER_ID, MDM_D_DEPT.TAX_NUMBER, MDM_D_DEPT.DEPT_TYPE_ID, MDM_D_DEPT.STATE, MDM_D_DEPT.TAX_HEAD, MDM_D_DEPT.BANK_ADDRESS, MDM_D_DEPT.CREATE_USER_ID, MDM_D_DEPT.COMMENTS, MDM_D_DEPT.SERVICES, MDM_D_DEPT.NAME, MDM_D_DEPT.BANK_NAME, MDM_D_DEPT.BANK_NUMBER, MDM_D_DEPT.CREATE_DEPT_ID, COM_TYPE_DEPT_TYPE_ID.NAME as DEPT_TYPE_ID_NAME, CONTRACT_START, CONTRACT_END from MDM_D_DEPT left join COM_TYPE   COM_TYPE_DEPT_TYPE_ID on MDM_D_DEPT.DEPT_TYPE_ID = COM_TYPE_DEPT_TYPE_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MDM_D_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MDM_D_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SHORT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PHONE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FAX = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BALANCE_TYPE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REGISTER_FUND = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.EMAIL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.LAW_PERSON = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TAX_NUMBER = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.TAX_HEAD = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.BANK_ADDRESS = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.COMMENTS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.SERVICES = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.BANK_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BANK_NUMBER = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.DEPT_TYPE_ID_NAME = sqlReader.GetString(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.CONTRACT_START = sqlReader.GetDateTime(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.CONTRACT_END = sqlReader.GetDateTime(31);
                objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MDM_D_DEPT[] objs = new DisplayObject_MDM_D_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MDM_D_DEPT cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.SHORT_NAME))
			{
				strBuf.Append(" And MDM_D_DEPT.SHORT_NAME ").Append((cause.SHORT_NAME.StartsWith("%") || cause.SHORT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :SHORT_NAME");
				param = new OracleParameter();
				param.ParameterName =":SHORT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SHORT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SHORT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "SHORT_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.PHONE))
			{
				strBuf.Append(" And MDM_D_DEPT.PHONE ").Append((cause.PHONE.StartsWith("%") || cause.PHONE.EndsWith("%")) ? " like " : " = ").Append(" :PHONE");
				param = new OracleParameter();
				param.ParameterName =":PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PHONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PHONE"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "PHONE"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And MDM_D_DEPT.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And MDM_D_DEPT.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.FAX))
			{
				strBuf.Append(" And MDM_D_DEPT.FAX ").Append((cause.FAX.StartsWith("%") || cause.FAX.EndsWith("%")) ? " like " : " = ").Append(" :FAX");
				param = new OracleParameter();
				param.ParameterName =":FAX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FAX;
				paramList.Add(param);
			}
			if (cause.HasINValue("FAX"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "FAX"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And MDM_D_DEPT.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And MDM_D_DEPT.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.LINK_PERSON))
			{
				strBuf.Append(" And MDM_D_DEPT.LINK_PERSON ").Append((cause.LINK_PERSON.StartsWith("%") || cause.LINK_PERSON.EndsWith("%")) ? " like " : " = ").Append(" :LINK_PERSON");
				param = new OracleParameter();
				param.ParameterName =":LINK_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.LINK_PERSON;
				paramList.Add(param);
			}
			if (cause.HasINValue("LINK_PERSON"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "LINK_PERSON"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And MDM_D_DEPT.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.ADDRESS))
			{
				strBuf.Append(" And MDM_D_DEPT.ADDRESS ").Append((cause.ADDRESS.StartsWith("%") || cause.ADDRESS.EndsWith("%")) ? " like " : " = ").Append(" :ADDRESS");
				param = new OracleParameter();
				param.ParameterName =":ADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.ADDRESS;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADDRESS"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "ADDRESS"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And MDM_D_DEPT.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BALANCE_TYPE_ID))
			{
				strBuf.Append(" And MDM_D_DEPT.BALANCE_TYPE_ID ").Append((cause.BALANCE_TYPE_ID.StartsWith("%") || cause.BALANCE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BALANCE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":BALANCE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BALANCE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BALANCE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "BALANCE_TYPE_ID"));
			}
			if(cause.REGISTER_FUND!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MDM_D_DEPT.REGISTER_FUND = :REGISTER_FUND");
				param = new OracleParameter();
				param.ParameterName =":REGISTER_FUND";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REGISTER_FUND;
				paramList.Add(param);
			}
			if (cause.HasINValue("REGISTER_FUND"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "REGISTER_FUND"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And MDM_D_DEPT.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "MODIFY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.URL))
			{
				strBuf.Append(" And MDM_D_DEPT.URL ").Append((cause.URL.StartsWith("%") || cause.URL.EndsWith("%")) ? " like " : " = ").Append(" :URL");
				param = new OracleParameter();
				param.ParameterName =":URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("URL"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "URL"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And MDM_D_DEPT.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.EMAIL))
			{
				strBuf.Append(" And MDM_D_DEPT.EMAIL ").Append((cause.EMAIL.StartsWith("%") || cause.EMAIL.EndsWith("%")) ? " like " : " = ").Append(" :EMAIL");
				param = new OracleParameter();
				param.ParameterName =":EMAIL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.EMAIL;
				paramList.Add(param);
			}
			if (cause.HasINValue("EMAIL"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "EMAIL"));
			}
			if(!string.IsNullOrEmpty(cause.LAW_PERSON))
			{
				strBuf.Append(" And MDM_D_DEPT.LAW_PERSON ").Append((cause.LAW_PERSON.StartsWith("%") || cause.LAW_PERSON.EndsWith("%")) ? " like " : " = ").Append(" :LAW_PERSON");
				param = new OracleParameter();
				param.ParameterName =":LAW_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.LAW_PERSON;
				paramList.Add(param);
			}
			if (cause.HasINValue("LAW_PERSON"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "LAW_PERSON"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And MDM_D_DEPT.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.TAX_NUMBER))
			{
				strBuf.Append(" And MDM_D_DEPT.TAX_NUMBER ").Append((cause.TAX_NUMBER.StartsWith("%") || cause.TAX_NUMBER.EndsWith("%")) ? " like " : " = ").Append(" :TAX_NUMBER");
				param = new OracleParameter();
				param.ParameterName =":TAX_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.TAX_NUMBER;
				paramList.Add(param);
			}
			if (cause.HasINValue("TAX_NUMBER"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "TAX_NUMBER"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_TYPE_ID))
			{
				strBuf.Append(" And MDM_D_DEPT.DEPT_TYPE_ID ").Append((cause.DEPT_TYPE_ID.StartsWith("%") || cause.DEPT_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DEPT_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":DEPT_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "DEPT_TYPE_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MDM_D_DEPT.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.TAX_HEAD))
			{
				strBuf.Append(" And MDM_D_DEPT.TAX_HEAD ").Append((cause.TAX_HEAD.StartsWith("%") || cause.TAX_HEAD.EndsWith("%")) ? " like " : " = ").Append(" :TAX_HEAD");
				param = new OracleParameter();
				param.ParameterName =":TAX_HEAD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.TAX_HEAD;
				paramList.Add(param);
			}
			if (cause.HasINValue("TAX_HEAD"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "TAX_HEAD"));
			}
			if(!string.IsNullOrEmpty(cause.BANK_ADDRESS))
			{
				strBuf.Append(" And MDM_D_DEPT.BANK_ADDRESS ").Append((cause.BANK_ADDRESS.StartsWith("%") || cause.BANK_ADDRESS.EndsWith("%")) ? " like " : " = ").Append(" :BANK_ADDRESS");
				param = new OracleParameter();
				param.ParameterName =":BANK_ADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.BANK_ADDRESS;
				paramList.Add(param);
			}
			if (cause.HasINValue("BANK_ADDRESS"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "BANK_ADDRESS"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And MDM_D_DEPT.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And MDM_D_DEPT.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.SERVICES))
			{
				strBuf.Append(" And MDM_D_DEPT.SERVICES ").Append((cause.SERVICES.StartsWith("%") || cause.SERVICES.EndsWith("%")) ? " like " : " = ").Append(" :SERVICES");
				param = new OracleParameter();
				param.ParameterName =":SERVICES";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.SERVICES;
				paramList.Add(param);
			}
			if (cause.HasINValue("SERVICES"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "SERVICES"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And MDM_D_DEPT.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BANK_NAME))
			{
				strBuf.Append(" And MDM_D_DEPT.BANK_NAME ").Append((cause.BANK_NAME.StartsWith("%") || cause.BANK_NAME.EndsWith("%")) ? " like " : " = ").Append(" :BANK_NAME");
				param = new OracleParameter();
				param.ParameterName =":BANK_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BANK_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BANK_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "BANK_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BANK_NUMBER))
			{
				strBuf.Append(" And MDM_D_DEPT.BANK_NUMBER ").Append((cause.BANK_NUMBER.StartsWith("%") || cause.BANK_NUMBER.EndsWith("%")) ? " like " : " = ").Append(" :BANK_NUMBER");
				param = new OracleParameter();
				param.ParameterName =":BANK_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BANK_NUMBER;
				paramList.Add(param);
			}
			if (cause.HasINValue("BANK_NUMBER"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "BANK_NUMBER"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And MDM_D_DEPT.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
    
            if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MDM_D_DEPT", "CREATE_DEPT_ID"));
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
		public static DisplayObject_MDM_D_DEPT[] Query(CauseObject_MDM_D_DEPT cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MDM_D_DEPT.SHORT_NAME, MDM_D_DEPT.PHONE, MDM_D_DEPT.CREATE_TIME, MDM_D_DEPT.FAX, MDM_D_DEPT.MODIFY_TIME, MDM_D_DEPT.LINK_PERSON, MDM_D_DEPT.ID, MDM_D_DEPT.ADDRESS, MDM_D_DEPT.DATA_ORGANISE_ID, MDM_D_DEPT.BALANCE_TYPE_ID, MDM_D_DEPT.REGISTER_FUND, MDM_D_DEPT.MODIFY_DEPT_ID, MDM_D_DEPT.URL, MDM_D_DEPT.CODE, MDM_D_DEPT.EMAIL, MDM_D_DEPT.LAW_PERSON, MDM_D_DEPT.MODIFY_USER_ID, MDM_D_DEPT.TAX_NUMBER, MDM_D_DEPT.DEPT_TYPE_ID, MDM_D_DEPT.STATE, MDM_D_DEPT.TAX_HEAD, MDM_D_DEPT.BANK_ADDRESS, MDM_D_DEPT.CREATE_USER_ID, MDM_D_DEPT.COMMENTS, MDM_D_DEPT.SERVICES, MDM_D_DEPT.NAME, MDM_D_DEPT.BANK_NAME, MDM_D_DEPT.BANK_NUMBER, MDM_D_DEPT.CREATE_DEPT_ID, COM_TYPE_DEPT_TYPE_ID.NAME as DEPT_TYPE_ID_NAME, CONTRACT_START, CONTRACT_END from MDM_D_DEPT left join COM_TYPE   COM_TYPE_DEPT_TYPE_ID on MDM_D_DEPT.DEPT_TYPE_ID = COM_TYPE_DEPT_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters).Replace("ID in", "MDM_D_DEPT.ID in");
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MDM_D_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MDM_D_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SHORT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PHONE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FAX = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BALANCE_TYPE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REGISTER_FUND = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.EMAIL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.LAW_PERSON = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TAX_NUMBER = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.TAX_HEAD = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.BANK_ADDRESS = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.COMMENTS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.SERVICES = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.BANK_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BANK_NUMBER = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.DEPT_TYPE_ID_NAME = sqlReader.GetString(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.CONTRACT_START = sqlReader.GetDateTime(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.CONTRACT_END = sqlReader.GetDateTime(31);
                objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MDM_D_DEPT[] objs = new DisplayObject_MDM_D_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_MDM_D_DEPT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MDM_D_DEPT where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_MDM_D_DEPT[] Query(CauseObject_MDM_D_DEPT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MDM_D_DEPT.SHORT_NAME, MDM_D_DEPT.PHONE, MDM_D_DEPT.CREATE_TIME, MDM_D_DEPT.FAX, MDM_D_DEPT.MODIFY_TIME, MDM_D_DEPT.LINK_PERSON, MDM_D_DEPT.ID, MDM_D_DEPT.ADDRESS, MDM_D_DEPT.DATA_ORGANISE_ID, MDM_D_DEPT.BALANCE_TYPE_ID, MDM_D_DEPT.REGISTER_FUND, MDM_D_DEPT.MODIFY_DEPT_ID, MDM_D_DEPT.URL, MDM_D_DEPT.CODE, MDM_D_DEPT.EMAIL, MDM_D_DEPT.LAW_PERSON, MDM_D_DEPT.MODIFY_USER_ID, MDM_D_DEPT.TAX_NUMBER, MDM_D_DEPT.DEPT_TYPE_ID, MDM_D_DEPT.STATE, MDM_D_DEPT.TAX_HEAD, MDM_D_DEPT.BANK_ADDRESS, MDM_D_DEPT.CREATE_USER_ID, MDM_D_DEPT.COMMENTS, MDM_D_DEPT.SERVICES, MDM_D_DEPT.NAME, MDM_D_DEPT.BANK_NAME, MDM_D_DEPT.BANK_NUMBER, MDM_D_DEPT.CREATE_DEPT_ID, COM_TYPE_DEPT_TYPE_ID.NAME as DEPT_TYPE_ID_NAME, CONTRACT_START, CONTRACT_END from MDM_D_DEPT left join COM_TYPE   COM_TYPE_DEPT_TYPE_ID on MDM_D_DEPT.DEPT_TYPE_ID = COM_TYPE_DEPT_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MDM_D_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MDM_D_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SHORT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PHONE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FAX = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BALANCE_TYPE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REGISTER_FUND = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.EMAIL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.LAW_PERSON = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TAX_NUMBER = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.TAX_HEAD = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.BANK_ADDRESS = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.COMMENTS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.SERVICES = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.BANK_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BANK_NUMBER = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.DEPT_TYPE_ID_NAME = sqlReader.GetString(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.CONTRACT_START = sqlReader.GetDateTime(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.CONTRACT_END = sqlReader.GetDateTime(31);
                objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MDM_D_DEPT[] objs = new DisplayObject_MDM_D_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MDM_D_DEPT[] Query(CauseObject_MDM_D_DEPT cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MDM_D_DEPT.SHORT_NAME, MDM_D_DEPT.PHONE, MDM_D_DEPT.CREATE_TIME, MDM_D_DEPT.FAX, MDM_D_DEPT.MODIFY_TIME, MDM_D_DEPT.LINK_PERSON, MDM_D_DEPT.ID, MDM_D_DEPT.ADDRESS, MDM_D_DEPT.DATA_ORGANISE_ID, MDM_D_DEPT.BALANCE_TYPE_ID, MDM_D_DEPT.REGISTER_FUND, MDM_D_DEPT.MODIFY_DEPT_ID, MDM_D_DEPT.URL, MDM_D_DEPT.CODE, MDM_D_DEPT.EMAIL, MDM_D_DEPT.LAW_PERSON, MDM_D_DEPT.MODIFY_USER_ID, MDM_D_DEPT.TAX_NUMBER, MDM_D_DEPT.DEPT_TYPE_ID, MDM_D_DEPT.STATE, MDM_D_DEPT.TAX_HEAD, MDM_D_DEPT.BANK_ADDRESS, MDM_D_DEPT.CREATE_USER_ID, MDM_D_DEPT.COMMENTS, MDM_D_DEPT.SERVICES, MDM_D_DEPT.NAME, MDM_D_DEPT.BANK_NAME, MDM_D_DEPT.BANK_NUMBER, MDM_D_DEPT.CREATE_DEPT_ID, COM_TYPE_DEPT_TYPE_ID.NAME as DEPT_TYPE_ID_NAME, CONTRACT_START, CONTRACT_END from MDM_D_DEPT left join COM_TYPE   COM_TYPE_DEPT_TYPE_ID on MDM_D_DEPT.DEPT_TYPE_ID = COM_TYPE_DEPT_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MDM_D_DEPT",paging, order, sSql, parameters, connection);
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
			DisplayObject_MDM_D_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MDM_D_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SHORT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PHONE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FAX = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BALANCE_TYPE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REGISTER_FUND = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.EMAIL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.LAW_PERSON = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TAX_NUMBER = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.TAX_HEAD = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.BANK_ADDRESS = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.COMMENTS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.SERVICES = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.BANK_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BANK_NUMBER = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.DEPT_TYPE_ID_NAME = sqlReader.GetString(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.CONTRACT_START = sqlReader.GetDateTime(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.CONTRACT_END = sqlReader.GetDateTime(31);
                objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MDM_D_DEPT[] objs = new DisplayObject_MDM_D_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MDM_D_DEPT[] Query(CauseObject_MDM_D_DEPT cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MDM_D_DEPT.SHORT_NAME, MDM_D_DEPT.PHONE, MDM_D_DEPT.CREATE_TIME, MDM_D_DEPT.FAX, MDM_D_DEPT.MODIFY_TIME, MDM_D_DEPT.LINK_PERSON, MDM_D_DEPT.ID, MDM_D_DEPT.ADDRESS, MDM_D_DEPT.DATA_ORGANISE_ID, MDM_D_DEPT.BALANCE_TYPE_ID, MDM_D_DEPT.REGISTER_FUND, MDM_D_DEPT.MODIFY_DEPT_ID, MDM_D_DEPT.URL, MDM_D_DEPT.CODE, MDM_D_DEPT.EMAIL, MDM_D_DEPT.LAW_PERSON, MDM_D_DEPT.MODIFY_USER_ID, MDM_D_DEPT.TAX_NUMBER, MDM_D_DEPT.DEPT_TYPE_ID, MDM_D_DEPT.STATE, MDM_D_DEPT.TAX_HEAD, MDM_D_DEPT.BANK_ADDRESS, MDM_D_DEPT.CREATE_USER_ID, MDM_D_DEPT.COMMENTS, MDM_D_DEPT.SERVICES, MDM_D_DEPT.NAME, MDM_D_DEPT.BANK_NAME, MDM_D_DEPT.BANK_NUMBER, MDM_D_DEPT.CREATE_DEPT_ID, COM_TYPE_DEPT_TYPE_ID.NAME as DEPT_TYPE_ID_NAME, CONTRACT_START, CONTRACT_END from MDM_D_DEPT left join COM_TYPE   COM_TYPE_DEPT_TYPE_ID on MDM_D_DEPT.DEPT_TYPE_ID = COM_TYPE_DEPT_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MDM_D_DEPT",paging, order, sSql, parameters, trans);
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
			DisplayObject_MDM_D_DEPT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MDM_D_DEPT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SHORT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PHONE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FAX = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BALANCE_TYPE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.REGISTER_FUND = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.EMAIL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.LAW_PERSON = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TAX_NUMBER = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.DEPT_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.TAX_HEAD = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.BANK_ADDRESS = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.COMMENTS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.SERVICES = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.BANK_NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.BANK_NUMBER = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.DEPT_TYPE_ID_NAME = sqlReader.GetString(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.CONTRACT_START = sqlReader.GetDateTime(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.CONTRACT_END = sqlReader.GetDateTime(31);
                objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MDM_D_DEPT[] objs = new DisplayObject_MDM_D_DEPT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MDM_D_DEPT obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("SHORT_NAME"))
			{
				strBuf.Add("  MDM_D_DEPT.SHORT_NAME = :SHORT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":SHORT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SHORT_NAME) ? string.Empty : obj.SHORT_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PHONE"))
			{
				strBuf.Add("  MDM_D_DEPT.PHONE = :PHONE");
				param = new OracleParameter();
				param.ParameterName = ":PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PHONE) ? string.Empty : obj.PHONE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FAX"))
			{
				strBuf.Add("  MDM_D_DEPT.FAX = :FAX");
				param = new OracleParameter();
				param.ParameterName = ":FAX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FAX) ? string.Empty : obj.FAX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  MDM_D_DEPT.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LINK_PERSON"))
			{
				strBuf.Add("  MDM_D_DEPT.LINK_PERSON = :LINK_PERSON");
				param = new OracleParameter();
				param.ParameterName = ":LINK_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.LINK_PERSON) ? string.Empty : obj.LINK_PERSON;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ADDRESS"))
			{
				strBuf.Add("  MDM_D_DEPT.ADDRESS = :ADDRESS");
				param = new OracleParameter();
				param.ParameterName = ":ADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.ADDRESS) ? string.Empty : obj.ADDRESS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  MDM_D_DEPT.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BALANCE_TYPE_ID"))
			{
				strBuf.Add("  MDM_D_DEPT.BALANCE_TYPE_ID = :BALANCE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BALANCE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BALANCE_TYPE_ID) ? string.Empty : obj.BALANCE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REGISTER_FUND"))
			{
				strBuf.Add("  MDM_D_DEPT.REGISTER_FUND = :REGISTER_FUND");
				param = new OracleParameter();
				param.ParameterName = ":REGISTER_FUND";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.REGISTER_FUND;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  MDM_D_DEPT.MODIFY_DEPT_ID = :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("URL"))
			{
				strBuf.Add("  MDM_D_DEPT.URL = :URL");
				param = new OracleParameter();
				param.ParameterName = ":URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.URL) ? string.Empty : obj.URL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  MDM_D_DEPT.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EMAIL"))
			{
				strBuf.Add("  MDM_D_DEPT.EMAIL = :EMAIL");
				param = new OracleParameter();
				param.ParameterName = ":EMAIL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.EMAIL) ? string.Empty : obj.EMAIL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LAW_PERSON"))
			{
				strBuf.Add("  MDM_D_DEPT.LAW_PERSON = :LAW_PERSON");
				param = new OracleParameter();
				param.ParameterName = ":LAW_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.LAW_PERSON) ? string.Empty : obj.LAW_PERSON;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  MDM_D_DEPT.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TAX_NUMBER"))
			{
				strBuf.Add("  MDM_D_DEPT.TAX_NUMBER = :TAX_NUMBER");
				param = new OracleParameter();
				param.ParameterName = ":TAX_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.TAX_NUMBER) ? string.Empty : obj.TAX_NUMBER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_TYPE_ID"))
			{
				strBuf.Add("  MDM_D_DEPT.DEPT_TYPE_ID = :DEPT_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DEPT_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_TYPE_ID) ? string.Empty : obj.DEPT_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  MDM_D_DEPT.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TAX_HEAD"))
			{
				strBuf.Add("  MDM_D_DEPT.TAX_HEAD = :TAX_HEAD");
				param = new OracleParameter();
				param.ParameterName = ":TAX_HEAD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.TAX_HEAD) ? string.Empty : obj.TAX_HEAD;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BANK_ADDRESS"))
			{
				strBuf.Add("  MDM_D_DEPT.BANK_ADDRESS = :BANK_ADDRESS");
				param = new OracleParameter();
				param.ParameterName = ":BANK_ADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.BANK_ADDRESS) ? string.Empty : obj.BANK_ADDRESS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MDM_D_DEPT.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SERVICES"))
			{
				strBuf.Add("  MDM_D_DEPT.SERVICES = :SERVICES");
				param = new OracleParameter();
				param.ParameterName = ":SERVICES";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.SERVICES) ? string.Empty : obj.SERVICES;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  MDM_D_DEPT.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BANK_NAME"))
			{
				strBuf.Add("  MDM_D_DEPT.BANK_NAME = :BANK_NAME");
				param = new OracleParameter();
				param.ParameterName = ":BANK_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BANK_NAME) ? string.Empty : obj.BANK_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BANK_NUMBER"))
			{
				strBuf.Add("  MDM_D_DEPT.BANK_NUMBER = :BANK_NUMBER");
				param = new OracleParameter();
				param.ParameterName = ":BANK_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BANK_NUMBER) ? string.Empty : obj.BANK_NUMBER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  MDM_D_DEPT.CREATE_DEPT_ID = :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
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
