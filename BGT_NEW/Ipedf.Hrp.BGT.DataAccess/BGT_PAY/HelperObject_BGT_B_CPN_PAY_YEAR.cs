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
	[CauseObject(typeof(CauseObject_BGT_B_CPN_PAY_YEAR))]
	public partial class HelperObject_BGT_B_CPN_PAY_YEAR
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_CPN_PAY_YEAR obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_B_CPN_PAY_YEAR( DATA_ORGANISE_ID, ID, TEMPLET_ID, BUDGET_CPN_ID, STATE, BUDGET_YEAR, MODIFY_DEPT_ID, CREATE_TIME, CREATE_USER_ID, CREATE_DEPT_ID, COMMENTS) values ( :DATA_ORGANISE_ID, :ID, :TEMPLET_ID, :BUDGET_CPN_ID, :STATE, :BUDGET_YEAR, :MODIFY_DEPT_ID, :CREATE_TIME, :CREATE_USER_ID, :CREATE_DEPT_ID, :COMMENTS)";
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
			parameters[2].ParameterName =":TEMPLET_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.TEMPLET_ID == null ? String.Empty:obj.TEMPLET_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":BUDGET_CPN_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.BUDGET_CPN_ID == null ? String.Empty:obj.BUDGET_CPN_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":STATE";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.STATE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":BUDGET_YEAR";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":MODIFY_DEPT_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.MODIFY_DEPT_ID == null ? String.Empty:obj.MODIFY_DEPT_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CREATE_TIME";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.CREATE_TIME;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CREATE_USER_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":CREATE_DEPT_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.CREATE_DEPT_ID == null ? String.Empty:obj.CREATE_DEPT_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":COMMENTS";
			parameters[10].Size = 200;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_CPN_PAY_YEAR obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_CPN_PAY_YEAR set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_CPN_PAY_YEAR obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_CPN_PAY_YEAR where  ID = :ID ";
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
		public static EntityObject_BGT_B_CPN_PAY_YEAR Get(EntityObject_BGT_B_CPN_PAY_YEAR obj)
		{
			
			//平台自动生成代码
			string sSql = "select  DATA_ORGANISE_ID, MODIFY_TIME, ID, TEMPLET_ID, BUDGET_CPN_ID, STATE, MODIFY_USER_ID, BUDGET_YEAR, MODIFY_DEPT_ID, CREATE_TIME, CREATE_USER_ID, CREATE_DEPT_ID, COMMENTS from BGT_B_CPN_PAY_YEAR where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_CPN_PAY_YEAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_CPN_PAY_YEAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TEMPLET_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_CPN_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_CPN_PAY_YEAR[] objs = new EntityObject_BGT_B_CPN_PAY_YEAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_CPN_PAY_YEAR Get(EntityObject_BGT_B_CPN_PAY_YEAR obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  DATA_ORGANISE_ID, MODIFY_TIME, ID, TEMPLET_ID, BUDGET_CPN_ID, STATE, MODIFY_USER_ID, BUDGET_YEAR, MODIFY_DEPT_ID, CREATE_TIME, CREATE_USER_ID, CREATE_DEPT_ID, COMMENTS from BGT_B_CPN_PAY_YEAR where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_CPN_PAY_YEAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_CPN_PAY_YEAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TEMPLET_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_CPN_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_CPN_PAY_YEAR[] objs = new EntityObject_BGT_B_CPN_PAY_YEAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_CPN_PAY_YEAR[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_CPN_PAY_YEAR.DATA_ORGANISE_ID, BGT_B_CPN_PAY_YEAR.MODIFY_TIME, BGT_B_CPN_PAY_YEAR.ID, BGT_B_CPN_PAY_YEAR.TEMPLET_ID, BGT_B_CPN_PAY_YEAR.BUDGET_CPN_ID, BGT_B_CPN_PAY_YEAR.STATE, BGT_B_CPN_PAY_YEAR.MODIFY_USER_ID, BGT_B_CPN_PAY_YEAR.BUDGET_YEAR, BGT_B_CPN_PAY_YEAR.MODIFY_DEPT_ID, BGT_B_CPN_PAY_YEAR.CREATE_TIME, BGT_B_CPN_PAY_YEAR.CREATE_USER_ID, BGT_B_CPN_PAY_YEAR.CREATE_DEPT_ID, BGT_B_CPN_PAY_YEAR.COMMENTS, BGT_D_BUDGET_T_TEMPLET_ID.NAME as TEMPLET_ID_NAME, (case  when BGT_B_CPN_PAY_YEAR.STATE = 0 then '默认值' when BGT_B_CPN_PAY_YEAR.STATE = 1 then '编辑中' when BGT_B_CPN_PAY_YEAR.STATE = 2 then '已提交' when BGT_B_CPN_PAY_YEAR.STATE = 3 then '已审核' when BGT_B_CPN_PAY_YEAR.STATE = 4 then '已归档' when BGT_B_CPN_PAY_YEAR.STATE = 9 then '已作废' else '' end ) as STATE_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from BGT_B_CPN_PAY_YEAR left join BGT_D_BUDGET_T   BGT_D_BUDGET_T_TEMPLET_ID on BGT_B_CPN_PAY_YEAR.TEMPLET_ID = BGT_D_BUDGET_T_TEMPLET_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_CPN_PAY_YEAR.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_CPN_PAY_YEAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_PAY_YEAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TEMPLET_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_CPN_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.TEMPLET_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_CPN_PAY_YEAR[] objs = new DisplayObject_BGT_B_CPN_PAY_YEAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_CPN_PAY_YEAR cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.DATA_ORGANISE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_PAY_YEAR.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_PAY_YEAR", "DATA_ORGANISE_ID"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And BGT_B_CPN_PAY_YEAR.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And BGT_B_CPN_PAY_YEAR.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_PAY_YEAR", "MODIFY_TIME"));
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_PAY_YEAR.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_PAY_YEAR", "ID"));
			}
			if(cause.TEMPLET_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_PAY_YEAR.TEMPLET_ID ").Append((cause.TEMPLET_ID.StartsWith("%") || cause.TEMPLET_ID.EndsWith("%")) ? " like " : " = ").Append(" :TEMPLET_ID");
				param = new OracleParameter();
				param.ParameterName =":TEMPLET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.TEMPLET_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TEMPLET_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_PAY_YEAR", "TEMPLET_ID"));
			}
			if(cause.BUDGET_CPN_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_PAY_YEAR.BUDGET_CPN_ID ").Append((cause.BUDGET_CPN_ID.StartsWith("%") || cause.BUDGET_CPN_ID.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_CPN_ID");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_CPN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_CPN_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_CPN_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_PAY_YEAR", "BUDGET_CPN_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_PAY_YEAR.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_PAY_YEAR", "STATE"));
			}
			if(cause.MODIFY_USER_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_PAY_YEAR.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_PAY_YEAR", "MODIFY_USER_ID"));
			}
			if(cause.BUDGET_YEAR!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_PAY_YEAR.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_PAY_YEAR", "BUDGET_YEAR"));
			}
			if(cause.MODIFY_DEPT_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_PAY_YEAR.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_PAY_YEAR", "MODIFY_DEPT_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And BGT_B_CPN_PAY_YEAR.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And BGT_B_CPN_PAY_YEAR.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_PAY_YEAR", "CREATE_TIME"));
			}
			if(cause.CREATE_USER_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_PAY_YEAR.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_PAY_YEAR", "CREATE_USER_ID"));
			}
			if(cause.CREATE_DEPT_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_PAY_YEAR.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_PAY_YEAR", "CREATE_DEPT_ID"));
			}
			if(cause.COMMENTS!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_PAY_YEAR.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_PAY_YEAR", "COMMENTS"));
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
		public static DisplayObject_BGT_B_CPN_PAY_YEAR[] Query(CauseObject_BGT_B_CPN_PAY_YEAR cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_PAY_YEAR.DATA_ORGANISE_ID, BGT_B_CPN_PAY_YEAR.MODIFY_TIME, BGT_B_CPN_PAY_YEAR.ID, BGT_B_CPN_PAY_YEAR.TEMPLET_ID, BGT_B_CPN_PAY_YEAR.BUDGET_CPN_ID, BGT_B_CPN_PAY_YEAR.STATE, BGT_B_CPN_PAY_YEAR.MODIFY_USER_ID, BGT_B_CPN_PAY_YEAR.BUDGET_YEAR, BGT_B_CPN_PAY_YEAR.MODIFY_DEPT_ID, BGT_B_CPN_PAY_YEAR.CREATE_TIME, BGT_B_CPN_PAY_YEAR.CREATE_USER_ID, BGT_B_CPN_PAY_YEAR.CREATE_DEPT_ID, BGT_B_CPN_PAY_YEAR.COMMENTS, BGT_D_BUDGET_T_TEMPLET_ID.NAME as TEMPLET_ID_NAME, (case  when BGT_B_CPN_PAY_YEAR.STATE = 0 then '默认值' when BGT_B_CPN_PAY_YEAR.STATE = 1 then '编辑中' when BGT_B_CPN_PAY_YEAR.STATE = 2 then '已提交' when BGT_B_CPN_PAY_YEAR.STATE = 3 then '已审核' when BGT_B_CPN_PAY_YEAR.STATE = 4 then '已归档' when BGT_B_CPN_PAY_YEAR.STATE = 9 then '已作废' else '' end ) as STATE_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from BGT_B_CPN_PAY_YEAR left join BGT_D_BUDGET_T   BGT_D_BUDGET_T_TEMPLET_ID on BGT_B_CPN_PAY_YEAR.TEMPLET_ID = BGT_D_BUDGET_T_TEMPLET_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_CPN_PAY_YEAR.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_CPN_PAY_YEAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_PAY_YEAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TEMPLET_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_CPN_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.TEMPLET_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_CPN_PAY_YEAR[] objs = new DisplayObject_BGT_B_CPN_PAY_YEAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_CPN_PAY_YEAR cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_CPN_PAY_YEAR where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_CPN_PAY_YEAR[] Query(CauseObject_BGT_B_CPN_PAY_YEAR cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_PAY_YEAR.DATA_ORGANISE_ID, BGT_B_CPN_PAY_YEAR.MODIFY_TIME, BGT_B_CPN_PAY_YEAR.ID, BGT_B_CPN_PAY_YEAR.TEMPLET_ID, BGT_B_CPN_PAY_YEAR.BUDGET_CPN_ID, BGT_B_CPN_PAY_YEAR.STATE, BGT_B_CPN_PAY_YEAR.MODIFY_USER_ID, BGT_B_CPN_PAY_YEAR.BUDGET_YEAR, BGT_B_CPN_PAY_YEAR.MODIFY_DEPT_ID, BGT_B_CPN_PAY_YEAR.CREATE_TIME, BGT_B_CPN_PAY_YEAR.CREATE_USER_ID, BGT_B_CPN_PAY_YEAR.CREATE_DEPT_ID, BGT_B_CPN_PAY_YEAR.COMMENTS, BGT_D_BUDGET_T_TEMPLET_ID.NAME as TEMPLET_ID_NAME, (case  when BGT_B_CPN_PAY_YEAR.STATE = 0 then '默认值' when BGT_B_CPN_PAY_YEAR.STATE = 1 then '编辑中' when BGT_B_CPN_PAY_YEAR.STATE = 2 then '已提交' when BGT_B_CPN_PAY_YEAR.STATE = 3 then '已审核' when BGT_B_CPN_PAY_YEAR.STATE = 4 then '已归档' when BGT_B_CPN_PAY_YEAR.STATE = 9 then '已作废' else '' end ) as STATE_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from BGT_B_CPN_PAY_YEAR left join BGT_D_BUDGET_T   BGT_D_BUDGET_T_TEMPLET_ID on BGT_B_CPN_PAY_YEAR.TEMPLET_ID = BGT_D_BUDGET_T_TEMPLET_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_CPN_PAY_YEAR.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_CPN_PAY_YEAR dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_PAY_YEAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TEMPLET_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_CPN_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.TEMPLET_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_CPN_PAY_YEAR[] objs = new DisplayObject_BGT_B_CPN_PAY_YEAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_CPN_PAY_YEAR[] Query(CauseObject_BGT_B_CPN_PAY_YEAR cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_PAY_YEAR.DATA_ORGANISE_ID, BGT_B_CPN_PAY_YEAR.MODIFY_TIME, BGT_B_CPN_PAY_YEAR.ID, BGT_B_CPN_PAY_YEAR.TEMPLET_ID, BGT_B_CPN_PAY_YEAR.BUDGET_CPN_ID, BGT_B_CPN_PAY_YEAR.STATE, BGT_B_CPN_PAY_YEAR.MODIFY_USER_ID, BGT_B_CPN_PAY_YEAR.BUDGET_YEAR, BGT_B_CPN_PAY_YEAR.MODIFY_DEPT_ID, BGT_B_CPN_PAY_YEAR.CREATE_TIME, BGT_B_CPN_PAY_YEAR.CREATE_USER_ID, BGT_B_CPN_PAY_YEAR.CREATE_DEPT_ID, BGT_B_CPN_PAY_YEAR.COMMENTS, BGT_D_BUDGET_T_TEMPLET_ID.NAME as TEMPLET_ID_NAME, (case  when BGT_B_CPN_PAY_YEAR.STATE = 0 then '默认值' when BGT_B_CPN_PAY_YEAR.STATE = 1 then '编辑中' when BGT_B_CPN_PAY_YEAR.STATE = 2 then '已提交' when BGT_B_CPN_PAY_YEAR.STATE = 3 then '已审核' when BGT_B_CPN_PAY_YEAR.STATE = 4 then '已归档' when BGT_B_CPN_PAY_YEAR.STATE = 9 then '已作废' else '' end ) as STATE_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from BGT_B_CPN_PAY_YEAR left join BGT_D_BUDGET_T   BGT_D_BUDGET_T_TEMPLET_ID on BGT_B_CPN_PAY_YEAR.TEMPLET_ID = BGT_D_BUDGET_T_TEMPLET_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_CPN_PAY_YEAR.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_CPN_PAY_YEAR",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_CPN_PAY_YEAR dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_PAY_YEAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TEMPLET_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_CPN_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.TEMPLET_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_CPN_PAY_YEAR[] objs = new DisplayObject_BGT_B_CPN_PAY_YEAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_CPN_PAY_YEAR[] Query(CauseObject_BGT_B_CPN_PAY_YEAR cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_PAY_YEAR.DATA_ORGANISE_ID, BGT_B_CPN_PAY_YEAR.MODIFY_TIME, BGT_B_CPN_PAY_YEAR.ID, BGT_B_CPN_PAY_YEAR.TEMPLET_ID, BGT_B_CPN_PAY_YEAR.BUDGET_CPN_ID, BGT_B_CPN_PAY_YEAR.STATE, BGT_B_CPN_PAY_YEAR.MODIFY_USER_ID, BGT_B_CPN_PAY_YEAR.BUDGET_YEAR, BGT_B_CPN_PAY_YEAR.MODIFY_DEPT_ID, BGT_B_CPN_PAY_YEAR.CREATE_TIME, BGT_B_CPN_PAY_YEAR.CREATE_USER_ID, BGT_B_CPN_PAY_YEAR.CREATE_DEPT_ID, BGT_B_CPN_PAY_YEAR.COMMENTS, BGT_D_BUDGET_T_TEMPLET_ID.NAME as TEMPLET_ID_NAME, (case  when BGT_B_CPN_PAY_YEAR.STATE = 0 then '默认值' when BGT_B_CPN_PAY_YEAR.STATE = 1 then '编辑中' when BGT_B_CPN_PAY_YEAR.STATE = 2 then '已提交' when BGT_B_CPN_PAY_YEAR.STATE = 3 then '已审核' when BGT_B_CPN_PAY_YEAR.STATE = 4 then '已归档' when BGT_B_CPN_PAY_YEAR.STATE = 9 then '已作废' else '' end ) as STATE_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from BGT_B_CPN_PAY_YEAR left join BGT_D_BUDGET_T   BGT_D_BUDGET_T_TEMPLET_ID on BGT_B_CPN_PAY_YEAR.TEMPLET_ID = BGT_D_BUDGET_T_TEMPLET_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_B_CPN_PAY_YEAR.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_CPN_PAY_YEAR",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_CPN_PAY_YEAR dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_PAY_YEAR();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TEMPLET_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BUDGET_CPN_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MODIFY_DEPT_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_DEPT_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.COMMENTS = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.TEMPLET_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_CPN_PAY_YEAR[] objs = new DisplayObject_BGT_B_CPN_PAY_YEAR[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_CPN_PAY_YEAR obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  BGT_B_CPN_PAY_YEAR.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  BGT_B_CPN_PAY_YEAR.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TEMPLET_ID"))
			{
				strBuf.Add("  BGT_B_CPN_PAY_YEAR.TEMPLET_ID = :TEMPLET_ID");
				param = new OracleParameter();
				param.ParameterName = ":TEMPLET_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.TEMPLET_ID) ? string.Empty : obj.TEMPLET_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_CPN_ID"))
			{
				strBuf.Add("  BGT_B_CPN_PAY_YEAR.BUDGET_CPN_ID = :BUDGET_CPN_ID");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_CPN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_CPN_ID) ? string.Empty : obj.BUDGET_CPN_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  BGT_B_CPN_PAY_YEAR.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  BGT_B_CPN_PAY_YEAR.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  BGT_B_CPN_PAY_YEAR.BUDGET_YEAR = :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
			{
				strBuf.Add("  BGT_B_CPN_PAY_YEAR.MODIFY_DEPT_ID = :MODIFY_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
			{
				strBuf.Add("  BGT_B_CPN_PAY_YEAR.CREATE_DEPT_ID = :CREATE_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":CREATE_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  BGT_B_CPN_PAY_YEAR.COMMENTS = :COMMENTS");
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
