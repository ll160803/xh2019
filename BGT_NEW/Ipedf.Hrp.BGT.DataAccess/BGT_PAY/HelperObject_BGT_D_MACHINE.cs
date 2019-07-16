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
	[CauseObject(typeof(CauseObject_BGT_D_MACHINE))]
	public partial class HelperObject_BGT_D_MACHINE
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_D_MACHINE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_D_MACHINE( BASEID, ID, INSTALL, CONDITION, PROJECT, FREQUENCY, BUY, NUM, SPEC, NEED, NO, PRICE, MAN) values ( :BASEID, :ID, :INSTALL, :CONDITION, :PROJECT, :FREQUENCY, :BUY, :NUM, :SPEC, :NEED, :NO, :PRICE, :MAN)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[13];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":BASEID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.BASEID == null ? String.Empty:obj.BASEID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":INSTALL";
			parameters[2].Size = 255;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.INSTALL == null ? String.Empty:obj.INSTALL;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":CONDITION";
			parameters[3].Size = 255;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.CONDITION == null ? String.Empty:obj.CONDITION;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":PROJECT";
			parameters[4].Size = 255;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.PROJECT == null ? String.Empty:obj.PROJECT;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":FREQUENCY";
			parameters[5].Size = 255;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.FREQUENCY == null ? String.Empty:obj.FREQUENCY;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":BUY";
			parameters[6].Size = 255;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.BUY == null ? String.Empty:obj.BUY;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":NUM";
			parameters[7].Size = 255;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.NUM == null ? String.Empty:obj.NUM;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":SPEC";
			parameters[8].Size = 255;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":NEED";
			parameters[9].Size = 255;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.NEED == null ? String.Empty:obj.NEED;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":NO";
			parameters[10].Size = 255;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.NO == null ? String.Empty:obj.NO;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":PRICE";
			parameters[11].Size = 255;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.PRICE == null ? String.Empty:obj.PRICE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":MAN";
			parameters[12].Size = 255;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.MAN == null ? String.Empty:obj.MAN;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_D_MACHINE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_D_MACHINE set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_D_MACHINE obj,CauseObject_BGT_D_MACHINE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_D_MACHINE set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_D_MACHINE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_D_MACHINE where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_BGT_D_MACHINE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_D_MACHINE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_BGT_D_MACHINE Get(EntityObject_BGT_D_MACHINE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  BASEID, ID, INSTALL, CONDITION, PROJECT, FREQUENCY, BUY, NUM, SPEC, NEED, NO, PRICE, MAN from BGT_D_MACHINE where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_BGT_D_MACHINE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_D_MACHINE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASEID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INSTALL = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CONDITION = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PROJECT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREQUENCY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUY = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NUM = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NEED = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NO = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRICE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MAN = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_D_MACHINE[] objs = new EntityObject_BGT_D_MACHINE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_D_MACHINE Get(EntityObject_BGT_D_MACHINE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  BASEID, ID, INSTALL, CONDITION, PROJECT, FREQUENCY, BUY, NUM, SPEC, NEED, NO, PRICE, MAN from BGT_D_MACHINE where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_BGT_D_MACHINE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_D_MACHINE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASEID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INSTALL = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CONDITION = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PROJECT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREQUENCY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUY = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NUM = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NEED = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NO = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRICE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MAN = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_D_MACHINE[] objs = new EntityObject_BGT_D_MACHINE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_D_MACHINE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_D_MACHINE.BASEID, BGT_D_MACHINE.ID, BGT_D_MACHINE.INSTALL, BGT_D_MACHINE.CONDITION, BGT_D_MACHINE.PROJECT, BGT_D_MACHINE.FREQUENCY, BGT_D_MACHINE.BUY, BGT_D_MACHINE.NUM, BGT_D_MACHINE.SPEC, BGT_D_MACHINE.NEED, BGT_D_MACHINE.NO, BGT_D_MACHINE.PRICE, BGT_D_MACHINE.MAN from BGT_D_MACHINE where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_D_MACHINE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_MACHINE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASEID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INSTALL = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CONDITION = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PROJECT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREQUENCY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUY = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NUM = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NEED = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NO = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRICE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MAN = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_MACHINE[] objs = new DisplayObject_BGT_D_MACHINE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_D_MACHINE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.BASEID))
			{
				strBuf.Append(" And BGT_D_MACHINE.BASEID ").Append((cause.BASEID.StartsWith("%") || cause.BASEID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASEID");
				param = new OracleParameter();
				param.ParameterName =":C_BASEID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 36;
				param.Value = cause.BASEID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASEID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_MACHINE", "BASEID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And BGT_D_MACHINE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_MACHINE", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.INSTALL))
			{
				strBuf.Append(" And BGT_D_MACHINE.INSTALL ").Append((cause.INSTALL.StartsWith("%") || cause.INSTALL.EndsWith("%")) ? " like " : " = ").Append(" :C_INSTALL");
				param = new OracleParameter();
				param.ParameterName =":C_INSTALL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = cause.INSTALL;
				paramList.Add(param);
			}
			if (cause.HasINValue("INSTALL"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_MACHINE", "INSTALL"));
			}
			if(!string.IsNullOrEmpty(cause.CONDITION))
			{
				strBuf.Append(" And BGT_D_MACHINE.CONDITION ").Append((cause.CONDITION.StartsWith("%") || cause.CONDITION.EndsWith("%")) ? " like " : " = ").Append(" :C_CONDITION");
				param = new OracleParameter();
				param.ParameterName =":C_CONDITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = cause.CONDITION;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONDITION"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_MACHINE", "CONDITION"));
			}
			if(!string.IsNullOrEmpty(cause.PROJECT))
			{
				strBuf.Append(" And BGT_D_MACHINE.PROJECT ").Append((cause.PROJECT.StartsWith("%") || cause.PROJECT.EndsWith("%")) ? " like " : " = ").Append(" :C_PROJECT");
				param = new OracleParameter();
				param.ParameterName =":C_PROJECT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = cause.PROJECT;
				paramList.Add(param);
			}
			if (cause.HasINValue("PROJECT"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_MACHINE", "PROJECT"));
			}
			if(!string.IsNullOrEmpty(cause.FREQUENCY))
			{
				strBuf.Append(" And BGT_D_MACHINE.FREQUENCY ").Append((cause.FREQUENCY.StartsWith("%") || cause.FREQUENCY.EndsWith("%")) ? " like " : " = ").Append(" :C_FREQUENCY");
				param = new OracleParameter();
				param.ParameterName =":C_FREQUENCY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = cause.FREQUENCY;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREQUENCY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_MACHINE", "FREQUENCY"));
			}
			if(!string.IsNullOrEmpty(cause.BUY))
			{
				strBuf.Append(" And BGT_D_MACHINE.BUY ").Append((cause.BUY.StartsWith("%") || cause.BUY.EndsWith("%")) ? " like " : " = ").Append(" :C_BUY");
				param = new OracleParameter();
				param.ParameterName =":C_BUY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = cause.BUY;
				paramList.Add(param);
			}
			if (cause.HasINValue("BUY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_MACHINE", "BUY"));
			}
			if(!string.IsNullOrEmpty(cause.NUM))
			{
				strBuf.Append(" And BGT_D_MACHINE.NUM ").Append((cause.NUM.StartsWith("%") || cause.NUM.EndsWith("%")) ? " like " : " = ").Append(" :C_NUM");
				param = new OracleParameter();
				param.ParameterName =":C_NUM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = cause.NUM;
				paramList.Add(param);
			}
			if (cause.HasINValue("NUM"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_MACHINE", "NUM"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And BGT_D_MACHINE.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_MACHINE", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.NEED))
			{
				strBuf.Append(" And BGT_D_MACHINE.NEED ").Append((cause.NEED.StartsWith("%") || cause.NEED.EndsWith("%")) ? " like " : " = ").Append(" :C_NEED");
				param = new OracleParameter();
				param.ParameterName =":C_NEED";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = cause.NEED;
				paramList.Add(param);
			}
			if (cause.HasINValue("NEED"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_MACHINE", "NEED"));
			}
			if(!string.IsNullOrEmpty(cause.NO))
			{
				strBuf.Append(" And BGT_D_MACHINE.NO ").Append((cause.NO.StartsWith("%") || cause.NO.EndsWith("%")) ? " like " : " = ").Append(" :C_NO");
				param = new OracleParameter();
				param.ParameterName =":C_NO";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = cause.NO;
				paramList.Add(param);
			}
			if (cause.HasINValue("NO"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_MACHINE", "NO"));
			}
			if(!string.IsNullOrEmpty(cause.PRICE))
			{
				strBuf.Append(" And BGT_D_MACHINE.PRICE ").Append((cause.PRICE.StartsWith("%") || cause.PRICE.EndsWith("%")) ? " like " : " = ").Append(" :C_PRICE");
				param = new OracleParameter();
				param.ParameterName =":C_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = cause.PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRICE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_MACHINE", "PRICE"));
			}
			if(!string.IsNullOrEmpty(cause.MAN))
			{
				strBuf.Append(" And BGT_D_MACHINE.MAN ").Append((cause.MAN.StartsWith("%") || cause.MAN.EndsWith("%")) ? " like " : " = ").Append(" :C_MAN");
				param = new OracleParameter();
				param.ParameterName =":C_MAN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = cause.MAN;
				paramList.Add(param);
			}
			if (cause.HasINValue("MAN"))
			{
				strBuf.Append(cause.GetINSQL("BGT_D_MACHINE", "MAN"));
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
		public static DisplayObject_BGT_D_MACHINE[] Query(CauseObject_BGT_D_MACHINE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_D_MACHINE.BASEID, BGT_D_MACHINE.ID, BGT_D_MACHINE.INSTALL, BGT_D_MACHINE.CONDITION, BGT_D_MACHINE.PROJECT, BGT_D_MACHINE.FREQUENCY, BGT_D_MACHINE.BUY, BGT_D_MACHINE.NUM, BGT_D_MACHINE.SPEC, BGT_D_MACHINE.NEED, BGT_D_MACHINE.NO, BGT_D_MACHINE.PRICE, BGT_D_MACHINE.MAN from BGT_D_MACHINE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_D_MACHINE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_MACHINE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASEID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INSTALL = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CONDITION = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PROJECT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREQUENCY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUY = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NUM = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NEED = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NO = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRICE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MAN = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_MACHINE[] objs = new DisplayObject_BGT_D_MACHINE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_BGT_D_MACHINE[] Query(CauseObject_BGT_D_MACHINE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_D_MACHINE.BASEID, BGT_D_MACHINE.ID, BGT_D_MACHINE.INSTALL, BGT_D_MACHINE.CONDITION, BGT_D_MACHINE.PROJECT, BGT_D_MACHINE.FREQUENCY, BGT_D_MACHINE.BUY, BGT_D_MACHINE.NUM, BGT_D_MACHINE.SPEC, BGT_D_MACHINE.NEED, BGT_D_MACHINE.NO, BGT_D_MACHINE.PRICE, BGT_D_MACHINE.MAN from BGT_D_MACHINE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_D_MACHINE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_MACHINE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASEID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INSTALL = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CONDITION = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PROJECT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREQUENCY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUY = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NUM = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NEED = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NO = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRICE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MAN = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_D_MACHINE[] objs = new DisplayObject_BGT_D_MACHINE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_D_MACHINE[] Query(CauseObject_BGT_D_MACHINE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_D_MACHINE.BASEID, BGT_D_MACHINE.ID, BGT_D_MACHINE.INSTALL, BGT_D_MACHINE.CONDITION, BGT_D_MACHINE.PROJECT, BGT_D_MACHINE.FREQUENCY, BGT_D_MACHINE.BUY, BGT_D_MACHINE.NUM, BGT_D_MACHINE.SPEC, BGT_D_MACHINE.NEED, BGT_D_MACHINE.NO, BGT_D_MACHINE.PRICE, BGT_D_MACHINE.MAN from BGT_D_MACHINE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_MACHINE",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_D_MACHINE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_MACHINE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASEID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INSTALL = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CONDITION = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PROJECT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREQUENCY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUY = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NUM = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NEED = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NO = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRICE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MAN = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_D_MACHINE[] objs = new DisplayObject_BGT_D_MACHINE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_D_MACHINE[] Query(CauseObject_BGT_D_MACHINE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_D_MACHINE.BASEID, BGT_D_MACHINE.ID, BGT_D_MACHINE.INSTALL, BGT_D_MACHINE.CONDITION, BGT_D_MACHINE.PROJECT, BGT_D_MACHINE.FREQUENCY, BGT_D_MACHINE.BUY, BGT_D_MACHINE.NUM, BGT_D_MACHINE.SPEC, BGT_D_MACHINE.NEED, BGT_D_MACHINE.NO, BGT_D_MACHINE.PRICE, BGT_D_MACHINE.MAN from BGT_D_MACHINE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_MACHINE",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_D_MACHINE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_D_MACHINE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.BASEID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INSTALL = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CONDITION = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PROJECT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FREQUENCY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BUY = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.NUM = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SPEC = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.NEED = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.NO = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PRICE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MAN = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_D_MACHINE[] objs = new DisplayObject_BGT_D_MACHINE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_D_MACHINE obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("BASEID"))
			{
				strBuf.Add("  BGT_D_MACHINE.BASEID = :U_BASEID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASEID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASEID) ? string.Empty : obj.BASEID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  BGT_D_MACHINE.ID = :U_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INSTALL"))
			{
				strBuf.Add("  BGT_D_MACHINE.INSTALL = :U_INSTALL");
				param = new OracleParameter();
				param.ParameterName = ":U_INSTALL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = string.IsNullOrEmpty(obj.INSTALL) ? string.Empty : obj.INSTALL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONDITION"))
			{
				strBuf.Add("  BGT_D_MACHINE.CONDITION = :U_CONDITION");
				param = new OracleParameter();
				param.ParameterName = ":U_CONDITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = string.IsNullOrEmpty(obj.CONDITION) ? string.Empty : obj.CONDITION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PROJECT"))
			{
				strBuf.Add("  BGT_D_MACHINE.PROJECT = :U_PROJECT");
				param = new OracleParameter();
				param.ParameterName = ":U_PROJECT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = string.IsNullOrEmpty(obj.PROJECT) ? string.Empty : obj.PROJECT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREQUENCY"))
			{
				strBuf.Add("  BGT_D_MACHINE.FREQUENCY = :U_FREQUENCY");
				param = new OracleParameter();
				param.ParameterName = ":U_FREQUENCY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = string.IsNullOrEmpty(obj.FREQUENCY) ? string.Empty : obj.FREQUENCY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BUY"))
			{
				strBuf.Add("  BGT_D_MACHINE.BUY = :U_BUY");
				param = new OracleParameter();
				param.ParameterName = ":U_BUY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = string.IsNullOrEmpty(obj.BUY) ? string.Empty : obj.BUY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NUM"))
			{
				strBuf.Add("  BGT_D_MACHINE.NUM = :U_NUM");
				param = new OracleParameter();
				param.ParameterName = ":U_NUM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = string.IsNullOrEmpty(obj.NUM) ? string.Empty : obj.NUM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  BGT_D_MACHINE.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NEED"))
			{
				strBuf.Add("  BGT_D_MACHINE.NEED = :U_NEED");
				param = new OracleParameter();
				param.ParameterName = ":U_NEED";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = string.IsNullOrEmpty(obj.NEED) ? string.Empty : obj.NEED;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NO"))
			{
				strBuf.Add("  BGT_D_MACHINE.NO = :U_NO");
				param = new OracleParameter();
				param.ParameterName = ":U_NO";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = string.IsNullOrEmpty(obj.NO) ? string.Empty : obj.NO;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRICE"))
			{
				strBuf.Add("  BGT_D_MACHINE.PRICE = :U_PRICE");
				param = new OracleParameter();
				param.ParameterName = ":U_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = string.IsNullOrEmpty(obj.PRICE) ? string.Empty : obj.PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MAN"))
			{
				strBuf.Add("  BGT_D_MACHINE.MAN = :U_MAN");
				param = new OracleParameter();
				param.ParameterName = ":U_MAN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 255;
				param.Value = string.IsNullOrEmpty(obj.MAN) ? string.Empty : obj.MAN;
				paramList.Add(param);
			}
			//pk here
			if(appendpk)
			{
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		#endregion 
	}
}
