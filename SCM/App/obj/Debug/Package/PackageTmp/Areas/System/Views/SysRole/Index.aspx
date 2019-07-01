<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
<script type="text/javascript" language="javascript">
    $(function () {

        $('#flexigridData').datagrid({
            title: '角色定义', //列表的标题
            iconCls: 'icon-site',
            fitColumns: true,
            fit: true,
            nowrap: false,
            striped: true,
            collapsible: false,
            singleSelect: true,
            url: '<%: Url.Content("~/System/SysRole/GetData")%>', //获取数据的url
            sortName: 'ID',
            sortOrder: 'asc',
            idField: 'ID',

            toolbar: [

            {
                text: '设置表单权限',
                iconCls: 'icon-search',
                handler: function () {
                    return SetFormRole();
                }
            }, {
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
                    field: 'NAME',
                    title: '角色名称',
                    width: 120
                }, {
                    field: 'DISCRIPTION',
                    title: '角色描述',
                    width:'150'
                }
               
            ]
        ],
            pagination: true,
            rownumbers: true

        });



    });
    //导航到创建的按钮
    function SetFormRole() {

        var arr = $('#flexigridData').datagrid('getSelections');

        if (arr.length == 1) {
           // alert(arr[0].NAME);
            if (arr[0].NAME) {
                var url = '<%: Url.Content("~/System/SysRole/SetFormRole/")%>' + $.trim(arr[0].ID) + "?Name=" + arr[0].NAME;
                window.location.href = url;
            } else {
                $.messager.alert('操作提示', '请选择一个用户!', 'warning');
                return false;
            }
        } else {
            $.messager.alert('操作提示', '请选择一个用户!', 'warning');
        }
        return false;
        return false;
    }
    //导航到创建的按钮
    function flexiCreate() {

        window.location.href = "<%: Url.Content("~/System/SysRole/Create")%>";
        return false;
    }
    //导航到修改的按钮
    function flexiModify() {
        var arr = $('#flexigridData').datagrid('getSelections');

        if (arr.length == 1) {
            window.location.href = "<%: Url.Content("~/System/SysRole/Edit/")%>" + arr[0].ID;

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
                $.post("<%: Url.Content("~/System/SysRole/Delete")%>", {
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
