<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_D_BUDGET_PATTERN.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_D_BUDGET_PATTERN" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>BGT_D_BUDGET_PATTERN</title>
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
	        <tr>
	            <td>
	                <table width="100%" border="0" cellspacing="0" cellpadding="0">
	                    <tr>
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
												 <Com:ComGridView ID="gvList" runat="server" AutoGenerateColumns="False"   BorderColor="#b5d6e6" BorderWidth="1px"  AllowPaging="True"  AllowSorting="True" BorderStyle="Double" >
													<Columns>
														<asp:TemplateField HeaderText="V">
														    <headertemplate>
                                                                    <INPUT id="chkSelItem" type="checkbox" onclick="selectAll('gvList');" />
                                                                </headertemplate>
														    <ItemTemplate>
															    <asp:CheckBox ID="cbSelect" runat="server" />
														    </ItemTemplate>
													    </asp:TemplateField>
														
							<asp:BoundField DataField="BUDGET_YEAR_NAME" HeaderText="预算年度" /> 
							<asp:BoundField DataField="IS_INTERNAL_NAME" HeaderText="是否部门预算" /> 
							<asp:BoundField DataField="PAY_PATTERN_ID_NAME" HeaderText="支出预算编制模式" /> 
							<asp:BoundField DataField="PAY_LEVEL_ID_NAME" HeaderText="支出预算编制层次" /> 
							<asp:BoundField DataField="IS_PAY_ITEM_MERGE_NAME" HeaderText="支出科目是否合并" /> 
							<asp:BoundField DataField="INCOME_LEVEL_ID_NAME" HeaderText="收入预算编制层次" /> 
							<asp:BoundField DataField="INCOME_PATTERN_ID_NAME" HeaderText="收入预算编制模式" /> 
							<asp:BoundField DataField="PAY_PATTERN_ENTRY_ID_NAME" HeaderText="支出预算自下而上编制起点" /> 
							<asp:BoundField DataField="PLAN_PATTERN_ID_NAME" HeaderText="业务预算编制模式" />
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
										<td >
											<div id="editPannel" runat="server">
												<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">			
													
				<tr>
					<td >
						<nobr><span style="color:red">预算年度</span></nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputBUDGET_YEAR" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>是否部门预算</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputIS_INTERNAL" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr><span style="color:red">业务预算编制模式</span></nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputPLAN_PATTERN_ID" runat="server" Enabled="false" ></Com:ComDropDownList>
					</td>
				</tr>	
				<tr>
					<td >
						<nobr><span style="color:red">收入预算编制模式</span></nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputINCOME_PATTERN_ID" runat="server" Enabled="false" ></Com:ComDropDownList>
					</td>
				</tr>		
				<tr>
					<td >
						<nobr>收入预算编制层次</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputINCOME_LEVEL_ID" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr><span style="color:red">支出预算编制模式</span></nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputPAY_PATTERN_ID" runat="server" Enabled="false" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>支出预算编制层次</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputPAY_LEVEL_ID" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>支出预算自下而上编制起点</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputPAY_PATTERN_ENTRY_ID" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>	
				<tr>
					<td >
						<nobr>支出科目是否合并</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputIS_PAY_ITEM_MERGE" runat="server" ></Com:ComDropDownList><input type="textbox" style="width:40px;" onkeyup="SearchValue(this,window.event.srcElement.previousSibling);" />
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

