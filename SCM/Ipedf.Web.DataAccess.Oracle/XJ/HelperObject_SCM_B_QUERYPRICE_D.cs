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
	[CauseObject(typeof(CauseObject_SCM_B_QUERYPRICE_D))]
	public partial class HelperObject_SCM_B_QUERYPRICE_D
	{		
		#region Method Blok
		public static int Save(EntityObject_SCM_B_QUERYPRICE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into SCM_B_QUERYPRICE_D( COMMENTS_D, GYSACCOUNT, GYSPYM, GYSLABEL, GYSNAME, ID, BASE_ID) values ( :COMMENTS_D, :GYSACCOUNT, :GYSPYM, :GYSLABEL, :GYSNAME, :ID, :BASE_ID)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[7];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":COMMENTS_D";
			parameters[0].Size = 1000;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.COMMENTS_D == null ? String.Empty:obj.COMMENTS_D;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":GYSACCOUNT";
			parameters[1].Size = 20;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.GYSACCOUNT == null ? String.Empty:obj.GYSACCOUNT;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":GYSPYM";
			parameters[2].Size = 20;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.GYSPYM == null ? String.Empty:obj.GYSPYM;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":GYSLABEL";
			parameters[3].Size = 20;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.GYSLABEL == null ? String.Empty:obj.GYSLABEL;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":GYSNAME";
			parameters[4].Size = 100;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.GYSNAME == null ? String.Empty:obj.GYSNAME;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":BASE_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.BASE_ID == null ? String.Empty:obj.BASE_ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SCM_B_QUERYPRICE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_B_QUERYPRICE_D set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_SCM_B_QUERYPRICE_D obj,CauseObject_SCM_B_QUERYPRICE_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update SCM_B_QUERYPRICE_D set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_SCM_B_QUERYPRICE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from SCM_B_QUERYPRICE_D where  ID = :ID ";
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
		public static int Delete(CauseObject_SCM_B_QUERYPRICE_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from SCM_B_QUERYPRICE_D where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_SCM_B_QUERYPRICE_D Get(EntityObject_SCM_B_QUERYPRICE_D obj)
		{
			
			//平台自动生成代码
			string sSql = "select  COMMENTS_D, GYSACCOUNT, GYSPYM, GYSLABEL, GYSNAME, ID, BASE_ID from SCM_B_QUERYPRICE_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_QUERYPRICE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_QUERYPRICE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS_D = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSPYM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.GYSLABEL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_SCM_B_QUERYPRICE_D[] objs = new EntityObject_SCM_B_QUERYPRICE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_B_QUERYPRICE_D Get(DisplayObject_SCM_B_QUERYPRICE_D obj)
		{
			
			//平台自动生成代码
			string sSql = " select  SCM_B_QUERYPRICE_D.COMMENTS_D, SCM_B_QUERYPRICE_D.GYSACCOUNT, SCM_B_QUERYPRICE_D.GYSPYM, SCM_B_QUERYPRICE_D.GYSLABEL, SCM_B_QUERYPRICE_D.GYSNAME, SCM_B_QUERYPRICE_D.ID, SCM_B_QUERYPRICE_D.BASE_ID from SCM_B_QUERYPRICE_D where (1=1) and SCM_B_QUERYPRICE_D.ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			DisplayObject_SCM_B_QUERYPRICE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS_D = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSPYM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.GYSLABEL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE_D[] objs = new DisplayObject_SCM_B_QUERYPRICE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null : objs[0];
		}
		public static EntityObject_SCM_B_QUERYPRICE_D Get(EntityObject_SCM_B_QUERYPRICE_D obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  COMMENTS_D, GYSACCOUNT, GYSPYM, GYSLABEL, GYSNAME, ID, BASE_ID from SCM_B_QUERYPRICE_D where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_SCM_B_QUERYPRICE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_SCM_B_QUERYPRICE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS_D = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSPYM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.GYSLABEL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_SCM_B_QUERYPRICE_D[] objs = new EntityObject_SCM_B_QUERYPRICE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_SCM_B_QUERYPRICE_D[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  SCM_B_QUERYPRICE_D.COMMENTS_D, SCM_B_QUERYPRICE_D.GYSACCOUNT, SCM_B_QUERYPRICE_D.GYSPYM, SCM_B_QUERYPRICE_D.GYSLABEL, SCM_B_QUERYPRICE_D.GYSNAME, SCM_B_QUERYPRICE_D.ID, SCM_B_QUERYPRICE_D.BASE_ID from SCM_B_QUERYPRICE_D where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_SCM_B_QUERYPRICE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS_D = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSPYM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.GYSLABEL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE_D[] objs = new DisplayObject_SCM_B_QUERYPRICE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_SCM_B_QUERYPRICE_D cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.COMMENTS_D))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE_D.COMMENTS_D ").Append((cause.COMMENTS_D.StartsWith("%") || cause.COMMENTS_D.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS_D");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS_D";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = cause.COMMENTS_D;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS_D"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE_D", "COMMENTS_D"));
			}
			if(!string.IsNullOrEmpty(cause.GYSACCOUNT))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE_D.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.GYSACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE_D", "GYSACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.GYSPYM))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE_D.GYSPYM ").Append((cause.GYSPYM.StartsWith("%") || cause.GYSPYM.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSPYM");
				param = new OracleParameter();
				param.ParameterName =":C_GYSPYM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.GYSPYM;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSPYM"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE_D", "GYSPYM"));
			}
			if(!string.IsNullOrEmpty(cause.GYSLABEL))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE_D.GYSLABEL ").Append((cause.GYSLABEL.StartsWith("%") || cause.GYSLABEL.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSLABEL");
				param = new OracleParameter();
				param.ParameterName =":C_GYSLABEL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.GYSLABEL;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSLABEL"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE_D", "GYSLABEL"));
			}
			if(!string.IsNullOrEmpty(cause.GYSNAME))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE_D.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :C_GYSNAME");
				param = new OracleParameter();
				param.ParameterName =":C_GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.GYSNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("GYSNAME"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE_D", "GYSNAME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE_D.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE_D", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.BASE_ID))
			{
				strBuf.Append(" And SCM_B_QUERYPRICE_D.BASE_ID ").Append((cause.BASE_ID.StartsWith("%") || cause.BASE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_BASE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.BASE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("BASE_ID"))
			{
				strBuf.Append(cause.GetINSQL("SCM_B_QUERYPRICE_D", "BASE_ID"));
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
		public static DisplayObject_SCM_B_QUERYPRICE_D[] Query(CauseObject_SCM_B_QUERYPRICE_D cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_B_QUERYPRICE_D.COMMENTS_D, SCM_B_QUERYPRICE_D.GYSACCOUNT, SCM_B_QUERYPRICE_D.GYSPYM, SCM_B_QUERYPRICE_D.GYSLABEL, SCM_B_QUERYPRICE_D.GYSNAME, SCM_B_QUERYPRICE_D.ID, SCM_B_QUERYPRICE_D.BASE_ID from SCM_B_QUERYPRICE_D where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_QUERYPRICE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS_D = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSPYM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.GYSLABEL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE_D[] objs = new DisplayObject_SCM_B_QUERYPRICE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_SCM_B_QUERYPRICE_D[] Query(CauseObject_SCM_B_QUERYPRICE_D cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  SCM_B_QUERYPRICE_D.COMMENTS_D, SCM_B_QUERYPRICE_D.GYSACCOUNT, SCM_B_QUERYPRICE_D.GYSPYM, SCM_B_QUERYPRICE_D.GYSLABEL, SCM_B_QUERYPRICE_D.GYSNAME, SCM_B_QUERYPRICE_D.ID, SCM_B_QUERYPRICE_D.BASE_ID from SCM_B_QUERYPRICE_D where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_SCM_B_QUERYPRICE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS_D = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSPYM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.GYSLABEL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE_D[] objs = new DisplayObject_SCM_B_QUERYPRICE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_QUERYPRICE_D[] Query(CauseObject_SCM_B_QUERYPRICE_D cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_B_QUERYPRICE_D.COMMENTS_D, SCM_B_QUERYPRICE_D.GYSACCOUNT, SCM_B_QUERYPRICE_D.GYSPYM, SCM_B_QUERYPRICE_D.GYSLABEL, SCM_B_QUERYPRICE_D.GYSNAME, SCM_B_QUERYPRICE_D.ID, SCM_B_QUERYPRICE_D.BASE_ID from SCM_B_QUERYPRICE_D where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_QUERYPRICE_D",paging, order, sSql, parameters, connection);
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
			DisplayObject_SCM_B_QUERYPRICE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS_D = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSPYM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.GYSLABEL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE_D[] objs = new DisplayObject_SCM_B_QUERYPRICE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_SCM_B_QUERYPRICE_D[] Query(CauseObject_SCM_B_QUERYPRICE_D cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  SCM_B_QUERYPRICE_D.COMMENTS_D, SCM_B_QUERYPRICE_D.GYSACCOUNT, SCM_B_QUERYPRICE_D.GYSPYM, SCM_B_QUERYPRICE_D.GYSLABEL, SCM_B_QUERYPRICE_D.GYSNAME, SCM_B_QUERYPRICE_D.ID, SCM_B_QUERYPRICE_D.BASE_ID from SCM_B_QUERYPRICE_D where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_B_QUERYPRICE_D",paging, order, sSql, parameters, trans);
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
			DisplayObject_SCM_B_QUERYPRICE_D dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_SCM_B_QUERYPRICE_D();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.COMMENTS_D = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.GYSACCOUNT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.GYSPYM = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.GYSLABEL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GYSNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.BASE_ID = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_SCM_B_QUERYPRICE_D[] objs = new DisplayObject_SCM_B_QUERYPRICE_D[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_SCM_B_QUERYPRICE_D obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("COMMENTS_D"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE_D.COMMENTS_D = :U_COMMENTS_D");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS_D";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1000;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS_D) ? string.Empty : obj.COMMENTS_D;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSACCOUNT"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE_D.GYSACCOUNT = :U_GYSACCOUNT");
				param = new OracleParameter();
				param.ParameterName = ":U_GYSACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSPYM"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE_D.GYSPYM = :U_GYSPYM");
				param = new OracleParameter();
				param.ParameterName = ":U_GYSPYM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.GYSPYM) ? string.Empty : obj.GYSPYM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSLABEL"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE_D.GYSLABEL = :U_GYSLABEL");
				param = new OracleParameter();
				param.ParameterName = ":U_GYSLABEL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = string.IsNullOrEmpty(obj.GYSLABEL) ? string.Empty : obj.GYSLABEL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GYSNAME"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE_D.GYSNAME = :U_GYSNAME");
				param = new OracleParameter();
				param.ParameterName = ":U_GYSNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.GYSNAME) ? string.Empty : obj.GYSNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BASE_ID"))
			{
				strBuf.Add("  SCM_B_QUERYPRICE_D.BASE_ID = :U_BASE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_BASE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.BASE_ID) ? string.Empty : obj.BASE_ID;
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
