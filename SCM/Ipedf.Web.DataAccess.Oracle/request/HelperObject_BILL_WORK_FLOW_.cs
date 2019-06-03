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
    public partial class HelperObject_BILL_WORK_FLOW
	{
        public static int BillUndoAudit(string billId, string billName, IDbTransaction transaction, out string msg)
        {
            int succeed = 0;
            IDbCommand cmd = transaction.Connection.CreateCommand();
            cmd.Transaction = transaction;
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter p1 = new OracleParameter();
            p1.ParameterName = "p_billid";
            p1.Direction = ParameterDirection.Input;
            p1.Size = 36;
            p1.OracleType = OracleType.Char;
            p1.Value = billId;
            cmd.Parameters.Add(p1);

            OracleParameter p2 = new OracleParameter();
            p2.ParameterName = "p_billname";
            p2.Direction = ParameterDirection.Input;
            p2.Size = 50;
            p2.OracleType = OracleType.VarChar;
            p2.Value = billName;
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

            cmd.CommandText = "SP_BILL_Undo_Audit";
            cmd.ExecuteNonQuery();
            billName = DBNull.Value.Equals(p2.Value) ? string.Empty : (string)p2.Value;
            msg = DBNull.Value.Equals(p3.Value) ? string.Empty : (string)p3.Value;
            succeed = (int)(decimal)p4.Value;
            return succeed;
        }
	}
}
