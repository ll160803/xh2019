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
	[CauseObject(typeof(CauseObject_V_GETSCM_COM_DRUG))]
	public partial class HelperObject_V_GETSCM_COM_DRUG
	{		
		#region Method Blok
		public static int Save(EntityObject_V_GETSCM_COM_DRUG obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_GETSCM_COM_DRUG( CODE, GYSACCOUNT, ID, HIS_NAME, FACTORY, NAME, SPEC, HIS_CODE) values ( :CODE, :GYSACCOUNT, :ID, :HIS_NAME, :FACTORY, :NAME, :SPEC, :HIS_CODE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[8];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CODE";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":GYSACCOUNT";
			parameters[1].Size = 20;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.GYSACCOUNT == null ? String.Empty:obj.GYSACCOUNT;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":HIS_NAME";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.HIS_NAME == null ? String.Empty:obj.HIS_NAME;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":FACTORY";
			parameters[4].Size = 100;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.FACTORY == null ? String.Empty:obj.FACTORY;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":NAME";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":SPEC";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":HIS_CODE";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.HIS_CODE == null ? String.Empty:obj.HIS_CODE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_GETSCM_COM_DRUG obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_GETSCM_COM_DRUG set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_GETSCM_COM_DRUG obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_GETSCM_COM_DRUG where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_GETSCM_COM_DRUG Get(EntityObject_V_GETSCM_COM_DRUG obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CODE, GYSACCOUNT, ID, HIS_NAME, FACTORY, NAME, SPEC, HIS_CODE from V_GETSCM_COM_DRUG where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_GETSCM_COM_DRUG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_GETSCM_COM_DRUG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.HIS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FACTORY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HIS_CODE = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_GETSCM_COM_DRUG[] objs = new EntityObject_V_GETSCM_COM_DRUG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_GETSCM_COM_DRUG Get(EntityObject_V_GETSCM_COM_DRUG obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CODE, GYSACCOUNT, ID, HIS_NAME, FACTORY, NAME, SPEC, HIS_CODE from V_GETSCM_COM_DRUG where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_GETSCM_COM_DRUG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_GETSCM_COM_DRUG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.HIS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FACTORY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HIS_CODE = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_GETSCM_COM_DRUG[] objs = new EntityObject_V_GETSCM_COM_DRUG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_GETSCM_COM_DRUG[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_GETSCM_COM_DRUG.CODE, V_GETSCM_COM_DRUG.GYSACCOUNT, V_GETSCM_COM_DRUG.ID, V_GETSCM_COM_DRUG.HIS_NAME, V_GETSCM_COM_DRUG.FACTORY, V_GETSCM_COM_DRUG.NAME, V_GETSCM_COM_DRUG.SPEC, V_GETSCM_COM_DRUG.HIS_CODE from V_GETSCM_COM_DRUG where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_GETSCM_COM_DRUG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_GETSCM_COM_DRUG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.HIS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FACTORY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HIS_CODE = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_GETSCM_COM_DRUG[] objs = new DisplayObject_V_GETSCM_COM_DRUG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_GETSCM_COM_DRUG cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And V_GETSCM_COM_DRUG.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_GETSCM_COM_DRUG", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And V_GETSCM_COM_DRUG.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_GETSCM_COM_DRUG", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_GETSCM_COM_DRUG.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_GETSCM_COM_DRUG", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.HIS_NAME))
			{
				strBuf.Append(" And V_GETSCM_COM_DRUG.HIS_NAME ").Append((cause.HIS_NAME.StartsWith("%") || cause.HIS_NAME.EndsWith("%")) ? " like " : " = ").Append(" :HIS_NAME");
				param = new OracleParameter();
				param.ParameterName =":HIS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.HIS_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("HIS_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_GETSCM_COM_DRUG", "HIS_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.FACTORY))
			{
				strBuf.Append(" And V_GETSCM_COM_DRUG.FACTORY ").Append((cause.FACTORY.StartsWith("%") || cause.FACTORY.EndsWith("%")) ? " like " : " = ").Append(" :FACTORY");
				param = new OracleParameter();
				param.ParameterName =":FACTORY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.FACTORY;
				paramList.Add(param);
			}
			if (cause.HasINValue("FACTORY"))
			{
				strBuf.Append(cause.GetINSQL("V_GETSCM_COM_DRUG", "FACTORY"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_GETSCM_COM_DRUG.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_GETSCM_COM_DRUG", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And V_GETSCM_COM_DRUG.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :SPEC");
				param = new OracleParameter();
				param.ParameterName =":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("V_GETSCM_COM_DRUG", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.HIS_CODE))
			{
				strBuf.Append(" And V_GETSCM_COM_DRUG.HIS_CODE ").Append((cause.HIS_CODE.StartsWith("%") || cause.HIS_CODE.EndsWith("%")) ? " like " : " = ").Append(" :HIS_CODE");
				param = new OracleParameter();
				param.ParameterName =":HIS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.HIS_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("HIS_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_GETSCM_COM_DRUG", "HIS_CODE"));
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
		public static DisplayObject_V_GETSCM_COM_DRUG[] Query(CauseObject_V_GETSCM_COM_DRUG cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_GETSCM_COM_DRUG.CODE, V_GETSCM_COM_DRUG.GYSACCOUNT, V_GETSCM_COM_DRUG.ID, V_GETSCM_COM_DRUG.HIS_NAME, V_GETSCM_COM_DRUG.FACTORY, V_GETSCM_COM_DRUG.NAME, V_GETSCM_COM_DRUG.SPEC, V_GETSCM_COM_DRUG.HIS_CODE from V_GETSCM_COM_DRUG where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_GETSCM_COM_DRUG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_GETSCM_COM_DRUG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.HIS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FACTORY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HIS_CODE = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_GETSCM_COM_DRUG[] objs = new DisplayObject_V_GETSCM_COM_DRUG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_GETSCM_COM_DRUG cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_GETSCM_COM_DRUG where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_GETSCM_COM_DRUG[] Query(CauseObject_V_GETSCM_COM_DRUG cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_GETSCM_COM_DRUG.CODE, V_GETSCM_COM_DRUG.GYSACCOUNT, V_GETSCM_COM_DRUG.ID, V_GETSCM_COM_DRUG.HIS_NAME, V_GETSCM_COM_DRUG.FACTORY, V_GETSCM_COM_DRUG.NAME, V_GETSCM_COM_DRUG.SPEC, V_GETSCM_COM_DRUG.HIS_CODE from V_GETSCM_COM_DRUG where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_GETSCM_COM_DRUG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_GETSCM_COM_DRUG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.HIS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FACTORY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HIS_CODE = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_GETSCM_COM_DRUG[] objs = new DisplayObject_V_GETSCM_COM_DRUG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_GETSCM_COM_DRUG[] Query(CauseObject_V_GETSCM_COM_DRUG cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_GETSCM_COM_DRUG.CODE, V_GETSCM_COM_DRUG.GYSACCOUNT, V_GETSCM_COM_DRUG.ID, V_GETSCM_COM_DRUG.HIS_NAME, V_GETSCM_COM_DRUG.FACTORY, V_GETSCM_COM_DRUG.NAME, V_GETSCM_COM_DRUG.SPEC, V_GETSCM_COM_DRUG.HIS_CODE from V_GETSCM_COM_DRUG where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_GETSCM_COM_DRUG",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_GETSCM_COM_DRUG dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_GETSCM_COM_DRUG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.HIS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FACTORY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HIS_CODE = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_GETSCM_COM_DRUG[] objs = new DisplayObject_V_GETSCM_COM_DRUG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_GETSCM_COM_DRUG[] Query(CauseObject_V_GETSCM_COM_DRUG cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_GETSCM_COM_DRUG.CODE, V_GETSCM_COM_DRUG.GYSACCOUNT, V_GETSCM_COM_DRUG.ID, V_GETSCM_COM_DRUG.HIS_NAME, V_GETSCM_COM_DRUG.FACTORY, V_GETSCM_COM_DRUG.NAME, V_GETSCM_COM_DRUG.SPEC, V_GETSCM_COM_DRUG.HIS_CODE from V_GETSCM_COM_DRUG where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_GETSCM_COM_DRUG",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_GETSCM_COM_DRUG dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_GETSCM_COM_DRUG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.HIS_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FACTORY = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SPEC = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.HIS_CODE = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_GETSCM_COM_DRUG[] objs = new DisplayObject_V_GETSCM_COM_DRUG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_GETSCM_COM_DRUG obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  V_GETSCM_COM_DRUG.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  V_GETSCM_COM_DRUG.GYSACCOUNT = :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_GETSCM_COM_DRUG.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("HIS_NAME"))
			{
				strBuf.Add("  V_GETSCM_COM_DRUG.HIS_NAME = :HIS_NAME");
				param = new OracleParameter();
				param.ParameterName = ":HIS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.HIS_NAME) ? string.Empty : obj.HIS_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FACTORY"))
			{
				strBuf.Add("  V_GETSCM_COM_DRUG.FACTORY = :FACTORY");
				param = new OracleParameter();
				param.ParameterName = ":FACTORY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.FACTORY) ? string.Empty : obj.FACTORY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_GETSCM_COM_DRUG.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  V_GETSCM_COM_DRUG.SPEC = :SPEC");
				param = new OracleParameter();
				param.ParameterName = ":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("HIS_CODE"))
			{
				strBuf.Add("  V_GETSCM_COM_DRUG.HIS_CODE = :HIS_CODE");
				param = new OracleParameter();
				param.ParameterName = ":HIS_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.HIS_CODE) ? string.Empty : obj.HIS_CODE;
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
