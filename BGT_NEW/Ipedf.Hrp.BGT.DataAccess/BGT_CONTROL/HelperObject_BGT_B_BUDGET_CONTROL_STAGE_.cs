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
	public partial class HelperObject_BGT_B_BUDGET_CONTROL_STAGE
	{
        /// <summary>
        /// 复制经费进入执行表
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static int Action_NewYear(string old_year_id, string new_year_id, out string msg)
        {
            int succeed = 0;
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter p1 = new OracleParameter();

                    p1.ParameterName = "p_old_year_id";
                    p1.Direction = ParameterDirection.Input;
                    p1.Size = 36;
                    p1.OracleType = OracleType.Char;
                    p1.Value = old_year_id;
                    cmd.Parameters.Add(p1);

                    OracleParameter p4 = new OracleParameter();

                    p4.ParameterName = "p_new_year_id";
                    p4.Direction = ParameterDirection.Input;
                    p4.Size = 36;
                    p4.OracleType = OracleType.Char;
                    p4.Value = new_year_id;
                    cmd.Parameters.Add(p4);

                    OracleParameter p2 = new OracleParameter();

                    p2.ParameterName = "p_msg";
                    p2.Direction = ParameterDirection.Output;
                    p2.Size = 1024;
                    p2.OracleType = OracleType.VarChar;
                    cmd.Parameters.Add(p2);

                    OracleParameter p3 = new OracleParameter();
                    p3.ParameterName = "p_succeed";
                    p3.Direction = ParameterDirection.Output;
                    p3.OracleType = OracleType.Number;
                    cmd.Parameters.Add(p3);

                    cmd.CommandText = "sp_bgt_new_budget_year";
                    cmd.ExecuteNonQuery();
                    msg = DBNull.Value.Equals(p2.Value) ? string.Empty : (string)p2.Value;
                    succeed = (int)(decimal)p3.Value;
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
