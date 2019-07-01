<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script src="<%: Url.Content("~/Scripts/jquery.min.js")%>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Lodop/LodopFuncs.js")%>" type="text/javascript"></script>
    <object id="LODOP_OB" classid="clsid:2105C259-1E0C-4534-8141-A753534CB4CA" width="0"
        height="0">
        <embed id="LODOP_EM" type="application/x-print-lodop" width="0" height="0"></embed>
    </object>
    <meta name="viewport" content="width=device-width" />
    <style media="print" type="text/css">
        .noprint
        {
            display: none;
        }
    </style>
    <script type="text/javascript" language="javascript">
        var LODOP;
        function PrintPrintPage() {
            LODOP = getLodop();
            LODOP.PRINT_INIT("条码打印");
            LODOP.ADD_PRINT_HTM(10, 10, $("#print").width(), $("#print").height(), document.getElementById("print").innerHTML);
            LODOP.SET_PRINT_PAGESIZE(1, 2100, 2970, "");
            // LODOP.PREVIEW();
            LODOP.PRINTA(); //直接打印在默认打印机
        }
        function PrintPreviewPage() {
            LODOP = getLodop();
            LODOP.PRINT_INIT("条码打印");
            LODOP.ADD_PRINT_HTM(10, 10, $("#print").width(), $("#print").height(), document.getElementById("print").innerHTML);
            LODOP.SET_PRINT_PAGESIZE(1, 2100, 2970, "");
            LODOP.PREVIEW();
            //LODOP.PRINT();
        }
    </script>
</head>
<body style="margin: 0; border: 0; padding: 0;">
    <form id="form1" runat="server">
    <div id="print" style="border: 0px; width: 1000px; position: absolute; top: 0px; left: 10px;">
        <%:ViewBag.PrintStr %>
    </div>
    <div style="position: fixed; z-index: 1000; right: 5px; top: 10px;">
        <input id="idPrint1" class="noprint" type="button" value="打印" onclick="PrintPrintPage();" />
        <input id="Button1" class="noprint" type="button" value="打印预览" onclick="PrintPreviewPage();" />
<%--        <input id="Button2" class="noprint" type="button" onclick="window.history.go(-1);"
            value="返回" />--%>
    </div>
    </form>
</body>
</html>
