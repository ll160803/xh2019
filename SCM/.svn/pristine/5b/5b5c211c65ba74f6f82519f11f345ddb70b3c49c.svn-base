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
	[CauseObject(typeof(CauseObject_SITE_GOODS))]
	public partial class HelperObject_SITE_GOODS
	{		
		#region Method Blok
		public static int Save(EntityObject_SITE_GOODS obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into SITE_GOODS( ID, NAME, SUMMARY, BROWSE_COUNT, PURCHASE_COUNT, GOODS_STATE, CODE, PRICE, IMAGE_URL, PRAISE_COUNT, PUBLISH_DATE) values ( :ID, :NAME, :SUMMARY, :BROWSE_COUNT, :PURCHASE_COUNT, :GOODS_STATE, :CODE, :PRICE, :IMAGE_URL, :PRAISE_COUNT, :PUBLISH_DATE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[11];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":NAME";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":SUMMARY";
			parameters[2].Size = 1024;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.SUMMARY == null ? String.Empty:obj.SUMMARY;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":BROWSE_COUNT";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.BROWSE_COUNT;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":PURCHASE_COUNT";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.PURCHASE_COUNT;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":GOODS_STATE";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.GOODS_STATE == null ? String.Empty:obj.GOODS_STATE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":CODE";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":PRICE";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.PRICE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":IMAGE_URL";
			parameters[8].Size = 200;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.IMAGE_URL == null ? String.Empty:obj.IMAGE_URL;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":PRAISE_COUNT";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.PRAISE_COUNT;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":PUBLISH_DATE";
			parameters[10].Size = 7;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[10].Value = obj.PUBLISH_DATE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SITE_GOODS obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SITE_GOODS set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SITE_GOODS obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SITE_GOODS where  ID = :ID ";
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
		public static EntityObject_SITE_GOODS Get(EntityObject_SITE_GOODS obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, NAME, SUMMARY, BROWSE_COUNT, PURCHASE_COUNT, GOODS_STATE, CODE, PRICE, IMAGE_URL, PRAISE_COUNT, PUBLISH_DATE from SITE_GOODS where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SITE_GOODS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SITE_GOODS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMMARY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PURCHASE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GOODS_STATE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IMAGE_URL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SITE_GOODS[] objs = new EntityObject_SITE_GOODS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_SITE_GOODS Get(EntityObject_SITE_GOODS obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, NAME, SUMMARY, BROWSE_COUNT, PURCHASE_COUNT, GOODS_STATE, CODE, PRICE, IMAGE_URL, PRAISE_COUNT, PUBLISH_DATE from SITE_GOODS where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SITE_GOODS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SITE_GOODS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMMARY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PURCHASE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GOODS_STATE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IMAGE_URL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(10);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SITE_GOODS[] objs = new EntityObject_SITE_GOODS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SITE_GOODS[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SITE_GOODS.ID, SITE_GOODS.NAME, SITE_GOODS.SUMMARY, SITE_GOODS.BROWSE_COUNT, SITE_GOODS.PURCHASE_COUNT, SITE_GOODS.GOODS_STATE, SITE_GOODS.CODE, SITE_GOODS.PRICE, SITE_GOODS.IMAGE_URL, SITE_GOODS.PRAISE_COUNT, SITE_GOODS.PUBLISH_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_GOODS left join COM_TYPE   COM_TYPE on SITE_GOODS.GOODS_STATE = COM_TYPE.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SITE_GOODS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_GOODS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMMARY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PURCHASE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GOODS_STATE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IMAGE_URL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_GOODS[] objs = new DisplayObject_SITE_GOODS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SITE_GOODS cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And SITE_GOODS.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS", "ID"));
			}
			if(cause.NAME!= string.Empty)
			{
				strBuf.Append(" And SITE_GOODS.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS", "NAME"));
			}
			if(cause.SUMMARY!= string.Empty)
			{
				strBuf.Append(" And SITE_GOODS.SUMMARY ").Append((cause.SUMMARY.StartsWith("%") || cause.SUMMARY.EndsWith("%")) ? " like " : " = ").Append(" :SUMMARY");
				param = new OracleParameter();
				param.ParameterName =":SUMMARY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1024;
				param.Value = cause.SUMMARY;
				paramList.Add(param);
			}
			if (cause.HasINValue("SUMMARY"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS", "SUMMARY"));
			}
			if(cause.BROWSE_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SITE_GOODS.BROWSE_COUNT = :BROWSE_COUNT");
				param = new OracleParameter();
				param.ParameterName =":BROWSE_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.BROWSE_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("BROWSE_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS", "BROWSE_COUNT"));
			}
			if(cause.PURCHASE_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SITE_GOODS.PURCHASE_COUNT = :PURCHASE_COUNT");
				param = new OracleParameter();
				param.ParameterName =":PURCHASE_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PURCHASE_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("PURCHASE_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS", "PURCHASE_COUNT"));
			}
			if(cause.GOODS_STATE!= string.Empty)
			{
				strBuf.Append(" And SITE_GOODS.GOODS_STATE ").Append((cause.GOODS_STATE.StartsWith("%") || cause.GOODS_STATE.EndsWith("%")) ? " like " : " = ").Append(" :GOODS_STATE");
				param = new OracleParameter();
				param.ParameterName =":GOODS_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.GOODS_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("GOODS_STATE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS", "GOODS_STATE"));
			}
			if(cause.CODE!= string.Empty)
			{
				strBuf.Append(" And SITE_GOODS.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS", "CODE"));
			}
			if(cause.PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SITE_GOODS.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName =":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRICE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS", "PRICE"));
			}
			if(cause.IMAGE_URL!= string.Empty)
			{
				strBuf.Append(" And SITE_GOODS.IMAGE_URL ").Append((cause.IMAGE_URL.StartsWith("%") || cause.IMAGE_URL.EndsWith("%")) ? " like " : " = ").Append(" :IMAGE_URL");
				param = new OracleParameter();
				param.ParameterName =":IMAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.IMAGE_URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("IMAGE_URL"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS", "IMAGE_URL"));
			}
			if(cause.PRAISE_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SITE_GOODS.PRAISE_COUNT = :PRAISE_COUNT");
				param = new OracleParameter();
				param.ParameterName =":PRAISE_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PRAISE_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRAISE_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS", "PRAISE_COUNT"));
			}
			if(cause.PUBLISH_DATE!= null)
			{
				if (cause.PUBLISH_DATE.Begin != null)
				{
					strBuf.Append(" And SITE_GOODS.PUBLISH_DATE >= :PUBLISH_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":PUBLISH_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PUBLISH_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PUBLISH_DATE.End != null)
				{
					strBuf.Append(" And SITE_GOODS.PUBLISH_DATE < :PUBLISH_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":PUBLISH_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PUBLISH_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("PUBLISH_DATE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_GOODS", "PUBLISH_DATE"));
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
		public static DisplayObject_SITE_GOODS[] Query(CauseObject_SITE_GOODS cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SITE_GOODS.ID, SITE_GOODS.NAME, SITE_GOODS.SUMMARY, SITE_GOODS.BROWSE_COUNT, SITE_GOODS.PURCHASE_COUNT, SITE_GOODS.GOODS_STATE, SITE_GOODS.CODE, SITE_GOODS.PRICE, SITE_GOODS.IMAGE_URL, SITE_GOODS.PRAISE_COUNT, SITE_GOODS.PUBLISH_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_GOODS left join COM_TYPE   COM_TYPE on SITE_GOODS.GOODS_STATE = COM_TYPE.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SITE_GOODS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_GOODS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMMARY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PURCHASE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GOODS_STATE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IMAGE_URL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_GOODS[] objs = new DisplayObject_SITE_GOODS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_SITE_GOODS cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SITE_GOODS where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_SITE_GOODS[] Query(CauseObject_SITE_GOODS cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SITE_GOODS.ID, SITE_GOODS.NAME, SITE_GOODS.SUMMARY, SITE_GOODS.BROWSE_COUNT, SITE_GOODS.PURCHASE_COUNT, SITE_GOODS.GOODS_STATE, SITE_GOODS.CODE, SITE_GOODS.PRICE, SITE_GOODS.IMAGE_URL, SITE_GOODS.PRAISE_COUNT, SITE_GOODS.PUBLISH_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_GOODS left join COM_TYPE   COM_TYPE on SITE_GOODS.GOODS_STATE = COM_TYPE.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SITE_GOODS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_GOODS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMMARY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PURCHASE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GOODS_STATE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IMAGE_URL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SITE_GOODS[] objs = new DisplayObject_SITE_GOODS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SITE_GOODS[] Query(CauseObject_SITE_GOODS cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SITE_GOODS.ID, SITE_GOODS.NAME, SITE_GOODS.SUMMARY, SITE_GOODS.BROWSE_COUNT, SITE_GOODS.PURCHASE_COUNT, SITE_GOODS.GOODS_STATE, SITE_GOODS.CODE, SITE_GOODS.PRICE, SITE_GOODS.IMAGE_URL, SITE_GOODS.PRAISE_COUNT, SITE_GOODS.PUBLISH_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_GOODS left join COM_TYPE   COM_TYPE on SITE_GOODS.GOODS_STATE = COM_TYPE.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SITE_GOODS",paging, order, sSql, parameters, connection);
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
			DisplayObject_SITE_GOODS dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_GOODS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMMARY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PURCHASE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GOODS_STATE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IMAGE_URL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_GOODS[] objs = new DisplayObject_SITE_GOODS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SITE_GOODS[] Query(CauseObject_SITE_GOODS cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SITE_GOODS.ID, SITE_GOODS.NAME, SITE_GOODS.SUMMARY, SITE_GOODS.BROWSE_COUNT, SITE_GOODS.PURCHASE_COUNT, SITE_GOODS.GOODS_STATE, SITE_GOODS.CODE, SITE_GOODS.PRICE, SITE_GOODS.IMAGE_URL, SITE_GOODS.PRAISE_COUNT, SITE_GOODS.PUBLISH_DATE, COM_TYPE.NAME as COM_TYPE_NAME from SITE_GOODS left join COM_TYPE   COM_TYPE on SITE_GOODS.GOODS_STATE = COM_TYPE.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SITE_GOODS",paging, order, sSql, parameters, trans);
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
			DisplayObject_SITE_GOODS dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_GOODS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SUMMARY = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BROWSE_COUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PURCHASE_COUNT = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.GOODS_STATE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PRICE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IMAGE_URL = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.PRAISE_COUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SITE_GOODS[] objs = new DisplayObject_SITE_GOODS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SITE_GOODS obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  SITE_GOODS.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SUMMARY"))
			{
				strBuf.Add("  SITE_GOODS.SUMMARY = :SUMMARY");
				param = new OracleParameter();
				param.ParameterName = ":SUMMARY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1024;
				param.Value = string.IsNullOrEmpty(obj.SUMMARY) ? string.Empty : obj.SUMMARY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BROWSE_COUNT"))
			{
				strBuf.Add("  SITE_GOODS.BROWSE_COUNT = :BROWSE_COUNT");
				param = new OracleParameter();
				param.ParameterName = ":BROWSE_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.BROWSE_COUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURCHASE_COUNT"))
			{
				strBuf.Add("  SITE_GOODS.PURCHASE_COUNT = :PURCHASE_COUNT");
				param = new OracleParameter();
				param.ParameterName = ":PURCHASE_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PURCHASE_COUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GOODS_STATE"))
			{
				strBuf.Add("  SITE_GOODS.GOODS_STATE = :GOODS_STATE");
				param = new OracleParameter();
				param.ParameterName = ":GOODS_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.GOODS_STATE) ? string.Empty : obj.GOODS_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  SITE_GOODS.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRICE"))
			{
				strBuf.Add("  SITE_GOODS.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName = ":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IMAGE_URL"))
			{
				strBuf.Add("  SITE_GOODS.IMAGE_URL = :IMAGE_URL");
				param = new OracleParameter();
				param.ParameterName = ":IMAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.IMAGE_URL) ? string.Empty : obj.IMAGE_URL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRAISE_COUNT"))
			{
				strBuf.Add("  SITE_GOODS.PRAISE_COUNT = :PRAISE_COUNT");
				param = new OracleParameter();
				param.ParameterName = ":PRAISE_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PRAISE_COUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PUBLISH_DATE"))
			{
				strBuf.Add("  SITE_GOODS.PUBLISH_DATE = :PUBLISH_DATE");
				param = new OracleParameter();
				param.ParameterName = ":PUBLISH_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PUBLISH_DATE;
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
