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
	[CauseObject(typeof(CauseObject_SCM_B_QUOTEDPRICE))]
	public partial class HelperObject_SCM_B_QUOTEDPRICE
	{		
		#region Method Blok
		public static int Save(EntityObject_SCM_B_QUOTEDPRICE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into SCM_B_QUOTEDPRICE( QUOTED_PRICE, COMMENTS, PRODUCT_NAME, ID, CREATE_USER_ID, DISPLAY_INDEX, STATE, DATA_ORGANISE_ID, CREATE_TIME, SUPPLY_AMOUNT, CODE, GYSACCOUNT, GYSNAME, BASE_ID, CREATE_DEPART_ID) values ( :QUOTED_PRICE, :COMMENTS, :PRODUCT_NAME, :ID, :CREATE_USER_ID, :DISPLAY_INDEX, :STATE, :DATA_ORGANISE_ID, :CREATE_TIME, :SUPPLY_AMOUNT, :CODE, :GYSACCOUNT, :GYSNAME, :BASE_ID, :CREATE_DEPART_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[15];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":QUOTED_PRICE";
			parameters[0].Size = 22;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[0].Value = obj.QUOTED_PRICE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":COMMENTS";
			parameters[1].Size = 500;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":PRODUCT_NAME";
			parameters[2].Size = 100;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.PRODUCT_NAME == null ? String.Empty:obj.PRODUCT_NAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":CREATE_USER_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":DISPLAY_INDEX";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.DISPLAY_INDEX;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":STATE";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.STATE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":DATA_ORGANISE_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CREATE_TIME";
			parameters[8].Size = 7;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[8].Value = obj.CREATE_TIME;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":SUPPLY_AMOUNT";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.SUPPLY_AMOUNT;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":CODE";
			parameters[10].Size = 12;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":GYSACCOUNT";
			parameters[11].Size = 20;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.GYSACCOUNT == null ? String.Empty:obj.GYSACCOUNT;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":GYSNAME";
			parameters[12].Size = 100;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.GYSNAME == null ? String.Empty:obj.GYSNAME;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":BASE_ID";
			parameters[13].Size = 36;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":CREATE_DEPART_ID";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.CREATE_DEPART_ID == null ? String.Empty:obj.CREATE_DEPART_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SCM_B_QUOTEDPRICE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_B_QUOTEDPRICE set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SCM_B_QUOTEDPRICE obj,CauseObject_SCM_B_QUOTEDPRICE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_B_QUOTEDPRICE set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SCM_B_QUOTEDPRICE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SCM_B_QUOTEDPRICE where  ID = :ID ";
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
		public static int Delete(CauseObject_SCM_B_QUOTEDPRICE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SCM_B_QUOTEDPRICE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_SCM_B_QUOTEDPRICE Get(EntityObject_SCM_B_QUOTEDPRICE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  QUOTED_PRICE, COMMENTS, PRODUCT_NAME, ID, CREATE_USER_ID, DISPLAY_INDEX, MODIFY_USER_ID, STATE, DATA_ORGANISE_ID, CREATE_TIME, SUPPLY_AMOUNT, CODE, GYSACCOUNT, GYSNAME, BASE_ID, MODIFY_TIME, CREATE_DEPART_ID, MODIFY_DEPART_ID from SCM_B_QUOTEDPRICE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_QUOTEDPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_QUOTEDPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSNAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SCM_B_QUOTEDPRICE[] objs = new EntityObject_SCM_B_QUOTEDPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_B_QUOTEDPRICE Get(DisplayObject_SCM_B_QUOTEDPRICE obj)
		{
			
			//平台自动生成代码
			string sSql = " select  SCM_B_QUOTEDPRICE.QUOTED_PRICE, SCM_B_QUOTEDPRICE.COMMENTS, SCM_B_QUOTEDPRICE.PRODUCT_NAME, SCM_B_QUOTEDPRICE.ID, SCM_B_QUOTEDPRICE.CREATE_USER_ID, SCM_B_QUOTEDPRICE.DISPLAY_INDEX, SCM_B_QUOTEDPRICE.MODIFY_USER_ID, SCM_B_QUOTEDPRICE.STATE, SCM_B_QUOTEDPRICE.DATA_ORGANISE_ID, SCM_B_QUOTEDPRICE.CREATE_TIME, SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT, SCM_B_QUOTEDPRICE.CODE, SCM_B_QUOTEDPRICE.GYSACCOUNT, SCM_B_QUOTEDPRICE.GYSNAME, SCM_B_QUOTEDPRICE.BASE_ID, SCM_B_QUOTEDPRICE.MODIFY_TIME, SCM_B_QUOTEDPRICE.CREATE_DEPART_ID, SCM_B_QUOTEDPRICE.MODIFY_DEPART_ID, (case  when SCM_B_QUOTEDPRICE.STATE = 0 then '默认值' when SCM_B_QUOTEDPRICE.STATE = 1 then '编辑中' when SCM_B_QUOTEDPRICE.STATE = 2 then '已提交' when SCM_B_QUOTEDPRICE.STATE = 3 then '已审核' when SCM_B_QUOTEDPRICE.STATE = 4 then '已归档' when SCM_B_QUOTEDPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME from SCM_B_QUOTEDPRICE where (1=1) and SCM_B_QUOTEDPRICE.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_SCM_B_QUOTEDPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUOTEDPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSNAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUOTEDPRICE[] objs = new DisplayObject_SCM_B_QUOTEDPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_SCM_B_QUOTEDPRICE Get(EntityObject_SCM_B_QUOTEDPRICE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  QUOTED_PRICE, COMMENTS, PRODUCT_NAME, ID, CREATE_USER_ID, DISPLAY_INDEX, MODIFY_USER_ID, STATE, DATA_ORGANISE_ID, CREATE_TIME, SUPPLY_AMOUNT, CODE, GYSACCOUNT, GYSNAME, BASE_ID, MODIFY_TIME, CREATE_DEPART_ID, MODIFY_DEPART_ID from SCM_B_QUOTEDPRICE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_QUOTEDPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_QUOTEDPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSNAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SCM_B_QUOTEDPRICE[] objs = new EntityObject_SCM_B_QUOTEDPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_B_QUOTEDPRICE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SCM_B_QUOTEDPRICE.QUOTED_PRICE, SCM_B_QUOTEDPRICE.COMMENTS, SCM_B_QUOTEDPRICE.PRODUCT_NAME, SCM_B_QUOTEDPRICE.ID, SCM_B_QUOTEDPRICE.CREATE_USER_ID, SCM_B_QUOTEDPRICE.DISPLAY_INDEX, SCM_B_QUOTEDPRICE.MODIFY_USER_ID, SCM_B_QUOTEDPRICE.STATE, SCM_B_QUOTEDPRICE.DATA_ORGANISE_ID, SCM_B_QUOTEDPRICE.CREATE_TIME, SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT, SCM_B_QUOTEDPRICE.CODE, SCM_B_QUOTEDPRICE.GYSACCOUNT, SCM_B_QUOTEDPRICE.GYSNAME, SCM_B_QUOTEDPRICE.BASE_ID, SCM_B_QUOTEDPRICE.MODIFY_TIME, SCM_B_QUOTEDPRICE.CREATE_DEPART_ID, SCM_B_QUOTEDPRICE.MODIFY_DEPART_ID, (case  when SCM_B_QUOTEDPRICE.STATE = 0 then '默认值' when SCM_B_QUOTEDPRICE.STATE = 1 then '编辑中' when SCM_B_QUOTEDPRICE.STATE = 2 then '已提交' when SCM_B_QUOTEDPRICE.STATE = 3 then '已审核' when SCM_B_QUOTEDPRICE.STATE = 4 then '已归档' when SCM_B_QUOTEDPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME from SCM_B_QUOTEDPRICE where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SCM_B_QUOTEDPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUOTEDPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSNAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUOTEDPRICE[] objs = new DisplayObject_SCM_B_QUOTEDPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SCM_B_QUOTEDPRICE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.QUOTED_PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.QUOTED_PRICE = :C_QUOTED_PRICE");
				param = new OracleParameter();
				param.ParameterName =":C_QUOTED_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.QUOTED_PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUOTED_PRICE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "QUOTED_PRICE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.PRODUCT_NAME))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.PRODUCT_NAME ").Append((cause.PRODUCT_NAME.StartsWith("%") || cause.PRODUCT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_PRODUCT_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_PRODUCT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.PRODUCT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRODUCT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "PRODUCT_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "CREATE_USER_ID"));
			}
			if(cause.DISPLAY_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.DISPLAY_INDEX = :C_DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName =":C_DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("DISPLAY_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "DISPLAY_INDEX"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "MODIFY_USER_ID"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "DATA_ORGANISE_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_B_QUOTEDPRICE.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And SCM_B_QUOTEDPRICE.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "CREATE_TIME"));
			}
			if(cause.SUPPLY_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT = :C_SUPPLY_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_SUPPLY_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.SUPPLY_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("SUPPLY_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "SUPPLY_AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.GYSNAME))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSNAME");
				param = new OracleParameter();
				param.ParameterName =":C_GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.GYSNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSNAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "GYSNAME"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "BASE_ID"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_B_QUOTEDPRICE.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And SCM_B_QUOTEDPRICE.MODIFY_TIME < :C_MODIFY_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("MODIFY_TIME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "CREATE_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE", "MODIFY_DEPART_ID"));
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
		public static DisplayObject_SCM_B_QUOTEDPRICE[] Query(CauseObject_SCM_B_QUOTEDPRICE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_B_QUOTEDPRICE.QUOTED_PRICE, SCM_B_QUOTEDPRICE.COMMENTS, SCM_B_QUOTEDPRICE.PRODUCT_NAME, SCM_B_QUOTEDPRICE.ID, SCM_B_QUOTEDPRICE.CREATE_USER_ID, SCM_B_QUOTEDPRICE.DISPLAY_INDEX, SCM_B_QUOTEDPRICE.MODIFY_USER_ID, SCM_B_QUOTEDPRICE.STATE, SCM_B_QUOTEDPRICE.DATA_ORGANISE_ID, SCM_B_QUOTEDPRICE.CREATE_TIME, SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT, SCM_B_QUOTEDPRICE.CODE, SCM_B_QUOTEDPRICE.GYSACCOUNT, SCM_B_QUOTEDPRICE.GYSNAME, SCM_B_QUOTEDPRICE.BASE_ID, SCM_B_QUOTEDPRICE.MODIFY_TIME, SCM_B_QUOTEDPRICE.CREATE_DEPART_ID, SCM_B_QUOTEDPRICE.MODIFY_DEPART_ID, (case  when SCM_B_QUOTEDPRICE.STATE = 0 then '默认值' when SCM_B_QUOTEDPRICE.STATE = 1 then '编辑中' when SCM_B_QUOTEDPRICE.STATE = 2 then '已提交' when SCM_B_QUOTEDPRICE.STATE = 3 then '已审核' when SCM_B_QUOTEDPRICE.STATE = 4 then '已归档' when SCM_B_QUOTEDPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME from SCM_B_QUOTEDPRICE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_QUOTEDPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUOTEDPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSNAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUOTEDPRICE[] objs = new DisplayObject_SCM_B_QUOTEDPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_SCM_B_QUOTEDPRICE[] Query(CauseObject_SCM_B_QUOTEDPRICE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_B_QUOTEDPRICE.QUOTED_PRICE, SCM_B_QUOTEDPRICE.COMMENTS, SCM_B_QUOTEDPRICE.PRODUCT_NAME, SCM_B_QUOTEDPRICE.ID, SCM_B_QUOTEDPRICE.CREATE_USER_ID, SCM_B_QUOTEDPRICE.DISPLAY_INDEX, SCM_B_QUOTEDPRICE.MODIFY_USER_ID, SCM_B_QUOTEDPRICE.STATE, SCM_B_QUOTEDPRICE.DATA_ORGANISE_ID, SCM_B_QUOTEDPRICE.CREATE_TIME, SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT, SCM_B_QUOTEDPRICE.CODE, SCM_B_QUOTEDPRICE.GYSACCOUNT, SCM_B_QUOTEDPRICE.GYSNAME, SCM_B_QUOTEDPRICE.BASE_ID, SCM_B_QUOTEDPRICE.MODIFY_TIME, SCM_B_QUOTEDPRICE.CREATE_DEPART_ID, SCM_B_QUOTEDPRICE.MODIFY_DEPART_ID, (case  when SCM_B_QUOTEDPRICE.STATE = 0 then '默认值' when SCM_B_QUOTEDPRICE.STATE = 1 then '编辑中' when SCM_B_QUOTEDPRICE.STATE = 2 then '已提交' when SCM_B_QUOTEDPRICE.STATE = 3 then '已审核' when SCM_B_QUOTEDPRICE.STATE = 4 then '已归档' when SCM_B_QUOTEDPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME from SCM_B_QUOTEDPRICE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_QUOTEDPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUOTEDPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSNAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_QUOTEDPRICE[] objs = new DisplayObject_SCM_B_QUOTEDPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_QUOTEDPRICE[] Query(CauseObject_SCM_B_QUOTEDPRICE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_B_QUOTEDPRICE.QUOTED_PRICE, SCM_B_QUOTEDPRICE.COMMENTS, SCM_B_QUOTEDPRICE.PRODUCT_NAME, SCM_B_QUOTEDPRICE.ID, SCM_B_QUOTEDPRICE.CREATE_USER_ID, SCM_B_QUOTEDPRICE.DISPLAY_INDEX, SCM_B_QUOTEDPRICE.MODIFY_USER_ID, SCM_B_QUOTEDPRICE.STATE, SCM_B_QUOTEDPRICE.DATA_ORGANISE_ID, SCM_B_QUOTEDPRICE.CREATE_TIME, SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT, SCM_B_QUOTEDPRICE.CODE, SCM_B_QUOTEDPRICE.GYSACCOUNT, SCM_B_QUOTEDPRICE.GYSNAME, SCM_B_QUOTEDPRICE.BASE_ID, SCM_B_QUOTEDPRICE.MODIFY_TIME, SCM_B_QUOTEDPRICE.CREATE_DEPART_ID, SCM_B_QUOTEDPRICE.MODIFY_DEPART_ID, (case  when SCM_B_QUOTEDPRICE.STATE = 0 then '默认值' when SCM_B_QUOTEDPRICE.STATE = 1 then '编辑中' when SCM_B_QUOTEDPRICE.STATE = 2 then '已提交' when SCM_B_QUOTEDPRICE.STATE = 3 then '已审核' when SCM_B_QUOTEDPRICE.STATE = 4 then '已归档' when SCM_B_QUOTEDPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME from SCM_B_QUOTEDPRICE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_QUOTEDPRICE",paging, order, sSql, parameters, connection);
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
			DisplayObject_SCM_B_QUOTEDPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUOTEDPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSNAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUOTEDPRICE[] objs = new DisplayObject_SCM_B_QUOTEDPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_QUOTEDPRICE[] Query(CauseObject_SCM_B_QUOTEDPRICE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_B_QUOTEDPRICE.QUOTED_PRICE, SCM_B_QUOTEDPRICE.COMMENTS, SCM_B_QUOTEDPRICE.PRODUCT_NAME, SCM_B_QUOTEDPRICE.ID, SCM_B_QUOTEDPRICE.CREATE_USER_ID, SCM_B_QUOTEDPRICE.DISPLAY_INDEX, SCM_B_QUOTEDPRICE.MODIFY_USER_ID, SCM_B_QUOTEDPRICE.STATE, SCM_B_QUOTEDPRICE.DATA_ORGANISE_ID, SCM_B_QUOTEDPRICE.CREATE_TIME, SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT, SCM_B_QUOTEDPRICE.CODE, SCM_B_QUOTEDPRICE.GYSACCOUNT, SCM_B_QUOTEDPRICE.GYSNAME, SCM_B_QUOTEDPRICE.BASE_ID, SCM_B_QUOTEDPRICE.MODIFY_TIME, SCM_B_QUOTEDPRICE.CREATE_DEPART_ID, SCM_B_QUOTEDPRICE.MODIFY_DEPART_ID, (case  when SCM_B_QUOTEDPRICE.STATE = 0 then '默认值' when SCM_B_QUOTEDPRICE.STATE = 1 then '编辑中' when SCM_B_QUOTEDPRICE.STATE = 2 then '已提交' when SCM_B_QUOTEDPRICE.STATE = 3 then '已审核' when SCM_B_QUOTEDPRICE.STATE = 4 then '已归档' when SCM_B_QUOTEDPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME from SCM_B_QUOTEDPRICE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_QUOTEDPRICE",paging, order, sSql, parameters, trans);
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
			DisplayObject_SCM_B_QUOTEDPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUOTEDPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DISPLAY_INDEX = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CODE = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSNAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.BASE_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.STATE_NAME = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_QUOTEDPRICE[] objs = new DisplayObject_SCM_B_QUOTEDPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SCM_B_QUOTEDPRICE obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("QUOTED_PRICE"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.QUOTED_PRICE = :U_QUOTED_PRICE");
				param = new OracleParameter();
				param.ParameterName = ":U_QUOTED_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.QUOTED_PRICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRODUCT_NAME"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.PRODUCT_NAME = :U_PRODUCT_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_PRODUCT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.PRODUCT_NAME) ? string.Empty : obj.PRODUCT_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DISPLAY_INDEX"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.DISPLAY_INDEX = :U_DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName = ":U_DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SUPPLY_AMOUNT"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT = :U_SUPPLY_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_SUPPLY_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.SUPPLY_AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.GYSACCOUNT = :U_GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSNAME"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.GYSNAME = :U_GYSNAME");
				param = new OracleParameter();
				param.ParameterName = ":U_GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.GYSNAME) ? string.Empty : obj.GYSNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE.MODIFY_DEPART_ID = :U_MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			//pk here
			if(appendpk)
			{
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = obj.ID;
				paramList.Add(param);
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		
		#endregion 
	}
}
