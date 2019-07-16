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
	[CauseObject(typeof(CauseObject_BGT_B_BUDGET_PROJ_D))]
	public partial class HelperObject_BGT_B_BUDGET_PROJ_D
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_BUDGET_PROJ_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_B_BUDGET_PROJ_D( CODE, EXECUTED_MONEY, BASE_ID, SOURCE_ID, AVAILABLE_MONEY, REPLY_MONEY, NAME, ITEM_ID, ADJUST_MONEY, APPLY_MONEY, IS_GOV_PROC, ADJUST_TYPE_ID, ID, APPLIED_MONEY, BUDEGT_MONEY) values ( :CODE, :EXECUTED_MONEY, :BASE_ID, :SOURCE_ID, :AVAILABLE_MONEY, :REPLY_MONEY, :NAME, :ITEM_ID, :ADJUST_MONEY, :APPLY_MONEY, :IS_GOV_PROC, :ADJUST_TYPE_ID, :ID, :APPLIED_MONEY, :BUDEGT_MONEY)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[15];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CODE";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":EXECUTED_MONEY";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.EXECUTED_MONEY;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":BASE_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":SOURCE_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.SOURCE_ID == null ? String.Empty:obj.SOURCE_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":AVAILABLE_MONEY";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.AVAILABLE_MONEY;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":REPLY_MONEY";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.REPLY_MONEY;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":NAME";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ITEM_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.ITEM_ID == null ? String.Empty:obj.ITEM_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":ADJUST_MONEY";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.ADJUST_MONEY;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":APPLY_MONEY";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.APPLY_MONEY;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":IS_GOV_PROC";
			parameters[10].Size = 22;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[10].Value = obj.IS_GOV_PROC;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":ADJUST_TYPE_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.ADJUST_TYPE_ID == null ? String.Empty:obj.ADJUST_TYPE_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":APPLIED_MONEY";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.APPLIED_MONEY;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":BUDEGT_MONEY";
			parameters[14].Size = 22;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[14].Value = obj.BUDEGT_MONEY;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_BUDGET_PROJ_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_BUDGET_PROJ_D set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_BUDGET_PROJ_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_BUDGET_PROJ_D where  ID = :ID ";
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
		public static EntityObject_BGT_B_BUDGET_PROJ_D Get(EntityObject_BGT_B_BUDGET_PROJ_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CODE, EXECUTED_MONEY, BASE_ID, SOURCE_ID, AVAILABLE_MONEY, REPLY_MONEY, NAME, ITEM_ID, ADJUST_MONEY, APPLY_MONEY, IS_GOV_PROC, ADJUST_TYPE_ID, ID, APPLIED_MONEY, BUDEGT_MONEY from BGT_B_BUDGET_PROJ_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_BUDGET_PROJ_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_BUDGET_PROJ_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SOURCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADJUST_TYPE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BUDEGT_MONEY = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_BUDGET_PROJ_D[] objs = new EntityObject_BGT_B_BUDGET_PROJ_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_BUDGET_PROJ_D Get(EntityObject_BGT_B_BUDGET_PROJ_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CODE, EXECUTED_MONEY, BASE_ID, SOURCE_ID, AVAILABLE_MONEY, REPLY_MONEY, NAME, ITEM_ID, ADJUST_MONEY, APPLY_MONEY, IS_GOV_PROC, ADJUST_TYPE_ID, ID, APPLIED_MONEY, BUDEGT_MONEY from BGT_B_BUDGET_PROJ_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_BUDGET_PROJ_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_BUDGET_PROJ_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SOURCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADJUST_TYPE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BUDEGT_MONEY = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_BUDGET_PROJ_D[] objs = new EntityObject_BGT_B_BUDGET_PROJ_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_BUDGET_PROJ_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_BUDGET_PROJ_D.CODE, BGT_B_BUDGET_PROJ_D.EXECUTED_MONEY, BGT_B_BUDGET_PROJ_D.BASE_ID, BGT_B_BUDGET_PROJ_D.SOURCE_ID, BGT_B_BUDGET_PROJ_D.AVAILABLE_MONEY, BGT_B_BUDGET_PROJ_D.REPLY_MONEY, BGT_B_BUDGET_PROJ_D.NAME, BGT_B_BUDGET_PROJ_D.ITEM_ID, BGT_B_BUDGET_PROJ_D.ADJUST_MONEY, BGT_B_BUDGET_PROJ_D.APPLY_MONEY, BGT_B_BUDGET_PROJ_D.IS_GOV_PROC, BGT_B_BUDGET_PROJ_D.ADJUST_TYPE_ID, BGT_B_BUDGET_PROJ_D.ID, BGT_B_BUDGET_PROJ_D.APPLIED_MONEY, BGT_B_BUDGET_PROJ_D.BUDEGT_MONEY, BILL_WORK_FLOW_BASE_ID.ID as BASE_ID_NAME, COM_TYPE_SOURCE_ID.NAME as SOURCE_ID_NAME, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, (case  when BGT_B_BUDGET_PROJ_D.IS_GOV_PROC = 1 then '是' when BGT_B_BUDGET_PROJ_D.IS_GOV_PROC = 2 then '否' else '' end ) as IS_GOV_PROC_NAME, COM_TYPE_ADJUST_TYPE_ID.NAME as ADJUST_TYPE_ID_NAME from BGT_B_BUDGET_PROJ_D left join BILL_WORK_FLOW   BILL_WORK_FLOW_BASE_ID on BGT_B_BUDGET_PROJ_D.BASE_ID = BILL_WORK_FLOW_BASE_ID.ID left join COM_TYPE   COM_TYPE_SOURCE_ID on BGT_B_BUDGET_PROJ_D.SOURCE_ID = COM_TYPE_SOURCE_ID.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on BGT_B_BUDGET_PROJ_D.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID left join COM_TYPE   COM_TYPE_ADJUST_TYPE_ID on BGT_B_BUDGET_PROJ_D.ADJUST_TYPE_ID = COM_TYPE_ADJUST_TYPE_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_BUDGET_PROJ_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SOURCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADJUST_TYPE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BUDEGT_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SOURCE_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_GOV_PROC_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ADJUST_TYPE_ID_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ_D[] objs = new DisplayObject_BGT_B_BUDGET_PROJ_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_BUDGET_PROJ_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.CODE!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "CODE"));
			}
			if(cause.EXECUTED_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.EXECUTED_MONEY = :EXECUTED_MONEY");
				param = new OracleParameter();
				param.ParameterName =":EXECUTED_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.EXECUTED_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("EXECUTED_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "EXECUTED_MONEY"));
			}
			if(cause.BASE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "BASE_ID"));
			}
			if(cause.SOURCE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.SOURCE_ID ").Append((cause.SOURCE_ID.StartsWith("%") || cause.SOURCE_ID.EndsWith("%")) ? " like " : " = ").Append(" :SOURCE_ID");
				param = new OracleParameter();
				param.ParameterName =":SOURCE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SOURCE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("SOURCE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "SOURCE_ID"));
			}
			if(cause.AVAILABLE_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.AVAILABLE_MONEY = :AVAILABLE_MONEY");
				param = new OracleParameter();
				param.ParameterName =":AVAILABLE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AVAILABLE_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("AVAILABLE_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "AVAILABLE_MONEY"));
			}
			if(cause.REPLY_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.REPLY_MONEY = :REPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName =":REPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REPLY_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("REPLY_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "REPLY_MONEY"));
			}
			if(cause.NAME!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "NAME"));
			}
			if(cause.ITEM_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.ITEM_ID ").Append((cause.ITEM_ID.StartsWith("%") || cause.ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "ITEM_ID"));
			}
			if(cause.ADJUST_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.ADJUST_MONEY = :ADJUST_MONEY");
				param = new OracleParameter();
				param.ParameterName =":ADJUST_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ADJUST_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADJUST_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "ADJUST_MONEY"));
			}
			if(cause.APPLY_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.APPLY_MONEY = :APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName =":APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLY_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "APPLY_MONEY"));
			}
			if(cause.IS_GOV_PROC!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.IS_GOV_PROC = :IS_GOV_PROC");
				param = new OracleParameter();
				param.ParameterName =":IS_GOV_PROC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_GOV_PROC;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_GOV_PROC"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "IS_GOV_PROC"));
			}
			if(cause.ADJUST_TYPE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.ADJUST_TYPE_ID ").Append((cause.ADJUST_TYPE_ID.StartsWith("%") || cause.ADJUST_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :ADJUST_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":ADJUST_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ADJUST_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADJUST_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "ADJUST_TYPE_ID"));
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "ID"));
			}
			if(cause.APPLIED_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.APPLIED_MONEY = :APPLIED_MONEY");
				param = new OracleParameter();
				param.ParameterName =":APPLIED_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLIED_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLIED_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "APPLIED_MONEY"));
			}
			if(cause.BUDEGT_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_BUDGET_PROJ_D.BUDEGT_MONEY = :BUDEGT_MONEY");
				param = new OracleParameter();
				param.ParameterName =":BUDEGT_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.BUDEGT_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDEGT_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_BUDGET_PROJ_D", "BUDEGT_MONEY"));
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
		public static DisplayObject_BGT_B_BUDGET_PROJ_D[] Query(CauseObject_BGT_B_BUDGET_PROJ_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_PROJ_D.CODE, BGT_B_BUDGET_PROJ_D.EXECUTED_MONEY, BGT_B_BUDGET_PROJ_D.BASE_ID, BGT_B_BUDGET_PROJ_D.SOURCE_ID, BGT_B_BUDGET_PROJ_D.AVAILABLE_MONEY, BGT_B_BUDGET_PROJ_D.REPLY_MONEY, BGT_B_BUDGET_PROJ_D.NAME, BGT_B_BUDGET_PROJ_D.ITEM_ID, BGT_B_BUDGET_PROJ_D.ADJUST_MONEY, BGT_B_BUDGET_PROJ_D.APPLY_MONEY, BGT_B_BUDGET_PROJ_D.IS_GOV_PROC, BGT_B_BUDGET_PROJ_D.ADJUST_TYPE_ID, BGT_B_BUDGET_PROJ_D.ID, BGT_B_BUDGET_PROJ_D.APPLIED_MONEY, BGT_B_BUDGET_PROJ_D.BUDEGT_MONEY, BILL_WORK_FLOW_BASE_ID.ID as BASE_ID_NAME, COM_TYPE_SOURCE_ID.NAME as SOURCE_ID_NAME, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, (case  when BGT_B_BUDGET_PROJ_D.IS_GOV_PROC = 1 then '是' when BGT_B_BUDGET_PROJ_D.IS_GOV_PROC = 2 then '否' else '' end ) as IS_GOV_PROC_NAME, COM_TYPE_ADJUST_TYPE_ID.NAME as ADJUST_TYPE_ID_NAME from BGT_B_BUDGET_PROJ_D left join BILL_WORK_FLOW   BILL_WORK_FLOW_BASE_ID on BGT_B_BUDGET_PROJ_D.BASE_ID = BILL_WORK_FLOW_BASE_ID.ID left join COM_TYPE   COM_TYPE_SOURCE_ID on BGT_B_BUDGET_PROJ_D.SOURCE_ID = COM_TYPE_SOURCE_ID.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on BGT_B_BUDGET_PROJ_D.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID left join COM_TYPE   COM_TYPE_ADJUST_TYPE_ID on BGT_B_BUDGET_PROJ_D.ADJUST_TYPE_ID = COM_TYPE_ADJUST_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_BUDGET_PROJ_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SOURCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADJUST_TYPE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BUDEGT_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SOURCE_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_GOV_PROC_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ADJUST_TYPE_ID_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ_D[] objs = new DisplayObject_BGT_B_BUDGET_PROJ_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_BUDGET_PROJ_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_BUDGET_PROJ_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_BUDGET_PROJ_D[] Query(CauseObject_BGT_B_BUDGET_PROJ_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_PROJ_D.CODE, BGT_B_BUDGET_PROJ_D.EXECUTED_MONEY, BGT_B_BUDGET_PROJ_D.BASE_ID, BGT_B_BUDGET_PROJ_D.SOURCE_ID, BGT_B_BUDGET_PROJ_D.AVAILABLE_MONEY, BGT_B_BUDGET_PROJ_D.REPLY_MONEY, BGT_B_BUDGET_PROJ_D.NAME, BGT_B_BUDGET_PROJ_D.ITEM_ID, BGT_B_BUDGET_PROJ_D.ADJUST_MONEY, BGT_B_BUDGET_PROJ_D.APPLY_MONEY, BGT_B_BUDGET_PROJ_D.IS_GOV_PROC, BGT_B_BUDGET_PROJ_D.ADJUST_TYPE_ID, BGT_B_BUDGET_PROJ_D.ID, BGT_B_BUDGET_PROJ_D.APPLIED_MONEY, BGT_B_BUDGET_PROJ_D.BUDEGT_MONEY, BILL_WORK_FLOW_BASE_ID.ID as BASE_ID_NAME, COM_TYPE_SOURCE_ID.NAME as SOURCE_ID_NAME, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, (case  when BGT_B_BUDGET_PROJ_D.IS_GOV_PROC = 1 then '是' when BGT_B_BUDGET_PROJ_D.IS_GOV_PROC = 2 then '否' else '' end ) as IS_GOV_PROC_NAME, COM_TYPE_ADJUST_TYPE_ID.NAME as ADJUST_TYPE_ID_NAME from BGT_B_BUDGET_PROJ_D left join BILL_WORK_FLOW   BILL_WORK_FLOW_BASE_ID on BGT_B_BUDGET_PROJ_D.BASE_ID = BILL_WORK_FLOW_BASE_ID.ID left join COM_TYPE   COM_TYPE_SOURCE_ID on BGT_B_BUDGET_PROJ_D.SOURCE_ID = COM_TYPE_SOURCE_ID.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on BGT_B_BUDGET_PROJ_D.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID left join COM_TYPE   COM_TYPE_ADJUST_TYPE_ID on BGT_B_BUDGET_PROJ_D.ADJUST_TYPE_ID = COM_TYPE_ADJUST_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_BUDGET_PROJ_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SOURCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADJUST_TYPE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BUDEGT_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SOURCE_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_GOV_PROC_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ADJUST_TYPE_ID_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ_D[] objs = new DisplayObject_BGT_B_BUDGET_PROJ_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_BUDGET_PROJ_D[] Query(CauseObject_BGT_B_BUDGET_PROJ_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_PROJ_D.CODE, BGT_B_BUDGET_PROJ_D.EXECUTED_MONEY, BGT_B_BUDGET_PROJ_D.BASE_ID, BGT_B_BUDGET_PROJ_D.SOURCE_ID, BGT_B_BUDGET_PROJ_D.AVAILABLE_MONEY, BGT_B_BUDGET_PROJ_D.REPLY_MONEY, BGT_B_BUDGET_PROJ_D.NAME, BGT_B_BUDGET_PROJ_D.ITEM_ID, BGT_B_BUDGET_PROJ_D.ADJUST_MONEY, BGT_B_BUDGET_PROJ_D.APPLY_MONEY, BGT_B_BUDGET_PROJ_D.IS_GOV_PROC, BGT_B_BUDGET_PROJ_D.ADJUST_TYPE_ID, BGT_B_BUDGET_PROJ_D.ID, BGT_B_BUDGET_PROJ_D.APPLIED_MONEY, BGT_B_BUDGET_PROJ_D.BUDEGT_MONEY, BILL_WORK_FLOW_BASE_ID.ID as BASE_ID_NAME, COM_TYPE_SOURCE_ID.NAME as SOURCE_ID_NAME, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, (case  when BGT_B_BUDGET_PROJ_D.IS_GOV_PROC = 1 then '是' when BGT_B_BUDGET_PROJ_D.IS_GOV_PROC = 2 then '否' else '' end ) as IS_GOV_PROC_NAME, COM_TYPE_ADJUST_TYPE_ID.NAME as ADJUST_TYPE_ID_NAME from BGT_B_BUDGET_PROJ_D left join BILL_WORK_FLOW   BILL_WORK_FLOW_BASE_ID on BGT_B_BUDGET_PROJ_D.BASE_ID = BILL_WORK_FLOW_BASE_ID.ID left join COM_TYPE   COM_TYPE_SOURCE_ID on BGT_B_BUDGET_PROJ_D.SOURCE_ID = COM_TYPE_SOURCE_ID.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on BGT_B_BUDGET_PROJ_D.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID left join COM_TYPE   COM_TYPE_ADJUST_TYPE_ID on BGT_B_BUDGET_PROJ_D.ADJUST_TYPE_ID = COM_TYPE_ADJUST_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_BUDGET_PROJ_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_BUDGET_PROJ_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SOURCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADJUST_TYPE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BUDEGT_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SOURCE_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_GOV_PROC_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ADJUST_TYPE_ID_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ_D[] objs = new DisplayObject_BGT_B_BUDGET_PROJ_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_BUDGET_PROJ_D[] Query(CauseObject_BGT_B_BUDGET_PROJ_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_BUDGET_PROJ_D.CODE, BGT_B_BUDGET_PROJ_D.EXECUTED_MONEY, BGT_B_BUDGET_PROJ_D.BASE_ID, BGT_B_BUDGET_PROJ_D.SOURCE_ID, BGT_B_BUDGET_PROJ_D.AVAILABLE_MONEY, BGT_B_BUDGET_PROJ_D.REPLY_MONEY, BGT_B_BUDGET_PROJ_D.NAME, BGT_B_BUDGET_PROJ_D.ITEM_ID, BGT_B_BUDGET_PROJ_D.ADJUST_MONEY, BGT_B_BUDGET_PROJ_D.APPLY_MONEY, BGT_B_BUDGET_PROJ_D.IS_GOV_PROC, BGT_B_BUDGET_PROJ_D.ADJUST_TYPE_ID, BGT_B_BUDGET_PROJ_D.ID, BGT_B_BUDGET_PROJ_D.APPLIED_MONEY, BGT_B_BUDGET_PROJ_D.BUDEGT_MONEY, BILL_WORK_FLOW_BASE_ID.ID as BASE_ID_NAME, COM_TYPE_SOURCE_ID.NAME as SOURCE_ID_NAME, BGT_D_BUDGET_ITEM_ITEM_ID.NAME as ITEM_ID_NAME, (case  when BGT_B_BUDGET_PROJ_D.IS_GOV_PROC = 1 then '是' when BGT_B_BUDGET_PROJ_D.IS_GOV_PROC = 2 then '否' else '' end ) as IS_GOV_PROC_NAME, COM_TYPE_ADJUST_TYPE_ID.NAME as ADJUST_TYPE_ID_NAME from BGT_B_BUDGET_PROJ_D left join BILL_WORK_FLOW   BILL_WORK_FLOW_BASE_ID on BGT_B_BUDGET_PROJ_D.BASE_ID = BILL_WORK_FLOW_BASE_ID.ID left join COM_TYPE   COM_TYPE_SOURCE_ID on BGT_B_BUDGET_PROJ_D.SOURCE_ID = COM_TYPE_SOURCE_ID.ID left join BGT_D_BUDGET_ITEM   BGT_D_BUDGET_ITEM_ITEM_ID on BGT_B_BUDGET_PROJ_D.ITEM_ID = BGT_D_BUDGET_ITEM_ITEM_ID.ID left join COM_TYPE   COM_TYPE_ADJUST_TYPE_ID on BGT_B_BUDGET_PROJ_D.ADJUST_TYPE_ID = COM_TYPE_ADJUST_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_BUDGET_PROJ_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_BUDGET_PROJ_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_BUDGET_PROJ_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.EXECUTED_MONEY = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SOURCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.AVAILABLE_MONEY = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REPLY_MONEY = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ADJUST_MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.APPLY_MONEY = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.IS_GOV_PROC = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ADJUST_TYPE_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.APPLIED_MONEY = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BUDEGT_MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BASE_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.SOURCE_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_GOV_PROC_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ADJUST_TYPE_ID_NAME = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_BUDGET_PROJ_D[] objs = new DisplayObject_BGT_B_BUDGET_PROJ_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_BUDGET_PROJ_D obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EXECUTED_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.EXECUTED_MONEY = :EXECUTED_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":EXECUTED_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.EXECUTED_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SOURCE_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.SOURCE_ID = :SOURCE_ID");
				param = new OracleParameter();
				param.ParameterName = ":SOURCE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.SOURCE_ID) ? string.Empty : obj.SOURCE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AVAILABLE_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.AVAILABLE_MONEY = :AVAILABLE_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":AVAILABLE_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AVAILABLE_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REPLY_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.REPLY_MONEY = :REPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":REPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.REPLY_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.ITEM_ID = :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_ID) ? string.Empty : obj.ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ADJUST_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.ADJUST_MONEY = :ADJUST_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":ADJUST_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ADJUST_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.APPLY_MONEY = :APPLY_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":APPLY_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.APPLY_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_GOV_PROC"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.IS_GOV_PROC = :IS_GOV_PROC");
				param = new OracleParameter();
				param.ParameterName = ":IS_GOV_PROC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_GOV_PROC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ADJUST_TYPE_ID"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.ADJUST_TYPE_ID = :ADJUST_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":ADJUST_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ADJUST_TYPE_ID) ? string.Empty : obj.ADJUST_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLIED_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.APPLIED_MONEY = :APPLIED_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":APPLIED_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.APPLIED_MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDEGT_MONEY"))
			{
				strBuf.Add("  BGT_B_BUDGET_PROJ_D.BUDEGT_MONEY = :BUDEGT_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":BUDEGT_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.BUDEGT_MONEY;
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
