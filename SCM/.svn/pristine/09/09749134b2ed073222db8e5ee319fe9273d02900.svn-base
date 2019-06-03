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
	[CauseObject(typeof(CauseObject_SITE_PROMOTION))]
	public partial class HelperObject_SITE_PROMOTION
	{		
		#region Method Blok
		public static int Save(EntityObject_SITE_PROMOTION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into SITE_PROMOTION( ID, PROMOTION_STATE, INTERESTED_COUNT, SUMMARY, BROWSE_COUNT, BEGIN_DATE, IMAGE_URL, PRAISE_COUNT, SUBJECT, END_DATE) values ( :ID, :PROMOTION_STATE, :INTERESTED_COUNT, :SUMMARY, :BROWSE_COUNT, :BEGIN_DATE, :IMAGE_URL, :PRAISE_COUNT, :SUBJECT, :END_DATE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[10];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":PROMOTION_STATE";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.PROMOTION_STATE == null ? String.Empty:obj.PROMOTION_STATE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":INTERESTED_COUNT";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.INTERESTED_COUNT;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":SUMMARY";
			parameters[3].Size = 1024;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.SUMMARY == null ? String.Empty:obj.SUMMARY;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":BROWSE_COUNT";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.BROWSE_COUNT;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":BEGIN_DATE";
			parameters[5].Size = 7;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[5].Value = obj.BEGIN_DATE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":IMAGE_URL";
			parameters[6].Size = 200;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.IMAGE_URL == null ? String.Empty:obj.IMAGE_URL;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":PRAISE_COUNT";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.PRAISE_COUNT;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":SUBJECT";
			parameters[8].Size = 50;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.SUBJECT == null ? String.Empty:obj.SUBJECT;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":END_DATE";
			parameters[9].Size = 7;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[9].Value = obj.END_DATE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SITE_PROMOTION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SITE_PROMOTION set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SITE_PROMOTION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SITE_PROMOTION where  ID = :ID ";
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
		public static EntityObject_SITE_PROMOTION Get(EntityObject_SITE_PROMOTION obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, PROMOTION_STATE, INTERESTED_COUNT, SUMMARY, BROWSE_COUNT, BEGIN_DATE, IMAGE_URL, PRAISE_COUNT, SUBJECT, END_DATE from SITE_PROMOTION where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SITE_PROMOTION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SITE_PROMOTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROMOTION_STATE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INTERESTED_COUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BEGIN_DATE = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IMAGE_URL = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SUBJECT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.END_DATE = sqlReader.GetDateTime(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SITE_PROMOTION[] objs = new EntityObject_SITE_PROMOTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_SITE_PROMOTION Get(EntityObject_SITE_PROMOTION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, PROMOTION_STATE, INTERESTED_COUNT, SUMMARY, BROWSE_COUNT, BEGIN_DATE, IMAGE_URL, PRAISE_COUNT, SUBJECT, END_DATE from SITE_PROMOTION where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SITE_PROMOTION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SITE_PROMOTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROMOTION_STATE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INTERESTED_COUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BEGIN_DATE = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IMAGE_URL = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SUBJECT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.END_DATE = sqlReader.GetDateTime(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SITE_PROMOTION[] objs = new EntityObject_SITE_PROMOTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SITE_PROMOTION[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SITE_PROMOTION.ID, SITE_PROMOTION.PROMOTION_STATE, SITE_PROMOTION.INTERESTED_COUNT, SITE_PROMOTION.SUMMARY, SITE_PROMOTION.BROWSE_COUNT, SITE_PROMOTION.BEGIN_DATE, SITE_PROMOTION.IMAGE_URL, SITE_PROMOTION.PRAISE_COUNT, SITE_PROMOTION.SUBJECT, SITE_PROMOTION.END_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_PROMOTION left join COM_TYPE   COM_TYPE on SITE_PROMOTION.PROMOTION_STATE = COM_TYPE.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SITE_PROMOTION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_PROMOTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROMOTION_STATE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INTERESTED_COUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BEGIN_DATE = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IMAGE_URL = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SUBJECT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.END_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_PROMOTION[] objs = new DisplayObject_SITE_PROMOTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SITE_PROMOTION cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And SITE_PROMOTION.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SITE_PROMOTION", "ID"));
			}
			if(cause.PROMOTION_STATE!= string.Empty)
			{
				strBuf.Append(" And SITE_PROMOTION.PROMOTION_STATE ").Append((cause.PROMOTION_STATE.StartsWith("%") || cause.PROMOTION_STATE.EndsWith("%")) ? " like " : " = ").Append(" :PROMOTION_STATE");
				param = new OracleParameter();
				param.ParameterName =":PROMOTION_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PROMOTION_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PROMOTION_STATE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_PROMOTION", "PROMOTION_STATE"));
			}
			if(cause.INTERESTED_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SITE_PROMOTION.INTERESTED_COUNT = :INTERESTED_COUNT");
				param = new OracleParameter();
				param.ParameterName =":INTERESTED_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.INTERESTED_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("INTERESTED_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("SITE_PROMOTION", "INTERESTED_COUNT"));
			}
			if(cause.SUMMARY!= string.Empty)
			{
				strBuf.Append(" And SITE_PROMOTION.SUMMARY ").Append((cause.SUMMARY.StartsWith("%") || cause.SUMMARY.EndsWith("%")) ? " like " : " = ").Append(" :SUMMARY");
				param = new OracleParameter();
				param.ParameterName =":SUMMARY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1024;
				param.Value = cause.SUMMARY;
				paramList.Add(param);
			}
			if (cause.HasINValue("SUMMARY"))
			{
				strBuf.Append(cause.GetINSQL("SITE_PROMOTION", "SUMMARY"));
			}
			if(cause.BROWSE_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SITE_PROMOTION.BROWSE_COUNT = :BROWSE_COUNT");
				param = new OracleParameter();
				param.ParameterName =":BROWSE_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.BROWSE_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("BROWSE_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("SITE_PROMOTION", "BROWSE_COUNT"));
			}
			if(cause.BEGIN_DATE!= null)
			{
				if (cause.BEGIN_DATE.Begin != null)
				{
					strBuf.Append(" And SITE_PROMOTION.BEGIN_DATE >= :BEGIN_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":BEGIN_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.BEGIN_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.BEGIN_DATE.End != null)
				{
					strBuf.Append(" And SITE_PROMOTION.BEGIN_DATE < :BEGIN_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":BEGIN_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.BEGIN_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("BEGIN_DATE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_PROMOTION", "BEGIN_DATE"));
			}
			if(cause.IMAGE_URL!= string.Empty)
			{
				strBuf.Append(" And SITE_PROMOTION.IMAGE_URL ").Append((cause.IMAGE_URL.StartsWith("%") || cause.IMAGE_URL.EndsWith("%")) ? " like " : " = ").Append(" :IMAGE_URL");
				param = new OracleParameter();
				param.ParameterName =":IMAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.IMAGE_URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("IMAGE_URL"))
			{
				strBuf.Append(cause.GetINSQL("SITE_PROMOTION", "IMAGE_URL"));
			}
			if(cause.PRAISE_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SITE_PROMOTION.PRAISE_COUNT = :PRAISE_COUNT");
				param = new OracleParameter();
				param.ParameterName =":PRAISE_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PRAISE_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRAISE_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("SITE_PROMOTION", "PRAISE_COUNT"));
			}
			if(cause.SUBJECT!= string.Empty)
			{
				strBuf.Append(" And SITE_PROMOTION.SUBJECT ").Append((cause.SUBJECT.StartsWith("%") || cause.SUBJECT.EndsWith("%")) ? " like " : " = ").Append(" :SUBJECT");
				param = new OracleParameter();
				param.ParameterName =":SUBJECT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SUBJECT;
				paramList.Add(param);
			}
			if (cause.HasINValue("SUBJECT"))
			{
				strBuf.Append(cause.GetINSQL("SITE_PROMOTION", "SUBJECT"));
			}
			if(cause.END_DATE!= null)
			{
				if (cause.END_DATE.Begin != null)
				{
					strBuf.Append(" And SITE_PROMOTION.END_DATE >= :END_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":END_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.END_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.END_DATE.End != null)
				{
					strBuf.Append(" And SITE_PROMOTION.END_DATE < :END_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":END_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.END_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("END_DATE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_PROMOTION", "END_DATE"));
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
		public static DisplayObject_SITE_PROMOTION[] Query(CauseObject_SITE_PROMOTION cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SITE_PROMOTION.ID, SITE_PROMOTION.PROMOTION_STATE, SITE_PROMOTION.INTERESTED_COUNT, SITE_PROMOTION.SUMMARY, SITE_PROMOTION.BROWSE_COUNT, SITE_PROMOTION.BEGIN_DATE, SITE_PROMOTION.IMAGE_URL, SITE_PROMOTION.PRAISE_COUNT, SITE_PROMOTION.SUBJECT, SITE_PROMOTION.END_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_PROMOTION left join COM_TYPE   COM_TYPE on SITE_PROMOTION.PROMOTION_STATE = COM_TYPE.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SITE_PROMOTION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_PROMOTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROMOTION_STATE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INTERESTED_COUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BEGIN_DATE = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IMAGE_URL = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SUBJECT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.END_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_PROMOTION[] objs = new DisplayObject_SITE_PROMOTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_SITE_PROMOTION cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SITE_PROMOTION where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_SITE_PROMOTION[] Query(CauseObject_SITE_PROMOTION cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SITE_PROMOTION.ID, SITE_PROMOTION.PROMOTION_STATE, SITE_PROMOTION.INTERESTED_COUNT, SITE_PROMOTION.SUMMARY, SITE_PROMOTION.BROWSE_COUNT, SITE_PROMOTION.BEGIN_DATE, SITE_PROMOTION.IMAGE_URL, SITE_PROMOTION.PRAISE_COUNT, SITE_PROMOTION.SUBJECT, SITE_PROMOTION.END_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_PROMOTION left join COM_TYPE   COM_TYPE on SITE_PROMOTION.PROMOTION_STATE = COM_TYPE.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SITE_PROMOTION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_PROMOTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROMOTION_STATE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INTERESTED_COUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BEGIN_DATE = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IMAGE_URL = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SUBJECT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.END_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SITE_PROMOTION[] objs = new DisplayObject_SITE_PROMOTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SITE_PROMOTION[] Query(CauseObject_SITE_PROMOTION cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SITE_PROMOTION.ID, SITE_PROMOTION.PROMOTION_STATE, SITE_PROMOTION.INTERESTED_COUNT, SITE_PROMOTION.SUMMARY, SITE_PROMOTION.BROWSE_COUNT, SITE_PROMOTION.BEGIN_DATE, SITE_PROMOTION.IMAGE_URL, SITE_PROMOTION.PRAISE_COUNT, SITE_PROMOTION.SUBJECT, SITE_PROMOTION.END_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_PROMOTION left join COM_TYPE   COM_TYPE on SITE_PROMOTION.PROMOTION_STATE = COM_TYPE.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SITE_PROMOTION",paging, order, sSql, parameters, connection);
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
			DisplayObject_SITE_PROMOTION dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_PROMOTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROMOTION_STATE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INTERESTED_COUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BEGIN_DATE = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IMAGE_URL = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SUBJECT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.END_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_PROMOTION[] objs = new DisplayObject_SITE_PROMOTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SITE_PROMOTION[] Query(CauseObject_SITE_PROMOTION cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SITE_PROMOTION.ID, SITE_PROMOTION.PROMOTION_STATE, SITE_PROMOTION.INTERESTED_COUNT, SITE_PROMOTION.SUMMARY, SITE_PROMOTION.BROWSE_COUNT, SITE_PROMOTION.BEGIN_DATE, SITE_PROMOTION.IMAGE_URL, SITE_PROMOTION.PRAISE_COUNT, SITE_PROMOTION.SUBJECT, SITE_PROMOTION.END_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_PROMOTION left join COM_TYPE   COM_TYPE on SITE_PROMOTION.PROMOTION_STATE = COM_TYPE.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SITE_PROMOTION",paging, order, sSql, parameters, trans);
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
			DisplayObject_SITE_PROMOTION dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_PROMOTION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PROMOTION_STATE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.INTERESTED_COUNT = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SUMMARY = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.BEGIN_DATE = sqlReader.GetDateTime(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.IMAGE_URL = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.SUBJECT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.END_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SITE_PROMOTION[] objs = new DisplayObject_SITE_PROMOTION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SITE_PROMOTION obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("PROMOTION_STATE"))
			{
				strBuf.Add("  SITE_PROMOTION.PROMOTION_STATE = :PROMOTION_STATE");
				param = new OracleParameter();
				param.ParameterName = ":PROMOTION_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PROMOTION_STATE) ? string.Empty : obj.PROMOTION_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INTERESTED_COUNT"))
			{
				strBuf.Add("  SITE_PROMOTION.INTERESTED_COUNT = :INTERESTED_COUNT");
				param = new OracleParameter();
				param.ParameterName = ":INTERESTED_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.INTERESTED_COUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SUMMARY"))
			{
				strBuf.Add("  SITE_PROMOTION.SUMMARY = :SUMMARY");
				param = new OracleParameter();
				param.ParameterName = ":SUMMARY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1024;
				param.Value = string.IsNullOrEmpty(obj.SUMMARY) ? string.Empty : obj.SUMMARY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BROWSE_COUNT"))
			{
				strBuf.Add("  SITE_PROMOTION.BROWSE_COUNT = :BROWSE_COUNT");
				param = new OracleParameter();
				param.ParameterName = ":BROWSE_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.BROWSE_COUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BEGIN_DATE"))
			{
				strBuf.Add("  SITE_PROMOTION.BEGIN_DATE = :BEGIN_DATE");
				param = new OracleParameter();
				param.ParameterName = ":BEGIN_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.BEGIN_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IMAGE_URL"))
			{
				strBuf.Add("  SITE_PROMOTION.IMAGE_URL = :IMAGE_URL");
				param = new OracleParameter();
				param.ParameterName = ":IMAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.IMAGE_URL) ? string.Empty : obj.IMAGE_URL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRAISE_COUNT"))
			{
				strBuf.Add("  SITE_PROMOTION.PRAISE_COUNT = :PRAISE_COUNT");
				param = new OracleParameter();
				param.ParameterName = ":PRAISE_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PRAISE_COUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SUBJECT"))
			{
				strBuf.Add("  SITE_PROMOTION.SUBJECT = :SUBJECT");
				param = new OracleParameter();
				param.ParameterName = ":SUBJECT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SUBJECT) ? string.Empty : obj.SUBJECT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("END_DATE"))
			{
				strBuf.Add("  SITE_PROMOTION.END_DATE = :END_DATE");
				param = new OracleParameter();
				param.ParameterName = ":END_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.END_DATE;
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
