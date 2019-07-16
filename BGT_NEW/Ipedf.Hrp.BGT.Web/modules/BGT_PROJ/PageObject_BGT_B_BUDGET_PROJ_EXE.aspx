<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_BUDGET_PROJ_EXE.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_B_BUDGET_PROJ_EXE" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>
	<title>BGT_B_BUDGET_PROJ_EXE</title>
	
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
		        <td>
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
           <tr >
				<td  >
				<table width="100%" border="0" cellspacing="0" cellpadding="0">
				     <tr >
						<td width="8"  >&nbsp;</td>
						<td>
	                             <table width="100%" border="0" cellspacing="0" cellpadding="0">
									<tr >
										<td  >
										<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">
											<tr>
												<td>
												<asp:Label ID="lblState" runat="server" Width="500px" ></asp:Label>
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
										<td >
											<div id="resultPannel" runat="server">
												 <Com:ComGridView ID="gvResultList" runat="server" AutoGenerateColumns="False"   BorderColor="#b5d6e6" BorderWidth="1px"  AllowPaging="True"  AllowSorting="True" BorderStyle="Double"  >
													<Columns>
														<asp:TemplateField HeaderText="V">
														    <headertemplate>
                                                                    <INPUT id="chkSelItem" type="checkbox" onclick="selectAll('gvResultList');" />
                                                                </headertemplate>
														    <ItemTemplate>
															    <asp:CheckBox ID="cbSelect" runat="server" />
														    </ItemTemplate>
													    </asp:TemplateField>							    
														
							<asp:BoundField DataField="PROJECT_ID_NAME" HeaderText="预算项目" /> 
							<asp:BoundField DataField="BUDGET_YEAR_NAME" HeaderText="预算年度" /> 
							<asp:BoundField DataField="APPLY_MONEY" HeaderText="申领金额" /> 
							<asp:BoundField DataField="EXECUTE_MONEY" HeaderText="执行金额" /> 
							<asp:BoundField DataField="STATE_NAME" HeaderText="状态" /> 
													</Columns>
													<HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
													<FooterStyle CssClass="FooterStyle"></FooterStyle>                            
													<RowStyle CssClass="RowStyle"></RowStyle>
													<PagerStyle CssClass="PagerStyle"></PagerStyle>
													<SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
													<AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
												</Com:ComGridView>
												<Com:ComPager runat="server" ID="pager" />
											</div>
										</td>
									</tr>
									<tr>
										<td>
											<div id="editPannel" runat="server">
												<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">
													<tr>
														<td>
															<div id="basePannel" runat="server">
																<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">			
																	
				<tr>
					<td >
						<nobr>预算项目</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputPROJECT_ID" runat="server"   ></Com:ComBaseBox>
					</td>
					<td >
						<nobr>预算年度</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="ddlInputBUDGET_YEAR" runat="server" ReadOnly="true"></Com:ComTextBox>
					</td>
					<td >
						<nobr>申领金额</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="ddlInputAPPLY_MONEY" runat="server" ReadOnly="true"></Com:ComTextBox>
					</td>
				</tr>		
				<tr>
					<td >
						<nobr>执行金额</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="ddlInputEXECUTE_MONEY" runat="server" ReadOnly="true"></Com:ComTextBox>
					</td>
					<td colspan=4>&nbsp;</td>
				</tr>					
				
																</table>
															</div>
														</td>
													</tr>
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
																				
							
							<asp:BoundField DataField="ITEM_ID_NAME" HeaderText="项目预算明细" /> 
							<asp:TemplateField HeaderText="申领日期">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputAPPLY_DATE" runat="server" ></Com:ComTextBox><img style="cursor: hand" onclick="if(!window.event.srcElement.previousSibling.getAttribute('disabled'))setday(this,window.event.srcElement.previousSibling);" src="../../images/calender.gif" >
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="申领金额">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputAPPLY_MONEY" runat="server" Width="40"></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField> 
							<asp:TemplateField HeaderText="申领人">
								<ItemTemplate>
									<Com:ComBaseBox ID="ddlInputAPPLY_USER_ID" runat="server" ></Com:ComBaseBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="执行月份">
								<ItemTemplate>
									<Com:ComDropDownList ID="ddlInputEXECUTE_MONTH_ID" runat="server" ></Com:ComDropDownList><input type="textbox" style="width:40px;" onkeyup="SearchValue(this,document.getElementById('ddlInputEXECUTE_MONTH_ID'));" />
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="执行日期">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputEXECUTE_DATE" runat="server" ></Com:ComTextBox><img style="cursor: hand" onclick="if(!window.event.srcElement.previousSibling.getAttribute('disabled'))setday(this,window.event.srcElement.previousSibling);" src="../../images/calender.gif" >
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="执行金额">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputEXECUTE_MONEY" runat="server" Width="40"></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="发票号">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputINVOICE_CODE" runat="server" ></Com:ComTextBox>
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
																		
							<Com:ComDropDownList ID="ddlDataSourceITEM_ID" runat="server" Visible="false"/>
							<Com:ComDropDownList ID="ddlDataSourceAPPLY_USER_ID" runat="server" Visible="false"/>
							<Com:ComDropDownList ID="ddlDataSourceEXECUTE_MONTH_ID" runat="server" Visible="false"/>
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

