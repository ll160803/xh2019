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
	[CauseObject(typeof(CauseObject_COM_TYPE))]
	public partial class HelperObject_COM_TYPE
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_TYPE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_TYPE( ID, CODE, DISPLAY_INDEX, COMMENTS, CREATE_USER_ID, PARENT_ID, DATA_ORGANISE_ID, CREATE_TIME, CREATE_DEPART_ID, STATE, FIVE_STROKE_CODE, SHORT_NAME, SPELL_CODE, NAME) values ( :ID, :CODE, :DISPLAY_INDEX, :COMMENTS, :CREATE_USER_ID, :PARENT_ID, :DATA_ORGANISE_ID, :CREATE_TIME, :CREATE_DEPART_ID, :STATE, :FIVE_STROKE_CODE, :SHORT_NAME, :SPELL_CODE, :NAME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[14];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":CODE";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":DISPLAY_INDEX";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.DISPLAY_INDEX;
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
			parameters[5].ParameterName =":PARENT_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.PARENT_ID == null ? String.Empty:obj.PARENT_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":DATA_ORGANISE_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
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
			parameters[9].ParameterName =":STATE";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.STATE;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":FIVE_STROKE_CODE";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.FIVE_STROKE_CODE == null ? String.Empty:obj.FIVE_STROKE_CODE;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":SHORT_NAME";
			parameters[11].Size = 50;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.SHORT_NAME == null ? String.Empty:obj.SHORT_NAME;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":SPELL_CODE";
			parameters[12].Size = 50;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.SPELL_CODE == null ? String.Empty:obj.SPELL_CODE;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":NAME";
			parameters[13].Size = 50;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.NAME == null ? String.Empty:obj.NAME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_TYPE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_TYPE set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_TYPE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_TYPE where  ID = :ID ";
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
		public static EntityObject_COM_TYPE Get(EntityObject_COM_TYPE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, MODIFY_USER_ID, CODE, DISPLAY_INDEX, COMMENTS, CREATE_USER_ID, PARENT_ID, DATA_ORGANISE_ID, CREATE_TIME, MODIFY_TIME, CREATE_DEPART_ID, STATE, MODIFY_DEPART_ID, FIVE_STROKE_CODE, SHORT_NAME, SPELL_CODE, NAME from COM_TYPE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARENT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.STATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SHORT_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SPELL_CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NAME = sqlReader.GetString(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_TYPE[] objs = new EntityObject_COM_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_TYPE Get(EntityObject_COM_TYPE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, MODIFY_USER_ID, CODE, DISPLAY_INDEX, COMMENTS, CREATE_USER_ID, PARENT_ID, DATA_ORGANISE_ID, CREATE_TIME, MODIFY_TIME, CREATE_DEPART_ID, STATE, MODIFY_DEPART_ID, FIVE_STROKE_CODE, SHORT_NAME, SPELL_CODE, NAME from COM_TYPE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARENT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.STATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SHORT_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SPELL_CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NAME = sqlReader.GetString(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_TYPE[] objs = new EntityObject_COM_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_TYPE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_TYPE.ID, COM_TYPE.MODIFY_USER_ID, COM_TYPE.CODE, COM_TYPE.DISPLAY_INDEX, COM_TYPE.COMMENTS, COM_TYPE.CREATE_USER_ID, COM_TYPE.PARENT_ID, COM_TYPE.DATA_ORGANISE_ID, COM_TYPE.CREATE_TIME, COM_TYPE.MODIFY_TIME, COM_TYPE.CREATE_DEPART_ID, COM_TYPE.STATE, COM_TYPE.MODIFY_DEPART_ID, COM_TYPE.FIVE_STROKE_CODE, COM_TYPE.SHORT_NAME, COM_TYPE.SPELL_CODE, COM_TYPE.NAME, SELF_T.PARENT_ID as SELF_T_NAME from COM_TYPE left join COM_TYPE   SELF_T on COM_TYPE.PARENT_ID = SELF_T.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARENT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.STATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SHORT_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SPELL_CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_TYPE_PARENT_ID = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_TYPE[] objs = new DisplayObject_COM_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_TYPE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And COM_TYPE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "ID"));
			}
			if(cause.MODIFY_USER_ID!= string.Empty)
			{
				strBuf.Append(" And COM_TYPE.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "MODIFY_USER_ID"));
			}
			if(cause.CODE!= string.Empty)
			{
				strBuf.Append(" And COM_TYPE.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "CODE"));
			}
			if(cause.DISPLAY_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_TYPE.DISPLAY_INDEX = :DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName =":DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("DISPLAY_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "DISPLAY_INDEX"));
			}
			if(cause.COMMENTS!= string.Empty)
			{
				strBuf.Append(" And COM_TYPE.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "COMMENTS"));
			}
			if(cause.CREATE_USER_ID!= string.Empty)
			{
				strBuf.Append(" And COM_TYPE.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "CREATE_USER_ID"));
			}
			if(cause.PARENT_ID!= string.Empty)
			{
				strBuf.Append(" And COM_TYPE.PARENT_ID ").Append((cause.PARENT_ID.StartsWith("%") || cause.PARENT_ID.EndsWith("%")) ? " like " : " = ").Append(" :PARENT_ID");
				param = new OracleParameter();
				param.ParameterName =":PARENT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PARENT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PARENT_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "PARENT_ID"));
			}
			if(cause.DATA_ORGANISE_ID!= string.Empty)
			{
				strBuf.Append(" And COM_TYPE.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "DATA_ORGANISE_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And COM_TYPE.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And COM_TYPE.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("COM_TYPE", "CREATE_TIME"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And COM_TYPE.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And COM_TYPE.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("COM_TYPE", "MODIFY_TIME"));
			}
			if(cause.CREATE_DEPART_ID!= string.Empty)
			{
				strBuf.Append(" And COM_TYPE.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "CREATE_DEPART_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_TYPE.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "STATE"));
			}
			if(cause.MODIFY_DEPART_ID!= string.Empty)
			{
				strBuf.Append(" And COM_TYPE.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "MODIFY_DEPART_ID"));
			}
			if(cause.FIVE_STROKE_CODE!= string.Empty)
			{
				strBuf.Append(" And COM_TYPE.FIVE_STROKE_CODE ").Append((cause.FIVE_STROKE_CODE.StartsWith("%") || cause.FIVE_STROKE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :FIVE_STROKE_CODE");
				param = new OracleParameter();
				param.ParameterName =":FIVE_STROKE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FIVE_STROKE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FIVE_STROKE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "FIVE_STROKE_CODE"));
			}
			if(cause.SHORT_NAME!= string.Empty)
			{
				strBuf.Append(" And COM_TYPE.SHORT_NAME ").Append((cause.SHORT_NAME.StartsWith("%") || cause.SHORT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :SHORT_NAME");
				param = new OracleParameter();
				param.ParameterName =":SHORT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SHORT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SHORT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "SHORT_NAME"));
			}
			if(cause.SPELL_CODE!= string.Empty)
			{
				strBuf.Append(" And COM_TYPE.SPELL_CODE ").Append((cause.SPELL_CODE.StartsWith("%") || cause.SPELL_CODE.EndsWith("%")) ? " like " : " = ").Append(" :SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName =":SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPELL_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPELL_CODE"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "SPELL_CODE"));
			}
			if(cause.NAME!= string.Empty)
			{
				strBuf.Append(" And COM_TYPE.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("COM_TYPE", "NAME"));
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
		public static DisplayObject_COM_TYPE[] Query(CauseObject_COM_TYPE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_TYPE.ID, COM_TYPE.MODIFY_USER_ID, COM_TYPE.CODE, COM_TYPE.DISPLAY_INDEX, COM_TYPE.COMMENTS, COM_TYPE.CREATE_USER_ID, COM_TYPE.PARENT_ID, COM_TYPE.DATA_ORGANISE_ID, COM_TYPE.CREATE_TIME, COM_TYPE.MODIFY_TIME, COM_TYPE.CREATE_DEPART_ID, COM_TYPE.STATE, COM_TYPE.MODIFY_DEPART_ID, COM_TYPE.FIVE_STROKE_CODE, COM_TYPE.SHORT_NAME, COM_TYPE.SPELL_CODE, COM_TYPE.NAME, SELF_T.PARENT_ID as SELF_T_NAME from COM_TYPE left join COM_TYPE   SELF_T on COM_TYPE.PARENT_ID = SELF_T.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARENT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.STATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SHORT_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SPELL_CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_TYPE_PARENT_ID = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_TYPE[] objs = new DisplayObject_COM_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_TYPE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_TYPE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_TYPE[] Query(CauseObject_COM_TYPE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_TYPE.ID, COM_TYPE.MODIFY_USER_ID, COM_TYPE.CODE, COM_TYPE.DISPLAY_INDEX, COM_TYPE.COMMENTS, COM_TYPE.CREATE_USER_ID, COM_TYPE.PARENT_ID, COM_TYPE.DATA_ORGANISE_ID, COM_TYPE.CREATE_TIME, COM_TYPE.MODIFY_TIME, COM_TYPE.CREATE_DEPART_ID, COM_TYPE.STATE, COM_TYPE.MODIFY_DEPART_ID, COM_TYPE.FIVE_STROKE_CODE, COM_TYPE.SHORT_NAME, COM_TYPE.SPELL_CODE, COM_TYPE.NAME, SELF_T.PARENT_ID as SELF_T_NAME from COM_TYPE left join COM_TYPE   SELF_T on COM_TYPE.PARENT_ID = SELF_T.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARENT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.STATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SHORT_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SPELL_CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_TYPE_PARENT_ID = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_TYPE[] objs = new DisplayObject_COM_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_TYPE[] Query(CauseObject_COM_TYPE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_TYPE.ID, COM_TYPE.MODIFY_USER_ID, COM_TYPE.CODE, COM_TYPE.DISPLAY_INDEX, COM_TYPE.COMMENTS, COM_TYPE.CREATE_USER_ID, COM_TYPE.PARENT_ID, COM_TYPE.DATA_ORGANISE_ID, COM_TYPE.CREATE_TIME, COM_TYPE.MODIFY_TIME, COM_TYPE.CREATE_DEPART_ID, COM_TYPE.STATE, COM_TYPE.MODIFY_DEPART_ID, COM_TYPE.FIVE_STROKE_CODE, COM_TYPE.SHORT_NAME, COM_TYPE.SPELL_CODE, COM_TYPE.NAME, SELF_T.PARENT_ID as SELF_T_NAME from COM_TYPE left join COM_TYPE   SELF_T on COM_TYPE.PARENT_ID = SELF_T.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_TYPE",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARENT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.STATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SHORT_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SPELL_CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_TYPE_PARENT_ID = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_TYPE[] objs = new DisplayObject_COM_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_TYPE[] Query(CauseObject_COM_TYPE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_TYPE.ID, COM_TYPE.MODIFY_USER_ID, COM_TYPE.CODE, COM_TYPE.DISPLAY_INDEX, COM_TYPE.COMMENTS, COM_TYPE.CREATE_USER_ID, COM_TYPE.PARENT_ID, COM_TYPE.DATA_ORGANISE_ID, COM_TYPE.CREATE_TIME, COM_TYPE.MODIFY_TIME, COM_TYPE.CREATE_DEPART_ID, COM_TYPE.STATE, COM_TYPE.MODIFY_DEPART_ID, COM_TYPE.FIVE_STROKE_CODE, COM_TYPE.SHORT_NAME, COM_TYPE.SPELL_CODE, COM_TYPE.NAME, SELF_T.PARENT_ID as SELF_T_NAME from COM_TYPE left join COM_TYPE   SELF_T on COM_TYPE.PARENT_ID = SELF_T.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_TYPE",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARENT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.STATE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FIVE_STROKE_CODE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SHORT_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SPELL_CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_TYPE_PARENT_ID = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_TYPE[] objs = new DisplayObject_COM_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_TYPE obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  COM_TYPE.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  COM_TYPE.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DISPLAY_INDEX"))
			{
				strBuf.Add("  COM_TYPE.DISPLAY_INDEX = :DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName = ":DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  COM_TYPE.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PARENT_ID"))
			{
				strBuf.Add("  COM_TYPE.PARENT_ID = :PARENT_ID");
				param = new OracleParameter();
				param.ParameterName = ":PARENT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PARENT_ID) ? string.Empty : obj.PARENT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  COM_TYPE.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  COM_TYPE.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  COM_TYPE.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  COM_TYPE.MODIFY_DEPART_ID = :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FIVE_STROKE_CODE"))
			{
				strBuf.Add("  COM_TYPE.FIVE_STROKE_CODE = :FIVE_STROKE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":FIVE_STROKE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FIVE_STROKE_CODE) ? string.Empty : obj.FIVE_STROKE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SHORT_NAME"))
			{
				strBuf.Add("  COM_TYPE.SHORT_NAME = :SHORT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":SHORT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SHORT_NAME) ? string.Empty : obj.SHORT_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPELL_CODE"))
			{
				strBuf.Add("  COM_TYPE.SPELL_CODE = :SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName = ":SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SPELL_CODE) ? string.Empty : obj.SPELL_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  COM_TYPE.NAME = :NAME");
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
