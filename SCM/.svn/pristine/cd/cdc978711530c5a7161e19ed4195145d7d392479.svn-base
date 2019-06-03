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
	[CauseObject(typeof(CauseObject_SCM_B_VISIT))]
	public partial class HelperObject_SCM_B_VISIT
	{		
		#region Method Blok
		public static int Save(EntityObject_SCM_B_VISIT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into SCM_B_VISIT( DATA_ORGANISE_ID, ID, CREATE_DEPART_ID, CREATE_USER_ID, STATE, NAME, NONESS_COUNT, CREATE_TIME, NESS_COUNT, CODE, COMMENTS) values ( :DATA_ORGANISE_ID, :ID, :CREATE_DEPART_ID, :CREATE_USER_ID, :STATE, :NAME, :NONESS_COUNT, :CREATE_TIME, :NESS_COUNT, :CODE, :COMMENTS)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[11];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":DATA_ORGANISE_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CREATE_DEPART_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.CREATE_DEPART_ID == null ? String.Empty:obj.CREATE_DEPART_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":CREATE_USER_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":STATE";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.STATE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":NAME";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":NONESS_COUNT";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.NONESS_COUNT;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CREATE_TIME";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.CREATE_TIME;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":NESS_COUNT";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.NESS_COUNT;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":CODE";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":COMMENTS";
			parameters[10].Size = 200;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SCM_B_VISIT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_B_VISIT set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SCM_B_VISIT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SCM_B_VISIT where  ID = :ID ";
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
		public static EntityObject_SCM_B_VISIT Get(EntityObject_SCM_B_VISIT obj)
		{
			
			//平台自动生成代码
			string sSql = "select  DATA_ORGANISE_ID, MODIFY_TIME, ID, CREATE_DEPART_ID, MODIFY_DEPART_ID, CREATE_USER_ID, STATE, NAME, NONESS_COUNT, MODIFY_USER_ID, CREATE_TIME, NESS_COUNT, CODE, COMMENTS from SCM_B_VISIT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_VISIT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_VISIT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NONESS_COUNT = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NESS_COUNT = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.COMMENTS = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SCM_B_VISIT[] objs = new EntityObject_SCM_B_VISIT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_SCM_B_VISIT Get(EntityObject_SCM_B_VISIT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  DATA_ORGANISE_ID, MODIFY_TIME, ID, CREATE_DEPART_ID, MODIFY_DEPART_ID, CREATE_USER_ID, STATE, NAME, NONESS_COUNT, MODIFY_USER_ID, CREATE_TIME, NESS_COUNT, CODE, COMMENTS from SCM_B_VISIT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_VISIT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_VISIT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NONESS_COUNT = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NESS_COUNT = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.COMMENTS = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SCM_B_VISIT[] objs = new EntityObject_SCM_B_VISIT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_B_VISIT[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SCM_B_VISIT.DATA_ORGANISE_ID, SCM_B_VISIT.MODIFY_TIME, SCM_B_VISIT.ID, SCM_B_VISIT.CREATE_DEPART_ID, SCM_B_VISIT.MODIFY_DEPART_ID, SCM_B_VISIT.CREATE_USER_ID, SCM_B_VISIT.STATE, SCM_B_VISIT.NAME, SCM_B_VISIT.NONESS_COUNT, SCM_B_VISIT.MODIFY_USER_ID, SCM_B_VISIT.CREATE_TIME, SCM_B_VISIT.NESS_COUNT, SCM_B_VISIT.CODE, SCM_B_VISIT.COMMENTS from SCM_B_VISIT where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SCM_B_VISIT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_VISIT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NONESS_COUNT = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NESS_COUNT = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.COMMENTS = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_VISIT[] objs = new DisplayObject_SCM_B_VISIT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SCM_B_VISIT cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And SCM_B_VISIT.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "DATA_ORGANISE_ID"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_B_VISIT.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And SCM_B_VISIT.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And SCM_B_VISIT.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And SCM_B_VISIT.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "CREATE_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And SCM_B_VISIT.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "MODIFY_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And SCM_B_VISIT.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "CREATE_USER_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_VISIT.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And SCM_B_VISIT.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "NAME"));
			}
			if(cause.NONESS_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_VISIT.NONESS_COUNT = :NONESS_COUNT");
				param = new OracleParameter();
				param.ParameterName =":NONESS_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.NONESS_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("NONESS_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "NONESS_COUNT"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And SCM_B_VISIT.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "MODIFY_USER_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_B_VISIT.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And SCM_B_VISIT.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "CREATE_TIME"));
			}
			if(cause.NESS_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_VISIT.NESS_COUNT = :NESS_COUNT");
				param = new OracleParameter();
				param.ParameterName =":NESS_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.NESS_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("NESS_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "NESS_COUNT"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And SCM_B_VISIT.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And SCM_B_VISIT.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_VISIT", "COMMENTS"));
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
		public static DisplayObject_SCM_B_VISIT[] Query(CauseObject_SCM_B_VISIT cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_B_VISIT.DATA_ORGANISE_ID, SCM_B_VISIT.MODIFY_TIME, SCM_B_VISIT.ID, SCM_B_VISIT.CREATE_DEPART_ID, SCM_B_VISIT.MODIFY_DEPART_ID, SCM_B_VISIT.CREATE_USER_ID, SCM_B_VISIT.STATE, SCM_B_VISIT.NAME, SCM_B_VISIT.NONESS_COUNT, SCM_B_VISIT.MODIFY_USER_ID, SCM_B_VISIT.CREATE_TIME, SCM_B_VISIT.NESS_COUNT, SCM_B_VISIT.CODE, SCM_B_VISIT.COMMENTS from SCM_B_VISIT where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_VISIT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_VISIT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NONESS_COUNT = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NESS_COUNT = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.COMMENTS = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_VISIT[] objs = new DisplayObject_SCM_B_VISIT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_SCM_B_VISIT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SCM_B_VISIT where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_SCM_B_VISIT[] Query(CauseObject_SCM_B_VISIT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_B_VISIT.DATA_ORGANISE_ID, SCM_B_VISIT.MODIFY_TIME, SCM_B_VISIT.ID, SCM_B_VISIT.CREATE_DEPART_ID, SCM_B_VISIT.MODIFY_DEPART_ID, SCM_B_VISIT.CREATE_USER_ID, SCM_B_VISIT.STATE, SCM_B_VISIT.NAME, SCM_B_VISIT.NONESS_COUNT, SCM_B_VISIT.MODIFY_USER_ID, SCM_B_VISIT.CREATE_TIME, SCM_B_VISIT.NESS_COUNT, SCM_B_VISIT.CODE, SCM_B_VISIT.COMMENTS from SCM_B_VISIT where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_VISIT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_VISIT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NONESS_COUNT = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NESS_COUNT = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.COMMENTS = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_VISIT[] objs = new DisplayObject_SCM_B_VISIT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_VISIT[] Query(CauseObject_SCM_B_VISIT cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_B_VISIT.DATA_ORGANISE_ID, SCM_B_VISIT.MODIFY_TIME, SCM_B_VISIT.ID, SCM_B_VISIT.CREATE_DEPART_ID, SCM_B_VISIT.MODIFY_DEPART_ID, SCM_B_VISIT.CREATE_USER_ID, SCM_B_VISIT.STATE, SCM_B_VISIT.NAME, SCM_B_VISIT.NONESS_COUNT, SCM_B_VISIT.MODIFY_USER_ID, SCM_B_VISIT.CREATE_TIME, SCM_B_VISIT.NESS_COUNT, SCM_B_VISIT.CODE, SCM_B_VISIT.COMMENTS from SCM_B_VISIT where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_VISIT",paging, order, sSql, parameters, connection);
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
			DisplayObject_SCM_B_VISIT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_VISIT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NONESS_COUNT = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NESS_COUNT = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.COMMENTS = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_VISIT[] objs = new DisplayObject_SCM_B_VISIT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_VISIT[] Query(CauseObject_SCM_B_VISIT cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_B_VISIT.DATA_ORGANISE_ID, SCM_B_VISIT.MODIFY_TIME, SCM_B_VISIT.ID, SCM_B_VISIT.CREATE_DEPART_ID, SCM_B_VISIT.MODIFY_DEPART_ID, SCM_B_VISIT.CREATE_USER_ID, SCM_B_VISIT.STATE, SCM_B_VISIT.NAME, SCM_B_VISIT.NONESS_COUNT, SCM_B_VISIT.MODIFY_USER_ID, SCM_B_VISIT.CREATE_TIME, SCM_B_VISIT.NESS_COUNT, SCM_B_VISIT.CODE, SCM_B_VISIT.COMMENTS from SCM_B_VISIT where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_VISIT",paging, order, sSql, parameters, trans);
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
			DisplayObject_SCM_B_VISIT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_VISIT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.NONESS_COUNT = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NESS_COUNT = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CODE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.COMMENTS = sqlReader.GetString(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_VISIT[] objs = new DisplayObject_SCM_B_VISIT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SCM_B_VISIT obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  SCM_B_VISIT.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  SCM_B_VISIT.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  SCM_B_VISIT.MODIFY_DEPART_ID = :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  SCM_B_VISIT.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  SCM_B_VISIT.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NONESS_COUNT"))
			{
				strBuf.Add("  SCM_B_VISIT.NONESS_COUNT = :NONESS_COUNT");
				param = new OracleParameter();
				param.ParameterName = ":NONESS_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.NONESS_COUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  SCM_B_VISIT.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NESS_COUNT"))
			{
				strBuf.Add("  SCM_B_VISIT.NESS_COUNT = :NESS_COUNT");
				param = new OracleParameter();
				param.ParameterName = ":NESS_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.NESS_COUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  SCM_B_VISIT.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  SCM_B_VISIT.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
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
