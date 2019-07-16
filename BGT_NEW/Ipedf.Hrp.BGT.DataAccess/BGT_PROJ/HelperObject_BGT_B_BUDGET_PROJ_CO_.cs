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
	public partial class HelperObject_BGT_B_BUDGET_PROJ_CO
	{
        public static int CreateProjExecuteData(string dataId, out string msg, IDbTransaction trans)
        {

            int succeed = 0;
            IDbCommand cmd = trans.Connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Transaction = trans;

            OracleParameter p1 = new OracleParameter();
            p1.ParameterName = "p_projid";
            p1.Direction = ParameterDirection.Input;
            p1.Size = 36;
            p1.OracleType = OracleType.Char;
            p1.Value = dataId;
            cmd.Parameters.Add(p1);


            OracleParameter p3 = new OracleParameter();
            p3.ParameterName = "p_msg";
            p3.Direction = ParameterDirection.Output;
            p3.Size = 1024;
            p3.OracleType = OracleType.VarChar;
            cmd.Parameters.Add(p3);

            OracleParameter p4 = new OracleParameter();
            p4.ParameterName = "p_succeed";
            p4.Direction = ParameterDirection.Output;
            p4.OracleType = OracleType.Number;
            cmd.Parameters.Add(p4);

            cmd.CommandText = "SP_bgt_Create_ProjExecuteData";
            cmd.ExecuteNonQuery();
            msg = DBNull.Value.Equals(p3.Value) ? string.Empty : (string)p3.Value;
            succeed = (int)(decimal)p4.Value;
            if (succeed == 0)
                throw new Exception(msg);
            return succeed;
        }
        public static EntityObject_BGT_D_BUDGET_YEAR GetRecentlyBudgetYear(string projectId)
        {

            //平台自动生成代码
            string sSql = "select  DATA_ORGANISE_ID, MODIFY_TIME, ID, '', STATE, BUDGET_YEAR, MODIFY_DEPT_ID, CREATE_TIME, CREATE_USER_ID, MODIFY_USER_ID, CREATE_DEPT_ID, COMMENTS from BGT_D_BUDGET_YEAR where  ID = (select t.budget_year from BGT_B_BUDGET_PROJ_CO t where t.project_id =:ID and t.is_recently = 1 and rownum = 1) ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = projectId;
            #endregion
            #region Push Block
            EntityObject_BGT_D_BUDGET_YEAR dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new EntityObject_BGT_D_BUDGET_YEAR();
                if (!sqlReader.IsDBNull(0))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(4))
                    dataObj.STATE = sqlReader.GetDecimal(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.BUDGET_YEAR = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.MODIFY_DEPT_ID = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.CREATE_DEPT_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.COMMENTS = sqlReader.GetString(11);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            EntityObject_BGT_D_BUDGET_YEAR[] objs = new EntityObject_BGT_D_BUDGET_YEAR[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
        public static int ArchiveProjectCOData(string dataId, out string msg)
        {
            int succeed = 0;
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = "p_coid";
                    p1.Direction = ParameterDirection.Input;
                    p1.Size = 36;
                    p1.OracleType = OracleType.Char;
                    p1.Value = dataId;
                    cmd.Parameters.Add(p1);


                    OracleParameter p3 = new OracleParameter();
                    p3.ParameterName = "p_msg";
                    p3.Direction = ParameterDirection.Output;
                    p3.Size = 1024;
                    p3.OracleType = OracleType.VarChar;
                    cmd.Parameters.Add(p3);

                    OracleParameter p4 = new OracleParameter();
                    p4.ParameterName = "p_succeed";
                    p4.Direction = ParameterDirection.Output;
                    p4.OracleType = OracleType.Number;
                    cmd.Parameters.Add(p4);

                    cmd.CommandText = "SP_bgt_Archive_ProjCOData";
                    cmd.ExecuteNonQuery();
                    msg = DBNull.Value.Equals(p3.Value) ? string.Empty : (string)p3.Value;
                    succeed = (int)(decimal)p4.Value;
                }
                catch (Exception expt)
                {
                    throw expt;
                }
                finally
                {
                    connection.Close();
                }
            }
            return succeed;
        }
	}
}
