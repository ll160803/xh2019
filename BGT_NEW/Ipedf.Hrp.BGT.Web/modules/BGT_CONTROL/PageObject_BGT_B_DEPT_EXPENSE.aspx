<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_DEPT_EXPENSE.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_B_DEPT_EXPENSE" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>
	<title>BGT_B_DEPT_EXPENSE</title>
	
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
							<asp:BoundField DataField="FINANCE_CYCLE" HeaderText="财务月份" /> 		
							<asp:BoundField DataField="CODE" HeaderText="报销单号" /> 	
							<asp:BoundField DataField="APPLY_DATE" HeaderText="申请日期" DataFormatString="{0:yyyy-MM-dd}"/> 	
							<asp:BoundField DataField="APPLY_DEPT_ID_NAME" HeaderText="申请部门" /> 			
							<asp:BoundField DataField="APPLY_USER_ID_NAME" HeaderText="申请人" /> 
							<asp:BoundField DataField="APPLY_MONEY" HeaderText="申请金额" /> 
							<asp:BoundField DataField="PAY_MONEY" HeaderText="报销金额" /> 
							<asp:BoundField DataField="PAY_DATE" HeaderText="领款日期" DataFormatString="{0:yyyy-MM-dd}"/> 
							<asp:BoundField DataField="PAY_USER_ID_NAME" HeaderText="领款人" /> 
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
						<nobr>报销单号</nobr>
					</td>
					<td>
						<Com:ComCodeBox ID="txtInputCODE" runat="server" CodeSetting = "预算-费用报销单" ></Com:ComCodeBox>
					</td>
					<td >
						<nobr>财务月份</nobr>
					</td>
					<td>
						<Com:ComFinanceCycle ID="txtInputFINANCE_CYCLE" runat="server"></Com:ComFinanceCycle>
					</td>
					<td >
						<nobr>申请日期</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputAPPLY_DATE" runat="server"></Com:ComTextBox>
									<img style="cursor: hand" onclick="if(!document.getElementById('txtInputAPPLY_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtInputAPPLY_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" >
									<asp:RegularExpressionValidator ID="revtxtInputAPPLY_DATE" runat="server" ControlToValidate="txtInputAPPLY_DATE" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">请输入正确的日期</asp:RegularExpressionValidator>
					</td>
					
				</tr>
				<tr>
				    <td >
						<nobr>申请部门</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputAPPLY_DEPT_ID" runat="server" ></Com:ComBaseBox>
					</td>
					<td >
						<nobr>申请人</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputAPPLY_USER_ID" runat="server" ></Com:ComBaseBox>
					</td>					
					<td >
						<nobr>申请金额</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputAPPLY_MONEY" runat="server" Enabled="false" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputAPPLY_MONEY" runat="server" ControlToValidate="txtInputAPPLY_MONEY" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
						
				<tr>
					<td >
						<nobr>报销金额</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputPAY_MONEY" runat="server" Enabled="false" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputPAY_MONEY" runat="server" ControlToValidate="txtInputPAY_MONEY" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
					<td >
						<nobr>领款日期</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputPAY_DATE" runat="server" Enabled="false"></Com:ComTextBox>
									<img style="cursor: hand" onclick="if(!document.getElementById('txtInputPAY_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtInputPAY_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" >
									<asp:RegularExpressionValidator ID="revtxtInputPAY_DATE" runat="server" ControlToValidate="txtInputPAY_DATE" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">请输入正确的日期</asp:RegularExpressionValidator>
					</td>
					<td >
						<nobr>领款人</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputPAY_USER_ID" runat="server"  Enabled="false"></Com:ComBaseBox>
					</td>
				</tr>
				<tr>
				    <td >
						<nobr>申请事由</nobr>
					</td>
					<td colspan=7>
						<Com:ComTextBox ID="txtInputSUMARRY" runat="server" MaxLength = "200" ></Com:ComTextBox>
					</td>
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
							                                                    <asp:BoundField DataField="ITEM_ID_NAME" HeaderText="预算科目" /> 
							                                                    <asp:TemplateField HeaderText="摘要">
								                                                    <ItemTemplate>
									                                                    <Com:ComTextBox ID="txtInputSUMARRY" runat="server" ></Com:ComTextBox>
								                                                    </ItemTemplate>
							                                                    </asp:TemplateField>
							                                                    <asp:TemplateField HeaderText="申请金额">
								                                                    <ItemTemplate>
									                                                    <Com:ComTextBox ID="txtInputAPPLY_MONEY" runat="server" Width="60" ></Com:ComTextBox>
								                                                    </ItemTemplate>
							                                                    </asp:TemplateField> 
							                                                    <asp:TemplateField HeaderText="报销金额">
								                                                    <ItemTemplate>
									                                                    <Com:ComTextBox ID="txtInputPAY_MONEY" runat="server" Width="60" Enabled="false"></Com:ComTextBox>
								                                                    </ItemTemplate>
							                                                    </asp:TemplateField>     
							                                                    <asp:TemplateField HeaderText="原始凭证">
								                                                    <ItemTemplate>
									                                                    <Com:ComUpFile ID="upfile" runat="server" ></Com:ComUpFile>
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

