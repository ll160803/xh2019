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
using Ipedf.Web.BizLogic;
using Ipedf.Core;
using log4net;
using System.Reflection;
using Ipedf.Web.Control;
using Ipedf.Web.Entity;
namespace Ipedf.Web
{
    public partial class login_ :BaseWebPage
    {
        protected void btnEntry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.ddlInputACCOUNT.SelectedValue))
            {
                WebControlHelper.WriteScript("alert('请选择科室');");
            }
            else if (this.txtPassword.Text.Trim().Length == 0)
            {
                WebControlHelper.WriteScript("alert('密码不能为空');");
            }
            else if (string.IsNullOrEmpty(this.ddlInputYEAR.SelectedValue))
            {
                WebControlHelper.WriteScript("alert('请选择预算年度');");
            }
            else
            {
                BizLogicMsg msg = SystemLogic.Proxy.Login(this, this.ddlInputACCOUNT.SelectedValue, this.txtPassword.Text);
                if (msg.Succeed)
                {
                    Session["budget_year"] = this.ddlInputYEAR.SelectedValue;
                    HttpCookie cookie = new HttpCookie("budget_year");
                    cookie.Value = this.ddlInputYEAR.SelectedItem.Text;
                    HttpContext.Current.Response.Cookies.Add(cookie); 
                    base.Response.Redirect("main2.html");
                }
                else
                {
                    WebControlHelper.WriteScript("alert('" + msg.Message + "');");
                    this.txtPassword.Text = string.Empty;
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!base.IsPostBack)
            {
                this.SetForeignKeySelected(this.ddlInputACCOUNT, typeof(BizLogicObject_COM_USER), "", "ACCOUNT", "ACCOUNT");
                SetForeignKeyBinding(this.ddlInputYEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR");
                string Year1 = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.GetCurrentBudgetYear(1);
                if (Year1 != null)
                {
                    this.ddlInputYEAR.SelectedValue = Year1;
                }
                else
                {
                    foreach (ListItem item in this.ddlInputYEAR.Items)
                    {
                        if (item.Text == "2018")
                        {
                            this.ddlInputYEAR.SelectedValue = item.Value;
                        }
                    }
                }
                this.Session.Contents.RemoveAll();
           
            }
        }     
    }
}
