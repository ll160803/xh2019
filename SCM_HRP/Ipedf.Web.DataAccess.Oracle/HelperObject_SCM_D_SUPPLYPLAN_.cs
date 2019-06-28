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
    public partial class HelperObject_SCM_D_SUPPLYPLAN
    {
        #region Method Blok
        public static int Save(EntityObject_SCM_D_SUPPLYPLAN obj, IDbTransaction trans)
        {
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    //平台自动生成代码
                  //  obj.ID = Guid.NewGuid().ToString();
                   // string sSql = "insert into SCM_D_SUPPLYPLAN( FPHM, CREATE_DEPART_ID, WERKS, FREEUSE3, FPBM, TXZ01, FPJR, LGORT, ID, CREATE_USER_ID, STATE, HSDAT, PKG_NUMBER, MEINS, ORDER_MENGE, STATUS, FPRQ, NETPR, CODE, GYJH, COMMENTS, WERKST, FREEUSE1, CHARG, MSEHT, MATNR, GYSACCOUNT, UNINFORMED_STATE, CREATE_TIME, GYSNAME, NAME, MENGE, PKG_AMOUNT, DATA_ORGANISE_ID, FREEUSE2, EBELN, BEDAT, VFDAT, INFORMED_STATE, EEIND) values ( :FPHM, :CREATE_DEPART_ID, :WERKS, :FREEUSE3, :FPBM, :TXZ01, :FPJR, :LGORT, :ID, :CREATE_USER_ID, :STATE, :HSDAT, :PKG_NUMBER, :MEINS, :ORDER_MENGE, :STATUS, :FPRQ, :NETPR, SCM_D_SUPPLY_SEQ.nextval, :GYJH, :COMMENTS, :WERKST, :FREEUSE1, :CHARG, :MSEHT, :MATNR, :GYSACCOUNT, :UNINFORMED_STATE, :CREATE_TIME, :GYSNAME, :NAME, :MENGE, :PKG_AMOUNT, :DATA_ORGANISE_ID, :FREEUSE2, :EBELN, :BEDAT, :VFDAT, :INFORMED_STATE, :EEIND); select SCM_D_SUPPLY_SEQ.CURRVAL into CODE from dual;";
                    #region Parameters Block
                    OracleParameter[] parameters = new OracleParameter[40];
                    parameters[0] = new OracleParameter();
                    parameters[0].ParameterName = "FPHM";
                    parameters[0].Size = 20;
                    parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[0].Value = obj.FPHM == null ? String.Empty : obj.FPHM;
                    parameters[1] = new OracleParameter();
                    parameters[1].ParameterName = "CREATE_DEPART_ID";
                    parameters[1].Size = 36;
                    parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[1].Value = obj.CREATE_DEPART_ID == null ? String.Empty : obj.CREATE_DEPART_ID;
                    parameters[2] = new OracleParameter();
                    parameters[2].ParameterName = "WERKS";
                    parameters[2].Size = 40;
                    parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[2].Value = obj.WERKS == null ? String.Empty : obj.WERKS;
                    parameters[3] = new OracleParameter();
                    parameters[3].ParameterName = "FREEUSE3";
                    parameters[3].Size = 100;
                    parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[3].Value = obj.FREEUSE3 == null ? String.Empty : obj.FREEUSE3;
                    parameters[4] = new OracleParameter();
                    parameters[4].ParameterName = "FPBM";
                    parameters[4].Size = 200;
                    parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[4].Value = obj.FPBM == null ? String.Empty : obj.FPBM;
                    parameters[5] = new OracleParameter();
                    parameters[5].ParameterName = "TXZ01";
                    parameters[5].Size = 200;
                    parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[5].Value = obj.TXZ01 == null ? String.Empty : obj.TXZ01;
                    parameters[6] = new OracleParameter();
                    parameters[6].ParameterName = "FPJR";
                    parameters[6].Size = 22;
                    parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
                    parameters[6].Value = obj.FPJR;
                    parameters[7] = new OracleParameter();
                    parameters[7].ParameterName = "LGORT";
                    parameters[7].Size = 200;
                    parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[7].Value = obj.LGORT == null ? String.Empty : obj.LGORT;
                    parameters[8] = new OracleParameter();
                    parameters[8].ParameterName = "ID";
                    parameters[8].Size = 36;
                    parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[8].Value = obj.ID == null ? String.Empty : obj.ID;
                    parameters[9] = new OracleParameter();
                    parameters[9].ParameterName = "CREATE_USER_ID";
                    parameters[9].Size = 36;
                    parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[9].Value = obj.CREATE_USER_ID == null ? String.Empty : obj.CREATE_USER_ID;
                    parameters[10] = new OracleParameter();
                    parameters[10].ParameterName = "STATE";
                    parameters[10].Size = 22;
                    parameters[10].OracleType = System.Data.OracleClient.OracleType.Number;
                    parameters[10].Value = obj.STATE;
                    parameters[11] = new OracleParameter();
                    parameters[11].ParameterName = "HSDAT";
                    parameters[11].Size = 7;
                    parameters[11].OracleType = System.Data.OracleClient.OracleType.DateTime;
                    if (obj.HSDAT == null)
                    {
                        parameters[11].Value = DBNull.Value;
                    }
                    else
                    {
                        parameters[11].Value =obj.HSDAT.Value;
                    }
                    
                    parameters[12] = new OracleParameter();
                    parameters[12].ParameterName = "PKG_NUMBER";
                    parameters[12].Size = 22;
                    parameters[12].OracleType = System.Data.OracleClient.OracleType.Number;
                    parameters[12].Value = obj.PKG_NUMBER;
                    parameters[13] = new OracleParameter();
                    parameters[13].ParameterName = "MEINS";
                    parameters[13].Size = 50;
                    parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[13].Value = obj.MEINS == null ? String.Empty : obj.MEINS;
                    parameters[14] = new OracleParameter();
                    parameters[14].ParameterName = "ORDER_MENGE";
                    parameters[14].Size = 22;
                    parameters[14].OracleType = System.Data.OracleClient.OracleType.Number;
                    parameters[14].Value = obj.ORDER_MENGE;
                    parameters[15] = new OracleParameter();
                    parameters[15].ParameterName = "STATUS";
                    parameters[15].Size = 1;
                    parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[15].Value = obj.STATUS == null ? String.Empty : obj.STATUS;
                    parameters[16] = new OracleParameter();
                    parameters[16].ParameterName = "FPRQ";
                    parameters[16].Size = 7;
                    parameters[16].OracleType = System.Data.OracleClient.OracleType.DateTime;
                    parameters[16].Value = obj.FPRQ;
                    parameters[17] = new OracleParameter();
                    parameters[17].ParameterName = "NETPR";
                    parameters[17].Size = 20;
                    parameters[17].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[17].Value = obj.NETPR == null ? String.Empty : obj.NETPR;

                    //parameters[18] = new OracleParameter();
                    //parameters[18].ParameterName ="CODE";
                    //parameters[18].Size = 50;
                    //parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    //parameters[18].Value = obj.CODE == null ? String.Empty:obj.CODE;

                    parameters[18] = new OracleParameter();
                    parameters[18].ParameterName = "GYJH";
                    parameters[18].Size = 13;
                    parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[18].Value = obj.GYJH == null ? String.Empty : obj.GYJH;
                    parameters[19] = new OracleParameter();
                    parameters[19].ParameterName = "COMMENTS";
                    parameters[19].Size = 1000;
                    parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[19].Value = obj.COMMENTS == null ? String.Empty : obj.COMMENTS;
                    parameters[20] = new OracleParameter();
                    parameters[20].ParameterName = "WERKST";
                    parameters[20].Size = 50;
                    parameters[20].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[20].Value = obj.WERKST == null ? String.Empty : obj.WERKST;
                    parameters[21] = new OracleParameter();
                    parameters[21].ParameterName = "FREEUSE1";
                    parameters[21].Size = 10;
                    parameters[21].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[21].Value = obj.FREEUSE1 == null ? String.Empty : obj.FREEUSE1;
                    parameters[22] = new OracleParameter();
                    parameters[22].ParameterName = "CHARG";
                    parameters[22].Size = 50;
                    parameters[22].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[22].Value = obj.CHARG == null ? String.Empty : obj.CHARG;
                    parameters[23] = new OracleParameter();
                    parameters[23].ParameterName = "MSEHT";
                    parameters[23].Size = 50;
                    parameters[23].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[23].Value = obj.MSEHT == null ? String.Empty : obj.MSEHT;
                    parameters[24] = new OracleParameter();
                    parameters[24].ParameterName = "MATNR";
                    parameters[24].Size = 50;
                    parameters[24].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[24].Value = obj.MATNR == null ? String.Empty : obj.MATNR;
                    parameters[25] = new OracleParameter();
                    parameters[25].ParameterName = "GYSACCOUNT";
                    parameters[25].Size = 50;
                    parameters[25].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[25].Value = obj.GYSACCOUNT == null ? String.Empty : obj.GYSACCOUNT;
                    parameters[26] = new OracleParameter();
                    parameters[26].ParameterName = "UNINFORMED_STATE";
                    parameters[26].Size = 1;
                    parameters[26].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[26].Value = obj.UNINFORMED_STATE == null ? String.Empty : obj.UNINFORMED_STATE;
                    parameters[27] = new OracleParameter();
                    parameters[27].ParameterName = "CREATE_TIME";
                    parameters[27].Size = 7;
                    parameters[27].OracleType = System.Data.OracleClient.OracleType.DateTime;
                    parameters[27].Value = obj.CREATE_TIME;
                    parameters[28] = new OracleParameter();
                    parameters[28].ParameterName = "GYSNAME";
                    parameters[28].Size = 200;
                    parameters[28].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[28].Value = obj.GYSNAME == null ? String.Empty : obj.GYSNAME;
                    parameters[29] = new OracleParameter();
                    parameters[29].ParameterName = "NAME";
                    parameters[29].Size = 50;
                    parameters[29].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[29].Value = obj.NAME == null ? String.Empty : obj.NAME;
                    parameters[30] = new OracleParameter();
                    parameters[30].ParameterName = "MENGE";
                    parameters[30].Size = 22;
                    parameters[30].OracleType = System.Data.OracleClient.OracleType.Number;
                    parameters[30].Value = obj.MENGE;
                    parameters[31] = new OracleParameter();
                    parameters[31].ParameterName = "PKG_AMOUNT";
                    parameters[31].Size = 22;
                    parameters[31].OracleType = System.Data.OracleClient.OracleType.Number;
                    parameters[31].Value = obj.PKG_AMOUNT;
                    parameters[32] = new OracleParameter();
                    parameters[32].ParameterName = "DATA_ORGANISE_ID";
                    parameters[32].Size = 36;
                    parameters[32].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[32].Value = obj.DATA_ORGANISE_ID == null ? String.Empty : obj.DATA_ORGANISE_ID;
                    parameters[33] = new OracleParameter();
                    parameters[33].ParameterName = "FREEUSE2";
                    parameters[33].Size = 50;
                    parameters[33].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[33].Value = obj.FREEUSE2 == null ? String.Empty : obj.FREEUSE2;
                    parameters[34] = new OracleParameter();
                    parameters[34].ParameterName = "EBELN";
                    parameters[34].Size = 50;
                    parameters[34].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[34].Value = obj.EBELN == null ? String.Empty : obj.EBELN;
                    parameters[35] = new OracleParameter();
                    parameters[35].ParameterName = "BEDAT";
                    parameters[35].Size = 8;
                    parameters[35].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[35].Value = obj.BEDAT == null ? String.Empty : obj.BEDAT;
                    parameters[36] = new OracleParameter();
                    parameters[36].ParameterName = "VFDAT";
                    parameters[36].Size = 7;
                    parameters[36].OracleType = System.Data.OracleClient.OracleType.DateTime;
                    parameters[36].Value = obj.VFDAT;
                    parameters[37] = new OracleParameter();
                    parameters[37].ParameterName = "INFORMED_STATE";
                    parameters[37].Size = 1;
                    parameters[37].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[37].Value = obj.INFORMED_STATE == null ? String.Empty : obj.INFORMED_STATE;
                    parameters[38] = new OracleParameter();
                    parameters[38].ParameterName = "EEIND";
                    parameters[38].Size = 10;
                    parameters[38].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[38].Value = obj.EEIND == null ? String.Empty : obj.EEIND;

                    parameters[39] = new OracleParameter();
                    parameters[39].ParameterName = "CODE";
                    parameters[39].Size = 20;
                    parameters[39].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[39].Direction = ParameterDirection.Output;
                    #endregion

                    cmd.CommandText = "SP_scm_supply_save";
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    cmd.ExecuteNonQuery();
                    obj.CODE = parameters[39].Value.ToString();
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
            return 1;


        }
       
        #endregion
    }
}
