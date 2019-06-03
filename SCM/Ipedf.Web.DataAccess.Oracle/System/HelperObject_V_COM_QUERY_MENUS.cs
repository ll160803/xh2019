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
	[CauseObject(typeof(CauseObject_V_COM_QUERY_MENUS))]
	public partial class HelperObject_V_COM_QUERY_MENUS
	{		
		#region Method Blok
		public static int Save(EntityObject_V_COM_QUERY_MENUS obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "insert into V_COM_QUERY_MENUS( FUNCTION_PAGE_URL, PAGE_CODE, MODULE_NAME, MODULE_PAGE_URL, FUNCTION_CODE, MODULE_CODE, FUNCTION_DISPLAY_INDEX, SYSTEM_NAME, PAGE_NAME, SYSTEM_CODE, FUNCTION_NAME, MODULE_DISPALY_INDEX, PAGE_URL, PAGE_ID, SYSTEM_PAGE_URL, SYSTEM_DISPLAY_INDEX, USER_ID, SYSTEM_ID, PAGE_DISPLAY_INDEX, IMG_URL) values ( :FUNCTION_PAGE_URL, :PAGE_CODE, :MODULE_NAME, :MODULE_PAGE_URL, :FUNCTION_CODE, :MODULE_CODE, :FUNCTION_DISPLAY_INDEX, :SYSTEM_NAME, :PAGE_NAME, :SYSTEM_CODE, :FUNCTION_NAME, :MODULE_DISPALY_INDEX, :PAGE_URL, :PAGE_ID, :SYSTEM_PAGE_URL, :SYSTEM_DISPLAY_INDEX, :USER_ID, :SYSTEM_ID, :PAGE_DISPLAY_INDEX, :IMG_URL)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[20];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":FUNCTION_PAGE_URL";
			parameters[0].Size = 50;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.FUNCTION_PAGE_URL == null ? String.Empty:obj.FUNCTION_PAGE_URL;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":PAGE_CODE";
			parameters[1].Size = 50;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.PAGE_CODE == null ? String.Empty:obj.PAGE_CODE;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":MODULE_NAME";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.MODULE_NAME == null ? String.Empty:obj.MODULE_NAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":MODULE_PAGE_URL";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.MODULE_PAGE_URL == null ? String.Empty:obj.MODULE_PAGE_URL;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":FUNCTION_CODE";
			parameters[4].Size = 50;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.FUNCTION_CODE == null ? String.Empty:obj.FUNCTION_CODE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":MODULE_CODE";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.MODULE_CODE == null ? String.Empty:obj.MODULE_CODE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":FUNCTION_DISPLAY_INDEX";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.FUNCTION_DISPLAY_INDEX;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":SYSTEM_NAME";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.SYSTEM_NAME == null ? String.Empty:obj.SYSTEM_NAME;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":PAGE_NAME";
			parameters[8].Size = 50;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.PAGE_NAME == null ? String.Empty:obj.PAGE_NAME;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":SYSTEM_CODE";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.SYSTEM_CODE == null ? String.Empty:obj.SYSTEM_CODE;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":FUNCTION_NAME";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.FUNCTION_NAME == null ? String.Empty:obj.FUNCTION_NAME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":MODULE_DISPALY_INDEX";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.MODULE_DISPALY_INDEX;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":PAGE_URL";
			parameters[12].Size = 100;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.PAGE_URL == null ? String.Empty:obj.PAGE_URL;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":PAGE_ID";
			parameters[13].Size = 36;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.PAGE_ID == null ? String.Empty:obj.PAGE_ID;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":SYSTEM_PAGE_URL";
			parameters[14].Size = 50;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.SYSTEM_PAGE_URL == null ? String.Empty:obj.SYSTEM_PAGE_URL;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":SYSTEM_DISPLAY_INDEX";
			parameters[15].Size = 22;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[15].Value = obj.SYSTEM_DISPLAY_INDEX;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":USER_ID";
			parameters[16].Size = 36;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[16].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":SYSTEM_ID";
			parameters[17].Size = 36;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[17].Value = obj.SYSTEM_ID == null ? String.Empty:obj.SYSTEM_ID;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":PAGE_DISPLAY_INDEX";
			parameters[18].Size = 22;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[18].Value = obj.PAGE_DISPLAY_INDEX;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":IMG_URL";
			parameters[19].Size = 50;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.IMG_URL == null ? String.Empty:obj.IMG_URL;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_COM_QUERY_MENUS obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_COM_QUERY_MENUS set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_COM_QUERY_MENUS obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_COM_QUERY_MENUS where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_COM_QUERY_MENUS Get(EntityObject_V_COM_QUERY_MENUS obj)
		{
			
			//平台自动生成代码
			string sSql = "select  FUNCTION_PAGE_URL, PAGE_CODE, MODULE_NAME, MODULE_PAGE_URL, FUNCTION_CODE, MODULE_CODE, FUNCTION_DISPLAY_INDEX, SYSTEM_NAME, PAGE_NAME, SYSTEM_CODE, FUNCTION_NAME, MODULE_DISPALY_INDEX, PAGE_URL, PAGE_ID, SYSTEM_PAGE_URL, SYSTEM_DISPLAY_INDEX, USER_ID, SYSTEM_ID, PAGE_DISPLAY_INDEX, IMG_URL from V_COM_QUERY_MENUS where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_COM_QUERY_MENUS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_COM_QUERY_MENUS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUNCTION_PAGE_URL = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODULE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODULE_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FUNCTION_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODULE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FUNCTION_DISPLAY_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SYSTEM_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAGE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SYSTEM_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FUNCTION_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODULE_DISPALY_INDEX = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PAGE_URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PAGE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SYSTEM_PAGE_URL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SYSTEM_DISPLAY_INDEX = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SYSTEM_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PAGE_DISPLAY_INDEX = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IMG_URL = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_COM_QUERY_MENUS[] objs = new EntityObject_V_COM_QUERY_MENUS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_COM_QUERY_MENUS Get(EntityObject_V_COM_QUERY_MENUS obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  FUNCTION_PAGE_URL, PAGE_CODE, MODULE_NAME, MODULE_PAGE_URL, FUNCTION_CODE, MODULE_CODE, FUNCTION_DISPLAY_INDEX, SYSTEM_NAME, PAGE_NAME, SYSTEM_CODE, FUNCTION_NAME, MODULE_DISPALY_INDEX, PAGE_URL, PAGE_ID, SYSTEM_PAGE_URL, SYSTEM_DISPLAY_INDEX, USER_ID, SYSTEM_ID, PAGE_DISPLAY_INDEX, IMG_URL from V_COM_QUERY_MENUS where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_COM_QUERY_MENUS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_COM_QUERY_MENUS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUNCTION_PAGE_URL = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODULE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODULE_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FUNCTION_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODULE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FUNCTION_DISPLAY_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SYSTEM_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAGE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SYSTEM_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FUNCTION_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODULE_DISPALY_INDEX = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PAGE_URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PAGE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SYSTEM_PAGE_URL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SYSTEM_DISPLAY_INDEX = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SYSTEM_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PAGE_DISPLAY_INDEX = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IMG_URL = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_COM_QUERY_MENUS[] objs = new EntityObject_V_COM_QUERY_MENUS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_COM_QUERY_MENUS[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_COM_QUERY_MENUS.FUNCTION_PAGE_URL, V_COM_QUERY_MENUS.PAGE_CODE, V_COM_QUERY_MENUS.MODULE_NAME, V_COM_QUERY_MENUS.MODULE_PAGE_URL, V_COM_QUERY_MENUS.FUNCTION_CODE, V_COM_QUERY_MENUS.MODULE_CODE, V_COM_QUERY_MENUS.FUNCTION_DISPLAY_INDEX, V_COM_QUERY_MENUS.SYSTEM_NAME, V_COM_QUERY_MENUS.PAGE_NAME, V_COM_QUERY_MENUS.SYSTEM_CODE, V_COM_QUERY_MENUS.FUNCTION_NAME, V_COM_QUERY_MENUS.MODULE_DISPALY_INDEX, V_COM_QUERY_MENUS.PAGE_URL, V_COM_QUERY_MENUS.PAGE_ID, V_COM_QUERY_MENUS.SYSTEM_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_DISPLAY_INDEX, V_COM_QUERY_MENUS.USER_ID, V_COM_QUERY_MENUS.SYSTEM_ID, V_COM_QUERY_MENUS.PAGE_DISPLAY_INDEX, V_COM_QUERY_MENUS.IMG_URL from V_COM_QUERY_MENUS where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_COM_QUERY_MENUS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_MENUS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUNCTION_PAGE_URL = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODULE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODULE_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FUNCTION_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODULE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FUNCTION_DISPLAY_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SYSTEM_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAGE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SYSTEM_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FUNCTION_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODULE_DISPALY_INDEX = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PAGE_URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PAGE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SYSTEM_PAGE_URL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SYSTEM_DISPLAY_INDEX = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SYSTEM_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PAGE_DISPLAY_INDEX = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IMG_URL = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_MENUS[] objs = new DisplayObject_V_COM_QUERY_MENUS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_COM_QUERY_MENUS cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.FUNCTION_PAGE_URL))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.FUNCTION_PAGE_URL ").Append((cause.FUNCTION_PAGE_URL.StartsWith("%") || cause.FUNCTION_PAGE_URL.EndsWith("%")) ? " like " : " = ").Append(" :FUNCTION_PAGE_URL");
				param = new OracleParameter();
				param.ParameterName =":FUNCTION_PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FUNCTION_PAGE_URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUNCTION_PAGE_URL"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "FUNCTION_PAGE_URL"));
			}
			if(!string.IsNullOrEmpty(cause.PAGE_CODE))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.PAGE_CODE ").Append((cause.PAGE_CODE.StartsWith("%") || cause.PAGE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :PAGE_CODE");
				param = new OracleParameter();
				param.ParameterName =":PAGE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PAGE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAGE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "PAGE_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.MODULE_NAME))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.MODULE_NAME ").Append((cause.MODULE_NAME.StartsWith("%") || cause.MODULE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :MODULE_NAME");
				param = new OracleParameter();
				param.ParameterName =":MODULE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MODULE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODULE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "MODULE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.MODULE_PAGE_URL))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.MODULE_PAGE_URL ").Append((cause.MODULE_PAGE_URL.StartsWith("%") || cause.MODULE_PAGE_URL.EndsWith("%")) ? " like " : " = ").Append(" :MODULE_PAGE_URL");
				param = new OracleParameter();
				param.ParameterName =":MODULE_PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MODULE_PAGE_URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODULE_PAGE_URL"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "MODULE_PAGE_URL"));
			}
			if(!string.IsNullOrEmpty(cause.FUNCTION_CODE))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.FUNCTION_CODE ").Append((cause.FUNCTION_CODE.StartsWith("%") || cause.FUNCTION_CODE.EndsWith("%")) ? " like " : " = ").Append(" :FUNCTION_CODE");
				param = new OracleParameter();
				param.ParameterName =":FUNCTION_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FUNCTION_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUNCTION_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "FUNCTION_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.MODULE_CODE))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.MODULE_CODE ").Append((cause.MODULE_CODE.StartsWith("%") || cause.MODULE_CODE.EndsWith("%")) ? " like " : " = ").Append(" :MODULE_CODE");
				param = new OracleParameter();
				param.ParameterName =":MODULE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MODULE_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODULE_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "MODULE_CODE"));
			}
			if(cause.FUNCTION_DISPLAY_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.FUNCTION_DISPLAY_INDEX = :FUNCTION_DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName =":FUNCTION_DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.FUNCTION_DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUNCTION_DISPLAY_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "FUNCTION_DISPLAY_INDEX"));
			}
			if(!string.IsNullOrEmpty(cause.SYSTEM_NAME))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.SYSTEM_NAME ").Append((cause.SYSTEM_NAME.StartsWith("%") || cause.SYSTEM_NAME.EndsWith("%")) ? " like " : " = ").Append(" :SYSTEM_NAME");
				param = new OracleParameter();
				param.ParameterName =":SYSTEM_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SYSTEM_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SYSTEM_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "SYSTEM_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.PAGE_NAME))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.PAGE_NAME ").Append((cause.PAGE_NAME.StartsWith("%") || cause.PAGE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :PAGE_NAME");
				param = new OracleParameter();
				param.ParameterName =":PAGE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PAGE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAGE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "PAGE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.SYSTEM_CODE))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.SYSTEM_CODE ").Append((cause.SYSTEM_CODE.StartsWith("%") || cause.SYSTEM_CODE.EndsWith("%")) ? " like " : " = ").Append(" :SYSTEM_CODE");
				param = new OracleParameter();
				param.ParameterName =":SYSTEM_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SYSTEM_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SYSTEM_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "SYSTEM_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.FUNCTION_NAME))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.FUNCTION_NAME ").Append((cause.FUNCTION_NAME.StartsWith("%") || cause.FUNCTION_NAME.EndsWith("%")) ? " like " : " = ").Append(" :FUNCTION_NAME");
				param = new OracleParameter();
				param.ParameterName =":FUNCTION_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.FUNCTION_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("FUNCTION_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "FUNCTION_NAME"));
			}
			if(cause.MODULE_DISPALY_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.MODULE_DISPALY_INDEX = :MODULE_DISPALY_INDEX");
				param = new OracleParameter();
				param.ParameterName =":MODULE_DISPALY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MODULE_DISPALY_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODULE_DISPALY_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "MODULE_DISPALY_INDEX"));
			}
			if(!string.IsNullOrEmpty(cause.PAGE_URL))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.PAGE_URL ").Append((cause.PAGE_URL.StartsWith("%") || cause.PAGE_URL.EndsWith("%")) ? " like " : " = ").Append(" :PAGE_URL");
				param = new OracleParameter();
				param.ParameterName =":PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.PAGE_URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAGE_URL"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "PAGE_URL"));
			}
			if(!string.IsNullOrEmpty(cause.PAGE_ID))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.PAGE_ID ").Append((cause.PAGE_ID.StartsWith("%") || cause.PAGE_ID.EndsWith("%")) ? " like " : " = ").Append(" :PAGE_ID");
				param = new OracleParameter();
				param.ParameterName =":PAGE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PAGE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAGE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "PAGE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SYSTEM_PAGE_URL))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.SYSTEM_PAGE_URL ").Append((cause.SYSTEM_PAGE_URL.StartsWith("%") || cause.SYSTEM_PAGE_URL.EndsWith("%")) ? " like " : " = ").Append(" :SYSTEM_PAGE_URL");
				param = new OracleParameter();
				param.ParameterName =":SYSTEM_PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SYSTEM_PAGE_URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("SYSTEM_PAGE_URL"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "SYSTEM_PAGE_URL"));
			}
			if(cause.SYSTEM_DISPLAY_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.SYSTEM_DISPLAY_INDEX = :SYSTEM_DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName =":SYSTEM_DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.SYSTEM_DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("SYSTEM_DISPLAY_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "SYSTEM_DISPLAY_INDEX"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :USER_ID");
				param = new OracleParameter();
				param.ParameterName =":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SYSTEM_ID))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.SYSTEM_ID ").Append((cause.SYSTEM_ID.StartsWith("%") || cause.SYSTEM_ID.EndsWith("%")) ? " like " : " = ").Append(" :SYSTEM_ID");
				param = new OracleParameter();
				param.ParameterName =":SYSTEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SYSTEM_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("SYSTEM_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "SYSTEM_ID"));
			}
			if(cause.PAGE_DISPLAY_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.PAGE_DISPLAY_INDEX = :PAGE_DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName =":PAGE_DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PAGE_DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("PAGE_DISPLAY_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "PAGE_DISPLAY_INDEX"));
			}
			if(!string.IsNullOrEmpty(cause.IMG_URL))
			{
				strBuf.Append(" And V_COM_QUERY_MENUS.IMG_URL ").Append((cause.IMG_URL.StartsWith("%") || cause.IMG_URL.EndsWith("%")) ? " like " : " = ").Append(" :IMG_URL");
				param = new OracleParameter();
				param.ParameterName =":IMG_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.IMG_URL;
				paramList.Add(param);
			}
			if (cause.HasINValue("IMG_URL"))
			{
				strBuf.Append(cause.GetINSQL("V_COM_QUERY_MENUS", "IMG_URL"));
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
		public static DisplayObject_V_COM_QUERY_MENUS[] Query(CauseObject_V_COM_QUERY_MENUS cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_MENUS.FUNCTION_PAGE_URL, V_COM_QUERY_MENUS.PAGE_CODE, V_COM_QUERY_MENUS.MODULE_NAME, V_COM_QUERY_MENUS.MODULE_PAGE_URL, V_COM_QUERY_MENUS.FUNCTION_CODE, V_COM_QUERY_MENUS.MODULE_CODE, V_COM_QUERY_MENUS.FUNCTION_DISPLAY_INDEX, V_COM_QUERY_MENUS.SYSTEM_NAME, V_COM_QUERY_MENUS.PAGE_NAME, V_COM_QUERY_MENUS.SYSTEM_CODE, V_COM_QUERY_MENUS.FUNCTION_NAME, V_COM_QUERY_MENUS.MODULE_DISPALY_INDEX, V_COM_QUERY_MENUS.PAGE_URL, V_COM_QUERY_MENUS.PAGE_ID, V_COM_QUERY_MENUS.SYSTEM_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_DISPLAY_INDEX, V_COM_QUERY_MENUS.USER_ID, V_COM_QUERY_MENUS.SYSTEM_ID, V_COM_QUERY_MENUS.PAGE_DISPLAY_INDEX, V_COM_QUERY_MENUS.IMG_URL from V_COM_QUERY_MENUS where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_COM_QUERY_MENUS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_MENUS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUNCTION_PAGE_URL = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODULE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODULE_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FUNCTION_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODULE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FUNCTION_DISPLAY_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SYSTEM_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAGE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SYSTEM_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FUNCTION_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODULE_DISPALY_INDEX = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PAGE_URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PAGE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SYSTEM_PAGE_URL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SYSTEM_DISPLAY_INDEX = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SYSTEM_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PAGE_DISPLAY_INDEX = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IMG_URL = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_MENUS[] objs = new DisplayObject_V_COM_QUERY_MENUS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_COM_QUERY_MENUS cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_COM_QUERY_MENUS where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_COM_QUERY_MENUS[] Query(CauseObject_V_COM_QUERY_MENUS cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_MENUS.FUNCTION_PAGE_URL, V_COM_QUERY_MENUS.PAGE_CODE, V_COM_QUERY_MENUS.MODULE_NAME, V_COM_QUERY_MENUS.MODULE_PAGE_URL, V_COM_QUERY_MENUS.FUNCTION_CODE, V_COM_QUERY_MENUS.MODULE_CODE, V_COM_QUERY_MENUS.FUNCTION_DISPLAY_INDEX, V_COM_QUERY_MENUS.SYSTEM_NAME, V_COM_QUERY_MENUS.PAGE_NAME, V_COM_QUERY_MENUS.SYSTEM_CODE, V_COM_QUERY_MENUS.FUNCTION_NAME, V_COM_QUERY_MENUS.MODULE_DISPALY_INDEX, V_COM_QUERY_MENUS.PAGE_URL, V_COM_QUERY_MENUS.PAGE_ID, V_COM_QUERY_MENUS.SYSTEM_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_DISPLAY_INDEX, V_COM_QUERY_MENUS.USER_ID, V_COM_QUERY_MENUS.SYSTEM_ID, V_COM_QUERY_MENUS.PAGE_DISPLAY_INDEX, V_COM_QUERY_MENUS.IMG_URL from V_COM_QUERY_MENUS where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_COM_QUERY_MENUS dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_MENUS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUNCTION_PAGE_URL = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODULE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODULE_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FUNCTION_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODULE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FUNCTION_DISPLAY_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SYSTEM_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAGE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SYSTEM_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FUNCTION_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODULE_DISPALY_INDEX = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PAGE_URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PAGE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SYSTEM_PAGE_URL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SYSTEM_DISPLAY_INDEX = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SYSTEM_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PAGE_DISPLAY_INDEX = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IMG_URL = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_MENUS[] objs = new DisplayObject_V_COM_QUERY_MENUS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_MENUS[] Query(CauseObject_V_COM_QUERY_MENUS cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_MENUS.FUNCTION_PAGE_URL, V_COM_QUERY_MENUS.PAGE_CODE, V_COM_QUERY_MENUS.MODULE_NAME, V_COM_QUERY_MENUS.MODULE_PAGE_URL, V_COM_QUERY_MENUS.FUNCTION_CODE, V_COM_QUERY_MENUS.MODULE_CODE, V_COM_QUERY_MENUS.FUNCTION_DISPLAY_INDEX, V_COM_QUERY_MENUS.SYSTEM_NAME, V_COM_QUERY_MENUS.PAGE_NAME, V_COM_QUERY_MENUS.SYSTEM_CODE, V_COM_QUERY_MENUS.FUNCTION_NAME, V_COM_QUERY_MENUS.MODULE_DISPALY_INDEX, V_COM_QUERY_MENUS.PAGE_URL, V_COM_QUERY_MENUS.PAGE_ID, V_COM_QUERY_MENUS.SYSTEM_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_DISPLAY_INDEX, V_COM_QUERY_MENUS.USER_ID, V_COM_QUERY_MENUS.SYSTEM_ID, V_COM_QUERY_MENUS.PAGE_DISPLAY_INDEX, V_COM_QUERY_MENUS.IMG_URL from V_COM_QUERY_MENUS where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_COM_QUERY_MENUS",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_COM_QUERY_MENUS dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_MENUS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUNCTION_PAGE_URL = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODULE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODULE_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FUNCTION_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODULE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FUNCTION_DISPLAY_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SYSTEM_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAGE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SYSTEM_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FUNCTION_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODULE_DISPALY_INDEX = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PAGE_URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PAGE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SYSTEM_PAGE_URL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SYSTEM_DISPLAY_INDEX = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SYSTEM_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PAGE_DISPLAY_INDEX = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IMG_URL = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_COM_QUERY_MENUS[] objs = new DisplayObject_V_COM_QUERY_MENUS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_COM_QUERY_MENUS[] Query(CauseObject_V_COM_QUERY_MENUS cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_COM_QUERY_MENUS.FUNCTION_PAGE_URL, V_COM_QUERY_MENUS.PAGE_CODE, V_COM_QUERY_MENUS.MODULE_NAME, V_COM_QUERY_MENUS.MODULE_PAGE_URL, V_COM_QUERY_MENUS.FUNCTION_CODE, V_COM_QUERY_MENUS.MODULE_CODE, V_COM_QUERY_MENUS.FUNCTION_DISPLAY_INDEX, V_COM_QUERY_MENUS.SYSTEM_NAME, V_COM_QUERY_MENUS.PAGE_NAME, V_COM_QUERY_MENUS.SYSTEM_CODE, V_COM_QUERY_MENUS.FUNCTION_NAME, V_COM_QUERY_MENUS.MODULE_DISPALY_INDEX, V_COM_QUERY_MENUS.PAGE_URL, V_COM_QUERY_MENUS.PAGE_ID, V_COM_QUERY_MENUS.SYSTEM_PAGE_URL, V_COM_QUERY_MENUS.SYSTEM_DISPLAY_INDEX, V_COM_QUERY_MENUS.USER_ID, V_COM_QUERY_MENUS.SYSTEM_ID, V_COM_QUERY_MENUS.PAGE_DISPLAY_INDEX, V_COM_QUERY_MENUS.IMG_URL from V_COM_QUERY_MENUS where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_COM_QUERY_MENUS",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_COM_QUERY_MENUS dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_COM_QUERY_MENUS();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FUNCTION_PAGE_URL = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PAGE_CODE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MODULE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODULE_PAGE_URL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FUNCTION_CODE = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MODULE_CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FUNCTION_DISPLAY_INDEX = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SYSTEM_NAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PAGE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SYSTEM_CODE = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.FUNCTION_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODULE_DISPALY_INDEX = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.PAGE_URL = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.PAGE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SYSTEM_PAGE_URL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SYSTEM_DISPLAY_INDEX = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.USER_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SYSTEM_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.PAGE_DISPLAY_INDEX = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IMG_URL = sqlReader.GetString(19);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_COM_QUERY_MENUS[] objs = new DisplayObject_V_COM_QUERY_MENUS[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_COM_QUERY_MENUS obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("FUNCTION_PAGE_URL"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.FUNCTION_PAGE_URL = :FUNCTION_PAGE_URL");
				param = new OracleParameter();
				param.ParameterName = ":FUNCTION_PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FUNCTION_PAGE_URL) ? string.Empty : obj.FUNCTION_PAGE_URL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAGE_CODE"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.PAGE_CODE = :PAGE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":PAGE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PAGE_CODE) ? string.Empty : obj.PAGE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODULE_NAME"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.MODULE_NAME = :MODULE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":MODULE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MODULE_NAME) ? string.Empty : obj.MODULE_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODULE_PAGE_URL"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.MODULE_PAGE_URL = :MODULE_PAGE_URL");
				param = new OracleParameter();
				param.ParameterName = ":MODULE_PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MODULE_PAGE_URL) ? string.Empty : obj.MODULE_PAGE_URL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FUNCTION_CODE"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.FUNCTION_CODE = :FUNCTION_CODE");
				param = new OracleParameter();
				param.ParameterName = ":FUNCTION_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FUNCTION_CODE) ? string.Empty : obj.FUNCTION_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODULE_CODE"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.MODULE_CODE = :MODULE_CODE");
				param = new OracleParameter();
				param.ParameterName = ":MODULE_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MODULE_CODE) ? string.Empty : obj.MODULE_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FUNCTION_DISPLAY_INDEX"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.FUNCTION_DISPLAY_INDEX = :FUNCTION_DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName = ":FUNCTION_DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.FUNCTION_DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SYSTEM_NAME"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.SYSTEM_NAME = :SYSTEM_NAME");
				param = new OracleParameter();
				param.ParameterName = ":SYSTEM_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SYSTEM_NAME) ? string.Empty : obj.SYSTEM_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAGE_NAME"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.PAGE_NAME = :PAGE_NAME");
				param = new OracleParameter();
				param.ParameterName = ":PAGE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PAGE_NAME) ? string.Empty : obj.PAGE_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SYSTEM_CODE"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.SYSTEM_CODE = :SYSTEM_CODE");
				param = new OracleParameter();
				param.ParameterName = ":SYSTEM_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SYSTEM_CODE) ? string.Empty : obj.SYSTEM_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FUNCTION_NAME"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.FUNCTION_NAME = :FUNCTION_NAME");
				param = new OracleParameter();
				param.ParameterName = ":FUNCTION_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.FUNCTION_NAME) ? string.Empty : obj.FUNCTION_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODULE_DISPALY_INDEX"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.MODULE_DISPALY_INDEX = :MODULE_DISPALY_INDEX");
				param = new OracleParameter();
				param.ParameterName = ":MODULE_DISPALY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MODULE_DISPALY_INDEX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAGE_URL"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.PAGE_URL = :PAGE_URL");
				param = new OracleParameter();
				param.ParameterName = ":PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.PAGE_URL) ? string.Empty : obj.PAGE_URL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAGE_ID"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.PAGE_ID = :PAGE_ID");
				param = new OracleParameter();
				param.ParameterName = ":PAGE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PAGE_ID) ? string.Empty : obj.PAGE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SYSTEM_PAGE_URL"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.SYSTEM_PAGE_URL = :SYSTEM_PAGE_URL");
				param = new OracleParameter();
				param.ParameterName = ":SYSTEM_PAGE_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.SYSTEM_PAGE_URL) ? string.Empty : obj.SYSTEM_PAGE_URL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SYSTEM_DISPLAY_INDEX"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.SYSTEM_DISPLAY_INDEX = :SYSTEM_DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName = ":SYSTEM_DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.SYSTEM_DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.USER_ID = :USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SYSTEM_ID"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.SYSTEM_ID = :SYSTEM_ID");
				param = new OracleParameter();
				param.ParameterName = ":SYSTEM_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.SYSTEM_ID) ? string.Empty : obj.SYSTEM_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PAGE_DISPLAY_INDEX"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.PAGE_DISPLAY_INDEX = :PAGE_DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName = ":PAGE_DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PAGE_DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IMG_URL"))
			{
				strBuf.Add("  V_COM_QUERY_MENUS.IMG_URL = :IMG_URL");
				param = new OracleParameter();
				param.ParameterName = ":IMG_URL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.IMG_URL) ? string.Empty : obj.IMG_URL;
				paramList.Add(param);
			}
			//pk here
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		#endregion 
	}
}
