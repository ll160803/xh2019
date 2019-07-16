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

	public partial class HelperObject_BGT_B_BUDGET_DATA
	{
        public static int PubPlanData(string dataId, out string msg)
        {
            int succeed = 0;
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = "p_dataid";
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

                    cmd.CommandText = "SP_bgt_pub_plan_data";
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
        public static int PubPayData(string dataId, out string msg)
        {
            int succeed = 0;
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = "p_dataid";
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

                    cmd.CommandText = "SP_bgt_pub_pay_data";
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
        public static int PubIncomeData(string dataId, out string msg)
        {
            int succeed = 0;
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = "p_dataid";
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

                    cmd.CommandText = "SP_bgt_pub_inc_data";
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
        public static int UndoSubmitPlanData(string budgetDeptId, string budgetYearId, string templateId,IDbTransaction trans)
        {
            OracleParameter[] parameters = new OracleParameter[0];
            string sSql = string.Format(@"
declare v_dept_year_data_id char(36);
begin
select id into v_dept_year_data_id from BGT_B_DEPT_PLAN_YEAR where templet_id = '{0}' and budget_year='{1}' and budget_dept_id = '{2}';
update BGT_B_DEPT_PLAN_YEAR set state = 1 where id = v_dept_year_data_id;
delete from bgt_b_budget_data_dept where ref_tab_id = v_dept_year_data_id;
delete from bgt_b_budget_data_d where ref_tab_id in(select id from BGT_B_DEPT_PLAN_YEAR_D where base_id =v_dept_year_data_id);
end;", templateId, budgetYearId, budgetDeptId);
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static int UndoSubmitIncomeData(string budgetDeptId, string budgetYearId, string templateId, IDbTransaction trans)
        {
            OracleParameter[] parameters = new OracleParameter[0];
            string sSql = string.Format(@"
declare v_dept_year_data_id char(36);
begin
select id into v_dept_year_data_id from BGT_B_DEPT_INC_YEAR where templet_id = '{0}' and budget_year='{1}' and budget_dept_id = '{2}';
update BGT_B_DEPT_INC_YEAR set state = 1 where id = v_dept_year_data_id;
delete from bgt_b_budget_data_dept where ref_tab_id = v_dept_year_data_id;
delete from bgt_b_budget_data_d where ref_tab_id in(select id from BGT_B_DEPT_INC_YEAR_D where base_id =v_dept_year_data_id);
end;", templateId, budgetYearId, budgetDeptId); 
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static int UndoSubmitPayData(string budgetDeptId, string budgetYearId, string templateId, IDbTransaction trans)
        {
            OracleParameter[] parameters = new OracleParameter[0];
            string sSql = string.Format(@"
declare v_dept_year_data_id char(36);
begin
select id into v_dept_year_data_id from BGT_B_DEPT_PAY_YEAR where templet_id = '{0}' and budget_year='{1}' and budget_dept_id = '{2}';
update BGT_B_DEPT_PAY_YEAR set state = 1 where id = v_dept_year_data_id;
delete from bgt_b_budget_data_dept where ref_tab_id = v_dept_year_data_id;
delete from bgt_b_budget_data_d where ref_tab_id in(select id from BGT_B_DEPT_PAY_YEAR_D where base_id =v_dept_year_data_id);
end;", templateId, budgetYearId, budgetDeptId); 
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
	}
}
