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
    public partial class PageObject_BGT_D_BUDGET_YEAR_B2A : ComListBatchEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {            
            base.Page_Load(sender, e);
            this.command[Ipedf.Web.Control.ButtonType.Custom].Text = "生成";
            this.command[Ipedf.Web.Control.ButtonType.Custom].Visible = true;
        }
        protected override void PrepareCause()
        {
            CauseObject_BGT_D_BUDGET_ITEM cause441 = new CauseObject_BGT_D_BUDGET_ITEM();
            cause441.SetCustomCondition(" and BGT_D_BUDGET_ITEM.ID in( select BGT_D_BUDGET_ACCOUNT.BUDGET_ITEM_ID from BGT_D_BUDGET_ACCOUNT group by BGT_D_BUDGET_ACCOUNT.BUDGET_ITEM_ID )");
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_ITEM>(ddlDataSourceBUDGET_ITEM_ID, typeof(BizLogicObject_BGT_D_BUDGET_ITEM), "ID", "NAME", cause441);
            CauseObject_BGT_D_ACCOUNT_ITEM cause552 = new CauseObject_BGT_D_ACCOUNT_ITEM();
            cause552.SetCustomCondition(" and BGT_D_ACCOUNT_ITEM.ID in( select BGT_D_BUDGET_ACCOUNT.ACCOUNT_ITEM_ID from BGT_D_BUDGET_ACCOUNT group by BGT_D_BUDGET_ACCOUNT.ACCOUNT_ITEM_ID )");
            SetForeignKeyBinding<CauseObject_BGT_D_ACCOUNT_ITEM>(ddlDataSourceACCOUNT_ITEM_ID, typeof(BizLogicObject_BGT_D_ACCOUNT_ITEM), "ID", "NAME", cause552);
            CauseObject_BGT_D_BUDGET_YEAR cause171 = new CauseObject_BGT_D_BUDGET_YEAR();
            cause171.SetCustomCondition(" and BGT_D_BUDGET_YEAR.ID in( select BGT_D_BUDGET_ACCOUNT.BUDGET_YEAR from BGT_D_BUDGET_ACCOUNT group by BGT_D_BUDGET_ACCOUNT.BUDGET_YEAR )");
            SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_YEAR>(ddlDataSourceBUDGET_YEAR, typeof(BizLogicObject_BGT_D_BUDGET_YEAR), "ID", "BUDGET_YEAR", cause171);
        }
        protected override object PrepareDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_D_BUDGET_ACCOUNT cause = (CauseObject_BGT_D_BUDGET_ACCOUNT)parameter;
			dataSource = BizLogicObject_BGT_D_BUDGET_ACCOUNT.Proxy.Query(cause,paging,orderBy);
			System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_ACCOUNT> list = new System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_ACCOUNT>();
			list.AddRange((DisplayObject_BGT_D_BUDGET_ACCOUNT[])dataSource);
            list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_D_BUDGET_ACCOUNT>(paging.PageSize - list.Count));
			dataSource = list.ToArray();
            return dataSource;
        }
        protected override string[] PrepareGridKeyNames()
        {
            return new string[] { "ID"};
        }
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            List<EntityObject_BGT_D_BUDGET_ACCOUNT> saveDetailEntities = new List<EntityObject_BGT_D_BUDGET_ACCOUNT>();
			List<EntityObject_BGT_D_BUDGET_ACCOUNT> updateDetailEntities = new List<EntityObject_BGT_D_BUDGET_ACCOUNT>();
			List<EntityObject_BGT_D_BUDGET_ACCOUNT> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_ACCOUNT>();
			foreach (GridViewRow row in gvList.Rows)
			{
				if (row.RowType == DataControlRowType.DataRow)
				{
					CheckBox select = (CheckBox)row.FindControl("cbSelect");
					
							ComBaseBox ddlInputBUDGET_ITEM_ID = (ComBaseBox)row.FindControl("ddlInputBUDGET_ITEM_ID");
							ComBaseBox ddlInputACCOUNT_ITEM_ID = (ComBaseBox)row.FindControl("ddlInputACCOUNT_ITEM_ID");
                            //ComBaseBox ddlInputBUDGET_YEAR = (ComBaseBox)row.FindControl("ddlInputBUDGET_YEAR");
							//平台自动生成代码
					EntityObject_BGT_D_BUDGET_ACCOUNT detailEntity = new EntityObject_BGT_D_BUDGET_ACCOUNT();
					
							detailEntity.BUDGET_YEAR = this.tvTree.SelectedValue;								
					
								detailEntity.ID=gvList.DataKeys[row.RowIndex].Value.ToString();
					if (select.Checked)
					{
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_ITEM_ID.KeyValue))
										detailEntity.BUDGET_ITEM_ID = ddlInputBUDGET_ITEM_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputACCOUNT_ITEM_ID.KeyValue))
										detailEntity.ACCOUNT_ITEM_ID = ddlInputACCOUNT_ITEM_ID.KeyValue;
                                    //if(!string.IsNullOrEmpty(ddlInputBUDGET_YEAR.KeyValue))
                                    //    detailEntity.BUDGET_YEAR = ddlInputBUDGET_YEAR.KeyValue;
                                    detailEntity.BUDGET_YEAR = this.tvTree.SelectedValue;
						if (detailEntity.ID == string.Empty)
						{
							saveDetailEntities.Add(detailEntity);
						}
						else
						{
							updateDetailEntities.Add(detailEntity);
						}
					}
					else
					{
						if (IsDeleteAble)
						{
							deleteDetailEntities.Add(detailEntity);
						}
					}								
				}
			}
            BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_ACCOUNT.Proxy.CommitUpdate(saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
            if (!msg.Succeed)
                throw new Exception(msg.Message);
            ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
			int index = this.tvTree.SelectedIndex;
            BindTreeView();
            this.tvTree.SelectedIndex = index;
            BindGridView();
            SetPageState(PageState.Edit);
        }                                                            
        
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_D_BUDGET_ACCOUNT cause = new CauseObject_BGT_D_BUDGET_ACCOUNT();
			
			return cause;
        }      
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_ACCOUNT>(parameter);
        }  
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_BUDGET_YEAR_B2A_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareTreeViewDataSource()
        {
            
			CauseObject_BGT_D_BUDGET_YEAR p = new CauseObject_BGT_D_BUDGET_YEAR();
            p.IS_AVAILABE = (decimal)是否状态.是;
			DisplayObject_BGT_D_BUDGET_YEAR[] results = BizLogicObject_BGT_D_BUDGET_YEAR.Proxy.Query(p);
			return results;
        }      
        protected override void OnGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
			if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_BGT_D_BUDGET_ACCOUNT entity = (EntityObject_BGT_D_BUDGET_ACCOUNT)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
				ComBaseBox ddlInputBUDGET_ITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputBUDGET_ITEM_ID");
				CopyComDropDownListItem(ddlDataSourceBUDGET_ITEM_ID,ref ddlInputBUDGET_ITEM_ID, entity.BUDGET_ITEM_ID,"BGT_D_BUDGET_ITEM","ID","NAME");
				ComBaseBox ddlInputACCOUNT_ITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputACCOUNT_ITEM_ID");
				CopyComDropDownListItem(ddlDataSourceACCOUNT_ITEM_ID,ref ddlInputACCOUNT_ITEM_ID, entity.ACCOUNT_ITEM_ID,"BGT_D_ACCOUNT_ITEM","ID","NAME");
                //ComBaseBox ddlInputBUDGET_YEAR= (ComBaseBox)e.Row.FindControl("ddlInputBUDGET_YEAR");
				//CopyComDropDownListItem(ddlDataSourceBUDGET_YEAR,ref ddlInputBUDGET_YEAR, entity.BUDGET_YEAR,"BGT_D_BUDGET_YEAR","ID","BUDGET_YEAR");
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }
        protected override void PrepareGridViewControlDataSource()
        {
			
			CauseObject_BGT_D_BUDGET_ITEM cause345 =  new CauseObject_BGT_D_BUDGET_ITEM();
			cause345.SetCustomCondition(" and BGT_D_BUDGET_ITEM.ID in( select BGT_D_BUDGET_ACCOUNT.BUDGET_ITEM_ID from BGT_D_BUDGET_ACCOUNT where BGT_D_BUDGET_ACCOUNT.BUDGET_YEAR = '" + this.tvTree.SelectedValue + "' group by BGT_D_BUDGET_ACCOUNT.BUDGET_ITEM_ID )");
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_ITEM>(ddlDataSourceBUDGET_ITEM_ID, typeof( BizLogicObject_BGT_D_BUDGET_ITEM),"ID","NAME",cause345);
			CauseObject_BGT_D_ACCOUNT_ITEM cause853 =  new CauseObject_BGT_D_ACCOUNT_ITEM();
			cause853.SetCustomCondition(" and BGT_D_ACCOUNT_ITEM.ID in( select BGT_D_BUDGET_ACCOUNT.ACCOUNT_ITEM_ID from BGT_D_BUDGET_ACCOUNT where BGT_D_BUDGET_ACCOUNT.BUDGET_YEAR = '" + this.tvTree.SelectedValue + "' group by BGT_D_BUDGET_ACCOUNT.ACCOUNT_ITEM_ID )");
			SetForeignKeyBinding<CauseObject_BGT_D_ACCOUNT_ITEM>(ddlDataSourceACCOUNT_ITEM_ID, typeof( BizLogicObject_BGT_D_ACCOUNT_ITEM),"ID","NAME",cause853);
        }
         protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_D_BUDGET_ACCOUNT> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_ACCOUNT>();
            foreach (GridViewRow row in gvList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_D_BUDGET_ACCOUNT entity = new EntityObject_BGT_D_BUDGET_ACCOUNT();
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
            BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_ACCOUNT.Proxy.BatchDelete(deleteDetailEntities.ToArray());
            if (!msg.Succeed)
                ShowError(msg.Message);
            else
            {
                ShowState(Ipedf.Web.Common.Message.PageDeleteSucceedMsg);
                ShowData();
            }  
            
        }
    }
}

