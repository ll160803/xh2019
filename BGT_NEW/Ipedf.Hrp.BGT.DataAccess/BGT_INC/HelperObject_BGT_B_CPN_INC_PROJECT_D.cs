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
	[CauseObject(typeof(CauseObject_BGT_B_CPN_INC_PROJECT_D))]
	public partial class HelperObject_BGT_B_CPN_INC_PROJECT_D
	{		
		#region Method Blok
		public static int Save(EntityObject_BGT_B_CPN_INC_PROJECT_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into BGT_B_CPN_INC_PROJECT_D( ID, ITEM_NAME, MONEY, BASE_ID, FINANCE_IDEA, DECALRE_CAUSE, CONTROL_MONEY) values ( :ID, :ITEM_NAME, :MONEY, :BASE_ID, :FINANCE_IDEA, :DECALRE_CAUSE, :CONTROL_MONEY)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[7];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ITEM_NAME";
			parameters[1].Size = 500;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.ITEM_NAME == null ? String.Empty:obj.ITEM_NAME;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":MONEY";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.MONEY;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":BASE_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":FINANCE_IDEA";
			parameters[4].Size = 500;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.FINANCE_IDEA == null ? String.Empty:obj.FINANCE_IDEA;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":DECALRE_CAUSE";
			parameters[5].Size = 2000;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.DECALRE_CAUSE == null ? String.Empty:obj.DECALRE_CAUSE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":CONTROL_MONEY";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.CONTROL_MONEY;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_BGT_B_CPN_INC_PROJECT_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update BGT_B_CPN_INC_PROJECT_D set ";
			sSql += PrepareUpdate(obj, out parameters);
			sSql += " where  ID = :ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_BGT_B_CPN_INC_PROJECT_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from BGT_B_CPN_INC_PROJECT_D where  ID = :ID ";
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
		public static EntityObject_BGT_B_CPN_INC_PROJECT_D Get(EntityObject_BGT_B_CPN_INC_PROJECT_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, ITEM_NAME, MONEY, BASE_ID, FINANCE_IDEA, DECALRE_CAUSE, CONTROL_MONEY from BGT_B_CPN_INC_PROJECT_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_CPN_INC_PROJECT_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_CPN_INC_PROJECT_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_BGT_B_CPN_INC_PROJECT_D[] objs = new EntityObject_BGT_B_CPN_INC_PROJECT_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_BGT_B_CPN_INC_PROJECT_D Get(EntityObject_BGT_B_CPN_INC_PROJECT_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, ITEM_NAME, MONEY, BASE_ID, FINANCE_IDEA, DECALRE_CAUSE, CONTROL_MONEY from BGT_B_CPN_INC_PROJECT_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_BGT_B_CPN_INC_PROJECT_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_BGT_B_CPN_INC_PROJECT_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_BGT_B_CPN_INC_PROJECT_D[] objs = new EntityObject_BGT_B_CPN_INC_PROJECT_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_BGT_B_CPN_INC_PROJECT_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  BGT_B_CPN_INC_PROJECT_D.ID, BGT_B_CPN_INC_PROJECT_D.ITEM_NAME, BGT_B_CPN_INC_PROJECT_D.MONEY, BGT_B_CPN_INC_PROJECT_D.BASE_ID, BGT_B_CPN_INC_PROJECT_D.FINANCE_IDEA, BGT_B_CPN_INC_PROJECT_D.DECALRE_CAUSE, BGT_B_CPN_INC_PROJECT_D.CONTROL_MONEY from BGT_B_CPN_INC_PROJECT_D where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_BGT_B_CPN_INC_PROJECT_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_INC_PROJECT_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_CPN_INC_PROJECT_D[] objs = new DisplayObject_BGT_B_CPN_INC_PROJECT_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_BGT_B_CPN_INC_PROJECT_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And BGT_B_CPN_INC_PROJECT_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
				param = new OracleParameter();
				param.ParameterName =":ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_INC_PROJECT_D", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.ITEM_NAME))
			{
				strBuf.Append(" And BGT_B_CPN_INC_PROJECT_D.ITEM_NAME ").Append((cause.ITEM_NAME.StartsWith("%") || cause.ITEM_NAME.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_NAME");
				param = new OracleParameter();
				param.ParameterName =":ITEM_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.ITEM_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ITEM_NAME"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_INC_PROJECT_D", "ITEM_NAME"));
			}
			if(cause.MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_INC_PROJECT_D.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName =":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_INC_PROJECT_D", "MONEY"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And BGT_B_CPN_INC_PROJECT_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_INC_PROJECT_D", "BASE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.FINANCE_IDEA))
			{
				strBuf.Append(" And BGT_B_CPN_INC_PROJECT_D.FINANCE_IDEA ").Append((cause.FINANCE_IDEA.StartsWith("%") || cause.FINANCE_IDEA.EndsWith("%")) ? " like " : " = ").Append(" :FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName =":FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (cause.HasINValue("FINANCE_IDEA"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_INC_PROJECT_D", "FINANCE_IDEA"));
			}
			if(!string.IsNullOrEmpty(cause.DECALRE_CAUSE))
			{
				strBuf.Append(" And BGT_B_CPN_INC_PROJECT_D.DECALRE_CAUSE ").Append((cause.DECALRE_CAUSE.StartsWith("%") || cause.DECALRE_CAUSE.EndsWith("%")) ? " like " : " = ").Append(" :DECALRE_CAUSE");
				param = new OracleParameter();
				param.ParameterName =":DECALRE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2000;
				param.Value = cause.DECALRE_CAUSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DECALRE_CAUSE"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_INC_PROJECT_D", "DECALRE_CAUSE"));
			}
			if(cause.CONTROL_MONEY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And BGT_B_CPN_INC_PROJECT_D.CONTROL_MONEY = :CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName =":CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CONTROL_MONEY;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTROL_MONEY"))
			{
				strBuf.Append(cause.GetINSQL("BGT_B_CPN_INC_PROJECT_D", "CONTROL_MONEY"));
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
		public static DisplayObject_BGT_B_CPN_INC_PROJECT_D[] Query(CauseObject_BGT_B_CPN_INC_PROJECT_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_INC_PROJECT_D.ID, BGT_B_CPN_INC_PROJECT_D.ITEM_NAME, BGT_B_CPN_INC_PROJECT_D.MONEY, BGT_B_CPN_INC_PROJECT_D.BASE_ID, BGT_B_CPN_INC_PROJECT_D.FINANCE_IDEA, BGT_B_CPN_INC_PROJECT_D.DECALRE_CAUSE, BGT_B_CPN_INC_PROJECT_D.CONTROL_MONEY from BGT_B_CPN_INC_PROJECT_D where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_CPN_INC_PROJECT_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_INC_PROJECT_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_CPN_INC_PROJECT_D[] objs = new DisplayObject_BGT_B_CPN_INC_PROJECT_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static int Delete(CauseObject_BGT_B_CPN_INC_PROJECT_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from BGT_B_CPN_INC_PROJECT_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static DisplayObject_BGT_B_CPN_INC_PROJECT_D[] Query(CauseObject_BGT_B_CPN_INC_PROJECT_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_INC_PROJECT_D.ID, BGT_B_CPN_INC_PROJECT_D.ITEM_NAME, BGT_B_CPN_INC_PROJECT_D.MONEY, BGT_B_CPN_INC_PROJECT_D.BASE_ID, BGT_B_CPN_INC_PROJECT_D.FINANCE_IDEA, BGT_B_CPN_INC_PROJECT_D.DECALRE_CAUSE, BGT_B_CPN_INC_PROJECT_D.CONTROL_MONEY from BGT_B_CPN_INC_PROJECT_D where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_BGT_B_CPN_INC_PROJECT_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_INC_PROJECT_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_CPN_INC_PROJECT_D[] objs = new DisplayObject_BGT_B_CPN_INC_PROJECT_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_CPN_INC_PROJECT_D[] Query(CauseObject_BGT_B_CPN_INC_PROJECT_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_INC_PROJECT_D.ID, BGT_B_CPN_INC_PROJECT_D.ITEM_NAME, BGT_B_CPN_INC_PROJECT_D.MONEY, BGT_B_CPN_INC_PROJECT_D.BASE_ID, BGT_B_CPN_INC_PROJECT_D.FINANCE_IDEA, BGT_B_CPN_INC_PROJECT_D.DECALRE_CAUSE, BGT_B_CPN_INC_PROJECT_D.CONTROL_MONEY from BGT_B_CPN_INC_PROJECT_D where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_CPN_INC_PROJECT_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_BGT_B_CPN_INC_PROJECT_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_INC_PROJECT_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_BGT_B_CPN_INC_PROJECT_D[] objs = new DisplayObject_BGT_B_CPN_INC_PROJECT_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_BGT_B_CPN_INC_PROJECT_D[] Query(CauseObject_BGT_B_CPN_INC_PROJECT_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  BGT_B_CPN_INC_PROJECT_D.ID, BGT_B_CPN_INC_PROJECT_D.ITEM_NAME, BGT_B_CPN_INC_PROJECT_D.MONEY, BGT_B_CPN_INC_PROJECT_D.BASE_ID, BGT_B_CPN_INC_PROJECT_D.FINANCE_IDEA, BGT_B_CPN_INC_PROJECT_D.DECALRE_CAUSE, BGT_B_CPN_INC_PROJECT_D.CONTROL_MONEY from BGT_B_CPN_INC_PROJECT_D where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_B_CPN_INC_PROJECT_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_BGT_B_CPN_INC_PROJECT_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_BGT_B_CPN_INC_PROJECT_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ITEM_NAME = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.MONEY = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.BASE_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.FINANCE_IDEA = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.DECALRE_CAUSE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.CONTROL_MONEY = sqlReader.GetDecimal(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_BGT_B_CPN_INC_PROJECT_D[] objs = new DisplayObject_BGT_B_CPN_INC_PROJECT_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_BGT_B_CPN_INC_PROJECT_D obj, out OracleParameter[] parameters )
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ITEM_NAME"))
			{
				strBuf.Add("  BGT_B_CPN_INC_PROJECT_D.ITEM_NAME = :ITEM_NAME");
				param = new OracleParameter();
				param.ParameterName = ":ITEM_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.ITEM_NAME) ? string.Empty : obj.ITEM_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MONEY"))
			{
				strBuf.Add("  BGT_B_CPN_INC_PROJECT_D.MONEY = :MONEY");
				param = new OracleParameter();
				param.ParameterName = ":MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.MONEY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  BGT_B_CPN_INC_PROJECT_D.BASE_ID = :BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FINANCE_IDEA"))
			{
				strBuf.Add("  BGT_B_CPN_INC_PROJECT_D.FINANCE_IDEA = :FINANCE_IDEA");
				param = new OracleParameter();
				param.ParameterName = ":FINANCE_IDEA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.FINANCE_IDEA) ? string.Empty : obj.FINANCE_IDEA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DECALRE_CAUSE"))
			{
				strBuf.Add("  BGT_B_CPN_INC_PROJECT_D.DECALRE_CAUSE = :DECALRE_CAUSE");
				param = new OracleParameter();
				param.ParameterName = ":DECALRE_CAUSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2000;
				param.Value = string.IsNullOrEmpty(obj.DECALRE_CAUSE) ? string.Empty : obj.DECALRE_CAUSE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONTROL_MONEY"))
			{
				strBuf.Add("  BGT_B_CPN_INC_PROJECT_D.CONTROL_MONEY = :CONTROL_MONEY");
				param = new OracleParameter();
				param.ParameterName = ":CONTROL_MONEY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.CONTROL_MONEY;
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
