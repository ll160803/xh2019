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
	[CauseObject(typeof(CauseObject_BGT_B_BUDGET_CONTROL_D_EXE))]
	public partial class HelperObject_BGT_B_BUDGET_CONTROL_D_EXE
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_B_BUDGET_CONTROL_D_EXE( BUDGET_DEPT_ID, ID, MONEY, BASE_ID, AVAILABLE_MONEY, ITEM_ID, REF_TAB_NAME, CREATE_DATE, APPLY_MONEY, REF_TAB_ID, FINANCE_CYCLE, IS_PASS) values ( :BUDGET_DEPT_ID, :ID, :MONEY, :BASE_ID, :AVAILABLE_MONEY, :ITEM_ID, :REF_TAB_NAME, :CREATE_DATE, :APPLY_MONEY, :REF_TAB_ID, :FINANCE_CYCLE, :IS_PASS)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[12];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":BUDGET_DEPT_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.BUDGET_DEPT_ID == null ? String.Empty:obj.BUDGET_DEPT_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":MONEY";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.MONEY;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":BASE_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":AVAILABLE_MONEY";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.AVAILABLE_MONEY;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ITEM_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.ITEM_ID == null ? String.Empty:obj.ITEM_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":REF_TAB_NAME";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.REF_TAB_NAME == null ? String.Empty:obj.REF_TAB_NAME;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CREATE_DATE";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.CREATE_DATE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":APPLY_MONEY";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.APPLY_MONEY;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":REF_TAB_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.REF_TAB_ID == null ? String.Empty:obj.REF_TAB_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":FINANCE_CYCLE";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.FINANCE_CYCLE == null ? String.Empty:obj.FINANCE_CYCLE;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":IS_PASS";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.IS_PASS;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_BUDGET_CONTROL_D_EXE set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_BUDGET_CONTROL_D_EXE where  ID = :ID ";
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
		public static EntityObject_BGT_B_BUDGET_CONTROL_D_EXE Get(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  BUDGET_DEPT_ID, ID, MONEY, BASE_ID, AVAILABLE_MONEY, ITEM_ID, REF_TAB_NAME, CREATE_DATE, APPLY_MONEY, REF_TAB_ID, FINANCE_CYCLE, IS_PASS from BGT_B_BUDGET_CONTROL_D_EXE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_BUDGET_CONTROL_D_EXE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_BUDGET_CONTROL_D_EXE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PASS = sqlReader.GetDecimal(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_BUDGET_CONTROL_D_EXE[] objs = new EntityObject_BGT_B_BUDGET_CONTROL_D_EXE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_BUDGET_CONTROL_D_EXE Get(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  BUDGET_DEPT_ID, ID, MONEY, BASE_ID, AVAILABLE_MONEY, ITEM_ID, REF_TAB_NAME, CREATE_DATE, APPLY_MONEY, REF_TAB_ID, FINANCE_CYCLE, IS_PASS from BGT_B_BUDGET_CONTROL_D_EXE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_BUDGET_CONTROL_D_EXE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_BUDGET_CONTROL_D_EXE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PASS = sqlReader.GetDecimal(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_BUDGET_CONTROL_D_EXE[] objs = new EntityObject_BGT_B_BUDGET_CONTROL_D_EXE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID, BGT_B_BUDGET_CONTROL_D_EXE.ID, BGT_B_BUDGET_CONTROL_D_EXE.MONEY, BGT_B_BUDGET_CONTROL_D_EXE.BASE_ID, BGT_B_BUDGET_CONTROL_D_EXE.AVAILABLE_MONEY, BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID, BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_NAME, BGT_B_BUDGET_CONTROL_D_EXE.CREATE_DATE, BGT_B_BUDGET_CONTROL_D_EXE.APPLY_MONEY, BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_ID, BGT_B_BUDGET_CONTROL_D_EXE.FINANCE_CYCLE, BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, (case  when BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS = 1 then '是' when BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS = 2 then '否' else '' end ) as IS_PASS_NAME from BGT_B_BUDGET_CONTROL_D_EXE left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PASS = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_PASS_NAME = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] objs = new DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_BUDGET_CONTROL_D_EXE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.BUDGET_DEPT_ID))
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID ").Append((cause.BUDGET_DEPT_ID.StartsWith("%") || cause.BUDGET_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_D_EXE", "BUDGET_DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_D_EXE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_D_EXE", "ID"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_D_EXE.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName =":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_D_EXE", "MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_D_EXE.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_D_EXE", "BASE_ID"));
			}
			if(cause.AVAILABLE_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_D_EXE.AVAILABLE_MONEY = :AVAILABLE_MONEY");
				param = new OracleParameter();
				param.ParameterName =":AVAILABLE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AVAILABLE_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("AVAILABLE_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_D_EXE", "AVAILABLE_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.ITEM_ID))
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID ").Append((cause.ITEM_ID.StartsWith("%") || cause.ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_D_EXE", "ITEM_ID"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_NAME))
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_NAME ").Append((cause.REF_TAB_NAME.StartsWith("%") || cause.REF_TAB_NAME.EndsWith("%")) ? " like " : " = ").Append(" :REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName =":REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_NAME"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_D_EXE", "REF_TAB_NAME"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_CONTROL_D_EXE.CREATE_DATE >= :CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_CONTROL_D_EXE.CREATE_DATE < :CREATE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_D_EXE", "CREATE_DATE"));
			}
			if(cause.APPLY_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_D_EXE.APPLY_MONEY = :APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName =":APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLY_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_D_EXE", "APPLY_MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.REF_TAB_ID))
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_ID ").Append((cause.REF_TAB_ID.StartsWith("%") || cause.REF_TAB_ID.EndsWith("%")) ? " like " : " = ").Append(" :REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName =":REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_TAB_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_D_EXE", "REF_TAB_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_CYCLE))
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_D_EXE.FINANCE_CYCLE ").Append((cause.FINANCE_CYCLE.StartsWith("%") || cause.FINANCE_CYCLE.EndsWith("%")) ? " like " : " = ").Append(" :FINANCE_CYCLE");
				param = new OracleParameter();
				param.ParameterName =":FINANCE_CYCLE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FINANCE_CYCLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_CYCLE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_D_EXE", "FINANCE_CYCLE"));
			}
			if(cause.IS_PASS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS = :IS_PASS");
				param = new OracleParameter();
				param.ParameterName =":IS_PASS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_PASS;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_PASS"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_CONTROL_D_EXE", "IS_PASS"));
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
		public static DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] Query(CauseObject_BGT_B_BUDGET_CONTROL_D_EXE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID, BGT_B_BUDGET_CONTROL_D_EXE.ID, BGT_B_BUDGET_CONTROL_D_EXE.MONEY, BGT_B_BUDGET_CONTROL_D_EXE.BASE_ID, BGT_B_BUDGET_CONTROL_D_EXE.AVAILABLE_MONEY, BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID, BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_NAME, BGT_B_BUDGET_CONTROL_D_EXE.CREATE_DATE, BGT_B_BUDGET_CONTROL_D_EXE.APPLY_MONEY, BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_ID, BGT_B_BUDGET_CONTROL_D_EXE.FINANCE_CYCLE, BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, (case  when BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS = 1 then '是' when BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS = 2 then '否' else '' end ) as IS_PASS_NAME from BGT_B_BUDGET_CONTROL_D_EXE left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PASS = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_PASS_NAME = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] objs = new DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_BUDGET_CONTROL_D_EXE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_BUDGET_CONTROL_D_EXE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] Query(CauseObject_BGT_B_BUDGET_CONTROL_D_EXE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID, BGT_B_BUDGET_CONTROL_D_EXE.ID, BGT_B_BUDGET_CONTROL_D_EXE.MONEY, BGT_B_BUDGET_CONTROL_D_EXE.BASE_ID, BGT_B_BUDGET_CONTROL_D_EXE.AVAILABLE_MONEY, BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID, BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_NAME, BGT_B_BUDGET_CONTROL_D_EXE.CREATE_DATE, BGT_B_BUDGET_CONTROL_D_EXE.APPLY_MONEY, BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_ID, BGT_B_BUDGET_CONTROL_D_EXE.FINANCE_CYCLE, BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, (case  when BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS = 1 then '是' when BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS = 2 then '否' else '' end ) as IS_PASS_NAME from BGT_B_BUDGET_CONTROL_D_EXE left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PASS = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_PASS_NAME = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] objs = new DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] Query(CauseObject_BGT_B_BUDGET_CONTROL_D_EXE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID, BGT_B_BUDGET_CONTROL_D_EXE.ID, BGT_B_BUDGET_CONTROL_D_EXE.MONEY, BGT_B_BUDGET_CONTROL_D_EXE.BASE_ID, BGT_B_BUDGET_CONTROL_D_EXE.AVAILABLE_MONEY, BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID, BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_NAME, BGT_B_BUDGET_CONTROL_D_EXE.CREATE_DATE, BGT_B_BUDGET_CONTROL_D_EXE.APPLY_MONEY, BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_ID, BGT_B_BUDGET_CONTROL_D_EXE.FINANCE_CYCLE, BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, (case  when BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS = 1 then '是' when BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS = 2 then '否' else '' end ) as IS_PASS_NAME from BGT_B_BUDGET_CONTROL_D_EXE left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_BUDGET_CONTROL_D_EXE",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PASS = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_PASS_NAME = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] objs = new DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] Query(CauseObject_BGT_B_BUDGET_CONTROL_D_EXE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID, BGT_B_BUDGET_CONTROL_D_EXE.ID, BGT_B_BUDGET_CONTROL_D_EXE.MONEY, BGT_B_BUDGET_CONTROL_D_EXE.BASE_ID, BGT_B_BUDGET_CONTROL_D_EXE.AVAILABLE_MONEY, BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID, BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_NAME, BGT_B_BUDGET_CONTROL_D_EXE.CREATE_DATE, BGT_B_BUDGET_CONTROL_D_EXE.APPLY_MONEY, BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_ID, BGT_B_BUDGET_CONTROL_D_EXE.FINANCE_CYCLE, BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS, BGT_D_BUDGET_DEPT_BUDGET_DEPT_.NAME as BUDGET_DEPT_ID_NAME, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, (case  when BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS = 1 then '是' when BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS = 2 then '否' else '' end ) as IS_PASS_NAME from BGT_B_BUDGET_CONTROL_D_EXE left join BGT_D_BUDGET_DEPT   BGT_D_BUDGET_DEPT_BUDGET_DEPT_ on BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID = BGT_D_BUDGET_DEPT_BUDGET_DEPT_.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_BUDGET_CONTROL_D_EXE",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BUDGET_DEPT_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ITEM_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FINANCE_CYCLE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_PASS = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BUDGET_DEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_PASS_NAME = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[] objs = new DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_BUDGET_CONTROL_D_EXE obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("BUDGET_DEPT_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID = :BUDGET_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_DEPT_ID) ? string.Empty : obj.BUDGET_DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_D_EXE.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName = ":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_D_EXE.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AVAILABLE_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_D_EXE.AVAILABLE_MONEY = :AVAILABLE_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":AVAILABLE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AVAILABLE_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID = :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_ID) ? string.Empty : obj.ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_NAME"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_NAME = :REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName = ":REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_NAME) ? string.Empty : obj.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_D_EXE.CREATE_DATE = :CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_D_EXE.APPLY_MONEY = :APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.APPLY_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_D_EXE.REF_TAB_ID = :REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName = ":REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_ID) ? string.Empty : obj.REF_TAB_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_CYCLE"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_D_EXE.FINANCE_CYCLE = :FINANCE_CYCLE");
				param = new OracleParameter();
				param.ParameterName = ":FINANCE_CYCLE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_CYCLE) ? string.Empty : obj.FINANCE_CYCLE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_PASS"))
			{
				strBuf.Add("  BGT_B_BUDGET_CONTROL_D_EXE.IS_PASS = :IS_PASS");
				param = new OracleParameter();
				param.ParameterName = ":IS_PASS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_PASS;
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
