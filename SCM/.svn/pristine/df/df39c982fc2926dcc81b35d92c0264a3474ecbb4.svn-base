using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.Entity;
namespace Ipedf.Web.DataAccess
{
    public partial class HelperObject_COM_USER
    {
        public static DisplayObject_COM_SYSTEM[] GetSystemByUser(string userId)
        {
            ArrayList objArray = new ArrayList();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    string sSql = "select distinct system_id,system_name,system_display_index from v_com_query_menus t where t.user_Id = '" + userId + "' order by system_display_index";
                    IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql.ToString(), new OracleParameter[0], transaction);
                    DisplayObject_COM_SYSTEM dataObj = null;
                    while (sqlReader.Read())
                    {
                        dataObj = new DisplayObject_COM_SYSTEM();
                        if (!sqlReader.IsDBNull(0))
                            dataObj.ID = sqlReader.GetString(0);
                        if (!sqlReader.IsDBNull(1))
                            dataObj.NAME = sqlReader.GetString(1);
                        objArray.Add(dataObj);
                    }
                    sqlReader.Close();
                    try
                    {
                        transaction.Commit();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            DisplayObject_COM_SYSTEM[] objs = new DisplayObject_COM_SYSTEM[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static string GetOrganiseIdByDept(string deptId)
        {
            ArrayList objArray = new ArrayList();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    string sSql = string.Format("select t.id,t.name,t.parent_id from (select level as lv,t.id,t.name,t.type ,t.parent_id from com_depart t start with  t.id ='{0}'connect by  prior t.parent_id =  t.id) t where t.type =1 and rownum = 1 order by t.lv ", deptId); ;
                    IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql.ToString(), new OracleParameter[0], transaction);
                    DisplayObject_COM_DEPART dataObj = null;
                    while (sqlReader.Read())
                    {
                        dataObj = new DisplayObject_COM_DEPART();
                        if (!sqlReader.IsDBNull(0))
                            dataObj.ID = sqlReader.GetString(0);
                        if (!sqlReader.IsDBNull(1))
                            dataObj.NAME = sqlReader.GetString(1);
                        if (!sqlReader.IsDBNull(2))
                            dataObj.PARENT_ID = sqlReader.GetString(2);
                        objArray.Add(dataObj);
                    }
                    sqlReader.Close();
                    try
                    {
                        transaction.Commit();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            DisplayObject_COM_DEPART[] objs = new DisplayObject_COM_DEPART[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0].ID;
        }
    }
}
