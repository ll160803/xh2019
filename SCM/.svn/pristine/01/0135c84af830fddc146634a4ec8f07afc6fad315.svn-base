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
using Ipedf.Web.DataAccess;
using System.Text;
using System.Collections.Specialized;
using System.Data.OracleClient;
using Ipedf.Web.Entity;
namespace Ipedf.Web.BizLogic
{
    public partial class SystemLogic
    {
        public string GetAccountByChineseName(string name)
        {
            string ret = ParseFirstWordLowerSpell(name);
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    CauseObject_COM_USER p = new CauseObject_COM_USER();
                    p.ACCOUNT = ret;
                    DisplayObject_COM_USER[] result = HelperObject_COM_USER.Query(p, transaction);
                    while (result.Length != 0)
                    {
                        ret = ret.PadRight(ret.Length + 1, '1');
                        p = new CauseObject_COM_USER();
                        p.ACCOUNT = ret;
                        result = HelperObject_COM_USER.Query(p, transaction);
                    }  
                    try
                    {                        
                                            
                        transaction.Commit();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        throw expt;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return ret;            
        }
        private string ParseFirstWordLowerSpell(string chinese)
        {
            return ParseFirstWordSpell(chinese).ToLower();
        }
        private string ParseFirstWordUpperSpell(string chinese)
        {
            return ParseFirstWordSpell(chinese).ToUpper();
        }
        private string ParseLowerSpell(string chinese)
        {
            return ParseSpell(chinese).ToLower();
        }
        private string ParseUpperSpell(string chinese)
        {
            return ParseSpell(chinese).ToUpper();
        }
        private string ParseSpell(string chinese)
        {
            StringBuilder ret = new StringBuilder();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    for (int i = 0; i < chinese.Length; i++)
                    {
                        CauseObject_COM_CHINESE_SPELL p = new CauseObject_COM_CHINESE_SPELL();
                        p.CHINESE = chinese[i].ToString();
                        DisplayObject_COM_CHINESE_SPELL[] result = HelperObject_COM_CHINESE_SPELL.Query(p, transaction);
                        if (result.Length != 0)
                        {
                            ret.Append(result[0].SPELL);
                        }
                    }
                    try
                    {
                        
                        transaction.Commit();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        throw expt;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return ret.ToString();
        }
        private string ParseFirstWordSpell(string chinese)
        {
            StringBuilder ret = new StringBuilder();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    for (int i = 0; i < chinese.Length; i++)
                    {
                        CauseObject_COM_CHINESE_SPELL p = new CauseObject_COM_CHINESE_SPELL();
                        p.CHINESE = chinese[i].ToString();
                        DisplayObject_COM_CHINESE_SPELL[] result = HelperObject_COM_CHINESE_SPELL.Query(p, transaction);
                        if (result.Length != 0)
                        {
                            ret.Append(result[0].SPELL[0].ToString());
                        }
                    }
                    try
                    {
                        
                        transaction.Commit();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        throw expt;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return ret.ToString();
        }
    }

}
