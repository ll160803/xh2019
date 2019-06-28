<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Edit.Master" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_SCM_COM_CODECOMPARE>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<fieldset>
        <legend>
            <input class="a2 f2" type="submit" value="保存" />
            <input class="a2 f2" type="button" onclick="window.history.go(-1);" value="返回" />
        </legend>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    药品编码：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.CODE)%>
                    <%: Html.ValidationMessageFor(model => model.CODE)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    药品名称：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.NAME)%>
                    <%: Html.ValidationMessageFor(model => model.NAME)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    药品规格：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.SPEC)%>
                    <%: Html.ValidationMessageFor(model => model.SPEC)%>
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    生产厂家：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.FACTORY)%>
                    <%: Html.ValidationMessageFor(model => model.FACTORY)%>
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
