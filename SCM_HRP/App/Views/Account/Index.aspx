<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Models.LogOnModel>" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <title>供应链管理平台 登录</title>
    <script src="<%: Url.Content("~/Scripts/jquery.min.js") %>" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $(window).keydown(function (event) {
                if (event.which == 13) {
                    $("#btnSubmit").click();
                    return false;
                }
            });
            $("#h_s").click(function () {
                $("#span_Search").show();
            });
        });
        function OpenEdit() {
            $("#dlg").dialog('open');
        }
        function Search() {
            if ($.trim($("#reg_Code").val()).length != 36) {
                alert("请输入正确注册查询码！");
                return false;
            }
            window.location.href = "<%: Url.Content("~/Home/RegisterEdit/")%>" + $.trim($("#reg_Code").val());
        }
    </script>
    <style type="text/css">
        body
        {
            background:url("Images/Login/bg.jpg") repeat-x scroll 0 0;
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
                    <td colspan="2" style="text-align: center;">
                        <input class="login_btn" style="text-align: center; letter-spacing: 2px;" type="submit"
                            value="登录" onmouseover="this.style.cursor='hand'" />
                    </td>
                </tr>
                <tr class="login_tr">
                    <td width="60">
                    </td>
                    <td width="192" style="text-align: left;">
                        <span style="margin-left: 25px;"><a href="#" onclick="window.location.href='<%: Url.Content("~/home/Register")%>'">
                            注册</a>/<a href="#" id="h_s">注册查询</a></span>
                    </td>
                </tr>
                <tr class="login_tr">
                    <td colspan="2" style="text-align: left;">
                        <span id="span_Search" style="display: none;">
                            <input id="reg_Code" class="easyui-textbox" style="width: 150px;" /><input type="button"
                                id="btnSearch" value="注册查询" onclick="Search();" /></span>
                    </td>
                </tr>
            </table>
            </form>
        </div>
    </div>
</body>
</html>
