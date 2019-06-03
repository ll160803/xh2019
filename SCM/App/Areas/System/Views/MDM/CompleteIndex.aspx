<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <div id="tb">
        <div>
        <a href="#" class="easyui-linkbutton" onclick="Export();" iconcls="icon-save"
                    plain="true">导出</a>
             创建时间:
            <input class="easyui-datebox" id="startDate" value="<%:ViewBag.LastDay%>" column="CREATE_TIME" style="width: 100px" />
            -
            <input class="easyui-datebox" id="endDate" value="<%:ViewBag.NowDay %>" column="CREATE_TIME" style="width: 100px" />
            供应商帐号：<input class="easyui-textbox" id="GYSAccount" style="width: 100px" />
            供应商名称：<input class="easyui-textbox" id="GysName" style="width: 100px" />
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
 </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
 <script type="text/javascript" language="javascript">
     $(function () {

         $('#flexigridData').datagrid({
             title: '供货率', //列表的标题
             iconCls: 'icon-site',
             fit: true,
             nowrap: false,
             striped: true,
             collapsible: false,
             singleSelect: true,
             url: '<%: Url.Content("~/System/MDM/GetCompleteData")%>', //获取数据的url
             sortName: 'CODE',
             sortOrder: 'asc',
             idField: 'CODE',
             toolbar:'#tb',
             columns: [
            [

                {
                    field: 'CODE',
                    title: '供应商账号',
                    width: 120
                }
                , {
                    field: 'NAME',
                    title: '供应商名称',
                    width: 150
                }, {
                    field: 'RANK_NUM',
                    title: '排名次序',
                    width: 120

                }, {
                    field: 'Percent',
                    title: '供货率',
                    width: 120,
                    formatter: function (value, row) {
                        return value + "%";
                    }
                }

            ]
        ],
             pagination: true,
             rownumbers: true

         });



     });
    function btnSearch() {
        $("#flexigridData").datagrid("reload", {
            dtBeginTime: $("#startDate").datebox('getValue'),
            dtEndtime: $("#endDate").datebox('getValue'),
            GysAccount: $("#GYSAccount").val(),
            GysName: $("#GysName").val()
        });
        $("#flexigridData").datagrid("clearSelections");
    }
    function Export() {
        var opts = $("#flexigridData").datagrid('options');
        //将查询条件按照分隔符拼接成字符串
        $.post("<%: Url.Content("~/System/MDM/ExportRankNum")%>",
                {
                    dtBeginTime: $("#startDate").datebox('getValue'),
                    dtEndtime: $("#endDate").datebox('getValue'),
                    GysAccount: $("#GYSAccount").val(),
                    GysName: $("#GysName").val()
                }, function (res) {
                    window.location.href = res;
                });
    };
</script>
</asp:Content>
