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
	[CauseObject(typeof(CauseObject_COM_PARAMETER))]
	public partial class HelperObject_COM_PARAMETER
	{		
		#region Method Blok
		public static int Save(EntityObject_COM_PARAMETER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into COM_PARAMETER( DATA_ORGANISE_ID, ID, CREATE_DEPART_ID, CREATE_USER_ID, PARAMETER_CODE, PARAMETER_VALUE, PARAMETER_COMMENT, CREATE_TIME, PARAMETER_KEY) values ( :DATA_ORGANISE_ID, :ID, :CREATE_DEPART_ID, :CREATE_USER_ID, :PARAMETER_CODE, :PARAMETER_VALUE, :PARAMETER_COMMENT, :CREATE_TIME, :PARAMETER_KEY)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[9];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":DATA_ORGANISE_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CREATE_DEPART_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.CREATE_DEPART_ID == null ? String.Empty:obj.CREATE_DEPART_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":CREATE_USER_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":PARAMETER_CODE";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.PARAMETER_CODE == null ? String.Empty:obj.PARAMETER_CODE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":PARAMETER_VALUE";
			parameters[5].Size = 1024;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.PARAMETER_VALUE == null ? String.Empty:obj.PARAMETER_VALUE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":PARAMETER_COMMENT";
			parameters[6].Size = 200;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.PARAMETER_COMMENT == null ? String.Empty:obj.PARAMETER_COMMENT;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":CREATE_TIME";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.CREATE_TIME;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":PARAMETER_KEY";
			parameters[8].Size = 50;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.PARAMETER_KEY == null ? String.Empty:obj.PARAMETER_KEY;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_COM_PARAMETER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update COM_PARAMETER set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_COM_PARAMETER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from COM_PARAMETER where  ID = :ID ";
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
		public static EntityObject_COM_PARAMETER Get(EntityObject_COM_PARAMETER obj)
		{
			
			//平台自动生成代码
			string sSql = "select  DATA_ORGANISE_ID, MODIFY_TIME, ID, CREATE_DEPART_ID, MODIFY_DEPART_ID, CREATE_USER_ID, PARAMETER_CODE, PARAMETER_VALUE, PARAMETER_COMMENT, CREATE_TIME, MODIFY_USER_ID, PARAMETER_KEY from COM_PARAMETER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_PARAMETER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_PARAMETER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARAMETER_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARAMETER_VALUE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PARAMETER_COMMENT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARAMETER_KEY = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_COM_PARAMETER[] objs = new EntityObject_COM_PARAMETER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_COM_PARAMETER Get(EntityObject_COM_PARAMETER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  DATA_ORGANISE_ID, MODIFY_TIME, ID, CREATE_DEPART_ID, MODIFY_DEPART_ID, CREATE_USER_ID, PARAMETER_CODE, PARAMETER_VALUE, PARAMETER_COMMENT, CREATE_TIME, MODIFY_USER_ID, PARAMETER_KEY from COM_PARAMETER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_COM_PARAMETER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_COM_PARAMETER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARAMETER_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARAMETER_VALUE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PARAMETER_COMMENT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARAMETER_KEY = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_COM_PARAMETER[] objs = new EntityObject_COM_PARAMETER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_COM_PARAMETER[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  COM_PARAMETER.DATA_ORGANISE_ID, COM_PARAMETER.MODIFY_TIME, COM_PARAMETER.ID, COM_PARAMETER.CREATE_DEPART_ID, COM_PARAMETER.MODIFY_DEPART_ID, COM_PARAMETER.CREATE_USER_ID, COM_PARAMETER.PARAMETER_CODE, COM_PARAMETER.PARAMETER_VALUE, COM_PARAMETER.PARAMETER_COMMENT, COM_PARAMETER.CREATE_TIME, COM_PARAMETER.MODIFY_USER_ID, COM_PARAMETER.PARAMETER_KEY from COM_PARAMETER where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_COM_PARAMETER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_PARAMETER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARAMETER_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARAMETER_VALUE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PARAMETER_COMMENT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARAMETER_KEY = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_PARAMETER[] objs = new DisplayObject_COM_PARAMETER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_COM_PARAMETER cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.DATA_ORGANISE_ID!= string.Empty)
			{
				strBuf.Append(" And COM_PARAMETER.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_PARAMETER", "DATA_ORGANISE_ID"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And COM_PARAMETER.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And COM_PARAMETER.MODIFY_TIME < :MODIFY_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("MODIFY_TIME"))
			{
				strBuf.Append(cause.GetINSQL("COM_PARAMETER", "MODIFY_TIME"));
			}
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And COM_PARAMETER.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_PARAMETER", "ID"));
			}
			if(cause.CREATE_DEPART_ID!= string.Empty)
			{
				strBuf.Append(" And COM_PARAMETER.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_PARAMETER", "CREATE_DEPART_ID"));
			}
			if(cause.MODIFY_DEPART_ID!= string.Empty)
			{
				strBuf.Append(" And COM_PARAMETER.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_PARAMETER", "MODIFY_DEPART_ID"));
			}
			if(cause.CREATE_USER_ID!= string.Empty)
			{
				strBuf.Append(" And COM_PARAMETER.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_PARAMETER", "CREATE_USER_ID"));
			}
			if(cause.PARAMETER_CODE!= string.Empty)
			{
				strBuf.Append(" And COM_PARAMETER.PARAMETER_CODE ").Append((cause.PARAMETER_CODE.StartsWith("%") || cause.PARAMETER_CODE.EndsWith("%")) ? " like " : " = ").Append(" :PARAMETER_CODE");
				param = new OracleParameter();
				param.ParameterName =":PARAMETER_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PARAMETER_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PARAMETER_CODE"))
			{
				strBuf.Append(cause.GetINSQL("COM_PARAMETER", "PARAMETER_CODE"));
			}
			if(cause.PARAMETER_VALUE!= string.Empty)
			{
				strBuf.Append(" And COM_PARAMETER.PARAMETER_VALUE ").Append((cause.PARAMETER_VALUE.StartsWith("%") || cause.PARAMETER_VALUE.EndsWith("%")) ? " like " : " = ").Append(" :PARAMETER_VALUE");
				param = new OracleParameter();
				param.ParameterName =":PARAMETER_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1024;
				param.Value = cause.PARAMETER_VALUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PARAMETER_VALUE"))
			{
				strBuf.Append(cause.GetINSQL("COM_PARAMETER", "PARAMETER_VALUE"));
			}
			if(cause.PARAMETER_COMMENT!= string.Empty)
			{
				strBuf.Append(" And COM_PARAMETER.PARAMETER_COMMENT ").Append((cause.PARAMETER_COMMENT.StartsWith("%") || cause.PARAMETER_COMMENT.EndsWith("%")) ? " like " : " = ").Append(" :PARAMETER_COMMENT");
				param = new OracleParameter();
				param.ParameterName =":PARAMETER_COMMENT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.PARAMETER_COMMENT;
				paramList.Add(param);
			}
			if (cause.HasINValue("PARAMETER_COMMENT"))
			{
				strBuf.Append(cause.GetINSQL("COM_PARAMETER", "PARAMETER_COMMENT"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And COM_PARAMETER.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And COM_PARAMETER.CREATE_TIME < :CREATE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_TIME"))
			{
				strBuf.Append(cause.GetINSQL("COM_PARAMETER", "CREATE_TIME"));
			}
			if(cause.MODIFY_USER_ID!= string.Empty)
			{
				strBuf.Append(" And COM_PARAMETER.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("COM_PARAMETER", "MODIFY_USER_ID"));
			}
			if(cause.PARAMETER_KEY!= string.Empty)
			{
				strBuf.Append(" And COM_PARAMETER.PARAMETER_KEY ").Append((cause.PARAMETER_KEY.StartsWith("%") || cause.PARAMETER_KEY.EndsWith("%")) ? " like " : " = ").Append(" :PARAMETER_KEY");
				param = new OracleParameter();
				param.ParameterName =":PARAMETER_KEY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PARAMETER_KEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("PARAMETER_KEY"))
			{
				strBuf.Append(cause.GetINSQL("COM_PARAMETER", "PARAMETER_KEY"));
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
		public static DisplayObject_COM_PARAMETER[] Query(CauseObject_COM_PARAMETER cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_PARAMETER.DATA_ORGANISE_ID, COM_PARAMETER.MODIFY_TIME, COM_PARAMETER.ID, COM_PARAMETER.CREATE_DEPART_ID, COM_PARAMETER.MODIFY_DEPART_ID, COM_PARAMETER.CREATE_USER_ID, COM_PARAMETER.PARAMETER_CODE, COM_PARAMETER.PARAMETER_VALUE, COM_PARAMETER.PARAMETER_COMMENT, COM_PARAMETER.CREATE_TIME, COM_PARAMETER.MODIFY_USER_ID, COM_PARAMETER.PARAMETER_KEY from COM_PARAMETER where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_PARAMETER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_PARAMETER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARAMETER_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARAMETER_VALUE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PARAMETER_COMMENT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARAMETER_KEY = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_PARAMETER[] objs = new DisplayObject_COM_PARAMETER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_COM_PARAMETER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from COM_PARAMETER where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_COM_PARAMETER[] Query(CauseObject_COM_PARAMETER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  COM_PARAMETER.DATA_ORGANISE_ID, COM_PARAMETER.MODIFY_TIME, COM_PARAMETER.ID, COM_PARAMETER.CREATE_DEPART_ID, COM_PARAMETER.MODIFY_DEPART_ID, COM_PARAMETER.CREATE_USER_ID, COM_PARAMETER.PARAMETER_CODE, COM_PARAMETER.PARAMETER_VALUE, COM_PARAMETER.PARAMETER_COMMENT, COM_PARAMETER.CREATE_TIME, COM_PARAMETER.MODIFY_USER_ID, COM_PARAMETER.PARAMETER_KEY from COM_PARAMETER where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_COM_PARAMETER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_PARAMETER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARAMETER_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARAMETER_VALUE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PARAMETER_COMMENT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARAMETER_KEY = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_PARAMETER[] objs = new DisplayObject_COM_PARAMETER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_PARAMETER[] Query(CauseObject_COM_PARAMETER cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_PARAMETER.DATA_ORGANISE_ID, COM_PARAMETER.MODIFY_TIME, COM_PARAMETER.ID, COM_PARAMETER.CREATE_DEPART_ID, COM_PARAMETER.MODIFY_DEPART_ID, COM_PARAMETER.CREATE_USER_ID, COM_PARAMETER.PARAMETER_CODE, COM_PARAMETER.PARAMETER_VALUE, COM_PARAMETER.PARAMETER_COMMENT, COM_PARAMETER.CREATE_TIME, COM_PARAMETER.MODIFY_USER_ID, COM_PARAMETER.PARAMETER_KEY from COM_PARAMETER where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_PARAMETER",paging, order, sSql, parameters, connection);
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
			DisplayObject_COM_PARAMETER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_PARAMETER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARAMETER_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARAMETER_VALUE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PARAMETER_COMMENT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARAMETER_KEY = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_COM_PARAMETER[] objs = new DisplayObject_COM_PARAMETER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_COM_PARAMETER[] Query(CauseObject_COM_PARAMETER cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  COM_PARAMETER.DATA_ORGANISE_ID, COM_PARAMETER.MODIFY_TIME, COM_PARAMETER.ID, COM_PARAMETER.CREATE_DEPART_ID, COM_PARAMETER.MODIFY_DEPART_ID, COM_PARAMETER.CREATE_USER_ID, COM_PARAMETER.PARAMETER_CODE, COM_PARAMETER.PARAMETER_VALUE, COM_PARAMETER.PARAMETER_COMMENT, COM_PARAMETER.CREATE_TIME, COM_PARAMETER.MODIFY_USER_ID, COM_PARAMETER.PARAMETER_KEY from COM_PARAMETER where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("COM_PARAMETER",paging, order, sSql, parameters, trans);
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
			DisplayObject_COM_PARAMETER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_COM_PARAMETER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PARAMETER_CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PARAMETER_VALUE = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PARAMETER_COMMENT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.PARAMETER_KEY = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_COM_PARAMETER[] objs = new DisplayObject_COM_PARAMETER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_COM_PARAMETER obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  COM_PARAMETER.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  COM_PARAMETER.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  COM_PARAMETER.MODIFY_DEPART_ID = :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PARAMETER_CODE"))
			{
				strBuf.Add("  COM_PARAMETER.PARAMETER_CODE = :PARAMETER_CODE");
				param = new OracleParameter();
				param.ParameterName = ":PARAMETER_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PARAMETER_CODE) ? string.Empty : obj.PARAMETER_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PARAMETER_VALUE"))
			{
				strBuf.Add("  COM_PARAMETER.PARAMETER_VALUE = :PARAMETER_VALUE");
				param = new OracleParameter();
				param.ParameterName = ":PARAMETER_VALUE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1024;
				param.Value = string.IsNullOrEmpty(obj.PARAMETER_VALUE) ? string.Empty : obj.PARAMETER_VALUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PARAMETER_COMMENT"))
			{
				strBuf.Add("  COM_PARAMETER.PARAMETER_COMMENT = :PARAMETER_COMMENT");
				param = new OracleParameter();
				param.ParameterName = ":PARAMETER_COMMENT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.PARAMETER_COMMENT) ? string.Empty : obj.PARAMETER_COMMENT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  COM_PARAMETER.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PARAMETER_KEY"))
			{
				strBuf.Add("  COM_PARAMETER.PARAMETER_KEY = :PARAMETER_KEY");
				param = new OracleParameter();
				param.ParameterName = ":PARAMETER_KEY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PARAMETER_KEY) ? string.Empty : obj.PARAMETER_KEY;
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
