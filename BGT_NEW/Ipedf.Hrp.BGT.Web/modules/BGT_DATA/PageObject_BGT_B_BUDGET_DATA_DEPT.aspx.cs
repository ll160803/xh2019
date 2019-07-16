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
using System.Collections.Generic;
using Newtonsoft.Json;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_BUDGET_DATA_DEPT :ComBatchEditPage
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
           base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
            
			CauseObject_BGT_D_BUDGET_DEPT cause474 =  new CauseObject_BGT_D_BUDGET_DEPT();
			cause474.SetCustomCondition(" and BGT_D_BUDGET_DEPT.ID in( select BGT_B_BUDGET_DATA_DEPT.BUDGET_DEPT_ID from BGT_B_BUDGET_DATA_DEPT group by BGT_B_BUDGET_DATA_DEPT.BUDGET_DEPT_ID )");
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_DEPT>(ddlDataSourceBUDGET_DEPT_ID, typeof( BizLogicObject_BGT_D_BUDGET_DEPT),"ID","NAME",cause474);
        }
        protected override object PrepareDataSource(object parameter)
        {
            object dataSource = null;              
            CauseObject_BGT_B_BUDGET_DATA_DEPT cause = (CauseObject_BGT_B_BUDGET_DATA_DEPT)parameter;
			dataSource = BizLogicObject_BGT_B_BUDGET_DATA_DEPT.Proxy.Query(cause);   
			System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_DATA_DEPT> list = new System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_DATA_DEPT>();
			list.AddRange((DisplayObject_BGT_B_BUDGET_DATA_DEPT[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_BUDGET_DATA_DEPT>(5));
			dataSource = list.ToArray();
            return dataSource;
        }
        protected override object PrepareEmptyDataSource()
        {            
            System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_DATA_DEPT> list = new System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_DATA_DEPT>();
            list.AddRange((DisplayObject_BGT_B_BUDGET_DATA_DEPT[])PrepareDataSource(PrepareQueryParameter()));
            list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_BUDGET_DATA_DEPT>(NewInputRowCount));
            return list.ToArray();
        }  
           
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            List<EntityObject_BGT_B_BUDGET_DATA_DEPT> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_DATA_DEPT>();
            List<EntityObject_BGT_B_BUDGET_DATA_DEPT> updateDetailEntities = new List<EntityObject_BGT_B_BUDGET_DATA_DEPT>();
            List<EntityObject_BGT_B_BUDGET_DATA_DEPT> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_DATA_DEPT>();
			foreach(GridViewRow row in gvList.Rows)
            {
                if(row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    
							ComBaseBox ddlInputBUDGET_DEPT_ID = (ComBaseBox)row.FindControl("ddlInputBUDGET_DEPT_ID");
							ComTextBox txtInputCREATE_DATE = (ComTextBox)row.FindControl("txtInputCREATE_DATE");
							//平台自动生成代码
                    EntityObject_BGT_B_BUDGET_DATA_DEPT  entity = new EntityObject_BGT_B_BUDGET_DATA_DEPT();
                    
								entity.ID=gvList.DataKeys[row.RowIndex].Value.ToString();
                    if (select.Checked)
                    {
                        
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										entity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputCREATE_DATE.Text))
					entity.CREATE_DATE = DateTime.Parse(txtInputCREATE_DATE.Text);
					else
					entity.CREATE_DATE = Ipedf.Common.Template.UndefineDatetime;                                    
                        if (string.IsNullOrEmpty(entity.ID))
                        {
                            saveDetailEntities.Add(entity);
                        }
                        else
                        {
                            updateDetailEntities.Add(entity);
                        }
                    }
                    else
                    {
                        if (IsDeleteAble)
                        {
							deleteDetailEntities.Add(entity);
                        }
                    }
                                          
                }                        
            }
            try
            {
                
                BizLogicObject_BGT_B_BUDGET_DATA_DEPT.Proxy.CommitUpdate(saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            catch(Exception expt)
            {
                
                throw expt;
            }
            PrepareCause();//??????,????ComBaseBox??????????Χ???????????,????????????????
			ShowData();
           
        }
        protected override void OnGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                DisplayObject_BGT_B_BUDGET_DATA_DEPT entity = (DisplayObject_BGT_B_BUDGET_DATA_DEPT)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
				ComBaseBox ddlInputBUDGET_DEPT_ID= (ComBaseBox)e.Row.FindControl("ddlInputBUDGET_DEPT_ID");
				CopyComDropDownListItem(ddlDataSourceBUDGET_DEPT_ID,ref ddlInputBUDGET_DEPT_ID, entity.BUDGET_DEPT_ID,"BGT_D_BUDGET_DEPT","ID","NAME");
				ComTextBox txtInputCREATE_DATE = (ComTextBox)e.Row.FindControl("txtInputCREATE_DATE");
				txtInputCREATE_DATE.Text = entity.CREATE_DATE == null ? String.Empty: entity.CREATE_DATE.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_B_BUDGET_DATA_DEPT cause = new CauseObject_BGT_B_BUDGET_DATA_DEPT();
            return cause;
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_BUDGET_DATA_DEPT_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_BUDGET_DATA_DEPT>(parameter);
        }
    }
}

