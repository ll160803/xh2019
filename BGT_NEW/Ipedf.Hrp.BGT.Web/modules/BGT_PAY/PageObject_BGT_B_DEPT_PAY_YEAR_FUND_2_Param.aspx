<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_DEPT_PAY_YEAR_FUND_2_Param.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_B_DEPT_PAY_YEAR_FUND_2_Param" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>BGT_B_DEPT_PAY_YEAR_FUND</title>
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
									<nobr>预算科室</nobr>
								</td>
								<td>
									<Com:ComBaseBox ID="ddlQueryBUDGET_DEPT_ID" runat="server" ></Com:ComBaseBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>申请年度</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQueryBUDGET_YEAR" runat="server" ></Com:ComDropDownList>
								</td>
							</tr>
							<tr style="display:none;">
								<td>
									<nobr>经费名称</nobr>
								</td>
								<td>
									<Com:ComBaseBox ID="ddlQueryBGT_D_BUDGET_ITEM_ID" runat="server" ></Com:ComBaseBox>
								</td>
							</tr>
							<tr style="display:none;">
								<td>
									<nobr></nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryITEM_NAME" runat="server" MaxLength = "200" ></Com:ComTextBox>
								</td>
							</tr>
							<tr style="display:none;">
								<td>
									<nobr>部门负责人</nobr>
								</td>
								<td>
									<Com:ComBaseBox ID="ddlQueryDEPT_USER_ID" runat="server" ></Com:ComBaseBox>
								</td>
							</tr>
							<tr style="display:none;">
								<td>
									<nobr>申请说明</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryDECALRE_CAUSE" runat="server" MaxLength = "2000" ></Com:ComTextBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>经费类别</nobr>
								</td>
								<td>
									<Com:ComBaseBox ID="ddlQueryFUND_TYPE_ID" runat="server" ></Com:ComBaseBox>
								</td>
							</tr>
							<tr style="display:none;">
								<td>
									<nobr>经费金额</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryFUND_MONEY" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtQueryFUND_MONEY" runat="server" ControlToValidate="txtQueryFUND_MONEY" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
								</td>
							</tr>
							<tr style="display:none;">
								<td>
									<nobr>状态</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQuerySTATE" runat="server" ></Com:ComDropDownList>
								</td>
							</tr>
							<tr style="display:none;">
								<td>
									<nobr>经费编码</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryCODE" runat="server" MaxLength = "50" ></Com:ComTextBox>
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

