using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
//using Ipedf.Web.BizLogic;
using System.Reflection;
using Ipedf.Common;
using Ipedf.Web.Control;
using System.Linq;
/*
 * 2015-5-19版本,对Gridview进行了升级,对于历史项目的升级改造,需要进行如下操作:
 * 1.去掉aspx中的gridview标签中的cmd_view,cmd_edit,cmd_delete标签列
 * 2.增加aspx中的gridview标签中的checkbox标签列(第1列)
 * 3.增加aspx.cs中的ondelete方法实现
 * 4.修改aspx中的btnQueryZone为btnDelete
 */
[assembly: TagPrefix("Ipedf.Hrp.BGT.Web.Control", "BGT")]
namespace Ipedf.Hrp.BGT.Web.Control
{
    public partial class BGTComGridView : ComGridView
    {
        public BGTComGridView()
        {
            base.RowDataBound += new GridViewRowEventHandler(BGTComGridView_RowDataBound);

        }
        protected override void OnPreRender(EventArgs e)
        {
            foreach (GridViewRow row in this.Rows)
            {
                if (this.DataKeys.Count == 0) continue;
                if (row.RowType == DataControlRowType.DataRow)
                {
                    object key = this.DataKeys[row.RowIndex].Value;
                    if (key != null)
                    {
                        if (
                                key is string && (string)key == Template.UndefineGuid
                            )
                        {
                            //空行
                            foreach (TableCell c in row.Cells)
                            {
                                c.Text = string.Empty;
                            }
                        }
                        else
                        {
                            //空日期显示为空白,而非0001-01-01
                            foreach (TableCell c in row.Cells)
                            {
                                if (System.Text.RegularExpressions.Regex.Match(c.Text, Template.TimeValidationExpression).Success)
                                    if (DateTime.Parse(c.Text) == Template.UndefineDatetime)
                                        c.Text = string.Empty;
                            }
                        }
                    }
                    else
                    {
                        //空行
                        foreach (TableCell c in row.Cells)
                        {
                            c.Text = string.Empty;
                        }
                    }

                }
            }
            base.OnPreRender(e);
        }
        void BGTComGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                object entity = e.Row.DataItem;
                CheckBox select = (CheckBox)e.Row.FindControl("cbSelect");
                if (select != null)
                {
                    if (((BaseWebPage)(this.Page)).OpLimitRequest)
                    {
                        if (entity != null)
                        {
                            //删除权限在BaseWebPage.RegisterCommandEvent()中控制
                            //select.Enabled = ((BaseWebPage)(this.Page)).IsDeleteAble;
                            if (select.Enabled)
                            {

                                select.Enabled = Ipedf.Web.BizLogic.SystemLogic.Proxy.IsEditStatus(entity); //编辑中
                            }
                        }
                    }
                    else
                    {
                        select.Enabled = true;
                    }
                }
                e.Row.Attributes.Add("onmouseover", "if(this!=prevselitem){this.style.backgroundColor='#Efefef'}");//当鼠标停留时更改背景色
                e.Row.Attributes.Add("onmouseout", "if(this!=prevselitem){this.style.backgroundColor='#ffffff'}");//当鼠标移开时还原背景色
                e.Row.Attributes.Add("onclick", "selectx(this)");//点击行变色                
                e.Row.Attributes["style"] = "Cursor:hand"; //设置悬浮鼠标指针形状为"小手"
                //双击行编辑-主列表
                if (DbClickEdit)
                {
                    object key = this.DataKeys[e.Row.RowIndex].Value;
                    if (key != null)
                    {
                        if (key is string && (string)key != Template.UndefineGuid)
                        {
                            Ipedf.Core.IView view = this.Page as Ipedf.Core.IView;
                            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Page.Request);
                            //System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();

                            if (parameters.AllKeys.Contains("linkquery"))
                            {
                                parameters.Remove("linkquery");
                            }
                            if (!string.IsNullOrEmpty(KeyValue))
                            {
                                parameters.Add("linkquery", "{\"" + Field_Value + "\":\"" + KeyValue + "\"}");
                            }
                            // parameters.Add(Field_Value, KeyValue);
                            parameters["linkopt"] = key.ToString();
                            string url = WebControlHelper.EncodeUrl(view.EditUrl, view.AppendEditParameter(parameters));
                            e.Row.Attributes.Add("ondblclick", "location.href='" + url + "';");
                        }
                    }
                }
                //弹出编缉-主列表
                if (PopEdit)
                {
                    object key = this.DataKeys[e.Row.RowIndex].Value;
                    if (key != null)
                    {
                        if (key is string && (string)key != Template.UndefineGuid)
                        {
                            Ipedf.Core.IView view = this.Page as Ipedf.Core.IView;
                            System.Collections.Specialized.NameValueCollection parameters = WebControlHelper.DecodeParameter(Page.Request);

                            //System.Collections.Specialized.NameValueCollection parameters = new System.Collections.Specialized.NameValueCollection();
                            parameters["linkopt"] = key.ToString();
                            string url = WebControlHelper.EncodeUrl(view.EditUrl, view.AppendEditParameter(parameters));
                            string scripts = view.PreparePopEditWindowScript(url);
                            e.Row.Attributes.Add("ondblclick", string.Format("{0};return false;", scripts));
                        }
                    }
                }
            }
        }
        [
           Category("Com"),
           DefaultValue(true),
           BrowsableAttribute(true),
           PersistenceMode(PersistenceMode.Attribute),
           Description("Com:是否允许双击编辑")
        ]
        public bool DbClickEdit
        {
            get
            {
                object value = ViewState["DBCLICK_EDIT"];
                if (value == null)
                    return true;
                return (bool)value;
            }
            set
            {
                ViewState["DBCLICK_EDIT"] = value;
            }
        }
        [
           Category("Com"),
           DefaultValue(false),
           BrowsableAttribute(true),
           PersistenceMode(PersistenceMode.Attribute),
           Description("Com:是否允许弹出编辑")
        ]
        public bool PopEdit
        {
            get
            {
                object value = ViewState["POP_EDIT"];
                if (value == null)
                    return false;
                return (bool)value;
            }
            set
            {
                ViewState["POP_EDIT"] = value;
            }
        }
        public string KeyValue
        {
            get
            {
                object value = ViewState["KEY_VALUE"];
                if (value == null)
                    return "";
                return value.ToString();
            }
            set
            {
                ViewState["KEY_VALUE"] = value;
            }
        }
        public string Field_Value
        {
            get
            {
                object value = ViewState["Field_Value"];
                if (value == null)
                    return "";
                return value.ToString();
            }
            set
            {
                ViewState["Field_Value"] = value;
            }
        }
    }
}
