<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_D_BUDGET_DEPT_USER.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_D_BUDGET_DEPT_USER" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>BGT_D_BUDGET_DEPT_USER</title>
	<script src="<%=ResolveClientUrl("~/scripts/xp.js") %>" type="text/javascript"></script>
	
	<link  href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet"/>
	<script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>
</head>
<body topmargin="0" leftmargin="0">
    <form id="form1" runat="server">
    <div>
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
		    <tr>
	            <td height="30" >
	                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="12" height="30"></td>
	                        <td><Com:ComControlBar ID="command" runat="server" HandoverState="True" /></td>
	                        <td width="16"></td>
                        </tr>
                    </table>
	            </td>	               
	        </tr>    
			<tr>
	            <td>
	                <table width="100%" border="0" cellspacing="0" cellpadding="0">
	                    <tr>
	                        <td width="8"  >&nbsp;</td>
	                        <td>
	                            <table width="100%" border="0" cellspacing="0" cellpadding="0">        
									<tr>
										<td>
											 <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">
											    <tr>
												    <td>
														<asp:Label ID="lblState" runat="server" Width="500px" ></asp:Label>
												    </td>
											    </tr>
										    </table>
										 </td>
									</tr>
									<tr>
									    <td><asp:LinkButton ID="lbAppend" runat="server" >Ìí¼Ó</asp:LinkButton></td>
									</tr>
									<tr>
										<td >
											<Com:ComGridView ID="gvList" runat="server" AutoGenerateColumns="False"   BorderColor="#b5d6e6" BorderWidth="1px"   BorderStyle="Double" DbClickEdit="false">
												<Columns>
													<asp:TemplateField HeaderText="V">
														<headertemplate>
                                                                <INPUT id="chkSelItem" type="checkbox" onclick="selectAll('gvList');" />
                                                            </headertemplate>
														<ItemTemplate>
															<asp:CheckBox ID="cbSelect" runat="server" />
														</ItemTemplate>
													</asp:TemplateField>
													
							<asp:BoundField DataField="USER_ID_NAME" HeaderText="ÓÃ»§" />      
												</Columns>
												<HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
												<FooterStyle CssClass="FooterStyle"></FooterStyle>                            
												<RowStyle CssClass="RowStyle"></RowStyle>
												<PagerStyle CssClass="PagerStyle"></PagerStyle>
												<SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
												<AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
											</Com:ComGridView>
											
							<Com:ComDropDownList ID="ddlDataSourceUSER_ID" runat="server" Visible="false"/>
										</td>
									</tr>
								</table>
	                        </td>
	                        <td width="8"  >&nbsp;</td>
	                    </tr>
	                </table>
	            </td>
	        </tr>	
            <tr>
	            <td height="35" >
	                <table width="100%" border="0" cellspacing="0" cellpadding="0">
	                    <tr>
	                        <td width="12" height="35"></td>
	                        <td >&nbsp;</td>   
	                        <td width="16"></td>   
	                    </tr>
	                </table>
	            </td>
	        </tr>	
        </table>
    </div>
    </form>
</body>
</html>

