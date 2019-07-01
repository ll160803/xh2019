<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_SCM_D_REPORT>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>公告详情</title>
    <script language="javascript" type="text/javascript">
        ///查看附件
        function DownFile(id) {

            window.open("<%: Url.Content("~/UploadFile/BaseInfo/")%>" + id, '_blank')

        }
    </script>
</head>
<body>
    <div>
       <%:new HtmlString(Model.COMMENTS) %>
    </div>
    <div><%:new HtmlString(ViewBag.FileStr) %></div>
</body>
</html>
