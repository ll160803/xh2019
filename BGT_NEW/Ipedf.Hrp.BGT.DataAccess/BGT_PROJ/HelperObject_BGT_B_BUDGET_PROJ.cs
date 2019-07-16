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
	[CauseObject(typeof(CauseObject_BGT_B_BUDGET_PROJ))]
	public partial class HelperObject_BGT_B_BUDGET_PROJ
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_BUDGET_PROJ obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_B_BUDGET_PROJ( EXECUTED_MONEY, PROJ_USER_ID, ID, FINANCE_USER_ID, CREATE_USER_ID, STATE, NATURE_ID, MODIFY_DEPT_ID, BACKDROP, DATA_ORGANISE_ID, CODE, ADJUST_MONEY, IS_GOV_PROC, APPLY_MONEY, PLAN_BEGIN_DATE, BUDGET_DEPT_ID, PLAN_END_DATE, CREATE_DEPT_ID, AVAILABLE_MONEY, REPLY_DATE, APPLIED_MONEY, CREATE_TIME, REPLY_MONEY, PURPOSE, BIZ_STATE, APPLY_USER_ID, BUDGET_YEAR, TYPE_ID, COMMENTS, NAME, APPLY_DATE, REPLY_USER_ID) values ( :EXECUTED_MONEY, :PROJ_USER_ID, :ID, :FINANCE_USER_ID, :CREATE_USER_ID, :STATE, :NATURE_ID, :MODIFY_DEPT_ID, :BACKDROP, :DATA_ORGANISE_ID, :CODE, :ADJUST_MONEY, :IS_GOV_PROC, :APPLY_MONEY, :PLAN_BEGIN_DATE, :BUDGET_DEPT_ID, :PLAN_END_DATE, :CREATE_DEPT_ID, :AVAILABLE_MONEY, :REPLY_DATE, :APPLIED_MONEY, :CREATE_TIME, :REPLY_MONEY, :PURPOSE, :BIZ_STATE, :APPLY_USER_ID, :BUDGET_YEAR, :TYPE_ID, :COMMENTS, :NAME, :APPLY_DATE, :REPLY_USER_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[32];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":EXECUTED_MONEY";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.EXECUTED_MONEY;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":PROJ_USER_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.PROJ_USER_ID == null ? String.Empty:obj.PROJ_USER_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":FINANCE_USER_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.FINANCE_USER_ID == null ? String.Empty:obj.FINANCE_USER_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":CREATE_USER_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":STATE";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.STATE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":NATURE_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.NATURE_ID == null ? String.Empty:obj.NATURE_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":MODIFY_DEPT_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":BACKDROP";
			parameters[8].Size = 50;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.BACKDROP == null ? String.Empty:obj.BACKDROP;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":DATA_ORGANISE_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":CODE";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":ADJUST_MONEY";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.ADJUST_MONEY;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":IS_GOV_PROC";
			parameters[12].Size = 22;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[12].Value = obj.IS_GOV_PROC;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":APPLY_MONEY";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.APPLY_MONEY;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":PLAN_BEGIN_DATE";
			parameters[14].Size = 7;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[14].Value = obj.PLAN_BEGIN_DATE;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":BUDGET_DEPT_ID";
			parameters[15].Size = 36;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[15].Value = obj.BUDGET_DEPT_ID == null ? String.Empty:obj.BUDGET_DEPT_ID;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":PLAN_END_DATE";
			parameters[16].Size = 7;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[16].Value = obj.PLAN_END_DATE;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":CREATE_DEPT_ID";
			parameters[17].Size = 36;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[17].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":AVAILABLE_MONEY";
			parameters[18].Size = 22;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[18].Value = obj.AVAILABLE_MONEY;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":REPLY_DATE";
			parameters[19].Size = 7;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[19].Value = obj.REPLY_DATE;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":APPLIED_MONEY";
			parameters[20].Size = 22;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[20].Value = obj.APPLIED_MONEY;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":CREATE_TIME";
			parameters[21].Size = 7;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[21].Value = obj.CREATE_TIME;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":REPLY_MONEY";
			parameters[22].Size = 22;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[22].Value = obj.REPLY_MONEY;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":PURPOSE";
			parameters[23].Size = 50;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[23].Value = obj.PURPOSE == null ? String.Empty:obj.PURPOSE;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":BIZ_STATE";
			parameters[24].Size = 36;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[24].Value = obj.BIZ_STATE == null ? String.Empty:obj.BIZ_STATE;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":APPLY_USER_ID";
			parameters[25].Size = 36;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[25].Value = obj.APPLY_USER_ID == null ? String.Empty:obj.APPLY_USER_ID;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":BUDGET_YEAR";
			parameters[26].Size = 36;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[26].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":TYPE_ID";
			parameters[27].Size = 36;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[27].Value = obj.TYPE_ID == null ? String.Empty:obj.TYPE_ID;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":COMMENTS";
			parameters[28].Size = 200;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[28].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":NAME";
			parameters[29].Size = 50;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[29].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[30] = new OracleParameter();
			parameters[30].ParameterName =":APPLY_DATE";
			parameters[30].Size = 7;
			parameters[30].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[30].Value = obj.APPLY_DATE;
			parameters[31] = new OracleParameter();
			parameters[31].ParameterName =":REPLY_USER_ID";
			parameters[31].Size = 36;
			parameters[31].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[31].Value = obj.REPLY_USER_ID == null ? String.Empty:obj.REPLY_USER_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_BUDGET_PROJ obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_BUDGET_PROJ set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_BUDGET_PROJ obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_BUDGET_PROJ where  ID = :ID ";
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
		public static EntityObject_BGT_B_BUDGET_PROJ Get(EntityObject_BGT_B_BUDGET_PROJ obj)
		{
			
			//平台自动生成代码
			string sSql = "select  EXECUTED_MONEY, PROJ_USER_ID, ID, FINANCE_USER_ID, CREATE_USER_ID, STATE, NATURE_ID, MODIFY_DEPT_ID, BACKDROP, DATA_ORGANISE_ID, MODIFY_TIME, CODE, ADJUST_MONEY, IS_GOV_PROC, APPLY_MONEY, PLAN_BEGIN_DATE, BUDGET_DEPT_ID, PLAN_END_DATE, CREATE_DEPT_ID, AVAILABLE_MONEY, REPLY_DATE, APPLIED_MONEY, CREATE_TIME, REPLY_MONEY, PURPOSE, BIZ_STATE, MODIFY_USER_ID, APPLY_USER_ID, BUDGET_YEAR, TYPE_ID, COMMENTS, NAME, APPLY_DATE, REPLY_USER_ID from BGT_B_BUDGET_PROJ where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_BUDGET_PROJ dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_BUDGET_PROJ();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROJ_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NATURE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BACKDROP = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PLAN_BEGIN_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PLAN_END_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.REPLY_DATE = sqlReader.GetDateTime(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURPOSE = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.BIZ_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.REPLY_USER_ID = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_BUDGET_PROJ[] objs = new EntityObject_BGT_B_BUDGET_PROJ[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_BUDGET_PROJ Get(EntityObject_BGT_B_BUDGET_PROJ obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  EXECUTED_MONEY, PROJ_USER_ID, ID, FINANCE_USER_ID, CREATE_USER_ID, STATE, NATURE_ID, MODIFY_DEPT_ID, BACKDROP, DATA_ORGANISE_ID, MODIFY_TIME, CODE, ADJUST_MONEY, IS_GOV_PROC, APPLY_MONEY, PLAN_BEGIN_DATE, BUDGET_DEPT_ID, PLAN_END_DATE, CREATE_DEPT_ID, AVAILABLE_MONEY, REPLY_DATE, APPLIED_MONEY, CREATE_TIME, REPLY_MONEY, PURPOSE, BIZ_STATE, MODIFY_USER_ID, APPLY_USER_ID, BUDGET_YEAR, TYPE_ID, COMMENTS, NAME, APPLY_DATE, REPLY_USER_ID from BGT_B_BUDGET_PROJ where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_BUDGET_PROJ dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_BUDGET_PROJ();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROJ_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NATURE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BACKDROP = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PLAN_BEGIN_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PLAN_END_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.REPLY_DATE = sqlReader.GetDateTime(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURPOSE = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.BIZ_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.REPLY_USER_ID = sqlReader.GetString(33);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_BUDGET_PROJ[] objs = new EntityObject_BGT_B_BUDGET_PROJ[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_BUDGET_PROJ[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_BUDGET_PROJ.EXECUTED_MONEY, BGT_B_BUDGET_PROJ.PROJ_USER_ID, BGT_B_BUDGET_PROJ.ID, BGT_B_BUDGET_PROJ.FINANCE_USER_ID, BGT_B_BUDGET_PROJ.CREATE_USER_ID, BGT_B_BUDGET_PROJ.STATE, BGT_B_BUDGET_PROJ.NATURE_ID, BGT_B_BUDGET_PROJ.MODIFY_DEPT_ID, BGT_B_BUDGET_PROJ.BACKDROP, BGT_B_BUDGET_PROJ.DATA_ORGANISE_ID, BGT_B_BUDGET_PROJ.MODIFY_TIME, BGT_B_BUDGET_PROJ.CODE, BGT_B_BUDGET_PROJ.ADJUST_MONEY, BGT_B_BUDGET_PROJ.IS_GOV_PROC, BGT_B_BUDGET_PROJ.APPLY_MONEY, BGT_B_BUDGET_PROJ.PLAN_BEGIN_DATE, BGT_B_BUDGET_PROJ.BUDGET_DEPT_ID, BGT_B_BUDGET_PROJ.PLAN_END_DATE, BGT_B_BUDGET_PROJ.CREATE_DEPT_ID, BGT_B_BUDGET_PROJ.AVAILABLE_MONEY, BGT_B_BUDGET_PROJ.REPLY_DATE, BGT_B_BUDGET_PROJ.APPLIED_MONEY, BGT_B_BUDGET_PROJ.CREATE_TIME, BGT_B_BUDGET_PROJ.REPLY_MONEY, BGT_B_BUDGET_PROJ.PURPOSE, BGT_B_BUDGET_PROJ.BIZ_STATE, BGT_B_BUDGET_PROJ.MODIFY_USER_ID, BGT_B_BUDGET_PROJ.APPLY_USER_ID, BGT_B_BUDGET_PROJ.BUDGET_YEAR, BGT_B_BUDGET_PROJ.TYPE_ID, BGT_B_BUDGET_PROJ.COMMENTS, BGT_B_BUDGET_PROJ.NAME, BGT_B_BUDGET_PROJ.APPLY_DATE, BGT_B_BUDGET_PROJ.REPLY_USER_ID, COM_USER_PROJ_USER_ID.NAME as PROJ_USER_ID_NAME, COM_USER_FINANCE_USER_ID.NAME as FINANCE_USER_ID_NAME, (case  when BGT_B_BUDGET_PROJ.STATE = 0 then '默认值' when BGT_B_BUDGET_PROJ.STATE = 1 then '编辑中' when BGT_B_BUDGET_PROJ.STATE = 2 then '已提交' when BGT_B_BUDGET_PROJ.STATE = 3 then '已审核' when BGT_B_BUDGET_PROJ.STATE = 4 then '已归档' when BGT_B_BUDGET_PROJ.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_NATURE_ID.NAME as NATURE_ID_NAME, (case  when BGT_B_BUDGET_PROJ.IS_GOV_PROC = 1 then '是' when BGT_B_BUDGET_PROJ.IS_GOV_PROC = 2 then '否' else '' end ) as IS_GOV_PROC_NAME, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, COM_TYPE_BIZ_STATE.NAME as BIZ_STATE_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_USER_REPLY_USER_ID.NAME as REPLY_USER_ID_NAME from BGT_B_BUDGET_PROJ left join COM_USER   COM_USER_PROJ_USER_ID on BGT_B_BUDGET_PROJ.PROJ_USER_ID = COM_USER_PROJ_USER_ID.ID left join COM_USER   COM_USER_FINANCE_USER_ID on BGT_B_BUDGET_PROJ.FINANCE_USER_ID = COM_USER_FINANCE_USER_ID.ID left join COM_TYPE   COM_TYPE_NATURE_ID on BGT_B_BUDGET_PROJ.NATURE_ID = COM_TYPE_NATURE_ID.ID left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_BUDGET_PROJ.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join COM_TYPE   COM_TYPE_BIZ_STATE on BGT_B_BUDGET_PROJ.BIZ_STATE = COM_TYPE_BIZ_STATE.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_BUDGET_PROJ.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_BUDGET_PROJ.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_TYPE_ID on BGT_B_BUDGET_PROJ.TYPE_ID = COM_TYPE_TYPE_ID.ID left join COM_USER   COM_USER_REPLY_USER_ID on BGT_B_BUDGET_PROJ.REPLY_USER_ID = COM_USER_REPLY_USER_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_BUDGET_PROJ dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROJ_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NATURE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BACKDROP = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PLAN_BEGIN_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PLAN_END_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.REPLY_DATE = sqlReader.GetDateTime(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURPOSE = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.BIZ_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.REPLY_USER_ID = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.PROJ_USER_ID_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FINANCE_USER_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.NATURE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_GOV_PROC_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.BIZ_STATE_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.REPLY_USER_ID_NAME = sqlReader.GetString(44);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ[] objs = new DisplayObject_BGT_B_BUDGET_PROJ[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_BUDGET_PROJ cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.EXECUTED_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.EXECUTED_MONEY = :EXECUTED_MONEY");
				param = new OracleParameter();
				param.ParameterName =":EXECUTED_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.EXECUTED_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("EXECUTED_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "EXECUTED_MONEY"));
			}
			if(cause.PROJ_USER_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.PROJ_USER_ID ").Append((cause.PROJ_USER_ID.StartsWith("%") || cause.PROJ_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :PROJ_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":PROJ_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PROJ_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PROJ_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "PROJ_USER_ID"));
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "ID"));
			}
			if(cause.FINANCE_USER_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.FINANCE_USER_ID ").Append((cause.FINANCE_USER_ID.StartsWith("%") || cause.FINANCE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :FINANCE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":FINANCE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.FINANCE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "FINANCE_USER_ID"));
			}
			if(cause.CREATE_USER_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "CREATE_USER_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "STATE"));
			}
			if(cause.NATURE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.NATURE_ID ").Append((cause.NATURE_ID.StartsWith("%") || cause.NATURE_ID.EndsWith("%")) ? " like " : " = ").Append(" :NATURE_ID");
				param = new OracleParameter();
				param.ParameterName =":NATURE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.NATURE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("NATURE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "NATURE_ID"));
			}
			if(cause.MODIFY_DEPT_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "MODIFY_DEPT_ID"));
			}
			if(cause.BACKDROP!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.BACKDROP ").Append((cause.BACKDROP.StartsWith("%") || cause.BACKDROP.EndsWith("%")) ? " like " : " = ").Append(" :BACKDROP");
				param = new OracleParameter();
				param.ParameterName =":BACKDROP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BACKDROP;
				paramList.Add(param);
			}
			if (cause.HasINValue("BACKDROP"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "BACKDROP"));
			}
			if(cause.DATA_ORGANISE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "DATA_ORGANISE_ID"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "MODIFY_TIME"));
			}
			if(cause.CODE!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "CODE"));
			}
			if(cause.ADJUST_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.ADJUST_MONEY = :ADJUST_MONEY");
				param = new OracleParameter();
				param.ParameterName =":ADJUST_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ADJUST_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADJUST_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "ADJUST_MONEY"));
			}
			if(cause.IS_GOV_PROC!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.IS_GOV_PROC = :IS_GOV_PROC");
				param = new OracleParameter();
				param.ParameterName =":IS_GOV_PROC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_GOV_PROC;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_GOV_PROC"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "IS_GOV_PROC"));
			}
			if(cause.APPLY_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.APPLY_MONEY = :APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName =":APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLY_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "APPLY_MONEY"));
			}
			if(cause.PLAN_BEGIN_DATE!= null)
			{
				if (cause.PLAN_BEGIN_DATE.Begin != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ.PLAN_BEGIN_DATE >= :PLAN_BEGIN_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":PLAN_BEGIN_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PLAN_BEGIN_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PLAN_BEGIN_DATE.End != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ.PLAN_BEGIN_DATE < :PLAN_BEGIN_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":PLAN_BEGIN_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PLAN_BEGIN_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("PLAN_BEGIN_DATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "PLAN_BEGIN_DATE"));
			}
			if(cause.BUDGET_DEPT_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.BUDGET_DEPT_ID ").Append((cause.BUDGET_DEPT_ID.StartsWith("%") || cause.BUDGET_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "BUDGET_DEPT_ID"));
			}
			if(cause.PLAN_END_DATE!= null)
			{
				if (cause.PLAN_END_DATE.Begin != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ.PLAN_END_DATE >= :PLAN_END_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":PLAN_END_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PLAN_END_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PLAN_END_DATE.End != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ.PLAN_END_DATE < :PLAN_END_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":PLAN_END_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PLAN_END_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("PLAN_END_DATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "PLAN_END_DATE"));
			}
			if(cause.CREATE_DEPT_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "CREATE_DEPT_ID"));
			}
			if(cause.AVAILABLE_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.AVAILABLE_MONEY = :AVAILABLE_MONEY");
				param = new OracleParameter();
				param.ParameterName =":AVAILABLE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AVAILABLE_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("AVAILABLE_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "AVAILABLE_MONEY"));
			}
			if(cause.REPLY_DATE!= null)
			{
				if (cause.REPLY_DATE.Begin != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ.REPLY_DATE >= :REPLY_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":REPLY_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.REPLY_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.REPLY_DATE.End != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ.REPLY_DATE < :REPLY_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":REPLY_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.REPLY_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("REPLY_DATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "REPLY_DATE"));
			}
			if(cause.APPLIED_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.APPLIED_MONEY = :APPLIED_MONEY");
				param = new OracleParameter();
				param.ParameterName =":APPLIED_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLIED_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLIED_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "APPLIED_MONEY"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "CREATE_TIME"));
			}
			if(cause.REPLY_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.REPLY_MONEY = :REPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName =":REPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REPLY_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("REPLY_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "REPLY_MONEY"));
			}
			if(cause.PURPOSE!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.PURPOSE ").Append((cause.PURPOSE.StartsWith("%") || cause.PURPOSE.EndsWith("%")) ? " like " : " = ").Append(" :PURPOSE");
				param = new OracleParameter();
				param.ParameterName =":PURPOSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PURPOSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PURPOSE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "PURPOSE"));
			}
			if(cause.BIZ_STATE!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.BIZ_STATE ").Append((cause.BIZ_STATE.StartsWith("%") || cause.BIZ_STATE.EndsWith("%")) ? " like " : " = ").Append(" :BIZ_STATE");
				param = new OracleParameter();
				param.ParameterName =":BIZ_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BIZ_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("BIZ_STATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "BIZ_STATE"));
			}
			if(cause.MODIFY_USER_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "MODIFY_USER_ID"));
			}
			if(cause.APPLY_USER_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.APPLY_USER_ID ").Append((cause.APPLY_USER_ID.StartsWith("%") || cause.APPLY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "APPLY_USER_ID"));
			}
			if(cause.BUDGET_YEAR!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "BUDGET_YEAR"));
			}
			if(cause.TYPE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.TYPE_ID ").Append((cause.TYPE_ID.StartsWith("%") || cause.TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "TYPE_ID"));
			}
			if(cause.COMMENTS!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "COMMENTS"));
			}
			if(cause.NAME!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "NAME"));
			}
			if(cause.APPLY_DATE!= null)
			{
				if (cause.APPLY_DATE.Begin != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ.APPLY_DATE >= :APPLY_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":APPLY_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.APPLY_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.APPLY_DATE.End != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ.APPLY_DATE < :APPLY_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":APPLY_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.APPLY_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("APPLY_DATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "APPLY_DATE"));
			}
			if(cause.REPLY_USER_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ.REPLY_USER_ID ").Append((cause.REPLY_USER_ID.StartsWith("%") || cause.REPLY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :REPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":REPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REPLY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REPLY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ", "REPLY_USER_ID"));
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
		public static DisplayObject_BGT_B_BUDGET_PROJ[] Query(CauseObject_BGT_B_BUDGET_PROJ cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_PROJ.EXECUTED_MONEY, BGT_B_BUDGET_PROJ.PROJ_USER_ID, BGT_B_BUDGET_PROJ.ID, BGT_B_BUDGET_PROJ.FINANCE_USER_ID, BGT_B_BUDGET_PROJ.CREATE_USER_ID, BGT_B_BUDGET_PROJ.STATE, BGT_B_BUDGET_PROJ.NATURE_ID, BGT_B_BUDGET_PROJ.MODIFY_DEPT_ID, BGT_B_BUDGET_PROJ.BACKDROP, BGT_B_BUDGET_PROJ.DATA_ORGANISE_ID, BGT_B_BUDGET_PROJ.MODIFY_TIME, BGT_B_BUDGET_PROJ.CODE, BGT_B_BUDGET_PROJ.ADJUST_MONEY, BGT_B_BUDGET_PROJ.IS_GOV_PROC, BGT_B_BUDGET_PROJ.APPLY_MONEY, BGT_B_BUDGET_PROJ.PLAN_BEGIN_DATE, BGT_B_BUDGET_PROJ.BUDGET_DEPT_ID, BGT_B_BUDGET_PROJ.PLAN_END_DATE, BGT_B_BUDGET_PROJ.CREATE_DEPT_ID, BGT_B_BUDGET_PROJ.AVAILABLE_MONEY, BGT_B_BUDGET_PROJ.REPLY_DATE, BGT_B_BUDGET_PROJ.APPLIED_MONEY, BGT_B_BUDGET_PROJ.CREATE_TIME, BGT_B_BUDGET_PROJ.REPLY_MONEY, BGT_B_BUDGET_PROJ.PURPOSE, BGT_B_BUDGET_PROJ.BIZ_STATE, BGT_B_BUDGET_PROJ.MODIFY_USER_ID, BGT_B_BUDGET_PROJ.APPLY_USER_ID, BGT_B_BUDGET_PROJ.BUDGET_YEAR, BGT_B_BUDGET_PROJ.TYPE_ID, BGT_B_BUDGET_PROJ.COMMENTS, BGT_B_BUDGET_PROJ.NAME, BGT_B_BUDGET_PROJ.APPLY_DATE, BGT_B_BUDGET_PROJ.REPLY_USER_ID, COM_USER_PROJ_USER_ID.NAME as PROJ_USER_ID_NAME, COM_USER_FINANCE_USER_ID.NAME as FINANCE_USER_ID_NAME, (case  when BGT_B_BUDGET_PROJ.STATE = 0 then '默认值' when BGT_B_BUDGET_PROJ.STATE = 1 then '编辑中' when BGT_B_BUDGET_PROJ.STATE = 2 then '已提交' when BGT_B_BUDGET_PROJ.STATE = 3 then '已审核' when BGT_B_BUDGET_PROJ.STATE = 4 then '已归档' when BGT_B_BUDGET_PROJ.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_NATURE_ID.NAME as NATURE_ID_NAME, (case  when BGT_B_BUDGET_PROJ.IS_GOV_PROC = 1 then '是' when BGT_B_BUDGET_PROJ.IS_GOV_PROC = 2 then '否' else '' end ) as IS_GOV_PROC_NAME, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, COM_TYPE_BIZ_STATE.NAME as BIZ_STATE_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_USER_REPLY_USER_ID.NAME as REPLY_USER_ID_NAME from BGT_B_BUDGET_PROJ left join COM_USER   COM_USER_PROJ_USER_ID on BGT_B_BUDGET_PROJ.PROJ_USER_ID = COM_USER_PROJ_USER_ID.ID left join COM_USER   COM_USER_FINANCE_USER_ID on BGT_B_BUDGET_PROJ.FINANCE_USER_ID = COM_USER_FINANCE_USER_ID.ID left join COM_TYPE   COM_TYPE_NATURE_ID on BGT_B_BUDGET_PROJ.NATURE_ID = COM_TYPE_NATURE_ID.ID left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_BUDGET_PROJ.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join COM_TYPE   COM_TYPE_BIZ_STATE on BGT_B_BUDGET_PROJ.BIZ_STATE = COM_TYPE_BIZ_STATE.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_BUDGET_PROJ.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_BUDGET_PROJ.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_TYPE_ID on BGT_B_BUDGET_PROJ.TYPE_ID = COM_TYPE_TYPE_ID.ID left join COM_USER   COM_USER_REPLY_USER_ID on BGT_B_BUDGET_PROJ.REPLY_USER_ID = COM_USER_REPLY_USER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_BUDGET_PROJ dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROJ_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NATURE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BACKDROP = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PLAN_BEGIN_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PLAN_END_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.REPLY_DATE = sqlReader.GetDateTime(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURPOSE = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.BIZ_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.REPLY_USER_ID = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.PROJ_USER_ID_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FINANCE_USER_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.NATURE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_GOV_PROC_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.BIZ_STATE_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.REPLY_USER_ID_NAME = sqlReader.GetString(44);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ[] objs = new DisplayObject_BGT_B_BUDGET_PROJ[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_BUDGET_PROJ cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_BUDGET_PROJ where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_BUDGET_PROJ[] Query(CauseObject_BGT_B_BUDGET_PROJ cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_PROJ.EXECUTED_MONEY, BGT_B_BUDGET_PROJ.PROJ_USER_ID, BGT_B_BUDGET_PROJ.ID, BGT_B_BUDGET_PROJ.FINANCE_USER_ID, BGT_B_BUDGET_PROJ.CREATE_USER_ID, BGT_B_BUDGET_PROJ.STATE, BGT_B_BUDGET_PROJ.NATURE_ID, BGT_B_BUDGET_PROJ.MODIFY_DEPT_ID, BGT_B_BUDGET_PROJ.BACKDROP, BGT_B_BUDGET_PROJ.DATA_ORGANISE_ID, BGT_B_BUDGET_PROJ.MODIFY_TIME, BGT_B_BUDGET_PROJ.CODE, BGT_B_BUDGET_PROJ.ADJUST_MONEY, BGT_B_BUDGET_PROJ.IS_GOV_PROC, BGT_B_BUDGET_PROJ.APPLY_MONEY, BGT_B_BUDGET_PROJ.PLAN_BEGIN_DATE, BGT_B_BUDGET_PROJ.BUDGET_DEPT_ID, BGT_B_BUDGET_PROJ.PLAN_END_DATE, BGT_B_BUDGET_PROJ.CREATE_DEPT_ID, BGT_B_BUDGET_PROJ.AVAILABLE_MONEY, BGT_B_BUDGET_PROJ.REPLY_DATE, BGT_B_BUDGET_PROJ.APPLIED_MONEY, BGT_B_BUDGET_PROJ.CREATE_TIME, BGT_B_BUDGET_PROJ.REPLY_MONEY, BGT_B_BUDGET_PROJ.PURPOSE, BGT_B_BUDGET_PROJ.BIZ_STATE, BGT_B_BUDGET_PROJ.MODIFY_USER_ID, BGT_B_BUDGET_PROJ.APPLY_USER_ID, BGT_B_BUDGET_PROJ.BUDGET_YEAR, BGT_B_BUDGET_PROJ.TYPE_ID, BGT_B_BUDGET_PROJ.COMMENTS, BGT_B_BUDGET_PROJ.NAME, BGT_B_BUDGET_PROJ.APPLY_DATE, BGT_B_BUDGET_PROJ.REPLY_USER_ID, COM_USER_PROJ_USER_ID.NAME as PROJ_USER_ID_NAME, COM_USER_FINANCE_USER_ID.NAME as FINANCE_USER_ID_NAME, (case  when BGT_B_BUDGET_PROJ.STATE = 0 then '默认值' when BGT_B_BUDGET_PROJ.STATE = 1 then '编辑中' when BGT_B_BUDGET_PROJ.STATE = 2 then '已提交' when BGT_B_BUDGET_PROJ.STATE = 3 then '已审核' when BGT_B_BUDGET_PROJ.STATE = 4 then '已归档' when BGT_B_BUDGET_PROJ.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_NATURE_ID.NAME as NATURE_ID_NAME, (case  when BGT_B_BUDGET_PROJ.IS_GOV_PROC = 1 then '是' when BGT_B_BUDGET_PROJ.IS_GOV_PROC = 2 then '否' else '' end ) as IS_GOV_PROC_NAME, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, COM_TYPE_BIZ_STATE.NAME as BIZ_STATE_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_USER_REPLY_USER_ID.NAME as REPLY_USER_ID_NAME from BGT_B_BUDGET_PROJ left join COM_USER   COM_USER_PROJ_USER_ID on BGT_B_BUDGET_PROJ.PROJ_USER_ID = COM_USER_PROJ_USER_ID.ID left join COM_USER   COM_USER_FINANCE_USER_ID on BGT_B_BUDGET_PROJ.FINANCE_USER_ID = COM_USER_FINANCE_USER_ID.ID left join COM_TYPE   COM_TYPE_NATURE_ID on BGT_B_BUDGET_PROJ.NATURE_ID = COM_TYPE_NATURE_ID.ID left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_BUDGET_PROJ.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join COM_TYPE   COM_TYPE_BIZ_STATE on BGT_B_BUDGET_PROJ.BIZ_STATE = COM_TYPE_BIZ_STATE.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_BUDGET_PROJ.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_BUDGET_PROJ.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_TYPE_ID on BGT_B_BUDGET_PROJ.TYPE_ID = COM_TYPE_TYPE_ID.ID left join COM_USER   COM_USER_REPLY_USER_ID on BGT_B_BUDGET_PROJ.REPLY_USER_ID = COM_USER_REPLY_USER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_BUDGET_PROJ dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROJ_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NATURE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BACKDROP = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PLAN_BEGIN_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PLAN_END_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.REPLY_DATE = sqlReader.GetDateTime(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURPOSE = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.BIZ_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.REPLY_USER_ID = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.PROJ_USER_ID_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FINANCE_USER_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.NATURE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_GOV_PROC_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.BIZ_STATE_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.REPLY_USER_ID_NAME = sqlReader.GetString(44);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ[] objs = new DisplayObject_BGT_B_BUDGET_PROJ[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_BUDGET_PROJ[] Query(CauseObject_BGT_B_BUDGET_PROJ cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_PROJ.EXECUTED_MONEY, BGT_B_BUDGET_PROJ.PROJ_USER_ID, BGT_B_BUDGET_PROJ.ID, BGT_B_BUDGET_PROJ.FINANCE_USER_ID, BGT_B_BUDGET_PROJ.CREATE_USER_ID, BGT_B_BUDGET_PROJ.STATE, BGT_B_BUDGET_PROJ.NATURE_ID, BGT_B_BUDGET_PROJ.MODIFY_DEPT_ID, BGT_B_BUDGET_PROJ.BACKDROP, BGT_B_BUDGET_PROJ.DATA_ORGANISE_ID, BGT_B_BUDGET_PROJ.MODIFY_TIME, BGT_B_BUDGET_PROJ.CODE, BGT_B_BUDGET_PROJ.ADJUST_MONEY, BGT_B_BUDGET_PROJ.IS_GOV_PROC, BGT_B_BUDGET_PROJ.APPLY_MONEY, BGT_B_BUDGET_PROJ.PLAN_BEGIN_DATE, BGT_B_BUDGET_PROJ.BUDGET_DEPT_ID, BGT_B_BUDGET_PROJ.PLAN_END_DATE, BGT_B_BUDGET_PROJ.CREATE_DEPT_ID, BGT_B_BUDGET_PROJ.AVAILABLE_MONEY, BGT_B_BUDGET_PROJ.REPLY_DATE, BGT_B_BUDGET_PROJ.APPLIED_MONEY, BGT_B_BUDGET_PROJ.CREATE_TIME, BGT_B_BUDGET_PROJ.REPLY_MONEY, BGT_B_BUDGET_PROJ.PURPOSE, BGT_B_BUDGET_PROJ.BIZ_STATE, BGT_B_BUDGET_PROJ.MODIFY_USER_ID, BGT_B_BUDGET_PROJ.APPLY_USER_ID, BGT_B_BUDGET_PROJ.BUDGET_YEAR, BGT_B_BUDGET_PROJ.TYPE_ID, BGT_B_BUDGET_PROJ.COMMENTS, BGT_B_BUDGET_PROJ.NAME, BGT_B_BUDGET_PROJ.APPLY_DATE, BGT_B_BUDGET_PROJ.REPLY_USER_ID, COM_USER_PROJ_USER_ID.NAME as PROJ_USER_ID_NAME, COM_USER_FINANCE_USER_ID.NAME as FINANCE_USER_ID_NAME, (case  when BGT_B_BUDGET_PROJ.STATE = 0 then '默认值' when BGT_B_BUDGET_PROJ.STATE = 1 then '编辑中' when BGT_B_BUDGET_PROJ.STATE = 2 then '已提交' when BGT_B_BUDGET_PROJ.STATE = 3 then '已审核' when BGT_B_BUDGET_PROJ.STATE = 4 then '已归档' when BGT_B_BUDGET_PROJ.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_NATURE_ID.NAME as NATURE_ID_NAME, (case  when BGT_B_BUDGET_PROJ.IS_GOV_PROC = 1 then '是' when BGT_B_BUDGET_PROJ.IS_GOV_PROC = 2 then '否' else '' end ) as IS_GOV_PROC_NAME, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, COM_TYPE_BIZ_STATE.NAME as BIZ_STATE_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_USER_REPLY_USER_ID.NAME as REPLY_USER_ID_NAME from BGT_B_BUDGET_PROJ left join COM_USER   COM_USER_PROJ_USER_ID on BGT_B_BUDGET_PROJ.PROJ_USER_ID = COM_USER_PROJ_USER_ID.ID left join COM_USER   COM_USER_FINANCE_USER_ID on BGT_B_BUDGET_PROJ.FINANCE_USER_ID = COM_USER_FINANCE_USER_ID.ID left join COM_TYPE   COM_TYPE_NATURE_ID on BGT_B_BUDGET_PROJ.NATURE_ID = COM_TYPE_NATURE_ID.ID left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_BUDGET_PROJ.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join COM_TYPE   COM_TYPE_BIZ_STATE on BGT_B_BUDGET_PROJ.BIZ_STATE = COM_TYPE_BIZ_STATE.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_BUDGET_PROJ.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_BUDGET_PROJ.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_TYPE_ID on BGT_B_BUDGET_PROJ.TYPE_ID = COM_TYPE_TYPE_ID.ID left join COM_USER   COM_USER_REPLY_USER_ID on BGT_B_BUDGET_PROJ.REPLY_USER_ID = COM_USER_REPLY_USER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_BUDGET_PROJ",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_BUDGET_PROJ dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROJ_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NATURE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BACKDROP = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PLAN_BEGIN_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PLAN_END_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.REPLY_DATE = sqlReader.GetDateTime(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURPOSE = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.BIZ_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.REPLY_USER_ID = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.PROJ_USER_ID_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FINANCE_USER_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.NATURE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_GOV_PROC_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.BIZ_STATE_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.REPLY_USER_ID_NAME = sqlReader.GetString(44);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ[] objs = new DisplayObject_BGT_B_BUDGET_PROJ[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_BUDGET_PROJ[] Query(CauseObject_BGT_B_BUDGET_PROJ cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_PROJ.EXECUTED_MONEY, BGT_B_BUDGET_PROJ.PROJ_USER_ID, BGT_B_BUDGET_PROJ.ID, BGT_B_BUDGET_PROJ.FINANCE_USER_ID, BGT_B_BUDGET_PROJ.CREATE_USER_ID, BGT_B_BUDGET_PROJ.STATE, BGT_B_BUDGET_PROJ.NATURE_ID, BGT_B_BUDGET_PROJ.MODIFY_DEPT_ID, BGT_B_BUDGET_PROJ.BACKDROP, BGT_B_BUDGET_PROJ.DATA_ORGANISE_ID, BGT_B_BUDGET_PROJ.MODIFY_TIME, BGT_B_BUDGET_PROJ.CODE, BGT_B_BUDGET_PROJ.ADJUST_MONEY, BGT_B_BUDGET_PROJ.IS_GOV_PROC, BGT_B_BUDGET_PROJ.APPLY_MONEY, BGT_B_BUDGET_PROJ.PLAN_BEGIN_DATE, BGT_B_BUDGET_PROJ.BUDGET_DEPT_ID, BGT_B_BUDGET_PROJ.PLAN_END_DATE, BGT_B_BUDGET_PROJ.CREATE_DEPT_ID, BGT_B_BUDGET_PROJ.AVAILABLE_MONEY, BGT_B_BUDGET_PROJ.REPLY_DATE, BGT_B_BUDGET_PROJ.APPLIED_MONEY, BGT_B_BUDGET_PROJ.CREATE_TIME, BGT_B_BUDGET_PROJ.REPLY_MONEY, BGT_B_BUDGET_PROJ.PURPOSE, BGT_B_BUDGET_PROJ.BIZ_STATE, BGT_B_BUDGET_PROJ.MODIFY_USER_ID, BGT_B_BUDGET_PROJ.APPLY_USER_ID, BGT_B_BUDGET_PROJ.BUDGET_YEAR, BGT_B_BUDGET_PROJ.TYPE_ID, BGT_B_BUDGET_PROJ.COMMENTS, BGT_B_BUDGET_PROJ.NAME, BGT_B_BUDGET_PROJ.APPLY_DATE, BGT_B_BUDGET_PROJ.REPLY_USER_ID, COM_USER_PROJ_USER_ID.NAME as PROJ_USER_ID_NAME, COM_USER_FINANCE_USER_ID.NAME as FINANCE_USER_ID_NAME, (case  when BGT_B_BUDGET_PROJ.STATE = 0 then '默认值' when BGT_B_BUDGET_PROJ.STATE = 1 then '编辑中' when BGT_B_BUDGET_PROJ.STATE = 2 then '已提交' when BGT_B_BUDGET_PROJ.STATE = 3 then '已审核' when BGT_B_BUDGET_PROJ.STATE = 4 then '已归档' when BGT_B_BUDGET_PROJ.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_TYPE_NATURE_ID.NAME as NATURE_ID_NAME, (case  when BGT_B_BUDGET_PROJ.IS_GOV_PROC = 1 then '是' when BGT_B_BUDGET_PROJ.IS_GOV_PROC = 2 then '否' else '' end ) as IS_GOV_PROC_NAME, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, COM_TYPE_BIZ_STATE.NAME as BIZ_STATE_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_TYPE_ID.NAME as TYPE_ID_NAME, COM_USER_REPLY_USER_ID.NAME as REPLY_USER_ID_NAME from BGT_B_BUDGET_PROJ left join COM_USER   COM_USER_PROJ_USER_ID on BGT_B_BUDGET_PROJ.PROJ_USER_ID = COM_USER_PROJ_USER_ID.ID left join COM_USER   COM_USER_FINANCE_USER_ID on BGT_B_BUDGET_PROJ.FINANCE_USER_ID = COM_USER_FINANCE_USER_ID.ID left join COM_TYPE   COM_TYPE_NATURE_ID on BGT_B_BUDGET_PROJ.NATURE_ID = COM_TYPE_NATURE_ID.ID left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_BUDGET_PROJ.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join COM_TYPE   COM_TYPE_BIZ_STATE on BGT_B_BUDGET_PROJ.BIZ_STATE = COM_TYPE_BIZ_STATE.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_BUDGET_PROJ.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_BUDGET_PROJ.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_TYPE_ID on BGT_B_BUDGET_PROJ.TYPE_ID = COM_TYPE_TYPE_ID.ID left join COM_USER   COM_USER_REPLY_USER_ID on BGT_B_BUDGET_PROJ.REPLY_USER_ID = COM_USER_REPLY_USER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_BUDGET_PROJ",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_BUDGET_PROJ dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROJ_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FINANCE_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NATURE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BACKDROP = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PLAN_BEGIN_DATE = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PLAN_END_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.REPLY_DATE = sqlReader.GetDateTime(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PURPOSE = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.BIZ_STATE = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.COMMENTS = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.NAME = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.REPLY_USER_ID = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.PROJ_USER_ID_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.FINANCE_USER_ID_NAME = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STATE_NAME = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.NATURE_ID_NAME = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_GOV_PROC_NAME = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.BIZ_STATE_NAME = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.REPLY_USER_ID_NAME = sqlReader.GetString(44);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ[] objs = new DisplayObject_BGT_B_BUDGET_PROJ[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_BUDGET_PROJ obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("EXECUTED_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.EXECUTED_MONEY = :EXECUTED_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":EXECUTED_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.EXECUTED_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PROJ_USER_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.PROJ_USER_ID = :PROJ_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":PROJ_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PROJ_USER_ID) ? string.Empty : obj.PROJ_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_USER_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.FINANCE_USER_ID = :FINANCE_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":FINANCE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_USER_ID) ? string.Empty : obj.FINANCE_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NATURE_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.NATURE_ID = :NATURE_ID");
				param = new OracleParameter();
				param.ParameterName = ":NATURE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.NATURE_ID) ? string.Empty : obj.NATURE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.MODIFY_DEPT_ID = :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BACKDROP"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.BACKDROP = :BACKDROP");
				param = new OracleParameter();
				param.ParameterName = ":BACKDROP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BACKDROP) ? string.Empty : obj.BACKDROP;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ADJUST_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.ADJUST_MONEY = :ADJUST_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":ADJUST_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ADJUST_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_GOV_PROC"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.IS_GOV_PROC = :IS_GOV_PROC");
				param = new OracleParameter();
				param.ParameterName = ":IS_GOV_PROC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_GOV_PROC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.APPLY_MONEY = :APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.APPLY_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PLAN_BEGIN_DATE"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.PLAN_BEGIN_DATE = :PLAN_BEGIN_DATE");
				param = new OracleParameter();
				param.ParameterName = ":PLAN_BEGIN_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PLAN_BEGIN_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_DEPT_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.BUDGET_DEPT_ID = :BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_DEPT_ID) ? string.Empty : obj.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PLAN_END_DATE"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.PLAN_END_DATE = :PLAN_END_DATE");
				param = new OracleParameter();
				param.ParameterName = ":PLAN_END_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PLAN_END_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.CREATE_DEPT_ID = :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AVAILABLE_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.AVAILABLE_MONEY = :AVAILABLE_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":AVAILABLE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AVAILABLE_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REPLY_DATE"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.REPLY_DATE = :REPLY_DATE");
				param = new OracleParameter();
				param.ParameterName = ":REPLY_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.REPLY_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLIED_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.APPLIED_MONEY = :APPLIED_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":APPLIED_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.APPLIED_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REPLY_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.REPLY_MONEY = :REPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":REPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.REPLY_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURPOSE"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.PURPOSE = :PURPOSE");
				param = new OracleParameter();
				param.ParameterName = ":PURPOSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PURPOSE) ? string.Empty : obj.PURPOSE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BIZ_STATE"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.BIZ_STATE = :BIZ_STATE");
				param = new OracleParameter();
				param.ParameterName = ":BIZ_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BIZ_STATE) ? string.Empty : obj.BIZ_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_USER_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.APPLY_USER_ID = :APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_USER_ID) ? string.Empty : obj.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.BUDGET_YEAR = :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TYPE_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.TYPE_ID = :TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.TYPE_ID) ? string.Empty : obj.TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_DATE"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.APPLY_DATE = :APPLY_DATE");
				param = new OracleParameter();
				param.ParameterName = ":APPLY_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.APPLY_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REPLY_USER_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ.REPLY_USER_ID = :REPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":REPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REPLY_USER_ID) ? string.Empty : obj.REPLY_USER_ID;
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
