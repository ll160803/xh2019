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
                    姓名：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.NAME)%>
                    <%: Html.ValidationMessageFor(model => model.NAME)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    账号：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.ACCOUNT)%>
                    <%: Html.ValidationMessageFor(model => model.ACCOUNT)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    所属角色：
                </div>
                <div class="trendrt">
                    <select class="easyui-combobox" name="UserType" id="UserType" style="width: 80px;">
                        <option value="0">管理员</option>
                        <option value="1">PDA</option>
                        <option value="2">供应商</option>
                    </select>
                </div>
            </div>
        </div>
    </fieldset>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">
<script language="javascript" type="text/javascript" >
    $(function () {
        $("#UserType").combobox('setValue', '<%:ViewBag.UserType %>');

    });

</script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CurentPlace" runat="server">
</asp:Content>
