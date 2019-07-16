<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_V_BGT_DEPT_BUDGET_DATA_PROCESS_Param.aspx.cs" Inherits="Ipedf.Web.PageObject_V_BGT_DEPT_BUDGET_DATA_PROCESS_Param" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>V_BGT_DEPT_BUDGET_DATA_PROCESS</title>
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
									<nobr></nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryDEPT_NAME" runat="server" MaxLength = "50" ></Com:ComTextBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr></nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryBEGINCREATE_DATE" runat="server"></Com:ComTextBox>
									<img style="cursor: hand" onclick="if(!document.getElementById('txtQueryBEGINCREATE_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtQueryBEGINCREATE_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" >
									<asp:RegularExpressionValidator ID="revtxtQueryBEGINCREATE_DATE" runat="server" ControlToValidate="txtQueryBEGINCREATE_DATE" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">请输入正确的日期</asp:RegularExpressionValidator>
									~
									<Com:ComTextBox ID="txtQueryENDCREATE_DATE" runat="server"></Com:ComTextBox>
									<img style="cursor: hand" onclick="if(!document.getElementById('txtQueryENDCREATE_DATE').getAttribute('disabled'))setday(this,document.getElementById('txtQueryENDCREATE_DATE'));" src="<%=ResolveClientUrl("~/images/calender.gif") %>" >
									<asp:RegularExpressionValidator ID="revtxtQueryENDCREATE_DATE" runat="server" ControlToValidate="txtQueryENDCREATE_DATE" ErrorMessage="" ValidationExpression="^(\d{2,4}-\d{1,2}-\d{1,2})*$">请输入正确的日期</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr></nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryDEPT_ID" runat="server" MaxLength = "36" ></Com:ComTextBox>
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

