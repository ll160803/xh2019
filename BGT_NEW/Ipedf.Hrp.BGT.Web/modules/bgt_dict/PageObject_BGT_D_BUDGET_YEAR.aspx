<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_D_BUDGET_YEAR.aspx.cs"
    Inherits="Ipedf.Web.PageObject_BGT_D_BUDGET_YEAR" %>

<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="Generator" content="Ipedf" />
    <meta name="Author" content="http://www.itabby.com" />
    <meta name="Keywords" content="http://www.itabby.com" />
    <meta name="Description" content="" />
    <title>BGT_D_BUDGET_YEAR</title>

    <script src="<%=ResolveClientUrl("~/scripts/xp.js") %>" type="text/javascript"></script>

    <link href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet" />

    <script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>

   <style>
		.flow-wrapper h4,.flow-wrapper h4,.flow-wrapper ol,.flow-wrapper ul,.flow-wrapper li,.flow-wrapper div,.flow-wrapper span,.flow-wrapper p{
			margin: 0;
			padding: 0;
			border: 0;
			font-size: 100%;
			font: inherit;
			/*vertical-align: baseline;*/
		}
		.flow-wrapper {
			line-height: 1;
			font-family: "Microsoft Yahei";
		}
		ol, ul {
			list-style: none;
		}
		.flow-wrapper{
			margin:10px;
		}
		.flow-one{
			width: 100px;
		}
		.flow-li h4 {
            padding: 5px 10px;
            border: 1px solid #aaa;
        }
        .flow-li p ,.flow-li span{
		    font-size: 40px;color: #aaa;
		    text-align: center;vertical-align: middle;
		}
		.flow-two{
			width: 400px;
		}
		.flow-two li,.flow-three li,.flow-two li h4,.flow-three li h4{
			display: inline-block;
		}
		.flow-three{
			width: 700px;
		}
		.flow-three p{
			width: 100px;margin-bottom: 4px;margin-top: -3px;
		}
		.flow-three li {
		    margin-top: -3px;
		}
		.flow-down{
			width: 544px;
		    height: 30px;
		    border: 4px solid #aaa;
		    margin-left: 44px;
		    margin-bottom: 0;
		    border-top-width: 0;
		    border-right-width: 0;
		}
		.flow-li .flow-node-active{
			    border-color: #00ACC1;background: #00ACC1;color: #fff;
		}
		h4 button{
			cursor:pointer; border: 1px solid #AED581; color: #008000;background: #eee;
		}
		h4 button:hover{
			background: #4DB6AC;color: #fff;
		}
	</style>

    <script type="text/javascript" charset="utf-8">
        function changeFlowIndex(index) { //index 从一开始计算的流程顺序号
            var _h = document.getElementsByClassName("flow-node");
            if (_h.length >= index) {
                var _elm = _h[--index];
                _elm.className = _elm.className + " flow-node-active";
            }
        }
        changeFlowIndex(2);
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
                                                        <asp:BoundField DataField="BUDGET_YEAR" HeaderText="预算年度" />
                                                        <asp:BoundField DataField="IS_AVAILABE_NAME" HeaderText="预算阶段" />
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
                                                            <nobr><span style="color:Red">预算年度</span></nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComTextBox ID="txtInputBUDGET_YEAR" runat="server" MaxLength="50"></Com:ComTextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <nobr>预算阶段</nobr>
                                                        </td>
                                                        <td>
                                                            <Com:ComDropDownList ID="ddlInputIS_AVAILABE" Enabled="false" runat="server">
                                                            </Com:ComDropDownList>
                                                            <input type="textbox" style="width: 40px;" onkeyup="SearchValue(this,window.event.srcElement.previousSibling);" />
                                                        </td>
                                                    </tr>
                                                </table>
                                                <div id="divControl" visible="false" runat="server">
                                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                                    <div id="flowImg" class="flow-wrapper">
                                                        <ul>
                                                            <li class="flow-li flow-one">
                                                                <h4 class="flow-node">
                                                                    预算系统</h4>
                                                                <p>
                                                                    &darr;</p>
                                                            </li>
                                                            <li class="flow-li flow-two">
                                                                <ol>
                                                                    <li>
                                                                        <h4 class="flow-node">
                                                                            编制阶段</h4>
                                                                        <span>&rarr;</span> </li>
                                                                    <li>
                                                                        <h4 class="flow-node">
                                                                            执行阶段</h4>
                                                                        <span>&rarr;</span> </li>
                                                                    <li>
                                                                        <h4 class="flow-node">
                                                                            <asp:Button ID="btnDone" runat="server" Text="归档" OnClick="btnDone_Click" /></h4>
                                                                    </li>
                                                                </ol>
                                                            </li>
                                                            <li class="flow-li flow-three">
                                                                <p>
                                                                    &darr;</p>
                                                                <ol>
                                                                    <li>
                                                                        <h4 class="flow-node">
                                                                            <asp:Button ID="btnStart" runat="server" Text="开始申报" OnClientClick="return confirm('你确定执行此操作吗？');" OnClick="btnStart_Click" /></h4>
                                                                        <span>&rarr;</span> </li>
                                                                    <li>
                                                                        <h4 class="flow-node">
                                                                            <asp:Button ID="btnFrUp" runat="server" Text="一上完成" OnClientClick="return confirm('你确定执行此操作吗？');" OnClick="btnFrUp_Click" /></h4>
                                                                        <span>&rarr;</span> </li>
                                                                    <li>
                                                                        <h4 class="flow-node">
                                                                            <asp:Button ID="btnScStart" runat="server" Text="二上开始" OnClientClick="return confirm('你确定执行此操作吗？');" OnClick="btnScStart_Click" /></h4>
                                                                        <span>&rarr;</span> </li>
                                                                    <li>
                                                                        <h4 class="flow-node">
                                                                            <asp:Button ID="btnScDone" runat="server" Text="二上完成" OnClientClick="return confirm('你确定执行此操作吗？');" OnClick="btnScDone_Click" /></h4>
                                                                        <span>&rarr;</span> </li>
                                                                    <li>
                                                                        <h4 class="flow-node">
                                                                            <asp:Button ID="btnExe" runat="server" Text="开始执行" OnClientClick="return confirm('你确定执行此操作吗？');" OnClick="btnExe_Click" /></h4>
                                                                    </li>
                                                                </ol>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                    <div>
                                                        <p>
                                                            可以单独设置每个科室的权限</p>
                                                        <asp:CheckBoxList ID="CheckBoxList_Dept" runat="server" RepeatColumns="5" RepeatDirection="Horizontal">
                                                        </asp:CheckBoxList>
                                                    </div>
                                                    <div>
                                                        <asp:Button ID="btnSave" runat="server" Width="60" Height="30" Text="保存" OnClick="btnSave_Click" /></div>
                                                </div>
                                                <p style="color: Red">
                                                    点击“一上完成阶段”按钮，则所有预算科室只有只读权限。如果需要单独放开一个或某几个科室的权限，则需要在预算部门管理设置。</p>
                                                <p style="color: Red">
                                                    点击“二上开始阶段”按钮，则所有预算科室开始二上申报。</p>
                                                <p style="color: Red">
                                                    点击“二上完成阶段”，则所有科室只有只读权限。如果需要单独放开一个或某几个科室的权限，则需要在预算部门管理设置。</p>
                                                <p style="color: Red">
                                                    点击“执行阶段”，则所有科室只有只读权限。</p>
                                            </div>
    </div>
    </td> </tr> </table> </td>
    <td width="8">
        &nbsp;
    </td>
    </tr> </table> </td> </tr>
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
    </table> </div>
    </form>
</body>
</html>
