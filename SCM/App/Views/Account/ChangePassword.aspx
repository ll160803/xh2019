<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Models.ChangePasswordModel>" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <title>修改密码</title>
    <script src="<%: Url.Content("~/Scripts/jquery.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    <style type="text/css">
        body
        {
            font-size: 12px;
            font-family: 微软雅黑,新宋体;
        
        }
        fieldset
        {
            margin: 0 auto;
            padding: 9px;
            border: 1px solid #CCC;
            width: 387px;
        }
        
        legend
        {
            font-size: 1.1em;
            font-weight: 600;
            padding: 2px 4px 8px 4px;
        }
        input[type="text"], input[type="password"]
        {
            width: 200px;
            border: 1px solid #CCC;
        }
        .editor-label
        {
            margin: 1em 0 0 0;
        }
        
        .editor-field
        {
            margin: 0.5em 0 0 0;
        }
        
        .field-validation-error, .validation-summary-errors
        {
            color: #ff0000;
        }
        .mbx
        {
            height: 23px;
            font-weight: bold;
            color: #9b6835;
            border-bottom: 1px #999 dotted;
            padding: 12px 19px 3px 19px;
            margin: 4px;
            background: url(../Images/direction.gif) 0 center no-repeat;
        }
        .buttonOn
        {
            background: url(../images/buttonOn_login.gif) left top no-repeat;
            height: 21px;
            width: 109px;
            text-align: center;
            border: 0px;
            margin: 9px,150px,0px,222px;
        }
    </style>
</head>
<body>
    <div class="mbx">
        修改密码
    </div>
    <% using (Html.BeginForm())
       { %>
    <div>
        <fieldset>
            <legend>用户名：
                <%: ViewBag.PersonNamea %>
            </legend>
            <div class="editor-label">
                <%: Html.LabelFor(m => m.OldPassword) %>
            </div>
            <div class="editor-field">
                <%: Html.PasswordFor(m => m.OldPassword) %>
                <%: Html.ValidationMessageFor(m => m.OldPassword) %>
            </div>
            <div class="editor-label">
                <%: Html.LabelFor(m => m.NewPassword) %>
            </div>
            <div class="editor-field">
                <%: Html.PasswordFor(m => m.NewPassword) %>
                <%: Html.ValidationMessageFor(m => m.NewPassword) %>
            </div>
            <div class="editor-label">
                <%: Html.LabelFor(m => m.ConfirmPassword) %>
            </div>
            <div class="editor-field">
                <%: Html.PasswordFor(m => m.ConfirmPassword) %>
                <%: Html.ValidationMessageFor(m => m.ConfirmPassword) %>
            </div>
            <p>
                <input class="easyui-linkbutton" type="submit" value="修改密码" />
            </p>
            <p>
                <%: Html.ValidationSummary(true) %>
            </p>
        </fieldset>
    </div>
    <% } %>
</body>
</html>

