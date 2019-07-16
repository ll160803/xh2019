using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ipedf.Web.Control;
using Ipedf.Web.BizLogic;
using Ipedf.Web.Entity;

namespace Ipedf.Web
{
    public partial class Down_Excel : BaseWebPage
    {
        public string ExcelName;
        protected void Page_Load(object sender, EventArgs e)
        {
            ExcelName = SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME;
        }
    }
}
