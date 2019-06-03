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
	[CauseObject(typeof(CauseObject_COM_USER))]
	public partial class HelperObject_COM_USER
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_USER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_USER( ID, DEPART_ID, CODE, COMMENTS, CREATE_USER_ID, DATA_ORGANISE_ID, STAFF_ID, CREATE_TIME, CREATE_DEPART_ID, IS_USABLE, STATE, ACCOUNT, NAME, ENTRY_COUNT, LAST_ENTRY_TIME, PASSWORD) values ( :ID, :DEPART_ID, :CODE, :COMMENTS, :CREATE_USER_ID, :DATA_ORGANISE_ID, :STAFF_ID, :CREATE_TIME, :CREATE_DEPART_ID, :IS_USABLE, :STATE, :ACCOUNT, :NAME, :ENTRY_COUNT, :LAST_ENTRY_TIME, :PASSWORD)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[16];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":DEPART_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.DEPART_ID == null ? String.Empty:obj.DEPART_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CODE";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":COMMENTS";
			parameters[3].Size = 200;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":CREATE_USER_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":DATA_ORGANISE_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":STAFF_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.STAFF_ID == null ? String.Empty:obj.STAFF_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CREATE_TIME";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.CREATE_TIME;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CREATE_DEPART_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.CREATE_DEPART_ID == null ? String.Empty:obj.CREATE_DEPART_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":IS_USABLE";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.IS_USABLE;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":STATE";
			parameters[10].Size = 22;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[10].Value = obj.STATE;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":ACCOUNT";
			parameters[11].Size = 50;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.ACCOUNT == null ? String.Empty:obj.ACCOUNT;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":NAME";
			parameters[12].Size = 50;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":ENTRY_COUNT";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.ENTRY_COUNT;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":LAST_ENTRY_TIME";
			parameters[14].Size = 7;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[14].Value = obj.LAST_ENTRY_TIME;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":PASSWORD";
			parameters[15].Size = 50;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.PASSWORD == null ? String.Empty:obj.PASSWORD;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_USER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_USER set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_USER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_USER where  ID = :ID ";
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
		public static EntityObject_COM_USER Get(EntityObject_COM_USER obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, MODIFY_USER_ID, DEPART_ID, CODE, COMMENTS, CREATE_USER_ID, DATA_ORGANISE_ID, STAFF_ID, CREATE_TIME, MODIFY_TIME, MODIFY_DEPART_ID, CREATE_DEPART_ID, IS_USABLE, STATE, ACCOUNT, NAME, ENTRY_COUNT, LAST_ENTRY_TIME, PASSWORD from COM_USER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPART_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACCOUNT = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ENTRY_COUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.LAST_ENTRY_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PASSWORD = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_USER[] objs = new EntityObject_COM_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_USER Get(EntityObject_COM_USER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, MODIFY_USER_ID, DEPART_ID, CODE, COMMENTS, CREATE_USER_ID, DATA_ORGANISE_ID, STAFF_ID, CREATE_TIME, MODIFY_TIME, MODIFY_DEPART_ID, CREATE_DEPART_ID, IS_USABLE, STATE, ACCOUNT, NAME, ENTRY_COUNT, LAST_ENTRY_TIME, PASSWORD from COM_USER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPART_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACCOUNT = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ENTRY_COUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.LAST_ENTRY_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PASSWORD = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_USER[] objs = new EntityObject_COM_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_USER[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_USER.ID, COM_USER.MODIFY_USER_ID, COM_USER.DEPART_ID, COM_USER.CODE, COM_USER.COMMENTS, COM_USER.CREATE_USER_ID, COM_USER.DATA_ORGANISE_ID, COM_USER.STAFF_ID, COM_USER.CREATE_TIME, COM_USER.MODIFY_TIME, COM_USER.MODIFY_DEPART_ID, COM_USER.CREATE_DEPART_ID, COM_USER.IS_USABLE, COM_USER.STATE, COM_USER.ACCOUNT, COM_USER.NAME, COM_USER.ENTRY_COUNT, COM_USER.LAST_ENTRY_TIME, COM_USER.PASSWORD, COM_DEPART_DEPART_ID.NAME as DEPART_ID_NAME, (case  when COM_USER.IS_USABLE = 1 then '是' when COM_USER.IS_USABLE = 2 then '否' else '' end ) as IS_USABLE_NAME from COM_USER left join COM_DEPART   COM_DEPART_DEPART_ID on COM_USER.DEPART_ID = COM_DEPART_DEPART_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPART_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACCOUNT = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ENTRY_COUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.LAST_ENTRY_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PASSWORD = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DEPART_ID_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_USABLE_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_USER[] objs = new DisplayObject_COM_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_USER cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And COM_USER.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And COM_USER.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DEPART_ID))
			{
				strBuf.Append(" And COM_USER.DEPART_ID ").Append((cause.DEPART_ID.StartsWith("%") || cause.DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And COM_USER.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And COM_USER.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And COM_USER.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And COM_USER.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_ID))
			{
				strBuf.Append(" And COM_USER.STAFF_ID ").Append((cause.STAFF_ID.StartsWith("%") || cause.STAFF_ID.EndsWith("%")) ? " like " : " = ").Append(" :STAFF_ID");
				param = new OracleParameter();
				param.ParameterName =":STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "STAFF_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And COM_USER.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And COM_USER.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("COM_USER", "CREATE_TIME"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And COM_USER.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And COM_USER.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("COM_USER", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And COM_USER.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "MODIFY_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And COM_USER.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "CREATE_DEPART_ID"));
			}
			if(cause.IS_USABLE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_USER.IS_USABLE = :IS_USABLE");
				param = new OracleParameter();
				param.ParameterName =":IS_USABLE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_USABLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_USABLE"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "IS_USABLE"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_USER.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.ACCOUNT))
			{
				strBuf.Append(" And COM_USER.ACCOUNT ").Append((cause.ACCOUNT.StartsWith("%") || cause.ACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :ACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "ACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And COM_USER.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "NAME"));
			}
			if(cause.ENTRY_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_USER.ENTRY_COUNT = :ENTRY_COUNT");
				param = new OracleParameter();
				param.ParameterName =":ENTRY_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ENTRY_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("ENTRY_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "ENTRY_COUNT"));
			}
			if(cause.LAST_ENTRY_TIME!= null)
			{
				if (cause.LAST_ENTRY_TIME.Begin != null)
				{
					strBuf.Append(" And COM_USER.LAST_ENTRY_TIME >= :LAST_ENTRY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":LAST_ENTRY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.LAST_ENTRY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.LAST_ENTRY_TIME.End != null)
				{
					strBuf.Append(" And COM_USER.LAST_ENTRY_TIME < :LAST_ENTRY_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":LAST_ENTRY_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.LAST_ENTRY_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("LAST_ENTRY_TIME"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "LAST_ENTRY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.PASSWORD))
			{
				strBuf.Append(" And COM_USER.PASSWORD ").Append((cause.PASSWORD.StartsWith("%") || cause.PASSWORD.EndsWith("%")) ? " like " : " = ").Append(" :PASSWORD");
				param = new OracleParameter();
				param.ParameterName =":PASSWORD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PASSWORD;
				paramList.Add(param);
			}
			if (cause.HasINValue("PASSWORD"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER", "PASSWORD"));
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
		public static DisplayObject_COM_USER[] Query(CauseObject_COM_USER cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_USER.ID, COM_USER.MODIFY_USER_ID, COM_USER.DEPART_ID, COM_USER.CODE, COM_USER.COMMENTS, COM_USER.CREATE_USER_ID, COM_USER.DATA_ORGANISE_ID, COM_USER.STAFF_ID, COM_USER.CREATE_TIME, COM_USER.MODIFY_TIME, COM_USER.MODIFY_DEPART_ID, COM_USER.CREATE_DEPART_ID, COM_USER.IS_USABLE, COM_USER.STATE, COM_USER.ACCOUNT, COM_USER.NAME, COM_USER.ENTRY_COUNT, COM_USER.LAST_ENTRY_TIME, COM_USER.PASSWORD, COM_DEPART_DEPART_ID.NAME as DEPART_ID_NAME, (case  when COM_USER.IS_USABLE = 1 then '是' when COM_USER.IS_USABLE = 2 then '否' else '' end ) as IS_USABLE_NAME from COM_USER left join COM_DEPART   COM_DEPART_DEPART_ID on COM_USER.DEPART_ID = COM_DEPART_DEPART_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPART_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACCOUNT = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ENTRY_COUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.LAST_ENTRY_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PASSWORD = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DEPART_ID_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_USABLE_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_USER[] objs = new DisplayObject_COM_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_USER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_USER where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_USER[] Query(CauseObject_COM_USER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_USER.ID, COM_USER.MODIFY_USER_ID, COM_USER.DEPART_ID, COM_USER.CODE, COM_USER.COMMENTS, COM_USER.CREATE_USER_ID, COM_USER.DATA_ORGANISE_ID, COM_USER.STAFF_ID, COM_USER.CREATE_TIME, COM_USER.MODIFY_TIME, COM_USER.MODIFY_DEPART_ID, COM_USER.CREATE_DEPART_ID, COM_USER.IS_USABLE, COM_USER.STATE, COM_USER.ACCOUNT, COM_USER.NAME, COM_USER.ENTRY_COUNT, COM_USER.LAST_ENTRY_TIME, COM_USER.PASSWORD, COM_DEPART_DEPART_ID.NAME as DEPART_ID_NAME, (case  when COM_USER.IS_USABLE = 1 then '是' when COM_USER.IS_USABLE = 2 then '否' else '' end ) as IS_USABLE_NAME from COM_USER left join COM_DEPART   COM_DEPART_DEPART_ID on COM_USER.DEPART_ID = COM_DEPART_DEPART_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPART_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACCOUNT = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ENTRY_COUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.LAST_ENTRY_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PASSWORD = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DEPART_ID_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_USABLE_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_USER[] objs = new DisplayObject_COM_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_USER[] Query(CauseObject_COM_USER cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_USER.ID, COM_USER.MODIFY_USER_ID, COM_USER.DEPART_ID, COM_USER.CODE, COM_USER.COMMENTS, COM_USER.CREATE_USER_ID, COM_USER.DATA_ORGANISE_ID, COM_USER.STAFF_ID, COM_USER.CREATE_TIME, COM_USER.MODIFY_TIME, COM_USER.MODIFY_DEPART_ID, COM_USER.CREATE_DEPART_ID, COM_USER.IS_USABLE, COM_USER.STATE, COM_USER.ACCOUNT, COM_USER.NAME, COM_USER.ENTRY_COUNT, COM_USER.LAST_ENTRY_TIME, COM_USER.PASSWORD, COM_DEPART_DEPART_ID.NAME as DEPART_ID_NAME, (case  when COM_USER.IS_USABLE = 1 then '是' when COM_USER.IS_USABLE = 2 then '否' else '' end ) as IS_USABLE_NAME from COM_USER left join COM_DEPART   COM_DEPART_DEPART_ID on COM_USER.DEPART_ID = COM_DEPART_DEPART_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_USER",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPART_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACCOUNT = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ENTRY_COUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.LAST_ENTRY_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PASSWORD = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DEPART_ID_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_USABLE_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_USER[] objs = new DisplayObject_COM_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_USER[] Query(CauseObject_COM_USER cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_USER.ID, COM_USER.MODIFY_USER_ID, COM_USER.DEPART_ID, COM_USER.CODE, COM_USER.COMMENTS, COM_USER.CREATE_USER_ID, COM_USER.DATA_ORGANISE_ID, COM_USER.STAFF_ID, COM_USER.CREATE_TIME, COM_USER.MODIFY_TIME, COM_USER.MODIFY_DEPART_ID, COM_USER.CREATE_DEPART_ID, COM_USER.IS_USABLE, COM_USER.STATE, COM_USER.ACCOUNT, COM_USER.NAME, COM_USER.ENTRY_COUNT, COM_USER.LAST_ENTRY_TIME, COM_USER.PASSWORD, COM_DEPART_DEPART_ID.NAME as DEPART_ID_NAME, (case  when COM_USER.IS_USABLE = 1 then '是' when COM_USER.IS_USABLE = 2 then '否' else '' end ) as IS_USABLE_NAME from COM_USER left join COM_DEPART   COM_DEPART_DEPART_ID on COM_USER.DEPART_ID = COM_DEPART_DEPART_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_USER",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPART_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ACCOUNT = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ENTRY_COUNT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.LAST_ENTRY_TIME = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PASSWORD = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DEPART_ID_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_USABLE_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_USER[] objs = new DisplayObject_COM_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_USER obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  COM_USER.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPART_ID"))
			{
				strBuf.Add("  COM_USER.DEPART_ID = :DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPART_ID) ? string.Empty : obj.DEPART_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  COM_USER.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  COM_USER.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  COM_USER.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STAFF_ID"))
			{
				strBuf.Add("  COM_USER.STAFF_ID = :STAFF_ID");
				param = new OracleParameter();
				param.ParameterName = ":STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.STAFF_ID) ? string.Empty : obj.STAFF_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  COM_USER.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  COM_USER.MODIFY_DEPART_ID = :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_USABLE"))
			{
				strBuf.Add("  COM_USER.IS_USABLE = :IS_USABLE");
				param = new OracleParameter();
				param.ParameterName = ":IS_USABLE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_USABLE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  COM_USER.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ACCOUNT"))
			{
				strBuf.Add("  COM_USER.ACCOUNT = :ACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ACCOUNT) ? string.Empty : obj.ACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  COM_USER.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ENTRY_COUNT"))
			{
				strBuf.Add("  COM_USER.ENTRY_COUNT = :ENTRY_COUNT");
				param = new OracleParameter();
				param.ParameterName = ":ENTRY_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ENTRY_COUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LAST_ENTRY_TIME"))
			{
				strBuf.Add("  COM_USER.LAST_ENTRY_TIME = :LAST_ENTRY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":LAST_ENTRY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.LAST_ENTRY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PASSWORD"))
			{
				strBuf.Add("  COM_USER.PASSWORD = :PASSWORD");
				param = new OracleParameter();
				param.ParameterName = ":PASSWORD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PASSWORD) ? string.Empty : obj.PASSWORD;
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
