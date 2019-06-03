<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Edit.Master" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_COM_TOOLBAR>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
        <legend>
            <input class="a2 f2" type="submit" value="保存" />
            <input class="a2 f2" type="button" onclick="window.history.go(-1);" value="返回" />
            <%: Html.HiddenFor(model => model.ID)%>
        </legend>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    按钮名称：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.TEXT)%>
                    <%: Html.ValidationMessageFor(model => model.TEXT)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    按钮图标：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.ICONCLS)%>
                    <%: Html.ValidationMessageFor(model => model.ICONCLS)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    事件：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.HANDLER)%>
                    <%: Html.ValidationMessageFor(model => model.HANDLER)%>
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    显示索引：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.DISPLAYINDEX)%>
                    <%: Html.ValidationMessageFor(model => model.DISPLAYINDEX)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                </div>
                <div class="trendrt">
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                </div>
                <div class="trendrt">
                </div>
            </div>
        </div>
    </fieldset>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CurentPlace" runat="server">
</asp:Content>
