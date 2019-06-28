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
    [CauseObject(typeof(CauseObject_SCM_D_SUPPLYPLAN))]
    public partial class HelperObject_SCM_D_SUPPLYPLAN
    {
        #region Method Blok
        public static int Update(EntityObject_SCM_D_SUPPLYPLAN obj, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = "update SCM_D_SUPPLYPLAN set ";
            sSql += PrepareUpdate(obj, out parameters);
            sSql += " where  ID = :ID ";
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static int Delete(EntityObject_SCM_D_SUPPLYPLAN obj, IDbTransaction trans)
        {

            //平台自动生成代码
            string sSql = "delete from SCM_D_SUPPLYPLAN where  ID = :ID ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static EntityObject_SCM_D_SUPPLYPLAN Get(EntityObject_SCM_D_SUPPLYPLAN obj)
        {

            //平台自动生成代码
            string sSql = "select  FPHM, CREATE_DEPART_ID, WERKS, FREEUSE3, FPBM, TXZ01, FPJR, LGORT, ID, CREATE_USER_ID, STATE, HSDAT, PKG_NUMBER, MEINS, ORDER_MENGE, STATUS, FPRQ, NETPR, MODIFY_TIME, CODE, GYJH, COMMENTS, WERKST, FREEUSE1, CHARG, MSEHT, MATNR, GYSACCOUNT, UNINFORMED_STATE, CREATE_TIME, GYSNAME, NAME, MENGE, PKG_AMOUNT, DATA_ORGANISE_ID, MODIFY_USER_ID, FREEUSE2, EBELN, BEDAT, VFDAT, INFORMED_STATE, EEIND, MODIFY_DEPART_ID from SCM_D_SUPPLYPLAN where  ID = :ID ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            #region Push Block
            EntityObject_SCM_D_SUPPLYPLAN dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new EntityObject_SCM_D_SUPPLYPLAN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.FPHM = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.WERKS = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.FREEUSE3 = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FPBM = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.TXZ01 = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.FPJR = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.LGORT = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.STATE = sqlReader.GetDecimal(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.HSDAT = sqlReader.GetDateTime(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.PKG_NUMBER = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.MEINS = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.ORDER_MENGE = sqlReader.GetDecimal(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.STATUS = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.FPRQ = sqlReader.GetDateTime(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.NETPR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.CODE = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.GYJH = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.COMMENTS = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.WERKST = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.FREEUSE1 = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.CHARG = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.MSEHT = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.MATNR = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.GYSACCOUNT = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.UNINFORMED_STATE = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.GYSNAME = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.NAME = sqlReader.GetString(31);
                if (!sqlReader.IsDBNull(32))
                    dataObj.MENGE = sqlReader.GetDecimal(32);
                if (!sqlReader.IsDBNull(33))
                    dataObj.PKG_AMOUNT = sqlReader.GetDecimal(33);
                if (!sqlReader.IsDBNull(34))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(34);
                if (!sqlReader.IsDBNull(35))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(35);
                if (!sqlReader.IsDBNull(36))
                    dataObj.FREEUSE2 = sqlReader.GetString(36);
                if (!sqlReader.IsDBNull(37))
                    dataObj.EBELN = sqlReader.GetString(37);
                if (!sqlReader.IsDBNull(38))
                    dataObj.BEDAT = sqlReader.GetString(38);
                if (!sqlReader.IsDBNull(39))
                    dataObj.VFDAT = sqlReader.GetDateTime(39);
                if (!sqlReader.IsDBNull(40))
                    dataObj.INFORMED_STATE = sqlReader.GetString(40);
                if (!sqlReader.IsDBNull(41))
                    dataObj.EEIND = sqlReader.GetString(41);
                if (!sqlReader.IsDBNull(42))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(42);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            EntityObject_SCM_D_SUPPLYPLAN[] objs = new EntityObject_SCM_D_SUPPLYPLAN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
        public static EntityObject_SCM_D_SUPPLYPLAN Get(EntityObject_SCM_D_SUPPLYPLAN obj, IDbTransaction trans)
        {

            //平台自动生成代码
            string sSql = "select  FPHM, CREATE_DEPART_ID, WERKS, FREEUSE3, FPBM, TXZ01, FPJR, LGORT, ID, CREATE_USER_ID, STATE, HSDAT, PKG_NUMBER, MEINS, ORDER_MENGE, STATUS, FPRQ, NETPR, MODIFY_TIME, CODE, GYJH, COMMENTS, WERKST, FREEUSE1, CHARG, MSEHT, MATNR, GYSACCOUNT, UNINFORMED_STATE, CREATE_TIME, GYSNAME, NAME, MENGE, PKG_AMOUNT, DATA_ORGANISE_ID, MODIFY_USER_ID, FREEUSE2, EBELN, BEDAT, VFDAT, INFORMED_STATE, EEIND, MODIFY_DEPART_ID from SCM_D_SUPPLYPLAN where  ID = :ID ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            #region Push Block
            EntityObject_SCM_D_SUPPLYPLAN dataObj = null;
            ArrayList objArray = new ArrayList();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            while (sqlReader.Read())
            {
                dataObj = new EntityObject_SCM_D_SUPPLYPLAN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.FPHM = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.WERKS = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.FREEUSE3 = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FPBM = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.TXZ01 = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.FPJR = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.LGORT = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.STATE = sqlReader.GetDecimal(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.HSDAT = sqlReader.GetDateTime(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.PKG_NUMBER = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.MEINS = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.ORDER_MENGE = sqlReader.GetDecimal(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.STATUS = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.FPRQ = sqlReader.GetDateTime(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.NETPR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.CODE = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.GYJH = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.COMMENTS = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.WERKST = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.FREEUSE1 = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.CHARG = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.MSEHT = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.MATNR = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.GYSACCOUNT = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.UNINFORMED_STATE = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.GYSNAME = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.NAME = sqlReader.GetString(31);
                if (!sqlReader.IsDBNull(32))
                    dataObj.MENGE = sqlReader.GetDecimal(32);
                if (!sqlReader.IsDBNull(33))
                    dataObj.PKG_AMOUNT = sqlReader.GetDecimal(33);
                if (!sqlReader.IsDBNull(34))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(34);
                if (!sqlReader.IsDBNull(35))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(35);
                if (!sqlReader.IsDBNull(36))
                    dataObj.FREEUSE2 = sqlReader.GetString(36);
                if (!sqlReader.IsDBNull(37))
                    dataObj.EBELN = sqlReader.GetString(37);
                if (!sqlReader.IsDBNull(38))
                    dataObj.BEDAT = sqlReader.GetString(38);
                if (!sqlReader.IsDBNull(39))
                    dataObj.VFDAT = sqlReader.GetDateTime(39);
                if (!sqlReader.IsDBNull(40))
                    dataObj.INFORMED_STATE = sqlReader.GetString(40);
                if (!sqlReader.IsDBNull(41))
                    dataObj.EEIND = sqlReader.GetString(41);
                if (!sqlReader.IsDBNull(42))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(42);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            EntityObject_SCM_D_SUPPLYPLAN[] objs = new EntityObject_SCM_D_SUPPLYPLAN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
        public static DisplayObject_SCM_D_SUPPLYPLAN[] List()
        {

            //平台自动生成代码
            string sSql = " select  SCM_D_SUPPLYPLAN.FPHM, SCM_D_SUPPLYPLAN.CREATE_DEPART_ID, SCM_D_SUPPLYPLAN.WERKS, SCM_D_SUPPLYPLAN.FREEUSE3, SCM_D_SUPPLYPLAN.FPBM, SCM_D_SUPPLYPLAN.TXZ01, SCM_D_SUPPLYPLAN.FPJR, SCM_D_SUPPLYPLAN.LGORT, SCM_D_SUPPLYPLAN.ID, SCM_D_SUPPLYPLAN.CREATE_USER_ID, SCM_D_SUPPLYPLAN.STATE, SCM_D_SUPPLYPLAN.HSDAT, SCM_D_SUPPLYPLAN.PKG_NUMBER, SCM_D_SUPPLYPLAN.MEINS, SCM_D_SUPPLYPLAN.ORDER_MENGE, SCM_D_SUPPLYPLAN.STATUS, SCM_D_SUPPLYPLAN.FPRQ, SCM_D_SUPPLYPLAN.NETPR, SCM_D_SUPPLYPLAN.MODIFY_TIME, SCM_D_SUPPLYPLAN.CODE, SCM_D_SUPPLYPLAN.GYJH, SCM_D_SUPPLYPLAN.COMMENTS, SCM_D_SUPPLYPLAN.WERKST, SCM_D_SUPPLYPLAN.FREEUSE1, SCM_D_SUPPLYPLAN.CHARG, SCM_D_SUPPLYPLAN.MSEHT, SCM_D_SUPPLYPLAN.MATNR, SCM_D_SUPPLYPLAN.GYSACCOUNT, SCM_D_SUPPLYPLAN.UNINFORMED_STATE, SCM_D_SUPPLYPLAN.CREATE_TIME, SCM_D_SUPPLYPLAN.GYSNAME, SCM_D_SUPPLYPLAN.NAME, SCM_D_SUPPLYPLAN.MENGE, SCM_D_SUPPLYPLAN.PKG_AMOUNT, SCM_D_SUPPLYPLAN.DATA_ORGANISE_ID, SCM_D_SUPPLYPLAN.MODIFY_USER_ID, SCM_D_SUPPLYPLAN.FREEUSE2, SCM_D_SUPPLYPLAN.EBELN, SCM_D_SUPPLYPLAN.BEDAT, SCM_D_SUPPLYPLAN.VFDAT, SCM_D_SUPPLYPLAN.INFORMED_STATE, SCM_D_SUPPLYPLAN.EEIND, SCM_D_SUPPLYPLAN.MODIFY_DEPART_ID from SCM_D_SUPPLYPLAN where (1=1)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[0];
            #endregion
            #region Push Block
            DisplayObject_SCM_D_SUPPLYPLAN dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_D_SUPPLYPLAN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.FPHM = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.WERKS = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.FREEUSE3 = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FPBM = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.TXZ01 = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.FPJR = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.LGORT = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.STATE = sqlReader.GetDecimal(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.HSDAT = sqlReader.GetDateTime(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.PKG_NUMBER = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.MEINS = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.ORDER_MENGE = sqlReader.GetDecimal(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.STATUS = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.FPRQ = sqlReader.GetDateTime(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.NETPR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.CODE = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.GYJH = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.COMMENTS = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.WERKST = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.FREEUSE1 = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.CHARG = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.MSEHT = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.MATNR = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.GYSACCOUNT = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.UNINFORMED_STATE = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.GYSNAME = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.NAME = sqlReader.GetString(31);
                if (!sqlReader.IsDBNull(32))
                    dataObj.MENGE = sqlReader.GetDecimal(32);
                if (!sqlReader.IsDBNull(33))
                    dataObj.PKG_AMOUNT = sqlReader.GetDecimal(33);
                if (!sqlReader.IsDBNull(34))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(34);
                if (!sqlReader.IsDBNull(35))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(35);
                if (!sqlReader.IsDBNull(36))
                    dataObj.FREEUSE2 = sqlReader.GetString(36);
                if (!sqlReader.IsDBNull(37))
                    dataObj.EBELN = sqlReader.GetString(37);
                if (!sqlReader.IsDBNull(38))
                    dataObj.BEDAT = sqlReader.GetString(38);
                if (!sqlReader.IsDBNull(39))
                    dataObj.VFDAT = sqlReader.GetDateTime(39);
                if (!sqlReader.IsDBNull(40))
                    dataObj.INFORMED_STATE = sqlReader.GetString(40);
                if (!sqlReader.IsDBNull(41))
                    dataObj.EEIND = sqlReader.GetString(41);
                if (!sqlReader.IsDBNull(42))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(42);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SCM_D_SUPPLYPLAN[] objs = new DisplayObject_SCM_D_SUPPLYPLAN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static string PrepareCause(CauseObject_SCM_D_SUPPLYPLAN cause, out OracleParameter[] parameters)
        {

            //平台自动生成代码
            System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
            ArrayList paramList = new ArrayList();
            OracleParameter param = null;
            #region Push Block
            if (!string.IsNullOrEmpty(cause.FPHM))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.FPHM ").Append((cause.FPHM.StartsWith("%") || cause.FPHM.EndsWith("%")) ? " like " : " = ").Append(" :FPHM");
                param = new OracleParameter();
                param.ParameterName = ":FPHM";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 20;
                param.Value = cause.FPHM;
                paramList.Add(param);
            }
            if (cause.HasINValue("FPHM"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FPHM"));
            }
            if (!string.IsNullOrEmpty(cause.CREATE_DEPART_ID))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.CREATE_DEPART_ID ").Append((cause.CREATE_DEPART_ID.StartsWith("%") || cause.CREATE_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPART_ID");
                param = new OracleParameter();
                param.ParameterName = ":CREATE_DEPART_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.CREATE_DEPART_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("CREATE_DEPART_ID"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "CREATE_DEPART_ID"));
            }
            if (!string.IsNullOrEmpty(cause.WERKS))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.WERKS ").Append((cause.WERKS.StartsWith("%") || cause.WERKS.EndsWith("%")) ? " like " : " = ").Append(" :WERKS");
                param = new OracleParameter();
                param.ParameterName = ":WERKS";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 40;
                param.Value = cause.WERKS;
                paramList.Add(param);
            }
            if (cause.HasINValue("WERKS"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "WERKS"));
            }
            if (!string.IsNullOrEmpty(cause.FREEUSE3))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.FREEUSE3 ").Append((cause.FREEUSE3.StartsWith("%") || cause.FREEUSE3.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE3");
                param = new OracleParameter();
                param.ParameterName = ":FREEUSE3";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 100;
                param.Value = cause.FREEUSE3;
                paramList.Add(param);
            }
            if (cause.HasINValue("FREEUSE3"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FREEUSE3"));
            }
            if (!string.IsNullOrEmpty(cause.FPBM))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.FPBM ").Append((cause.FPBM.StartsWith("%") || cause.FPBM.EndsWith("%")) ? " like " : " = ").Append(" :FPBM");
                param = new OracleParameter();
                param.ParameterName = ":FPBM";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 200;
                param.Value = cause.FPBM;
                paramList.Add(param);
            }
            if (cause.HasINValue("FPBM"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FPBM"));
            }
            if (!string.IsNullOrEmpty(cause.TXZ01))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.TXZ01 ").Append((cause.TXZ01.StartsWith("%") || cause.TXZ01.EndsWith("%")) ? " like " : " = ").Append(" :TXZ01");
                param = new OracleParameter();
                param.ParameterName = ":TXZ01";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 200;
                param.Value = cause.TXZ01;
                paramList.Add(param);
            }
            if (cause.HasINValue("TXZ01"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "TXZ01"));
            }
            if (cause.FPJR != ConstLibrary.Template.UndefineDecimal)
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.FPJR = :FPJR");
                param = new OracleParameter();
                param.ParameterName = ":FPJR";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = cause.FPJR;
                paramList.Add(param);
            }
            if (cause.HasINValue("FPJR"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FPJR"));
            }
            if (!string.IsNullOrEmpty(cause.LGORT))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.LGORT ").Append((cause.LGORT.StartsWith("%") || cause.LGORT.EndsWith("%")) ? " like " : " = ").Append(" :LGORT");
                param = new OracleParameter();
                param.ParameterName = ":LGORT";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 200;
                param.Value = cause.LGORT;
                paramList.Add(param);
            }
            if (cause.HasINValue("LGORT"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "LGORT"));
            }
            if (!string.IsNullOrEmpty(cause.ID))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
                param = new OracleParameter();
                param.ParameterName = ":ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("ID"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "ID"));
            }
            if (!string.IsNullOrEmpty(cause.CREATE_USER_ID))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
                param = new OracleParameter();
                param.ParameterName = ":CREATE_USER_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.CREATE_USER_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("CREATE_USER_ID"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "CREATE_USER_ID"));
            }
            if (cause.STATE != ConstLibrary.Template.UndefineDecimal)
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.STATE = :STATE");
                param = new OracleParameter();
                param.ParameterName = ":STATE";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = cause.STATE;
                paramList.Add(param);
            }
            if (cause.HasINValue("STATE"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "STATE"));
            }
            if (cause.HSDAT != null)
            {
                if (cause.HSDAT.Begin != null)
                {
                    strBuf.Append(" And SCM_D_SUPPLYPLAN.HSDAT >= :HSDAT_BEGIN");
                    param = new OracleParameter();
                    param.ParameterName = ":HSDAT_BEGIN";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.HSDAT.Begin;
                    paramList.Add(param);
                }
                if (cause.HSDAT.End != null)
                {
                    strBuf.Append(" And SCM_D_SUPPLYPLAN.HSDAT < :HSDAT_END");
                    param = new OracleParameter();
                    param.ParameterName = ":HSDAT_END";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.HSDAT.End;
                    paramList.Add(param);
                }
            }
            if (cause.HasINValue("HSDAT"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "HSDAT"));
            }
            if (cause.PKG_NUMBER != ConstLibrary.Template.UndefineDecimal)
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.PKG_NUMBER = :PKG_NUMBER");
                param = new OracleParameter();
                param.ParameterName = ":PKG_NUMBER";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = cause.PKG_NUMBER;
                paramList.Add(param);
            }
            if (cause.HasINValue("PKG_NUMBER"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "PKG_NUMBER"));
            }
            if (!string.IsNullOrEmpty(cause.MEINS))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.MEINS ").Append((cause.MEINS.StartsWith("%") || cause.MEINS.EndsWith("%")) ? " like " : " = ").Append(" :MEINS");
                param = new OracleParameter();
                param.ParameterName = ":MEINS";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.MEINS;
                paramList.Add(param);
            }
            if (cause.HasINValue("MEINS"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MEINS"));
            }
            if (cause.ORDER_MENGE != ConstLibrary.Template.UndefineDecimal)
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.ORDER_MENGE = :ORDER_MENGE");
                param = new OracleParameter();
                param.ParameterName = ":ORDER_MENGE";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = cause.ORDER_MENGE;
                paramList.Add(param);
            }
            if (cause.HasINValue("ORDER_MENGE"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "ORDER_MENGE"));
            }
            if (!string.IsNullOrEmpty(cause.STATUS))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.STATUS ").Append((cause.STATUS.StartsWith("%") || cause.STATUS.EndsWith("%")) ? " like " : " = ").Append(" :STATUS");
                param = new OracleParameter();
                param.ParameterName = ":STATUS";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 1;
                param.Value = cause.STATUS;
                paramList.Add(param);
            }
            if (cause.HasINValue("STATUS"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "STATUS"));
            }
            if (cause.FPRQ != null)
            {
                if (cause.FPRQ.Begin != null)
                {
                    strBuf.Append(" And SCM_D_SUPPLYPLAN.FPRQ >= :FPRQ_BEGIN");
                    param = new OracleParameter();
                    param.ParameterName = ":FPRQ_BEGIN";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.FPRQ.Begin;
                    paramList.Add(param);
                }
                if (cause.FPRQ.End != null)
                {
                    strBuf.Append(" And SCM_D_SUPPLYPLAN.FPRQ < :FPRQ_END");
                    param = new OracleParameter();
                    param.ParameterName = ":FPRQ_END";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.FPRQ.End;
                    paramList.Add(param);
                }
            }
            if (cause.HasINValue("FPRQ"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FPRQ"));
            }
            if (!string.IsNullOrEmpty(cause.NETPR))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.NETPR ").Append((cause.NETPR.StartsWith("%") || cause.NETPR.EndsWith("%")) ? " like " : " = ").Append(" :NETPR");
                param = new OracleParameter();
                param.ParameterName = ":NETPR";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 20;
                param.Value = cause.NETPR;
                paramList.Add(param);
            }
            if (cause.HasINValue("NETPR"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "NETPR"));
            }
            if (cause.MODIFY_TIME != null)
            {
                if (cause.MODIFY_TIME.Begin != null)
                {
                    strBuf.Append(" And SCM_D_SUPPLYPLAN.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
                    param = new OracleParameter();
                    param.ParameterName = ":MODIFY_TIME_BEGIN";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.MODIFY_TIME.Begin;
                    paramList.Add(param);
                }
                if (cause.MODIFY_TIME.End != null)
                {
                    strBuf.Append(" And SCM_D_SUPPLYPLAN.MODIFY_TIME < :MODIFY_TIME_END");
                    param = new OracleParameter();
                    param.ParameterName = ":MODIFY_TIME_END";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.MODIFY_TIME.End;
                    paramList.Add(param);
                }
            }
            if (cause.HasINValue("MODIFY_TIME"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MODIFY_TIME"));
            }
            if (!string.IsNullOrEmpty(cause.CODE))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
                param = new OracleParameter();
                param.ParameterName = ":CODE";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.CODE;
                paramList.Add(param);
            }
            if (cause.HasINValue("CODE"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "CODE"));
            }
            if (!string.IsNullOrEmpty(cause.GYJH))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.GYJH ").Append((cause.GYJH.StartsWith("%") || cause.GYJH.EndsWith("%")) ? " like " : " = ").Append(" :GYJH");
                param = new OracleParameter();
                param.ParameterName = ":GYJH";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 13;
                param.Value = cause.GYJH;
                paramList.Add(param);
            }
            if (cause.HasINValue("GYJH"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "GYJH"));
            }
            if (!string.IsNullOrEmpty(cause.COMMENTS))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
                param = new OracleParameter();
                param.ParameterName = ":COMMENTS";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 1000;
                param.Value = cause.COMMENTS;
                paramList.Add(param);
            }
            if (cause.HasINValue("COMMENTS"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "COMMENTS"));
            }
            if (!string.IsNullOrEmpty(cause.WERKST))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.WERKST ").Append((cause.WERKST.StartsWith("%") || cause.WERKST.EndsWith("%")) ? " like " : " = ").Append(" :WERKST");
                param = new OracleParameter();
                param.ParameterName = ":WERKST";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.WERKST;
                paramList.Add(param);
            }
            if (cause.HasINValue("WERKST"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "WERKST"));
            }
            if (!string.IsNullOrEmpty(cause.FREEUSE1))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.FREEUSE1 ").Append((cause.FREEUSE1.StartsWith("%") || cause.FREEUSE1.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE1");
                param = new OracleParameter();
                param.ParameterName = ":FREEUSE1";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 10;
                param.Value = cause.FREEUSE1;
                paramList.Add(param);
            }
            if (cause.HasINValue("FREEUSE1"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FREEUSE1"));
            }
            if (!string.IsNullOrEmpty(cause.CHARG))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.CHARG ").Append((cause.CHARG.StartsWith("%") || cause.CHARG.EndsWith("%")) ? " like " : " = ").Append(" :CHARG");
                param = new OracleParameter();
                param.ParameterName = ":CHARG";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.CHARG;
                paramList.Add(param);
            }
            if (cause.HasINValue("CHARG"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "CHARG"));
            }
            if (!string.IsNullOrEmpty(cause.MSEHT))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.MSEHT ").Append((cause.MSEHT.StartsWith("%") || cause.MSEHT.EndsWith("%")) ? " like " : " = ").Append(" :MSEHT");
                param = new OracleParameter();
                param.ParameterName = ":MSEHT";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.MSEHT;
                paramList.Add(param);
            }
            if (cause.HasINValue("MSEHT"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MSEHT"));
            }
            if (!string.IsNullOrEmpty(cause.MATNR))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.MATNR ").Append((cause.MATNR.StartsWith("%") || cause.MATNR.EndsWith("%")) ? " like " : " = ").Append(" :MATNR");
                param = new OracleParameter();
                param.ParameterName = ":MATNR";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.MATNR;
                paramList.Add(param);
            }
            if (cause.HasINValue("MATNR"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MATNR"));
            }
            if (!string.IsNullOrEmpty(cause.GYSACCOUNT))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.GYSACCOUNT ").Append((cause.GYSACCOUNT.StartsWith("%") || cause.GYSACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :GYSACCOUNT");
                param = new OracleParameter();
                param.ParameterName = ":GYSACCOUNT";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.GYSACCOUNT;
                paramList.Add(param);
            }
            if (cause.HasINValue("GYSACCOUNT"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "GYSACCOUNT"));
            }
            if (!string.IsNullOrEmpty(cause.UNINFORMED_STATE))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.UNINFORMED_STATE ").Append((cause.UNINFORMED_STATE.StartsWith("%") || cause.UNINFORMED_STATE.EndsWith("%")) ? " like " : " = ").Append(" :UNINFORMED_STATE");
                param = new OracleParameter();
                param.ParameterName = ":UNINFORMED_STATE";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 1;
                param.Value = cause.UNINFORMED_STATE;
                paramList.Add(param);
            }
            if (cause.HasINValue("UNINFORMED_STATE"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "UNINFORMED_STATE"));
            }
            if (cause.CREATE_TIME != null)
            {
                if (cause.CREATE_TIME.Begin != null)
                {
                    strBuf.Append(" And SCM_D_SUPPLYPLAN.CREATE_TIME >= :CREATE_TIME_BEGIN");
                    param = new OracleParameter();
                    param.ParameterName = ":CREATE_TIME_BEGIN";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.CREATE_TIME.Begin;
                    paramList.Add(param);
                }
                if (cause.CREATE_TIME.End != null)
                {
                    strBuf.Append(" And SCM_D_SUPPLYPLAN.CREATE_TIME < :CREATE_TIME_END");
                    param = new OracleParameter();
                    param.ParameterName = ":CREATE_TIME_END";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.CREATE_TIME.End;
                    paramList.Add(param);
                }
            }
            if (cause.HasINValue("CREATE_TIME"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "CREATE_TIME"));
            }
            if (!string.IsNullOrEmpty(cause.GYSNAME))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.GYSNAME ").Append((cause.GYSNAME.StartsWith("%") || cause.GYSNAME.EndsWith("%")) ? " like " : " = ").Append(" :GYSNAME");
                param = new OracleParameter();
                param.ParameterName = ":GYSNAME";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 200;
                param.Value = cause.GYSNAME;
                paramList.Add(param);
            }
            if (cause.HasINValue("GYSNAME"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "GYSNAME"));
            }
            if (!string.IsNullOrEmpty(cause.NAME))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
                param = new OracleParameter();
                param.ParameterName = ":NAME";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.NAME;
                paramList.Add(param);
            }
            if (cause.HasINValue("NAME"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "NAME"));
            }
            if (cause.MENGE != ConstLibrary.Template.UndefineDecimal)
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.MENGE = :MENGE");
                param = new OracleParameter();
                param.ParameterName = ":MENGE";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = cause.MENGE;
                paramList.Add(param);
            }
            if (cause.HasINValue("MENGE"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MENGE"));
            }
            if (cause.PKG_AMOUNT != ConstLibrary.Template.UndefineDecimal)
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.PKG_AMOUNT = :PKG_AMOUNT");
                param = new OracleParameter();
                param.ParameterName = ":PKG_AMOUNT";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = cause.PKG_AMOUNT;
                paramList.Add(param);
            }
            if (cause.HasINValue("PKG_AMOUNT"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "PKG_AMOUNT"));
            }
            if (!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
                param = new OracleParameter();
                param.ParameterName = ":DATA_ORGANISE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.DATA_ORGANISE_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("DATA_ORGANISE_ID"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "DATA_ORGANISE_ID"));
            }
            if (!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
                param = new OracleParameter();
                param.ParameterName = ":MODIFY_USER_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.MODIFY_USER_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("MODIFY_USER_ID"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MODIFY_USER_ID"));
            }
            if (!string.IsNullOrEmpty(cause.FREEUSE2))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.FREEUSE2 ").Append((cause.FREEUSE2.StartsWith("%") || cause.FREEUSE2.EndsWith("%")) ? " like " : " = ").Append(" :FREEUSE2");
                param = new OracleParameter();
                param.ParameterName = ":FREEUSE2";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 50;
                param.Value = cause.FREEUSE2;
                paramList.Add(param);
            }
            if (cause.HasINValue("FREEUSE2"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "FREEUSE2"));
            }
            if (!string.IsNullOrEmpty(cause.EBELN))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.EBELN ").Append((cause.EBELN.StartsWith("%") || cause.EBELN.EndsWith("%")) ? " like " : " = ").Append(" :EBELN");
                param = new OracleParameter();
                param.ParameterName = ":EBELN";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.EBELN;
                paramList.Add(param);
            }
            if (cause.HasINValue("EBELN"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "EBELN"));
            }
            if (!string.IsNullOrEmpty(cause.BEDAT))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.BEDAT ").Append((cause.BEDAT.StartsWith("%") || cause.BEDAT.EndsWith("%")) ? " like " : " = ").Append(" :BEDAT");
                param = new OracleParameter();
                param.ParameterName = ":BEDAT";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 8;
                param.Value = cause.BEDAT;
                paramList.Add(param);
            }
            if (cause.HasINValue("BEDAT"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "BEDAT"));
            }
            if (cause.VFDAT != null)
            {
                if (cause.VFDAT.Begin != null)
                {
                    strBuf.Append(" And SCM_D_SUPPLYPLAN.VFDAT >= :VFDAT_BEGIN");
                    param = new OracleParameter();
                    param.ParameterName = ":VFDAT_BEGIN";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.VFDAT.Begin;
                    paramList.Add(param);
                }
                if (cause.VFDAT.End != null)
                {
                    strBuf.Append(" And SCM_D_SUPPLYPLAN.VFDAT < :VFDAT_END");
                    param = new OracleParameter();
                    param.ParameterName = ":VFDAT_END";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.VFDAT.End;
                    paramList.Add(param);
                }
            }
            if (cause.HasINValue("VFDAT"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "VFDAT"));
            }
            if (!string.IsNullOrEmpty(cause.INFORMED_STATE))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.INFORMED_STATE ").Append((cause.INFORMED_STATE.StartsWith("%") || cause.INFORMED_STATE.EndsWith("%")) ? " like " : " = ").Append(" :INFORMED_STATE");
                param = new OracleParameter();
                param.ParameterName = ":INFORMED_STATE";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 1;
                param.Value = cause.INFORMED_STATE;
                paramList.Add(param);
            }
            if (cause.HasINValue("INFORMED_STATE"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "INFORMED_STATE"));
            }
            if (!string.IsNullOrEmpty(cause.EEIND))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.EEIND ").Append((cause.EEIND.StartsWith("%") || cause.EEIND.EndsWith("%")) ? " like " : " = ").Append(" :EEIND");
                param = new OracleParameter();
                param.ParameterName = ":EEIND";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 10;
                param.Value = cause.EEIND;
                paramList.Add(param);
            }
            if (cause.HasINValue("EEIND"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "EEIND"));
            }
            if (!string.IsNullOrEmpty(cause.MODIFY_DEPART_ID))
            {
                strBuf.Append(" And SCM_D_SUPPLYPLAN.MODIFY_DEPART_ID ").Append((cause.MODIFY_DEPART_ID.StartsWith("%") || cause.MODIFY_DEPART_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPART_ID");
                param = new OracleParameter();
                param.ParameterName = ":MODIFY_DEPART_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.MODIFY_DEPART_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("MODIFY_DEPART_ID"))
            {
                strBuf.Append(cause.GetINSQL("SCM_D_SUPPLYPLAN", "MODIFY_DEPART_ID"));
            }
            if (!string.IsNullOrEmpty(cause.GetCustomCondition()))
            {
                strBuf.Append(cause.GetCustomCondition());
            }
            #endregion
            parameters = new OracleParameter[paramList.Count];
            paramList.CopyTo(parameters);
            return strBuf.ToString();


        }
        public static DisplayObject_SCM_D_SUPPLYPLAN[] Query(CauseObject_SCM_D_SUPPLYPLAN cause)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  SCM_D_SUPPLYPLAN.FPHM, SCM_D_SUPPLYPLAN.CREATE_DEPART_ID, SCM_D_SUPPLYPLAN.WERKS, SCM_D_SUPPLYPLAN.FREEUSE3, SCM_D_SUPPLYPLAN.FPBM, SCM_D_SUPPLYPLAN.TXZ01, SCM_D_SUPPLYPLAN.FPJR, SCM_D_SUPPLYPLAN.LGORT, SCM_D_SUPPLYPLAN.ID, SCM_D_SUPPLYPLAN.CREATE_USER_ID, SCM_D_SUPPLYPLAN.STATE, SCM_D_SUPPLYPLAN.HSDAT, SCM_D_SUPPLYPLAN.PKG_NUMBER, SCM_D_SUPPLYPLAN.MEINS, SCM_D_SUPPLYPLAN.ORDER_MENGE, SCM_D_SUPPLYPLAN.STATUS, SCM_D_SUPPLYPLAN.FPRQ, SCM_D_SUPPLYPLAN.NETPR, SCM_D_SUPPLYPLAN.MODIFY_TIME, SCM_D_SUPPLYPLAN.CODE, SCM_D_SUPPLYPLAN.GYJH, SCM_D_SUPPLYPLAN.COMMENTS, SCM_D_SUPPLYPLAN.WERKST, SCM_D_SUPPLYPLAN.FREEUSE1, SCM_D_SUPPLYPLAN.CHARG, SCM_D_SUPPLYPLAN.MSEHT, SCM_D_SUPPLYPLAN.MATNR, SCM_D_SUPPLYPLAN.GYSACCOUNT, SCM_D_SUPPLYPLAN.UNINFORMED_STATE, SCM_D_SUPPLYPLAN.CREATE_TIME, SCM_D_SUPPLYPLAN.GYSNAME, SCM_D_SUPPLYPLAN.NAME, SCM_D_SUPPLYPLAN.MENGE, SCM_D_SUPPLYPLAN.PKG_AMOUNT, SCM_D_SUPPLYPLAN.DATA_ORGANISE_ID, SCM_D_SUPPLYPLAN.MODIFY_USER_ID, SCM_D_SUPPLYPLAN.FREEUSE2, SCM_D_SUPPLYPLAN.EBELN, SCM_D_SUPPLYPLAN.BEDAT, SCM_D_SUPPLYPLAN.VFDAT, SCM_D_SUPPLYPLAN.INFORMED_STATE, SCM_D_SUPPLYPLAN.EEIND, SCM_D_SUPPLYPLAN.MODIFY_DEPART_ID from SCM_D_SUPPLYPLAN where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_SCM_D_SUPPLYPLAN dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_D_SUPPLYPLAN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.FPHM = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.WERKS = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.FREEUSE3 = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FPBM = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.TXZ01 = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.FPJR = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.LGORT = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.STATE = sqlReader.GetDecimal(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.HSDAT = sqlReader.GetDateTime(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.PKG_NUMBER = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.MEINS = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.ORDER_MENGE = sqlReader.GetDecimal(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.STATUS = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.FPRQ = sqlReader.GetDateTime(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.NETPR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.CODE = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.GYJH = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.COMMENTS = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.WERKST = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.FREEUSE1 = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.CHARG = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.MSEHT = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.MATNR = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.GYSACCOUNT = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.UNINFORMED_STATE = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.GYSNAME = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.NAME = sqlReader.GetString(31);
                if (!sqlReader.IsDBNull(32))
                    dataObj.MENGE = sqlReader.GetDecimal(32);
                if (!sqlReader.IsDBNull(33))
                    dataObj.PKG_AMOUNT = sqlReader.GetDecimal(33);
                if (!sqlReader.IsDBNull(34))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(34);
                if (!sqlReader.IsDBNull(35))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(35);
                if (!sqlReader.IsDBNull(36))
                    dataObj.FREEUSE2 = sqlReader.GetString(36);
                if (!sqlReader.IsDBNull(37))
                    dataObj.EBELN = sqlReader.GetString(37);
                if (!sqlReader.IsDBNull(38))
                    dataObj.BEDAT = sqlReader.GetString(38);
                if (!sqlReader.IsDBNull(39))
                    dataObj.VFDAT = sqlReader.GetDateTime(39);
                if (!sqlReader.IsDBNull(40))
                    dataObj.INFORMED_STATE = sqlReader.GetString(40);
                if (!sqlReader.IsDBNull(41))
                    dataObj.EEIND = sqlReader.GetString(41);
                if (!sqlReader.IsDBNull(42))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(42);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SCM_D_SUPPLYPLAN[] objs = new DisplayObject_SCM_D_SUPPLYPLAN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static int Delete(CauseObject_SCM_D_SUPPLYPLAN cause, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = "delete from SCM_D_SUPPLYPLAN where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static DisplayObject_SCM_D_SUPPLYPLAN[] Query(CauseObject_SCM_D_SUPPLYPLAN cause, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  SCM_D_SUPPLYPLAN.FPHM, SCM_D_SUPPLYPLAN.CREATE_DEPART_ID, SCM_D_SUPPLYPLAN.WERKS, SCM_D_SUPPLYPLAN.FREEUSE3, SCM_D_SUPPLYPLAN.FPBM, SCM_D_SUPPLYPLAN.TXZ01, SCM_D_SUPPLYPLAN.FPJR, SCM_D_SUPPLYPLAN.LGORT, SCM_D_SUPPLYPLAN.ID, SCM_D_SUPPLYPLAN.CREATE_USER_ID, SCM_D_SUPPLYPLAN.STATE, SCM_D_SUPPLYPLAN.HSDAT, SCM_D_SUPPLYPLAN.PKG_NUMBER, SCM_D_SUPPLYPLAN.MEINS, SCM_D_SUPPLYPLAN.ORDER_MENGE, SCM_D_SUPPLYPLAN.STATUS, SCM_D_SUPPLYPLAN.FPRQ, SCM_D_SUPPLYPLAN.NETPR, SCM_D_SUPPLYPLAN.MODIFY_TIME, SCM_D_SUPPLYPLAN.CODE, SCM_D_SUPPLYPLAN.GYJH, SCM_D_SUPPLYPLAN.COMMENTS, SCM_D_SUPPLYPLAN.WERKST, SCM_D_SUPPLYPLAN.FREEUSE1, SCM_D_SUPPLYPLAN.CHARG, SCM_D_SUPPLYPLAN.MSEHT, SCM_D_SUPPLYPLAN.MATNR, SCM_D_SUPPLYPLAN.GYSACCOUNT, SCM_D_SUPPLYPLAN.UNINFORMED_STATE, SCM_D_SUPPLYPLAN.CREATE_TIME, SCM_D_SUPPLYPLAN.GYSNAME, SCM_D_SUPPLYPLAN.NAME, SCM_D_SUPPLYPLAN.MENGE, SCM_D_SUPPLYPLAN.PKG_AMOUNT, SCM_D_SUPPLYPLAN.DATA_ORGANISE_ID, SCM_D_SUPPLYPLAN.MODIFY_USER_ID, SCM_D_SUPPLYPLAN.FREEUSE2, SCM_D_SUPPLYPLAN.EBELN, SCM_D_SUPPLYPLAN.BEDAT, SCM_D_SUPPLYPLAN.VFDAT, SCM_D_SUPPLYPLAN.INFORMED_STATE, SCM_D_SUPPLYPLAN.EEIND, SCM_D_SUPPLYPLAN.MODIFY_DEPART_ID from SCM_D_SUPPLYPLAN where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_SCM_D_SUPPLYPLAN dataObj = null;
            ArrayList objArray = new ArrayList();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_D_SUPPLYPLAN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.FPHM = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.WERKS = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.FREEUSE3 = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FPBM = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.TXZ01 = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.FPJR = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.LGORT = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.STATE = sqlReader.GetDecimal(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.HSDAT = sqlReader.GetDateTime(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.PKG_NUMBER = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.MEINS = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.ORDER_MENGE = sqlReader.GetDecimal(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.STATUS = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.FPRQ = sqlReader.GetDateTime(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.NETPR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.CODE = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.GYJH = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.COMMENTS = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.WERKST = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.FREEUSE1 = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.CHARG = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.MSEHT = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.MATNR = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.GYSACCOUNT = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.UNINFORMED_STATE = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.GYSNAME = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.NAME = sqlReader.GetString(31);
                if (!sqlReader.IsDBNull(32))
                    dataObj.MENGE = sqlReader.GetDecimal(32);
                if (!sqlReader.IsDBNull(33))
                    dataObj.PKG_AMOUNT = sqlReader.GetDecimal(33);
                if (!sqlReader.IsDBNull(34))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(34);
                if (!sqlReader.IsDBNull(35))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(35);
                if (!sqlReader.IsDBNull(36))
                    dataObj.FREEUSE2 = sqlReader.GetString(36);
                if (!sqlReader.IsDBNull(37))
                    dataObj.EBELN = sqlReader.GetString(37);
                if (!sqlReader.IsDBNull(38))
                    dataObj.BEDAT = sqlReader.GetString(38);
                if (!sqlReader.IsDBNull(39))
                    dataObj.VFDAT = sqlReader.GetDateTime(39);
                if (!sqlReader.IsDBNull(40))
                    dataObj.INFORMED_STATE = sqlReader.GetString(40);
                if (!sqlReader.IsDBNull(41))
                    dataObj.EEIND = sqlReader.GetString(41);
                if (!sqlReader.IsDBNull(42))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(42);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_SCM_D_SUPPLYPLAN[] objs = new DisplayObject_SCM_D_SUPPLYPLAN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_SCM_D_SUPPLYPLAN[] Query(CauseObject_SCM_D_SUPPLYPLAN cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  SCM_D_SUPPLYPLAN.FPHM, SCM_D_SUPPLYPLAN.CREATE_DEPART_ID, SCM_D_SUPPLYPLAN.WERKS, SCM_D_SUPPLYPLAN.FREEUSE3, SCM_D_SUPPLYPLAN.FPBM, SCM_D_SUPPLYPLAN.TXZ01, SCM_D_SUPPLYPLAN.FPJR, SCM_D_SUPPLYPLAN.LGORT, SCM_D_SUPPLYPLAN.ID, SCM_D_SUPPLYPLAN.CREATE_USER_ID, SCM_D_SUPPLYPLAN.STATE, SCM_D_SUPPLYPLAN.HSDAT, SCM_D_SUPPLYPLAN.PKG_NUMBER, SCM_D_SUPPLYPLAN.MEINS, SCM_D_SUPPLYPLAN.ORDER_MENGE, SCM_D_SUPPLYPLAN.STATUS, SCM_D_SUPPLYPLAN.FPRQ, SCM_D_SUPPLYPLAN.NETPR, SCM_D_SUPPLYPLAN.MODIFY_TIME, SCM_D_SUPPLYPLAN.CODE, SCM_D_SUPPLYPLAN.GYJH, SCM_D_SUPPLYPLAN.COMMENTS, SCM_D_SUPPLYPLAN.WERKST, SCM_D_SUPPLYPLAN.FREEUSE1, SCM_D_SUPPLYPLAN.CHARG, SCM_D_SUPPLYPLAN.MSEHT, SCM_D_SUPPLYPLAN.MATNR, SCM_D_SUPPLYPLAN.GYSACCOUNT, SCM_D_SUPPLYPLAN.UNINFORMED_STATE, SCM_D_SUPPLYPLAN.CREATE_TIME, SCM_D_SUPPLYPLAN.GYSNAME, SCM_D_SUPPLYPLAN.NAME, SCM_D_SUPPLYPLAN.MENGE, SCM_D_SUPPLYPLAN.PKG_AMOUNT, SCM_D_SUPPLYPLAN.DATA_ORGANISE_ID, SCM_D_SUPPLYPLAN.MODIFY_USER_ID, SCM_D_SUPPLYPLAN.FREEUSE2, SCM_D_SUPPLYPLAN.EBELN, SCM_D_SUPPLYPLAN.BEDAT, SCM_D_SUPPLYPLAN.VFDAT, SCM_D_SUPPLYPLAN.INFORMED_STATE, SCM_D_SUPPLYPLAN.EEIND, SCM_D_SUPPLYPLAN.MODIFY_DEPART_ID from SCM_D_SUPPLYPLAN where (1=1)";
            string sCauseSql = PrepareCause(cause, out parameters);
            sSql += sCauseSql;
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            if (paging != null)
            {
                string countSql = string.Empty;
                if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
                {
                    countSql = "Select Count(*) From (" + sSql + ") t";
                }
                else
                {
                    countSql = "Select Count(*) From (" + sSql + ") t";
                }
                if (paging.TotalRecords == 0)
                {
                    paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection);
                }
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_D_SUPPLYPLAN", paging, order, sSql, parameters, connection);
            }
            else if (order != null)
            {
                sSql += order.ToString();
                sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            }
            else
            {
                sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            }
            DisplayObject_SCM_D_SUPPLYPLAN dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_D_SUPPLYPLAN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.FPHM = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.WERKS = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.FREEUSE3 = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FPBM = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.TXZ01 = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.FPJR = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.LGORT = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.STATE = sqlReader.GetDecimal(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.HSDAT = sqlReader.GetDateTime(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.PKG_NUMBER = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.MEINS = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.ORDER_MENGE = sqlReader.GetDecimal(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.STATUS = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.FPRQ = sqlReader.GetDateTime(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.NETPR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.CODE = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.GYJH = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.COMMENTS = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.WERKST = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.FREEUSE1 = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.CHARG = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.MSEHT = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.MATNR = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.GYSACCOUNT = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.UNINFORMED_STATE = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.GYSNAME = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.NAME = sqlReader.GetString(31);
                if (!sqlReader.IsDBNull(32))
                    dataObj.MENGE = sqlReader.GetDecimal(32);
                if (!sqlReader.IsDBNull(33))
                    dataObj.PKG_AMOUNT = sqlReader.GetDecimal(33);
                if (!sqlReader.IsDBNull(34))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(34);
                if (!sqlReader.IsDBNull(35))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(35);
                if (!sqlReader.IsDBNull(36))
                    dataObj.FREEUSE2 = sqlReader.GetString(36);
                if (!sqlReader.IsDBNull(37))
                    dataObj.EBELN = sqlReader.GetString(37);
                if (!sqlReader.IsDBNull(38))
                    dataObj.BEDAT = sqlReader.GetString(38);
                if (!sqlReader.IsDBNull(39))
                    dataObj.VFDAT = sqlReader.GetDateTime(39);
                if (!sqlReader.IsDBNull(40))
                    dataObj.INFORMED_STATE = sqlReader.GetString(40);
                if (!sqlReader.IsDBNull(41))
                    dataObj.EEIND = sqlReader.GetString(41);
                if (!sqlReader.IsDBNull(42))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(42);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SCM_D_SUPPLYPLAN[] objs = new DisplayObject_SCM_D_SUPPLYPLAN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_SCM_D_SUPPLYPLAN[] Query(CauseObject_SCM_D_SUPPLYPLAN cause, PagingParamter paging, OrderByParameter order, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  SCM_D_SUPPLYPLAN.FPHM, SCM_D_SUPPLYPLAN.CREATE_DEPART_ID, SCM_D_SUPPLYPLAN.WERKS, SCM_D_SUPPLYPLAN.FREEUSE3, SCM_D_SUPPLYPLAN.FPBM, SCM_D_SUPPLYPLAN.TXZ01, SCM_D_SUPPLYPLAN.FPJR, SCM_D_SUPPLYPLAN.LGORT, SCM_D_SUPPLYPLAN.ID, SCM_D_SUPPLYPLAN.CREATE_USER_ID, SCM_D_SUPPLYPLAN.STATE, SCM_D_SUPPLYPLAN.HSDAT, SCM_D_SUPPLYPLAN.PKG_NUMBER, SCM_D_SUPPLYPLAN.MEINS, SCM_D_SUPPLYPLAN.ORDER_MENGE, SCM_D_SUPPLYPLAN.STATUS, SCM_D_SUPPLYPLAN.FPRQ, SCM_D_SUPPLYPLAN.NETPR, SCM_D_SUPPLYPLAN.MODIFY_TIME, SCM_D_SUPPLYPLAN.CODE, SCM_D_SUPPLYPLAN.GYJH, SCM_D_SUPPLYPLAN.COMMENTS, SCM_D_SUPPLYPLAN.WERKST, SCM_D_SUPPLYPLAN.FREEUSE1, SCM_D_SUPPLYPLAN.CHARG, SCM_D_SUPPLYPLAN.MSEHT, SCM_D_SUPPLYPLAN.MATNR, SCM_D_SUPPLYPLAN.GYSACCOUNT, SCM_D_SUPPLYPLAN.UNINFORMED_STATE, SCM_D_SUPPLYPLAN.CREATE_TIME, SCM_D_SUPPLYPLAN.GYSNAME, SCM_D_SUPPLYPLAN.NAME, SCM_D_SUPPLYPLAN.MENGE, SCM_D_SUPPLYPLAN.PKG_AMOUNT, SCM_D_SUPPLYPLAN.DATA_ORGANISE_ID, SCM_D_SUPPLYPLAN.MODIFY_USER_ID, SCM_D_SUPPLYPLAN.FREEUSE2, SCM_D_SUPPLYPLAN.EBELN, SCM_D_SUPPLYPLAN.BEDAT, SCM_D_SUPPLYPLAN.VFDAT, SCM_D_SUPPLYPLAN.INFORMED_STATE, SCM_D_SUPPLYPLAN.EEIND, SCM_D_SUPPLYPLAN.MODIFY_DEPART_ID from SCM_D_SUPPLYPLAN where (1=1)";
            string sCauseSql = PrepareCause(cause, out parameters);
            sSql += sCauseSql;
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            if (paging != null)
            {
                string countSql = string.Empty;
                if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
                {
                    countSql = "Select Count(*) From (" + sSql + ") t";
                }
                else
                {
                    countSql = "Select Count(*) From (" + sSql + ") t";
                }
                if (paging.TotalRecords == 0)
                {
                    paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer || IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.Db2 ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
                }
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_D_SUPPLYPLAN", paging, order, sSql, parameters, trans);
            }
            else if (order != null)
            {
                sSql += order.ToString();
                sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            }
            else
            {
                sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            }
            DisplayObject_SCM_D_SUPPLYPLAN dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_D_SUPPLYPLAN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.FPHM = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.WERKS = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.FREEUSE3 = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FPBM = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.TXZ01 = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.FPJR = sqlReader.GetDecimal(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.LGORT = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.STATE = sqlReader.GetDecimal(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.HSDAT = sqlReader.GetDateTime(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.PKG_NUMBER = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.MEINS = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.ORDER_MENGE = sqlReader.GetDecimal(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.STATUS = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.FPRQ = sqlReader.GetDateTime(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.NETPR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.CODE = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.GYJH = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.COMMENTS = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.WERKST = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.FREEUSE1 = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.CHARG = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.MSEHT = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.MATNR = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.GYSACCOUNT = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.UNINFORMED_STATE = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.GYSNAME = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.NAME = sqlReader.GetString(31);
                if (!sqlReader.IsDBNull(32))
                    dataObj.MENGE = sqlReader.GetDecimal(32);
                if (!sqlReader.IsDBNull(33))
                    dataObj.PKG_AMOUNT = sqlReader.GetDecimal(33);
                if (!sqlReader.IsDBNull(34))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(34);
                if (!sqlReader.IsDBNull(35))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(35);
                if (!sqlReader.IsDBNull(36))
                    dataObj.FREEUSE2 = sqlReader.GetString(36);
                if (!sqlReader.IsDBNull(37))
                    dataObj.EBELN = sqlReader.GetString(37);
                if (!sqlReader.IsDBNull(38))
                    dataObj.BEDAT = sqlReader.GetString(38);
                if (!sqlReader.IsDBNull(39))
                    dataObj.VFDAT = sqlReader.GetDateTime(39);
                if (!sqlReader.IsDBNull(40))
                    dataObj.INFORMED_STATE = sqlReader.GetString(40);
                if (!sqlReader.IsDBNull(41))
                    dataObj.EEIND = sqlReader.GetString(41);
                if (!sqlReader.IsDBNull(42))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(42);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_SCM_D_SUPPLYPLAN[] objs = new DisplayObject_SCM_D_SUPPLYPLAN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static string PrepareUpdate(EntityObject_SCM_D_SUPPLYPLAN obj, out OracleParameter[] parameters)
        {

            //平台自动生成代码
            List<string> strBuf = new List<string>();
            ArrayList paramList = new ArrayList();
            OracleParameter param = null;
            #region Push Block
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
            if (!obj.IsNotUpdate("HSDAT"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.HSDAT = :HSDAT");
                param = new OracleParameter();
                param.ParameterName = ":HSDAT";
                param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                param.Size = 7;
                if (obj.HSDAT == null)
                {
                    param.Value = DBNull.Value;
                }
                else
                {
                    param.Value = obj.HSDAT.Value;
                }
                
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
            if (!obj.IsNotUpdate("FPRQ"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.FPRQ = :FPRQ");
                param = new OracleParameter();
                param.ParameterName = ":FPRQ";
                param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                param.Size = 7;
                param.Value = obj.FPRQ;
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
            if (!obj.IsNotUpdate("COMMENTS"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.COMMENTS = :COMMENTS");
                param = new OracleParameter();
                param.ParameterName = ":COMMENTS";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 1000;
                param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
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
            if (!obj.IsNotUpdate("GYSNAME"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.GYSNAME = :GYSNAME");
                param = new OracleParameter();
                param.ParameterName = ":GYSNAME";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 200;
                param.Value = string.IsNullOrEmpty(obj.GYSNAME) ? string.Empty : obj.GYSNAME;
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
            if (!obj.IsNotUpdate("EEIND"))
            {
                strBuf.Add("  SCM_D_SUPPLYPLAN.EEIND = :EEIND");
                param = new OracleParameter();
                param.ParameterName = ":EEIND";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 10;
                param.Value = string.IsNullOrEmpty(obj.EEIND) ? string.Empty : obj.EEIND;
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
        #endregion
    }
}
