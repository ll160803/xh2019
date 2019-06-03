﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Models.LogOnModel>" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <title>供应链管理平台 登录</title>
    <script src="<%: Url.Content("~/Scripts/jquery.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/jquery.easyui.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/locale/easyui-lang-zh_CN.js") %>" type="text/javascript"></script>
    <link href="<%: Url.Content("~/Res/easyui/themes/icon.css") %>" rel="stylesheet"
        type="text/css" />
    <link href="<%: Url.Content("~/Res/easyui/themes/default/easyui.css") %>" rel="stylesheet"
        type="text/css" />
    <link href="<%: Url.Content("~/Content/StyleSheet.css") %>" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(document).ready(function () {
            $(window).keydown(function (event) {
                if (event.which == 13) {
                    $("#btnSubmit").click();
                    return false;
                }
            });
        });
       
    </script>
    <script language="javascript" type="text/javascript">
        function OpenRegister() {
            var url = $("#combo_MDM").combobox('getValue');
            if (url == "") {
                alert("请选择注册供应商类型!");
                return false;
            }
            window.location.href = url;
        }
        function Search() {

            var url = $("#combo_searMDM").combobox('getValue');
            if (url == "") {
                alert("请选择注册供应商类型!");
                return false;
            }
            if ($.trim($("#reg_Code").val()).length != 36) {
                alert("请输入正确注册查询码！");
                return false;
            }
            window.location.href = url + $.trim($("#reg_Code").val());
        }
        function RefreshValidateCode(obj) {
            obj.src = "Account/ValidateCode/" + Math.floor(Math.random() * 10000);
        }
    </script>
    <style type="text/css">
        body
        {
            background: url("Images/Login/bg.jpg") repeat-x scroll 0 0;
            color: #505050;
            font-family: "宋体" ,Arial,Helvetica,sans-serif;
            font-size: 12px;
            line-height: 100%;
            margin: 0;
            padding: 0;
            text-align: center;
        }
        .wrap
        {
            background: url("Images/Login/conbg.png") no-repeat scroll 0 0;
            height: 390px;
            margin: 8% auto 0;
            width: 765px;
        }
        .login_con
        {
            margin-left: 436px;
            padding-top: 185px;
        }
        .login_btn
        {
            background: url("Images/Login/btn3.gif") no-repeat scroll 0 0;
            border: medium none;
            color: #fff;
            height: 24px;
            line-height: 24px;
            width: 75px;
        }
        td
        {
            color: #194673;
        }
        .login_tr
        {
            height: 32px;
        }
        .login_input
        {
            border: 1px solid #d1ebf2;
            height: 25px;
            line-height: 25px;
            width: 150px;
        }
    </style>
</head>
<body>
    <div id="dlg" class="easyui-dialog" title="注册选择类型" data-options="iconCls:'icon-save',closed:true,buttons: [{
					text:'确定',
					iconCls:'icon-ok',
					handler:function(){
						OpenRegister();
					}
				}]" style="width: 400px; height: 150px; padding: 10px">
        供应商类型：
        <select class="easyui-combobox" id="combo_MDM" style="width: 200px;">
            <option value="<%: Url.Content("~/home/Register")%>">药品供应商</option>
            <option value="<%: Url.Content("~/Scm_Register/Register")%>">总务供应商</option>
        </select>
    </div>
    <div id="searchdlg" class="easyui-dialog" title="选择查询供应商类型" data-options="iconCls:'icon-save',closed:true,buttons: [{
					text:'确定',
					iconCls:'icon-ok',
					handler:function(){
						Search();
					}
				}]" style="width: 400px; height: 180px; padding: 10px">
        <table>
            <tr>
                <td>
                    供应商类型：<select class="easyui-combobox" id="combo_searMDM" style="width: 200px; padding: 10px;">
                        <option value="<%: Url.Content("~/Home/RegisterEdit/")%>">药品供应商</option>
                        <option value="<%: Url.Content("~/Scm_Register/RegisterEdit/")%>">总务供应商</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td>
                      &nbsp;&nbsp;注册码：<input id="reg_Code" class="easyui-textbox" style="width: 195px;" />
                </td>
            </tr>
        </table>
    </div>
    <div class="wrap">
        <div class="login_con">
            <form id="Form1" runat="server">
            <table border="0">
                <tr class="login_tr">
                    <td width="60">
                        账 号：
                    </td>
                    <td width="192" style="text-align: left;">
                        <%: Html.TextBoxFor(m => m.PersonName, new { @class="login_input" })%>
                    </td>
                </tr>
                <tr class="login_tr">
                    <td width="60">
                        密 码：
                    </td>
                    <td width="192" style="text-align: left;">
                        <%: Html.PasswordFor(m => m.Password, new { @class="login_input" })%>
                    </td>
                </tr>
                <tr class="login_tr">
                    <td width="60">
                        验证码：
                    </td>
                    <td width="192" style="text-align: left;">
                    <%: Html.TextBoxFor(m => m.ValidateCode, new { MaxLength = "4", style = "width:50px;" })%>
                        <img alt="点击刷新验证码！" title="点击刷新验证码！" src="Account/ValidateCode" style="cursor: pointer;vertical-align:bottom;"
                                onclick="RefreshValidateCode(this);" />
                                <%--<%: Html.ValidationMessageFor(m => m.ValidateCode, "", new { @class = "text-danger" })%>--%>
                    </td>
                </tr>
                <tr class="login_tr">
                    <td colspan="2" style="text-align: center;">
                        <input class="login_btn" style="text-align: center; letter-spacing: 2px;" type="submit"
                            value="登录" onmouseover="this.style.cursor='hand'" />
                    </td>
                </tr>
                <tr class="login_tr">
                    <td width="60">
                    </td>
                    <td width="192" style="text-align: left;">
                        <span style="margin-left: 25px;"><a href="#" onclick="$('#dlg').dialog('open');">注册</a>/<a
                            href="#" id="h_s" onclick="$('#searchdlg').dialog('open');">注册查询</a></span>
                    </td>
                </tr>
            </table>
            </form>
        </div>
    </div>
</body>
</html>
