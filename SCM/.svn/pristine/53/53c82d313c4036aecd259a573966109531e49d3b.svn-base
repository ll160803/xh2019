<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Create.Master" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_COM_ROLE>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
        <legend>
            <input class="a2 f2" type="submit" value="保存" />
            <input class="a2 f2" type="button" onclick="window.history.go(-1);" value="返回" />
        </legend>
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td>
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="8">
                                &nbsp;
                            </td>
                            <td>
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td>
                                            <div>
                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                    cellpadding="0">
                                                   
                                                    <tr>
                                                        <td>
                                                            <nobr>角色名称</nobr>
                                                        </td>
                                                        <td>
                                                           <%: Html.EditorFor(model => model.NAME)%>
                                                            <%: Html.ValidationMessageFor(model => model.NAME)%>
                                                        </td>
                                                    </tr>
                                                   <tr>
                                                        <td>
                                                            <nobr>角色描述</nobr>
                                                        </td>
                                                        <td>
                                                            <%: Html.TextAreaFor(model => model.DISCRIPTION)%>
                                                            <%: Html.ValidationMessageFor(model => model.DISCRIPTION)%>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td width="8">
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td height="35">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="12" height="35">
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td width="16">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </fieldset>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CurentPlace" runat="server">
</asp:Content>
