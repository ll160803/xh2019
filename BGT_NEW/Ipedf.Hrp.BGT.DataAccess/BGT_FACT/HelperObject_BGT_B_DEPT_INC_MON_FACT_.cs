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

	public partial class HelperObject_BGT_B_DEPT_INC_MON_FACT
	{
        public static int ApplyFactData(string dataId, out string msg)
        {
            int succeed = 0;
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = "p_factid";
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

                    cmd.CommandText = "SP_bgt_pub_inc_fact_data";
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
