<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_DEPT_PAY_YEAY_D_FUND.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_B_DEPT_PAY_YEAY_D_FUND" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>BGT_B_DEPT_PAY_YEAY_D_FUND</title>
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
														
							<asp:BoundField DataField="DECLARE_CAUSE" HeaderText="依据说明" /> 
							<asp:BoundField DataField="ASSET_ID" HeaderText="设备ID" /> 
							<asp:BoundField DataField="MONEY" HeaderText="申请金额" /> 
							<asp:BoundField DataField="FUND_NAME" HeaderText="一般经费名称" /> 
							<asp:BoundField DataField="AMOUNT" HeaderText="设备数量" /> 
							<asp:BoundField DataField="PRICE" HeaderText="设备单价" /> 
							<asp:BoundField DataField="COMPLETE_TIME" HeaderText="计划完成时间" DataFormatString="{0:yyyy-MM-dd}"/> 
							<asp:BoundField DataField="ASSET_NAME" HeaderText="设备名称" /> 
							<asp:BoundField DataField="BUILDING_NAME" HeaderText="建筑名称" /> 
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
						<nobr>依据说明</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputDECLARE_CAUSE" runat="server" MaxLength = "200" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>设备ID</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputASSET_ID" runat="server" MaxLength = "36" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>申请金额</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputMONEY" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputMONEY" runat="server" ControlToValidate="txtInputMONEY" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>一般经费名称</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputFUND_NAME" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>设备数量</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputAMOUNT" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputAMOUNT" runat="server" ControlToValidate="txtInputAMOUNT" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>设备单价</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputPRICE" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputPRICE" runat="server" ControlToValidate="txtInputPRICE" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>计划完成时间</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputCOMPLETE_TIME" runat="server"></Com:ComTextBox>
									<img style="cursor: hand" onclick="if(!document.getElementById('txtInputCOMPLETE_TIME').getAttribute('disabled'))setday(this,document.getElementById('txtInputCOMPLETE_TIME'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" >
									<asp:RegularExpressionValidator ID="revtxtInputCOMPLETE_TIME" runat="server" ControlToValidate="txtInputCOMPLETE_TIME" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">请输入正确的日期</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>设备名称</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputASSET_NAME" runat="server" MaxLength = "100" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>建筑名称</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputBUILDING_NAME" runat="server" MaxLength = "100" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>一般经费名称</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputACCOUNT_ITEM_ID" runat="server" ></Com:ComBaseBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>应归属经济分类</nobr>
					</td>
					<td>
						<Com:ComBaseBox ID="ddlInputBGT_D_ACCOUNT_ITEM_ID" runat="server" ></Com:ComBaseBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>财务意见</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputFINANCE_IDEA" runat="server" MaxLength = "500" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>保留字段3</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputFREE_FIELD3" runat="server" MaxLength = "10" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>保留字段</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputFREE_FIELD" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>保留字段2</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputFREE_FIELD2" runat="server" MaxLength = "200" ></Com:ComTextBox>
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

