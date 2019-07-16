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
using Ipedf.Web.Control;
using Ipedf.Core;
using Ipedf.Common;
using Newtonsoft.Json;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using System.Collections.Generic;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_D_BUDGET_YEAR_B2A
    {
        protected override string PrepareDataTextField()
        {
            return "BUDGET_YEAR";
        }
        protected override string PrepareOrderByColumn()
        {
            return "BUDGET_ITEM_ID_NAME";
        }
        protected override void OnCustom(object sender, EventArgs e)
        {
            string yearId = this.tvTree.SelectedValue;
            if (!string.IsNullOrEmpty(yearId))
            {
                BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.CreateBudetAccount(yearId);
                if (msg.Succeed)
                {
                    SetPageState(PageState.Query);
                    ShowData();
                }
            }
            else
            {
                WebControlHelper.ShowAlert(this, "请选择预算年度.");
            }
        }
    }
}
