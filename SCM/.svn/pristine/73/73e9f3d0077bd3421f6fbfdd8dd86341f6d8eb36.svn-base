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
	[CauseObject(typeof(CauseObject_V_SCM_D_MATER_MDM))]
	public partial class HelperObject_V_SCM_D_MATER_MDM
	{		
		#region Method Blok
		public static int Save(EntityObject_V_SCM_D_MATER_MDM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_SCM_D_MATER_MDM( SPELL_CODE, SPEC, ID, FREEUSE3, FREEUSE2, PRODUCE_AREA, GYSACCOUNT, TXZ01, MATNR, GYS_NAME, FREEUSE1) values ( :SPELL_CODE, :SPEC, :ID, :FREEUSE3, :FREEUSE2, :PRODUCE_AREA, :GYSACCOUNT, :TXZ01, :MATNR, :GYS_NAME, :FREEUSE1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[11];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":SPELL_CODE";
			parameters[0].Size = 20;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.SPELL_CODE == null ? String.Empty:obj.SPELL_CODE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":SPEC";
			parameters[1].Size = 200;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":FREEUSE3";
			parameters[3].Size = 200;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.FREEUSE3 == null ? String.Empty:obj.FREEUSE3;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":FREEUSE2";
			parameters[4].Size = 100;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.FREEUSE2 == null ? String.Empty:obj.FREEUSE2;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":PRODUCE_AREA";
			parameters[5].Size = 200;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.PRODUCE_AREA == null ? String.Empty:obj.PRODUCE_AREA;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":GYSACCOUNT";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.GYSACCOUNT == null ? String.Empty:obj.GYSACCOUNT;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":TXZ01";
			parameters[7].Size = 200;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.TXZ01 == null ? String.Empty:obj.TXZ01;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":MATNR";
			parameters[8].Size = 20;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.MATNR == null ? String.Empty:obj.MATNR;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":GYS_NAME";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.GYS_NAME == null ? String.Empty:obj.GYS_NAME;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":FREEUSE1";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.FREEUSE1 == null ? String.Empty:obj.FREEUSE1;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_SCM_D_MATER_MDM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_SCM_D_MATER_MDM set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_SCM_D_MATER_MDM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_SCM_D_MATER_MDM where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_SCM_D_MATER_MDM Get(EntityObject_V_SCM_D_MATER_MDM obj)
		{
			
			//平台自动生成代码
			string sSql = "select  SPELL_CODE, SPEC, ID, FREEUSE3, FREEUSE2, PRODUCE_AREA, GYSACCOUNT, TXZ01, MATNR, GYS_NAME, FREEUSE1 from V_SCM_D_MATER_MDM where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_D_MATER_MDM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_D_MATER_MDM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE2 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.TXZ01 = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MATNR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYS_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREEUSE1 = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_SCM_D_MATER_MDM[] objs = new EntityObject_V_SCM_D_MATER_MDM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_SCM_D_MATER_MDM Get(EntityObject_V_SCM_D_MATER_MDM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  SPELL_CODE, SPEC, ID, FREEUSE3, FREEUSE2, PRODUCE_AREA, GYSACCOUNT, TXZ01, MATNR, GYS_NAME, FREEUSE1 from V_SCM_D_MATER_MDM where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_D_MATER_MDM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_D_MATER_MDM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE2 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.TXZ01 = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MATNR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYS_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREEUSE1 = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_SCM_D_MATER_MDM[] objs = new EntityObject_V_SCM_D_MATER_MDM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_SCM_D_MATER_MDM[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_SCM_D_MATER_MDM.SPELL_CODE, V_SCM_D_MATER_MDM.SPEC, V_SCM_D_MATER_MDM.ID, V_SCM_D_MATER_MDM.FREEUSE3, V_SCM_D_MATER_MDM.FREEUSE2, V_SCM_D_MATER_MDM.PRODUCE_AREA, V_SCM_D_MATER_MDM.GYSACCOUNT, V_SCM_D_MATER_MDM.TXZ01, V_SCM_D_MATER_MDM.MATNR, V_SCM_D_MATER_MDM.GYS_NAME, V_SCM_D_MATER_MDM.FREEUSE1 from V_SCM_D_MATER_MDM where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_SCM_D_MATER_MDM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_MATER_MDM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE2 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.TXZ01 = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MATNR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYS_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREEUSE1 = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_MATER_MDM[] objs = new DisplayObject_V_SCM_D_MATER_MDM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_SCM_D_MATER_MDM cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.SPELL_CODE))
			{
				strBuf.Append(" And V_SCM_D_MATER_MDM.SPELL_CODE ").Append((cause.SPELL_CODE.StartsWith("%") || cause.SPELL_CODE.EndsWith("%")) ? " like " : " = ").Append(" :SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName =":SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.SPELL_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPELL_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_MDM", "SPELL_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And V_SCM_D_MATER_MDM.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :SPEC");
				param = new OracleParameter();
				param.ParameterName =":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_MDM", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_SCM_D_MATER_MDM.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_MDM", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE3))
			{
				strBuf.Append(" And V_SCM_D_MATER_MDM.FREEUSE3 ").Append((cause.FREEUSE3.StartsWith("%") || cause.FREEUSE3.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE3");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.FREEUSE3;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE3"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_MDM", "FREEUSE3"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE2))
			{
				strBuf.Append(" And V_SCM_D_MATER_MDM.FREEUSE2 ").Append((cause.FREEUSE2.StartsWith("%") || cause.FREEUSE2.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE2");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.FREEUSE2;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE2"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_MDM", "FREEUSE2"));
			}
			if(!string.IsNullOrEmpty(cause.PRODUCE_AREA))
			{
				strBuf.Append(" And V_SCM_D_MATER_MDM.PRODUCE_AREA ").Append((cause.PRODUCE_AREA.StartsWith("%") || cause.PRODUCE_AREA.EndsWith("%")) ? " like " : " = ").Append(" :PRODUCE_AREA");
				param = new OracleParameter();
				param.ParameterName =":PRODUCE_AREA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.PRODUCE_AREA;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRODUCE_AREA"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_MDM", "PRODUCE_AREA"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And V_SCM_D_MATER_MDM.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_MDM", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.TXZ01))
			{
				strBuf.Append(" And V_SCM_D_MATER_MDM.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :TXZ01");
				param = new OracleParameter();
				param.ParameterName =":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.TXZ01;
				paramList.Add(param);
			}
			if (cause.HasINValue("TXZ01"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_MDM", "TXZ01"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR))
			{
				strBuf.Append(" And V_SCM_D_MATER_MDM.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :MATNR");
				param = new OracleParameter();
				param.ParameterName =":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.MATNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_MDM", "MATNR"));
			}
			if(!string.IsNullOrEmpty(cause.GYS_NAME))
			{
				strBuf.Append(" And V_SCM_D_MATER_MDM.GYS_NAME ").Append((cause.GYS_NAME.StartsWith("%") || cause.GYS_NAME.EndsWith("%")) ? " like " : " = ").Append(" :GYS_NAME");
				param = new OracleParameter();
				param.ParameterName =":GYS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYS_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYS_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_MDM", "GYS_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE1))
			{
				strBuf.Append(" And V_SCM_D_MATER_MDM.FREEUSE1 ").Append((cause.FREEUSE1.StartsWith("%") || cause.FREEUSE1.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE1");
				param = new OracleParameter();
				param.ParameterName =":FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FREEUSE1;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE1"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_MATER_MDM", "FREEUSE1"));
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
		public static DisplayObject_V_SCM_D_MATER_MDM[] Query(CauseObject_V_SCM_D_MATER_MDM cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_D_MATER_MDM.SPELL_CODE, V_SCM_D_MATER_MDM.SPEC, V_SCM_D_MATER_MDM.ID, V_SCM_D_MATER_MDM.FREEUSE3, V_SCM_D_MATER_MDM.FREEUSE2, V_SCM_D_MATER_MDM.PRODUCE_AREA, V_SCM_D_MATER_MDM.GYSACCOUNT, V_SCM_D_MATER_MDM.TXZ01, V_SCM_D_MATER_MDM.MATNR, V_SCM_D_MATER_MDM.GYS_NAME, V_SCM_D_MATER_MDM.FREEUSE1 from V_SCM_D_MATER_MDM where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_D_MATER_MDM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_MATER_MDM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE2 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.TXZ01 = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MATNR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYS_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREEUSE1 = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_MATER_MDM[] objs = new DisplayObject_V_SCM_D_MATER_MDM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_SCM_D_MATER_MDM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_SCM_D_MATER_MDM where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_SCM_D_MATER_MDM[] Query(CauseObject_V_SCM_D_MATER_MDM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_D_MATER_MDM.SPELL_CODE, V_SCM_D_MATER_MDM.SPEC, V_SCM_D_MATER_MDM.ID, V_SCM_D_MATER_MDM.FREEUSE3, V_SCM_D_MATER_MDM.FREEUSE2, V_SCM_D_MATER_MDM.PRODUCE_AREA, V_SCM_D_MATER_MDM.GYSACCOUNT, V_SCM_D_MATER_MDM.TXZ01, V_SCM_D_MATER_MDM.MATNR, V_SCM_D_MATER_MDM.GYS_NAME, V_SCM_D_MATER_MDM.FREEUSE1 from V_SCM_D_MATER_MDM where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_D_MATER_MDM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_MATER_MDM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE2 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.TXZ01 = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MATNR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYS_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREEUSE1 = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_D_MATER_MDM[] objs = new DisplayObject_V_SCM_D_MATER_MDM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_D_MATER_MDM[] Query(CauseObject_V_SCM_D_MATER_MDM cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_D_MATER_MDM.SPELL_CODE, V_SCM_D_MATER_MDM.SPEC, V_SCM_D_MATER_MDM.ID, V_SCM_D_MATER_MDM.FREEUSE3, V_SCM_D_MATER_MDM.FREEUSE2, V_SCM_D_MATER_MDM.PRODUCE_AREA, V_SCM_D_MATER_MDM.GYSACCOUNT, V_SCM_D_MATER_MDM.TXZ01, V_SCM_D_MATER_MDM.MATNR, V_SCM_D_MATER_MDM.GYS_NAME, V_SCM_D_MATER_MDM.FREEUSE1 from V_SCM_D_MATER_MDM where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_D_MATER_MDM",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_SCM_D_MATER_MDM dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_MATER_MDM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE2 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.TXZ01 = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MATNR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYS_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREEUSE1 = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_MATER_MDM[] objs = new DisplayObject_V_SCM_D_MATER_MDM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_D_MATER_MDM[] Query(CauseObject_V_SCM_D_MATER_MDM cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_D_MATER_MDM.SPELL_CODE, V_SCM_D_MATER_MDM.SPEC, V_SCM_D_MATER_MDM.ID, V_SCM_D_MATER_MDM.FREEUSE3, V_SCM_D_MATER_MDM.FREEUSE2, V_SCM_D_MATER_MDM.PRODUCE_AREA, V_SCM_D_MATER_MDM.GYSACCOUNT, V_SCM_D_MATER_MDM.TXZ01, V_SCM_D_MATER_MDM.MATNR, V_SCM_D_MATER_MDM.GYS_NAME, V_SCM_D_MATER_MDM.FREEUSE1 from V_SCM_D_MATER_MDM where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_D_MATER_MDM",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_SCM_D_MATER_MDM dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_MATER_MDM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.FREEUSE3 = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FREEUSE2 = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.TXZ01 = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MATNR = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYS_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FREEUSE1 = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_D_MATER_MDM[] objs = new DisplayObject_V_SCM_D_MATER_MDM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_SCM_D_MATER_MDM obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("SPELL_CODE"))
			{
				strBuf.Add("  V_SCM_D_MATER_MDM.SPELL_CODE = :SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName = ":SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.SPELL_CODE) ? string.Empty : obj.SPELL_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  V_SCM_D_MATER_MDM.SPEC = :SPEC");
				param = new OracleParameter();
				param.ParameterName = ":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_SCM_D_MATER_MDM.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE3"))
			{
				strBuf.Add("  V_SCM_D_MATER_MDM.FREEUSE3 = :FREEUSE3");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE3";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE3) ? string.Empty : obj.FREEUSE3;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE2"))
			{
				strBuf.Add("  V_SCM_D_MATER_MDM.FREEUSE2 = :FREEUSE2");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE2) ? string.Empty : obj.FREEUSE2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRODUCE_AREA"))
			{
				strBuf.Add("  V_SCM_D_MATER_MDM.PRODUCE_AREA = :PRODUCE_AREA");
				param = new OracleParameter();
				param.ParameterName = ":PRODUCE_AREA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.PRODUCE_AREA) ? string.Empty : obj.PRODUCE_AREA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  V_SCM_D_MATER_MDM.GYSACCOUNT = :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TXZ01"))
			{
				strBuf.Add("  V_SCM_D_MATER_MDM.TXZ01 = :TXZ01");
				param = new OracleParameter();
				param.ParameterName = ":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.TXZ01) ? string.Empty : obj.TXZ01;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATNR"))
			{
				strBuf.Add("  V_SCM_D_MATER_MDM.MATNR = :MATNR");
				param = new OracleParameter();
				param.ParameterName = ":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.MATNR) ? string.Empty : obj.MATNR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYS_NAME"))
			{
				strBuf.Add("  V_SCM_D_MATER_MDM.GYS_NAME = :GYS_NAME");
				param = new OracleParameter();
				param.ParameterName = ":GYS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYS_NAME) ? string.Empty : obj.GYS_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE1"))
			{
				strBuf.Add("  V_SCM_D_MATER_MDM.FREEUSE1 = :FREEUSE1");
				param = new OracleParameter();
				param.ParameterName = ":FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE1) ? string.Empty : obj.FREEUSE1;
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
