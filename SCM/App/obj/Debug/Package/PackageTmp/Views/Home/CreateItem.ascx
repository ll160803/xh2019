<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>
<script src="<%: Url.Content("~/Scripts/jquery.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Res/easyui/jquery.easyui.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Res/easyui/locale/easyui-lang-zh_CN.js") %>" type="text/javascript"></script>
<link href="<%: Url.Content("~/Res/easyui/themes/icon.css") %>" rel="stylesheet"
    type="text/css" />
<link href="<%: Url.Content("~/Res/easyui/themes/default/easyui.css") %>" rel="stylesheet"
    type="text/css" />
<link href="<%: Url.Content("~/Content/default.css") %>" rel="stylesheet" type="text/css" />
<%=ViewData["Menu"]%>
