<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <div id="tb" style="padding: 5px; height: auto">
        <div>
            药品名称：<input class="easyui-textbox" id="NAME" style="width: 120px" />
            药品编码：<input class="easyui-textbox" id="CODE" style="width: 120px" />
             <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
        $(function () {

            $('#flexigridData').datagrid({
                title: 'HIS药品目录', //列表的标题
                iconCls: 'icon-site',
                fitColumns: true,
                fit: true,
                nowrap: false,
                striped: true,
                collapsible: false,
                singleSelect: true,
                url: '<%: Url.Content("~/System/SCM_COM_DRUG/GetData")%>', //获取数据的url
                sortName: 'ID',
                sortOrder: 'asc',
                idField: 'ID',
                columns: [
            [

                {
                    field: 'ID',
                    title: 'ID',
                    width: 120,
                    hidden: true
                }, {
                    field: 'CODE',
                    title: '药品编码',
                    width: 80,
                    sortable:true
                }
                , {
                    field: 'NAME',
                    title: '药品名称',
                    width: 150,
                    sortable: true
                }, {
                    field: 'SPEC',
                    title: '药品规格',
                    width: 120,
                    sortable: true

                }, {
                    field: 'FACTORY',
                    title: '生产厂家',
                    width: 80,
                    sortable: true
                }, {
                    field: 'MRJJ',
                    title: '药品进价',
                    width: 100,
                    sortable: true
                }

            ]
        ],
                pagination: true,
                rownumbers: true

            });



        });
        function btnSearch() {
            $("#flexigridData").datagrid("reload", {
                Name: $("#NAME").val(),
                Code: $("#CODE").val()
            });
            $("#flexigridData").datagrid("clearSelections");
        }
    </script>
</asp:Content>
