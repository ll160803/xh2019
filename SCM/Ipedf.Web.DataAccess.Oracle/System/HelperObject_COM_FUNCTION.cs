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
	[CauseObject(typeof(CauseObject_COM_FUNCTION))]
	public partial class HelperObject_COM_FUNCTION
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_FUNCTION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_FUNCTION( CODE, MODULE_ID, NAME, DEFAULT_PAGE_URL, STATE, IMG_URL, VERSION, DISPLAY_INDEX, ID, DELIVER_DATE, COMMENTS) values ( :CODE, :MODULE_ID, :NAME, :DEFAULT_PAGE_URL, :STATE, :IMG_URL, :VERSION, :DISPLAY_INDEX, :ID, :DELIVER_DATE, :COMMENTS)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[11];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CODE";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":MODULE_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.MODULE_ID == null ? String.Empty:obj.MODULE_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":NAME";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":DEFAULT_PAGE_URL";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.DEFAULT_PAGE_URL == null ? String.Empty:obj.DEFAULT_PAGE_URL;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":STATE";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.STATE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":IMG_URL";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.IMG_URL == null ? String.Empty:obj.IMG_URL;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":VERSION";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.VERSION == null ? String.Empty:obj.VERSION;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":DISPLAY_INDEX";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.DISPLAY_INDEX;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":DELIVER_DATE";
			parameters[9].Size = 7;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[9].Value = obj.DELIVER_DATE;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":COMMENTS";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_FUNCTION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_FUNCTION set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_FUNCTION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_FUNCTION where  ID = :ID ";
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
		public static EntityObject_COM_FUNCTION Get(EntityObject_COM_FUNCTION obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CODE, MODULE_ID, NAME, DEFAULT_PAGE_URL, STATE, IMG_URL, VERSION, DISPLAY_INDEX, ID, DELIVER_DATE, COMMENTS from COM_FUNCTION where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_FUNCTION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_FUNCTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODULE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IMG_URL = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.VERSION = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DELIVER_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_FUNCTION[] objs = new EntityObject_COM_FUNCTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_FUNCTION Get(EntityObject_COM_FUNCTION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CODE, MODULE_ID, NAME, DEFAULT_PAGE_URL, STATE, IMG_URL, VERSION, DISPLAY_INDEX, ID, DELIVER_DATE, COMMENTS from COM_FUNCTION where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_FUNCTION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_FUNCTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODULE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IMG_URL = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.VERSION = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DELIVER_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_FUNCTION[] objs = new EntityObject_COM_FUNCTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_FUNCTION[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_FUNCTION.CODE, COM_FUNCTION.MODULE_ID, COM_FUNCTION.NAME, COM_FUNCTION.DEFAULT_PAGE_URL, COM_FUNCTION.STATE, COM_FUNCTION.IMG_URL, COM_FUNCTION.VERSION, COM_FUNCTION.DISPLAY_INDEX, COM_FUNCTION.ID, COM_FUNCTION.DELIVER_DATE, COM_FUNCTION.COMMENTS, COM_MODULE.NAME as COM_MODULE_NAME from COM_FUNCTION left join COM_MODULE   COM_MODULE on COM_FUNCTION.MODULE_ID = COM_MODULE.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_FUNCTION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FUNCTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODULE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IMG_URL = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.VERSION = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DELIVER_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_MODULE_NAME = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_FUNCTION[] objs = new DisplayObject_COM_FUNCTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_FUNCTION cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.CODE!= string.Empty)
			{
				strBuf.Append(" And COM_FUNCTION.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("COM_FUNCTION", "CODE"));
			}
			if(cause.MODULE_ID!= string.Empty)
			{
				strBuf.Append(" And COM_FUNCTION.MODULE_ID ").Append((cause.MODULE_ID.StartsWith("%") || cause.MODULE_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODULE_ID");
				param = new OracleParameter();
				param.ParameterName =":MODULE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODULE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODULE_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_FUNCTION", "MODULE_ID"));
			}
			if(cause.NAME!= string.Empty)
			{
				strBuf.Append(" And COM_FUNCTION.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("COM_FUNCTION", "NAME"));
			}
			if(cause.DEFAULT_PAGE_URL!= string.Empty)
			{
				strBuf.Append(" And COM_FUNCTION.DEFAULT_PAGE_URL ").Append((cause.DEFAULT_PAGE_URL.StartsWith("%") || cause.DEFAULT_PAGE_URL.EndsWith("%")) ? " like " : " = ").Append(" :DEFAULT_PAGE_URL");
				param = new OracleParameter();
				param.ParameterName =":DEFAULT_PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DEFAULT_PAGE_URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEFAULT_PAGE_URL"))
			{
				strBuf.Append(cause.GetINSQL("COM_FUNCTION", "DEFAULT_PAGE_URL"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_FUNCTION.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("COM_FUNCTION", "STATE"));
			}
			if(cause.IMG_URL!= string.Empty)
			{
				strBuf.Append(" And COM_FUNCTION.IMG_URL ").Append((cause.IMG_URL.StartsWith("%") || cause.IMG_URL.EndsWith("%")) ? " like " : " = ").Append(" :IMG_URL");
				param = new OracleParameter();
				param.ParameterName =":IMG_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.IMG_URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("IMG_URL"))
			{
				strBuf.Append(cause.GetINSQL("COM_FUNCTION", "IMG_URL"));
			}
			if(cause.VERSION!= string.Empty)
			{
				strBuf.Append(" And COM_FUNCTION.VERSION ").Append((cause.VERSION.StartsWith("%") || cause.VERSION.EndsWith("%")) ? " like " : " = ").Append(" :VERSION");
				param = new OracleParameter();
				param.ParameterName =":VERSION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.VERSION;
				paramList.Add(param);
			}
			if (cause.HasINValue("VERSION"))
			{
				strBuf.Append(cause.GetINSQL("COM_FUNCTION", "VERSION"));
			}
			if(cause.DISPLAY_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_FUNCTION.DISPLAY_INDEX = :DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName =":DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("DISPLAY_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("COM_FUNCTION", "DISPLAY_INDEX"));
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And COM_FUNCTION.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_FUNCTION", "ID"));
			}
			if(cause.DELIVER_DATE!= null)
			{
				if (cause.DELIVER_DATE.Begin != null)
				{
					strBuf.Append(" And COM_FUNCTION.DELIVER_DATE >= :DELIVER_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":DELIVER_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.DELIVER_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.DELIVER_DATE.End != null)
				{
					strBuf.Append(" And COM_FUNCTION.DELIVER_DATE < :DELIVER_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":DELIVER_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.DELIVER_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("DELIVER_DATE"))
			{
				strBuf.Append(cause.GetINSQL("COM_FUNCTION", "DELIVER_DATE"));
			}
			if(cause.COMMENTS!= string.Empty)
			{
				strBuf.Append(" And COM_FUNCTION.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("COM_FUNCTION", "COMMENTS"));
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
		public static DisplayObject_COM_FUNCTION[] Query(CauseObject_COM_FUNCTION cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_FUNCTION.CODE, COM_FUNCTION.MODULE_ID, COM_FUNCTION.NAME, COM_FUNCTION.DEFAULT_PAGE_URL, COM_FUNCTION.STATE, COM_FUNCTION.IMG_URL, COM_FUNCTION.VERSION, COM_FUNCTION.DISPLAY_INDEX, COM_FUNCTION.ID, COM_FUNCTION.DELIVER_DATE, COM_FUNCTION.COMMENTS, COM_MODULE.NAME as COM_MODULE_NAME from COM_FUNCTION left join COM_MODULE   COM_MODULE on COM_FUNCTION.MODULE_ID = COM_MODULE.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_FUNCTION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FUNCTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODULE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IMG_URL = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.VERSION = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DELIVER_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_MODULE_NAME = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_FUNCTION[] objs = new DisplayObject_COM_FUNCTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_FUNCTION cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_FUNCTION where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_FUNCTION[] Query(CauseObject_COM_FUNCTION cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_FUNCTION.CODE, COM_FUNCTION.MODULE_ID, COM_FUNCTION.NAME, COM_FUNCTION.DEFAULT_PAGE_URL, COM_FUNCTION.STATE, COM_FUNCTION.IMG_URL, COM_FUNCTION.VERSION, COM_FUNCTION.DISPLAY_INDEX, COM_FUNCTION.ID, COM_FUNCTION.DELIVER_DATE, COM_FUNCTION.COMMENTS, COM_MODULE.NAME as COM_MODULE_NAME from COM_FUNCTION left join COM_MODULE   COM_MODULE on COM_FUNCTION.MODULE_ID = COM_MODULE.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_FUNCTION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FUNCTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODULE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IMG_URL = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.VERSION = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DELIVER_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_MODULE_NAME = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_FUNCTION[] objs = new DisplayObject_COM_FUNCTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_FUNCTION[] Query(CauseObject_COM_FUNCTION cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_FUNCTION.CODE, COM_FUNCTION.MODULE_ID, COM_FUNCTION.NAME, COM_FUNCTION.DEFAULT_PAGE_URL, COM_FUNCTION.STATE, COM_FUNCTION.IMG_URL, COM_FUNCTION.VERSION, COM_FUNCTION.DISPLAY_INDEX, COM_FUNCTION.ID, COM_FUNCTION.DELIVER_DATE, COM_FUNCTION.COMMENTS, COM_MODULE.NAME as COM_MODULE_NAME from COM_FUNCTION left join COM_MODULE   COM_MODULE on COM_FUNCTION.MODULE_ID = COM_MODULE.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_FUNCTION",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_FUNCTION dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FUNCTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODULE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IMG_URL = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.VERSION = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DELIVER_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_MODULE_NAME = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_FUNCTION[] objs = new DisplayObject_COM_FUNCTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_FUNCTION[] Query(CauseObject_COM_FUNCTION cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_FUNCTION.CODE, COM_FUNCTION.MODULE_ID, COM_FUNCTION.NAME, COM_FUNCTION.DEFAULT_PAGE_URL, COM_FUNCTION.STATE, COM_FUNCTION.IMG_URL, COM_FUNCTION.VERSION, COM_FUNCTION.DISPLAY_INDEX, COM_FUNCTION.ID, COM_FUNCTION.DELIVER_DATE, COM_FUNCTION.COMMENTS, COM_MODULE.NAME as COM_MODULE_NAME from COM_FUNCTION left join COM_MODULE   COM_MODULE on COM_FUNCTION.MODULE_ID = COM_MODULE.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_FUNCTION",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_FUNCTION dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_FUNCTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODULE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IMG_URL = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.VERSION = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DELIVER_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_MODULE_NAME = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_FUNCTION[] objs = new DisplayObject_COM_FUNCTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_FUNCTION obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  COM_FUNCTION.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODULE_ID"))
			{
				strBuf.Add("  COM_FUNCTION.MODULE_ID = :MODULE_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODULE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODULE_ID) ? string.Empty : obj.MODULE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  COM_FUNCTION.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEFAULT_PAGE_URL"))
			{
				strBuf.Add("  COM_FUNCTION.DEFAULT_PAGE_URL = :DEFAULT_PAGE_URL");
				param = new OracleParameter();
				param.ParameterName = ":DEFAULT_PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.DEFAULT_PAGE_URL) ? string.Empty : obj.DEFAULT_PAGE_URL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  COM_FUNCTION.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IMG_URL"))
			{
				strBuf.Add("  COM_FUNCTION.IMG_URL = :IMG_URL");
				param = new OracleParameter();
				param.ParameterName = ":IMG_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.IMG_URL) ? string.Empty : obj.IMG_URL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("VERSION"))
			{
				strBuf.Add("  COM_FUNCTION.VERSION = :VERSION");
				param = new OracleParameter();
				param.ParameterName = ":VERSION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.VERSION) ? string.Empty : obj.VERSION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DISPLAY_INDEX"))
			{
				strBuf.Add("  COM_FUNCTION.DISPLAY_INDEX = :DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName = ":DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DELIVER_DATE"))
			{
				strBuf.Add("  COM_FUNCTION.DELIVER_DATE = :DELIVER_DATE");
				param = new OracleParameter();
				param.ParameterName = ":DELIVER_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.DELIVER_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  COM_FUNCTION.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
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
