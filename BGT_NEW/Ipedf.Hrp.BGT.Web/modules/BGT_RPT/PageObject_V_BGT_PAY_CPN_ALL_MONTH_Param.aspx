<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_V_BGT_PAY_CPN_ALL_MONTH_Param.aspx.cs" Inherits="Ipedf.Web.PageObject_V_BGT_PAY_CPN_ALL_MONTH_Param" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>V_BGT_PAY_CPN_ALL_MONTH</title>
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
									<nobr>9月</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryM9TH" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryM9TH" runat="server" ControlToValidate="txtQueryM9TH" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>预算年度</nobr>
								</td>
								<td>
									<Com:ComBaseBox ID="ddlQueryBUDGET_YEAR" runat="server" ></Com:ComBaseBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>4月</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryM4TH" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryM4TH" runat="server" ControlToValidate="txtQueryM4TH" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>7月</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryM7TH" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryM7TH" runat="server" ControlToValidate="txtQueryM7TH" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>8月</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryM8TH" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryM8TH" runat="server" ControlToValidate="txtQueryM8TH" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>6月</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryM6TH" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryM6TH" runat="server" ControlToValidate="txtQueryM6TH" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>预算科目</nobr>
								</td>
								<td>
									<Com:ComBaseBox ID="ddlQueryITEM_ID" runat="server" ></Com:ComBaseBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>10月</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryM10TH" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryM10TH" runat="server" ControlToValidate="txtQueryM10TH" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>11月</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryM11TH" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryM11TH" runat="server" ControlToValidate="txtQueryM11TH" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>5月</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryM5TH" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryM5TH" runat="server" ControlToValidate="txtQueryM5TH" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>1月</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryM1TH" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryM1TH" runat="server" ControlToValidate="txtQueryM1TH" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>3月</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryM3TH" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryM3TH" runat="server" ControlToValidate="txtQueryM3TH" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>年度计划</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryMALL" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryMALL" runat="server" ControlToValidate="txtQueryMALL" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>12月</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryM12TH" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryM12TH" runat="server" ControlToValidate="txtQueryM12TH" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>2月</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryM2TH" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryM2TH" runat="server" ControlToValidate="txtQueryM2TH" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
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

