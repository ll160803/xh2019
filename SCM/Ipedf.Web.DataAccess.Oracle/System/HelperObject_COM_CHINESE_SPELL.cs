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
	[CauseObject(typeof(CauseObject_COM_CHINESE_SPELL))]
	public partial class HelperObject_COM_CHINESE_SPELL
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_CHINESE_SPELL obj,IDbTransaction trans)
		{
			
			//试用版本,平纹软件,版权所有
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_CHINESE_SPELL( CHINESE, ID, SPELL) values ( :CHINESE, :ID, :SPELL)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[3];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CHINESE";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.CHINESE == null ? String.Empty:obj.CHINESE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":SPELL";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.SPELL == null ? String.Empty:obj.SPELL;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_CHINESE_SPELL obj,IDbTransaction trans)
		{
			
			//试用版本,平纹软件,版权所有
			string sSql = "update COM_CHINESE_SPELL set  CHINESE = :CHINESE, SPELL = :SPELL where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[3];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CHINESE";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.CHINESE == null?String.Empty:obj.CHINESE ;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":SPELL";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.SPELL == null?String.Empty:obj.SPELL ;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_CHINESE_SPELL obj,IDbTransaction trans)
		{
			
			//试用版本,平纹软件,版权所有
			string sSql = "delete from COM_CHINESE_SPELL where  ID = :ID ";
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
		public static EntityObject_COM_CHINESE_SPELL Get(EntityObject_COM_CHINESE_SPELL obj)
		{
			
			//试用版本,平纹软件,版权所有
			string sSql = "select  CHINESE, ID, SPELL from COM_CHINESE_SPELL where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_CHINESE_SPELL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_CHINESE_SPELL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CHINESE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPELL = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			connection.Close();
			#endregion 
			EntityObject_COM_CHINESE_SPELL[] objs = new EntityObject_COM_CHINESE_SPELL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_CHINESE_SPELL[] List()
		{
			
			//试用版本,平纹软件,版权所有
			string sSql = " select  COM_CHINESE_SPELL.CHINESE, COM_CHINESE_SPELL.ID, COM_CHINESE_SPELL.SPELL from COM_CHINESE_SPELL where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_CHINESE_SPELL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_CHINESE_SPELL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CHINESE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPELL = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			connection.Close();
			#endregion 
			DisplayObject_COM_CHINESE_SPELL[] objs = new DisplayObject_COM_CHINESE_SPELL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_CHINESE_SPELL cause,out OracleParameter[] parameters )
		{
			
			//试用版本,平纹软件,版权所有
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.CHINESE!= string.Empty)
			{
				strBuf.Append(" And COM_CHINESE_SPELL.CHINESE ").Append((cause.CHINESE.StartsWith("%") || cause.CHINESE.EndsWith("%")) ? " like " : " = ").Append(" :CHINESE");
				param = new OracleParameter();
				param.ParameterName =":CHINESE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CHINESE;
				paramList.Add(param);
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And COM_CHINESE_SPELL.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if(cause.SPELL!= string.Empty)
			{
				strBuf.Append(" And COM_CHINESE_SPELL.SPELL ").Append((cause.SPELL.StartsWith("%") || cause.SPELL.EndsWith("%")) ? " like " : " = ").Append(" :SPELL");
				param = new OracleParameter();
				param.ParameterName =":SPELL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SPELL;
				paramList.Add(param);
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return strBuf.ToString();


		}
		public static DisplayObject_COM_CHINESE_SPELL[] Query(CauseObject_COM_CHINESE_SPELL cause)
		{
			
			//试用版本,平纹软件,版权所有
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_CHINESE_SPELL.CHINESE, COM_CHINESE_SPELL.ID, COM_CHINESE_SPELL.SPELL from COM_CHINESE_SPELL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_CHINESE_SPELL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_CHINESE_SPELL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CHINESE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPELL = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			connection.Close();
			#endregion 
			DisplayObject_COM_CHINESE_SPELL[] objs = new DisplayObject_COM_CHINESE_SPELL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_CHINESE_SPELL cause,IDbTransaction trans)
		{
			
			//试用版本,平纹软件,版权所有
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_CHINESE_SPELL where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_CHINESE_SPELL[] Query(CauseObject_COM_CHINESE_SPELL cause,IDbTransaction trans)
		{
			
			//试用版本,平纹软件,版权所有
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_CHINESE_SPELL.CHINESE, COM_CHINESE_SPELL.ID, COM_CHINESE_SPELL.SPELL from COM_CHINESE_SPELL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_CHINESE_SPELL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_CHINESE_SPELL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CHINESE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPELL = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_CHINESE_SPELL[] objs = new DisplayObject_COM_CHINESE_SPELL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_CHINESE_SPELL[] Query(CauseObject_COM_CHINESE_SPELL cause,PagingParamter paging,OrderByParameter order)
		{
			
			//试用版本,平纹软件,版权所有
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_CHINESE_SPELL.CHINESE, COM_CHINESE_SPELL.ID, COM_CHINESE_SPELL.SPELL from COM_CHINESE_SPELL where (1=1)";
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
					countSql = "Select Count(*) From COM_CHINESE_SPELL Where (1=1)" + sCauseSql;
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_CHINESE_SPELL",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_CHINESE_SPELL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_CHINESE_SPELL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CHINESE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPELL = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			connection.Close();
			#endregion 
			DisplayObject_COM_CHINESE_SPELL[] objs = new DisplayObject_COM_CHINESE_SPELL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_CHINESE_SPELL[] Query(CauseObject_COM_CHINESE_SPELL cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//试用版本,平纹软件,版权所有
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_CHINESE_SPELL.CHINESE, COM_CHINESE_SPELL.ID, COM_CHINESE_SPELL.SPELL from COM_CHINESE_SPELL where (1=1)";
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
					countSql = "Select Count(*) From COM_CHINESE_SPELL Where (1=1)" + sCauseSql;
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_CHINESE_SPELL",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_CHINESE_SPELL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_CHINESE_SPELL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CHINESE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SPELL = sqlReader.GetString(2);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_CHINESE_SPELL[] objs = new DisplayObject_COM_CHINESE_SPELL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}	
		#endregion 
	}
}
