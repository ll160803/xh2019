
using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
//using System.Web.UI.HtmlControls;
using System.Text;
using System.Xml;
using System.IO;
using Ipedf.Core;
using System.Data.SqlClient;
using Ipedf.Web.DataAccess;
using System.Security.Cryptography;
using System.Collections;
//using ExamSys.Common.system;
using System.Data.OracleClient;
using Ipedf.Web.Entity;
using System.Reflection;
using Ipedf.Common;
namespace Ipedf.Web.BizLogic
{
    public partial class SystemLogic
    {
         System.Collections.Hashtable organiseCache = Hashtable.Synchronized(new Hashtable());
        private string PrepareOrganiseCacheKey(string departId)
        {
            return departId;
        }
        /// <summary>
        /// 清空单位缓存,当单位数据发生变更时请调用此方法以更新缓存
        /// </summary>
        public  void ResetOrganiseCache()
        {
            organiseCache.Clear();
        }
        public string SearchOrganiseByDepart(string departId)
        {
            departId = string.IsNullOrEmpty(departId) ? string.Empty : departId;
            string cacheKey = PrepareOrganiseCacheKey(departId);
            if (organiseCache[cacheKey] == null)
            {
                string organiseId = HelperObject_COM_USER.GetOrganiseIdByDept(departId);
                //缓存结果
                organiseCache[cacheKey] = organiseId;
                return organiseId;
            }
            else
            {
                return (string)organiseCache[cacheKey];
            }
        }
        
        public  List<DisplayObject_COM_ROLE_M_USER> SearchRoleByUser(string userId)
        {
            List<DisplayObject_COM_ROLE_M_USER> ret = new List<DisplayObject_COM_ROLE_M_USER>();
            CauseObject_COM_ROLE_M_USER p = new CauseObject_COM_ROLE_M_USER();
            p.USER_ID = userId;
            DisplayObject_COM_ROLE_M_USER[] results = HelperObject_COM_ROLE_M_USER.Query(p);
            ret.AddRange(results);
            return ret;
        }
        public  List<DisplayObject_COM_ROLE_M_DATA> SearcheStrategyByRole(string roleId)
        {
            List<DisplayObject_COM_ROLE_M_DATA> ret = new List<DisplayObject_COM_ROLE_M_DATA>();
            CauseObject_COM_ROLE_M_DATA p = new CauseObject_COM_ROLE_M_DATA();
            p.ROLE_ID = roleId;
            DisplayObject_COM_ROLE_M_DATA[] results = HelperObject_COM_ROLE_M_DATA.Query(p);
            ret.AddRange(results);
            return ret;
        }
        public  QuerayAditStrategy SearchStrategyById(string strategyId)
        {
            CauseObject_COM_STRATEGY p = new CauseObject_COM_STRATEGY();
            DisplayObject_COM_STRATEGY[] strategies = HelperObject_COM_STRATEGY.Query(p);
            return (QuerayAditStrategy)System.Activator.CreateInstance(Type.GetType(strategies[0].STRATEGY_TYPE));
        }
        public  QuerayAditStrategy SearchStrategyByType(string type)
        {
             return (QuerayAditStrategy)System.Activator.CreateInstance(Type.GetType(type));
        }
        
       
        public ComLevelDataEntity[] PrepareHierarchyData(ComLevelDataEntity entity)
        {
            return IDALProvider.IDAL.PrepareHierarchyData(entity);
        }
        /// <summary>
        /// 通过拼接sql的方式来构造一个Display_Com_Data类型的数组,仅填充Id和Name属性
        /// </summary>
        /// <param name="table"></param>
        /// <param name="valueField"></param>
        /// <param name="nameField"></param>
        /// <param name="like"></param>
        /// <param name="paging"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public DisplayObject_COM_DATA[] PrepareCommonData(string table, string valueField, string nameField, string like,PagingParamter paging,OrderByParameter order)
        {
            AuditQuery(table, ref like);
            string sSql = string.Format("select {0} as ID, {1} as NAME from {2} where (1=1)  {3} ", valueField, nameField, table, like);
            System.Collections.Specialized.NameValueCollection entities = new System.Collections.Specialized.NameValueCollection();
            #region Parameters Block
            IDataReader sqlReader = null;
            OracleParameter[] parameters = new OracleParameter[0];
            #endregion
            #region Push Block
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            if (paging != null)
            {
                string countSql = string.Empty;
                countSql = string.Format("Select Count(*) From {0} Where (1=1) {1}",table,like);
                if (paging.TotalRecords == 0)
                {
                    paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection);
                }
                sqlReader = IDALProvider.IDAL.ExecutePagingReader(table, paging, order, sSql, parameters, connection);
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
            DisplayObject_COM_DATA dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_COM_DATA();
                if (!sqlReader.IsDBNull(0))
                    dataObj.ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.NAME = sqlReader.GetString(1);             
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion 
            DisplayObject_COM_DATA[] objs = new DisplayObject_COM_DATA[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
    }
}
