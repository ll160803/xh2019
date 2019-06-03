using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.Entity;
namespace Ipedf.Web.DataAccess
{
	[CauseObject(typeof(CauseObject_V_SCM_B_QUOTEDPRICE))]	
	public partial class HelperObject_V_SCM_B_QUOTEDPRICE
	{		
		#region Method Blok
		public static DisplayObject_V_SCM_B_QUOTEDPRICE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_SCM_B_QUOTEDPRICE.MCODE, V_SCM_B_QUOTEDPRICE.MCOMMENTS, V_SCM_B_QUOTEDPRICE.MNAME, V_SCM_B_QUOTEDPRICE.AMOUNT, V_SCM_B_QUOTEDPRICE.SPEC, V_SCM_B_QUOTEDPRICE.CODE, V_SCM_B_QUOTEDPRICE.STATE_NAME, V_SCM_B_QUOTEDPRICE.CREATE_TIME, V_SCM_B_QUOTEDPRICE.QUOTED_PRICE, V_SCM_B_QUOTEDPRICE.GYSPYM, V_SCM_B_QUOTEDPRICE.MSTATE, V_SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT, V_SCM_B_QUOTEDPRICE.MDEPT_ID_NAME, V_SCM_B_QUOTEDPRICE.GYSLABEL, V_SCM_B_QUOTEDPRICE.STATE, V_SCM_B_QUOTEDPRICE.MSTATE_NAME, V_SCM_B_QUOTEDPRICE.MDEPT_ID, V_SCM_B_QUOTEDPRICE.TXZ01, V_SCM_B_QUOTEDPRICE.QUERY_STATE, V_SCM_B_QUOTEDPRICE.ID, V_SCM_B_QUOTEDPRICE.QUERY_TYPE, V_SCM_B_QUOTEDPRICE.QUERY_TYPE_NAME, V_SCM_B_QUOTEDPRICE.MATNR, V_SCM_B_QUOTEDPRICE.END_DATE, V_SCM_B_QUOTEDPRICE.COMMENTS, V_SCM_B_QUOTEDPRICE.GYSNAME, V_SCM_B_QUOTEDPRICE.MSEHT, V_SCM_B_QUOTEDPRICE.GYSACCOUNT, V_SCM_B_QUOTEDPRICE.PRODUCT_NAME, V_SCM_B_QUOTEDPRICE.MID, V_SCM_B_QUOTEDPRICE.QUERY_DATE, V_SCM_B_QUOTEDPRICE.MATNR_ID, V_SCM_B_QUOTEDPRICE.QUERY_STATE_NAME from V_SCM_B_QUOTEDPRICE where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_SCM_B_QUOTEDPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_QUOTEDPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MCODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MCOMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSPYM = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MSTATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MDEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSLABEL = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MSTATE_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MDEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TXZ01 = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.QUERY_STATE = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MATNR = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.END_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.COMMENTS = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.GYSNAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MSEHT = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.MID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.MATNR_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(32);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_B_QUOTEDPRICE[] objs = new DisplayObject_V_SCM_B_QUOTEDPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_SCM_B_QUOTEDPRICE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.MCODE))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.MCODE ").Append((cause.MCODE.StartsWith("%") || cause.MCODE.EndsWith("%")) ? " like " : " = ").Append(" :C_MCODE");
				param = new OracleParameter();
				param.ParameterName =":C_MCODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = cause.MCODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MCODE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "MCODE"));
			}
			if(!string.IsNullOrEmpty(cause.MCOMMENTS))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.MCOMMENTS ").Append((cause.MCOMMENTS.StartsWith("%") || cause.MCOMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_MCOMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_MCOMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.MCOMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("MCOMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "MCOMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.MNAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.MNAME ").Append((cause.MNAME.StartsWith("%") || cause.MNAME.EndsWith("%")) ? " like " : " = ").Append(" :C_MNAME");
				param = new OracleParameter();
				param.ParameterName =":C_MNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("MNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "MNAME"));
			}
			if(cause.AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.AMOUNT = :C_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.SPEC))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.SPEC ").Append((cause.SPEC.StartsWith("%") || cause.SPEC.EndsWith("%")) ? " like " : " = ").Append(" :C_SPEC");
				param = new OracleParameter();
				param.ParameterName =":C_SPEC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.SPEC;
				paramList.Add(param);
			}
			if (cause.HasINValue("SPEC"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "SPEC"));
			}
			if(!string.IsNullOrEmpty(cause.CODE))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :C_CODE");
				param = new OracleParameter();
				param.ParameterName =":C_CODE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 12;
				param.Value = cause.CODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("CODE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "CODE"));
			}
			if(!string.IsNullOrEmpty(cause.STATE_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.STATE_NAME ").Append((cause.STATE_NAME.StartsWith("%") || cause.STATE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_STATE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = cause.STATE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "STATE_NAME"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And V_SCM_B_QUOTEDPRICE.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And V_SCM_B_QUOTEDPRICE.CREATE_TIME < :C_CREATE_TIME_END");
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
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "CREATE_TIME"));
			}
			if(cause.QUOTED_PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.QUOTED_PRICE = :C_QUOTED_PRICE");
				param = new OracleParameter();
				param.ParameterName =":C_QUOTED_PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.QUOTED_PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUOTED_PRICE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "QUOTED_PRICE"));
			}
			if(!string.IsNullOrEmpty(cause.GYSPYM))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.GYSPYM ").Append((cause.GYSPYM.StartsWith("%") || cause.GYSPYM.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSPYM");
				param = new OracleParameter();
				param.ParameterName =":C_GYSPYM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.GYSPYM;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSPYM"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "GYSPYM"));
			}
			if(cause.MSTATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.MSTATE = :C_MSTATE");
				param = new OracleParameter();
				param.ParameterName =":C_MSTATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MSTATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSTATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "MSTATE"));
			}
			if(cause.SUPPLY_AMOUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT = :C_SUPPLY_AMOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_SUPPLY_AMOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.SUPPLY_AMOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("SUPPLY_AMOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "SUPPLY_AMOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.MDEPT_ID_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.MDEPT_ID_NAME ").Append((cause.MDEPT_ID_NAME.StartsWith("%") || cause.MDEPT_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_MDEPT_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_MDEPT_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MDEPT_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("MDEPT_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "MDEPT_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.GYSLABEL))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.GYSLABEL ").Append((cause.GYSLABEL.StartsWith("%") || cause.GYSLABEL.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSLABEL");
				param = new OracleParameter();
				param.ParameterName =":C_GYSLABEL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.GYSLABEL;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSLABEL"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "GYSLABEL"));
			}
			if(cause.STATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.STATE = :C_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "STATE"));
			}
			if(!string.IsNullOrEmpty(cause.MSTATE_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.MSTATE_NAME ").Append((cause.MSTATE_NAME.StartsWith("%") || cause.MSTATE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_MSTATE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_MSTATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = cause.MSTATE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSTATE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "MSTATE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.MDEPT_ID))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.MDEPT_ID ").Append((cause.MDEPT_ID.StartsWith("%") || cause.MDEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MDEPT_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MDEPT_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MDEPT_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MDEPT_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "MDEPT_ID"));
			}
			if(!string.IsNullOrEmpty(cause.TXZ01))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :C_TXZ01");
				param = new OracleParameter();
				param.ParameterName =":C_TXZ01";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.TXZ01;
				paramList.Add(param);
			}
			if (cause.HasINValue("TXZ01"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "TXZ01"));
			}
			if(!string.IsNullOrEmpty(cause.QUERY_STATE))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.QUERY_STATE ").Append((cause.QUERY_STATE.StartsWith("%") || cause.QUERY_STATE.EndsWith("%")) ? " like " : " = ").Append(" :C_QUERY_STATE");
				param = new OracleParameter();
				param.ParameterName =":C_QUERY_STATE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.QUERY_STATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUERY_STATE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "QUERY_STATE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.QUERY_TYPE))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.QUERY_TYPE ").Append((cause.QUERY_TYPE.StartsWith("%") || cause.QUERY_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :C_QUERY_TYPE");
				param = new OracleParameter();
				param.ParameterName =":C_QUERY_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.QUERY_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUERY_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "QUERY_TYPE"));
			}
			if(!string.IsNullOrEmpty(cause.QUERY_TYPE_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.QUERY_TYPE_NAME ").Append((cause.QUERY_TYPE_NAME.StartsWith("%") || cause.QUERY_TYPE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_QUERY_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_QUERY_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.QUERY_TYPE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUERY_TYPE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "QUERY_TYPE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :C_MATNR");
				param = new OracleParameter();
				param.ParameterName =":C_MATNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MATNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "MATNR"));
			}
			if(cause.END_DATE!= null)
			{
				if (cause.END_DATE.Begin != null)
				{
					strBuf.Append(" And V_SCM_B_QUOTEDPRICE.END_DATE >= :C_END_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_END_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.END_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.END_DATE.End != null)
				{
					strBuf.Append(" And V_SCM_B_QUOTEDPRICE.END_DATE < :C_END_DATE_END");
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
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "END_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.GYSNAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSNAME");
				param = new OracleParameter();
				param.ParameterName =":C_GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.GYSNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "GYSNAME"));
			}
			if(!string.IsNullOrEmpty(cause.MSEHT))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.MSEHT ").Append((cause.MSEHT.StartsWith("%") || cause.MSEHT.EndsWith("%")) ? " like " : " = ").Append(" :C_MSEHT");
				param = new OracleParameter();
				param.ParameterName =":C_MSEHT";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 10;
				param.Value = cause.MSEHT;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSEHT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "MSEHT"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.PRODUCT_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.PRODUCT_NAME ").Append((cause.PRODUCT_NAME.StartsWith("%") || cause.PRODUCT_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_PRODUCT_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_PRODUCT_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.PRODUCT_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRODUCT_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "PRODUCT_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.MID))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.MID ").Append((cause.MID.StartsWith("%") || cause.MID.EndsWith("%")) ? " like " : " = ").Append(" :C_MID");
				param = new OracleParameter();
				param.ParameterName =":C_MID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "MID"));
			}
			if(cause.QUERY_DATE!= null)
			{
				if (cause.QUERY_DATE.Begin != null)
				{
					strBuf.Append(" And V_SCM_B_QUOTEDPRICE.QUERY_DATE >= :C_QUERY_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_QUERY_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.QUERY_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.QUERY_DATE.End != null)
				{
					strBuf.Append(" And V_SCM_B_QUOTEDPRICE.QUERY_DATE < :C_QUERY_DATE_END");
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
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "QUERY_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.MATNR_ID))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.MATNR_ID ").Append((cause.MATNR_ID.StartsWith("%") || cause.MATNR_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MATNR_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MATNR_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MATNR_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MATNR_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "MATNR_ID"));
			}
			if(!string.IsNullOrEmpty(cause.QUERY_STATE_NAME))
			{
				strBuf.Append(" And V_SCM_B_QUOTEDPRICE.QUERY_STATE_NAME ").Append((cause.QUERY_STATE_NAME.StartsWith("%") || cause.QUERY_STATE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_QUERY_STATE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_QUERY_STATE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.QUERY_STATE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("QUERY_STATE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_SCM_B_QUOTEDPRICE", "QUERY_STATE_NAME"));
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
		public static DisplayObject_V_SCM_B_QUOTEDPRICE[] Query(CauseObject_V_SCM_B_QUOTEDPRICE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_B_QUOTEDPRICE.MCODE, V_SCM_B_QUOTEDPRICE.MCOMMENTS, V_SCM_B_QUOTEDPRICE.MNAME, V_SCM_B_QUOTEDPRICE.AMOUNT, V_SCM_B_QUOTEDPRICE.SPEC, V_SCM_B_QUOTEDPRICE.CODE, V_SCM_B_QUOTEDPRICE.STATE_NAME, V_SCM_B_QUOTEDPRICE.CREATE_TIME, V_SCM_B_QUOTEDPRICE.QUOTED_PRICE, V_SCM_B_QUOTEDPRICE.GYSPYM, V_SCM_B_QUOTEDPRICE.MSTATE, V_SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT, V_SCM_B_QUOTEDPRICE.MDEPT_ID_NAME, V_SCM_B_QUOTEDPRICE.GYSLABEL, V_SCM_B_QUOTEDPRICE.STATE, V_SCM_B_QUOTEDPRICE.MSTATE_NAME, V_SCM_B_QUOTEDPRICE.MDEPT_ID, V_SCM_B_QUOTEDPRICE.TXZ01, V_SCM_B_QUOTEDPRICE.QUERY_STATE, V_SCM_B_QUOTEDPRICE.ID, V_SCM_B_QUOTEDPRICE.QUERY_TYPE, V_SCM_B_QUOTEDPRICE.QUERY_TYPE_NAME, V_SCM_B_QUOTEDPRICE.MATNR, V_SCM_B_QUOTEDPRICE.END_DATE, V_SCM_B_QUOTEDPRICE.COMMENTS, V_SCM_B_QUOTEDPRICE.GYSNAME, V_SCM_B_QUOTEDPRICE.MSEHT, V_SCM_B_QUOTEDPRICE.GYSACCOUNT, V_SCM_B_QUOTEDPRICE.PRODUCT_NAME, V_SCM_B_QUOTEDPRICE.MID, V_SCM_B_QUOTEDPRICE.QUERY_DATE, V_SCM_B_QUOTEDPRICE.MATNR_ID, V_SCM_B_QUOTEDPRICE.QUERY_STATE_NAME from V_SCM_B_QUOTEDPRICE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_B_QUOTEDPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_QUOTEDPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MCODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MCOMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSPYM = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MSTATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MDEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSLABEL = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MSTATE_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MDEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TXZ01 = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.QUERY_STATE = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MATNR = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.END_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.COMMENTS = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.GYSNAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MSEHT = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.MID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.MATNR_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(32);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_B_QUOTEDPRICE[] objs = new DisplayObject_V_SCM_B_QUOTEDPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_B_QUOTEDPRICE[] Query(CauseObject_V_SCM_B_QUOTEDPRICE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_SCM_B_QUOTEDPRICE.MCODE, V_SCM_B_QUOTEDPRICE.MCOMMENTS, V_SCM_B_QUOTEDPRICE.MNAME, V_SCM_B_QUOTEDPRICE.AMOUNT, V_SCM_B_QUOTEDPRICE.SPEC, V_SCM_B_QUOTEDPRICE.CODE, V_SCM_B_QUOTEDPRICE.STATE_NAME, V_SCM_B_QUOTEDPRICE.CREATE_TIME, V_SCM_B_QUOTEDPRICE.QUOTED_PRICE, V_SCM_B_QUOTEDPRICE.GYSPYM, V_SCM_B_QUOTEDPRICE.MSTATE, V_SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT, V_SCM_B_QUOTEDPRICE.MDEPT_ID_NAME, V_SCM_B_QUOTEDPRICE.GYSLABEL, V_SCM_B_QUOTEDPRICE.STATE, V_SCM_B_QUOTEDPRICE.MSTATE_NAME, V_SCM_B_QUOTEDPRICE.MDEPT_ID, V_SCM_B_QUOTEDPRICE.TXZ01, V_SCM_B_QUOTEDPRICE.QUERY_STATE, V_SCM_B_QUOTEDPRICE.ID, V_SCM_B_QUOTEDPRICE.QUERY_TYPE, V_SCM_B_QUOTEDPRICE.QUERY_TYPE_NAME, V_SCM_B_QUOTEDPRICE.MATNR, V_SCM_B_QUOTEDPRICE.END_DATE, V_SCM_B_QUOTEDPRICE.COMMENTS, V_SCM_B_QUOTEDPRICE.GYSNAME, V_SCM_B_QUOTEDPRICE.MSEHT, V_SCM_B_QUOTEDPRICE.GYSACCOUNT, V_SCM_B_QUOTEDPRICE.PRODUCT_NAME, V_SCM_B_QUOTEDPRICE.MID, V_SCM_B_QUOTEDPRICE.QUERY_DATE, V_SCM_B_QUOTEDPRICE.MATNR_ID, V_SCM_B_QUOTEDPRICE.QUERY_STATE_NAME from V_SCM_B_QUOTEDPRICE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_SCM_B_QUOTEDPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_QUOTEDPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MCODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MCOMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSPYM = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MSTATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MDEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSLABEL = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MSTATE_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MDEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TXZ01 = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.QUERY_STATE = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MATNR = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.END_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.COMMENTS = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.GYSNAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MSEHT = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.MID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.MATNR_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(32);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_B_QUOTEDPRICE[] objs = new DisplayObject_V_SCM_B_QUOTEDPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_B_QUOTEDPRICE[] Query(CauseObject_V_SCM_B_QUOTEDPRICE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_B_QUOTEDPRICE.MCODE, V_SCM_B_QUOTEDPRICE.MCOMMENTS, V_SCM_B_QUOTEDPRICE.MNAME, V_SCM_B_QUOTEDPRICE.AMOUNT, V_SCM_B_QUOTEDPRICE.SPEC, V_SCM_B_QUOTEDPRICE.CODE, V_SCM_B_QUOTEDPRICE.STATE_NAME, V_SCM_B_QUOTEDPRICE.CREATE_TIME, V_SCM_B_QUOTEDPRICE.QUOTED_PRICE, V_SCM_B_QUOTEDPRICE.GYSPYM, V_SCM_B_QUOTEDPRICE.MSTATE, V_SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT, V_SCM_B_QUOTEDPRICE.MDEPT_ID_NAME, V_SCM_B_QUOTEDPRICE.GYSLABEL, V_SCM_B_QUOTEDPRICE.STATE, V_SCM_B_QUOTEDPRICE.MSTATE_NAME, V_SCM_B_QUOTEDPRICE.MDEPT_ID, V_SCM_B_QUOTEDPRICE.TXZ01, V_SCM_B_QUOTEDPRICE.QUERY_STATE, V_SCM_B_QUOTEDPRICE.ID, V_SCM_B_QUOTEDPRICE.QUERY_TYPE, V_SCM_B_QUOTEDPRICE.QUERY_TYPE_NAME, V_SCM_B_QUOTEDPRICE.MATNR, V_SCM_B_QUOTEDPRICE.END_DATE, V_SCM_B_QUOTEDPRICE.COMMENTS, V_SCM_B_QUOTEDPRICE.GYSNAME, V_SCM_B_QUOTEDPRICE.MSEHT, V_SCM_B_QUOTEDPRICE.GYSACCOUNT, V_SCM_B_QUOTEDPRICE.PRODUCT_NAME, V_SCM_B_QUOTEDPRICE.MID, V_SCM_B_QUOTEDPRICE.QUERY_DATE, V_SCM_B_QUOTEDPRICE.MATNR_ID, V_SCM_B_QUOTEDPRICE.QUERY_STATE_NAME from V_SCM_B_QUOTEDPRICE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_B_QUOTEDPRICE",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_SCM_B_QUOTEDPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_QUOTEDPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MCODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MCOMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSPYM = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MSTATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MDEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSLABEL = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MSTATE_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MDEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TXZ01 = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.QUERY_STATE = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MATNR = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.END_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.COMMENTS = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.GYSNAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MSEHT = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.MID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.MATNR_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(32);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_SCM_B_QUOTEDPRICE[] objs = new DisplayObject_V_SCM_B_QUOTEDPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_SCM_B_QUOTEDPRICE[] Query(CauseObject_V_SCM_B_QUOTEDPRICE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_SCM_B_QUOTEDPRICE.MCODE, V_SCM_B_QUOTEDPRICE.MCOMMENTS, V_SCM_B_QUOTEDPRICE.MNAME, V_SCM_B_QUOTEDPRICE.AMOUNT, V_SCM_B_QUOTEDPRICE.SPEC, V_SCM_B_QUOTEDPRICE.CODE, V_SCM_B_QUOTEDPRICE.STATE_NAME, V_SCM_B_QUOTEDPRICE.CREATE_TIME, V_SCM_B_QUOTEDPRICE.QUOTED_PRICE, V_SCM_B_QUOTEDPRICE.GYSPYM, V_SCM_B_QUOTEDPRICE.MSTATE, V_SCM_B_QUOTEDPRICE.SUPPLY_AMOUNT, V_SCM_B_QUOTEDPRICE.MDEPT_ID_NAME, V_SCM_B_QUOTEDPRICE.GYSLABEL, V_SCM_B_QUOTEDPRICE.STATE, V_SCM_B_QUOTEDPRICE.MSTATE_NAME, V_SCM_B_QUOTEDPRICE.MDEPT_ID, V_SCM_B_QUOTEDPRICE.TXZ01, V_SCM_B_QUOTEDPRICE.QUERY_STATE, V_SCM_B_QUOTEDPRICE.ID, V_SCM_B_QUOTEDPRICE.QUERY_TYPE, V_SCM_B_QUOTEDPRICE.QUERY_TYPE_NAME, V_SCM_B_QUOTEDPRICE.MATNR, V_SCM_B_QUOTEDPRICE.END_DATE, V_SCM_B_QUOTEDPRICE.COMMENTS, V_SCM_B_QUOTEDPRICE.GYSNAME, V_SCM_B_QUOTEDPRICE.MSEHT, V_SCM_B_QUOTEDPRICE.GYSACCOUNT, V_SCM_B_QUOTEDPRICE.PRODUCT_NAME, V_SCM_B_QUOTEDPRICE.MID, V_SCM_B_QUOTEDPRICE.QUERY_DATE, V_SCM_B_QUOTEDPRICE.MATNR_ID, V_SCM_B_QUOTEDPRICE.QUERY_STATE_NAME from V_SCM_B_QUOTEDPRICE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_SCM_B_QUOTEDPRICE",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_SCM_B_QUOTEDPRICE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_SCM_B_QUOTEDPRICE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.MCODE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.MCOMMENTS = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MNAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.AMOUNT = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SPEC = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.CODE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATE_NAME = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.QUOTED_PRICE = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.GYSPYM = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MSTATE = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SUPPLY_AMOUNT = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MDEPT_ID_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.GYSLABEL = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.STATE = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.MSTATE_NAME = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MDEPT_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.TXZ01 = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.QUERY_STATE = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ID = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.QUERY_TYPE = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.QUERY_TYPE_NAME = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.MATNR = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.END_DATE = sqlReader.GetDateTime(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.COMMENTS = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.GYSNAME = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.MSEHT = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.PRODUCT_NAME = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.MID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.QUERY_DATE = sqlReader.GetDateTime(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.MATNR_ID = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.QUERY_STATE_NAME = sqlReader.GetString(32);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_SCM_B_QUOTEDPRICE[] objs = new DisplayObject_V_SCM_B_QUOTEDPRICE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
