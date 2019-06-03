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
	[CauseObject(typeof(CauseObject_SCM_D_MATER))]
	public partial class HelperObject_SCM_D_MATER
	{		
		#region Method Blok
		public static int Save(EntityObject_SCM_D_MATER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into SCM_D_MATER( ID, CODE, BKLAS, COMMENTS, FREEUSE1, FREEUSE3, CREATE_USER_ID, DATA_ORGANISE_ID, GYSACCOUNT, CREATE_DEPART_ID, CREATE_TIME, SPEC, TXZ01, MATNR, PRODUCE_AREA, FREEUSE2, STATE, SPELL_CODE, NAME) values ( :ID, :CODE, :BKLAS, :COMMENTS, :FREEUSE1, :FREEUSE3, :CREATE_USER_ID, :DATA_ORGANISE_ID, :GYSACCOUNT, :CREATE_DEPART_ID, :CREATE_TIME, :SPEC, :TXZ01, :MATNR, :PRODUCE_AREA, :FREEUSE2, :STATE, :SPELL_CODE, :NAME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[19];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":CODE";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":BKLAS";
			parameters[2].Size = 20;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.BKLAS == null ? String.Empty:obj.BKLAS;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":COMMENTS";
			parameters[3].Size = 1000;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":FREEUSE1";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.FREEUSE1 == null ? String.Empty:obj.FREEUSE1;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":FREEUSE3";
			parameters[5].Size = 200;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.FREEUSE3 == null ? String.Empty:obj.FREEUSE3;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":CREATE_USER_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":DATA_ORGANISE_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":GYSACCOUNT";
			parameters[8].Size = 50;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.GYSACCOUNT == null ? String.Empty:obj.GYSACCOUNT;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":CREATE_DEPART_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.CREATE_DEPART_ID == null ? String.Empty:obj.CREATE_DEPART_ID;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":CREATE_TIME";
			parameters[10].Size = 7;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[10].Value = obj.CREATE_TIME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":SPEC";
			parameters[11].Size = 200;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":TXZ01";
			parameters[12].Size = 200;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.TXZ01 == null ? String.Empty:obj.TXZ01;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":MATNR";
			parameters[13].Size = 20;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.MATNR == null ? String.Empty:obj.MATNR;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":PRODUCE_AREA";
			parameters[14].Size = 200;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.PRODUCE_AREA == null ? String.Empty:obj.PRODUCE_AREA;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":FREEUSE2";
			parameters[15].Size = 100;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.FREEUSE2 == null ? String.Empty:obj.FREEUSE2;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":STATE";
			parameters[16].Size = 22;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[16].Value = obj.STATE;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":SPELL_CODE";
			parameters[17].Size = 20;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[17].Value = obj.SPELL_CODE == null ? String.Empty:obj.SPELL_CODE;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":NAME";
			parameters[18].Size = 200;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.NAME == null ? String.Empty:obj.NAME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SCM_D_MATER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_D_MATER set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SCM_D_MATER obj,CauseObject_SCM_D_MATER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_D_MATER set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SCM_D_MATER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SCM_D_MATER where  ID = :ID ";
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
		public static int Delete(CauseObject_SCM_D_MATER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SCM_D_MATER where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_SCM_D_MATER Get(EntityObject_SCM_D_MATER obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, MODIFY_USER_ID, CODE, BKLAS, COMMENTS, FREEUSE1, FREEUSE3, CREATE_USER_ID, DATA_ORGANISE_ID, GYSACCOUNT, CREATE_DEPART_ID, CREATE_TIME, SPEC, MODIFY_DEPART_ID, TXZ01, MODIFY_TIME, MATNR, PRODUCE_AREA, FREEUSE2, STATE, SPELL_CODE, NAME from SCM_D_MATER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_D_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_D_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BKLAS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FREEUSE3 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SPEC = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.TXZ01 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREEUSE2 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SPELL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SCM_D_MATER[] objs = new EntityObject_SCM_D_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_SCM_D_MATER Get(EntityObject_SCM_D_MATER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, MODIFY_USER_ID, CODE, BKLAS, COMMENTS, FREEUSE1, FREEUSE3, CREATE_USER_ID, DATA_ORGANISE_ID, GYSACCOUNT, CREATE_DEPART_ID, CREATE_TIME, SPEC, MODIFY_DEPART_ID, TXZ01, MODIFY_TIME, MATNR, PRODUCE_AREA, FREEUSE2, STATE, SPELL_CODE, NAME from SCM_D_MATER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_D_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_D_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BKLAS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FREEUSE3 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SPEC = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.TXZ01 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREEUSE2 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SPELL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SCM_D_MATER[] objs = new EntityObject_SCM_D_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_D_MATER[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SCM_D_MATER.ID, SCM_D_MATER.MODIFY_USER_ID, SCM_D_MATER.CODE, SCM_D_MATER.BKLAS, SCM_D_MATER.COMMENTS, SCM_D_MATER.FREEUSE1, SCM_D_MATER.FREEUSE3, SCM_D_MATER.CREATE_USER_ID, SCM_D_MATER.DATA_ORGANISE_ID, SCM_D_MATER.GYSACCOUNT, SCM_D_MATER.CREATE_DEPART_ID, SCM_D_MATER.CREATE_TIME, SCM_D_MATER.SPEC, SCM_D_MATER.MODIFY_DEPART_ID, SCM_D_MATER.TXZ01, SCM_D_MATER.MODIFY_TIME, SCM_D_MATER.MATNR, SCM_D_MATER.PRODUCE_AREA, SCM_D_MATER.FREEUSE2, SCM_D_MATER.STATE, SCM_D_MATER.SPELL_CODE, SCM_D_MATER.NAME from SCM_D_MATER where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SCM_D_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BKLAS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FREEUSE3 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SPEC = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.TXZ01 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREEUSE2 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SPELL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_D_MATER[] objs = new DisplayObject_SCM_D_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SCM_D_MATER cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And SCM_D_MATER.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And SCM_D_MATER.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And SCM_D_MATER.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.BKLAS))
			{
				strBuf.Append(" And SCM_D_MATER.BKLAS ").Append((cause.BKLAS.StartsWith("%") || cause.BKLAS.EndsWith("%")) ? " like " : " = ").Append(" :C_BKLAS");
				param = new OracleParameter();
				param.ParameterName =":C_BKLAS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.BKLAS;
				paramList.Add(param);
			}
			if (cause.HasINValue("BKLAS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "BKLAS"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And SCM_D_MATER.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE1))
			{
				strBuf.Append(" And SCM_D_MATER.FREEUSE1 ").Append((cause.FREEUSE1.StartsWith("%") || cause.FREEUSE1.EndsWith("%")) ? " like " : " = ").Append(" :C_FREEUSE1");
				param = new OracleParameter();
				param.ParameterName =":C_FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FREEUSE1;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE1"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "FREEUSE1"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE3))
			{
				strBuf.Append(" And SCM_D_MATER.FREEUSE3 ").Append((cause.FREEUSE3.StartsWith("%") || cause.FREEUSE3.EndsWith("%")) ? " like " : " = ").Append(" :C_FREEUSE3");
				param = new OracleParameter();
				param.ParameterName =":C_FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.FREEUSE3;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE3"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "FREEUSE3"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And SCM_D_MATER.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And SCM_D_MATER.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And SCM_D_MATER.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And SCM_D_MATER.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "CREATE_DEPART_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_D_MATER.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And SCM_D_MATER.CREATE_TIME < :C_CREATE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_TIME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And SCM_D_MATER.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And SCM_D_MATER.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "MODIFY_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.TXZ01))
			{
				strBuf.Append(" And SCM_D_MATER.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :C_TXZ01");
				param = new OracleParameter();
				param.ParameterName =":C_TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.TXZ01;
				paramList.Add(param);
			}
			if (cause.HasINValue("TXZ01"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "TXZ01"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_D_MATER.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And SCM_D_MATER.MODIFY_TIME < :C_MODIFY_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("MODIFY_TIME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR))
			{
				strBuf.Append(" And SCM_D_MATER.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :C_MATNR");
				param = new OracleParameter();
				param.ParameterName =":C_MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.MATNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "MATNR"));
			}
			if(!string.IsNullOrEmpty(cause.PRODUCE_AREA))
			{
				strBuf.Append(" And SCM_D_MATER.PRODUCE_AREA ").Append((cause.PRODUCE_AREA.StartsWith("%") || cause.PRODUCE_AREA.EndsWith("%")) ? " like " : " = ").Append(" :C_PRODUCE_AREA");
				param = new OracleParameter();
				param.ParameterName =":C_PRODUCE_AREA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.PRODUCE_AREA;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRODUCE_AREA"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "PRODUCE_AREA"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE2))
			{
				strBuf.Append(" And SCM_D_MATER.FREEUSE2 ").Append((cause.FREEUSE2.StartsWith("%") || cause.FREEUSE2.EndsWith("%")) ? " like " : " = ").Append(" :C_FREEUSE2");
				param = new OracleParameter();
				param.ParameterName =":C_FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.FREEUSE2;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE2"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "FREEUSE2"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_D_MATER.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.SPELL_CODE))
			{
				strBuf.Append(" And SCM_D_MATER.SPELL_CODE ").Append((cause.SPELL_CODE.StartsWith("%") || cause.SPELL_CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.SPELL_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPELL_CODE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "SPELL_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And SCM_D_MATER.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_D_MATER", "NAME"));
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
		public static DisplayObject_SCM_D_MATER[] Query(CauseObject_SCM_D_MATER cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_D_MATER.ID, SCM_D_MATER.MODIFY_USER_ID, SCM_D_MATER.CODE, SCM_D_MATER.BKLAS, SCM_D_MATER.COMMENTS, SCM_D_MATER.FREEUSE1, SCM_D_MATER.FREEUSE3, SCM_D_MATER.CREATE_USER_ID, SCM_D_MATER.DATA_ORGANISE_ID, SCM_D_MATER.GYSACCOUNT, SCM_D_MATER.CREATE_DEPART_ID, SCM_D_MATER.CREATE_TIME, SCM_D_MATER.SPEC, SCM_D_MATER.MODIFY_DEPART_ID, SCM_D_MATER.TXZ01, SCM_D_MATER.MODIFY_TIME, SCM_D_MATER.MATNR, SCM_D_MATER.PRODUCE_AREA, SCM_D_MATER.FREEUSE2, SCM_D_MATER.STATE, SCM_D_MATER.SPELL_CODE, SCM_D_MATER.NAME from SCM_D_MATER where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_D_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BKLAS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FREEUSE3 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SPEC = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.TXZ01 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREEUSE2 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SPELL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_D_MATER[] objs = new DisplayObject_SCM_D_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_SCM_D_MATER[] Query(CauseObject_SCM_D_MATER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_D_MATER.ID, SCM_D_MATER.MODIFY_USER_ID, SCM_D_MATER.CODE, SCM_D_MATER.BKLAS, SCM_D_MATER.COMMENTS, SCM_D_MATER.FREEUSE1, SCM_D_MATER.FREEUSE3, SCM_D_MATER.CREATE_USER_ID, SCM_D_MATER.DATA_ORGANISE_ID, SCM_D_MATER.GYSACCOUNT, SCM_D_MATER.CREATE_DEPART_ID, SCM_D_MATER.CREATE_TIME, SCM_D_MATER.SPEC, SCM_D_MATER.MODIFY_DEPART_ID, SCM_D_MATER.TXZ01, SCM_D_MATER.MODIFY_TIME, SCM_D_MATER.MATNR, SCM_D_MATER.PRODUCE_AREA, SCM_D_MATER.FREEUSE2, SCM_D_MATER.STATE, SCM_D_MATER.SPELL_CODE, SCM_D_MATER.NAME from SCM_D_MATER where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_D_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BKLAS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FREEUSE3 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SPEC = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.TXZ01 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREEUSE2 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SPELL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_D_MATER[] objs = new DisplayObject_SCM_D_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_D_MATER[] Query(CauseObject_SCM_D_MATER cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_D_MATER.ID, SCM_D_MATER.MODIFY_USER_ID, SCM_D_MATER.CODE, SCM_D_MATER.BKLAS, SCM_D_MATER.COMMENTS, SCM_D_MATER.FREEUSE1, SCM_D_MATER.FREEUSE3, SCM_D_MATER.CREATE_USER_ID, SCM_D_MATER.DATA_ORGANISE_ID, SCM_D_MATER.GYSACCOUNT, SCM_D_MATER.CREATE_DEPART_ID, SCM_D_MATER.CREATE_TIME, SCM_D_MATER.SPEC, SCM_D_MATER.MODIFY_DEPART_ID, SCM_D_MATER.TXZ01, SCM_D_MATER.MODIFY_TIME, SCM_D_MATER.MATNR, SCM_D_MATER.PRODUCE_AREA, SCM_D_MATER.FREEUSE2, SCM_D_MATER.STATE, SCM_D_MATER.SPELL_CODE, SCM_D_MATER.NAME from SCM_D_MATER where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_D_MATER",paging, order, sSql, parameters, connection);
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
			DisplayObject_SCM_D_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BKLAS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FREEUSE3 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SPEC = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.TXZ01 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREEUSE2 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SPELL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_D_MATER[] objs = new DisplayObject_SCM_D_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_D_MATER[] Query(CauseObject_SCM_D_MATER cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_D_MATER.ID, SCM_D_MATER.MODIFY_USER_ID, SCM_D_MATER.CODE, SCM_D_MATER.BKLAS, SCM_D_MATER.COMMENTS, SCM_D_MATER.FREEUSE1, SCM_D_MATER.FREEUSE3, SCM_D_MATER.CREATE_USER_ID, SCM_D_MATER.DATA_ORGANISE_ID, SCM_D_MATER.GYSACCOUNT, SCM_D_MATER.CREATE_DEPART_ID, SCM_D_MATER.CREATE_TIME, SCM_D_MATER.SPEC, SCM_D_MATER.MODIFY_DEPART_ID, SCM_D_MATER.TXZ01, SCM_D_MATER.MODIFY_TIME, SCM_D_MATER.MATNR, SCM_D_MATER.PRODUCE_AREA, SCM_D_MATER.FREEUSE2, SCM_D_MATER.STATE, SCM_D_MATER.SPELL_CODE, SCM_D_MATER.NAME from SCM_D_MATER where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_D_MATER",paging, order, sSql, parameters, trans);
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
			DisplayObject_SCM_D_MATER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_D_MATER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CODE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BKLAS = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.COMMENTS = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREEUSE1 = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FREEUSE3 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SPEC = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.TXZ01 = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MATNR = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FREEUSE2 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.STATE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.SPELL_CODE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.NAME = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_D_MATER[] objs = new DisplayObject_SCM_D_MATER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SCM_D_MATER obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  SCM_D_MATER.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  SCM_D_MATER.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BKLAS"))
			{
				strBuf.Add("  SCM_D_MATER.BKLAS = :U_BKLAS");
				param = new OracleParameter();
				param.ParameterName = ":U_BKLAS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.BKLAS) ? string.Empty : obj.BKLAS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  SCM_D_MATER.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE1"))
			{
				strBuf.Add("  SCM_D_MATER.FREEUSE1 = :U_FREEUSE1");
				param = new OracleParameter();
				param.ParameterName = ":U_FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE1) ? string.Empty : obj.FREEUSE1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE3"))
			{
				strBuf.Add("  SCM_D_MATER.FREEUSE3 = :U_FREEUSE3");
				param = new OracleParameter();
				param.ParameterName = ":U_FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE3) ? string.Empty : obj.FREEUSE3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  SCM_D_MATER.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  SCM_D_MATER.GYSACCOUNT = :U_GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  SCM_D_MATER.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  SCM_D_MATER.MODIFY_DEPART_ID = :U_MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TXZ01"))
			{
				strBuf.Add("  SCM_D_MATER.TXZ01 = :U_TXZ01");
				param = new OracleParameter();
				param.ParameterName = ":U_TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.TXZ01) ? string.Empty : obj.TXZ01;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  SCM_D_MATER.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATNR"))
			{
				strBuf.Add("  SCM_D_MATER.MATNR = :U_MATNR");
				param = new OracleParameter();
				param.ParameterName = ":U_MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.MATNR) ? string.Empty : obj.MATNR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRODUCE_AREA"))
			{
				strBuf.Add("  SCM_D_MATER.PRODUCE_AREA = :U_PRODUCE_AREA");
				param = new OracleParameter();
				param.ParameterName = ":U_PRODUCE_AREA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.PRODUCE_AREA) ? string.Empty : obj.PRODUCE_AREA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE2"))
			{
				strBuf.Add("  SCM_D_MATER.FREEUSE2 = :U_FREEUSE2");
				param = new OracleParameter();
				param.ParameterName = ":U_FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE2) ? string.Empty : obj.FREEUSE2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  SCM_D_MATER.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPELL_CODE"))
			{
				strBuf.Add("  SCM_D_MATER.SPELL_CODE = :U_SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.SPELL_CODE) ? string.Empty : obj.SPELL_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  SCM_D_MATER.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			//pk here
			if(appendpk)
			{
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = obj.ID;
				paramList.Add(param);
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		#endregion 
	}
}
