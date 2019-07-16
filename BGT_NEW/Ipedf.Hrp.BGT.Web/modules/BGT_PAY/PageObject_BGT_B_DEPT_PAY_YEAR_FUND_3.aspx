<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageObject_BGT_B_DEPT_PAY_YEAR_FUND_3.aspx.cs"
    Inherits="Ipedf.Web.PageObject_BGT_B_DEPT_PAY_YEAR_FUND_3" %>

<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta name="Generator" content="Ipedf" />
    <meta name="Author" content="http://www.itabby.com" />
    <meta name="Keywords" content="http://www.itabby.com" />
    <meta name="Description" content="" />
    <title>BGT_B_DEPT_PAY_YEAR_FUND</title>
    <link href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet" />

    <script src="<%=ResolveClientUrl("~/scripts/common.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/dateSelect.js") %>" type="text/javascript"></script>

    <script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>

    <script type="text/javascript">
        function ClientFun(comBaseId, row) {//comBaseId 控件ID，row所选ComBaseBox的行值 是对象 row.NAME,row.ID

            $("#txtInputCODE").val(row.CODE);
            $("#txtInputCODE_H").val(row.CODE);

        }
    </script>

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
                <td height="30">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="12" height="30">
                            </td>
                            <td>
                                <Com:ComControlBar ID="command" runat="server" HandoverState="True" />
                            </td>
                            <td width="16">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="8">
                                &nbsp;
                            </td>
                            <td>
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td>
                                            <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                cellpadding="0">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblState" runat="server" Width="500px"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td><Com:ComButton ID="btnDelete" runat="server" Text="删除" />&nbsp;
     <Com:ComButton ID="btnSeSubmit" runat="server" OnClientClick="if (!confirm('确定要提交吗?')) return false;" Text="提交" OnClick="OnSeSubmit"/>&nbsp;
                                                         <asp:Button runat="server" ID="btnExport" Text="导出" OnClick="OnExport" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div id="resultPannel" runat="server">
                                                <Com:ComGridView ID="gvResultList" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                    BorderWidth="1px" AllowPaging="True" AllowSorting="True" BorderStyle="Double" ShowFooter="True">
                                                    <Columns>
                                                        <asp:TemplateField HeaderText="V">
                                                            <HeaderTemplate>
                                                                <input id="chkSelItem" type="checkbox" onclick="selectAll('gvResultList');" />
                                                            </HeaderTemplate>
                                                            <ItemTemplate>
                                                                <asp:CheckBox ID="cbSelect" runat="server" />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:BoundField DataField="BUDGET_YEAR_NAME" HeaderText="申请年度" />
                                                        <asp:BoundField DataField="BUDGET_DEPT_ID_NAME" HeaderText="预算科室" />
                                                        <asp:BoundField DataField="DEPT_USER_ID" HeaderText="科室负责人" />
                                                        <asp:BoundField DataField="BGT_D_BUDGET_ITEM_ID_NAME" HeaderText="经费名称" />
                                                        <asp:BoundField DataField="CODE" HeaderText="经费代码" />
                                                        <asp:BoundField DataField="FUND_MONEY" HeaderText="一上申报金额" />
                                                        <asp:BoundField DataField="CONTROL_MONEY" HeaderText="一下调整金额" />
                                                        <asp:BoundField DataField="ISAGREE" HeaderText="是否同意调整" />
                                                        <asp:BoundField DataField="FUND_MONEY1" HeaderText="二上申报金额" />
                                                        <asp:BoundField DataField="CONTROL_MONEY1" HeaderText="核定数" />
                                                        <asp:BoundField DataField="FUND_TYPE_ID_NAME" HeaderText="经费类别" />
                                                        <asp:BoundField DataField="STATE_NAME" HeaderText="状态" />
                                                        <asp:BoundField DataField="IS_ATTACH" HeaderText="是否上传附件" />
                                                    </Columns>
                                                    <HeaderStyle CssClass="HeaderStyle"></HeaderStyle>
                                                    <FooterStyle CssClass="FooterStyle"></FooterStyle>
                                                    <RowStyle CssClass="RowStyle"></RowStyle>
                                                    <PagerStyle CssClass="PagerStyle"></PagerStyle>
                                                    <SelectedRowStyle CssClass="SelectedRowStyle"></SelectedRowStyle>
                                                    <AlternatingRowStyle CssClass="AlternatingRowStyle"></AlternatingRowStyle>
                                                </Com:ComGridView>
                                                <Com:ComPager runat="server" ID="pager" />
                                                <p style="color: Red">
                                                    <%=Tip %>
                                                </p>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div id="editPannel" runat="server">
                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                    cellpadding="0">
                                                    <tr>
                                                        <td>
                                                            <div id="basePannel" runat="server">
                                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                                    cellpadding="0">
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>预算科室</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComBaseBox ID="ddlInputBUDGET_DEPT_ID" Enabled="false" runat="server"></Com:ComBaseBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>部门负责人</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="ddlInputDEPT_USER_ID" Enabled="false" runat="server"></Com:ComTextBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>申请年度</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComDropDownList ID="ddlInputBUDGET_YEAR" runat="server">
                                                                            </Com:ComDropDownList>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>经费名称</nobr>
                                                                        </td>
                                                                        <td colspan="3">
                                                                            <Com:ComBaseBox ID="ddlInputBGT_D_BUDGET_ITEM_ID"  runat="server"></Com:ComBaseBox>
                                                                            <input type="button" onclick="$('#txtInputNewItem').attr('disabled',false);" value="新增" />
                                                                            <Com:ComTextBox ID="txtInputNewItem" runat="server" Enabled="false">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>经费类别</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="ddlInputFUND_TYPE_ID" runat="server" Enabled="false">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>一上经费金额</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputFUND_MONEY" runat="server" Enabled="true"  onfocus="this.blur()">
                                                                            </Com:ComTextBox>
                                                                            <asp:RegularExpressionValidator ID="revtxtInputFUND_MONEY" runat="server" ControlToValidate="txtInputFUND_MONEY"
                                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>一下调整数</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputCONTROL_MONEY" ForeColor="Red" Enabled ="false" runat="server" >
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>是否同意调整</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComDropDownList ID="ddlInputIS_AGREE" AutoPostBack="true" OnSelectedIndexChanged="ddlInputIS_AGREE_Change" runat="server" onchange="onselchange(this.value)">
                                                                            </Com:ComDropDownList>
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                    <td>
                                                                            <nobr>二上经费金额</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputFUND_MONEY1" runat="server" Enabled="true" onfocus="this.blur()">
                                                                            </Com:ComTextBox>
                                                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtInputFUND_MONEY1"
                                                                                ErrorMessage="" ValidationExpression="^[-]{0,1}[0-9]+(.[0-9]{1,})?$">请输入正确的小数</asp:RegularExpressionValidator>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>核定数</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputCONTROL_MONEY1" ForeColor="Red" Enabled ="false" runat="server" >
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                        <td>
                                                                            <nobr>经费编码</nobr>
                                                                        </td>
                                                                        <td>
                                                                            <Com:ComTextBox ID="txtInputCODE" runat="server" MaxLength="50" Enabled="false">
                                                                            </Com:ComTextBox>
                                                                           <asp:HiddenField ID="txtInputCODE_H" runat="server" />
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>一上申请说明</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputDECALRE_CAUSE" TextMode="MultiLine" Columns="20" Rows="2" Font-Size="12px"
                                                                                Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>一下预算工作委员会办公室意见</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox Enabled="false" ID="txtInputFINANCE_IDEA" TextMode="MultiLine" Columns="20" Rows="2"
                                                                                Font-Size="12px" Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>二上申请说明</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputDECALRE_CAUSE1" TextMode="MultiLine" Columns="20" Rows="2" Font-Size="12px"
                                                                                Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <nobr>预算工作委员会办公室核定意见</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA1" TextMode="MultiLine" Columns="20" Rows="2"
                                                                             Enabled="false"   Font-Size="12px" Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="6">
                                                                            <Com:ComUpFile ID="upFiles" runat="server"></Com:ComUpFile>
                                                                        </td>
                                                                    </tr>
                                                                    <%--<tr>
                                                                        <td>
                                                                            <nobr>财务意见</nobr>
                                                                        </td>
                                                                        <td colspan="5">
                                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA2" TextMode="MultiLine" Enabled="false" Columns="20"
                                                                                Rows="2" Width="96%" Height="35px" runat="server" MaxLength="2000">
                                                                            </Com:ComTextBox>
                                                                        </td>
                                                                    </tr>--%>
                                                                </table>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:LinkButton OnClick="OnResourceAppend" ID="lbAppend" runat="server">查看设备购置明细执行情况</asp:LinkButton>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <div id="detailPannel" runat="server">
                                                                <table border="1" bordercolordark="#FFFFFF" bordercolorlight="#b5d6e6" cellspacing="0"
                                                                    cellpadding="0">
                                                                    <tr>
                                                                        <td style="text-align: center">
                                                                            项目支出明细
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <Com:ComGridView ID="gvDetailList" runat="server" AutoGenerateColumns="False" BorderColor="#b5d6e6"
                                                                                BorderWidth="1px" DbClickEdit="false">
                                                                                <Columns>
                                                                                    <asp:BoundField DataField="ID" SortExpression="ID" Visible="False" />
                                                                                    <asp:TemplateField HeaderText="V">
                                                                                        <HeaderTemplate>
                                                                                            <input id="chkSelItem" type="checkbox" onclick="selectAll('gvDetailList');" onchange="showedit()"/>
                                                                                        </HeaderTemplate>
                                                                                        <ItemTemplate>
                                                                                            <asp:CheckBox ID="cbSelect" runat="server"  cbSelect/>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="设备名称">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputASSET_NAME" Width="100" runat="server" onchange="ontextchange()" ></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="设备单价">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputPRICE"  Width="100" runat="server"  onchange="ontextchange()" ></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="设备数量">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputAMOUNT"  Width="100" runat="server" onchange="ontextchange()" ></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="一上申请金额">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputMONEY" Width="100" runat="server" Enabled="true"  onchange="ontextchange()" txtInputMONEY></Com:ComTextBox>元
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="依据说明">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputDECLARE_CAUSE" TextMode="MultiLine" Font-Size="12px" Columns="20" Rows="2" Width="96%" Height="35px" runat="server"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                   <asp:TemplateField HeaderText="预算办公室一下调整金额">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputCONTROL_MONEY" Width="100" Enabled="false" runat="server"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="预算办公室一下意见">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA" runat="server" Enabled="false" TextMode="MultiLine" Font-Size="12px" Columns="20" Rows="10" Width="96%" Height="35px"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="二上申请金额" >
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputMONEY1" Width="100"  runat="server" onchange="ontextchange1()" txtInputMONEY1></Com:ComTextBox>元
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="核定数">
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputCONTROL_MONEY1" Enabled="false" Width="100" runat="server"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="预算办公室核定意见" >
                                                                                        <ItemTemplate>
                                                                                            <Com:ComTextBox ID="txtInputFINANCE_IDEA1" runat="server" TextMode="MultiLine"  Enabled="false" Font-Size="12px" Columns="20" Rows="10" Width="96%" Height="35px"></Com:ComTextBox>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField ShowHeader="False">
                                                                                        <ItemTemplate>
                                                                                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                                                                                Text="删除" OnClientClick='<%#  "if (!confirm(\"你确定要删除此项吗?\")) return false;"%>'></asp:LinkButton>
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
                                                                            <Com:ComDropDownList ID="ddlDataSourceACCOUNT_ITEM_ID" runat="server" Visible="false" />
                                                                            <Com:ComDropDownList ID="ddlDataSourceBGT_D_ACCOUNT_ITEM_ID" runat="server" Visible="false" />
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <a href="../../Template/bgt/PageObject_BGT_B_DEPT_PAY_YEAR_FUND_3.xls" onclick="javascript:void(0);"
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
                            <td width="8">
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td height="35">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="12" height="35">
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td width="16">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
    
                                                                              <script type="text/javascript">
                                                                                          $(function () {
                $("#gvDetailList [cbSelect] input").change(showedit);
            })
   

                                                                                      function showedit() {
                                                                                          console.log("showedit")
                                                                                        ontextchange();
                                                                                        ontextchange1();
                                                                                      
                                                                                  }

                                                                                  function toint(val) {
                                                                                      var ret = parseInt(val);
                                                                                      if (isNaN(ret)) return 0;
                                                                                      return ret;
                                                                                  }

                                                                                  function ontextchange() {
                                                                                      console.log("ontextchange");
                                                                                      var InputMONEY = 0;
                                                                                      $("#gvDetailList [txtInputMONEY]").each(function () {
                                                                                          //console.log("aaaaaaa ");
                                                                                          //console.dir($(this).val());
                                                                                          var cb = $(this).parent().parent().find("[type='checkbox']").get(0)
                                                                                          console.dir(cb)
                                                                                          if (cb.checked) {
                                                                                              console.log("aaaaaaaaaaaaaaaaa")
                                                                                              InputMONEY = InputMONEY + toint($(this).val());
                                                                                          }
                                                                                      })

                                                                                      if (!$("#txtInputFUND_MONEY").attr("disabled")) {
                                                                                          $("#txtInputFUND_MONEY").val(InputMONEY);
                                                                                      }
                                                                                      
                                                                                  }

                                                                                  function ontextchange1() {
                                                                                      console.log("ontextchange1");
                                                                                      var InputMONEY = 0;
                                                                                      $("#gvDetailList [txtInputMONEY1]").each(function () {
                                                                                          //console.log("aaaaaaa ");
                                                                                          //console.dir($(this).val());
                                                                                          InputMONEY = InputMONEY + toint($(this).val());
                                                                                      })

                                                                                      if (!$("#txtInputFUND_MONEY1").attr("disabled")) {
                                                                                           $("#txtInputFUND_MONEY1").val(InputMONEY);
                                                                                      }
                                                                                     
                                                                                  }
                                                                                  function onselchange(val) {
                                                                                      console.log("onselchange: " + val);
                                                                                      if (val == "1") {
                                                                                          $("#txtInputFUND_MONEY1").val($("#txtInputCONTROL_MONEY").val());
                                                                                      } else {
                                                                                          $("#txtInputFUND_MONEY1").val("0");
                                                                                      }

                                                                                      /*$("#gvDetailList .RowStyle,.AlternatingRowStyle").each(
                                                                                          function () {
                                                                                              var row = $(this)
                                                                                              var a = row.find("[txtInputMONEY1]").first()
                                                                                              var b = row.find("[txtInputCONTROL_MONEY]").first()
                                                                                              console.log("txtInputMONEY1: " + a.val());
                                                                                              console.log("txtInputCONTROL_MONEY: " + b.val());
                                                                                              a.val(b.val());
                                                            
                                                                                              a.attr("disabled", val == "1" ? true : false)
                                                                                              $("#txtInputDECALRE_CAUSE1").attr("disabled", val == "1" ? true : false)
                                                                                          });*/
                                                                                  }
                                                                                   </script>
</body>
</html>
