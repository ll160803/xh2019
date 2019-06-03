<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_COM_DEPART>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    部门
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
        $(function () {

            $('#flexigridData').treegrid({
                title: '部门',
                iconCls: 'icon-site',
                url: '<%: Url.Content("~/System/SysDepartment/GetAllMetadata")%>',
                idField: 'ID',
                fitColumns: true,
                fit: true,
                treeField: 'NAME',
                rownumbers: true,
                sortName: 'ID',
                sortOrder: 'asc',
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
                    [{
                        field: 'NAME',
                        title: '名称',
                        width: 150
                    }, {
                        field: 'CODE',
                        title: '编码',
                        width: 80
                    }, {
                        field: 'TYPE_NAME',
                        title: '组织类型',
                        width: 80
                    },
                    {
                        field: 'FAX',
                        title: '传真',
                        width: 80
                    },
                    {
                        field: 'PHONE',
                        title: '电话',
                        width: 80
                    },
                    {
                        field: 'DROP_DATE',
                        title: '撤销日期',
                        width: 100,
                        formatter: function (value, rec) {
                            if (value) {
                                return dateConvert(value);
                            }
                        }
                    },
                    {
                        field: 'ADDRESS',
                        title: '地址',
                        width: 110
                    },
                    {
                        field: 'POST_CODE',
                        title: '邮政编码',
                        width: 80
                    }

		]
	]
            });

            //            //ResizeGrid();

                        //如果列表页出现在弹出框中，则只显示查询和选择按钮 
                         var parent = window.dialogArguments; //获取父页面
                         if (parent == "undefined" || parent == null) {
            //                //异步获取按钮
            //                var iframeid; //iframe标签的id值
            //                var fs = window.parent.document.getElementsByTagName("iframe");
            //                for (var i = 0; i < fs.length; i++) {
            //                    var iframe = fs[i];
            //                    var contentWindow = iframe.contentWindow;
            //                    if (window == contentWindow) {
            //                        iframeid = iframe.id;

            //                    }
            //                }

            //                //关闭AJAX相应的缓存
            //                $.ajaxSetup({
            //                    cache: false
            //                });

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


        });

        //调整表格高度
        function ResizeGrid() {

            var newHeight = parent.$('#tabs').tabs('getSelected').panel('options').height - 15;

            $("#flexigridData").treegrid('resize', {
                height: newHeight
            });

        }

        function flexiSelect() {
            var node = $('#flexigridData').treegrid('getSelected');
            if (!node) {
                $.messager.alert('操作提示', '请选择一条数据!', 'warning');
                return false;
            }
            var arr = new Array(0);
            arr.push(node.ID);
            arr.push("^"); //主键列和显示列的分割符 ^ 
            arr.push(node.NAME);
            //主键列和显示列之间用 ^ 分割   每一项用 , 分割
            if (arr.length == 3) { //一条数据和多于一条
                returnParent(arr.join("&")); //每一项用 & 分割
            }
            return false;
        }
        //导航到查看详细的按钮
        function getView() {

            var arr = $('#flexigridData').treegrid('getSelected');

            if (arr) {
                window.location.href = "../SysDepartment/Details/" + arr.ID;

            } else {
                $.messager.alert('操作提示', '请选择一条数据!', 'warning');
            }
            return false;
        }
        //导航到创建的按钮
        function flexiCreate() {

            window.location.href =  '<%: Url.Content("~/System/SysDepartment/Create")%>';
            return false;
        }
        //导航到修改的按钮
        function flexiModify() {

            var arr = $('#flexigridData').treegrid('getSelected');

            if (arr) {
                window.location.href = '<%: Url.Content("~/System/SysDepartment/Edit/")%>' + arr.ID;

            } else {
                $.messager.alert('操作提示', '请选择一条数据!', 'warning');
            }
            return false;
        };
        //删除的按钮
        function flexiDelete() {

            var node = $('#flexigridData').treegrid('getSelected');
            if (!node) {
                $.messager.alert('操作提示', '请选择数据!', 'warning');

            } else {
                $.messager.confirm('操作提示', "确认删除这1项吗？", function (r) {
                    if (r) {
                        $.post( '<%: Url.Content("~/System/SysDepartment/Delete")%>', {
                            query: node.ID
                        }, function (res) {
                            if (res == "OK") {
                                remove();//客户端删除 不刷新
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
            }
            return false;
        };


        function remove() {
            var node = $('#flexigridData').treegrid('getSelected');
            if (node) {
                $('#flexigridData').treegrid('remove', node.ID);
            }
        }
    </script>
</asp:Content>
