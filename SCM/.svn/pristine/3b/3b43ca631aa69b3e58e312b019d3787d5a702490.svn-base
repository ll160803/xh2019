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
	[CauseObject(typeof(CauseObject_SCM_B_QUERYPRICE_PRODUCT))]
	public partial class HelperObject_SCM_B_QUERYPRICE_PRODUCT
	{		
		#region Method Blok
		public static int Save(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into SCM_B_QUERYPRICE_PRODUCT( PRODUCT_NAME, BASE_ID, ID) values ( :PRODUCT_NAME, :BASE_ID, :ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[3];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":PRODUCT_NAME";
			parameters[0].Size = 100;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.PRODUCT_NAME == null ? String.Empty:obj.PRODUCT_NAME;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":BASE_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_B_QUERYPRICE_PRODUCT set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj,CauseObject_SCM_B_QUERYPRICE_PRODUCT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_B_QUERYPRICE_PRODUCT set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SCM_B_QUERYPRICE_PRODUCT where  ID = :ID ";
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
		public static int Delete(CauseObject_SCM_B_QUERYPRICE_PRODUCT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SCM_B_QUERYPRICE_PRODUCT where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_SCM_B_QUERYPRICE_PRODUCT Get(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj)
		{
			
			//平台自动生成代码
			string sSql = "select  PRODUCT_NAME, BASE_ID, ID from SCM_B_QUERYPRICE_PRODUCT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_QUERYPRICE_PRODUCT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_QUERYPRICE_PRODUCT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SCM_B_QUERYPRICE_PRODUCT[] objs = new EntityObject_SCM_B_QUERYPRICE_PRODUCT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_B_QUERYPRICE_PRODUCT Get(DisplayObject_SCM_B_QUERYPRICE_PRODUCT obj)
		{
			
			//平台自动生成代码
			string sSql = " select  SCM_B_QUERYPRICE_PRODUCT.PRODUCT_NAME, SCM_B_QUERYPRICE_PRODUCT.BASE_ID, SCM_B_QUERYPRICE_PRODUCT.ID from SCM_B_QUERYPRICE_PRODUCT where (1=1) and SCM_B_QUERYPRICE_PRODUCT.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_SCM_B_QUERYPRICE_PRODUCT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE_PRODUCT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] objs = new DisplayObject_SCM_B_QUERYPRICE_PRODUCT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_SCM_B_QUERYPRICE_PRODUCT Get(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  PRODUCT_NAME, BASE_ID, ID from SCM_B_QUERYPRICE_PRODUCT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_QUERYPRICE_PRODUCT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_QUERYPRICE_PRODUCT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SCM_B_QUERYPRICE_PRODUCT[] objs = new EntityObject_SCM_B_QUERYPRICE_PRODUCT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SCM_B_QUERYPRICE_PRODUCT.PRODUCT_NAME, SCM_B_QUERYPRICE_PRODUCT.BASE_ID, SCM_B_QUERYPRICE_PRODUCT.ID from SCM_B_QUERYPRICE_PRODUCT where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SCM_B_QUERYPRICE_PRODUCT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE_PRODUCT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] objs = new DisplayObject_SCM_B_QUERYPRICE_PRODUCT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SCM_B_QUERYPRICE_PRODUCT cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.PRODUCT_NAME))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE_PRODUCT.PRODUCT_NAME ").Append((cause.PRODUCT_NAME.StartsWith("%") || cause.PRODUCT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_PRODUCT_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_PRODUCT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.PRODUCT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRODUCT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE_PRODUCT", "PRODUCT_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE_PRODUCT.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE_PRODUCT", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE_PRODUCT.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE_PRODUCT", "ID"));
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
		public static DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] Query(CauseObject_SCM_B_QUERYPRICE_PRODUCT cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_B_QUERYPRICE_PRODUCT.PRODUCT_NAME, SCM_B_QUERYPRICE_PRODUCT.BASE_ID, SCM_B_QUERYPRICE_PRODUCT.ID from SCM_B_QUERYPRICE_PRODUCT where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_QUERYPRICE_PRODUCT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE_PRODUCT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] objs = new DisplayObject_SCM_B_QUERYPRICE_PRODUCT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] Query(CauseObject_SCM_B_QUERYPRICE_PRODUCT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_B_QUERYPRICE_PRODUCT.PRODUCT_NAME, SCM_B_QUERYPRICE_PRODUCT.BASE_ID, SCM_B_QUERYPRICE_PRODUCT.ID from SCM_B_QUERYPRICE_PRODUCT where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_QUERYPRICE_PRODUCT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE_PRODUCT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] objs = new DisplayObject_SCM_B_QUERYPRICE_PRODUCT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] Query(CauseObject_SCM_B_QUERYPRICE_PRODUCT cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_B_QUERYPRICE_PRODUCT.PRODUCT_NAME, SCM_B_QUERYPRICE_PRODUCT.BASE_ID, SCM_B_QUERYPRICE_PRODUCT.ID from SCM_B_QUERYPRICE_PRODUCT where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_QUERYPRICE_PRODUCT",paging, order, sSql, parameters, connection);
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
			DisplayObject_SCM_B_QUERYPRICE_PRODUCT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE_PRODUCT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] objs = new DisplayObject_SCM_B_QUERYPRICE_PRODUCT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] Query(CauseObject_SCM_B_QUERYPRICE_PRODUCT cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_B_QUERYPRICE_PRODUCT.PRODUCT_NAME, SCM_B_QUERYPRICE_PRODUCT.BASE_ID, SCM_B_QUERYPRICE_PRODUCT.ID from SCM_B_QUERYPRICE_PRODUCT where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_QUERYPRICE_PRODUCT",paging, order, sSql, parameters, trans);
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
			DisplayObject_SCM_B_QUERYPRICE_PRODUCT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE_PRODUCT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.BASE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] objs = new DisplayObject_SCM_B_QUERYPRICE_PRODUCT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SCM_B_QUERYPRICE_PRODUCT obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("PRODUCT_NAME"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE_PRODUCT.PRODUCT_NAME = :U_PRODUCT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_PRODUCT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.PRODUCT_NAME) ? string.Empty : obj.PRODUCT_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE_PRODUCT.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
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
