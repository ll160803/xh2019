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
	[CauseObject(typeof(CauseObject_BGT_D_BUDGET_PATTERN))]
	public partial class HelperObject_BGT_D_BUDGET_PATTERN
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_D_BUDGET_PATTERN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_D_BUDGET_PATTERN( ID, PAY_PATTERN_ENTRY_ID, INCOME_PATTERN_ID, INCOME_LEVEL_ID, IS_INTERNAL, PLAN_PATTERN_ID, BUDGET_YEAR, PAY_PATTERN_ID, PAY_LEVEL_ID, IS_PAY_ITEM_MERGE) values ( :ID, :PAY_PATTERN_ENTRY_ID, :INCOME_PATTERN_ID, :INCOME_LEVEL_ID, :IS_INTERNAL, :PLAN_PATTERN_ID, :BUDGET_YEAR, :PAY_PATTERN_ID, :PAY_LEVEL_ID, :IS_PAY_ITEM_MERGE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[10];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":PAY_PATTERN_ENTRY_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.PAY_PATTERN_ENTRY_ID == null ? String.Empty:obj.PAY_PATTERN_ENTRY_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":INCOME_PATTERN_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.INCOME_PATTERN_ID == null ? String.Empty:obj.INCOME_PATTERN_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":INCOME_LEVEL_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.INCOME_LEVEL_ID == null ? String.Empty:obj.INCOME_LEVEL_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":IS_INTERNAL";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.IS_INTERNAL;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":PLAN_PATTERN_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.PLAN_PATTERN_ID == null ? String.Empty:obj.PLAN_PATTERN_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":BUDGET_YEAR";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":PAY_PATTERN_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.PAY_PATTERN_ID == null ? String.Empty:obj.PAY_PATTERN_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":PAY_LEVEL_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.PAY_LEVEL_ID == null ? String.Empty:obj.PAY_LEVEL_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":IS_PAY_ITEM_MERGE";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.IS_PAY_ITEM_MERGE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_D_BUDGET_PATTERN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_D_BUDGET_PATTERN set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_D_BUDGET_PATTERN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_D_BUDGET_PATTERN where  ID = :ID ";
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
		public static EntityObject_BGT_D_BUDGET_PATTERN Get(EntityObject_BGT_D_BUDGET_PATTERN obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, PAY_PATTERN_ENTRY_ID, INCOME_PATTERN_ID, INCOME_LEVEL_ID, IS_INTERNAL, PLAN_PATTERN_ID, BUDGET_YEAR, PAY_PATTERN_ID, PAY_LEVEL_ID, IS_PAY_ITEM_MERGE from BGT_D_BUDGET_PATTERN where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_D_BUDGET_PATTERN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_D_BUDGET_PATTERN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAY_PATTERN_ENTRY_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INCOME_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.INCOME_LEVEL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_INTERNAL = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PLAN_PATTERN_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PAY_PATTERN_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAY_LEVEL_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PAY_ITEM_MERGE = sqlReader.GetDecimal(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_D_BUDGET_PATTERN[] objs = new EntityObject_BGT_D_BUDGET_PATTERN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_D_BUDGET_PATTERN Get(EntityObject_BGT_D_BUDGET_PATTERN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, PAY_PATTERN_ENTRY_ID, INCOME_PATTERN_ID, INCOME_LEVEL_ID, IS_INTERNAL, PLAN_PATTERN_ID, BUDGET_YEAR, PAY_PATTERN_ID, PAY_LEVEL_ID, IS_PAY_ITEM_MERGE from BGT_D_BUDGET_PATTERN where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_D_BUDGET_PATTERN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_D_BUDGET_PATTERN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAY_PATTERN_ENTRY_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INCOME_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.INCOME_LEVEL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_INTERNAL = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PLAN_PATTERN_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PAY_PATTERN_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAY_LEVEL_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PAY_ITEM_MERGE = sqlReader.GetDecimal(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_D_BUDGET_PATTERN[] objs = new EntityObject_BGT_D_BUDGET_PATTERN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_D_BUDGET_PATTERN[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_D_BUDGET_PATTERN.ID, BGT_D_BUDGET_PATTERN.PAY_PATTERN_ENTRY_ID, BGT_D_BUDGET_PATTERN.INCOME_PATTERN_ID, BGT_D_BUDGET_PATTERN.INCOME_LEVEL_ID, BGT_D_BUDGET_PATTERN.IS_INTERNAL, BGT_D_BUDGET_PATTERN.PLAN_PATTERN_ID, BGT_D_BUDGET_PATTERN.BUDGET_YEAR, BGT_D_BUDGET_PATTERN.PAY_PATTERN_ID, BGT_D_BUDGET_PATTERN.PAY_LEVEL_ID, BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE, COM_TYPE_PAY_PATTERN_ENTRY_ID.NAME as PAY_PATTERN_ENTRY_ID_NAME, COM_TYPE_INCOME_PATTERN_ID.NAME as INCOME_PATTERN_ID_NAME, COM_TYPE_INCOME_LEVEL_ID.NAME as INCOME_LEVEL_ID_NAME, (case  when BGT_D_BUDGET_PATTERN.IS_INTERNAL = 1 then '是' when BGT_D_BUDGET_PATTERN.IS_INTERNAL = 2 then '否' else '' end ) as IS_INTERNAL_NAME, COM_TYPE_PLAN_PATTERN_ID.NAME as PLAN_PATTERN_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_PAY_PATTERN_ID.NAME as PAY_PATTERN_ID_NAME, COM_TYPE_PAY_LEVEL_ID.NAME as PAY_LEVEL_ID_NAME, (case  when BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE = 1 then '是' when BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE = 2 then '否' else '' end ) as IS_PAY_ITEM_MERGE_NAME from BGT_D_BUDGET_PATTERN left join COM_TYPE   COM_TYPE_PAY_PATTERN_ENTRY_ID on BGT_D_BUDGET_PATTERN.PAY_PATTERN_ENTRY_ID = COM_TYPE_PAY_PATTERN_ENTRY_ID.ID left join COM_TYPE   COM_TYPE_INCOME_PATTERN_ID on BGT_D_BUDGET_PATTERN.INCOME_PATTERN_ID = COM_TYPE_INCOME_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_INCOME_LEVEL_ID on BGT_D_BUDGET_PATTERN.INCOME_LEVEL_ID = COM_TYPE_INCOME_LEVEL_ID.ID left join COM_TYPE   COM_TYPE_PLAN_PATTERN_ID on BGT_D_BUDGET_PATTERN.PLAN_PATTERN_ID = COM_TYPE_PLAN_PATTERN_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_BUDGET_PATTERN.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_PAY_PATTERN_ID on BGT_D_BUDGET_PATTERN.PAY_PATTERN_ID = COM_TYPE_PAY_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_PAY_LEVEL_ID on BGT_D_BUDGET_PATTERN.PAY_LEVEL_ID = COM_TYPE_PAY_LEVEL_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_D_BUDGET_PATTERN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_PATTERN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAY_PATTERN_ENTRY_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INCOME_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.INCOME_LEVEL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_INTERNAL = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PLAN_PATTERN_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PAY_PATTERN_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAY_LEVEL_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PAY_ITEM_MERGE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAY_PATTERN_ENTRY_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.INCOME_PATTERN_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.INCOME_LEVEL_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_INTERNAL_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.PLAN_PATTERN_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.PAY_PATTERN_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PAY_LEVEL_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_PAY_ITEM_MERGE_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_BUDGET_PATTERN[] objs = new DisplayObject_BGT_D_BUDGET_PATTERN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_D_BUDGET_PATTERN cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And BGT_D_BUDGET_PATTERN.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_PATTERN", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.PAY_PATTERN_ENTRY_ID))
			{
				strBuf.Append(" And BGT_D_BUDGET_PATTERN.PAY_PATTERN_ENTRY_ID ").Append((cause.PAY_PATTERN_ENTRY_ID.StartsWith("%") || cause.PAY_PATTERN_ENTRY_ID.EndsWith("%")) ? " like " : " = ").Append(" :PAY_PATTERN_ENTRY_ID");
				param = new OracleParameter();
				param.ParameterName =":PAY_PATTERN_ENTRY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PAY_PATTERN_ENTRY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAY_PATTERN_ENTRY_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_PATTERN", "PAY_PATTERN_ENTRY_ID"));
			}
			if(!string.IsNullOrEmpty(cause.INCOME_PATTERN_ID))
			{
				strBuf.Append(" And BGT_D_BUDGET_PATTERN.INCOME_PATTERN_ID ").Append((cause.INCOME_PATTERN_ID.StartsWith("%") || cause.INCOME_PATTERN_ID.EndsWith("%")) ? " like " : " = ").Append(" :INCOME_PATTERN_ID");
				param = new OracleParameter();
				param.ParameterName =":INCOME_PATTERN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.INCOME_PATTERN_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("INCOME_PATTERN_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_PATTERN", "INCOME_PATTERN_ID"));
			}
			if(!string.IsNullOrEmpty(cause.INCOME_LEVEL_ID))
			{
				strBuf.Append(" And BGT_D_BUDGET_PATTERN.INCOME_LEVEL_ID ").Append((cause.INCOME_LEVEL_ID.StartsWith("%") || cause.INCOME_LEVEL_ID.EndsWith("%")) ? " like " : " = ").Append(" :INCOME_LEVEL_ID");
				param = new OracleParameter();
				param.ParameterName =":INCOME_LEVEL_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.INCOME_LEVEL_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("INCOME_LEVEL_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_PATTERN", "INCOME_LEVEL_ID"));
			}
			if(cause.IS_INTERNAL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_D_BUDGET_PATTERN.IS_INTERNAL = :IS_INTERNAL");
				param = new OracleParameter();
				param.ParameterName =":IS_INTERNAL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_INTERNAL;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_INTERNAL"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_PATTERN", "IS_INTERNAL"));
			}
			if(!string.IsNullOrEmpty(cause.PLAN_PATTERN_ID))
			{
				strBuf.Append(" And BGT_D_BUDGET_PATTERN.PLAN_PATTERN_ID ").Append((cause.PLAN_PATTERN_ID.StartsWith("%") || cause.PLAN_PATTERN_ID.EndsWith("%")) ? " like " : " = ").Append(" :PLAN_PATTERN_ID");
				param = new OracleParameter();
				param.ParameterName =":PLAN_PATTERN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PLAN_PATTERN_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PLAN_PATTERN_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_PATTERN", "PLAN_PATTERN_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BUDGET_YEAR))
			{
				strBuf.Append(" And BGT_D_BUDGET_PATTERN.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_PATTERN", "BUDGET_YEAR"));
			}
			if(!string.IsNullOrEmpty(cause.PAY_PATTERN_ID))
			{
				strBuf.Append(" And BGT_D_BUDGET_PATTERN.PAY_PATTERN_ID ").Append((cause.PAY_PATTERN_ID.StartsWith("%") || cause.PAY_PATTERN_ID.EndsWith("%")) ? " like " : " = ").Append(" :PAY_PATTERN_ID");
				param = new OracleParameter();
				param.ParameterName =":PAY_PATTERN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PAY_PATTERN_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAY_PATTERN_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_PATTERN", "PAY_PATTERN_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PAY_LEVEL_ID))
			{
				strBuf.Append(" And BGT_D_BUDGET_PATTERN.PAY_LEVEL_ID ").Append((cause.PAY_LEVEL_ID.StartsWith("%") || cause.PAY_LEVEL_ID.EndsWith("%")) ? " like " : " = ").Append(" :PAY_LEVEL_ID");
				param = new OracleParameter();
				param.ParameterName =":PAY_LEVEL_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PAY_LEVEL_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAY_LEVEL_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_PATTERN", "PAY_LEVEL_ID"));
			}
			if(cause.IS_PAY_ITEM_MERGE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE = :IS_PAY_ITEM_MERGE");
				param = new OracleParameter();
				param.ParameterName =":IS_PAY_ITEM_MERGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_PAY_ITEM_MERGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_PAY_ITEM_MERGE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_PATTERN", "IS_PAY_ITEM_MERGE"));
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
		public static DisplayObject_BGT_D_BUDGET_PATTERN[] Query(CauseObject_BGT_D_BUDGET_PATTERN cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_D_BUDGET_PATTERN.ID, BGT_D_BUDGET_PATTERN.PAY_PATTERN_ENTRY_ID, BGT_D_BUDGET_PATTERN.INCOME_PATTERN_ID, BGT_D_BUDGET_PATTERN.INCOME_LEVEL_ID, BGT_D_BUDGET_PATTERN.IS_INTERNAL, BGT_D_BUDGET_PATTERN.PLAN_PATTERN_ID, BGT_D_BUDGET_PATTERN.BUDGET_YEAR, BGT_D_BUDGET_PATTERN.PAY_PATTERN_ID, BGT_D_BUDGET_PATTERN.PAY_LEVEL_ID, BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE, COM_TYPE_PAY_PATTERN_ENTRY_ID.NAME as PAY_PATTERN_ENTRY_ID_NAME, COM_TYPE_INCOME_PATTERN_ID.NAME as INCOME_PATTERN_ID_NAME, COM_TYPE_INCOME_LEVEL_ID.NAME as INCOME_LEVEL_ID_NAME, (case  when BGT_D_BUDGET_PATTERN.IS_INTERNAL = 1 then '是' when BGT_D_BUDGET_PATTERN.IS_INTERNAL = 2 then '否' else '' end ) as IS_INTERNAL_NAME, COM_TYPE_PLAN_PATTERN_ID.NAME as PLAN_PATTERN_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_PAY_PATTERN_ID.NAME as PAY_PATTERN_ID_NAME, COM_TYPE_PAY_LEVEL_ID.NAME as PAY_LEVEL_ID_NAME, (case  when BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE = 1 then '是' when BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE = 2 then '否' else '' end ) as IS_PAY_ITEM_MERGE_NAME from BGT_D_BUDGET_PATTERN left join COM_TYPE   COM_TYPE_PAY_PATTERN_ENTRY_ID on BGT_D_BUDGET_PATTERN.PAY_PATTERN_ENTRY_ID = COM_TYPE_PAY_PATTERN_ENTRY_ID.ID left join COM_TYPE   COM_TYPE_INCOME_PATTERN_ID on BGT_D_BUDGET_PATTERN.INCOME_PATTERN_ID = COM_TYPE_INCOME_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_INCOME_LEVEL_ID on BGT_D_BUDGET_PATTERN.INCOME_LEVEL_ID = COM_TYPE_INCOME_LEVEL_ID.ID left join COM_TYPE   COM_TYPE_PLAN_PATTERN_ID on BGT_D_BUDGET_PATTERN.PLAN_PATTERN_ID = COM_TYPE_PLAN_PATTERN_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_BUDGET_PATTERN.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_PAY_PATTERN_ID on BGT_D_BUDGET_PATTERN.PAY_PATTERN_ID = COM_TYPE_PAY_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_PAY_LEVEL_ID on BGT_D_BUDGET_PATTERN.PAY_LEVEL_ID = COM_TYPE_PAY_LEVEL_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_D_BUDGET_PATTERN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_PATTERN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAY_PATTERN_ENTRY_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INCOME_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.INCOME_LEVEL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_INTERNAL = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PLAN_PATTERN_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PAY_PATTERN_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAY_LEVEL_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PAY_ITEM_MERGE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAY_PATTERN_ENTRY_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.INCOME_PATTERN_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.INCOME_LEVEL_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_INTERNAL_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.PLAN_PATTERN_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.PAY_PATTERN_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PAY_LEVEL_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_PAY_ITEM_MERGE_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_BUDGET_PATTERN[] objs = new DisplayObject_BGT_D_BUDGET_PATTERN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_D_BUDGET_PATTERN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_D_BUDGET_PATTERN where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_D_BUDGET_PATTERN[] Query(CauseObject_BGT_D_BUDGET_PATTERN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_D_BUDGET_PATTERN.ID, BGT_D_BUDGET_PATTERN.PAY_PATTERN_ENTRY_ID, BGT_D_BUDGET_PATTERN.INCOME_PATTERN_ID, BGT_D_BUDGET_PATTERN.INCOME_LEVEL_ID, BGT_D_BUDGET_PATTERN.IS_INTERNAL, BGT_D_BUDGET_PATTERN.PLAN_PATTERN_ID, BGT_D_BUDGET_PATTERN.BUDGET_YEAR, BGT_D_BUDGET_PATTERN.PAY_PATTERN_ID, BGT_D_BUDGET_PATTERN.PAY_LEVEL_ID, BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE, COM_TYPE_PAY_PATTERN_ENTRY_ID.NAME as PAY_PATTERN_ENTRY_ID_NAME, COM_TYPE_INCOME_PATTERN_ID.NAME as INCOME_PATTERN_ID_NAME, COM_TYPE_INCOME_LEVEL_ID.NAME as INCOME_LEVEL_ID_NAME, (case  when BGT_D_BUDGET_PATTERN.IS_INTERNAL = 1 then '是' when BGT_D_BUDGET_PATTERN.IS_INTERNAL = 2 then '否' else '' end ) as IS_INTERNAL_NAME, COM_TYPE_PLAN_PATTERN_ID.NAME as PLAN_PATTERN_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_PAY_PATTERN_ID.NAME as PAY_PATTERN_ID_NAME, COM_TYPE_PAY_LEVEL_ID.NAME as PAY_LEVEL_ID_NAME, (case  when BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE = 1 then '是' when BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE = 2 then '否' else '' end ) as IS_PAY_ITEM_MERGE_NAME from BGT_D_BUDGET_PATTERN left join COM_TYPE   COM_TYPE_PAY_PATTERN_ENTRY_ID on BGT_D_BUDGET_PATTERN.PAY_PATTERN_ENTRY_ID = COM_TYPE_PAY_PATTERN_ENTRY_ID.ID left join COM_TYPE   COM_TYPE_INCOME_PATTERN_ID on BGT_D_BUDGET_PATTERN.INCOME_PATTERN_ID = COM_TYPE_INCOME_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_INCOME_LEVEL_ID on BGT_D_BUDGET_PATTERN.INCOME_LEVEL_ID = COM_TYPE_INCOME_LEVEL_ID.ID left join COM_TYPE   COM_TYPE_PLAN_PATTERN_ID on BGT_D_BUDGET_PATTERN.PLAN_PATTERN_ID = COM_TYPE_PLAN_PATTERN_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_BUDGET_PATTERN.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_PAY_PATTERN_ID on BGT_D_BUDGET_PATTERN.PAY_PATTERN_ID = COM_TYPE_PAY_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_PAY_LEVEL_ID on BGT_D_BUDGET_PATTERN.PAY_LEVEL_ID = COM_TYPE_PAY_LEVEL_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_D_BUDGET_PATTERN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_PATTERN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAY_PATTERN_ENTRY_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INCOME_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.INCOME_LEVEL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_INTERNAL = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PLAN_PATTERN_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PAY_PATTERN_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAY_LEVEL_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PAY_ITEM_MERGE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAY_PATTERN_ENTRY_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.INCOME_PATTERN_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.INCOME_LEVEL_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_INTERNAL_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.PLAN_PATTERN_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.PAY_PATTERN_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PAY_LEVEL_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_PAY_ITEM_MERGE_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_D_BUDGET_PATTERN[] objs = new DisplayObject_BGT_D_BUDGET_PATTERN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_D_BUDGET_PATTERN[] Query(CauseObject_BGT_D_BUDGET_PATTERN cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_D_BUDGET_PATTERN.ID, BGT_D_BUDGET_PATTERN.PAY_PATTERN_ENTRY_ID, BGT_D_BUDGET_PATTERN.INCOME_PATTERN_ID, BGT_D_BUDGET_PATTERN.INCOME_LEVEL_ID, BGT_D_BUDGET_PATTERN.IS_INTERNAL, BGT_D_BUDGET_PATTERN.PLAN_PATTERN_ID, BGT_D_BUDGET_PATTERN.BUDGET_YEAR, BGT_D_BUDGET_PATTERN.PAY_PATTERN_ID, BGT_D_BUDGET_PATTERN.PAY_LEVEL_ID, BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE, COM_TYPE_PAY_PATTERN_ENTRY_ID.NAME as PAY_PATTERN_ENTRY_ID_NAME, COM_TYPE_INCOME_PATTERN_ID.NAME as INCOME_PATTERN_ID_NAME, COM_TYPE_INCOME_LEVEL_ID.NAME as INCOME_LEVEL_ID_NAME, (case  when BGT_D_BUDGET_PATTERN.IS_INTERNAL = 1 then '是' when BGT_D_BUDGET_PATTERN.IS_INTERNAL = 2 then '否' else '' end ) as IS_INTERNAL_NAME, COM_TYPE_PLAN_PATTERN_ID.NAME as PLAN_PATTERN_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_PAY_PATTERN_ID.NAME as PAY_PATTERN_ID_NAME, COM_TYPE_PAY_LEVEL_ID.NAME as PAY_LEVEL_ID_NAME, (case  when BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE = 1 then '是' when BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE = 2 then '否' else '' end ) as IS_PAY_ITEM_MERGE_NAME from BGT_D_BUDGET_PATTERN left join COM_TYPE   COM_TYPE_PAY_PATTERN_ENTRY_ID on BGT_D_BUDGET_PATTERN.PAY_PATTERN_ENTRY_ID = COM_TYPE_PAY_PATTERN_ENTRY_ID.ID left join COM_TYPE   COM_TYPE_INCOME_PATTERN_ID on BGT_D_BUDGET_PATTERN.INCOME_PATTERN_ID = COM_TYPE_INCOME_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_INCOME_LEVEL_ID on BGT_D_BUDGET_PATTERN.INCOME_LEVEL_ID = COM_TYPE_INCOME_LEVEL_ID.ID left join COM_TYPE   COM_TYPE_PLAN_PATTERN_ID on BGT_D_BUDGET_PATTERN.PLAN_PATTERN_ID = COM_TYPE_PLAN_PATTERN_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_BUDGET_PATTERN.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_PAY_PATTERN_ID on BGT_D_BUDGET_PATTERN.PAY_PATTERN_ID = COM_TYPE_PAY_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_PAY_LEVEL_ID on BGT_D_BUDGET_PATTERN.PAY_LEVEL_ID = COM_TYPE_PAY_LEVEL_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_BUDGET_PATTERN",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_D_BUDGET_PATTERN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_PATTERN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAY_PATTERN_ENTRY_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INCOME_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.INCOME_LEVEL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_INTERNAL = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PLAN_PATTERN_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PAY_PATTERN_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAY_LEVEL_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PAY_ITEM_MERGE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAY_PATTERN_ENTRY_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.INCOME_PATTERN_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.INCOME_LEVEL_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_INTERNAL_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.PLAN_PATTERN_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.PAY_PATTERN_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PAY_LEVEL_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_PAY_ITEM_MERGE_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_BUDGET_PATTERN[] objs = new DisplayObject_BGT_D_BUDGET_PATTERN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_D_BUDGET_PATTERN[] Query(CauseObject_BGT_D_BUDGET_PATTERN cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_D_BUDGET_PATTERN.ID, BGT_D_BUDGET_PATTERN.PAY_PATTERN_ENTRY_ID, BGT_D_BUDGET_PATTERN.INCOME_PATTERN_ID, BGT_D_BUDGET_PATTERN.INCOME_LEVEL_ID, BGT_D_BUDGET_PATTERN.IS_INTERNAL, BGT_D_BUDGET_PATTERN.PLAN_PATTERN_ID, BGT_D_BUDGET_PATTERN.BUDGET_YEAR, BGT_D_BUDGET_PATTERN.PAY_PATTERN_ID, BGT_D_BUDGET_PATTERN.PAY_LEVEL_ID, BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE, COM_TYPE_PAY_PATTERN_ENTRY_ID.NAME as PAY_PATTERN_ENTRY_ID_NAME, COM_TYPE_INCOME_PATTERN_ID.NAME as INCOME_PATTERN_ID_NAME, COM_TYPE_INCOME_LEVEL_ID.NAME as INCOME_LEVEL_ID_NAME, (case  when BGT_D_BUDGET_PATTERN.IS_INTERNAL = 1 then '是' when BGT_D_BUDGET_PATTERN.IS_INTERNAL = 2 then '否' else '' end ) as IS_INTERNAL_NAME, COM_TYPE_PLAN_PATTERN_ID.NAME as PLAN_PATTERN_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_PAY_PATTERN_ID.NAME as PAY_PATTERN_ID_NAME, COM_TYPE_PAY_LEVEL_ID.NAME as PAY_LEVEL_ID_NAME, (case  when BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE = 1 then '是' when BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE = 2 then '否' else '' end ) as IS_PAY_ITEM_MERGE_NAME from BGT_D_BUDGET_PATTERN left join COM_TYPE   COM_TYPE_PAY_PATTERN_ENTRY_ID on BGT_D_BUDGET_PATTERN.PAY_PATTERN_ENTRY_ID = COM_TYPE_PAY_PATTERN_ENTRY_ID.ID left join COM_TYPE   COM_TYPE_INCOME_PATTERN_ID on BGT_D_BUDGET_PATTERN.INCOME_PATTERN_ID = COM_TYPE_INCOME_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_INCOME_LEVEL_ID on BGT_D_BUDGET_PATTERN.INCOME_LEVEL_ID = COM_TYPE_INCOME_LEVEL_ID.ID left join COM_TYPE   COM_TYPE_PLAN_PATTERN_ID on BGT_D_BUDGET_PATTERN.PLAN_PATTERN_ID = COM_TYPE_PLAN_PATTERN_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_BUDGET_PATTERN.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_PAY_PATTERN_ID on BGT_D_BUDGET_PATTERN.PAY_PATTERN_ID = COM_TYPE_PAY_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_PAY_LEVEL_ID on BGT_D_BUDGET_PATTERN.PAY_LEVEL_ID = COM_TYPE_PAY_LEVEL_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_BUDGET_PATTERN",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_D_BUDGET_PATTERN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_BUDGET_PATTERN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAY_PATTERN_ENTRY_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INCOME_PATTERN_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.INCOME_LEVEL_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_INTERNAL = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PLAN_PATTERN_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PAY_PATTERN_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAY_LEVEL_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PAY_ITEM_MERGE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAY_PATTERN_ENTRY_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.INCOME_PATTERN_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.INCOME_LEVEL_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_INTERNAL_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.PLAN_PATTERN_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.PAY_PATTERN_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PAY_LEVEL_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_PAY_ITEM_MERGE_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_D_BUDGET_PATTERN[] objs = new DisplayObject_BGT_D_BUDGET_PATTERN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_D_BUDGET_PATTERN obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("PAY_PATTERN_ENTRY_ID"))
			{
				strBuf.Add("  BGT_D_BUDGET_PATTERN.PAY_PATTERN_ENTRY_ID = :PAY_PATTERN_ENTRY_ID");
				param = new OracleParameter();
				param.ParameterName = ":PAY_PATTERN_ENTRY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PAY_PATTERN_ENTRY_ID) ? string.Empty : obj.PAY_PATTERN_ENTRY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INCOME_PATTERN_ID"))
			{
				strBuf.Add("  BGT_D_BUDGET_PATTERN.INCOME_PATTERN_ID = :INCOME_PATTERN_ID");
				param = new OracleParameter();
				param.ParameterName = ":INCOME_PATTERN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.INCOME_PATTERN_ID) ? string.Empty : obj.INCOME_PATTERN_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INCOME_LEVEL_ID"))
			{
				strBuf.Add("  BGT_D_BUDGET_PATTERN.INCOME_LEVEL_ID = :INCOME_LEVEL_ID");
				param = new OracleParameter();
				param.ParameterName = ":INCOME_LEVEL_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.INCOME_LEVEL_ID) ? string.Empty : obj.INCOME_LEVEL_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_INTERNAL"))
			{
				strBuf.Add("  BGT_D_BUDGET_PATTERN.IS_INTERNAL = :IS_INTERNAL");
				param = new OracleParameter();
				param.ParameterName = ":IS_INTERNAL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_INTERNAL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PLAN_PATTERN_ID"))
			{
				strBuf.Add("  BGT_D_BUDGET_PATTERN.PLAN_PATTERN_ID = :PLAN_PATTERN_ID");
				param = new OracleParameter();
				param.ParameterName = ":PLAN_PATTERN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PLAN_PATTERN_ID) ? string.Empty : obj.PLAN_PATTERN_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  BGT_D_BUDGET_PATTERN.BUDGET_YEAR = :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAY_PATTERN_ID"))
			{
				strBuf.Add("  BGT_D_BUDGET_PATTERN.PAY_PATTERN_ID = :PAY_PATTERN_ID");
				param = new OracleParameter();
				param.ParameterName = ":PAY_PATTERN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PAY_PATTERN_ID) ? string.Empty : obj.PAY_PATTERN_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAY_LEVEL_ID"))
			{
				strBuf.Add("  BGT_D_BUDGET_PATTERN.PAY_LEVEL_ID = :PAY_LEVEL_ID");
				param = new OracleParameter();
				param.ParameterName = ":PAY_LEVEL_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PAY_LEVEL_ID) ? string.Empty : obj.PAY_LEVEL_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_PAY_ITEM_MERGE"))
			{
				strBuf.Add("  BGT_D_BUDGET_PATTERN.IS_PAY_ITEM_MERGE = :IS_PAY_ITEM_MERGE");
				param = new OracleParameter();
				param.ParameterName = ":IS_PAY_ITEM_MERGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_PAY_ITEM_MERGE;
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
