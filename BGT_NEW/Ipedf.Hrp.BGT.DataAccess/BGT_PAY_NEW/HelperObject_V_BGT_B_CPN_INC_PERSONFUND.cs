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
	[CauseObject(typeof(CauseObject_V_BGT_B_CPN_INC_PERSONFUND))]
	public partial class HelperObject_V_BGT_B_CPN_INC_PERSONFUND
	{		
		#region Method Blok
		public static int Save(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "insert into V_BGT_B_CPN_INC_PERSONFUND( CODE, MONEY, DEPT_ID, NAME, ITEM_ID, DEPT_NAME, BUDGET_YEAR, ADDRESS) values ( :CODE, :MONEY, :DEPT_ID, :NAME, :ITEM_ID, :DEPT_NAME, :BUDGET_YEAR, :ADDRESS)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[8];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CODE";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":MONEY";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.MONEY;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":DEPT_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.DEPT_ID == null ? String.Empty:obj.DEPT_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":NAME";
			parameters[3].Size = 100;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ITEM_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ITEM_ID == null ? String.Empty:obj.ITEM_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":DEPT_NAME";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.DEPT_NAME == null ? String.Empty:obj.DEPT_NAME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":BUDGET_YEAR";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ADDRESS";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.ADDRESS == null ? String.Empty:obj.ADDRESS;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_BGT_B_CPN_INC_PERSONFUND set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_BGT_B_CPN_INC_PERSONFUND where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_BGT_B_CPN_INC_PERSONFUND Get(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CODE, MONEY, DEPT_ID, NAME, ITEM_ID, DEPT_NAME, BUDGET_YEAR, ADDRESS from V_BGT_B_CPN_INC_PERSONFUND where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_B_CPN_INC_PERSONFUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_B_CPN_INC_PERSONFUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DEPT_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_BGT_B_CPN_INC_PERSONFUND[] objs = new EntityObject_V_BGT_B_CPN_INC_PERSONFUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_BGT_B_CPN_INC_PERSONFUND Get(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CODE, MONEY, DEPT_ID, NAME, ITEM_ID, DEPT_NAME, BUDGET_YEAR, ADDRESS from V_BGT_B_CPN_INC_PERSONFUND where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_B_CPN_INC_PERSONFUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_B_CPN_INC_PERSONFUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DEPT_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_BGT_B_CPN_INC_PERSONFUND[] objs = new EntityObject_V_BGT_B_CPN_INC_PERSONFUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_BGT_B_CPN_INC_PERSONFUND.CODE, V_BGT_B_CPN_INC_PERSONFUND.MONEY, V_BGT_B_CPN_INC_PERSONFUND.DEPT_ID, V_BGT_B_CPN_INC_PERSONFUND.NAME, V_BGT_B_CPN_INC_PERSONFUND.ITEM_ID, V_BGT_B_CPN_INC_PERSONFUND.DEPT_NAME, V_BGT_B_CPN_INC_PERSONFUND.BUDGET_YEAR, V_BGT_B_CPN_INC_PERSONFUND.ADDRESS from V_BGT_B_CPN_INC_PERSONFUND where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_BGT_B_CPN_INC_PERSONFUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_B_CPN_INC_PERSONFUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DEPT_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[] objs = new DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_BGT_B_CPN_INC_PERSONFUND cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_PERSONFUND.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_PERSONFUND", "CODE"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_PERSONFUND.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName =":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_PERSONFUND", "MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_ID))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_PERSONFUND.DEPT_ID ").Append((cause.DEPT_ID.StartsWith("%") || cause.DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_PERSONFUND", "DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_PERSONFUND.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_PERSONFUND", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ITEM_ID))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_PERSONFUND.ITEM_ID ").Append((cause.ITEM_ID.StartsWith("%") || cause.ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_PERSONFUND", "ITEM_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_NAME))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_PERSONFUND.DEPT_NAME ").Append((cause.DEPT_NAME.StartsWith("%") || cause.DEPT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :DEPT_NAME");
				param = new OracleParameter();
				param.ParameterName =":DEPT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DEPT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_PERSONFUND", "DEPT_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_PERSONFUND.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_PERSONFUND", "BUDGET_YEAR"));
			}
			if(!string.IsNullOrEmpty(cause.ADDRESS))
			{
				strBuf.Append(" And V_BGT_B_CPN_INC_PERSONFUND.ADDRESS ").Append((cause.ADDRESS.StartsWith("%") || cause.ADDRESS.EndsWith("%")) ? " like " : " = ").Append(" :ADDRESS");
				param = new OracleParameter();
				param.ParameterName =":ADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ADDRESS;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADDRESS"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_B_CPN_INC_PERSONFUND", "ADDRESS"));
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
		public static DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[] Query(CauseObject_V_BGT_B_CPN_INC_PERSONFUND cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_B_CPN_INC_PERSONFUND.CODE, V_BGT_B_CPN_INC_PERSONFUND.MONEY, V_BGT_B_CPN_INC_PERSONFUND.DEPT_ID, V_BGT_B_CPN_INC_PERSONFUND.NAME, V_BGT_B_CPN_INC_PERSONFUND.ITEM_ID, V_BGT_B_CPN_INC_PERSONFUND.DEPT_NAME, V_BGT_B_CPN_INC_PERSONFUND.BUDGET_YEAR, V_BGT_B_CPN_INC_PERSONFUND.ADDRESS from V_BGT_B_CPN_INC_PERSONFUND where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_B_CPN_INC_PERSONFUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_B_CPN_INC_PERSONFUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DEPT_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[] objs = new DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_BGT_B_CPN_INC_PERSONFUND cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_BGT_B_CPN_INC_PERSONFUND where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[] Query(CauseObject_V_BGT_B_CPN_INC_PERSONFUND cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_B_CPN_INC_PERSONFUND.CODE, V_BGT_B_CPN_INC_PERSONFUND.MONEY, V_BGT_B_CPN_INC_PERSONFUND.DEPT_ID, V_BGT_B_CPN_INC_PERSONFUND.NAME, V_BGT_B_CPN_INC_PERSONFUND.ITEM_ID, V_BGT_B_CPN_INC_PERSONFUND.DEPT_NAME, V_BGT_B_CPN_INC_PERSONFUND.BUDGET_YEAR, V_BGT_B_CPN_INC_PERSONFUND.ADDRESS from V_BGT_B_CPN_INC_PERSONFUND where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_B_CPN_INC_PERSONFUND dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_B_CPN_INC_PERSONFUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DEPT_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[] objs = new DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[] Query(CauseObject_V_BGT_B_CPN_INC_PERSONFUND cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_B_CPN_INC_PERSONFUND.CODE, V_BGT_B_CPN_INC_PERSONFUND.MONEY, V_BGT_B_CPN_INC_PERSONFUND.DEPT_ID, V_BGT_B_CPN_INC_PERSONFUND.NAME, V_BGT_B_CPN_INC_PERSONFUND.ITEM_ID, V_BGT_B_CPN_INC_PERSONFUND.DEPT_NAME, V_BGT_B_CPN_INC_PERSONFUND.BUDGET_YEAR, V_BGT_B_CPN_INC_PERSONFUND.ADDRESS from V_BGT_B_CPN_INC_PERSONFUND where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_B_CPN_INC_PERSONFUND",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_BGT_B_CPN_INC_PERSONFUND dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_B_CPN_INC_PERSONFUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DEPT_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[] objs = new DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[] Query(CauseObject_V_BGT_B_CPN_INC_PERSONFUND cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_B_CPN_INC_PERSONFUND.CODE, V_BGT_B_CPN_INC_PERSONFUND.MONEY, V_BGT_B_CPN_INC_PERSONFUND.DEPT_ID, V_BGT_B_CPN_INC_PERSONFUND.NAME, V_BGT_B_CPN_INC_PERSONFUND.ITEM_ID, V_BGT_B_CPN_INC_PERSONFUND.DEPT_NAME, V_BGT_B_CPN_INC_PERSONFUND.BUDGET_YEAR, V_BGT_B_CPN_INC_PERSONFUND.ADDRESS from V_BGT_B_CPN_INC_PERSONFUND where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_B_CPN_INC_PERSONFUND",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_BGT_B_CPN_INC_PERSONFUND dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_B_CPN_INC_PERSONFUND();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DEPT_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DEPT_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADDRESS = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[] objs = new DisplayObject_V_BGT_B_CPN_INC_PERSONFUND[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_BGT_B_CPN_INC_PERSONFUND obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_PERSONFUND.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_PERSONFUND.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName = ":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_ID"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_PERSONFUND.DEPT_ID = :DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_ID) ? string.Empty : obj.DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_PERSONFUND.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_ID"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_PERSONFUND.ITEM_ID = :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_ID) ? string.Empty : obj.ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_NAME"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_PERSONFUND.DEPT_NAME = :DEPT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":DEPT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.DEPT_NAME) ? string.Empty : obj.DEPT_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_PERSONFUND.BUDGET_YEAR = :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ADDRESS"))
			{
				strBuf.Add("  V_BGT_B_CPN_INC_PERSONFUND.ADDRESS = :ADDRESS");
				param = new OracleParameter();
				param.ParameterName = ":ADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.ADDRESS) ? string.Empty : obj.ADDRESS;
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
