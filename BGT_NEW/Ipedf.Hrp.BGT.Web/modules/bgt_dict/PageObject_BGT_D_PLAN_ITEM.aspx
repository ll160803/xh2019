<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_D_PLAN_ITEM.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_D_PLAN_ITEM" %>
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
										<td  colspan="2">
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
										<td valign="top" style="table-layout:fixed; width:210px;">	
									        <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0" cellpadding="0" >
									            <tr>
									                <td>
									                    <div style="overflow: auto; position:relative; WIDTH:200px; HEIGHT:300px" valign="top" >
									                    <input type="textbox" style="width:200px;" onkeyup="SearchValue(this,document.getElementById('tvTree'));" />
									                    <Com:ComListBox runat="server" ID="tvTree" AutoPostBack="true" Width="200" Height="300"/>
							                            </div>		                    
									                </td>
									            </tr>
									        </table>									        
									    </td>	
									    <td valign="top" style="table-layout:fixed; width:80%;">
									        <div runat="server" id="resultPannel">
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
														
							<asp:BoundField DataField="CODE" HeaderText="指标编码" /> 
							<asp:BoundField DataField="NAME" HeaderText="指标名称" /> 
							<asp:BoundField DataField="ITEM_TYPE_ID_NAME" HeaderText="指标类型" /> 
							<asp:BoundField DataField="UNIT_ID_NAME" HeaderText="计量单位" /> 
							<asp:BoundField DataField="ITEM_CLASSIFY_ID_NAME" HeaderText="指标分类" /> 
							<asp:BoundField DataField="IMPORT_TYPE_ID_NAME" HeaderText="编制方式" /> 
							<asp:BoundField DataField="SOURCE_TYPE_ID_NAME" HeaderText="指标来源" /> 
							<asp:BoundField DataField="DATA_TYPE_ID_NAME" HeaderText="数据类型" /> 
							<asp:BoundField DataField="ADVICE_CLASSIFY_ID_NAME" HeaderText="医嘱类别" /> 
							<asp:BoundField DataField="PREPARE_PATTERN_ID_NAME" HeaderText="编制模式" /> 
							<asp:BoundField DataField="IS_DISABLE_NAME" HeaderText="是否停用" /> 
							<asp:BoundField DataField="IS_CALCULATE_NAME" HeaderText="是否计算" /> 
							<asp:BoundField DataField="IS_CARRYOVER_NAME" HeaderText="是否结转" /> 
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
											<div id="editPannel" runat="server">
												<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">			
													
				<tr>
					<td >
						<nobr><span style="color:Red">指标编码</span></nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputCODE" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr><span style="color:Red">指标名称</span></nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputNAME" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>指标类型</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputITEM_TYPE_ID" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr><span style="color:Red">计量单位</span></nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputUNIT_ID" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>指标分类</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputITEM_CLASSIFY_ID" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>编制方式</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputIMPORT_TYPE_ID" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>指标来源</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputSOURCE_TYPE_ID" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr><span style="color:Red">数据类型</span></nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputDATA_TYPE_ID" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>医嘱类别</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputADVICE_CLASSIFY_ID" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>编制模式</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputPREPARE_PATTERN_ID" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr><span style="color:Red">是否停用</span></nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputIS_DISABLE" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>是否计算</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputIS_CALCULATE" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>是否结转</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputIS_CARRYOVER" runat="server" ></Com:ComDropDownList>
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

