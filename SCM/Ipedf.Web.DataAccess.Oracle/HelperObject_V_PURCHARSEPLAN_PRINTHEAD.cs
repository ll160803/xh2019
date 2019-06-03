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
	[CauseObject(typeof(CauseObject_V_PURCHARSEPLAN_PRINTHEAD))]
	public partial class HelperObject_V_PURCHARSEPLAN_PRINTHEAD
	{		
		#region Method Blok
		public static int Save(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_PURCHARSEPLAN_PRINTHEAD( ID, ORDER_MENGE, FREEUSE1, EEIND, BEDAT, FACTORY, WERKS, GYSACCOUNT, CREATE_TIME, SPEC, GYSNAME, TXZ01, BSART, MATNR, GYJH, NETPR, EBELN, WERKST, MSEHT, MEINS, NAME, LGORT) values ( :ID, :ORDER_MENGE, :FREEUSE1, :EEIND, :BEDAT, :FACTORY, :WERKS, :GYSACCOUNT, :CREATE_TIME, :SPEC, :GYSNAME, :TXZ01, :BSART, :MATNR, :GYJH, :NETPR, :EBELN, :WERKST, :MSEHT, :MEINS, :NAME, :LGORT)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[22];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ORDER_MENGE";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.ORDER_MENGE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":FREEUSE1";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.FREEUSE1 == null ? String.Empty:obj.FREEUSE1;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":EEIND";
			parameters[3].Size = 10;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.EEIND == null ? String.Empty:obj.EEIND;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":BEDAT";
			parameters[4].Size = 10;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.BEDAT == null ? String.Empty:obj.BEDAT;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":FACTORY";
			parameters[5].Size = 100;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.FACTORY == null ? String.Empty:obj.FACTORY;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":WERKS";
			parameters[6].Size = 40;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.WERKS == null ? String.Empty:obj.WERKS;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":GYSACCOUNT";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.GYSACCOUNT == null ? String.Empty:obj.GYSACCOUNT;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CREATE_TIME";
			parameters[8].Size = 7;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[8].Value = obj.CREATE_TIME;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":SPEC";
			parameters[9].Size = 200;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":GYSNAME";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.GYSNAME == null ? String.Empty:obj.GYSNAME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":TXZ01";
			parameters[11].Size = 200;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.TXZ01 == null ? String.Empty:obj.TXZ01;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":BSART";
			parameters[12].Size = 4;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.BSART == null ? String.Empty:obj.BSART;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":MATNR";
			parameters[13].Size = 50;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.MATNR == null ? String.Empty:obj.MATNR;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":GYJH";
			parameters[14].Size = 200;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.GYJH == null ? String.Empty:obj.GYJH;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":NETPR";
			parameters[15].Size = 20;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.NETPR == null ? String.Empty:obj.NETPR;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":EBELN";
			parameters[16].Size = 200;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[16].Value = obj.EBELN == null ? String.Empty:obj.EBELN;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":WERKST";
			parameters[17].Size = 200;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[17].Value = obj.WERKST == null ? String.Empty:obj.WERKST;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":MSEHT";
			parameters[18].Size = 50;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.MSEHT == null ? String.Empty:obj.MSEHT;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":MEINS";
			parameters[19].Size = 50;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.MEINS == null ? String.Empty:obj.MEINS;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":NAME";
			parameters[20].Size = 200;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[20].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":LGORT";
			parameters[21].Size = 200;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[21].Value = obj.LGORT == null ? String.Empty:obj.LGORT;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_PURCHARSEPLAN_PRINTHEAD set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj,CauseObject_V_PURCHARSEPLAN_PRINTHEAD cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_PURCHARSEPLAN_PRINTHEAD set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_PURCHARSEPLAN_PRINTHEAD where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_V_PURCHARSEPLAN_PRINTHEAD cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_PURCHARSEPLAN_PRINTHEAD where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_PURCHARSEPLAN_PRINTHEAD Get(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, ORDER_MENGE, FREEUSE1, EEIND, BEDAT, FACTORY, WERKS, GYSACCOUNT, CREATE_TIME, SPEC, GYSNAME, TXZ01, BSART, MATNR, GYJH, NETPR, EBELN, WERKST, MSEHT, MEINS, NAME, LGORT from V_PURCHARSEPLAN_PRINTHEAD where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_PURCHARSEPLAN_PRINTHEAD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_PURCHARSEPLAN_PRINTHEAD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE1 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.EEIND = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FACTORY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.WERKS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATNR = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.GYJH = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EBELN = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.WERKST = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MSEHT = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MEINS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.LGORT = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_PURCHARSEPLAN_PRINTHEAD[] objs = new EntityObject_V_PURCHARSEPLAN_PRINTHEAD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_PURCHARSEPLAN_PRINTHEAD Get(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, ORDER_MENGE, FREEUSE1, EEIND, BEDAT, FACTORY, WERKS, GYSACCOUNT, CREATE_TIME, SPEC, GYSNAME, TXZ01, BSART, MATNR, GYJH, NETPR, EBELN, WERKST, MSEHT, MEINS, NAME, LGORT from V_PURCHARSEPLAN_PRINTHEAD where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_PURCHARSEPLAN_PRINTHEAD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_PURCHARSEPLAN_PRINTHEAD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE1 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.EEIND = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FACTORY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.WERKS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATNR = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.GYJH = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EBELN = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.WERKST = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MSEHT = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MEINS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.LGORT = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_PURCHARSEPLAN_PRINTHEAD[] objs = new EntityObject_V_PURCHARSEPLAN_PRINTHEAD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_PURCHARSEPLAN_PRINTHEAD.ID, V_PURCHARSEPLAN_PRINTHEAD.ORDER_MENGE, V_PURCHARSEPLAN_PRINTHEAD.FREEUSE1, V_PURCHARSEPLAN_PRINTHEAD.EEIND, V_PURCHARSEPLAN_PRINTHEAD.BEDAT, V_PURCHARSEPLAN_PRINTHEAD.FACTORY, V_PURCHARSEPLAN_PRINTHEAD.WERKS, V_PURCHARSEPLAN_PRINTHEAD.GYSACCOUNT, V_PURCHARSEPLAN_PRINTHEAD.CREATE_TIME, V_PURCHARSEPLAN_PRINTHEAD.SPEC, V_PURCHARSEPLAN_PRINTHEAD.GYSNAME, V_PURCHARSEPLAN_PRINTHEAD.TXZ01, V_PURCHARSEPLAN_PRINTHEAD.BSART, V_PURCHARSEPLAN_PRINTHEAD.MATNR, V_PURCHARSEPLAN_PRINTHEAD.GYJH, V_PURCHARSEPLAN_PRINTHEAD.NETPR, V_PURCHARSEPLAN_PRINTHEAD.EBELN, V_PURCHARSEPLAN_PRINTHEAD.WERKST, V_PURCHARSEPLAN_PRINTHEAD.MSEHT, V_PURCHARSEPLAN_PRINTHEAD.MEINS, V_PURCHARSEPLAN_PRINTHEAD.NAME, V_PURCHARSEPLAN_PRINTHEAD.LGORT from V_PURCHARSEPLAN_PRINTHEAD where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_PURCHARSEPLAN_PRINTHEAD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_PURCHARSEPLAN_PRINTHEAD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE1 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.EEIND = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FACTORY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.WERKS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATNR = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.GYJH = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EBELN = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.WERKST = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MSEHT = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MEINS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.LGORT = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[] objs = new DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_PURCHARSEPLAN_PRINTHEAD cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "ID"));
			}
			if(cause.ORDER_MENGE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.ORDER_MENGE = :C_ORDER_MENGE");
				param = new OracleParameter();
				param.ParameterName =":C_ORDER_MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ORDER_MENGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ORDER_MENGE"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "ORDER_MENGE"));
			}
			if(!string.IsNullOrEmpty(cause.FREEUSE1))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.FREEUSE1 ").Append((cause.FREEUSE1.StartsWith("%") || cause.FREEUSE1.EndsWith("%")) ? " like " : " = ").Append(" :C_FREEUSE1");
				param = new OracleParameter();
				param.ParameterName =":C_FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FREEUSE1;
				paramList.Add(param);
			}
			if (cause.HasINValue("FREEUSE1"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "FREEUSE1"));
			}
			if(!string.IsNullOrEmpty(cause.EEIND))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.EEIND ").Append((cause.EEIND.StartsWith("%") || cause.EEIND.EndsWith("%")) ? " like " : " = ").Append(" :C_EEIND");
				param = new OracleParameter();
				param.ParameterName =":C_EEIND";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.EEIND;
				paramList.Add(param);
			}
			if (cause.HasINValue("EEIND"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "EEIND"));
			}
			if(!string.IsNullOrEmpty(cause.BEDAT))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.BEDAT ").Append((cause.BEDAT.StartsWith("%") || cause.BEDAT.EndsWith("%")) ? " like " : " = ").Append(" :C_BEDAT");
				param = new OracleParameter();
				param.ParameterName =":C_BEDAT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.BEDAT;
				paramList.Add(param);
			}
			if (cause.HasINValue("BEDAT"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "BEDAT"));
			}
			if(!string.IsNullOrEmpty(cause.FACTORY))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.FACTORY ").Append((cause.FACTORY.StartsWith("%") || cause.FACTORY.EndsWith("%")) ? " like " : " = ").Append(" :C_FACTORY");
				param = new OracleParameter();
				param.ParameterName =":C_FACTORY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.FACTORY;
				paramList.Add(param);
			}
			if (cause.HasINValue("FACTORY"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "FACTORY"));
			}
			if(!string.IsNullOrEmpty(cause.WERKS))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.WERKS ").Append((cause.WERKS.StartsWith("%") || cause.WERKS.EndsWith("%")) ? " like " : " = ").Append(" :C_WERKS");
				param = new OracleParameter();
				param.ParameterName =":C_WERKS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 40;
				param.Value = cause.WERKS;
				paramList.Add(param);
			}
			if (cause.HasINValue("WERKS"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "WERKS"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "GYSACCOUNT"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.CREATE_TIME < :C_CREATE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_TIME"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "CREATE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.GYSNAME))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSNAME");
				param = new OracleParameter();
				param.ParameterName =":C_GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "GYSNAME"));
			}
			if(!string.IsNullOrEmpty(cause.TXZ01))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :C_TXZ01");
				param = new OracleParameter();
				param.ParameterName =":C_TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.TXZ01;
				paramList.Add(param);
			}
			if (cause.HasINValue("TXZ01"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "TXZ01"));
			}
			if(!string.IsNullOrEmpty(cause.BSART))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.BSART ").Append((cause.BSART.StartsWith("%") || cause.BSART.EndsWith("%")) ? " like " : " = ").Append(" :C_BSART");
				param = new OracleParameter();
				param.ParameterName =":C_BSART";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 4;
				param.Value = cause.BSART;
				paramList.Add(param);
			}
			if (cause.HasINValue("BSART"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "BSART"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :C_MATNR");
				param = new OracleParameter();
				param.ParameterName =":C_MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MATNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "MATNR"));
			}
			if(!string.IsNullOrEmpty(cause.GYJH))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.GYJH ").Append((cause.GYJH.StartsWith("%") || cause.GYJH.EndsWith("%")) ? " like " : " = ").Append(" :C_GYJH");
				param = new OracleParameter();
				param.ParameterName =":C_GYJH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.GYJH;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYJH"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "GYJH"));
			}
			if(!string.IsNullOrEmpty(cause.NETPR))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.NETPR ").Append((cause.NETPR.StartsWith("%") || cause.NETPR.EndsWith("%")) ? " like " : " = ").Append(" :C_NETPR");
				param = new OracleParameter();
				param.ParameterName =":C_NETPR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.NETPR;
				paramList.Add(param);
			}
			if (cause.HasINValue("NETPR"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "NETPR"));
			}
			if(!string.IsNullOrEmpty(cause.EBELN))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.EBELN ").Append((cause.EBELN.StartsWith("%") || cause.EBELN.EndsWith("%")) ? " like " : " = ").Append(" :C_EBELN");
				param = new OracleParameter();
				param.ParameterName =":C_EBELN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.EBELN;
				paramList.Add(param);
			}
			if (cause.HasINValue("EBELN"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "EBELN"));
			}
			if(!string.IsNullOrEmpty(cause.WERKST))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.WERKST ").Append((cause.WERKST.StartsWith("%") || cause.WERKST.EndsWith("%")) ? " like " : " = ").Append(" :C_WERKST");
				param = new OracleParameter();
				param.ParameterName =":C_WERKST";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.WERKST;
				paramList.Add(param);
			}
			if (cause.HasINValue("WERKST"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "WERKST"));
			}
			if(!string.IsNullOrEmpty(cause.MSEHT))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.MSEHT ").Append((cause.MSEHT.StartsWith("%") || cause.MSEHT.EndsWith("%")) ? " like " : " = ").Append(" :C_MSEHT");
				param = new OracleParameter();
				param.ParameterName =":C_MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MSEHT;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSEHT"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "MSEHT"));
			}
			if(!string.IsNullOrEmpty(cause.MEINS))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.MEINS ").Append((cause.MEINS.StartsWith("%") || cause.MEINS.EndsWith("%")) ? " like " : " = ").Append(" :C_MEINS");
				param = new OracleParameter();
				param.ParameterName =":C_MEINS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MEINS;
				paramList.Add(param);
			}
			if (cause.HasINValue("MEINS"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "MEINS"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.LGORT))
			{
				strBuf.Append(" And V_PURCHARSEPLAN_PRINTHEAD.LGORT ").Append((cause.LGORT.StartsWith("%") || cause.LGORT.EndsWith("%")) ? " like " : " = ").Append(" :C_LGORT");
				param = new OracleParameter();
				param.ParameterName =":C_LGORT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.LGORT;
				paramList.Add(param);
			}
			if (cause.HasINValue("LGORT"))
			{
				strBuf.Append(cause.GetINSQL("V_PURCHARSEPLAN_PRINTHEAD", "LGORT"));
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
		public static DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[] Query(CauseObject_V_PURCHARSEPLAN_PRINTHEAD cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_PURCHARSEPLAN_PRINTHEAD.ID, V_PURCHARSEPLAN_PRINTHEAD.ORDER_MENGE, V_PURCHARSEPLAN_PRINTHEAD.FREEUSE1, V_PURCHARSEPLAN_PRINTHEAD.EEIND, V_PURCHARSEPLAN_PRINTHEAD.BEDAT, V_PURCHARSEPLAN_PRINTHEAD.FACTORY, V_PURCHARSEPLAN_PRINTHEAD.WERKS, V_PURCHARSEPLAN_PRINTHEAD.GYSACCOUNT, V_PURCHARSEPLAN_PRINTHEAD.CREATE_TIME, V_PURCHARSEPLAN_PRINTHEAD.SPEC, V_PURCHARSEPLAN_PRINTHEAD.GYSNAME, V_PURCHARSEPLAN_PRINTHEAD.TXZ01, V_PURCHARSEPLAN_PRINTHEAD.BSART, V_PURCHARSEPLAN_PRINTHEAD.MATNR, V_PURCHARSEPLAN_PRINTHEAD.GYJH, V_PURCHARSEPLAN_PRINTHEAD.NETPR, V_PURCHARSEPLAN_PRINTHEAD.EBELN, V_PURCHARSEPLAN_PRINTHEAD.WERKST, V_PURCHARSEPLAN_PRINTHEAD.MSEHT, V_PURCHARSEPLAN_PRINTHEAD.MEINS, V_PURCHARSEPLAN_PRINTHEAD.NAME, V_PURCHARSEPLAN_PRINTHEAD.LGORT from V_PURCHARSEPLAN_PRINTHEAD where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_PURCHARSEPLAN_PRINTHEAD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_PURCHARSEPLAN_PRINTHEAD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE1 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.EEIND = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FACTORY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.WERKS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATNR = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.GYJH = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EBELN = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.WERKST = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MSEHT = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MEINS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.LGORT = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[] objs = new DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[] Query(CauseObject_V_PURCHARSEPLAN_PRINTHEAD cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_PURCHARSEPLAN_PRINTHEAD.ID, V_PURCHARSEPLAN_PRINTHEAD.ORDER_MENGE, V_PURCHARSEPLAN_PRINTHEAD.FREEUSE1, V_PURCHARSEPLAN_PRINTHEAD.EEIND, V_PURCHARSEPLAN_PRINTHEAD.BEDAT, V_PURCHARSEPLAN_PRINTHEAD.FACTORY, V_PURCHARSEPLAN_PRINTHEAD.WERKS, V_PURCHARSEPLAN_PRINTHEAD.GYSACCOUNT, V_PURCHARSEPLAN_PRINTHEAD.CREATE_TIME, V_PURCHARSEPLAN_PRINTHEAD.SPEC, V_PURCHARSEPLAN_PRINTHEAD.GYSNAME, V_PURCHARSEPLAN_PRINTHEAD.TXZ01, V_PURCHARSEPLAN_PRINTHEAD.BSART, V_PURCHARSEPLAN_PRINTHEAD.MATNR, V_PURCHARSEPLAN_PRINTHEAD.GYJH, V_PURCHARSEPLAN_PRINTHEAD.NETPR, V_PURCHARSEPLAN_PRINTHEAD.EBELN, V_PURCHARSEPLAN_PRINTHEAD.WERKST, V_PURCHARSEPLAN_PRINTHEAD.MSEHT, V_PURCHARSEPLAN_PRINTHEAD.MEINS, V_PURCHARSEPLAN_PRINTHEAD.NAME, V_PURCHARSEPLAN_PRINTHEAD.LGORT from V_PURCHARSEPLAN_PRINTHEAD where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_PURCHARSEPLAN_PRINTHEAD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_PURCHARSEPLAN_PRINTHEAD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE1 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.EEIND = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FACTORY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.WERKS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATNR = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.GYJH = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EBELN = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.WERKST = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MSEHT = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MEINS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.LGORT = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[] objs = new DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[] Query(CauseObject_V_PURCHARSEPLAN_PRINTHEAD cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_PURCHARSEPLAN_PRINTHEAD.ID, V_PURCHARSEPLAN_PRINTHEAD.ORDER_MENGE, V_PURCHARSEPLAN_PRINTHEAD.FREEUSE1, V_PURCHARSEPLAN_PRINTHEAD.EEIND, V_PURCHARSEPLAN_PRINTHEAD.BEDAT, V_PURCHARSEPLAN_PRINTHEAD.FACTORY, V_PURCHARSEPLAN_PRINTHEAD.WERKS, V_PURCHARSEPLAN_PRINTHEAD.GYSACCOUNT, V_PURCHARSEPLAN_PRINTHEAD.CREATE_TIME, V_PURCHARSEPLAN_PRINTHEAD.SPEC, V_PURCHARSEPLAN_PRINTHEAD.GYSNAME, V_PURCHARSEPLAN_PRINTHEAD.TXZ01, V_PURCHARSEPLAN_PRINTHEAD.BSART, V_PURCHARSEPLAN_PRINTHEAD.MATNR, V_PURCHARSEPLAN_PRINTHEAD.GYJH, V_PURCHARSEPLAN_PRINTHEAD.NETPR, V_PURCHARSEPLAN_PRINTHEAD.EBELN, V_PURCHARSEPLAN_PRINTHEAD.WERKST, V_PURCHARSEPLAN_PRINTHEAD.MSEHT, V_PURCHARSEPLAN_PRINTHEAD.MEINS, V_PURCHARSEPLAN_PRINTHEAD.NAME, V_PURCHARSEPLAN_PRINTHEAD.LGORT from V_PURCHARSEPLAN_PRINTHEAD where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_PURCHARSEPLAN_PRINTHEAD",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_PURCHARSEPLAN_PRINTHEAD dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_PURCHARSEPLAN_PRINTHEAD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE1 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.EEIND = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FACTORY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.WERKS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATNR = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.GYJH = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EBELN = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.WERKST = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MSEHT = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MEINS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.LGORT = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[] objs = new DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[] Query(CauseObject_V_PURCHARSEPLAN_PRINTHEAD cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_PURCHARSEPLAN_PRINTHEAD.ID, V_PURCHARSEPLAN_PRINTHEAD.ORDER_MENGE, V_PURCHARSEPLAN_PRINTHEAD.FREEUSE1, V_PURCHARSEPLAN_PRINTHEAD.EEIND, V_PURCHARSEPLAN_PRINTHEAD.BEDAT, V_PURCHARSEPLAN_PRINTHEAD.FACTORY, V_PURCHARSEPLAN_PRINTHEAD.WERKS, V_PURCHARSEPLAN_PRINTHEAD.GYSACCOUNT, V_PURCHARSEPLAN_PRINTHEAD.CREATE_TIME, V_PURCHARSEPLAN_PRINTHEAD.SPEC, V_PURCHARSEPLAN_PRINTHEAD.GYSNAME, V_PURCHARSEPLAN_PRINTHEAD.TXZ01, V_PURCHARSEPLAN_PRINTHEAD.BSART, V_PURCHARSEPLAN_PRINTHEAD.MATNR, V_PURCHARSEPLAN_PRINTHEAD.GYJH, V_PURCHARSEPLAN_PRINTHEAD.NETPR, V_PURCHARSEPLAN_PRINTHEAD.EBELN, V_PURCHARSEPLAN_PRINTHEAD.WERKST, V_PURCHARSEPLAN_PRINTHEAD.MSEHT, V_PURCHARSEPLAN_PRINTHEAD.MEINS, V_PURCHARSEPLAN_PRINTHEAD.NAME, V_PURCHARSEPLAN_PRINTHEAD.LGORT from V_PURCHARSEPLAN_PRINTHEAD where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_PURCHARSEPLAN_PRINTHEAD",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_PURCHARSEPLAN_PRINTHEAD dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_PURCHARSEPLAN_PRINTHEAD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ORDER_MENGE = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.FREEUSE1 = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.EEIND = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.BEDAT = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FACTORY = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.WERKS = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SPEC = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.GYSNAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TXZ01 = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BSART = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MATNR = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.GYJH = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.NETPR = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.EBELN = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.WERKST = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.MSEHT = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MEINS = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.NAME = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.LGORT = sqlReader.GetString(21);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[] objs = new DisplayObject_V_PURCHARSEPLAN_PRINTHEAD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_PURCHARSEPLAN_PRINTHEAD obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.ID = :U_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ORDER_MENGE"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.ORDER_MENGE = :U_ORDER_MENGE");
				param = new OracleParameter();
				param.ParameterName = ":U_ORDER_MENGE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ORDER_MENGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FREEUSE1"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.FREEUSE1 = :U_FREEUSE1");
				param = new OracleParameter();
				param.ParameterName = ":U_FREEUSE1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FREEUSE1) ? string.Empty : obj.FREEUSE1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EEIND"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.EEIND = :U_EEIND");
				param = new OracleParameter();
				param.ParameterName = ":U_EEIND";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.EEIND) ? string.Empty : obj.EEIND;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BEDAT"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.BEDAT = :U_BEDAT");
				param = new OracleParameter();
				param.ParameterName = ":U_BEDAT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.BEDAT) ? string.Empty : obj.BEDAT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FACTORY"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.FACTORY = :U_FACTORY");
				param = new OracleParameter();
				param.ParameterName = ":U_FACTORY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.FACTORY) ? string.Empty : obj.FACTORY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WERKS"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.WERKS = :U_WERKS");
				param = new OracleParameter();
				param.ParameterName = ":U_WERKS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 40;
				param.Value = string.IsNullOrEmpty(obj.WERKS) ? string.Empty : obj.WERKS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.GYSACCOUNT = :U_GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSNAME"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.GYSNAME = :U_GYSNAME");
				param = new OracleParameter();
				param.ParameterName = ":U_GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYSNAME) ? string.Empty : obj.GYSNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TXZ01"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.TXZ01 = :U_TXZ01");
				param = new OracleParameter();
				param.ParameterName = ":U_TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.TXZ01) ? string.Empty : obj.TXZ01;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BSART"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.BSART = :U_BSART");
				param = new OracleParameter();
				param.ParameterName = ":U_BSART";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 4;
				param.Value = string.IsNullOrEmpty(obj.BSART) ? string.Empty : obj.BSART;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATNR"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.MATNR = :U_MATNR");
				param = new OracleParameter();
				param.ParameterName = ":U_MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MATNR) ? string.Empty : obj.MATNR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYJH"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.GYJH = :U_GYJH");
				param = new OracleParameter();
				param.ParameterName = ":U_GYJH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.GYJH) ? string.Empty : obj.GYJH;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NETPR"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.NETPR = :U_NETPR");
				param = new OracleParameter();
				param.ParameterName = ":U_NETPR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.NETPR) ? string.Empty : obj.NETPR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("EBELN"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.EBELN = :U_EBELN");
				param = new OracleParameter();
				param.ParameterName = ":U_EBELN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.EBELN) ? string.Empty : obj.EBELN;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WERKST"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.WERKST = :U_WERKST");
				param = new OracleParameter();
				param.ParameterName = ":U_WERKST";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.WERKST) ? string.Empty : obj.WERKST;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MSEHT"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.MSEHT = :U_MSEHT");
				param = new OracleParameter();
				param.ParameterName = ":U_MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MSEHT) ? string.Empty : obj.MSEHT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MEINS"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.MEINS = :U_MEINS");
				param = new OracleParameter();
				param.ParameterName = ":U_MEINS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MEINS) ? string.Empty : obj.MEINS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LGORT"))
			{
				strBuf.Add("  V_PURCHARSEPLAN_PRINTHEAD.LGORT = :U_LGORT");
				param = new OracleParameter();
				param.ParameterName = ":U_LGORT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.LGORT) ? string.Empty : obj.LGORT;
				paramList.Add(param);
			}
			//pk here
			if(appendpk)
			{
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		#endregion 
	}
}
