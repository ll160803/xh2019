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
	[CauseObject(typeof(CauseObject_COM_LOG))]
	public partial class HelperObject_COM_LOG
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_LOG obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_LOG( ID, PAGEURL, TYPE, USER_ID, MESSAGE, LOG_TIME, IPADDRESS, COMMAND) values ( :ID, :PAGEURL, :TYPE, :USER_ID, :MESSAGE, :LOG_TIME, :IPADDRESS, :COMMAND)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[8];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":PAGEURL";
			parameters[1].Size = 200;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.PAGEURL == null ? String.Empty:obj.PAGEURL;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":TYPE";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.TYPE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":USER_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":MESSAGE";
			parameters[4].Size = 2048;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.MESSAGE == null ? String.Empty:obj.MESSAGE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":LOG_TIME";
			parameters[5].Size = 7;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[5].Value = obj.LOG_TIME;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":IPADDRESS";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.IPADDRESS == null ? String.Empty:obj.IPADDRESS;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":COMMAND";
			parameters[7].Size = 200;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.COMMAND == null ? String.Empty:obj.COMMAND;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_LOG obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_LOG set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_LOG obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_LOG where  ID = :ID ";
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
		public static EntityObject_COM_LOG Get(EntityObject_COM_LOG obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, PAGEURL, TYPE, USER_ID, MESSAGE, LOG_TIME, IPADDRESS, COMMAND from COM_LOG where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_LOG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_LOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGEURL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MESSAGE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOG_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IPADDRESS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMAND = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_LOG[] objs = new EntityObject_COM_LOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_LOG Get(EntityObject_COM_LOG obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, PAGEURL, TYPE, USER_ID, MESSAGE, LOG_TIME, IPADDRESS, COMMAND from COM_LOG where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_LOG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_LOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGEURL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MESSAGE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOG_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IPADDRESS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMAND = sqlReader.GetString(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_LOG[] objs = new EntityObject_COM_LOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_LOG[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_LOG.ID, COM_LOG.PAGEURL, COM_LOG.TYPE, COM_LOG.USER_ID, COM_LOG.MESSAGE, COM_LOG.LOG_TIME, COM_LOG.IPADDRESS, COM_LOG.COMMAND, (case  when COM_LOG.TYPE = 1 then '正常' when COM_LOG.TYPE = 2 then '错误' else '' end ) as TYPE_NAME, COM_USER.NAME as COM_USER_NAME from COM_LOG left join COM_USER   COM_USER on COM_LOG.USER_ID = COM_USER.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_LOG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_LOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGEURL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MESSAGE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOG_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IPADDRESS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMAND = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.TYPE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_LOG[] objs = new DisplayObject_COM_LOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_LOG cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And COM_LOG.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_LOG", "ID"));
			}
			if(cause.PAGEURL!= string.Empty)
			{
				strBuf.Append(" And COM_LOG.PAGEURL ").Append((cause.PAGEURL.StartsWith("%") || cause.PAGEURL.EndsWith("%")) ? " like " : " = ").Append(" :PAGEURL");
				param = new OracleParameter();
				param.ParameterName =":PAGEURL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.PAGEURL;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAGEURL"))
			{
				strBuf.Append(cause.GetINSQL("COM_LOG", "PAGEURL"));
			}
			if(cause.TYPE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And COM_LOG.TYPE = :TYPE");
				param = new OracleParameter();
				param.ParameterName =":TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE"))
			{
				strBuf.Append(cause.GetINSQL("COM_LOG", "TYPE"));
			}
			if(cause.USER_ID!= string.Empty)
			{
				strBuf.Append(" And COM_LOG.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :USER_ID");
				param = new OracleParameter();
				param.ParameterName =":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_LOG", "USER_ID"));
			}
			if(cause.MESSAGE!= string.Empty)
			{
				strBuf.Append(" And COM_LOG.MESSAGE ").Append((cause.MESSAGE.StartsWith("%") || cause.MESSAGE.EndsWith("%")) ? " like " : " = ").Append(" :MESSAGE");
				param = new OracleParameter();
				param.ParameterName =":MESSAGE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2048;
				param.Value = cause.MESSAGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MESSAGE"))
			{
				strBuf.Append(cause.GetINSQL("COM_LOG", "MESSAGE"));
			}
			if(cause.LOG_TIME!= null)
			{
				if (cause.LOG_TIME.Begin != null)
				{
					strBuf.Append(" And COM_LOG.LOG_TIME >= :LOG_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":LOG_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.LOG_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.LOG_TIME.End != null)
				{
					strBuf.Append(" And COM_LOG.LOG_TIME < :LOG_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":LOG_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.LOG_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("LOG_TIME"))
			{
				strBuf.Append(cause.GetINSQL("COM_LOG", "LOG_TIME"));
			}
			if(cause.IPADDRESS!= string.Empty)
			{
				strBuf.Append(" And COM_LOG.IPADDRESS ").Append((cause.IPADDRESS.StartsWith("%") || cause.IPADDRESS.EndsWith("%")) ? " like " : " = ").Append(" :IPADDRESS");
				param = new OracleParameter();
				param.ParameterName =":IPADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.IPADDRESS;
				paramList.Add(param);
			}
			if (cause.HasINValue("IPADDRESS"))
			{
				strBuf.Append(cause.GetINSQL("COM_LOG", "IPADDRESS"));
			}
			if(cause.COMMAND!= string.Empty)
			{
				strBuf.Append(" And COM_LOG.COMMAND ").Append((cause.COMMAND.StartsWith("%") || cause.COMMAND.EndsWith("%")) ? " like " : " = ").Append(" :COMMAND");
				param = new OracleParameter();
				param.ParameterName =":COMMAND";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMAND;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMAND"))
			{
				strBuf.Append(cause.GetINSQL("COM_LOG", "COMMAND"));
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
		public static DisplayObject_COM_LOG[] Query(CauseObject_COM_LOG cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_LOG.ID, COM_LOG.PAGEURL, COM_LOG.TYPE, COM_LOG.USER_ID, COM_LOG.MESSAGE, COM_LOG.LOG_TIME, COM_LOG.IPADDRESS, COM_LOG.COMMAND, (case  when COM_LOG.TYPE = 1 then '正常' when COM_LOG.TYPE = 2 then '错误' else '' end ) as TYPE_NAME, COM_USER.NAME as COM_USER_NAME from COM_LOG left join COM_USER   COM_USER on COM_LOG.USER_ID = COM_USER.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_LOG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_LOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGEURL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MESSAGE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOG_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IPADDRESS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMAND = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.TYPE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_LOG[] objs = new DisplayObject_COM_LOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_LOG cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_LOG where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_LOG[] Query(CauseObject_COM_LOG cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_LOG.ID, COM_LOG.PAGEURL, COM_LOG.TYPE, COM_LOG.USER_ID, COM_LOG.MESSAGE, COM_LOG.LOG_TIME, COM_LOG.IPADDRESS, COM_LOG.COMMAND, (case  when COM_LOG.TYPE = 1 then '正常' when COM_LOG.TYPE = 2 then '错误' else '' end ) as TYPE_NAME, COM_USER.NAME as COM_USER_NAME from COM_LOG left join COM_USER   COM_USER on COM_LOG.USER_ID = COM_USER.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_LOG dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_LOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGEURL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MESSAGE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOG_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IPADDRESS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMAND = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.TYPE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_LOG[] objs = new DisplayObject_COM_LOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_LOG[] Query(CauseObject_COM_LOG cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_LOG.ID, COM_LOG.PAGEURL, COM_LOG.TYPE, COM_LOG.USER_ID, COM_LOG.MESSAGE, COM_LOG.LOG_TIME, COM_LOG.IPADDRESS, COM_LOG.COMMAND, (case  when COM_LOG.TYPE = 1 then '正常' when COM_LOG.TYPE = 2 then '错误' else '' end ) as TYPE_NAME, COM_USER.NAME as COM_USER_NAME from COM_LOG left join COM_USER   COM_USER on COM_LOG.USER_ID = COM_USER.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_LOG",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_LOG dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_LOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGEURL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MESSAGE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOG_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IPADDRESS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMAND = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.TYPE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_LOG[] objs = new DisplayObject_COM_LOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_LOG[] Query(CauseObject_COM_LOG cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_LOG.ID, COM_LOG.PAGEURL, COM_LOG.TYPE, COM_LOG.USER_ID, COM_LOG.MESSAGE, COM_LOG.LOG_TIME, COM_LOG.IPADDRESS, COM_LOG.COMMAND, (case  when COM_LOG.TYPE = 1 then '正常' when COM_LOG.TYPE = 2 then '错误' else '' end ) as TYPE_NAME, COM_USER.NAME as COM_USER_NAME from COM_LOG left join COM_USER   COM_USER on COM_LOG.USER_ID = COM_USER.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_LOG",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_LOG dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_LOG();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGEURL = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MESSAGE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOG_TIME = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IPADDRESS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMMAND = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.TYPE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.COM_USER_NAME = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_LOG[] objs = new DisplayObject_COM_LOG[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_LOG obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("PAGEURL"))
			{
				strBuf.Add("  COM_LOG.PAGEURL = :PAGEURL");
				param = new OracleParameter();
				param.ParameterName = ":PAGEURL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.PAGEURL) ? string.Empty : obj.PAGEURL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TYPE"))
			{
				strBuf.Add("  COM_LOG.TYPE = :TYPE");
				param = new OracleParameter();
				param.ParameterName = ":TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  COM_LOG.USER_ID = :USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MESSAGE"))
			{
				strBuf.Add("  COM_LOG.MESSAGE = :MESSAGE");
				param = new OracleParameter();
				param.ParameterName = ":MESSAGE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2048;
				param.Value = string.IsNullOrEmpty(obj.MESSAGE) ? string.Empty : obj.MESSAGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LOG_TIME"))
			{
				strBuf.Add("  COM_LOG.LOG_TIME = :LOG_TIME");
				param = new OracleParameter();
				param.ParameterName = ":LOG_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.LOG_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IPADDRESS"))
			{
				strBuf.Add("  COM_LOG.IPADDRESS = :IPADDRESS");
				param = new OracleParameter();
				param.ParameterName = ":IPADDRESS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.IPADDRESS) ? string.Empty : obj.IPADDRESS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMAND"))
			{
				strBuf.Add("  COM_LOG.COMMAND = :COMMAND");
				param = new OracleParameter();
				param.ParameterName = ":COMMAND";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMAND) ? string.Empty : obj.COMMAND;
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
