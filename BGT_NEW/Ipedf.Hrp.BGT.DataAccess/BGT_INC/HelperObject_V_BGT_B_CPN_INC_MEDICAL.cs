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
	[CauseObject(typeof(CauseObject_V_BGT_B_CPN_INC_MEDICAL))]
	public partial class HelperObject_V_BGT_B_CPN_INC_MEDICAL
	{		
		#region Method Blok
		public static int Save(EntityObject_V_BGT_B_CPN_INC_MEDICAL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_BGT_B_CPN_INC_MEDICAL( ITEM_NAME, PERSON_COUNT, BUDGET_YEAR_NAME, STATE_NAME, ID, PER_MONEY, STATE, MODIFY_DEPT_ID, IS_PERFORMANCE, DATA_ORGANISE_ID, MONEY, CODE, DEPT_USER_ID, IS_FIXED, CREATE_USER_ID, BUDGET_DEPT_ID, CREATE_DEPT_ID, FREE_FIELD3, FREE_FIELD2, DEPT_NAME, CREATE_TIME, NAME, BUDGET_YEAR, COM_TYPE_ID, FINANCE_IDEA, DECALRE_CAUSE, COMMENTS, CONTROL_MONEY, COM_TYPE_ID_NAME, FREE_FIELD) values ( :ITEM_NAME, :PERSON_COUNT, :BUDGET_YEAR_NAME, :STATE_NAME, :ID, :PER_MONEY, :STATE, :MODIFY_DEPT_ID, :IS_PERFORMANCE, :DATA_ORGANISE_ID, :MONEY, :CODE, :DEPT_USER_ID, :IS_FIXED, :CREATE_USER_ID, :BUDGET_DEPT_ID, :CREATE_DEPT_ID, :FREE_FIELD3, :FREE_FIELD2, :DEPT_NAME, :CREATE_TIME, :NAME, :BUDGET_YEAR, :COM_TYPE_ID, :FINANCE_IDEA, :DECALRE_CAUSE, :COMMENTS, :CONTROL_MONEY, :COM_TYPE_ID_NAME, :FREE_FIELD)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[30];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ITEM_NAME";
			parameters[0].Size = 200;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.ITEM_NAME == null ? String.Empty:obj.ITEM_NAME;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":PERSON_COUNT";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.PERSON_COUNT;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":BUDGET_YEAR_NAME";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.BUDGET_YEAR_NAME == null ? String.Empty:obj.BUDGET_YEAR_NAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":STATE_NAME";
			parameters[3].Size = 6;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.STATE_NAME == null ? String.Empty:obj.STATE_NAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":PER_MONEY";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.PER_MONEY;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":STATE";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.STATE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":MODIFY_DEPT_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":IS_PERFORMANCE";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.IS_PERFORMANCE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":DATA_ORGANISE_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":MONEY";
			parameters[10].Size = 22;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[10].Value = obj.MONEY;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":CODE";
			parameters[11].Size = 50;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":DEPT_USER_ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.DEPT_USER_ID == null ? String.Empty:obj.DEPT_USER_ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":IS_FIXED";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.IS_FIXED;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":CREATE_USER_ID";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":BUDGET_DEPT_ID";
			parameters[15].Size = 36;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[15].Value = obj.BUDGET_DEPT_ID == null ? String.Empty:obj.BUDGET_DEPT_ID;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":CREATE_DEPT_ID";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":FREE_FIELD3";
			parameters[17].Size = 10;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[17].Value = obj.FREE_FIELD3 == null ? String.Empty:obj.FREE_FIELD3;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":FREE_FIELD2";
			parameters[18].Size = 200;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.FREE_FIELD2 == null ? String.Empty:obj.FREE_FIELD2;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":DEPT_NAME";
			parameters[19].Size = 50;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.DEPT_NAME == null ? String.Empty:obj.DEPT_NAME;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":CREATE_TIME";
			parameters[20].Size = 7;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[20].Value = obj.CREATE_TIME;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":NAME";
			parameters[21].Size = 100;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[21].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":BUDGET_YEAR";
			parameters[22].Size = 36;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[22].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":COM_TYPE_ID";
			parameters[23].Size = 36;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[23].Value = obj.COM_TYPE_ID == null ? String.Empty:obj.COM_TYPE_ID;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":FINANCE_IDEA";
			parameters[24].Size = 500;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[24].Value = obj.FINANCE_IDEA == null ? String.Empty:obj.FINANCE_IDEA;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":DECALRE_CAUSE";
			parameters[25].Size = 2000;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[25].Value = obj.DECALRE_CAUSE == null ? String.Empty:obj.DECALRE_CAUSE;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":COMMENTS";
			parameters[26].Size = 200;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[26].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":CONTROL_MONEY";
			parameters[27].Size = 22;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[27].Value = obj.CONTROL_MONEY;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":COM_TYPE_ID_NAME";
			parameters[28].Size = 50;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[28].Value = obj.COM_TYPE_ID_NAME == null ? String.Empty:obj.COM_TYPE_ID_NAME;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":FREE_FIELD";
			parameters[29].Size = 50;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[29].Value = obj.FREE_FIELD == null ? String.Empty:obj.FREE_FIELD;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_BGT_B_CPN_INC_MEDICAL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_BGT_B_CPN_INC_MEDICAL set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_BGT_B_CPN_INC_MEDICAL obj,CauseObject_V_BGT_B_CPN_INC_MEDICAL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_BGT_B_CPN_INC_MEDICAL set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_BGT_B_CPN_INC_MEDICAL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_BGT_B_CPN_INC_MEDICAL where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_V_BGT_B_CPN_INC_MEDICAL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_BGT_B_CPN_INC_MEDICAL where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_BGT_B_CPN_INC_MEDICAL Get(EntityObject_V_BGT_B_CPN_INC_MEDICAL obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ITEM_NAME, PERSON_COUNT, BUDGET_YEAR_NAME, STATE_NAME, ID, PER_MONEY, STATE, MODIFY_DEPT_ID, IS_PERFORMANCE, DATA_ORGANISE_ID, MONEY, MODIFY_TIME, CODE, DEPT_USER_ID, IS_FIXED, CREATE_USER_ID, BUDGET_DEPT_ID, CREATE_DEPT_ID, FREE_FIELD3, FREE_FIELD2, DEPT_NAME, CREATE_TIME, NAME, BUDGET_YEAR, COM_TYPE_ID, MODIFY_USER_ID, FINANCE_IDEA, DECALRE_CAUSE, COMMENTS, CONTROL_MONEY, COM_TYPE_ID_NAME, FREE_FIELD from V_BGT_B_CPN_INC_MEDICAL where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_B_CPN_INC_MEDICAL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_B_CPN_INC_MEDICAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PERSON_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PER_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.DEPT_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.COM_TYPE_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.COMMENTS = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COM_TYPE_ID_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREE_FIELD = sqlReader.GetString(31);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_BGT_B_CPN_INC_MEDICAL[] objs = new EntityObject_V_BGT_B_CPN_INC_MEDICAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_BGT_B_CPN_INC_MEDICAL Get(EntityObject_V_BGT_B_CPN_INC_MEDICAL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ITEM_NAME, PERSON_COUNT, BUDGET_YEAR_NAME, STATE_NAME, ID, PER_MONEY, STATE, MODIFY_DEPT_ID, IS_PERFORMANCE, DATA_ORGANISE_ID, MONEY, MODIFY_TIME, CODE, DEPT_USER_ID, IS_FIXED, CREATE_USER_ID, BUDGET_DEPT_ID, CREATE_DEPT_ID, FREE_FIELD3, FREE_FIELD2, DEPT_NAME, CREATE_TIME, NAME, BUDGET_YEAR, COM_TYPE_ID, MODIFY_USER_ID, FINANCE_IDEA, DECALRE_CAUSE, COMMENTS, CONTROL_MONEY, COM_TYPE_ID_NAME, FREE_FIELD from V_BGT_B_CPN_INC_MEDICAL where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_B_CPN_INC_MEDICAL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_B_CPN_INC_MEDICAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PERSON_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PER_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.DEPT_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.COM_TYPE_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.COMMENTS = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COM_TYPE_ID_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREE_FIELD = sqlReader.GetString(31);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_BGT_B_CPN_INC_MEDICAL[] objs = new EntityObject_V_BGT_B_CPN_INC_MEDICAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_BGT_B_CPN_INC_MEDICAL[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_BGT_B_CPN_INC_MEDICAL.ITEM_NAME, V_BGT_B_CPN_INC_MEDICAL.PERSON_COUNT, V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR_NAME, V_BGT_B_CPN_INC_MEDICAL.STATE_NAME, V_BGT_B_CPN_INC_MEDICAL.ID, V_BGT_B_CPN_INC_MEDICAL.PER_MONEY, V_BGT_B_CPN_INC_MEDICAL.STATE, V_BGT_B_CPN_INC_MEDICAL.MODIFY_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.IS_PERFORMANCE, V_BGT_B_CPN_INC_MEDICAL.DATA_ORGANISE_ID, V_BGT_B_CPN_INC_MEDICAL.MONEY, V_BGT_B_CPN_INC_MEDICAL.MODIFY_TIME, V_BGT_B_CPN_INC_MEDICAL.CODE, V_BGT_B_CPN_INC_MEDICAL.DEPT_USER_ID, V_BGT_B_CPN_INC_MEDICAL.IS_FIXED, V_BGT_B_CPN_INC_MEDICAL.CREATE_USER_ID, V_BGT_B_CPN_INC_MEDICAL.BUDGET_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.CREATE_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD3, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD2, V_BGT_B_CPN_INC_MEDICAL.DEPT_NAME, V_BGT_B_CPN_INC_MEDICAL.CREATE_TIME, V_BGT_B_CPN_INC_MEDICAL.NAME, V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR, V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID, V_BGT_B_CPN_INC_MEDICAL.MODIFY_USER_ID, V_BGT_B_CPN_INC_MEDICAL.FINANCE_IDEA, V_BGT_B_CPN_INC_MEDICAL.DECALRE_CAUSE, V_BGT_B_CPN_INC_MEDICAL.COMMENTS, V_BGT_B_CPN_INC_MEDICAL.CONTROL_MONEY, V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID_NAME, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD from V_BGT_B_CPN_INC_MEDICAL where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_BGT_B_CPN_INC_MEDICAL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_B_CPN_INC_MEDICAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PERSON_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PER_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.DEPT_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.COM_TYPE_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.COMMENTS = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COM_TYPE_ID_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREE_FIELD = sqlReader.GetString(31);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_B_CPN_INC_MEDICAL[] objs = new DisplayObject_V_BGT_B_CPN_INC_MEDICAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_BGT_B_CPN_INC_MEDICAL cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ITEM_NAME))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.ITEM_NAME ").Append((cause.ITEM_NAME.StartsWith("%") || cause.ITEM_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ITEM_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ITEM_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.ITEM_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "ITEM_NAME"));
			}
			if(cause.PERSON_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.PERSON_COUNT = :C_PERSON_COUNT");
				param = new OracleParameter();
				param.ParameterName =":C_PERSON_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PERSON_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("PERSON_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "PERSON_COUNT"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR_NAME))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR_NAME ").Append((cause.BUDGET_YEAR_NAME.StartsWith("%") || cause.BUDGET_YEAR_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_BUDGET_YEAR_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_BUDGET_YEAR_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BUDGET_YEAR_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "BUDGET_YEAR_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.STATE_NAME))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.STATE_NAME ").Append((cause.STATE_NAME.StartsWith("%") || cause.STATE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_STATE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = cause.STATE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "STATE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "ID"));
			}
			if(cause.PER_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.PER_MONEY = :C_PER_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_PER_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PER_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("PER_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "PER_MONEY"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "MODIFY_DEPT_ID"));
			}
			if(cause.IS_PERFORMANCE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.IS_PERFORMANCE = :C_IS_PERFORMANCE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_PERFORMANCE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_PERFORMANCE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_PERFORMANCE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "IS_PERFORMANCE"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "DATA_ORGANISE_ID"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.MONEY = :C_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "MONEY"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.MODIFY_TIME < :C_MODIFY_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("MODIFY_TIME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_USER_ID))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.DEPT_USER_ID ").Append((cause.DEPT_USER_ID.StartsWith("%") || cause.DEPT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DEPT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "DEPT_USER_ID"));
			}
			if(cause.IS_FIXED!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.IS_FIXED = :C_IS_FIXED");
				param = new OracleParameter();
				param.ParameterName =":C_IS_FIXED";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_FIXED;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_FIXED"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "IS_FIXED"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_DEPT_ID))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.BUDGET_DEPT_ID ").Append((cause.BUDGET_DEPT_ID.StartsWith("%") || cause.BUDGET_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "BUDGET_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "CREATE_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD3))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD3 ").Append((cause.FREE_FIELD3.StartsWith("%") || cause.FREE_FIELD3.EndsWith("%")) ? " like " : " = ").Append(" :C_FREE_FIELD3");
				param = new OracleParameter();
				param.ParameterName =":C_FREE_FIELD3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.FREE_FIELD3;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD3"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "FREE_FIELD3"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD2))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD2 ").Append((cause.FREE_FIELD2.StartsWith("%") || cause.FREE_FIELD2.EndsWith("%")) ? " like " : " = ").Append(" :C_FREE_FIELD2");
				param = new OracleParameter();
				param.ParameterName =":C_FREE_FIELD2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.FREE_FIELD2;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD2"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "FREE_FIELD2"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_NAME))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.DEPT_NAME ").Append((cause.DEPT_NAME.StartsWith("%") || cause.DEPT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPT_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_DEPT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DEPT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "DEPT_NAME"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.CREATE_TIME < :C_CREATE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_TIME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :C_BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":C_BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "BUDGET_YEAR"));
			}
			if(!string.IsNullOrEmpty(cause.COM_TYPE_ID))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID ").Append((cause.COM_TYPE_ID.StartsWith("%") || cause.COM_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_COM_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_COM_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.COM_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("COM_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "COM_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_IDEA))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.FINANCE_IDEA ").Append((cause.FINANCE_IDEA.StartsWith("%") || cause.FINANCE_IDEA.EndsWith("%")) ? " like " : " = ").Append(" :C_FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName =":C_FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_IDEA"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "FINANCE_IDEA"));
			}
			if(!string.IsNullOrEmpty(cause.DECALRE_CAUSE))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.DECALRE_CAUSE ").Append((cause.DECALRE_CAUSE.StartsWith("%") || cause.DECALRE_CAUSE.EndsWith("%")) ? " like " : " = ").Append(" :C_DECALRE_CAUSE");
				param = new OracleParameter();
				param.ParameterName =":C_DECALRE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2000;
				param.Value = cause.DECALRE_CAUSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DECALRE_CAUSE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "DECALRE_CAUSE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "COMMENTS"));
			}
			if(cause.CONTROL_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.CONTROL_MONEY = :C_CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName =":C_CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CONTROL_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTROL_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "CONTROL_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.COM_TYPE_ID_NAME))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID_NAME ").Append((cause.COM_TYPE_ID_NAME.StartsWith("%") || cause.COM_TYPE_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_COM_TYPE_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_COM_TYPE_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.COM_TYPE_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("COM_TYPE_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "COM_TYPE_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD ").Append((cause.FREE_FIELD.StartsWith("%") || cause.FREE_FIELD.EndsWith("%")) ? " like " : " = ").Append(" :C_FREE_FIELD");
				param = new OracleParameter();
				param.ParameterName =":C_FREE_FIELD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FREE_FIELD;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_MEDICAL", "FREE_FIELD"));
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
		public static DisplayObject_V_BGT_B_CPN_INC_MEDICAL[] Query(CauseObject_V_BGT_B_CPN_INC_MEDICAL cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_B_CPN_INC_MEDICAL.ITEM_NAME, V_BGT_B_CPN_INC_MEDICAL.PERSON_COUNT, V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR_NAME, V_BGT_B_CPN_INC_MEDICAL.STATE_NAME, V_BGT_B_CPN_INC_MEDICAL.ID, V_BGT_B_CPN_INC_MEDICAL.PER_MONEY, V_BGT_B_CPN_INC_MEDICAL.STATE, V_BGT_B_CPN_INC_MEDICAL.MODIFY_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.IS_PERFORMANCE, V_BGT_B_CPN_INC_MEDICAL.DATA_ORGANISE_ID, V_BGT_B_CPN_INC_MEDICAL.MONEY, V_BGT_B_CPN_INC_MEDICAL.MODIFY_TIME, V_BGT_B_CPN_INC_MEDICAL.CODE, V_BGT_B_CPN_INC_MEDICAL.DEPT_USER_ID, V_BGT_B_CPN_INC_MEDICAL.IS_FIXED, V_BGT_B_CPN_INC_MEDICAL.CREATE_USER_ID, V_BGT_B_CPN_INC_MEDICAL.BUDGET_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.CREATE_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD3, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD2, V_BGT_B_CPN_INC_MEDICAL.DEPT_NAME, V_BGT_B_CPN_INC_MEDICAL.CREATE_TIME, V_BGT_B_CPN_INC_MEDICAL.NAME, V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR, V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID, V_BGT_B_CPN_INC_MEDICAL.MODIFY_USER_ID, V_BGT_B_CPN_INC_MEDICAL.FINANCE_IDEA, V_BGT_B_CPN_INC_MEDICAL.DECALRE_CAUSE, V_BGT_B_CPN_INC_MEDICAL.COMMENTS, V_BGT_B_CPN_INC_MEDICAL.CONTROL_MONEY, V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID_NAME, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD from V_BGT_B_CPN_INC_MEDICAL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_B_CPN_INC_MEDICAL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_B_CPN_INC_MEDICAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PERSON_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PER_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.DEPT_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.COM_TYPE_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.COMMENTS = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COM_TYPE_ID_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREE_FIELD = sqlReader.GetString(31);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_B_CPN_INC_MEDICAL[] objs = new DisplayObject_V_BGT_B_CPN_INC_MEDICAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_V_BGT_B_CPN_INC_MEDICAL[] Query(CauseObject_V_BGT_B_CPN_INC_MEDICAL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_B_CPN_INC_MEDICAL.ITEM_NAME, V_BGT_B_CPN_INC_MEDICAL.PERSON_COUNT, V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR_NAME, V_BGT_B_CPN_INC_MEDICAL.STATE_NAME, V_BGT_B_CPN_INC_MEDICAL.ID, V_BGT_B_CPN_INC_MEDICAL.PER_MONEY, V_BGT_B_CPN_INC_MEDICAL.STATE, V_BGT_B_CPN_INC_MEDICAL.MODIFY_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.IS_PERFORMANCE, V_BGT_B_CPN_INC_MEDICAL.DATA_ORGANISE_ID, V_BGT_B_CPN_INC_MEDICAL.MONEY, V_BGT_B_CPN_INC_MEDICAL.MODIFY_TIME, V_BGT_B_CPN_INC_MEDICAL.CODE, V_BGT_B_CPN_INC_MEDICAL.DEPT_USER_ID, V_BGT_B_CPN_INC_MEDICAL.IS_FIXED, V_BGT_B_CPN_INC_MEDICAL.CREATE_USER_ID, V_BGT_B_CPN_INC_MEDICAL.BUDGET_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.CREATE_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD3, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD2, V_BGT_B_CPN_INC_MEDICAL.DEPT_NAME, V_BGT_B_CPN_INC_MEDICAL.CREATE_TIME, V_BGT_B_CPN_INC_MEDICAL.NAME, V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR, V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID, V_BGT_B_CPN_INC_MEDICAL.MODIFY_USER_ID, V_BGT_B_CPN_INC_MEDICAL.FINANCE_IDEA, V_BGT_B_CPN_INC_MEDICAL.DECALRE_CAUSE, V_BGT_B_CPN_INC_MEDICAL.COMMENTS, V_BGT_B_CPN_INC_MEDICAL.CONTROL_MONEY, V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID_NAME, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD from V_BGT_B_CPN_INC_MEDICAL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_B_CPN_INC_MEDICAL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_B_CPN_INC_MEDICAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PERSON_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PER_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.DEPT_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.COM_TYPE_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.COMMENTS = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COM_TYPE_ID_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREE_FIELD = sqlReader.GetString(31);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_B_CPN_INC_MEDICAL[] objs = new DisplayObject_V_BGT_B_CPN_INC_MEDICAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_B_CPN_INC_MEDICAL[] Query(CauseObject_V_BGT_B_CPN_INC_MEDICAL cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_B_CPN_INC_MEDICAL.ITEM_NAME, V_BGT_B_CPN_INC_MEDICAL.PERSON_COUNT, V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR_NAME, V_BGT_B_CPN_INC_MEDICAL.STATE_NAME, V_BGT_B_CPN_INC_MEDICAL.ID, V_BGT_B_CPN_INC_MEDICAL.PER_MONEY, V_BGT_B_CPN_INC_MEDICAL.STATE, V_BGT_B_CPN_INC_MEDICAL.MODIFY_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.IS_PERFORMANCE, V_BGT_B_CPN_INC_MEDICAL.DATA_ORGANISE_ID, V_BGT_B_CPN_INC_MEDICAL.MONEY, V_BGT_B_CPN_INC_MEDICAL.MODIFY_TIME, V_BGT_B_CPN_INC_MEDICAL.CODE, V_BGT_B_CPN_INC_MEDICAL.DEPT_USER_ID, V_BGT_B_CPN_INC_MEDICAL.IS_FIXED, V_BGT_B_CPN_INC_MEDICAL.CREATE_USER_ID, V_BGT_B_CPN_INC_MEDICAL.BUDGET_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.CREATE_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD3, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD2, V_BGT_B_CPN_INC_MEDICAL.DEPT_NAME, V_BGT_B_CPN_INC_MEDICAL.CREATE_TIME, V_BGT_B_CPN_INC_MEDICAL.NAME, V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR, V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID, V_BGT_B_CPN_INC_MEDICAL.MODIFY_USER_ID, V_BGT_B_CPN_INC_MEDICAL.FINANCE_IDEA, V_BGT_B_CPN_INC_MEDICAL.DECALRE_CAUSE, V_BGT_B_CPN_INC_MEDICAL.COMMENTS, V_BGT_B_CPN_INC_MEDICAL.CONTROL_MONEY, V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID_NAME, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD from V_BGT_B_CPN_INC_MEDICAL where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_B_CPN_INC_MEDICAL",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_BGT_B_CPN_INC_MEDICAL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_B_CPN_INC_MEDICAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PERSON_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PER_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.DEPT_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.COM_TYPE_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.COMMENTS = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COM_TYPE_ID_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREE_FIELD = sqlReader.GetString(31);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_B_CPN_INC_MEDICAL[] objs = new DisplayObject_V_BGT_B_CPN_INC_MEDICAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_B_CPN_INC_MEDICAL[] Query(CauseObject_V_BGT_B_CPN_INC_MEDICAL cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_B_CPN_INC_MEDICAL.ITEM_NAME, V_BGT_B_CPN_INC_MEDICAL.PERSON_COUNT, V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR_NAME, V_BGT_B_CPN_INC_MEDICAL.STATE_NAME, V_BGT_B_CPN_INC_MEDICAL.ID, V_BGT_B_CPN_INC_MEDICAL.PER_MONEY, V_BGT_B_CPN_INC_MEDICAL.STATE, V_BGT_B_CPN_INC_MEDICAL.MODIFY_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.IS_PERFORMANCE, V_BGT_B_CPN_INC_MEDICAL.DATA_ORGANISE_ID, V_BGT_B_CPN_INC_MEDICAL.MONEY, V_BGT_B_CPN_INC_MEDICAL.MODIFY_TIME, V_BGT_B_CPN_INC_MEDICAL.CODE, V_BGT_B_CPN_INC_MEDICAL.DEPT_USER_ID, V_BGT_B_CPN_INC_MEDICAL.IS_FIXED, V_BGT_B_CPN_INC_MEDICAL.CREATE_USER_ID, V_BGT_B_CPN_INC_MEDICAL.BUDGET_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.CREATE_DEPT_ID, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD3, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD2, V_BGT_B_CPN_INC_MEDICAL.DEPT_NAME, V_BGT_B_CPN_INC_MEDICAL.CREATE_TIME, V_BGT_B_CPN_INC_MEDICAL.NAME, V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR, V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID, V_BGT_B_CPN_INC_MEDICAL.MODIFY_USER_ID, V_BGT_B_CPN_INC_MEDICAL.FINANCE_IDEA, V_BGT_B_CPN_INC_MEDICAL.DECALRE_CAUSE, V_BGT_B_CPN_INC_MEDICAL.COMMENTS, V_BGT_B_CPN_INC_MEDICAL.CONTROL_MONEY, V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID_NAME, V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD from V_BGT_B_CPN_INC_MEDICAL where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_B_CPN_INC_MEDICAL",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_BGT_B_CPN_INC_MEDICAL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_B_CPN_INC_MEDICAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ITEM_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PERSON_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PER_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.DEPT_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.COM_TYPE_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.COMMENTS = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COM_TYPE_ID_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.FREE_FIELD = sqlReader.GetString(31);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_B_CPN_INC_MEDICAL[] objs = new DisplayObject_V_BGT_B_CPN_INC_MEDICAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_BGT_B_CPN_INC_MEDICAL obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ITEM_NAME"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.ITEM_NAME = :U_ITEM_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_ITEM_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.ITEM_NAME) ? string.Empty : obj.ITEM_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PERSON_COUNT"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.PERSON_COUNT = :U_PERSON_COUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_PERSON_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PERSON_COUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR_NAME"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR_NAME = :U_BUDGET_YEAR_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_BUDGET_YEAR_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR_NAME) ? string.Empty : obj.BUDGET_YEAR_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE_NAME"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.STATE_NAME = :U_STATE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = string.IsNullOrEmpty(obj.STATE_NAME) ? string.Empty : obj.STATE_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.ID = :U_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PER_MONEY"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.PER_MONEY = :U_PER_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_PER_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PER_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.MODIFY_DEPT_ID = :U_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_PERFORMANCE"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.IS_PERFORMANCE = :U_IS_PERFORMANCE");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_PERFORMANCE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_PERFORMANCE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.MONEY = :U_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_USER_ID"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.DEPT_USER_ID = :U_DEPT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_USER_ID) ? string.Empty : obj.DEPT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_FIXED"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.IS_FIXED = :U_IS_FIXED");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_FIXED";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_FIXED;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_DEPT_ID"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.BUDGET_DEPT_ID = :U_BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_DEPT_ID) ? string.Empty : obj.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.CREATE_DEPT_ID = :U_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD3"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD3 = :U_FREE_FIELD3");
				param = new OracleParameter();
				param.ParameterName = ":U_FREE_FIELD3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD3) ? string.Empty : obj.FREE_FIELD3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD2"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD2 = :U_FREE_FIELD2");
				param = new OracleParameter();
				param.ParameterName = ":U_FREE_FIELD2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD2) ? string.Empty : obj.FREE_FIELD2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_NAME"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.DEPT_NAME = :U_DEPT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.DEPT_NAME) ? string.Empty : obj.DEPT_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.BUDGET_YEAR = :U_BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":U_BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COM_TYPE_ID"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID = :U_COM_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_COM_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.COM_TYPE_ID) ? string.Empty : obj.COM_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_IDEA"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.FINANCE_IDEA = :U_FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName = ":U_FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_IDEA) ? string.Empty : obj.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DECALRE_CAUSE"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.DECALRE_CAUSE = :U_DECALRE_CAUSE");
				param = new OracleParameter();
				param.ParameterName = ":U_DECALRE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2000;
				param.Value = string.IsNullOrEmpty(obj.DECALRE_CAUSE) ? string.Empty : obj.DECALRE_CAUSE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONTROL_MONEY"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.CONTROL_MONEY = :U_CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":U_CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CONTROL_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COM_TYPE_ID_NAME"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.COM_TYPE_ID_NAME = :U_COM_TYPE_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_COM_TYPE_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.COM_TYPE_ID_NAME) ? string.Empty : obj.COM_TYPE_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_MEDICAL.FREE_FIELD = :U_FREE_FIELD");
				param = new OracleParameter();
				param.ParameterName = ":U_FREE_FIELD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD) ? string.Empty : obj.FREE_FIELD;
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


        public static decimal[] QuerySUM(CauseObject_V_BGT_B_CPN_INC_MEDICAL cause)
        {
            List<decimal> list = new List<decimal>();

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select sum(MONEY), sum(PERSON_COUNT), case when sum(PERSON_COUNT) = 0 then 0 else  round(sum(MONEY)/sum(PERSON_COUNT), 2)  end  FROM V_BGT_B_CPN_INC_MEDICAL where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            #region Push Block

            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                if (!sqlReader.IsDBNull(0))
                {
                    decimal money = sqlReader.GetDecimal(0);
                    list.Add(money);
                }

                if (!sqlReader.IsDBNull(1))
                {
                    decimal count = sqlReader.GetDecimal(1);
                    list.Add(count);
                }

                if (!sqlReader.IsDBNull(2))
                {
                    decimal per_money = sqlReader.GetDecimal(2);
                    list.Add(per_money);
                }

            }
            sqlReader.Close();

            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            return list.ToArray();
        }
        #endregion
    }
}
