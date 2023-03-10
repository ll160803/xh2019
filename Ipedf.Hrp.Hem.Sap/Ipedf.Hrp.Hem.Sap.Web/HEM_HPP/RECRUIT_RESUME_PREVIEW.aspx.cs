using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Ipedf.Web.Control;
using Ipedf.Core;
using Ipedf.Hrp.Hem.Sap.BizLogic;
using Ipedf.Hrp.Hem.Sap.Entity;

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public partial class RECRUIT_RESUME_PREVIEW : Manage_Page
    {
        private bool IsMaster = false;
        private string POSTER_ID= "2";
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(this.Request);

            if (parameters.Count != 0)
            {
                string staff_type_id = parameters["ID"].ToString();
                string APPLY_ID = "";
                if (parameters["APPLY_ID"] != null)
                {
                    APPLY_ID = parameters["APPLY_ID"].ToString();
                }
                if (parameters["POSTER_ID"] != null)
                {
                    POSTER_ID = parameters["POSTER_ID"].ToString();
                    EntityObject_HEM_B_RECRUIT_POSTER entity = new EntityObject_HEM_B_RECRUIT_POSTER();
                    entity.ID = POSTER_ID;
                    entity = BizLogicObject_HEM_B_RECRUIT_POSTER.Proxy.Get(entity);
                    if(entity != null)
                    POSTER_ID = entity.IS_SEND.ToString();
                }
                DdlBindData();
                StaffBindData(staff_type_id, APPLY_ID);
            }
        }

        private DisplayObject_V_HEM_B_STAFF_EXT GetDisplay(DisplayObject_V_HEM_B_STAFF_EXT dispaly)
        {
            dispaly.REAL_ZHRGRSG = 0;
            dispaly.REAL_ZHRGRTZ = 0;
            dispaly.REAL_ZHRSLJZ = 0;
            dispaly.WRITTEN_ENGLISH = 0;
            dispaly.WRITTEN_THEORY = 0;
            dispaly.OPERATOR_ONE = 0;

            return dispaly;
        }

        protected void StaffBindData(string ID, string APPLY_ID)
        {
            CauseObject_V_HEM_B_STAFF_EXT cause_Vstaff = new CauseObject_V_HEM_B_STAFF_EXT();

            cause_Vstaff.STAFF_TYPE_ID = ID;

            DisplayObject_V_HEM_B_STAFF_EXT[] arr_Vstaff = BizLogicObject_V_HEM_B_STAFF_EXT.Proxy.Query(cause_Vstaff);
            if (arr_Vstaff.Length > 0)
            {
                DisplayObject_V_HEM_B_STAFF_EXT[] item_Vstaff = null;
                if (!string.IsNullOrEmpty(APPLY_ID))
                {
                    DisplayObject_V_HEM_B_STAFF_EXT[] arr_Vstaff1 = arr_Vstaff.Where(p => p.APPLY_ID == APPLY_ID).ToArray();
                    if (arr_Vstaff1.Length > 0)
                    {
                        item_Vstaff = new DisplayObject_V_HEM_B_STAFF_EXT[1] { arr_Vstaff1[0] };
                    }
                    else
                    {
                        DisplayObject_V_HEM_B_STAFF_EXT displayExt = GetDisplay(arr_Vstaff[0]);
                        item_Vstaff = new DisplayObject_V_HEM_B_STAFF_EXT[1] { displayExt };
                    }
                }
                else
                {
                    DisplayObject_V_HEM_B_STAFF_EXT displayExt = GetDisplay(arr_Vstaff[0]);
                    item_Vstaff = new DisplayObject_V_HEM_B_STAFF_EXT[1] { displayExt };
                }
                lit_Staff.DataSource = item_Vstaff;
                lit_Staff.DataBind();

                //判断是否为硕士及以上学历
                CauseObject_HEM_B_STAFF_EDUCATION cause = new CauseObject_HEM_B_STAFF_EDUCATION();
                cause.STAFF_ID = item_Vstaff[0].ID;
                DisplayObject_HEM_B_STAFF_EDUCATION[] hbe = BizLogicObject_HEM_B_STAFF_EDUCATION.Proxy.Query(cause);
                foreach (DisplayObject_HEM_B_STAFF_EDUCATION he in hbe)
                {
                    if (he.SLART == "10" || he.SLART == "11")
                    {
                        IsMaster = true;
                        break;
                    }
                }

                if (item_Vstaff[0].IS_NURSE == 3)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "displayHtmlZY", "<script>$(\".displayHtmlZY\").hide();$(\".displayHtmlHG\").hide();</script>");
                }
                if (item_Vstaff[0].IS_NURSE == 2)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\".displayHtml\").hide();$(\".displayHtmlSxxx\").hide();$(\".displayHtmlyjsSxxx\").hide();</script>");
                }
                if (item_Vstaff[0].IS_NURSE == 1)
                {
                    if (item_Vstaff[0].TYPE_ID == "1003")
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\".displayHtmlZY\").hide();$(\".displayHtmlSxxx\").hide();$(\".displayHtmlyjsSxxx\").hide();$(\".displayHtmlHG\").hide();</script>");
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml", "<script>$(\".displayHtmlZY\").hide();$(\".displayHtmlHG\").hide();</script>");
                        if (item_Vstaff[0].TYPE_ID == "1002" && !IsMaster)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "ThisDisplayHtml1", "<script>$(\".displayHtmlyjsSxxx\").hide();</script>");
                        }
                    }
                }


                //工作经历
                CauseObject_HEM_B_STAFF_WORK cause_Work = new CauseObject_HEM_B_STAFF_WORK();
                cause_Work.STAFF_ID = item_Vstaff[0].ID; ;
                DisplayObject_HEM_B_STAFF_WORK[] item_Work = BizLogicObject_HEM_B_STAFF_WORK.Proxy.Query(cause_Work);

                if (item_Work.Length > 1)
                {
                    item_Work = item_Work.OrderByDescending(p => p.ENDDA).ToArray();
                }

                foreach (DataListItem items in lit_Staff.Items)
                {
                    string lbl_FAMST_Txt = ((Label)items.FindControl("lbl_FAMST")).Text;
                    if (lbl_FAMST_Txt != "")
                    {
                        lbl_FAMST_Txt = ddlInputFAMST.Items.FindByValue(lbl_FAMST_Txt).Text;
                        ((Label)items.FindControl("lbl_FAMST")).Text = lbl_FAMST_Txt;
                    }
                    else
                    {
                        ((Label)items.FindControl("lbl_FAMST")).Text = "";
                    }

                    string lab_ZHRFZDJ_Txt = ((Label)items.FindControl("lab_ZHRFZDJ")).Text;
                    if (!string.IsNullOrEmpty(lab_ZHRFZDJ_Txt))
                    {
                        ((Label)items.FindControl("lab_ZHRFZDJ")).Text = "是";
                    }
                    else
                    {
                        ((Label)items.FindControl("lab_ZHRFZDJ")).Text = "否";
                    }

                    string lbl_ZHRYRXX_Txt = ((Label)items.FindControl("lbl_ZHRYRXX")).Text;
                    if (lbl_ZHRYRXX_Txt != "")
                    {
                        lbl_ZHRYRXX_Txt = ddlInputZHRYRXX.Items.FindByValue(lbl_ZHRYRXX_Txt).Text;
                        ((Label)items.FindControl("lbl_ZHRYRXX")).Text = lbl_ZHRYRXX_Txt;
                    }
                    else
                    {
                        ((Label)items.FindControl("lbl_ZHRYRXX")).Text = "";
                    }

                    string lbl_RACKY_Txt = ((Label)items.FindControl("lbl_RACKY")).Text;
                    if (lbl_RACKY_Txt != "")
                    {
                        lbl_RACKY_Txt = ddlInputRACKY.Items.FindByValue(lbl_RACKY_Txt).Text;
                        ((Label)items.FindControl("lbl_RACKY")).Text = lbl_RACKY_Txt;
                    }
                    else
                    {
                        ((Label)items.FindControl("lbl_RACKY")).Text = "";
                    }

                    string lbl_PCODE_Txt = ((Label)items.FindControl("lbl_PCODE")).Text;
                    if (lbl_PCODE_Txt != "")
                    {
                        lbl_PCODE_Txt = ddlInputPCODE.Items.FindByValue(lbl_PCODE_Txt).Text;
                        ((Label)items.FindControl("lbl_PCODE")).Text = lbl_PCODE_Txt;
                    }
                    else
                    {
                        ((Label)items.FindControl("lbl_PCODE")).Text = "";
                    }

                    string lbl_ZHRJSJSP_Txt = ((Label)items.FindControl("lbl_ZHRJSJSP")).Text;
                    if (lbl_ZHRJSJSP_Txt != "" && lbl_ZHRJSJSP_Txt != "0")
                    {
                        lbl_ZHRJSJSP_Txt = ddlInputZHRJSJSP.Items.FindByValue(lbl_ZHRJSJSP_Txt).Text;
                        ((Label)items.FindControl("lbl_ZHRJSJSP")).Text = lbl_ZHRJSJSP_Txt;
                    }
                    else
                    {
                        ((Label)items.FindControl("lbl_ZHRJSJSP")).Text = "";
                    }

                    string lbl_ZHRWYSP_Txt = ((Label)items.FindControl("lbl_ZHRWYSP")).Text;
                    if (lbl_ZHRWYSP_Txt != "" && lbl_ZHRWYSP_Txt != "0")
                    {
                        lbl_ZHRWYSP_Txt = ddlInputZHRWYSP.Items.FindByValue(lbl_ZHRWYSP_Txt).Text;
                        ((Label)items.FindControl("lbl_ZHRWYSP")).Text = lbl_ZHRWYSP_Txt;
                    }
                    else
                    {
                        ((Label)items.FindControl("lbl_ZHRWYSP")).Text = "";
                    }

                    string lab_PRACTICE_TYPE_ID_Txt = ((Label)items.FindControl("lab_PRACTICE_TYPE_ID")).Text;
                    if (lab_PRACTICE_TYPE_ID_Txt != "")
                    {
                        lab_PRACTICE_TYPE_ID_Txt = ddlInputPRACTICE_TYPE_ID.Items.FindByValue(lab_PRACTICE_TYPE_ID_Txt).Text;
                        ((Label)items.FindControl("lab_PRACTICE_TYPE_ID")).Text = lab_PRACTICE_TYPE_ID_Txt;
                    }
                    else
                    {
                        ((Label)items.FindControl("lab_PRACTICE_TYPE_ID")).Text = "";
                    }

                    string lbl_FILE_PATH = "";

                    lbl_FILE_PATH = item_Vstaff[0].FILE_PATH;

                    if (!string.IsNullOrEmpty(lbl_FILE_PATH))
                    {
                        ((Label)items.FindControl("lbl_FILE_PATH")).Text = "<a href='../" + lbl_FILE_PATH + "' title='简历下载'><img width='100px' border='0px' src='../Images/Public/doc.jpg' /></a>";
                    }
                    else
                    {
                        ((Label)items.FindControl("lbl_FILE_PATH")).Text = "&nbsp;";
                    }

                    if (item_Vstaff[0].IS_NURSE == 1)
                    {
                        string lbl_TYPE_IDTXT = ((Label)items.FindControl("lbl_TYPE_ID")).Text;

                        if (!string.IsNullOrEmpty(lbl_TYPE_IDTXT))
                        {
                            lbl_TYPE_IDTXT = lbl_TYPE_IDTXT.Trim();
                        }

                        if (!string.IsNullOrEmpty(lbl_TYPE_IDTXT))
                        {
                            if (lbl_TYPE_IDTXT == "1003")
                            {
                                ((Label)items.FindControl("lab_NURSETXT")).Text = "三级甲等医院工作年限";
                            }
                            else
                            {
                                ((Label)items.FindControl("lab_NURSETXT")).Text = "实习时长";
                            }

                            lbl_TYPE_IDTXT = ddlInputTYPE_ID.Items.FindByValue(lbl_TYPE_IDTXT).Text;
                            ((Label)items.FindControl("lbl_TYPE_ID")).Text = lbl_TYPE_IDTXT;
                        }

                        ((Label)items.FindControl("lab_IS_CERTIFICATE")).Text = "是否护士资格证";
                        ((Label)items.FindControl("lab_IS_CERTIFICATE_VAL")).Text = item_Vstaff[0].IS_CERTIFICATE == 1 ? "是" : "否";
                        ((Label)items.FindControl("lab_CZ")).Text = "视　　力";
                        ((Label)items.FindControl("lab_lab_CZVal")).Text = item_Vstaff[0].ZHRSLJZ;
                    }
                    else
                    {
                        //((Label)items.FindControl("lab_IS_CERTIFICATE")).Text = "是否医师资格证";
                        ((Label)items.FindControl("lab_CZ")).Text = "是否医师资格证";
                        ((Label)items.FindControl("lab_lab_CZVal")).Text = item_Vstaff[0].IS_CERTIFICATE == 1 ? "是" : "否";
                    }
                    if (item_Vstaff[0].IS_NURSE == 1)
                    {

                        //lbl_ZHRSXXX
                        if (item_Vstaff[0].TYPE_ID != "1003")
                        {
                            if (item_Work.Length > 0)
                            {
                                if (string.IsNullOrEmpty(item_Vstaff[0].ZHRSXXX))
                                {
                                    ((Label)items.FindControl("lbl_ZHRSXXX")).Text = item_Work[0].ZHRXXDW;
                                }
                            }
                        }
                    }
                }

                //教育信息

                CauseObject_HEM_B_STAFF_EDUCATION cause_Eudcation = new CauseObject_HEM_B_STAFF_EDUCATION();
                cause_Eudcation.STAFF_ID = item_Vstaff[0].ID; ;
                DisplayObject_HEM_B_STAFF_EDUCATION[] item_Eudcation = BizLogicObject_HEM_B_STAFF_EDUCATION.Proxy.Query(cause_Eudcation);
                if (item_Eudcation.Length > 0)
                {
                    if (item_Eudcation.Length > 1)
                    {
                        item_Eudcation = item_Eudcation.OrderBy(p => p.SLART).ToArray();
                    }
                    v_Eudcation.Visible = true;
                    lit_Eudcation.DataSource = item_Eudcation;
                    lit_Eudcation.DataBind();

                    foreach (DataListItem items in lit_Eudcation.Items)
                    {
                        string lbl_Slart_Txt = ((Label)items.FindControl("lbl_SLART")).Text;
                        if (lbl_Slart_Txt != "")
                        {
                            lbl_Slart_Txt = ddlInputSLART.Items.FindByValue(lbl_Slart_Txt).Text;
                            ((Label)items.FindControl("lbl_SLART")).Text = lbl_Slart_Txt;
                        }
                        else
                        {
                            ((Label)items.FindControl("lbl_SLART")).Text = "";
                        }

                        string lbl_TYPE_ID_Txt = ((Label)items.FindControl("lbl_TYPE_ID")).Text;
                        if (lbl_TYPE_ID_Txt != "")
                        {
                            lbl_TYPE_ID_Txt = ddlInputED_TYPE_ID.Items.FindByValue(lbl_TYPE_ID_Txt).Text;
                            ((Label)items.FindControl("lbl_TYPE_ID")).Text = lbl_TYPE_ID_Txt;
                        }
                        else
                        {
                            ((Label)items.FindControl("lbl_TYPE_ID")).Text = "";
                        }
                    }
                }

                //工作经历
                if (item_Work.Length > 0)
                {
                    v_Work.Visible = true;
                    lit_Work.DataSource = item_Work;
                    lit_Work.DataBind();

                    foreach (DataListItem items in lit_Work.Items)
                    {
                        string lbl_Slart_Work_Txt = ((Label)items.FindControl("lbl_SLART_Work")).Text;
                        if (lbl_Slart_Work_Txt != "")
                        {
                            lbl_Slart_Work_Txt = ddlInputSLART.Items.FindByValue(lbl_Slart_Work_Txt).Text;
                            ((Label)items.FindControl("lbl_SLART_Work")).Text = lbl_Slart_Work_Txt;
                        }
                        else
                        {
                            ((Label)items.FindControl("lbl_SLART_Work")).Text = "";
                        }

                    }
                }


                //项目信息
                CauseObject_HEM_B_STAFF_PROJECT cause_Project = new CauseObject_HEM_B_STAFF_PROJECT();
                cause_Project.STAFF_ID = item_Vstaff[0].ID; ;
                DisplayObject_HEM_B_STAFF_PROJECT[] item_Project = BizLogicObject_HEM_B_STAFF_PROJECT.Proxy.Query(cause_Project);
                if (item_Project.Length > 0)
                {
                    if (item_Project.Length > 1)
                    {
                        item_Project = item_Project.OrderByDescending(p => p.ENDDA).ToArray();
                    }
                    v_Project.Visible = true;
                    lit_Project.DataSource = item_Project;
                    lit_Project.DataBind();
                }

                if (item_Vstaff[0].IS_NURSE == 2)
                {
                    //文章信息
                    CauseObject_HEM_B_STAFF_ESSAY cause_Essay = new CauseObject_HEM_B_STAFF_ESSAY();
                    cause_Essay.STAFF_ID = item_Vstaff[0].ID; ;
                    DisplayObject_HEM_B_STAFF_ESSAY[] item_Essay = BizLogicObject_HEM_B_STAFF_ESSAY.Proxy.Query(cause_Essay);
                    if (item_Essay.Length > 0)
                    {
                        if (item_Essay.Length > 1)
                        {
                            item_Essay = item_Essay.OrderByDescending(p => p.BEGDA).ToArray();
                        }
                        v_Essay.Visible = true;
                        lit_Essay.DataSource = item_Essay;
                        lit_Essay.DataBind();

                        foreach (DataListItem items in lit_Essay.Items)
                        {
                            string lbl_ZHRBRMP_Txt = ((Label)items.FindControl("lbl_ZHRBRMP")).Text;
                            if (lbl_ZHRBRMP_Txt != "")
                            {
                                lbl_ZHRBRMP_Txt = ddlInputZHRBRMP.Items.FindByValue(lbl_ZHRBRMP_Txt).Text;
                                ((Label)items.FindControl("lbl_ZHRBRMP")).Text = lbl_ZHRBRMP_Txt;
                            }
                            else
                            {
                                ((Label)items.FindControl("lbl_ZHRBRMP")).Text = "";
                            }

                            string lbl_ZHRKWJB_Txt = ((Label)items.FindControl("lbl_ZHRKWJB")).Text;
                            if (lbl_ZHRKWJB_Txt != "")
                            {
                                lbl_ZHRKWJB_Txt = ddlInputZHRKWJB.Items.FindByValue(lbl_ZHRKWJB_Txt).Text;
                                ((Label)items.FindControl("lbl_ZHRKWJB")).Text = lbl_ZHRKWJB_Txt;
                            }
                            else
                            {
                                ((Label)items.FindControl("lbl_ZHRKWJB")).Text = "";
                            }

                            string lbl_ZHRFBZT_Txt = ((Label)items.FindControl("lbl_ZHRFBZT")).Text;
                            if (lbl_ZHRFBZT_Txt != "")
                            {
                                lbl_ZHRFBZT_Txt = ddlInputZHRFBZT.Items.FindByValue(lbl_ZHRFBZT_Txt).Text;
                                ((Label)items.FindControl("lbl_ZHRFBZT")).Text = lbl_ZHRFBZT_Txt;
                            }
                            else
                            {
                                ((Label)items.FindControl("lbl_ZHRFBZT")).Text = "";
                            }

                        }
                    }
                }
            }
        }

        protected void DdlBindData()
        {
            CauseObject_SYS_DATA_TYPE cause = new CauseObject_SYS_DATA_TYPE();
            cause.PARENT_ID = "HEM_1001";
            //血型

            ddlInputZHRYRXX.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputZHRYRXX.DataTextField = "NAME";
            ddlInputZHRYRXX.DataValueField = "CODE";
            ddlInputZHRYRXX.DataBind();
            //民族 
            cause.PARENT_ID = "HEM_1008";
            ddlInputRACKY.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputRACKY.DataTextField = "NAME";
            ddlInputRACKY.DataValueField = "CODE";
            ddlInputRACKY.DataBind();
            //政治面貌
            cause.PARENT_ID = "HEM_1002";
            ddlInputPCODE.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputPCODE.DataTextField = "NAME";
            ddlInputPCODE.DataValueField = "CODE";
            ddlInputPCODE.DataBind();

            //婚姻状况
            cause.PARENT_ID = "HEM_1009";
            ddlInputFAMST.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputFAMST.DataTextField = "NAME";
            ddlInputFAMST.DataValueField = "CODE";
            ddlInputFAMST.DataBind();

            //外语水平
            cause.PARENT_ID = "HEM_1003";
            ddlInputZHRWYSP.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputZHRWYSP.DataTextField = "NAME";
            ddlInputZHRWYSP.DataValueField = "CODE";
            ddlInputZHRWYSP.DataBind();

            //计算机水平
            cause.PARENT_ID = "HEM_1004";
            ddlInputZHRJSJSP.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputZHRJSJSP.DataTextField = "NAME";
            ddlInputZHRJSJSP.DataValueField = "CODE";
            ddlInputZHRJSJSP.DataBind();

            //学历
            cause.PARENT_ID = "HEM_1005";
            ddlInputSLART.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputSLART.DataTextField = "NAME";
            ddlInputSLART.DataValueField = "CODE";
            ddlInputSLART.DataBind();

            //本人排名
            cause.PARENT_ID = "HEM_1007";
            ddlInputZHRBRMP.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputZHRBRMP.DataTextField = "NAME";
            ddlInputZHRBRMP.DataValueField = "CODE";
            ddlInputZHRBRMP.DataBind();

            //刊物级别
            cause.PARENT_ID = "HEM_1006";
            ddlInputZHRKWJB.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputZHRKWJB.DataTextField = "NAME";
            ddlInputZHRKWJB.DataValueField = "CODE";
            ddlInputZHRKWJB.DataBind();

            //发布状态
            cause.PARENT_ID = "HEM_1011";
            ddlInputZHRFBZT.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputZHRFBZT.DataTextField = "NAME";
            ddlInputZHRFBZT.DataValueField = "CODE";
            ddlInputZHRFBZT.DataBind();

            //护理类型
            cause.PARENT_ID = "HEM_1012";
            ddlInputTYPE_ID.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputTYPE_ID.DataTextField = "NAME";
            ddlInputTYPE_ID.DataValueField = "CODE";
            ddlInputTYPE_ID.DataBind();

            //执业类型
            cause.PARENT_ID = "HEM_1016";
            ddlInputPRACTICE_TYPE_ID.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputPRACTICE_TYPE_ID.DataTextField = "NAME";
            ddlInputPRACTICE_TYPE_ID.DataValueField = "CODE";
            ddlInputPRACTICE_TYPE_ID.DataBind();

            //学科类型
            cause.PARENT_ID = "HEM_1017";
            ddlInputED_TYPE_ID.DataSource = BizLogicObject_SYS_DATA_TYPE.Proxy.Query(cause);
            ddlInputED_TYPE_ID.DataTextField = "NAME";
            ddlInputED_TYPE_ID.DataValueField = "CODE";
            ddlInputED_TYPE_ID.DataBind();
        }
    }
}
