<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Details.Master"Inherits="System.Web.Mvc.ViewPage<WCJD.DAL.Notice>" %>
<%@ Import Namespace="Common" %>
 
<asp:Content ID="Content4" ContentPlaceHolderID="CurentPlace" runat="server">
      详细 公告管理
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <fieldset>
        <legend>
            <input class="a2 f2" type="button"  onclick="window.location.href = 'javascript:history.go(-1)';"  value="返回" />   
        </legend>
        <%: Html.HiddenFor(model => model.ID) %>
<!--一行开始-->
   
                <%--<div class="leftTD">
                    <div class="leftlabel">
                    <%: Html.LabelFor(model => model.ID) %>
                    </div>
                    <div class="righteditor">
                      <%: Html.DisplayFor(model => model.ID) %>
                    </div>
                </div>--%>
            
        <!--一行开始-->
            <div class="laytr">
                <div class="leftTD">
                    <div class="leftlabel">
                     <%: Html.LabelFor(model => model.CreateTime) %>
                    </div>
                    <div class="righteditor">
                     <%: Html.DisplayFor(model => model.CreateTime) %>
                    </div>
                </div>
                <div class="rightTD">
                    <div class="leftlabel">
                     <%: Html.LabelFor(model => model.UpdateTime) %>
                    </div>
                    <div class="righteditor">
                      <%: Html.DisplayFor(model => model.UpdateTime) %>
                    </div>
                </div>
            </div>
            <!--一行结束-->
 <!--一行开始-->
            <div class="laytr">
                <div class="leftTD">
                    <div class="leftlabel">
                        <%: Html.LabelFor(model => model.CreatePerson) %>
                    </div>
                    <div class="righteditor">
                       <%: Html.DisplayFor(model => model.CreatePerson) %>
                    </div>
                </div>
                <div class="rightTD">
                    <div class="leftlabel">
                     <%: Html.LabelFor(model => model.UpdatePerson) %>
                    </div>
                    <div class="righteditor">
                     <%: Html.DisplayFor(model => model.UpdatePerson) %>
                    </div>
                </div>
            </div>
            <!--一行结束-->
<div class="bottom">
        <div class="bottomleft">
           
             <%: Html.LabelFor(model => model.Content) %>
            </div> 
            <div class="bottomright">
            <div class="textarea-box">
               <%: Html.DisplayFor(model => model.Content) %>

            </div>
            </div> 
        </div>



    </fieldset>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
 
</asp:Content>

