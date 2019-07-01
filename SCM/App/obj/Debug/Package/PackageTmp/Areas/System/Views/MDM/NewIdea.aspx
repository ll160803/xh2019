<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>扩展服务</title>
    <script src="<%: Url.Content("~/Scripts/jquery.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/jquery.easyui.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/locale/easyui-lang-zh_CN.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/datagrid-detailview.js") %>" type="text/javascript"></script>
    <link href="<%: Url.Content("~/Res/easyui/themes/icon.css") %>" rel="stylesheet"
        type="text/css" />
    <link href="<%: Url.Content("~/Res/easyui/themes/default/easyui.css") %>" rel="stylesheet"
        type="text/css" />
    <script language="javascript" type="text/javascript">
    function NoNESS(ID)
    {
      SetVisit(ID,'0');
    }
        function NESS(ID)
    {
      SetVisit(ID,'1');
    }
        function SetVisit(ID,flag) {
             $.post("<%: Url.Content("~/System/MDM/SetVISIT")%>", {
                        ID:ID,
                        Flag:flag
                    }, function (res) {
                       
                    });
                     $.messager.alert('操作提示', '谢谢关注!', 'info');
        }
    </script>
</head>
<body>
    <ul>
        1.信息查询：
        <li>1.1 查询供货信息的状态，是否创建，是否完成收货，是否发票校验，是否过账。<input type="button" value="无用" onclick="NoNESS('1');" />
            <input type="button" value="有用" onclick="NESS('1');" /></li>
        <li>1.2 查询某年某月内，某个物料（药品），医院的需求数量。<input type="button" value="无用" onclick="NoNESS('2');" />
            <input type="button" value="有用" onclick="NESS('2');" /></li>
        <li>1.3 查询某年某月内，某个药品的供应情况，比如药品A，2016年12月，医院的需求量是1000，供应数量是400。<input type="button"
            value="无用" onclick="NoNESS('3');" />
            <input type="button" value="有用" onclick="NESS('3');" /></li>
        <li>1.4 某种药品的规格查询，比如药品A，会搜索到A1，A2，A3等药品规格。<input type="button" value="无用" onclick="NoNESS('4');" />
            <input type="button" value="有用" onclick="NESS('4');" /></li>
        <li>1.5 查询某年某月内，供货的所有药片清单。<input type="button" value="无用" onclick="NoNESS('5');" />
            <input type="button" value="有用" onclick="NESS('5');" /></li>
        <li>1.6 查询某个时间段内已开发票的金额，某个时间段供货数量<input type="button" value="无用" onclick="NoNESS('6');" />
            <input type="button" value="有用" onclick="NESS('6');" /></li>
    </ul>
    <ul>
        2.接口
        <li>2.1 供应商和SCM药品对应，对应模式需要供应商提供。<input type="button" value="无用" onclick="NoNESS('7');" />
            <input type="button" value="有用" onclick="NESS('7');" /></li>
        <li>2.2 提供供应计划，excel导入功能<input type="button" value="无用" onclick="NoNESS('8');" />
            <input type="button" value="有用" onclick="NESS('8');" /></li>
    </ul>
    <ul>
        3.打印
        <li>3.1 MeadX打印 支持ie8<input type="button" value="无用" onclick="NoNESS('9');" />
            <input type="button" value="有用" onclick="NESS('9');" /></li>
        <li>3.2 LODOP打印，支持ie,遨游，360，火狐等主流浏览器<input type="button" value="无用" onclick="NoNESS('10');" />
            <input type="button" value="有用" onclick="NESS('10');" /></li>
    </ul>
    <ul>
        4.报表
        <li>支持供应关于供应计划的各种报表，饼状图，立体图，增长曲线，年度数据比较等。<input type="button" value="无用" onclick="NoNESS('11');" />
            <input type="button" value="有用" onclick="NESS('11');" /></li>
    </ul>
</body>
</html>
