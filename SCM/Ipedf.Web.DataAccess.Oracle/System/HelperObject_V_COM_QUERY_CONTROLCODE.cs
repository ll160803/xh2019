using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.Entity;
namespace Ipedf.Web.DataAccess
{
	[CauseObject(typeof(CauseObject_V_COM_QUERY_CONTROLCODE))]
	public partial class HelperObject_V_COM_QUERY_CONTROLCODE
	{		
		#region Method Blok
		public static int Save(EntityObject_V_COM_QUERY_CONTROLCODE obj,IDbTransaction trans)
		{
			
			//试用版本,平纹软件,版权所有
			string sSql = "insert into V_COM_QUERY_CONTROLCODE( CONTROL_CODE, DEFAULT_PAGE_URL, USER_ID) values ( :CONTROL_CODE, :DEFAULT_PAGE_URL, :USER_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[3];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CONTROL_CODE";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.CONTROL_CODE == null ? String.Empty:obj.CONTROL_CODE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":DEFAULT_PAGE_URL";
			parameters[1].Size = 100;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.DEFAULT_PAGE_URL == null ? String.Empty:obj.DEFAULT_PAGE_URL;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":USER_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_COM_QUERY_CONTROLCODE obj,IDbTransaction trans)
		{
			
			//试用版本,平纹软件,版权所有
			string sSql = "update V_COM_QUERY_CONTROLCODE set  CONTROL_CODE = :CONTROL_CODE, DEFAULT_PAGE_URL = :DEFAULT_PAGE_URL, USER_ID = :USER_ID where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[3];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CONTROL_CODE";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.CONTROL_CODE == null?String.Empty:obj.CONTROL_CODE ;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":DEFAULT_PAGE_URL";
			parameters[1].Size = 100;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.DEFAULT_PAGE_URL == null?String.Empty:obj.DEFAULT_PAGE_URL ;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":USER_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.USER_ID == null?String.Empty:obj.USER_ID ;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_COM_QUERY_CONTROLCODE obj,IDbTransaction trans)
		{
			
			//试用版本,平纹软件,版权所有
			string sSql = "delete from V_COM_QUERY_CONTROLCODE where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_COM_QUERY_CONTROLCODE Get(EntityObject_V_COM_QUERY_CONTROLCODE obj)
		{
			
			//试用版本,平纹软件,版权所有
			string sSql = "select  CONTROL_CODE, DEFAULT_PAGE_URL, USER_ID from V_COM_QUERY_CONTROLCODE where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_COM_QUERY_CONTROLCODE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_COM_QUERY_CONTROLCODE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTROL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			connection.Close();
			#endregion 
			EntityObject_V_COM_QUERY_CONTROLCODE[] objs = new EntityObject_V_COM_QUERY_CONTROLCODE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_COM_QUERY_CONTROLCODE[] List()
		{
			
			//试用版本,平纹软件,版权所有
			string sSql = " select  V_COM_QUERY_CONTROLCODE.CONTROL_CODE, V_COM_QUERY_CONTROLCODE.DEFAULT_PAGE_URL, V_COM_QUERY_CONTROLCODE.USER_ID from V_COM_QUERY_CONTROLCODE where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_COM_QUERY_CONTROLCODE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_CONTROLCODE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTROL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			connection.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_CONTROLCODE[] objs = new DisplayObject_V_COM_QUERY_CONTROLCODE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_COM_QUERY_CONTROLCODE cause,out OracleParameter[] parameters )
		{
			
			//试用版本,平纹软件,版权所有
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.CONTROL_CODE!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_CONTROLCODE.CONTROL_CODE ").Append((cause.CONTROL_CODE.StartsWith("%") || cause.CONTROL_CODE.EndsWith("%")) ? " like " : " = ").Append(" :CONTROL_CODE");
				param = new OracleParameter();
				param.ParameterName =":CONTROL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CONTROL_CODE;
				paramList.Add(param);
			}
			if(cause.DEFAULT_PAGE_URL!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_CONTROLCODE.DEFAULT_PAGE_URL ").Append((cause.DEFAULT_PAGE_URL.StartsWith("%") || cause.DEFAULT_PAGE_URL.EndsWith("%")) ? " like " : " = ").Append(" :DEFAULT_PAGE_URL");
				param = new OracleParameter();
				param.ParameterName =":DEFAULT_PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.DEFAULT_PAGE_URL;
				paramList.Add(param);
			}
			if(cause.USER_ID!= string.Empty)
			{
				strBuf.Append(" And V_COM_QUERY_CONTROLCODE.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :USER_ID");
				param = new OracleParameter();
				param.ParameterName =":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return strBuf.ToString();


		}
		public static DisplayObject_V_COM_QUERY_CONTROLCODE[] Query(CauseObject_V_COM_QUERY_CONTROLCODE cause)
		{
			
			//试用版本,平纹软件,版权所有
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_CONTROLCODE.CONTROL_CODE, V_COM_QUERY_CONTROLCODE.DEFAULT_PAGE_URL, V_COM_QUERY_CONTROLCODE.USER_ID from V_COM_QUERY_CONTROLCODE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_COM_QUERY_CONTROLCODE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_CONTROLCODE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTROL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			connection.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_CONTROLCODE[] objs = new DisplayObject_V_COM_QUERY_CONTROLCODE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_COM_QUERY_CONTROLCODE cause,IDbTransaction trans)
		{
			
			//试用版本,平纹软件,版权所有
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_COM_QUERY_CONTROLCODE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_COM_QUERY_CONTROLCODE[] Query(CauseObject_V_COM_QUERY_CONTROLCODE cause,IDbTransaction trans)
		{
			
			//试用版本,平纹软件,版权所有
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_CONTROLCODE.CONTROL_CODE, V_COM_QUERY_CONTROLCODE.DEFAULT_PAGE_URL, V_COM_QUERY_CONTROLCODE.USER_ID from V_COM_QUERY_CONTROLCODE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_COM_QUERY_CONTROLCODE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_CONTROLCODE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTROL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_CONTROLCODE[] objs = new DisplayObject_V_COM_QUERY_CONTROLCODE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_CONTROLCODE[] Query(CauseObject_V_COM_QUERY_CONTROLCODE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//试用版本,平纹软件,版权所有
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_CONTROLCODE.CONTROL_CODE, V_COM_QUERY_CONTROLCODE.DEFAULT_PAGE_URL, V_COM_QUERY_CONTROLCODE.USER_ID from V_COM_QUERY_CONTROLCODE where (1=1)";
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
					countSql = "Select Count(*) From V_COM_QUERY_CONTROLCODE Where (1=1)" + sCauseSql;
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_COM_QUERY_CONTROLCODE",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_COM_QUERY_CONTROLCODE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_CONTROLCODE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTROL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			connection.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_CONTROLCODE[] objs = new DisplayObject_V_COM_QUERY_CONTROLCODE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_CONTROLCODE[] Query(CauseObject_V_COM_QUERY_CONTROLCODE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//试用版本,平纹软件,版权所有
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_CONTROLCODE.CONTROL_CODE, V_COM_QUERY_CONTROLCODE.DEFAULT_PAGE_URL, V_COM_QUERY_CONTROLCODE.USER_ID from V_COM_QUERY_CONTROLCODE where (1=1)";
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
					countSql = "Select Count(*) From V_COM_QUERY_CONTROLCODE Where (1=1)" + sCauseSql;
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_COM_QUERY_CONTROLCODE",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_COM_QUERY_CONTROLCODE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_CONTROLCODE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTROL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DEFAULT_PAGE_URL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_CONTROLCODE[] objs = new DisplayObject_V_COM_QUERY_CONTROLCODE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}	
		#endregion 
	}
}
