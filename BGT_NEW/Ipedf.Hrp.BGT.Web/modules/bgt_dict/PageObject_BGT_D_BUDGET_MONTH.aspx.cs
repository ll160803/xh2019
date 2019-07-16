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
    public partial class PageObject_BGT_D_BUDGET_MONTH :ComBatchEditPage
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
           base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
            
        }
        protected override object PrepareDataSource(object parameter)
        {
            object dataSource = null;              
            CauseObject_BGT_D_BUDGET_MONTH cause = (CauseObject_BGT_D_BUDGET_MONTH)parameter;
			dataSource = BizLogicObject_BGT_D_BUDGET_MONTH.Proxy.Query(cause);   
			DisplayObject_BGT_D_BUDGET_MONTH[] list = (DisplayObject_BGT_D_BUDGET_MONTH[])dataSource;
            return list.Length == 0 ? CreateEmptyDataSource<DisplayObject_BGT_D_BUDGET_MONTH>(NewInputRowCount):list;  
        }
        protected override object PrepareEmptyDataSource()
        {            
            System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_MONTH> list = new System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_MONTH>();
            list.AddRange((DisplayObject_BGT_D_BUDGET_MONTH[])PrepareDataSource(PrepareQueryParameter()));
            list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_D_BUDGET_MONTH>(NewInputRowCount));
            return list.ToArray();
        }  
           
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            List<EntityObject_BGT_D_BUDGET_MONTH> saveDetailEntities = new List<EntityObject_BGT_D_BUDGET_MONTH>();
            List<EntityObject_BGT_D_BUDGET_MONTH> updateDetailEntities = new List<EntityObject_BGT_D_BUDGET_MONTH>();
            List<EntityObject_BGT_D_BUDGET_MONTH> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_MONTH>();
			foreach(GridViewRow row in gvList.Rows)
            {
                if(row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    
							ComTextBox txtInputBUDGET_MONTH = (ComTextBox)row.FindControl("txtInputBUDGET_MONTH");
							//平台自动生成代码
                    EntityObject_BGT_D_BUDGET_MONTH  entity = new EntityObject_BGT_D_BUDGET_MONTH();
                    
								entity.ID=gvList.DataKeys[row.RowIndex].Value.ToString();
                    if (select.Checked)
                    {
                        
									//平台自动生成代码
					entity.BUDGET_MONTH = txtInputBUDGET_MONTH.Text;                                    
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
            BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_MONTH.Proxy.CommitUpdate(saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());

            if (!msg.Succeed)
                throw new Exception(msg.Message);
            ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            PrepareCause();//ǿ��ˢ��,����ComBaseBox���ض����Ʒ�Χ����Դû��ˢ��,����������¼��ʾ�쳣
			ShowData();
           
        }
        protected override void OnGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                DisplayObject_BGT_D_BUDGET_MONTH entity = (DisplayObject_BGT_D_BUDGET_MONTH)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
				ComTextBox txtInputBUDGET_MONTH = (ComTextBox)e.Row.FindControl("txtInputBUDGET_MONTH");
				txtInputBUDGET_MONTH.Text = entity.BUDGET_MONTH == null ? String.Empty: entity.BUDGET_MONTH.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_D_BUDGET_MONTH cause = new CauseObject_BGT_D_BUDGET_MONTH();
            return cause;
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_BUDGET_MONTH_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_MONTH>(parameter);
        }
    }
}

