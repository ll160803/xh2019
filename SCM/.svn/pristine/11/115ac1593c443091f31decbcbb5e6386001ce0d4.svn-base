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
	[CauseObject(typeof(CauseObject_SCM_B_SENDORDER))]
	public partial class HelperObject_SCM_B_SENDORDER
	{		
		#region Method Blok
		
		public static int Update(EntityObject_SCM_B_SENDORDER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_B_SENDORDER set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SCM_B_SENDORDER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SCM_B_SENDORDER where  ID = :ID ";
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
		public static EntityObject_SCM_B_SENDORDER Get(EntityObject_SCM_B_SENDORDER obj)
		{
			
			//平台自动生成代码
			string sSql = "select  COMMENTS, MODIFY_TIME, DATA_ORGANISE_ID, ID, CREATE_USER_ID, MODIFY_USER_ID, STATE, NAME, CODE, GYSACCOUNT, GYSNAME, FPJR, CREATE_TIME, FPHM, CREATE_DEPART_ID, MODIFY_DEPART_ID from SCM_B_SENDORDER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FPJR = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPHM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SCM_B_SENDORDER[] objs = new EntityObject_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_SCM_B_SENDORDER Get(EntityObject_SCM_B_SENDORDER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  COMMENTS, MODIFY_TIME, DATA_ORGANISE_ID, ID, CREATE_USER_ID, MODIFY_USER_ID, STATE, NAME, CODE, GYSACCOUNT, GYSNAME, FPJR, CREATE_TIME, FPHM, CREATE_DEPART_ID, MODIFY_DEPART_ID from SCM_B_SENDORDER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FPJR = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPHM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SCM_B_SENDORDER[] objs = new EntityObject_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_B_SENDORDER[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SCM_B_SENDORDER.COMMENTS, SCM_B_SENDORDER.MODIFY_TIME, SCM_B_SENDORDER.DATA_ORGANISE_ID, SCM_B_SENDORDER.ID, SCM_B_SENDORDER.CREATE_USER_ID, SCM_B_SENDORDER.MODIFY_USER_ID, SCM_B_SENDORDER.STATE, SCM_B_SENDORDER.NAME, SCM_B_SENDORDER.CODE, SCM_B_SENDORDER.GYSACCOUNT, SCM_B_SENDORDER.GYSNAME, SCM_B_SENDORDER.FPJR, SCM_B_SENDORDER.CREATE_TIME, SCM_B_SENDORDER.FPHM, SCM_B_SENDORDER.CREATE_DEPART_ID, SCM_B_SENDORDER.MODIFY_DEPART_ID from SCM_B_SENDORDER where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FPJR = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPHM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_SENDORDER[] objs = new DisplayObject_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SCM_B_SENDORDER cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And SCM_B_SENDORDER.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "COMMENTS"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_B_SENDORDER.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And SCM_B_SENDORDER.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And SCM_B_SENDORDER.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And SCM_B_SENDORDER.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And SCM_B_SENDORDER.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And SCM_B_SENDORDER.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "MODIFY_USER_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_SENDORDER.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And SCM_B_SENDORDER.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And SCM_B_SENDORDER.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And SCM_B_SENDORDER.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.GYSNAME))
			{
				strBuf.Append(" And SCM_B_SENDORDER.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :GYSNAME");
				param = new OracleParameter();
				param.ParameterName =":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.GYSNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSNAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "GYSNAME"));
			}
			if(cause.FPJR!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_SENDORDER.FPJR = :FPJR");
				param = new OracleParameter();
				param.ParameterName =":FPJR";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.FPJR;
				paramList.Add(param);
			}
			if (cause.HasINValue("FPJR"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "FPJR"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_B_SENDORDER.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And SCM_B_SENDORDER.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.FPHM))
			{
				strBuf.Append(" And SCM_B_SENDORDER.FPHM ").Append((cause.FPHM.StartsWith("%") || cause.FPHM.EndsWith("%")) ? " like " : " = ").Append(" :FPHM");
				param = new OracleParameter();
				param.ParameterName =":FPHM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.FPHM;
				paramList.Add(param);
			}
			if (cause.HasINValue("FPHM"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "FPHM"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And SCM_B_SENDORDER.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "CREATE_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And SCM_B_SENDORDER.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDORDER", "MODIFY_DEPART_ID"));
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
		public static DisplayObject_SCM_B_SENDORDER[] Query(CauseObject_SCM_B_SENDORDER cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_B_SENDORDER.COMMENTS, SCM_B_SENDORDER.MODIFY_TIME, SCM_B_SENDORDER.DATA_ORGANISE_ID, SCM_B_SENDORDER.ID, SCM_B_SENDORDER.CREATE_USER_ID, SCM_B_SENDORDER.MODIFY_USER_ID, SCM_B_SENDORDER.STATE, SCM_B_SENDORDER.NAME, SCM_B_SENDORDER.CODE, SCM_B_SENDORDER.GYSACCOUNT, SCM_B_SENDORDER.GYSNAME, SCM_B_SENDORDER.FPJR, SCM_B_SENDORDER.CREATE_TIME, SCM_B_SENDORDER.FPHM, SCM_B_SENDORDER.CREATE_DEPART_ID, SCM_B_SENDORDER.MODIFY_DEPART_ID from SCM_B_SENDORDER where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FPJR = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPHM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_SENDORDER[] objs = new DisplayObject_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_SCM_B_SENDORDER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SCM_B_SENDORDER where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_SCM_B_SENDORDER[] Query(CauseObject_SCM_B_SENDORDER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_B_SENDORDER.COMMENTS, SCM_B_SENDORDER.MODIFY_TIME, SCM_B_SENDORDER.DATA_ORGANISE_ID, SCM_B_SENDORDER.ID, SCM_B_SENDORDER.CREATE_USER_ID, SCM_B_SENDORDER.MODIFY_USER_ID, SCM_B_SENDORDER.STATE, SCM_B_SENDORDER.NAME, SCM_B_SENDORDER.CODE, SCM_B_SENDORDER.GYSACCOUNT, SCM_B_SENDORDER.GYSNAME, SCM_B_SENDORDER.FPJR, SCM_B_SENDORDER.CREATE_TIME, SCM_B_SENDORDER.FPHM, SCM_B_SENDORDER.CREATE_DEPART_ID, SCM_B_SENDORDER.MODIFY_DEPART_ID from SCM_B_SENDORDER where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FPJR = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPHM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_SENDORDER[] objs = new DisplayObject_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_SENDORDER[] Query(CauseObject_SCM_B_SENDORDER cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_B_SENDORDER.COMMENTS, SCM_B_SENDORDER.MODIFY_TIME, SCM_B_SENDORDER.DATA_ORGANISE_ID, SCM_B_SENDORDER.ID, SCM_B_SENDORDER.CREATE_USER_ID, SCM_B_SENDORDER.MODIFY_USER_ID, SCM_B_SENDORDER.STATE, SCM_B_SENDORDER.NAME, SCM_B_SENDORDER.CODE, SCM_B_SENDORDER.GYSACCOUNT, SCM_B_SENDORDER.GYSNAME, SCM_B_SENDORDER.FPJR, SCM_B_SENDORDER.CREATE_TIME, SCM_B_SENDORDER.FPHM, SCM_B_SENDORDER.CREATE_DEPART_ID, SCM_B_SENDORDER.MODIFY_DEPART_ID from SCM_B_SENDORDER where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_SENDORDER",paging, order, sSql, parameters, connection);
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
			DisplayObject_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FPJR = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPHM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_SENDORDER[] objs = new DisplayObject_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_SENDORDER[] Query(CauseObject_SCM_B_SENDORDER cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_B_SENDORDER.COMMENTS, SCM_B_SENDORDER.MODIFY_TIME, SCM_B_SENDORDER.DATA_ORGANISE_ID, SCM_B_SENDORDER.ID, SCM_B_SENDORDER.CREATE_USER_ID, SCM_B_SENDORDER.MODIFY_USER_ID, SCM_B_SENDORDER.STATE, SCM_B_SENDORDER.NAME, SCM_B_SENDORDER.CODE, SCM_B_SENDORDER.GYSACCOUNT, SCM_B_SENDORDER.GYSNAME, SCM_B_SENDORDER.FPJR, SCM_B_SENDORDER.CREATE_TIME, SCM_B_SENDORDER.FPHM, SCM_B_SENDORDER.CREATE_DEPART_ID, SCM_B_SENDORDER.MODIFY_DEPART_ID from SCM_B_SENDORDER where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_SENDORDER",paging, order, sSql, parameters, trans);
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
			DisplayObject_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FPJR = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FPHM = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_SENDORDER[] objs = new DisplayObject_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SCM_B_SENDORDER obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  SCM_B_SENDORDER.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  SCM_B_SENDORDER.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  SCM_B_SENDORDER.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  SCM_B_SENDORDER.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  SCM_B_SENDORDER.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  SCM_B_SENDORDER.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  SCM_B_SENDORDER.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  SCM_B_SENDORDER.GYSACCOUNT = :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSNAME"))
			{
				strBuf.Add("  SCM_B_SENDORDER.GYSNAME = :GYSNAME");
				param = new OracleParameter();
				param.ParameterName = ":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.GYSNAME) ? string.Empty : obj.GYSNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FPJR"))
			{
				strBuf.Add("  SCM_B_SENDORDER.FPJR = :FPJR");
				param = new OracleParameter();
				param.ParameterName = ":FPJR";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.FPJR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FPHM"))
			{
				strBuf.Add("  SCM_B_SENDORDER.FPHM = :FPHM");
				param = new OracleParameter();
				param.ParameterName = ":FPHM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.FPHM) ? string.Empty : obj.FPHM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  SCM_B_SENDORDER.MODIFY_DEPART_ID = :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
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
