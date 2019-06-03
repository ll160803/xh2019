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
	[CauseObject(typeof(CauseObject_SITE_ORDER))]
	public partial class HelperObject_SITE_ORDER
	{		
		#region Method Blok
		public static int Save(EntityObject_SITE_ORDER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into SITE_ORDER( ID, USER_ID, CREATE_DATE, ORDER_STATE, PAYMENT_STATE, PAYMENT_TYPE, DUE, COMPLETE_DATE, MONEY, SUBMIT_DATE, PAYMENT_CODE, CODE, PURCHASE_TYPE, ACTUAL_PAYMENT) values ( :ID, :USER_ID, :CREATE_DATE, :ORDER_STATE, :PAYMENT_STATE, :PAYMENT_TYPE, :DUE, :COMPLETE_DATE, :MONEY, :SUBMIT_DATE, :PAYMENT_CODE, :CODE, :PURCHASE_TYPE, :ACTUAL_PAYMENT)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[14];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":USER_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":CREATE_DATE";
			parameters[2].Size = 7;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[2].Value = obj.CREATE_DATE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ORDER_STATE";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.ORDER_STATE == null ? String.Empty:obj.ORDER_STATE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":PAYMENT_STATE";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.PAYMENT_STATE == null ? String.Empty:obj.PAYMENT_STATE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":PAYMENT_TYPE";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.PAYMENT_TYPE == null ? String.Empty:obj.PAYMENT_TYPE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":DUE";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.DUE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":COMPLETE_DATE";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.COMPLETE_DATE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":MONEY";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.MONEY;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":SUBMIT_DATE";
			parameters[9].Size = 7;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[9].Value = obj.SUBMIT_DATE;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":PAYMENT_CODE";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.PAYMENT_CODE == null ? String.Empty:obj.PAYMENT_CODE;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":CODE";
			parameters[11].Size = 50;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":PURCHASE_TYPE";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.PURCHASE_TYPE == null ? String.Empty:obj.PURCHASE_TYPE;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":ACTUAL_PAYMENT";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.ACTUAL_PAYMENT;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SITE_ORDER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SITE_ORDER set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SITE_ORDER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SITE_ORDER where  ID = :ID ";
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
		public static EntityObject_SITE_ORDER Get(EntityObject_SITE_ORDER obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, USER_ID, CREATE_DATE, ORDER_STATE, PAYMENT_STATE, PAYMENT_TYPE, DUE, COMPLETE_DATE, MONEY, SUBMIT_DATE, PAYMENT_CODE, CODE, PURCHASE_TYPE, ACTUAL_PAYMENT from SITE_ORDER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SITE_ORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SITE_ORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ORDER_STATE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PAYMENT_STATE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PAYMENT_TYPE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMPLETE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SUBMIT_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAYMENT_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PURCHASE_TYPE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACTUAL_PAYMENT = sqlReader.GetDecimal(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SITE_ORDER[] objs = new EntityObject_SITE_ORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_SITE_ORDER Get(EntityObject_SITE_ORDER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, USER_ID, CREATE_DATE, ORDER_STATE, PAYMENT_STATE, PAYMENT_TYPE, DUE, COMPLETE_DATE, MONEY, SUBMIT_DATE, PAYMENT_CODE, CODE, PURCHASE_TYPE, ACTUAL_PAYMENT from SITE_ORDER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SITE_ORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SITE_ORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ORDER_STATE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PAYMENT_STATE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PAYMENT_TYPE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMPLETE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SUBMIT_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAYMENT_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PURCHASE_TYPE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACTUAL_PAYMENT = sqlReader.GetDecimal(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SITE_ORDER[] objs = new EntityObject_SITE_ORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SITE_ORDER[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SITE_ORDER.ID, SITE_ORDER.USER_ID, SITE_ORDER.CREATE_DATE, SITE_ORDER.ORDER_STATE, SITE_ORDER.PAYMENT_STATE, SITE_ORDER.PAYMENT_TYPE, SITE_ORDER.DUE, SITE_ORDER.COMPLETE_DATE, SITE_ORDER.MONEY, SITE_ORDER.SUBMIT_DATE, SITE_ORDER.PAYMENT_CODE, SITE_ORDER.CODE, SITE_ORDER.PURCHASE_TYPE, SITE_ORDER.ACTUAL_PAYMENT, SITE_USER.NAME as SITE_USER_NAME, COM_TYPE.NAME as COM_TYPE_NAME, COM_TYPE_1.NAME as COM_TYPE_1_NAME, COM_TYPE_1_1.NAME as COM_TYPE_1_1_NAME, COM_TYPE_1_1_1.NAME as COM_TYPE_1_1_1_NAME from SITE_ORDER left join SITE_USER   SITE_USER on SITE_ORDER.USER_ID = SITE_USER.ID left join COM_TYPE   COM_TYPE on SITE_ORDER.ORDER_STATE = COM_TYPE.ID left join COM_TYPE   COM_TYPE_1 on SITE_ORDER.PAYMENT_STATE = COM_TYPE_1.ID left join COM_TYPE   COM_TYPE_1_1 on SITE_ORDER.PAYMENT_TYPE = COM_TYPE_1_1.ID left join COM_TYPE   COM_TYPE_1_1_1 on SITE_ORDER.PURCHASE_TYPE = COM_TYPE_1_1_1.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SITE_ORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_ORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ORDER_STATE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PAYMENT_STATE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PAYMENT_TYPE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMPLETE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SUBMIT_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAYMENT_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PURCHASE_TYPE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACTUAL_PAYMENT = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SITE_USER_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COM_TYPE_NAME_1 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_TYPE_NAME_1_1 = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COM_TYPE_NAME_1_1_1 = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_ORDER[] objs = new DisplayObject_SITE_ORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SITE_ORDER cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ID!= string.Empty)
			{
				strBuf.Append(" And SITE_ORDER.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "ID"));
			}
			if(cause.USER_ID!= string.Empty)
			{
				strBuf.Append(" And SITE_ORDER.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :USER_ID");
				param = new OracleParameter();
				param.ParameterName =":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "USER_ID"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And SITE_ORDER.CREATE_DATE >= :CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And SITE_ORDER.CREATE_DATE < :CREATE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "CREATE_DATE"));
			}
			if(cause.ORDER_STATE!= string.Empty)
			{
				strBuf.Append(" And SITE_ORDER.ORDER_STATE ").Append((cause.ORDER_STATE.StartsWith("%") || cause.ORDER_STATE.EndsWith("%")) ? " like " : " = ").Append(" :ORDER_STATE");
				param = new OracleParameter();
				param.ParameterName =":ORDER_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ORDER_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ORDER_STATE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "ORDER_STATE"));
			}
			if(cause.PAYMENT_STATE!= string.Empty)
			{
				strBuf.Append(" And SITE_ORDER.PAYMENT_STATE ").Append((cause.PAYMENT_STATE.StartsWith("%") || cause.PAYMENT_STATE.EndsWith("%")) ? " like " : " = ").Append(" :PAYMENT_STATE");
				param = new OracleParameter();
				param.ParameterName =":PAYMENT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PAYMENT_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAYMENT_STATE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "PAYMENT_STATE"));
			}
			if(cause.PAYMENT_TYPE!= string.Empty)
			{
				strBuf.Append(" And SITE_ORDER.PAYMENT_TYPE ").Append((cause.PAYMENT_TYPE.StartsWith("%") || cause.PAYMENT_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :PAYMENT_TYPE");
				param = new OracleParameter();
				param.ParameterName =":PAYMENT_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PAYMENT_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAYMENT_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "PAYMENT_TYPE"));
			}
			if(cause.DUE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SITE_ORDER.DUE = :DUE");
				param = new OracleParameter();
				param.ParameterName =":DUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DUE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DUE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "DUE"));
			}
			if(cause.COMPLETE_DATE!= null)
			{
				if (cause.COMPLETE_DATE.Begin != null)
				{
					strBuf.Append(" And SITE_ORDER.COMPLETE_DATE >= :COMPLETE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":COMPLETE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.COMPLETE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.COMPLETE_DATE.End != null)
				{
					strBuf.Append(" And SITE_ORDER.COMPLETE_DATE < :COMPLETE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":COMPLETE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.COMPLETE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("COMPLETE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "COMPLETE_DATE"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SITE_ORDER.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName =":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "MONEY"));
			}
			if(cause.SUBMIT_DATE!= null)
			{
				if (cause.SUBMIT_DATE.Begin != null)
				{
					strBuf.Append(" And SITE_ORDER.SUBMIT_DATE >= :SUBMIT_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":SUBMIT_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.SUBMIT_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.SUBMIT_DATE.End != null)
				{
					strBuf.Append(" And SITE_ORDER.SUBMIT_DATE < :SUBMIT_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":SUBMIT_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.SUBMIT_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("SUBMIT_DATE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "SUBMIT_DATE"));
			}
			if(cause.PAYMENT_CODE!= string.Empty)
			{
				strBuf.Append(" And SITE_ORDER.PAYMENT_CODE ").Append((cause.PAYMENT_CODE.StartsWith("%") || cause.PAYMENT_CODE.EndsWith("%")) ? " like " : " = ").Append(" :PAYMENT_CODE");
				param = new OracleParameter();
				param.ParameterName =":PAYMENT_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PAYMENT_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAYMENT_CODE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "PAYMENT_CODE"));
			}
			if(cause.CODE!= string.Empty)
			{
				strBuf.Append(" And SITE_ORDER.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "CODE"));
			}
			if(cause.PURCHASE_TYPE!= string.Empty)
			{
				strBuf.Append(" And SITE_ORDER.PURCHASE_TYPE ").Append((cause.PURCHASE_TYPE.StartsWith("%") || cause.PURCHASE_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :PURCHASE_TYPE");
				param = new OracleParameter();
				param.ParameterName =":PURCHASE_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PURCHASE_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PURCHASE_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "PURCHASE_TYPE"));
			}
			if(cause.ACTUAL_PAYMENT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SITE_ORDER.ACTUAL_PAYMENT = :ACTUAL_PAYMENT");
				param = new OracleParameter();
				param.ParameterName =":ACTUAL_PAYMENT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ACTUAL_PAYMENT;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACTUAL_PAYMENT"))
			{
				strBuf.Append(cause.GetINSQL("SITE_ORDER", "ACTUAL_PAYMENT"));
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
		public static DisplayObject_SITE_ORDER[] Query(CauseObject_SITE_ORDER cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SITE_ORDER.ID, SITE_ORDER.USER_ID, SITE_ORDER.CREATE_DATE, SITE_ORDER.ORDER_STATE, SITE_ORDER.PAYMENT_STATE, SITE_ORDER.PAYMENT_TYPE, SITE_ORDER.DUE, SITE_ORDER.COMPLETE_DATE, SITE_ORDER.MONEY, SITE_ORDER.SUBMIT_DATE, SITE_ORDER.PAYMENT_CODE, SITE_ORDER.CODE, SITE_ORDER.PURCHASE_TYPE, SITE_ORDER.ACTUAL_PAYMENT, SITE_USER.NAME as SITE_USER_NAME, COM_TYPE.NAME as COM_TYPE_NAME, COM_TYPE_1.NAME as COM_TYPE_1_NAME, COM_TYPE_1_1.NAME as COM_TYPE_1_1_NAME, COM_TYPE_1_1_1.NAME as COM_TYPE_1_1_1_NAME from SITE_ORDER left join SITE_USER   SITE_USER on SITE_ORDER.USER_ID = SITE_USER.ID left join COM_TYPE   COM_TYPE on SITE_ORDER.ORDER_STATE = COM_TYPE.ID left join COM_TYPE   COM_TYPE_1 on SITE_ORDER.PAYMENT_STATE = COM_TYPE_1.ID left join COM_TYPE   COM_TYPE_1_1 on SITE_ORDER.PAYMENT_TYPE = COM_TYPE_1_1.ID left join COM_TYPE   COM_TYPE_1_1_1 on SITE_ORDER.PURCHASE_TYPE = COM_TYPE_1_1_1.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SITE_ORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_ORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ORDER_STATE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PAYMENT_STATE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PAYMENT_TYPE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMPLETE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SUBMIT_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAYMENT_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PURCHASE_TYPE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACTUAL_PAYMENT = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SITE_USER_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COM_TYPE_NAME_1 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_TYPE_NAME_1_1 = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COM_TYPE_NAME_1_1_1 = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_ORDER[] objs = new DisplayObject_SITE_ORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_SITE_ORDER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SITE_ORDER where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_SITE_ORDER[] Query(CauseObject_SITE_ORDER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SITE_ORDER.ID, SITE_ORDER.USER_ID, SITE_ORDER.CREATE_DATE, SITE_ORDER.ORDER_STATE, SITE_ORDER.PAYMENT_STATE, SITE_ORDER.PAYMENT_TYPE, SITE_ORDER.DUE, SITE_ORDER.COMPLETE_DATE, SITE_ORDER.MONEY, SITE_ORDER.SUBMIT_DATE, SITE_ORDER.PAYMENT_CODE, SITE_ORDER.CODE, SITE_ORDER.PURCHASE_TYPE, SITE_ORDER.ACTUAL_PAYMENT, SITE_USER.NAME as SITE_USER_NAME, COM_TYPE.NAME as COM_TYPE_NAME, COM_TYPE_1.NAME as COM_TYPE_1_NAME, COM_TYPE_1_1.NAME as COM_TYPE_1_1_NAME, COM_TYPE_1_1_1.NAME as COM_TYPE_1_1_1_NAME from SITE_ORDER left join SITE_USER   SITE_USER on SITE_ORDER.USER_ID = SITE_USER.ID left join COM_TYPE   COM_TYPE on SITE_ORDER.ORDER_STATE = COM_TYPE.ID left join COM_TYPE   COM_TYPE_1 on SITE_ORDER.PAYMENT_STATE = COM_TYPE_1.ID left join COM_TYPE   COM_TYPE_1_1 on SITE_ORDER.PAYMENT_TYPE = COM_TYPE_1_1.ID left join COM_TYPE   COM_TYPE_1_1_1 on SITE_ORDER.PURCHASE_TYPE = COM_TYPE_1_1_1.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SITE_ORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_ORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ORDER_STATE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PAYMENT_STATE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PAYMENT_TYPE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMPLETE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SUBMIT_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAYMENT_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PURCHASE_TYPE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACTUAL_PAYMENT = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SITE_USER_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COM_TYPE_NAME_1 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_TYPE_NAME_1_1 = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COM_TYPE_NAME_1_1_1 = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SITE_ORDER[] objs = new DisplayObject_SITE_ORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SITE_ORDER[] Query(CauseObject_SITE_ORDER cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SITE_ORDER.ID, SITE_ORDER.USER_ID, SITE_ORDER.CREATE_DATE, SITE_ORDER.ORDER_STATE, SITE_ORDER.PAYMENT_STATE, SITE_ORDER.PAYMENT_TYPE, SITE_ORDER.DUE, SITE_ORDER.COMPLETE_DATE, SITE_ORDER.MONEY, SITE_ORDER.SUBMIT_DATE, SITE_ORDER.PAYMENT_CODE, SITE_ORDER.CODE, SITE_ORDER.PURCHASE_TYPE, SITE_ORDER.ACTUAL_PAYMENT, SITE_USER.NAME as SITE_USER_NAME, COM_TYPE.NAME as COM_TYPE_NAME, COM_TYPE_1.NAME as COM_TYPE_1_NAME, COM_TYPE_1_1.NAME as COM_TYPE_1_1_NAME, COM_TYPE_1_1_1.NAME as COM_TYPE_1_1_1_NAME from SITE_ORDER left join SITE_USER   SITE_USER on SITE_ORDER.USER_ID = SITE_USER.ID left join COM_TYPE   COM_TYPE on SITE_ORDER.ORDER_STATE = COM_TYPE.ID left join COM_TYPE   COM_TYPE_1 on SITE_ORDER.PAYMENT_STATE = COM_TYPE_1.ID left join COM_TYPE   COM_TYPE_1_1 on SITE_ORDER.PAYMENT_TYPE = COM_TYPE_1_1.ID left join COM_TYPE   COM_TYPE_1_1_1 on SITE_ORDER.PURCHASE_TYPE = COM_TYPE_1_1_1.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SITE_ORDER",paging, order, sSql, parameters, connection);
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
			DisplayObject_SITE_ORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_ORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ORDER_STATE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PAYMENT_STATE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PAYMENT_TYPE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMPLETE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SUBMIT_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAYMENT_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PURCHASE_TYPE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACTUAL_PAYMENT = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SITE_USER_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COM_TYPE_NAME_1 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_TYPE_NAME_1_1 = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COM_TYPE_NAME_1_1_1 = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SITE_ORDER[] objs = new DisplayObject_SITE_ORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SITE_ORDER[] Query(CauseObject_SITE_ORDER cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SITE_ORDER.ID, SITE_ORDER.USER_ID, SITE_ORDER.CREATE_DATE, SITE_ORDER.ORDER_STATE, SITE_ORDER.PAYMENT_STATE, SITE_ORDER.PAYMENT_TYPE, SITE_ORDER.DUE, SITE_ORDER.COMPLETE_DATE, SITE_ORDER.MONEY, SITE_ORDER.SUBMIT_DATE, SITE_ORDER.PAYMENT_CODE, SITE_ORDER.CODE, SITE_ORDER.PURCHASE_TYPE, SITE_ORDER.ACTUAL_PAYMENT, SITE_USER.NAME as SITE_USER_NAME, COM_TYPE.NAME as COM_TYPE_NAME, COM_TYPE_1.NAME as COM_TYPE_1_NAME, COM_TYPE_1_1.NAME as COM_TYPE_1_1_NAME, COM_TYPE_1_1_1.NAME as COM_TYPE_1_1_1_NAME from SITE_ORDER left join SITE_USER   SITE_USER on SITE_ORDER.USER_ID = SITE_USER.ID left join COM_TYPE   COM_TYPE on SITE_ORDER.ORDER_STATE = COM_TYPE.ID left join COM_TYPE   COM_TYPE_1 on SITE_ORDER.PAYMENT_STATE = COM_TYPE_1.ID left join COM_TYPE   COM_TYPE_1_1 on SITE_ORDER.PAYMENT_TYPE = COM_TYPE_1_1.ID left join COM_TYPE   COM_TYPE_1_1_1 on SITE_ORDER.PURCHASE_TYPE = COM_TYPE_1_1_1.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SITE_ORDER",paging, order, sSql, parameters, trans);
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
			DisplayObject_SITE_ORDER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SITE_ORDER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.USER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ORDER_STATE = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.PAYMENT_STATE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.PAYMENT_TYPE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.DUE = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.COMPLETE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MONEY = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SUBMIT_DATE = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PAYMENT_CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PURCHASE_TYPE = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACTUAL_PAYMENT = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SITE_USER_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.COM_TYPE_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.COM_TYPE_NAME_1 = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.COM_TYPE_NAME_1_1 = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COM_TYPE_NAME_1_1_1 = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SITE_ORDER[] objs = new DisplayObject_SITE_ORDER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SITE_ORDER obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  SITE_ORDER.USER_ID = :USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  SITE_ORDER.CREATE_DATE = :CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ORDER_STATE"))
			{
				strBuf.Add("  SITE_ORDER.ORDER_STATE = :ORDER_STATE");
				param = new OracleParameter();
				param.ParameterName = ":ORDER_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ORDER_STATE) ? string.Empty : obj.ORDER_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAYMENT_STATE"))
			{
				strBuf.Add("  SITE_ORDER.PAYMENT_STATE = :PAYMENT_STATE");
				param = new OracleParameter();
				param.ParameterName = ":PAYMENT_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PAYMENT_STATE) ? string.Empty : obj.PAYMENT_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAYMENT_TYPE"))
			{
				strBuf.Add("  SITE_ORDER.PAYMENT_TYPE = :PAYMENT_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":PAYMENT_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PAYMENT_TYPE) ? string.Empty : obj.PAYMENT_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DUE"))
			{
				strBuf.Add("  SITE_ORDER.DUE = :DUE");
				param = new OracleParameter();
				param.ParameterName = ":DUE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DUE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMPLETE_DATE"))
			{
				strBuf.Add("  SITE_ORDER.COMPLETE_DATE = :COMPLETE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":COMPLETE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.COMPLETE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  SITE_ORDER.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName = ":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SUBMIT_DATE"))
			{
				strBuf.Add("  SITE_ORDER.SUBMIT_DATE = :SUBMIT_DATE");
				param = new OracleParameter();
				param.ParameterName = ":SUBMIT_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.SUBMIT_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAYMENT_CODE"))
			{
				strBuf.Add("  SITE_ORDER.PAYMENT_CODE = :PAYMENT_CODE");
				param = new OracleParameter();
				param.ParameterName = ":PAYMENT_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PAYMENT_CODE) ? string.Empty : obj.PAYMENT_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  SITE_ORDER.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PURCHASE_TYPE"))
			{
				strBuf.Add("  SITE_ORDER.PURCHASE_TYPE = :PURCHASE_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":PURCHASE_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PURCHASE_TYPE) ? string.Empty : obj.PURCHASE_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ACTUAL_PAYMENT"))
			{
				strBuf.Add("  SITE_ORDER.ACTUAL_PAYMENT = :ACTUAL_PAYMENT");
				param = new OracleParameter();
				param.ParameterName = ":ACTUAL_PAYMENT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ACTUAL_PAYMENT;
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
