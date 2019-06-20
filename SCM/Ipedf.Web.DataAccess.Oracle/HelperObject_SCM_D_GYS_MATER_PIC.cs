using System;
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
	[CauseObject(typeof(CauseObject_SCM_D_GYS_MATER_PIC))]
	public partial class HelperObject_SCM_D_GYS_MATER_PIC
	{		
		#region Method Blok
		public static int Update(EntityObject_SCM_D_GYS_MATER_PIC obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_D_GYS_MATER_PIC set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SCM_D_GYS_MATER_PIC obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SCM_D_GYS_MATER_PIC where  ID = :ID ";
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
		public static EntityObject_SCM_D_GYS_MATER_PIC Get(EntityObject_SCM_D_GYS_MATER_PIC obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, MODIFY_USER_ID, CODE, COMMENTS, FREEUSE1, FREEUSE3, CREATE_USER_ID, DATA_ORGANISE_ID, GYSACCOUNT, CHARGE, CREATE_TIME, MODIFY_TIME, MODIFY_DEPART_ID, MATER_ID, CREATE_DEPART_ID, STATE, FREEUSE2, NAME from SCM_D_GYS_MATER_PIC where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_D_GYS_MATER_PIC dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_D_GYS_MATER_PIC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE1 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE3 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CHARGE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREEUSE2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.NAME = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SCM_D_GYS_MATER_PIC[] objs = new EntityObject_SCM_D_GYS_MATER_PIC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_SCM_D_GYS_MATER_PIC Get(EntityObject_SCM_D_GYS_MATER_PIC obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, MODIFY_USER_ID, CODE, COMMENTS, FREEUSE1, FREEUSE3, CREATE_USER_ID, DATA_ORGANISE_ID, GYSACCOUNT, CHARGE, CREATE_TIME, MODIFY_TIME, MODIFY_DEPART_ID, MATER_ID, CREATE_DEPART_ID, STATE, FREEUSE2, NAME from SCM_D_GYS_MATER_PIC where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_D_GYS_MATER_PIC dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_D_GYS_MATER_PIC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE1 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE3 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CHARGE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREEUSE2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.NAME = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SCM_D_GYS_MATER_PIC[] objs = new EntityObject_SCM_D_GYS_MATER_PIC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_D_GYS_MATER_PIC[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SCM_D_GYS_MATER_PIC.ID, SCM_D_GYS_MATER_PIC.MODIFY_USER_ID, SCM_D_GYS_MATER_PIC.CODE, SCM_D_GYS_MATER_PIC.COMMENTS, SCM_D_GYS_MATER_PIC.FREEUSE1, SCM_D_GYS_MATER_PIC.FREEUSE3, SCM_D_GYS_MATER_PIC.CREATE_USER_ID, SCM_D_GYS_MATER_PIC.DATA_ORGANISE_ID, SCM_D_GYS_MATER_PIC.GYSACCOUNT, SCM_D_GYS_MATER_PIC.CHARGE, SCM_D_GYS_MATER_PIC.CREATE_TIME, SCM_D_GYS_MATER_PIC.MODIFY_TIME, SCM_D_GYS_MATER_PIC.MODIFY_DEPART_ID, SCM_D_GYS_MATER_PIC.MATER_ID, SCM_D_GYS_MATER_PIC.CREATE_DEPART_ID, SCM_D_GYS_MATER_PIC.STATE, SCM_D_GYS_MATER_PIC.FREEUSE2, SCM_D_GYS_MATER_PIC.NAME, SCM_D_MATER_MATER_ID.TXZ01 as MATER_ID_NAME from SCM_D_GYS_MATER_PIC left join SCM_D_MATER   SCM_D_MATER_MATER_ID on SCM_D_GYS_MATER_PIC.MATER_ID = SCM_D_MATER_MATER_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SCM_D_GYS_MATER_PIC dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_GYS_MATER_PIC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE1 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE3 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CHARGE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREEUSE2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MATER_ID_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_D_GYS_MATER_PIC[] objs = new DisplayObject_SCM_D_GYS_MATER_PIC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SCM_D_GYS_MATER_PIC cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE1))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.FREEUSE1 ").Append((cause.FREEUSE1.StartsWith("%") || cause.FREEUSE1.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE1");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FREEUSE1;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE1"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "FREEUSE1"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE3))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.FREEUSE3 ").Append((cause.FREEUSE3.StartsWith("%") || cause.FREEUSE3.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE3");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.FREEUSE3;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE3"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "FREEUSE3"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.CHARGE))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.CHARGE ").Append((cause.CHARGE.StartsWith("%") || cause.CHARGE.EndsWith("%")) ? " like " : " = ").Append(" :CHARGE");
				param = new OracleParameter();
				param.ParameterName =":CHARGE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.CHARGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CHARGE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "CHARGE"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_D_GYS_MATER_PIC.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And SCM_D_GYS_MATER_PIC.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "CREATE_TIME"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_D_GYS_MATER_PIC.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And SCM_D_GYS_MATER_PIC.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "MODIFY_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MATER_ID))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.MATER_ID ").Append((cause.MATER_ID.StartsWith("%") || cause.MATER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MATER_ID");
				param = new OracleParameter();
				param.ParameterName =":MATER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MATER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "MATER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "CREATE_DEPART_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE2))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.FREEUSE2 ").Append((cause.FREEUSE2.StartsWith("%") || cause.FREEUSE2.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE2");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.FREEUSE2;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE2"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "FREEUSE2"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And SCM_D_GYS_MATER_PIC.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_GYS_MATER_PIC", "NAME"));
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
		public static DisplayObject_SCM_D_GYS_MATER_PIC[] Query(CauseObject_SCM_D_GYS_MATER_PIC cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_D_GYS_MATER_PIC.ID, SCM_D_GYS_MATER_PIC.MODIFY_USER_ID, SCM_D_GYS_MATER_PIC.CODE, SCM_D_GYS_MATER_PIC.COMMENTS, SCM_D_GYS_MATER_PIC.FREEUSE1, SCM_D_GYS_MATER_PIC.FREEUSE3, SCM_D_GYS_MATER_PIC.CREATE_USER_ID, SCM_D_GYS_MATER_PIC.DATA_ORGANISE_ID, SCM_D_GYS_MATER_PIC.GYSACCOUNT, SCM_D_GYS_MATER_PIC.CHARGE, SCM_D_GYS_MATER_PIC.CREATE_TIME, SCM_D_GYS_MATER_PIC.MODIFY_TIME, SCM_D_GYS_MATER_PIC.MODIFY_DEPART_ID, SCM_D_GYS_MATER_PIC.MATER_ID, SCM_D_GYS_MATER_PIC.CREATE_DEPART_ID, SCM_D_GYS_MATER_PIC.STATE, SCM_D_GYS_MATER_PIC.FREEUSE2, SCM_D_GYS_MATER_PIC.NAME, SCM_D_MATER_MATER_ID.TXZ01 as MATER_ID_NAME from SCM_D_GYS_MATER_PIC left join SCM_D_MATER   SCM_D_MATER_MATER_ID on SCM_D_GYS_MATER_PIC.MATER_ID = SCM_D_MATER_MATER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_D_GYS_MATER_PIC dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_GYS_MATER_PIC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE1 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE3 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CHARGE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREEUSE2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MATER_ID_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_D_GYS_MATER_PIC[] objs = new DisplayObject_SCM_D_GYS_MATER_PIC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_SCM_D_GYS_MATER_PIC cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SCM_D_GYS_MATER_PIC where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_SCM_D_GYS_MATER_PIC[] Query(CauseObject_SCM_D_GYS_MATER_PIC cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_D_GYS_MATER_PIC.ID, SCM_D_GYS_MATER_PIC.MODIFY_USER_ID, SCM_D_GYS_MATER_PIC.CODE, SCM_D_GYS_MATER_PIC.COMMENTS, SCM_D_GYS_MATER_PIC.FREEUSE1, SCM_D_GYS_MATER_PIC.FREEUSE3, SCM_D_GYS_MATER_PIC.CREATE_USER_ID, SCM_D_GYS_MATER_PIC.DATA_ORGANISE_ID, SCM_D_GYS_MATER_PIC.GYSACCOUNT, SCM_D_GYS_MATER_PIC.CHARGE, SCM_D_GYS_MATER_PIC.CREATE_TIME, SCM_D_GYS_MATER_PIC.MODIFY_TIME, SCM_D_GYS_MATER_PIC.MODIFY_DEPART_ID, SCM_D_GYS_MATER_PIC.MATER_ID, SCM_D_GYS_MATER_PIC.CREATE_DEPART_ID, SCM_D_GYS_MATER_PIC.STATE, SCM_D_GYS_MATER_PIC.FREEUSE2, SCM_D_GYS_MATER_PIC.NAME, SCM_D_MATER_MATER_ID.TXZ01 as MATER_ID_NAME from SCM_D_GYS_MATER_PIC left join SCM_D_MATER   SCM_D_MATER_MATER_ID on SCM_D_GYS_MATER_PIC.MATER_ID = SCM_D_MATER_MATER_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_D_GYS_MATER_PIC dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_GYS_MATER_PIC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE1 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE3 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CHARGE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREEUSE2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MATER_ID_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_D_GYS_MATER_PIC[] objs = new DisplayObject_SCM_D_GYS_MATER_PIC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_D_GYS_MATER_PIC[] Query(CauseObject_SCM_D_GYS_MATER_PIC cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_D_GYS_MATER_PIC.ID, SCM_D_GYS_MATER_PIC.MODIFY_USER_ID, SCM_D_GYS_MATER_PIC.CODE, SCM_D_GYS_MATER_PIC.COMMENTS, SCM_D_GYS_MATER_PIC.FREEUSE1, SCM_D_GYS_MATER_PIC.FREEUSE3, SCM_D_GYS_MATER_PIC.CREATE_USER_ID, SCM_D_GYS_MATER_PIC.DATA_ORGANISE_ID, SCM_D_GYS_MATER_PIC.GYSACCOUNT, SCM_D_GYS_MATER_PIC.CHARGE, SCM_D_GYS_MATER_PIC.CREATE_TIME, SCM_D_GYS_MATER_PIC.MODIFY_TIME, SCM_D_GYS_MATER_PIC.MODIFY_DEPART_ID, SCM_D_GYS_MATER_PIC.MATER_ID, SCM_D_GYS_MATER_PIC.CREATE_DEPART_ID, SCM_D_GYS_MATER_PIC.STATE, SCM_D_GYS_MATER_PIC.FREEUSE2, SCM_D_GYS_MATER_PIC.NAME, SCM_D_MATER_MATER_ID.TXZ01 as MATER_ID_NAME from SCM_D_GYS_MATER_PIC left join SCM_D_MATER   SCM_D_MATER_MATER_ID on SCM_D_GYS_MATER_PIC.MATER_ID = SCM_D_MATER_MATER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_D_GYS_MATER_PIC",paging, order, sSql, parameters, connection);
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
			DisplayObject_SCM_D_GYS_MATER_PIC dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_GYS_MATER_PIC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE1 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE3 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CHARGE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREEUSE2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MATER_ID_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_D_GYS_MATER_PIC[] objs = new DisplayObject_SCM_D_GYS_MATER_PIC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_D_GYS_MATER_PIC[] Query(CauseObject_SCM_D_GYS_MATER_PIC cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_D_GYS_MATER_PIC.ID, SCM_D_GYS_MATER_PIC.MODIFY_USER_ID, SCM_D_GYS_MATER_PIC.CODE, SCM_D_GYS_MATER_PIC.COMMENTS, SCM_D_GYS_MATER_PIC.FREEUSE1, SCM_D_GYS_MATER_PIC.FREEUSE3, SCM_D_GYS_MATER_PIC.CREATE_USER_ID, SCM_D_GYS_MATER_PIC.DATA_ORGANISE_ID, SCM_D_GYS_MATER_PIC.GYSACCOUNT, SCM_D_GYS_MATER_PIC.CHARGE, SCM_D_GYS_MATER_PIC.CREATE_TIME, SCM_D_GYS_MATER_PIC.MODIFY_TIME, SCM_D_GYS_MATER_PIC.MODIFY_DEPART_ID, SCM_D_GYS_MATER_PIC.MATER_ID, SCM_D_GYS_MATER_PIC.CREATE_DEPART_ID, SCM_D_GYS_MATER_PIC.STATE, SCM_D_GYS_MATER_PIC.FREEUSE2, SCM_D_GYS_MATER_PIC.NAME, SCM_D_MATER_MATER_ID.TXZ01 as MATER_ID_NAME from SCM_D_GYS_MATER_PIC left join SCM_D_MATER   SCM_D_MATER_MATER_ID on SCM_D_GYS_MATER_PIC.MATER_ID = SCM_D_MATER_MATER_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_D_GYS_MATER_PIC",paging, order, sSql, parameters, trans);
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
			DisplayObject_SCM_D_GYS_MATER_PIC dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_GYS_MATER_PIC();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE1 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE3 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CHARGE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATER_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.FREEUSE2 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MATER_ID_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_D_GYS_MATER_PIC[] objs = new DisplayObject_SCM_D_GYS_MATER_PIC[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SCM_D_GYS_MATER_PIC obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE1"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.FREEUSE1 = :FREEUSE1");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE1) ? string.Empty : obj.FREEUSE1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE3"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.FREEUSE3 = :FREEUSE3");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE3) ? string.Empty : obj.FREEUSE3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.GYSACCOUNT = :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CHARGE"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.CHARGE = :CHARGE");
				param = new OracleParameter();
				param.ParameterName = ":CHARGE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.CHARGE) ? string.Empty : obj.CHARGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.MODIFY_DEPART_ID = :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATER_ID"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.MATER_ID = :MATER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MATER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MATER_ID) ? string.Empty : obj.MATER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE2"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.FREEUSE2 = :FREEUSE2");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE2) ? string.Empty : obj.FREEUSE2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  SCM_D_GYS_MATER_PIC.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
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
