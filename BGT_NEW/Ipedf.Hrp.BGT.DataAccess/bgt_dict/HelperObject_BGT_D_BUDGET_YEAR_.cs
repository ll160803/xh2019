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
	public partial class HelperObject_BGT_D_BUDGET_YEAR
	{
        public static int CreateBudetAccount(string yearId, out string msg)
        {
            int succeed = 0;
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = "p_yearid";
                    p1.Direction = ParameterDirection.Input;
                    p1.Size = 36;
                    p1.OracleType = OracleType.Char;
                    p1.Value = yearId;
                    cmd.Parameters.Add(p1);


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

                    cmd.CommandText = "SP_bgt_create_budget_account";
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
