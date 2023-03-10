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
	[CauseObject(typeof(CauseObject_SCM_B_SENDINFO))]
	public partial class HelperObject_SCM_B_SENDINFO
	{		
		#region Method Blok
		
		public static int Update(EntityObject_SCM_B_SENDINFO obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_B_SENDINFO set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SCM_B_SENDINFO obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SCM_B_SENDINFO where  ID = :ID ";
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
		public static EntityObject_SCM_B_SENDINFO Get(EntityObject_SCM_B_SENDINFO obj)
		{
			
			//平台自动生成代码
			string sSql = "select  MODIFY_DEPART_ID, NAME, ID, AMOUNT, DATA_ORGANISE_ID, LINK_PERSON, CODE, MODIFY_TIME, CREATE_TIME, MODIFY_USER_ID, PRICE, MATER_CODE, SEND_DEPART, STATE, MONEY, TXZ01, LINK_TELEPHONE, CREATE_USER_ID, COMMENTS, GYSNAME, CREATE_DEPART_ID, MSEHT, GYSACCOUNT, MEINS, MATNR from SCM_B_SENDINFO where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_SENDINFO dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_SENDINFO();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRICE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SEND_DEPART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.TXZ01 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.GYSNAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MEINS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SCM_B_SENDINFO[] objs = new EntityObject_SCM_B_SENDINFO[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_SCM_B_SENDINFO Get(EntityObject_SCM_B_SENDINFO obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  MODIFY_DEPART_ID, NAME, ID, AMOUNT, DATA_ORGANISE_ID, LINK_PERSON, CODE, MODIFY_TIME, CREATE_TIME, MODIFY_USER_ID, PRICE, MATER_CODE, SEND_DEPART, STATE, MONEY, TXZ01, LINK_TELEPHONE, CREATE_USER_ID, COMMENTS, GYSNAME, CREATE_DEPART_ID, MSEHT, GYSACCOUNT, MEINS, MATNR from SCM_B_SENDINFO where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_SENDINFO dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_SENDINFO();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRICE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SEND_DEPART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.TXZ01 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.GYSNAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MEINS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SCM_B_SENDINFO[] objs = new EntityObject_SCM_B_SENDINFO[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_B_SENDINFO[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SCM_B_SENDINFO.MODIFY_DEPART_ID, SCM_B_SENDINFO.NAME, SCM_B_SENDINFO.ID, SCM_B_SENDINFO.AMOUNT, SCM_B_SENDINFO.DATA_ORGANISE_ID, SCM_B_SENDINFO.LINK_PERSON, SCM_B_SENDINFO.CODE, SCM_B_SENDINFO.MODIFY_TIME, SCM_B_SENDINFO.CREATE_TIME, SCM_B_SENDINFO.MODIFY_USER_ID, SCM_B_SENDINFO.PRICE, SCM_B_SENDINFO.MATER_CODE, SCM_B_SENDINFO.SEND_DEPART, SCM_B_SENDINFO.STATE, SCM_B_SENDINFO.MONEY, SCM_B_SENDINFO.TXZ01, SCM_B_SENDINFO.LINK_TELEPHONE, SCM_B_SENDINFO.CREATE_USER_ID, SCM_B_SENDINFO.COMMENTS, SCM_B_SENDINFO.GYSNAME, SCM_B_SENDINFO.CREATE_DEPART_ID, SCM_B_SENDINFO.MSEHT, SCM_B_SENDINFO.GYSACCOUNT, SCM_B_SENDINFO.MEINS, SCM_B_SENDINFO.MATNR, SCM_D_SENDDEPART_SEND_DEPART.NAME as SEND_DEPART_NAME from SCM_B_SENDINFO left join SCM_D_SENDDEPART   SCM_D_SENDDEPART_SEND_DEPART on SCM_B_SENDINFO.SEND_DEPART = SCM_D_SENDDEPART_SEND_DEPART.CODE where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SCM_B_SENDINFO dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_SENDINFO();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRICE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SEND_DEPART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.TXZ01 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.GYSNAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MEINS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(25);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_SENDINFO[] objs = new DisplayObject_SCM_B_SENDINFO[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SCM_B_SENDINFO cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And SCM_B_SENDINFO.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "MODIFY_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And SCM_B_SENDINFO.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
				param = new OracleParameter();
				param.ParameterName =":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And SCM_B_SENDINFO.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "ID"));
			}
			if(cause.AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_SENDINFO.AMOUNT = :AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And SCM_B_SENDINFO.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.LINK_PERSON))
			{
				strBuf.Append(" And SCM_B_SENDINFO.LINK_PERSON ").Append((cause.LINK_PERSON.StartsWith("%") || cause.LINK_PERSON.EndsWith("%")) ? " like " : " = ").Append(" :LINK_PERSON");
				param = new OracleParameter();
				param.ParameterName =":LINK_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.LINK_PERSON;
				paramList.Add(param);
			}
			if (cause.HasINValue("LINK_PERSON"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "LINK_PERSON"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And SCM_B_SENDINFO.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
				param = new OracleParameter();
				param.ParameterName =":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "CODE"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_B_SENDINFO.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And SCM_B_SENDINFO.MODIFY_TIME < :MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "MODIFY_TIME"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_B_SENDINFO.CREATE_TIME >= :CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And SCM_B_SENDINFO.CREATE_TIME < :CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And SCM_B_SENDINFO.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "MODIFY_USER_ID"));
			}
			if(cause.PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_SENDINFO.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName =":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRICE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "PRICE"));
			}
			if(!string.IsNullOrEmpty(cause.MATER_CODE))
			{
				strBuf.Append(" And SCM_B_SENDINFO.MATER_CODE ").Append((cause.MATER_CODE.StartsWith("%") || cause.MATER_CODE.EndsWith("%")) ? " like " : " = ").Append(" :MATER_CODE");
				param = new OracleParameter();
				param.ParameterName =":MATER_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.MATER_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATER_CODE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "MATER_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_DEPART))
			{
				strBuf.Append(" And SCM_B_SENDINFO.SEND_DEPART ").Append((cause.SEND_DEPART.StartsWith("%") || cause.SEND_DEPART.EndsWith("%")) ? " like " : " = ").Append(" :SEND_DEPART");
				param = new OracleParameter();
				param.ParameterName =":SEND_DEPART";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SEND_DEPART;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_DEPART"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "SEND_DEPART"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_SENDINFO.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "STATE"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_SENDINFO.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName =":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.TXZ01))
			{
				strBuf.Append(" And SCM_B_SENDINFO.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :TXZ01");
				param = new OracleParameter();
				param.ParameterName =":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.TXZ01;
				paramList.Add(param);
			}
			if (cause.HasINValue("TXZ01"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "TXZ01"));
			}
			if(!string.IsNullOrEmpty(cause.LINK_TELEPHONE))
			{
				strBuf.Append(" And SCM_B_SENDINFO.LINK_TELEPHONE ").Append((cause.LINK_TELEPHONE.StartsWith("%") || cause.LINK_TELEPHONE.EndsWith("%")) ? " like " : " = ").Append(" :LINK_TELEPHONE");
				param = new OracleParameter();
				param.ParameterName =":LINK_TELEPHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.LINK_TELEPHONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("LINK_TELEPHONE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "LINK_TELEPHONE"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And SCM_B_SENDINFO.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And SCM_B_SENDINFO.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.GYSNAME))
			{
				strBuf.Append(" And SCM_B_SENDINFO.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :GYSNAME");
				param = new OracleParameter();
				param.ParameterName =":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.GYSNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSNAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "GYSNAME"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And SCM_B_SENDINFO.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "CREATE_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MSEHT))
			{
				strBuf.Append(" And SCM_B_SENDINFO.MSEHT ").Append((cause.MSEHT.StartsWith("%") || cause.MSEHT.EndsWith("%")) ? " like " : " = ").Append(" :MSEHT");
				param = new OracleParameter();
				param.ParameterName =":MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.MSEHT;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSEHT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "MSEHT"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And SCM_B_SENDINFO.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.MEINS))
			{
				strBuf.Append(" And SCM_B_SENDINFO.MEINS ").Append((cause.MEINS.StartsWith("%") || cause.MEINS.EndsWith("%")) ? " like " : " = ").Append(" :MEINS");
				param = new OracleParameter();
				param.ParameterName =":MEINS";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 3;
				param.Value = cause.MEINS;
				paramList.Add(param);
			}
			if (cause.HasINValue("MEINS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "MEINS"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR))
			{
				strBuf.Append(" And SCM_B_SENDINFO.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :MATNR");
				param = new OracleParameter();
				param.ParameterName =":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.MATNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_SENDINFO", "MATNR"));
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
		public static DisplayObject_SCM_B_SENDINFO[] Query(CauseObject_SCM_B_SENDINFO cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
            string sSql = " select  SCM_B_SENDINFO.MODIFY_DEPART_ID, SCM_B_SENDINFO.NAME, SCM_B_SENDINFO.ID, SCM_B_SENDINFO.AMOUNT, SCM_B_SENDINFO.DATA_ORGANISE_ID, SCM_B_SENDINFO.LINK_PERSON, SCM_B_SENDINFO.CODE, SCM_B_SENDINFO.MODIFY_TIME, SCM_B_SENDINFO.CREATE_TIME, SCM_B_SENDINFO.MODIFY_USER_ID, SCM_B_SENDINFO.PRICE, SCM_B_SENDINFO.MATER_CODE, SCM_B_SENDINFO.SEND_DEPART, SCM_B_SENDINFO.STATE, SCM_B_SENDINFO.MONEY, SCM_B_SENDINFO.TXZ01, SCM_B_SENDINFO.LINK_TELEPHONE, SCM_B_SENDINFO.CREATE_USER_ID, SCM_B_SENDINFO.COMMENTS, SCM_B_SENDINFO.GYSNAME, SCM_B_SENDINFO.CREATE_DEPART_ID, SCM_B_SENDINFO.MSEHT, SCM_B_SENDINFO.GYSACCOUNT, SCM_B_SENDINFO.MEINS, SCM_B_SENDINFO.MATNR, SCM_D_SENDDEPART_SEND_DEPART.NAME as SEND_DEPART_NAME, SCM_B_SENDINFO.WERKS as WERKS from SCM_B_SENDINFO left join SCM_D_SENDDEPART   SCM_D_SENDDEPART_SEND_DEPART on SCM_B_SENDINFO.SEND_DEPART = SCM_D_SENDDEPART_SEND_DEPART.CODE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_SENDINFO dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_SENDINFO();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRICE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SEND_DEPART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.TXZ01 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.GYSNAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MEINS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.WERKS = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_SENDINFO[] objs = new DisplayObject_SCM_B_SENDINFO[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_SCM_B_SENDINFO cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SCM_B_SENDINFO where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_SCM_B_SENDINFO[] Query(CauseObject_SCM_B_SENDINFO cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_B_SENDINFO.MODIFY_DEPART_ID, SCM_B_SENDINFO.NAME, SCM_B_SENDINFO.ID, SCM_B_SENDINFO.AMOUNT, SCM_B_SENDINFO.DATA_ORGANISE_ID, SCM_B_SENDINFO.LINK_PERSON, SCM_B_SENDINFO.CODE, SCM_B_SENDINFO.MODIFY_TIME, SCM_B_SENDINFO.CREATE_TIME, SCM_B_SENDINFO.MODIFY_USER_ID, SCM_B_SENDINFO.PRICE, SCM_B_SENDINFO.MATER_CODE, SCM_B_SENDINFO.SEND_DEPART, SCM_B_SENDINFO.STATE, SCM_B_SENDINFO.MONEY, SCM_B_SENDINFO.TXZ01, SCM_B_SENDINFO.LINK_TELEPHONE, SCM_B_SENDINFO.CREATE_USER_ID, SCM_B_SENDINFO.COMMENTS, SCM_B_SENDINFO.GYSNAME, SCM_B_SENDINFO.CREATE_DEPART_ID, SCM_B_SENDINFO.MSEHT, SCM_B_SENDINFO.GYSACCOUNT, SCM_B_SENDINFO.MEINS, SCM_B_SENDINFO.MATNR, SCM_D_SENDDEPART_SEND_DEPART.NAME as SEND_DEPART_NAME from SCM_B_SENDINFO left join SCM_D_SENDDEPART   SCM_D_SENDDEPART_SEND_DEPART on SCM_B_SENDINFO.SEND_DEPART = SCM_D_SENDDEPART_SEND_DEPART.CODE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_SENDINFO dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_SENDINFO();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRICE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SEND_DEPART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.TXZ01 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.GYSNAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MEINS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(25);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_SENDINFO[] objs = new DisplayObject_SCM_B_SENDINFO[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_SENDINFO[] Query(CauseObject_SCM_B_SENDINFO cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
            string sSql = " select  SCM_B_SENDINFO.MODIFY_DEPART_ID, SCM_B_SENDINFO.NAME, SCM_B_SENDINFO.ID, SCM_B_SENDINFO.AMOUNT, SCM_B_SENDINFO.DATA_ORGANISE_ID, SCM_B_SENDINFO.LINK_PERSON, SCM_B_SENDINFO.CODE, SCM_B_SENDINFO.MODIFY_TIME, SCM_B_SENDINFO.CREATE_TIME, SCM_B_SENDINFO.MODIFY_USER_ID, SCM_B_SENDINFO.PRICE, SCM_B_SENDINFO.MATER_CODE, SCM_B_SENDINFO.SEND_DEPART, SCM_B_SENDINFO.STATE, SCM_B_SENDINFO.MONEY, SCM_B_SENDINFO.TXZ01, SCM_B_SENDINFO.LINK_TELEPHONE, SCM_B_SENDINFO.CREATE_USER_ID, SCM_B_SENDINFO.COMMENTS, SCM_B_SENDINFO.GYSNAME, SCM_B_SENDINFO.CREATE_DEPART_ID, SCM_B_SENDINFO.MSEHT, SCM_B_SENDINFO.GYSACCOUNT, SCM_B_SENDINFO.MEINS, SCM_B_SENDINFO.MATNR, SCM_D_SENDDEPART_SEND_DEPART.NAME as SEND_DEPART_NAME,Case when SCM_B_SENDINFO.WERKS='2000' then '武汉协和医院-本部' when SCM_B_SENDINFO.WERKS='2100' then '武汉协和医院-肿瘤中心' when SCM_B_SENDINFO.WERKS='2200' then '武汉协和医院-西院' else '' end as WERKS from SCM_B_SENDINFO left join SCM_D_SENDDEPART   SCM_D_SENDDEPART_SEND_DEPART on SCM_B_SENDINFO.SEND_DEPART = SCM_D_SENDDEPART_SEND_DEPART.CODE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_SENDINFO",paging, order, sSql, parameters, connection);
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
			DisplayObject_SCM_B_SENDINFO dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_SENDINFO();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRICE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SEND_DEPART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.TXZ01 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.GYSNAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MEINS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.WERKS = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_SENDINFO[] objs = new DisplayObject_SCM_B_SENDINFO[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_SENDINFO[] Query(CauseObject_SCM_B_SENDINFO cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_B_SENDINFO.MODIFY_DEPART_ID, SCM_B_SENDINFO.NAME, SCM_B_SENDINFO.ID, SCM_B_SENDINFO.AMOUNT, SCM_B_SENDINFO.DATA_ORGANISE_ID, SCM_B_SENDINFO.LINK_PERSON, SCM_B_SENDINFO.CODE, SCM_B_SENDINFO.MODIFY_TIME, SCM_B_SENDINFO.CREATE_TIME, SCM_B_SENDINFO.MODIFY_USER_ID, SCM_B_SENDINFO.PRICE, SCM_B_SENDINFO.MATER_CODE, SCM_B_SENDINFO.SEND_DEPART, SCM_B_SENDINFO.STATE, SCM_B_SENDINFO.MONEY, SCM_B_SENDINFO.TXZ01, SCM_B_SENDINFO.LINK_TELEPHONE, SCM_B_SENDINFO.CREATE_USER_ID, SCM_B_SENDINFO.COMMENTS, SCM_B_SENDINFO.GYSNAME, SCM_B_SENDINFO.CREATE_DEPART_ID, SCM_B_SENDINFO.MSEHT, SCM_B_SENDINFO.GYSACCOUNT, SCM_B_SENDINFO.MEINS, SCM_B_SENDINFO.MATNR, SCM_D_SENDDEPART_SEND_DEPART.NAME as SEND_DEPART_NAME from SCM_B_SENDINFO left join SCM_D_SENDDEPART   SCM_D_SENDDEPART_SEND_DEPART on SCM_B_SENDINFO.SEND_DEPART = SCM_D_SENDDEPART_SEND_DEPART.CODE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_SENDINFO",paging, order, sSql, parameters, trans);
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
			DisplayObject_SCM_B_SENDINFO dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_SENDINFO();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LINK_PERSON = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CODE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.PRICE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MATER_CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.SEND_DEPART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STATE = sqlReader.GetDecimal(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MONEY = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.TXZ01 = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.LINK_TELEPHONE = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.COMMENTS = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.GYSNAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.MEINS = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.MATNR = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SEND_DEPART_NAME = sqlReader.GetString(25);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_SENDINFO[] objs = new DisplayObject_SCM_B_SENDINFO[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SCM_B_SENDINFO obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  SCM_B_SENDINFO.MODIFY_DEPART_ID = :MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  SCM_B_SENDINFO.NAME = :NAME");
				param = new OracleParameter();
				param.ParameterName = ":NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AMOUNT"))
			{
				strBuf.Add("  SCM_B_SENDINFO.AMOUNT = :AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  SCM_B_SENDINFO.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LINK_PERSON"))
			{
				strBuf.Add("  SCM_B_SENDINFO.LINK_PERSON = :LINK_PERSON");
				param = new OracleParameter();
				param.ParameterName = ":LINK_PERSON";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.LINK_PERSON) ? string.Empty : obj.LINK_PERSON;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  SCM_B_SENDINFO.CODE = :CODE");
				param = new OracleParameter();
				param.ParameterName = ":CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  SCM_B_SENDINFO.MODIFY_TIME = :MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  SCM_B_SENDINFO.MODIFY_USER_ID = :MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRICE"))
			{
				strBuf.Add("  SCM_B_SENDINFO.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName = ":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATER_CODE"))
			{
				strBuf.Add("  SCM_B_SENDINFO.MATER_CODE = :MATER_CODE");
				param = new OracleParameter();
				param.ParameterName = ":MATER_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.MATER_CODE) ? string.Empty : obj.MATER_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEND_DEPART"))
			{
				strBuf.Add("  SCM_B_SENDINFO.SEND_DEPART = :SEND_DEPART");
				param = new OracleParameter();
				param.ParameterName = ":SEND_DEPART";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.SEND_DEPART) ? string.Empty : obj.SEND_DEPART;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  SCM_B_SENDINFO.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  SCM_B_SENDINFO.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName = ":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TXZ01"))
			{
				strBuf.Add("  SCM_B_SENDINFO.TXZ01 = :TXZ01");
				param = new OracleParameter();
				param.ParameterName = ":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.TXZ01) ? string.Empty : obj.TXZ01;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LINK_TELEPHONE"))
			{
				strBuf.Add("  SCM_B_SENDINFO.LINK_TELEPHONE = :LINK_TELEPHONE");
				param = new OracleParameter();
				param.ParameterName = ":LINK_TELEPHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.LINK_TELEPHONE) ? string.Empty : obj.LINK_TELEPHONE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  SCM_B_SENDINFO.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSNAME"))
			{
				strBuf.Add("  SCM_B_SENDINFO.GYSNAME = :GYSNAME");
				param = new OracleParameter();
				param.ParameterName = ":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.GYSNAME) ? string.Empty : obj.GYSNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MSEHT"))
			{
				strBuf.Add("  SCM_B_SENDINFO.MSEHT = :MSEHT");
				param = new OracleParameter();
				param.ParameterName = ":MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.MSEHT) ? string.Empty : obj.MSEHT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  SCM_B_SENDINFO.GYSACCOUNT = :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MEINS"))
			{
				strBuf.Add("  SCM_B_SENDINFO.MEINS = :MEINS");
				param = new OracleParameter();
				param.ParameterName = ":MEINS";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 3;
				param.Value = string.IsNullOrEmpty(obj.MEINS) ? string.Empty : obj.MEINS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATNR"))
			{
				strBuf.Add("  SCM_B_SENDINFO.MATNR = :MATNR");
				param = new OracleParameter();
				param.ParameterName = ":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.MATNR) ? string.Empty : obj.MATNR;
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
