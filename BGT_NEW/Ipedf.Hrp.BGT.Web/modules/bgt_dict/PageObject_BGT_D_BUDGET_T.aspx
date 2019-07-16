<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_D_BUDGET_T.aspx.cs" Inherits="Ipedf.Web.PageObject_BGT_D_BUDGET_T" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<meta name="Generator" content="Ipedf"/>
	<meta name="Author" content="http://www.itabby.com"/>
	<meta name="Keywords" content="http://www.itabby.com"/>
	<meta name="Description" content=""/>
	<title>BGT_D_BUDGET_T</title>
	
	<link  href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet"/>
	<script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>
</head >
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
	            <td height="30"  >
	                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="12" height="30"></td>
	                        <td><Com:ComControlBar ID="command" runat="server" HandoverState="True" /></td>
	                        <td width="16"></td>
                        </tr>
                    </table>
	            </td>	               
	        </tr>
           <tr >
				<td  >
				<table width="100%" border="0" cellspacing="0" cellpadding="0">
				     <tr >
						<td width="8" >&nbsp;</td>
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
												 <Com:ComGridView ID="gvResultList" runat="server" AutoGenerateColumns="False"   BorderColor="#b5d6e6" BorderWidth="1px"  AllowPaging="True"  AllowSorting="True" BorderStyle="Double"  >
													<Columns>
														<asp:TemplateField HeaderText="V">
														    <headertemplate>
                                                                    <INPUT id="chkSelItem" type="checkbox" onclick="selectAll('gvResultList');" />
                                                                </headertemplate>
														    <ItemTemplate>
															    <asp:CheckBox ID="cbSelect" runat="server" />
														    </ItemTemplate>
													    </asp:TemplateField>							    
														
							<asp:BoundField DataField="BUDGET_YEAR_NAME" HeaderText="预算年度" /> 
							<asp:BoundField DataField="CODE" HeaderText="方案编码" /> 
							<asp:BoundField DataField="NAME" HeaderText="方案名称" /> 
							<asp:BoundField DataField="BUDGET_CONTENTS_ID_NAME" HeaderText="预算内容" /> 
							<asp:BoundField DataField="TEMPLET_TYPE_ID_NAME" HeaderText="模板分类" /> 
							<asp:ButtonField CommandName="Copy_Data" Text="复制新增" />
													</Columns>
													<HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
													<FooterStyle CssClass="FooterStyle"></FooterStyle>                            
													<RowStyle CssClass="RowStyle"></RowStyle>
													<PagerStyle CssClass="PagerStyle"></PagerStyle>
													<SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
													<AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
												</Com:ComGridView>
												<Com:ComPager runat="server" ID="pager" />
											</div>
										</td>
									</tr>
									<tr>
										<td>
											<div id="editPannel" runat="server">
												<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">
													<tr>
														<td>
															<div id="basePannel" runat="server">
																<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">			
																	
				<tr>
					<td >
						<nobr>预算年度</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputBUDGET_YEAR" runat="server" ></Com:ComDropDownList>
					</td>
					<td >
						<nobr>方案编码</nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputCODE" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
					<td >
						<nobr><span style="color:Red">方案名称</span></nobr>
					</td>
					<td>
						<Com:ComTextBox ID="txtInputNAME" runat="server" MaxLength = "50" ></Com:ComTextBox>
					</td>
				</tr>
				<tr>
					<td >
						<nobr>预算内容</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputBUDGET_CONTENTS_ID" runat="server" ></Com:ComDropDownList>
					</td>
					<td >
						<nobr>模板分类</nobr>
					</td>
					<td>
						<Com:ComDropDownList ID="ddlInputTEMPLET_TYPE_ID" runat="server" ></Com:ComDropDownList>
					</td>
					<td colspan=2>&nbsp;</td>
				</tr>
																</table>
															</div>
														</td>
													</tr>
													<tr>
													    <td>
                                                            <asp:LinkButton ID="lbAppend" runat="server" >添加</asp:LinkButton>
                                                        </td>
													</tr>
													<tr>
														<td >
															<div id="detailPannel" runat="server">
															<table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellSpacing="0" cellPadding="0">	
																<tr>
																	<td>
																		<Com:ComGridView ID="gvDetailList" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6" BorderWidth="1px" DbClickEdit="false">
																			<Columns>
																				<asp:BoundField DataField="ID" SortExpression="ID" Visible="False" />
																				<asp:TemplateField HeaderText="V">
																					<headertemplate>
																							<INPUT id="chkSelItem" type="checkbox" onclick="selectAll('gvDetailList');" />
																						</headertemplate>
																					<ItemTemplate>
																						<asp:CheckBox ID="cbSelect" runat="server" />
																					</ItemTemplate>
																				</asp:TemplateField>
																				
							<asp:BoundField DataField="ITEM_ID_NAME" HeaderText="计划指标" /> 
							<asp:BoundField DataField="UNIT_ID_NAME" HeaderText="计量单位" /> 
							<asp:TemplateField HeaderText="参考方法">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputCONSULT" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="计算方法">
								<ItemTemplate>
									<Com:ComDropDownList ID="ddlInputCALCULATE_METHOD_ID" runat="server" ></Com:ComDropDownList><input type="textbox" style="width:40px;" onkeyup="SearchValue(this,document.getElementById('ddlInputCALCULATE_METHOD_ID'));" />
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="计算公式">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputCALCULATE_FORMULA" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="计算序">
								<ItemTemplate>
									<Com:ComTextBox ID="txtInputCALCULATE_INDEX" runat="server" ></Com:ComTextBox>
								</ItemTemplate>
							</asp:TemplateField>
							<asp:TemplateField HeaderText="编制方法">
								<ItemTemplate>
									<Com:ComDropDownList ID="ddlInputPREPARE_METHOD_ID" runat="server" ></Com:ComDropDownList><input type="textbox" style="width:40px;" onkeyup="SearchValue(this,document.getElementById('ddlInputPREPARE_METHOD_ID'));" />
								</ItemTemplate>
							</asp:TemplateField>                     
																			</Columns>
																			<HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
																			<FooterStyle CssClass="FooterStyle"></FooterStyle>                            
																			<RowStyle CssClass="RowStyle"></RowStyle>
																			<PagerStyle CssClass="PagerStyle"></PagerStyle>
																			<SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
																			<AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
																		</Com:ComGridView>
																		
							<Com:ComDropDownList ID="ddlDataSourceITEM_ID" runat="server" Visible="false"/>
							<Com:ComDropDownList ID="ddlDataSourceCALCULATE_METHOD_ID" runat="server" Visible="false"/>
							<Com:ComDropDownList ID="ddlDataSourcePREPARE_METHOD_ID" runat="server" Visible="false"/>
																	</td>
																</tr>
																																<tr>
                                                                        <td>
                                                                            <a href="../../Template/bgt/PageObject_BGT_D_BUDGET_T.xls" onclick="javascript:void(0);"
                                                                                target="_blank">模板下载</a>
                                                                            <asp:FileUpload ID="btnScan" runat="server" Visible="false" />
                                                                            <asp:Button ID="btnUpload" runat="server" Visible="false" Text="导入" Style="height: 26px"
                                                                                OnClick="btnUpload_Click" />
                                                                        </td>
                                                                    </tr>
															</table>
															</div>
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

