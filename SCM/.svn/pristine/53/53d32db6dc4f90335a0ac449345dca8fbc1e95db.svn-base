<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
        $(function () {

            $('#flexigridData').datagrid({
                title: '功能按钮', //列表的标题
                iconCls: 'icon-site',
                fitColumns: true,
                fit: true,
                nowrap: false,
                striped: true,
                collapsible: false,
                singleSelect: true,
                url: '<%: Url.Content("~/System/Com_ToolBar/GetData")%>', //获取数据的url
                sortName: 'DISPLAYINDEX',
                sortOrder: 'asc',
                idField: 'ID',

                toolbar: [

            {
                text: '创建',
                iconCls: 'icon-add',
                handler: function () {
                    return flexiCreate();
                }
            }, {
                text: '删除',
                iconCls: 'icon-remove',
                handler: function () {
                    return flexiDelete();
                }
            }, {
                text: '修改',
                iconCls: 'icon-edit',
                handler: function () {
                    return flexiModify();
                }
            }
        ],

                columns: [
            [

                {
                    field: 'ID',
                    title: 'ID',
                    width: 120,
                    hidden: true
                }, {
                    field: 'TEXT',
                    title: '按钮名称',
                    width: 100
                }
                , {
                    field: 'ICONCLS',
                    title: '按钮图标',
                    width: 100
                }, {
                    field: 'HANDLER',
                    title: '事件',
                    width: 120

                }, {
                    field: 'DISPLAYINDEX',
                    title: '索引',
                    width: 100
                }
            ]
        ],
                pagination: true,
                rownumbers: true

            });



        });

        //导航到创建的按钮
        function flexiCreate() {

            window.location.href = "../../System/Com_ToolBar/Create";
            return false;
        }
        //导航到修改的按钮
        function flexiModify() {
            var arr = $('#flexigridData').datagrid('getSelections');

            if (arr.length == 1) {
                window.location.href = "../../System/Com_ToolBar/Edit/" + arr[0].ID;

            } else {
                $.messager.alert('操作提示', '请选择一条数据!', 'warning');
            }
            return false;

        };
        //删除的按钮
        function flexiDelete() {

            var rows = $('#flexigridData').datagrid('getSelections');
            if (rows.length == 0) {
                $.messager.alert('操作提示', '请选择数据!', 'warning');
                return false;
            }

            var arr = [];
            for (var i = 0; i < rows.length; i++) {
                arr.push(rows[i].ID);
            }

            $.messager.confirm('操作提示', "确认删除这 " + arr.length + " 项吗？", function (r) {
                if (r) {
                    $.post("../../System/Com_ToolBar/Delete", {
                        query: arr.join(",")
                    }, function (res) {
                        if (res == "OK") {
                            //移除删除的数据

                            $.messager.alert('操作提示', '删除成功!', 'info');
                            $("#flexigridData").datagrid("reload");
                            $("#flexigridData").datagrid("clearSelections");
                        } else {
                            if (res == "") {
                                $.messager.alert('操作提示', '删除失败!请查看该数据与其他模块下的信息的关联，或联系管理员。', 'info');
                            } else {
                                $.messager.alert('操作提示', res, 'info');
                            }
                        }
                    });
                }
            });

        };
    </script>
</asp:Content>
