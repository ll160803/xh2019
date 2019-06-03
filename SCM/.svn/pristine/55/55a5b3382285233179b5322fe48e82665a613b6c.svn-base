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
	[CauseObject(typeof(CauseObject_SCM_B_QUOTEDPRICE_D))]
	public partial class HelperObject_SCM_B_QUOTEDPRICE_D
	{		
		#region Method Blok
		public static int Save(EntityObject_SCM_B_QUOTEDPRICE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into SCM_B_QUOTEDPRICE_D( COMMENTS_D, HOSPITAL_NAME, BASE_ID, DISPLAY_INDEX, COM_FILE_ID, ID, PRICE) values ( :COMMENTS_D, :HOSPITAL_NAME, :BASE_ID, :DISPLAY_INDEX, :COM_FILE_ID, :ID, :PRICE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[7];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":COMMENTS_D";
			parameters[0].Size = 500;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.COMMENTS_D == null ? String.Empty:obj.COMMENTS_D;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":HOSPITAL_NAME";
			parameters[1].Size = 100;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.HOSPITAL_NAME == null ? String.Empty:obj.HOSPITAL_NAME;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":BASE_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":DISPLAY_INDEX";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.DISPLAY_INDEX;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":COM_FILE_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.COM_FILE_ID == null ? String.Empty:obj.COM_FILE_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":PRICE";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.PRICE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SCM_B_QUOTEDPRICE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_B_QUOTEDPRICE_D set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  (1=1) ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SCM_B_QUOTEDPRICE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SCM_B_QUOTEDPRICE_D where  (1=1) ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		
		public static string PrepareCause(CauseObject_SCM_B_QUOTEDPRICE_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.COMMENTS_D))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE_D.COMMENTS_D ").Append((cause.COMMENTS_D.StartsWith("%") || cause.COMMENTS_D.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS_D");
				param = new OracleParameter();
				param.ParameterName =":COMMENTS_D";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.COMMENTS_D;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS_D"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE_D", "COMMENTS_D"));
			}
			if(!string.IsNullOrEmpty(cause.HOSPITAL_NAME))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE_D.HOSPITAL_NAME ").Append((cause.HOSPITAL_NAME.StartsWith("%") || cause.HOSPITAL_NAME.EndsWith("%")) ? " like " : " = ").Append(" :HOSPITAL_NAME");
				param = new OracleParameter();
				param.ParameterName =":HOSPITAL_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.HOSPITAL_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("HOSPITAL_NAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE_D", "HOSPITAL_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE_D", "BASE_ID"));
			}
			if(cause.DISPLAY_INDEX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE_D.DISPLAY_INDEX = :DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName =":DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("DISPLAY_INDEX"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE_D", "DISPLAY_INDEX"));
			}
			if(!string.IsNullOrEmpty(cause.COM_FILE_ID))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE_D.COM_FILE_ID ").Append((cause.COM_FILE_ID.StartsWith("%") || cause.COM_FILE_ID.EndsWith("%")) ? " like " : " = ").Append(" :COM_FILE_ID");
				param = new OracleParameter();
				param.ParameterName =":COM_FILE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.COM_FILE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("COM_FILE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE_D", "COM_FILE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE_D", "ID"));
			}
			if(cause.PRICE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And SCM_B_QUOTEDPRICE_D.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName =":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.PRICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRICE"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUOTEDPRICE_D", "PRICE"));
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
		
		public static int Delete(CauseObject_SCM_B_QUOTEDPRICE_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SCM_B_QUOTEDPRICE_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		
		public static string PrepareUpdate(EntityObject_SCM_B_QUOTEDPRICE_D obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("COMMENTS_D"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE_D.COMMENTS_D = :COMMENTS_D");
				param = new OracleParameter();
				param.ParameterName = ":COMMENTS_D";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS_D) ? string.Empty : obj.COMMENTS_D;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("HOSPITAL_NAME"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE_D.HOSPITAL_NAME = :HOSPITAL_NAME");
				param = new OracleParameter();
				param.ParameterName = ":HOSPITAL_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.HOSPITAL_NAME) ? string.Empty : obj.HOSPITAL_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE_D.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DISPLAY_INDEX"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE_D.DISPLAY_INDEX = :DISPLAY_INDEX");
				param = new OracleParameter();
				param.ParameterName = ":DISPLAY_INDEX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.DISPLAY_INDEX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COM_FILE_ID"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE_D.COM_FILE_ID = :COM_FILE_ID");
				param = new OracleParameter();
				param.ParameterName = ":COM_FILE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.COM_FILE_ID) ? string.Empty : obj.COM_FILE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ID"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE_D.ID = :ID");
				param = new OracleParameter();
				param.ParameterName = ":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.ID) ? string.Empty : obj.ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRICE"))
			{
				strBuf.Add("  SCM_B_QUOTEDPRICE_D.PRICE = :PRICE");
				param = new OracleParameter();
				param.ParameterName = ":PRICE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.PRICE;
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
