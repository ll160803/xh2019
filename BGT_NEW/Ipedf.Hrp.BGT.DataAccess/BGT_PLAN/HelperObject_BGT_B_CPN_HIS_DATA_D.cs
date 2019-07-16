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
	[CauseObject(typeof(CauseObject_BGT_B_CPN_HIS_DATA_D))]
	public partial class HelperObject_BGT_B_CPN_HIS_DATA_D
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_CPN_HIS_DATA_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_B_CPN_HIS_DATA_D( M_4_VALUE, ID, M_8_VALUE, BASE_ID, M_6_VALUE, M_5_VALUE, M_10_VALUE, ITEM_ID, M_9_VALUE, M_2_VALUE, M_11_VALUE, M_3_VALUE, M_12_VALUE, M_7_VALUE, M_1_VALUE) values ( :M_4_VALUE, :ID, :M_8_VALUE, :BASE_ID, :M_6_VALUE, :M_5_VALUE, :M_10_VALUE, :ITEM_ID, :M_9_VALUE, :M_2_VALUE, :M_11_VALUE, :M_3_VALUE, :M_12_VALUE, :M_7_VALUE, :M_1_VALUE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[15];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":M_4_VALUE";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.M_4_VALUE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":M_8_VALUE";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.M_8_VALUE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":BASE_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":M_6_VALUE";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.M_6_VALUE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":M_5_VALUE";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.M_5_VALUE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":M_10_VALUE";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.M_10_VALUE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ITEM_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.ITEM_ID == null ? String.Empty:obj.ITEM_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":M_9_VALUE";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.M_9_VALUE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":M_2_VALUE";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.M_2_VALUE;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":M_11_VALUE";
			parameters[10].Size = 22;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[10].Value = obj.M_11_VALUE;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":M_3_VALUE";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.M_3_VALUE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":M_12_VALUE";
			parameters[12].Size = 22;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[12].Value = obj.M_12_VALUE;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":M_7_VALUE";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.M_7_VALUE;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":M_1_VALUE";
			parameters[14].Size = 22;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[14].Value = obj.M_1_VALUE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_CPN_HIS_DATA_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_CPN_HIS_DATA_D set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_CPN_HIS_DATA_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_CPN_HIS_DATA_D where  ID = :ID ";
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
		public static EntityObject_BGT_B_CPN_HIS_DATA_D Get(EntityObject_BGT_B_CPN_HIS_DATA_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  M_4_VALUE, ID, M_8_VALUE, BASE_ID, M_6_VALUE, M_5_VALUE, M_10_VALUE, ITEM_ID, M_9_VALUE, M_2_VALUE, M_11_VALUE, M_3_VALUE, M_12_VALUE, M_7_VALUE, M_1_VALUE from BGT_B_CPN_HIS_DATA_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_CPN_HIS_DATA_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_CPN_HIS_DATA_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.M_4_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.M_8_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.M_6_VALUE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.M_5_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.M_10_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.M_9_VALUE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.M_2_VALUE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.M_11_VALUE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.M_3_VALUE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.M_12_VALUE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.M_7_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.M_1_VALUE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_CPN_HIS_DATA_D[] objs = new EntityObject_BGT_B_CPN_HIS_DATA_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_CPN_HIS_DATA_D Get(EntityObject_BGT_B_CPN_HIS_DATA_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  M_4_VALUE, ID, M_8_VALUE, BASE_ID, M_6_VALUE, M_5_VALUE, M_10_VALUE, ITEM_ID, M_9_VALUE, M_2_VALUE, M_11_VALUE, M_3_VALUE, M_12_VALUE, M_7_VALUE, M_1_VALUE from BGT_B_CPN_HIS_DATA_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_CPN_HIS_DATA_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_CPN_HIS_DATA_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.M_4_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.M_8_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.M_6_VALUE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.M_5_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.M_10_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.M_9_VALUE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.M_2_VALUE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.M_11_VALUE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.M_3_VALUE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.M_12_VALUE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.M_7_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.M_1_VALUE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_CPN_HIS_DATA_D[] objs = new EntityObject_BGT_B_CPN_HIS_DATA_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_CPN_HIS_DATA_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_CPN_HIS_DATA_D.M_4_VALUE, BGT_B_CPN_HIS_DATA_D.ID, BGT_B_CPN_HIS_DATA_D.M_8_VALUE, BGT_B_CPN_HIS_DATA_D.BASE_ID, BGT_B_CPN_HIS_DATA_D.M_6_VALUE, BGT_B_CPN_HIS_DATA_D.M_5_VALUE, BGT_B_CPN_HIS_DATA_D.M_10_VALUE, BGT_B_CPN_HIS_DATA_D.ITEM_ID, BGT_B_CPN_HIS_DATA_D.M_9_VALUE, BGT_B_CPN_HIS_DATA_D.M_2_VALUE, BGT_B_CPN_HIS_DATA_D.M_11_VALUE, BGT_B_CPN_HIS_DATA_D.M_3_VALUE, BGT_B_CPN_HIS_DATA_D.M_12_VALUE, BGT_B_CPN_HIS_DATA_D.M_7_VALUE, BGT_B_CPN_HIS_DATA_D.M_1_VALUE, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from BGT_B_CPN_HIS_DATA_D left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_B_CPN_HIS_DATA_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_CPN_HIS_DATA_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_HIS_DATA_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.M_4_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.M_8_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.M_6_VALUE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.M_5_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.M_10_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.M_9_VALUE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.M_2_VALUE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.M_11_VALUE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.M_3_VALUE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.M_12_VALUE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.M_7_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.M_1_VALUE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_CPN_HIS_DATA_D[] objs = new DisplayObject_BGT_B_CPN_HIS_DATA_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_CPN_HIS_DATA_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.M_4_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.M_4_VALUE = :M_4_VALUE");
				param = new OracleParameter();
				param.ParameterName =":M_4_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M_4_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("M_4_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "M_4_VALUE"));
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "ID"));
			}
			if(cause.M_8_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.M_8_VALUE = :M_8_VALUE");
				param = new OracleParameter();
				param.ParameterName =":M_8_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M_8_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("M_8_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "M_8_VALUE"));
			}
			if(cause.BASE_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "BASE_ID"));
			}
			if(cause.M_6_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.M_6_VALUE = :M_6_VALUE");
				param = new OracleParameter();
				param.ParameterName =":M_6_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M_6_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("M_6_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "M_6_VALUE"));
			}
			if(cause.M_5_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.M_5_VALUE = :M_5_VALUE");
				param = new OracleParameter();
				param.ParameterName =":M_5_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M_5_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("M_5_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "M_5_VALUE"));
			}
			if(cause.M_10_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.M_10_VALUE = :M_10_VALUE");
				param = new OracleParameter();
				param.ParameterName =":M_10_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M_10_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("M_10_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "M_10_VALUE"));
			}
			if(cause.ITEM_ID!= string.Empty)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.ITEM_ID ").Append((cause.ITEM_ID.StartsWith("%") || cause.ITEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName =":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ITEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "ITEM_ID"));
			}
			if(cause.M_9_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.M_9_VALUE = :M_9_VALUE");
				param = new OracleParameter();
				param.ParameterName =":M_9_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M_9_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("M_9_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "M_9_VALUE"));
			}
			if(cause.M_2_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.M_2_VALUE = :M_2_VALUE");
				param = new OracleParameter();
				param.ParameterName =":M_2_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M_2_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("M_2_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "M_2_VALUE"));
			}
			if(cause.M_11_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.M_11_VALUE = :M_11_VALUE");
				param = new OracleParameter();
				param.ParameterName =":M_11_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M_11_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("M_11_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "M_11_VALUE"));
			}
			if(cause.M_3_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.M_3_VALUE = :M_3_VALUE");
				param = new OracleParameter();
				param.ParameterName =":M_3_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M_3_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("M_3_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "M_3_VALUE"));
			}
			if(cause.M_12_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.M_12_VALUE = :M_12_VALUE");
				param = new OracleParameter();
				param.ParameterName =":M_12_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M_12_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("M_12_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "M_12_VALUE"));
			}
			if(cause.M_7_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.M_7_VALUE = :M_7_VALUE");
				param = new OracleParameter();
				param.ParameterName =":M_7_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M_7_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("M_7_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "M_7_VALUE"));
			}
			if(cause.M_1_VALUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_HIS_DATA_D.M_1_VALUE = :M_1_VALUE");
				param = new OracleParameter();
				param.ParameterName =":M_1_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.M_1_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("M_1_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_HIS_DATA_D", "M_1_VALUE"));
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
		public static DisplayObject_BGT_B_CPN_HIS_DATA_D[] Query(CauseObject_BGT_B_CPN_HIS_DATA_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_HIS_DATA_D.M_4_VALUE, BGT_B_CPN_HIS_DATA_D.ID, BGT_B_CPN_HIS_DATA_D.M_8_VALUE, BGT_B_CPN_HIS_DATA_D.BASE_ID, BGT_B_CPN_HIS_DATA_D.M_6_VALUE, BGT_B_CPN_HIS_DATA_D.M_5_VALUE, BGT_B_CPN_HIS_DATA_D.M_10_VALUE, BGT_B_CPN_HIS_DATA_D.ITEM_ID, BGT_B_CPN_HIS_DATA_D.M_9_VALUE, BGT_B_CPN_HIS_DATA_D.M_2_VALUE, BGT_B_CPN_HIS_DATA_D.M_11_VALUE, BGT_B_CPN_HIS_DATA_D.M_3_VALUE, BGT_B_CPN_HIS_DATA_D.M_12_VALUE, BGT_B_CPN_HIS_DATA_D.M_7_VALUE, BGT_B_CPN_HIS_DATA_D.M_1_VALUE, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from BGT_B_CPN_HIS_DATA_D left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_B_CPN_HIS_DATA_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_CPN_HIS_DATA_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_HIS_DATA_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.M_4_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.M_8_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.M_6_VALUE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.M_5_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.M_10_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.M_9_VALUE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.M_2_VALUE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.M_11_VALUE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.M_3_VALUE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.M_12_VALUE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.M_7_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.M_1_VALUE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_CPN_HIS_DATA_D[] objs = new DisplayObject_BGT_B_CPN_HIS_DATA_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_CPN_HIS_DATA_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_CPN_HIS_DATA_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_CPN_HIS_DATA_D[] Query(CauseObject_BGT_B_CPN_HIS_DATA_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_HIS_DATA_D.M_4_VALUE, BGT_B_CPN_HIS_DATA_D.ID, BGT_B_CPN_HIS_DATA_D.M_8_VALUE, BGT_B_CPN_HIS_DATA_D.BASE_ID, BGT_B_CPN_HIS_DATA_D.M_6_VALUE, BGT_B_CPN_HIS_DATA_D.M_5_VALUE, BGT_B_CPN_HIS_DATA_D.M_10_VALUE, BGT_B_CPN_HIS_DATA_D.ITEM_ID, BGT_B_CPN_HIS_DATA_D.M_9_VALUE, BGT_B_CPN_HIS_DATA_D.M_2_VALUE, BGT_B_CPN_HIS_DATA_D.M_11_VALUE, BGT_B_CPN_HIS_DATA_D.M_3_VALUE, BGT_B_CPN_HIS_DATA_D.M_12_VALUE, BGT_B_CPN_HIS_DATA_D.M_7_VALUE, BGT_B_CPN_HIS_DATA_D.M_1_VALUE, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from BGT_B_CPN_HIS_DATA_D left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_B_CPN_HIS_DATA_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_CPN_HIS_DATA_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_HIS_DATA_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.M_4_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.M_8_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.M_6_VALUE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.M_5_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.M_10_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.M_9_VALUE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.M_2_VALUE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.M_11_VALUE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.M_3_VALUE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.M_12_VALUE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.M_7_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.M_1_VALUE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_CPN_HIS_DATA_D[] objs = new DisplayObject_BGT_B_CPN_HIS_DATA_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_CPN_HIS_DATA_D[] Query(CauseObject_BGT_B_CPN_HIS_DATA_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_HIS_DATA_D.M_4_VALUE, BGT_B_CPN_HIS_DATA_D.ID, BGT_B_CPN_HIS_DATA_D.M_8_VALUE, BGT_B_CPN_HIS_DATA_D.BASE_ID, BGT_B_CPN_HIS_DATA_D.M_6_VALUE, BGT_B_CPN_HIS_DATA_D.M_5_VALUE, BGT_B_CPN_HIS_DATA_D.M_10_VALUE, BGT_B_CPN_HIS_DATA_D.ITEM_ID, BGT_B_CPN_HIS_DATA_D.M_9_VALUE, BGT_B_CPN_HIS_DATA_D.M_2_VALUE, BGT_B_CPN_HIS_DATA_D.M_11_VALUE, BGT_B_CPN_HIS_DATA_D.M_3_VALUE, BGT_B_CPN_HIS_DATA_D.M_12_VALUE, BGT_B_CPN_HIS_DATA_D.M_7_VALUE, BGT_B_CPN_HIS_DATA_D.M_1_VALUE, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from BGT_B_CPN_HIS_DATA_D left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_B_CPN_HIS_DATA_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_CPN_HIS_DATA_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_CPN_HIS_DATA_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_HIS_DATA_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.M_4_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.M_8_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.M_6_VALUE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.M_5_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.M_10_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.M_9_VALUE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.M_2_VALUE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.M_11_VALUE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.M_3_VALUE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.M_12_VALUE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.M_7_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.M_1_VALUE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_CPN_HIS_DATA_D[] objs = new DisplayObject_BGT_B_CPN_HIS_DATA_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_CPN_HIS_DATA_D[] Query(CauseObject_BGT_B_CPN_HIS_DATA_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_HIS_DATA_D.M_4_VALUE, BGT_B_CPN_HIS_DATA_D.ID, BGT_B_CPN_HIS_DATA_D.M_8_VALUE, BGT_B_CPN_HIS_DATA_D.BASE_ID, BGT_B_CPN_HIS_DATA_D.M_6_VALUE, BGT_B_CPN_HIS_DATA_D.M_5_VALUE, BGT_B_CPN_HIS_DATA_D.M_10_VALUE, BGT_B_CPN_HIS_DATA_D.ITEM_ID, BGT_B_CPN_HIS_DATA_D.M_9_VALUE, BGT_B_CPN_HIS_DATA_D.M_2_VALUE, BGT_B_CPN_HIS_DATA_D.M_11_VALUE, BGT_B_CPN_HIS_DATA_D.M_3_VALUE, BGT_B_CPN_HIS_DATA_D.M_12_VALUE, BGT_B_CPN_HIS_DATA_D.M_7_VALUE, BGT_B_CPN_HIS_DATA_D.M_1_VALUE, BGT_D_PLAN_ITEM_ITEM_ID.NAME as ITEM_ID_NAME from BGT_B_CPN_HIS_DATA_D left join BGT_D_PLAN_ITEM   BGT_D_PLAN_ITEM_ITEM_ID on BGT_B_CPN_HIS_DATA_D.ITEM_ID = BGT_D_PLAN_ITEM_ITEM_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_CPN_HIS_DATA_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_CPN_HIS_DATA_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_HIS_DATA_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.M_4_VALUE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.M_8_VALUE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.M_6_VALUE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.M_5_VALUE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.M_10_VALUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ITEM_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.M_9_VALUE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.M_2_VALUE = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.M_11_VALUE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.M_3_VALUE = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.M_12_VALUE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.M_7_VALUE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.M_1_VALUE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ITEM_ID_NAME = sqlReader.GetString(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_CPN_HIS_DATA_D[] objs = new DisplayObject_BGT_B_CPN_HIS_DATA_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_CPN_HIS_DATA_D obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("M_4_VALUE"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.M_4_VALUE = :M_4_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":M_4_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.M_4_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("M_8_VALUE"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.M_8_VALUE = :M_8_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":M_8_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.M_8_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("M_6_VALUE"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.M_6_VALUE = :M_6_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":M_6_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.M_6_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("M_5_VALUE"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.M_5_VALUE = :M_5_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":M_5_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.M_5_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("M_10_VALUE"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.M_10_VALUE = :M_10_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":M_10_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.M_10_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ITEM_ID"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.ITEM_ID = :ITEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ITEM_ID) ? string.Empty : obj.ITEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("M_9_VALUE"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.M_9_VALUE = :M_9_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":M_9_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.M_9_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("M_2_VALUE"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.M_2_VALUE = :M_2_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":M_2_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.M_2_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("M_11_VALUE"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.M_11_VALUE = :M_11_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":M_11_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.M_11_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("M_3_VALUE"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.M_3_VALUE = :M_3_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":M_3_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.M_3_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("M_12_VALUE"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.M_12_VALUE = :M_12_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":M_12_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.M_12_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("M_7_VALUE"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.M_7_VALUE = :M_7_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":M_7_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.M_7_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("M_1_VALUE"))
			{
				strBuf.Add("  BGT_B_CPN_HIS_DATA_D.M_1_VALUE = :M_1_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":M_1_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.M_1_VALUE;
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
