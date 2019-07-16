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

	public partial class HelperObject_BGT_D_BUDGET_PATTERN
	{
        public static decimal GetRepeartBudgetYear(IDbTransaction trans)
        {
            string sSql = @"select count(*) from (select budget_year,count(*) rpt  from BGT_D_BUDGET_PATTERN group by budget_year) t where t.rpt > 1";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[0];          
            #endregion
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
            decimal rpt = 0;
            while (sqlReader.Read())
            {
                if (!sqlReader.IsDBNull(0))
                    rpt = sqlReader.GetDecimal(0);
            }
            sqlReader.Close();
            return rpt;
        }
	}
}
