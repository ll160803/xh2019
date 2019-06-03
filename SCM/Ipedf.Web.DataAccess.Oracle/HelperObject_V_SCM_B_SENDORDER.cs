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
	[CauseObject(typeof(CauseObject_V_SCM_B_SENDORDER))]
	public partial class HelperObject_V_SCM_B_SENDORDER
	{		
		#region Method Blok
		public static int Save(EntityObject_V_SCM_B_SENDORDER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_SCM_B_SENDORDER( GYSACCOUNT, FPJR, FPHM, ID, GYSNAME, CODE, COMMENTS, NAME, CREATE_TIME) values ( :GYSACCOUNT, :FPJR, :FPHM, :ID, :GYSNAME, :CODE, :COMMENTS, :NAME, :CREATE_TIME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[9];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":GYSACCOUNT";
			parameters[0].Size = 20;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.GYSACCOUNT == null ? String.Empty:obj.GYSACCOUNT;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":FPJR";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.FPJR;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":FPHM";
			parameters[2].Size = 20;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.FPHM == null ? String.Empty:obj.FPHM;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":GYSNAME";
			parameters[4].Size = 100;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.GYSNAME == null ? String.Empty:obj.GYSNAME;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":CODE";
			parameters[5].Size = 12;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":COMMENTS";
			parameters[6].Size = 300;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":NAME";
			parameters[7].Size = 500;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CREATE_TIME";
			parameters[8].Size = 7;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[8].Value = obj.CREATE_TIME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_SCM_B_SENDORDER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_SCM_B_SENDORDER set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_SCM_B_SENDORDER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_SCM_B_SENDORDER where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_SCM_B_SENDORDER Get(EntityObject_V_SCM_B_SENDORDER obj)
		{
			
			//平台自动生成代码
			string sSql = "select  GYSACCOUNT, FPJR, FPHM, ID, GYSNAME, CODE, COMMENTS, NAME, CREATE_TIME from V_SCM_B_SENDORDER where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FPJR = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPHM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_SCM_B_SENDORDER[] objs = new EntityObject_V_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_SCM_B_SENDORDER Get(EntityObject_V_SCM_B_SENDORDER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  GYSACCOUNT, FPJR, FPHM, ID, GYSNAME, CODE, COMMENTS, NAME, CREATE_TIME from V_SCM_B_SENDORDER where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FPJR = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPHM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_SCM_B_SENDORDER[] objs = new EntityObject_V_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_SCM_B_SENDORDER[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_SCM_B_SENDORDER.GYSACCOUNT, V_SCM_B_SENDORDER.FPJR, V_SCM_B_SENDORDER.FPHM, V_SCM_B_SENDORDER.ID, V_SCM_B_SENDORDER.GYSNAME, V_SCM_B_SENDORDER.CODE, V_SCM_B_SENDORDER.COMMENTS, V_SCM_B_SENDORDER.NAME, V_SCM_B_SENDORDER.CREATE_TIME from V_SCM_B_SENDORDER where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FPJR = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPHM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_B_SENDORDER[] objs = new DisplayObject_V_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_SCM_B_SENDORDER cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And V_SCM_B_SENDORDER.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_SENDORDER", "GYSACCOUNT"));
			}
			if(cause.FPJR!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_B_SENDORDER.FPJR = :FPJR");
				param = new OracleParameter();
				param.ParameterName =":FPJR";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.FPJR;
				paramList.Add(param);
			}
			if (cause.HasINValue("FPJR"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_SENDORDER", "FPJR"));
			}
			if(!string.IsNullOrEmpty(cause.FPHM))
			{
				strBuf.Append(" And V_SCM_B_SENDORDER.FPHM ").Append((cause.FPHM.StartsWith("%") || cause.FPHM.EndsWith("%")) ? " like " : " = ").Append(" :FPHM");
				param = new OracleParameter();
				param.ParameterName =":FPHM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.FPHM;
				paramList.Add(param);
			}
			if (cause.HasINValue("FPHM"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_SENDORDER", "FPHM"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_SCM_B_SENDORDER.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_SENDORDER", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.GYSNAME))
			{
				strBuf.Append(" And V_SCM_B_SENDORDER.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :GYSNAME");
				param = new OracleParameter();
				param.ParameterName =":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.GYSNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_SENDORDER", "GYSNAME"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And V_SCM_B_SENDORDER.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_SENDORDER", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And V_SCM_B_SENDORDER.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_SENDORDER", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_SCM_B_SENDORDER.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_SENDORDER", "NAME"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And V_SCM_B_SENDORDER.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And V_SCM_B_SENDORDER.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("V_SCM_B_SENDORDER", "CREATE_TIME"));
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
		public static DisplayObject_V_SCM_B_SENDORDER[] Query(CauseObject_V_SCM_B_SENDORDER cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_B_SENDORDER.GYSACCOUNT, V_SCM_B_SENDORDER.FPJR, V_SCM_B_SENDORDER.FPHM, V_SCM_B_SENDORDER.ID, V_SCM_B_SENDORDER.GYSNAME, V_SCM_B_SENDORDER.CODE, V_SCM_B_SENDORDER.COMMENTS, V_SCM_B_SENDORDER.NAME, V_SCM_B_SENDORDER.CREATE_TIME from V_SCM_B_SENDORDER where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FPJR = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPHM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_B_SENDORDER[] objs = new DisplayObject_V_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_SCM_B_SENDORDER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_SCM_B_SENDORDER where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_SCM_B_SENDORDER[] Query(CauseObject_V_SCM_B_SENDORDER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_B_SENDORDER.GYSACCOUNT, V_SCM_B_SENDORDER.FPJR, V_SCM_B_SENDORDER.FPHM, V_SCM_B_SENDORDER.ID, V_SCM_B_SENDORDER.GYSNAME, V_SCM_B_SENDORDER.CODE, V_SCM_B_SENDORDER.COMMENTS, V_SCM_B_SENDORDER.NAME, V_SCM_B_SENDORDER.CREATE_TIME from V_SCM_B_SENDORDER where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FPJR = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPHM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_B_SENDORDER[] objs = new DisplayObject_V_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_B_SENDORDER[] Query(CauseObject_V_SCM_B_SENDORDER cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
            string sSql = " select  V_SCM_B_SENDORDER.GYSACCOUNT, V_SCM_B_SENDORDER.FPJR, V_SCM_B_SENDORDER.FPHM, V_SCM_B_SENDORDER.ID, V_SCM_B_SENDORDER.GYSNAME, V_SCM_B_SENDORDER.CODE, V_SCM_B_SENDORDER.COMMENTS, V_SCM_B_SENDORDER.NAME, V_SCM_B_SENDORDER.CREATE_TIME,V_SCM_B_SENDORDER.WERKST,V_SCM_B_SENDORDER.FPRQ from V_SCM_B_SENDORDER where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_B_SENDORDER",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FPJR = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPHM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.WERKST = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.FPRQ = sqlReader.GetDateTime(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_B_SENDORDER[] objs = new DisplayObject_V_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_B_SENDORDER[] Query(CauseObject_V_SCM_B_SENDORDER cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_B_SENDORDER.GYSACCOUNT, V_SCM_B_SENDORDER.FPJR, V_SCM_B_SENDORDER.FPHM, V_SCM_B_SENDORDER.ID, V_SCM_B_SENDORDER.GYSNAME, V_SCM_B_SENDORDER.CODE, V_SCM_B_SENDORDER.COMMENTS, V_SCM_B_SENDORDER.NAME, V_SCM_B_SENDORDER.CREATE_TIME from V_SCM_B_SENDORDER where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_B_SENDORDER",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_SCM_B_SENDORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_SENDORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FPJR = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FPHM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_B_SENDORDER[] objs = new DisplayObject_V_SCM_B_SENDORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_SCM_B_SENDORDER obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  V_SCM_B_SENDORDER.GYSACCOUNT = :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FPJR"))
			{
				strBuf.Add("  V_SCM_B_SENDORDER.FPJR = :FPJR");
				param = new OracleParameter();
				param.ParameterName = ":FPJR";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.FPJR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FPHM"))
			{
				strBuf.Add("  V_SCM_B_SENDORDER.FPHM = :FPHM");
				param = new OracleParameter();
				param.ParameterName = ":FPHM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.FPHM) ? string.Empty : obj.FPHM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_SCM_B_SENDORDER.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSNAME"))
			{
				strBuf.Add("  V_SCM_B_SENDORDER.GYSNAME = :GYSNAME");
				param = new OracleParameter();
				param.ParameterName = ":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.GYSNAME) ? string.Empty : obj.GYSNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  V_SCM_B_SENDORDER.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  V_SCM_B_SENDORDER.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_SCM_B_SENDORDER.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			//pk here
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		#endregion 
	}
}
