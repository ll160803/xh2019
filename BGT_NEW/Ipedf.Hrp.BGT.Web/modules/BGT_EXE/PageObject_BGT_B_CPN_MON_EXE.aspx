<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_CPN_MON_EXE.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_B_CPN_MON_EXE" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>
	<title>BGT_B_CPN_MON_EXE</title>
	
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
														
							<asp:BoundField DataField="BUDGET_YEAR_NAME" HeaderText="预算年度" /> 
							<asp:BoundField DataField="BUDGET_CONTENTS_ID_NAME" HeaderText="预算内容" /> 
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
						<nobr>预算年度</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputBUDGET_YEAR" runat="server" ></Com:ComBaseBox>
					</td>
					<td >
						<nobr>预算内容</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputBUDGET_CONTENTS_ID" runat="server" ></Com:ComDropDownList>
					</td>
					<td colspan=2>&nbsp;</td>
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
							<asp:BoundField DataField="ITEM_ID_NAME" HeaderText="预算指标" /> 
							<asp:BoundField DataField="UNIT_ID_NAME" HeaderText="计量单位" />  
							<asp:BoundField DataField="M_1_VALUE" HeaderText="1月指标值" /> 
							<asp:BoundField DataField="M_1_FACT_VALUE" HeaderText="1月执行值" /> 
							<asp:BoundField DataField="M_2_VALUE" HeaderText="2月指标值" /> 
							<asp:BoundField DataField="M_2_FACT_VALUE" HeaderText="2月执行值" /> 
							<asp:BoundField DataField="M_3_VALUE" HeaderText="3月指标值" /> 
							<asp:BoundField DataField="M_3_FACT_VALUE" HeaderText="3月执行值" /> 
							<asp:BoundField DataField="M_4_VALUE" HeaderText="4月指标值" /> 
							<asp:BoundField DataField="M_4_FACT_VALUE" HeaderText="4月执行值" /> 
							<asp:BoundField DataField="M_5_VALUE" HeaderText="5月指标值" /> 
							<asp:BoundField DataField="M_5_FACT_VALUE" HeaderText="5月执行值" /> 
							<asp:BoundField DataField="M_6_VALUE" HeaderText="6月指标值" /> 
							<asp:BoundField DataField="M_6_FACT_VALUE" HeaderText="6月执行值" /> 
							<asp:BoundField DataField="M_7_VALUE" HeaderText="7月指标值" /> 
							<asp:BoundField DataField="M_7_FACT_VALUE" HeaderText="7月执行值" /> 
							<asp:BoundField DataField="M_8_VALUE" HeaderText="8月指标值" /> 
							<asp:BoundField DataField="M_8_FACT_VALUE" HeaderText="8月执行值" /> 
							<asp:BoundField DataField="M_9_VALUE" HeaderText="9月指标值" /> 
							<asp:BoundField DataField="M_9_FACT_VALUE" HeaderText="9月执行值" /> 
							<asp:BoundField DataField="M_10_VALUE" HeaderText="10月指标值" /> 
							<asp:BoundField DataField="M_10_FACT_VALUE" HeaderText="10月执行值" /> 
							<asp:BoundField DataField="M_11_VALUE" HeaderText="11月指标值" /> 
							<asp:BoundField DataField="M_11_FACT_VALUE" HeaderText="11月执行值" /> 
							<asp:BoundField DataField="M_12_VALUE" HeaderText="12月指标值" /> 
							<asp:BoundField DataField="M_12_FACT_VALUE" HeaderText="12月执行值" /> 
						                  
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

