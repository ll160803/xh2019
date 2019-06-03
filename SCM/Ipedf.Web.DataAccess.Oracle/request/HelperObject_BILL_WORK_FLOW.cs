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
	[CauseObject(typeof(CauseObject_BILL_WORK_FLOW))]
	public partial class HelperObject_BILL_WORK_FLOW
	{		
		#region Method Blok
		public static int Save(EntityObject_BILL_WORK_FLOW obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BILL_WORK_FLOW( ID, CREATE_TIME, NEXT_BILL_ID, BILL_ID, BILL_STATE, NEXT_BILL_NAME, CREATE_DEPT_ID, BILL_CODE, BILL_OPT_COUNTER, BILL_MSG, COMMENTS, DATA_ORGANISE_ID, BILL_NAME, CREATE_USER_ID, BILL_TYPE, NEXT_BILL_CODE) values ( :ID, :CREATE_TIME, :NEXT_BILL_ID, :BILL_ID, :BILL_STATE, :NEXT_BILL_NAME, :CREATE_DEPT_ID, :BILL_CODE, :BILL_OPT_COUNTER, :BILL_MSG, :COMMENTS, :DATA_ORGANISE_ID, :BILL_NAME, :CREATE_USER_ID, :BILL_TYPE, :NEXT_BILL_CODE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[16];
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
			parameters[2].ParameterName =":NEXT_BILL_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.NEXT_BILL_ID == null ? String.Empty:obj.NEXT_BILL_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":BILL_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.BILL_ID == null ? String.Empty:obj.BILL_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":BILL_STATE";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.BILL_STATE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":NEXT_BILL_NAME";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.NEXT_BILL_NAME == null ? String.Empty:obj.NEXT_BILL_NAME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":CREATE_DEPT_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":BILL_CODE";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.BILL_CODE == null ? String.Empty:obj.BILL_CODE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":BILL_OPT_COUNTER";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.BILL_OPT_COUNTER;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":BILL_MSG";
			parameters[9].Size = 4000;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Clob;
			parameters[9].Value = obj.BILL_MSG == null ? String.Empty:obj.BILL_MSG;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":COMMENTS";
			parameters[10].Size = 200;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":DATA_ORGANISE_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":BILL_NAME";
			parameters[12].Size = 50;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.BILL_NAME == null ? String.Empty:obj.BILL_NAME;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":CREATE_USER_ID";
			parameters[13].Size = 36;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":BILL_TYPE";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.BILL_TYPE == null ? String.Empty:obj.BILL_TYPE;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":NEXT_BILL_CODE";
			parameters[15].Size = 50;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.NEXT_BILL_CODE == null ? String.Empty:obj.NEXT_BILL_CODE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BILL_WORK_FLOW obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BILL_WORK_FLOW set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BILL_WORK_FLOW obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BILL_WORK_FLOW where  ID = :ID ";
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
		public static EntityObject_BILL_WORK_FLOW Get(EntityObject_BILL_WORK_FLOW obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, CREATE_TIME, NEXT_BILL_ID, BILL_ID, BILL_STATE, NEXT_BILL_NAME, CREATE_DEPT_ID, BILL_CODE, BILL_OPT_COUNTER, BILL_MSG, COMMENTS, DATA_ORGANISE_ID, BILL_NAME, CREATE_USER_ID, BILL_TYPE, NEXT_BILL_CODE from BILL_WORK_FLOW where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BILL_WORK_FLOW dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BILL_WORK_FLOW();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEXT_BILL_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BILL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BILL_STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_BILL_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BILL_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BILL_OPT_COUNTER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BILL_MSG = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BILL_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BILL_TYPE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NEXT_BILL_CODE = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BILL_WORK_FLOW[] objs = new EntityObject_BILL_WORK_FLOW[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BILL_WORK_FLOW Get(EntityObject_BILL_WORK_FLOW obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, CREATE_TIME, NEXT_BILL_ID, BILL_ID, BILL_STATE, NEXT_BILL_NAME, CREATE_DEPT_ID, BILL_CODE, BILL_OPT_COUNTER, BILL_MSG, COMMENTS, DATA_ORGANISE_ID, BILL_NAME, CREATE_USER_ID, BILL_TYPE, NEXT_BILL_CODE from BILL_WORK_FLOW where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BILL_WORK_FLOW dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BILL_WORK_FLOW();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEXT_BILL_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BILL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BILL_STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_BILL_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BILL_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BILL_OPT_COUNTER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BILL_MSG = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BILL_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BILL_TYPE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NEXT_BILL_CODE = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BILL_WORK_FLOW[] objs = new EntityObject_BILL_WORK_FLOW[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BILL_WORK_FLOW[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BILL_WORK_FLOW.ID, BILL_WORK_FLOW.CREATE_TIME, BILL_WORK_FLOW.NEXT_BILL_ID, BILL_WORK_FLOW.BILL_ID, BILL_WORK_FLOW.BILL_STATE, BILL_WORK_FLOW.NEXT_BILL_NAME, BILL_WORK_FLOW.CREATE_DEPT_ID, BILL_WORK_FLOW.BILL_CODE, BILL_WORK_FLOW.BILL_OPT_COUNTER, BILL_WORK_FLOW.BILL_MSG, BILL_WORK_FLOW.COMMENTS, BILL_WORK_FLOW.DATA_ORGANISE_ID, BILL_WORK_FLOW.BILL_NAME, BILL_WORK_FLOW.CREATE_USER_ID, BILL_WORK_FLOW.BILL_TYPE, BILL_WORK_FLOW.NEXT_BILL_CODE, COM_DEPART.NAME as COM_DEPART_NAME, COM_USER.NAME as COM_USER_NAME from BILL_WORK_FLOW left join COM_DEPART   COM_DEPART on BILL_WORK_FLOW.CREATE_DEPT_ID = COM_DEPART.ID left join COM_USER   COM_USER on BILL_WORK_FLOW.CREATE_USER_ID = COM_USER.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BILL_WORK_FLOW dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BILL_WORK_FLOW();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEXT_BILL_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BILL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BILL_STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_BILL_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BILL_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BILL_OPT_COUNTER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BILL_MSG = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BILL_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BILL_TYPE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NEXT_BILL_CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COM_DEPART_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BILL_WORK_FLOW[] objs = new DisplayObject_BILL_WORK_FLOW[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BILL_WORK_FLOW cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And BILL_WORK_FLOW.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And BILL_WORK_FLOW.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And BILL_WORK_FLOW.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "CREATE_TIME"));
			}
			if(cause.NEXT_BILL_ID!= string.Empty)
			{
				strBuf.Append(" And BILL_WORK_FLOW.NEXT_BILL_ID ").Append((cause.NEXT_BILL_ID.StartsWith("%") || cause.NEXT_BILL_ID.EndsWith("%")) ? " like " : " = ").Append(" :NEXT_BILL_ID");
				param = new OracleParameter();
				param.ParameterName =":NEXT_BILL_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.NEXT_BILL_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("NEXT_BILL_ID"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "NEXT_BILL_ID"));
			}
			if(cause.BILL_ID!= string.Empty)
			{
				strBuf.Append(" And BILL_WORK_FLOW.BILL_ID ").Append((cause.BILL_ID.StartsWith("%") || cause.BILL_ID.EndsWith("%")) ? " like " : " = ").Append(" :BILL_ID");
				param = new OracleParameter();
				param.ParameterName =":BILL_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BILL_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BILL_ID"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "BILL_ID"));
			}
			if(cause.BILL_STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BILL_WORK_FLOW.BILL_STATE = :BILL_STATE");
				param = new OracleParameter();
				param.ParameterName =":BILL_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.BILL_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("BILL_STATE"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "BILL_STATE"));
			}
			if(cause.NEXT_BILL_NAME!= string.Empty)
			{
				strBuf.Append(" And BILL_WORK_FLOW.NEXT_BILL_NAME ").Append((cause.NEXT_BILL_NAME.StartsWith("%") || cause.NEXT_BILL_NAME.EndsWith("%")) ? " like " : " = ").Append(" :NEXT_BILL_NAME");
				param = new OracleParameter();
				param.ParameterName =":NEXT_BILL_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NEXT_BILL_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NEXT_BILL_NAME"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "NEXT_BILL_NAME"));
			}
			if(cause.CREATE_DEPT_ID!= string.Empty)
			{
				strBuf.Append(" And BILL_WORK_FLOW.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "CREATE_DEPT_ID"));
			}
			if(cause.BILL_CODE!= string.Empty)
			{
				strBuf.Append(" And BILL_WORK_FLOW.BILL_CODE ").Append((cause.BILL_CODE.StartsWith("%") || cause.BILL_CODE.EndsWith("%")) ? " like " : " = ").Append(" :BILL_CODE");
				param = new OracleParameter();
				param.ParameterName =":BILL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BILL_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("BILL_CODE"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "BILL_CODE"));
			}
			if(cause.BILL_OPT_COUNTER!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BILL_WORK_FLOW.BILL_OPT_COUNTER = :BILL_OPT_COUNTER");
				param = new OracleParameter();
				param.ParameterName =":BILL_OPT_COUNTER";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.BILL_OPT_COUNTER;
				paramList.Add(param);
			}
			if (cause.HasINValue("BILL_OPT_COUNTER"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "BILL_OPT_COUNTER"));
			}
			if(cause.BILL_MSG!= string.Empty)
			{
				strBuf.Append(" And BILL_WORK_FLOW.BILL_MSG ").Append((cause.BILL_MSG.StartsWith("%") || cause.BILL_MSG.EndsWith("%")) ? " like " : " = ").Append(" :BILL_MSG");
				param = new OracleParameter();
				param.ParameterName =":BILL_MSG";
				param.OracleType = System.Data.OracleClient.OracleType.Clob;
				param.Size = 4000;
				param.Value = cause.BILL_MSG;
				paramList.Add(param);
			}
			if (cause.HasINValue("BILL_MSG"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "BILL_MSG"));
			}
			if(cause.COMMENTS!= string.Empty)
			{
				strBuf.Append(" And BILL_WORK_FLOW.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "COMMENTS"));
			}
			if(cause.DATA_ORGANISE_ID!= string.Empty)
			{
				strBuf.Append(" And BILL_WORK_FLOW.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "DATA_ORGANISE_ID"));
			}
			if(cause.BILL_NAME!= string.Empty)
			{
				strBuf.Append(" And BILL_WORK_FLOW.BILL_NAME ").Append((cause.BILL_NAME.StartsWith("%") || cause.BILL_NAME.EndsWith("%")) ? " like " : " = ").Append(" :BILL_NAME");
				param = new OracleParameter();
				param.ParameterName =":BILL_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BILL_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BILL_NAME"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "BILL_NAME"));
			}
			if(cause.CREATE_USER_ID!= string.Empty)
			{
				strBuf.Append(" And BILL_WORK_FLOW.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "CREATE_USER_ID"));
			}
			if(cause.BILL_TYPE!= string.Empty)
			{
				strBuf.Append(" And BILL_WORK_FLOW.BILL_TYPE ").Append((cause.BILL_TYPE.StartsWith("%") || cause.BILL_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :BILL_TYPE");
				param = new OracleParameter();
				param.ParameterName =":BILL_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BILL_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("BILL_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "BILL_TYPE"));
			}
			if(cause.NEXT_BILL_CODE!= string.Empty)
			{
				strBuf.Append(" And BILL_WORK_FLOW.NEXT_BILL_CODE ").Append((cause.NEXT_BILL_CODE.StartsWith("%") || cause.NEXT_BILL_CODE.EndsWith("%")) ? " like " : " = ").Append(" :NEXT_BILL_CODE");
				param = new OracleParameter();
				param.ParameterName =":NEXT_BILL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NEXT_BILL_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("NEXT_BILL_CODE"))
			{
				strBuf.Append(cause.GetINSQL("BILL_WORK_FLOW", "NEXT_BILL_CODE"));
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
		public static DisplayObject_BILL_WORK_FLOW[] Query(CauseObject_BILL_WORK_FLOW cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BILL_WORK_FLOW.ID, BILL_WORK_FLOW.CREATE_TIME, BILL_WORK_FLOW.NEXT_BILL_ID, BILL_WORK_FLOW.BILL_ID, BILL_WORK_FLOW.BILL_STATE, BILL_WORK_FLOW.NEXT_BILL_NAME, BILL_WORK_FLOW.CREATE_DEPT_ID, BILL_WORK_FLOW.BILL_CODE, BILL_WORK_FLOW.BILL_OPT_COUNTER, BILL_WORK_FLOW.BILL_MSG, BILL_WORK_FLOW.COMMENTS, BILL_WORK_FLOW.DATA_ORGANISE_ID, BILL_WORK_FLOW.BILL_NAME, BILL_WORK_FLOW.CREATE_USER_ID, BILL_WORK_FLOW.BILL_TYPE, BILL_WORK_FLOW.NEXT_BILL_CODE, COM_DEPART.NAME as COM_DEPART_NAME, COM_USER.NAME as COM_USER_NAME from BILL_WORK_FLOW left join COM_DEPART   COM_DEPART on BILL_WORK_FLOW.CREATE_DEPT_ID = COM_DEPART.ID left join COM_USER   COM_USER on BILL_WORK_FLOW.CREATE_USER_ID = COM_USER.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BILL_WORK_FLOW dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BILL_WORK_FLOW();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEXT_BILL_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BILL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BILL_STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_BILL_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BILL_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BILL_OPT_COUNTER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BILL_MSG = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BILL_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BILL_TYPE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NEXT_BILL_CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COM_DEPART_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BILL_WORK_FLOW[] objs = new DisplayObject_BILL_WORK_FLOW[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BILL_WORK_FLOW cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BILL_WORK_FLOW where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BILL_WORK_FLOW[] Query(CauseObject_BILL_WORK_FLOW cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BILL_WORK_FLOW.ID, BILL_WORK_FLOW.CREATE_TIME, BILL_WORK_FLOW.NEXT_BILL_ID, BILL_WORK_FLOW.BILL_ID, BILL_WORK_FLOW.BILL_STATE, BILL_WORK_FLOW.NEXT_BILL_NAME, BILL_WORK_FLOW.CREATE_DEPT_ID, BILL_WORK_FLOW.BILL_CODE, BILL_WORK_FLOW.BILL_OPT_COUNTER, BILL_WORK_FLOW.BILL_MSG, BILL_WORK_FLOW.COMMENTS, BILL_WORK_FLOW.DATA_ORGANISE_ID, BILL_WORK_FLOW.BILL_NAME, BILL_WORK_FLOW.CREATE_USER_ID, BILL_WORK_FLOW.BILL_TYPE, BILL_WORK_FLOW.NEXT_BILL_CODE, COM_DEPART.NAME as COM_DEPART_NAME, COM_USER.NAME as COM_USER_NAME from BILL_WORK_FLOW left join COM_DEPART   COM_DEPART on BILL_WORK_FLOW.CREATE_DEPT_ID = COM_DEPART.ID left join COM_USER   COM_USER on BILL_WORK_FLOW.CREATE_USER_ID = COM_USER.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BILL_WORK_FLOW dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BILL_WORK_FLOW();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEXT_BILL_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BILL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BILL_STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_BILL_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BILL_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BILL_OPT_COUNTER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BILL_MSG = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BILL_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BILL_TYPE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NEXT_BILL_CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COM_DEPART_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BILL_WORK_FLOW[] objs = new DisplayObject_BILL_WORK_FLOW[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BILL_WORK_FLOW[] Query(CauseObject_BILL_WORK_FLOW cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BILL_WORK_FLOW.ID, BILL_WORK_FLOW.CREATE_TIME, BILL_WORK_FLOW.NEXT_BILL_ID, BILL_WORK_FLOW.BILL_ID, BILL_WORK_FLOW.BILL_STATE, BILL_WORK_FLOW.NEXT_BILL_NAME, BILL_WORK_FLOW.CREATE_DEPT_ID, BILL_WORK_FLOW.BILL_CODE, BILL_WORK_FLOW.BILL_OPT_COUNTER, BILL_WORK_FLOW.BILL_MSG, BILL_WORK_FLOW.COMMENTS, BILL_WORK_FLOW.DATA_ORGANISE_ID, BILL_WORK_FLOW.BILL_NAME, BILL_WORK_FLOW.CREATE_USER_ID, BILL_WORK_FLOW.BILL_TYPE, BILL_WORK_FLOW.NEXT_BILL_CODE, COM_DEPART.NAME as COM_DEPART_NAME, COM_USER.NAME as COM_USER_NAME from BILL_WORK_FLOW left join COM_DEPART   COM_DEPART on BILL_WORK_FLOW.CREATE_DEPT_ID = COM_DEPART.ID left join COM_USER   COM_USER on BILL_WORK_FLOW.CREATE_USER_ID = COM_USER.ID where (1=1)";
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
					countSql = "Select Count(*) From BILL_WORK_FLOW Where (1=1)" + sCauseSql;
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BILL_WORK_FLOW",paging, order, sSql, parameters, connection);
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
			DisplayObject_BILL_WORK_FLOW dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BILL_WORK_FLOW();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEXT_BILL_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BILL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BILL_STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_BILL_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BILL_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BILL_OPT_COUNTER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BILL_MSG = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BILL_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BILL_TYPE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NEXT_BILL_CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COM_DEPART_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BILL_WORK_FLOW[] objs = new DisplayObject_BILL_WORK_FLOW[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BILL_WORK_FLOW[] Query(CauseObject_BILL_WORK_FLOW cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BILL_WORK_FLOW.ID, BILL_WORK_FLOW.CREATE_TIME, BILL_WORK_FLOW.NEXT_BILL_ID, BILL_WORK_FLOW.BILL_ID, BILL_WORK_FLOW.BILL_STATE, BILL_WORK_FLOW.NEXT_BILL_NAME, BILL_WORK_FLOW.CREATE_DEPT_ID, BILL_WORK_FLOW.BILL_CODE, BILL_WORK_FLOW.BILL_OPT_COUNTER, BILL_WORK_FLOW.BILL_MSG, BILL_WORK_FLOW.COMMENTS, BILL_WORK_FLOW.DATA_ORGANISE_ID, BILL_WORK_FLOW.BILL_NAME, BILL_WORK_FLOW.CREATE_USER_ID, BILL_WORK_FLOW.BILL_TYPE, BILL_WORK_FLOW.NEXT_BILL_CODE, COM_DEPART.NAME as COM_DEPART_NAME, COM_USER.NAME as COM_USER_NAME from BILL_WORK_FLOW left join COM_DEPART   COM_DEPART on BILL_WORK_FLOW.CREATE_DEPT_ID = COM_DEPART.ID left join COM_USER   COM_USER on BILL_WORK_FLOW.CREATE_USER_ID = COM_USER.ID where (1=1)";
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
					countSql = "Select Count(*) From BILL_WORK_FLOW Where (1=1)" + sCauseSql;
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer || IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.Db2? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BILL_WORK_FLOW",paging, order, sSql, parameters, trans);
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
			DisplayObject_BILL_WORK_FLOW dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BILL_WORK_FLOW();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NEXT_BILL_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BILL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BILL_STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NEXT_BILL_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BILL_CODE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BILL_OPT_COUNTER = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BILL_MSG = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BILL_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BILL_TYPE = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NEXT_BILL_CODE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COM_DEPART_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BILL_WORK_FLOW[] objs = new DisplayObject_BILL_WORK_FLOW[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BILL_WORK_FLOW obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("NEXT_BILL_ID"))
			{
				strBuf.Add("  BILL_WORK_FLOW.NEXT_BILL_ID = :NEXT_BILL_ID");
				param = new OracleParameter();
				param.ParameterName = ":NEXT_BILL_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.NEXT_BILL_ID) ? string.Empty : obj.NEXT_BILL_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BILL_ID"))
			{
				strBuf.Add("  BILL_WORK_FLOW.BILL_ID = :BILL_ID");
				param = new OracleParameter();
				param.ParameterName = ":BILL_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BILL_ID) ? string.Empty : obj.BILL_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BILL_STATE"))
			{
				strBuf.Add("  BILL_WORK_FLOW.BILL_STATE = :BILL_STATE");
				param = new OracleParameter();
				param.ParameterName = ":BILL_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.BILL_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NEXT_BILL_NAME"))
			{
				strBuf.Add("  BILL_WORK_FLOW.NEXT_BILL_NAME = :NEXT_BILL_NAME");
				param = new OracleParameter();
				param.ParameterName = ":NEXT_BILL_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NEXT_BILL_NAME) ? string.Empty : obj.NEXT_BILL_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  BILL_WORK_FLOW.CREATE_DEPT_ID = :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BILL_CODE"))
			{
				strBuf.Add("  BILL_WORK_FLOW.BILL_CODE = :BILL_CODE");
				param = new OracleParameter();
				param.ParameterName = ":BILL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BILL_CODE) ? string.Empty : obj.BILL_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BILL_OPT_COUNTER"))
			{
				strBuf.Add("  BILL_WORK_FLOW.BILL_OPT_COUNTER = :BILL_OPT_COUNTER");
				param = new OracleParameter();
				param.ParameterName = ":BILL_OPT_COUNTER";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.BILL_OPT_COUNTER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BILL_MSG"))
			{
				strBuf.Add("  BILL_WORK_FLOW.BILL_MSG = :BILL_MSG");
				param = new OracleParameter();
				param.ParameterName = ":BILL_MSG";
				param.OracleType = System.Data.OracleClient.OracleType.Clob;
				param.Size = 4000;
				param.Value = string.IsNullOrEmpty(obj.BILL_MSG) ? string.Empty : obj.BILL_MSG;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  BILL_WORK_FLOW.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  BILL_WORK_FLOW.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BILL_NAME"))
			{
				strBuf.Add("  BILL_WORK_FLOW.BILL_NAME = :BILL_NAME");
				param = new OracleParameter();
				param.ParameterName = ":BILL_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BILL_NAME) ? string.Empty : obj.BILL_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BILL_TYPE"))
			{
				strBuf.Add("  BILL_WORK_FLOW.BILL_TYPE = :BILL_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":BILL_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BILL_TYPE) ? string.Empty : obj.BILL_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NEXT_BILL_CODE"))
			{
				strBuf.Add("  BILL_WORK_FLOW.NEXT_BILL_CODE = :NEXT_BILL_CODE");
				param = new OracleParameter();
				param.ParameterName = ":NEXT_BILL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NEXT_BILL_CODE) ? string.Empty : obj.NEXT_BILL_CODE;
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
