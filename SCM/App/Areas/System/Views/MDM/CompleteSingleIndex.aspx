<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <div id="tb">
        <div>
             创建时间:
            <input class="easyui-datebox" id="startDate" value="<%:ViewBag.LastDay%>" column="CREATE_TIME" style="width: 100px" />
            -
            <input class="easyui-datebox" id="endDate" value="<%:ViewBag.NowDay %>" column="CREATE_TIME" style="width: 100px" />
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
             fitColumns: true,
             fit: true,
             nowrap: false,
             striped: true,
             collapsible: false,
             singleSelect: true,
             url: '<%: Url.Content("~/System/MDM/GetCompleteData")%>', //获取数据的url
             sortName: 'CODE',
             sortOrder: 'asc',
             idField: 'CODE',
             toolbar: '#tb',
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
                    width: 120
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
             GysAccount: '<%:ViewBag.GysAccount%>'
         });
         $("#flexigridData").datagrid("clearSelections");
     }
</script>
</asp:Content>
