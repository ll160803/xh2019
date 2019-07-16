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
using System.Collections.Generic;
using Ipedf.Core;
using Ipedf.Web.Control;
using Ipedf.Web.BizLogic;
using Newtonsoft.Json;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_D_BUDGET_YEAR_R_3 
    {
        protected override string PrepareResultOrderByColumn()
        {
            return "id";
        }
        protected override void OnDetailGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I entity = (EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;

                ComDropDownList ddlInputRESOLVE_METHOD_ID = (ComDropDownList)e.Row.FindControl("ddlInputRESOLVE_METHOD_ID");
                CopyComDropDownListItem(ddlDataSourceRESOLVE_METHOD_ID, ddlInputRESOLVE_METHOD_ID, entity.RESOLVE_METHOD_ID);
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
                if (entity.RESOLVE_METHOD_ID.Trim() == "00230001" || entity.RESOLVE_METHOD_ID.Trim() == "00230003")
                {
                    System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                    parameters.Add("linkopt", entity.ID);
                    string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_DEPT_YEAR_R_I_Edit.aspx", parameters);
                    e.Row.Cells[4].Text = string.Format("<a href=\"#\" onclick=\"{0}\">维护数据</a>", WebControlHelper.GetOpenWindowScript(url, 800, 600));
                }
            }
        }      
    }
}
