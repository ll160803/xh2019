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
	public partial class HelperObject_V_BGT_B_FUND_EXE_ADD_UPDATE
	{
        public static decimal[] QuerySUM(CauseObject_V_BGT_B_FUND_EXE_ADD_UPDATE cause)
        {
            List<decimal> list = new List<decimal>();
            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            //, BGT_B_DEPT_PAY_YEAR_FUND.CONTROL_MONEY
            string sSql = " select  nvl(SUM(V_BGT_B_FUND_EXE_ADD_UPDATE.FUND_MONEY),0)  MONEY, nvl(sum(V_BGT_B_FUND_EXE_ADD_UPDATE.CONTROL_MONEY), 0) CONTROL_MONEY from V_BGT_B_FUND_EXE_ADD_UPDATE where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            #region Push Block

            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                if (!sqlReader.IsDBNull(0))
                {
                    decimal money = sqlReader.GetDecimal(0);
                    list.Add(money);
                }
                if (!sqlReader.IsDBNull(1))
                {
                    decimal controlMoney = sqlReader.GetDecimal(1);
                    list.Add(controlMoney);
                }
            }
            sqlReader.Close();

            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            return list.ToArray();
        }
     
   
	}
}
