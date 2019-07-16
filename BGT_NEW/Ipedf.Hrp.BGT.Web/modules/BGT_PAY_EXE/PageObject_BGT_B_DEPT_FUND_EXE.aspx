<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_DEPT_FUND_EXE.aspx.cs"
    Inherits="Ipedf.Web.PageObject_BGT_B_DEPT_FUND_EXE" %>

<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="Generator" content="Ipedf" />
    <meta name="Author" content="http://www.itabby.com" />
    <meta name="Keywords" content="http://www.itabby.com" />
    <meta name="Description" content="" />
    <title>BGT_B_DEPT_FUND_EXE</title>

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
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div id="resultPannel" runat="server">
                                                <Com:ComGridView ID="gvList" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                    BorderWidth="1px" AllowPaging="True" AllowSorting="True" BorderStyle="Double">
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
                                                        <asp:BoundField DataField="BUDGET_DEPT_ID_NAME" HeaderText="预算部门" />
                                                        <asp:BoundField DataField="DEPT_USER_ID_NAME" HeaderText="科室负责人" />
                                                        <asp:BoundField DataField="BGT_D_BUDGET_ITEM_ID_NAME" HeaderText="经费名称" />
                                                        <asp:BoundField DataField="CODE" HeaderText="经费编码" />
                                                        <asp:BoundField DataField="FUND_MONEY" HeaderText="经费金额" />
                                                        <asp:BoundField DataField="CONTROL_MONEY" HeaderText="控制数" />
                                                        <asp:BoundField DataField="NEW_FUND_MONEY" HeaderText="当前经费金额" />
                                                        <asp:BoundField DataField="FUND_TYPE_ID_NAME" HeaderText="经费类别" />
                                                        <asp:BoundField DataField="DECALRE_CAUSE" HeaderText="申请理由" />
                                                        <asp:BoundField DataField="IS_FIXED_NAME" HeaderText="是否刚性需求" />
                                                        <asp:BoundField DataField="IS_PERFORMANCE_NAME" HeaderText="是否绩效考核项目" />
                                                        <asp:BoundField DataField="IS_UPDATE_ITEM_NAME" HeaderText="是否变更新增经费" />
                                                        <asp:BoundField DataField="FINANCE_IDEA" HeaderText="财务意见" />
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
                                                            <nobr>预算年度</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComBaseBox ID="ddlInputBUDGET_YEAR" runat="server"></Com:ComBaseBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>预算部门</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComBaseBox ID="ddlInputBUDGET_DEPT_ID" runat="server"></Com:ComBaseBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>经费名称</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComBaseBox ID="ddlInputBGT_D_BUDGET_ITEM_ID" runat="server"></Com:ComBaseBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>保留字段3</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputFREE_FIELD3" runat="server" MaxLength="10"></Com:ComTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>当前经费金额</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputNEW_FUND_MONEY" runat="server"></Com:ComTextBox>
                                                            <asp:RegularExpressionValidator ID="revtxtInputNEW_FUND_MONEY" runat="server" ControlToValidate="txtInputNEW_FUND_MONEY"
                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>保留字段1</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputFREE_FIELD" runat="server" MaxLength="50"></Com:ComTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>申请理由</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputDECALRE_CAUSE" runat="server" MaxLength="2000"></Com:ComTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>名称</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputNAME" runat="server" MaxLength="100"></Com:ComTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>控制数</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputCONTROL_MONEY" runat="server"></Com:ComTextBox>
                                                            <asp:RegularExpressionValidator ID="revtxtInputCONTROL_MONEY" runat="server" ControlToValidate="txtInputCONTROL_MONEY"
                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>是否刚性需求</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComDropDownList ID="ddlInputIS_FIXED" runat="server">
                                                            </Com:ComDropDownList>
                                                            <input type="textbox" style="width: 40px;" onkeyup="SearchValue(this,window.event.srcElement.previousSibling);" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>保留字段2</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputFREE_FIELD2" runat="server" MaxLength="200"></Com:ComTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>经费类别</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComBaseBox ID="ddlInputFUND_TYPE_ID" runat="server"></Com:ComBaseBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>对应科室年度经费表</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputREF_TAB_ID" runat="server" MaxLength="36"></Com:ComTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>是否变更新增经费</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComDropDownList ID="ddlInputIS_UPDATE_ITEM" runat="server">
                                                            </Com:ComDropDownList>
                                                            <input type="textbox" style="width: 40px;" onkeyup="SearchValue(this,window.event.srcElement.previousSibling);" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>经费金额</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputFUND_MONEY" runat="server"></Com:ComTextBox>
                                                            <asp:RegularExpressionValidator ID="revtxtInputFUND_MONEY" runat="server" ControlToValidate="txtInputFUND_MONEY"
                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>财务意见</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA" runat="server" MaxLength="500"></Com:ComTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>是否绩效考核项目</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComDropDownList ID="ddlInputIS_PERFORMANCE" runat="server">
                                                            </Com:ComDropDownList>
                                                            <input type="textbox" style="width: 40px;" onkeyup="SearchValue(this,window.event.srcElement.previousSibling);" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr></nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputITEM_NAME" runat="server" MaxLength="200"></Com:ComTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>科室负责人</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComBaseBox ID="ddlInputDEPT_USER_ID" runat="server"></Com:ComBaseBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>经费编码</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputCODE" runat="server" MaxLength="50"></Com:ComTextBox>
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
</body>
</html>
