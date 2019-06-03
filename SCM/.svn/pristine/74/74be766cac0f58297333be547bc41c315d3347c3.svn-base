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
	[CauseObject(typeof(CauseObject_COM_CODE_DETAIL))]
	public partial class HelperObject_COM_CODE_DETAIL
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_CODE_DETAIL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_CODE_DETAIL( CODE_INDEX, CODE_TYPE, BASE_ID, ID, CODE_WIDTH, CODE_VALUE) values ( :CODE_INDEX, :CODE_TYPE, :BASE_ID, :ID, :CODE_WIDTH, :CODE_VALUE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[6];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CODE_INDEX";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.CODE_INDEX;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":CODE_TYPE";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.CODE_TYPE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":BASE_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":CODE_WIDTH";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.CODE_WIDTH;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":CODE_VALUE";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.CODE_VALUE == null ? String.Empty:obj.CODE_VALUE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_CODE_DETAIL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_CODE_DETAIL set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_CODE_DETAIL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_CODE_DETAIL where  ID = :ID ";
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
		public static EntityObject_COM_CODE_DETAIL Get(EntityObject_COM_CODE_DETAIL obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CODE_INDEX, CODE_TYPE, BASE_ID, ID, CODE_WIDTH, CODE_VALUE from COM_CODE_DETAIL where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_CODE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_CODE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE_INDEX = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE_TYPE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE_WIDTH = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE_VALUE = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_CODE_DETAIL[] objs = new EntityObject_COM_CODE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_CODE_DETAIL Get(EntityObject_COM_CODE_DETAIL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CODE_INDEX, CODE_TYPE, BASE_ID, ID, CODE_WIDTH, CODE_VALUE from COM_CODE_DETAIL where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_CODE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_CODE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE_INDEX = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE_TYPE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE_WIDTH = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE_VALUE = sqlReader.GetString(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_CODE_DETAIL[] objs = new EntityObject_COM_CODE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_CODE_DETAIL[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_CODE_DETAIL.CODE_INDEX, COM_CODE_DETAIL.CODE_TYPE, COM_CODE_DETAIL.BASE_ID, COM_CODE_DETAIL.ID, COM_CODE_DETAIL.CODE_WIDTH, COM_CODE_DETAIL.CODE_VALUE, (case  when COM_CODE_DETAIL.CODE_TYPE = 1 then '分隔符号' when COM_CODE_DETAIL.CODE_TYPE = 2 then '定长序列' when COM_CODE_DETAIL.CODE_TYPE = 3 then '变长序列' when COM_CODE_DETAIL.CODE_TYPE = 4 then '固定内容' when COM_CODE_DETAIL.CODE_TYPE = 5 then '长整日期' when COM_CODE_DETAIL.CODE_TYPE = 6 then '短整日期' when COM_CODE_DETAIL.CODE_TYPE = 7 then '按天更新定长序列' else '' end ) as CODE_TYPE_NAME from COM_CODE_DETAIL where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_CODE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_CODE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE_INDEX = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE_TYPE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE_WIDTH = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE_VALUE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE_TYPE_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_CODE_DETAIL[] objs = new DisplayObject_COM_CODE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_CODE_DETAIL cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.CODE_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_CODE_DETAIL.CODE_INDEX = :CODE_INDEX");
				param = new OracleParameter();
				param.ParameterName =":CODE_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CODE_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("COM_CODE_DETAIL", "CODE_INDEX"));
			}
			if(cause.CODE_TYPE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_CODE_DETAIL.CODE_TYPE = :CODE_TYPE");
				param = new OracleParameter();
				param.ParameterName =":CODE_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CODE_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("COM_CODE_DETAIL", "CODE_TYPE"));
			}
			if(cause.BASE_ID!= string.Empty)
			{
				strBuf.Append(" And COM_CODE_DETAIL.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_CODE_DETAIL", "BASE_ID"));
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And COM_CODE_DETAIL.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_CODE_DETAIL", "ID"));
			}
			if(cause.CODE_WIDTH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_CODE_DETAIL.CODE_WIDTH = :CODE_WIDTH");
				param = new OracleParameter();
				param.ParameterName =":CODE_WIDTH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CODE_WIDTH;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE_WIDTH"))
			{
				strBuf.Append(cause.GetINSQL("COM_CODE_DETAIL", "CODE_WIDTH"));
			}
			if(cause.CODE_VALUE!= string.Empty)
			{
				strBuf.Append(" And COM_CODE_DETAIL.CODE_VALUE ").Append((cause.CODE_VALUE.StartsWith("%") || cause.CODE_VALUE.EndsWith("%")) ? " like " : " = ").Append(" :CODE_VALUE");
				param = new OracleParameter();
				param.ParameterName =":CODE_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("COM_CODE_DETAIL", "CODE_VALUE"));
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
		public static DisplayObject_COM_CODE_DETAIL[] Query(CauseObject_COM_CODE_DETAIL cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_CODE_DETAIL.CODE_INDEX, COM_CODE_DETAIL.CODE_TYPE, COM_CODE_DETAIL.BASE_ID, COM_CODE_DETAIL.ID, COM_CODE_DETAIL.CODE_WIDTH, COM_CODE_DETAIL.CODE_VALUE, (case  when COM_CODE_DETAIL.CODE_TYPE = 1 then '分隔符号' when COM_CODE_DETAIL.CODE_TYPE = 2 then '定长序列' when COM_CODE_DETAIL.CODE_TYPE = 3 then '变长序列' when COM_CODE_DETAIL.CODE_TYPE = 4 then '固定内容' when COM_CODE_DETAIL.CODE_TYPE = 5 then '长整日期' when COM_CODE_DETAIL.CODE_TYPE = 6 then '短整日期' when COM_CODE_DETAIL.CODE_TYPE = 7 then '按天更新定长序列' else '' end ) as CODE_TYPE_NAME from COM_CODE_DETAIL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_CODE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_CODE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE_INDEX = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE_TYPE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE_WIDTH = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE_VALUE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE_TYPE_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_CODE_DETAIL[] objs = new DisplayObject_COM_CODE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_CODE_DETAIL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_CODE_DETAIL where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_CODE_DETAIL[] Query(CauseObject_COM_CODE_DETAIL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_CODE_DETAIL.CODE_INDEX, COM_CODE_DETAIL.CODE_TYPE, COM_CODE_DETAIL.BASE_ID, COM_CODE_DETAIL.ID, COM_CODE_DETAIL.CODE_WIDTH, COM_CODE_DETAIL.CODE_VALUE, (case  when COM_CODE_DETAIL.CODE_TYPE = 1 then '分隔符号' when COM_CODE_DETAIL.CODE_TYPE = 2 then '定长序列' when COM_CODE_DETAIL.CODE_TYPE = 3 then '变长序列' when COM_CODE_DETAIL.CODE_TYPE = 4 then '固定内容' when COM_CODE_DETAIL.CODE_TYPE = 5 then '长整日期' when COM_CODE_DETAIL.CODE_TYPE = 6 then '短整日期' when COM_CODE_DETAIL.CODE_TYPE = 7 then '按天更新定长序列' else '' end ) as CODE_TYPE_NAME from COM_CODE_DETAIL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_CODE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_CODE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE_INDEX = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE_TYPE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE_WIDTH = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE_VALUE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE_TYPE_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_CODE_DETAIL[] objs = new DisplayObject_COM_CODE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_CODE_DETAIL[] Query(CauseObject_COM_CODE_DETAIL cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_CODE_DETAIL.CODE_INDEX, COM_CODE_DETAIL.CODE_TYPE, COM_CODE_DETAIL.BASE_ID, COM_CODE_DETAIL.ID, COM_CODE_DETAIL.CODE_WIDTH, COM_CODE_DETAIL.CODE_VALUE, (case  when COM_CODE_DETAIL.CODE_TYPE = 1 then '分隔符号' when COM_CODE_DETAIL.CODE_TYPE = 2 then '定长序列' when COM_CODE_DETAIL.CODE_TYPE = 3 then '变长序列' when COM_CODE_DETAIL.CODE_TYPE = 4 then '固定内容' when COM_CODE_DETAIL.CODE_TYPE = 5 then '长整日期' when COM_CODE_DETAIL.CODE_TYPE = 6 then '短整日期' when COM_CODE_DETAIL.CODE_TYPE = 7 then '按天更新定长序列' else '' end ) as CODE_TYPE_NAME from COM_CODE_DETAIL where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_CODE_DETAIL",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_CODE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_CODE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE_INDEX = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE_TYPE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE_WIDTH = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE_VALUE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE_TYPE_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_CODE_DETAIL[] objs = new DisplayObject_COM_CODE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_CODE_DETAIL[] Query(CauseObject_COM_CODE_DETAIL cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_CODE_DETAIL.CODE_INDEX, COM_CODE_DETAIL.CODE_TYPE, COM_CODE_DETAIL.BASE_ID, COM_CODE_DETAIL.ID, COM_CODE_DETAIL.CODE_WIDTH, COM_CODE_DETAIL.CODE_VALUE, (case  when COM_CODE_DETAIL.CODE_TYPE = 1 then '分隔符号' when COM_CODE_DETAIL.CODE_TYPE = 2 then '定长序列' when COM_CODE_DETAIL.CODE_TYPE = 3 then '变长序列' when COM_CODE_DETAIL.CODE_TYPE = 4 then '固定内容' when COM_CODE_DETAIL.CODE_TYPE = 5 then '长整日期' when COM_CODE_DETAIL.CODE_TYPE = 6 then '短整日期' when COM_CODE_DETAIL.CODE_TYPE = 7 then '按天更新定长序列' else '' end ) as CODE_TYPE_NAME from COM_CODE_DETAIL where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_CODE_DETAIL",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_CODE_DETAIL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_CODE_DETAIL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CODE_INDEX = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CODE_TYPE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.BASE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CODE_WIDTH = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE_VALUE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE_TYPE_NAME = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_CODE_DETAIL[] objs = new DisplayObject_COM_CODE_DETAIL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_CODE_DETAIL obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CODE_INDEX"))
			{
				strBuf.Add("  COM_CODE_DETAIL.CODE_INDEX = :CODE_INDEX");
				param = new OracleParameter();
				param.ParameterName = ":CODE_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CODE_INDEX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE_TYPE"))
			{
				strBuf.Add("  COM_CODE_DETAIL.CODE_TYPE = :CODE_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":CODE_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CODE_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  COM_CODE_DETAIL.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE_WIDTH"))
			{
				strBuf.Add("  COM_CODE_DETAIL.CODE_WIDTH = :CODE_WIDTH");
				param = new OracleParameter();
				param.ParameterName = ":CODE_WIDTH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CODE_WIDTH;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE_VALUE"))
			{
				strBuf.Add("  COM_CODE_DETAIL.CODE_VALUE = :CODE_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":CODE_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE_VALUE) ? string.Empty : obj.CODE_VALUE;
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
