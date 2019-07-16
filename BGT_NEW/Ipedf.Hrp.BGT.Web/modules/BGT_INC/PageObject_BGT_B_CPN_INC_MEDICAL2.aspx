<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_CPN_INC_MEDICAL2.aspx.cs"
    Inherits="Ipedf.Web.PageObject_BGT_B_CPN_INC_MEDICAL2" %>

<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta name="Generator" content="Ipedf" />
    <meta name="Author" content="http://www.itabby.com" />
    <meta name="Keywords" content="http://www.itabby.com" />
    <meta name="Description" content="" />
    <title>BGT_B_CPN_INC_MEDICAL</title>

    <script src="<%=ResolveClientUrl("~/scripts/xp.js") %>" type="text/javascript"></script>

    <link href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet" />

    <script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>

</head>
<body topmargin="0" leftmargin="0">
    <form id="form1" runat="server">
    <div>
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td>
                    <Com:ComPageNavigator runat="server" ID="navigator" />
                </td>
            </tr>
            <tr>
                <td height="30">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="12" height="30">
                            </td>
                            <td>
                                <Com:ComControlBar ID="command" runat="server" HandoverState="True" />
                            </td>
                            <td width="16">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
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
                                            <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                cellpadding="0">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblState" runat="server" Width="500px"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <Com:ComButton ID="btnDelete" runat="server" Text="删除" />&nbsp;
                                                        <Com:ComButton ID="btnSeSubmit" OnClientClick="if (!confirm('确定要提交吗?')) return false;" runat="server" Text="提交" OnClick="OnSeSubmit"/>&nbsp;
                                                         <asp:Button runat="server" ID="btnExport" Text="导出" OnClick="OnExport" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div id="resultPannel" runat="server">
                                                <Com:ComGridView ID="gvList" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                    BorderWidth="1px" AllowPaging="True" AllowSorting="True" BorderStyle="Double" ShowFooter="True">
                                                    <Columns>
                                                        <asp:TemplateField HeaderText="V">
                                                            <HeaderTemplate>
                                                                <input id="chkSelItem" type="checkbox" onclick="selectAll('gvList');" />
                                                            </HeaderTemplate>
                                                            <ItemTemplate>
                                                                <asp:CheckBox ID="cbSelect" runat="server" />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:BoundField DataField="BUDGET_YEAR_NAME" HeaderText="预算年度" />
                                                        <asp:BoundField DataField="COM_TYPE_ID_NAME" HeaderText="收入类型" />
                                                        <asp:BoundField DataField="DEPT_NAME" HeaderText="预算科室" />
                                                        <asp:BoundField DataField="ITEM_NAME" HeaderText="临床科室" />
                                                        <asp:BoundField DataField="MONEY" HeaderText="金额" />
                                                        <asp:BoundField DataField="PER_MONEY" HeaderText="人均费用" />
                                                        <asp:BoundField DataField="PERSON_COUNT" HeaderText="目标人次" />
                                                        <asp:BoundField DataField="STATE_NAME" HeaderText="状态" />
                                                    </Columns>
                                                    <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                                    <FooterStyle CssClass="FooterStyle"></FooterStyle>
                                                    <RowStyle CssClass="RowStyle"></RowStyle>
                                                    <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                    <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                    <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                                    <PagerSettings Visible="False" />
                                                </Com:ComGridView>
                                                <Com:ComPager runat="server" ID="pager" />
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div id="editPannel" runat="server">
                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                    cellpadding="0">
                                                    <tr>
                                                        <td>
                                                            <nobr>申请年度</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComDropDownList ID="ddlInputBUDGET_YEAR" runat="server">
                                                            </Com:ComDropDownList>
                                                        </td>
                                                        <td>
                                                            <nobr>临床科室</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputITEM_NAME" runat="server" MaxLength="200"></Com:ComTextBox>
                                                        </td>
                                                        <td>
                                                            <nobr>金额</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputMONEY" Enabled="false" runat="server"></Com:ComTextBox>
                                                            <asp:RegularExpressionValidator ID="revtxtInputMONEY" runat="server" ControlToValidate="txtInputMONEY"
                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>目标人次</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputPERSON_COUNT" runat="server"></Com:ComTextBox>
                                                            <asp:RegularExpressionValidator ID="revtxtInputPERSON_COUNT" runat="server" ControlToValidate="txtInputPERSON_COUNT"
                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
                                                        </td>
                                                        <td>
                                                            <nobr>人均费用</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputPER_MONEY" Enabled="true" runat="server"></Com:ComTextBox>
                                                            <asp:RegularExpressionValidator ID="revtxtInputPER_MONEY" runat="server" ControlToValidate="txtInputPER_MONEY"
                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
                                                        </td>
                                                        <td>
                                                        </td>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>申请理由</nobr>
                                                        </td>
                                                        <td colspan="5">
                                                            <Com:ComTextBox ID="txtInputDECALRE_CAUSE" TextMode="MultiLine" Columns="20" Rows="2"
                                                                Font-Size="12px" Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                            </Com:ComTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="6">
                                                            <Com:ComUpFile ID="upFiles" runat="server"></Com:ComUpFile>
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
    </div>
    </form>
        <script type="text/javascript">
        function ontextchange() {
            //console.log("aaaaaaaaaaaaaaa");
            //console.log(document.getElementById("txtInputPER_MONEY").value);
            document.getElementById("txtInputMONEY").value = (parseInt(document.getElementById("txtInputPER_MONEY").value) * parseInt(document.getElementById("txtInputPERSON_COUNT").value)).toString();
        }
    </script>
</body>
</html>
