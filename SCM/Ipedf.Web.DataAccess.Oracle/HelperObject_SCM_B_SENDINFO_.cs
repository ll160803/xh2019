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
    public partial class HelperObject_SCM_B_SENDINFO
    {

        public static int Save(EntityObject_SCM_B_SENDINFO obj, IDbTransaction trans)
        {

            //平台自动生成代码
            obj.ID = Guid.NewGuid().ToString();
            string sSql = "insert into SCM_B_SENDINFO( NAME, ID, AMOUNT, DATA_ORGANISE_ID, LINK_PERSON, CODE, CREATE_TIME, PRICE, MATER_CODE, SEND_DEPART, STATE, MONEY, TXZ01, LINK_TELEPHONE, CREATE_USER_ID, COMMENTS, GYSNAME, CREATE_DEPART_ID, MSEHT, GYSACCOUNT, MEINS, MATNR,WERKS) values ( :NAME, :ID, :AMOUNT, :DATA_ORGANISE_ID, :LINK_PERSON, SCM_B_SENDINFO_SEQ.nextval, :CREATE_TIME, :PRICE, :MATER_CODE, :SEND_DEPART, :STATE, :MONEY, :TXZ01, :LINK_TELEPHONE, :CREATE_USER_ID, :COMMENTS, :GYSNAME, :CREATE_DEPART_ID, :MSEHT, :GYSACCOUNT, :MEINS, :MATNR, :WERKS)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[22];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":NAME";
            parameters[0].Size = 50;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[0].Value = obj.NAME == null ? String.Empty : obj.NAME;
            parameters[1] = new OracleParameter();
            parameters[1].ParameterName = ":ID";
            parameters[1].Size = 36;
            parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[1].Value = obj.ID == null ? String.Empty : obj.ID;
            parameters[2] = new OracleParameter();
            parameters[2].ParameterName = ":AMOUNT";
            parameters[2].Size = 22;
            parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[2].Value = obj.AMOUNT;
            parameters[3] = new OracleParameter();
            parameters[3].ParameterName = ":DATA_ORGANISE_ID";
            parameters[3].Size = 36;
            parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[3].Value = obj.DATA_ORGANISE_ID == null ? String.Empty : obj.DATA_ORGANISE_ID;
            parameters[4] = new OracleParameter();
            parameters[4].ParameterName = ":LINK_PERSON";
            parameters[4].Size = 50;
            parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[4].Value = obj.LINK_PERSON == null ? String.Empty : obj.LINK_PERSON;
            //parameters[5] = new OracleParameter();
            //parameters[5].ParameterName = ":CODE";
            //parameters[5].Size = 12;
            //parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
            //parameters[5].Value = obj.CODE == null ? String.Empty : obj.CODE;
            parameters[5] = new OracleParameter();
            parameters[5].ParameterName = ":CREATE_TIME";
            parameters[5].Size = 7;
            parameters[5].OracleType = System.Data.OracleClient.OracleType.DateTime;
            parameters[5].Value = obj.CREATE_TIME;
            parameters[6] = new OracleParameter();
            parameters[6].ParameterName = ":PRICE";
            parameters[6].Size = 22;
            parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[6].Value = obj.PRICE;
            parameters[7] = new OracleParameter();
            parameters[7].ParameterName = ":MATER_CODE";
            parameters[7].Size = 100;
            parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[7].Value = obj.MATER_CODE == null ? String.Empty : obj.MATER_CODE;
            parameters[8] = new OracleParameter();
            parameters[8].ParameterName = ":SEND_DEPART";
            parameters[8].Size = 36;
            parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[8].Value = obj.SEND_DEPART == null ? String.Empty : obj.SEND_DEPART;
            parameters[9] = new OracleParameter();
            parameters[9].ParameterName = ":STATE";
            parameters[9].Size = 22;
            parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[9].Value = obj.STATE;
            parameters[10] = new OracleParameter();
            parameters[10].ParameterName = ":MONEY";
            parameters[10].Size = 22;
            parameters[10].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[10].Value = obj.MONEY;
            parameters[11] = new OracleParameter();
            parameters[11].ParameterName = ":TXZ01";
            parameters[11].Size = 200;
            parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[11].Value = obj.TXZ01 == null ? String.Empty : obj.TXZ01;
            parameters[12] = new OracleParameter();
            parameters[12].ParameterName = ":LINK_TELEPHONE";
            parameters[12].Size = 50;
            parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[12].Value = obj.LINK_TELEPHONE == null ? String.Empty : obj.LINK_TELEPHONE;
            parameters[13] = new OracleParameter();
            parameters[13].ParameterName = ":CREATE_USER_ID";
            parameters[13].Size = 36;
            parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[13].Value = obj.CREATE_USER_ID == null ? String.Empty : obj.CREATE_USER_ID;
            parameters[14] = new OracleParameter();
            parameters[14].ParameterName = ":COMMENTS";
            parameters[14].Size = 300;
            parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[14].Value = obj.COMMENTS == null ? String.Empty : obj.COMMENTS;
            parameters[15] = new OracleParameter();
            parameters[15].ParameterName = ":GYSNAME";
            parameters[15].Size = 100;
            parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[15].Value = obj.GYSNAME == null ? String.Empty : obj.GYSNAME;
            parameters[16] = new OracleParameter();
            parameters[16].ParameterName = ":CREATE_DEPART_ID";
            parameters[16].Size = 36;
            parameters[16].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[16].Value = obj.CREATE_DEPART_ID == null ? String.Empty : obj.CREATE_DEPART_ID;
            parameters[17] = new OracleParameter();
            parameters[17].ParameterName = ":MSEHT";
            parameters[17].Size = 10;
            parameters[17].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[17].Value = obj.MSEHT == null ? String.Empty : obj.MSEHT;
            parameters[18] = new OracleParameter();
            parameters[18].ParameterName = ":GYSACCOUNT";
            parameters[18].Size = 19;
            parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[18].Value = obj.GYSACCOUNT == null ? String.Empty : obj.GYSACCOUNT;
            parameters[19] = new OracleParameter();
            parameters[19].ParameterName = ":MEINS";
            parameters[19].Size = 3;
            parameters[19].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[19].Value = obj.MEINS == null ? String.Empty : obj.MEINS;
            parameters[20] = new OracleParameter();
            parameters[20].ParameterName = ":MATNR";
            parameters[20].Size = 19;
            parameters[20].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[20].Value = obj.MATNR == null ? String.Empty : obj.MATNR;
            parameters[21] = new OracleParameter();
            parameters[21].ParameterName = ":WERKS";
            parameters[21].Size = 19;
            parameters[21].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[21].Value = obj.WERKS == null ? String.Empty : obj.WERKS;
            #endregion
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
    }
}
