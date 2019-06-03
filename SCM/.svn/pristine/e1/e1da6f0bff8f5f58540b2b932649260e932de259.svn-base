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
	[CauseObject(typeof(CauseObject_SITE_USER))]
	public partial class HelperObject_SITE_USER
	{		
		#region Method Blok
		public static int Save(EntityObject_SITE_USER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into SITE_USER( ID, QUESTION, IDENTITY_NUMBER, ANSWER, TYPE, NICKNAME, POST_CODE, VALUE, EMAIL, NAME, U_PWD, ADDRESS, U_NAME, PHONE, REGISTER_DATE) values ( :ID, :QUESTION, :IDENTITY_NUMBER, :ANSWER, :TYPE, :NICKNAME, :POST_CODE, :VALUE, :EMAIL, :NAME, :U_PWD, :ADDRESS, :U_NAME, :PHONE, :REGISTER_DATE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[15];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":QUESTION";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.QUESTION == null ? String.Empty:obj.QUESTION;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":IDENTITY_NUMBER";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.IDENTITY_NUMBER == null ? String.Empty:obj.IDENTITY_NUMBER;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ANSWER";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.ANSWER == null ? String.Empty:obj.ANSWER;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":TYPE";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.TYPE == null ? String.Empty:obj.TYPE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":NICKNAME";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.NICKNAME == null ? String.Empty:obj.NICKNAME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":POST_CODE";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.POST_CODE == null ? String.Empty:obj.POST_CODE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":VALUE";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.VALUE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":EMAIL";
			parameters[8].Size = 50;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.EMAIL == null ? String.Empty:obj.EMAIL;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":NAME";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":U_PWD";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.U_PWD == null ? String.Empty:obj.U_PWD;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":ADDRESS";
			parameters[11].Size = 200;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.ADDRESS == null ? String.Empty:obj.ADDRESS;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":U_NAME";
			parameters[12].Size = 50;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.U_NAME == null ? String.Empty:obj.U_NAME;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":PHONE";
			parameters[13].Size = 50;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.PHONE == null ? String.Empty:obj.PHONE;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":REGISTER_DATE";
			parameters[14].Size = 7;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[14].Value = obj.REGISTER_DATE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SITE_USER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SITE_USER set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SITE_USER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SITE_USER where  ID = :ID ";
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
		public static EntityObject_SITE_USER Get(EntityObject_SITE_USER obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, QUESTION, IDENTITY_NUMBER, ANSWER, TYPE, NICKNAME, POST_CODE, VALUE, EMAIL, NAME, U_PWD, ADDRESS, U_NAME, PHONE, REGISTER_DATE from SITE_USER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SITE_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SITE_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.QUESTION = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ANSWER = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NICKNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.POST_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EMAIL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.U_PWD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADDRESS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.U_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PHONE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REGISTER_DATE = sqlReader.GetDateTime(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SITE_USER[] objs = new EntityObject_SITE_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_SITE_USER Get(EntityObject_SITE_USER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, QUESTION, IDENTITY_NUMBER, ANSWER, TYPE, NICKNAME, POST_CODE, VALUE, EMAIL, NAME, U_PWD, ADDRESS, U_NAME, PHONE, REGISTER_DATE from SITE_USER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SITE_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SITE_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.QUESTION = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ANSWER = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NICKNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.POST_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EMAIL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.U_PWD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADDRESS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.U_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PHONE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REGISTER_DATE = sqlReader.GetDateTime(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SITE_USER[] objs = new EntityObject_SITE_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SITE_USER[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SITE_USER.ID, SITE_USER.QUESTION, SITE_USER.IDENTITY_NUMBER, SITE_USER.ANSWER, SITE_USER.TYPE, SITE_USER.NICKNAME, SITE_USER.POST_CODE, SITE_USER.VALUE, SITE_USER.EMAIL, SITE_USER.NAME, SITE_USER.U_PWD, SITE_USER.ADDRESS, SITE_USER.U_NAME, SITE_USER.PHONE, SITE_USER.REGISTER_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_USER left join COM_TYPE   COM_TYPE on SITE_USER.TYPE = COM_TYPE.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SITE_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.QUESTION = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ANSWER = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NICKNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.POST_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EMAIL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.U_PWD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADDRESS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.U_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PHONE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REGISTER_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_USER[] objs = new DisplayObject_SITE_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SITE_USER cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And SITE_USER.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "ID"));
			}
			if(cause.QUESTION!= string.Empty)
			{
				strBuf.Append(" And SITE_USER.QUESTION ").Append((cause.QUESTION.StartsWith("%") || cause.QUESTION.EndsWith("%")) ? " like " : " = ").Append(" :QUESTION");
				param = new OracleParameter();
				param.ParameterName =":QUESTION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.QUESTION;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUESTION"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "QUESTION"));
			}
			if(cause.IDENTITY_NUMBER!= string.Empty)
			{
				strBuf.Append(" And SITE_USER.IDENTITY_NUMBER ").Append((cause.IDENTITY_NUMBER.StartsWith("%") || cause.IDENTITY_NUMBER.EndsWith("%")) ? " like " : " = ").Append(" :IDENTITY_NUMBER");
				param = new OracleParameter();
				param.ParameterName =":IDENTITY_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.IDENTITY_NUMBER;
				paramList.Add(param);
			}
			if (cause.HasINValue("IDENTITY_NUMBER"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "IDENTITY_NUMBER"));
			}
			if(cause.ANSWER!= string.Empty)
			{
				strBuf.Append(" And SITE_USER.ANSWER ").Append((cause.ANSWER.StartsWith("%") || cause.ANSWER.EndsWith("%")) ? " like " : " = ").Append(" :ANSWER");
				param = new OracleParameter();
				param.ParameterName =":ANSWER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ANSWER;
				paramList.Add(param);
			}
			if (cause.HasINValue("ANSWER"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "ANSWER"));
			}
			if(cause.TYPE!= string.Empty)
			{
				strBuf.Append(" And SITE_USER.TYPE ").Append((cause.TYPE.StartsWith("%") || cause.TYPE.EndsWith("%")) ? " like " : " = ").Append(" :TYPE");
				param = new OracleParameter();
				param.ParameterName =":TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "TYPE"));
			}
			if(cause.NICKNAME!= string.Empty)
			{
				strBuf.Append(" And SITE_USER.NICKNAME ").Append((cause.NICKNAME.StartsWith("%") || cause.NICKNAME.EndsWith("%")) ? " like " : " = ").Append(" :NICKNAME");
				param = new OracleParameter();
				param.ParameterName =":NICKNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NICKNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NICKNAME"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "NICKNAME"));
			}
			if(cause.POST_CODE!= string.Empty)
			{
				strBuf.Append(" And SITE_USER.POST_CODE ").Append((cause.POST_CODE.StartsWith("%") || cause.POST_CODE.EndsWith("%")) ? " like " : " = ").Append(" :POST_CODE");
				param = new OracleParameter();
				param.ParameterName =":POST_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.POST_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("POST_CODE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "POST_CODE"));
			}
			if(cause.VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SITE_USER.VALUE = :VALUE");
				param = new OracleParameter();
				param.ParameterName =":VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("VALUE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "VALUE"));
			}
			if(cause.EMAIL!= string.Empty)
			{
				strBuf.Append(" And SITE_USER.EMAIL ").Append((cause.EMAIL.StartsWith("%") || cause.EMAIL.EndsWith("%")) ? " like " : " = ").Append(" :EMAIL");
				param = new OracleParameter();
				param.ParameterName =":EMAIL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.EMAIL;
				paramList.Add(param);
			}
			if (cause.HasINValue("EMAIL"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "EMAIL"));
			}
			if(cause.NAME!= string.Empty)
			{
				strBuf.Append(" And SITE_USER.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "NAME"));
			}
			if(cause.U_PWD!= string.Empty)
			{
				strBuf.Append(" And SITE_USER.U_PWD ").Append((cause.U_PWD.StartsWith("%") || cause.U_PWD.EndsWith("%")) ? " like " : " = ").Append(" :U_PWD");
				param = new OracleParameter();
				param.ParameterName =":U_PWD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.U_PWD;
				paramList.Add(param);
			}
			if (cause.HasINValue("U_PWD"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "U_PWD"));
			}
			if(cause.ADDRESS!= string.Empty)
			{
				strBuf.Append(" And SITE_USER.ADDRESS ").Append((cause.ADDRESS.StartsWith("%") || cause.ADDRESS.EndsWith("%")) ? " like " : " = ").Append(" :ADDRESS");
				param = new OracleParameter();
				param.ParameterName =":ADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.ADDRESS;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADDRESS"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "ADDRESS"));
			}
			if(cause.U_NAME!= string.Empty)
			{
				strBuf.Append(" And SITE_USER.U_NAME ").Append((cause.U_NAME.StartsWith("%") || cause.U_NAME.EndsWith("%")) ? " like " : " = ").Append(" :U_NAME");
				param = new OracleParameter();
				param.ParameterName =":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.U_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("U_NAME"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "U_NAME"));
			}
			if(cause.PHONE!= string.Empty)
			{
				strBuf.Append(" And SITE_USER.PHONE ").Append((cause.PHONE.StartsWith("%") || cause.PHONE.EndsWith("%")) ? " like " : " = ").Append(" :PHONE");
				param = new OracleParameter();
				param.ParameterName =":PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PHONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PHONE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "PHONE"));
			}
			if(cause.REGISTER_DATE!= null)
			{
				if (cause.REGISTER_DATE.Begin != null)
				{
					strBuf.Append(" And SITE_USER.REGISTER_DATE >= :REGISTER_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":REGISTER_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.REGISTER_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.REGISTER_DATE.End != null)
				{
					strBuf.Append(" And SITE_USER.REGISTER_DATE < :REGISTER_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":REGISTER_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.REGISTER_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("REGISTER_DATE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_USER", "REGISTER_DATE"));
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
		public static DisplayObject_SITE_USER[] Query(CauseObject_SITE_USER cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SITE_USER.ID, SITE_USER.QUESTION, SITE_USER.IDENTITY_NUMBER, SITE_USER.ANSWER, SITE_USER.TYPE, SITE_USER.NICKNAME, SITE_USER.POST_CODE, SITE_USER.VALUE, SITE_USER.EMAIL, SITE_USER.NAME, SITE_USER.U_PWD, SITE_USER.ADDRESS, SITE_USER.U_NAME, SITE_USER.PHONE, SITE_USER.REGISTER_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_USER left join COM_TYPE   COM_TYPE on SITE_USER.TYPE = COM_TYPE.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SITE_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.QUESTION = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ANSWER = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NICKNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.POST_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EMAIL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.U_PWD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADDRESS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.U_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PHONE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REGISTER_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_USER[] objs = new DisplayObject_SITE_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_SITE_USER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SITE_USER where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_SITE_USER[] Query(CauseObject_SITE_USER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SITE_USER.ID, SITE_USER.QUESTION, SITE_USER.IDENTITY_NUMBER, SITE_USER.ANSWER, SITE_USER.TYPE, SITE_USER.NICKNAME, SITE_USER.POST_CODE, SITE_USER.VALUE, SITE_USER.EMAIL, SITE_USER.NAME, SITE_USER.U_PWD, SITE_USER.ADDRESS, SITE_USER.U_NAME, SITE_USER.PHONE, SITE_USER.REGISTER_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_USER left join COM_TYPE   COM_TYPE on SITE_USER.TYPE = COM_TYPE.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SITE_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.QUESTION = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ANSWER = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NICKNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.POST_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EMAIL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.U_PWD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADDRESS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.U_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PHONE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REGISTER_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SITE_USER[] objs = new DisplayObject_SITE_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SITE_USER[] Query(CauseObject_SITE_USER cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SITE_USER.ID, SITE_USER.QUESTION, SITE_USER.IDENTITY_NUMBER, SITE_USER.ANSWER, SITE_USER.TYPE, SITE_USER.NICKNAME, SITE_USER.POST_CODE, SITE_USER.VALUE, SITE_USER.EMAIL, SITE_USER.NAME, SITE_USER.U_PWD, SITE_USER.ADDRESS, SITE_USER.U_NAME, SITE_USER.PHONE, SITE_USER.REGISTER_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_USER left join COM_TYPE   COM_TYPE on SITE_USER.TYPE = COM_TYPE.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SITE_USER",paging, order, sSql, parameters, connection);
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
			DisplayObject_SITE_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.QUESTION = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ANSWER = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NICKNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.POST_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EMAIL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.U_PWD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADDRESS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.U_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PHONE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REGISTER_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_USER[] objs = new DisplayObject_SITE_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SITE_USER[] Query(CauseObject_SITE_USER cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SITE_USER.ID, SITE_USER.QUESTION, SITE_USER.IDENTITY_NUMBER, SITE_USER.ANSWER, SITE_USER.TYPE, SITE_USER.NICKNAME, SITE_USER.POST_CODE, SITE_USER.VALUE, SITE_USER.EMAIL, SITE_USER.NAME, SITE_USER.U_PWD, SITE_USER.ADDRESS, SITE_USER.U_NAME, SITE_USER.PHONE, SITE_USER.REGISTER_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_USER left join COM_TYPE   COM_TYPE on SITE_USER.TYPE = COM_TYPE.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SITE_USER",paging, order, sSql, parameters, trans);
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
			DisplayObject_SITE_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.QUESTION = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IDENTITY_NUMBER = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ANSWER = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NICKNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.POST_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.VALUE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.EMAIL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.U_PWD = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADDRESS = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.U_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PHONE = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.REGISTER_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SITE_USER[] objs = new DisplayObject_SITE_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SITE_USER obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("QUESTION"))
			{
				strBuf.Add("  SITE_USER.QUESTION = :QUESTION");
				param = new OracleParameter();
				param.ParameterName = ":QUESTION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.QUESTION) ? string.Empty : obj.QUESTION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IDENTITY_NUMBER"))
			{
				strBuf.Add("  SITE_USER.IDENTITY_NUMBER = :IDENTITY_NUMBER");
				param = new OracleParameter();
				param.ParameterName = ":IDENTITY_NUMBER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.IDENTITY_NUMBER) ? string.Empty : obj.IDENTITY_NUMBER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ANSWER"))
			{
				strBuf.Add("  SITE_USER.ANSWER = :ANSWER");
				param = new OracleParameter();
				param.ParameterName = ":ANSWER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ANSWER) ? string.Empty : obj.ANSWER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TYPE"))
			{
				strBuf.Add("  SITE_USER.TYPE = :TYPE");
				param = new OracleParameter();
				param.ParameterName = ":TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.TYPE) ? string.Empty : obj.TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NICKNAME"))
			{
				strBuf.Add("  SITE_USER.NICKNAME = :NICKNAME");
				param = new OracleParameter();
				param.ParameterName = ":NICKNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NICKNAME) ? string.Empty : obj.NICKNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("POST_CODE"))
			{
				strBuf.Add("  SITE_USER.POST_CODE = :POST_CODE");
				param = new OracleParameter();
				param.ParameterName = ":POST_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.POST_CODE) ? string.Empty : obj.POST_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("VALUE"))
			{
				strBuf.Add("  SITE_USER.VALUE = :VALUE");
				param = new OracleParameter();
				param.ParameterName = ":VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EMAIL"))
			{
				strBuf.Add("  SITE_USER.EMAIL = :EMAIL");
				param = new OracleParameter();
				param.ParameterName = ":EMAIL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.EMAIL) ? string.Empty : obj.EMAIL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  SITE_USER.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("U_PWD"))
			{
				strBuf.Add("  SITE_USER.U_PWD = :U_PWD");
				param = new OracleParameter();
				param.ParameterName = ":U_PWD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.U_PWD) ? string.Empty : obj.U_PWD;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ADDRESS"))
			{
				strBuf.Add("  SITE_USER.ADDRESS = :ADDRESS");
				param = new OracleParameter();
				param.ParameterName = ":ADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.ADDRESS) ? string.Empty : obj.ADDRESS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("U_NAME"))
			{
				strBuf.Add("  SITE_USER.U_NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.U_NAME) ? string.Empty : obj.U_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PHONE"))
			{
				strBuf.Add("  SITE_USER.PHONE = :PHONE");
				param = new OracleParameter();
				param.ParameterName = ":PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PHONE) ? string.Empty : obj.PHONE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REGISTER_DATE"))
			{
				strBuf.Add("  SITE_USER.REGISTER_DATE = :REGISTER_DATE");
				param = new OracleParameter();
				param.ParameterName = ":REGISTER_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.REGISTER_DATE;
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
