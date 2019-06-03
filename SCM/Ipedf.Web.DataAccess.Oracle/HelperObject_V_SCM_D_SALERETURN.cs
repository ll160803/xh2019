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
	[CauseObject(typeof(CauseObject_V_SCM_D_SALERETURN))]
	public partial class HelperObject_V_SCM_D_SALERETURN
	{		
		#region Method Blok
		public static int Save(EntityObject_V_SCM_D_SALERETURN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into V_SCM_D_SALERETURN( SPELL_CODE, SPEC, ID, DEPT_ID, CHARG, STATE, TXZ01, GYSNAME, PRODUCE_AREA, GYSACCOUNT, COMMENTS, DEPT_ID_NAME, MATNR, AMOUNT) values ( :SPELL_CODE, :SPEC, :ID, :DEPT_ID, :CHARG, :STATE, :TXZ01, :GYSNAME, :PRODUCE_AREA, :GYSACCOUNT, :COMMENTS, :DEPT_ID_NAME, :MATNR, :AMOUNT)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[14];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":SPELL_CODE";
			parameters[0].Size = 20;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.SPELL_CODE == null ? String.Empty:obj.SPELL_CODE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":SPEC";
			parameters[1].Size = 200;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.SPEC == null ? String.Empty:obj.SPEC;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":DEPT_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.DEPT_ID == null ? String.Empty:obj.DEPT_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":CHARG";
			parameters[4].Size = 20;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.CHARG == null ? String.Empty:obj.CHARG;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":STATE";
			parameters[5].Size = 22;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[5].Value = obj.STATE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":TXZ01";
			parameters[6].Size = 200;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.TXZ01 == null ? String.Empty:obj.TXZ01;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":GYSNAME";
			parameters[7].Size = 50;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.GYSNAME == null ? String.Empty:obj.GYSNAME;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":PRODUCE_AREA";
			parameters[8].Size = 200;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.PRODUCE_AREA == null ? String.Empty:obj.PRODUCE_AREA;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":GYSACCOUNT";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.GYSACCOUNT == null ? String.Empty:obj.GYSACCOUNT;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":COMMENTS";
			parameters[10].Size = 1000;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":DEPT_ID_NAME";
			parameters[11].Size = 50;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.DEPT_ID_NAME == null ? String.Empty:obj.DEPT_ID_NAME;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":MATNR";
			parameters[12].Size = 20;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[12].Value = obj.MATNR == null ? String.Empty:obj.MATNR;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":AMOUNT";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.AMOUNT;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_V_SCM_D_SALERETURN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update V_SCM_D_SALERETURN set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_V_SCM_D_SALERETURN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from V_SCM_D_SALERETURN where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_V_SCM_D_SALERETURN Get(EntityObject_V_SCM_D_SALERETURN obj)
		{
			
			//平台自动生成代码
			string sSql = "select  SPELL_CODE, SPEC, ID, DEPT_ID, CHARG, STATE, TXZ01, GYSNAME, PRODUCE_AREA, GYSACCOUNT, COMMENTS, DEPT_ID_NAME, MATNR, AMOUNT from V_SCM_D_SALERETURN where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_D_SALERETURN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_D_SALERETURN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CHARG = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TXZ01 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSNAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATNR = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_V_SCM_D_SALERETURN[] objs = new EntityObject_V_SCM_D_SALERETURN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_V_SCM_D_SALERETURN Get(EntityObject_V_SCM_D_SALERETURN obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  SPELL_CODE, SPEC, ID, DEPT_ID, CHARG, STATE, TXZ01, GYSNAME, PRODUCE_AREA, GYSACCOUNT, COMMENTS, DEPT_ID_NAME, MATNR, AMOUNT from V_SCM_D_SALERETURN where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			EntityObject_V_SCM_D_SALERETURN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_V_SCM_D_SALERETURN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CHARG = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TXZ01 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSNAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATNR = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_V_SCM_D_SALERETURN[] objs = new EntityObject_V_SCM_D_SALERETURN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_V_SCM_D_SALERETURN[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_SCM_D_SALERETURN.SPELL_CODE, V_SCM_D_SALERETURN.SPEC, V_SCM_D_SALERETURN.ID, V_SCM_D_SALERETURN.DEPT_ID, V_SCM_D_SALERETURN.CHARG, V_SCM_D_SALERETURN.STATE, V_SCM_D_SALERETURN.TXZ01, V_SCM_D_SALERETURN.GYSNAME, V_SCM_D_SALERETURN.PRODUCE_AREA, V_SCM_D_SALERETURN.GYSACCOUNT, V_SCM_D_SALERETURN.COMMENTS, V_SCM_D_SALERETURN.DEPT_ID_NAME, V_SCM_D_SALERETURN.MATNR, V_SCM_D_SALERETURN.AMOUNT from V_SCM_D_SALERETURN where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_SCM_D_SALERETURN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SALERETURN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CHARG = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TXZ01 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSNAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATNR = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_SALERETURN[] objs = new DisplayObject_V_SCM_D_SALERETURN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_SCM_D_SALERETURN cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.SPELL_CODE))
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.SPELL_CODE ").Append((cause.SPELL_CODE.StartsWith("%") || cause.SPELL_CODE.EndsWith("%")) ? " like " : " = ").Append(" :SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName =":SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.SPELL_CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPELL_CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "SPELL_CODE"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :SPEC");
				param = new OracleParameter();
				param.ParameterName =":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_ID))
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.DEPT_ID ").Append((cause.DEPT_ID.StartsWith("%") || cause.DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :DEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.DEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "DEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.CHARG))
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.CHARG ").Append((cause.CHARG.StartsWith("%") || cause.CHARG.EndsWith("%")) ? " like " : " = ").Append(" :CHARG");
				param = new OracleParameter();
				param.ParameterName =":CHARG";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.CHARG;
				paramList.Add(param);
			}
			if (cause.HasINValue("CHARG"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "CHARG"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName =":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.TXZ01))
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :TXZ01");
				param = new OracleParameter();
				param.ParameterName =":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.TXZ01;
				paramList.Add(param);
			}
			if (cause.HasINValue("TXZ01"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "TXZ01"));
			}
			if(!string.IsNullOrEmpty(cause.GYSNAME))
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :GYSNAME");
				param = new OracleParameter();
				param.ParameterName =":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "GYSNAME"));
			}
			if(!string.IsNullOrEmpty(cause.PRODUCE_AREA))
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.PRODUCE_AREA ").Append((cause.PRODUCE_AREA.StartsWith("%") || cause.PRODUCE_AREA.EndsWith("%")) ? " like " : " = ").Append(" :PRODUCE_AREA");
				param = new OracleParameter();
				param.ParameterName =":PRODUCE_AREA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.PRODUCE_AREA;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRODUCE_AREA"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "PRODUCE_AREA"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.DEPT_ID_NAME))
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.DEPT_ID_NAME ").Append((cause.DEPT_ID_NAME.StartsWith("%") || cause.DEPT_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :DEPT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":DEPT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DEPT_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DEPT_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "DEPT_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR))
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :MATNR");
				param = new OracleParameter();
				param.ParameterName =":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = cause.MATNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "MATNR"));
			}
			if(cause.AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_D_SALERETURN.AMOUNT = :AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_D_SALERETURN", "AMOUNT"));
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
		public static DisplayObject_V_SCM_D_SALERETURN[] Query(CauseObject_V_SCM_D_SALERETURN cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_D_SALERETURN.SPELL_CODE, V_SCM_D_SALERETURN.SPEC, V_SCM_D_SALERETURN.ID, V_SCM_D_SALERETURN.DEPT_ID, V_SCM_D_SALERETURN.CHARG, V_SCM_D_SALERETURN.STATE, V_SCM_D_SALERETURN.TXZ01, V_SCM_D_SALERETURN.GYSNAME, V_SCM_D_SALERETURN.PRODUCE_AREA, V_SCM_D_SALERETURN.GYSACCOUNT, V_SCM_D_SALERETURN.COMMENTS, V_SCM_D_SALERETURN.DEPT_ID_NAME, V_SCM_D_SALERETURN.MATNR, V_SCM_D_SALERETURN.AMOUNT from V_SCM_D_SALERETURN where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_D_SALERETURN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SALERETURN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CHARG = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TXZ01 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSNAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATNR = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_SALERETURN[] objs = new DisplayObject_V_SCM_D_SALERETURN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_V_SCM_D_SALERETURN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from V_SCM_D_SALERETURN where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_V_SCM_D_SALERETURN[] Query(CauseObject_V_SCM_D_SALERETURN cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_D_SALERETURN.SPELL_CODE, V_SCM_D_SALERETURN.SPEC, V_SCM_D_SALERETURN.ID, V_SCM_D_SALERETURN.DEPT_ID, V_SCM_D_SALERETURN.CHARG, V_SCM_D_SALERETURN.STATE, V_SCM_D_SALERETURN.TXZ01, V_SCM_D_SALERETURN.GYSNAME, V_SCM_D_SALERETURN.PRODUCE_AREA, V_SCM_D_SALERETURN.GYSACCOUNT, V_SCM_D_SALERETURN.COMMENTS, V_SCM_D_SALERETURN.DEPT_ID_NAME, V_SCM_D_SALERETURN.MATNR, V_SCM_D_SALERETURN.AMOUNT from V_SCM_D_SALERETURN where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_D_SALERETURN dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SALERETURN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CHARG = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TXZ01 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSNAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATNR = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_D_SALERETURN[] objs = new DisplayObject_V_SCM_D_SALERETURN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_D_SALERETURN[] Query(CauseObject_V_SCM_D_SALERETURN cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_D_SALERETURN.SPELL_CODE, V_SCM_D_SALERETURN.SPEC, V_SCM_D_SALERETURN.ID, V_SCM_D_SALERETURN.DEPT_ID, V_SCM_D_SALERETURN.CHARG, V_SCM_D_SALERETURN.STATE, V_SCM_D_SALERETURN.TXZ01, V_SCM_D_SALERETURN.GYSNAME, V_SCM_D_SALERETURN.PRODUCE_AREA, V_SCM_D_SALERETURN.GYSACCOUNT, V_SCM_D_SALERETURN.COMMENTS, V_SCM_D_SALERETURN.DEPT_ID_NAME, V_SCM_D_SALERETURN.MATNR, V_SCM_D_SALERETURN.AMOUNT from V_SCM_D_SALERETURN where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_D_SALERETURN",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_SCM_D_SALERETURN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SALERETURN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CHARG = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TXZ01 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSNAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATNR = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_D_SALERETURN[] objs = new DisplayObject_V_SCM_D_SALERETURN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_D_SALERETURN[] Query(CauseObject_V_SCM_D_SALERETURN cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_D_SALERETURN.SPELL_CODE, V_SCM_D_SALERETURN.SPEC, V_SCM_D_SALERETURN.ID, V_SCM_D_SALERETURN.DEPT_ID, V_SCM_D_SALERETURN.CHARG, V_SCM_D_SALERETURN.STATE, V_SCM_D_SALERETURN.TXZ01, V_SCM_D_SALERETURN.GYSNAME, V_SCM_D_SALERETURN.PRODUCE_AREA, V_SCM_D_SALERETURN.GYSACCOUNT, V_SCM_D_SALERETURN.COMMENTS, V_SCM_D_SALERETURN.DEPT_ID_NAME, V_SCM_D_SALERETURN.MATNR, V_SCM_D_SALERETURN.AMOUNT from V_SCM_D_SALERETURN where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_D_SALERETURN",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_SCM_D_SALERETURN dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_D_SALERETURN();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SPELL_CODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SPEC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.DEPT_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CHARG = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TXZ01 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GYSNAME = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PRODUCE_AREA = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.COMMENTS = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.DEPT_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MATNR = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_D_SALERETURN[] objs = new DisplayObject_V_SCM_D_SALERETURN[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_V_SCM_D_SALERETURN obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("SPELL_CODE"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.SPELL_CODE = :SPELL_CODE");
				param = new OracleParameter();
				param.ParameterName = ":SPELL_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.SPELL_CODE) ? string.Empty : obj.SPELL_CODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SPEC"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.SPEC = :SPEC");
				param = new OracleParameter();
				param.ParameterName = ":SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.SPEC) ? string.Empty : obj.SPEC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_ID"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.DEPT_ID = :DEPT_ID");
				param = new OracleParameter();
				param.ParameterName = ":DEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.DEPT_ID) ? string.Empty : obj.DEPT_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CHARG"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.CHARG = :CHARG");
				param = new OracleParameter();
				param.ParameterName = ":CHARG";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.CHARG) ? string.Empty : obj.CHARG;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATE"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.STATE = :STATE");
				param = new OracleParameter();
				param.ParameterName = ":STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TXZ01"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.TXZ01 = :TXZ01");
				param = new OracleParameter();
				param.ParameterName = ":TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.TXZ01) ? string.Empty : obj.TXZ01;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSNAME"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.GYSNAME = :GYSNAME");
				param = new OracleParameter();
				param.ParameterName = ":GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYSNAME) ? string.Empty : obj.GYSNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRODUCE_AREA"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.PRODUCE_AREA = :PRODUCE_AREA");
				param = new OracleParameter();
				param.ParameterName = ":PRODUCE_AREA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.PRODUCE_AREA) ? string.Empty : obj.PRODUCE_AREA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.GYSACCOUNT = :GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.COMMENTS = :COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DEPT_ID_NAME"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.DEPT_ID_NAME = :DEPT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName = ":DEPT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.DEPT_ID_NAME) ? string.Empty : obj.DEPT_ID_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MATNR"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.MATNR = :MATNR");
				param = new OracleParameter();
				param.ParameterName = ":MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.MATNR) ? string.Empty : obj.MATNR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("AMOUNT"))
			{
				strBuf.Add("  V_SCM_D_SALERETURN.AMOUNT = :AMOUNT");
				param = new OracleParameter();
				param.ParameterName = ":AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.AMOUNT;
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
