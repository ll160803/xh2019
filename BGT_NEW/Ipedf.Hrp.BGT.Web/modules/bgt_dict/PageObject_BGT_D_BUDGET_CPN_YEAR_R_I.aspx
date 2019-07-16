<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_D_BUDGET_CPN_YEAR_R_I.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_D_BUDGET_CPN_YEAR_R_I" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>
	<title>BGT_D_BUDGET_CPN_YEAR_R_I</title>
	
	<link  href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet"/>
	<script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>
</head >
<body topmargin="0" leftmargin="0">
    <form id="form1" runat="server">
    <div>
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
		     <tr>
	            <td><Com:ComControlBar ID="command" runat="server" HandoverState="True" /></td>          
	        </tr>
           <tr >
				<td  >
				<div id="editPannel" runat="server">
												<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">
		
													<tr>
													    <td>
                                                            <asp:LinkButton ID="lbAppend" runat="server" >添加</asp:LinkButton>
                                                        </td>
													</tr>
													<tr>
														<td >
															<div id="detailPannel" runat="server">
															<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">	
																<tr>
																	<td>
																		<Com:ComGridView ID="gvDetailList" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6" BorderWidth="1px" DbClickEdit="false">
																			<Columns>
																				<asp:BoundField DataField="ID" SortExpression="ID" Visible="False" />
																				<asp:TemplateField HeaderText="V">
																					<headertemplate>
																							<INPUT id="chkSelItem" type="checkbox" onclick="selectAll('gvDetailList');" />
																						</headertemplate>
																					<ItemTemplate>
																						<asp:CheckBox ID="cbSelect" runat="server" />
																					</ItemTemplate>
																				</asp:TemplateField>
							                                                    <asp:BoundField DataField="BUDGET_MONTH_NAME" HeaderText="预算月份" /> 													
							                                                    <asp:TemplateField HeaderText="调节比例">
								                                                    <ItemTemplate>
									                                                    <Com:ComTextBox ID="txtInputADJUST_SCALE" runat="server" ></Com:ComTextBox>
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
																		
							<Com:ComDropDownList ID="ddlDataSourceBUDGET_MONTH" runat="server" Visible="false"/>
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

