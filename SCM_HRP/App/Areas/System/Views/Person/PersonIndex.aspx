<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    人员
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
        $(function () {
            $('#flexigridData').datagrid({
                title: '人员', //列表的标题
                iconCls: 'icon-site',
                url: '<%: Url.Content("~/System/Person/GetData")%>',
                fit: true,
                idField: 'ID',
                sortName: 'ID',
                sortOrder: 'asc',
                pagination: true,
                singleSelect:true,
                rownumbers: true,
                toolbar: [{
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
                , {
                    text: '重置密码',
                    iconCls: 'icon-save',
                    handler: function () {
                        return ResetPassword();
                    }
                }],
                columns: [
                    [{
                        field: 'ID',
                        title: 'ID',
                        width: 380,
                        hidden: true
                    },{
                        field: 'ID2',
                        checkbox:true
                    }, {
                        field: 'NAME',
                        title: '姓名',
                        width: 200
                    }, {
                        field: 'ROLENAME',
                        title: '角色',
                        width: 180
                    }, {
                        field: 'ACCOUNT',
                        title: '账号',
                        width: 120
                    }, {
                        field: 'PASSWORD',
                        title: '密码',
                        width: 150
                    }
                    ]
		]
            });

            //ResizeGrid();

            //如果列表页出现在弹出框中，则只显示查询和选择按钮 
            var parent = window.dialogArguments; //获取父页面
            //异步获取按钮          
            if (parent == "undefined" || parent == null) {
                //首先获取iframe标签的id值

                //                var iframeid = window.parent.$('#tabs').tabs('getSelected').find('iframe').attr("id");

                //                //                //然后关闭AJAX相应的缓存
                //                //                $.ajaxSetup({
                //                //                    cache: false
                //                //                });

                //                //获取按钮值
                //                $.getJSON("../Home/GetToolbar", {
                //                    id: iframeid
                //                }, function (data) {
                //                    if (data == null) {
                //                        return;
                //                    }
                //                    $('#flexigridData').treegrid("addToolbarItem", data);

                //                });

            } else {
                //添加选择按钮
                $('#flexigridData').treegrid("addToolbarItem", [{
                    "text": "选择",
                    "iconCls": "icon-ok",
                    handler: function () {
                        flexiSelect();
                    }
                }]);
            }
            //查询按钮样式
            $('.a4').mouseover(function () {
                this.style.background = 'rgb(113,4,4)';
            }).mouseout(function () {
                this.style.background = 'rgb(131,0,0)';
            });

        });

       

        //“选择”按钮，在其他（与此页面有关联）的页面中，此页面以弹出框的形式出现，选择页面中的数据
        function flexiSelect() {

            var rows = $('#flexigridData').treegrid('getSelections');
            if (rows.length == 0) {
                $.messager.alert('操作提示', '请选择数据!', 'warning');
                return false;
            }

            var arr = [];
            for (var i = 0; i < rows.length; i++) {
                arr.push(rows[i].ID);
            }
            arr.push("^");
            for (var i = 0; i < rows.length; i++) {
                arr.push(rows[i].NAME);
            }
            //主键列和显示列之间用 ^ 分割   每一项用 , 分割
            if (arr.length > 0) { //一条数据和多于一条
                returnParent(arr.join("&")); //每一项用 & 分割
            }
        }
        //导航到查看详细的按钮
        function getView() {

            var arr = $('#flexigridData').treegrid('getSelections');

            if (arr.length == 1) {
                window.location.href = '<%: Url.Content("~/System/Person/Details/")%>' + arr[0].ID;

            } else {
                $.messager.alert('操作提示', '请选择一条数据!', 'warning');
            }
            return false;
        }
        //导航到创建的按钮
        function flexiCreate() {

            window.location.href = '<%: Url.Content("~/System/Person/Create_Person")%>';
            return false;
        }
        //导航到修改的按钮
        function flexiModify() {

            var arr = $('#flexigridData').datagrid('getSelections');

            if (arr.length == 1) {
                if (arr[0].NAME) {
                    window.location.href = '<%: Url.Content("~/System/Person/Edit_Person/")%>' + arr[0].ID;
                } else {
                    $.messager.alert('操作提示', '请选择一个用户!', 'warning');
                    return false;
                }
            } else {
                $.messager.alert('操作提示', '请选择一个用户!', 'warning');
            }
            return false;

        };
        function ResetPassword() {
            var rows = $('#flexigridData').datagrid('getSelections');
            if (rows.length == 0) {
                $.messager.alert('操作提示', '请选择数据!', 'warning');
                return false;
            }

            var arr = [];
            for (var i = 0; i < rows.length; i++) {
                arr.push(rows[i].ID);
            }

            $.messager.confirm('操作提示', "确认重置这 " + arr.length + " 项吗？", function (r) {
                if (r) {
                    $.post('<%: Url.Content("~/System/Person/ResetPassword")%>', {
                        query: arr.join(",")
                    }, function (res) {
                        if (res == "OK") {
                            $('#flexigridData').datagrid("reload");
                            $('#flexigridData').datagrid("clearSelections");
                            $.messager.alert('操作提示', '密码重置成功!', 'info');
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
        }
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
                    $.post('<%: Url.Content("~/System/Person/Delete")%>', {
                        query: arr.join(",")
                    }, function (res) {
                        if (res == "OK") {
                            //移除删除的数据
                            $('#flexigridData').datagrid("reload");
                            $('#flexigridData').datagrid("clearSelections");
                            $.messager.alert('操作提示', '删除成功!', 'info');
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
