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
	[CauseObject(typeof(CauseObject_BGT_B_PAY_PERSON_D))]
	public partial class HelperObject_BGT_B_PAY_PERSON_D
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_PAY_PERSON_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_B_PAY_PERSON_D( OTHERS, LASTYEAR_COUNT, ID, BASE_ID, FINANCE_IDEA, DECLARE_CAUSE, NOWYEAR_COUNT, PERSON_TYPE_ID, CONTROL_COUNT) values ( :OTHERS, :LASTYEAR_COUNT, :ID, :BASE_ID, :FINANCE_IDEA, :DECLARE_CAUSE, :NOWYEAR_COUNT, :PERSON_TYPE_ID, :CONTROL_COUNT)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[9];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":OTHERS";
			parameters[0].Size = 500;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.OTHERS == null ? String.Empty:obj.OTHERS;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":LASTYEAR_COUNT";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.LASTYEAR_COUNT;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":BASE_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":FINANCE_IDEA";
			parameters[4].Size = 1000;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.FINANCE_IDEA == null ? String.Empty:obj.FINANCE_IDEA;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":DECLARE_CAUSE";
			parameters[5].Size = 1000;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.DECLARE_CAUSE == null ? String.Empty:obj.DECLARE_CAUSE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":NOWYEAR_COUNT";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.NOWYEAR_COUNT;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":PERSON_TYPE_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.PERSON_TYPE_ID == null ? String.Empty:obj.PERSON_TYPE_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CONTROL_COUNT";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.CONTROL_COUNT;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_PAY_PERSON_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_PAY_PERSON_D set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_PAY_PERSON_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_PAY_PERSON_D where  ID = :ID ";
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
		public static EntityObject_BGT_B_PAY_PERSON_D Get(EntityObject_BGT_B_PAY_PERSON_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  OTHERS, LASTYEAR_COUNT, ID, BASE_ID, FINANCE_IDEA, DECLARE_CAUSE, NOWYEAR_COUNT, PERSON_TYPE_ID, CONTROL_COUNT from BGT_B_PAY_PERSON_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_PAY_PERSON_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_PAY_PERSON_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OTHERS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.LASTYEAR_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NOWYEAR_COUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PERSON_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CONTROL_COUNT = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_PAY_PERSON_D[] objs = new EntityObject_BGT_B_PAY_PERSON_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_PAY_PERSON_D Get(EntityObject_BGT_B_PAY_PERSON_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  OTHERS, LASTYEAR_COUNT, ID, BASE_ID, FINANCE_IDEA, DECLARE_CAUSE, NOWYEAR_COUNT, PERSON_TYPE_ID, CONTROL_COUNT from BGT_B_PAY_PERSON_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_PAY_PERSON_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_PAY_PERSON_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OTHERS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.LASTYEAR_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NOWYEAR_COUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PERSON_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CONTROL_COUNT = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_PAY_PERSON_D[] objs = new EntityObject_BGT_B_PAY_PERSON_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_PAY_PERSON_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_PAY_PERSON_D.OTHERS, BGT_B_PAY_PERSON_D.LASTYEAR_COUNT, BGT_B_PAY_PERSON_D.ID, BGT_B_PAY_PERSON_D.BASE_ID, BGT_B_PAY_PERSON_D.FINANCE_IDEA, BGT_B_PAY_PERSON_D.DECLARE_CAUSE, BGT_B_PAY_PERSON_D.NOWYEAR_COUNT, BGT_B_PAY_PERSON_D.PERSON_TYPE_ID, BGT_B_PAY_PERSON_D.CONTROL_COUNT from BGT_B_PAY_PERSON_D where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_PAY_PERSON_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_PAY_PERSON_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OTHERS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.LASTYEAR_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NOWYEAR_COUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PERSON_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CONTROL_COUNT = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_PAY_PERSON_D[] objs = new DisplayObject_BGT_B_PAY_PERSON_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_PAY_PERSON_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.OTHERS))
			{
				strBuf.Append(" And BGT_B_PAY_PERSON_D.OTHERS ").Append((cause.OTHERS.StartsWith("%") || cause.OTHERS.EndsWith("%")) ? " like " : " = ").Append(" :OTHERS");
				param = new OracleParameter();
				param.ParameterName =":OTHERS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.OTHERS;
				paramList.Add(param);
			}
			if (cause.HasINValue("OTHERS"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_PAY_PERSON_D", "OTHERS"));
			}
			if(cause.LASTYEAR_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_PAY_PERSON_D.LASTYEAR_COUNT = :LASTYEAR_COUNT");
				param = new OracleParameter();
				param.ParameterName =":LASTYEAR_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.LASTYEAR_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("LASTYEAR_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_PAY_PERSON_D", "LASTYEAR_COUNT"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And BGT_B_PAY_PERSON_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_PAY_PERSON_D", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And BGT_B_PAY_PERSON_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_PAY_PERSON_D", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_IDEA))
			{
				strBuf.Append(" And BGT_B_PAY_PERSON_D.FINANCE_IDEA ").Append((cause.FINANCE_IDEA.StartsWith("%") || cause.FINANCE_IDEA.EndsWith("%")) ? " like " : " = ").Append(" :FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName =":FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_IDEA"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_PAY_PERSON_D", "FINANCE_IDEA"));
			}
			if(!string.IsNullOrEmpty(cause.DECLARE_CAUSE))
			{
				strBuf.Append(" And BGT_B_PAY_PERSON_D.DECLARE_CAUSE ").Append((cause.DECLARE_CAUSE.StartsWith("%") || cause.DECLARE_CAUSE.EndsWith("%")) ? " like " : " = ").Append(" :DECLARE_CAUSE");
				param = new OracleParameter();
				param.ParameterName =":DECLARE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.DECLARE_CAUSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DECLARE_CAUSE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_PAY_PERSON_D", "DECLARE_CAUSE"));
			}
			if(cause.NOWYEAR_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_PAY_PERSON_D.NOWYEAR_COUNT = :NOWYEAR_COUNT");
				param = new OracleParameter();
				param.ParameterName =":NOWYEAR_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.NOWYEAR_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("NOWYEAR_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_PAY_PERSON_D", "NOWYEAR_COUNT"));
			}
			if(!string.IsNullOrEmpty(cause.PERSON_TYPE_ID))
			{
				strBuf.Append(" And BGT_B_PAY_PERSON_D.PERSON_TYPE_ID ").Append((cause.PERSON_TYPE_ID.StartsWith("%") || cause.PERSON_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :PERSON_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":PERSON_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.PERSON_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PERSON_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_PAY_PERSON_D", "PERSON_TYPE_ID"));
			}
			if(cause.CONTROL_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_PAY_PERSON_D.CONTROL_COUNT = :CONTROL_COUNT");
				param = new OracleParameter();
				param.ParameterName =":CONTROL_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CONTROL_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTROL_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_PAY_PERSON_D", "CONTROL_COUNT"));
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
		public static DisplayObject_BGT_B_PAY_PERSON_D[] Query(CauseObject_BGT_B_PAY_PERSON_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_PAY_PERSON_D.OTHERS, BGT_B_PAY_PERSON_D.LASTYEAR_COUNT, BGT_B_PAY_PERSON_D.ID, BGT_B_PAY_PERSON_D.BASE_ID, BGT_B_PAY_PERSON_D.FINANCE_IDEA, BGT_B_PAY_PERSON_D.DECLARE_CAUSE, BGT_B_PAY_PERSON_D.NOWYEAR_COUNT, BGT_B_PAY_PERSON_D.PERSON_TYPE_ID, BGT_B_PAY_PERSON_D.CONTROL_COUNT from BGT_B_PAY_PERSON_D where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_PAY_PERSON_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_PAY_PERSON_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OTHERS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.LASTYEAR_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NOWYEAR_COUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PERSON_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CONTROL_COUNT = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_PAY_PERSON_D[] objs = new DisplayObject_BGT_B_PAY_PERSON_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_PAY_PERSON_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_PAY_PERSON_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_PAY_PERSON_D[] Query(CauseObject_BGT_B_PAY_PERSON_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_PAY_PERSON_D.OTHERS, BGT_B_PAY_PERSON_D.LASTYEAR_COUNT, BGT_B_PAY_PERSON_D.ID, BGT_B_PAY_PERSON_D.BASE_ID, BGT_B_PAY_PERSON_D.FINANCE_IDEA, BGT_B_PAY_PERSON_D.DECLARE_CAUSE, BGT_B_PAY_PERSON_D.NOWYEAR_COUNT, BGT_B_PAY_PERSON_D.PERSON_TYPE_ID, BGT_B_PAY_PERSON_D.CONTROL_COUNT from BGT_B_PAY_PERSON_D where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_PAY_PERSON_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_PAY_PERSON_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OTHERS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.LASTYEAR_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NOWYEAR_COUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PERSON_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CONTROL_COUNT = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_PAY_PERSON_D[] objs = new DisplayObject_BGT_B_PAY_PERSON_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_PAY_PERSON_D[] Query(CauseObject_BGT_B_PAY_PERSON_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_PAY_PERSON_D.OTHERS, BGT_B_PAY_PERSON_D.LASTYEAR_COUNT, BGT_B_PAY_PERSON_D.ID, BGT_B_PAY_PERSON_D.BASE_ID, BGT_B_PAY_PERSON_D.FINANCE_IDEA, BGT_B_PAY_PERSON_D.DECLARE_CAUSE, BGT_B_PAY_PERSON_D.NOWYEAR_COUNT, BGT_B_PAY_PERSON_D.PERSON_TYPE_ID, BGT_B_PAY_PERSON_D.CONTROL_COUNT from BGT_B_PAY_PERSON_D where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_PAY_PERSON_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_PAY_PERSON_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_PAY_PERSON_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OTHERS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.LASTYEAR_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NOWYEAR_COUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PERSON_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CONTROL_COUNT = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_PAY_PERSON_D[] objs = new DisplayObject_BGT_B_PAY_PERSON_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_PAY_PERSON_D[] Query(CauseObject_BGT_B_PAY_PERSON_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_PAY_PERSON_D.OTHERS, BGT_B_PAY_PERSON_D.LASTYEAR_COUNT, BGT_B_PAY_PERSON_D.ID, BGT_B_PAY_PERSON_D.BASE_ID, BGT_B_PAY_PERSON_D.FINANCE_IDEA, BGT_B_PAY_PERSON_D.DECLARE_CAUSE, BGT_B_PAY_PERSON_D.NOWYEAR_COUNT, BGT_B_PAY_PERSON_D.PERSON_TYPE_ID, BGT_B_PAY_PERSON_D.CONTROL_COUNT from BGT_B_PAY_PERSON_D where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_PAY_PERSON_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_PAY_PERSON_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_PAY_PERSON_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OTHERS = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.LASTYEAR_COUNT = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECLARE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.NOWYEAR_COUNT = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PERSON_TYPE_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CONTROL_COUNT = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_PAY_PERSON_D[] objs = new DisplayObject_BGT_B_PAY_PERSON_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_PAY_PERSON_D obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("OTHERS"))
			{
				strBuf.Add("  BGT_B_PAY_PERSON_D.OTHERS = :OTHERS");
				param = new OracleParameter();
				param.ParameterName = ":OTHERS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.OTHERS) ? string.Empty : obj.OTHERS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LASTYEAR_COUNT"))
			{
				strBuf.Add("  BGT_B_PAY_PERSON_D.LASTYEAR_COUNT = :LASTYEAR_COUNT");
				param = new OracleParameter();
				param.ParameterName = ":LASTYEAR_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.LASTYEAR_COUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  BGT_B_PAY_PERSON_D.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_IDEA"))
			{
				strBuf.Add("  BGT_B_PAY_PERSON_D.FINANCE_IDEA = :FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName = ":FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_IDEA) ? string.Empty : obj.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DECLARE_CAUSE"))
			{
				strBuf.Add("  BGT_B_PAY_PERSON_D.DECLARE_CAUSE = :DECLARE_CAUSE");
				param = new OracleParameter();
				param.ParameterName = ":DECLARE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.DECLARE_CAUSE) ? string.Empty : obj.DECLARE_CAUSE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NOWYEAR_COUNT"))
			{
				strBuf.Add("  BGT_B_PAY_PERSON_D.NOWYEAR_COUNT = :NOWYEAR_COUNT");
				param = new OracleParameter();
				param.ParameterName = ":NOWYEAR_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.NOWYEAR_COUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PERSON_TYPE_ID"))
			{
				strBuf.Add("  BGT_B_PAY_PERSON_D.PERSON_TYPE_ID = :PERSON_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":PERSON_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.PERSON_TYPE_ID) ? string.Empty : obj.PERSON_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONTROL_COUNT"))
			{
				strBuf.Add("  BGT_B_PAY_PERSON_D.CONTROL_COUNT = :CONTROL_COUNT");
				param = new OracleParameter();
				param.ParameterName = ":CONTROL_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CONTROL_COUNT;
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
