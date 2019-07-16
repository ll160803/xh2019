<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_CPN_INC_BASIC_D_Param.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_B_CPN_INC_BASIC_D_Param" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>BGT_B_CPN_INC_BASIC_D</title>
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
									<nobr>财务意见</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryFINANCE_IDEA" runat="server" MaxLength = "500" ></Com:ComTextBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>控制数</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryCONTROL_MONEY" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryCONTROL_MONEY" runat="server" ControlToValidate="txtQueryCONTROL_MONEY" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>金额</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryMONEY" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryMONEY" runat="server" ControlToValidate="txtQueryMONEY" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr></nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryBASE_ID" runat="server" MaxLength = "36" ></Com:ComTextBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>申请理由</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryDECALRE_CAUSE" runat="server" MaxLength = "2000" ></Com:ComTextBox>
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

