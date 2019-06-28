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
	[CauseObject(typeof(CauseObject_COM_FILE))]
	public partial class HelperObject_COM_FILE
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_FILE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_FILE( ID, CREATE_TIME, SERVER_NAME, FILE_TYPE, FILE_SIZE, IS_COMPRESS, CREATE_DEPT_ID, REF_TAB_NAME, MODIFY_DEPT_ID, COMMENTS, DATA_ORGANISE_ID, CREATE_USER_ID, REF_TAB_ID, STATE, IS_IMPORT, CONTENT_TYPE, CLIENT_NAME) values ( :ID, :CREATE_TIME, :SERVER_NAME, :FILE_TYPE, :FILE_SIZE, :IS_COMPRESS, :CREATE_DEPT_ID, :REF_TAB_NAME, :MODIFY_DEPT_ID, :COMMENTS, :DATA_ORGANISE_ID, :CREATE_USER_ID, :REF_TAB_ID, :STATE, :IS_IMPORT, :CONTENT_TYPE, :CLIENT_NAME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[17];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":CREATE_TIME";
			parameters[1].Size = 7;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[1].Value = obj.CREATE_TIME;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":SERVER_NAME";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.SERVER_NAME == null ? String.Empty:obj.SERVER_NAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":FILE_TYPE";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.FILE_TYPE == null ? String.Empty:obj.FILE_TYPE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":FILE_SIZE";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.FILE_SIZE == null ? String.Empty:obj.FILE_SIZE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":IS_COMPRESS";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.IS_COMPRESS;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":CREATE_DEPT_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":REF_TAB_NAME";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.REF_TAB_NAME == null ? String.Empty:obj.REF_TAB_NAME;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":MODIFY_DEPT_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":COMMENTS";
			parameters[9].Size = 200;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":DATA_ORGANISE_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":CREATE_USER_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":REF_TAB_ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.REF_TAB_ID == null ? String.Empty:obj.REF_TAB_ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":STATE";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.STATE;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":IS_IMPORT";
			parameters[14].Size = 22;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[14].Value = obj.IS_IMPORT;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":CONTENT_TYPE";
			parameters[15].Size = 50;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.CONTENT_TYPE == null ? String.Empty:obj.CONTENT_TYPE;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":CLIENT_NAME";
			parameters[16].Size = 50;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[16].Value = obj.CLIENT_NAME == null ? String.Empty:obj.CLIENT_NAME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_FILE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_FILE set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_FILE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_FILE where  ID = :ID ";
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
		public static EntityObject_COM_FILE Get(EntityObject_COM_FILE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, CREATE_TIME, SERVER_NAME, FILE_TYPE, MODIFY_TIME, FILE_SIZE, IS_COMPRESS, CREATE_DEPT_ID, REF_TAB_NAME, MODIFY_DEPT_ID, MODIFY_USER_ID, COMMENTS, DATA_ORGANISE_ID, CREATE_USER_ID, REF_TAB_ID, STATE, IS_IMPORT, CONTENT_TYPE, CLIENT_NAME from COM_FILE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SERVER_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FILE_TYPE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_SIZE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_COMPRESS = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COMMENTS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_IMPORT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTENT_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_FILE[] objs = new EntityObject_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_FILE Get(EntityObject_COM_FILE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, CREATE_TIME, SERVER_NAME, FILE_TYPE, MODIFY_TIME, FILE_SIZE, IS_COMPRESS, CREATE_DEPT_ID, REF_TAB_NAME, MODIFY_DEPT_ID, MODIFY_USER_ID, COMMENTS, DATA_ORGANISE_ID, CREATE_USER_ID, REF_TAB_ID, STATE, IS_IMPORT, CONTENT_TYPE, CLIENT_NAME from COM_FILE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SERVER_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FILE_TYPE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_SIZE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_COMPRESS = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COMMENTS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_IMPORT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTENT_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_FILE[] objs = new EntityObject_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_FILE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_FILE.ID, COM_FILE.CREATE_TIME, COM_FILE.SERVER_NAME, COM_FILE.FILE_TYPE, COM_FILE.MODIFY_TIME, COM_FILE.FILE_SIZE, COM_FILE.IS_COMPRESS, COM_FILE.CREATE_DEPT_ID, COM_FILE.REF_TAB_NAME, COM_FILE.MODIFY_DEPT_ID, COM_FILE.MODIFY_USER_ID, COM_FILE.COMMENTS, COM_FILE.DATA_ORGANISE_ID, COM_FILE.CREATE_USER_ID, COM_FILE.REF_TAB_ID, COM_FILE.STATE, COM_FILE.IS_IMPORT, COM_FILE.CONTENT_TYPE, COM_FILE.CLIENT_NAME, (case  when COM_FILE.IS_COMPRESS = 1 then '是' when COM_FILE.IS_COMPRESS = 2 then '否' else '' end ) as IS_COMPRESS_NAME, (case  when COM_FILE.STATE = 0 then '已作废' when COM_FILE.STATE = 1 then '编辑中' when COM_FILE.STATE = 2 then '已提交' when COM_FILE.STATE = 3 then '已审核' when COM_FILE.STATE = 4 then '已审批' else '' end ) as STATE_NAME, (case  when COM_FILE.IS_IMPORT = 1 then '是' when COM_FILE.IS_IMPORT = 2 then '否' else '' end ) as IS_IMPORT_NAME from COM_FILE where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SERVER_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FILE_TYPE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_SIZE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_COMPRESS = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COMMENTS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_IMPORT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTENT_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_COMPRESS_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.STATE_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.IS_IMPORT_NAME = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_FILE[] objs = new DisplayObject_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_FILE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And COM_FILE.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And COM_FILE.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("COM_FILE", "CREATE_TIME"));
			}
			if(cause.SERVER_NAME!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.SERVER_NAME ").Append((cause.SERVER_NAME.StartsWith("%") || cause.SERVER_NAME.EndsWith("%")) ? " like " : " = ").Append(" :SERVER_NAME");
				param = new OracleParameter();
				param.ParameterName =":SERVER_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SERVER_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SERVER_NAME"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "SERVER_NAME"));
			}
			if(cause.FILE_TYPE!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.FILE_TYPE ").Append((cause.FILE_TYPE.StartsWith("%") || cause.FILE_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :FILE_TYPE");
				param = new OracleParameter();
				param.ParameterName =":FILE_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.FILE_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FILE_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "FILE_TYPE"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And COM_FILE.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And COM_FILE.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("COM_FILE", "MODIFY_TIME"));
			}
			if(cause.FILE_SIZE!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.FILE_SIZE ").Append((cause.FILE_SIZE.StartsWith("%") || cause.FILE_SIZE.EndsWith("%")) ? " like " : " = ").Append(" :FILE_SIZE");
				param = new OracleParameter();
				param.ParameterName =":FILE_SIZE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FILE_SIZE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FILE_SIZE"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "FILE_SIZE"));
			}
			if(cause.IS_COMPRESS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_FILE.IS_COMPRESS = :IS_COMPRESS");
				param = new OracleParameter();
				param.ParameterName =":IS_COMPRESS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_COMPRESS;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_COMPRESS"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "IS_COMPRESS"));
			}
			if(cause.CREATE_DEPT_ID!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "CREATE_DEPT_ID"));
			}
			if(cause.REF_TAB_NAME!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.REF_TAB_NAME ").Append((cause.REF_TAB_NAME.StartsWith("%") || cause.REF_TAB_NAME.EndsWith("%")) ? " like " : " = ").Append(" :REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName =":REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_NAME"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "REF_TAB_NAME"));
			}
			if(cause.MODIFY_DEPT_ID!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "MODIFY_DEPT_ID"));
			}
			if(cause.MODIFY_USER_ID!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "MODIFY_USER_ID"));
			}
			if(cause.COMMENTS!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "COMMENTS"));
			}
			if(cause.DATA_ORGANISE_ID!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "DATA_ORGANISE_ID"));
			}
			if(cause.CREATE_USER_ID!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "CREATE_USER_ID"));
			}
			if(cause.REF_TAB_ID!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.REF_TAB_ID ").Append((cause.REF_TAB_ID.StartsWith("%") || cause.REF_TAB_ID.EndsWith("%")) ? " like " : " = ").Append(" :REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName =":REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_TAB_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "REF_TAB_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_FILE.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "STATE"));
			}
			if(cause.IS_IMPORT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_FILE.IS_IMPORT = :IS_IMPORT");
				param = new OracleParameter();
				param.ParameterName =":IS_IMPORT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_IMPORT;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_IMPORT"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "IS_IMPORT"));
			}
			if(cause.CONTENT_TYPE!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.CONTENT_TYPE ").Append((cause.CONTENT_TYPE.StartsWith("%") || cause.CONTENT_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :CONTENT_TYPE");
				param = new OracleParameter();
				param.ParameterName =":CONTENT_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CONTENT_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTENT_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "CONTENT_TYPE"));
			}
			if(cause.CLIENT_NAME!= string.Empty)
			{
				strBuf.Append(" And COM_FILE.CLIENT_NAME ").Append((cause.CLIENT_NAME.StartsWith("%") || cause.CLIENT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :CLIENT_NAME");
				param = new OracleParameter();
				param.ParameterName =":CLIENT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CLIENT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("CLIENT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("COM_FILE", "CLIENT_NAME"));
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
		public static DisplayObject_COM_FILE[] Query(CauseObject_COM_FILE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_FILE.ID, COM_FILE.CREATE_TIME, COM_FILE.SERVER_NAME, COM_FILE.FILE_TYPE, COM_FILE.MODIFY_TIME, COM_FILE.FILE_SIZE, COM_FILE.IS_COMPRESS, COM_FILE.CREATE_DEPT_ID, COM_FILE.REF_TAB_NAME, COM_FILE.MODIFY_DEPT_ID, COM_FILE.MODIFY_USER_ID, COM_FILE.COMMENTS, COM_FILE.DATA_ORGANISE_ID, COM_FILE.CREATE_USER_ID, COM_FILE.REF_TAB_ID, COM_FILE.STATE, COM_FILE.IS_IMPORT, COM_FILE.CONTENT_TYPE, COM_FILE.CLIENT_NAME, (case  when COM_FILE.IS_COMPRESS = 1 then '是' when COM_FILE.IS_COMPRESS = 2 then '否' else '' end ) as IS_COMPRESS_NAME, (case  when COM_FILE.STATE = 0 then '已作废' when COM_FILE.STATE = 1 then '编辑中' when COM_FILE.STATE = 2 then '已提交' when COM_FILE.STATE = 3 then '已审核' when COM_FILE.STATE = 4 then '已审批' else '' end ) as STATE_NAME, (case  when COM_FILE.IS_IMPORT = 1 then '是' when COM_FILE.IS_IMPORT = 2 then '否' else '' end ) as IS_IMPORT_NAME from COM_FILE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SERVER_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FILE_TYPE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_SIZE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_COMPRESS = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COMMENTS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_IMPORT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTENT_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_COMPRESS_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.STATE_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.IS_IMPORT_NAME = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_FILE[] objs = new DisplayObject_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_FILE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_FILE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_FILE[] Query(CauseObject_COM_FILE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_FILE.ID, COM_FILE.CREATE_TIME, COM_FILE.SERVER_NAME, COM_FILE.FILE_TYPE, COM_FILE.MODIFY_TIME, COM_FILE.FILE_SIZE, COM_FILE.IS_COMPRESS, COM_FILE.CREATE_DEPT_ID, COM_FILE.REF_TAB_NAME, COM_FILE.MODIFY_DEPT_ID, COM_FILE.MODIFY_USER_ID, COM_FILE.COMMENTS, COM_FILE.DATA_ORGANISE_ID, COM_FILE.CREATE_USER_ID, COM_FILE.REF_TAB_ID, COM_FILE.STATE, COM_FILE.IS_IMPORT, COM_FILE.CONTENT_TYPE, COM_FILE.CLIENT_NAME, (case  when COM_FILE.IS_COMPRESS = 1 then '是' when COM_FILE.IS_COMPRESS = 2 then '否' else '' end ) as IS_COMPRESS_NAME, (case  when COM_FILE.STATE = 0 then '已作废' when COM_FILE.STATE = 1 then '编辑中' when COM_FILE.STATE = 2 then '已提交' when COM_FILE.STATE = 3 then '已审核' when COM_FILE.STATE = 4 then '已审批' else '' end ) as STATE_NAME, (case  when COM_FILE.IS_IMPORT = 1 then '是' when COM_FILE.IS_IMPORT = 2 then '否' else '' end ) as IS_IMPORT_NAME from COM_FILE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SERVER_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FILE_TYPE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_SIZE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_COMPRESS = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COMMENTS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_IMPORT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTENT_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_COMPRESS_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.STATE_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.IS_IMPORT_NAME = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_FILE[] objs = new DisplayObject_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_FILE[] Query(CauseObject_COM_FILE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_FILE.ID, COM_FILE.CREATE_TIME, COM_FILE.SERVER_NAME, COM_FILE.FILE_TYPE, COM_FILE.MODIFY_TIME, COM_FILE.FILE_SIZE, COM_FILE.IS_COMPRESS, COM_FILE.CREATE_DEPT_ID, COM_FILE.REF_TAB_NAME, COM_FILE.MODIFY_DEPT_ID, COM_FILE.MODIFY_USER_ID, COM_FILE.COMMENTS, COM_FILE.DATA_ORGANISE_ID, COM_FILE.CREATE_USER_ID, COM_FILE.REF_TAB_ID, COM_FILE.STATE, COM_FILE.IS_IMPORT, COM_FILE.CONTENT_TYPE, COM_FILE.CLIENT_NAME, (case  when COM_FILE.IS_COMPRESS = 1 then '是' when COM_FILE.IS_COMPRESS = 2 then '否' else '' end ) as IS_COMPRESS_NAME, (case  when COM_FILE.STATE = 0 then '已作废' when COM_FILE.STATE = 1 then '编辑中' when COM_FILE.STATE = 2 then '已提交' when COM_FILE.STATE = 3 then '已审核' when COM_FILE.STATE = 4 then '已审批' else '' end ) as STATE_NAME, (case  when COM_FILE.IS_IMPORT = 1 then '是' when COM_FILE.IS_IMPORT = 2 then '否' else '' end ) as IS_IMPORT_NAME from COM_FILE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_FILE",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SERVER_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FILE_TYPE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_SIZE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_COMPRESS = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COMMENTS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_IMPORT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTENT_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_COMPRESS_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.STATE_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.IS_IMPORT_NAME = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_FILE[] objs = new DisplayObject_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_FILE[] Query(CauseObject_COM_FILE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_FILE.ID, COM_FILE.CREATE_TIME, COM_FILE.SERVER_NAME, COM_FILE.FILE_TYPE, COM_FILE.MODIFY_TIME, COM_FILE.FILE_SIZE, COM_FILE.IS_COMPRESS, COM_FILE.CREATE_DEPT_ID, COM_FILE.REF_TAB_NAME, COM_FILE.MODIFY_DEPT_ID, COM_FILE.MODIFY_USER_ID, COM_FILE.COMMENTS, COM_FILE.DATA_ORGANISE_ID, COM_FILE.CREATE_USER_ID, COM_FILE.REF_TAB_ID, COM_FILE.STATE, COM_FILE.IS_IMPORT, COM_FILE.CONTENT_TYPE, COM_FILE.CLIENT_NAME, (case  when COM_FILE.IS_COMPRESS = 1 then '是' when COM_FILE.IS_COMPRESS = 2 then '否' else '' end ) as IS_COMPRESS_NAME, (case  when COM_FILE.STATE = 0 then '已作废' when COM_FILE.STATE = 1 then '编辑中' when COM_FILE.STATE = 2 then '已提交' when COM_FILE.STATE = 3 then '已审核' when COM_FILE.STATE = 4 then '已审批' else '' end ) as STATE_NAME, (case  when COM_FILE.IS_IMPORT = 1 then '是' when COM_FILE.IS_IMPORT = 2 then '否' else '' end ) as IS_IMPORT_NAME from COM_FILE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_FILE",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_FILE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FILE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SERVER_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FILE_TYPE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_SIZE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_COMPRESS = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COMMENTS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IS_IMPORT = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CONTENT_TYPE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CLIENT_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_COMPRESS_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.STATE_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.IS_IMPORT_NAME = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_FILE[] objs = new DisplayObject_COM_FILE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_FILE obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("SERVER_NAME"))
			{
				strBuf.Add("  COM_FILE.SERVER_NAME = :SERVER_NAME");
				param = new OracleParameter();
				param.ParameterName = ":SERVER_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SERVER_NAME) ? string.Empty : obj.SERVER_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FILE_TYPE"))
			{
				strBuf.Add("  COM_FILE.FILE_TYPE = :FILE_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":FILE_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.FILE_TYPE) ? string.Empty : obj.FILE_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  COM_FILE.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FILE_SIZE"))
			{
				strBuf.Add("  COM_FILE.FILE_SIZE = :FILE_SIZE");
				param = new OracleParameter();
				param.ParameterName = ":FILE_SIZE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FILE_SIZE) ? string.Empty : obj.FILE_SIZE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_COMPRESS"))
			{
				strBuf.Add("  COM_FILE.IS_COMPRESS = :IS_COMPRESS");
				param = new OracleParameter();
				param.ParameterName = ":IS_COMPRESS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_COMPRESS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  COM_FILE.CREATE_DEPT_ID = :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_NAME"))
			{
				strBuf.Add("  COM_FILE.REF_TAB_NAME = :REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName = ":REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_NAME) ? string.Empty : obj.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  COM_FILE.MODIFY_DEPT_ID = :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  COM_FILE.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  COM_FILE.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  COM_FILE.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_ID"))
			{
				strBuf.Add("  COM_FILE.REF_TAB_ID = :REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName = ":REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_ID) ? string.Empty : obj.REF_TAB_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  COM_FILE.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_IMPORT"))
			{
				strBuf.Add("  COM_FILE.IS_IMPORT = :IS_IMPORT");
				param = new OracleParameter();
				param.ParameterName = ":IS_IMPORT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_IMPORT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONTENT_TYPE"))
			{
				strBuf.Add("  COM_FILE.CONTENT_TYPE = :CONTENT_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":CONTENT_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CONTENT_TYPE) ? string.Empty : obj.CONTENT_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CLIENT_NAME"))
			{
				strBuf.Add("  COM_FILE.CLIENT_NAME = :CLIENT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":CLIENT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CLIENT_NAME) ? string.Empty : obj.CLIENT_NAME;
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
