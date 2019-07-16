<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="selectdialog_budgetItem.aspx.cs" Inherits="Ipedf.Web.selectdialog_budgetItem" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>BGT_D_BUDGET_ITEM</title>
	<script src="<%=ResolveClientUrl("~/scripts/xp.js") %>" type="text/javascript"></script>
	
	<link  href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet"/>
	<script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>
</head >
<body>
    <form id="form1" runat="server">
    <div>
        <table >
            <tr>			                                
                <td  valign="top"> 
                    <table >			
                        <tr>                            
                            <td align="right">
                                <nobr>预算年度:</nobr><Com:ComDropDownList runat="server" ID="ddlInputBUDGET_YEAR"  AutoPostBack="True"  OnSelectedIndexChanged="ddlInputBUDGET_YEAR_SelectedIndexChanged"/>
                                <nobr>名称:</nobr><Com:ComTextBox runat="server" ID="txtQueryName"></Com:ComTextBox><asp:ImageButton runat="server" ID="btnSearch" ImageUrl="../images/action/zoom.gif" OnClick="btnSearch_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td >
                                <div style="overflow: auto; position:relative; WIDTH:100%; HEIGHT:370px" valign="top" >
                                     <Com:ComGridView ID="gvList" runat="server" AutoGenerateColumns="False"   BorderColor="#b5d6e6" BorderWidth="1px"   AllowSorting="True" BorderStyle="Double" OnRowDataBound="gvList_RowDataBound" DbClickEdit="false" >
                                        <Columns>                                        							                                                        <asp:BoundField DataField="ID" SortExpression="ID" Visible="False" />
							            <asp:TemplateField HeaderText="V">
								            <ItemTemplate>
									            <Com:ComGroupRadioButton id="cbSelect" runat="server" GroupName="G_SELECT" />
								            </ItemTemplate>
							            </asp:TemplateField>
							            <asp:BoundField DataField="BUDGET_YEAR_NAME" HeaderText="预算年度" /> 
							                            <asp:BoundField DataField="CODE" HeaderText="科目编码" /> 
							                            <asp:BoundField DataField="NAME" HeaderText="科目名称" /> 
							                            <asp:BoundField DataField="ITEM_TYPE_ID_NAME" HeaderText="科目类别" /> 
							                            <asp:BoundField DataField="IMPORT_TYPE_ID_NAME" HeaderText="编制方式" /> 
							                            <asp:BoundField DataField="DATA_TYPE_ID_NAME" HeaderText="数据类型" /> 
							                            <asp:BoundField DataField="USAGE_ID_NAME" HeaderText="适用范围" /> 
							                            <asp:BoundField DataField="PREPARE_PATTERN_ID_NAME" HeaderText="编制模式" /> 
							                            <asp:BoundField DataField="IS_CARRYOVER_NAME" HeaderText="是否结转" /> 
							                            <asp:BoundField DataField="IS_MERGE_NAME" HeaderText="是否合并科目" /> 
                                        </Columns>
                                        <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                        <FooterStyle CssClass="FooterStyle"></FooterStyle>                            
                                                                <RowStyle CssClass="RowStyle"></RowStyle>
                                                                <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                                <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                                <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                    </Com:ComGridView>
                                    <Com:ComPager runat="server" ID="pager" OnPageIndex_Changed="pager_PageIndex_Changed" />
                                </div>
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

