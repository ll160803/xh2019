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
	[CauseObject(typeof(CauseObject_COM_DATA_INSTANCE))]
	public partial class HelperObject_COM_DATA_INSTANCE
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_DATA_INSTANCE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_DATA_INSTANCE( ID, CREATE_TIME, DATA_INSTANCE_ID, PARENT_INSTANCE_ID, CREATE_DEPART_ID, DATA_ID, DATA_ORGANISE_ID, DATA_INSTANCE_CODE, CREATE_USER_ID, PARENT_DATA_ID) values ( :ID, :CREATE_TIME, :DATA_INSTANCE_ID, :PARENT_INSTANCE_ID, :CREATE_DEPART_ID, :DATA_ID, :DATA_ORGANISE_ID, :DATA_INSTANCE_CODE, :CREATE_USER_ID, :PARENT_DATA_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[10];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":CREATE_TIME";
			parameters[1].Size = 7;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[1].Value = obj.CREATE_TIME;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":DATA_INSTANCE_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.DATA_INSTANCE_ID == null ? String.Empty:obj.DATA_INSTANCE_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":PARENT_INSTANCE_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.PARENT_INSTANCE_ID == null ? String.Empty:obj.PARENT_INSTANCE_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":CREATE_DEPART_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.CREATE_DEPART_ID == null ? String.Empty:obj.CREATE_DEPART_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":DATA_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.DATA_ID == null ? String.Empty:obj.DATA_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":DATA_ORGANISE_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":DATA_INSTANCE_CODE";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.DATA_INSTANCE_CODE == null ? String.Empty:obj.DATA_INSTANCE_CODE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CREATE_USER_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":PARENT_DATA_ID";
			parameters[9].Size = 36;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.PARENT_DATA_ID == null ? String.Empty:obj.PARENT_DATA_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_DATA_INSTANCE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_DATA_INSTANCE set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_DATA_INSTANCE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_DATA_INSTANCE where  ID = :ID ";
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
		public static EntityObject_COM_DATA_INSTANCE Get(EntityObject_COM_DATA_INSTANCE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, CREATE_TIME, MODIFY_TIME, DATA_INSTANCE_ID, PARENT_INSTANCE_ID, CREATE_DEPART_ID, MODIFY_USER_ID, DATA_ID, DATA_ORGANISE_ID, DATA_INSTANCE_CODE, CREATE_USER_ID, PARENT_DATA_ID, MODIFY_DEPART_ID from COM_DATA_INSTANCE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_DATA_INSTANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_DATA_INSTANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_INSTANCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PARENT_INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_INSTANCE_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARENT_DATA_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_DATA_INSTANCE[] objs = new EntityObject_COM_DATA_INSTANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_DATA_INSTANCE Get(EntityObject_COM_DATA_INSTANCE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, CREATE_TIME, MODIFY_TIME, DATA_INSTANCE_ID, PARENT_INSTANCE_ID, CREATE_DEPART_ID, MODIFY_USER_ID, DATA_ID, DATA_ORGANISE_ID, DATA_INSTANCE_CODE, CREATE_USER_ID, PARENT_DATA_ID, MODIFY_DEPART_ID from COM_DATA_INSTANCE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_DATA_INSTANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_DATA_INSTANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_INSTANCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PARENT_INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_INSTANCE_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARENT_DATA_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_DATA_INSTANCE[] objs = new EntityObject_COM_DATA_INSTANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_DATA_INSTANCE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_DATA_INSTANCE.ID, COM_DATA_INSTANCE.CREATE_TIME, COM_DATA_INSTANCE.MODIFY_TIME, COM_DATA_INSTANCE.DATA_INSTANCE_ID, COM_DATA_INSTANCE.PARENT_INSTANCE_ID, COM_DATA_INSTANCE.CREATE_DEPART_ID, COM_DATA_INSTANCE.MODIFY_USER_ID, COM_DATA_INSTANCE.DATA_ID, COM_DATA_INSTANCE.DATA_ORGANISE_ID, COM_DATA_INSTANCE.DATA_INSTANCE_CODE, COM_DATA_INSTANCE.CREATE_USER_ID, COM_DATA_INSTANCE.PARENT_DATA_ID, COM_DATA_INSTANCE.MODIFY_DEPART_ID, COM_DATA.NAME as COM_DATA_NAME, COM_DATA_1.NAME as COM_DATA_1_NAME from COM_DATA_INSTANCE left join COM_DATA   COM_DATA on COM_DATA_INSTANCE.DATA_ID = COM_DATA.ID left join COM_DATA   COM_DATA_1 on COM_DATA_INSTANCE.PARENT_DATA_ID = COM_DATA_1.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_DATA_INSTANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_DATA_INSTANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_INSTANCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PARENT_INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_INSTANCE_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARENT_DATA_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.COM_DATA_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.COM_DATA_NAME_1 = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_DATA_INSTANCE[] objs = new DisplayObject_COM_DATA_INSTANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_DATA_INSTANCE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And COM_DATA_INSTANCE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And COM_DATA_INSTANCE.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And COM_DATA_INSTANCE.CREATE_TIME < :CREATE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.End;
					paramList.Add(param);
				}
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And COM_DATA_INSTANCE.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And COM_DATA_INSTANCE.MODIFY_TIME < :MODIFY_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.End;
					paramList.Add(param);
				}
			}
			if(cause.DATA_INSTANCE_ID!= string.Empty)
			{
				strBuf.Append(" And COM_DATA_INSTANCE.DATA_INSTANCE_ID ").Append((cause.DATA_INSTANCE_ID.StartsWith("%") || cause.DATA_INSTANCE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_INSTANCE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_INSTANCE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_INSTANCE_ID;
				paramList.Add(param);
			}
			if(cause.PARENT_INSTANCE_ID!= string.Empty)
			{
				strBuf.Append(" And COM_DATA_INSTANCE.PARENT_INSTANCE_ID ").Append((cause.PARENT_INSTANCE_ID.StartsWith("%") || cause.PARENT_INSTANCE_ID.EndsWith("%")) ? " like " : " = ").Append(" :PARENT_INSTANCE_ID");
				param = new OracleParameter();
				param.ParameterName =":PARENT_INSTANCE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PARENT_INSTANCE_ID;
				paramList.Add(param);
			}
			if(cause.CREATE_DEPART_ID!= string.Empty)
			{
				strBuf.Append(" And COM_DATA_INSTANCE.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if(cause.MODIFY_USER_ID!= string.Empty)
			{
				strBuf.Append(" And COM_DATA_INSTANCE.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if(cause.DATA_ID!= string.Empty)
			{
				strBuf.Append(" And COM_DATA_INSTANCE.DATA_ID ").Append((cause.DATA_ID.StartsWith("%") || cause.DATA_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ID;
				paramList.Add(param);
			}
			if(cause.DATA_ORGANISE_ID!= string.Empty)
			{
				strBuf.Append(" And COM_DATA_INSTANCE.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if(cause.DATA_INSTANCE_CODE!= string.Empty)
			{
				strBuf.Append(" And COM_DATA_INSTANCE.DATA_INSTANCE_CODE ").Append((cause.DATA_INSTANCE_CODE.StartsWith("%") || cause.DATA_INSTANCE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :DATA_INSTANCE_CODE");
				param = new OracleParameter();
				param.ParameterName =":DATA_INSTANCE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DATA_INSTANCE_CODE;
				paramList.Add(param);
			}
			if(cause.CREATE_USER_ID!= string.Empty)
			{
				strBuf.Append(" And COM_DATA_INSTANCE.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if(cause.PARENT_DATA_ID!= string.Empty)
			{
				strBuf.Append(" And COM_DATA_INSTANCE.PARENT_DATA_ID ").Append((cause.PARENT_DATA_ID.StartsWith("%") || cause.PARENT_DATA_ID.EndsWith("%")) ? " like " : " = ").Append(" :PARENT_DATA_ID");
				param = new OracleParameter();
				param.ParameterName =":PARENT_DATA_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PARENT_DATA_ID;
				paramList.Add(param);
			}
			if(cause.MODIFY_DEPART_ID!= string.Empty)
			{
				strBuf.Append(" And COM_DATA_INSTANCE.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return strBuf.ToString();


		}
		public static DisplayObject_COM_DATA_INSTANCE[] Query(CauseObject_COM_DATA_INSTANCE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_DATA_INSTANCE.ID, COM_DATA_INSTANCE.CREATE_TIME, COM_DATA_INSTANCE.MODIFY_TIME, COM_DATA_INSTANCE.DATA_INSTANCE_ID, COM_DATA_INSTANCE.PARENT_INSTANCE_ID, COM_DATA_INSTANCE.CREATE_DEPART_ID, COM_DATA_INSTANCE.MODIFY_USER_ID, COM_DATA_INSTANCE.DATA_ID, COM_DATA_INSTANCE.DATA_ORGANISE_ID, COM_DATA_INSTANCE.DATA_INSTANCE_CODE, COM_DATA_INSTANCE.CREATE_USER_ID, COM_DATA_INSTANCE.PARENT_DATA_ID, COM_DATA_INSTANCE.MODIFY_DEPART_ID, COM_DATA.NAME as COM_DATA_NAME, COM_DATA_1.NAME as COM_DATA_1_NAME from COM_DATA_INSTANCE left join COM_DATA   COM_DATA on COM_DATA_INSTANCE.DATA_ID = COM_DATA.ID left join COM_DATA   COM_DATA_1 on COM_DATA_INSTANCE.PARENT_DATA_ID = COM_DATA_1.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_DATA_INSTANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_DATA_INSTANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_INSTANCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PARENT_INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_INSTANCE_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARENT_DATA_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.COM_DATA_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.COM_DATA_NAME_1 = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_DATA_INSTANCE[] objs = new DisplayObject_COM_DATA_INSTANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_DATA_INSTANCE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_DATA_INSTANCE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_DATA_INSTANCE[] Query(CauseObject_COM_DATA_INSTANCE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_DATA_INSTANCE.ID, COM_DATA_INSTANCE.CREATE_TIME, COM_DATA_INSTANCE.MODIFY_TIME, COM_DATA_INSTANCE.DATA_INSTANCE_ID, COM_DATA_INSTANCE.PARENT_INSTANCE_ID, COM_DATA_INSTANCE.CREATE_DEPART_ID, COM_DATA_INSTANCE.MODIFY_USER_ID, COM_DATA_INSTANCE.DATA_ID, COM_DATA_INSTANCE.DATA_ORGANISE_ID, COM_DATA_INSTANCE.DATA_INSTANCE_CODE, COM_DATA_INSTANCE.CREATE_USER_ID, COM_DATA_INSTANCE.PARENT_DATA_ID, COM_DATA_INSTANCE.MODIFY_DEPART_ID, COM_DATA.NAME as COM_DATA_NAME, COM_DATA_1.NAME as COM_DATA_1_NAME from COM_DATA_INSTANCE left join COM_DATA   COM_DATA on COM_DATA_INSTANCE.DATA_ID = COM_DATA.ID left join COM_DATA   COM_DATA_1 on COM_DATA_INSTANCE.PARENT_DATA_ID = COM_DATA_1.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_DATA_INSTANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_DATA_INSTANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_INSTANCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PARENT_INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_INSTANCE_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARENT_DATA_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.COM_DATA_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.COM_DATA_NAME_1 = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_DATA_INSTANCE[] objs = new DisplayObject_COM_DATA_INSTANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_DATA_INSTANCE[] Query(CauseObject_COM_DATA_INSTANCE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_DATA_INSTANCE.ID, COM_DATA_INSTANCE.CREATE_TIME, COM_DATA_INSTANCE.MODIFY_TIME, COM_DATA_INSTANCE.DATA_INSTANCE_ID, COM_DATA_INSTANCE.PARENT_INSTANCE_ID, COM_DATA_INSTANCE.CREATE_DEPART_ID, COM_DATA_INSTANCE.MODIFY_USER_ID, COM_DATA_INSTANCE.DATA_ID, COM_DATA_INSTANCE.DATA_ORGANISE_ID, COM_DATA_INSTANCE.DATA_INSTANCE_CODE, COM_DATA_INSTANCE.CREATE_USER_ID, COM_DATA_INSTANCE.PARENT_DATA_ID, COM_DATA_INSTANCE.MODIFY_DEPART_ID, COM_DATA.NAME as COM_DATA_NAME, COM_DATA_1.NAME as COM_DATA_1_NAME from COM_DATA_INSTANCE left join COM_DATA   COM_DATA on COM_DATA_INSTANCE.DATA_ID = COM_DATA.ID left join COM_DATA   COM_DATA_1 on COM_DATA_INSTANCE.PARENT_DATA_ID = COM_DATA_1.ID where (1=1)";
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
					countSql = "Select Count(*) From COM_DATA_INSTANCE Where (1=1)" + sCauseSql;
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_DATA_INSTANCE",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_DATA_INSTANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_DATA_INSTANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_INSTANCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PARENT_INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_INSTANCE_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARENT_DATA_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.COM_DATA_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.COM_DATA_NAME_1 = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_DATA_INSTANCE[] objs = new DisplayObject_COM_DATA_INSTANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_DATA_INSTANCE[] Query(CauseObject_COM_DATA_INSTANCE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_DATA_INSTANCE.ID, COM_DATA_INSTANCE.CREATE_TIME, COM_DATA_INSTANCE.MODIFY_TIME, COM_DATA_INSTANCE.DATA_INSTANCE_ID, COM_DATA_INSTANCE.PARENT_INSTANCE_ID, COM_DATA_INSTANCE.CREATE_DEPART_ID, COM_DATA_INSTANCE.MODIFY_USER_ID, COM_DATA_INSTANCE.DATA_ID, COM_DATA_INSTANCE.DATA_ORGANISE_ID, COM_DATA_INSTANCE.DATA_INSTANCE_CODE, COM_DATA_INSTANCE.CREATE_USER_ID, COM_DATA_INSTANCE.PARENT_DATA_ID, COM_DATA_INSTANCE.MODIFY_DEPART_ID, COM_DATA.NAME as COM_DATA_NAME, COM_DATA_1.NAME as COM_DATA_1_NAME from COM_DATA_INSTANCE left join COM_DATA   COM_DATA on COM_DATA_INSTANCE.DATA_ID = COM_DATA.ID left join COM_DATA   COM_DATA_1 on COM_DATA_INSTANCE.PARENT_DATA_ID = COM_DATA_1.ID where (1=1)";
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
					countSql = "Select Count(*) From COM_DATA_INSTANCE Where (1=1)" + sCauseSql;
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer || IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.Db2? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_DATA_INSTANCE",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_DATA_INSTANCE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_DATA_INSTANCE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DATA_INSTANCE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PARENT_INSTANCE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.DATA_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.DATA_INSTANCE_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARENT_DATA_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.COM_DATA_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.COM_DATA_NAME_1 = sqlReader.GetString(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_DATA_INSTANCE[] objs = new DisplayObject_COM_DATA_INSTANCE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_DATA_INSTANCE obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  COM_DATA_INSTANCE.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_INSTANCE_ID"))
			{
				strBuf.Add("  COM_DATA_INSTANCE.DATA_INSTANCE_ID = :DATA_INSTANCE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_INSTANCE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_INSTANCE_ID) ? string.Empty : obj.DATA_INSTANCE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PARENT_INSTANCE_ID"))
			{
				strBuf.Add("  COM_DATA_INSTANCE.PARENT_INSTANCE_ID = :PARENT_INSTANCE_ID");
				param = new OracleParameter();
				param.ParameterName = ":PARENT_INSTANCE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PARENT_INSTANCE_ID) ? string.Empty : obj.PARENT_INSTANCE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  COM_DATA_INSTANCE.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ID"))
			{
				strBuf.Add("  COM_DATA_INSTANCE.DATA_ID = :DATA_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ID) ? string.Empty : obj.DATA_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  COM_DATA_INSTANCE.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_INSTANCE_CODE"))
			{
				strBuf.Add("  COM_DATA_INSTANCE.DATA_INSTANCE_CODE = :DATA_INSTANCE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":DATA_INSTANCE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.DATA_INSTANCE_CODE) ? string.Empty : obj.DATA_INSTANCE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PARENT_DATA_ID"))
			{
				strBuf.Add("  COM_DATA_INSTANCE.PARENT_DATA_ID = :PARENT_DATA_ID");
				param = new OracleParameter();
				param.ParameterName = ":PARENT_DATA_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PARENT_DATA_ID) ? string.Empty : obj.PARENT_DATA_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  COM_DATA_INSTANCE.MODIFY_DEPART_ID = :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
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
