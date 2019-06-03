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
	[CauseObject(typeof(CauseObject_SCM_B_QUERYPRICE))]
	public partial class HelperObject_SCM_B_QUERYPRICE
	{		
		#region Method Blok
		public static int Save(EntityObject_SCM_B_QUERYPRICE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
            string sSql = "insert into SCM_B_QUERYPRICE( QUERY_DATE, COMMENTS, QUERY_STATE, SPEC, ID, CREATE_USER_ID, MATNR_ID, END_DATE, AMOUNT, CODE, CREATE_TIME, STATE, DATA_ORGANISE_ID, NAME, CREATE_DEPART_ID, DEPT_ID, MATNR, TXZ01, QUERY_TYPE, MSEHT,ADJUSTPRICE_ID) values ( :QUERY_DATE, :COMMENTS, :QUERY_STATE, :SPEC, :ID, :CREATE_USER_ID, :MATNR_ID, :END_DATE, :AMOUNT, :CODE, :CREATE_TIME, :STATE, :DATA_ORGANISE_ID, :NAME, :CREATE_DEPART_ID, :DEPT_ID, :MATNR, :TXZ01, :QUERY_TYPE, :MSEHT,:ADJUSTPRICE_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[21];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":QUERY_DATE";
			parameters[0].Size = 7;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[0].Value = obj.QUERY_DATE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":COMMENTS";
			parameters[1].Size = 300;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":QUERY_STATE";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.QUERY_STATE == null ? String.Empty:obj.QUERY_STATE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":SPEC";
			parameters[3].Size = 100;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":CREATE_USER_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.CREATE_USER_ID == null ? String.Empty:obj.CREATE_USER_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":MATNR_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.MATNR_ID == null ? String.Empty:obj.MATNR_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":END_DATE";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.END_DATE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":AMOUNT";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.AMOUNT;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":CODE";
			parameters[9].Size = 12;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[9].Value = obj.CODE == null ? String.Empty:obj.CODE;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":CREATE_TIME";
			parameters[10].Size = 7;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[10].Value = obj.CREATE_TIME;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":STATE";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.STATE;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":DATA_ORGANISE_ID";
			parameters[12].Size = 36;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.DATA_ORGANISE_ID == null ? String.Empty:obj.DATA_ORGANISE_ID;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":NAME";
			parameters[13].Size = 50;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.NAME == null ? String.Empty:obj.NAME;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":CREATE_DEPART_ID";
			parameters[14].Size = 36;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[14].Value = obj.CREATE_DEPART_ID == null ? String.Empty:obj.CREATE_DEPART_ID;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":DEPT_ID";
			parameters[15].Size = 36;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[15].Value = obj.DEPT_ID == null ? String.Empty:obj.DEPT_ID;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":MATNR";
			parameters[16].Size = 50;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[16].Value = obj.MATNR == null ? String.Empty:obj.MATNR;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":TXZ01";
			parameters[17].Size = 200;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[17].Value = obj.TXZ01 == null ? String.Empty:obj.TXZ01;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":QUERY_TYPE";
			parameters[18].Size = 36;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[18].Value = obj.QUERY_TYPE == null ? String.Empty:obj.QUERY_TYPE;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":MSEHT";
			parameters[19].Size = 10;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[19].Value = obj.MSEHT == null ? String.Empty:obj.MSEHT;
            parameters[20] = new OracleParameter();
            parameters[20].ParameterName = ":ADJUSTPRICE_ID";
            parameters[20].Size = 36;
            parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[20].Value = obj.ADJUSTPRICE_ID == null ? String.Empty : obj.ADJUSTPRICE_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SCM_B_QUERYPRICE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_B_QUERYPRICE set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SCM_B_QUERYPRICE obj,CauseObject_SCM_B_QUERYPRICE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_B_QUERYPRICE set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SCM_B_QUERYPRICE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SCM_B_QUERYPRICE where  ID = :ID ";
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
		public static int Delete(CauseObject_SCM_B_QUERYPRICE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SCM_B_QUERYPRICE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_SCM_B_QUERYPRICE Get(EntityObject_SCM_B_QUERYPRICE obj)
		{
			
			//平台自动生成代码
            string sSql = "select  QUERY_DATE, COMMENTS, QUERY_STATE, SPEC, ID, CREATE_USER_ID, MODIFY_USER_ID, MATNR_ID, END_DATE, AMOUNT, CODE, CREATE_TIME, STATE, DATA_ORGANISE_ID, NAME, CREATE_DEPART_ID, DEPT_ID, MATNR, TXZ01, MODIFY_TIME, QUERY_TYPE, MSEHT, MODIFY_DEPART_ID,ADJUSTPRICE_ID from SCM_B_QUERYPRICE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_QUERYPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_QUERYPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MATNR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MATNR = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.TXZ01 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.ADJUSTPRICE_ID = sqlReader.GetString(23);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SCM_B_QUERYPRICE[] objs = new EntityObject_SCM_B_QUERYPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_B_QUERYPRICE Get(DisplayObject_SCM_B_QUERYPRICE obj)
		{
			
			//平台自动生成代码
            string sSql = " select  SCM_B_QUERYPRICE.QUERY_DATE, SCM_B_QUERYPRICE.COMMENTS, SCM_B_QUERYPRICE.QUERY_STATE, SCM_B_QUERYPRICE.SPEC, SCM_B_QUERYPRICE.ID, SCM_B_QUERYPRICE.CREATE_USER_ID, SCM_B_QUERYPRICE.MODIFY_USER_ID, SCM_B_QUERYPRICE.MATNR_ID, SCM_B_QUERYPRICE.END_DATE, SCM_B_QUERYPRICE.AMOUNT, SCM_B_QUERYPRICE.CODE, SCM_B_QUERYPRICE.CREATE_TIME, SCM_B_QUERYPRICE.STATE, SCM_B_QUERYPRICE.DATA_ORGANISE_ID, SCM_B_QUERYPRICE.NAME, SCM_B_QUERYPRICE.CREATE_DEPART_ID, SCM_B_QUERYPRICE.DEPT_ID, SCM_B_QUERYPRICE.MATNR, SCM_B_QUERYPRICE.TXZ01, SCM_B_QUERYPRICE.MODIFY_TIME, SCM_B_QUERYPRICE.QUERY_TYPE, SCM_B_QUERYPRICE.MSEHT, SCM_B_QUERYPRICE.MODIFY_DEPART_ID, COM_TYPE_QUERY_STATE.NAME as QUERY_STATE_NAME, (case  when SCM_B_QUERYPRICE.STATE = 0 then '默认值' when SCM_B_QUERYPRICE.STATE = 1 then '编辑中' when SCM_B_QUERYPRICE.STATE = 2 then '已提交' when SCM_B_QUERYPRICE.STATE = 3 then '已审核' when SCM_B_QUERYPRICE.STATE = 4 then '已归档' when SCM_B_QUERYPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, COM_TYPE_QUERY_TYPE.NAME as QUERY_TYPE_NAME, SCM_B_QUERYPRICE.ADJUSTPRICE_ID from SCM_B_QUERYPRICE left join COM_TYPE   COM_TYPE_QUERY_STATE on SCM_B_QUERYPRICE.QUERY_STATE = COM_TYPE_QUERY_STATE.ID left join COM_DEPART   COM_DEPART_DEPT_ID on SCM_B_QUERYPRICE.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_QUERY_TYPE on SCM_B_QUERYPRICE.QUERY_TYPE = COM_TYPE_QUERY_TYPE.ID where (1=1) and SCM_B_QUERYPRICE.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_SCM_B_QUERYPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MATNR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MATNR = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.TXZ01 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.ADJUSTPRICE_ID = sqlReader.GetString(27);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE[] objs = new DisplayObject_SCM_B_QUERYPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_SCM_B_QUERYPRICE Get(EntityObject_SCM_B_QUERYPRICE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
            string sSql = "select  QUERY_DATE, COMMENTS, QUERY_STATE, SPEC, ID, CREATE_USER_ID, MODIFY_USER_ID, MATNR_ID, END_DATE, AMOUNT, CODE, CREATE_TIME, STATE, DATA_ORGANISE_ID, NAME, CREATE_DEPART_ID, DEPT_ID, MATNR, TXZ01, MODIFY_TIME, QUERY_TYPE, MSEHT, MODIFY_DEPART_ID,ADJUSTPRICE_ID from SCM_B_QUERYPRICE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_QUERYPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_QUERYPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MATNR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MATNR = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.TXZ01 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.ADJUSTPRICE_ID = sqlReader.GetString(23);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SCM_B_QUERYPRICE[] objs = new EntityObject_SCM_B_QUERYPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_B_QUERYPRICE[] List()
		{
			
			//平台自动生成代码
            string sSql = " select  SCM_B_QUERYPRICE.QUERY_DATE, SCM_B_QUERYPRICE.COMMENTS, SCM_B_QUERYPRICE.QUERY_STATE, SCM_B_QUERYPRICE.SPEC, SCM_B_QUERYPRICE.ID, SCM_B_QUERYPRICE.CREATE_USER_ID, SCM_B_QUERYPRICE.MODIFY_USER_ID, SCM_B_QUERYPRICE.MATNR_ID, SCM_B_QUERYPRICE.END_DATE, SCM_B_QUERYPRICE.AMOUNT, SCM_B_QUERYPRICE.CODE, SCM_B_QUERYPRICE.CREATE_TIME, SCM_B_QUERYPRICE.STATE, SCM_B_QUERYPRICE.DATA_ORGANISE_ID, SCM_B_QUERYPRICE.NAME, SCM_B_QUERYPRICE.CREATE_DEPART_ID, SCM_B_QUERYPRICE.DEPT_ID, SCM_B_QUERYPRICE.MATNR, SCM_B_QUERYPRICE.TXZ01, SCM_B_QUERYPRICE.MODIFY_TIME, SCM_B_QUERYPRICE.QUERY_TYPE, SCM_B_QUERYPRICE.MSEHT, SCM_B_QUERYPRICE.MODIFY_DEPART_ID, COM_TYPE_QUERY_STATE.NAME as QUERY_STATE_NAME, (case  when SCM_B_QUERYPRICE.STATE = 0 then '默认值' when SCM_B_QUERYPRICE.STATE = 1 then '编辑中' when SCM_B_QUERYPRICE.STATE = 2 then '已提交' when SCM_B_QUERYPRICE.STATE = 3 then '已审核' when SCM_B_QUERYPRICE.STATE = 4 then '已归档' when SCM_B_QUERYPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, COM_TYPE_QUERY_TYPE.NAME as QUERY_TYPE_NAME,SCM_B_QUERYPRICE.ADJUSTPRICE_ID from SCM_B_QUERYPRICE left join COM_TYPE   COM_TYPE_QUERY_STATE on SCM_B_QUERYPRICE.QUERY_STATE = COM_TYPE_QUERY_STATE.ID left join COM_DEPART   COM_DEPART_DEPT_ID on SCM_B_QUERYPRICE.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_QUERY_TYPE on SCM_B_QUERYPRICE.QUERY_TYPE = COM_TYPE_QUERY_TYPE.ID where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SCM_B_QUERYPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MATNR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MATNR = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.TXZ01 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);

                if (!sqlReader.IsDBNull(27))
                    dataObj.ADJUSTPRICE_ID = sqlReader.GetString(27);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE[] objs = new DisplayObject_SCM_B_QUERYPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SCM_B_QUERYPRICE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.QUERY_DATE!= null)
			{
				if (cause.QUERY_DATE.Begin != null)
				{
					strBuf.Append(" And SCM_B_QUERYPRICE.QUERY_DATE >= :C_QUERY_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_QUERY_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.QUERY_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.QUERY_DATE.End != null)
				{
					strBuf.Append(" And SCM_B_QUERYPRICE.QUERY_DATE < :C_QUERY_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_QUERY_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.QUERY_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("QUERY_DATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "QUERY_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.QUERY_STATE))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.QUERY_STATE ").Append((cause.QUERY_STATE.StartsWith("%") || cause.QUERY_STATE.EndsWith("%")) ? " like " : " = ").Append(" :C_QUERY_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_QUERY_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.QUERY_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUERY_STATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "QUERY_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_USER_ID))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "CREATE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR_ID))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.MATNR_ID ").Append((cause.MATNR_ID.StartsWith("%") || cause.MATNR_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MATNR_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MATNR_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MATNR_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "MATNR_ID"));
			}
			if(cause.END_DATE!= null)
			{
				if (cause.END_DATE.Begin != null)
				{
					strBuf.Append(" And SCM_B_QUERYPRICE.END_DATE >= :C_END_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_END_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.END_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.END_DATE.End != null)
				{
					strBuf.Append(" And SCM_B_QUERYPRICE.END_DATE < :C_END_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_END_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.END_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("END_DATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "END_DATE"));
			}
			if(cause.AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.AMOUNT = :C_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "CODE"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_B_QUERYPRICE.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And SCM_B_QUERYPRICE.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "CREATE_TIME"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_ORGANISE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "DATA_ORGANISE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "NAME"));
			}
			if(!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_CREATE_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":C_CREATE_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.CREATE_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("CREATE_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "CREATE_DEPART_ID"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_ID))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.DEPT_ID ").Append((cause.DEPT_ID.StartsWith("%") || cause.DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_ID;
				paramList.Add(param);
			}
            if (cause.HasINValue("ADJUSTPRICE_ID"))
			{
                strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "ADJUSTPRICE_ID"));
			}

            if (!string.IsNullOrEmpty(cause.ADJUSTPRICE_ID))
            {
                strBuf.Append(" And SCM_B_QUERYPRICE.ADJUSTPRICE_ID ").Append((cause.ADJUSTPRICE_ID.StartsWith("%") || cause.ADJUSTPRICE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ADJUSTPRICE_ID");
                param = new OracleParameter();
                param.ParameterName = ":C_ADJUSTPRICE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.ADJUSTPRICE_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("DEPT_ID"))
            {
                strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "DEPT_ID"));
            }

			if(!string.IsNullOrEmpty(cause.MATNR))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :C_MATNR");
				param = new OracleParameter();
				param.ParameterName =":C_MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MATNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "MATNR"));
			}
			if(!string.IsNullOrEmpty(cause.TXZ01))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :C_TXZ01");
				param = new OracleParameter();
				param.ParameterName =":C_TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.TXZ01;
				paramList.Add(param);
			}
			if (cause.HasINValue("TXZ01"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "TXZ01"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And SCM_B_QUERYPRICE.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And SCM_B_QUERYPRICE.MODIFY_TIME < :C_MODIFY_TIME_END");
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
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.QUERY_TYPE))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.QUERY_TYPE ").Append((cause.QUERY_TYPE.StartsWith("%") || cause.QUERY_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :C_QUERY_TYPE");
				param = new OracleParameter();
				param.ParameterName =":C_QUERY_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.QUERY_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUERY_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "QUERY_TYPE"));
			}
			if(!string.IsNullOrEmpty(cause.MSEHT))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.MSEHT ").Append((cause.MSEHT.StartsWith("%") || cause.MSEHT.EndsWith("%")) ? " like " : " = ").Append(" :C_MSEHT");
				param = new OracleParameter();
				param.ParameterName =":C_MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.MSEHT;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSEHT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "MSEHT"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_DEPART_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_DEPART_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_DEPART_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_DEPART_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE", "MODIFY_DEPART_ID"));
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
		public static DisplayObject_SCM_B_QUERYPRICE[] Query(CauseObject_SCM_B_QUERYPRICE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_B_QUERYPRICE.QUERY_DATE, SCM_B_QUERYPRICE.COMMENTS, SCM_B_QUERYPRICE.QUERY_STATE, SCM_B_QUERYPRICE.SPEC, SCM_B_QUERYPRICE.ID, SCM_B_QUERYPRICE.CREATE_USER_ID, SCM_B_QUERYPRICE.MODIFY_USER_ID, SCM_B_QUERYPRICE.MATNR_ID, SCM_B_QUERYPRICE.END_DATE, SCM_B_QUERYPRICE.AMOUNT, SCM_B_QUERYPRICE.CODE, SCM_B_QUERYPRICE.CREATE_TIME, SCM_B_QUERYPRICE.STATE, SCM_B_QUERYPRICE.DATA_ORGANISE_ID, SCM_B_QUERYPRICE.NAME, SCM_B_QUERYPRICE.CREATE_DEPART_ID, SCM_B_QUERYPRICE.DEPT_ID, SCM_B_QUERYPRICE.MATNR, SCM_B_QUERYPRICE.TXZ01, SCM_B_QUERYPRICE.MODIFY_TIME, SCM_B_QUERYPRICE.QUERY_TYPE, SCM_B_QUERYPRICE.MSEHT, SCM_B_QUERYPRICE.MODIFY_DEPART_ID, COM_TYPE_QUERY_STATE.NAME as QUERY_STATE_NAME, (case  when SCM_B_QUERYPRICE.STATE = 0 then '默认值' when SCM_B_QUERYPRICE.STATE = 1 then '编辑中' when SCM_B_QUERYPRICE.STATE = 2 then '已提交' when SCM_B_QUERYPRICE.STATE = 3 then '已审核' when SCM_B_QUERYPRICE.STATE = 4 then '已归档' when SCM_B_QUERYPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, COM_TYPE_QUERY_TYPE.NAME as QUERY_TYPE_NAME from SCM_B_QUERYPRICE left join COM_TYPE   COM_TYPE_QUERY_STATE on SCM_B_QUERYPRICE.QUERY_STATE = COM_TYPE_QUERY_STATE.ID left join COM_DEPART   COM_DEPART_DEPT_ID on SCM_B_QUERYPRICE.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_QUERY_TYPE on SCM_B_QUERYPRICE.QUERY_TYPE = COM_TYPE_QUERY_TYPE.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_QUERYPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MATNR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MATNR = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.TXZ01 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE[] objs = new DisplayObject_SCM_B_QUERYPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_SCM_B_QUERYPRICE[] Query(CauseObject_SCM_B_QUERYPRICE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
            string sSql = " select  SCM_B_QUERYPRICE.QUERY_DATE, SCM_B_QUERYPRICE.COMMENTS, SCM_B_QUERYPRICE.QUERY_STATE, SCM_B_QUERYPRICE.SPEC, SCM_B_QUERYPRICE.ID, SCM_B_QUERYPRICE.CREATE_USER_ID, SCM_B_QUERYPRICE.MODIFY_USER_ID, SCM_B_QUERYPRICE.MATNR_ID, SCM_B_QUERYPRICE.END_DATE, SCM_B_QUERYPRICE.AMOUNT, SCM_B_QUERYPRICE.CODE, SCM_B_QUERYPRICE.CREATE_TIME, SCM_B_QUERYPRICE.STATE, SCM_B_QUERYPRICE.DATA_ORGANISE_ID, SCM_B_QUERYPRICE.NAME, SCM_B_QUERYPRICE.CREATE_DEPART_ID, SCM_B_QUERYPRICE.DEPT_ID, SCM_B_QUERYPRICE.MATNR, SCM_B_QUERYPRICE.TXZ01, SCM_B_QUERYPRICE.MODIFY_TIME, SCM_B_QUERYPRICE.QUERY_TYPE, SCM_B_QUERYPRICE.MSEHT, SCM_B_QUERYPRICE.MODIFY_DEPART_ID, COM_TYPE_QUERY_STATE.NAME as QUERY_STATE_NAME, (case  when SCM_B_QUERYPRICE.STATE = 0 then '默认值' when SCM_B_QUERYPRICE.STATE = 1 then '编辑中' when SCM_B_QUERYPRICE.STATE = 2 then '已提交' when SCM_B_QUERYPRICE.STATE = 3 then '已审核' when SCM_B_QUERYPRICE.STATE = 4 then '已归档' when SCM_B_QUERYPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, COM_TYPE_QUERY_TYPE.NAME as QUERY_TYPE_NAME,SCM_B_QUERYPRICE.ADJUSTPRICE_ID from SCM_B_QUERYPRICE left join COM_TYPE   COM_TYPE_QUERY_STATE on SCM_B_QUERYPRICE.QUERY_STATE = COM_TYPE_QUERY_STATE.ID left join COM_DEPART   COM_DEPART_DEPT_ID on SCM_B_QUERYPRICE.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_QUERY_TYPE on SCM_B_QUERYPRICE.QUERY_TYPE = COM_TYPE_QUERY_TYPE.ID where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_QUERYPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MATNR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MATNR = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.TXZ01 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.ADJUSTPRICE_ID = sqlReader.GetString(27);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE[] objs = new DisplayObject_SCM_B_QUERYPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_QUERYPRICE[] Query(CauseObject_SCM_B_QUERYPRICE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
            string sSql = " select  SCM_B_QUERYPRICE.QUERY_DATE, SCM_B_QUERYPRICE.COMMENTS, SCM_B_QUERYPRICE.QUERY_STATE, SCM_B_QUERYPRICE.SPEC, SCM_B_QUERYPRICE.ID, SCM_B_QUERYPRICE.CREATE_USER_ID, SCM_B_QUERYPRICE.MODIFY_USER_ID, SCM_B_QUERYPRICE.MATNR_ID, SCM_B_QUERYPRICE.END_DATE, SCM_B_QUERYPRICE.AMOUNT, SCM_B_QUERYPRICE.CODE, SCM_B_QUERYPRICE.CREATE_TIME, SCM_B_QUERYPRICE.STATE, SCM_B_QUERYPRICE.DATA_ORGANISE_ID, SCM_B_QUERYPRICE.NAME, SCM_B_QUERYPRICE.CREATE_DEPART_ID, SCM_B_QUERYPRICE.DEPT_ID, SCM_B_QUERYPRICE.MATNR, SCM_B_QUERYPRICE.TXZ01, SCM_B_QUERYPRICE.MODIFY_TIME, SCM_B_QUERYPRICE.QUERY_TYPE, SCM_B_QUERYPRICE.MSEHT, SCM_B_QUERYPRICE.MODIFY_DEPART_ID, COM_TYPE_QUERY_STATE.NAME as QUERY_STATE_NAME, (case  when SCM_B_QUERYPRICE.STATE = 0 then '默认值' when SCM_B_QUERYPRICE.STATE = 1 then '编辑中' when SCM_B_QUERYPRICE.STATE = 2 then '已提交' when SCM_B_QUERYPRICE.STATE = 3 then '已审核' when SCM_B_QUERYPRICE.STATE = 4 then '已归档' when SCM_B_QUERYPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, COM_TYPE_QUERY_TYPE.NAME as QUERY_TYPE_NAME,SCM_B_QUERYPRICE.ADJUSTPRICE_ID from SCM_B_QUERYPRICE left join COM_TYPE   COM_TYPE_QUERY_STATE on SCM_B_QUERYPRICE.QUERY_STATE = COM_TYPE_QUERY_STATE.ID left join COM_DEPART   COM_DEPART_DEPT_ID on SCM_B_QUERYPRICE.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_QUERY_TYPE on SCM_B_QUERYPRICE.QUERY_TYPE = COM_TYPE_QUERY_TYPE.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_QUERYPRICE",paging, order, sSql, parameters, connection);
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
			DisplayObject_SCM_B_QUERYPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MATNR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MATNR = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.TXZ01 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.ADJUSTPRICE_ID = sqlReader.GetString(27);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE[] objs = new DisplayObject_SCM_B_QUERYPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_QUERYPRICE[] Query(CauseObject_SCM_B_QUERYPRICE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
            string sSql = " select  SCM_B_QUERYPRICE.QUERY_DATE, SCM_B_QUERYPRICE.COMMENTS, SCM_B_QUERYPRICE.QUERY_STATE, SCM_B_QUERYPRICE.SPEC, SCM_B_QUERYPRICE.ID, SCM_B_QUERYPRICE.CREATE_USER_ID, SCM_B_QUERYPRICE.MODIFY_USER_ID, SCM_B_QUERYPRICE.MATNR_ID, SCM_B_QUERYPRICE.END_DATE, SCM_B_QUERYPRICE.AMOUNT, SCM_B_QUERYPRICE.CODE, SCM_B_QUERYPRICE.CREATE_TIME, SCM_B_QUERYPRICE.STATE, SCM_B_QUERYPRICE.DATA_ORGANISE_ID, SCM_B_QUERYPRICE.NAME, SCM_B_QUERYPRICE.CREATE_DEPART_ID, SCM_B_QUERYPRICE.DEPT_ID, SCM_B_QUERYPRICE.MATNR, SCM_B_QUERYPRICE.TXZ01, SCM_B_QUERYPRICE.MODIFY_TIME, SCM_B_QUERYPRICE.QUERY_TYPE, SCM_B_QUERYPRICE.MSEHT, SCM_B_QUERYPRICE.MODIFY_DEPART_ID, COM_TYPE_QUERY_STATE.NAME as QUERY_STATE_NAME, (case  when SCM_B_QUERYPRICE.STATE = 0 then '默认值' when SCM_B_QUERYPRICE.STATE = 1 then '编辑中' when SCM_B_QUERYPRICE.STATE = 2 then '已提交' when SCM_B_QUERYPRICE.STATE = 3 then '已审核' when SCM_B_QUERYPRICE.STATE = 4 then '已归档' when SCM_B_QUERYPRICE.STATE = 9 then '已作废' else '' end ) as STATE_NAME, COM_DEPART_DEPT_ID.NAME as DEPT_ID_NAME, COM_TYPE_QUERY_TYPE.NAME as QUERY_TYPE_NAME ,SCM_B_QUERYPRICE.ADJUSTPRICE_ID from SCM_B_QUERYPRICE left join COM_TYPE   COM_TYPE_QUERY_STATE on SCM_B_QUERYPRICE.QUERY_STATE = COM_TYPE_QUERY_STATE.ID left join COM_DEPART   COM_DEPART_DEPT_ID on SCM_B_QUERYPRICE.DEPT_ID = COM_DEPART_DEPT_ID.ID left join COM_TYPE   COM_TYPE_QUERY_TYPE on SCM_B_QUERYPRICE.QUERY_TYPE = COM_TYPE_QUERY_TYPE.ID where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_QUERYPRICE",paging, order, sSql, parameters, trans);
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
			DisplayObject_SCM_B_QUERYPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.COMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.QUERY_STATE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SPEC = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CREATE_USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MATNR_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.CODE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.STATE = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.DATA_ORGANISE_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.CREATE_DEPART_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.DEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.MATNR = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.TXZ01 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.MSEHT = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MODIFY_DEPART_ID = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.STATE_NAME = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.ADJUSTPRICE_ID = sqlReader.GetString(27);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE[] objs = new DisplayObject_SCM_B_QUERYPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SCM_B_QUERYPRICE obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("QUERY_DATE"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.QUERY_DATE = :U_QUERY_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_QUERY_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.QUERY_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("QUERY_STATE"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.QUERY_STATE = :U_QUERY_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_QUERY_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.QUERY_STATE) ? string.Empty : obj.QUERY_STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.SPEC = :U_SPEC");
				param = new OracleParameter();
				param.ParameterName = ":U_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
            if (!obj.IsNotUpdate("ADJUSTPRICE_ID"))
            {
                strBuf.Add("  SCM_B_QUERYPRICE.ADJUSTPRICE_ID = :U_ADJUSTPRICE_ID");
                param = new OracleParameter();
                param.ParameterName = ":U_ADJUSTPRICE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.ADJUSTPRICE_ID) ? string.Empty : obj.ADJUSTPRICE_ID;
                paramList.Add(param);
            }
			if (!obj.IsNotUpdate("MATNR_ID"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.MATNR_ID = :U_MATNR_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MATNR_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MATNR_ID) ? string.Empty : obj.MATNR_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("END_DATE"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.END_DATE = :U_END_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_END_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.END_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AMOUNT"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.AMOUNT = :U_AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AMOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CODE"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.CODE = :U_CODE");
				param = new OracleParameter();
				param.ParameterName = ":U_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.STATE = :U_STATE");
				param = new OracleParameter();
				param.ParameterName = ":U_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.DATA_ORGANISE_ID = :U_DATA_ORGANISE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_ORGANISE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NAME"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.NAME = :U_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_ID"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.DEPT_ID = :U_DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_ID) ? string.Empty : obj.DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATNR"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.MATNR = :U_MATNR");
				param = new OracleParameter();
				param.ParameterName = ":U_MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MATNR) ? string.Empty : obj.MATNR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TXZ01"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.TXZ01 = :U_TXZ01");
				param = new OracleParameter();
				param.ParameterName = ":U_TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.TXZ01) ? string.Empty : obj.TXZ01;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("QUERY_TYPE"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.QUERY_TYPE = :U_QUERY_TYPE");
				param = new OracleParameter();
				param.ParameterName = ":U_QUERY_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.QUERY_TYPE) ? string.Empty : obj.QUERY_TYPE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MSEHT"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.MSEHT = :U_MSEHT");
				param = new OracleParameter();
				param.ParameterName = ":U_MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.MSEHT) ? string.Empty : obj.MSEHT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE.MODIFY_DEPART_ID = :U_MODIFY_DEPART_ID");
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
