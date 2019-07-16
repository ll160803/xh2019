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
	[CauseObject(typeof(CauseObject_BGT_D_FEE_ITEM))]
	public partial class HelperObject_BGT_D_FEE_ITEM
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_D_FEE_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_D_FEE_ITEM( PREPARE_PATTERN_ID, CODE, IMPORT_TYPE_ID, IS_CARRYOVER, IS_CALCULATE, ID, IS_DISABLE, ADVICE_CLASSIFY_ID, BUDGET_YEAR, ITEM_CLASSIFY_ID, DATA_TYPE_ID, NAME, ITEM_TYPE_ID, UNIT_ID, SOURCE_TYPE_ID) values ( :PREPARE_PATTERN_ID, :CODE, :IMPORT_TYPE_ID, :IS_CARRYOVER, :IS_CALCULATE, :ID, :IS_DISABLE, :ADVICE_CLASSIFY_ID, :BUDGET_YEAR, :ITEM_CLASSIFY_ID, :DATA_TYPE_ID, :NAME, :ITEM_TYPE_ID, :UNIT_ID, :SOURCE_TYPE_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[15];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":PREPARE_PATTERN_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.PREPARE_PATTERN_ID == null ? String.Empty:obj.PREPARE_PATTERN_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":CODE";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":IMPORT_TYPE_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.IMPORT_TYPE_ID == null ? String.Empty:obj.IMPORT_TYPE_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":IS_CARRYOVER";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.IS_CARRYOVER;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":IS_CALCULATE";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.IS_CALCULATE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":IS_DISABLE";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.IS_DISABLE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ADVICE_CLASSIFY_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.ADVICE_CLASSIFY_ID == null ? String.Empty:obj.ADVICE_CLASSIFY_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":BUDGET_YEAR";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.BUDGET_YEAR == null ? String.Empty:obj.BUDGET_YEAR;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":ITEM_CLASSIFY_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.ITEM_CLASSIFY_ID == null ? String.Empty:obj.ITEM_CLASSIFY_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":DATA_TYPE_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.DATA_TYPE_ID == null ? String.Empty:obj.DATA_TYPE_ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":NAME";
			parameters[11].Size = 50;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":ITEM_TYPE_ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.ITEM_TYPE_ID == null ? String.Empty:obj.ITEM_TYPE_ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":UNIT_ID";
			parameters[13].Size = 36;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.UNIT_ID == null ? String.Empty:obj.UNIT_ID;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":SOURCE_TYPE_ID";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.SOURCE_TYPE_ID == null ? String.Empty:obj.SOURCE_TYPE_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_D_FEE_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_D_FEE_ITEM set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_D_FEE_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_D_FEE_ITEM where  ID = :ID ";
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
		public static EntityObject_BGT_D_FEE_ITEM Get(EntityObject_BGT_D_FEE_ITEM obj)
		{
			
			//平台自动生成代码
			string sSql = "select  PREPARE_PATTERN_ID, CODE, IMPORT_TYPE_ID, IS_CARRYOVER, IS_CALCULATE, ID, IS_DISABLE, ADVICE_CLASSIFY_ID, BUDGET_YEAR, ITEM_CLASSIFY_ID, DATA_TYPE_ID, NAME, ITEM_TYPE_ID, UNIT_ID, SOURCE_TYPE_ID from BGT_D_FEE_ITEM where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_D_FEE_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_D_FEE_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_CALCULATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_DISABLE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADVICE_CLASSIFY_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ITEM_CLASSIFY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.UNIT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SOURCE_TYPE_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_D_FEE_ITEM[] objs = new EntityObject_BGT_D_FEE_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_D_FEE_ITEM Get(EntityObject_BGT_D_FEE_ITEM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  PREPARE_PATTERN_ID, CODE, IMPORT_TYPE_ID, IS_CARRYOVER, IS_CALCULATE, ID, IS_DISABLE, ADVICE_CLASSIFY_ID, BUDGET_YEAR, ITEM_CLASSIFY_ID, DATA_TYPE_ID, NAME, ITEM_TYPE_ID, UNIT_ID, SOURCE_TYPE_ID from BGT_D_FEE_ITEM where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_D_FEE_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_D_FEE_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_CALCULATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_DISABLE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADVICE_CLASSIFY_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ITEM_CLASSIFY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.UNIT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SOURCE_TYPE_ID = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_D_FEE_ITEM[] objs = new EntityObject_BGT_D_FEE_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_D_FEE_ITEM[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_D_FEE_ITEM.PREPARE_PATTERN_ID, BGT_D_FEE_ITEM.CODE, BGT_D_FEE_ITEM.IMPORT_TYPE_ID, BGT_D_FEE_ITEM.IS_CARRYOVER, BGT_D_FEE_ITEM.IS_CALCULATE, BGT_D_FEE_ITEM.ID, BGT_D_FEE_ITEM.IS_DISABLE, BGT_D_FEE_ITEM.ADVICE_CLASSIFY_ID, BGT_D_FEE_ITEM.BUDGET_YEAR, BGT_D_FEE_ITEM.ITEM_CLASSIFY_ID, BGT_D_FEE_ITEM.DATA_TYPE_ID, BGT_D_FEE_ITEM.NAME, BGT_D_FEE_ITEM.ITEM_TYPE_ID, BGT_D_FEE_ITEM.UNIT_ID, BGT_D_FEE_ITEM.SOURCE_TYPE_ID, COM_TYPE_PREPARE_PATTERN_ID.NAME as PREPARE_PATTERN_ID_NAME, COM_TYPE_IMPORT_TYPE_ID.NAME as IMPORT_TYPE_ID_NAME, (case  when BGT_D_FEE_ITEM.IS_CARRYOVER = 1 then '是' when BGT_D_FEE_ITEM.IS_CARRYOVER = 2 then '否' else '' end ) as IS_CARRYOVER_NAME, (case  when BGT_D_FEE_ITEM.IS_CALCULATE = 1 then '是' when BGT_D_FEE_ITEM.IS_CALCULATE = 2 then '否' else '' end ) as IS_CALCULATE_NAME, (case  when BGT_D_FEE_ITEM.IS_DISABLE = 1 then '是' when BGT_D_FEE_ITEM.IS_DISABLE = 2 then '否' else '' end ) as IS_DISABLE_NAME, COM_TYPE_ADVICE_CLASSIFY_ID.NAME as ADVICE_CLASSIFY_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_ITEM_CLASSIFY_ID.NAME as ITEM_CLASSIFY_ID_NAME, COM_TYPE_DATA_TYPE_ID.NAME as DATA_TYPE_ID_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_TYPE_SOURCE_TYPE_ID.NAME as SOURCE_TYPE_ID_NAME from BGT_D_FEE_ITEM left join COM_TYPE   COM_TYPE_PREPARE_PATTERN_ID on BGT_D_FEE_ITEM.PREPARE_PATTERN_ID = COM_TYPE_PREPARE_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_IMPORT_TYPE_ID on BGT_D_FEE_ITEM.IMPORT_TYPE_ID = COM_TYPE_IMPORT_TYPE_ID.ID left join COM_TYPE   COM_TYPE_ADVICE_CLASSIFY_ID on BGT_D_FEE_ITEM.ADVICE_CLASSIFY_ID = COM_TYPE_ADVICE_CLASSIFY_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_FEE_ITEM.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_ITEM_CLASSIFY_ID on BGT_D_FEE_ITEM.ITEM_CLASSIFY_ID = COM_TYPE_ITEM_CLASSIFY_ID.ID left join COM_TYPE   COM_TYPE_DATA_TYPE_ID on BGT_D_FEE_ITEM.DATA_TYPE_ID = COM_TYPE_DATA_TYPE_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_FEE_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on BGT_D_FEE_ITEM.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_TYPE   COM_TYPE_SOURCE_TYPE_ID on BGT_D_FEE_ITEM.SOURCE_TYPE_ID = COM_TYPE_SOURCE_TYPE_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_D_FEE_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_FEE_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_CALCULATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_DISABLE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADVICE_CLASSIFY_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ITEM_CLASSIFY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.UNIT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SOURCE_TYPE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PREPARE_PATTERN_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IMPORT_TYPE_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_CARRYOVER_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_CALCULATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_DISABLE_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ADVICE_CLASSIFY_ID_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ITEM_CLASSIFY_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DATA_TYPE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SOURCE_TYPE_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_FEE_ITEM[] objs = new DisplayObject_BGT_D_FEE_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_D_FEE_ITEM cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.PREPARE_PATTERN_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.PREPARE_PATTERN_ID ").Append((cause.PREPARE_PATTERN_ID.StartsWith("%") || cause.PREPARE_PATTERN_ID.EndsWith("%")) ? " like " : " = ").Append(" :PREPARE_PATTERN_ID");
				param = new OracleParameter();
				param.ParameterName =":PREPARE_PATTERN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PREPARE_PATTERN_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PREPARE_PATTERN_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "PREPARE_PATTERN_ID"));
			}
			if(cause.CODE!= string.Empty)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "CODE"));
			}
			if(cause.IMPORT_TYPE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.IMPORT_TYPE_ID ").Append((cause.IMPORT_TYPE_ID.StartsWith("%") || cause.IMPORT_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :IMPORT_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":IMPORT_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.IMPORT_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("IMPORT_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "IMPORT_TYPE_ID"));
			}
			if(cause.IS_CARRYOVER!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.IS_CARRYOVER = :IS_CARRYOVER");
				param = new OracleParameter();
				param.ParameterName =":IS_CARRYOVER";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_CARRYOVER;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_CARRYOVER"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "IS_CARRYOVER"));
			}
			if(cause.IS_CALCULATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.IS_CALCULATE = :IS_CALCULATE");
				param = new OracleParameter();
				param.ParameterName =":IS_CALCULATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_CALCULATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_CALCULATE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "IS_CALCULATE"));
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "ID"));
			}
			if(cause.IS_DISABLE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.IS_DISABLE = :IS_DISABLE");
				param = new OracleParameter();
				param.ParameterName =":IS_DISABLE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_DISABLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_DISABLE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "IS_DISABLE"));
			}
			if(cause.ADVICE_CLASSIFY_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.ADVICE_CLASSIFY_ID ").Append((cause.ADVICE_CLASSIFY_ID.StartsWith("%") || cause.ADVICE_CLASSIFY_ID.EndsWith("%")) ? " like " : " = ").Append(" :ADVICE_CLASSIFY_ID");
				param = new OracleParameter();
				param.ParameterName =":ADVICE_CLASSIFY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ADVICE_CLASSIFY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ADVICE_CLASSIFY_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "ADVICE_CLASSIFY_ID"));
			}
			if(cause.BUDGET_YEAR!= string.Empty)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName =":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUDGET_YEAR"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "BUDGET_YEAR"));
			}
			if(cause.ITEM_CLASSIFY_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.ITEM_CLASSIFY_ID ").Append((cause.ITEM_CLASSIFY_ID.StartsWith("%") || cause.ITEM_CLASSIFY_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_CLASSIFY_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_CLASSIFY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_CLASSIFY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_CLASSIFY_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "ITEM_CLASSIFY_ID"));
			}
			if(cause.DATA_TYPE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.DATA_TYPE_ID ").Append((cause.DATA_TYPE_ID.StartsWith("%") || cause.DATA_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "DATA_TYPE_ID"));
			}
			if(cause.NAME!= string.Empty)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "NAME"));
			}
			if(cause.ITEM_TYPE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.ITEM_TYPE_ID ").Append((cause.ITEM_TYPE_ID.StartsWith("%") || cause.ITEM_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "ITEM_TYPE_ID"));
			}
			if(cause.UNIT_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.UNIT_ID ").Append((cause.UNIT_ID.StartsWith("%") || cause.UNIT_ID.EndsWith("%")) ? " like " : " = ").Append(" :UNIT_ID");
				param = new OracleParameter();
				param.ParameterName =":UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.UNIT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNIT_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "UNIT_ID"));
			}
			if(cause.SOURCE_TYPE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_D_FEE_ITEM.SOURCE_TYPE_ID ").Append((cause.SOURCE_TYPE_ID.StartsWith("%") || cause.SOURCE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :SOURCE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":SOURCE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SOURCE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("SOURCE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_FEE_ITEM", "SOURCE_TYPE_ID"));
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
		public static DisplayObject_BGT_D_FEE_ITEM[] Query(CauseObject_BGT_D_FEE_ITEM cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_D_FEE_ITEM.PREPARE_PATTERN_ID, BGT_D_FEE_ITEM.CODE, BGT_D_FEE_ITEM.IMPORT_TYPE_ID, BGT_D_FEE_ITEM.IS_CARRYOVER, BGT_D_FEE_ITEM.IS_CALCULATE, BGT_D_FEE_ITEM.ID, BGT_D_FEE_ITEM.IS_DISABLE, BGT_D_FEE_ITEM.ADVICE_CLASSIFY_ID, BGT_D_FEE_ITEM.BUDGET_YEAR, BGT_D_FEE_ITEM.ITEM_CLASSIFY_ID, BGT_D_FEE_ITEM.DATA_TYPE_ID, BGT_D_FEE_ITEM.NAME, BGT_D_FEE_ITEM.ITEM_TYPE_ID, BGT_D_FEE_ITEM.UNIT_ID, BGT_D_FEE_ITEM.SOURCE_TYPE_ID, COM_TYPE_PREPARE_PATTERN_ID.NAME as PREPARE_PATTERN_ID_NAME, COM_TYPE_IMPORT_TYPE_ID.NAME as IMPORT_TYPE_ID_NAME, (case  when BGT_D_FEE_ITEM.IS_CARRYOVER = 1 then '是' when BGT_D_FEE_ITEM.IS_CARRYOVER = 2 then '否' else '' end ) as IS_CARRYOVER_NAME, (case  when BGT_D_FEE_ITEM.IS_CALCULATE = 1 then '是' when BGT_D_FEE_ITEM.IS_CALCULATE = 2 then '否' else '' end ) as IS_CALCULATE_NAME, (case  when BGT_D_FEE_ITEM.IS_DISABLE = 1 then '是' when BGT_D_FEE_ITEM.IS_DISABLE = 2 then '否' else '' end ) as IS_DISABLE_NAME, COM_TYPE_ADVICE_CLASSIFY_ID.NAME as ADVICE_CLASSIFY_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_ITEM_CLASSIFY_ID.NAME as ITEM_CLASSIFY_ID_NAME, COM_TYPE_DATA_TYPE_ID.NAME as DATA_TYPE_ID_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_TYPE_SOURCE_TYPE_ID.NAME as SOURCE_TYPE_ID_NAME from BGT_D_FEE_ITEM left join COM_TYPE   COM_TYPE_PREPARE_PATTERN_ID on BGT_D_FEE_ITEM.PREPARE_PATTERN_ID = COM_TYPE_PREPARE_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_IMPORT_TYPE_ID on BGT_D_FEE_ITEM.IMPORT_TYPE_ID = COM_TYPE_IMPORT_TYPE_ID.ID left join COM_TYPE   COM_TYPE_ADVICE_CLASSIFY_ID on BGT_D_FEE_ITEM.ADVICE_CLASSIFY_ID = COM_TYPE_ADVICE_CLASSIFY_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_FEE_ITEM.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_ITEM_CLASSIFY_ID on BGT_D_FEE_ITEM.ITEM_CLASSIFY_ID = COM_TYPE_ITEM_CLASSIFY_ID.ID left join COM_TYPE   COM_TYPE_DATA_TYPE_ID on BGT_D_FEE_ITEM.DATA_TYPE_ID = COM_TYPE_DATA_TYPE_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_FEE_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on BGT_D_FEE_ITEM.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_TYPE   COM_TYPE_SOURCE_TYPE_ID on BGT_D_FEE_ITEM.SOURCE_TYPE_ID = COM_TYPE_SOURCE_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_D_FEE_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_FEE_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_CALCULATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_DISABLE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADVICE_CLASSIFY_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ITEM_CLASSIFY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.UNIT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SOURCE_TYPE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PREPARE_PATTERN_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IMPORT_TYPE_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_CARRYOVER_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_CALCULATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_DISABLE_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ADVICE_CLASSIFY_ID_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ITEM_CLASSIFY_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DATA_TYPE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SOURCE_TYPE_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_FEE_ITEM[] objs = new DisplayObject_BGT_D_FEE_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_D_FEE_ITEM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_D_FEE_ITEM where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_D_FEE_ITEM[] Query(CauseObject_BGT_D_FEE_ITEM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_D_FEE_ITEM.PREPARE_PATTERN_ID, BGT_D_FEE_ITEM.CODE, BGT_D_FEE_ITEM.IMPORT_TYPE_ID, BGT_D_FEE_ITEM.IS_CARRYOVER, BGT_D_FEE_ITEM.IS_CALCULATE, BGT_D_FEE_ITEM.ID, BGT_D_FEE_ITEM.IS_DISABLE, BGT_D_FEE_ITEM.ADVICE_CLASSIFY_ID, BGT_D_FEE_ITEM.BUDGET_YEAR, BGT_D_FEE_ITEM.ITEM_CLASSIFY_ID, BGT_D_FEE_ITEM.DATA_TYPE_ID, BGT_D_FEE_ITEM.NAME, BGT_D_FEE_ITEM.ITEM_TYPE_ID, BGT_D_FEE_ITEM.UNIT_ID, BGT_D_FEE_ITEM.SOURCE_TYPE_ID, COM_TYPE_PREPARE_PATTERN_ID.NAME as PREPARE_PATTERN_ID_NAME, COM_TYPE_IMPORT_TYPE_ID.NAME as IMPORT_TYPE_ID_NAME, (case  when BGT_D_FEE_ITEM.IS_CARRYOVER = 1 then '是' when BGT_D_FEE_ITEM.IS_CARRYOVER = 2 then '否' else '' end ) as IS_CARRYOVER_NAME, (case  when BGT_D_FEE_ITEM.IS_CALCULATE = 1 then '是' when BGT_D_FEE_ITEM.IS_CALCULATE = 2 then '否' else '' end ) as IS_CALCULATE_NAME, (case  when BGT_D_FEE_ITEM.IS_DISABLE = 1 then '是' when BGT_D_FEE_ITEM.IS_DISABLE = 2 then '否' else '' end ) as IS_DISABLE_NAME, COM_TYPE_ADVICE_CLASSIFY_ID.NAME as ADVICE_CLASSIFY_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_ITEM_CLASSIFY_ID.NAME as ITEM_CLASSIFY_ID_NAME, COM_TYPE_DATA_TYPE_ID.NAME as DATA_TYPE_ID_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_TYPE_SOURCE_TYPE_ID.NAME as SOURCE_TYPE_ID_NAME from BGT_D_FEE_ITEM left join COM_TYPE   COM_TYPE_PREPARE_PATTERN_ID on BGT_D_FEE_ITEM.PREPARE_PATTERN_ID = COM_TYPE_PREPARE_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_IMPORT_TYPE_ID on BGT_D_FEE_ITEM.IMPORT_TYPE_ID = COM_TYPE_IMPORT_TYPE_ID.ID left join COM_TYPE   COM_TYPE_ADVICE_CLASSIFY_ID on BGT_D_FEE_ITEM.ADVICE_CLASSIFY_ID = COM_TYPE_ADVICE_CLASSIFY_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_FEE_ITEM.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_ITEM_CLASSIFY_ID on BGT_D_FEE_ITEM.ITEM_CLASSIFY_ID = COM_TYPE_ITEM_CLASSIFY_ID.ID left join COM_TYPE   COM_TYPE_DATA_TYPE_ID on BGT_D_FEE_ITEM.DATA_TYPE_ID = COM_TYPE_DATA_TYPE_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_FEE_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on BGT_D_FEE_ITEM.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_TYPE   COM_TYPE_SOURCE_TYPE_ID on BGT_D_FEE_ITEM.SOURCE_TYPE_ID = COM_TYPE_SOURCE_TYPE_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_D_FEE_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_FEE_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_CALCULATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_DISABLE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADVICE_CLASSIFY_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ITEM_CLASSIFY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.UNIT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SOURCE_TYPE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PREPARE_PATTERN_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IMPORT_TYPE_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_CARRYOVER_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_CALCULATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_DISABLE_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ADVICE_CLASSIFY_ID_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ITEM_CLASSIFY_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DATA_TYPE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SOURCE_TYPE_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_D_FEE_ITEM[] objs = new DisplayObject_BGT_D_FEE_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_D_FEE_ITEM[] Query(CauseObject_BGT_D_FEE_ITEM cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_D_FEE_ITEM.PREPARE_PATTERN_ID, BGT_D_FEE_ITEM.CODE, BGT_D_FEE_ITEM.IMPORT_TYPE_ID, BGT_D_FEE_ITEM.IS_CARRYOVER, BGT_D_FEE_ITEM.IS_CALCULATE, BGT_D_FEE_ITEM.ID, BGT_D_FEE_ITEM.IS_DISABLE, BGT_D_FEE_ITEM.ADVICE_CLASSIFY_ID, BGT_D_FEE_ITEM.BUDGET_YEAR, BGT_D_FEE_ITEM.ITEM_CLASSIFY_ID, BGT_D_FEE_ITEM.DATA_TYPE_ID, BGT_D_FEE_ITEM.NAME, BGT_D_FEE_ITEM.ITEM_TYPE_ID, BGT_D_FEE_ITEM.UNIT_ID, BGT_D_FEE_ITEM.SOURCE_TYPE_ID, COM_TYPE_PREPARE_PATTERN_ID.NAME as PREPARE_PATTERN_ID_NAME, COM_TYPE_IMPORT_TYPE_ID.NAME as IMPORT_TYPE_ID_NAME, (case  when BGT_D_FEE_ITEM.IS_CARRYOVER = 1 then '是' when BGT_D_FEE_ITEM.IS_CARRYOVER = 2 then '否' else '' end ) as IS_CARRYOVER_NAME, (case  when BGT_D_FEE_ITEM.IS_CALCULATE = 1 then '是' when BGT_D_FEE_ITEM.IS_CALCULATE = 2 then '否' else '' end ) as IS_CALCULATE_NAME, (case  when BGT_D_FEE_ITEM.IS_DISABLE = 1 then '是' when BGT_D_FEE_ITEM.IS_DISABLE = 2 then '否' else '' end ) as IS_DISABLE_NAME, COM_TYPE_ADVICE_CLASSIFY_ID.NAME as ADVICE_CLASSIFY_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_ITEM_CLASSIFY_ID.NAME as ITEM_CLASSIFY_ID_NAME, COM_TYPE_DATA_TYPE_ID.NAME as DATA_TYPE_ID_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_TYPE_SOURCE_TYPE_ID.NAME as SOURCE_TYPE_ID_NAME from BGT_D_FEE_ITEM left join COM_TYPE   COM_TYPE_PREPARE_PATTERN_ID on BGT_D_FEE_ITEM.PREPARE_PATTERN_ID = COM_TYPE_PREPARE_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_IMPORT_TYPE_ID on BGT_D_FEE_ITEM.IMPORT_TYPE_ID = COM_TYPE_IMPORT_TYPE_ID.ID left join COM_TYPE   COM_TYPE_ADVICE_CLASSIFY_ID on BGT_D_FEE_ITEM.ADVICE_CLASSIFY_ID = COM_TYPE_ADVICE_CLASSIFY_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_FEE_ITEM.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_ITEM_CLASSIFY_ID on BGT_D_FEE_ITEM.ITEM_CLASSIFY_ID = COM_TYPE_ITEM_CLASSIFY_ID.ID left join COM_TYPE   COM_TYPE_DATA_TYPE_ID on BGT_D_FEE_ITEM.DATA_TYPE_ID = COM_TYPE_DATA_TYPE_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_FEE_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on BGT_D_FEE_ITEM.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_TYPE   COM_TYPE_SOURCE_TYPE_ID on BGT_D_FEE_ITEM.SOURCE_TYPE_ID = COM_TYPE_SOURCE_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_FEE_ITEM",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_D_FEE_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_FEE_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_CALCULATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_DISABLE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADVICE_CLASSIFY_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ITEM_CLASSIFY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.UNIT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SOURCE_TYPE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PREPARE_PATTERN_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IMPORT_TYPE_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_CARRYOVER_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_CALCULATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_DISABLE_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ADVICE_CLASSIFY_ID_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ITEM_CLASSIFY_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DATA_TYPE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SOURCE_TYPE_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_FEE_ITEM[] objs = new DisplayObject_BGT_D_FEE_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_D_FEE_ITEM[] Query(CauseObject_BGT_D_FEE_ITEM cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_D_FEE_ITEM.PREPARE_PATTERN_ID, BGT_D_FEE_ITEM.CODE, BGT_D_FEE_ITEM.IMPORT_TYPE_ID, BGT_D_FEE_ITEM.IS_CARRYOVER, BGT_D_FEE_ITEM.IS_CALCULATE, BGT_D_FEE_ITEM.ID, BGT_D_FEE_ITEM.IS_DISABLE, BGT_D_FEE_ITEM.ADVICE_CLASSIFY_ID, BGT_D_FEE_ITEM.BUDGET_YEAR, BGT_D_FEE_ITEM.ITEM_CLASSIFY_ID, BGT_D_FEE_ITEM.DATA_TYPE_ID, BGT_D_FEE_ITEM.NAME, BGT_D_FEE_ITEM.ITEM_TYPE_ID, BGT_D_FEE_ITEM.UNIT_ID, BGT_D_FEE_ITEM.SOURCE_TYPE_ID, COM_TYPE_PREPARE_PATTERN_ID.NAME as PREPARE_PATTERN_ID_NAME, COM_TYPE_IMPORT_TYPE_ID.NAME as IMPORT_TYPE_ID_NAME, (case  when BGT_D_FEE_ITEM.IS_CARRYOVER = 1 then '是' when BGT_D_FEE_ITEM.IS_CARRYOVER = 2 then '否' else '' end ) as IS_CARRYOVER_NAME, (case  when BGT_D_FEE_ITEM.IS_CALCULATE = 1 then '是' when BGT_D_FEE_ITEM.IS_CALCULATE = 2 then '否' else '' end ) as IS_CALCULATE_NAME, (case  when BGT_D_FEE_ITEM.IS_DISABLE = 1 then '是' when BGT_D_FEE_ITEM.IS_DISABLE = 2 then '否' else '' end ) as IS_DISABLE_NAME, COM_TYPE_ADVICE_CLASSIFY_ID.NAME as ADVICE_CLASSIFY_ID_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, COM_TYPE_ITEM_CLASSIFY_ID.NAME as ITEM_CLASSIFY_ID_NAME, COM_TYPE_DATA_TYPE_ID.NAME as DATA_TYPE_ID_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, COM_TYPE_SOURCE_TYPE_ID.NAME as SOURCE_TYPE_ID_NAME from BGT_D_FEE_ITEM left join COM_TYPE   COM_TYPE_PREPARE_PATTERN_ID on BGT_D_FEE_ITEM.PREPARE_PATTERN_ID = COM_TYPE_PREPARE_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_IMPORT_TYPE_ID on BGT_D_FEE_ITEM.IMPORT_TYPE_ID = COM_TYPE_IMPORT_TYPE_ID.ID left join COM_TYPE   COM_TYPE_ADVICE_CLASSIFY_ID on BGT_D_FEE_ITEM.ADVICE_CLASSIFY_ID = COM_TYPE_ADVICE_CLASSIFY_ID.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_FEE_ITEM.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_ITEM_CLASSIFY_ID on BGT_D_FEE_ITEM.ITEM_CLASSIFY_ID = COM_TYPE_ITEM_CLASSIFY_ID.ID left join COM_TYPE   COM_TYPE_DATA_TYPE_ID on BGT_D_FEE_ITEM.DATA_TYPE_ID = COM_TYPE_DATA_TYPE_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_FEE_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on BGT_D_FEE_ITEM.UNIT_ID = COM_TYPE_UNIT_ID.ID left join COM_TYPE   COM_TYPE_SOURCE_TYPE_ID on BGT_D_FEE_ITEM.SOURCE_TYPE_ID = COM_TYPE_SOURCE_TYPE_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_FEE_ITEM",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_D_FEE_ITEM dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_FEE_ITEM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IMPORT_TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_CARRYOVER = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_CALCULATE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IS_DISABLE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ADVICE_CLASSIFY_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BUDGET_YEAR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ITEM_CLASSIFY_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_TYPE_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ITEM_TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.UNIT_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SOURCE_TYPE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PREPARE_PATTERN_ID_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.IMPORT_TYPE_ID_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_CARRYOVER_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_CALCULATE_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_DISABLE_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ADVICE_CLASSIFY_ID_NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ITEM_CLASSIFY_ID_NAME = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.DATA_TYPE_ID_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SOURCE_TYPE_ID_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_D_FEE_ITEM[] objs = new DisplayObject_BGT_D_FEE_ITEM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_D_FEE_ITEM obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("PREPARE_PATTERN_ID"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.PREPARE_PATTERN_ID = :PREPARE_PATTERN_ID");
				param = new OracleParameter();
				param.ParameterName = ":PREPARE_PATTERN_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PREPARE_PATTERN_ID) ? string.Empty : obj.PREPARE_PATTERN_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IMPORT_TYPE_ID"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.IMPORT_TYPE_ID = :IMPORT_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":IMPORT_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.IMPORT_TYPE_ID) ? string.Empty : obj.IMPORT_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_CARRYOVER"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.IS_CARRYOVER = :IS_CARRYOVER");
				param = new OracleParameter();
				param.ParameterName = ":IS_CARRYOVER";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_CARRYOVER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_CALCULATE"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.IS_CALCULATE = :IS_CALCULATE");
				param = new OracleParameter();
				param.ParameterName = ":IS_CALCULATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_CALCULATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_DISABLE"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.IS_DISABLE = :IS_DISABLE");
				param = new OracleParameter();
				param.ParameterName = ":IS_DISABLE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_DISABLE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ADVICE_CLASSIFY_ID"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.ADVICE_CLASSIFY_ID = :ADVICE_CLASSIFY_ID");
				param = new OracleParameter();
				param.ParameterName = ":ADVICE_CLASSIFY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ADVICE_CLASSIFY_ID) ? string.Empty : obj.ADVICE_CLASSIFY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUDGET_YEAR"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.BUDGET_YEAR = :BUDGET_YEAR");
				param = new OracleParameter();
				param.ParameterName = ":BUDGET_YEAR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_CLASSIFY_ID"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.ITEM_CLASSIFY_ID = :ITEM_CLASSIFY_ID");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_CLASSIFY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_CLASSIFY_ID) ? string.Empty : obj.ITEM_CLASSIFY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_TYPE_ID"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.DATA_TYPE_ID = :DATA_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_TYPE_ID) ? string.Empty : obj.DATA_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_TYPE_ID"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.ITEM_TYPE_ID = :ITEM_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_TYPE_ID) ? string.Empty : obj.ITEM_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("UNIT_ID"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.UNIT_ID = :UNIT_ID");
				param = new OracleParameter();
				param.ParameterName = ":UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.UNIT_ID) ? string.Empty : obj.UNIT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SOURCE_TYPE_ID"))
			{
				strBuf.Add("  BGT_D_FEE_ITEM.SOURCE_TYPE_ID = :SOURCE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":SOURCE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.SOURCE_TYPE_ID) ? string.Empty : obj.SOURCE_TYPE_ID;
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
