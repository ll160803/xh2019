using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ipedf.Web.Entity;
using System.Data.OracleClient;
using System.Data;
using Ipedf.Core;
using System.Collections;

namespace Ipedf.Web.DataAccess
{
    public class HelperObject_COMPLETEPERCENT
    {
        public static EntityObject_COMPLETEPERCENT[] List(DateTime dtBegin, DateTime dtEnd, string gysAccount,string gysName)
        {
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    //平台自动生成代码
                    #region Parameters Block
                    OracleParameter[] parameters = new OracleParameter[5];
                    parameters[0] = new OracleParameter();
                    parameters[0].ParameterName = "T_BEGINTIME";
                    parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[0].Value = dtBegin.ToString("yyyy-MM-dd");

                    parameters[1] = new OracleParameter();
                    parameters[1].ParameterName = "T_ENDTIME";
                    parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[1].Value = dtEnd.ToString("yyyy-MM-dd");

                    parameters[2] = new OracleParameter();
                    parameters[2].ParameterName = "T_GYSACCOUNT";
                    parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[2].Size = 8;
                    if (!string.IsNullOrEmpty(gysAccount))
                    {
                        parameters[2].Value = gysAccount;
                    }
                    else
                    {
                        parameters[2].Value = DBNull.Value;
                    }
                    parameters[3] = new OracleParameter();
                    parameters[3].ParameterName = "T_GYSNAME";
                    parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[3].Size = 50;
                    if (!string.IsNullOrEmpty(gysName))
                    {
                        parameters[3].Value = gysName;
                    }
                    else
                    {
                        parameters[3].Value = DBNull.Value;
                    }

                    parameters[4] = new OracleParameter();
                    parameters[4].ParameterName = "RESULTCUR2";
                    parameters[4].OracleType = System.Data.OracleClient.OracleType.Cursor;
                    parameters[4].Direction = ParameterDirection.Output;
                    #endregion
                    #region Push Block

                    cmd.CommandText = "SP_SCM_COMPLETEPERCENT";
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    cmd.ExecuteNonQuery();
                    EntityObject_COMPLETEPERCENT dataObj = null;
                    ArrayList objArray = new ArrayList();//SP_SCM_COMPLETEPERCENT
                    IDataReader sqlReader = parameters[4].Value as IDataReader;
                    while (sqlReader.Read())
                    {
                        dataObj = new EntityObject_COMPLETEPERCENT();
                        if (!sqlReader.IsDBNull(0))
                            dataObj.RANK_NUM = sqlReader.GetInt32(0);
                        if (!sqlReader.IsDBNull(1))
                            dataObj.CODE = sqlReader.GetString(1);
                        if (!sqlReader.IsDBNull(2))
                            dataObj.NAME = sqlReader.GetString(2);
                        if (!sqlReader.IsDBNull(3))
                        {
                            dataObj.Percent = sqlReader.GetDecimal(3);
                        }
                        else
                        {
                            dataObj.Percent = 0;
                        }
                        objArray.Add(dataObj);
                    }
                    sqlReader.Close();
                    #endregion
                    EntityObject_COMPLETEPERCENT[] objs = new EntityObject_COMPLETEPERCENT[objArray.Count];
                    objArray.CopyTo(0, objs, 0, objs.Length);
                    return objs;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
                return null;
            }
        }

        public static EntityObject_COMPLETEPERCENT[] MaterList(string dtBegin, string dtEnd, string gysAccount, string gysName, string matnr, string txz01,string WERKST, string order, string sort,out int totalRecord, int page = 1, int pageSize = 10)
        {
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    //平台自动生成代码
                    #region Parameters Block
                    OracleParameter[] parameters = new OracleParameter[13];
                    parameters[0] = new OracleParameter();
                    parameters[0].ParameterName = "T_BEGINTIME";
                    parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[0].Value = dtBegin;

                    parameters[1] = new OracleParameter();
                    parameters[1].ParameterName = "T_ENDTIME";
                    parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[1].Value = dtEnd;

                    parameters[2] = new OracleParameter();
                    parameters[2].ParameterName = "T_GYSACCOUNT";
                    parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[2].Size = 8;
                    if (!string.IsNullOrEmpty(gysAccount))
                    {
                        parameters[2].Value = gysAccount;
                    }
                    else
                    {
                        parameters[2].Value = DBNull.Value;
                    }
                    parameters[3] = new OracleParameter();
                    parameters[3].ParameterName = "t_GYSNAME";
                    parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[3].Size = 50;
                    if (!string.IsNullOrEmpty(gysName))
                    {
                        parameters[3].Value = gysName;
                    }
                    else
                    {
                        parameters[3].Value = DBNull.Value;
                    }
                    parameters[4] = new OracleParameter();
                    parameters[4].ParameterName = "t_mater";
                    parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
                    parameters[4].Size = 10;
                    if (!string.IsNullOrEmpty(matnr))
                    {
                        parameters[4].Value = matnr;
                    }
                    else
                    {
                        parameters[4].Value = DBNull.Value;
                    }
                    parameters[5] = new OracleParameter();
                    parameters[5].ParameterName = "t_txz01";
                    parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[5].Size = 50;
                    if (!string.IsNullOrEmpty(txz01))
                    {
                        parameters[5].Value = txz01;
                    }
                    else
                    {
                        parameters[5].Value = DBNull.Value;
                    }
                    parameters[6] = new OracleParameter();
                    parameters[6].ParameterName = "p_curPage";
                    parameters[6].OracleType = System.Data.OracleClient.OracleType.Int32;

                    parameters[6].Value = page;

                    parameters[7] = new OracleParameter();
                    parameters[7].ParameterName = "p_pageSize";
                    parameters[7].OracleType = System.Data.OracleClient.OracleType.Int32;

                    parameters[7].Value = pageSize;

                    parameters[8] = new OracleParameter();
                    parameters[8].ParameterName = "p_order";
                    parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;

                    parameters[8].Value = order;

                    parameters[9] = new OracleParameter();
                    parameters[9].ParameterName = "p_sort";
                    parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;

                    parameters[9].Value = sort;

                    parameters[10] = new OracleParameter();
                    parameters[10].ParameterName = "p_totalRecords";
                    parameters[10].OracleType = System.Data.OracleClient.OracleType.Int32;
                    parameters[10].Direction = ParameterDirection.Output;

                    parameters[11] = new OracleParameter();
                    parameters[11].ParameterName = "RESULTCUR";
                    parameters[11].OracleType = System.Data.OracleClient.OracleType.Cursor;
                    parameters[11].Direction = ParameterDirection.Output;
                    parameters[12] = new OracleParameter();
                    parameters[12].ParameterName = "t_werkst";
                    parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
                    parameters[12].Size = 50;
                    if (!string.IsNullOrEmpty(WERKST))
                    {
                        parameters[12].Value = WERKST;
                    }
                    else
                    {
                        parameters[12].Value = DBNull.Value;
                    }
                    #endregion
                    #region Push Block

                    cmd.CommandText = "Sp_SCM_MATERCOMPLETEPERCENT";
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    cmd.ExecuteNonQuery();
                    totalRecord = Convert.ToInt32(parameters[10].Value);
                    EntityObject_COMPLETEPERCENT dataObj = null;
                    ArrayList objArray = new ArrayList();//SP_SCM_COMPLETEPERCENT
                    IDataReader sqlReader = parameters[11].Value as IDataReader;
                    while (sqlReader.Read())
                    {
                        dataObj = new EntityObject_COMPLETEPERCENT();
                        if (!sqlReader.IsDBNull(0))
                            dataObj.CODE = sqlReader.GetString(0);
                        if (!sqlReader.IsDBNull(1))
                            dataObj.NAME = sqlReader.GetString(1);
                        if (!sqlReader.IsDBNull(2))
                            dataObj.MENGE = sqlReader.GetDecimal(2);
                        if (!sqlReader.IsDBNull(3))
                            dataObj.DONE_Menge = sqlReader.GetDecimal(3);
                       
                        if (!sqlReader.IsDBNull(4))
                        {
                            dataObj.Percent = sqlReader.GetDecimal(4);
                        }
                        else
                        {
                            dataObj.Percent = 0;
                        }
                        if (!sqlReader.IsDBNull(5))
                            dataObj.MATNR = sqlReader.GetString(5);
                        if (!sqlReader.IsDBNull(6))
                            dataObj.TXZ01 = sqlReader.GetString(6);
                        objArray.Add(dataObj);
                    }
                    sqlReader.Close();
                    #endregion
                    EntityObject_COMPLETEPERCENT[] objs = new EntityObject_COMPLETEPERCENT[objArray.Count];
                    objArray.CopyTo(0, objs, 0, objs.Length);
                    return objs;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
                return null;
            }
        }
    }
}
