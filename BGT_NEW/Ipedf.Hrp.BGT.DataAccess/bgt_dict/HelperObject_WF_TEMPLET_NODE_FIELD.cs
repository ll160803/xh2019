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
	[CauseObject(typeof(CauseObject_WF_TEMPLET_NODE_FIELD))]
	public partial class HelperObject_WF_TEMPLET_NODE_FIELD
	{		
		#region Method Blok
		public static int Save(EntityObject_WF_TEMPLET_NODE_FIELD obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "insert into WF_TEMPLET_NODE_FIELD( ID, READABLE, FIELD_ID, WRITABLE, NODE_ID) values ( :ID, :READABLE, :FIELD_ID, :WRITABLE, :NODE_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[5];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":READABLE";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.READABLE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":FIELD_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.FIELD_ID == null ? String.Empty:obj.FIELD_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":WRITABLE";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.WRITABLE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":NODE_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.NODE_ID == null ? String.Empty:obj.NODE_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_WF_TEMPLET_NODE_FIELD obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update WF_TEMPLET_NODE_FIELD set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_WF_TEMPLET_NODE_FIELD obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from WF_TEMPLET_NODE_FIELD where  ID = :ID ";
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
		public static EntityObject_WF_TEMPLET_NODE_FIELD Get(EntityObject_WF_TEMPLET_NODE_FIELD obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, READABLE, FIELD_ID, WRITABLE, NODE_ID from WF_TEMPLET_NODE_FIELD where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_WF_TEMPLET_NODE_FIELD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_WF_TEMPLET_NODE_FIELD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.READABLE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FIELD_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITABLE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NODE_ID = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_WF_TEMPLET_NODE_FIELD[] objs = new EntityObject_WF_TEMPLET_NODE_FIELD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_WF_TEMPLET_NODE_FIELD Get(EntityObject_WF_TEMPLET_NODE_FIELD obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, READABLE, FIELD_ID, WRITABLE, NODE_ID from WF_TEMPLET_NODE_FIELD where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_WF_TEMPLET_NODE_FIELD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_WF_TEMPLET_NODE_FIELD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.READABLE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FIELD_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITABLE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NODE_ID = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_WF_TEMPLET_NODE_FIELD[] objs = new EntityObject_WF_TEMPLET_NODE_FIELD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_WF_TEMPLET_NODE_FIELD[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  WF_TEMPLET_NODE_FIELD.ID, WF_TEMPLET_NODE_FIELD.READABLE, WF_TEMPLET_NODE_FIELD.FIELD_ID, WF_TEMPLET_NODE_FIELD.WRITABLE, WF_TEMPLET_NODE_FIELD.NODE_ID, (case  when WF_TEMPLET_NODE_FIELD.READABLE = 1 then '是' when WF_TEMPLET_NODE_FIELD.READABLE = 2 then '否' else '' end ) as READABLE_NAME, PAAS_OBJECT_FIELD_FIELD_ID.NAME as FIELD_ID_NAME, (case  when WF_TEMPLET_NODE_FIELD.WRITABLE = 1 then '是' when WF_TEMPLET_NODE_FIELD.WRITABLE = 2 then '否' else '' end ) as WRITABLE_NAME from WF_TEMPLET_NODE_FIELD left join PAAS_OBJECT_FIELD   PAAS_OBJECT_FIELD_FIELD_ID on WF_TEMPLET_NODE_FIELD.FIELD_ID = PAAS_OBJECT_FIELD_FIELD_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_WF_TEMPLET_NODE_FIELD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_WF_TEMPLET_NODE_FIELD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.READABLE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FIELD_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITABLE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NODE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.READABLE_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FIELD_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.WRITABLE_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_WF_TEMPLET_NODE_FIELD[] objs = new DisplayObject_WF_TEMPLET_NODE_FIELD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_WF_TEMPLET_NODE_FIELD cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And WF_TEMPLET_NODE_FIELD.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("WF_TEMPLET_NODE_FIELD", "ID"));
			}
			if(cause.READABLE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And WF_TEMPLET_NODE_FIELD.READABLE = :READABLE");
				param = new OracleParameter();
				param.ParameterName =":READABLE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.READABLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("READABLE"))
			{
				strBuf.Append(cause.GetINSQL("WF_TEMPLET_NODE_FIELD", "READABLE"));
			}
			if(cause.FIELD_ID!= string.Empty)
			{
				strBuf.Append(" And WF_TEMPLET_NODE_FIELD.FIELD_ID ").Append((cause.FIELD_ID.StartsWith("%") || cause.FIELD_ID.EndsWith("%")) ? " like " : " = ").Append(" :FIELD_ID");
				param = new OracleParameter();
				param.ParameterName =":FIELD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.FIELD_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("FIELD_ID"))
			{
				strBuf.Append(cause.GetINSQL("WF_TEMPLET_NODE_FIELD", "FIELD_ID"));
			}
			if(cause.WRITABLE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And WF_TEMPLET_NODE_FIELD.WRITABLE = :WRITABLE");
				param = new OracleParameter();
				param.ParameterName =":WRITABLE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.WRITABLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("WRITABLE"))
			{
				strBuf.Append(cause.GetINSQL("WF_TEMPLET_NODE_FIELD", "WRITABLE"));
			}
			if(cause.NODE_ID!= string.Empty)
			{
				strBuf.Append(" And WF_TEMPLET_NODE_FIELD.NODE_ID ").Append((cause.NODE_ID.StartsWith("%") || cause.NODE_ID.EndsWith("%")) ? " like " : " = ").Append(" :NODE_ID");
				param = new OracleParameter();
				param.ParameterName =":NODE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.NODE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("NODE_ID"))
			{
				strBuf.Append(cause.GetINSQL("WF_TEMPLET_NODE_FIELD", "NODE_ID"));
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
		public static DisplayObject_WF_TEMPLET_NODE_FIELD[] Query(CauseObject_WF_TEMPLET_NODE_FIELD cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  WF_TEMPLET_NODE_FIELD.ID, WF_TEMPLET_NODE_FIELD.READABLE, WF_TEMPLET_NODE_FIELD.FIELD_ID, WF_TEMPLET_NODE_FIELD.WRITABLE, WF_TEMPLET_NODE_FIELD.NODE_ID, (case  when WF_TEMPLET_NODE_FIELD.READABLE = 1 then '是' when WF_TEMPLET_NODE_FIELD.READABLE = 2 then '否' else '' end ) as READABLE_NAME, PAAS_OBJECT_FIELD_FIELD_ID.NAME as FIELD_ID_NAME, (case  when WF_TEMPLET_NODE_FIELD.WRITABLE = 1 then '是' when WF_TEMPLET_NODE_FIELD.WRITABLE = 2 then '否' else '' end ) as WRITABLE_NAME from WF_TEMPLET_NODE_FIELD left join PAAS_OBJECT_FIELD   PAAS_OBJECT_FIELD_FIELD_ID on WF_TEMPLET_NODE_FIELD.FIELD_ID = PAAS_OBJECT_FIELD_FIELD_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_WF_TEMPLET_NODE_FIELD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_WF_TEMPLET_NODE_FIELD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.READABLE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FIELD_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITABLE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NODE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.READABLE_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FIELD_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.WRITABLE_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_WF_TEMPLET_NODE_FIELD[] objs = new DisplayObject_WF_TEMPLET_NODE_FIELD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_WF_TEMPLET_NODE_FIELD cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from WF_TEMPLET_NODE_FIELD where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_WF_TEMPLET_NODE_FIELD[] Query(CauseObject_WF_TEMPLET_NODE_FIELD cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  WF_TEMPLET_NODE_FIELD.ID, WF_TEMPLET_NODE_FIELD.READABLE, WF_TEMPLET_NODE_FIELD.FIELD_ID, WF_TEMPLET_NODE_FIELD.WRITABLE, WF_TEMPLET_NODE_FIELD.NODE_ID, (case  when WF_TEMPLET_NODE_FIELD.READABLE = 1 then '是' when WF_TEMPLET_NODE_FIELD.READABLE = 2 then '否' else '' end ) as READABLE_NAME, PAAS_OBJECT_FIELD_FIELD_ID.NAME as FIELD_ID_NAME, (case  when WF_TEMPLET_NODE_FIELD.WRITABLE = 1 then '是' when WF_TEMPLET_NODE_FIELD.WRITABLE = 2 then '否' else '' end ) as WRITABLE_NAME from WF_TEMPLET_NODE_FIELD left join PAAS_OBJECT_FIELD   PAAS_OBJECT_FIELD_FIELD_ID on WF_TEMPLET_NODE_FIELD.FIELD_ID = PAAS_OBJECT_FIELD_FIELD_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_WF_TEMPLET_NODE_FIELD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_WF_TEMPLET_NODE_FIELD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.READABLE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FIELD_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITABLE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NODE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.READABLE_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FIELD_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.WRITABLE_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_WF_TEMPLET_NODE_FIELD[] objs = new DisplayObject_WF_TEMPLET_NODE_FIELD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_WF_TEMPLET_NODE_FIELD[] Query(CauseObject_WF_TEMPLET_NODE_FIELD cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  WF_TEMPLET_NODE_FIELD.ID, WF_TEMPLET_NODE_FIELD.READABLE, WF_TEMPLET_NODE_FIELD.FIELD_ID, WF_TEMPLET_NODE_FIELD.WRITABLE, WF_TEMPLET_NODE_FIELD.NODE_ID, (case  when WF_TEMPLET_NODE_FIELD.READABLE = 1 then '是' when WF_TEMPLET_NODE_FIELD.READABLE = 2 then '否' else '' end ) as READABLE_NAME, PAAS_OBJECT_FIELD_FIELD_ID.NAME as FIELD_ID_NAME, (case  when WF_TEMPLET_NODE_FIELD.WRITABLE = 1 then '是' when WF_TEMPLET_NODE_FIELD.WRITABLE = 2 then '否' else '' end ) as WRITABLE_NAME from WF_TEMPLET_NODE_FIELD left join PAAS_OBJECT_FIELD   PAAS_OBJECT_FIELD_FIELD_ID on WF_TEMPLET_NODE_FIELD.FIELD_ID = PAAS_OBJECT_FIELD_FIELD_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("WF_TEMPLET_NODE_FIELD",paging, order, sSql, parameters, connection);
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
			DisplayObject_WF_TEMPLET_NODE_FIELD dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_WF_TEMPLET_NODE_FIELD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.READABLE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FIELD_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITABLE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NODE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.READABLE_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FIELD_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.WRITABLE_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_WF_TEMPLET_NODE_FIELD[] objs = new DisplayObject_WF_TEMPLET_NODE_FIELD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_WF_TEMPLET_NODE_FIELD[] Query(CauseObject_WF_TEMPLET_NODE_FIELD cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  WF_TEMPLET_NODE_FIELD.ID, WF_TEMPLET_NODE_FIELD.READABLE, WF_TEMPLET_NODE_FIELD.FIELD_ID, WF_TEMPLET_NODE_FIELD.WRITABLE, WF_TEMPLET_NODE_FIELD.NODE_ID, (case  when WF_TEMPLET_NODE_FIELD.READABLE = 1 then '是' when WF_TEMPLET_NODE_FIELD.READABLE = 2 then '否' else '' end ) as READABLE_NAME, PAAS_OBJECT_FIELD_FIELD_ID.NAME as FIELD_ID_NAME, (case  when WF_TEMPLET_NODE_FIELD.WRITABLE = 1 then '是' when WF_TEMPLET_NODE_FIELD.WRITABLE = 2 then '否' else '' end ) as WRITABLE_NAME from WF_TEMPLET_NODE_FIELD left join PAAS_OBJECT_FIELD   PAAS_OBJECT_FIELD_FIELD_ID on WF_TEMPLET_NODE_FIELD.FIELD_ID = PAAS_OBJECT_FIELD_FIELD_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("WF_TEMPLET_NODE_FIELD",paging, order, sSql, parameters, trans);
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
			DisplayObject_WF_TEMPLET_NODE_FIELD dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_WF_TEMPLET_NODE_FIELD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.READABLE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FIELD_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITABLE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.NODE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.READABLE_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FIELD_ID_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.WRITABLE_NAME = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_WF_TEMPLET_NODE_FIELD[] objs = new DisplayObject_WF_TEMPLET_NODE_FIELD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_WF_TEMPLET_NODE_FIELD obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("READABLE"))
			{
				strBuf.Add("  WF_TEMPLET_NODE_FIELD.READABLE = :READABLE");
				param = new OracleParameter();
				param.ParameterName = ":READABLE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.READABLE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FIELD_ID"))
			{
				strBuf.Add("  WF_TEMPLET_NODE_FIELD.FIELD_ID = :FIELD_ID");
				param = new OracleParameter();
				param.ParameterName = ":FIELD_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.FIELD_ID) ? string.Empty : obj.FIELD_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WRITABLE"))
			{
				strBuf.Add("  WF_TEMPLET_NODE_FIELD.WRITABLE = :WRITABLE");
				param = new OracleParameter();
				param.ParameterName = ":WRITABLE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.WRITABLE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NODE_ID"))
			{
				strBuf.Add("  WF_TEMPLET_NODE_FIELD.NODE_ID = :NODE_ID");
				param = new OracleParameter();
				param.ParameterName = ":NODE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.NODE_ID) ? string.Empty : obj.NODE_ID;
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
