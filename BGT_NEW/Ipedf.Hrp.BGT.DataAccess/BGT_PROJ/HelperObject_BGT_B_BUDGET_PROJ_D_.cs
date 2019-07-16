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
	public partial class HelperObject_BGT_B_BUDGET_PROJ_D
	{
        public static int PrepareAvilableMoney(EntityObject_BGT_B_BUDGET_PROJ_D obj, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            string sSql = "update BGT_B_BUDGET_PROJ_D t set t.AVAILABLE_MONEY = t.REPLY_MONEY + t.ADJUST_MONEY - t.EXECUTED_MONEY where t.id =:ID";
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
	}
}
