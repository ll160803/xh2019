<%@ Page Language="C#" ValidateRequest="false" Inherits="System.Web.Mvc.ViewPage<WCJD.DAL.Notice>" %>

<!DOCTYPE html>
<html>
<head id="Head1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>编辑通告</title>
    <script src="<%: Url.Content("~/Res/My97DatePicker/WdatePicker.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/JScriptCommon.js") %>" type="text/javascript"></script>
    <link href="<%: Url.Content("~/Content/StyleSheet.css") %>" rel="stylesheet" type="text/css" />
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    <script src="../../Scripts/jquery.unobtrusive-ajax.min.js" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/jquery.easyui.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/locale/easyui-lang-zh_CN.js") %>" type="text/javascript"></script>
    <link href="<%: Url.Content("~/Res/easyui/themes/icon.css") %>" rel="stylesheet"
        type="text/css" />
    <link href="<%: Url.Content("~/Res/easyui/themes/default/easyui.css") %>" rel="stylesheet"
        type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("#submit").click(function () {
                $.ajax({
                    type: 'POST',
                    url: "../../Notice/Edit",
                    data: $("#form1").serialize(),
                    success: function (data) {
                        var msg = data.substring(0, 1);
                        if (msg == 'F') {
                            $.messager.alert('错误提示', data); ;
                            return false;
                        } else
                            if (msg == 'S') {
                                $.messager.alert('信息提示', data, "info", function () {
                                    window.history.go(-1);
                                });

                            };
                        dataType: "json"
                    }
                });
            });
        });
    </script>
</head>
<body class="easyui-layout">
    <form id="form1" action="">
    <div id="content" region="center" title="编辑通告" style="padding: 5px;">
        <input id="submit" class="a2 f2" type="button" value="修改" />
        <input class="a2 f2" type="button" onclick="BackList('Notice')" value="返回列表" />
        <div class="bigdiv">
            <%: Html.HiddenFor(model => model.ID ) %>
            <%: Html.HiddenFor(model => model.UpdatePerson)%>
            <%: Html.HiddenFor(model => model.UpdateTime)%>
            <%: Html.HiddenFor(model => model.CreateTime)%>
            <%: Html.HiddenFor(model => model.CreatePerson)%>
            <input type="hidden" name="hidden" id="hidden" value="" />
            <div class="laytr">
                <div class="leftTD">
                    <div class="leftlabel">
                        <%: Html.LabelFor(model => model.Title) %>
                    </div>
                    <div class="righteditor">
                        <%: Html.EditorFor(model => model.Title)%>
                        <%: Html.ValidationMessageFor(model => model.Title)%>
                    </div>
                </div>
                <div class="rightTD">
                    <div class="leftlabel">
                    </div>
                    <div class="righteditor">
                    </div>
                </div>
            </div>
            <!--一行结束-->
            <div class="bottom">
                <div class="bottomleft">
                    <%: Html.LabelFor(model => model.Content) %>
                </div>
                <div class="bottomright">
                    <div class="textarea-box">
                        <%: Html.TextAreaFor(model => model.Content)%>
                        <%: Html.ValidationMessageFor(model => model.Content) %>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
