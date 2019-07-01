<%@ Page Title="" Language="C#" ValidateRequest="false"  MasterPageFile="~/Views/Shared/Create_Editor.Master"
    Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_SCM_D_REPORT>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <fieldset>
        <legend>
            <input class="a2 f2" type="submit" value="保存" />
            <input class="a2 f2" type="button" onclick="window.history.go(-1);" value="返回" />
            <%: Html.HiddenFor(model => model.ID)%>
        </legend>
        <table>
            <tr>
                <td>
                    标题：
                </td>
                <td>
                    <%: Html.EditorFor(model => model.NAME)%>
                </td>
            </tr>
            <tr>
                <td>
                    内容:
                </td>
                <td>
                  <textarea id="COMMENTS" name="COMMENTS" cols="100" rows="8" style="width:700px;height:300px;"></textarea>
                </td>
            </tr>
        </table>
    </fieldset>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="<%: Url.Content("~/Scripts/kindeditor/kindeditor-all.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/kindeditor/themes/default/default.css") %>"
        type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/kindeditor/plugins/code/prettify.css") %>"
        type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/kindeditor/lang/zh-CN.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/kindeditor/plugins/code/prettify.js") %>"
        type="text/javascript"></script>
    <script>
        var editor;
        KindEditor.ready(function (K) {
            editor = K.create('textarea[name="COMMENTS"]', {
                cssPath: '<%: Url.Content("~/Scripts/kindeditor/plugins/code/prettify.css") %>',
                allowFileManager: true
            });
        });
         
    </script>
    <style type="text/css">
    #NAME{ width:500px;}
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CurentPlace" runat="server">

</asp:Content>
