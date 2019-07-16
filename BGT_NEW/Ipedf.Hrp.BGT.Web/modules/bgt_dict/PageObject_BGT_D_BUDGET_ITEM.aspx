<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_D_BUDGET_ITEM.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_D_BUDGET_ITEM" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>	
	<title>BGT_D_BUDGET_ITEM</title>
	<script src="<%=ResolveClientUrl("~/scripts/xp.js") %>" type="text/javascript"></script>
	
	<link  href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet"/>
	<script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>
</head>
<style type="text/css">
   .hidden { display:none;}
</style>
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
												<Com:ComButton ID="btnDelete" runat="server" Text="删除" />
												    <asp:LinkButton ID="lbAppend" runat="server" onclick="lbAppend_Click">引入会计科目</asp:LinkButton>
												</td>
											</tr>
										</table>					
										</td>
									</tr>										
									<tr>
										<td valign="top" style="table-layout:fixed; width:240px;display:none;">	
									        <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0" cellpadding="0" >
									            <tr>
									                <td>
									                    <div style="overflow:  hidden; position:relative; WIDTH:230px; HEIGHT:300px" valign="top" >
									                    <nobr>预算年度:
									                    <Com:ComDropDownList runat="server" ID="ddlInputBUDGET_YEAR"  AutoPostBack="True"  OnSelectedIndexChanged="ddlInputBUDGET_YEAR_SelectedIndexChanged"/></nobr>
									                    <input type="textbox" style="width:230px;display:none;" onkeyup="SearchValue(this,document.getElementById('tvTree'));" />
									                    <Com:ComListBox runat="server" ID="tvTree" AutoPostBack="true" Width="230" Height="260"/>
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
							<asp:BoundField DataField="BUDGET_YEAR_NAME" HeaderText="预算年度" />
							<asp:BoundField DataField="DEPT_NAME" HeaderText="预算科室" />  
							<asp:BoundField DataField="CODE" HeaderText="科目编码" /> 
							<asp:BoundField DataField="NAME" HeaderText="科目名称" /> 
							<asp:BoundField DataField="ITEM_TYPE_ID_NAME" HeaderText="科目类别" /> 
							<asp:BoundField DataField="IMPORT_TYPE_ID_NAME" HeaderText="编制方式" /> 
							<asp:BoundField DataField="DATA_TYPE_ID_NAME" HeaderText="数据类型" /> 
							<asp:BoundField DataField="USAGE_ID_NAME" HeaderText="适用范围" /> 
							<asp:BoundField DataField="PREPARE_PATTERN_ID_NAME" HeaderText="编制模式" /> 
							<asp:BoundField DataField="IS_CARRYOVER_NAME" HeaderText="是否结转" /> 
							<asp:BoundField DataField="IS_MERGE_NAME" HeaderText="是否合并科目" /> 
							<asp:BoundField DataField="IS_END_NAME" HeaderText="是否末级" /> 
							<asp:BoundField DataField="COMMENTS_NAME" HeaderText="映射关系" /> 
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
						<nobr><span style="color:Red">科目编码</span></nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputCODE" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr><span style="color:Red">科目名称</span></nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputNAME" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr><span style="color:Red">科目类别</span></nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputITEM_TYPE_ID" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr><span style="color:Red">预算年度</span></nobr>
					</td>
					<td>
						 <Com:ComDropDownList runat="server" Enabled="false" ID="ddlBudgetYear" />
					</td>
				</tr>
				<tr>
					<td >
						<nobr><span style="color:Red">预算科室</span></nobr>
					</td>
					<td>
						 <Com:ComBaseBox ID="ddlBUDGET_DEPT_ID" runat="server"></Com:ComBaseBox>
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
						<nobr><span style="color:Red">数据类型</span></nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputDATA_TYPE_ID" runat="server" ></Com:ComDropDownList>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>适用范围</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputUSAGE_ID" runat="server" ></Com:ComDropDownList>
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
						<nobr>是否结转</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputIS_CARRYOVER" runat="server" ></Com:ComDropDownList><input type="textbox" style="width:40px;" onkeyup="SearchValue(this,window.event.srcElement.previousSibling);" />
					</td>
				</tr>
				<tr>
					<td >
						<nobr>是否合并科目</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputIS_MERGE" runat="server" ></Com:ComDropDownList><input type="textbox" style="width:40px;" onkeyup="SearchValue(this,window.event.srcElement.previousSibling);" />
					</td>
				</tr>
				<tr>
					<td >
						<nobr><span style="color:Red">是否末级</span></nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputIS_FINAL" runat="server" ></Com:ComDropDownList><input type="textbox" style="width:40px;" onkeyup="SearchValue(this,window.event.srcElement.previousSibling);" />
					</td>
				</tr>
				<tr>
					<td >
						<nobr><span>映射关系</span></nobr>
					</td>
					<td>
						 <Com:ComBaseBox ID="ddlComments" runat="server"></Com:ComBaseBox>
					</td>
				</tr>				
												</table>
											</div>																	
									    </td>	
									</tr>	
									<tr>
                                        <td colspan="2">
                                            <a href="../../Template/bgt/PageObject_BGT_D_BUDGET_ITEM.xls" onclick="javascript:void(0);"
                                                target="_blank">模板下载</a>
                                            <asp:FileUpload ID="btnScan" runat="server" />
                                            <asp:Button ID="btnUpload" runat="server" Text="导入" Style="height: 26px"
                                                OnClick="btnUpload_Click" />
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

