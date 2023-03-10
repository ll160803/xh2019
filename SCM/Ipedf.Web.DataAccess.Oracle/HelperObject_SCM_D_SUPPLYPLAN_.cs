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
        /// <summary>
        /// 总务方式
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
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
                    OracleParameter[] parameters = new OracleParameter[48];
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
                        parameters[11].Value = obj.HSDAT.Value;
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
                    if (obj.FPRQ == null)
                    {
                        parameters[16].Value = DBNull.Value;
                    }
                    else
                    {
                        parameters[16].Value = obj.FPRQ.Value;
                    }
                   
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
                    parameters[39].ParameterName = "BSART";
                    parameters[39].Size = 4;
                    parameters[39].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[39].Value = obj.BSART == null ? String.Empty : obj.BSART;

                    parameters[40] = new OracleParameter();
                    parameters[40].ParameterName = "LINK_PERSON";
                    parameters[40].Size = 50;
                    parameters[40].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[40].Value = obj.LINK_PERSON == null ? String.Empty : obj.LINK_PERSON;

                    parameters[41] = new OracleParameter();
                    parameters[41].ParameterName = "SEND_DEPART";
                    parameters[41].Size = 36;
                    parameters[41].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[41].Value = obj.SEND_DEPART == null ? String.Empty : obj.SEND_DEPART;

                    parameters[42] = new OracleParameter();
                    parameters[42].ParameterName = "LINK_TELEPHONE";
                    parameters[42].Size = 50;
                    parameters[42].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[42].Value = obj.LINK_TELEPHONE == null ? String.Empty : obj.LINK_TELEPHONE;

                    parameters[43] = new OracleParameter();
                    parameters[43].ParameterName = "MATER_CODE";
                    parameters[43].Size = 100;
                    parameters[43].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[43].Value = obj.MATER_CODE == null ? String.Empty : obj.MATER_CODE;

                    parameters[44] = new OracleParameter();
                    parameters[44].ParameterName = "SEND_ORDER_CODE";
                    parameters[44].Size = 12;
                    parameters[44].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[44].Value = obj.SEND_ORDER_CODE == null ? String.Empty : obj.SEND_ORDER_CODE;

                    parameters[45] = new OracleParameter();
                    parameters[45].ParameterName = "CODE";
                    parameters[45].Size = 20;
                    parameters[45].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[45].Direction = ParameterDirection.Output;

                    parameters[46] = new OracleParameter();
                    parameters[46].ParameterName = "OUT_CAUSE";
                    parameters[46].Size = 12;
                    parameters[46].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[46].Value = obj.OUT_CAUSE == null ? String.Empty : obj.OUT_CAUSE;

                    parameters[47] = new OracleParameter();
                    parameters[47].ParameterName = "OUT_DATE";
                    parameters[47].Size = 7;
                    parameters[47].OracleType = System.Data.OracleClient.OracleType.DateTime;
                    parameters[47].Value = obj.OUT_DATE == null ? DateTime.MinValue : obj.OUT_DATE;
                    #endregion

                    cmd.CommandText = "SP_scm_supply_save";
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    cmd.ExecuteNonQuery();
                    obj.CODE = parameters[45].Value.ToString();
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
        public static string PrepareUpdate(EntityObject_SCM_D_SUPPLYPLAN obj, out OracleParameter[] parameters)
        {

            //平台自动生成代码
            List<string> strBuf = new List<string>();
            ArrayList paramList = new ArrayList();
            OracleParameter param = null;
            #region Push Block
            if (!obj.IsNotUpdate("PKG_AMOUNT"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.PKG_AMOUNT = :PKG_AMOUNT");
                param = new OracleParameter();
                param.ParameterName = ":PKG_AMOUNT";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.PKG_AMOUNT;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("NAME"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.NAME = :NAME");
                param = new OracleParameter();
                param.ParameterName = ":NAME";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("FREEUSE2"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.FREEUSE2 = :FREEUSE2");
                param = new OracleParameter();
                param.ParameterName = ":FREEUSE2";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.FREEUSE2) ? string.Empty : obj.FREEUSE2;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("FREEUSE3"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.FREEUSE3 = :FREEUSE3");
                param = new OracleParameter();
                param.ParameterName = ":FREEUSE3";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 100;
                param.Value = string.IsNullOrEmpty(obj.FREEUSE3) ? string.Empty : obj.FREEUSE3;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("BEDAT"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.BEDAT = :BEDAT");
                param = new OracleParameter();
                param.ParameterName = ":BEDAT";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 8;
                param.Value = string.IsNullOrEmpty(obj.BEDAT) ? string.Empty : obj.BEDAT;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("FPJR"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.FPJR = :FPJR");
                param = new OracleParameter();
                param.ParameterName = ":FPJR";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.FPJR;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("MODIFY_DEPART_ID"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.MODIFY_DEPART_ID = :MODIFY_DEPART_ID");
                param = new OracleParameter();
                param.ParameterName = ":MODIFY_DEPART_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPART_ID) ? string.Empty : obj.MODIFY_DEPART_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("HSDAT"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.HSDAT = :HSDAT");
                param = new OracleParameter();
                param.ParameterName = ":HSDAT";
                param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                param.Size = 7;
                param.Value = obj.HSDAT;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("STATUS"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.STATUS = :STATUS");
                param = new OracleParameter();
                param.ParameterName = ":STATUS";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 1;
                param.Value = string.IsNullOrEmpty(obj.STATUS) ? string.Empty : obj.STATUS;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
                param = new OracleParameter();
                param.ParameterName = ":DATA_ORGANISE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("LINK_PERSON"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.LINK_PERSON = :LINK_PERSON");
                param = new OracleParameter();
                param.ParameterName = ":LINK_PERSON";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.LINK_PERSON) ? string.Empty : obj.LINK_PERSON;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("CODE"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.CODE = :CODE");
                param = new OracleParameter();
                param.ParameterName = ":CODE";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("BSART"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.BSART = :BSART");
                param = new OracleParameter();
                param.ParameterName = ":BSART";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 4;
                param.Value = string.IsNullOrEmpty(obj.BSART) ? string.Empty : obj.BSART;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("MODIFY_TIME"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.MODIFY_TIME = :MODIFY_TIME");
                param = new OracleParameter();
                param.ParameterName = ":MODIFY_TIME";
                param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                param.Size = 7;
                param.Value = obj.MODIFY_TIME;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("NETPR"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.NETPR = :NETPR");
                param = new OracleParameter();
                param.ParameterName = ":NETPR";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 20;
                param.Value = string.IsNullOrEmpty(obj.NETPR) ? string.Empty : obj.NETPR;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("SEND_ORDER_CODE"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.SEND_ORDER_CODE = :SEND_ORDER_CODE");
                param = new OracleParameter();
                param.ParameterName = ":SEND_ORDER_CODE";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 20;
                param.Value = string.IsNullOrEmpty(obj.SEND_ORDER_CODE) ? string.Empty : obj.SEND_ORDER_CODE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("FPBM"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.FPBM = :FPBM");
                param = new OracleParameter();
                param.ParameterName = ":FPBM";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 200;
                param.Value = string.IsNullOrEmpty(obj.FPBM) ? string.Empty : obj.FPBM;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("MEINS"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.MEINS = :MEINS");
                param = new OracleParameter();
                param.ParameterName = ":MEINS";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.MEINS) ? string.Empty : obj.MEINS;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("CHARG"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.CHARG = :CHARG");
                param = new OracleParameter();
                param.ParameterName = ":CHARG";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.CHARG) ? string.Empty : obj.CHARG;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("SEND_DEPART"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.SEND_DEPART = :SEND_DEPART");
                param = new OracleParameter();
                param.ParameterName = ":SEND_DEPART";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.SEND_DEPART) ? string.Empty : obj.SEND_DEPART;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("WERKST"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.WERKST = :WERKST");
                param = new OracleParameter();
                param.ParameterName = ":WERKST";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.WERKST) ? string.Empty : obj.WERKST;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("FREEUSE1"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.FREEUSE1 = :FREEUSE1");
                param = new OracleParameter();
                param.ParameterName = ":FREEUSE1";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 10;
                param.Value = string.IsNullOrEmpty(obj.FREEUSE1) ? string.Empty : obj.FREEUSE1;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("EEIND"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.EEIND = :EEIND");
                param = new OracleParameter();
                param.ParameterName = ":EEIND";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 8;
                param.Value = string.IsNullOrEmpty(obj.EEIND) ? string.Empty : obj.EEIND;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("STATE"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.STATE = :STATE");
                param = new OracleParameter();
                param.ParameterName = ":STATE";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.STATE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("UNINFORMED_STATE"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.UNINFORMED_STATE = :UNINFORMED_STATE");
                param = new OracleParameter();
                param.ParameterName = ":UNINFORMED_STATE";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 1;
                param.Value = string.IsNullOrEmpty(obj.UNINFORMED_STATE) ? string.Empty : obj.UNINFORMED_STATE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("INFORMED_STATE"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.INFORMED_STATE = :INFORMED_STATE");
                param = new OracleParameter();
                param.ParameterName = ":INFORMED_STATE";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 1;
                param.Value = string.IsNullOrEmpty(obj.INFORMED_STATE) ? string.Empty : obj.INFORMED_STATE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("LGORT"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.LGORT = :LGORT");
                param = new OracleParameter();
                param.ParameterName = ":LGORT";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 200;
                param.Value = string.IsNullOrEmpty(obj.LGORT) ? string.Empty : obj.LGORT;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("TXZ01"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.TXZ01 = :TXZ01");
                param = new OracleParameter();
                param.ParameterName = ":TXZ01";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 200;
                param.Value = string.IsNullOrEmpty(obj.TXZ01) ? string.Empty : obj.TXZ01;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("LINK_TELEPHONE"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.LINK_TELEPHONE = :LINK_TELEPHONE");
                param = new OracleParameter();
                param.ParameterName = ":LINK_TELEPHONE";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.LINK_TELEPHONE) ? string.Empty : obj.LINK_TELEPHONE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("FPRQ"))//hsc add 发票号码为空的情况
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.FPRQ = :FPRQ");
                param = new OracleParameter();
                param.ParameterName = ":FPRQ";
                param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                param.Size = 7;
                if (obj.FPRQ == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = obj.FPRQ;
                }
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("MENGE"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.MENGE = :MENGE");
                param = new OracleParameter();
                param.ParameterName = ":MENGE";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.MENGE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("PKG_NUMBER"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.PKG_NUMBER = :PKG_NUMBER");
                param = new OracleParameter();
                param.ParameterName = ":PKG_NUMBER";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.PKG_NUMBER;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("MODIFY_USER_ID"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.MODIFY_USER_ID = :MODIFY_USER_ID");
                param = new OracleParameter();
                param.ParameterName = ":MODIFY_USER_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("ORDER_MENGE"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.ORDER_MENGE = :ORDER_MENGE");
                param = new OracleParameter();
                param.ParameterName = ":ORDER_MENGE";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.ORDER_MENGE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("FPHM"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.FPHM = :FPHM");
                param = new OracleParameter();
                param.ParameterName = ":FPHM";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 20;
                param.Value = string.IsNullOrEmpty(obj.FPHM) ? string.Empty : obj.FPHM;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("COMMENTS"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.COMMENTS = :COMMENTS");
                param = new OracleParameter();
                param.ParameterName = ":COMMENTS";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 200;
                param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("GYSNAME"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.GYSNAME = :GYSNAME");
                param = new OracleParameter();
                param.ParameterName = ":GYSNAME";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.GYSNAME) ? string.Empty : obj.GYSNAME;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("MSEHT"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.MSEHT = :MSEHT");
                param = new OracleParameter();
                param.ParameterName = ":MSEHT";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.MSEHT) ? string.Empty : obj.MSEHT;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("GYSACCOUNT"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.GYSACCOUNT = :GYSACCOUNT");
                param = new OracleParameter();
                param.ParameterName = ":GYSACCOUNT";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.GYSACCOUNT) ? string.Empty : obj.GYSACCOUNT;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("EBELN"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.EBELN = :EBELN");
                param = new OracleParameter();
                param.ParameterName = ":EBELN";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.EBELN) ? string.Empty : obj.EBELN;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("WERKS"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.WERKS = :WERKS");
                param = new OracleParameter();
                param.ParameterName = ":WERKS";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 40;
                param.Value = string.IsNullOrEmpty(obj.WERKS) ? string.Empty : obj.WERKS;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("GYJH"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.GYJH = :GYJH");
                param = new OracleParameter();
                param.ParameterName = ":GYJH";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 13;
                param.Value = string.IsNullOrEmpty(obj.GYJH) ? string.Empty : obj.GYJH;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("MATNR"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.MATNR = :MATNR");
                param = new OracleParameter();
                param.ParameterName = ":MATNR";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.MATNR) ? string.Empty : obj.MATNR;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("MATER_CODE"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.MATER_CODE = :MATER_CODE");
                param = new OracleParameter();
                param.ParameterName = ":MATER_CODE";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 100;
                param.Value = string.IsNullOrEmpty(obj.MATER_CODE) ? string.Empty : obj.MATER_CODE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("VFDAT"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.VFDAT = :VFDAT");
                param = new OracleParameter();
                param.ParameterName = ":VFDAT";
                param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                param.Size = 7;
                param.Value = obj.VFDAT;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("OUT_CAUSE"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.OUT_CAUSE = :OUT_CAUSE");
                param = new OracleParameter();
                param.ParameterName = ":OUT_CAUSE";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 10;
                param.Value = string.IsNullOrEmpty(obj.OUT_CAUSE) ? string.Empty : obj.OUT_CAUSE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("OUT_DATE"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.OUT_DATE = :OUT_DATE");
                param = new OracleParameter();
                param.ParameterName = ":OUT_DATE";
                param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                param.Size = 7;
                param.Value = obj.OUT_DATE == null ? DateTime.MinValue : obj.OUT_DATE;
                paramList.Add(param);
            }
            //pk here
            param = new OracleParameter();
            param.ParameterName = ":ID";
            param.OracleType = System.Data.OracleClient.OracleType.Char;
            param.Size = 36;
            param.Value = obj.ID;
            paramList.Add(param);
            #endregion
            parameters = new OracleParameter[paramList.Count];
            paramList.CopyTo(parameters);
            return string.Join(", ", strBuf.ToArray());

        }	
    }
}
