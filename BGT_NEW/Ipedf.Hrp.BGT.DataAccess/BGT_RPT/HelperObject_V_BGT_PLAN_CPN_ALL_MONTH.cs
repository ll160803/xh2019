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
	[CauseObject(typeof(CauseObject_V_BGT_PLAN_CPN_ALL_MONTH))]	
	public partial class HelperObject_V_BGT_PLAN_CPN_ALL_MONTH
	{		
		#region Method Blok
		public static DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_BGT_PLAN_CPN_ALL_MONTH.M12TH, V_BGT_PLAN_CPN_ALL_MONTH.M1TH, V_BGT_PLAN_CPN_ALL_MONTH.MALL, V_BGT_PLAN_CPN_ALL_MONTH.M4TH, V_BGT_PLAN_CPN_ALL_MONTH.M5TH, V_BGT_PLAN_CPN_ALL_MONTH.M11TH, V_BGT_PLAN_CPN_ALL_MONTH.M2TH, V_BGT_PLAN_CPN_ALL_MONTH.M3TH, V_BGT_PLAN_CPN_ALL_MONTH.ITEM_ID, V_BGT_PLAN_CPN_ALL_MONTH.M6TH, V_BGT_PLAN_CPN_ALL_MONTH.BUDGET_YEAR, V_BGT_PLAN_CPN_ALL_MONTH.M10TH, V_BGT_PLAN_CPN_ALL_MONTH.M7TH, V_BGT_PLAN_CPN_ALL_MONTH.M8TH, V_BGT_PLAN_CPN_ALL_MONTH.M9TH, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PLAN_CPN_ALL_MONTH left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on V_BGT_PLAN_CPN_ALL_MONTH.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PLAN_CPN_ALL_MONTH.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.M12TH = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.M1TH = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MALL = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.M4TH = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.M5TH = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.M11TH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.M2TH = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.M3TH = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ITEM_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.M6TH = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.M10TH = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.M7TH = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.M8TH = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.M9TH = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[] objs = new DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_BGT_PLAN_CPN_ALL_MONTH cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.M12TH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.M12TH = :M12TH");
				param = new OracleParameter();
				param.ParameterName =":M12TH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M12TH;
				paramList.Add(param);
			}
			if (cause.HasINValue("M12TH"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "M12TH"));
			}
			if(cause.M1TH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.M1TH = :M1TH");
				param = new OracleParameter();
				param.ParameterName =":M1TH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M1TH;
				paramList.Add(param);
			}
			if (cause.HasINValue("M1TH"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "M1TH"));
			}
			if(cause.MALL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.MALL = :MALL");
				param = new OracleParameter();
				param.ParameterName =":MALL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MALL;
				paramList.Add(param);
			}
			if (cause.HasINValue("MALL"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "MALL"));
			}
			if(cause.M4TH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.M4TH = :M4TH");
				param = new OracleParameter();
				param.ParameterName =":M4TH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M4TH;
				paramList.Add(param);
			}
			if (cause.HasINValue("M4TH"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "M4TH"));
			}
			if(cause.M5TH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.M5TH = :M5TH");
				param = new OracleParameter();
				param.ParameterName =":M5TH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M5TH;
				paramList.Add(param);
			}
			if (cause.HasINValue("M5TH"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "M5TH"));
			}
			if(cause.M11TH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.M11TH = :M11TH");
				param = new OracleParameter();
				param.ParameterName =":M11TH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M11TH;
				paramList.Add(param);
			}
			if (cause.HasINValue("M11TH"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "M11TH"));
			}
			if(cause.M2TH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.M2TH = :M2TH");
				param = new OracleParameter();
				param.ParameterName =":M2TH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M2TH;
				paramList.Add(param);
			}
			if (cause.HasINValue("M2TH"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "M2TH"));
			}
			if(cause.M3TH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.M3TH = :M3TH");
				param = new OracleParameter();
				param.ParameterName =":M3TH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M3TH;
				paramList.Add(param);
			}
			if (cause.HasINValue("M3TH"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "M3TH"));
			}
			if(cause.ITEM_ID!= string.Empty)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.ITEM_ID ").Append((cause.ITEM_ID.StartsWith("%") || cause.ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "ITEM_ID"));
			}
			if(cause.M6TH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.M6TH = :M6TH");
				param = new OracleParameter();
				param.ParameterName =":M6TH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M6TH;
				paramList.Add(param);
			}
			if (cause.HasINValue("M6TH"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "M6TH"));
			}
			if(cause.BUDGET_YEAR!= string.Empty)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "BUDGET_YEAR"));
			}
			if(cause.M10TH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.M10TH = :M10TH");
				param = new OracleParameter();
				param.ParameterName =":M10TH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M10TH;
				paramList.Add(param);
			}
			if (cause.HasINValue("M10TH"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "M10TH"));
			}
			if(cause.M7TH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.M7TH = :M7TH");
				param = new OracleParameter();
				param.ParameterName =":M7TH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M7TH;
				paramList.Add(param);
			}
			if (cause.HasINValue("M7TH"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "M7TH"));
			}
			if(cause.M8TH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.M8TH = :M8TH");
				param = new OracleParameter();
				param.ParameterName =":M8TH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M8TH;
				paramList.Add(param);
			}
			if (cause.HasINValue("M8TH"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "M8TH"));
			}
			if(cause.M9TH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_PLAN_CPN_ALL_MONTH.M9TH = :M9TH");
				param = new OracleParameter();
				param.ParameterName =":M9TH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M9TH;
				paramList.Add(param);
			}
			if (cause.HasINValue("M9TH"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_PLAN_CPN_ALL_MONTH", "M9TH"));
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
		public static DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[] Query(CauseObject_V_BGT_PLAN_CPN_ALL_MONTH cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_PLAN_CPN_ALL_MONTH.M12TH, V_BGT_PLAN_CPN_ALL_MONTH.M1TH, V_BGT_PLAN_CPN_ALL_MONTH.MALL, V_BGT_PLAN_CPN_ALL_MONTH.M4TH, V_BGT_PLAN_CPN_ALL_MONTH.M5TH, V_BGT_PLAN_CPN_ALL_MONTH.M11TH, V_BGT_PLAN_CPN_ALL_MONTH.M2TH, V_BGT_PLAN_CPN_ALL_MONTH.M3TH, V_BGT_PLAN_CPN_ALL_MONTH.ITEM_ID, V_BGT_PLAN_CPN_ALL_MONTH.M6TH, V_BGT_PLAN_CPN_ALL_MONTH.BUDGET_YEAR, V_BGT_PLAN_CPN_ALL_MONTH.M10TH, V_BGT_PLAN_CPN_ALL_MONTH.M7TH, V_BGT_PLAN_CPN_ALL_MONTH.M8TH, V_BGT_PLAN_CPN_ALL_MONTH.M9TH, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PLAN_CPN_ALL_MONTH left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on V_BGT_PLAN_CPN_ALL_MONTH.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PLAN_CPN_ALL_MONTH.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.M12TH = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.M1TH = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MALL = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.M4TH = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.M5TH = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.M11TH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.M2TH = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.M3TH = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ITEM_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.M6TH = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.M10TH = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.M7TH = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.M8TH = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.M9TH = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[] objs = new DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[] Query(CauseObject_V_BGT_PLAN_CPN_ALL_MONTH cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_PLAN_CPN_ALL_MONTH.M12TH, V_BGT_PLAN_CPN_ALL_MONTH.M1TH, V_BGT_PLAN_CPN_ALL_MONTH.MALL, V_BGT_PLAN_CPN_ALL_MONTH.M4TH, V_BGT_PLAN_CPN_ALL_MONTH.M5TH, V_BGT_PLAN_CPN_ALL_MONTH.M11TH, V_BGT_PLAN_CPN_ALL_MONTH.M2TH, V_BGT_PLAN_CPN_ALL_MONTH.M3TH, V_BGT_PLAN_CPN_ALL_MONTH.ITEM_ID, V_BGT_PLAN_CPN_ALL_MONTH.M6TH, V_BGT_PLAN_CPN_ALL_MONTH.BUDGET_YEAR, V_BGT_PLAN_CPN_ALL_MONTH.M10TH, V_BGT_PLAN_CPN_ALL_MONTH.M7TH, V_BGT_PLAN_CPN_ALL_MONTH.M8TH, V_BGT_PLAN_CPN_ALL_MONTH.M9TH, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PLAN_CPN_ALL_MONTH left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on V_BGT_PLAN_CPN_ALL_MONTH.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PLAN_CPN_ALL_MONTH.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.M12TH = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.M1TH = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MALL = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.M4TH = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.M5TH = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.M11TH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.M2TH = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.M3TH = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ITEM_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.M6TH = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.M10TH = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.M7TH = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.M8TH = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.M9TH = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[] objs = new DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[] Query(CauseObject_V_BGT_PLAN_CPN_ALL_MONTH cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_PLAN_CPN_ALL_MONTH.M12TH, V_BGT_PLAN_CPN_ALL_MONTH.M1TH, V_BGT_PLAN_CPN_ALL_MONTH.MALL, V_BGT_PLAN_CPN_ALL_MONTH.M4TH, V_BGT_PLAN_CPN_ALL_MONTH.M5TH, V_BGT_PLAN_CPN_ALL_MONTH.M11TH, V_BGT_PLAN_CPN_ALL_MONTH.M2TH, V_BGT_PLAN_CPN_ALL_MONTH.M3TH, V_BGT_PLAN_CPN_ALL_MONTH.ITEM_ID, V_BGT_PLAN_CPN_ALL_MONTH.M6TH, V_BGT_PLAN_CPN_ALL_MONTH.BUDGET_YEAR, V_BGT_PLAN_CPN_ALL_MONTH.M10TH, V_BGT_PLAN_CPN_ALL_MONTH.M7TH, V_BGT_PLAN_CPN_ALL_MONTH.M8TH, V_BGT_PLAN_CPN_ALL_MONTH.M9TH, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PLAN_CPN_ALL_MONTH left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on V_BGT_PLAN_CPN_ALL_MONTH.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PLAN_CPN_ALL_MONTH.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_PLAN_CPN_ALL_MONTH",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.M12TH = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.M1TH = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MALL = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.M4TH = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.M5TH = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.M11TH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.M2TH = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.M3TH = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ITEM_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.M6TH = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.M10TH = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.M7TH = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.M8TH = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.M9TH = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[] objs = new DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[] Query(CauseObject_V_BGT_PLAN_CPN_ALL_MONTH cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_PLAN_CPN_ALL_MONTH.M12TH, V_BGT_PLAN_CPN_ALL_MONTH.M1TH, V_BGT_PLAN_CPN_ALL_MONTH.MALL, V_BGT_PLAN_CPN_ALL_MONTH.M4TH, V_BGT_PLAN_CPN_ALL_MONTH.M5TH, V_BGT_PLAN_CPN_ALL_MONTH.M11TH, V_BGT_PLAN_CPN_ALL_MONTH.M2TH, V_BGT_PLAN_CPN_ALL_MONTH.M3TH, V_BGT_PLAN_CPN_ALL_MONTH.ITEM_ID, V_BGT_PLAN_CPN_ALL_MONTH.M6TH, V_BGT_PLAN_CPN_ALL_MONTH.BUDGET_YEAR, V_BGT_PLAN_CPN_ALL_MONTH.M10TH, V_BGT_PLAN_CPN_ALL_MONTH.M7TH, V_BGT_PLAN_CPN_ALL_MONTH.M8TH, V_BGT_PLAN_CPN_ALL_MONTH.M9TH, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_PLAN_CPN_ALL_MONTH left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on V_BGT_PLAN_CPN_ALL_MONTH.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_PLAN_CPN_ALL_MONTH.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_PLAN_CPN_ALL_MONTH",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.M12TH = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.M1TH = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MALL = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.M4TH = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.M5TH = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.M11TH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.M2TH = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.M3TH = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ITEM_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.M6TH = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.M10TH = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.M7TH = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.M8TH = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.M9TH = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[] objs = new DisplayObject_V_BGT_PLAN_CPN_ALL_MONTH[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
