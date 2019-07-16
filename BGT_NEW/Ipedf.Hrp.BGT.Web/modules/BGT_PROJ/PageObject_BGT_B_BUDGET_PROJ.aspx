<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_BUDGET_PROJ.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_B_BUDGET_PROJ" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>
	<title>BGT_B_BUDGET_PROJ</title>
	
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
							<asp:BoundField DataField="CODE" HeaderText="编码" /> 	
							<asp:BoundField DataField="NAME" HeaderText="名称" /> 	
							<asp:BoundField DataField="NATURE_ID_NAME" HeaderText="性质" /> 
							<asp:BoundField DataField="TYPE_ID_NAME" HeaderText="分类" /> 
							<asp:BoundField DataField="BUDGET_DEPT_ID_NAME" HeaderText="预算科室" /> 
							<asp:BoundField DataField="PROJ_USER_ID_NAME" HeaderText="负责人" /> 
							<asp:BoundField DataField="FINANCE_USER_ID_NAME" HeaderText="财务负责人" />
							<asp:BoundField DataField="BUDGET_YEAR_NAME" HeaderText="项目实施年度" /> 
							<asp:BoundField DataField="PLAN_BEGIN_DATE" HeaderText="计划开始时间" DataFormatString="{0:yyyy-MM-dd}"/>
							<asp:BoundField DataField="PLAN_END_DATE" HeaderText="计划结束时间" DataFormatString="{0:yyyy-MM-dd}"/> 
							<asp:BoundField DataField="BIZ_STATE_NAME" HeaderText="业务状态" /> 
							<asp:BoundField DataField="IS_GOV_PROC_NAME" HeaderText="是否政府采购" /> 
							<asp:BoundField DataField="APPLY_MONEY" HeaderText="申报金额" /> 
							<asp:BoundField DataField="REPLY_MONEY" HeaderText="批复金额" /> 
							<asp:BoundField DataField="ADJUST_MONEY" HeaderText="调整金额" /> 
							<asp:BoundField DataField="AVAILABLE_MONEY" HeaderText="可用金额" /> 
							<asp:BoundField DataField="APPLIED_MONEY" HeaderText="已申领金额" /> 
							<asp:BoundField DataField="EXECUTED_MONEY" HeaderText="已执行金额" /> 
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
						<nobr><span style="color:Red">编码</span></nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputCODE" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
					<td >
						<nobr><span style="color:Red">名称</span></nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputNAME" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
					<td >
						<nobr>目的</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputPURPOSE" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					
				    <td >
						<nobr><span style="color:Red">分类</span></nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputTYPE_ID" runat="server" ></Com:ComDropDownList>
					</td>
					<td >
						<nobr><span style="color:Red">性质</span></nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputNATURE_ID" runat="server" ></Com:ComDropDownList>
					</td>
					  <td >
						<nobr><span style="color:Red">业务状态</span></nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputBIZ_STATE" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>				  
					<td >
						<nobr>背景</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputBACKDROP" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
					<td >
						<nobr>是否政府采购</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputIS_GOV_PROC" runat="server" ></Com:ComDropDownList><input type="textbox" style="width:40px;" onkeyup="SearchValue(this,window.event.srcElement.previousSibling);" />
					</td>
					<td colspan=2>&nbsp;</td>
				</tr>
				<tr>				    
					<td >
						<nobr>项目实施年度</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputBUDGET_YEAR" runat="server" ></Com:ComDropDownList>
					</td>	
					
					<td >
						<nobr>计划开始时间</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputPLAN_BEGIN_DATE" runat="server"></Com:ComTextBox>
									<img style="cursor: hand" onclick="if(!document.getElementById('txtInputPLAN_BEGIN_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtInputPLAN_BEGIN_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" >
									<asp:RegularExpressionValidator ID="revtxtInputPLAN_BEGIN_DATE" runat="server" ControlToValidate="txtInputPLAN_BEGIN_DATE" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">请输入正确的日期</asp:RegularExpressionValidator>
					</td>
					<td >
						<nobr>计划结束时间</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputPLAN_END_DATE" runat="server"></Com:ComTextBox>
									<img style="cursor: hand" onclick="if(!document.getElementById('txtInputPLAN_END_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtInputPLAN_END_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" >
									<asp:RegularExpressionValidator ID="revtxtInputPLAN_END_DATE" runat="server" ControlToValidate="txtInputPLAN_END_DATE" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">请输入正确的日期</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
				    <td >
						<nobr>预算科室</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputBUDGET_DEPT_ID" runat="server" ></Com:ComBaseBox>
					</td>
					<td >
						<nobr>负责人</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputPROJ_USER_ID" runat="server" ></Com:ComBaseBox>
					</td>
				    <td >
						<nobr>财务负责人</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputFINANCE_USER_ID" runat="server" ></Com:ComBaseBox>
					</td>
									
				</tr>
				<tr>
				    
					 <td >
						<nobr>申报人</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputAPPLY_USER_ID" runat="server" ></Com:ComBaseBox>
					</td>
					<td >
						<nobr>申报时间</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputAPPLY_DATE" runat="server"></Com:ComTextBox>
									<img style="cursor: hand" onclick="if(!document.getElementById('txtInputAPPLY_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtInputAPPLY_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" >
									<asp:RegularExpressionValidator ID="revtxtInputAPPLY_DATE" runat="server" ControlToValidate="txtInputAPPLY_DATE" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">请输入正确的日期</asp:RegularExpressionValidator>
					</td>
					
				    <td >
						<nobr>申报金额</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputAPPLY_MONEY" runat="server" ReadOnly="true" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputAPPLY_MONEY" runat="server" ControlToValidate="txtInputAPPLY_MONEY" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				   				
				</tr>				
				<tr>
				   
					<td >
						<nobr>批复人</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputREPLY_USER_ID" runat="server" ></Com:ComBaseBox>
					</td>
					<td >
						<nobr>批复日期</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputREPLY_DATE" runat="server"></Com:ComTextBox>
									<img style="cursor: hand" onclick="if(!document.getElementById('txtInputREPLY_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtInputREPLY_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" >
									<asp:RegularExpressionValidator ID="revtxtInputREPLY_DATE" runat="server" ControlToValidate="txtInputREPLY_DATE" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">请输入正确的日期</asp:RegularExpressionValidator>
					</td>	
					 <td >
						<nobr>批复金额</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputREPLY_MONEY" runat="server" ReadOnly="true"></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputREPLY_MONEY" runat="server" ControlToValidate="txtInputREPLY_MONEY" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>				
				</tr>
				
				
			
																</table>
															</div>
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
																				
							<asp:TemplateField HeaderText="编号">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputCODE" runat="server" Width="30" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="名称">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputNAME" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="预算科目">
								<ItemTemplate>
									<Com:ComBaseBox ID="ddlInputITEM_ID" runat="server" ></Com:ComBaseBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="资金来源">
								<ItemTemplate>
									<Com:ComDropDownList ID="ddlInputSOURCE_ID" runat="server" ></Com:ComDropDownList><input type="textbox" style="width:40px;" onkeyup="SearchValue(this,document.getElementById('ddlInputSOURCE_ID'));" />
								</ItemTemplate>
							</asp:TemplateField>   
							<asp:TemplateField HeaderText="资金额度">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputBUDEGT_MONEY" runat="server" Width="40" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="申报金额">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputAPPLY_MONEY" runat="server" Width="40" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="批复金额">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputREPLY_MONEY" runat="server" Width="40" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="是否政府采购">
								<ItemTemplate>
									<Com:ComDropDownList ID="ddlInputIS_GOV_PROC" runat="server" Width="40" ></Com:ComDropDownList>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:BoundField DataField="ADJUST_MONEY" HeaderText="调整金额" />
							<asp:BoundField DataField="APPLIED_MONEY" HeaderText="已申领金额" /> 
							<asp:BoundField DataField="EXECUTED_MONEY" HeaderText="已执行金额" />
																			</Columns>
																			<HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
																			<FooterStyle CssClass="FooterStyle"></FooterStyle>                            
																			<RowStyle CssClass="RowStyle"></RowStyle>
																			<PagerStyle CssClass="PagerStyle"></PagerStyle>
																			<SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
																			<AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
																		</Com:ComGridView>
																		
							<Com:ComDropDownList ID="ddlDataSourceITEM_ID" runat="server" Visible="false"/>
							<Com:ComDropDownList ID="ddlDataSourceIS_GOV_PROC" runat="server" Visible="false"/>
							<Com:ComDropDownList ID="ddlDataSourceSOURCE_ID" runat="server" Visible="false"/>
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

