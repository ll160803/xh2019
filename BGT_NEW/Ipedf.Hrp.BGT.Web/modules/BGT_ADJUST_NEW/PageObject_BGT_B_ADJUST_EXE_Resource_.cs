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
    public partial class PageObject_BGT_B_ADJUST_EXE_Resource 
    {
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_B_DEPT_FUND_EXE cause = new CauseObject_BGT_B_DEPT_FUND_EXE();
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);
            if (!string.IsNullOrEmpty(parameters["linkid"]))//当前预算科室 主表选中年 的数据 进行变更
            {
                var obj = BizLogicObject_BGT_B_ADJUST_EXE.Proxy.Query(new CauseObject_BGT_B_ADJUST_EXE { ID = parameters["linkid"] }).FirstOrDefault();
                cause.BUDGET_YEAR = obj.BUDGET_YEAR;
                cause.BUDGET_DEPT_ID = obj.BUDGET_DEPT_ID;
                cause.SetCustomCondition(" and BGT_B_DEPT_FUND_EXE.ID not in (select REF_TAB_ID from BGT_B_ADJUST_EXE_D where BASE_ID='" + parameters["linkid"] + "') ");
            }
            if (!string.IsNullOrEmpty(txtQueryKey.Text))
            {
                cause.NAME = string.Format("%{0}%", this.txtQueryKey.Text);
            }

            return cause;
        }
    }
}
