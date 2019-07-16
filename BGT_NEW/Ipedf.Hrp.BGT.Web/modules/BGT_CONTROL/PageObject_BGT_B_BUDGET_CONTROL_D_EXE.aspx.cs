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
    public partial class PageObject_BGT_B_BUDGET_CONTROL_D_EXE :ComBatchEditPage
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
           base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
            
			CauseObject_BGT_D_BUDGET_DEPT cause555 =  new CauseObject_BGT_D_BUDGET_DEPT();
			cause555.SetCustomCondition(" and BGT_D_BUDGET_DEPT.ID in( select BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID from BGT_B_BUDGET_CONTROL_D_EXE group by BGT_B_BUDGET_CONTROL_D_EXE.BUDGET_DEPT_ID )");
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_DEPT>(ddlDataSourceBUDGET_DEPT_ID, typeof( BizLogicObject_BGT_D_BUDGET_DEPT),"ID","NAME",cause555);
			CauseObject_BGT_D_BUDGET_ITEM cause113 =  new CauseObject_BGT_D_BUDGET_ITEM();
			cause113.SetCustomCondition(" and BGT_D_BUDGET_ITEM.ID in( select BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID from BGT_B_BUDGET_CONTROL_D_EXE group by BGT_B_BUDGET_CONTROL_D_EXE.ITEM_ID )");
			SetForeignKeyBinding<CauseObject_BGT_D_BUDGET_ITEM>(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_D_BUDGET_ITEM),"ID","NAME",cause113);
        }
        protected override object PrepareDataSource(object parameter)
        {
            object dataSource = null;              
            CauseObject_BGT_B_BUDGET_CONTROL_D_EXE cause = (CauseObject_BGT_B_BUDGET_CONTROL_D_EXE)parameter;
			dataSource = BizLogicObject_BGT_B_BUDGET_CONTROL_D_EXE.Proxy.Query(cause);   
			System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE> list = new System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE>();
			list.AddRange((DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE>(5));
			dataSource = list.ToArray();
            return dataSource;
        }
        protected override object PrepareEmptyDataSource()
        {            
            System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE> list = new System.Collections.Generic.List<DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE>();
            list.AddRange((DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE[])PrepareDataSource(PrepareQueryParameter()));
            list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE>(NewInputRowCount));
            return list.ToArray();
        }  
           
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            List<EntityObject_BGT_B_BUDGET_CONTROL_D_EXE> saveDetailEntities = new List<EntityObject_BGT_B_BUDGET_CONTROL_D_EXE>();
            List<EntityObject_BGT_B_BUDGET_CONTROL_D_EXE> updateDetailEntities = new List<EntityObject_BGT_B_BUDGET_CONTROL_D_EXE>();
            List<EntityObject_BGT_B_BUDGET_CONTROL_D_EXE> deleteDetailEntities = new List<EntityObject_BGT_B_BUDGET_CONTROL_D_EXE>();
			foreach(GridViewRow row in gvList.Rows)
            {
                if(row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    
							ComTextBox txtInputCREATE_DATE = (ComTextBox)row.FindControl("txtInputCREATE_DATE");
							ComTextBox txtInputMONEY = (ComTextBox)row.FindControl("txtInputMONEY");
							ComBaseBox ddlInputBUDGET_DEPT_ID = (ComBaseBox)row.FindControl("ddlInputBUDGET_DEPT_ID");
							ComFinanceCycle txtInputFINANCE_CYCLE = (ComFinanceCycle)row.FindControl("txtInputFINANCE_CYCLE");
							ComTextBox txtInputAPPLY_MONEY = (ComTextBox)row.FindControl("txtInputAPPLY_MONEY");
							ComTextBox txtInputAVAILABLE_MONEY = (ComTextBox)row.FindControl("txtInputAVAILABLE_MONEY");
							ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							//平台自动生成代码
                    EntityObject_BGT_B_BUDGET_CONTROL_D_EXE  entity = new EntityObject_BGT_B_BUDGET_CONTROL_D_EXE();
                    
								entity.ID=gvList.DataKeys[row.RowIndex].Value.ToString();
                    if (select.Checked)
                    {
                        
									//平台自动生成代码
					if(!string.IsNullOrEmpty(txtInputCREATE_DATE.Text))
					entity.CREATE_DATE = DateTime.Parse(txtInputCREATE_DATE.Text);
					else
					entity.CREATE_DATE = Ipedf.Common.Template.UndefineDatetime;
					if(!string.IsNullOrEmpty(txtInputMONEY.Text))
					entity.MONEY = decimal.Parse(txtInputMONEY.Text);
					else
					entity.MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										entity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
					entity.FINANCE_CYCLE = txtInputFINANCE_CYCLE.Text;
					if(!string.IsNullOrEmpty(txtInputAPPLY_MONEY.Text))
					entity.APPLY_MONEY = decimal.Parse(txtInputAPPLY_MONEY.Text);
					else
					entity.APPLY_MONEY = 0;
					if(!string.IsNullOrEmpty(txtInputAVAILABLE_MONEY.Text))
					entity.AVAILABLE_MONEY = decimal.Parse(txtInputAVAILABLE_MONEY.Text);
					else
					entity.AVAILABLE_MONEY = 0;
									if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
										entity.ITEM_ID = ddlInputITEM_ID.KeyValue;                                    
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
                
                BizLogicObject_BGT_B_BUDGET_CONTROL_D_EXE.Proxy.CommitUpdate(saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            }
            catch(Exception expt)
            {
                
                throw expt;
            }
            PrepareCause();//ǿ��ˢ��,����ComBaseBox���ض����Ʒ�Χ����Դû��ˢ��,����������¼��ʾ�쳣
			ShowData();
           
        }
        protected override void OnGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE entity = (DisplayObject_BGT_B_BUDGET_CONTROL_D_EXE)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
				ComTextBox txtInputCREATE_DATE = (ComTextBox)e.Row.FindControl("txtInputCREATE_DATE");
				txtInputCREATE_DATE.Text = entity.CREATE_DATE == null ? String.Empty: entity.CREATE_DATE.ToString();
				ComTextBox txtInputMONEY = (ComTextBox)e.Row.FindControl("txtInputMONEY");
				txtInputMONEY.Text = entity.MONEY == null ? "0": entity.MONEY.ToString();
				ComBaseBox ddlInputBUDGET_DEPT_ID= (ComBaseBox)e.Row.FindControl("ddlInputBUDGET_DEPT_ID");
				CopyComDropDownListItem(ddlDataSourceBUDGET_DEPT_ID,ref ddlInputBUDGET_DEPT_ID, entity.BUDGET_DEPT_ID,"BGT_D_BUDGET_DEPT","ID","NAME");
				ComFinanceCycle txtInputFINANCE_CYCLE = (ComFinanceCycle)e.Row.FindControl("txtInputFINANCE_CYCLE");
				txtInputFINANCE_CYCLE.Text = entity.FINANCE_CYCLE == null ? String.Empty: entity.FINANCE_CYCLE.ToString();
				ComTextBox txtInputAPPLY_MONEY = (ComTextBox)e.Row.FindControl("txtInputAPPLY_MONEY");
				txtInputAPPLY_MONEY.Text = entity.APPLY_MONEY == null ? "0": entity.APPLY_MONEY.ToString();
				ComTextBox txtInputAVAILABLE_MONEY = (ComTextBox)e.Row.FindControl("txtInputAVAILABLE_MONEY");
				txtInputAVAILABLE_MONEY.Text = entity.AVAILABLE_MONEY == null ? "0": entity.AVAILABLE_MONEY.ToString();
				ComBaseBox ddlInputITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputITEM_ID");
				CopyComDropDownListItem(ddlDataSourceITEM_ID,ref ddlInputITEM_ID, entity.ITEM_ID,"BGT_D_BUDGET_ITEM","ID","NAME");
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_B_BUDGET_CONTROL_D_EXE cause = new CauseObject_BGT_B_BUDGET_CONTROL_D_EXE();
            return cause;
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_BUDGET_CONTROL_D_EXE_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_BUDGET_CONTROL_D_EXE>(parameter);
        }
    }
}

