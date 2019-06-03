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
	[CauseObject(typeof(CauseObject_COM_DEPART))]
	public partial class HelperObject_COM_DEPART
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_DEPART obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_DEPART( ID, IS_USABLE, CODE, POST_CODE, COMMENTS, SUMMARY, CREATE_USER_ID, PARENT_ID, DATA_ORGANISE_ID, DROP_DATE, ADDRESS, HEAD_USER_ID, CREATE_DEPART_ID, PHONE, FAX, CREATE_DATE, STATE, CREATE_TIME, TYPE, NAME) values ( :ID, :IS_USABLE, :CODE, :POST_CODE, :COMMENTS, :SUMMARY, :CREATE_USER_ID, :PARENT_ID, :DATA_ORGANISE_ID, :DROP_DATE, :ADDRESS, :HEAD_USER_ID, :CREATE_DEPART_ID, :PHONE, :FAX, :CREATE_DATE, :STATE, :CREATE_TIME, :TYPE, :NAME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[20];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":IS_USABLE";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.IS_USABLE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CODE";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":POST_CODE";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.POST_CODE == null ? String.Empty:obj.POST_CODE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":COMMENTS";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":SUMMARY";
			parameters[5].Size = 200;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.SUMMARY == null ? String.Empty:obj.SUMMARY;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":CREATE_USER_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":PARENT_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.PARENT_ID == null ? String.Empty:obj.PARENT_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":DATA_ORGANISE_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":DROP_DATE";
			parameters[9].Size = 7;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[9].Value = obj.DROP_DATE;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":ADDRESS";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.ADDRESS == null ? String.Empty:obj.ADDRESS;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":HEAD_USER_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.HEAD_USER_ID == null ? String.Empty:obj.HEAD_USER_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":CREATE_DEPART_ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.CREATE_DEPART_ID == null ? String.Empty:obj.CREATE_DEPART_ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":PHONE";
			parameters[13].Size = 50;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.PHONE == null ? String.Empty:obj.PHONE;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":FAX";
			parameters[14].Size = 50;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.FAX == null ? String.Empty:obj.FAX;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":CREATE_DATE";
			parameters[15].Size = 7;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[15].Value = obj.CREATE_DATE;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":STATE";
			parameters[16].Size = 22;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[16].Value = obj.STATE;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":CREATE_TIME";
			parameters[17].Size = 7;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[17].Value = obj.CREATE_TIME;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":TYPE";
			parameters[18].Size = 22;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[18].Value = obj.TYPE;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":NAME";
			parameters[19].Size = 50;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.NAME == null ? String.Empty:obj.NAME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_DEPART obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_DEPART set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_DEPART obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_DEPART where  ID = :ID ";
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
		public static EntityObject_COM_DEPART Get(EntityObject_COM_DEPART obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, MODIFY_USER_ID, IS_USABLE, CODE, POST_CODE, COMMENTS, MODIFY_TIME, SUMMARY, CREATE_USER_ID, PARENT_ID, DATA_ORGANISE_ID, DROP_DATE, ADDRESS, HEAD_USER_ID, CREATE_DEPART_ID, PHONE, FAX, CREATE_DATE, STATE, CREATE_TIME, MODIFY_DEPART_ID, TYPE, NAME from COM_DEPART where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_DEPART dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_DEPART();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.POST_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SUMMARY = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DROP_DATE = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADDRESS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FAX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.TYPE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_DEPART[] objs = new EntityObject_COM_DEPART[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_DEPART Get(EntityObject_COM_DEPART obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, MODIFY_USER_ID, IS_USABLE, CODE, POST_CODE, COMMENTS, MODIFY_TIME, SUMMARY, CREATE_USER_ID, PARENT_ID, DATA_ORGANISE_ID, DROP_DATE, ADDRESS, HEAD_USER_ID, CREATE_DEPART_ID, PHONE, FAX, CREATE_DATE, STATE, CREATE_TIME, MODIFY_DEPART_ID, TYPE, NAME from COM_DEPART where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_DEPART dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_DEPART();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.POST_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SUMMARY = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DROP_DATE = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADDRESS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FAX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.TYPE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_DEPART[] objs = new EntityObject_COM_DEPART[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_DEPART[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_DEPART.ID, COM_DEPART.MODIFY_USER_ID, COM_DEPART.IS_USABLE, COM_DEPART.CODE, COM_DEPART.POST_CODE, COM_DEPART.COMMENTS, COM_DEPART.MODIFY_TIME, COM_DEPART.SUMMARY, COM_DEPART.CREATE_USER_ID, COM_DEPART.PARENT_ID, COM_DEPART.DATA_ORGANISE_ID, COM_DEPART.DROP_DATE, COM_DEPART.ADDRESS, COM_DEPART.HEAD_USER_ID, COM_DEPART.CREATE_DEPART_ID, COM_DEPART.PHONE, COM_DEPART.FAX, COM_DEPART.CREATE_DATE, COM_DEPART.STATE, COM_DEPART.CREATE_TIME, COM_DEPART.MODIFY_DEPART_ID, COM_DEPART.TYPE, COM_DEPART.NAME, (case  when COM_DEPART.IS_USABLE = 1 then '是' when COM_DEPART.IS_USABLE = 2 then '否' else '' end ) as IS_USABLE_NAME, SELF_T.NAME as PARENT_ID_NAME, COM_USER_HEAD_USER_ID.NAME as HEAD_USER_ID_NAME, (case  when COM_DEPART.TYPE = 1 then '单位' when COM_DEPART.TYPE = 2 then '部门' else '' end ) as TYPE_NAME from COM_DEPART left join COM_DEPART   SELF_T on COM_DEPART.PARENT_ID = SELF_T.ID left join COM_USER   COM_USER_HEAD_USER_ID on COM_DEPART.HEAD_USER_ID = COM_USER_HEAD_USER_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_DEPART dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_DEPART();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.POST_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SUMMARY = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DROP_DATE = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADDRESS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FAX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.TYPE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.IS_USABLE_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.HEAD_USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.TYPE_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_DEPART[] objs = new DisplayObject_COM_DEPART[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_DEPART cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And COM_DEPART.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And COM_DEPART.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "MODIFY_USER_ID"));
			}
			if(cause.IS_USABLE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_DEPART.IS_USABLE = :IS_USABLE");
				param = new OracleParameter();
				param.ParameterName =":IS_USABLE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_USABLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_USABLE"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "IS_USABLE"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And COM_DEPART.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.POST_CODE))
			{
				strBuf.Append(" And COM_DEPART.POST_CODE ").Append((cause.POST_CODE.StartsWith("%") || cause.POST_CODE.EndsWith("%")) ? " like " : " = ").Append(" :POST_CODE");
				param = new OracleParameter();
				param.ParameterName =":POST_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.POST_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("POST_CODE"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "POST_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And COM_DEPART.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "COMMENTS"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And COM_DEPART.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And COM_DEPART.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("COM_DEPART", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.SUMMARY))
			{
				strBuf.Append(" And COM_DEPART.SUMMARY ").Append((cause.SUMMARY.StartsWith("%") || cause.SUMMARY.EndsWith("%")) ? " like " : " = ").Append(" :SUMMARY");
				param = new OracleParameter();
				param.ParameterName =":SUMMARY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.SUMMARY;
				paramList.Add(param);
			}
			if (cause.HasINValue("SUMMARY"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "SUMMARY"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And COM_DEPART.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PARENT_ID))
			{
				strBuf.Append(" And COM_DEPART.PARENT_ID ").Append((cause.PARENT_ID.StartsWith("%") || cause.PARENT_ID.EndsWith("%")) ? " like " : " = ").Append(" :PARENT_ID");
				param = new OracleParameter();
				param.ParameterName =":PARENT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PARENT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PARENT_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "PARENT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And COM_DEPART.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "DATA_ORGANISE_ID"));
			}
			if(cause.DROP_DATE!= null)
			{
				if (cause.DROP_DATE.Begin != null)
				{
					strBuf.Append(" And COM_DEPART.DROP_DATE >= :DROP_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":DROP_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.DROP_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.DROP_DATE.End != null)
				{
					strBuf.Append(" And COM_DEPART.DROP_DATE < :DROP_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":DROP_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.DROP_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("DROP_DATE"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "DROP_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.ADDRESS))
			{
				strBuf.Append(" And COM_DEPART.ADDRESS ").Append((cause.ADDRESS.StartsWith("%") || cause.ADDRESS.EndsWith("%")) ? " like " : " = ").Append(" :ADDRESS");
				param = new OracleParameter();
				param.ParameterName =":ADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ADDRESS;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADDRESS"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "ADDRESS"));
			}
			if(!string.IsNullOrEmpty(cause.HEAD_USER_ID))
			{
				strBuf.Append(" And COM_DEPART.HEAD_USER_ID ").Append((cause.HEAD_USER_ID.StartsWith("%") || cause.HEAD_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :HEAD_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":HEAD_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.HEAD_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("HEAD_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "HEAD_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And COM_DEPART.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "CREATE_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PHONE))
			{
				strBuf.Append(" And COM_DEPART.PHONE ").Append((cause.PHONE.StartsWith("%") || cause.PHONE.EndsWith("%")) ? " like " : " = ").Append(" :PHONE");
				param = new OracleParameter();
				param.ParameterName =":PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PHONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PHONE"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "PHONE"));
			}
			if(!string.IsNullOrEmpty(cause.FAX))
			{
				strBuf.Append(" And COM_DEPART.FAX ").Append((cause.FAX.StartsWith("%") || cause.FAX.EndsWith("%")) ? " like " : " = ").Append(" :FAX");
				param = new OracleParameter();
				param.ParameterName =":FAX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FAX;
				paramList.Add(param);
			}
			if (cause.HasINValue("FAX"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "FAX"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And COM_DEPART.CREATE_DATE >= :CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And COM_DEPART.CREATE_DATE < :CREATE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "CREATE_DATE"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_DEPART.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "STATE"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And COM_DEPART.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And COM_DEPART.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("COM_DEPART", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And COM_DEPART.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "MODIFY_DEPART_ID"));
			}
			if(cause.TYPE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_DEPART.TYPE = :TYPE");
				param = new OracleParameter();
				param.ParameterName =":TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "TYPE"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And COM_DEPART.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("COM_DEPART", "NAME"));
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
		public static DisplayObject_COM_DEPART[] Query(CauseObject_COM_DEPART cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_DEPART.ID, COM_DEPART.MODIFY_USER_ID, COM_DEPART.IS_USABLE, COM_DEPART.CODE, COM_DEPART.POST_CODE, COM_DEPART.COMMENTS, COM_DEPART.MODIFY_TIME, COM_DEPART.SUMMARY, COM_DEPART.CREATE_USER_ID, COM_DEPART.PARENT_ID, COM_DEPART.DATA_ORGANISE_ID, COM_DEPART.DROP_DATE, COM_DEPART.ADDRESS, COM_DEPART.HEAD_USER_ID, COM_DEPART.CREATE_DEPART_ID, COM_DEPART.PHONE, COM_DEPART.FAX, COM_DEPART.CREATE_DATE, COM_DEPART.STATE, COM_DEPART.CREATE_TIME, COM_DEPART.MODIFY_DEPART_ID, COM_DEPART.TYPE, COM_DEPART.NAME, (case  when COM_DEPART.IS_USABLE = 1 then '是' when COM_DEPART.IS_USABLE = 2 then '否' else '' end ) as IS_USABLE_NAME, SELF_T.NAME as PARENT_ID_NAME, COM_USER_HEAD_USER_ID.NAME as HEAD_USER_ID_NAME, (case  when COM_DEPART.TYPE = 1 then '单位' when COM_DEPART.TYPE = 2 then '部门' else '' end ) as TYPE_NAME from COM_DEPART left join COM_DEPART   SELF_T on COM_DEPART.PARENT_ID = SELF_T.ID left join COM_USER   COM_USER_HEAD_USER_ID on COM_DEPART.HEAD_USER_ID = COM_USER_HEAD_USER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_DEPART dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_DEPART();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.POST_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SUMMARY = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DROP_DATE = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADDRESS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FAX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.TYPE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.IS_USABLE_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.HEAD_USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.TYPE_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_DEPART[] objs = new DisplayObject_COM_DEPART[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_DEPART cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_DEPART where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_DEPART[] Query(CauseObject_COM_DEPART cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_DEPART.ID, COM_DEPART.MODIFY_USER_ID, COM_DEPART.IS_USABLE, COM_DEPART.CODE, COM_DEPART.POST_CODE, COM_DEPART.COMMENTS, COM_DEPART.MODIFY_TIME, COM_DEPART.SUMMARY, COM_DEPART.CREATE_USER_ID, COM_DEPART.PARENT_ID, COM_DEPART.DATA_ORGANISE_ID, COM_DEPART.DROP_DATE, COM_DEPART.ADDRESS, COM_DEPART.HEAD_USER_ID, COM_DEPART.CREATE_DEPART_ID, COM_DEPART.PHONE, COM_DEPART.FAX, COM_DEPART.CREATE_DATE, COM_DEPART.STATE, COM_DEPART.CREATE_TIME, COM_DEPART.MODIFY_DEPART_ID, COM_DEPART.TYPE, COM_DEPART.NAME, (case  when COM_DEPART.IS_USABLE = 1 then '是' when COM_DEPART.IS_USABLE = 2 then '否' else '' end ) as IS_USABLE_NAME, SELF_T.NAME as PARENT_ID_NAME, COM_USER_HEAD_USER_ID.NAME as HEAD_USER_ID_NAME, (case  when COM_DEPART.TYPE = 1 then '单位' when COM_DEPART.TYPE = 2 then '部门' else '' end ) as TYPE_NAME from COM_DEPART left join COM_DEPART   SELF_T on COM_DEPART.PARENT_ID = SELF_T.ID left join COM_USER   COM_USER_HEAD_USER_ID on COM_DEPART.HEAD_USER_ID = COM_USER_HEAD_USER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_DEPART dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_DEPART();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.POST_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SUMMARY = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DROP_DATE = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADDRESS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FAX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.TYPE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.IS_USABLE_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.HEAD_USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.TYPE_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_DEPART[] objs = new DisplayObject_COM_DEPART[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_DEPART[] Query(CauseObject_COM_DEPART cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_DEPART.ID, COM_DEPART.MODIFY_USER_ID, COM_DEPART.IS_USABLE, COM_DEPART.CODE, COM_DEPART.POST_CODE, COM_DEPART.COMMENTS, COM_DEPART.MODIFY_TIME, COM_DEPART.SUMMARY, COM_DEPART.CREATE_USER_ID, COM_DEPART.PARENT_ID, COM_DEPART.DATA_ORGANISE_ID, COM_DEPART.DROP_DATE, COM_DEPART.ADDRESS, COM_DEPART.HEAD_USER_ID, COM_DEPART.CREATE_DEPART_ID, COM_DEPART.PHONE, COM_DEPART.FAX, COM_DEPART.CREATE_DATE, COM_DEPART.STATE, COM_DEPART.CREATE_TIME, COM_DEPART.MODIFY_DEPART_ID, COM_DEPART.TYPE, COM_DEPART.NAME, (case  when COM_DEPART.IS_USABLE = 1 then '是' when COM_DEPART.IS_USABLE = 2 then '否' else '' end ) as IS_USABLE_NAME, SELF_T.NAME as PARENT_ID_NAME, COM_USER_HEAD_USER_ID.NAME as HEAD_USER_ID_NAME, (case  when COM_DEPART.TYPE = 1 then '单位' when COM_DEPART.TYPE = 2 then '部门' else '' end ) as TYPE_NAME from COM_DEPART left join COM_DEPART   SELF_T on COM_DEPART.PARENT_ID = SELF_T.ID left join COM_USER   COM_USER_HEAD_USER_ID on COM_DEPART.HEAD_USER_ID = COM_USER_HEAD_USER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_DEPART",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_DEPART dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_DEPART();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.POST_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SUMMARY = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DROP_DATE = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADDRESS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FAX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.TYPE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.IS_USABLE_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.HEAD_USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.TYPE_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_DEPART[] objs = new DisplayObject_COM_DEPART[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_DEPART[] Query(CauseObject_COM_DEPART cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_DEPART.ID, COM_DEPART.MODIFY_USER_ID, COM_DEPART.IS_USABLE, COM_DEPART.CODE, COM_DEPART.POST_CODE, COM_DEPART.COMMENTS, COM_DEPART.MODIFY_TIME, COM_DEPART.SUMMARY, COM_DEPART.CREATE_USER_ID, COM_DEPART.PARENT_ID, COM_DEPART.DATA_ORGANISE_ID, COM_DEPART.DROP_DATE, COM_DEPART.ADDRESS, COM_DEPART.HEAD_USER_ID, COM_DEPART.CREATE_DEPART_ID, COM_DEPART.PHONE, COM_DEPART.FAX, COM_DEPART.CREATE_DATE, COM_DEPART.STATE, COM_DEPART.CREATE_TIME, COM_DEPART.MODIFY_DEPART_ID, COM_DEPART.TYPE, COM_DEPART.NAME, (case  when COM_DEPART.IS_USABLE = 1 then '是' when COM_DEPART.IS_USABLE = 2 then '否' else '' end ) as IS_USABLE_NAME, SELF_T.NAME as PARENT_ID_NAME, COM_USER_HEAD_USER_ID.NAME as HEAD_USER_ID_NAME, (case  when COM_DEPART.TYPE = 1 then '单位' when COM_DEPART.TYPE = 2 then '部门' else '' end ) as TYPE_NAME from COM_DEPART left join COM_DEPART   SELF_T on COM_DEPART.PARENT_ID = SELF_T.ID left join COM_USER   COM_USER_HEAD_USER_ID on COM_DEPART.HEAD_USER_ID = COM_USER_HEAD_USER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_DEPART",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_DEPART dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_DEPART();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_USABLE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.POST_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SUMMARY = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PARENT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DROP_DATE = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ADDRESS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.HEAD_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PHONE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FAX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.TYPE = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.IS_USABLE_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.PARENT_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.HEAD_USER_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.TYPE_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_DEPART[] objs = new DisplayObject_COM_DEPART[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_DEPART obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  COM_DEPART.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_USABLE"))
			{
				strBuf.Add("  COM_DEPART.IS_USABLE = :IS_USABLE");
				param = new OracleParameter();
				param.ParameterName = ":IS_USABLE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_USABLE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  COM_DEPART.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("POST_CODE"))
			{
				strBuf.Add("  COM_DEPART.POST_CODE = :POST_CODE");
				param = new OracleParameter();
				param.ParameterName = ":POST_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.POST_CODE) ? string.Empty : obj.POST_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  COM_DEPART.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  COM_DEPART.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SUMMARY"))
			{
				strBuf.Add("  COM_DEPART.SUMMARY = :SUMMARY");
				param = new OracleParameter();
				param.ParameterName = ":SUMMARY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.SUMMARY) ? string.Empty : obj.SUMMARY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PARENT_ID"))
			{
				strBuf.Add("  COM_DEPART.PARENT_ID = :PARENT_ID");
				param = new OracleParameter();
				param.ParameterName = ":PARENT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PARENT_ID) ? string.Empty : obj.PARENT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  COM_DEPART.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DROP_DATE"))
			{
				strBuf.Add("  COM_DEPART.DROP_DATE = :DROP_DATE");
				param = new OracleParameter();
				param.ParameterName = ":DROP_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.DROP_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ADDRESS"))
			{
				strBuf.Add("  COM_DEPART.ADDRESS = :ADDRESS");
				param = new OracleParameter();
				param.ParameterName = ":ADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ADDRESS) ? string.Empty : obj.ADDRESS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("HEAD_USER_ID"))
			{
				strBuf.Add("  COM_DEPART.HEAD_USER_ID = :HEAD_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":HEAD_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.HEAD_USER_ID) ? string.Empty : obj.HEAD_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PHONE"))
			{
				strBuf.Add("  COM_DEPART.PHONE = :PHONE");
				param = new OracleParameter();
				param.ParameterName = ":PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PHONE) ? string.Empty : obj.PHONE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FAX"))
			{
				strBuf.Add("  COM_DEPART.FAX = :FAX");
				param = new OracleParameter();
				param.ParameterName = ":FAX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FAX) ? string.Empty : obj.FAX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  COM_DEPART.CREATE_DATE = :CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  COM_DEPART.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  COM_DEPART.MODIFY_DEPART_ID = :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TYPE"))
			{
				strBuf.Add("  COM_DEPART.TYPE = :TYPE");
				param = new OracleParameter();
				param.ParameterName = ":TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  COM_DEPART.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
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
