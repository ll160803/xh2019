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
	[CauseObject(typeof(CauseObject_V_BGT_D_BUDGET_DEPT_USER))]
	public partial class HelperObject_V_BGT_D_BUDGET_DEPT_USER
	{		
		#region Method Blok
		public static int Save(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_BGT_D_BUDGET_DEPT_USER( CODE, IS_FUNCTION, CPN_ID, DEPT_ID, ID, HEADNAME, BUDGET_YEAR, NAME) values ( :CODE, :IS_FUNCTION, :CPN_ID, :DEPT_ID, :ID, :HEADNAME, :BUDGET_YEAR, :NAME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[8];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CODE";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":IS_FUNCTION";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.IS_FUNCTION;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CPN_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.CPN_ID == null ? String.Empty:obj.CPN_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":DEPT_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.DEPT_ID == null ? String.Empty:obj.DEPT_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":HEADNAME";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.HEADNAME == null ? String.Empty:obj.HEADNAME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":BUDGET_YEAR";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":NAME";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.NAME == null ? String.Empty:obj.NAME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_BGT_D_BUDGET_DEPT_USER set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_BGT_D_BUDGET_DEPT_USER where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_BGT_D_BUDGET_DEPT_USER Get(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CODE, IS_FUNCTION, CPN_ID, DEPT_ID, ID, HEADNAME, BUDGET_YEAR, NAME from V_BGT_D_BUDGET_DEPT_USER where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_D_BUDGET_DEPT_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_D_BUDGET_DEPT_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CPN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.HEADNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_BGT_D_BUDGET_DEPT_USER[] objs = new EntityObject_V_BGT_D_BUDGET_DEPT_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_BGT_D_BUDGET_DEPT_USER Get(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CODE, IS_FUNCTION, CPN_ID, DEPT_ID, ID, HEADNAME, BUDGET_YEAR, NAME from V_BGT_D_BUDGET_DEPT_USER where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_BGT_D_BUDGET_DEPT_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_BGT_D_BUDGET_DEPT_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CPN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.HEADNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_BGT_D_BUDGET_DEPT_USER[] objs = new EntityObject_V_BGT_D_BUDGET_DEPT_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_BGT_D_BUDGET_DEPT_USER[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_BGT_D_BUDGET_DEPT_USER.CODE, V_BGT_D_BUDGET_DEPT_USER.IS_FUNCTION, V_BGT_D_BUDGET_DEPT_USER.CPN_ID, V_BGT_D_BUDGET_DEPT_USER.DEPT_ID, V_BGT_D_BUDGET_DEPT_USER.ID, V_BGT_D_BUDGET_DEPT_USER.HEADNAME, V_BGT_D_BUDGET_DEPT_USER.BUDGET_YEAR, V_BGT_D_BUDGET_DEPT_USER.NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_D_BUDGET_DEPT_USER left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_D_BUDGET_DEPT_USER.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_BGT_D_BUDGET_DEPT_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_D_BUDGET_DEPT_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CPN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.HEADNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_D_BUDGET_DEPT_USER[] objs = new DisplayObject_V_BGT_D_BUDGET_DEPT_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_BGT_D_BUDGET_DEPT_USER cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_DEPT_USER.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_DEPT_USER", "CODE"));
			}
			if(cause.IS_FUNCTION!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_BGT_D_BUDGET_DEPT_USER.IS_FUNCTION = :IS_FUNCTION");
				param = new OracleParameter();
				param.ParameterName =":IS_FUNCTION";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_FUNCTION;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_FUNCTION"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_DEPT_USER", "IS_FUNCTION"));
			}
			if(!string.IsNullOrEmpty(cause.CPN_ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_DEPT_USER.CPN_ID ").Append((cause.CPN_ID.StartsWith("%") || cause.CPN_ID.EndsWith("%")) ? " like " : " = ").Append(" :CPN_ID");
				param = new OracleParameter();
				param.ParameterName =":CPN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CPN_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CPN_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_DEPT_USER", "CPN_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_DEPT_USER.DEPT_ID ").Append((cause.DEPT_ID.StartsWith("%") || cause.DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_DEPT_USER", "DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_DEPT_USER.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_DEPT_USER", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.HEADNAME))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_DEPT_USER.HEADNAME ").Append((cause.HEADNAME.StartsWith("%") || cause.HEADNAME.EndsWith("%")) ? " like " : " = ").Append(" :HEADNAME");
				param = new OracleParameter();
				param.ParameterName =":HEADNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.HEADNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("HEADNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_DEPT_USER", "HEADNAME"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_DEPT_USER.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_DEPT_USER", "BUDGET_YEAR"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_BGT_D_BUDGET_DEPT_USER.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_BGT_D_BUDGET_DEPT_USER", "NAME"));
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
		public static DisplayObject_V_BGT_D_BUDGET_DEPT_USER[] Query(CauseObject_V_BGT_D_BUDGET_DEPT_USER cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_D_BUDGET_DEPT_USER.CODE, V_BGT_D_BUDGET_DEPT_USER.IS_FUNCTION, V_BGT_D_BUDGET_DEPT_USER.CPN_ID, V_BGT_D_BUDGET_DEPT_USER.DEPT_ID, V_BGT_D_BUDGET_DEPT_USER.ID, V_BGT_D_BUDGET_DEPT_USER.HEADNAME, V_BGT_D_BUDGET_DEPT_USER.BUDGET_YEAR, V_BGT_D_BUDGET_DEPT_USER.NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_D_BUDGET_DEPT_USER left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_D_BUDGET_DEPT_USER.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_D_BUDGET_DEPT_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_D_BUDGET_DEPT_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CPN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.HEADNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_D_BUDGET_DEPT_USER[] objs = new DisplayObject_V_BGT_D_BUDGET_DEPT_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_BGT_D_BUDGET_DEPT_USER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_BGT_D_BUDGET_DEPT_USER where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_BGT_D_BUDGET_DEPT_USER[] Query(CauseObject_V_BGT_D_BUDGET_DEPT_USER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_BGT_D_BUDGET_DEPT_USER.CODE, V_BGT_D_BUDGET_DEPT_USER.IS_FUNCTION, V_BGT_D_BUDGET_DEPT_USER.CPN_ID, V_BGT_D_BUDGET_DEPT_USER.DEPT_ID, V_BGT_D_BUDGET_DEPT_USER.ID, V_BGT_D_BUDGET_DEPT_USER.HEADNAME, V_BGT_D_BUDGET_DEPT_USER.BUDGET_YEAR, V_BGT_D_BUDGET_DEPT_USER.NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_D_BUDGET_DEPT_USER left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_D_BUDGET_DEPT_USER.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_BGT_D_BUDGET_DEPT_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_D_BUDGET_DEPT_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CPN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.HEADNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_D_BUDGET_DEPT_USER[] objs = new DisplayObject_V_BGT_D_BUDGET_DEPT_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_D_BUDGET_DEPT_USER[] Query(CauseObject_V_BGT_D_BUDGET_DEPT_USER cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_D_BUDGET_DEPT_USER.CODE, V_BGT_D_BUDGET_DEPT_USER.IS_FUNCTION, V_BGT_D_BUDGET_DEPT_USER.CPN_ID, V_BGT_D_BUDGET_DEPT_USER.DEPT_ID, V_BGT_D_BUDGET_DEPT_USER.ID, V_BGT_D_BUDGET_DEPT_USER.HEADNAME, V_BGT_D_BUDGET_DEPT_USER.BUDGET_YEAR, V_BGT_D_BUDGET_DEPT_USER.NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_D_BUDGET_DEPT_USER left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_D_BUDGET_DEPT_USER.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_D_BUDGET_DEPT_USER",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_BGT_D_BUDGET_DEPT_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_D_BUDGET_DEPT_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CPN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.HEADNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_BGT_D_BUDGET_DEPT_USER[] objs = new DisplayObject_V_BGT_D_BUDGET_DEPT_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_BGT_D_BUDGET_DEPT_USER[] Query(CauseObject_V_BGT_D_BUDGET_DEPT_USER cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_BGT_D_BUDGET_DEPT_USER.CODE, V_BGT_D_BUDGET_DEPT_USER.IS_FUNCTION, V_BGT_D_BUDGET_DEPT_USER.CPN_ID, V_BGT_D_BUDGET_DEPT_USER.DEPT_ID, V_BGT_D_BUDGET_DEPT_USER.ID, V_BGT_D_BUDGET_DEPT_USER.HEADNAME, V_BGT_D_BUDGET_DEPT_USER.BUDGET_YEAR, V_BGT_D_BUDGET_DEPT_USER.NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME from V_BGT_D_BUDGET_DEPT_USER left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on V_BGT_D_BUDGET_DEPT_USER.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_BGT_D_BUDGET_DEPT_USER",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_BGT_D_BUDGET_DEPT_USER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_BGT_D_BUDGET_DEPT_USER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IS_FUNCTION = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CPN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.HEADNAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_BGT_D_BUDGET_DEPT_USER[] objs = new DisplayObject_V_BGT_D_BUDGET_DEPT_USER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_BGT_D_BUDGET_DEPT_USER obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_DEPT_USER.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_FUNCTION"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_DEPT_USER.IS_FUNCTION = :IS_FUNCTION");
				param = new OracleParameter();
				param.ParameterName = ":IS_FUNCTION";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_FUNCTION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CPN_ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_DEPT_USER.CPN_ID = :CPN_ID");
				param = new OracleParameter();
				param.ParameterName = ":CPN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.CPN_ID) ? string.Empty : obj.CPN_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_DEPT_USER.DEPT_ID = :DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_ID) ? string.Empty : obj.DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_DEPT_USER.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("HEADNAME"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_DEPT_USER.HEADNAME = :HEADNAME");
				param = new OracleParameter();
				param.ParameterName = ":HEADNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.HEADNAME) ? string.Empty : obj.HEADNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_DEPT_USER.BUDGET_YEAR = :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_BGT_D_BUDGET_DEPT_USER.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
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
