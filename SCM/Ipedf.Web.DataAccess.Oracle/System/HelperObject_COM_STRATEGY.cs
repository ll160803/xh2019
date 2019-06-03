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
	[CauseObject(typeof(CauseObject_COM_STRATEGY))]
	public partial class HelperObject_COM_STRATEGY
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_STRATEGY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_STRATEGY( ID, COMMENTS, STRATEGY_NAME, STATE, STRATEGY_TYPE, STRATEGY_CODE, STRATEGY_CUSTOMCONDITION) values ( :ID, :COMMENTS, :STRATEGY_NAME, :STATE, :STRATEGY_TYPE, :STRATEGY_CODE, :STRATEGY_CUSTOMCONDITION)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[7];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":COMMENTS";
			parameters[1].Size = 500;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":STRATEGY_NAME";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.STRATEGY_NAME == null ? String.Empty:obj.STRATEGY_NAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":STATE";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.STATE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":STRATEGY_TYPE";
			parameters[4].Size = 200;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.STRATEGY_TYPE == null ? String.Empty:obj.STRATEGY_TYPE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":STRATEGY_CODE";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.STRATEGY_CODE == null ? String.Empty:obj.STRATEGY_CODE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":STRATEGY_CUSTOMCONDITION";
			parameters[6].Size = 2000;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.STRATEGY_CUSTOMCONDITION == null ? String.Empty:obj.STRATEGY_CUSTOMCONDITION;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_STRATEGY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_STRATEGY set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_STRATEGY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_STRATEGY where  ID = :ID ";
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
		public static EntityObject_COM_STRATEGY Get(EntityObject_COM_STRATEGY obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, COMMENTS, STRATEGY_NAME, STATE, STRATEGY_TYPE, STRATEGY_CODE, STRATEGY_CUSTOMCONDITION from COM_STRATEGY where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_STRATEGY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_STRATEGY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STRATEGY_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_STRATEGY[] objs = new EntityObject_COM_STRATEGY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_STRATEGY Get(EntityObject_COM_STRATEGY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, COMMENTS, STRATEGY_NAME, STATE, STRATEGY_TYPE, STRATEGY_CODE, STRATEGY_CUSTOMCONDITION from COM_STRATEGY where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_STRATEGY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_STRATEGY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STRATEGY_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_STRATEGY[] objs = new EntityObject_COM_STRATEGY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_STRATEGY[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_STRATEGY.ID, COM_STRATEGY.COMMENTS, COM_STRATEGY.STRATEGY_NAME, COM_STRATEGY.STATE, COM_STRATEGY.STRATEGY_TYPE, COM_STRATEGY.STRATEGY_CODE, COM_STRATEGY.STRATEGY_CUSTOMCONDITION from COM_STRATEGY where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_STRATEGY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_STRATEGY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STRATEGY_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_STRATEGY[] objs = new DisplayObject_COM_STRATEGY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_STRATEGY cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And COM_STRATEGY.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_STRATEGY", "ID"));
			}
			if(cause.COMMENTS!= string.Empty)
			{
				strBuf.Append(" And COM_STRATEGY.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("COM_STRATEGY", "COMMENTS"));
			}
			if(cause.STRATEGY_NAME!= string.Empty)
			{
				strBuf.Append(" And COM_STRATEGY.STRATEGY_NAME ").Append((cause.STRATEGY_NAME.StartsWith("%") || cause.STRATEGY_NAME.EndsWith("%")) ? " like " : " = ").Append(" :STRATEGY_NAME");
				param = new OracleParameter();
				param.ParameterName =":STRATEGY_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.STRATEGY_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("STRATEGY_NAME"))
			{
				strBuf.Append(cause.GetINSQL("COM_STRATEGY", "STRATEGY_NAME"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_STRATEGY.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("COM_STRATEGY", "STATE"));
			}
			if(cause.STRATEGY_TYPE!= string.Empty)
			{
				strBuf.Append(" And COM_STRATEGY.STRATEGY_TYPE ").Append((cause.STRATEGY_TYPE.StartsWith("%") || cause.STRATEGY_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :STRATEGY_TYPE");
				param = new OracleParameter();
				param.ParameterName =":STRATEGY_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.STRATEGY_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STRATEGY_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("COM_STRATEGY", "STRATEGY_TYPE"));
			}
			if(cause.STRATEGY_CODE!= string.Empty)
			{
				strBuf.Append(" And COM_STRATEGY.STRATEGY_CODE ").Append((cause.STRATEGY_CODE.StartsWith("%") || cause.STRATEGY_CODE.EndsWith("%")) ? " like " : " = ").Append(" :STRATEGY_CODE");
				param = new OracleParameter();
				param.ParameterName =":STRATEGY_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.STRATEGY_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STRATEGY_CODE"))
			{
				strBuf.Append(cause.GetINSQL("COM_STRATEGY", "STRATEGY_CODE"));
			}
			if(cause.STRATEGY_CUSTOMCONDITION!= string.Empty)
			{
				strBuf.Append(" And COM_STRATEGY.STRATEGY_CUSTOMCONDITION ").Append((cause.STRATEGY_CUSTOMCONDITION.StartsWith("%") || cause.STRATEGY_CUSTOMCONDITION.EndsWith("%")) ? " like " : " = ").Append(" :STRATEGY_CUSTOMCONDITION");
				param = new OracleParameter();
				param.ParameterName =":STRATEGY_CUSTOMCONDITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2000;
				param.Value = cause.STRATEGY_CUSTOMCONDITION;
				paramList.Add(param);
			}
			if (cause.HasINValue("STRATEGY_CUSTOMCONDITION"))
			{
				strBuf.Append(cause.GetINSQL("COM_STRATEGY", "STRATEGY_CUSTOMCONDITION"));
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
		public static DisplayObject_COM_STRATEGY[] Query(CauseObject_COM_STRATEGY cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_STRATEGY.ID, COM_STRATEGY.COMMENTS, COM_STRATEGY.STRATEGY_NAME, COM_STRATEGY.STATE, COM_STRATEGY.STRATEGY_TYPE, COM_STRATEGY.STRATEGY_CODE, COM_STRATEGY.STRATEGY_CUSTOMCONDITION from COM_STRATEGY where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_STRATEGY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_STRATEGY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STRATEGY_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_STRATEGY[] objs = new DisplayObject_COM_STRATEGY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_STRATEGY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_STRATEGY where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_STRATEGY[] Query(CauseObject_COM_STRATEGY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_STRATEGY.ID, COM_STRATEGY.COMMENTS, COM_STRATEGY.STRATEGY_NAME, COM_STRATEGY.STATE, COM_STRATEGY.STRATEGY_TYPE, COM_STRATEGY.STRATEGY_CODE, COM_STRATEGY.STRATEGY_CUSTOMCONDITION from COM_STRATEGY where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_STRATEGY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_STRATEGY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STRATEGY_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_STRATEGY[] objs = new DisplayObject_COM_STRATEGY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_STRATEGY[] Query(CauseObject_COM_STRATEGY cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_STRATEGY.ID, COM_STRATEGY.COMMENTS, COM_STRATEGY.STRATEGY_NAME, COM_STRATEGY.STATE, COM_STRATEGY.STRATEGY_TYPE, COM_STRATEGY.STRATEGY_CODE, COM_STRATEGY.STRATEGY_CUSTOMCONDITION from COM_STRATEGY where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_STRATEGY",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_STRATEGY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_STRATEGY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STRATEGY_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_STRATEGY[] objs = new DisplayObject_COM_STRATEGY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_STRATEGY[] Query(CauseObject_COM_STRATEGY cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_STRATEGY.ID, COM_STRATEGY.COMMENTS, COM_STRATEGY.STRATEGY_NAME, COM_STRATEGY.STATE, COM_STRATEGY.STRATEGY_TYPE, COM_STRATEGY.STRATEGY_CODE, COM_STRATEGY.STRATEGY_CUSTOMCONDITION from COM_STRATEGY where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_STRATEGY",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_STRATEGY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_STRATEGY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STRATEGY_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STRATEGY_TYPE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STRATEGY_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STRATEGY_CUSTOMCONDITION = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_STRATEGY[] objs = new DisplayObject_COM_STRATEGY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_STRATEGY obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  COM_STRATEGY.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STRATEGY_NAME"))
			{
				strBuf.Add("  COM_STRATEGY.STRATEGY_NAME = :STRATEGY_NAME");
				param = new OracleParameter();
				param.ParameterName = ":STRATEGY_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.STRATEGY_NAME) ? string.Empty : obj.STRATEGY_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  COM_STRATEGY.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STRATEGY_TYPE"))
			{
				strBuf.Add("  COM_STRATEGY.STRATEGY_TYPE = :STRATEGY_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":STRATEGY_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.STRATEGY_TYPE) ? string.Empty : obj.STRATEGY_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STRATEGY_CODE"))
			{
				strBuf.Add("  COM_STRATEGY.STRATEGY_CODE = :STRATEGY_CODE");
				param = new OracleParameter();
				param.ParameterName = ":STRATEGY_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.STRATEGY_CODE) ? string.Empty : obj.STRATEGY_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STRATEGY_CUSTOMCONDITION"))
			{
				strBuf.Add("  COM_STRATEGY.STRATEGY_CUSTOMCONDITION = :STRATEGY_CUSTOMCONDITION");
				param = new OracleParameter();
				param.ParameterName = ":STRATEGY_CUSTOMCONDITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2000;
				param.Value = string.IsNullOrEmpty(obj.STRATEGY_CUSTOMCONDITION) ? string.Empty : obj.STRATEGY_CUSTOMCONDITION;
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
