using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Reflection;
using Ipedf.Web.Control;
using Ipedf.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using System.Linq;

namespace Ipedf.Web
{
    public partial class PageObject_BGT_D_MACHINE1 
    {
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_D_MACHINE cause = new CauseObject_BGT_D_MACHINE();
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
            if (!string.IsNullOrEmpty(parameters["linkid"]))
            {
                cause.BASEID = parameters["linkid"];
            }
            return cause;
        }
    }
}
