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
    <script src="<%: Url.Content("~/Res/ECharts/echarts-all.js") %>" type="text/javascript"></script>
    <link href="<%: Url.Content("~/Res/easyui/themes/default/easyui.css") %>" rel="stylesheet"
        type="text/css" />
    <script src="<%: Url.Content("~/Scripts/Utils.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/JScriptCommon.js") %>" type="text/javascript"></script>
    <link href="<%: Url.Content("~/Res/easyui/themes/icon.css") %>" rel="stylesheet"
        type="text/css" />
    <link href="<%: Url.Content("~/Content/StyleSheet.css") %>" rel="stylesheet" type="text/css" />
    <script type="text/javascript">

        $(function () {
            $('#StartDate').datebox({
                required: false
            });

            $('#EndDate').datebox({
                required: false
            });
            $('#DepartmentGuid').combotree({
                url: '../../SysDepartment/GetDataByPersonIdByGuid/',
                width: '125',
                panelWidth: '300',
                valueField: 'Id',
                textField: 'Name'
            });
            var width = ($("#divNorth").width() - 20);
            var height = ($("#divCenter").height() - 16);
            $('#chart1').panel('resize', {
                width: width,
                height: 400
            });
            $('#chart2').panel('resize', {
                width: width,
                height: 400
            });
           
        });

        function ECharts(selector, options) {

            var self = this;

            var _selector;

            var chart;

            // 构造函数
            var constructor = function () {
                _selector = selector;
                chart = echarts.init(document.getElementById(_selector));
            };

            self.Init = function () {
                chart.setOption(options);
            };

            constructor();

        }
        function GetFaultData() {
            var departmentGuid = "";
            $("input[name='DepartmentGuid']").each(function () {
                if ($(this).is(":checked")) {
                    if (departmentGuid.length == 0) {
                        departmentGuid += $(this).val();
                    }
                    else {
                        departmentGuid += "," + $(this).val();
                    }
                }
            });
            $('#chart3').datagrid({
                title: '故障位置统计表', //列表的标题
                iconCls: 'icon-site',
                width: 'auto',
                height: 'auto',
                nowrap: false,
                striped: true,
                collapsible: true,
                url: '../../EChart/GetDates', //获取数据的url
                sortname: 'name',
                sortorder: 'desc',
                idfield: 'name',
                columns: [[
                    { field: 'name', title: '故障类型', width: 120 }

                , { field: 'value', sortable: true, title: '数量', width: 120 }

                , { field: 'percent', title: '百分比', width: 100 }
                ]],
                queryParams: {
                    departmentGuid: departmentGuid,
                    startDate: $("#StartDate").datebox('getValue'),
                    endDate: $("#EndDate").datebox('getValue')
                },
                pagination: true,
                rownumbers: true
            });
        }

        function GetChartData() {
            var departmentGuid = "";
            $("input[name='DepartmentGuid']").each(function () {
                if ($(this).is(":checked")) {
                    if (departmentGuid.length == 0) {
                        departmentGuid += $(this).val();
                    }
                    else {
                        departmentGuid += "," + $(this).val();
                    }
                }
            });
            $.post('../../EChart/ChartBreak/', {
                departmentGuid: departmentGuid,
                startDate: $("#StartDate").datebox('getValue'),
                endDate: $("#EndDate").datebox('getValue')

            }, function (data) {
                new ECharts('chart1', data).Init(); 
            });
        }

        function selectAllTM(obj) {
            if (obj.is(":checked")) {
                $("input[paren=" + obj.val() + "]").each(function () {
                    $(this).attr("checked", "checked");
                });
            } else {
                $("input[paren=" + obj.val() + "]").each(function () {
                    $(this).removeAttr("checked")
                });
            }
        }

        function GetChartDepartmentData() {
            var departmentGuid = "";
            $("input[name='DepartmentGuid']").each(function () {
                if ($(this).is(":checked")) {
                    if (departmentGuid.length == 0) {
                        departmentGuid += $(this).val();
                    }
                    else {
                        departmentGuid += "," + $(this).val();
                    }
                }
            });
            $.post('../../EChart/ChartDepartmentBreak/', {
                departmentGuid: departmentGuid,
                startDate: $("#StartDate").datebox('getValue'),
                endDate: $("#EndDate").datebox('getValue')
            }, function (data) {
                new ECharts('chart2', data).Init();
            });
        }

        function SearchQuery() {
            GetFaultData();
            GetChartData();
            GetChartDepartmentData();
        }
    </script>
    <style type="text/css">
        .td_F4 
        {
            border:solid #0ecfc9;
            border-width:2px 2px 0px 0px;
        }
        .tr2 
        {
            border:solid #0ecfc9;
            border-width:2px 2px 2px 0px;
        }
        .td_F
        {
            border: solid #0ecfc9;
            border-width: 0px 2px 2px 2px;
            text-align:center
        }
        .td_F2
        {
            border: solid #0ecfc9;
            border-width: 1px 2px 0px 0px;
            width:1200px;
        }
        .td_F3 
        {
            border: solid #0ecfc9;
            border-width: 2px 2px 0px 0px;
            width:1200px;
        }
        .td1
        {
            border-right: 2px solid #0ecfc9;
        }
        .td_S
        {
            border: solid #0ecfc9;
            border-width: 2px 2px 0px 2px;
        }
        .td_S2
        {
            border: solid #0ecfc9;
            border-width: 1px 1px 0px 0px;
            height:30px
        }
        .td_S3
        {
            border: solid #0ecfc9;
            border-width: 2px 1px 0px 0px;
            height:30px
        }
        .td2
        {
            border: solid #0ecfc9;
            border-width: 2px 2px 0px 2px;
        }
        .td_T2
        {
            border: solid #0ecfc9;
            border-width: 2px 2px 2px 2px;
            text-align:center;
        }
        .td_T
        {
            border: solid #0ecfc9;
            border-width: 2px 2px 2px 0px;
        }
        .td_M 
        {
            border: solid #0ecfc9;
            border-width: 0px 2px 2px 0px;
        }
    </style>
</head>
<body class="easyui-layout">
    <div data-options="region:'north', title:'查询条件'" style="height:207px">
    <div id="searchbox" class="easyui-panel searchPannel" style="background: #fafafa; padding:3px 3px 3px 3px"data-options="iconCls:'icon-search'" >
        <table cellpadding="0;" cellspacing="0;">
            <% 
                var parentList = ViewBag.Department as List<WCJD.DAL.SysDepartment>;
                var list = parentList.Where(p => p.ParentId == Guid.Parse("4CEAD24C-E17E-4E36-808E-90A9ED1A4259")).ToList();
                for (int j = 0; j < list.Count; j++)
                { %>
            <tr>
                <%if (j == 0) { %>
                <td rowspan="<%=list.Count %>" style="width: 80px; text-align:center" class="td_S">
                    部门：
                </td>
                <%} %>
                <td >
                    <table cellpadding="0;" cellspacing="0;">
                        <tr class="tr2">
                            <%if (j==0)
                              {%>
                                <td style="width: 100px;" class="td_S3">
                              <%}
                              else
                              {%>
                                <td style="width: 100px;" class="td_S2">  
                              <%} %>
                                <%if (list[j].Name.Equals("信息管理中心"))
                                  {%>
                                      <input id="Id" name="DepartmentGuid" type="checkbox" onclick="" value="<%=list[j].Id %>" /><%=list[j].Name%>
                                  <%}
                                  else
                                  {%>
                                    <input id="Checkbox1" name="Id" type="checkbox" onclick="selectAllTM($(this));" value="<%=list[j].Id %>" /><%=list[j].Name%>
                                  <%} %>
                            </td>
                            <%if (j==0)
                              {%>
                                <td class="td_F3">
                              <%}
                              else
                              {%>
                                <td class="td_F2">
                              <%} %>
                            
                                <% var listSub = parentList.Where(p => p.ParentId == list[j].Id).ToList();
                                   for (int k1 = 0; k1 < listSub.Count; k1++) { %>
                                <span style="width: 130px; display: block; float: left;">
                                    <input id="DepartmentGuid<%=k1 %>" name="DepartmentGuid" paren="<%=listSub[j].ParentId%>" type="checkbox" value="<%=listSub[k1].Id %>" /><%=listSub[k1].Name%></span>
                                <% } %> 
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <%} %>
            <tr>
                <td  class="td_T2">
                    时  间：
                </td>
                <td style=" padding-left: 41px; height:30px" class="td_T">
                    开始时间： &nbsp<input id="StartDate" type="text" />&nbsp&nbsp&nbsp&nbsp 结束时间： &nbsp<input id="EndDate" type="text" />
                </td>
            </tr>
            <tr>
                <td  class="td_F">
                    查  询：
                </td>
                <td class="td_M" style="text-align: center;height:30px ">
                    <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="SearchQuery();">
                        查询</a>
                </td>
            </tr>
        </table>
    </div>
    </div>
    <div data-options="region:'center'" id="divCenter">
        <div id="chart3">
        </div>
       <%-- <div id="chartBreakYear" class="easyui-panel" title="各故障类型" style="background: #fafafa;">
            <div id="chart1" class="easyui-panel">
            </div>
        </div>--%>
        <div id="chartPartmentBreak" class="easyui-panel" title="各故障位置" style="background: #fafafa; padding-left: 10px; padding-top: 10px;">
            <div id="chart2" class="easyui-panel">
            </div>
        </div>
    </div>
</body>
</html>
