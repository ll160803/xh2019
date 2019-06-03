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

    public partial class HelperObject_SCM_D_REPORT
    {
        public static int Save(EntityObject_SCM_D_REPORT obj, IDbTransaction trans)
        {

            //平台自动生成代码
            if (string.IsNullOrEmpty(obj.ID))
            {
                obj.ID = Guid.NewGuid().ToString();
            }
            string sSql = "insert into SCM_D_REPORT( DATA_ORGANISE_ID, ID, CREATE_DEPART_ID, CREATE_USER_ID, STATE, NAME, CREATE_TIME, CODE, COMMENTS) values ( :DATA_ORGANISE_ID, :ID, :CREATE_DEPART_ID, :CREATE_USER_ID, :STATE, :NAME, :CREATE_TIME, :CODE, :COMMENTS)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[9];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":DATA_ORGANISE_ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.DATA_ORGANISE_ID == null ? String.Empty : obj.DATA_ORGANISE_ID;
            parameters[1] = new OracleParameter();
            parameters[1].ParameterName = ":ID";
            parameters[1].Size = 36;
            parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[1].Value = obj.ID == null ? String.Empty : obj.ID;
            parameters[2] = new OracleParameter();
            parameters[2].ParameterName = ":CREATE_DEPART_ID";
            parameters[2].Size = 36;
            parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[2].Value = obj.CREATE_DEPART_ID == null ? String.Empty : obj.CREATE_DEPART_ID;
            parameters[3] = new OracleParameter();
            parameters[3].ParameterName = ":CREATE_USER_ID";
            parameters[3].Size = 36;
            parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[3].Value = obj.CREATE_USER_ID == null ? String.Empty : obj.CREATE_USER_ID;
            parameters[4] = new OracleParameter();
            parameters[4].ParameterName = ":STATE";
            parameters[4].Size = 22;
            parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[4].Value = obj.STATE;
            parameters[5] = new OracleParameter();
            parameters[5].ParameterName = ":NAME";
            parameters[5].Size = 500;
            parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[5].Value = obj.NAME == null ? String.Empty : obj.NAME;
            parameters[6] = new OracleParameter();
            parameters[6].ParameterName = ":CREATE_TIME";
            parameters[6].Size = 7;
            parameters[6].OracleType = System.Data.OracleClient.OracleType.DateTime;
            parameters[6].Value = obj.CREATE_TIME;
            parameters[7] = new OracleParameter();
            parameters[7].ParameterName = ":CODE";
            parameters[7].Size = 50;
            parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[7].Value = obj.CODE == null ? String.Empty : obj.CODE;
            parameters[8] = new OracleParameter();
            parameters[8].ParameterName = ":COMMENTS";
            parameters[8].Size = 3000;
            parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[8].Value = obj.COMMENTS == null ? String.Empty : obj.COMMENTS;
            #endregion
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
    }
}
