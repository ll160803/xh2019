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
    public partial class HelperObject_SCM_D_PURCHARSEPLAN
    {
        public static int 
            
            IsAllowAdd(string EBELN, string EBELP, decimal MENGE, string gysaccount, string matnr, string charge,decimal Flag, string ID)
        {
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter[] parameters = new OracleParameter[9];
                    parameters[0] = new OracleParameter();
                    parameters[0].ParameterName = "t_EBELN";
                    parameters[0].Size = 200;
                    parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[0].Value = EBELN;

                    parameters[1] = new OracleParameter();
                    parameters[1].ParameterName = "t_EBELP";
                    parameters[1].Size = 13;
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

                    parameters[4] = new OracleParameter();
                    parameters[4].ParameterName = "t_GYSAccount";
                    parameters[4].Size = 50;
                    parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[4].Value = gysaccount;

                    parameters[5] = new OracleParameter();
                    parameters[5].ParameterName = "t_MATNR";
                    parameters[5].Size = 20;
                    parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[5].Value = matnr;

                    parameters[6] = new OracleParameter();
                    parameters[6].ParameterName = "t_CHARGE";
                    parameters[6].Size = 10;
                    parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[6].Value = charge;

                    parameters[7] = new OracleParameter();
                    parameters[7].ParameterName = "t_Flag";
                    parameters[7].Size = 3;
                    parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
                    parameters[7].Value = Flag;

                   
                    if (!string.IsNullOrEmpty(ID))
                    {
                        parameters[3].Value = ID;
                    }
                    else
                    {
                        parameters[3].Value ="";
                    }

                    parameters[8] = new OracleParameter();
                    parameters[8].ParameterName = "out_Flag";
                    parameters[8].Direction = System.Data.ParameterDirection.Output;
                    parameters[8].Size = 4;
                    parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;


                    cmd.CommandText = "Sp_SCM_IsAllowAdd";
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    cmd.ExecuteNonQuery();

                    int IsCanAllow = int.Parse(parameters[8].Value.ToString());
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

        #region 在和供应商做联合查询时候 条件复杂

        public static DisplayObject_SCM_D_PURCHARSEPLAN[] List()
        {

            //平台自动生成代码
            string sSql = " select  SCM_D_PURCHARSEPLAN.MSEHT, SCM_D_PURCHARSEPLAN.NAME, SCM_D_PURCHARSEPLAN.FREEUSE2, SCM_D_PURCHARSEPLAN.FREEUSE3, SCM_D_PURCHARSEPLAN.BEDAT, SCM_D_PURCHARSEPLAN.FREEUSE1, SCM_D_PURCHARSEPLAN.MODIFY_TIME, SCM_D_PURCHARSEPLAN.LIFNR, SCM_D_PURCHARSEPLAN.STATUS, SCM_D_PURCHARSEPLAN.MODIFY_DEPART_ID, SCM_D_PURCHARSEPLAN.DATA_ORGANISE_ID, SCM_D_PURCHARSEPLAN.SEND_DEAPRT_NAME, SCM_D_PURCHARSEPLAN.CODE, SCM_D_PURCHARSEPLAN.BSART, SCM_D_PURCHARSEPLAN.CREATE_TIME, SCM_D_PURCHARSEPLAN.MODIFY_USER_ID, SCM_D_PURCHARSEPLAN.SEND_DEAPRT_ID, SCM_D_PURCHARSEPLAN.MEINS, SCM_D_PURCHARSEPLAN.WERKST, SCM_D_PURCHARSEPLAN.STATE, SCM_D_PURCHARSEPLAN.EINDT, SCM_D_PURCHARSEPLAN.LGORT, SCM_D_PURCHARSEPLAN.TXZ01, SCM_D_PURCHARSEPLAN.SUREMENGE, SCM_D_PURCHARSEPLAN.CREATE_USER_ID, SCM_D_PURCHARSEPLAN.ID, SCM_D_PURCHARSEPLAN.MENGE, Case when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-本部' then '2000' when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-肿瘤中心' then '2100' when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-西院' then '2200' else '2000' end as WERKS, SCM_D_PURCHARSEPLAN.EBELP, SCM_D_PURCHARSEPLAN.ALLMENGE, SCM_D_PURCHARSEPLAN.COMMENTS, SCM_D_PURCHARSEPLAN.CREATE_DEPART_ID, SCM_D_PURCHARSEPLAN.NETPR, SCM_D_PURCHARSEPLAN.EBELN, SCM_D_PURCHARSEPLAN.MATNR, MDM_D_DEPT_LIFNR.NAME as LIFNR_NAME from SCM_D_PURCHARSEPLAN left join (SELECT *  FROM (SELECT ROW_NUMBER() OVER(PARTITION BY CODE ORDER BY MDM_D_DEPT.DEPT_TYPE_ID DESC) rn,MDM_D_DEPT.ID,MDM_D_DEPT.DEPT_TYPE_ID,MDM_D_DEPT.NAME,MDM_D_DEPT.CODE FROM MDM_D_DEPT ) WHERE rn = 1)    MDM_D_DEPT_LIFNR on SCM_D_PURCHARSEPLAN.LIFNR = MDM_D_DEPT_LIFNR.CODE where (1=1)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[0];
            #endregion
            #region Push Block
            DisplayObject_SCM_D_PURCHARSEPLAN dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_D_PURCHARSEPLAN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.MSEHT = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.FREEUSE2 = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.FREEUSE3 = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.BEDAT = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.FREEUSE1 = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.LIFNR = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.STATUS = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.SEND_DEAPRT_NAME = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.CODE = sqlReader.GetString(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.BSART = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.SEND_DEAPRT_ID = sqlReader.GetString(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.MEINS = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.WERKST = sqlReader.GetString(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.STATE = sqlReader.GetDecimal(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.EINDT = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.LGORT = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.TXZ01 = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.SUREMENGE = sqlReader.GetDecimal(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.ID = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.MENGE = sqlReader.GetDecimal(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.WERKS = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.EBELP = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.ALLMENGE = sqlReader.GetDecimal(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.COMMENTS = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(31);
                if (!sqlReader.IsDBNull(32))
                    dataObj.NETPR = sqlReader.GetString(32);
                if (!sqlReader.IsDBNull(33))
                    dataObj.EBELN = sqlReader.GetString(33);
                if (!sqlReader.IsDBNull(34))
                    dataObj.MATNR = sqlReader.GetString(34);
                if (!sqlReader.IsDBNull(35))
                    dataObj.LIFNR_NAME = sqlReader.GetString(35);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SCM_D_PURCHARSEPLAN[] objs = new DisplayObject_SCM_D_PURCHARSEPLAN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_SCM_D_PURCHARSEPLAN[] Query(CauseObject_SCM_D_PURCHARSEPLAN cause)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  SCM_D_PURCHARSEPLAN.MSEHT, SCM_D_PURCHARSEPLAN.NAME, SCM_D_PURCHARSEPLAN.FREEUSE2, SCM_D_PURCHARSEPLAN.FREEUSE3, SCM_D_PURCHARSEPLAN.BEDAT, SCM_D_PURCHARSEPLAN.FREEUSE1, SCM_D_PURCHARSEPLAN.MODIFY_TIME, SCM_D_PURCHARSEPLAN.LIFNR, SCM_D_PURCHARSEPLAN.STATUS, SCM_D_PURCHARSEPLAN.MODIFY_DEPART_ID, SCM_D_PURCHARSEPLAN.DATA_ORGANISE_ID, SCM_D_PURCHARSEPLAN.SEND_DEAPRT_NAME, SCM_D_PURCHARSEPLAN.CODE, SCM_D_PURCHARSEPLAN.BSART, SCM_D_PURCHARSEPLAN.CREATE_TIME, SCM_D_PURCHARSEPLAN.MODIFY_USER_ID, SCM_D_PURCHARSEPLAN.SEND_DEAPRT_ID, SCM_D_PURCHARSEPLAN.MEINS, SCM_D_PURCHARSEPLAN.WERKST, SCM_D_PURCHARSEPLAN.STATE, SCM_D_PURCHARSEPLAN.EINDT, SCM_D_PURCHARSEPLAN.LGORT, SCM_D_PURCHARSEPLAN.TXZ01, SCM_D_PURCHARSEPLAN.SUREMENGE, SCM_D_PURCHARSEPLAN.CREATE_USER_ID, SCM_D_PURCHARSEPLAN.ID, SCM_D_PURCHARSEPLAN.MENGE, Case when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-本部' then '2000' when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-肿瘤中心' then '2100' when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-西院' then '2200' else '2000' end as WERKS, SCM_D_PURCHARSEPLAN.EBELP, SCM_D_PURCHARSEPLAN.ALLMENGE, SCM_D_PURCHARSEPLAN.COMMENTS, SCM_D_PURCHARSEPLAN.CREATE_DEPART_ID, SCM_D_PURCHARSEPLAN.NETPR, SCM_D_PURCHARSEPLAN.EBELN, SCM_D_PURCHARSEPLAN.MATNR, MDM_D_DEPT_LIFNR.NAME as LIFNR_NAME from SCM_D_PURCHARSEPLAN left join (SELECT *  FROM (SELECT ROW_NUMBER() OVER(PARTITION BY CODE ORDER BY MDM_D_DEPT.DEPT_TYPE_ID DESC) rn,MDM_D_DEPT.ID,MDM_D_DEPT.DEPT_TYPE_ID,MDM_D_DEPT.NAME,MDM_D_DEPT.CODE FROM MDM_D_DEPT ) WHERE rn = 1)    MDM_D_DEPT_LIFNR on SCM_D_PURCHARSEPLAN.LIFNR = MDM_D_DEPT_LIFNR.CODE where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_SCM_D_PURCHARSEPLAN dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_D_PURCHARSEPLAN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.MSEHT = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.FREEUSE2 = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.FREEUSE3 = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.BEDAT = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.FREEUSE1 = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.LIFNR = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.STATUS = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.SEND_DEAPRT_NAME = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.CODE = sqlReader.GetString(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.BSART = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.SEND_DEAPRT_ID = sqlReader.GetString(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.MEINS = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.WERKST = sqlReader.GetString(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.STATE = sqlReader.GetDecimal(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.EINDT = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.LGORT = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.TXZ01 = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.SUREMENGE = sqlReader.GetDecimal(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.ID = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.MENGE = sqlReader.GetDecimal(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.WERKS = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.EBELP = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.ALLMENGE = sqlReader.GetDecimal(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.COMMENTS = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(31);
                if (!sqlReader.IsDBNull(32))
                    dataObj.NETPR = sqlReader.GetString(32);
                if (!sqlReader.IsDBNull(33))
                    dataObj.EBELN = sqlReader.GetString(33);
                if (!sqlReader.IsDBNull(34))
                    dataObj.MATNR = sqlReader.GetString(34);
                if (!sqlReader.IsDBNull(35))
                    dataObj.LIFNR_NAME = sqlReader.GetString(35);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SCM_D_PURCHARSEPLAN[] objs = new DisplayObject_SCM_D_PURCHARSEPLAN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_SCM_D_PURCHARSEPLAN[] Query(CauseObject_SCM_D_PURCHARSEPLAN cause, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  SCM_D_PURCHARSEPLAN.MSEHT, SCM_D_PURCHARSEPLAN.NAME, SCM_D_PURCHARSEPLAN.FREEUSE2, SCM_D_PURCHARSEPLAN.FREEUSE3, SCM_D_PURCHARSEPLAN.BEDAT, SCM_D_PURCHARSEPLAN.FREEUSE1, SCM_D_PURCHARSEPLAN.MODIFY_TIME, SCM_D_PURCHARSEPLAN.LIFNR, SCM_D_PURCHARSEPLAN.STATUS, SCM_D_PURCHARSEPLAN.MODIFY_DEPART_ID, SCM_D_PURCHARSEPLAN.DATA_ORGANISE_ID, SCM_D_PURCHARSEPLAN.SEND_DEAPRT_NAME, SCM_D_PURCHARSEPLAN.CODE, SCM_D_PURCHARSEPLAN.BSART, SCM_D_PURCHARSEPLAN.CREATE_TIME, SCM_D_PURCHARSEPLAN.MODIFY_USER_ID, SCM_D_PURCHARSEPLAN.SEND_DEAPRT_ID, SCM_D_PURCHARSEPLAN.MEINS, SCM_D_PURCHARSEPLAN.WERKST, SCM_D_PURCHARSEPLAN.STATE, SCM_D_PURCHARSEPLAN.EINDT, SCM_D_PURCHARSEPLAN.LGORT, SCM_D_PURCHARSEPLAN.TXZ01, SCM_D_PURCHARSEPLAN.SUREMENGE, SCM_D_PURCHARSEPLAN.CREATE_USER_ID, SCM_D_PURCHARSEPLAN.ID, SCM_D_PURCHARSEPLAN.MENGE, Case when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-本部' then '2000' when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-肿瘤中心' then '2100' when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-西院' then '2200' else '2000' end as WERKS, SCM_D_PURCHARSEPLAN.EBELP, SCM_D_PURCHARSEPLAN.ALLMENGE, SCM_D_PURCHARSEPLAN.COMMENTS, SCM_D_PURCHARSEPLAN.CREATE_DEPART_ID, SCM_D_PURCHARSEPLAN.NETPR, SCM_D_PURCHARSEPLAN.EBELN, SCM_D_PURCHARSEPLAN.MATNR, MDM_D_DEPT_LIFNR.NAME as LIFNR_NAME from SCM_D_PURCHARSEPLAN left join (SELECT *  FROM (SELECT ROW_NUMBER() OVER(PARTITION BY CODE ORDER BY MDM_D_DEPT.DEPT_TYPE_ID DESC) rn,MDM_D_DEPT.ID,MDM_D_DEPT.DEPT_TYPE_ID,MDM_D_DEPT.NAME,MDM_D_DEPT.CODE FROM MDM_D_DEPT ) WHERE rn = 1)    MDM_D_DEPT_LIFNR on SCM_D_PURCHARSEPLAN.LIFNR = MDM_D_DEPT_LIFNR.CODE where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_SCM_D_PURCHARSEPLAN dataObj = null;
            ArrayList objArray = new ArrayList();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_D_PURCHARSEPLAN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.MSEHT = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.FREEUSE2 = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.FREEUSE3 = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.BEDAT = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.FREEUSE1 = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.LIFNR = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.STATUS = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.SEND_DEAPRT_NAME = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.CODE = sqlReader.GetString(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.BSART = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.SEND_DEAPRT_ID = sqlReader.GetString(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.MEINS = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.WERKST = sqlReader.GetString(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.STATE = sqlReader.GetDecimal(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.EINDT = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.LGORT = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.TXZ01 = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.SUREMENGE = sqlReader.GetDecimal(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.ID = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.MENGE = sqlReader.GetDecimal(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.WERKS = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.EBELP = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.ALLMENGE = sqlReader.GetDecimal(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.COMMENTS = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(31);
                if (!sqlReader.IsDBNull(32))
                    dataObj.NETPR = sqlReader.GetString(32);
                if (!sqlReader.IsDBNull(33))
                    dataObj.EBELN = sqlReader.GetString(33);
                if (!sqlReader.IsDBNull(34))
                    dataObj.MATNR = sqlReader.GetString(34);
                if (!sqlReader.IsDBNull(35))
                    dataObj.LIFNR_NAME = sqlReader.GetString(35);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_SCM_D_PURCHARSEPLAN[] objs = new DisplayObject_SCM_D_PURCHARSEPLAN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_SCM_D_PURCHARSEPLAN[] Query(CauseObject_SCM_D_PURCHARSEPLAN cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  SCM_D_PURCHARSEPLAN.MSEHT, SCM_D_PURCHARSEPLAN.NAME, SCM_D_PURCHARSEPLAN.FREEUSE2, SCM_D_PURCHARSEPLAN.FREEUSE3, SCM_D_PURCHARSEPLAN.BEDAT, SCM_D_PURCHARSEPLAN.FREEUSE1, SCM_D_PURCHARSEPLAN.MODIFY_TIME, SCM_D_PURCHARSEPLAN.LIFNR, SCM_D_PURCHARSEPLAN.STATUS, SCM_D_PURCHARSEPLAN.MODIFY_DEPART_ID, SCM_D_PURCHARSEPLAN.DATA_ORGANISE_ID, SCM_D_PURCHARSEPLAN.SEND_DEAPRT_NAME, SCM_D_PURCHARSEPLAN.CODE, SCM_D_PURCHARSEPLAN.BSART, SCM_D_PURCHARSEPLAN.CREATE_TIME, SCM_D_PURCHARSEPLAN.MODIFY_USER_ID, SCM_D_PURCHARSEPLAN.SEND_DEAPRT_ID, SCM_D_PURCHARSEPLAN.MEINS, SCM_D_PURCHARSEPLAN.WERKST, SCM_D_PURCHARSEPLAN.STATE, SCM_D_PURCHARSEPLAN.EINDT, SCM_D_PURCHARSEPLAN.LGORT, SCM_D_PURCHARSEPLAN.TXZ01, SCM_D_PURCHARSEPLAN.SUREMENGE, SCM_D_PURCHARSEPLAN.CREATE_USER_ID, SCM_D_PURCHARSEPLAN.ID, SCM_D_PURCHARSEPLAN.MENGE, Case when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-本部' then '2000' when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-肿瘤中心' then '2100' when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-西院' then '2200' else '2000' end as WERKS, SCM_D_PURCHARSEPLAN.EBELP, SCM_D_PURCHARSEPLAN.ALLMENGE, SCM_D_PURCHARSEPLAN.COMMENTS, SCM_D_PURCHARSEPLAN.CREATE_DEPART_ID, SCM_D_PURCHARSEPLAN.NETPR, SCM_D_PURCHARSEPLAN.EBELN, SCM_D_PURCHARSEPLAN.MATNR, MDM_D_DEPT_LIFNR.NAME as LIFNR_NAME, SCM_D_MATER_MATNR.BKLAS as MATNR_NAME, SCM_D_PURCHARSEPLAN.SEND_DEAPRT_CONTACT, SCM_D_PURCHARSEPLAN.SEND_DEAPRT_PHONE from SCM_D_PURCHARSEPLAN  left join SCM_D_HRPMATER   SCM_D_MATER_MATNR on TRIM(SCM_D_PURCHARSEPLAN.MATNR) = TRIM(SCM_D_MATER_MATNR.MATNR)  left join (SELECT *  FROM (SELECT ROW_NUMBER() OVER(PARTITION BY CODE ORDER BY MDM_D_DEPT.DEPT_TYPE_ID DESC) rn,MDM_D_DEPT.ID,MDM_D_DEPT.DEPT_TYPE_ID,MDM_D_DEPT.NAME,MDM_D_DEPT.CODE FROM MDM_D_DEPT ) WHERE rn = 1)    MDM_D_DEPT_LIFNR on SCM_D_PURCHARSEPLAN.LIFNR = MDM_D_DEPT_LIFNR.CODE where (1=1)";
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_D_PURCHARSEPLAN", paging, order, sSql, parameters, connection);
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
            DisplayObject_SCM_D_PURCHARSEPLAN dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_D_PURCHARSEPLAN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.MSEHT = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.FREEUSE2 = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.FREEUSE3 = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.BEDAT = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.FREEUSE1 = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.LIFNR = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.STATUS = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.SEND_DEAPRT_NAME = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.CODE = sqlReader.GetString(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.BSART = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.SEND_DEAPRT_ID = sqlReader.GetString(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.MEINS = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.WERKST = sqlReader.GetString(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.STATE = sqlReader.GetDecimal(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.EINDT = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.LGORT = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.TXZ01 = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.SUREMENGE = sqlReader.GetDecimal(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.ID = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.MENGE = sqlReader.GetDecimal(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.WERKS = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.EBELP = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.ALLMENGE = sqlReader.GetDecimal(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.COMMENTS = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(31);
                if (!sqlReader.IsDBNull(32))
                    dataObj.NETPR = sqlReader.GetString(32);
                if (!sqlReader.IsDBNull(33))
                    dataObj.EBELN = sqlReader.GetString(33);
                if (!sqlReader.IsDBNull(34))
                    dataObj.MATNR = sqlReader.GetString(34);
                if (!sqlReader.IsDBNull(35))
                    dataObj.LIFNR_NAME = sqlReader.GetString(35);
                if (!sqlReader.IsDBNull(36))
                    dataObj.MATNR_NAME = sqlReader.GetString(36);
                if (!sqlReader.IsDBNull(37))
                    dataObj.SEND_DEAPRT_CONTACT = sqlReader.GetString(37);
                if (!sqlReader.IsDBNull(38))
                    dataObj.SEND_DEAPRT_PHONE = sqlReader.GetString(38);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_SCM_D_PURCHARSEPLAN[] objs = new DisplayObject_SCM_D_PURCHARSEPLAN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_SCM_D_PURCHARSEPLAN[] Query(CauseObject_SCM_D_PURCHARSEPLAN cause, PagingParamter paging, OrderByParameter order, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  SCM_D_PURCHARSEPLAN.MSEHT, SCM_D_PURCHARSEPLAN.NAME, SCM_D_PURCHARSEPLAN.FREEUSE2, SCM_D_PURCHARSEPLAN.FREEUSE3, SCM_D_PURCHARSEPLAN.BEDAT, SCM_D_PURCHARSEPLAN.FREEUSE1, SCM_D_PURCHARSEPLAN.MODIFY_TIME, SCM_D_PURCHARSEPLAN.LIFNR, SCM_D_PURCHARSEPLAN.STATUS, SCM_D_PURCHARSEPLAN.MODIFY_DEPART_ID, SCM_D_PURCHARSEPLAN.DATA_ORGANISE_ID, SCM_D_PURCHARSEPLAN.SEND_DEAPRT_NAME, SCM_D_PURCHARSEPLAN.CODE, SCM_D_PURCHARSEPLAN.BSART, SCM_D_PURCHARSEPLAN.CREATE_TIME, SCM_D_PURCHARSEPLAN.MODIFY_USER_ID, SCM_D_PURCHARSEPLAN.SEND_DEAPRT_ID, SCM_D_PURCHARSEPLAN.MEINS, SCM_D_PURCHARSEPLAN.WERKST, SCM_D_PURCHARSEPLAN.STATE, SCM_D_PURCHARSEPLAN.EINDT, SCM_D_PURCHARSEPLAN.LGORT, SCM_D_PURCHARSEPLAN.TXZ01, SCM_D_PURCHARSEPLAN.SUREMENGE, SCM_D_PURCHARSEPLAN.CREATE_USER_ID, SCM_D_PURCHARSEPLAN.ID, SCM_D_PURCHARSEPLAN.MENGE, Case when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-本部' then '2000' when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-肿瘤中心' then '2100' when SCM_D_PURCHARSEPLAN.WERKST='武汉协和医院-西院' then '2200' else '2000' end as WERKS, SCM_D_PURCHARSEPLAN.EBELP, SCM_D_PURCHARSEPLAN.ALLMENGE, SCM_D_PURCHARSEPLAN.COMMENTS, SCM_D_PURCHARSEPLAN.CREATE_DEPART_ID, SCM_D_PURCHARSEPLAN.NETPR, SCM_D_PURCHARSEPLAN.EBELN, SCM_D_PURCHARSEPLAN.MATNR, MDM_D_DEPT_LIFNR.NAME as LIFNR_NAME, SCM_D_MATER_MATNR.BKLAS as MATNR_NAME from SCM_D_PURCHARSEPLAN left join SCM_D_HRPMATER   SCM_D_MATER_MATNR on SCM_D_PURCHARSEPLAN.MATNR = SCM_D_MATER_MATNR.MATNR left join (SELECT *  FROM (SELECT ROW_NUMBER() OVER(PARTITION BY CODE ORDER BY MDM_D_DEPT.DEPT_TYPE_ID DESC) rn,MDM_D_DEPT.ID,MDM_D_DEPT.DEPT_TYPE_ID,MDM_D_DEPT.NAME,MDM_D_DEPT.CODE FROM MDM_D_DEPT ) WHERE rn = 1)    MDM_D_DEPT_LIFNR on SCM_D_PURCHARSEPLAN.LIFNR = MDM_D_DEPT_LIFNR.CODE where (1=1)";
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("SCM_D_PURCHARSEPLAN", paging, order, sSql, parameters, trans);
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
            DisplayObject_SCM_D_PURCHARSEPLAN dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_SCM_D_PURCHARSEPLAN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.MSEHT = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.FREEUSE2 = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.FREEUSE3 = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.BEDAT = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.FREEUSE1 = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.LIFNR = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.STATUS = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.MODIFY_DEPART_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.SEND_DEAPRT_NAME = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.CODE = sqlReader.GetString(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.BSART = sqlReader.GetString(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.SEND_DEAPRT_ID = sqlReader.GetString(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.MEINS = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.WERKST = sqlReader.GetString(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.STATE = sqlReader.GetDecimal(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.EINDT = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.LGORT = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.TXZ01 = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.SUREMENGE = sqlReader.GetDecimal(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.ID = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.MENGE = sqlReader.GetDecimal(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.WERKS = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.EBELP = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.ALLMENGE = sqlReader.GetDecimal(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.COMMENTS = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.CREATE_DEPART_ID = sqlReader.GetString(31);
                if (!sqlReader.IsDBNull(32))
                    dataObj.NETPR = sqlReader.GetString(32);
                if (!sqlReader.IsDBNull(33))
                    dataObj.EBELN = sqlReader.GetString(33);
                if (!sqlReader.IsDBNull(34))
                    dataObj.MATNR = sqlReader.GetString(34);
                if (!sqlReader.IsDBNull(35))
                    dataObj.LIFNR_NAME = sqlReader.GetString(35);
                if (!sqlReader.IsDBNull(36))
                    dataObj.MATNR_NAME = sqlReader.GetString(36);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_SCM_D_PURCHARSEPLAN[] objs = new DisplayObject_SCM_D_PURCHARSEPLAN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        #endregion
    }
}
