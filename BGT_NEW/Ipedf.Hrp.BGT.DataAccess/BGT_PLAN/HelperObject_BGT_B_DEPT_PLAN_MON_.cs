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

	public partial class HelperObject_BGT_B_DEPT_PLAN_MON
	{
        public static int Calculate(string yearId,string deptId, out string msg)
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
                    p2.ParameterName = "p_deptid";
                    p2.Direction = ParameterDirection.Input;
                    p2.Size = 36;
                    p2.OracleType = OracleType.Char;
                    p2.Value = deptId;
                    cmd.Parameters.Add(p2);


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

                    cmd.CommandText = "SP_bgt_Cal_dept_plan_month";
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
