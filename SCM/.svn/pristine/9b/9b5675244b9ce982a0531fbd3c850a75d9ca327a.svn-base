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
using Ipedf.Web.Entity;
using Ipedf.Common;
//using ExamSys.Common.system;
namespace Ipedf.Web.BizLogic
{   
    public partial class SystemLogic
    {
        public static string GetOrginaseId(string departId)
        {
            string orginaseId = departId;
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    CauseObject_COM_DEPART pDepart = new CauseObject_COM_DEPART();
                    pDepart.ID = departId;
                    DisplayObject_COM_DEPART[] departs = HelperObject_COM_DEPART.Query(pDepart, transaction);
                    while(departs.Length != 0)
                    {
                        DisplayObject_COM_DEPART dept = departs[0];
                        if (dept.TYPE == (decimal)组织类型.单位)
                        {
                            orginaseId = dept.ID;
                            break;
                        }
                        else
                        {
                            pDepart = new CauseObject_COM_DEPART();
                            pDepart.ID = dept.PARENT_ID;
                            departs = HelperObject_COM_DEPART.Query(pDepart, transaction);
                        }
                    }                    
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
            return orginaseId;
        }
    }
}
