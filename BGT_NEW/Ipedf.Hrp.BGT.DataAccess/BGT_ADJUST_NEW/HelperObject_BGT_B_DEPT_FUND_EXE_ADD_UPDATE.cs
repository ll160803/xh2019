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
	[CauseObject(typeof(CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE))]
	public partial class HelperObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_B_DEPT_FUND_EXE_ADD_UPDATE( IS_PERFORMANCE, ID, BUDGET_YEAR, CODE, MODIFY_DEPT_ID, BGT_D_BUDGET_ITEM_ID, ITEM_NAME, REF_TAB_ID, CREATE_USER_ID, DEPT_USER_ID, DATA_ORGANISE_ID, BUDGET_DEPT_ID, CREATE_TIME, FREE_FIELD, FREE_FIELD3, FREE_FIELD2, DECALRE_CAUSE, COMMENTS, FUND_MONEY, FINANCE_IDEA, STATE, FUND_TYPE_ID, CREATE_DEPT_ID, IS_FIXED, NAME, CONTROL_MONEY) values ( :IS_PERFORMANCE, :ID, :BUDGET_YEAR, :CODE, :MODIFY_DEPT_ID, :BGT_D_BUDGET_ITEM_ID, :ITEM_NAME, :REF_TAB_ID, :CREATE_USER_ID, :DEPT_USER_ID, :DATA_ORGANISE_ID, :BUDGET_DEPT_ID, :CREATE_TIME, :FREE_FIELD, :FREE_FIELD3, :FREE_FIELD2, :DECALRE_CAUSE, :COMMENTS, :FUND_MONEY, :FINANCE_IDEA, :STATE, :FUND_TYPE_ID, :CREATE_DEPT_ID, :IS_FIXED, :NAME, :CONTROL_MONEY)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[26];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":IS_PERFORMANCE";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.IS_PERFORMANCE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":BUDGET_YEAR";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":CODE";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":MODIFY_DEPT_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":BGT_D_BUDGET_ITEM_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.BGT_D_BUDGET_ITEM_ID == null ? String.Empty:obj.BGT_D_BUDGET_ITEM_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ITEM_NAME";
			parameters[6].Size = 200;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.ITEM_NAME == null ? String.Empty:obj.ITEM_NAME;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":REF_TAB_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.REF_TAB_ID == null ? String.Empty:obj.REF_TAB_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CREATE_USER_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":DEPT_USER_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.DEPT_USER_ID == null ? String.Empty:obj.DEPT_USER_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":DATA_ORGANISE_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":BUDGET_DEPT_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.BUDGET_DEPT_ID == null ? String.Empty:obj.BUDGET_DEPT_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":CREATE_TIME";
			parameters[12].Size = 7;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[12].Value = obj.CREATE_TIME;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":FREE_FIELD";
			parameters[13].Size = 50;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.FREE_FIELD == null ? String.Empty:obj.FREE_FIELD;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":FREE_FIELD3";
			parameters[14].Size = 10;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.FREE_FIELD3 == null ? String.Empty:obj.FREE_FIELD3;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":FREE_FIELD2";
			parameters[15].Size = 200;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.FREE_FIELD2 == null ? String.Empty:obj.FREE_FIELD2;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":DECALRE_CAUSE";
			parameters[16].Size = 2000;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[16].Value = obj.DECALRE_CAUSE == null ? String.Empty:obj.DECALRE_CAUSE;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":COMMENTS";
			parameters[17].Size = 200;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[17].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":FUND_MONEY";
			parameters[18].Size = 22;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[18].Value = obj.FUND_MONEY;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":FINANCE_IDEA";
			parameters[19].Size = 500;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.FINANCE_IDEA == null ? String.Empty:obj.FINANCE_IDEA;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":STATE";
			parameters[20].Size = 22;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[20].Value = obj.STATE;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":FUND_TYPE_ID";
			parameters[21].Size = 36;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[21].Value = obj.FUND_TYPE_ID == null ? String.Empty:obj.FUND_TYPE_ID;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":CREATE_DEPT_ID";
			parameters[22].Size = 36;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[22].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":IS_FIXED";
			parameters[23].Size = 22;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[23].Value = obj.IS_FIXED;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":NAME";
			parameters[24].Size = 100;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[24].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":CONTROL_MONEY";
			parameters[25].Size = 22;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[25].Value = obj.CONTROL_MONEY;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_DEPT_FUND_EXE_ADD_UPDATE set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_DEPT_FUND_EXE_ADD_UPDATE where  ID = :ID ";
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
		public static EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE Get(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  IS_PERFORMANCE, ID, BUDGET_YEAR, CODE, MODIFY_DEPT_ID, BGT_D_BUDGET_ITEM_ID, ITEM_NAME, REF_TAB_ID, CREATE_USER_ID, DEPT_USER_ID, DATA_ORGANISE_ID, BUDGET_DEPT_ID, CREATE_TIME, FREE_FIELD, MODIFY_USER_ID, FREE_FIELD3, FREE_FIELD2, DECALRE_CAUSE, MODIFY_TIME, COMMENTS, FUND_MONEY, FINANCE_IDEA, STATE, FUND_TYPE_ID, CREATE_DEPT_ID, IS_FIXED, NAME, CONTROL_MONEY from BGT_B_DEPT_FUND_EXE_ADD_UPDATE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ITEM_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FREE_FIELD = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(27);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] objs = new EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE Get(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  IS_PERFORMANCE, ID, BUDGET_YEAR, CODE, MODIFY_DEPT_ID, BGT_D_BUDGET_ITEM_ID, ITEM_NAME, REF_TAB_ID, CREATE_USER_ID, DEPT_USER_ID, DATA_ORGANISE_ID, BUDGET_DEPT_ID, CREATE_TIME, FREE_FIELD, MODIFY_USER_ID, FREE_FIELD3, FREE_FIELD2, DECALRE_CAUSE, MODIFY_TIME, COMMENTS, FUND_MONEY, FINANCE_IDEA, STATE, FUND_TYPE_ID, CREATE_DEPT_ID, IS_FIXED, NAME, CONTROL_MONEY from BGT_B_DEPT_FUND_EXE_ADD_UPDATE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ITEM_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FREE_FIELD = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(27);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] objs = new EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_YEAR, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CODE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BGT_D_BUDGET_ITEM_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ITEM_NAME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.REF_TAB_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DEPT_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DATA_ORGANISE_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_TIME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD3, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD2, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DECALRE_CAUSE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_TIME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.COMMENTS, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_MONEY, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FINANCE_IDEA, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_TYPE_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.NAME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CONTROL_MONEY, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE = 1 then '是' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE = 2 then '否' else '' end ) as IS_PERFORMANCE_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, BGT_D_BUDGET_ITEM_BGT_D_BUDGET.NAME as BGT_D_BUDGET_ITEM_ID_NAME, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 0 then '默认值' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 1 then '编辑中' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 2 then '已提交' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 3 then '已审核' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 4 then '已归档' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_FUND_TYPE_ID.NAME as FUND_TYPE_ID_NAME, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED = 1 then '是' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED = 2 then '否' else '' end ) as IS_FIXED_NAME from BGT_B_DEPT_FUND_EXE_ADD_UPDATE left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_BGT_D_BUDGET on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BGT_D_BUDGET_ITEM_ID = BGT_D_BUDGET_ITEM_BGT_D_BUDGET.ID left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join COM_TYPE   COM_TYPE_FUND_TYPE_ID on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_TYPE_ID = COM_TYPE_FUND_TYPE_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ITEM_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FREE_FIELD = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.IS_PERFORMANCE_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.STATE_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.FUND_TYPE_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IS_FIXED_NAME = sqlReader.GetString(34);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] objs = new DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.IS_PERFORMANCE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE = :IS_PERFORMANCE");
				param = new OracleParameter();
				param.ParameterName =":IS_PERFORMANCE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_PERFORMANCE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_PERFORMANCE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "IS_PERFORMANCE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "BUDGET_YEAR"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "MODIFY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BGT_D_BUDGET_ITEM_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BGT_D_BUDGET_ITEM_ID ").Append((cause.BGT_D_BUDGET_ITEM_ID.StartsWith("%") || cause.BGT_D_BUDGET_ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :BGT_D_BUDGET_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":BGT_D_BUDGET_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BGT_D_BUDGET_ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BGT_D_BUDGET_ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "BGT_D_BUDGET_ITEM_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ITEM_NAME))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ITEM_NAME ").Append((cause.ITEM_NAME.StartsWith("%") || cause.ITEM_NAME.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_NAME");
				param = new OracleParameter();
				param.ParameterName =":ITEM_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.ITEM_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_NAME"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "ITEM_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.REF_TAB_ID ").Append((cause.REF_TAB_ID.StartsWith("%") || cause.REF_TAB_ID.EndsWith("%")) ? " like " : " = ").Append(" :REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName =":REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_TAB_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "REF_TAB_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_USER_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DEPT_USER_ID ").Append((cause.DEPT_USER_ID.StartsWith("%") || cause.DEPT_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :DEPT_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":DEPT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "DEPT_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_DEPT_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_DEPT_ID ").Append((cause.BUDGET_DEPT_ID.StartsWith("%") || cause.BUDGET_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "BUDGET_DEPT_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD ").Append((cause.FREE_FIELD.StartsWith("%") || cause.FREE_FIELD.EndsWith("%")) ? " like " : " = ").Append(" :FREE_FIELD");
				param = new OracleParameter();
				param.ParameterName =":FREE_FIELD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FREE_FIELD;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "FREE_FIELD"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD3))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD3 ").Append((cause.FREE_FIELD3.StartsWith("%") || cause.FREE_FIELD3.EndsWith("%")) ? " like " : " = ").Append(" :FREE_FIELD3");
				param = new OracleParameter();
				param.ParameterName =":FREE_FIELD3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.FREE_FIELD3;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD3"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "FREE_FIELD3"));
			}
			if(!string.IsNullOrEmpty(cause.FREE_FIELD2))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD2 ").Append((cause.FREE_FIELD2.StartsWith("%") || cause.FREE_FIELD2.EndsWith("%")) ? " like " : " = ").Append(" :FREE_FIELD2");
				param = new OracleParameter();
				param.ParameterName =":FREE_FIELD2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.FREE_FIELD2;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREE_FIELD2"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "FREE_FIELD2"));
			}
			if(!string.IsNullOrEmpty(cause.DECALRE_CAUSE))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DECALRE_CAUSE ").Append((cause.DECALRE_CAUSE.StartsWith("%") || cause.DECALRE_CAUSE.EndsWith("%")) ? " like " : " = ").Append(" :DECALRE_CAUSE");
				param = new OracleParameter();
				param.ParameterName =":DECALRE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2000;
				param.Value = cause.DECALRE_CAUSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DECALRE_CAUSE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "DECALRE_CAUSE"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "COMMENTS"));
			}
			if(cause.FUND_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_MONEY = :FUND_MONEY");
				param = new OracleParameter();
				param.ParameterName =":FUND_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.FUND_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUND_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "FUND_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_IDEA))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FINANCE_IDEA ").Append((cause.FINANCE_IDEA.StartsWith("%") || cause.FINANCE_IDEA.EndsWith("%")) ? " like " : " = ").Append(" :FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName =":FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_IDEA"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "FINANCE_IDEA"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.FUND_TYPE_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_TYPE_ID ").Append((cause.FUND_TYPE_ID.StartsWith("%") || cause.FUND_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :FUND_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":FUND_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.FUND_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUND_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "FUND_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "CREATE_DEPT_ID"));
			}
			if(cause.IS_FIXED!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED = :IS_FIXED");
				param = new OracleParameter();
				param.ParameterName =":IS_FIXED";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_FIXED;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_FIXED"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "IS_FIXED"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "NAME"));
			}
			if(cause.CONTROL_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CONTROL_MONEY = :CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName =":CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CONTROL_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTROL_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_FUND_EXE_ADD_UPDATE", "CONTROL_MONEY"));
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
		public static DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] Query(CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_YEAR, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CODE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BGT_D_BUDGET_ITEM_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ITEM_NAME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.REF_TAB_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DEPT_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DATA_ORGANISE_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_TIME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD3, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD2, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DECALRE_CAUSE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_TIME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.COMMENTS, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_MONEY, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FINANCE_IDEA, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_TYPE_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.NAME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CONTROL_MONEY, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE = 1 then '是' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE = 2 then '否' else '' end ) as IS_PERFORMANCE_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, BGT_D_BUDGET_ITEM_BGT_D_BUDGET.NAME as BGT_D_BUDGET_ITEM_ID_NAME, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 0 then '默认值' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 1 then '编辑中' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 2 then '已提交' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 3 then '已审核' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 4 then '已归档' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_FUND_TYPE_ID.NAME as FUND_TYPE_ID_NAME, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED = 1 then '是' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED = 2 then '否' else '' end ) as IS_FIXED_NAME from BGT_B_DEPT_FUND_EXE_ADD_UPDATE left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_BGT_D_BUDGET on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BGT_D_BUDGET_ITEM_ID = BGT_D_BUDGET_ITEM_BGT_D_BUDGET.ID left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join COM_TYPE   COM_TYPE_FUND_TYPE_ID on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_TYPE_ID = COM_TYPE_FUND_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ITEM_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FREE_FIELD = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.IS_PERFORMANCE_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.STATE_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.FUND_TYPE_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IS_FIXED_NAME = sqlReader.GetString(34);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] objs = new DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_DEPT_FUND_EXE_ADD_UPDATE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] Query(CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_YEAR, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CODE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BGT_D_BUDGET_ITEM_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ITEM_NAME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.REF_TAB_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DEPT_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DATA_ORGANISE_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_TIME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD3, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD2, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DECALRE_CAUSE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_TIME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.COMMENTS, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_MONEY, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FINANCE_IDEA, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_TYPE_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.NAME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CONTROL_MONEY, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE = 1 then '是' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE = 2 then '否' else '' end ) as IS_PERFORMANCE_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, BGT_D_BUDGET_ITEM_BGT_D_BUDGET.NAME as BGT_D_BUDGET_ITEM_ID_NAME, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 0 then '默认值' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 1 then '编辑中' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 2 then '已提交' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 3 then '已审核' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 4 then '已归档' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_FUND_TYPE_ID.NAME as FUND_TYPE_ID_NAME, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED = 1 then '是' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED = 2 then '否' else '' end ) as IS_FIXED_NAME from BGT_B_DEPT_FUND_EXE_ADD_UPDATE left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_BGT_D_BUDGET on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BGT_D_BUDGET_ITEM_ID = BGT_D_BUDGET_ITEM_BGT_D_BUDGET.ID left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join COM_TYPE   COM_TYPE_FUND_TYPE_ID on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_TYPE_ID = COM_TYPE_FUND_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ITEM_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FREE_FIELD = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.IS_PERFORMANCE_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.STATE_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.FUND_TYPE_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IS_FIXED_NAME = sqlReader.GetString(34);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] objs = new DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] Query(CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_YEAR, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CODE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BGT_D_BUDGET_ITEM_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ITEM_NAME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.REF_TAB_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DEPT_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DATA_ORGANISE_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_TIME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD3, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD2, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DECALRE_CAUSE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_TIME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.COMMENTS, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_MONEY, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FINANCE_IDEA, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_TYPE_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.NAME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CONTROL_MONEY, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE = 1 then '是' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE = 2 then '否' else '' end ) as IS_PERFORMANCE_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, BGT_D_BUDGET_ITEM_BGT_D_BUDGET.NAME as BGT_D_BUDGET_ITEM_ID_NAME, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 0 then '默认值' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 1 then '编辑中' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 2 then '已提交' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 3 then '已审核' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 4 then '已归档' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_FUND_TYPE_ID.NAME as FUND_TYPE_ID_NAME, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED = 1 then '是' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED = 2 then '否' else '' end ) as IS_FIXED_NAME from BGT_B_DEPT_FUND_EXE_ADD_UPDATE left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_BGT_D_BUDGET on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BGT_D_BUDGET_ITEM_ID = BGT_D_BUDGET_ITEM_BGT_D_BUDGET.ID left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join COM_TYPE   COM_TYPE_FUND_TYPE_ID on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_TYPE_ID = COM_TYPE_FUND_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_DEPT_FUND_EXE_ADD_UPDATE",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ITEM_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FREE_FIELD = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.IS_PERFORMANCE_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.STATE_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.FUND_TYPE_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IS_FIXED_NAME = sqlReader.GetString(34);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] objs = new DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] Query(CauseObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_YEAR, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CODE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BGT_D_BUDGET_ITEM_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ITEM_NAME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.REF_TAB_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DEPT_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DATA_ORGANISE_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_TIME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_USER_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD3, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD2, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DECALRE_CAUSE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_TIME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.COMMENTS, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_MONEY, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FINANCE_IDEA, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_TYPE_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_DEPT_ID, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.NAME, BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CONTROL_MONEY, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE = 1 then '是' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE = 2 then '否' else '' end ) as IS_PERFORMANCE_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, BGT_D_BUDGET_ITEM_BGT_D_BUDGET.NAME as BGT_D_BUDGET_ITEM_ID_NAME, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 0 then '默认值' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 1 then '编辑中' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 2 then '已提交' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 3 then '已审核' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 4 then '已归档' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_FUND_TYPE_ID.NAME as FUND_TYPE_ID_NAME, (case  when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED = 1 then '是' when BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED = 2 then '否' else '' end ) as IS_FIXED_NAME from BGT_B_DEPT_FUND_EXE_ADD_UPDATE left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_BGT_D_BUDGET on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BGT_D_BUDGET_ITEM_ID = BGT_D_BUDGET_ITEM_BGT_D_BUDGET.ID left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join COM_TYPE   COM_TYPE_FUND_TYPE_ID on BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_TYPE_ID = COM_TYPE_FUND_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_DEPT_FUND_EXE_ADD_UPDATE",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_PERFORMANCE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BGT_D_BUDGET_ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ITEM_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DEPT_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FREE_FIELD = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.FREE_FIELD3 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREE_FIELD2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COMMENTS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.FUND_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.STATE = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.FUND_TYPE_ID = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.IS_FIXED = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.NAME = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.IS_PERFORMANCE_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.BGT_D_BUDGET_ITEM_ID_NAME = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.STATE_NAME = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.FUND_TYPE_ID_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.IS_FIXED_NAME = sqlReader.GetString(34);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[] objs = new DisplayObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_DEPT_FUND_EXE_ADD_UPDATE obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("IS_PERFORMANCE"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_PERFORMANCE = :IS_PERFORMANCE");
				param = new OracleParameter();
				param.ParameterName = ":IS_PERFORMANCE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_PERFORMANCE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_YEAR = :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_DEPT_ID = :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BGT_D_BUDGET_ITEM_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BGT_D_BUDGET_ITEM_ID = :BGT_D_BUDGET_ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":BGT_D_BUDGET_ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BGT_D_BUDGET_ITEM_ID) ? string.Empty : obj.BGT_D_BUDGET_ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_NAME"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.ITEM_NAME = :ITEM_NAME");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.ITEM_NAME) ? string.Empty : obj.ITEM_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.REF_TAB_ID = :REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName = ":REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_ID) ? string.Empty : obj.REF_TAB_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_USER_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DEPT_USER_ID = :DEPT_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":DEPT_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_USER_ID) ? string.Empty : obj.DEPT_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_DEPT_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.BUDGET_DEPT_ID = :BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_DEPT_ID) ? string.Empty : obj.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD = :FREE_FIELD");
				param = new OracleParameter();
				param.ParameterName = ":FREE_FIELD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD) ? string.Empty : obj.FREE_FIELD;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD3"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD3 = :FREE_FIELD3");
				param = new OracleParameter();
				param.ParameterName = ":FREE_FIELD3";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD3) ? string.Empty : obj.FREE_FIELD3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREE_FIELD2"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FREE_FIELD2 = :FREE_FIELD2");
				param = new OracleParameter();
				param.ParameterName = ":FREE_FIELD2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.FREE_FIELD2) ? string.Empty : obj.FREE_FIELD2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DECALRE_CAUSE"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.DECALRE_CAUSE = :DECALRE_CAUSE");
				param = new OracleParameter();
				param.ParameterName = ":DECALRE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2000;
				param.Value = string.IsNullOrEmpty(obj.DECALRE_CAUSE) ? string.Empty : obj.DECALRE_CAUSE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FUND_MONEY"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_MONEY = :FUND_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":FUND_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.FUND_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_IDEA"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FINANCE_IDEA = :FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName = ":FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_IDEA) ? string.Empty : obj.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FUND_TYPE_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.FUND_TYPE_ID = :FUND_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":FUND_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.FUND_TYPE_ID) ? string.Empty : obj.FUND_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CREATE_DEPT_ID = :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_FIXED"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.IS_FIXED = :IS_FIXED");
				param = new OracleParameter();
				param.ParameterName = ":IS_FIXED";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_FIXED;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONTROL_MONEY"))
			{
				strBuf.Add("  BGT_B_DEPT_FUND_EXE_ADD_UPDATE.CONTROL_MONEY = :CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CONTROL_MONEY;
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
