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
    public partial class HelperObject_BGT_B_CPN_INC_PERSONFUND
    {
        public static int UpdatePfDD(EntityObject_BGT_B_CPN_INC_PERSONFUND obj, IDbTransaction trans)
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

            string sSql = @"update BGT_B_CPN_INC_PF_D_D d
                            set d.Item_code = (select code from bgt_d_budget_item t where t.id = d.item_id) 
                            where d.base_id in (select id from BGT_B_CPN_INC_PF_D where base_id = :ID) ";

            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static int UpdatePfD(EntityObject_BGT_B_CPN_INC_PERSONFUND obj, IDbTransaction trans)
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

            string sSql = @"update BGT_B_CPN_INC_PF_D t
                            set t.total_money = (select nvl(sum(d.money), 0) from BGT_B_CPN_INC_PF_D_D d where d.base_id = t.id) 
                            where t.base_id = :ID";

            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static int UpdateTotalMoney(EntityObject_BGT_B_CPN_INC_PERSONFUND obj, IDbTransaction trans)
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

            string sSql = @"update BGT_B_CPN_INC_PERSONFUND b
                            set b.total_money = (select nvl(sum(t.total_money), 0) from BGT_B_CPN_INC_PF_D t where t.base_id = b.id)
                            where b.id = :ID";

            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
    }
}
