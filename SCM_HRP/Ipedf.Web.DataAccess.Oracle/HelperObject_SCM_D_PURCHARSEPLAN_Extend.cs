using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Data;
using Ipedf.Core;

namespace Ipedf.Web.DataAccess
{
    public partial class HelperObject_SCM_D_PURCHARSEPLAN
    {
        public static int IsAllowAdd(string EBELN, string EBELP, decimal MENGE, string ID)
        {
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter[] parameters = new OracleParameter[5];
                    parameters[0] = new OracleParameter();
                    parameters[0].ParameterName = "t_EBELN";
                    parameters[0].Size = 200;
                    parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[0].Value = EBELN;

                    parameters[1] = new OracleParameter();
                    parameters[1].ParameterName = "t_EBELP";
                    parameters[1].Size = 50;
                    parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[1].Value = EBELP;

                    parameters[2] = new OracleParameter();
                    parameters[2].ParameterName = "t_MENGE";
                    parameters[2].Size = 21;
                    parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
                    parameters[2].Value = MENGE;


                    parameters[3] = new OracleParameter();
                    parameters[3].ParameterName = "t_SUPPLY_ID";
                    parameters[3].Size = 36;
                    parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
                    if (!string.IsNullOrEmpty(ID))
                    {
                        parameters[3].Value = ID;
                    }
                    else
                    {
                        parameters[3].Value ="";
                    }

                    parameters[4] = new OracleParameter();
                    parameters[4].ParameterName = "out_Flag";
                    parameters[4].Direction = System.Data.ParameterDirection.Output;
                    parameters[4].Size = 4;
                    parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;


                    cmd.CommandText = "Sp_SCM_IsAllowAdd";
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    cmd.ExecuteNonQuery();

                    int IsCanAllow = int.Parse(parameters[4].Value.ToString());
                    return IsCanAllow;
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
            return -1;
        }
    }
}
