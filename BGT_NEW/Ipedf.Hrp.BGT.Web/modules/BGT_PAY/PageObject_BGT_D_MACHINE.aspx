<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_D_MACHINE.aspx.cs"
    Inherits="Ipedf.Web.PageObject_BGT_D_MACHINE" %>

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
                <td height="30">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="12" height="30">
                            </td>
                            <td>
                                <a href="../../Template/bgt/2018年新增资产（100万以上专用设备）-模板.xls" onclick="javascript:void(0);"
                                                                                target="_blank">模板下载</a> <asp:FileUpload ID="btnScan" runat="server" />
                                                                            <asp:Button ID="btnUpload" runat="server" Text="导入" Style="height: 26px"
                                                                                OnClick="btnUpload_Click" /> <asp:Button ID="btnOutExcel" runat="server" Text="导出" Style="height: 26px"
                                                                                OnClick="OnExport" /><Com:ComControlBar ID="command" runat="server" HandoverState="False" Visible="false" />
                            </td>
                            <td width="16">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="right" style="display:none;">
                    <nobr>名称:</nobr>
                    <Com:ComTextBox runat="server" ID="txtQueryKey"></Com:ComTextBox><asp:ImageButton
                        runat="server" ID="btnSearch" ImageUrl="../../images/action/zoom.gif" OnClick="OnQuery" />
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
                                            <div id="resultPannel" runat="server">
                                                <Com:ComGridView ID="gvList" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                    BorderWidth="1px" AllowPaging="True" AllowSorting="True" BorderStyle="Double"
                                                    DbClickEdit="false">
                                                    <Columns>
                                                        <asp:BoundField DataField="NO" HeaderText="序号" />
                                                        <asp:BoundField DataField="BUY" HeaderText="是否采购" />
                                                        <asp:BoundField DataField="PRICE" HeaderText="设备单价(万元)" />
                                                        <asp:BoundField DataField="NUM" HeaderText="拟购置数量" />
                                                        <asp:BoundField DataField="PROJECT" HeaderText="项目（二级）名称" />
                                                        <asp:BoundField DataField="INSTALL" HtmlEncode="false" HeaderText="是否具备安装设备的环境条件" />
                                                        <asp:BoundField DataField="MAN" HeaderText="是否具备使用设备的专业人员" />
                                                        <asp:BoundField DataField="CONDITION" HeaderText="是否具备维护设备运行的经费和条件" />
                                                        <asp:BoundField DataField="FREQUENCY" HeaderText="设备预期使用频率
（预期年度使用时长、次数/年度设计使用时长、次数）" />
<asp:BoundField DataField="SPEC" HeaderText="设备主要规格参数" />
<asp:BoundField DataField="NEED" HeaderText="购置设备的必要性" />
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
