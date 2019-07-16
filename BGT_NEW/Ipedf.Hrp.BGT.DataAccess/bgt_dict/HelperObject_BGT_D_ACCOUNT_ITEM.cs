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
	[CauseObject(typeof(CauseObject_BGT_D_ACCOUNT_ITEM))]
	public partial class HelperObject_BGT_D_ACCOUNT_ITEM
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_D_ACCOUNT_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_D_ACCOUNT_ITEM( PROPERTY_ID, ID, CODE, MODIFY_DEPT_ID, COMMENTS, CREATE_USER_ID, PARENT_ID, DATA_ORGANISE_ID, CREATE_TIME, NAME, FULL_NAME, IS_ASSSIST, CREATE_DEPT_ID, STATE, DIRECTION_ID, IS_END, ITEM_TYPE_ID, IS_CASH) values ( :PROPERTY_ID, :ID, :CODE, :MODIFY_DEPT_ID, :COMMENTS, :CREATE_USER_ID, :PARENT_ID, :DATA_ORGANISE_ID, :CREATE_TIME, :NAME, :FULL_NAME, :IS_ASSSIST, :CREATE_DEPT_ID, :STATE, :DIRECTION_ID, :IS_END, :ITEM_TYPE_ID, :IS_CASH)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[18];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":PROPERTY_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.PROPERTY_ID == null ? String.Empty:obj.PROPERTY_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CODE";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":MODIFY_DEPT_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":COMMENTS";
			parameters[4].Size = 200;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":CREATE_USER_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":PARENT_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.PARENT_ID == null ? String.Empty:obj.PARENT_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":DATA_ORGANISE_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CREATE_TIME";
			parameters[8].Size = 7;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[8].Value = obj.CREATE_TIME;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":NAME";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":FULL_NAME";
			parameters[10].Size = 100;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.FULL_NAME == null ? String.Empty:obj.FULL_NAME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":IS_ASSSIST";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.IS_ASSSIST;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":CREATE_DEPT_ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":STATE";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.STATE;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":DIRECTION_ID";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.DIRECTION_ID == null ? String.Empty:obj.DIRECTION_ID;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":IS_END";
			parameters[15].Size = 36;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[15].Value = obj.IS_END == null ? String.Empty:obj.IS_END;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":ITEM_TYPE_ID";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.ITEM_TYPE_ID == null ? String.Empty:obj.ITEM_TYPE_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":IS_CASH";
			parameters[17].Size = 22;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[17].Value = obj.IS_CASH;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_D_ACCOUNT_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_D_ACCOUNT_ITEM set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_D_ACCOUNT_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_D_ACCOUNT_ITEM where  ID = :ID ";
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
		public static EntityObject_BGT_D_ACCOUNT_ITEM Get(EntityObject_BGT_D_ACCOUNT_ITEM obj)
		{
			
			//平台自动生成代码
			string sSql = "select  PROPERTY_ID, ID, MODIFY_USER_ID, CODE, MODIFY_DEPT_ID, COMMENTS, CREATE_USER_ID, PARENT_ID, DATA_ORGANISE_ID, CREATE_TIME, NAME, FULL_NAME, IS_ASSSIST, CREATE_DEPT_ID, MODIFY_TIME, STATE, DIRECTION_ID, IS_END, ITEM_TYPE_ID, IS_CASH from BGT_D_ACCOUNT_ITEM where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_D_ACCOUNT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_D_ACCOUNT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PROPERTY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARENT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FULL_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_ASSSIST = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DIRECTION_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_END = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_CASH = sqlReader.GetDecimal(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_D_ACCOUNT_ITEM[] objs = new EntityObject_BGT_D_ACCOUNT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_D_ACCOUNT_ITEM Get(EntityObject_BGT_D_ACCOUNT_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  PROPERTY_ID, ID, MODIFY_USER_ID, CODE, MODIFY_DEPT_ID, COMMENTS, CREATE_USER_ID, PARENT_ID, DATA_ORGANISE_ID, CREATE_TIME, NAME, FULL_NAME, IS_ASSSIST, CREATE_DEPT_ID, MODIFY_TIME, STATE, DIRECTION_ID, IS_END, ITEM_TYPE_ID, IS_CASH from BGT_D_ACCOUNT_ITEM where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_D_ACCOUNT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_D_ACCOUNT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PROPERTY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARENT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FULL_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_ASSSIST = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DIRECTION_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_END = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_CASH = sqlReader.GetDecimal(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_D_ACCOUNT_ITEM[] objs = new EntityObject_BGT_D_ACCOUNT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_D_ACCOUNT_ITEM[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_D_ACCOUNT_ITEM.PROPERTY_ID, BGT_D_ACCOUNT_ITEM.ID, BGT_D_ACCOUNT_ITEM.MODIFY_USER_ID, BGT_D_ACCOUNT_ITEM.CODE, BGT_D_ACCOUNT_ITEM.MODIFY_DEPT_ID, BGT_D_ACCOUNT_ITEM.COMMENTS, BGT_D_ACCOUNT_ITEM.CREATE_USER_ID, BGT_D_ACCOUNT_ITEM.PARENT_ID, BGT_D_ACCOUNT_ITEM.DATA_ORGANISE_ID, BGT_D_ACCOUNT_ITEM.CREATE_TIME, BGT_D_ACCOUNT_ITEM.NAME, BGT_D_ACCOUNT_ITEM.FULL_NAME, BGT_D_ACCOUNT_ITEM.IS_ASSSIST, BGT_D_ACCOUNT_ITEM.CREATE_DEPT_ID, BGT_D_ACCOUNT_ITEM.MODIFY_TIME, BGT_D_ACCOUNT_ITEM.STATE, BGT_D_ACCOUNT_ITEM.DIRECTION_ID, BGT_D_ACCOUNT_ITEM.IS_END, BGT_D_ACCOUNT_ITEM.ITEM_TYPE_ID, BGT_D_ACCOUNT_ITEM.IS_CASH, COM_TYPE_PROPERTY_ID.NAME as PROPERTY_ID_NAME, SELF_T.NAME as PARENT_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_ASSSIST = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_ASSSIST = 2 then '否' else '' end ) as IS_ASSSIST_NAME, COM_TYPE_DIRECTION_ID.NAME as DIRECTION_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_END = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_END = 2 then '否' else '' end ) as IS_END_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_CASH = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_CASH = 2 then '否' else '' end ) as IS_CASH_NAME from BGT_D_ACCOUNT_ITEM left join COM_TYPE   COM_TYPE_PROPERTY_ID on BGT_D_ACCOUNT_ITEM.PROPERTY_ID = COM_TYPE_PROPERTY_ID.ID left join BGT_D_ACCOUNT_ITEM   SELF_T on BGT_D_ACCOUNT_ITEM.PARENT_ID = SELF_T.ID left join COM_TYPE   COM_TYPE_DIRECTION_ID on BGT_D_ACCOUNT_ITEM.DIRECTION_ID = COM_TYPE_DIRECTION_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_ACCOUNT_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_D_ACCOUNT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_ACCOUNT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PROPERTY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARENT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FULL_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_ASSSIST = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DIRECTION_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_END = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_CASH = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PROPERTY_ID_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IS_ASSSIST_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DIRECTION_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.IS_END_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.IS_CASH_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_ACCOUNT_ITEM[] objs = new DisplayObject_BGT_D_ACCOUNT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_D_ACCOUNT_ITEM cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.PROPERTY_ID))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.PROPERTY_ID ").Append((cause.PROPERTY_ID.StartsWith("%") || cause.PROPERTY_ID.EndsWith("%")) ? " like " : " = ").Append(" :PROPERTY_ID");
				param = new OracleParameter();
				param.ParameterName =":PROPERTY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PROPERTY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PROPERTY_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "PROPERTY_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "MODIFY_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PARENT_ID))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.PARENT_ID ").Append((cause.PARENT_ID.StartsWith("%") || cause.PARENT_ID.EndsWith("%")) ? " like " : " = ").Append(" :PARENT_ID");
				param = new OracleParameter();
				param.ParameterName =":PARENT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PARENT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PARENT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "PARENT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "DATA_ORGANISE_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And BGT_D_ACCOUNT_ITEM.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And BGT_D_ACCOUNT_ITEM.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.FULL_NAME))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.FULL_NAME ").Append((cause.FULL_NAME.StartsWith("%") || cause.FULL_NAME.EndsWith("%")) ? " like " : " = ").Append(" :FULL_NAME");
				param = new OracleParameter();
				param.ParameterName =":FULL_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.FULL_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("FULL_NAME"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "FULL_NAME"));
			}
			if(cause.IS_ASSSIST!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.IS_ASSSIST = :IS_ASSSIST");
				param = new OracleParameter();
				param.ParameterName =":IS_ASSSIST";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_ASSSIST;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_ASSSIST"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "IS_ASSSIST"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "CREATE_DEPT_ID"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And BGT_D_ACCOUNT_ITEM.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And BGT_D_ACCOUNT_ITEM.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "MODIFY_TIME"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.DIRECTION_ID))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.DIRECTION_ID ").Append((cause.DIRECTION_ID.StartsWith("%") || cause.DIRECTION_ID.EndsWith("%")) ? " like " : " = ").Append(" :DIRECTION_ID");
				param = new OracleParameter();
				param.ParameterName =":DIRECTION_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DIRECTION_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DIRECTION_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "DIRECTION_ID"));
			}
			if(!string.IsNullOrEmpty(cause.IS_END))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.IS_END ").Append((cause.IS_END.StartsWith("%") || cause.IS_END.EndsWith("%")) ? " like " : " = ").Append(" :IS_END");
				param = new OracleParameter();
				param.ParameterName =":IS_END";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.IS_END;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_END"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "IS_END"));
			}
			if(!string.IsNullOrEmpty(cause.ITEM_TYPE_ID))
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.ITEM_TYPE_ID ").Append((cause.ITEM_TYPE_ID.StartsWith("%") || cause.ITEM_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "ITEM_TYPE_ID"));
			}
			if(cause.IS_CASH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_D_ACCOUNT_ITEM.IS_CASH = :IS_CASH");
				param = new OracleParameter();
				param.ParameterName =":IS_CASH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_CASH;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_CASH"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_ACCOUNT_ITEM", "IS_CASH"));
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
		public static DisplayObject_BGT_D_ACCOUNT_ITEM[] Query(CauseObject_BGT_D_ACCOUNT_ITEM cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_D_ACCOUNT_ITEM.PROPERTY_ID, BGT_D_ACCOUNT_ITEM.ID, BGT_D_ACCOUNT_ITEM.MODIFY_USER_ID, BGT_D_ACCOUNT_ITEM.CODE, BGT_D_ACCOUNT_ITEM.MODIFY_DEPT_ID, BGT_D_ACCOUNT_ITEM.COMMENTS, BGT_D_ACCOUNT_ITEM.CREATE_USER_ID, BGT_D_ACCOUNT_ITEM.PARENT_ID, BGT_D_ACCOUNT_ITEM.DATA_ORGANISE_ID, BGT_D_ACCOUNT_ITEM.CREATE_TIME, BGT_D_ACCOUNT_ITEM.NAME, BGT_D_ACCOUNT_ITEM.FULL_NAME, BGT_D_ACCOUNT_ITEM.IS_ASSSIST, BGT_D_ACCOUNT_ITEM.CREATE_DEPT_ID, BGT_D_ACCOUNT_ITEM.MODIFY_TIME, BGT_D_ACCOUNT_ITEM.STATE, BGT_D_ACCOUNT_ITEM.DIRECTION_ID, BGT_D_ACCOUNT_ITEM.IS_END, BGT_D_ACCOUNT_ITEM.ITEM_TYPE_ID, BGT_D_ACCOUNT_ITEM.IS_CASH, COM_TYPE_PROPERTY_ID.NAME as PROPERTY_ID_NAME, SELF_T.NAME as PARENT_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_ASSSIST = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_ASSSIST = 2 then '否' else '' end ) as IS_ASSSIST_NAME, COM_TYPE_DIRECTION_ID.NAME as DIRECTION_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_END = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_END = 2 then '否' else '' end ) as IS_END_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_CASH = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_CASH = 2 then '否' else '' end ) as IS_CASH_NAME from BGT_D_ACCOUNT_ITEM left join COM_TYPE   COM_TYPE_PROPERTY_ID on BGT_D_ACCOUNT_ITEM.PROPERTY_ID = COM_TYPE_PROPERTY_ID.ID left join BGT_D_ACCOUNT_ITEM   SELF_T on BGT_D_ACCOUNT_ITEM.PARENT_ID = SELF_T.ID left join COM_TYPE   COM_TYPE_DIRECTION_ID on BGT_D_ACCOUNT_ITEM.DIRECTION_ID = COM_TYPE_DIRECTION_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_ACCOUNT_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_D_ACCOUNT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_ACCOUNT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PROPERTY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARENT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FULL_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_ASSSIST = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DIRECTION_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_END = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_CASH = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PROPERTY_ID_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IS_ASSSIST_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DIRECTION_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.IS_END_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.IS_CASH_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_ACCOUNT_ITEM[] objs = new DisplayObject_BGT_D_ACCOUNT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_D_ACCOUNT_ITEM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_D_ACCOUNT_ITEM where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_D_ACCOUNT_ITEM[] Query(CauseObject_BGT_D_ACCOUNT_ITEM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_D_ACCOUNT_ITEM.PROPERTY_ID, BGT_D_ACCOUNT_ITEM.ID, BGT_D_ACCOUNT_ITEM.MODIFY_USER_ID, BGT_D_ACCOUNT_ITEM.CODE, BGT_D_ACCOUNT_ITEM.MODIFY_DEPT_ID, BGT_D_ACCOUNT_ITEM.COMMENTS, BGT_D_ACCOUNT_ITEM.CREATE_USER_ID, BGT_D_ACCOUNT_ITEM.PARENT_ID, BGT_D_ACCOUNT_ITEM.DATA_ORGANISE_ID, BGT_D_ACCOUNT_ITEM.CREATE_TIME, BGT_D_ACCOUNT_ITEM.NAME, BGT_D_ACCOUNT_ITEM.FULL_NAME, BGT_D_ACCOUNT_ITEM.IS_ASSSIST, BGT_D_ACCOUNT_ITEM.CREATE_DEPT_ID, BGT_D_ACCOUNT_ITEM.MODIFY_TIME, BGT_D_ACCOUNT_ITEM.STATE, BGT_D_ACCOUNT_ITEM.DIRECTION_ID, BGT_D_ACCOUNT_ITEM.IS_END, BGT_D_ACCOUNT_ITEM.ITEM_TYPE_ID, BGT_D_ACCOUNT_ITEM.IS_CASH, COM_TYPE_PROPERTY_ID.NAME as PROPERTY_ID_NAME, SELF_T.NAME as PARENT_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_ASSSIST = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_ASSSIST = 2 then '否' else '' end ) as IS_ASSSIST_NAME, COM_TYPE_DIRECTION_ID.NAME as DIRECTION_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_END = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_END = 2 then '否' else '' end ) as IS_END_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_CASH = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_CASH = 2 then '否' else '' end ) as IS_CASH_NAME from BGT_D_ACCOUNT_ITEM left join COM_TYPE   COM_TYPE_PROPERTY_ID on BGT_D_ACCOUNT_ITEM.PROPERTY_ID = COM_TYPE_PROPERTY_ID.ID left join BGT_D_ACCOUNT_ITEM   SELF_T on BGT_D_ACCOUNT_ITEM.PARENT_ID = SELF_T.ID left join COM_TYPE   COM_TYPE_DIRECTION_ID on BGT_D_ACCOUNT_ITEM.DIRECTION_ID = COM_TYPE_DIRECTION_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_ACCOUNT_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_D_ACCOUNT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_ACCOUNT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PROPERTY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARENT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FULL_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_ASSSIST = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DIRECTION_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_END = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_CASH = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PROPERTY_ID_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IS_ASSSIST_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DIRECTION_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.IS_END_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.IS_CASH_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_D_ACCOUNT_ITEM[] objs = new DisplayObject_BGT_D_ACCOUNT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_D_ACCOUNT_ITEM[] Query(CauseObject_BGT_D_ACCOUNT_ITEM cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_D_ACCOUNT_ITEM.PROPERTY_ID, BGT_D_ACCOUNT_ITEM.ID, BGT_D_ACCOUNT_ITEM.MODIFY_USER_ID, BGT_D_ACCOUNT_ITEM.CODE, BGT_D_ACCOUNT_ITEM.MODIFY_DEPT_ID, BGT_D_ACCOUNT_ITEM.COMMENTS, BGT_D_ACCOUNT_ITEM.CREATE_USER_ID, BGT_D_ACCOUNT_ITEM.PARENT_ID, BGT_D_ACCOUNT_ITEM.DATA_ORGANISE_ID, BGT_D_ACCOUNT_ITEM.CREATE_TIME, BGT_D_ACCOUNT_ITEM.NAME, BGT_D_ACCOUNT_ITEM.FULL_NAME, BGT_D_ACCOUNT_ITEM.IS_ASSSIST, BGT_D_ACCOUNT_ITEM.CREATE_DEPT_ID, BGT_D_ACCOUNT_ITEM.MODIFY_TIME, BGT_D_ACCOUNT_ITEM.STATE, BGT_D_ACCOUNT_ITEM.DIRECTION_ID, BGT_D_ACCOUNT_ITEM.IS_END, BGT_D_ACCOUNT_ITEM.ITEM_TYPE_ID, BGT_D_ACCOUNT_ITEM.IS_CASH, COM_TYPE_PROPERTY_ID.NAME as PROPERTY_ID_NAME, SELF_T.NAME as PARENT_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_ASSSIST = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_ASSSIST = 2 then '否' else '' end ) as IS_ASSSIST_NAME, COM_TYPE_DIRECTION_ID.NAME as DIRECTION_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_END = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_END = 2 then '否' else '' end ) as IS_END_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_CASH = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_CASH = 2 then '否' else '' end ) as IS_CASH_NAME from BGT_D_ACCOUNT_ITEM left join COM_TYPE   COM_TYPE_PROPERTY_ID on BGT_D_ACCOUNT_ITEM.PROPERTY_ID = COM_TYPE_PROPERTY_ID.ID left join BGT_D_ACCOUNT_ITEM   SELF_T on BGT_D_ACCOUNT_ITEM.PARENT_ID = SELF_T.ID left join COM_TYPE   COM_TYPE_DIRECTION_ID on BGT_D_ACCOUNT_ITEM.DIRECTION_ID = COM_TYPE_DIRECTION_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_ACCOUNT_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_ACCOUNT_ITEM",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_D_ACCOUNT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_ACCOUNT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PROPERTY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARENT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FULL_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_ASSSIST = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DIRECTION_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_END = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_CASH = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PROPERTY_ID_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IS_ASSSIST_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DIRECTION_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.IS_END_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.IS_CASH_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_ACCOUNT_ITEM[] objs = new DisplayObject_BGT_D_ACCOUNT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_D_ACCOUNT_ITEM[] Query(CauseObject_BGT_D_ACCOUNT_ITEM cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_D_ACCOUNT_ITEM.PROPERTY_ID, BGT_D_ACCOUNT_ITEM.ID, BGT_D_ACCOUNT_ITEM.MODIFY_USER_ID, BGT_D_ACCOUNT_ITEM.CODE, BGT_D_ACCOUNT_ITEM.MODIFY_DEPT_ID, BGT_D_ACCOUNT_ITEM.COMMENTS, BGT_D_ACCOUNT_ITEM.CREATE_USER_ID, BGT_D_ACCOUNT_ITEM.PARENT_ID, BGT_D_ACCOUNT_ITEM.DATA_ORGANISE_ID, BGT_D_ACCOUNT_ITEM.CREATE_TIME, BGT_D_ACCOUNT_ITEM.NAME, BGT_D_ACCOUNT_ITEM.FULL_NAME, BGT_D_ACCOUNT_ITEM.IS_ASSSIST, BGT_D_ACCOUNT_ITEM.CREATE_DEPT_ID, BGT_D_ACCOUNT_ITEM.MODIFY_TIME, BGT_D_ACCOUNT_ITEM.STATE, BGT_D_ACCOUNT_ITEM.DIRECTION_ID, BGT_D_ACCOUNT_ITEM.IS_END, BGT_D_ACCOUNT_ITEM.ITEM_TYPE_ID, BGT_D_ACCOUNT_ITEM.IS_CASH, COM_TYPE_PROPERTY_ID.NAME as PROPERTY_ID_NAME, SELF_T.NAME as PARENT_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_ASSSIST = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_ASSSIST = 2 then '否' else '' end ) as IS_ASSSIST_NAME, COM_TYPE_DIRECTION_ID.NAME as DIRECTION_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_END = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_END = 2 then '否' else '' end ) as IS_END_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME, (case  when BGT_D_ACCOUNT_ITEM.IS_CASH = 1 then '是' when BGT_D_ACCOUNT_ITEM.IS_CASH = 2 then '否' else '' end ) as IS_CASH_NAME from BGT_D_ACCOUNT_ITEM left join COM_TYPE   COM_TYPE_PROPERTY_ID on BGT_D_ACCOUNT_ITEM.PROPERTY_ID = COM_TYPE_PROPERTY_ID.ID left join BGT_D_ACCOUNT_ITEM   SELF_T on BGT_D_ACCOUNT_ITEM.PARENT_ID = SELF_T.ID left join COM_TYPE   COM_TYPE_DIRECTION_ID on BGT_D_ACCOUNT_ITEM.DIRECTION_ID = COM_TYPE_DIRECTION_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_ACCOUNT_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_ACCOUNT_ITEM",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_D_ACCOUNT_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_ACCOUNT_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PROPERTY_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARENT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FULL_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_ASSSIST = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DIRECTION_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_END = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_CASH = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PROPERTY_ID_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IS_ASSSIST_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DIRECTION_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.IS_END_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.IS_CASH_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_D_ACCOUNT_ITEM[] objs = new DisplayObject_BGT_D_ACCOUNT_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_D_ACCOUNT_ITEM obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("PROPERTY_ID"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.PROPERTY_ID = :PROPERTY_ID");
				param = new OracleParameter();
				param.ParameterName = ":PROPERTY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PROPERTY_ID) ? string.Empty : obj.PROPERTY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.MODIFY_DEPT_ID = :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PARENT_ID"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.PARENT_ID = :PARENT_ID");
				param = new OracleParameter();
				param.ParameterName = ":PARENT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PARENT_ID) ? string.Empty : obj.PARENT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FULL_NAME"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.FULL_NAME = :FULL_NAME");
				param = new OracleParameter();
				param.ParameterName = ":FULL_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.FULL_NAME) ? string.Empty : obj.FULL_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_ASSSIST"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.IS_ASSSIST = :IS_ASSSIST");
				param = new OracleParameter();
				param.ParameterName = ":IS_ASSSIST";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_ASSSIST;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.CREATE_DEPT_ID = :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DIRECTION_ID"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.DIRECTION_ID = :DIRECTION_ID");
				param = new OracleParameter();
				param.ParameterName = ":DIRECTION_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DIRECTION_ID) ? string.Empty : obj.DIRECTION_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_END"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.IS_END = :IS_END");
				param = new OracleParameter();
				param.ParameterName = ":IS_END";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.IS_END) ? string.Empty : obj.IS_END;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_TYPE_ID"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.ITEM_TYPE_ID = :ITEM_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_TYPE_ID) ? string.Empty : obj.ITEM_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_CASH"))
			{
				strBuf.Add("  BGT_D_ACCOUNT_ITEM.IS_CASH = :IS_CASH");
				param = new OracleParameter();
				param.ParameterName = ":IS_CASH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_CASH;
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
