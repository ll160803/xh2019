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
using Newtonsoft.Json;
using System.Collections.Generic;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.Common;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_D_BUDGET_DEPT : ComListEditPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.tvTree.SelectedIndex = 0;
            base.Page_Load(sender, e);
            
            btnUpload.Enabled = ((ComControlBar)FindControl("command"))[Ipedf.Web.Control.ButtonType.Add].Enabled;
            btnScan.Enabled = ((ComControlBar)FindControl("command"))[Ipedf.Web.Control.ButtonType.Add].Enabled;
        }
        protected override void PrepareCause()
        {

        }
        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;

            //ƽ̨�Զ���ɴ��
            CauseObject_BGT_D_BUDGET_DEPT cause = (CauseObject_BGT_D_BUDGET_DEPT)parameter;
            cause.BUDGET_YEAR = Session["budget_year"].ToString();
            dataSource = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID" };
        }
        protected override void PrepareInput()
        {

            //�ƽ̨�Զ���ɴ��
            //�ƽ̨�Զ���ɴ��
            this.txtInputCODE.Text = string.Empty;
            this.txtInputNAME.Text = string.Empty;
            CauseObject_COM_TYPE cause815 = new CauseObject_COM_TYPE();
            cause815.PARENT_ID = "0004";
            SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputDEPT_PROPERTY_ID, typeof(BizLogicObject_COM_TYPE), "ID", "NAME", cause815);
            CauseObject_COM_TYPE cause524 = new CauseObject_COM_TYPE();
            cause524.PARENT_ID = "0003";
            SetForeignKeyBinding<CauseObject_COM_TYPE>(this.ddlInputDEPT_TYPE_ID, typeof(BizLogicObject_COM_TYPE), "ID", "NAME", cause524);
            SetEnumReferenceBinding(this.ddlInputIS_FUNCTION, Type.GetType("Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            this.ddlInputDEPT_ID.DataTable = "COM_DEPART";

            //是否职能科室,默认为否
            WebControlHelper.SetSelected(this.ddlInputIS_FUNCTION, (decimal)是否状态.否);
        }
        protected override string PrepareOrderByColumn()
        {
            return "Create_Time";
        }
        protected override void OnBeforeSave()
        {
            if (string.IsNullOrEmpty(txtInputCODE.Text))
                throw new Exception("科室编码不能为空");
            if (string.IsNullOrEmpty(txtInputNAME.Text))
                throw new Exception("科室名称不能为空");
            if (string.IsNullOrEmpty(ddlInputDEPT_ID.KeyValue))
                throw new Exception("对应部门不能为空");
        }
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {

                //ƽ̨�Զ���ɴ��
                EntityObject_BGT_D_BUDGET_DEPT curObj = new EntityObject_BGT_D_BUDGET_DEPT();
                //�ƽ̨�Զ���ɴ��
                curObj.BUDGET_YEAR = this.tvTree.SelectedValue;
                curObj.CODE = txtInputCODE.Text;
                curObj.NAME = txtInputNAME.Text;
                if (!string.IsNullOrEmpty(ddlInputDEPT_PROPERTY_ID.SelectedValue))
                    curObj.DEPT_PROPERTY_ID = ddlInputDEPT_PROPERTY_ID.SelectedValue;
                if (!string.IsNullOrEmpty(ddlInputDEPT_TYPE_ID.SelectedValue))
                    curObj.DEPT_TYPE_ID = ddlInputDEPT_TYPE_ID.SelectedValue;
                if (!string.IsNullOrEmpty(ddlInputIS_FUNCTION.SelectedValue))
                    curObj.IS_FUNCTION = decimal.Parse(ddlInputIS_FUNCTION.SelectedValue);
                if (!string.IsNullOrEmpty(ddlInputDEPT_ID.KeyValue))
                    curObj.DEPT_ID = ddlInputDEPT_ID.KeyValue;

                BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Save(curObj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
                ViewState["CUR_OBJ"] = curObj;
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            else
            {

                //�ƽ̨�Զ���ɴ��
                EntityObject_BGT_D_BUDGET_DEPT curObj = ViewState["CUR_OBJ"] as EntityObject_BGT_D_BUDGET_DEPT;
                //�ƽ̨�Զ���ɴ��
                curObj.CODE = txtInputCODE.Text;
                curObj.NAME = txtInputNAME.Text;
                if (!string.IsNullOrEmpty(ddlInputDEPT_PROPERTY_ID.SelectedValue))
                    curObj.DEPT_PROPERTY_ID = ddlInputDEPT_PROPERTY_ID.SelectedValue;
                if (!string.IsNullOrEmpty(ddlInputDEPT_TYPE_ID.SelectedValue))
                    curObj.DEPT_TYPE_ID = ddlInputDEPT_TYPE_ID.SelectedValue;
                if (!string.IsNullOrEmpty(ddlInputIS_FUNCTION.SelectedValue))
                    curObj.IS_FUNCTION = decimal.Parse(ddlInputIS_FUNCTION.SelectedValue);
                if (!string.IsNullOrEmpty(ddlInputDEPT_ID.KeyValue))
                    curObj.DEPT_ID = ddlInputDEPT_ID.KeyValue;
                BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Update(curObj);
                if (!msg.Succeed)
                    throw new Exception(msg.Message);
                ShowEditState(curObj);
                ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            SetPageState(PageState.GridViewEdit);
            int index = this.tvTree.SelectedIndex;
            BindTreeView();
            this.tvTree.SelectedIndex = index;
        }
        protected override void PrepareEdit(string id)
        {

            //�ƽ̨�Զ���ɴ��
            EntityObject_BGT_D_BUDGET_DEPT curObj = new EntityObject_BGT_D_BUDGET_DEPT();
            curObj.ID = id;
            curObj = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(curObj);
            this.txtInputCODE.Text = curObj.CODE == null ? string.Empty : curObj.CODE.ToString();
            this.txtInputNAME.Text = curObj.NAME == null ? string.Empty : curObj.NAME.ToString();
            CauseObject_COM_TYPE cause125 = new CauseObject_COM_TYPE();
            cause125.PARENT_ID = "0004";
            SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputDEPT_PROPERTY_ID, typeof(BizLogicObject_COM_TYPE), curObj.DEPT_PROPERTY_ID, "ID", "NAME", cause125);
            CauseObject_COM_TYPE cause224 = new CauseObject_COM_TYPE();
            cause224.PARENT_ID = "0003";
            SetForeignKeySelected<CauseObject_COM_TYPE>(this.ddlInputDEPT_TYPE_ID, typeof(BizLogicObject_COM_TYPE), curObj.DEPT_TYPE_ID, "ID", "NAME", cause224);
            SetEnumReferenceSelected(this.ddlInputIS_FUNCTION, Type.GetType("Ipedf.Common.是否状态, Ipedf.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"), curObj.IS_FUNCTION);
            this.ddlInputDEPT_ID.KeyField = "ID";
            this.ddlInputDEPT_ID.NameField = "NAME";
            this.ddlInputDEPT_ID.KeyValue = curObj.DEPT_ID;
            this.ddlInputDEPT_ID.NameValue = string.IsNullOrEmpty(curObj.DEPT_ID) ? string.Empty : BizLogicObject_COM_DEPART.Proxy.Get(new EntityObject_COM_DEPART() { ID = curObj.DEPT_ID }).NAME;
            this.ddlInputDEPT_ID.DataTable = "COM_DEPART";
            ShowEditState(curObj);
            ViewState["CUR_OBJ"] = curObj;
            SetPageState(PageState.GridViewEdit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        }
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_D_BUDGET_DEPT cause = new CauseObject_BGT_D_BUDGET_DEPT();

            return cause;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_DEPT>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_BUDGET_DEPT_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareTreeViewDataSource()
        {

            CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)是否状态.是;
            DisplayObject_BGT_D_BUDGET_YEAR[] results = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Query(p);
            return results;
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_BUDGET_DEPT> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_DEPT>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_BUDGET_DEPT entity = new EntityObject_BGT_D_BUDGET_DEPT();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.BatchDelete(deleteDetailEntities.ToArray());
            if (!msg.Succeed)
                ShowError(msg.Message);
            else
            {
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
                int index = this.tvTree.SelectedIndex;
                BindTreeView();
                this.tvTree.SelectedIndex = index;
                BindGridView();
            }


        }
        protected override void ShowQueryResult(object parameter)
        {
            if (this.tvTree.SelectedValue != null)
            {
                parameter.GetType().GetProperty("BUDGET_YEAR").SetValue(parameter, this.tvTree.SelectedValue, null);
            }
            base.ShowQueryResult(parameter);
        }

    }
}
