<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_BUDGET_CONTROL_D_EXE.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_B_BUDGET_CONTROL_D_EXE" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>BGT_B_BUDGET_CONTROL_D_EXE</title>
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
		        <td >
		            <Com:ComPageNavigator runat="server" ID="navigator" />
		        </td>
		    </tr>
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
													
							<asp:TemplateField HeaderText="执行时间">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputCREATE_DATE" runat="server" ></Com:ComTextBox><img style="cursor: hand" onclick="if(!window.event.srcElement.previousSibling.getAttribute('disabled'))setday(this,window.event.srcElement.previousSibling);" src="../../images/calender.gif" >
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="执行金额">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputMONEY" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="执行部门">
								<ItemTemplate>
									<Com:ComBaseBox ID="ddlInputBUDGET_DEPT_ID" runat="server" ></Com:ComBaseBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="财务月份">
								<ItemTemplate>
									<Com:ComFinanceCycle ID="txtInputFINANCE_CYCLE" runat="server" ></Com:ComFinanceCycle>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="申请金额">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputAPPLY_MONEY" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="可用金额">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputAVAILABLE_MONEY" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="预算科目">
								<ItemTemplate>
									<Com:ComBaseBox ID="ddlInputITEM_ID" runat="server" ></Com:ComBaseBox>
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
											
							<Com:ComDropDownList ID="ddlDataSourceBUDGET_DEPT_ID" runat="server" Visible="false"/>
							<Com:ComDropDownList ID="ddlDataSourceITEM_ID" runat="server" Visible="false"/>
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

