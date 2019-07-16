<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_D_BUDGET_CPN_YEAR_R_I_Edit.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_D_BUDGET_CPN_YEAR_R_I_Edit" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>BGT_D_BUDGET_CPN_YEAR_R_I</title>
	<script src="<%=ResolveClientUrl("~/scripts/xp.js") %>" type="text/javascript"></script>	
	<link  href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet"/>
	<script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>
	<script type="text/javascript">
	     function cal() {

	        document.getElementById('txtInputM_1_VALUE').value = (1 / 12).toFixed(2);
	        document.getElementById('txtInputM_2_VALUE').value = (1 / 12).toFixed(2);
	        document.getElementById('txtInputM_3_VALUE').value = (1 / 12).toFixed(2);
	        document.getElementById('txtInputM_4_VALUE').value = (1 / 12).toFixed(2);
	        document.getElementById('txtInputM_5_VALUE').value = (1 / 12).toFixed(2);
	        document.getElementById('txtInputM_6_VALUE').value = (1 / 12).toFixed(2);
	        document.getElementById('txtInputM_7_VALUE').value = (1 / 12).toFixed(2);
	        document.getElementById('txtInputM_8_VALUE').value = (1 / 12).toFixed(2);
	        document.getElementById('txtInputM_9_VALUE').value = (1 / 12).toFixed(2);
	        document.getElementById('txtInputM_10_VALUE').value = (1 / 12).toFixed(2);
	        document.getElementById('txtInputM_11_VALUE').value = (1 / 12).toFixed(2);
	        document.getElementById('txtInputM_12_VALUE').value = (1 / 12).toFixed(2);
	        caltotal();
	    }
	    function caltotal() {
	        var total = 0;	        
	        total += parseFloat(document.getElementById('txtInputM_1_VALUE').value);
	        total += parseFloat(document.getElementById('txtInputM_2_VALUE').value);
	        total += parseFloat(document.getElementById('txtInputM_3_VALUE').value);
	        total += parseFloat(document.getElementById('txtInputM_4_VALUE').value);
	        total += parseFloat(document.getElementById('txtInputM_5_VALUE').value);
	        total += parseFloat(document.getElementById('txtInputM_6_VALUE').value);
	        total += parseFloat(document.getElementById('txtInputM_7_VALUE').value);
	        total += parseFloat(document.getElementById('txtInputM_8_VALUE').value);
	        total += parseFloat(document.getElementById('txtInputM_9_VALUE').value);
	        total += parseFloat(document.getElementById('txtInputM_10_VALUE').value);
	        total += parseFloat(document.getElementById('txtInputM_11_VALUE').value);
	        total += parseFloat(document.getElementById('txtInputM_12_VALUE').value);
	        document.getElementById('txtTotal').value = total.toFixed(2);
	    }
	    function checktotal() {
	        try {
	                var pass = parseFloat(document.getElementById('txtTotal').value) == 1;
	                if (!pass) {
	                    alert('合计不等于1,请重新分解!');
	                    return false;
	                }
	                else
	                    return true;

	            } catch (e) { return false; }
	    }
	</script>
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
	                        <td>	                            
	                            <Com:ComButton runat="server" ID="btnSave" OnClick="OnSave"  Text="保存" />
	                            <input type="button" value="关闭" onclick="self.close();">
	                        </td>
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
											<div id="editPannel" runat="server">
												<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">			
							
				<tr>
					<td >
						<nobr>1月调节比例值</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputM_1_VALUE" runat="server" ></Com:ComTextBox>
						<asp:RegularExpressionValidator ID="revtxtInputM_1_VALUE" runat="server" ControlToValidate="txtInputM_1_VALUE" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>2月调节比例值</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputM_2_VALUE" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputM_2_VALUE" runat="server" ControlToValidate="txtInputM_2_VALUE" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>3月调节比例值</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputM_3_VALUE" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputM_3_VALUE" runat="server" ControlToValidate="txtInputM_3_VALUE" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>4月调节比例值</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputM_4_VALUE" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputM_4_VALUE" runat="server" ControlToValidate="txtInputM_4_VALUE" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>5月调节比例值</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputM_5_VALUE" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputM_5_VALUE" runat="server" ControlToValidate="txtInputM_5_VALUE" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>6月调节比例值</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputM_6_VALUE" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputM_6_VALUE" runat="server" ControlToValidate="txtInputM_6_VALUE" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				
				<tr>
					<td >
						<nobr>7月调节比例值</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputM_7_VALUE" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputM_7_VALUE" runat="server" ControlToValidate="txtInputM_7_VALUE" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>		
				<tr>
					<td >
						<nobr>8月调节比例值</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputM_8_VALUE" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputM_8_VALUE" runat="server" ControlToValidate="txtInputM_8_VALUE" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>9月调节比例值</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputM_9_VALUE" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputM_9_VALUE" runat="server" ControlToValidate="txtInputM_9_VALUE" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>10月调节比例值</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputM_10_VALUE" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputM_10_VALUE" runat="server" ControlToValidate="txtInputM_10_VALUE" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>11月调节比例值</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputM_11_VALUE" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputM_11_VALUE" runat="server" ControlToValidate="txtInputM_11_VALUE" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>12月调节比例值</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputM_12_VALUE" runat="server" ></Com:ComTextBox>
									<asp:RegularExpressionValidator ID="revtxtInputM_12_VALUE" runat="server" ControlToValidate="txtInputM_12_VALUE" ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td >
						<nobr><span style="color:red">合计</span></nobr>
					</td>
					<td>
						<input type="text" disabled="disabled" id="txtTotal" />
					</td>
				</tr>
				<tr>
				    <td colspan=2>
				        <input type="button" value = "自动分解"  onclick="cal();"/>
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
<script type="text/javascript">
    if (window.opener) {
        window.opener.window.location.href = window.opener.window.location.href;
    }
</script>
<script type="text/javascript">
    caltotal();
</script>
</body>
</html>

