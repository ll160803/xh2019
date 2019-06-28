using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Xml;
using System.IO;
using Ipedf.Core;
using System.Data.SqlClient;
using Ipedf.Web.DataAccess;
using System.Security.Cryptography;
using System.Collections;
using Ipedf.Web.Entity;
using System.Data.OracleClient;
namespace Ipedf.Web.BizLogic
{
    public partial class SystemLogic
    {
        public int NewInputRowCount
        {
            get
            {
                string p = GetParameterValue("BATCHEDITSIZE");
                return p == string.Empty ? 5 : int.Parse(p);
            }
        }
        public bool IsQueryWhenLoad
        {
            get
            {
                string p = GetParameterValue("ISQUERYWHENLOAD");
                return p == string.Empty ? true : p == "否" || p.ToLower() == "false" ? false : true;
            }
        }
        //public IDatabaseProduct CurrentDatabaseProduct
        //{
        //    get
        //    {
        //        string p = GetParameterValue("DATABASEPRODUCT");
        //        string[] type = p.Split(',');
        //        IDatabaseProduct product = Activator.CreateInstance(type[1], type[0]).Unwrap() as IDatabaseProduct;
        //        return product;
        //    }
        //}
        public string EnterpriseName
        {
            get
            {
                string p = GetParameterValue("ENTERPRISENAME");
                return p;
            }
        }
        public string EnterpriseAddress
        {
            get
            {
                string p = GetParameterValue("ENTERPRISEADDRESS");
                return p;
            }
        }
        private string GetParameterValue(string key)
        {
            if (System.Web.HttpContext.Current != null)
            {
                if (System.Web.HttpContext.Current.Application[key] != null)
                {
                    return (string)System.Web.HttpContext.Current.Application[key];
                }
            }
            string value = string.Empty;
            //解除关系数据库产品依赖
            IDbDataParameter[] prameters = null;
            if (IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.Oracle)
            {
                prameters = new OracleParameter[0];
            }
            else if (IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer)
            {
                prameters = new SqlParameter[0];
            }
            else
            {
                prameters = new System.Data.OleDb.OleDbParameter[0];
            }
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDataReader reader = IDALProvider.IDAL.ExecuteReader(string.Format("select PARAMETER_VALUE from COM_PARAMETER where PARAMETER_KEY='{0}'", key), prameters, connection);
                    while (reader.Read())
                    {
                        value = reader.GetString(0);
                    }
                    reader.Close();
                }
                catch (Exception expt) { }
                finally
                {
                    IDALProvider.IDAL.PushConnection(connection);
                }
            }
            if (System.Web.HttpContext.Current != null)
            {
                System.Web.HttpContext.Current.Application[key] = value;
            }
            return value;
        }
    }
}