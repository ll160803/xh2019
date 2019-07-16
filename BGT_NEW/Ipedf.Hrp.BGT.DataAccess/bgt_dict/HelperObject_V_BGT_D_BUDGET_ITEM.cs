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
	[CauseObject(typeof(CauseObject_V_BGT_D_BUDGET_ITEM))]
	public partial class HelperObject_V_BGT_D_BUDGET_ITEM
	{		
		#region Method Blok
		public static int Save(EntityObject_V_BGT_D_BUDGET_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_BGT_D_BUDGET_ITEM( BUDGET_YEAR_NAME, ID, PREPARE_PATTERN_ID, CODE, MODIFY_DEPT_ID, COMMENTS, CREATE_USER_ID, DATA_TYPE_ID, PARENT_ID, DATA_ORGANISE_ID, BUDGET_YEAR, IS_MERGE, CREATE_TIME, CREATE_DEPT_ID, IS_CARRYOVER, IMPORT_TYPE_ID, STATE, IS_END, USAGE_ID, ITEM_TYPE_ID, NAME) values ( :BUDGET_YEAR_NAME, :ID, :PREPARE_PATTERN_ID, :CODE, :MODIFY_DEPT_ID, :COMMENTS, :CREATE_USER_ID, :DATA_TYPE_ID, :PARENT_ID, :DATA_ORGANISE_ID, :BUDGET_YEAR, :IS_MERGE, :CREATE_TIME, :CREATE_DEPT_ID, :IS_CARRYOVER, :IMPORT_TYPE_ID, :STATE, :IS_END, :USAGE_ID, :ITEM_TYPE_ID, :NAME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[21];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":BUDGET_YEAR_NAME";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.BUDGET_YEAR_NAME == null ? String.Empty:obj.BUDGET_YEAR_NAME;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":PREPARE_PATTERN_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.PREPARE_PATTERN_ID == null ? String.Empty:obj.PREPARE_PATTERN_ID;
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
			parameters[5].ParameterName =":COMMENTS";
			parameters[5].Size = 200;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":CREATE_USER_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":DATA_TYPE_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.DATA_TYPE_ID == null ? String.Empty:obj.DATA_TYPE_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":PARENT_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.PARENT_ID == null ? String.Empty:obj.PARENT_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":DATA_ORGANISE_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":BUDGET_YEAR";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":IS_MERGE";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.IS_MERGE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":CREATE_TIME";
			parameters[12].Size = 7;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[12].Value = obj.CREATE_TIME;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":CREATE_DEPT_ID";
			parameters[13].Size = 36;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":IS_CARRYOVER";
			parameters[14].Size = 22;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[14].Value = obj.IS_CARRYOVER;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":IMPORT_TYPE_ID";
			parameters[15].Size = 36;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[15].Value = obj.IMPORT_TYPE_ID == null ? String.Empty:obj.IMPORT_TYPE_ID;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":STATE";
			parameters[16].Size = 22;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[16].Value = obj.STATE;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":IS_END";
			parameters[17].Size = 22;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[17].Value = obj.IS_END;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":USAGE_ID";
			parameters[18].Size = 36;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[18].Value = obj.USAGE_ID == null ? String.Empty:obj.USAGE_ID;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":ITEM_TYPE_ID";
			parameters[19].Size = 36;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[19].Value = obj.ITEM_TYPE_ID == null ? String.Empty:obj.ITEM_TYPE_ID;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":NAME";
			parameters[20].Size = 200;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[20].Value = obj.NAME == null ? String.Empty:obj.NAME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_BGT_D_BUDGET_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_BGT_D_BUDGET_ITEM set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_BGT_D_BUDGET_ITEM obj,CauseObject_V_BGT_D_BUDGET_ITEM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_BGT_D_BUDGET_ITEM set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_BGT_D_BUDGET_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_BGT_D_BUDGET_ITEM where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_V_BGT_D_BUDGET_ITEM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_BGT_D_BUDGET_ITEM where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_BGT_D_BUDGET_ITEM Get(EntityObject_V_BGT_D_BUDGET_ITEM obj)
		{
			
			//平台自动生成代码
			string sSql = "select  BUDGET_YEAR_NAME, ID, PREPARE_PATTERN_ID, MODIFY_USER_ID, CODE, MODIFY_DEPT_ID, COMMENTS, CREATE_USER_ID, DATA_TYPE_ID, PARENT_ID, DATA_ORGANISE_ID, BUDGET_YEAR, IS_MERGE, CREATE_TIME, CREATE_DEPT_ID, MODIFY_TIME, IS_CARRYOVER, IMPORT_TYPE_ID, STATE, IS_END, USAGE_ID, ITEM_TYPE_ID, NAME from V_BGT_D_BUDGET_ITEM where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_D_BUDGET_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_D_BUDGET_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_MERGE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_END = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USAGE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_BGT_D_BUDGET_ITEM[] objs = new EntityObject_V_BGT_D_BUDGET_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_BGT_D_BUDGET_ITEM Get(EntityObject_V_BGT_D_BUDGET_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  BUDGET_YEAR_NAME, ID, PREPARE_PATTERN_ID, MODIFY_USER_ID, CODE, MODIFY_DEPT_ID, COMMENTS, CREATE_USER_ID, DATA_TYPE_ID, PARENT_ID, DATA_ORGANISE_ID, BUDGET_YEAR, IS_MERGE, CREATE_TIME, CREATE_DEPT_ID, MODIFY_TIME, IS_CARRYOVER, IMPORT_TYPE_ID, STATE, IS_END, USAGE_ID, ITEM_TYPE_ID, NAME from V_BGT_D_BUDGET_ITEM where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_D_BUDGET_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_D_BUDGET_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_MERGE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_END = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USAGE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_BGT_D_BUDGET_ITEM[] objs = new EntityObject_V_BGT_D_BUDGET_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_BGT_D_BUDGET_ITEM[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_BGT_D_BUDGET_ITEM.BUDGET_YEAR_NAME, V_BGT_D_BUDGET_ITEM.ID, V_BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID, V_BGT_D_BUDGET_ITEM.MODIFY_USER_ID, V_BGT_D_BUDGET_ITEM.CODE, V_BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID, V_BGT_D_BUDGET_ITEM.COMMENTS, V_BGT_D_BUDGET_ITEM.CREATE_USER_ID, V_BGT_D_BUDGET_ITEM.DATA_TYPE_ID, V_BGT_D_BUDGET_ITEM.PARENT_ID, V_BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID, V_BGT_D_BUDGET_ITEM.BUDGET_YEAR, V_BGT_D_BUDGET_ITEM.IS_MERGE, V_BGT_D_BUDGET_ITEM.CREATE_TIME, V_BGT_D_BUDGET_ITEM.CREATE_DEPT_ID, V_BGT_D_BUDGET_ITEM.MODIFY_TIME, V_BGT_D_BUDGET_ITEM.IS_CARRYOVER, V_BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID, V_BGT_D_BUDGET_ITEM.STATE, V_BGT_D_BUDGET_ITEM.IS_END, V_BGT_D_BUDGET_ITEM.USAGE_ID, V_BGT_D_BUDGET_ITEM.ITEM_TYPE_ID, V_BGT_D_BUDGET_ITEM.NAME from V_BGT_D_BUDGET_ITEM where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_BGT_D_BUDGET_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_D_BUDGET_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_MERGE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_END = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USAGE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_D_BUDGET_ITEM[] objs = new DisplayObject_V_BGT_D_BUDGET_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_BGT_D_BUDGET_ITEM cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR_NAME))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.BUDGET_YEAR_NAME ").Append((cause.BUDGET_YEAR_NAME.StartsWith("%") || cause.BUDGET_YEAR_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_BUDGET_YEAR_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_BUDGET_YEAR_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BUDGET_YEAR_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "BUDGET_YEAR_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.PREPARE_PATTERN_ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID ").Append((cause.PREPARE_PATTERN_ID.StartsWith("%") || cause.PREPARE_PATTERN_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PREPARE_PATTERN_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PREPARE_PATTERN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PREPARE_PATTERN_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PREPARE_PATTERN_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "PREPARE_PATTERN_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "MODIFY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_TYPE_ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.DATA_TYPE_ID ").Append((cause.DATA_TYPE_ID.StartsWith("%") || cause.DATA_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "DATA_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PARENT_ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.PARENT_ID ").Append((cause.PARENT_ID.StartsWith("%") || cause.PARENT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PARENT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PARENT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PARENT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PARENT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "PARENT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :C_BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":C_BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "BUDGET_YEAR"));
			}
			if(cause.IS_MERGE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.IS_MERGE = :C_IS_MERGE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_MERGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_MERGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_MERGE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "IS_MERGE"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And V_BGT_D_BUDGET_ITEM.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And V_BGT_D_BUDGET_ITEM.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "CREATE_DEPT_ID"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And V_BGT_D_BUDGET_ITEM.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And V_BGT_D_BUDGET_ITEM.MODIFY_TIME < :C_MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "MODIFY_TIME"));
			}
			if(cause.IS_CARRYOVER!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.IS_CARRYOVER = :C_IS_CARRYOVER");
				param = new OracleParameter();
				param.ParameterName =":C_IS_CARRYOVER";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_CARRYOVER;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_CARRYOVER"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "IS_CARRYOVER"));
			}
			if(!string.IsNullOrEmpty(cause.IMPORT_TYPE_ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID ").Append((cause.IMPORT_TYPE_ID.StartsWith("%") || cause.IMPORT_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_IMPORT_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_IMPORT_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.IMPORT_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("IMPORT_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "IMPORT_TYPE_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "STATE"));
			}
			if(cause.IS_END!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.IS_END = :C_IS_END");
				param = new OracleParameter();
				param.ParameterName =":C_IS_END";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_END;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_END"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "IS_END"));
			}
			if(!string.IsNullOrEmpty(cause.USAGE_ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.USAGE_ID ").Append((cause.USAGE_ID.StartsWith("%") || cause.USAGE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USAGE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USAGE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USAGE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USAGE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "USAGE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ITEM_TYPE_ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.ITEM_TYPE_ID ").Append((cause.ITEM_TYPE_ID.StartsWith("%") || cause.ITEM_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ITEM_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ITEM_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "ITEM_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_ITEM.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_ITEM", "NAME"));
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
		public static DisplayObject_V_BGT_D_BUDGET_ITEM[] Query(CauseObject_V_BGT_D_BUDGET_ITEM cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_D_BUDGET_ITEM.BUDGET_YEAR_NAME, V_BGT_D_BUDGET_ITEM.ID, V_BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID, V_BGT_D_BUDGET_ITEM.MODIFY_USER_ID, V_BGT_D_BUDGET_ITEM.CODE, V_BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID, V_BGT_D_BUDGET_ITEM.COMMENTS, V_BGT_D_BUDGET_ITEM.CREATE_USER_ID, V_BGT_D_BUDGET_ITEM.DATA_TYPE_ID, V_BGT_D_BUDGET_ITEM.PARENT_ID, V_BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID, V_BGT_D_BUDGET_ITEM.BUDGET_YEAR, V_BGT_D_BUDGET_ITEM.IS_MERGE, V_BGT_D_BUDGET_ITEM.CREATE_TIME, V_BGT_D_BUDGET_ITEM.CREATE_DEPT_ID, V_BGT_D_BUDGET_ITEM.MODIFY_TIME, V_BGT_D_BUDGET_ITEM.IS_CARRYOVER, V_BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID, V_BGT_D_BUDGET_ITEM.STATE, V_BGT_D_BUDGET_ITEM.IS_END, V_BGT_D_BUDGET_ITEM.USAGE_ID, V_BGT_D_BUDGET_ITEM.ITEM_TYPE_ID, V_BGT_D_BUDGET_ITEM.NAME from V_BGT_D_BUDGET_ITEM where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_D_BUDGET_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_D_BUDGET_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_MERGE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_END = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USAGE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_D_BUDGET_ITEM[] objs = new DisplayObject_V_BGT_D_BUDGET_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_V_BGT_D_BUDGET_ITEM[] Query(CauseObject_V_BGT_D_BUDGET_ITEM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_D_BUDGET_ITEM.BUDGET_YEAR_NAME, V_BGT_D_BUDGET_ITEM.ID, V_BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID, V_BGT_D_BUDGET_ITEM.MODIFY_USER_ID, V_BGT_D_BUDGET_ITEM.CODE, V_BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID, V_BGT_D_BUDGET_ITEM.COMMENTS, V_BGT_D_BUDGET_ITEM.CREATE_USER_ID, V_BGT_D_BUDGET_ITEM.DATA_TYPE_ID, V_BGT_D_BUDGET_ITEM.PARENT_ID, V_BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID, V_BGT_D_BUDGET_ITEM.BUDGET_YEAR, V_BGT_D_BUDGET_ITEM.IS_MERGE, V_BGT_D_BUDGET_ITEM.CREATE_TIME, V_BGT_D_BUDGET_ITEM.CREATE_DEPT_ID, V_BGT_D_BUDGET_ITEM.MODIFY_TIME, V_BGT_D_BUDGET_ITEM.IS_CARRYOVER, V_BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID, V_BGT_D_BUDGET_ITEM.STATE, V_BGT_D_BUDGET_ITEM.IS_END, V_BGT_D_BUDGET_ITEM.USAGE_ID, V_BGT_D_BUDGET_ITEM.ITEM_TYPE_ID, V_BGT_D_BUDGET_ITEM.NAME from V_BGT_D_BUDGET_ITEM where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_D_BUDGET_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_D_BUDGET_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_MERGE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_END = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USAGE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_D_BUDGET_ITEM[] objs = new DisplayObject_V_BGT_D_BUDGET_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_D_BUDGET_ITEM[] Query(CauseObject_V_BGT_D_BUDGET_ITEM cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_D_BUDGET_ITEM.BUDGET_YEAR_NAME, V_BGT_D_BUDGET_ITEM.ID, V_BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID, V_BGT_D_BUDGET_ITEM.MODIFY_USER_ID, V_BGT_D_BUDGET_ITEM.CODE, V_BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID, V_BGT_D_BUDGET_ITEM.COMMENTS, V_BGT_D_BUDGET_ITEM.CREATE_USER_ID, V_BGT_D_BUDGET_ITEM.DATA_TYPE_ID, V_BGT_D_BUDGET_ITEM.PARENT_ID, V_BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID, V_BGT_D_BUDGET_ITEM.BUDGET_YEAR, V_BGT_D_BUDGET_ITEM.IS_MERGE, V_BGT_D_BUDGET_ITEM.CREATE_TIME, V_BGT_D_BUDGET_ITEM.CREATE_DEPT_ID, V_BGT_D_BUDGET_ITEM.MODIFY_TIME, V_BGT_D_BUDGET_ITEM.IS_CARRYOVER, V_BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID, V_BGT_D_BUDGET_ITEM.STATE, V_BGT_D_BUDGET_ITEM.IS_END, V_BGT_D_BUDGET_ITEM.USAGE_ID, V_BGT_D_BUDGET_ITEM.ITEM_TYPE_ID, V_BGT_D_BUDGET_ITEM.NAME from V_BGT_D_BUDGET_ITEM where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_D_BUDGET_ITEM",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_BGT_D_BUDGET_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_D_BUDGET_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_MERGE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_END = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USAGE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_D_BUDGET_ITEM[] objs = new DisplayObject_V_BGT_D_BUDGET_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_D_BUDGET_ITEM[] Query(CauseObject_V_BGT_D_BUDGET_ITEM cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_D_BUDGET_ITEM.BUDGET_YEAR_NAME, V_BGT_D_BUDGET_ITEM.ID, V_BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID, V_BGT_D_BUDGET_ITEM.MODIFY_USER_ID, V_BGT_D_BUDGET_ITEM.CODE, V_BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID, V_BGT_D_BUDGET_ITEM.COMMENTS, V_BGT_D_BUDGET_ITEM.CREATE_USER_ID, V_BGT_D_BUDGET_ITEM.DATA_TYPE_ID, V_BGT_D_BUDGET_ITEM.PARENT_ID, V_BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID, V_BGT_D_BUDGET_ITEM.BUDGET_YEAR, V_BGT_D_BUDGET_ITEM.IS_MERGE, V_BGT_D_BUDGET_ITEM.CREATE_TIME, V_BGT_D_BUDGET_ITEM.CREATE_DEPT_ID, V_BGT_D_BUDGET_ITEM.MODIFY_TIME, V_BGT_D_BUDGET_ITEM.IS_CARRYOVER, V_BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID, V_BGT_D_BUDGET_ITEM.STATE, V_BGT_D_BUDGET_ITEM.IS_END, V_BGT_D_BUDGET_ITEM.USAGE_ID, V_BGT_D_BUDGET_ITEM.ITEM_TYPE_ID, V_BGT_D_BUDGET_ITEM.NAME from V_BGT_D_BUDGET_ITEM where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_D_BUDGET_ITEM",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_BGT_D_BUDGET_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_D_BUDGET_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_MERGE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_END = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.USAGE_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_D_BUDGET_ITEM[] objs = new DisplayObject_V_BGT_D_BUDGET_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_BGT_D_BUDGET_ITEM obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("BUDGET_YEAR_NAME"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.BUDGET_YEAR_NAME = :U_BUDGET_YEAR_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_BUDGET_YEAR_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR_NAME) ? string.Empty : obj.BUDGET_YEAR_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.ID = :U_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PREPARE_PATTERN_ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID = :U_PREPARE_PATTERN_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PREPARE_PATTERN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PREPARE_PATTERN_ID) ? string.Empty : obj.PREPARE_PATTERN_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID = :U_MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_TYPE_ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.DATA_TYPE_ID = :U_DATA_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_TYPE_ID) ? string.Empty : obj.DATA_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PARENT_ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.PARENT_ID = :U_PARENT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PARENT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PARENT_ID) ? string.Empty : obj.PARENT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.BUDGET_YEAR = :U_BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":U_BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_MERGE"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.IS_MERGE = :U_IS_MERGE");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_MERGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_MERGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.CREATE_DEPT_ID = :U_CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_CARRYOVER"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.IS_CARRYOVER = :U_IS_CARRYOVER");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_CARRYOVER";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_CARRYOVER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IMPORT_TYPE_ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID = :U_IMPORT_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_IMPORT_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.IMPORT_TYPE_ID) ? string.Empty : obj.IMPORT_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_END"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.IS_END = :U_IS_END");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_END";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_END;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USAGE_ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.USAGE_ID = :U_USAGE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USAGE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USAGE_ID) ? string.Empty : obj.USAGE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_TYPE_ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.ITEM_TYPE_ID = :U_ITEM_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ITEM_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_TYPE_ID) ? string.Empty : obj.ITEM_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_ITEM.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
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
		#endregion 
	}
}
