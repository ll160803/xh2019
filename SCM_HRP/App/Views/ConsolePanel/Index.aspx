<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
    <script src="<%: Url.Content("~/Scripts/jquery.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/JScriptIndex.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/jquery.easyui.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/locale/easyui-lang-zh_CN.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/locale/easyui-lang-zh_CN.js") %>" type="text/javascript"></script>

    <link href="<%: Url.Content("~/Res/easyui/themes/default/easyui.css") %>" rel="stylesheet"
        type="text/css" />
    <script src="<%: Url.Content("~/Scripts/JScriptCommon.js") %>" type="text/javascript"></script>
    <link href="<%: Url.Content("~/Res/easyui/themes/icon.css") %>" rel="stylesheet"
        type="text/css" />
    <link href="<%: Url.Content("~/Content/StyleSheet.css") %>" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #layer_workFlow a
        {
            text-decoration: none;
        }
        #layer_workFlow a:visited
        {
            text-decoration: none;
        }
        #layer_Notice a
        {
            text-decoration: none;
        }
        #layer_Notice a:visited
        {
            text-decoration: none;
        }
    </style>
    <script type="text/javascript">
        $(function () {
            var width = ($("#divNorth").width());
            $('#layer_Notice').panel('resize', {
                width: width / 2,
                height: 253
            });
            $('#layer_workFlow').panel('resize', {
                width: width / 2,
                height: 253
            });
            GetData();
            GetNotice();
        });


        function PageRedirect(url, id, title) {
            if (url && id && url != '-') {
                window.parent.addTab(title, url + "/" + id, 'tu0814', true, id);
            } else {
                $.messager.alert('操作提示', '请联系统管理员配置页面!', 'warning');
            }
        }




        function GetData() {
            $("#layer_workFlow").html("");
            $.ajax({
                url: "../../WC_SYSTEM_WORKFLOWTYPE/GetWorkFlowStatusData",
                data: null,
                dataType: "json",
                cache: false,
                success: function (data) {
                    if (data != null) {

                        for (var i = 0; i < data.length; i++) {

                            $("#layer_workFlow").append("<a href='#' onclick=\"PageRedirect('" + data[i].Url + "','" + data[i].WorkFlowStautsGuid + "','【流程审核】')\" >【" + data[i].WorkFlowTypeName + "】-" + data[i].WorkFlowStautsName + "-[" + data[i].Count + "条]" + "</a>" + "</br></br>");


                        }
                    }

                }
            });
        }
        //显示弹出dialog
        function showdialog(Content, Title, createTime, CreatePerson) {


            $("#showdia").html("");
            $("#showdia").append("<div class=\"layer_notice_tra\"><div class=\"layer_notice_titlea\">" + Title + "</div><div class=\"layer_notice_createtimea\">发布时间：" + createTime + "发布人：" + CreatePerson + "</div><div class=\"layer_notice_contenta\">" + Content + "</div></div>");
            $("#showdia").window("open");
        };

        function GetNotice() {
            $("#layer_Notice").html("");
            $.ajax({
                url: "../Notice/GetDataNew",
                data: null,
                dataType: "json",
                cache: false,
                success: function (data) {
                    if (data) {
                        $(data).each(function (index, item) {
                            if (item) {
                                var title = "";
                                if (item.Title) {
                                    if (item.Title.length > 30) {
                                        title = item.Title.substring(0, 30) + "...";
                                    } else {
                                        title = item.Title;
                                    }
                                }
                                var createTime = "";
                                if (item.CreateTime) {
                                    createTime = dateConvert(item.CreateTime) + "&nbsp;&nbsp;";
                                }

                                $("#layer_Notice").append("<div class=\"layer_notice_tr\"><div class=\"layer_notice_title\"><a href=\"#\" onclick='showdialog(\"" + item.Content + "\",\"" + title + "\",\"" + createTime + "\",\"" + item.CreatePerson + "\")'>" + title + "</a></div><div class=\"layer_notice_createtime\"><a href=\"#\">" + createTime + "</a></div></div>");
                            }
                        });
                    }
                }
            });
        }


     
    </script>
</head>
<body class="easyui-layout">
    <div data-options="region:'north'" id="divNorth" style="height: 255px;">
        <div style="float: left;">
            <div id="layer_workFlow" class="easyui-panel" title="流程提醒信息" style="height: 253px;
                background: #fafafa; padding-left: 10px; padding-top: 10px;" data-options="closable:false,tools:[
				    {
					    iconCls:'icon-reload',
					    handler:function(){GetData();}
				    }]">
            </div>
        </div>
        <div style="float: left;">
            <div id="layer_Notice" class="easyui-panel" title="公告" style="height: 253px; background: #fafafa;
                padding-left: 10px; padding-top: 10px;" data-options="closable:false,tools:[
				    {
					    iconCls:'icon-reload',
					    handler:function(){GetNotice();}
				    }]">
            </div>
        </div>
    </div>
     <div data-options="region:'center'" id="divCenter"></div>
    <div id="showdia" class="easyui-dialog" title="公告" style="width: 500px; height:
    300px;" data-options="iconCls:'icon-save',modal:true,closed:true"> </div>
</body>
</html>
