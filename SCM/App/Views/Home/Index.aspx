<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>SCM管理平台</title>
    <script src="<%: Url.Content("~/Scripts/jquery.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/jquery.easyui.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/locale/easyui-lang-zh_CN.js") %>" type="text/javascript"></script>
    <link href="<%: Url.Content("~/Res/easyui/themes/icon.css") %>" rel="stylesheet"
        type="text/css" />
    <link href="<%: Url.Content("~/Res/easyui/themes/default/easyui.css") %>" rel="stylesheet"
        type="text/css" />
    
    <script src="<%: Url.Content("~/Scripts/Easyui_Tab.js") %>" type="text/javascript"></script>
    <script type="text/javascript">

        function ShowCenterHtml(obj) {
            addTab(obj.text(), obj.attr("rel"), "icon-save", true);
        } //


        $(function () {

            //  CallBackByID(''); //加载第一个默认模块
            $('#loginOut').click(function () {

                $.messager.confirm('系统提示', '您确定要退出本次登录吗?', function (r) {

                    if (r) {
                        location.href = 'Account/LogOff';
                    }
                });
            });
            $('#ChangePassword').click(function () {
                showMyWindow("修改密码", "Account/ChangePassword");
            });
        });


        function showMyWindow(title, href, width, height, modal, minimizable, maximizable) {

            $('#myWindow').window({
                title: title,
                width: width === undefined ? 600 : width,
                height: height === undefined ? 450 : height,
                content: '<iframe scrolling="yes" frameborder="0"  src="' + href + '" style="width:100%;height:98%;"></iframe>',
                //        href: href === undefined ? null : href, 
                modal: modal === undefined ? true : modal,
                minimizable: minimizable === undefined ? false : minimizable,
                maximizable: maximizable === undefined ? false : maximizable,
                shadow: false,
                cache: false,
                closed: false,
                collapsible: false,
                resizable: false,
                loadingMessage: '正在加载数据，请稍等片刻......'
            });

        }
    </script>
    <style type="text/css">
        body
        {
            font-family: 微软雅黑,新宋体;
        }
        a
        {
            color: Black;
            text-decoration: none;
        }
        .easyui-tree li
        {
            margin: 5px 0px 0px 0px;
            padding: 1px;
        }
        
        #mainlogo
        {
            position: absolute;
            top: 0px;
            left: 0px;
            width: 575px;
            height: 72px;
        }
        #center
        {
            padding-left: 575px;
            padding-right: 425px;
        }
        #mainctrl
        {
            position: absolute;
            top: 0px;
            right: 0px;
            height: 72px;
            width: 425px;
        }
        
        
        .wel
        {
            height: 30px;
            line-height: 30px;
            color: #FFFFFF;
            font-size: 14px;
            text-align: right;
            padding-right: 5px;
        }
        .ctr
        {
            vertical-align: middle;
            margin-top: 18px;
            height: 22px;
            text-align: right;
            float: right;
        }
        
        .ctr li
        {
            float: left;
            list-style: none;
        }
        .zi
        {
            /*在1.4版本中修改*/
            background-image: url(../images/beijing.gif);
            background-repeat: repeat-x;
            padding-right: 6px;
            padding-left: 3px;
        }
        
        
        a.v1:visited, a.v1:active, a.v1:link
        {
            font-size: 14px;
            color: #000;
            text-decoration: none;
        }
        a.v1:hover
        {
            font-size: 14px;
            color: #005500;
            text-decoration: none;
        }
        .easyui-accordion
        {
            width: 180px;
        }
        /* .index_alink
        {
            color: #FFF;
        }
        .accordion .accordion-header
        {
            background-color: #196ee2;
        }
        .panel-header
        {
            background-color: #196ee2;
        }
        .panel-title
        {
            color: #FFF;
        }
        .accordion .accordion-header-selected .panel-title
        {
            color: #FFF;
        }
        .accordion .accordion-header-selected .panel-title {
            color: #FFF;
        }
        .panel-header {
            background: #196ee2;
        }*/
        .layout-panel-center .panel-tool
        {
            left: 50px;
            right: auto;
        }
       
    </style>
</head>
<body class="easyui-layout">
    <noscript>
        <div style="position: absolute; z-index: 100000; height: 2046px; top: 0px; left: 0px;
            width: 100%; background: white; text-align: center;">
            <img src="images/noscript.gif" alt='抱歉，请开启脚本支持！' />
        </div>
    </noscript>
    <div region="north" split="false" border="false" style="overflow: hidden; height: 60px;
        background: url(Images/Login/title.jpg) no-repeat; font-family: Verdana, 微软雅黑,黑体">
        <span style="float: right; padding-right: 20px; padding-top: 35px;">欢迎[<%= ViewData["PersonName"]%>]&nbsp;[<%= ViewData["Department"]%>]&nbsp;<a
            href="#" class="index_alink" id="ChangePassword">修改密码</a> <a class="index_alink"
                href="#" id="loginOut">安全退出</a> </span>
    </div>
    <div region="west" hide="true" split="true" title="导航菜单" style="width: 160px;" id="west">
        <div class="easyui-accordion" id="leftMenu" fit="true" border="false">
            <%=ViewData["FirstMenu"] %>
        </div>
    </div>
    <div id="mainPanle" region="center" class="easyui-panel" title='欢迎使用SCM管理系统' data-options="iconCls:'icon-save'"
        style="background: #eee; overflow-y: hidden;">
        <%--<iframe name="centerFrame" id="centerFrame" height="100%" width="100%" border="0"
            frameborder="0" src='system/SCM_D_REPORT/ListIndex'>浏览器不支持嵌入式框架，或被配置为不显示嵌入式框架。</iframe>--%>
        <div id="tabs" class="easyui-tabs" fit="true" border="false" margin="false">
        </div>
    </div>
</body>
<div region="south" split="true" style="height: 29px;">
    <div style="padding: 0px; margin-left: 50%;">
        SCM管理平台
    </div>
</div>
<div id="mm" class="easyui-menu" style="width: 150px;">
    <div id="mm-tabupdate">
        刷新</div>
    <div class="menu-sep">
    </div>
    <div id="mm-tabclose">
        关闭</div>
    <div id="mm-tabcloseall">
        全部关闭</div>
    <div id="mm-tabcloseother">
        除此之外全部关闭</div>
    <div class="menu-sep">
    </div>
    <div id="mm-tabcloseright">
        当前页右侧全部关闭</div>
    <div id="mm-tabcloseleft">
        当前页左侧全部关闭</div>
    <div class="menu-sep">
    </div>
    <div id="mm-exit">
        退出</div>
</div>
<div id="myWindow">
</div>
</html>
