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
	[CauseObject(typeof(CauseObject_BGT_B_BUDGET_PROJ_EXE_D))]
	public partial class HelperObject_BGT_B_BUDGET_PROJ_EXE_D
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_BUDGET_PROJ_EXE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_B_BUDGET_PROJ_EXE_D( EXECUTE_MONEY, BASE_ID, EXECUTE_DATE, ID, ITEM_ID, INVOICE_CODE, APPLY_MONEY, APPLY_DATE, APPLY_USER_ID, EXECUTE_MONTH_ID) values ( :EXECUTE_MONEY, :BASE_ID, :EXECUTE_DATE, :ID, :ITEM_ID, :INVOICE_CODE, :APPLY_MONEY, :APPLY_DATE, :APPLY_USER_ID, :EXECUTE_MONTH_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[10];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":EXECUTE_MONEY";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.EXECUTE_MONEY;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":BASE_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":EXECUTE_DATE";
			parameters[2].Size = 7;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[2].Value = obj.EXECUTE_DATE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ITEM_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ITEM_ID == null ? String.Empty:obj.ITEM_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":INVOICE_CODE";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.INVOICE_CODE == null ? String.Empty:obj.INVOICE_CODE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":APPLY_MONEY";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.APPLY_MONEY;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":APPLY_DATE";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.APPLY_DATE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":APPLY_USER_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.APPLY_USER_ID == null ? String.Empty:obj.APPLY_USER_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":EXECUTE_MONTH_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.EXECUTE_MONTH_ID == null ? String.Empty:obj.EXECUTE_MONTH_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_BUDGET_PROJ_EXE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_BUDGET_PROJ_EXE_D set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_BUDGET_PROJ_EXE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_BUDGET_PROJ_EXE_D where  ID = :ID ";
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
		public static EntityObject_BGT_B_BUDGET_PROJ_EXE_D Get(EntityObject_BGT_B_BUDGET_PROJ_EXE_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  EXECUTE_MONEY, BASE_ID, EXECUTE_DATE, ID, ITEM_ID, INVOICE_CODE, APPLY_MONEY, APPLY_DATE, APPLY_USER_ID, EXECUTE_MONTH_ID from BGT_B_BUDGET_PROJ_EXE_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_BUDGET_PROJ_EXE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_BUDGET_PROJ_EXE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXECUTE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EXECUTE_MONTH_ID = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_BUDGET_PROJ_EXE_D[] objs = new EntityObject_BGT_B_BUDGET_PROJ_EXE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_BUDGET_PROJ_EXE_D Get(EntityObject_BGT_B_BUDGET_PROJ_EXE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  EXECUTE_MONEY, BASE_ID, EXECUTE_DATE, ID, ITEM_ID, INVOICE_CODE, APPLY_MONEY, APPLY_DATE, APPLY_USER_ID, EXECUTE_MONTH_ID from BGT_B_BUDGET_PROJ_EXE_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_BUDGET_PROJ_EXE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_BUDGET_PROJ_EXE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXECUTE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EXECUTE_MONTH_ID = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_BUDGET_PROJ_EXE_D[] objs = new EntityObject_BGT_B_BUDGET_PROJ_EXE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONEY, BGT_B_BUDGET_PROJ_EXE_D.BASE_ID, BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_DATE, BGT_B_BUDGET_PROJ_EXE_D.ID, BGT_B_BUDGET_PROJ_EXE_D.ITEM_ID, BGT_B_BUDGET_PROJ_EXE_D.INVOICE_CODE, BGT_B_BUDGET_PROJ_EXE_D.APPLY_MONEY, BGT_B_BUDGET_PROJ_EXE_D.APPLY_DATE, BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID, BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONTH_ID, BGT_B_BUDGET_PROJ_D_ITEM_ID.NAME as ITEM_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, BGT_D_BUDGET_MONTH_EXECUTE_MON.BUDGET_MONTH as EXECUTE_MONTH_ID_NAME from BGT_B_BUDGET_PROJ_EXE_D left join BGT_B_BUDGET_PROJ_D   BGT_B_BUDGET_PROJ_D_ITEM_ID on BGT_B_BUDGET_PROJ_EXE_D.ITEM_ID = BGT_B_BUDGET_PROJ_D_ITEM_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join BGT_D_BUDGET_MONTH   BGT_D_BUDGET_MONTH_EXECUTE_MON on BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONTH_ID = BGT_D_BUDGET_MONTH_EXECUTE_MON.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_BUDGET_PROJ_EXE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ_EXE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXECUTE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EXECUTE_MONTH_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.EXECUTE_MONTH_ID_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[] objs = new DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_BUDGET_PROJ_EXE_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.EXECUTE_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONEY = :EXECUTE_MONEY");
				param = new OracleParameter();
				param.ParameterName =":EXECUTE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.EXECUTE_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("EXECUTE_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_EXE_D", "EXECUTE_MONEY"));
			}
			if(cause.BASE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_EXE_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_EXE_D", "BASE_ID"));
			}
			if(cause.EXECUTE_DATE!= null)
			{
				if (cause.EXECUTE_DATE.Begin != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_DATE >= :EXECUTE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":EXECUTE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.EXECUTE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.EXECUTE_DATE.End != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_DATE < :EXECUTE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":EXECUTE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.EXECUTE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("EXECUTE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_EXE_D", "EXECUTE_DATE"));
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_EXE_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_EXE_D", "ID"));
			}
			if(cause.ITEM_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_EXE_D.ITEM_ID ").Append((cause.ITEM_ID.StartsWith("%") || cause.ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_EXE_D", "ITEM_ID"));
			}
			if(cause.INVOICE_CODE!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_EXE_D.INVOICE_CODE ").Append((cause.INVOICE_CODE.StartsWith("%") || cause.INVOICE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :INVOICE_CODE");
				param = new OracleParameter();
				param.ParameterName =":INVOICE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.INVOICE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("INVOICE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_EXE_D", "INVOICE_CODE"));
			}
			if(cause.APPLY_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_EXE_D.APPLY_MONEY = :APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName =":APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLY_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_EXE_D", "APPLY_MONEY"));
			}
			if(cause.APPLY_DATE!= null)
			{
				if (cause.APPLY_DATE.Begin != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ_EXE_D.APPLY_DATE >= :APPLY_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":APPLY_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.APPLY_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.APPLY_DATE.End != null)
				{
					strBuf.Append(" And BGT_B_BUDGET_PROJ_EXE_D.APPLY_DATE < :APPLY_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":APPLY_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.APPLY_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("APPLY_DATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_EXE_D", "APPLY_DATE"));
			}
			if(cause.APPLY_USER_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID ").Append((cause.APPLY_USER_ID.StartsWith("%") || cause.APPLY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_EXE_D", "APPLY_USER_ID"));
			}
			if(cause.EXECUTE_MONTH_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONTH_ID ").Append((cause.EXECUTE_MONTH_ID.StartsWith("%") || cause.EXECUTE_MONTH_ID.EndsWith("%")) ? " like " : " = ").Append(" :EXECUTE_MONTH_ID");
				param = new OracleParameter();
				param.ParameterName =":EXECUTE_MONTH_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.EXECUTE_MONTH_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("EXECUTE_MONTH_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_EXE_D", "EXECUTE_MONTH_ID"));
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
		public static DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[] Query(CauseObject_BGT_B_BUDGET_PROJ_EXE_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONEY, BGT_B_BUDGET_PROJ_EXE_D.BASE_ID, BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_DATE, BGT_B_BUDGET_PROJ_EXE_D.ID, BGT_B_BUDGET_PROJ_EXE_D.ITEM_ID, BGT_B_BUDGET_PROJ_EXE_D.INVOICE_CODE, BGT_B_BUDGET_PROJ_EXE_D.APPLY_MONEY, BGT_B_BUDGET_PROJ_EXE_D.APPLY_DATE, BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID, BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONTH_ID, BGT_B_BUDGET_PROJ_D_ITEM_ID.NAME as ITEM_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, BGT_D_BUDGET_MONTH_EXECUTE_MON.BUDGET_MONTH as EXECUTE_MONTH_ID_NAME from BGT_B_BUDGET_PROJ_EXE_D left join BGT_B_BUDGET_PROJ_D   BGT_B_BUDGET_PROJ_D_ITEM_ID on BGT_B_BUDGET_PROJ_EXE_D.ITEM_ID = BGT_B_BUDGET_PROJ_D_ITEM_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join BGT_D_BUDGET_MONTH   BGT_D_BUDGET_MONTH_EXECUTE_MON on BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONTH_ID = BGT_D_BUDGET_MONTH_EXECUTE_MON.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_BUDGET_PROJ_EXE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ_EXE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXECUTE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EXECUTE_MONTH_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.EXECUTE_MONTH_ID_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[] objs = new DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_BUDGET_PROJ_EXE_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_BUDGET_PROJ_EXE_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[] Query(CauseObject_BGT_B_BUDGET_PROJ_EXE_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONEY, BGT_B_BUDGET_PROJ_EXE_D.BASE_ID, BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_DATE, BGT_B_BUDGET_PROJ_EXE_D.ID, BGT_B_BUDGET_PROJ_EXE_D.ITEM_ID, BGT_B_BUDGET_PROJ_EXE_D.INVOICE_CODE, BGT_B_BUDGET_PROJ_EXE_D.APPLY_MONEY, BGT_B_BUDGET_PROJ_EXE_D.APPLY_DATE, BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID, BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONTH_ID, BGT_B_BUDGET_PROJ_D_ITEM_ID.NAME as ITEM_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, BGT_D_BUDGET_MONTH_EXECUTE_MON.BUDGET_MONTH as EXECUTE_MONTH_ID_NAME from BGT_B_BUDGET_PROJ_EXE_D left join BGT_B_BUDGET_PROJ_D   BGT_B_BUDGET_PROJ_D_ITEM_ID on BGT_B_BUDGET_PROJ_EXE_D.ITEM_ID = BGT_B_BUDGET_PROJ_D_ITEM_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join BGT_D_BUDGET_MONTH   BGT_D_BUDGET_MONTH_EXECUTE_MON on BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONTH_ID = BGT_D_BUDGET_MONTH_EXECUTE_MON.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_BUDGET_PROJ_EXE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ_EXE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXECUTE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EXECUTE_MONTH_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.EXECUTE_MONTH_ID_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[] objs = new DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[] Query(CauseObject_BGT_B_BUDGET_PROJ_EXE_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONEY, BGT_B_BUDGET_PROJ_EXE_D.BASE_ID, BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_DATE, BGT_B_BUDGET_PROJ_EXE_D.ID, BGT_B_BUDGET_PROJ_EXE_D.ITEM_ID, BGT_B_BUDGET_PROJ_EXE_D.INVOICE_CODE, BGT_B_BUDGET_PROJ_EXE_D.APPLY_MONEY, BGT_B_BUDGET_PROJ_EXE_D.APPLY_DATE, BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID, BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONTH_ID, BGT_B_BUDGET_PROJ_D_ITEM_ID.NAME as ITEM_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, BGT_D_BUDGET_MONTH_EXECUTE_MON.BUDGET_MONTH as EXECUTE_MONTH_ID_NAME from BGT_B_BUDGET_PROJ_EXE_D left join BGT_B_BUDGET_PROJ_D   BGT_B_BUDGET_PROJ_D_ITEM_ID on BGT_B_BUDGET_PROJ_EXE_D.ITEM_ID = BGT_B_BUDGET_PROJ_D_ITEM_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join BGT_D_BUDGET_MONTH   BGT_D_BUDGET_MONTH_EXECUTE_MON on BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONTH_ID = BGT_D_BUDGET_MONTH_EXECUTE_MON.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_BUDGET_PROJ_EXE_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_BUDGET_PROJ_EXE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ_EXE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXECUTE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EXECUTE_MONTH_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.EXECUTE_MONTH_ID_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[] objs = new DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[] Query(CauseObject_BGT_B_BUDGET_PROJ_EXE_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONEY, BGT_B_BUDGET_PROJ_EXE_D.BASE_ID, BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_DATE, BGT_B_BUDGET_PROJ_EXE_D.ID, BGT_B_BUDGET_PROJ_EXE_D.ITEM_ID, BGT_B_BUDGET_PROJ_EXE_D.INVOICE_CODE, BGT_B_BUDGET_PROJ_EXE_D.APPLY_MONEY, BGT_B_BUDGET_PROJ_EXE_D.APPLY_DATE, BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID, BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONTH_ID, BGT_B_BUDGET_PROJ_D_ITEM_ID.NAME as ITEM_ID_NAME, COM_USER_APPLY_USER_ID.NAME as APPLY_USER_ID_NAME, BGT_D_BUDGET_MONTH_EXECUTE_MON.BUDGET_MONTH as EXECUTE_MONTH_ID_NAME from BGT_B_BUDGET_PROJ_EXE_D left join BGT_B_BUDGET_PROJ_D   BGT_B_BUDGET_PROJ_D_ITEM_ID on BGT_B_BUDGET_PROJ_EXE_D.ITEM_ID = BGT_B_BUDGET_PROJ_D_ITEM_ID.ID left join COM_USER   COM_USER_APPLY_USER_ID on BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID = COM_USER_APPLY_USER_ID.ID left join BGT_D_BUDGET_MONTH   BGT_D_BUDGET_MONTH_EXECUTE_MON on BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONTH_ID = BGT_D_BUDGET_MONTH_EXECUTE_MON.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_BUDGET_PROJ_EXE_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_BUDGET_PROJ_EXE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ_EXE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.EXECUTE_MONEY = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.EXECUTE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ITEM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.INVOICE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.APPLY_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_USER_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.EXECUTE_MONTH_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.APPLY_USER_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.EXECUTE_MONTH_ID_NAME = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[] objs = new DisplayObject_BGT_B_BUDGET_PROJ_EXE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_BUDGET_PROJ_EXE_D obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("EXECUTE_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONEY = :EXECUTE_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":EXECUTE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.EXECUTE_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_EXE_D.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EXECUTE_DATE"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_DATE = :EXECUTE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":EXECUTE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.EXECUTE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_EXE_D.ITEM_ID = :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_ID) ? string.Empty : obj.ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INVOICE_CODE"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_EXE_D.INVOICE_CODE = :INVOICE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":INVOICE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.INVOICE_CODE) ? string.Empty : obj.INVOICE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_EXE_D.APPLY_MONEY = :APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.APPLY_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_DATE"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_EXE_D.APPLY_DATE = :APPLY_DATE");
				param = new OracleParameter();
				param.ParameterName = ":APPLY_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.APPLY_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_USER_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_EXE_D.APPLY_USER_ID = :APPLY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":APPLY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_USER_ID) ? string.Empty : obj.APPLY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EXECUTE_MONTH_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_EXE_D.EXECUTE_MONTH_ID = :EXECUTE_MONTH_ID");
				param = new OracleParameter();
				param.ParameterName = ":EXECUTE_MONTH_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.EXECUTE_MONTH_ID) ? string.Empty : obj.EXECUTE_MONTH_ID;
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
