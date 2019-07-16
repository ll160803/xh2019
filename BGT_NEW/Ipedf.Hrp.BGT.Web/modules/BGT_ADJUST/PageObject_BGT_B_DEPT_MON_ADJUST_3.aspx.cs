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
using Ipedf.Common;
namespace Ipedf.Web
{
    public partial class PageObject_BGT_B_DEPT_MON_ADJUST_3 : ComNestingEditPage
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
        }
        protected override void PrepareCause()
        {
			
        }
        protected override void PrepareBaseInput()
        {
            
			//平台自动生成代码
			this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
			this.ddlInputADJUST_ID.DataTable = "BGT_B_BUDGET_ADJUST";
            this.ddlInputADJUST_ID.NameField = "ADJUST_CODE";

            this.ddlInputADJUST_ID.Enabled = false;
            this.ddlInputBUDGET_DEPT_ID.Enabled = false;
        }  
        protected override void OnSave(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (ViewState["CUR_OBJ"] == null)
            {
				List<EntityObject_BGT_B_DEPT_MON_ADJUST_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_MON_ADJUST_D>();
				EntityObject_BGT_B_DEPT_MON_ADJUST baseEntity = new EntityObject_BGT_B_DEPT_MON_ADJUST();
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputADJUST_ID.KeyValue))
										baseEntity.ADJUST_ID = ddlInputADJUST_ID.KeyValue;
                                    baseEntity.BUDGET_CONTENTS_ID = "00120003";//支出预算
						//AuditAdd(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComTextBox txtInputM_4_VALUE = (ComTextBox)row.FindControl("txtInputM_4_VALUE");
                            //ComTextBox txtInputM_5_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_5_BASE_VALUE");
                            //ComTextBox txtInputM_7_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_7_BASE_VALUE");
                            //ComTextBox txtInputM_2_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_2_BASE_VALUE");
							ComTextBox txtInputM_9_VALUE = (ComTextBox)row.FindControl("txtInputM_9_VALUE");
                            //ComTextBox txtInputM_3_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_3_BASE_VALUE");
                            //ComTextBox txtInputM_4_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_4_BASE_VALUE");
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							ComTextBox txtInputM_2_VALUE = (ComTextBox)row.FindControl("txtInputM_2_VALUE");
                            //ComTextBox txtInputM_10_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_10_BASE_VALUE");
                            //ComTextBox txtInputM_11_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_11_BASE_VALUE");
							ComTextBox txtInputM_3_VALUE = (ComTextBox)row.FindControl("txtInputM_3_VALUE");
							ComTextBox txtInputM_5_VALUE = (ComTextBox)row.FindControl("txtInputM_5_VALUE");
                            //ComTextBox txtInputM_9_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_9_BASE_VALUE");
                            //ComTextBox txtInputM_8_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_8_BASE_VALUE");
							ComTextBox txtInputM_7_VALUE = (ComTextBox)row.FindControl("txtInputM_7_VALUE");
                            //ComTextBox txtInputM_12_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_12_BASE_VALUE");
							ComTextBox txtInputM_11_VALUE = (ComTextBox)row.FindControl("txtInputM_11_VALUE");
                            //ComTextBox txtInputM_1_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_1_BASE_VALUE");
                            //ComTextBox txtInputM_6_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_6_BASE_VALUE");
							ComTextBox txtInputM_10_VALUE = (ComTextBox)row.FindControl("txtInputM_10_VALUE");
							ComTextBox txtInputM_12_VALUE = (ComTextBox)row.FindControl("txtInputM_12_VALUE");
							ComTextBox txtInputM_6_VALUE = (ComTextBox)row.FindControl("txtInputM_6_VALUE");
							ComTextBox txtInputM_1_VALUE = (ComTextBox)row.FindControl("txtInputM_1_VALUE");
							ComTextBox txtInputM_8_VALUE = (ComTextBox)row.FindControl("txtInputM_8_VALUE");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_MON_ADJUST_D detailEntity = new EntityObject_BGT_B_DEPT_MON_ADJUST_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					if(!string.IsNullOrEmpty(txtInputM_4_VALUE.Text))
					detailEntity.M_4_VALUE = decimal.Parse(txtInputM_4_VALUE.Text);
					else
					detailEntity.M_4_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_5_BASE_VALUE.Text))
                    //detailEntity.M_5_BASE_VALUE = decimal.Parse(txtInputM_5_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_5_BASE_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_7_BASE_VALUE.Text))
                    //detailEntity.M_7_BASE_VALUE = decimal.Parse(txtInputM_7_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_7_BASE_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_2_BASE_VALUE.Text))
                    //detailEntity.M_2_BASE_VALUE = decimal.Parse(txtInputM_2_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_2_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_9_VALUE.Text))
					detailEntity.M_9_VALUE = decimal.Parse(txtInputM_9_VALUE.Text);
					else
					detailEntity.M_9_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_3_BASE_VALUE.Text))
                    //detailEntity.M_3_BASE_VALUE = decimal.Parse(txtInputM_3_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_3_BASE_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_4_BASE_VALUE.Text))
                    //detailEntity.M_4_BASE_VALUE = decimal.Parse(txtInputM_4_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_4_BASE_VALUE = 0;
                                    //if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                    //    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputM_2_VALUE.Text))
					detailEntity.M_2_VALUE = decimal.Parse(txtInputM_2_VALUE.Text);
					else
					detailEntity.M_2_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_10_BASE_VALUE.Text))
                    //detailEntity.M_10_BASE_VALUE = decimal.Parse(txtInputM_10_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_10_BASE_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_11_BASE_VALUE.Text))
                    //detailEntity.M_11_BASE_VALUE = decimal.Parse(txtInputM_11_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_11_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_3_VALUE.Text))
					detailEntity.M_3_VALUE = decimal.Parse(txtInputM_3_VALUE.Text);
					else
					detailEntity.M_3_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_5_VALUE.Text))
					detailEntity.M_5_VALUE = decimal.Parse(txtInputM_5_VALUE.Text);
					else
					detailEntity.M_5_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_9_BASE_VALUE.Text))
                    //detailEntity.M_9_BASE_VALUE = decimal.Parse(txtInputM_9_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_9_BASE_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_8_BASE_VALUE.Text))
                    //detailEntity.M_8_BASE_VALUE = decimal.Parse(txtInputM_8_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_8_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_7_VALUE.Text))
					detailEntity.M_7_VALUE = decimal.Parse(txtInputM_7_VALUE.Text);
					else
					detailEntity.M_7_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_12_BASE_VALUE.Text))
                    //detailEntity.M_12_BASE_VALUE = decimal.Parse(txtInputM_12_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_12_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_11_VALUE.Text))
					detailEntity.M_11_VALUE = decimal.Parse(txtInputM_11_VALUE.Text);
					else
					detailEntity.M_11_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_1_BASE_VALUE.Text))
                    //detailEntity.M_1_BASE_VALUE = decimal.Parse(txtInputM_1_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_1_BASE_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_6_BASE_VALUE.Text))
                    //detailEntity.M_6_BASE_VALUE = decimal.Parse(txtInputM_6_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_6_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_10_VALUE.Text))
					detailEntity.M_10_VALUE = decimal.Parse(txtInputM_10_VALUE.Text);
					else
					detailEntity.M_10_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_12_VALUE.Text))
					detailEntity.M_12_VALUE = decimal.Parse(txtInputM_12_VALUE.Text);
					else
					detailEntity.M_12_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_6_VALUE.Text))
					detailEntity.M_6_VALUE = decimal.Parse(txtInputM_6_VALUE.Text);
					else
					detailEntity.M_6_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_1_VALUE.Text))
					detailEntity.M_1_VALUE = decimal.Parse(txtInputM_1_VALUE.Text);
					else
					detailEntity.M_1_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_8_VALUE.Text))
					detailEntity.M_8_VALUE = decimal.Parse(txtInputM_8_VALUE.Text);
					else
					detailEntity.M_8_VALUE = 0;
									//AuditAdd(detailEntity);
									saveDetailEntities.Add(detailEntity);
								}						
							}
						}
                        BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_MON_ADJUST.Proxy.CommitSave(baseEntity, saveDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);        
                        ViewState["CUR_OBJ"] = baseEntity;
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			else
			{
						List<EntityObject_BGT_B_DEPT_MON_ADJUST_D> saveDetailEntities = new List<EntityObject_BGT_B_DEPT_MON_ADJUST_D>();
						List<EntityObject_BGT_B_DEPT_MON_ADJUST_D> updateDetailEntities = new List<EntityObject_BGT_B_DEPT_MON_ADJUST_D>();
						List<EntityObject_BGT_B_DEPT_MON_ADJUST_D> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_MON_ADJUST_D>();
						EntityObject_BGT_B_DEPT_MON_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_MON_ADJUST;
						
									//平台自动生成代码
									if(!string.IsNullOrEmpty(ddlInputBUDGET_DEPT_ID.KeyValue))
										baseEntity.BUDGET_DEPT_ID = ddlInputBUDGET_DEPT_ID.KeyValue;
									if(!string.IsNullOrEmpty(ddlInputADJUST_ID.KeyValue))
										baseEntity.ADJUST_ID = ddlInputADJUST_ID.KeyValue;
						//AuditEdit(baseEntity);
						foreach (GridViewRow row in gvDetailList.Rows)
						{
							if (row.RowType == DataControlRowType.DataRow)
							{
								CheckBox select = (CheckBox)row.FindControl("cbSelect");
								
							ComTextBox txtInputM_4_VALUE = (ComTextBox)row.FindControl("txtInputM_4_VALUE");
                            //ComTextBox txtInputM_5_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_5_BASE_VALUE");
                            //ComTextBox txtInputM_7_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_7_BASE_VALUE");
                            //ComTextBox txtInputM_2_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_2_BASE_VALUE");
							ComTextBox txtInputM_9_VALUE = (ComTextBox)row.FindControl("txtInputM_9_VALUE");
                            //ComTextBox txtInputM_3_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_3_BASE_VALUE");
                            //ComTextBox txtInputM_4_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_4_BASE_VALUE");
                            //ComBaseBox ddlInputITEM_ID = (ComBaseBox)row.FindControl("ddlInputITEM_ID");
							ComTextBox txtInputM_2_VALUE = (ComTextBox)row.FindControl("txtInputM_2_VALUE");
                            //ComTextBox txtInputM_10_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_10_BASE_VALUE");
                            //ComTextBox txtInputM_11_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_11_BASE_VALUE");
							ComTextBox txtInputM_3_VALUE = (ComTextBox)row.FindControl("txtInputM_3_VALUE");
							ComTextBox txtInputM_5_VALUE = (ComTextBox)row.FindControl("txtInputM_5_VALUE");
                            //ComTextBox txtInputM_9_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_9_BASE_VALUE");
                            //ComTextBox txtInputM_8_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_8_BASE_VALUE");
							ComTextBox txtInputM_7_VALUE = (ComTextBox)row.FindControl("txtInputM_7_VALUE");
                            //ComTextBox txtInputM_12_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_12_BASE_VALUE");
							ComTextBox txtInputM_11_VALUE = (ComTextBox)row.FindControl("txtInputM_11_VALUE");
                            //ComTextBox txtInputM_1_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_1_BASE_VALUE");
                            //ComTextBox txtInputM_6_BASE_VALUE = (ComTextBox)row.FindControl("txtInputM_6_BASE_VALUE");
							ComTextBox txtInputM_10_VALUE = (ComTextBox)row.FindControl("txtInputM_10_VALUE");
							ComTextBox txtInputM_12_VALUE = (ComTextBox)row.FindControl("txtInputM_12_VALUE");
							ComTextBox txtInputM_6_VALUE = (ComTextBox)row.FindControl("txtInputM_6_VALUE");
							ComTextBox txtInputM_1_VALUE = (ComTextBox)row.FindControl("txtInputM_1_VALUE");
							ComTextBox txtInputM_8_VALUE = (ComTextBox)row.FindControl("txtInputM_8_VALUE");
							//平台自动生成代码
								EntityObject_BGT_B_DEPT_MON_ADJUST_D detailEntity = new EntityObject_BGT_B_DEPT_MON_ADJUST_D();
								
							detailEntity.BASE_ID = baseEntity.ID;								
								
								detailEntity.ID=gvDetailList.DataKeys[row.RowIndex].Value.ToString();
								if (select.Checked)
								{
									
									//平台自动生成代码
					if(!string.IsNullOrEmpty(txtInputM_4_VALUE.Text))
					detailEntity.M_4_VALUE = decimal.Parse(txtInputM_4_VALUE.Text);
					else
					detailEntity.M_4_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_5_BASE_VALUE.Text))
                    //detailEntity.M_5_BASE_VALUE = decimal.Parse(txtInputM_5_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_5_BASE_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_7_BASE_VALUE.Text))
                    //detailEntity.M_7_BASE_VALUE = decimal.Parse(txtInputM_7_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_7_BASE_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_2_BASE_VALUE.Text))
                    //detailEntity.M_2_BASE_VALUE = decimal.Parse(txtInputM_2_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_2_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_9_VALUE.Text))
					detailEntity.M_9_VALUE = decimal.Parse(txtInputM_9_VALUE.Text);
					else
					detailEntity.M_9_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_3_BASE_VALUE.Text))
                    //detailEntity.M_3_BASE_VALUE = decimal.Parse(txtInputM_3_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_3_BASE_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_4_BASE_VALUE.Text))
                    //detailEntity.M_4_BASE_VALUE = decimal.Parse(txtInputM_4_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_4_BASE_VALUE = 0;
                                    //if(!string.IsNullOrEmpty(ddlInputITEM_ID.KeyValue))
                                    //    detailEntity.ITEM_ID = ddlInputITEM_ID.KeyValue;
					if(!string.IsNullOrEmpty(txtInputM_2_VALUE.Text))
					detailEntity.M_2_VALUE = decimal.Parse(txtInputM_2_VALUE.Text);
					else
					detailEntity.M_2_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_10_BASE_VALUE.Text))
                    //detailEntity.M_10_BASE_VALUE = decimal.Parse(txtInputM_10_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_10_BASE_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_11_BASE_VALUE.Text))
                    //detailEntity.M_11_BASE_VALUE = decimal.Parse(txtInputM_11_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_11_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_3_VALUE.Text))
					detailEntity.M_3_VALUE = decimal.Parse(txtInputM_3_VALUE.Text);
					else
					detailEntity.M_3_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_5_VALUE.Text))
					detailEntity.M_5_VALUE = decimal.Parse(txtInputM_5_VALUE.Text);
					else
					detailEntity.M_5_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_9_BASE_VALUE.Text))
                    //detailEntity.M_9_BASE_VALUE = decimal.Parse(txtInputM_9_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_9_BASE_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_8_BASE_VALUE.Text))
                    //detailEntity.M_8_BASE_VALUE = decimal.Parse(txtInputM_8_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_8_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_7_VALUE.Text))
					detailEntity.M_7_VALUE = decimal.Parse(txtInputM_7_VALUE.Text);
					else
					detailEntity.M_7_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_12_BASE_VALUE.Text))
                    //detailEntity.M_12_BASE_VALUE = decimal.Parse(txtInputM_12_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_12_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_11_VALUE.Text))
					detailEntity.M_11_VALUE = decimal.Parse(txtInputM_11_VALUE.Text);
					else
					detailEntity.M_11_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_1_BASE_VALUE.Text))
                    //detailEntity.M_1_BASE_VALUE = decimal.Parse(txtInputM_1_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_1_BASE_VALUE = 0;
                    //if(!string.IsNullOrEmpty(txtInputM_6_BASE_VALUE.Text))
                    //detailEntity.M_6_BASE_VALUE = decimal.Parse(txtInputM_6_BASE_VALUE.Text);
                    //else
                    //detailEntity.M_6_BASE_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_10_VALUE.Text))
					detailEntity.M_10_VALUE = decimal.Parse(txtInputM_10_VALUE.Text);
					else
					detailEntity.M_10_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_12_VALUE.Text))
					detailEntity.M_12_VALUE = decimal.Parse(txtInputM_12_VALUE.Text);
					else
					detailEntity.M_12_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_6_VALUE.Text))
					detailEntity.M_6_VALUE = decimal.Parse(txtInputM_6_VALUE.Text);
					else
					detailEntity.M_6_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_1_VALUE.Text))
					detailEntity.M_1_VALUE = decimal.Parse(txtInputM_1_VALUE.Text);
					else
					detailEntity.M_1_VALUE = 0;
					if(!string.IsNullOrEmpty(txtInputM_8_VALUE.Text))
					detailEntity.M_8_VALUE = decimal.Parse(txtInputM_8_VALUE.Text);
					else
					detailEntity.M_8_VALUE = 0;
                    detailEntity.SetNotUpdate("ITEM_ID", "M_1_BASE_VALUE", "M_2_BASE_VALUE", "M_3_BASE_VALUE", "M_4_BASE_VALUE", "M_5_BASE_VALUE", "M_6_BASE_VALUE", "M_7_BASE_VALUE", "M_8_BASE_VALUE", "M_9_BASE_VALUE", "M_10_BASE_VALUE", "M_11_BASE_VALUE", "M_12_BASE_VALUE");
									if (detailEntity.ID == string.Empty)
									{
										//AuditAdd(detailEntity);
										saveDetailEntities.Add(detailEntity);
									}
									else
									{
										//AuditEdit(detailEntity);
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

                        BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_MON_ADJUST.Proxy.CommitUpdate(baseEntity, saveDetailEntities.ToArray(), updateDetailEntities.ToArray(), deleteDetailEntities.ToArray());
                        if (!msg.Succeed)
                            throw new Exception(msg.Message);        
                ShowEditState(baseEntity);
                        ShowState(Ipedf.Web.Common.Message.PageSaveSucceedMsg);

			}
			ShowDetailData();
            SetPageState(PageState.Edit);
        }  
        protected override void OnDetailGridRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                EntityObject_BGT_B_DEPT_MON_ADJUST_D entity = (EntityObject_BGT_B_DEPT_MON_ADJUST_D)e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                select.Checked = entity.ID != string.Empty;
                
				ComTextBox txtInputM_4_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_4_VALUE");
				txtInputM_4_VALUE.Text = entity.M_4_VALUE == null ? "0": entity.M_4_VALUE.ToString();
                //ComTextBox txtInputM_5_BASE_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_5_BASE_VALUE");
                //txtInputM_5_BASE_VALUE.Text = entity.M_5_BASE_VALUE == null ? "0": entity.M_5_BASE_VALUE.ToString();
                //ComTextBox txtInputM_7_BASE_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_7_BASE_VALUE");
                //txtInputM_7_BASE_VALUE.Text = entity.M_7_BASE_VALUE == null ? "0": entity.M_7_BASE_VALUE.ToString();
                //ComTextBox txtInputM_2_BASE_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_2_BASE_VALUE");
                //txtInputM_2_BASE_VALUE.Text = entity.M_2_BASE_VALUE == null ? "0": entity.M_2_BASE_VALUE.ToString();
				ComTextBox txtInputM_9_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_9_VALUE");
				txtInputM_9_VALUE.Text = entity.M_9_VALUE == null ? "0": entity.M_9_VALUE.ToString();
                //ComTextBox txtInputM_3_BASE_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_3_BASE_VALUE");
                //txtInputM_3_BASE_VALUE.Text = entity.M_3_BASE_VALUE == null ? "0": entity.M_3_BASE_VALUE.ToString();
                //ComTextBox txtInputM_4_BASE_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_4_BASE_VALUE");
                //txtInputM_4_BASE_VALUE.Text = entity.M_4_BASE_VALUE == null ? "0": entity.M_4_BASE_VALUE.ToString();
                //ComBaseBox ddlInputITEM_ID= (ComBaseBox)e.Row.FindControl("ddlInputITEM_ID");
                //CopyComDropDownListItem(ddlDataSourceITEM_ID,ref ddlInputITEM_ID, entity.ITEM_ID,"BGT_D_PLAN_ITEM","ID","NAME");
				ComTextBox txtInputM_2_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_2_VALUE");
				txtInputM_2_VALUE.Text = entity.M_2_VALUE == null ? "0": entity.M_2_VALUE.ToString();
                //ComTextBox txtInputM_10_BASE_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_10_BASE_VALUE");
                //txtInputM_10_BASE_VALUE.Text = entity.M_10_BASE_VALUE == null ? "0": entity.M_10_BASE_VALUE.ToString();
                //ComTextBox txtInputM_11_BASE_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_11_BASE_VALUE");
                //txtInputM_11_BASE_VALUE.Text = entity.M_11_BASE_VALUE == null ? "0": entity.M_11_BASE_VALUE.ToString();
                ComTextBox txtInputM_3_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_3_VALUE");
				txtInputM_3_VALUE.Text = entity.M_3_VALUE == null ? "0": entity.M_3_VALUE.ToString();
				ComTextBox txtInputM_5_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_5_VALUE");
				txtInputM_5_VALUE.Text = entity.M_5_VALUE == null ? "0": entity.M_5_VALUE.ToString();
                //ComTextBox txtInputM_9_BASE_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_9_BASE_VALUE");
                //txtInputM_9_BASE_VALUE.Text = entity.M_9_BASE_VALUE == null ? "0": entity.M_9_BASE_VALUE.ToString();
                //ComTextBox txtInputM_8_BASE_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_8_BASE_VALUE");
                //txtInputM_8_BASE_VALUE.Text = entity.M_8_BASE_VALUE == null ? "0": entity.M_8_BASE_VALUE.ToString();
				ComTextBox txtInputM_7_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_7_VALUE");
				txtInputM_7_VALUE.Text = entity.M_7_VALUE == null ? "0": entity.M_7_VALUE.ToString();
                //ComTextBox txtInputM_12_BASE_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_12_BASE_VALUE");
                //txtInputM_12_BASE_VALUE.Text = entity.M_12_BASE_VALUE == null ? "0": entity.M_12_BASE_VALUE.ToString();
				ComTextBox txtInputM_11_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_11_VALUE");
				txtInputM_11_VALUE.Text = entity.M_11_VALUE == null ? "0": entity.M_11_VALUE.ToString();
                //ComTextBox txtInputM_1_BASE_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_1_BASE_VALUE");
                //txtInputM_1_BASE_VALUE.Text = entity.M_1_BASE_VALUE == null ? "0": entity.M_1_BASE_VALUE.ToString();
                //ComTextBox txtInputM_6_BASE_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_6_BASE_VALUE");
                //txtInputM_6_BASE_VALUE.Text = entity.M_6_BASE_VALUE == null ? "0": entity.M_6_BASE_VALUE.ToString();
				ComTextBox txtInputM_10_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_10_VALUE");
				txtInputM_10_VALUE.Text = entity.M_10_VALUE == null ? "0": entity.M_10_VALUE.ToString();
				ComTextBox txtInputM_12_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_12_VALUE");
				txtInputM_12_VALUE.Text = entity.M_12_VALUE == null ? "0": entity.M_12_VALUE.ToString();
				ComTextBox txtInputM_6_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_6_VALUE");
				txtInputM_6_VALUE.Text = entity.M_6_VALUE == null ? "0": entity.M_6_VALUE.ToString();
				ComTextBox txtInputM_1_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_1_VALUE");
				txtInputM_1_VALUE.Text = entity.M_1_VALUE == null ? "0": entity.M_1_VALUE.ToString();
				ComTextBox txtInputM_8_VALUE = (ComTextBox)e.Row.FindControl("txtInputM_8_VALUE");
				txtInputM_8_VALUE.Text = entity.M_8_VALUE == null ? "0": entity.M_8_VALUE.ToString();
                //todo:call "RegisterSelectedScript(yourFireEventControl, select);" to processing select
            }
        }      
        protected override object PrepareQueryParameter()
        {
			CauseObject_BGT_B_DEPT_MON_ADJUST cause = new CauseObject_BGT_B_DEPT_MON_ADJUST();
            cause.BUDGET_CONTENTS_ID = "00120003";//支出预算
            cause.IS_FUNCTION = (decimal)是否状态.否;//业务科室
            cause.SetCustomCondition(" and BGT_B_BUDGET_ADJUST_ADJUST_ID.id in(select id from BGT_B_BUDGET_ADJUST t where BUDGET_YEAR in (select id from Bgt_d_Budget_Year where IS_AVAILABE =1))");
			return cause;
        }   
        protected override object DeserializeQueryObject(string parameter)
        {
            return JsonConvert.DeserializeObject<CauseObject_BGT_B_DEPT_MON_ADJUST>(parameter);
        }
        protected override string PrepareOpenQueryParameterPageScript()
        {
            string scripts = WebControlHelper.GetOpenWindowScript("PageObject_BGT_B_DEPT_MON_ADJUST_3_PARAM.aspx", 500, 500);
            return scripts;
        }
        protected override object PrepareResultDataSource(object parameter, PagingParamter paging, OrderByParameter orderBy)
        {
            object dataSource = null;
            
			//平台自动生成代码
			CauseObject_BGT_B_DEPT_MON_ADJUST cause = (CauseObject_BGT_B_DEPT_MON_ADJUST)parameter;
			dataSource = BizLogicObject_BGT_B_DEPT_MON_ADJUST.Proxy.Query(cause, paging, orderBy);
            return dataSource;
        }        
        protected override void PrepareBaseEdit(string id)
        {
			
				//平台自动生成代码
				EntityObject_BGT_B_DEPT_MON_ADJUST baseEntity = new EntityObject_BGT_B_DEPT_MON_ADJUST();
				baseEntity.ID=id;
				baseEntity =  BizLogicObject_BGT_B_DEPT_MON_ADJUST.Proxy.Get(baseEntity);
				this.ddlInputBUDGET_DEPT_ID.KeyField = "ID";
				this.ddlInputBUDGET_DEPT_ID.NameField = "NAME";
				this.ddlInputBUDGET_DEPT_ID.KeyValue = baseEntity.BUDGET_DEPT_ID;
				this.ddlInputBUDGET_DEPT_ID.NameValue = string.IsNullOrEmpty(baseEntity.BUDGET_DEPT_ID)?string.Empty: BizLogicObject_BGT_D_BUDGET_DEPT.Proxy.Get(new EntityObject_BGT_D_BUDGET_DEPT(){ID = baseEntity.BUDGET_DEPT_ID}).NAME;
				this.ddlInputBUDGET_DEPT_ID.DataTable = "BGT_D_BUDGET_DEPT";
				this.ddlInputADJUST_ID.KeyField = "ID";
				this.ddlInputADJUST_ID.NameField = "ADJUST_CODE";
				this.ddlInputADJUST_ID.KeyValue = baseEntity.ADJUST_ID;
				this.ddlInputADJUST_ID.NameValue = string.IsNullOrEmpty(baseEntity.ADJUST_ID)?string.Empty: BizLogicObject_BGT_B_BUDGET_ADJUST.Proxy.Get(new EntityObject_BGT_B_BUDGET_ADJUST(){ID = baseEntity.ADJUST_ID}).ADJUST_CODE;
				this.ddlInputADJUST_ID.DataTable = "BGT_B_BUDGET_ADJUST";
				ShowEditState(baseEntity);
				ViewState["CUR_OBJ"] = baseEntity; 
			CauseObject_BGT_D_PLAN_ITEM cause378 =  new CauseObject_BGT_D_PLAN_ITEM();
			cause378.SetCustomCondition(" and BGT_D_PLAN_ITEM.ID in( select BGT_B_DEPT_MON_ADJUST_D.ITEM_ID from BGT_B_DEPT_MON_ADJUST_D where BGT_B_DEPT_MON_ADJUST_D.BASE_ID = '" + baseEntity.ID + "' group by BGT_B_DEPT_MON_ADJUST_D.ITEM_ID )");
			SetForeignKeyBinding<CauseObject_BGT_D_PLAN_ITEM>(ddlDataSourceITEM_ID, typeof( BizLogicObject_BGT_D_PLAN_ITEM),"ID","NAME",cause378);
            ShowDetailData();
            SetPageState(PageState.Edit);
            ShowState(Ipedf.Web.Common.Message.PageWelcomeMsg);
        } 
              
        protected override void OnSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_MON_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_MON_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_MON_ADJUST.Proxy.Submit(baseEntity);
            }
        }
        protected override void OnUndoSubmit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_MON_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_MON_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_MON_ADJUST.Proxy.UndoSubmit(baseEntity);
            }
        }
        protected override void OnUndoAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_MON_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_MON_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_MON_ADJUST.Proxy.UndoAudit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnAudit(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_MON_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_MON_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_MON_ADJUST.Proxy.Audit(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnCancel(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_MON_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_MON_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");
				BizLogicObject_BGT_B_DEPT_MON_ADJUST.Proxy.Cancel(baseEntity);
            }
        }
       
        protected override void OnArchive(object sender, EventArgs e)
        {
            EntityObject_BGT_B_DEPT_MON_ADJUST baseEntity = ViewState["CUR_OBJ"] as EntityObject_BGT_B_DEPT_MON_ADJUST;
            if (baseEntity != null)
            {
				baseEntity.SetUpdate("STATE");            
				BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_MON_ADJUST.Proxy.Archive(baseEntity);
				if (!msg.Succeed)
					throw new Exception(msg.Message);
            }
        }
        protected override void OnDelete(object sender, EventArgs e)
        {
            List<EntityObject_BGT_B_DEPT_MON_ADJUST> deleteDetailEntities = new List<EntityObject_BGT_B_DEPT_MON_ADJUST>();
            foreach (GridViewRow row in gvResultList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox select = (CheckBox)row.FindControl("cbSelect");
                    EntityObject_BGT_B_DEPT_MON_ADJUST entity = new EntityObject_BGT_B_DEPT_MON_ADJUST();
                    entity.ID = gvResultList.DataKeys[row.RowIndex].Value.ToString();
                    if (select.Enabled)
                    {
                        if (select.Checked)
                        {
                            deleteDetailEntities.Add(entity);
                        }
                    }
                }
            }
            BizLogicMsg msg = BizLogicObject_BGT_B_DEPT_MON_ADJUST.Proxy.BatchDelete(deleteDetailEntities.ToArray());
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

