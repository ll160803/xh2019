using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.Entity;
namespace Ipedf.Web.DataAccess
{
	[CauseObject(typeof(CauseObject_V_COM_QUERY_MENUS))]	
	public partial class HelperObject_V_COM_QUERY_MENUS
	{		
		#region Method Blok
		public static DisplayObject_V_COM_QUERY_MENUS[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_COM_QUERY_MENUS.MODULE_NAME, V_COM_QUERY_MENUS.MODULE_CODE, V_COM_QUERY_MENUS.SYSTEM_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_NAME, V_COM_QUERY_MENUS.PAGE_ID, V_COM_QUERY_MENUS.FUNCTION_CODE, V_COM_QUERY_MENUS.PAGE_DISPLAY_INDEX, V_COM_QUERY_MENUS.PAGE_NAME, V_COM_QUERY_MENUS.PAGE_CODE, V_COM_QUERY_MENUS.SYSTEM_CODE, V_COM_QUERY_MENUS.PAGE_URL, V_COM_QUERY_MENUS.FUNCTION_DISPLAY_INDEX, V_COM_QUERY_MENUS.FUNCTION_PAGE_URL, V_COM_QUERY_MENUS.MODULE_DISPALY_INDEX, V_COM_QUERY_MENUS.MODULE_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_ID, V_COM_QUERY_MENUS.SYSTEM_DISPLAY_INDEX, V_COM_QUERY_MENUS.USER_ID, V_COM_QUERY_MENUS.FUNCTION_NAME, COM_FORM.NAME as COM_FORM_NAME from V_COM_QUERY_MENUS left join COM_FORM   COM_FORM on V_COM_QUERY_MENUS.PAGE_ID = COM_FORM.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_COM_QUERY_MENUS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_MENUS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MODULE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODULE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SYSTEM_PAGE_URL = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SYSTEM_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PAGE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FUNCTION_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PAGE_DISPLAY_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PAGE_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAGE_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SYSTEM_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAGE_URL = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FUNCTION_DISPLAY_INDEX = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.FUNCTION_PAGE_URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODULE_DISPALY_INDEX = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODULE_PAGE_URL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SYSTEM_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SYSTEM_DISPLAY_INDEX = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FUNCTION_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COM_FORM_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_MENUS[] objs = new DisplayObject_V_COM_QUERY_MENUS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_COM_QUERY_MENUS cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.MODULE_NAME!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.MODULE_NAME ").Append((cause.MODULE_NAME.StartsWith("%") || cause.MODULE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :MODULE_NAME");
				param = new OracleParameter();
				param.ParameterName =":MODULE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MODULE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODULE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "MODULE_NAME"));
			}
			if(cause.MODULE_CODE!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.MODULE_CODE ").Append((cause.MODULE_CODE.StartsWith("%") || cause.MODULE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :MODULE_CODE");
				param = new OracleParameter();
				param.ParameterName =":MODULE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MODULE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODULE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "MODULE_CODE"));
			}
			if(cause.SYSTEM_PAGE_URL!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.SYSTEM_PAGE_URL ").Append((cause.SYSTEM_PAGE_URL.StartsWith("%") || cause.SYSTEM_PAGE_URL.EndsWith("%")) ? " like " : " = ").Append(" :SYSTEM_PAGE_URL");
				param = new OracleParameter();
				param.ParameterName =":SYSTEM_PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SYSTEM_PAGE_URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("SYSTEM_PAGE_URL"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "SYSTEM_PAGE_URL"));
			}
			if(cause.SYSTEM_NAME!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.SYSTEM_NAME ").Append((cause.SYSTEM_NAME.StartsWith("%") || cause.SYSTEM_NAME.EndsWith("%")) ? " like " : " = ").Append(" :SYSTEM_NAME");
				param = new OracleParameter();
				param.ParameterName =":SYSTEM_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SYSTEM_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SYSTEM_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "SYSTEM_NAME"));
			}
			if(cause.PAGE_ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.PAGE_ID ").Append((cause.PAGE_ID.StartsWith("%") || cause.PAGE_ID.EndsWith("%")) ? " like " : " = ").Append(" :PAGE_ID");
				param = new OracleParameter();
				param.ParameterName =":PAGE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PAGE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAGE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "PAGE_ID"));
			}
			if(cause.FUNCTION_CODE!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.FUNCTION_CODE ").Append((cause.FUNCTION_CODE.StartsWith("%") || cause.FUNCTION_CODE.EndsWith("%")) ? " like " : " = ").Append(" :FUNCTION_CODE");
				param = new OracleParameter();
				param.ParameterName =":FUNCTION_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FUNCTION_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUNCTION_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "FUNCTION_CODE"));
			}
			if(cause.PAGE_DISPLAY_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.PAGE_DISPLAY_INDEX = :PAGE_DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName =":PAGE_DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PAGE_DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAGE_DISPLAY_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "PAGE_DISPLAY_INDEX"));
			}
			if(cause.PAGE_NAME!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.PAGE_NAME ").Append((cause.PAGE_NAME.StartsWith("%") || cause.PAGE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :PAGE_NAME");
				param = new OracleParameter();
				param.ParameterName =":PAGE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PAGE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAGE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "PAGE_NAME"));
			}
			if(cause.PAGE_CODE!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.PAGE_CODE ").Append((cause.PAGE_CODE.StartsWith("%") || cause.PAGE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :PAGE_CODE");
				param = new OracleParameter();
				param.ParameterName =":PAGE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PAGE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAGE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "PAGE_CODE"));
			}
			if(cause.SYSTEM_CODE!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.SYSTEM_CODE ").Append((cause.SYSTEM_CODE.StartsWith("%") || cause.SYSTEM_CODE.EndsWith("%")) ? " like " : " = ").Append(" :SYSTEM_CODE");
				param = new OracleParameter();
				param.ParameterName =":SYSTEM_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SYSTEM_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SYSTEM_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "SYSTEM_CODE"));
			}
			if(cause.PAGE_URL!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.PAGE_URL ").Append((cause.PAGE_URL.StartsWith("%") || cause.PAGE_URL.EndsWith("%")) ? " like " : " = ").Append(" :PAGE_URL");
				param = new OracleParameter();
				param.ParameterName =":PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.PAGE_URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAGE_URL"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "PAGE_URL"));
			}
			if(cause.FUNCTION_DISPLAY_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.FUNCTION_DISPLAY_INDEX = :FUNCTION_DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName =":FUNCTION_DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.FUNCTION_DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUNCTION_DISPLAY_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "FUNCTION_DISPLAY_INDEX"));
			}
			if(cause.FUNCTION_PAGE_URL!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.FUNCTION_PAGE_URL ").Append((cause.FUNCTION_PAGE_URL.StartsWith("%") || cause.FUNCTION_PAGE_URL.EndsWith("%")) ? " like " : " = ").Append(" :FUNCTION_PAGE_URL");
				param = new OracleParameter();
				param.ParameterName =":FUNCTION_PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FUNCTION_PAGE_URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUNCTION_PAGE_URL"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "FUNCTION_PAGE_URL"));
			}
			if(cause.MODULE_DISPALY_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.MODULE_DISPALY_INDEX = :MODULE_DISPALY_INDEX");
				param = new OracleParameter();
				param.ParameterName =":MODULE_DISPALY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MODULE_DISPALY_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODULE_DISPALY_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "MODULE_DISPALY_INDEX"));
			}
			if(cause.MODULE_PAGE_URL!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.MODULE_PAGE_URL ").Append((cause.MODULE_PAGE_URL.StartsWith("%") || cause.MODULE_PAGE_URL.EndsWith("%")) ? " like " : " = ").Append(" :MODULE_PAGE_URL");
				param = new OracleParameter();
				param.ParameterName =":MODULE_PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MODULE_PAGE_URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODULE_PAGE_URL"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "MODULE_PAGE_URL"));
			}
			if(cause.SYSTEM_ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.SYSTEM_ID ").Append((cause.SYSTEM_ID.StartsWith("%") || cause.SYSTEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :SYSTEM_ID");
				param = new OracleParameter();
				param.ParameterName =":SYSTEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SYSTEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("SYSTEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "SYSTEM_ID"));
			}
			if(cause.SYSTEM_DISPLAY_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.SYSTEM_DISPLAY_INDEX = :SYSTEM_DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName =":SYSTEM_DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.SYSTEM_DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("SYSTEM_DISPLAY_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "SYSTEM_DISPLAY_INDEX"));
			}
			if(cause.USER_ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :USER_ID");
				param = new OracleParameter();
				param.ParameterName =":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "USER_ID"));
			}
			if(cause.FUNCTION_NAME!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.FUNCTION_NAME ").Append((cause.FUNCTION_NAME.StartsWith("%") || cause.FUNCTION_NAME.EndsWith("%")) ? " like " : " = ").Append(" :FUNCTION_NAME");
				param = new OracleParameter();
				param.ParameterName =":FUNCTION_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FUNCTION_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUNCTION_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "FUNCTION_NAME"));
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
		public static DisplayObject_V_COM_QUERY_MENUS[] Query(CauseObject_V_COM_QUERY_MENUS cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_MENUS.MODULE_NAME, V_COM_QUERY_MENUS.MODULE_CODE, V_COM_QUERY_MENUS.SYSTEM_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_NAME, V_COM_QUERY_MENUS.PAGE_ID, V_COM_QUERY_MENUS.FUNCTION_CODE, V_COM_QUERY_MENUS.PAGE_DISPLAY_INDEX, V_COM_QUERY_MENUS.PAGE_NAME, V_COM_QUERY_MENUS.PAGE_CODE, V_COM_QUERY_MENUS.SYSTEM_CODE, V_COM_QUERY_MENUS.PAGE_URL, V_COM_QUERY_MENUS.FUNCTION_DISPLAY_INDEX, V_COM_QUERY_MENUS.FUNCTION_PAGE_URL, V_COM_QUERY_MENUS.MODULE_DISPALY_INDEX, V_COM_QUERY_MENUS.MODULE_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_ID, V_COM_QUERY_MENUS.SYSTEM_DISPLAY_INDEX, V_COM_QUERY_MENUS.USER_ID, V_COM_QUERY_MENUS.FUNCTION_NAME, COM_FORM.NAME as COM_FORM_NAME from V_COM_QUERY_MENUS left join COM_FORM   COM_FORM on V_COM_QUERY_MENUS.PAGE_ID = COM_FORM.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_COM_QUERY_MENUS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_MENUS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MODULE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODULE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SYSTEM_PAGE_URL = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SYSTEM_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PAGE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FUNCTION_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PAGE_DISPLAY_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PAGE_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAGE_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SYSTEM_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAGE_URL = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FUNCTION_DISPLAY_INDEX = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.FUNCTION_PAGE_URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODULE_DISPALY_INDEX = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODULE_PAGE_URL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SYSTEM_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SYSTEM_DISPLAY_INDEX = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FUNCTION_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COM_FORM_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_MENUS[] objs = new DisplayObject_V_COM_QUERY_MENUS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_MENUS[] Query(CauseObject_V_COM_QUERY_MENUS cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_MENUS.MODULE_NAME, V_COM_QUERY_MENUS.MODULE_CODE, V_COM_QUERY_MENUS.SYSTEM_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_NAME, V_COM_QUERY_MENUS.PAGE_ID, V_COM_QUERY_MENUS.FUNCTION_CODE, V_COM_QUERY_MENUS.PAGE_DISPLAY_INDEX, V_COM_QUERY_MENUS.PAGE_NAME, V_COM_QUERY_MENUS.PAGE_CODE, V_COM_QUERY_MENUS.SYSTEM_CODE, V_COM_QUERY_MENUS.PAGE_URL, V_COM_QUERY_MENUS.FUNCTION_DISPLAY_INDEX, V_COM_QUERY_MENUS.FUNCTION_PAGE_URL, V_COM_QUERY_MENUS.MODULE_DISPALY_INDEX, V_COM_QUERY_MENUS.MODULE_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_ID, V_COM_QUERY_MENUS.SYSTEM_DISPLAY_INDEX, V_COM_QUERY_MENUS.USER_ID, V_COM_QUERY_MENUS.FUNCTION_NAME, COM_FORM.NAME as COM_FORM_NAME from V_COM_QUERY_MENUS left join COM_FORM   COM_FORM on V_COM_QUERY_MENUS.PAGE_ID = COM_FORM.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_COM_QUERY_MENUS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_MENUS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MODULE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODULE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SYSTEM_PAGE_URL = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SYSTEM_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PAGE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FUNCTION_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PAGE_DISPLAY_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PAGE_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAGE_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SYSTEM_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAGE_URL = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FUNCTION_DISPLAY_INDEX = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.FUNCTION_PAGE_URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODULE_DISPALY_INDEX = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODULE_PAGE_URL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SYSTEM_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SYSTEM_DISPLAY_INDEX = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FUNCTION_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COM_FORM_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_MENUS[] objs = new DisplayObject_V_COM_QUERY_MENUS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_MENUS[] Query(CauseObject_V_COM_QUERY_MENUS cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_MENUS.MODULE_NAME, V_COM_QUERY_MENUS.MODULE_CODE, V_COM_QUERY_MENUS.SYSTEM_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_NAME, V_COM_QUERY_MENUS.PAGE_ID, V_COM_QUERY_MENUS.FUNCTION_CODE, V_COM_QUERY_MENUS.PAGE_DISPLAY_INDEX, V_COM_QUERY_MENUS.PAGE_NAME, V_COM_QUERY_MENUS.PAGE_CODE, V_COM_QUERY_MENUS.SYSTEM_CODE, V_COM_QUERY_MENUS.PAGE_URL, V_COM_QUERY_MENUS.FUNCTION_DISPLAY_INDEX, V_COM_QUERY_MENUS.FUNCTION_PAGE_URL, V_COM_QUERY_MENUS.MODULE_DISPALY_INDEX, V_COM_QUERY_MENUS.MODULE_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_ID, V_COM_QUERY_MENUS.SYSTEM_DISPLAY_INDEX, V_COM_QUERY_MENUS.USER_ID, V_COM_QUERY_MENUS.FUNCTION_NAME, COM_FORM.NAME as COM_FORM_NAME from V_COM_QUERY_MENUS left join COM_FORM   COM_FORM on V_COM_QUERY_MENUS.PAGE_ID = COM_FORM.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_COM_QUERY_MENUS",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_COM_QUERY_MENUS dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_MENUS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MODULE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODULE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SYSTEM_PAGE_URL = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SYSTEM_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PAGE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FUNCTION_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PAGE_DISPLAY_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PAGE_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAGE_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SYSTEM_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAGE_URL = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FUNCTION_DISPLAY_INDEX = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.FUNCTION_PAGE_URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODULE_DISPALY_INDEX = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODULE_PAGE_URL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SYSTEM_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SYSTEM_DISPLAY_INDEX = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FUNCTION_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COM_FORM_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_MENUS[] objs = new DisplayObject_V_COM_QUERY_MENUS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_MENUS[] Query(CauseObject_V_COM_QUERY_MENUS cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_MENUS.MODULE_NAME, V_COM_QUERY_MENUS.MODULE_CODE, V_COM_QUERY_MENUS.SYSTEM_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_NAME, V_COM_QUERY_MENUS.PAGE_ID, V_COM_QUERY_MENUS.FUNCTION_CODE, V_COM_QUERY_MENUS.PAGE_DISPLAY_INDEX, V_COM_QUERY_MENUS.PAGE_NAME, V_COM_QUERY_MENUS.PAGE_CODE, V_COM_QUERY_MENUS.SYSTEM_CODE, V_COM_QUERY_MENUS.PAGE_URL, V_COM_QUERY_MENUS.FUNCTION_DISPLAY_INDEX, V_COM_QUERY_MENUS.FUNCTION_PAGE_URL, V_COM_QUERY_MENUS.MODULE_DISPALY_INDEX, V_COM_QUERY_MENUS.MODULE_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_ID, V_COM_QUERY_MENUS.SYSTEM_DISPLAY_INDEX, V_COM_QUERY_MENUS.USER_ID, V_COM_QUERY_MENUS.FUNCTION_NAME, COM_FORM.NAME as COM_FORM_NAME from V_COM_QUERY_MENUS left join COM_FORM   COM_FORM on V_COM_QUERY_MENUS.PAGE_ID = COM_FORM.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_COM_QUERY_MENUS",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_COM_QUERY_MENUS dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_MENUS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MODULE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODULE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SYSTEM_PAGE_URL = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SYSTEM_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PAGE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FUNCTION_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PAGE_DISPLAY_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PAGE_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAGE_CODE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SYSTEM_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAGE_URL = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.FUNCTION_DISPLAY_INDEX = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.FUNCTION_PAGE_URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODULE_DISPALY_INDEX = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MODULE_PAGE_URL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SYSTEM_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SYSTEM_DISPLAY_INDEX = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FUNCTION_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.COM_FORM_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_MENUS[] objs = new DisplayObject_V_COM_QUERY_MENUS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
