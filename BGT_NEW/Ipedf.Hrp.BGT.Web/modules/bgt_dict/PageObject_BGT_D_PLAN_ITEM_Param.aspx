<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_D_PLAN_ITEM_Param.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_D_PLAN_ITEM_Param" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>BGT_D_PLAN_ITEM</title>
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
									<nobr>预算年度</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQueryBUDGET_YEAR" runat="server" ></Com:ComDropDownList>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>指标编码</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryCODE" runat="server" MaxLength = "50" ></Com:ComTextBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>指标名称</nobr>
								</td>
								<td>
									<Com:ComTextBox ID="txtQueryNAME" runat="server" MaxLength = "50" ></Com:ComTextBox>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>指标类型</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQueryITEM_TYPE_ID" runat="server" ></Com:ComDropDownList>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>计量单位</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQueryUNIT_ID" runat="server" ></Com:ComDropDownList>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>指标分类</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQueryITEM_CLASSIFY_ID" runat="server" ></Com:ComDropDownList>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>编制方式</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQueryIMPORT_TYPE_ID" runat="server" ></Com:ComDropDownList>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>指标来源</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQuerySOURCE_TYPE_ID" runat="server" ></Com:ComDropDownList>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>数据类型</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQueryDATA_TYPE_ID" runat="server" ></Com:ComDropDownList>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>医嘱类别</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQueryADVICE_CLASSIFY_ID" runat="server" ></Com:ComDropDownList>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>编制模式</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQueryPREPARE_PATTERN_ID" runat="server" ></Com:ComDropDownList>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>是否停用</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQueryIS_DISABLE" runat="server" ></Com:ComDropDownList>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>是否计算</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQueryIS_CALCULATE" runat="server" ></Com:ComDropDownList>
								</td>
							</tr>
							<tr>
								<td>
									<nobr>是否结转</nobr>
								</td>
								<td>
									<Com:ComDropDownList ID="ddlQueryIS_CARRYOVER" runat="server" ></Com:ComDropDownList>
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

