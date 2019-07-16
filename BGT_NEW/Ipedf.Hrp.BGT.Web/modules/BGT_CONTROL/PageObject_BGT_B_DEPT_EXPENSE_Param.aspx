<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_DEPT_EXPENSE_Param.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_B_DEPT_EXPENSE_Param" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>BGT_B_DEPT_EXPENSE</title>
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
	                        <td><Com:ComControlBar ID="command" runat="server" HandoverState="False" /></td>
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
										<td >
											<div >
												<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">							
													
							<tr>
								<td>
									<nobr>申请人</nobr>
								</td>
								<td>
									<Com:ComBaseBox ID="ddlQueryAPPLY_USER_ID" runat="server" ></Com:ComBaseBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>申请日期</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryBEGINAPPLY_DATE" runat="server"></Com:ComTextBox>
									<img style="cursor: hand" onclick="if(!document.getElementById('txtQueryBEGINAPPLY_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtQueryBEGINAPPLY_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" >
									<asp:RegularExpressionValidator ID="revtxtQueryBEGINAPPLY_DATE" runat="server" ControlToValidate="txtQueryBEGINAPPLY_DATE" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">请输入正确的日期</asp:RegularExpressionValidator>
									~
									<Com:ComTextBox ID="txtQueryENDAPPLY_DATE" runat="server"></Com:ComTextBox>
									<img style="cursor: hand" onclick="if(!document.getElementById('txtQueryENDAPPLY_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtQueryENDAPPLY_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" >
									<asp:RegularExpressionValidator ID="revtxtQueryENDAPPLY_DATE" runat="server" ControlToValidate="txtQueryENDAPPLY_DATE" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">请输入正确的日期</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>申请事由</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQuerySUMARRY" runat="server" MaxLength = "200" ></Com:ComTextBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>领款日期</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryBEGINPAY_DATE" runat="server"></Com:ComTextBox>
									<img style="cursor: hand" onclick="if(!document.getElementById('txtQueryBEGINPAY_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtQueryBEGINPAY_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" >
									<asp:RegularExpressionValidator ID="revtxtQueryBEGINPAY_DATE" runat="server" ControlToValidate="txtQueryBEGINPAY_DATE" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">请输入正确的日期</asp:RegularExpressionValidator>
									~
									<Com:ComTextBox ID="txtQueryENDPAY_DATE" runat="server"></Com:ComTextBox>
									<img style="cursor: hand" onclick="if(!document.getElementById('txtQueryENDPAY_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtQueryENDPAY_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" >
									<asp:RegularExpressionValidator ID="revtxtQueryENDPAY_DATE" runat="server" ControlToValidate="txtQueryENDPAY_DATE" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">请输入正确的日期</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>报销单号</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryCODE" runat="server" MaxLength = "50" ></Com:ComTextBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>申请部门</nobr>
								</td>
								<td>
									<Com:ComBaseBox ID="ddlQueryAPPLY_DEPT_ID" runat="server" ></Com:ComBaseBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>报销金额</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryPAY_MONEY" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryPAY_MONEY" runat="server" ControlToValidate="txtQueryPAY_MONEY" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>领款人</nobr>
								</td>
								<td>
									<Com:ComBaseBox ID="ddlQueryPAY_USER_ID" runat="server" ></Com:ComBaseBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>申请金额</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryAPPLY_MONEY" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryAPPLY_MONEY" runat="server" ControlToValidate="txtQueryAPPLY_MONEY" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>财务月份</nobr>
								</td>
								<td>
									<Com:ComFinanceCycle ID="txtQueryFINANCE_CYCLE" runat="server" MaxLength = "50" ></Com:ComFinanceCycle>
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

