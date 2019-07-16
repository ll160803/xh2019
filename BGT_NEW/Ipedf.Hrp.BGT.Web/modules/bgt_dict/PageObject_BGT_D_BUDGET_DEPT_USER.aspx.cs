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
    public partial class PageObject_BGT_D_BUDGET_DEPT_USER :ComBatchResourceEditPage
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
           base.Page_Load(sender, e);
        }
        override protected void OnResourceAppend(object sender, EventArgs e)
        {
            System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
            parameters.Add("linkid", Request["linkid"]);//to do:enable this line for bind a base page
            string url = WebControlHelper.EncodeUrl("PageObject_BGT_D_BUDGET_DEPT_USER_Resource.aspx", parameters);
            base.OpenWindow(url, 800, 360);
        }
        override protected void DeserializeSourceObject(string key, string parameter)
        {
            string[] el = JsonConvert.DeserializeObject<string[]>(parameter);
            List<EntityObject_BGT_D_BUDGET_DEPT_USER> dl = new List<EntityObject_BGT_D_BUDGET_DEPT_USER>();            
            foreach (string entity in el)
            {
                EntityObject_BGT_D_BUDGET_DEPT_USER detailEntity = new EntityObject_BGT_D_BUDGET_DEPT_USER();
                detailEntity.BASE_ID = key;//to do:enable this line for bind a base page
                detailEntity.USER_ID = entity;
                dl.Add(detailEntity);
            }
            BizLogicObject_BGT_D_BUDGET_DEPT_USER.Proxy.BatchSave(dl.ToArray());
            Response.Redirect(string.Format("PageObject_BGT_D_BUDGET_DEPT_USER.aspx?linkid={0}", key));//to do:enable this line for bind a base page
        }
        protected override void PrepareCause()
        {
            
			CauseObject_COM_USER cause226 =  new CauseObject_COM_USER();
			cause226.SetCustomCondition(" and COM_USER.ID in( select BGT_D_BUDGET_DEPT_USER.USER_ID from BGT_D_BUDGET_DEPT_USER group by BGT_D_BUDGET_DEPT_USER.USER_ID )");
			SetForeignKeyBinding<CauseObject_COM_USER>(ddlDataSourceUSER_ID, typeof( BizLogicObject_COM_USER),"ID","NAME",cause226);
        }
        protected override object PrepareDataSource(object parameter)
        {
            object dataSource = null;              
            CauseObject_BGT_D_BUDGET_DEPT_USER cause = (CauseObject_BGT_D_BUDGET_DEPT_USER)parameter;
			dataSource = BizLogicObject_BGT_D_BUDGET_DEPT_USER.Proxy.Query(cause);   
			System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_DEPT_USER> list = new System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_DEPT_USER>();
			list.AddRange((DisplayObject_BGT_D_BUDGET_DEPT_USER[])dataSource);
			list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_D_BUDGET_DEPT_USER>(5));
			dataSource = list.ToArray();
            return dataSource;
        }
        protected override object PrepareEmptyDataSource()
        {            
            System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_DEPT_USER> list = new System.Collections.Generic.List<DisplayObject_BGT_D_BUDGET_DEPT_USER>();
            list.AddRange((DisplayObject_BGT_D_BUDGET_DEPT_USER[])PrepareDataSource(PrepareQueryParameter()));
            list.AddRange(CreateEmptyDataSource<DisplayObject_BGT_D_BUDGET_DEPT_USER>(NewInputRowCount));
            return list.ToArray();
        }  
           
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            List<EntityObject_BGT_D_BUDGET_DEPT_USER> saveDetailEntities = new List<EntityObject_BGT_D_BUDGET_DEPT_USER>();
            List<EntityObject_BGT_D_BUDGET_DEPT_USER> updateDetailEntities = new List<EntityObject_BGT_D_BUDGET_DEPT_USER>();
            List<EntityObject_BGT_D_BUDGET_DEPT_USER> deleteDetailEntities = new List<EntityObject_BGT_D_BUDGET_DEPT_USER>();
			foreach(GridViewRow row in gvList.Rows)
            {
                if(row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    
							//平台自动生成代码
                    EntityObject_BGT_D_BUDGET_DEPT_USER  entity = new EntityObject_BGT_D_BUDGET_DEPT_USER();
                    
								entity.ID=gvList.DataKeys[row.RowIndex].Value.ToString();
                                entity.BASE_ID = Request["linkid"];
                    if (select.Checked)
                    {
                        
									//平台自动生成代码    
                        //entity.BASE_ID = Request["linkid"];//to do:enable this line for bind a base page                                 
                        if (string.IsNullOrEmpty(entity.ID))
                        {
                            saveDetailEntities.Add(entity);
                        }
                        else
                        {
                            entity.SetNotUpdate("USER_ID");
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
            BizLogicMsg msg = BizLogicObject_BGT_D_BUDGET_DEPT_USER.Proxy.CommitUpdate(saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
            if (!msg.Succeed)
                throw new Exception(msg.Message);
            ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);
            PrepareCause();//强制刷新,避免ComBaseBox的特定限制范围数据源没有刷新,导致新增记录显示异常
			ShowData();
           
        }
        protected override void OnGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                DisplayObject_BGT_D_BUDGET_DEPT_USER entity = (DisplayObject_BGT_D_BUDGET_DEPT_USER)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }
        protected override object PrepareQueryParameter()
        {
            CauseObject_BGT_D_BUDGET_DEPT_USER cause = new CauseObject_BGT_D_BUDGET_DEPT_USER();
            cause.BASE_ID = Request["linkid"];//to do:enable this line for bind a base page
            return cause;
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_D_BUDGET_DEPT_USER_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_D_BUDGET_DEPT_USER>(parameter);
        }
    }
}

