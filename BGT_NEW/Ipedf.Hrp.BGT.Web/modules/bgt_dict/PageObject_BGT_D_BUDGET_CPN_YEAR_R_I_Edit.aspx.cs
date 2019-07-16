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
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web
{
	public partial class PageObject_BGT_D_BUDGET_CPN_YEAR_R_I_Edit : ComSimpleEditPage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
            btnSave.Attributes.Add("onclick", "return checktotal();");
            txtInputM_1_VALUE.Attributes.Add("onblur", "caltotal();");
            txtInputM_2_VALUE.Attributes.Add("onblur", "caltotal();");
            txtInputM_3_VALUE.Attributes.Add("onblur", "caltotal();");
            txtInputM_4_VALUE.Attributes.Add("onblur", "caltotal();");
            txtInputM_5_VALUE.Attributes.Add("onblur", "caltotal();");
            txtInputM_6_VALUE.Attributes.Add("onblur", "caltotal();");
            txtInputM_7_VALUE.Attributes.Add("onblur", "caltotal();");
            txtInputM_8_VALUE.Attributes.Add("onblur", "caltotal();");
            txtInputM_9_VALUE.Attributes.Add("onblur", "caltotal();");
            txtInputM_10_VALUE.Attributes.Add("onblur", "caltotal();");
            txtInputM_11_VALUE.Attributes.Add("onblur", "caltotal();");
            txtInputM_12_VALUE.Attributes.Add("onblur", "caltotal();");
		}	
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			this.txtInputM_4_VALUE.Text = "0.00";
			this.txtInputM_11_VALUE.Text = "0.00";
			this.txtInputM_9_VALUE.Text = "0.00";
			this.txtInputM_10_VALUE.Text = "0.00";
			this.txtInputM_2_VALUE.Text = "0.00";
			this.txtInputM_3_VALUE.Text = "0.00";
			this.txtInputM_5_VALUE.Text = "0.00";
			this.txtInputM_12_VALUE.Text = "0.00";
			this.txtInputM_6_VALUE.Text = "0.00";
			this.txtInputM_1_VALUE.Text = "0.00";
			this.txtInputM_8_VALUE.Text = "0.00";
			this.txtInputM_7_VALUE.Text = "0.00";
        }       
        protected override void OnSave(object sender, EventArgs e)
        {
			if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
                
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I curObj = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I();
									//平台自动生成代码
					if(!string.IsNullOrEmpty(txtInputM_4_VALUE.Text))
					curObj.M_4_VALUE = decimal.Parse(txtInputM_4_VALUE.Text);
					else
					curObj.M_4_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_11_VALUE.Text))
					curObj.M_11_VALUE = decimal.Parse(txtInputM_11_VALUE.Text);
					else
					curObj.M_11_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_9_VALUE.Text))
					curObj.M_9_VALUE = decimal.Parse(txtInputM_9_VALUE.Text);
					else
					curObj.M_9_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_10_VALUE.Text))
					curObj.M_10_VALUE = decimal.Parse(txtInputM_10_VALUE.Text);
					else
					curObj.M_10_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_2_VALUE.Text))
					curObj.M_2_VALUE = decimal.Parse(txtInputM_2_VALUE.Text);
					else
					curObj.M_2_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_3_VALUE.Text))
					curObj.M_3_VALUE = decimal.Parse(txtInputM_3_VALUE.Text);
					else
					curObj.M_3_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_5_VALUE.Text))
					curObj.M_5_VALUE = decimal.Parse(txtInputM_5_VALUE.Text);
					else
					curObj.M_5_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_12_VALUE.Text))
					curObj.M_12_VALUE = decimal.Parse(txtInputM_12_VALUE.Text);
					else
					curObj.M_12_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_6_VALUE.Text))
					curObj.M_6_VALUE = decimal.Parse(txtInputM_6_VALUE.Text);
					else
					curObj.M_6_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_1_VALUE.Text))
					curObj.M_1_VALUE = decimal.Parse(txtInputM_1_VALUE.Text);
					else
					curObj.M_1_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_8_VALUE.Text))
					curObj.M_8_VALUE = decimal.Parse(txtInputM_8_VALUE.Text);
					else
					curObj.M_8_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_7_VALUE.Text))
					curObj.M_7_VALUE = decimal.Parse(txtInputM_7_VALUE.Text);
					else
					curObj.M_7_VALUE = 0;
				BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.Save(curObj);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
									//平台自动生成代码
					if(!string.IsNullOrEmpty(txtInputM_4_VALUE.Text))
					curObj.M_4_VALUE = decimal.Parse(txtInputM_4_VALUE.Text);
					else
					curObj.M_4_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_11_VALUE.Text))
					curObj.M_11_VALUE = decimal.Parse(txtInputM_11_VALUE.Text);
					else
					curObj.M_11_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_9_VALUE.Text))
					curObj.M_9_VALUE = decimal.Parse(txtInputM_9_VALUE.Text);
					else
					curObj.M_9_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_10_VALUE.Text))
					curObj.M_10_VALUE = decimal.Parse(txtInputM_10_VALUE.Text);
					else
					curObj.M_10_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_2_VALUE.Text))
					curObj.M_2_VALUE = decimal.Parse(txtInputM_2_VALUE.Text);
					else
					curObj.M_2_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_3_VALUE.Text))
					curObj.M_3_VALUE = decimal.Parse(txtInputM_3_VALUE.Text);
					else
					curObj.M_3_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_5_VALUE.Text))
					curObj.M_5_VALUE = decimal.Parse(txtInputM_5_VALUE.Text);
					else
					curObj.M_5_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_12_VALUE.Text))
					curObj.M_12_VALUE = decimal.Parse(txtInputM_12_VALUE.Text);
					else
					curObj.M_12_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_6_VALUE.Text))
					curObj.M_6_VALUE = decimal.Parse(txtInputM_6_VALUE.Text);
					else
					curObj.M_6_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_1_VALUE.Text))
					curObj.M_1_VALUE = decimal.Parse(txtInputM_1_VALUE.Text);
					else
					curObj.M_1_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_8_VALUE.Text))
					curObj.M_8_VALUE = decimal.Parse(txtInputM_8_VALUE.Text);
					else
					curObj.M_8_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_7_VALUE.Text))
					curObj.M_7_VALUE = decimal.Parse(txtInputM_7_VALUE.Text);
					else
					curObj.M_7_VALUE = 0;
				BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.Update(curObj);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }       
        protected override void PrepareEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I curObj = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.Get(curObj);
				if (curObj != null)
				{
				    this.txtInputM_4_VALUE.Text = curObj.M_4_VALUE == null ? string.Empty:curObj.M_4_VALUE.ToString();
				    this.txtInputM_11_VALUE.Text = curObj.M_11_VALUE == null ? string.Empty:curObj.M_11_VALUE.ToString();
				    this.txtInputM_9_VALUE.Text = curObj.M_9_VALUE == null ? string.Empty:curObj.M_9_VALUE.ToString();
				    this.txtInputM_10_VALUE.Text = curObj.M_10_VALUE == null ? string.Empty:curObj.M_10_VALUE.ToString();
				    this.txtInputM_2_VALUE.Text = curObj.M_2_VALUE == null ? string.Empty:curObj.M_2_VALUE.ToString();
				    this.txtInputM_3_VALUE.Text = curObj.M_3_VALUE == null ? string.Empty:curObj.M_3_VALUE.ToString();
				    this.txtInputM_5_VALUE.Text = curObj.M_5_VALUE == null ? string.Empty:curObj.M_5_VALUE.ToString();
				    this.txtInputM_12_VALUE.Text = curObj.M_12_VALUE == null ? string.Empty:curObj.M_12_VALUE.ToString();
				    this.txtInputM_6_VALUE.Text = curObj.M_6_VALUE == null ? string.Empty:curObj.M_6_VALUE.ToString();
				    this.txtInputM_1_VALUE.Text = curObj.M_1_VALUE == null ? string.Empty:curObj.M_1_VALUE.ToString();
				    this.txtInputM_8_VALUE.Text = curObj.M_8_VALUE == null ? string.Empty:curObj.M_8_VALUE.ToString();
				    this.txtInputM_7_VALUE.Text = curObj.M_7_VALUE == null ? string.Empty:curObj.M_7_VALUE.ToString();
                    ViewState["CUR_OBJ"] = curObj;
                    ShowEditState(curObj);
				}
				else
				{
					ShowEditState(new EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I());
				}
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }        
         protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I obj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_CPN_YEAR_R_I.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        
	}
}

