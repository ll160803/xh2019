<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_DEPT_PAY_YEAR_FUND_SF2.aspx.cs"
    Inherits="Ipedf.Web.PageObject_BGT_B_DEPT_PAY_YEAR_FUND_SF2" %>

<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<%@ Register Assembly="Ipedf.Hrp.BGT.Web.Control" Namespace="Ipedf.Hrp.BGT.Web.Control"
    TagPrefix="BGT" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta name="Generator" content="Ipedf" />
    <meta name="Author" content="http://www.itabby.com" />
    <meta name="Keywords" content="http://www.itabby.com" />
    <meta name="Description" content="" />
    <title>BGT_B_DEPT_PAY_YEAR_FUND</title>
    <link href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet" />

    <script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>
<script type="text/javascript">
    function ClientFun(comBaseId, row) {//comBaseId 控件ID，row所选ComBaseBox的行值 是对象 row.NAME,row.ID
        $("#ddlInputDEPT_USER_ID").val(row.HEADNAME);

    }
    function ClientCode(comBaseId, row) {//comBaseId 控件ID，row所选ComBaseBox的行值 是对象 row.NAME,row.ID

        $("#txtInputCODE").val(row.CODE);
        $("#txtInputCODE_H").val(row.CODE);
    }
        
    </script>
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
                                                          <Com:ComBaseBox ID="ddlBUDGET_DEPT_ID" runat="server"></Com:ComBaseBox>
                                                        &nbsp;<asp:Button runat="server" ID="btnSearch" Text="查询" OnClick="OnQuery" />
                                                        &nbsp;<asp:Button runat="server" ID="btnExport" Text="导出" OnClick="OnExport" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div id="resultPannel" runat="server">
                                                <BGT:BGTComGridView ID="gvResultList" runat="server" AutoGenerateColumns="False"
                                                    BorderColor="#b5d6e6" BorderWidth="1px" AllowPaging="True" AllowSorting="True"
                                                    BorderStyle="Double" ShowFooter="True">
                                                    <Columns>
                                                        <asp:TemplateField HeaderText="V">
                                                            <HeaderTemplate>
                                                                <input id="chkSelItem" type="checkbox" onclick="selectAll('gvResultList');" />
                                                            </HeaderTemplate>
                                                            <ItemTemplate>
                                                                <asp:CheckBox ID="cbSelect" runat="server" />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:BoundField DataField="BUDGET_YEAR_NAME" HeaderText="申请年度" />
                                                        <asp:BoundField DataField="BUDGET_DEPT_ID_NAME" HeaderText="预算科室" />
                                                        <asp:BoundField DataField="DEPT_USER_ID" HeaderText="科室负责人" />
                                                        <asp:BoundField DataField="BGT_D_BUDGET_ITEM_ID_NAME" HeaderText="经费名称" />
                                                        <asp:BoundField DataField="CODE" HeaderText="经费代码" />
                                                        <asp:BoundField DataField="IS_PERFORMANCE_NAME" HeaderText="是否为绩效考核项目" />
                                                        <asp:BoundField DataField="IS_FIXED_NAME" HeaderText="是否为刚性预算" />
                                                        <asp:BoundField DataField="FUND_MONEY" HeaderText="经费金额" />
                                                        <asp:BoundField DataField="CONTROL_MONEY" ControlStyle-ForeColor="Red" ItemStyle-ForeColor="Red"  HeaderText="控制数" />
                                                        <asp:BoundField DataField="FUND_TYPE_ID_NAME" HeaderText="经费类别" />
                                                        <asp:BoundField DataField="STATE_NAME" HeaderText="状态" />
                                                        <asp:BoundField DataField="IS_ATTACH" HeaderText="是否上传附件" />
                                                    </Columns>
                                                    <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                                    <FooterStyle CssClass="FooterStyle"></FooterStyle>
                                                    <RowStyle CssClass="RowStyle"></RowStyle>
                                                    <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                    <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                    <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                                </BGT:BGTComGridView>
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
                                                            <div id="basePannel" runat="server">
                                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                                    cellpadding="0">
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>预算科室</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComBaseBox ID="ddlInputBUDGET_DEPT_ID" runat="server"></Com:ComBaseBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>部门负责人</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="ddlInputDEPT_USER_ID"  runat="server"></Com:ComTextBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>申请年度</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComDropDownList ID="ddlInputBUDGET_YEAR" Enabled="false" runat="server">
                                                                            </Com:ComDropDownList>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>经费名称</nobr>
                                                                        </td>
                                                                        <td colspan="3">
                                                                            <Com:ComBaseBox ID="ddlInputBGT_D_BUDGET_ITEM_ID"  Width="80%" runat="server">
                                                                            </Com:ComBaseBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>经费类别</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="ddlInputFUND_TYPE_ID" runat="server" Enabled="false">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>经费金额</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputFUND_MONEY" runat="server" Enabled="false">
                                                                            </Com:ComTextBox>
                                                                            <asp:RegularExpressionValidator ID="revtxtInputFUND_MONEY" runat="server" ControlToValidate="txtInputFUND_MONEY"
                                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>核定数</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputCONTROL_MONEY" runat="server" >
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>经费编码</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputCODE" Enabled="false" runat="server" MaxLength="50">
                                                                            </Com:ComTextBox>
                                                                            <asp:HiddenField ID="txtInputCODE_H" runat="server" />
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>绩效考核</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComDropDownList ID="ddlInputIS_PERFORMANCE"  runat="server">
                                                                            </Com:ComDropDownList>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>刚性预算</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComDropDownList ID="ddlInputIS_FIXED"   runat="server">
                                                                            </Com:ComDropDownList>
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>申请说明</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputDECALRE_CAUSE"  TextMode="MultiLine" Columns="20"
                                                                                Rows="2" Width="96%" Height="35px" Font-Size="12px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>预算工作委员会办公室意见</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA2" Enabled="false" TextMode="MultiLine" Columns="20" Rows="2"
                                                                                Width="96%" Height="35px" Font-Size="12px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="6">
                                                                            <Com:ComUpFile ID="upFiles"   runat="server"></Com:ComUpFile>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <div id="detailPannel" runat="server">
                                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                                    cellpadding="0">
                                                                    <tr>
                                                                        <td>
                                                                            <Com:ComGridView ID="gvDetailList" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                                                BorderWidth="1px" DbClickEdit="false">
                                                                                <Columns>
                                                                                    <asp:BoundField DataField="ID" SortExpression="ID" Visible="False" />
                                                                                    <asp:TemplateField HeaderText="V">
                                                                                        <HeaderTemplate>
                                                                                            <input id="chkSelItem" type="checkbox" onclick="selectAll('gvDetailList');" />
                                                                                        </HeaderTemplate>
                                                                                        <ItemTemplate>
                                                                                            <asp:CheckBox ID="cbSelect" runat="server" />
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                     <asp:BoundField DataField="F_BUILDING_NAME"  HeaderText="核定支出内容" />
                                                                                    <asp:BoundField DataField="F_MONEY"  HeaderText="核定金额" />
                                                                                     <asp:BoundField DataField="F_COMPLETE_TIME"  HeaderText="核定计划完成时间" />
                                                                                    <asp:BoundField DataField="F_DECLARE_CAUSE"  HeaderText="核定依据说明" />
                                                                                    <asp:TemplateField HeaderText="支出内容">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputBUILDING_NAME" TextMode="MultiLine" Font-Size="12px"
                                                                                                Columns="20" Rows="10" Width="96%" Height="35px" runat="server"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="计划支出金额">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputMONEY" Width="80"  runat="server"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="计划完成时间">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputCOMPLETE_TIME" Width="80"  runat="server"></Com:ComTextBox><img
                                                                                                style="cursor: hand" onclick="tableClick(this)" src="../../images/calender.gif">
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="依据说明">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputDECLARE_CAUSE"  TextMode="MultiLine" Font-Size="12px"
                                                                                                Columns="20" Rows="10" Width="96%" Height="35px" runat="server"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="预算工作委员会办公室核定数" Visible="false">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtCONTROL_MONEY" Enabled="false" runat="server"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="预算工作委员会办公室意见" Visible="false">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA" Enabled="false" TextMode="MultiLine" Font-Size="12px" Columns="20"
                                                                                                Rows="10" Width="96%" Height="35px" runat="server"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                </Columns>
                                                                                <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                                                                <FooterStyle CssClass="FooterStyle"></FooterStyle>
                                                                                <RowStyle CssClass="RowStyle"></RowStyle>
                                                                                <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                                                <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                                                <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                                                            </Com:ComGridView>
                                                                            <Com:ComDropDownList ID="ddlDataSourceACCOUNT_ITEM_ID" runat="server" Visible="false" />
                                                                            <Com:ComDropDownList ID="ddlDataSourceBGT_D_ACCOUNT_ITEM_ID" runat="server" Visible="false" />
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </div>
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
