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
namespace Ipedf.Web
{
	public partial class PageObject_BGT_B_CPN_INC_PROJECT_D : ComSimplePage
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            base.Page_Load(sender, e);
		}
		protected override void PrepareCause()
		{
			
		}
        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_CPN_INC_PROJECT_D cause = (CauseObject_BGT_B_CPN_INC_PROJECT_D)parameter;
			dataSource = BizLogicObject_BGT_B_CPN_INC_PROJECT_D.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareInput()
        {
            
			//平台自动生成代码
			this.txtInputFINANCE_IDEA.Text = string.Empty;
			this.txtInputCONTROL_MONEY.Text = "0.00";
			this.txtInputMONEY.Text = "0.00";
			this.txtInputBASE_ID.Text = string.Empty;
			this.txtInputITEM_NAME.Text = string.Empty;
			this.txtInputDECALRE_CAUSE.Text = string.Empty;
        }
        protected override string PrepareOrderByColumn()
        {
            return "Id";
        }
        protected override void OnSave(object sender, EventArgs e)
        {
			if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
                
				//平台自动生成代码
				EntityObject_BGT_B_CPN_INC_PROJECT_D curObj = new EntityObject_BGT_B_CPN_INC_PROJECT_D();
									//平台自动生成代码
					curObj.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
					if(!string.IsNullOrEmpty(txtInputCONTROL_MONEY.Text))
					curObj.CONTROL_MONEY = decimal.Parse(txtInputCONTROL_MONEY.Text);
					else
					curObj.CONTROL_MONEY = 0;
					if(!string.IsNullOrEmpty(txtInputMONEY.Text))
					curObj.MONEY = decimal.Parse(txtInputMONEY.Text);
					else
					curObj.MONEY = 0;
					curObj.BASE_ID = txtInputBASE_ID.Text;
					curObj.ITEM_NAME = txtInputITEM_NAME.Text;
					curObj.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
				BizLogicObject_BGT_B_CPN_INC_PROJECT_D.Proxy.Save(curObj);
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {
                
				//平台自动生成代码
				EntityObject_BGT_B_CPN_INC_PROJECT_D curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT_D;
									//平台自动生成代码
					curObj.FINANCE_IDEA = txtInputFINANCE_IDEA.Text;
					if(!string.IsNullOrEmpty(txtInputCONTROL_MONEY.Text))
					curObj.CONTROL_MONEY = decimal.Parse(txtInputCONTROL_MONEY.Text);
					else
					curObj.CONTROL_MONEY = 0;
					if(!string.IsNullOrEmpty(txtInputMONEY.Text))
					curObj.MONEY = decimal.Parse(txtInputMONEY.Text);
					else
					curObj.MONEY = 0;
					curObj.BASE_ID = txtInputBASE_ID.Text;
					curObj.ITEM_NAME = txtInputITEM_NAME.Text;
					curObj.DECALRE_CAUSE = txtInputDECALRE_CAUSE.Text;
				BizLogicObject_BGT_B_CPN_INC_PROJECT_D.Proxy.Update(curObj);
				ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            ShowData();
            SetPageState(PageState.Edit);
        }        
        protected override void PrepareEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_CPN_INC_PROJECT_D curObj = new EntityObject_BGT_B_CPN_INC_PROJECT_D();
				curObj.ID=id;
				curObj =  BizLogicObject_BGT_B_CPN_INC_PROJECT_D.Proxy.Get(curObj);
				this.txtInputFINANCE_IDEA.Text = curObj.FINANCE_IDEA == null ? string.Empty:curObj.FINANCE_IDEA.ToString();
				this.txtInputCONTROL_MONEY.Text = curObj.CONTROL_MONEY == null ? string.Empty:curObj.CONTROL_MONEY.ToString();
				this.txtInputMONEY.Text = curObj.MONEY == null ? string.Empty:curObj.MONEY.ToString();
				this.txtInputBASE_ID.Text = curObj.BASE_ID == null ? string.Empty:curObj.BASE_ID.ToString();
				this.txtInputITEM_NAME.Text = curObj.ITEM_NAME == null ? string.Empty:curObj.ITEM_NAME.ToString();
				this.txtInputDECALRE_CAUSE.Text = curObj.DECALRE_CAUSE == null ? string.Empty:curObj.DECALRE_CAUSE.ToString();
				ShowEditState(curObj);
				ViewState["CUR_OBJ"] = curObj; 
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
        protected override  object PrepareQueryParameter()
        {
			CauseObject_BGT_B_CPN_INC_PROJECT_D cause = new CauseObject_BGT_B_CPN_INC_PROJECT_D();
			
			return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_CPN_INC_PROJECT_D>(parameter);
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_PROJECT_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT_D.Proxy.Audit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            
            EntityObject_BGT_B_CPN_INC_PROJECT_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT_D.Proxy.UndoAudit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
            
        }
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_PROJECT_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT_D.Proxy.Submit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_PROJECT_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT_D.Proxy.UndoSubmit(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_CPN_INC_PROJECT_D obj = ViewState["CUR_OBJ"] as EntityObject_BGT_B_CPN_INC_PROJECT_D;
            if (obj != null)
            {
				obj.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_CPN_INC_PROJECT_D.Proxy.Archive(obj);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_CPN_INC_PROJECT_D_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_CPN_INC_PROJECT_D> deleteDetailEntities = new List<EntityObject_BGT_B_CPN_INC_PROJECT_D>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_CPN_INC_PROJECT_D entity = new EntityObject_BGT_B_CPN_INC_PROJECT_D();
                    entity.ID = gvList.DataKeys[row.RowIndex].Value.ToString();
                    if (select.Enabled)
                    {
                        if (select.Checked)
                        {
                            deleteDetailEntities.Add(entity);
                        }
                    }
                }
            }
            try
            {
                BizLogicObject_BGT_B_CPN_INC_PROJECT_D.Proxy.BatchDelete(deleteDetailEntities.ToArray());
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
            }
            catch (Exception expt)
            {
                throw expt;
            }
            ShowData();
        }
	}
}

