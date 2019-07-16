<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_DEPT_PAY_YEAR_FUND_EXE_DETAIL1.aspx.cs"
    Inherits="Ipedf.Web.PageObject_BGT_B_DEPT_PAY_YEAR_FUND_EXE_DETAIL1" EnableEventValidation="false"%>

<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>BGT_D_BUDGET_ITEM</title>
	<script src="<%=ResolveClientUrl("~/scripts/xp.js") %>" type="text/javascript"></script>
	
	<link  href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet"/>
	<link  href="<%=ResolveClientUrl("~/styles/web.css") %>" type="text/css" rel="stylesheet"/>
	<script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>
	<script type="text/javascript" src="<%=ResolveClientUrl("~/scripts/gridviewscroll.js") %>"></script>
</head >
<body>
    <form id="form1" runat="server">
    <div>
        <table >
            <tr>			                                
                <td  valign="top"> 
                    <table >			
                        <tr>                            
                            <td align="left">
                               <nobr style="display:none;">预算年度:</nobr><Com:ComDropDownList ID="ddlQueryBUDGET_YEAR" runat="server" AutoPostBack="true" OnSelectedIndexChanged ="ddlQueryBUDGET_YEAR_Changed" Visible="false"></Com:ComDropDownList><nobr style="display:none;">部门:</nobr><Com:ComDropDownList ID="ddlBUDGET_DEPT_ID" Width="200" Visible="false" runat="server"></Com:ComDropDownList><asp:Button runat="server" ID="btnSearch" OnClick="OnQuery" Text="查询" Visible="false" /><asp:Button runat="server" ID="btnOut" OnClick="btnOutExcel_Click" Text="导出" />
                            </td>
                        </tr>
                        <tr>
                            <td >
                                <div style="overflow: auto; position:relative; WIDTH:100%; HEIGHT:370px" valign="top" >
                                    <ASP:GridView ID="gvList" runat="server" AutoGenerateColumns="False" BorderStyle="None" CellPadding="0" GridLines ="None"  AllowSorting="True" OnRowCreated="gvResultList_RowCreated" HeaderStyle-CssClass="GridViewScrollHeader" OnRowDataBound="OnResultGridRowDataBound" ShowFooter="false"  DbClickEdit="false" >
                                        <Columns>
                                        <asp:BoundField DataField="ZJFLB" HeaderText="经费类别" />
                                        <asp:BoundField DataField="BUDAT" HeaderText="凭证中的过帐日期" />
                                        <asp:BoundField DataField="AUFEX" HeaderText="经费代码" />
                                        <asp:BoundField DataField="ZLTEXT" HeaderText="经费代码名称" />
                                        <asp:BoundField DataField="BKTXT" HeaderText="说明" />
                                        <asp:BoundField DataField="DMBTR" HeaderText="按本位币计的金额" />
                                        </Columns>
                                        <HeaderStyle CssClass="GridViewScrollHeader"></HeaderStyle>
                                        <RowStyle CssClass="GridViewScrollItem"></RowStyle>
                                        <FooterStyle CssClass="GridViewScrollFooterFreeze"></FooterStyle> 
                                    </ASP:GridView> 
                                    <Com:ComPager runat="server" ID="pager" Visible="false" OnPageIndex_Changed="pager_PageIndex_Changed" />
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
<script type="text/javascript">
    var width = window.parent.document.body.clientWidth - 240;
    var height = window.parent.document.body.clientHeight - 300;
    //得到页面高度 
    var yScroll = (document.documentElement.scrollHeight > document.documentElement.clientHeight) ? document.documentElement.scrollHeight : document.documentElement.clientHeight;
    //alert(yScroll);
    //得到页面宽度 
    var xScroll = (document.documentElement.scrollWidth > document.documentElement.clientWidth) ? document.documentElement.scrollWidth : document.documentElement.scrollWidth;
    //alert(xScroll);
    var gridViewScroll = null;
    window.onload = function() {
        gridViewScroll = new GridViewScroll({
        elementID: "gvList",
            width: 770,
            height: 320,
            freezeColumn: false,
            freezeFooter: false,
            freezeColumnCssClass: "GridViewScrollItemFreeze",
            freezeFooterCssClass: "GridViewScrollFooterFreeze",
            freezeHeaderRowCount: 1,
            freezeColumnCount: 1
        });
        gridViewScroll.enhance();
    }
    </script>
</html>
