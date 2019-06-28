<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Edit.Master" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_COM_USER>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
        <legend>
            <input class="a2 f2" type="submit" value="保存" />
            <input class="a2 f2" type="button" onclick="window.history.go(-1);" value="返回" />
        </legend>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    编码：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.CODE)%>
                    <%: Html.ValidationMessageFor(model => model.CODE)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    姓名：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.NAME)%>
                    <%: Html.ValidationMessageFor(model => model.NAME)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    账号：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.ACCOUNT)%>
                    <%: Html.ValidationMessageFor(model => model.ACCOUNT)%>
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    所属部门：
                </div>
                <div class="trendrt">
                    <input id="checkDEPART_ID" type="text" value="<%:ViewBag.DepartmentName %>" disabled style="width: 110px;" />
                    <input type="button" value="..." onclick="showModalOnly_New('DEPART_ID','../../../System/SysDepartment');" />
                    <%: Html.HiddenFor(model => model.DEPART_ID)%>
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
