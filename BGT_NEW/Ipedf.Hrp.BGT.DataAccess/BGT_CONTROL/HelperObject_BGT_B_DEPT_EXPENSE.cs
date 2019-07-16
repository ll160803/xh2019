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
	[CauseObject(typeof(CauseObject_BGT_B_DEPT_EXPENSE))]
	public partial class HelperObject_BGT_B_DEPT_EXPENSE
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_DEPT_EXPENSE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_B_DEPT_EXPENSE( APPLY_DEPT_ID, ID, SUMARRY, INSTANCE_ID, CODE, MODIFY_DEPT_ID, COMMENTS, FINANCE_CYCLE, PAY_DATE, APPLY_USER_ID, CREATE_USER_ID, DATA_ORGANISE_ID, CREATE_TIME, APPLY_MONEY, PAY_USER_ID, CREATE_DEPT_ID, APPLY_DATE, STATE, PAY_MONEY) values ( :APPLY_DEPT_ID, :ID, :SUMARRY, :INSTANCE_ID, :CODE, :MODIFY_DEPT_ID, :COMMENTS, :FINANCE_CYCLE, :PAY_DATE, :APPLY_USER_ID, :CREATE_USER_ID, :DATA_ORGANISE_ID, :CREATE_TIME, :APPLY_MONEY, :PAY_USER_ID, :CREATE_DEPT_ID, :APPLY_DATE, :STATE, :PAY_MONEY)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[19];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":APPLY_DEPT_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.APPLY_DEPT_ID == null ? String.Empty:obj.APPLY_DEPT_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":SUMARRY";
			parameters[2].Size = 200;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.SUMARRY == null ? String.Empty:obj.SUMARRY;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":INSTANCE_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.INSTANCE_ID == null ? String.Empty:obj.INSTANCE_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":CODE";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":MODIFY_DEPT_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":COMMENTS";
			parameters[6].Size = 200;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":FINANCE_CYCLE";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.FINANCE_CYCLE == null ? String.Empty:obj.FINANCE_CYCLE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":PAY_DATE";
			parameters[8].Size = 7;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[8].Value = obj.PAY_DATE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":APPLY_USER_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.APPLY_USER_ID == null ? String.Empty:obj.APPLY_USER_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":CREATE_USER_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":DATA_ORGANISE_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":CREATE_TIME";
			parameters[12].Size = 7;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[12].Value = obj.CREATE_TIME;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":APPLY_MONEY";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.APPLY_MONEY;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":PAY_USER_ID";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.PAY_USER_ID == null ? String.Empty:obj.PAY_USER_ID;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":CREATE_DEPT_ID";
			parameters[15].Size = 36;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[15].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":APPLY_DATE";
			parameters[16].Size = 7;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[16].Value = obj.APPLY_DATE;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":STATE";
			parameters[17].Size = 22;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[17].Value = obj.STATE;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":PAY_MONEY";
			parameters[18].Size = 22;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[18].Value = obj.PAY_MONEY;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_DEPT_EXPENSE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_DEPT_EXPENSE set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_DEPT_EXPENSE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_DEPT_EXPENSE where  ID = :ID ";
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
		public static EntityObject_BGT_B_DEPT_EXPENSE Get(EntityObject_BGT_B_DEPT_EXPENSE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  APPLY_DEPT_ID, ID, SUMARRY, MODIFY_USER_ID, INSTANCE_ID, CODE, MODIFY_DEPT_ID, COMMENTS, FINANCE_CYCLE, PAY_DATE, APPLY_USER_ID, CREATE_USER_ID, DATA_ORGANISE_ID, CREATE_TIME, MODIFY_TIME, APPLY_MONEY, PAY_USER_ID, CREATE_DEPT_ID, APPLY_DATE, STATE, PAY_MONEY from BGT_B_DEPT_EXPENSE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_DEPT_EXPENSE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_DEPT_EXPENSE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMARRY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMENTS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAY_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.PAY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PAY_MONEY = sqlReader.GetDecimal(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_DEPT_EXPENSE[] objs = new EntityObject_BGT_B_DEPT_EXPENSE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_DEPT_EXPENSE Get(EntityObject_BGT_B_DEPT_EXPENSE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  APPLY_DEPT_ID, ID, SUMARRY, MODIFY_USER_ID, INSTANCE_ID, CODE, MODIFY_DEPT_ID, COMMENTS, FINANCE_CYCLE, PAY_DATE, APPLY_USER_ID, CREATE_USER_ID, DATA_ORGANISE_ID, CREATE_TIME, MODIFY_TIME, APPLY_MONEY, PAY_USER_ID, CREATE_DEPT_ID, APPLY_DATE, STATE, PAY_MONEY from BGT_B_DEPT_EXPENSE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_DEPT_EXPENSE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_DEPT_EXPENSE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMARRY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMENTS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAY_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.PAY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PAY_MONEY = sqlReader.GetDecimal(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_DEPT_EXPENSE[] objs = new EntityObject_BGT_B_DEPT_EXPENSE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_DEPT_EXPENSE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_DEPT_EXPENSE.APPLY_DEPT_ID, BGT_B_DEPT_EXPENSE.ID, BGT_B_DEPT_EXPENSE.SUMARRY, BGT_B_DEPT_EXPENSE.MODIFY_USER_ID, BGT_B_DEPT_EXPENSE.INSTANCE_ID, BGT_B_DEPT_EXPENSE.CODE, BGT_B_DEPT_EXPENSE.MODIFY_DEPT_ID, BGT_B_DEPT_EXPENSE.COMMENTS, BGT_B_DEPT_EXPENSE.FINANCE_CYCLE, BGT_B_DEPT_EXPENSE.PAY_DATE, BGT_B_DEPT_EXPENSE.APPLY_USER_ID, BGT_B_DEPT_EXPENSE.CREATE_USER_ID, BGT_B_DEPT_EXPENSE.DATA_ORGANISE_ID, BGT_B_DEPT_EXPENSE.CREATE_TIME, BGT_B_DEPT_EXPENSE.MODIFY_TIME, BGT_B_DEPT_EXPENSE.APPLY_MONEY, BGT_B_DEPT_EXPENSE.PAY_USER_ID, BGT_B_DEPT_EXPENSE.CREATE_DEPT_ID, BGT_B_DEPT_EXPENSE.APPLY_DATE, BGT_B_DEPT_EXPENSE.STATE, BGT_B_DEPT_EXPENSE.PAY_MONEY, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_USER_PAY_USER_ID.NAME as PAY_USER_ID_NAME, (case  when BGT_B_DEPT_EXPENSE.STATE = 0 then '默认值' when BGT_B_DEPT_EXPENSE.STATE = 1 then '编辑中' when BGT_B_DEPT_EXPENSE.STATE = 2 then '已提交' when BGT_B_DEPT_EXPENSE.STATE = 3 then '已审核' when BGT_B_DEPT_EXPENSE.STATE = 4 then '已归档' when BGT_B_DEPT_EXPENSE.STATE = 9 then '已作废' else '' end ) as STATE_NAME from BGT_B_DEPT_EXPENSE left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on BGT_B_DEPT_EXPENSE.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_DEPT_EXPENSE.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_USER   COM_USER_PAY_USER_ID on BGT_B_DEPT_EXPENSE.PAY_USER_ID = COM_USER_PAY_USER_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_DEPT_EXPENSE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_EXPENSE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMARRY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMENTS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAY_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.PAY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PAY_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.PAY_USER_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_DEPT_EXPENSE[] objs = new DisplayObject_BGT_B_DEPT_EXPENSE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_DEPT_EXPENSE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.APPLY_DEPT_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.APPLY_DEPT_ID ").Append((cause.APPLY_DEPT_ID.StartsWith("%") || cause.APPLY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :APPLY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":APPLY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "APPLY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.SUMARRY))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.SUMARRY ").Append((cause.SUMARRY.StartsWith("%") || cause.SUMARRY.EndsWith("%")) ? " like " : " = ").Append(" :SUMARRY");
				param = new OracleParameter();
				param.ParameterName =":SUMARRY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.SUMARRY;
				paramList.Add(param);
			}
			if (cause.HasINValue("SUMARRY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "SUMARRY"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.INSTANCE_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.INSTANCE_ID ").Append((cause.INSTANCE_ID.StartsWith("%") || cause.INSTANCE_ID.EndsWith("%")) ? " like " : " = ").Append(" :INSTANCE_ID");
				param = new OracleParameter();
				param.ParameterName =":INSTANCE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.INSTANCE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("INSTANCE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "INSTANCE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "MODIFY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_CYCLE))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.FINANCE_CYCLE ").Append((cause.FINANCE_CYCLE.StartsWith("%") || cause.FINANCE_CYCLE.EndsWith("%")) ? " like " : " = ").Append(" :FINANCE_CYCLE");
				param = new OracleParameter();
				param.ParameterName =":FINANCE_CYCLE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FINANCE_CYCLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_CYCLE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "FINANCE_CYCLE"));
			}
			if(cause.PAY_DATE!= null)
			{
				if (cause.PAY_DATE.Begin != null)
				{
					strBuf.Append(" And BGT_B_DEPT_EXPENSE.PAY_DATE >= :PAY_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":PAY_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PAY_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PAY_DATE.End != null)
				{
					strBuf.Append(" And BGT_B_DEPT_EXPENSE.PAY_DATE < :PAY_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":PAY_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PAY_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("PAY_DATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "PAY_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_USER_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.APPLY_USER_ID ").Append((cause.APPLY_USER_ID.StartsWith("%") || cause.APPLY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "APPLY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "DATA_ORGANISE_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And BGT_B_DEPT_EXPENSE.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And BGT_B_DEPT_EXPENSE.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "CREATE_TIME"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And BGT_B_DEPT_EXPENSE.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And BGT_B_DEPT_EXPENSE.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "MODIFY_TIME"));
			}
			if(cause.APPLY_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.APPLY_MONEY = :APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName =":APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLY_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "APPLY_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.PAY_USER_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.PAY_USER_ID ").Append((cause.PAY_USER_ID.StartsWith("%") || cause.PAY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :PAY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":PAY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PAY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "PAY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "CREATE_DEPT_ID"));
			}
			if(cause.APPLY_DATE!= null)
			{
				if (cause.APPLY_DATE.Begin != null)
				{
					strBuf.Append(" And BGT_B_DEPT_EXPENSE.APPLY_DATE >= :APPLY_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":APPLY_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.APPLY_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.APPLY_DATE.End != null)
				{
					strBuf.Append(" And BGT_B_DEPT_EXPENSE.APPLY_DATE < :APPLY_DATE_END");
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
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "APPLY_DATE"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "STATE"));
			}
			if(cause.PAY_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_DEPT_EXPENSE.PAY_MONEY = :PAY_MONEY");
				param = new OracleParameter();
				param.ParameterName =":PAY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PAY_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAY_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_DEPT_EXPENSE", "PAY_MONEY"));
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
		public static DisplayObject_BGT_B_DEPT_EXPENSE[] Query(CauseObject_BGT_B_DEPT_EXPENSE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_EXPENSE.APPLY_DEPT_ID, BGT_B_DEPT_EXPENSE.ID, BGT_B_DEPT_EXPENSE.SUMARRY, BGT_B_DEPT_EXPENSE.MODIFY_USER_ID, BGT_B_DEPT_EXPENSE.INSTANCE_ID, BGT_B_DEPT_EXPENSE.CODE, BGT_B_DEPT_EXPENSE.MODIFY_DEPT_ID, BGT_B_DEPT_EXPENSE.COMMENTS, BGT_B_DEPT_EXPENSE.FINANCE_CYCLE, BGT_B_DEPT_EXPENSE.PAY_DATE, BGT_B_DEPT_EXPENSE.APPLY_USER_ID, BGT_B_DEPT_EXPENSE.CREATE_USER_ID, BGT_B_DEPT_EXPENSE.DATA_ORGANISE_ID, BGT_B_DEPT_EXPENSE.CREATE_TIME, BGT_B_DEPT_EXPENSE.MODIFY_TIME, BGT_B_DEPT_EXPENSE.APPLY_MONEY, BGT_B_DEPT_EXPENSE.PAY_USER_ID, BGT_B_DEPT_EXPENSE.CREATE_DEPT_ID, BGT_B_DEPT_EXPENSE.APPLY_DATE, BGT_B_DEPT_EXPENSE.STATE, BGT_B_DEPT_EXPENSE.PAY_MONEY, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_USER_PAY_USER_ID.NAME as PAY_USER_ID_NAME, (case  when BGT_B_DEPT_EXPENSE.STATE = 0 then '默认值' when BGT_B_DEPT_EXPENSE.STATE = 1 then '编辑中' when BGT_B_DEPT_EXPENSE.STATE = 2 then '已提交' when BGT_B_DEPT_EXPENSE.STATE = 3 then '已审核' when BGT_B_DEPT_EXPENSE.STATE = 4 then '已归档' when BGT_B_DEPT_EXPENSE.STATE = 9 then '已作废' else '' end ) as STATE_NAME from BGT_B_DEPT_EXPENSE left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on BGT_B_DEPT_EXPENSE.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_DEPT_EXPENSE.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_USER   COM_USER_PAY_USER_ID on BGT_B_DEPT_EXPENSE.PAY_USER_ID = COM_USER_PAY_USER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_DEPT_EXPENSE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_EXPENSE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMARRY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMENTS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAY_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.PAY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PAY_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.PAY_USER_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_DEPT_EXPENSE[] objs = new DisplayObject_BGT_B_DEPT_EXPENSE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_DEPT_EXPENSE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_DEPT_EXPENSE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_DEPT_EXPENSE[] Query(CauseObject_BGT_B_DEPT_EXPENSE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_EXPENSE.APPLY_DEPT_ID, BGT_B_DEPT_EXPENSE.ID, BGT_B_DEPT_EXPENSE.SUMARRY, BGT_B_DEPT_EXPENSE.MODIFY_USER_ID, BGT_B_DEPT_EXPENSE.INSTANCE_ID, BGT_B_DEPT_EXPENSE.CODE, BGT_B_DEPT_EXPENSE.MODIFY_DEPT_ID, BGT_B_DEPT_EXPENSE.COMMENTS, BGT_B_DEPT_EXPENSE.FINANCE_CYCLE, BGT_B_DEPT_EXPENSE.PAY_DATE, BGT_B_DEPT_EXPENSE.APPLY_USER_ID, BGT_B_DEPT_EXPENSE.CREATE_USER_ID, BGT_B_DEPT_EXPENSE.DATA_ORGANISE_ID, BGT_B_DEPT_EXPENSE.CREATE_TIME, BGT_B_DEPT_EXPENSE.MODIFY_TIME, BGT_B_DEPT_EXPENSE.APPLY_MONEY, BGT_B_DEPT_EXPENSE.PAY_USER_ID, BGT_B_DEPT_EXPENSE.CREATE_DEPT_ID, BGT_B_DEPT_EXPENSE.APPLY_DATE, BGT_B_DEPT_EXPENSE.STATE, BGT_B_DEPT_EXPENSE.PAY_MONEY, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_USER_PAY_USER_ID.NAME as PAY_USER_ID_NAME, (case  when BGT_B_DEPT_EXPENSE.STATE = 0 then '默认值' when BGT_B_DEPT_EXPENSE.STATE = 1 then '编辑中' when BGT_B_DEPT_EXPENSE.STATE = 2 then '已提交' when BGT_B_DEPT_EXPENSE.STATE = 3 then '已审核' when BGT_B_DEPT_EXPENSE.STATE = 4 then '已归档' when BGT_B_DEPT_EXPENSE.STATE = 9 then '已作废' else '' end ) as STATE_NAME from BGT_B_DEPT_EXPENSE left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on BGT_B_DEPT_EXPENSE.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_DEPT_EXPENSE.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_USER   COM_USER_PAY_USER_ID on BGT_B_DEPT_EXPENSE.PAY_USER_ID = COM_USER_PAY_USER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_DEPT_EXPENSE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_EXPENSE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMARRY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMENTS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAY_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.PAY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PAY_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.PAY_USER_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_DEPT_EXPENSE[] objs = new DisplayObject_BGT_B_DEPT_EXPENSE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_DEPT_EXPENSE[] Query(CauseObject_BGT_B_DEPT_EXPENSE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_EXPENSE.APPLY_DEPT_ID, BGT_B_DEPT_EXPENSE.ID, BGT_B_DEPT_EXPENSE.SUMARRY, BGT_B_DEPT_EXPENSE.MODIFY_USER_ID, BGT_B_DEPT_EXPENSE.INSTANCE_ID, BGT_B_DEPT_EXPENSE.CODE, BGT_B_DEPT_EXPENSE.MODIFY_DEPT_ID, BGT_B_DEPT_EXPENSE.COMMENTS, BGT_B_DEPT_EXPENSE.FINANCE_CYCLE, BGT_B_DEPT_EXPENSE.PAY_DATE, BGT_B_DEPT_EXPENSE.APPLY_USER_ID, BGT_B_DEPT_EXPENSE.CREATE_USER_ID, BGT_B_DEPT_EXPENSE.DATA_ORGANISE_ID, BGT_B_DEPT_EXPENSE.CREATE_TIME, BGT_B_DEPT_EXPENSE.MODIFY_TIME, BGT_B_DEPT_EXPENSE.APPLY_MONEY, BGT_B_DEPT_EXPENSE.PAY_USER_ID, BGT_B_DEPT_EXPENSE.CREATE_DEPT_ID, BGT_B_DEPT_EXPENSE.APPLY_DATE, BGT_B_DEPT_EXPENSE.STATE, BGT_B_DEPT_EXPENSE.PAY_MONEY, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_USER_PAY_USER_ID.NAME as PAY_USER_ID_NAME, (case  when BGT_B_DEPT_EXPENSE.STATE = 0 then '默认值' when BGT_B_DEPT_EXPENSE.STATE = 1 then '编辑中' when BGT_B_DEPT_EXPENSE.STATE = 2 then '已提交' when BGT_B_DEPT_EXPENSE.STATE = 3 then '已审核' when BGT_B_DEPT_EXPENSE.STATE = 4 then '已归档' when BGT_B_DEPT_EXPENSE.STATE = 9 then '已作废' else '' end ) as STATE_NAME from BGT_B_DEPT_EXPENSE left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on BGT_B_DEPT_EXPENSE.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_DEPT_EXPENSE.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_USER   COM_USER_PAY_USER_ID on BGT_B_DEPT_EXPENSE.PAY_USER_ID = COM_USER_PAY_USER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_DEPT_EXPENSE",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_DEPT_EXPENSE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_EXPENSE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMARRY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMENTS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAY_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.PAY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PAY_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.PAY_USER_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_DEPT_EXPENSE[] objs = new DisplayObject_BGT_B_DEPT_EXPENSE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_DEPT_EXPENSE[] Query(CauseObject_BGT_B_DEPT_EXPENSE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_DEPT_EXPENSE.APPLY_DEPT_ID, BGT_B_DEPT_EXPENSE.ID, BGT_B_DEPT_EXPENSE.SUMARRY, BGT_B_DEPT_EXPENSE.MODIFY_USER_ID, BGT_B_DEPT_EXPENSE.INSTANCE_ID, BGT_B_DEPT_EXPENSE.CODE, BGT_B_DEPT_EXPENSE.MODIFY_DEPT_ID, BGT_B_DEPT_EXPENSE.COMMENTS, BGT_B_DEPT_EXPENSE.FINANCE_CYCLE, BGT_B_DEPT_EXPENSE.PAY_DATE, BGT_B_DEPT_EXPENSE.APPLY_USER_ID, BGT_B_DEPT_EXPENSE.CREATE_USER_ID, BGT_B_DEPT_EXPENSE.DATA_ORGANISE_ID, BGT_B_DEPT_EXPENSE.CREATE_TIME, BGT_B_DEPT_EXPENSE.MODIFY_TIME, BGT_B_DEPT_EXPENSE.APPLY_MONEY, BGT_B_DEPT_EXPENSE.PAY_USER_ID, BGT_B_DEPT_EXPENSE.CREATE_DEPT_ID, BGT_B_DEPT_EXPENSE.APPLY_DATE, BGT_B_DEPT_EXPENSE.STATE, BGT_B_DEPT_EXPENSE.PAY_MONEY, COM_DEPART_APPLY_DEPT_ID.NAME as APPLY_DEPT_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, COM_USER_PAY_USER_ID.NAME as PAY_USER_ID_NAME, (case  when BGT_B_DEPT_EXPENSE.STATE = 0 then '默认值' when BGT_B_DEPT_EXPENSE.STATE = 1 then '编辑中' when BGT_B_DEPT_EXPENSE.STATE = 2 then '已提交' when BGT_B_DEPT_EXPENSE.STATE = 3 then '已审核' when BGT_B_DEPT_EXPENSE.STATE = 4 then '已归档' when BGT_B_DEPT_EXPENSE.STATE = 9 then '已作废' else '' end ) as STATE_NAME from BGT_B_DEPT_EXPENSE left join COM_DEPART   COM_DEPART_APPLY_DEPT_ID on BGT_B_DEPT_EXPENSE.APPLY_DEPT_ID = COM_DEPART_APPLY_DEPT_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_DEPT_EXPENSE.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join COM_USER   COM_USER_PAY_USER_ID on BGT_B_DEPT_EXPENSE.PAY_USER_ID = COM_USER_PAY_USER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_DEPT_EXPENSE",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_DEPT_EXPENSE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_DEPT_EXPENSE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.APPLY_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMARRY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMENTS = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PAY_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.PAY_USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PAY_MONEY = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.APPLY_DEPT_ID_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.PAY_USER_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_DEPT_EXPENSE[] objs = new DisplayObject_BGT_B_DEPT_EXPENSE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_DEPT_EXPENSE obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("APPLY_DEPT_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.APPLY_DEPT_ID = :APPLY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":APPLY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_DEPT_ID) ? string.Empty : obj.APPLY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SUMARRY"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.SUMARRY = :SUMARRY");
				param = new OracleParameter();
				param.ParameterName = ":SUMARRY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.SUMARRY) ? string.Empty : obj.SUMARRY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INSTANCE_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.INSTANCE_ID = :INSTANCE_ID");
				param = new OracleParameter();
				param.ParameterName = ":INSTANCE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.INSTANCE_ID) ? string.Empty : obj.INSTANCE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.MODIFY_DEPT_ID = :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_CYCLE"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.FINANCE_CYCLE = :FINANCE_CYCLE");
				param = new OracleParameter();
				param.ParameterName = ":FINANCE_CYCLE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_CYCLE) ? string.Empty : obj.FINANCE_CYCLE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAY_DATE"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.PAY_DATE = :PAY_DATE");
				param = new OracleParameter();
				param.ParameterName = ":PAY_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PAY_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_USER_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.APPLY_USER_ID = :APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_USER_ID) ? string.Empty : obj.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_MONEY"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.APPLY_MONEY = :APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.APPLY_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAY_USER_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.PAY_USER_ID = :PAY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":PAY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PAY_USER_ID) ? string.Empty : obj.PAY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.CREATE_DEPT_ID = :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_DATE"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.APPLY_DATE = :APPLY_DATE");
				param = new OracleParameter();
				param.ParameterName = ":APPLY_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.APPLY_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAY_MONEY"))
			{
				strBuf.Add("  BGT_B_DEPT_EXPENSE.PAY_MONEY = :PAY_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":PAY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PAY_MONEY;
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
