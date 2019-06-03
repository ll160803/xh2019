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
	[CauseObject(typeof(CauseObject_COM_USER_FORM))]
	public partial class HelperObject_COM_USER_FORM
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_USER_FORM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_USER_FORM( USER_ID, DISPLAY_INDEX, ID, CODE, FORM_ID) values ( :USER_ID, :DISPLAY_INDEX, :ID, :CODE, :FORM_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[5];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":USER_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":DISPLAY_INDEX";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.DISPLAY_INDEX;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":CODE";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":FORM_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.FORM_ID == null ? String.Empty:obj.FORM_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_USER_FORM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_USER_FORM set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_USER_FORM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_USER_FORM where  ID = :ID ";
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
		public static EntityObject_COM_USER_FORM Get(EntityObject_COM_USER_FORM obj)
		{
			
			//平台自动生成代码
			string sSql = "select  USER_ID, DISPLAY_INDEX, ID, CODE, FORM_ID from COM_USER_FORM where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_USER_FORM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_USER_FORM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.USER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FORM_ID = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_USER_FORM[] objs = new EntityObject_COM_USER_FORM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_USER_FORM Get(EntityObject_COM_USER_FORM obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  USER_ID, DISPLAY_INDEX, ID, CODE, FORM_ID from COM_USER_FORM where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_USER_FORM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_USER_FORM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.USER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FORM_ID = sqlReader.GetString(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_USER_FORM[] objs = new EntityObject_COM_USER_FORM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_USER_FORM[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_USER_FORM.USER_ID, COM_USER_FORM.DISPLAY_INDEX, COM_USER_FORM.ID, COM_USER_FORM.CODE, COM_USER_FORM.FORM_ID, COM_USER_USER_ID.NAME as USER_ID_NAME, COM_FORM_FORM_ID.NAME as FORM_ID_NAME from COM_USER_FORM left join COM_USER   COM_USER_USER_ID on COM_USER_FORM.USER_ID = COM_USER_USER_ID.ID left join COM_FORM   COM_FORM_FORM_ID on COM_USER_FORM.FORM_ID = COM_FORM_FORM_ID.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_USER_FORM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER_FORM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.USER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FORM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FORM_ID_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_USER_FORM[] objs = new DisplayObject_COM_USER_FORM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_USER_FORM cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And COM_USER_FORM.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :USER_ID");
				param = new OracleParameter();
				param.ParameterName =":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER_FORM", "USER_ID"));
			}
			if(cause.DISPLAY_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_USER_FORM.DISPLAY_INDEX = :DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName =":DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("DISPLAY_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER_FORM", "DISPLAY_INDEX"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And COM_USER_FORM.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER_FORM", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And COM_USER_FORM.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER_FORM", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.FORM_ID))
			{
				strBuf.Append(" And COM_USER_FORM.FORM_ID ").Append((cause.FORM_ID.StartsWith("%") || cause.FORM_ID.EndsWith("%")) ? " like " : " = ").Append(" :FORM_ID");
				param = new OracleParameter();
				param.ParameterName =":FORM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.FORM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("FORM_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_USER_FORM", "FORM_ID"));
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
		public static DisplayObject_COM_USER_FORM[] Query(CauseObject_COM_USER_FORM cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_USER_FORM.USER_ID, COM_USER_FORM.DISPLAY_INDEX, COM_USER_FORM.ID, COM_USER_FORM.CODE, COM_USER_FORM.FORM_ID, COM_USER_USER_ID.NAME as USER_ID_NAME, COM_FORM_FORM_ID.NAME as FORM_ID_NAME from COM_USER_FORM left join COM_USER   COM_USER_USER_ID on COM_USER_FORM.USER_ID = COM_USER_USER_ID.ID left join COM_FORM   COM_FORM_FORM_ID on COM_USER_FORM.FORM_ID = COM_FORM_FORM_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_USER_FORM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER_FORM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.USER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FORM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FORM_ID_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_USER_FORM[] objs = new DisplayObject_COM_USER_FORM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_USER_FORM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_USER_FORM where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_USER_FORM[] Query(CauseObject_COM_USER_FORM cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_USER_FORM.USER_ID, COM_USER_FORM.DISPLAY_INDEX, COM_USER_FORM.ID, COM_USER_FORM.CODE, COM_USER_FORM.FORM_ID, COM_USER_USER_ID.NAME as USER_ID_NAME, COM_FORM_FORM_ID.NAME as FORM_ID_NAME from COM_USER_FORM left join COM_USER   COM_USER_USER_ID on COM_USER_FORM.USER_ID = COM_USER_USER_ID.ID left join COM_FORM   COM_FORM_FORM_ID on COM_USER_FORM.FORM_ID = COM_FORM_FORM_ID.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_USER_FORM dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER_FORM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.USER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FORM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FORM_ID_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_USER_FORM[] objs = new DisplayObject_COM_USER_FORM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_USER_FORM[] Query(CauseObject_COM_USER_FORM cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_USER_FORM.USER_ID, COM_USER_FORM.DISPLAY_INDEX, COM_USER_FORM.ID, COM_USER_FORM.CODE, COM_USER_FORM.FORM_ID, COM_USER_USER_ID.NAME as USER_ID_NAME, COM_FORM_FORM_ID.NAME as FORM_ID_NAME from COM_USER_FORM left join COM_USER   COM_USER_USER_ID on COM_USER_FORM.USER_ID = COM_USER_USER_ID.ID left join COM_FORM   COM_FORM_FORM_ID on COM_USER_FORM.FORM_ID = COM_FORM_FORM_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_USER_FORM",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_USER_FORM dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER_FORM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.USER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FORM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FORM_ID_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_USER_FORM[] objs = new DisplayObject_COM_USER_FORM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_USER_FORM[] Query(CauseObject_COM_USER_FORM cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_USER_FORM.USER_ID, COM_USER_FORM.DISPLAY_INDEX, COM_USER_FORM.ID, COM_USER_FORM.CODE, COM_USER_FORM.FORM_ID, COM_USER_USER_ID.NAME as USER_ID_NAME, COM_FORM_FORM_ID.NAME as FORM_ID_NAME from COM_USER_FORM left join COM_USER   COM_USER_USER_ID on COM_USER_FORM.USER_ID = COM_USER_USER_ID.ID left join COM_FORM   COM_FORM_FORM_ID on COM_USER_FORM.FORM_ID = COM_FORM_FORM_ID.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_USER_FORM",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_USER_FORM dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_USER_FORM();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.USER_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CODE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FORM_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FORM_ID_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_USER_FORM[] objs = new DisplayObject_COM_USER_FORM[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_USER_FORM obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  COM_USER_FORM.USER_ID = :USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DISPLAY_INDEX"))
			{
				strBuf.Add("  COM_USER_FORM.DISPLAY_INDEX = :DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName = ":DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  COM_USER_FORM.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FORM_ID"))
			{
				strBuf.Add("  COM_USER_FORM.FORM_ID = :FORM_ID");
				param = new OracleParameter();
				param.ParameterName = ":FORM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.FORM_ID) ? string.Empty : obj.FORM_ID;
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
