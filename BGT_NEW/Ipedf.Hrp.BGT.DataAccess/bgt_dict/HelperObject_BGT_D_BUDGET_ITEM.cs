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
    [CauseObject(typeof(CauseObject_BGT_D_BUDGET_ITEM))]
    public partial class HelperObject_BGT_D_BUDGET_ITEM
    {
        #region Method Blok
        public static int Save(EntityObject_BGT_D_BUDGET_ITEM obj, IDbTransaction trans)
        {

            //平台自动生成代码
            obj.ID = Guid.NewGuid().ToString();
            string sSql = "insert into BGT_D_BUDGET_ITEM( IMPORT_TYPE_ID, ID, PREPARE_PATTERN_ID, CODE, MODIFY_DEPT_ID, COMMENTS, STATE, CREATE_USER_ID, DATA_TYPE_ID, PARENT_ID, DATA_ORGANISE_ID, IS_MERGE, CREATE_TIME, CREATE_DEPT_ID, IS_CARRYOVER, BUDGET_YEAR, IS_END, USAGE_ID, ITEM_TYPE_ID, NAME) values ( :IMPORT_TYPE_ID, :ID, :PREPARE_PATTERN_ID, :CODE, :MODIFY_DEPT_ID, :COMMENTS, :STATE, :CREATE_USER_ID, :DATA_TYPE_ID, :PARENT_ID, :DATA_ORGANISE_ID, :IS_MERGE, :CREATE_TIME, :CREATE_DEPT_ID, :IS_CARRYOVER, :BUDGET_YEAR, :IS_END, :USAGE_ID, :ITEM_TYPE_ID, :NAME)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[20];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":IMPORT_TYPE_ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.IMPORT_TYPE_ID == null ? String.Empty : obj.IMPORT_TYPE_ID;
            parameters[1] = new OracleParameter();
            parameters[1].ParameterName = ":ID";
            parameters[1].Size = 36;
            parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[1].Value = obj.ID == null ? String.Empty : obj.ID;
            parameters[2] = new OracleParameter();
            parameters[2].ParameterName = ":PREPARE_PATTERN_ID";
            parameters[2].Size = 36;
            parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[2].Value = obj.PREPARE_PATTERN_ID == null ? String.Empty : obj.PREPARE_PATTERN_ID;
            parameters[3] = new OracleParameter();
            parameters[3].ParameterName = ":CODE";
            parameters[3].Size = 50;
            parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[3].Value = obj.CODE == null ? String.Empty : obj.CODE;
            parameters[4] = new OracleParameter();
            parameters[4].ParameterName = ":MODIFY_DEPT_ID";
            parameters[4].Size = 36;
            parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[4].Value = obj.MODIFY_DEPT_ID == null ? String.Empty : obj.MODIFY_DEPT_ID;
            parameters[5] = new OracleParameter();
            parameters[5].ParameterName = ":COMMENTS";
            parameters[5].Size = 200;
            parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[5].Value = obj.COMMENTS == null ? String.Empty : obj.COMMENTS;
            parameters[6] = new OracleParameter();
            parameters[6].ParameterName = ":STATE";
            parameters[6].Size = 22;
            parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[6].Value = obj.STATE;
            parameters[7] = new OracleParameter();
            parameters[7].ParameterName = ":CREATE_USER_ID";
            parameters[7].Size = 36;
            parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[7].Value = obj.CREATE_USER_ID == null ? String.Empty : obj.CREATE_USER_ID;
            parameters[8] = new OracleParameter();
            parameters[8].ParameterName = ":DATA_TYPE_ID";
            parameters[8].Size = 36;
            parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[8].Value = obj.DATA_TYPE_ID == null ? String.Empty : obj.DATA_TYPE_ID;
            parameters[9] = new OracleParameter();
            parameters[9].ParameterName = ":PARENT_ID";
            parameters[9].Size = 36;
            parameters[9].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[9].Value = obj.PARENT_ID == null ? String.Empty : obj.PARENT_ID;
            parameters[10] = new OracleParameter();
            parameters[10].ParameterName = ":DATA_ORGANISE_ID";
            parameters[10].Size = 36;
            parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[10].Value = obj.DATA_ORGANISE_ID == null ? String.Empty : obj.DATA_ORGANISE_ID;
            parameters[11] = new OracleParameter();
            parameters[11].ParameterName = ":IS_MERGE";
            parameters[11].Size = 22;
            parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[11].Value = obj.IS_MERGE;
            parameters[12] = new OracleParameter();
            parameters[12].ParameterName = ":CREATE_TIME";
            parameters[12].Size = 7;
            parameters[12].OracleType = System.Data.OracleClient.OracleType.DateTime;
            parameters[12].Value = obj.CREATE_TIME;
            parameters[13] = new OracleParameter();
            parameters[13].ParameterName = ":CREATE_DEPT_ID";
            parameters[13].Size = 36;
            parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[13].Value = obj.CREATE_DEPT_ID == null ? String.Empty : obj.CREATE_DEPT_ID;
            parameters[14] = new OracleParameter();
            parameters[14].ParameterName = ":IS_CARRYOVER";
            parameters[14].Size = 22;
            parameters[14].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[14].Value = obj.IS_CARRYOVER;
            parameters[15] = new OracleParameter();
            parameters[15].ParameterName = ":BUDGET_YEAR";
            parameters[15].Size = 36;
            parameters[15].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[15].Value = obj.BUDGET_YEAR == null ? String.Empty : obj.BUDGET_YEAR;
            parameters[16] = new OracleParameter();
            parameters[16].ParameterName = ":IS_END";
            parameters[16].Size = 22;
            parameters[16].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[16].Value = obj.IS_END;
            parameters[17] = new OracleParameter();
            parameters[17].ParameterName = ":USAGE_ID";
            parameters[17].Size = 36;
            parameters[17].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[17].Value = obj.USAGE_ID == null ? String.Empty : obj.USAGE_ID;
            parameters[18] = new OracleParameter();
            parameters[18].ParameterName = ":ITEM_TYPE_ID";
            parameters[18].Size = 36;
            parameters[18].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[18].Value = obj.ITEM_TYPE_ID == null ? String.Empty : obj.ITEM_TYPE_ID;
            parameters[19] = new OracleParameter();
            parameters[19].ParameterName = ":NAME";
            parameters[19].Size = 50;
            parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[19].Value = obj.NAME == null ? String.Empty : obj.NAME;
            #endregion
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static int Update(EntityObject_BGT_D_BUDGET_ITEM obj, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = "update BGT_D_BUDGET_ITEM set ";
            sSql += PrepareUpdate(obj, out parameters);
            sSql += " where  ID = :ID ";
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static int Delete(EntityObject_BGT_D_BUDGET_ITEM obj, IDbTransaction trans)
        {

            //平台自动生成代码
            string sSql = "delete from BGT_D_BUDGET_ITEM where  ID = :ID ";
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
        public static EntityObject_BGT_D_BUDGET_ITEM Get(EntityObject_BGT_D_BUDGET_ITEM obj)
        {

            //平台自动生成代码
            string sSql = "select  BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID, BGT_D_BUDGET_ITEM.ID, BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID, BGT_D_BUDGET_ITEM.MODIFY_USER_ID, BGT_D_BUDGET_ITEM.CODE, BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID, BGT_D_BUDGET_ITEM.COMMENTS, BGT_D_BUDGET_ITEM.STATE, BGT_D_BUDGET_ITEM.CREATE_USER_ID, BGT_D_BUDGET_ITEM.DATA_TYPE_ID, BGT_D_BUDGET_ITEM.PARENT_ID, BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID, BGT_D_BUDGET_ITEM.IS_MERGE, BGT_D_BUDGET_ITEM.CREATE_TIME, BGT_D_BUDGET_ITEM.CREATE_DEPT_ID, BGT_D_BUDGET_ITEM.MODIFY_TIME, BGT_D_BUDGET_ITEM.IS_CARRYOVER, BGT_D_BUDGET_ITEM.BUDGET_YEAR, BGT_D_BUDGET_ITEM.IS_END, BGT_D_BUDGET_ITEM.USAGE_ID, BGT_D_BUDGET_ITEM.ITEM_TYPE_ID, BGT_D_BUDGET_ITEM.NAME,BGT_D_BUDGET_DEPT.ID AS DEPT_ID,BGT_D_BUDGET_DEPT.NAME AS DEPT_NAME,BGT_D_BUDGET_DEPT_BUDGET_ITEM.ID as TAB_ID,COM_TYPE.NAME AS COMMENTS_NAME from BGT_D_BUDGET_ITEM left join BGT_D_BUDGET_DEPT_BUDGET_ITEM on BGT_D_BUDGET_ITEM.ID = BGT_D_BUDGET_DEPT_BUDGET_ITEM.BUDGET_ITEM_ID left join BGT_D_BUDGET_DEPT on BGT_D_BUDGET_DEPT_BUDGET_ITEM.Base_Id = BGT_D_BUDGET_DEPT.Id left join COM_TYPE ON BGT_D_BUDGET_ITEM.COMMENTS = COM_TYPE.ID AND COM_TYPE.PARENT_ID = 'BGTTYPE_001' where  BGT_D_BUDGET_ITEM.ID = :ID ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            #region Push Block
            EntityObject_BGT_D_BUDGET_ITEM dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new EntityObject_BGT_D_BUDGET_ITEM();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IMPORT_TYPE_ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.COMMENTS = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.STATE = sqlReader.GetDecimal(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.DATA_TYPE_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.PARENT_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.IS_MERGE = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.BUDGET_YEAR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.IS_END = sqlReader.GetDecimal(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.USAGE_ID = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.ITEM_TYPE_ID = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.NAME = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.DEPT_ID = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.DEPT_NAME = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.TAB_ID = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.COMMENTS_NAME = sqlReader.GetString(25);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            EntityObject_BGT_D_BUDGET_ITEM[] objs = new EntityObject_BGT_D_BUDGET_ITEM[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
        public static EntityObject_BGT_D_BUDGET_ITEM Get(EntityObject_BGT_D_BUDGET_ITEM obj, IDbTransaction trans)
        {

            //平台自动生成代码
            string sSql = "select  IMPORT_TYPE_ID, ID, PREPARE_PATTERN_ID, MODIFY_USER_ID, CODE, MODIFY_DEPT_ID, COMMENTS, STATE, CREATE_USER_ID, DATA_TYPE_ID, PARENT_ID, DATA_ORGANISE_ID, IS_MERGE, CREATE_TIME, CREATE_DEPT_ID, MODIFY_TIME, IS_CARRYOVER, BUDGET_YEAR, IS_END, USAGE_ID, ITEM_TYPE_ID, NAME from BGT_D_BUDGET_ITEM where  ID = :ID ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            #region Push Block
            EntityObject_BGT_D_BUDGET_ITEM dataObj = null;
            ArrayList objArray = new ArrayList();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            while (sqlReader.Read())
            {
                dataObj = new EntityObject_BGT_D_BUDGET_ITEM();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IMPORT_TYPE_ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.COMMENTS = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.STATE = sqlReader.GetDecimal(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.DATA_TYPE_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.PARENT_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.IS_MERGE = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.BUDGET_YEAR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.IS_END = sqlReader.GetDecimal(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.USAGE_ID = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.ITEM_TYPE_ID = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.NAME = sqlReader.GetString(21);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            EntityObject_BGT_D_BUDGET_ITEM[] objs = new EntityObject_BGT_D_BUDGET_ITEM[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
        public static DisplayObject_BGT_D_BUDGET_ITEM[] List()
        {

            //平台自动生成代码
            string sSql = " select  BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID, BGT_D_BUDGET_ITEM.ID, BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID, BGT_D_BUDGET_ITEM.MODIFY_USER_ID, BGT_D_BUDGET_ITEM.CODE, BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID, BGT_D_BUDGET_ITEM.COMMENTS, BGT_D_BUDGET_ITEM.STATE, BGT_D_BUDGET_ITEM.CREATE_USER_ID, BGT_D_BUDGET_ITEM.DATA_TYPE_ID, BGT_D_BUDGET_ITEM.PARENT_ID, BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID, BGT_D_BUDGET_ITEM.IS_MERGE, BGT_D_BUDGET_ITEM.CREATE_TIME, BGT_D_BUDGET_ITEM.CREATE_DEPT_ID, BGT_D_BUDGET_ITEM.MODIFY_TIME, BGT_D_BUDGET_ITEM.IS_CARRYOVER, BGT_D_BUDGET_ITEM.BUDGET_YEAR, BGT_D_BUDGET_ITEM.IS_END, BGT_D_BUDGET_ITEM.USAGE_ID, BGT_D_BUDGET_ITEM.ITEM_TYPE_ID, BGT_D_BUDGET_ITEM.NAME, COM_TYPE_IMPORT_TYPE_ID.NAME as IMPORT_TYPE_ID_NAME, COM_TYPE_PREPARE_PATTERN_ID.NAME as PREPARE_PATTERN_ID_NAME, COM_TYPE_DATA_TYPE_ID.NAME as DATA_TYPE_ID_NAME, SELF_T.NAME as PARENT_ID_NAME, (case  when BGT_D_BUDGET_ITEM.IS_MERGE = 1 then '是' when BGT_D_BUDGET_ITEM.IS_MERGE = 2 then '否' else '' end ) as IS_MERGE_NAME, (case  when BGT_D_BUDGET_ITEM.IS_CARRYOVER = 1 then '是' when BGT_D_BUDGET_ITEM.IS_CARRYOVER = 2 then '否' else '' end ) as IS_CARRYOVER_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, (case  when BGT_D_BUDGET_ITEM.IS_END = 1 then '是' when BGT_D_BUDGET_ITEM.IS_END = 2 then '否' else '' end ) as IS_END_NAME, COM_TYPE_USAGE_ID.NAME as USAGE_ID_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME from BGT_D_BUDGET_ITEM left join COM_TYPE   COM_TYPE_IMPORT_TYPE_ID on BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID = COM_TYPE_IMPORT_TYPE_ID.ID left join COM_TYPE   COM_TYPE_PREPARE_PATTERN_ID on BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID = COM_TYPE_PREPARE_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_DATA_TYPE_ID on BGT_D_BUDGET_ITEM.DATA_TYPE_ID = COM_TYPE_DATA_TYPE_ID.ID left join BGT_D_BUDGET_ITEM   SELF_T on BGT_D_BUDGET_ITEM.PARENT_ID = SELF_T.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_BUDGET_ITEM.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_USAGE_ID on BGT_D_BUDGET_ITEM.USAGE_ID = COM_TYPE_USAGE_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_BUDGET_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID where (1=1)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[0];
            #endregion
            #region Push Block
            DisplayObject_BGT_D_BUDGET_ITEM dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_D_BUDGET_ITEM();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IMPORT_TYPE_ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.COMMENTS = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.STATE = sqlReader.GetDecimal(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.DATA_TYPE_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.PARENT_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.IS_MERGE = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.BUDGET_YEAR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.IS_END = sqlReader.GetDecimal(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.USAGE_ID = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.ITEM_TYPE_ID = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.NAME = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.IMPORT_TYPE_ID_NAME = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.PREPARE_PATTERN_ID_NAME = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.DATA_TYPE_ID_NAME = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.PARENT_ID_NAME = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.IS_MERGE_NAME = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.IS_CARRYOVER_NAME = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.IS_END_NAME = sqlReader.GetString(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.USAGE_ID_NAME = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(31);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_BGT_D_BUDGET_ITEM[] objs = new DisplayObject_BGT_D_BUDGET_ITEM[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static string PrepareCause(CauseObject_BGT_D_BUDGET_ITEM cause, out OracleParameter[] parameters)
        {

            //平台自动生成代码
            System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
            ArrayList paramList = new ArrayList();
            OracleParameter param = null;
            #region Push Block
            if (!string.IsNullOrEmpty(cause.IMPORT_TYPE_ID))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID ").Append((cause.IMPORT_TYPE_ID.StartsWith("%") || cause.IMPORT_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :IMPORT_TYPE_ID");
                param = new OracleParameter();
                param.ParameterName = ":IMPORT_TYPE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.IMPORT_TYPE_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("IMPORT_TYPE_ID"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "IMPORT_TYPE_ID"));
            }
            if (!string.IsNullOrEmpty(cause.ID))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
                param = new OracleParameter();
                param.ParameterName = ":ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("ID"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "ID"));
            }
            if (!string.IsNullOrEmpty(cause.PREPARE_PATTERN_ID))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID ").Append((cause.PREPARE_PATTERN_ID.StartsWith("%") || cause.PREPARE_PATTERN_ID.EndsWith("%")) ? " like " : " = ").Append(" :PREPARE_PATTERN_ID");
                param = new OracleParameter();
                param.ParameterName = ":PREPARE_PATTERN_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.PREPARE_PATTERN_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("PREPARE_PATTERN_ID"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "PREPARE_PATTERN_ID"));
            }
            if (!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_USER_ID");
                param = new OracleParameter();
                param.ParameterName = ":MODIFY_USER_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.MODIFY_USER_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("MODIFY_USER_ID"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "MODIFY_USER_ID"));
            }
            if (!string.IsNullOrEmpty(cause.CODE))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.CODE ").Append((cause.CODE.StartsWith("%") || cause.CODE.EndsWith("%")) ? " like " : " = ").Append(" :CODE");
                param = new OracleParameter();
                param.ParameterName = ":CODE";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.CODE;
                paramList.Add(param);
            }
            if (cause.HasINValue("CODE"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "CODE"));
            }
            if (!string.IsNullOrEmpty(cause.MODIFY_DEPT_ID))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID ").Append((cause.MODIFY_DEPT_ID.StartsWith("%") || cause.MODIFY_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :MODIFY_DEPT_ID");
                param = new OracleParameter();
                param.ParameterName = ":MODIFY_DEPT_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.MODIFY_DEPT_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("MODIFY_DEPT_ID"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "MODIFY_DEPT_ID"));
            }
            if (!string.IsNullOrEmpty(cause.COMMENTS))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :COMMENTS");
                param = new OracleParameter();
                param.ParameterName = ":COMMENTS";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 200;
                param.Value = cause.COMMENTS;
                paramList.Add(param);
            }
            if (cause.HasINValue("COMMENTS"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "COMMENTS"));
            }
            if (cause.STATE != ConstLibrary.Template.UndefineDecimal)
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.STATE = :STATE");
                param = new OracleParameter();
                param.ParameterName = ":STATE";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = cause.STATE;
                paramList.Add(param);
            }
            if (cause.HasINValue("STATE"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "STATE"));
            }
            if (!string.IsNullOrEmpty(cause.CREATE_USER_ID))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.CREATE_USER_ID ").Append((cause.CREATE_USER_ID.StartsWith("%") || cause.CREATE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_USER_ID");
                param = new OracleParameter();
                param.ParameterName = ":CREATE_USER_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.CREATE_USER_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("CREATE_USER_ID"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "CREATE_USER_ID"));
            }
            if (!string.IsNullOrEmpty(cause.DATA_TYPE_ID))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.DATA_TYPE_ID ").Append((cause.DATA_TYPE_ID.StartsWith("%") || cause.DATA_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_TYPE_ID");
                param = new OracleParameter();
                param.ParameterName = ":DATA_TYPE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.DATA_TYPE_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("DATA_TYPE_ID"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "DATA_TYPE_ID"));
            }
            if (!string.IsNullOrEmpty(cause.PARENT_ID))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.PARENT_ID ").Append((cause.PARENT_ID.StartsWith("%") || cause.PARENT_ID.EndsWith("%")) ? " like " : " = ").Append(" :PARENT_ID");
                param = new OracleParameter();
                param.ParameterName = ":PARENT_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.PARENT_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("PARENT_ID"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "PARENT_ID"));
            }
            if (!string.IsNullOrEmpty(cause.DATA_ORGANISE_ID))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID ").Append((cause.DATA_ORGANISE_ID.StartsWith("%") || cause.DATA_ORGANISE_ID.EndsWith("%")) ? " like " : " = ").Append(" :DATA_ORGANISE_ID");
                param = new OracleParameter();
                param.ParameterName = ":DATA_ORGANISE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.DATA_ORGANISE_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("DATA_ORGANISE_ID"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "DATA_ORGANISE_ID"));
            }
            if (cause.IS_MERGE != ConstLibrary.Template.UndefineDecimal)
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.IS_MERGE = :IS_MERGE");
                param = new OracleParameter();
                param.ParameterName = ":IS_MERGE";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = cause.IS_MERGE;
                paramList.Add(param);
            }
            if (cause.HasINValue("IS_MERGE"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "IS_MERGE"));
            }
            if (cause.CREATE_TIME != null)
            {
                if (cause.CREATE_TIME.Begin != null)
                {
                    strBuf.Append(" And BGT_D_BUDGET_ITEM.CREATE_TIME >= :CREATE_TIME_BEGIN");
                    param = new OracleParameter();
                    param.ParameterName = ":CREATE_TIME_BEGIN";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.CREATE_TIME.Begin;
                    paramList.Add(param);
                }
                if (cause.CREATE_TIME.End != null)
                {
                    strBuf.Append(" And BGT_D_BUDGET_ITEM.CREATE_TIME < :CREATE_TIME_END");
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
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "CREATE_TIME"));
            }
            if (!string.IsNullOrEmpty(cause.CREATE_DEPT_ID))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.CREATE_DEPT_ID ").Append((cause.CREATE_DEPT_ID.StartsWith("%") || cause.CREATE_DEPT_ID.EndsWith("%")) ? " like " : " = ").Append(" :CREATE_DEPT_ID");
                param = new OracleParameter();
                param.ParameterName = ":CREATE_DEPT_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.CREATE_DEPT_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("CREATE_DEPT_ID"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "CREATE_DEPT_ID"));
            }
            if (cause.MODIFY_TIME != null)
            {
                if (cause.MODIFY_TIME.Begin != null)
                {
                    strBuf.Append(" And BGT_D_BUDGET_ITEM.MODIFY_TIME >= :MODIFY_TIME_BEGIN");
                    param = new OracleParameter();
                    param.ParameterName = ":MODIFY_TIME_BEGIN";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.MODIFY_TIME.Begin;
                    paramList.Add(param);
                }
                if (cause.MODIFY_TIME.End != null)
                {
                    strBuf.Append(" And BGT_D_BUDGET_ITEM.MODIFY_TIME < :MODIFY_TIME_END");
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
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "MODIFY_TIME"));
            }
            if (cause.IS_CARRYOVER != ConstLibrary.Template.UndefineDecimal)
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.IS_CARRYOVER = :IS_CARRYOVER");
                param = new OracleParameter();
                param.ParameterName = ":IS_CARRYOVER";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = cause.IS_CARRYOVER;
                paramList.Add(param);
            }
            if (cause.HasINValue("IS_CARRYOVER"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "IS_CARRYOVER"));
            }
            if (!string.IsNullOrEmpty(cause.BUDGET_YEAR))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.BUDGET_YEAR ").Append((cause.BUDGET_YEAR.StartsWith("%") || cause.BUDGET_YEAR.EndsWith("%")) ? " like " : " = ").Append(" :BUDGET_YEAR");
                param = new OracleParameter();
                param.ParameterName = ":BUDGET_YEAR";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.BUDGET_YEAR;
                paramList.Add(param);
            }
            if (cause.HasINValue("BUDGET_YEAR"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "BUDGET_YEAR"));
            }
            if (cause.IS_END != ConstLibrary.Template.UndefineDecimal)
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.IS_END = :IS_END");
                param = new OracleParameter();
                param.ParameterName = ":IS_END";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = cause.IS_END;
                paramList.Add(param);
            }
            if (cause.HasINValue("IS_END"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "IS_END"));
            }
            if (!string.IsNullOrEmpty(cause.USAGE_ID))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.USAGE_ID ").Append((cause.USAGE_ID.StartsWith("%") || cause.USAGE_ID.EndsWith("%")) ? " like " : " = ").Append(" :USAGE_ID");
                param = new OracleParameter();
                param.ParameterName = ":USAGE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.USAGE_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("USAGE_ID"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "USAGE_ID"));
            }
            if (!string.IsNullOrEmpty(cause.ITEM_TYPE_ID))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.ITEM_TYPE_ID ").Append((cause.ITEM_TYPE_ID.StartsWith("%") || cause.ITEM_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :ITEM_TYPE_ID");
                param = new OracleParameter();
                param.ParameterName = ":ITEM_TYPE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.ITEM_TYPE_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("ITEM_TYPE_ID"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "ITEM_TYPE_ID"));
            }
            if (!string.IsNullOrEmpty(cause.NAME))
            {
                strBuf.Append(" And BGT_D_BUDGET_ITEM.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
                param = new OracleParameter();
                param.ParameterName = ":NAME";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.NAME;
                paramList.Add(param);
            }
            if (cause.HasINValue("NAME"))
            {
                strBuf.Append(cause.GetINSQL("BGT_D_BUDGET_ITEM", "NAME"));
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
        public static DisplayObject_BGT_D_BUDGET_ITEM[] Query(CauseObject_BGT_D_BUDGET_ITEM cause)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID, BGT_D_BUDGET_ITEM.ID, BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID, BGT_D_BUDGET_ITEM.MODIFY_USER_ID, BGT_D_BUDGET_ITEM.CODE, BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID, BGT_D_BUDGET_ITEM.COMMENTS, BGT_D_BUDGET_ITEM.STATE, BGT_D_BUDGET_ITEM.CREATE_USER_ID, BGT_D_BUDGET_ITEM.DATA_TYPE_ID, BGT_D_BUDGET_ITEM.PARENT_ID, BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID, BGT_D_BUDGET_ITEM.IS_MERGE, BGT_D_BUDGET_ITEM.CREATE_TIME, BGT_D_BUDGET_ITEM.CREATE_DEPT_ID, BGT_D_BUDGET_ITEM.MODIFY_TIME, BGT_D_BUDGET_ITEM.IS_CARRYOVER, BGT_D_BUDGET_ITEM.BUDGET_YEAR, BGT_D_BUDGET_ITEM.IS_END, BGT_D_BUDGET_ITEM.USAGE_ID, BGT_D_BUDGET_ITEM.ITEM_TYPE_ID, BGT_D_BUDGET_ITEM.NAME, COM_TYPE_IMPORT_TYPE_ID.NAME as IMPORT_TYPE_ID_NAME, COM_TYPE_PREPARE_PATTERN_ID.NAME as PREPARE_PATTERN_ID_NAME, COM_TYPE_DATA_TYPE_ID.NAME as DATA_TYPE_ID_NAME, SELF_T.NAME as PARENT_ID_NAME, (case  when BGT_D_BUDGET_ITEM.IS_MERGE = 1 then '是' when BGT_D_BUDGET_ITEM.IS_MERGE = 2 then '否' else '' end ) as IS_MERGE_NAME, (case  when BGT_D_BUDGET_ITEM.IS_CARRYOVER = 1 then '是' when BGT_D_BUDGET_ITEM.IS_CARRYOVER = 2 then '否' else '' end ) as IS_CARRYOVER_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, (case  when BGT_D_BUDGET_ITEM.IS_END = 1 then '是' when BGT_D_BUDGET_ITEM.IS_END = 2 then '否' else '' end ) as IS_END_NAME, COM_TYPE_USAGE_ID.NAME as USAGE_ID_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME from BGT_D_BUDGET_ITEM left join COM_TYPE   COM_TYPE_IMPORT_TYPE_ID on BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID = COM_TYPE_IMPORT_TYPE_ID.ID left join COM_TYPE   COM_TYPE_PREPARE_PATTERN_ID on BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID = COM_TYPE_PREPARE_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_DATA_TYPE_ID on BGT_D_BUDGET_ITEM.DATA_TYPE_ID = COM_TYPE_DATA_TYPE_ID.ID left join BGT_D_BUDGET_ITEM   SELF_T on BGT_D_BUDGET_ITEM.PARENT_ID = SELF_T.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_BUDGET_ITEM.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_USAGE_ID on BGT_D_BUDGET_ITEM.USAGE_ID = COM_TYPE_USAGE_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_BUDGET_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_BGT_D_BUDGET_ITEM dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_D_BUDGET_ITEM();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IMPORT_TYPE_ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.COMMENTS = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.STATE = sqlReader.GetDecimal(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.DATA_TYPE_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.PARENT_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.IS_MERGE = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.BUDGET_YEAR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.IS_END = sqlReader.GetDecimal(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.USAGE_ID = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.ITEM_TYPE_ID = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.NAME = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.IMPORT_TYPE_ID_NAME = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.PREPARE_PATTERN_ID_NAME = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.DATA_TYPE_ID_NAME = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.PARENT_ID_NAME = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.IS_MERGE_NAME = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.IS_CARRYOVER_NAME = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.IS_END_NAME = sqlReader.GetString(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.USAGE_ID_NAME = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(31);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_BGT_D_BUDGET_ITEM[] objs = new DisplayObject_BGT_D_BUDGET_ITEM[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static int Delete(CauseObject_BGT_D_BUDGET_ITEM cause, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = "delete from BGT_D_BUDGET_ITEM where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static DisplayObject_BGT_D_BUDGET_ITEM[] Query(CauseObject_BGT_D_BUDGET_ITEM cause, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID, BGT_D_BUDGET_ITEM.ID, BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID, BGT_D_BUDGET_ITEM.MODIFY_USER_ID, BGT_D_BUDGET_ITEM.CODE, BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID, BGT_D_BUDGET_ITEM.COMMENTS, BGT_D_BUDGET_ITEM.STATE, BGT_D_BUDGET_ITEM.CREATE_USER_ID, BGT_D_BUDGET_ITEM.DATA_TYPE_ID, BGT_D_BUDGET_ITEM.PARENT_ID, BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID, BGT_D_BUDGET_ITEM.IS_MERGE, BGT_D_BUDGET_ITEM.CREATE_TIME, BGT_D_BUDGET_ITEM.CREATE_DEPT_ID, BGT_D_BUDGET_ITEM.MODIFY_TIME, BGT_D_BUDGET_ITEM.IS_CARRYOVER, BGT_D_BUDGET_ITEM.BUDGET_YEAR, BGT_D_BUDGET_ITEM.IS_END, BGT_D_BUDGET_ITEM.USAGE_ID, BGT_D_BUDGET_ITEM.ITEM_TYPE_ID, BGT_D_BUDGET_ITEM.NAME, COM_TYPE_IMPORT_TYPE_ID.NAME as IMPORT_TYPE_ID_NAME, COM_TYPE_PREPARE_PATTERN_ID.NAME as PREPARE_PATTERN_ID_NAME, COM_TYPE_DATA_TYPE_ID.NAME as DATA_TYPE_ID_NAME, SELF_T.NAME as PARENT_ID_NAME, (case  when BGT_D_BUDGET_ITEM.IS_MERGE = 1 then '是' when BGT_D_BUDGET_ITEM.IS_MERGE = 2 then '否' else '' end ) as IS_MERGE_NAME, (case  when BGT_D_BUDGET_ITEM.IS_CARRYOVER = 1 then '是' when BGT_D_BUDGET_ITEM.IS_CARRYOVER = 2 then '否' else '' end ) as IS_CARRYOVER_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, (case  when BGT_D_BUDGET_ITEM.IS_END = 1 then '是' when BGT_D_BUDGET_ITEM.IS_END = 2 then '否' else '' end ) as IS_END_NAME, COM_TYPE_USAGE_ID.NAME as USAGE_ID_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME from BGT_D_BUDGET_ITEM left join COM_TYPE   COM_TYPE_IMPORT_TYPE_ID on BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID = COM_TYPE_IMPORT_TYPE_ID.ID left join COM_TYPE   COM_TYPE_PREPARE_PATTERN_ID on BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID = COM_TYPE_PREPARE_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_DATA_TYPE_ID on BGT_D_BUDGET_ITEM.DATA_TYPE_ID = COM_TYPE_DATA_TYPE_ID.ID left join BGT_D_BUDGET_ITEM   SELF_T on BGT_D_BUDGET_ITEM.PARENT_ID = SELF_T.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_BUDGET_ITEM.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_USAGE_ID on BGT_D_BUDGET_ITEM.USAGE_ID = COM_TYPE_USAGE_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_BUDGET_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_BGT_D_BUDGET_ITEM dataObj = null;
            ArrayList objArray = new ArrayList();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_D_BUDGET_ITEM();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IMPORT_TYPE_ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.COMMENTS = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.STATE = sqlReader.GetDecimal(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.DATA_TYPE_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.PARENT_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.IS_MERGE = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.BUDGET_YEAR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.IS_END = sqlReader.GetDecimal(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.USAGE_ID = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.ITEM_TYPE_ID = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.NAME = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.IMPORT_TYPE_ID_NAME = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.PREPARE_PATTERN_ID_NAME = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.DATA_TYPE_ID_NAME = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.PARENT_ID_NAME = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.IS_MERGE_NAME = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.IS_CARRYOVER_NAME = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.IS_END_NAME = sqlReader.GetString(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.USAGE_ID_NAME = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(31);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_BGT_D_BUDGET_ITEM[] objs = new DisplayObject_BGT_D_BUDGET_ITEM[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_BGT_D_BUDGET_ITEM[] Query(CauseObject_BGT_D_BUDGET_ITEM cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID, BGT_D_BUDGET_ITEM.ID, BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID, BGT_D_BUDGET_ITEM.MODIFY_USER_ID, BGT_D_BUDGET_ITEM.CODE, BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID, BGT_D_BUDGET_ITEM.COMMENTS, BGT_D_BUDGET_ITEM.STATE, BGT_D_BUDGET_ITEM.CREATE_USER_ID, BGT_D_BUDGET_ITEM.DATA_TYPE_ID, BGT_D_BUDGET_ITEM.PARENT_ID, BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID, BGT_D_BUDGET_ITEM.IS_MERGE, BGT_D_BUDGET_ITEM.CREATE_TIME, BGT_D_BUDGET_ITEM.CREATE_DEPT_ID, BGT_D_BUDGET_ITEM.MODIFY_TIME, BGT_D_BUDGET_ITEM.IS_CARRYOVER, BGT_D_BUDGET_ITEM.BUDGET_YEAR, BGT_D_BUDGET_ITEM.IS_END, BGT_D_BUDGET_ITEM.USAGE_ID, BGT_D_BUDGET_ITEM.ITEM_TYPE_ID, BGT_D_BUDGET_ITEM.NAME, COM_TYPE_IMPORT_TYPE_ID.NAME as IMPORT_TYPE_ID_NAME, COM_TYPE_PREPARE_PATTERN_ID.NAME as PREPARE_PATTERN_ID_NAME, COM_TYPE_DATA_TYPE_ID.NAME as DATA_TYPE_ID_NAME, SELF_T.NAME as PARENT_ID_NAME, (case  when BGT_D_BUDGET_ITEM.IS_MERGE = 1 then '是' when BGT_D_BUDGET_ITEM.IS_MERGE = 2 then '否' else '' end ) as IS_MERGE_NAME, (case  when BGT_D_BUDGET_ITEM.IS_CARRYOVER = 1 then '是' when BGT_D_BUDGET_ITEM.IS_CARRYOVER = 2 then '否' else '' end ) as IS_CARRYOVER_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, (case  when BGT_D_BUDGET_ITEM.IS_END = 1 then '是' when BGT_D_BUDGET_ITEM.IS_END = 2 then '否' else '' end ) as IS_END_NAME, COM_TYPE_USAGE_ID.NAME as USAGE_ID_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME,BGT_D_BUDGET_DEPT.ID AS DEPT_ID,BGT_D_BUDGET_DEPT.NAME AS DEPT_NAME,BGT_D_BUDGET_DEPT_BUDGET_ITEM.ID AS TAB_ID,COMMENTS_TYPE.NAME AS COMMENTS_NAME from BGT_D_BUDGET_ITEM left join COM_TYPE   COM_TYPE_IMPORT_TYPE_ID on BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID = COM_TYPE_IMPORT_TYPE_ID.ID left join COM_TYPE   COM_TYPE_PREPARE_PATTERN_ID on BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID = COM_TYPE_PREPARE_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_DATA_TYPE_ID on BGT_D_BUDGET_ITEM.DATA_TYPE_ID = COM_TYPE_DATA_TYPE_ID.ID left join BGT_D_BUDGET_ITEM   SELF_T on BGT_D_BUDGET_ITEM.PARENT_ID = SELF_T.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_BUDGET_ITEM.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_USAGE_ID on BGT_D_BUDGET_ITEM.USAGE_ID = COM_TYPE_USAGE_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_BUDGET_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID left join BGT_D_BUDGET_DEPT_BUDGET_ITEM on BGT_D_BUDGET_ITEM.ID = BGT_D_BUDGET_DEPT_BUDGET_ITEM.BUDGET_ITEM_ID left join BGT_D_BUDGET_DEPT on BGT_D_BUDGET_DEPT_BUDGET_ITEM.Base_Id = BGT_D_BUDGET_DEPT.Id left join COM_TYPE COMMENTS_TYPE ON BGT_D_BUDGET_ITEM.COMMENTS = COMMENTS_TYPE.ID AND COMMENTS_TYPE.PARENT_ID = 'BGTTYPE_001' where (1=1)";
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_BUDGET_ITEM", paging, order, sSql, parameters, connection);
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
            DisplayObject_BGT_D_BUDGET_ITEM dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_D_BUDGET_ITEM();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IMPORT_TYPE_ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.COMMENTS = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.STATE = sqlReader.GetDecimal(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.DATA_TYPE_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.PARENT_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.IS_MERGE = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.BUDGET_YEAR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.IS_END = sqlReader.GetDecimal(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.USAGE_ID = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.ITEM_TYPE_ID = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.NAME = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.IMPORT_TYPE_ID_NAME = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.PREPARE_PATTERN_ID_NAME = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.DATA_TYPE_ID_NAME = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.PARENT_ID_NAME = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.IS_MERGE_NAME = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.IS_CARRYOVER_NAME = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.IS_END_NAME = sqlReader.GetString(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.USAGE_ID_NAME = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(31);
                if (!sqlReader.IsDBNull(32))
                    dataObj.DEPT_ID = sqlReader.GetString(32);
                if (!sqlReader.IsDBNull(33))
                    dataObj.DEPT_NAME = sqlReader.GetString(33);
                if (!sqlReader.IsDBNull(34))
                    dataObj.TAB_ID = sqlReader.GetString(34);
                if (!sqlReader.IsDBNull(35))
                    dataObj.COMMENTS_NAME = sqlReader.GetString(35);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_BGT_D_BUDGET_ITEM[] objs = new DisplayObject_BGT_D_BUDGET_ITEM[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_BGT_D_BUDGET_ITEM[] Query(CauseObject_BGT_D_BUDGET_ITEM cause, PagingParamter paging, OrderByParameter order, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID, BGT_D_BUDGET_ITEM.ID, BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID, BGT_D_BUDGET_ITEM.MODIFY_USER_ID, BGT_D_BUDGET_ITEM.CODE, BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID, BGT_D_BUDGET_ITEM.COMMENTS, BGT_D_BUDGET_ITEM.STATE, BGT_D_BUDGET_ITEM.CREATE_USER_ID, BGT_D_BUDGET_ITEM.DATA_TYPE_ID, BGT_D_BUDGET_ITEM.PARENT_ID, BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID, BGT_D_BUDGET_ITEM.IS_MERGE, BGT_D_BUDGET_ITEM.CREATE_TIME, BGT_D_BUDGET_ITEM.CREATE_DEPT_ID, BGT_D_BUDGET_ITEM.MODIFY_TIME, BGT_D_BUDGET_ITEM.IS_CARRYOVER, BGT_D_BUDGET_ITEM.BUDGET_YEAR, BGT_D_BUDGET_ITEM.IS_END, BGT_D_BUDGET_ITEM.USAGE_ID, BGT_D_BUDGET_ITEM.ITEM_TYPE_ID, BGT_D_BUDGET_ITEM.NAME, COM_TYPE_IMPORT_TYPE_ID.NAME as IMPORT_TYPE_ID_NAME, COM_TYPE_PREPARE_PATTERN_ID.NAME as PREPARE_PATTERN_ID_NAME, COM_TYPE_DATA_TYPE_ID.NAME as DATA_TYPE_ID_NAME, SELF_T.NAME as PARENT_ID_NAME, (case  when BGT_D_BUDGET_ITEM.IS_MERGE = 1 then '是' when BGT_D_BUDGET_ITEM.IS_MERGE = 2 then '否' else '' end ) as IS_MERGE_NAME, (case  when BGT_D_BUDGET_ITEM.IS_CARRYOVER = 1 then '是' when BGT_D_BUDGET_ITEM.IS_CARRYOVER = 2 then '否' else '' end ) as IS_CARRYOVER_NAME, BGT_D_BUDGET_YEAR_BUDGET_YEAR.BUDGET_YEAR as BUDGET_YEAR_NAME, (case  when BGT_D_BUDGET_ITEM.IS_END = 1 then '是' when BGT_D_BUDGET_ITEM.IS_END = 2 then '否' else '' end ) as IS_END_NAME, COM_TYPE_USAGE_ID.NAME as USAGE_ID_NAME, COM_TYPE_ITEM_TYPE_ID.NAME as ITEM_TYPE_ID_NAME from BGT_D_BUDGET_ITEM left join COM_TYPE   COM_TYPE_IMPORT_TYPE_ID on BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID = COM_TYPE_IMPORT_TYPE_ID.ID left join COM_TYPE   COM_TYPE_PREPARE_PATTERN_ID on BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID = COM_TYPE_PREPARE_PATTERN_ID.ID left join COM_TYPE   COM_TYPE_DATA_TYPE_ID on BGT_D_BUDGET_ITEM.DATA_TYPE_ID = COM_TYPE_DATA_TYPE_ID.ID left join BGT_D_BUDGET_ITEM   SELF_T on BGT_D_BUDGET_ITEM.PARENT_ID = SELF_T.ID left join BGT_D_BUDGET_YEAR   BGT_D_BUDGET_YEAR_BUDGET_YEAR on BGT_D_BUDGET_ITEM.BUDGET_YEAR = BGT_D_BUDGET_YEAR_BUDGET_YEAR.ID left join COM_TYPE   COM_TYPE_USAGE_ID on BGT_D_BUDGET_ITEM.USAGE_ID = COM_TYPE_USAGE_ID.ID left join COM_TYPE   COM_TYPE_ITEM_TYPE_ID on BGT_D_BUDGET_ITEM.ITEM_TYPE_ID = COM_TYPE_ITEM_TYPE_ID.ID where (1=1)";
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("BGT_D_BUDGET_ITEM", paging, order, sSql, parameters, trans);
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
            DisplayObject_BGT_D_BUDGET_ITEM dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_BGT_D_BUDGET_ITEM();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IMPORT_TYPE_ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PREPARE_PATTERN_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.CODE = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.MODIFY_DEPT_ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.COMMENTS = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.STATE = sqlReader.GetDecimal(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.CREATE_USER_ID = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.DATA_TYPE_ID = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.PARENT_ID = sqlReader.GetString(10);
                if (!sqlReader.IsDBNull(11))
                    dataObj.DATA_ORGANISE_ID = sqlReader.GetString(11);
                if (!sqlReader.IsDBNull(12))
                    dataObj.IS_MERGE = sqlReader.GetDecimal(12);
                if (!sqlReader.IsDBNull(13))
                    dataObj.CREATE_TIME = sqlReader.GetDateTime(13);
                if (!sqlReader.IsDBNull(14))
                    dataObj.CREATE_DEPT_ID = sqlReader.GetString(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.MODIFY_TIME = sqlReader.GetDateTime(15);
                if (!sqlReader.IsDBNull(16))
                    dataObj.IS_CARRYOVER = sqlReader.GetDecimal(16);
                if (!sqlReader.IsDBNull(17))
                    dataObj.BUDGET_YEAR = sqlReader.GetString(17);
                if (!sqlReader.IsDBNull(18))
                    dataObj.IS_END = sqlReader.GetDecimal(18);
                if (!sqlReader.IsDBNull(19))
                    dataObj.USAGE_ID = sqlReader.GetString(19);
                if (!sqlReader.IsDBNull(20))
                    dataObj.ITEM_TYPE_ID = sqlReader.GetString(20);
                if (!sqlReader.IsDBNull(21))
                    dataObj.NAME = sqlReader.GetString(21);
                if (!sqlReader.IsDBNull(22))
                    dataObj.IMPORT_TYPE_ID_NAME = sqlReader.GetString(22);
                if (!sqlReader.IsDBNull(23))
                    dataObj.PREPARE_PATTERN_ID_NAME = sqlReader.GetString(23);
                if (!sqlReader.IsDBNull(24))
                    dataObj.DATA_TYPE_ID_NAME = sqlReader.GetString(24);
                if (!sqlReader.IsDBNull(25))
                    dataObj.PARENT_ID_NAME = sqlReader.GetString(25);
                if (!sqlReader.IsDBNull(26))
                    dataObj.IS_MERGE_NAME = sqlReader.GetString(26);
                if (!sqlReader.IsDBNull(27))
                    dataObj.IS_CARRYOVER_NAME = sqlReader.GetString(27);
                if (!sqlReader.IsDBNull(28))
                    dataObj.BUDGET_YEAR_NAME = sqlReader.GetString(28);
                if (!sqlReader.IsDBNull(29))
                    dataObj.IS_END_NAME = sqlReader.GetString(29);
                if (!sqlReader.IsDBNull(30))
                    dataObj.USAGE_ID_NAME = sqlReader.GetString(30);
                if (!sqlReader.IsDBNull(31))
                    dataObj.ITEM_TYPE_ID_NAME = sqlReader.GetString(31);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_BGT_D_BUDGET_ITEM[] objs = new DisplayObject_BGT_D_BUDGET_ITEM[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static string PrepareUpdate(EntityObject_BGT_D_BUDGET_ITEM obj, out OracleParameter[] parameters)
        {

            //平台自动生成代码
            List<string> strBuf = new List<string>();
            ArrayList paramList = new ArrayList();
            OracleParameter param = null;
            #region Push Block
            if (!obj.IsNotUpdate("IMPORT_TYPE_ID"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.IMPORT_TYPE_ID = :IMPORT_TYPE_ID");
                param = new OracleParameter();
                param.ParameterName = ":IMPORT_TYPE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.IMPORT_TYPE_ID) ? string.Empty : obj.IMPORT_TYPE_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("PREPARE_PATTERN_ID"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.PREPARE_PATTERN_ID = :PREPARE_PATTERN_ID");
                param = new OracleParameter();
                param.ParameterName = ":PREPARE_PATTERN_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.PREPARE_PATTERN_ID) ? string.Empty : obj.PREPARE_PATTERN_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("MODIFY_USER_ID"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.MODIFY_USER_ID = :MODIFY_USER_ID");
                param = new OracleParameter();
                param.ParameterName = ":MODIFY_USER_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("CODE"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.CODE = :CODE");
                param = new OracleParameter();
                param.ParameterName = ":CODE";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.CODE) ? string.Empty : obj.CODE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("MODIFY_DEPT_ID"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.MODIFY_DEPT_ID = :MODIFY_DEPT_ID");
                param = new OracleParameter();
                param.ParameterName = ":MODIFY_DEPT_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.MODIFY_DEPT_ID) ? string.Empty : obj.MODIFY_DEPT_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("COMMENTS"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.COMMENTS = :COMMENTS");
                param = new OracleParameter();
                param.ParameterName = ":COMMENTS";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 200;
                param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("STATE"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.STATE = :STATE");
                param = new OracleParameter();
                param.ParameterName = ":STATE";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.STATE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("DATA_TYPE_ID"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.DATA_TYPE_ID = :DATA_TYPE_ID");
                param = new OracleParameter();
                param.ParameterName = ":DATA_TYPE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.DATA_TYPE_ID) ? string.Empty : obj.DATA_TYPE_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("PARENT_ID"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.PARENT_ID = :PARENT_ID");
                param = new OracleParameter();
                param.ParameterName = ":PARENT_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.PARENT_ID) ? string.Empty : obj.PARENT_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("DATA_ORGANISE_ID"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.DATA_ORGANISE_ID = :DATA_ORGANISE_ID");
                param = new OracleParameter();
                param.ParameterName = ":DATA_ORGANISE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.DATA_ORGANISE_ID) ? string.Empty : obj.DATA_ORGANISE_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("IS_MERGE"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.IS_MERGE = :IS_MERGE");
                param = new OracleParameter();
                param.ParameterName = ":IS_MERGE";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.IS_MERGE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("CREATE_DEPT_ID"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.CREATE_DEPT_ID = :CREATE_DEPT_ID");
                param = new OracleParameter();
                param.ParameterName = ":CREATE_DEPT_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.CREATE_DEPT_ID) ? string.Empty : obj.CREATE_DEPT_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("MODIFY_TIME"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.MODIFY_TIME = :MODIFY_TIME");
                param = new OracleParameter();
                param.ParameterName = ":MODIFY_TIME";
                param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                param.Size = 7;
                param.Value = obj.MODIFY_TIME;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("IS_CARRYOVER"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.IS_CARRYOVER = :IS_CARRYOVER");
                param = new OracleParameter();
                param.ParameterName = ":IS_CARRYOVER";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.IS_CARRYOVER;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("BUDGET_YEAR"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.BUDGET_YEAR = :BUDGET_YEAR");
                param = new OracleParameter();
                param.ParameterName = ":BUDGET_YEAR";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.BUDGET_YEAR) ? string.Empty : obj.BUDGET_YEAR;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("IS_END"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.IS_END = :IS_END");
                param = new OracleParameter();
                param.ParameterName = ":IS_END";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.IS_END;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("USAGE_ID"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.USAGE_ID = :USAGE_ID");
                param = new OracleParameter();
                param.ParameterName = ":USAGE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.USAGE_ID) ? string.Empty : obj.USAGE_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("ITEM_TYPE_ID"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.ITEM_TYPE_ID = :ITEM_TYPE_ID");
                param = new OracleParameter();
                param.ParameterName = ":ITEM_TYPE_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.ITEM_TYPE_ID) ? string.Empty : obj.ITEM_TYPE_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("NAME"))
            {
                strBuf.Add("  BGT_D_BUDGET_ITEM.NAME = :NAME");
                param = new OracleParameter();
                param.ParameterName = ":NAME";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
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
