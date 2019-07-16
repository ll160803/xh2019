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
	[CauseObject(typeof(CauseObject_MTR_B_OUTSTOCK_D))]
	public partial class HelperObject_MTR_B_OUTSTOCK_D
	{		
		#region Method Blok
		public static int Save(EntityObject_MTR_B_OUTSTOCK_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into MTR_B_OUTSTOCK_D( BATCH_CODE, ID, PRD_DATE, COMMENTS, PRICE, REF_TAB_ID, AMOUNT, REF_TAB_NAME, RETAIL_PRICE, SPEC, MONEY, MATER_ID, UNIT_ID, PKG_AMOUNT, BASE_ID, PRD_ID, INVALID_DATE, RETAIL_MONEY) values ( :BATCH_CODE, :ID, :PRD_DATE, :COMMENTS, :PRICE, :REF_TAB_ID, :AMOUNT, :REF_TAB_NAME, :RETAIL_PRICE, :SPEC, :MONEY, :MATER_ID, :UNIT_ID, :PKG_AMOUNT, :BASE_ID, :PRD_ID, :INVALID_DATE, :RETAIL_MONEY)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[18];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":BATCH_CODE";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.BATCH_CODE == null ? String.Empty:obj.BATCH_CODE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":PRD_DATE";
			parameters[2].Size = 7;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[2].Value = obj.PRD_DATE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":COMMENTS";
			parameters[3].Size = 200;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":PRICE";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.PRICE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":REF_TAB_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.REF_TAB_ID == null ? String.Empty:obj.REF_TAB_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":AMOUNT";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.AMOUNT;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":REF_TAB_NAME";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.REF_TAB_NAME == null ? String.Empty:obj.REF_TAB_NAME;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":RETAIL_PRICE";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.RETAIL_PRICE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":SPEC";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":MONEY";
			parameters[10].Size = 22;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[10].Value = obj.MONEY;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":MATER_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.MATER_ID == null ? String.Empty:obj.MATER_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":UNIT_ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.UNIT_ID == null ? String.Empty:obj.UNIT_ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":PKG_AMOUNT";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.PKG_AMOUNT;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":BASE_ID";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":PRD_ID";
			parameters[15].Size = 36;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[15].Value = obj.PRD_ID == null ? String.Empty:obj.PRD_ID;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":INVALID_DATE";
			parameters[16].Size = 7;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[16].Value = obj.INVALID_DATE;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":RETAIL_MONEY";
			parameters[17].Size = 22;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[17].Value = obj.RETAIL_MONEY;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_MTR_B_OUTSTOCK_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update MTR_B_OUTSTOCK_D set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_MTR_B_OUTSTOCK_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from MTR_B_OUTSTOCK_D where  ID = :ID ";
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
		public static EntityObject_MTR_B_OUTSTOCK_D Get(EntityObject_MTR_B_OUTSTOCK_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  BATCH_CODE, ID, PRD_DATE, COMMENTS, PRICE, REF_TAB_ID, AMOUNT, REF_TAB_NAME, RETAIL_PRICE, SPEC, MONEY, MATER_ID, UNIT_ID, PKG_AMOUNT, BASE_ID, PRD_ID, INVALID_DATE, RETAIL_MONEY from MTR_B_OUTSTOCK_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MTR_B_OUTSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MTR_B_OUTSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BATCH_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PRICE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.RETAIL_PRICE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PRD_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.INVALID_DATE = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.RETAIL_MONEY = sqlReader.GetDecimal(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_MTR_B_OUTSTOCK_D[] objs = new EntityObject_MTR_B_OUTSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_MTR_B_OUTSTOCK_D Get(EntityObject_MTR_B_OUTSTOCK_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  BATCH_CODE, ID, PRD_DATE, COMMENTS, PRICE, REF_TAB_ID, AMOUNT, REF_TAB_NAME, RETAIL_PRICE, SPEC, MONEY, MATER_ID, UNIT_ID, PKG_AMOUNT, BASE_ID, PRD_ID, INVALID_DATE, RETAIL_MONEY from MTR_B_OUTSTOCK_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_MTR_B_OUTSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_MTR_B_OUTSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BATCH_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PRICE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.RETAIL_PRICE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PRD_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.INVALID_DATE = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.RETAIL_MONEY = sqlReader.GetDecimal(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_MTR_B_OUTSTOCK_D[] objs = new EntityObject_MTR_B_OUTSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_MTR_B_OUTSTOCK_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  MTR_B_OUTSTOCK_D.BATCH_CODE, MTR_B_OUTSTOCK_D.ID, MTR_B_OUTSTOCK_D.PRD_DATE, MTR_B_OUTSTOCK_D.COMMENTS, MTR_B_OUTSTOCK_D.PRICE, MTR_B_OUTSTOCK_D.REF_TAB_ID, MTR_B_OUTSTOCK_D.AMOUNT, MTR_B_OUTSTOCK_D.REF_TAB_NAME, MTR_B_OUTSTOCK_D.RETAIL_PRICE, MTR_B_OUTSTOCK_D.SPEC, MTR_B_OUTSTOCK_D.MONEY, MTR_B_OUTSTOCK_D.MATER_ID, MTR_B_OUTSTOCK_D.UNIT_ID, MTR_B_OUTSTOCK_D.PKG_AMOUNT, MTR_B_OUTSTOCK_D.BASE_ID, MTR_B_OUTSTOCK_D.PRD_ID, MTR_B_OUTSTOCK_D.INVALID_DATE, MTR_B_OUTSTOCK_D.RETAIL_MONEY, MTR_D_MTR_MATER_ID.NAME as MATER_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME from MTR_B_OUTSTOCK_D left join MTR_D_MTR   MTR_D_MTR_MATER_ID on MTR_B_OUTSTOCK_D.MATER_ID = MTR_D_MTR_MATER_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MTR_B_OUTSTOCK_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MTR_B_OUTSTOCK_D.PRD_ID = MDM_D_DEPT_PRD_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_MTR_B_OUTSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MTR_B_OUTSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BATCH_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PRICE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.RETAIL_PRICE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PRD_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.INVALID_DATE = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.RETAIL_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MATER_ID_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MTR_B_OUTSTOCK_D[] objs = new DisplayObject_MTR_B_OUTSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_MTR_B_OUTSTOCK_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.BATCH_CODE!= string.Empty)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.BATCH_CODE ").Append((cause.BATCH_CODE.StartsWith("%") || cause.BATCH_CODE.EndsWith("%")) ? " like " : " = ").Append(" :BATCH_CODE");
				param = new OracleParameter();
				param.ParameterName =":BATCH_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BATCH_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("BATCH_CODE"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "BATCH_CODE"));
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "ID"));
			}
			if(cause.PRD_DATE!= null)
			{
				if (cause.PRD_DATE.Begin != null)
				{
					strBuf.Append(" And MTR_B_OUTSTOCK_D.PRD_DATE >= :PRD_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":PRD_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PRD_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PRD_DATE.End != null)
				{
					strBuf.Append(" And MTR_B_OUTSTOCK_D.PRD_DATE < :PRD_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":PRD_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PRD_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("PRD_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "PRD_DATE"));
			}
			if(cause.COMMENTS!= string.Empty)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "COMMENTS"));
			}
			if(cause.PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName =":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRICE"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "PRICE"));
			}
			if(cause.REF_TAB_ID!= string.Empty)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.REF_TAB_ID ").Append((cause.REF_TAB_ID.StartsWith("%") || cause.REF_TAB_ID.EndsWith("%")) ? " like " : " = ").Append(" :REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName =":REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.REF_TAB_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_ID"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "REF_TAB_ID"));
			}
			if(cause.AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.AMOUNT = :AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "AMOUNT"));
			}
			if(cause.REF_TAB_NAME!= string.Empty)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.REF_TAB_NAME ").Append((cause.REF_TAB_NAME.StartsWith("%") || cause.REF_TAB_NAME.EndsWith("%")) ? " like " : " = ").Append(" :REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName =":REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("REF_TAB_NAME"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "REF_TAB_NAME"));
			}
			if(cause.RETAIL_PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.RETAIL_PRICE = :RETAIL_PRICE");
				param = new OracleParameter();
				param.ParameterName =":RETAIL_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.RETAIL_PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("RETAIL_PRICE"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "RETAIL_PRICE"));
			}
			if(cause.SPEC!= string.Empty)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :SPEC");
				param = new OracleParameter();
				param.ParameterName =":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "SPEC"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName =":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "MONEY"));
			}
			if(cause.MATER_ID!= string.Empty)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.MATER_ID ").Append((cause.MATER_ID.StartsWith("%") || cause.MATER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MATER_ID");
				param = new OracleParameter();
				param.ParameterName =":MATER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MATER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATER_ID"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "MATER_ID"));
			}
			if(cause.UNIT_ID!= string.Empty)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.UNIT_ID ").Append((cause.UNIT_ID.StartsWith("%") || cause.UNIT_ID.EndsWith("%")) ? " like " : " = ").Append(" :UNIT_ID");
				param = new OracleParameter();
				param.ParameterName =":UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.UNIT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("UNIT_ID"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "UNIT_ID"));
			}
			if(cause.PKG_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.PKG_AMOUNT = :PKG_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":PKG_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PKG_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("PKG_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "PKG_AMOUNT"));
			}
			if(cause.BASE_ID!= string.Empty)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "BASE_ID"));
			}
			if(cause.PRD_ID!= string.Empty)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.PRD_ID ").Append((cause.PRD_ID.StartsWith("%") || cause.PRD_ID.EndsWith("%")) ? " like " : " = ").Append(" :PRD_ID");
				param = new OracleParameter();
				param.ParameterName =":PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PRD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRD_ID"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "PRD_ID"));
			}
			if(cause.INVALID_DATE!= null)
			{
				if (cause.INVALID_DATE.Begin != null)
				{
					strBuf.Append(" And MTR_B_OUTSTOCK_D.INVALID_DATE >= :INVALID_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":INVALID_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.INVALID_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.INVALID_DATE.End != null)
				{
					strBuf.Append(" And MTR_B_OUTSTOCK_D.INVALID_DATE < :INVALID_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":INVALID_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.INVALID_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("INVALID_DATE"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "INVALID_DATE"));
			}
			if(cause.RETAIL_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And MTR_B_OUTSTOCK_D.RETAIL_MONEY = :RETAIL_MONEY");
				param = new OracleParameter();
				param.ParameterName =":RETAIL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.RETAIL_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("RETAIL_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("MTR_B_OUTSTOCK_D", "RETAIL_MONEY"));
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
		public static DisplayObject_MTR_B_OUTSTOCK_D[] Query(CauseObject_MTR_B_OUTSTOCK_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MTR_B_OUTSTOCK_D.BATCH_CODE, MTR_B_OUTSTOCK_D.ID, MTR_B_OUTSTOCK_D.PRD_DATE, MTR_B_OUTSTOCK_D.COMMENTS, MTR_B_OUTSTOCK_D.PRICE, MTR_B_OUTSTOCK_D.REF_TAB_ID, MTR_B_OUTSTOCK_D.AMOUNT, MTR_B_OUTSTOCK_D.REF_TAB_NAME, MTR_B_OUTSTOCK_D.RETAIL_PRICE, MTR_B_OUTSTOCK_D.SPEC, MTR_B_OUTSTOCK_D.MONEY, MTR_B_OUTSTOCK_D.MATER_ID, MTR_B_OUTSTOCK_D.UNIT_ID, MTR_B_OUTSTOCK_D.PKG_AMOUNT, MTR_B_OUTSTOCK_D.BASE_ID, MTR_B_OUTSTOCK_D.PRD_ID, MTR_B_OUTSTOCK_D.INVALID_DATE, MTR_B_OUTSTOCK_D.RETAIL_MONEY, MTR_D_MTR_MATER_ID.NAME as MATER_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME from MTR_B_OUTSTOCK_D left join MTR_D_MTR   MTR_D_MTR_MATER_ID on MTR_B_OUTSTOCK_D.MATER_ID = MTR_D_MTR_MATER_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MTR_B_OUTSTOCK_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MTR_B_OUTSTOCK_D.PRD_ID = MDM_D_DEPT_PRD_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MTR_B_OUTSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MTR_B_OUTSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BATCH_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PRICE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.RETAIL_PRICE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PRD_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.INVALID_DATE = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.RETAIL_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MATER_ID_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MTR_B_OUTSTOCK_D[] objs = new DisplayObject_MTR_B_OUTSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_MTR_B_OUTSTOCK_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from MTR_B_OUTSTOCK_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_MTR_B_OUTSTOCK_D[] Query(CauseObject_MTR_B_OUTSTOCK_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  MTR_B_OUTSTOCK_D.BATCH_CODE, MTR_B_OUTSTOCK_D.ID, MTR_B_OUTSTOCK_D.PRD_DATE, MTR_B_OUTSTOCK_D.COMMENTS, MTR_B_OUTSTOCK_D.PRICE, MTR_B_OUTSTOCK_D.REF_TAB_ID, MTR_B_OUTSTOCK_D.AMOUNT, MTR_B_OUTSTOCK_D.REF_TAB_NAME, MTR_B_OUTSTOCK_D.RETAIL_PRICE, MTR_B_OUTSTOCK_D.SPEC, MTR_B_OUTSTOCK_D.MONEY, MTR_B_OUTSTOCK_D.MATER_ID, MTR_B_OUTSTOCK_D.UNIT_ID, MTR_B_OUTSTOCK_D.PKG_AMOUNT, MTR_B_OUTSTOCK_D.BASE_ID, MTR_B_OUTSTOCK_D.PRD_ID, MTR_B_OUTSTOCK_D.INVALID_DATE, MTR_B_OUTSTOCK_D.RETAIL_MONEY, MTR_D_MTR_MATER_ID.NAME as MATER_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME from MTR_B_OUTSTOCK_D left join MTR_D_MTR   MTR_D_MTR_MATER_ID on MTR_B_OUTSTOCK_D.MATER_ID = MTR_D_MTR_MATER_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MTR_B_OUTSTOCK_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MTR_B_OUTSTOCK_D.PRD_ID = MDM_D_DEPT_PRD_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_MTR_B_OUTSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MTR_B_OUTSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BATCH_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PRICE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.RETAIL_PRICE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PRD_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.INVALID_DATE = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.RETAIL_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MATER_ID_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MTR_B_OUTSTOCK_D[] objs = new DisplayObject_MTR_B_OUTSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MTR_B_OUTSTOCK_D[] Query(CauseObject_MTR_B_OUTSTOCK_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MTR_B_OUTSTOCK_D.BATCH_CODE, MTR_B_OUTSTOCK_D.ID, MTR_B_OUTSTOCK_D.PRD_DATE, MTR_B_OUTSTOCK_D.COMMENTS, MTR_B_OUTSTOCK_D.PRICE, MTR_B_OUTSTOCK_D.REF_TAB_ID, MTR_B_OUTSTOCK_D.AMOUNT, MTR_B_OUTSTOCK_D.REF_TAB_NAME, MTR_B_OUTSTOCK_D.RETAIL_PRICE, MTR_B_OUTSTOCK_D.SPEC, MTR_B_OUTSTOCK_D.MONEY, MTR_B_OUTSTOCK_D.MATER_ID, MTR_B_OUTSTOCK_D.UNIT_ID, MTR_B_OUTSTOCK_D.PKG_AMOUNT, MTR_B_OUTSTOCK_D.BASE_ID, MTR_B_OUTSTOCK_D.PRD_ID, MTR_B_OUTSTOCK_D.INVALID_DATE, MTR_B_OUTSTOCK_D.RETAIL_MONEY, MTR_D_MTR_MATER_ID.NAME as MATER_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME from MTR_B_OUTSTOCK_D left join MTR_D_MTR   MTR_D_MTR_MATER_ID on MTR_B_OUTSTOCK_D.MATER_ID = MTR_D_MTR_MATER_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MTR_B_OUTSTOCK_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MTR_B_OUTSTOCK_D.PRD_ID = MDM_D_DEPT_PRD_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MTR_B_OUTSTOCK_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_MTR_B_OUTSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MTR_B_OUTSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BATCH_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PRICE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.RETAIL_PRICE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PRD_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.INVALID_DATE = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.RETAIL_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MATER_ID_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_MTR_B_OUTSTOCK_D[] objs = new DisplayObject_MTR_B_OUTSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_MTR_B_OUTSTOCK_D[] Query(CauseObject_MTR_B_OUTSTOCK_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  MTR_B_OUTSTOCK_D.BATCH_CODE, MTR_B_OUTSTOCK_D.ID, MTR_B_OUTSTOCK_D.PRD_DATE, MTR_B_OUTSTOCK_D.COMMENTS, MTR_B_OUTSTOCK_D.PRICE, MTR_B_OUTSTOCK_D.REF_TAB_ID, MTR_B_OUTSTOCK_D.AMOUNT, MTR_B_OUTSTOCK_D.REF_TAB_NAME, MTR_B_OUTSTOCK_D.RETAIL_PRICE, MTR_B_OUTSTOCK_D.SPEC, MTR_B_OUTSTOCK_D.MONEY, MTR_B_OUTSTOCK_D.MATER_ID, MTR_B_OUTSTOCK_D.UNIT_ID, MTR_B_OUTSTOCK_D.PKG_AMOUNT, MTR_B_OUTSTOCK_D.BASE_ID, MTR_B_OUTSTOCK_D.PRD_ID, MTR_B_OUTSTOCK_D.INVALID_DATE, MTR_B_OUTSTOCK_D.RETAIL_MONEY, MTR_D_MTR_MATER_ID.NAME as MATER_ID_NAME, COM_TYPE_UNIT_ID.NAME as UNIT_ID_NAME, MDM_D_DEPT_PRD_ID.NAME as PRD_ID_NAME from MTR_B_OUTSTOCK_D left join MTR_D_MTR   MTR_D_MTR_MATER_ID on MTR_B_OUTSTOCK_D.MATER_ID = MTR_D_MTR_MATER_ID.ID left join COM_TYPE   COM_TYPE_UNIT_ID on MTR_B_OUTSTOCK_D.UNIT_ID = COM_TYPE_UNIT_ID.ID left join MDM_D_DEPT   MDM_D_DEPT_PRD_ID on MTR_B_OUTSTOCK_D.PRD_ID = MDM_D_DEPT_PRD_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("MTR_B_OUTSTOCK_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_MTR_B_OUTSTOCK_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_MTR_B_OUTSTOCK_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BATCH_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRD_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.COMMENTS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PRICE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REF_TAB_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.REF_TAB_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.RETAIL_PRICE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MONEY = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.UNIT_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PKG_AMOUNT = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.PRD_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.INVALID_DATE = sqlReader.GetDateTime(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.RETAIL_MONEY = sqlReader.GetDecimal(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MATER_ID_NAME = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.UNIT_ID_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.PRD_ID_NAME = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_MTR_B_OUTSTOCK_D[] objs = new DisplayObject_MTR_B_OUTSTOCK_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_MTR_B_OUTSTOCK_D obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("BATCH_CODE"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.BATCH_CODE = :BATCH_CODE");
				param = new OracleParameter();
				param.ParameterName = ":BATCH_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.BATCH_CODE) ? string.Empty : obj.BATCH_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_DATE"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.PRD_DATE = :PRD_DATE");
				param = new OracleParameter();
				param.ParameterName = ":PRD_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PRD_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRICE"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName = ":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_ID"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.REF_TAB_ID = :REF_TAB_ID");
				param = new OracleParameter();
				param.ParameterName = ":REF_TAB_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_ID) ? string.Empty : obj.REF_TAB_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AMOUNT"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.AMOUNT = :AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REF_TAB_NAME"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.REF_TAB_NAME = :REF_TAB_NAME");
				param = new OracleParameter();
				param.ParameterName = ":REF_TAB_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.REF_TAB_NAME) ? string.Empty : obj.REF_TAB_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("RETAIL_PRICE"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.RETAIL_PRICE = :RETAIL_PRICE");
				param = new OracleParameter();
				param.ParameterName = ":RETAIL_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.RETAIL_PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.SPEC = :SPEC");
				param = new OracleParameter();
				param.ParameterName = ":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName = ":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATER_ID"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.MATER_ID = :MATER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MATER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MATER_ID) ? string.Empty : obj.MATER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("UNIT_ID"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.UNIT_ID = :UNIT_ID");
				param = new OracleParameter();
				param.ParameterName = ":UNIT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.UNIT_ID) ? string.Empty : obj.UNIT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PKG_AMOUNT"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.PKG_AMOUNT = :PKG_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":PKG_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PKG_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRD_ID"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.PRD_ID = :PRD_ID");
				param = new OracleParameter();
				param.ParameterName = ":PRD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PRD_ID) ? string.Empty : obj.PRD_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INVALID_DATE"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.INVALID_DATE = :INVALID_DATE");
				param = new OracleParameter();
				param.ParameterName = ":INVALID_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.INVALID_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("RETAIL_MONEY"))
			{
				strBuf.Add("  MTR_B_OUTSTOCK_D.RETAIL_MONEY = :RETAIL_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":RETAIL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.RETAIL_MONEY;
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
