<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<WCJD.DAL.Notice>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    公告管理
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
        $(function () {

            $('#flexigridData').datagrid({
                title: '公告管理', //列表的标题
                iconCls: 'icon-site',
                fitColumns: true,
                fit: true,
                nowrap: false,
                striped: true,
                collapsible: false,
                singleSelect:true,
                url: '../Notice/GetData', //获取数据的url
                sortName: 'UpdateTime',
                sortOrder: 'asc',
                idField: 'ID',

                toolbar: [

            {
                text: '详细',
                iconCls: 'icon-search',
                handler: function () {
                    return getView();
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
                    title: '<%: Html.DisplayNameFor(model => model.ID) %>',
                    width: 120,
                    hidden: true
                }, {
                    field: 'Title',
                    title: '<%: Html.DisplayNameFor(model => model.Title) %>',
                    width: 180
                }
                , {
                    field: 'Content',
                    title: '<%: Html.DisplayNameFor(model => model.Content) %>',
                    width: 180
                }, {
                    field: 'CreateTime',
                    title: '<%: Html.DisplayNameFor(model => model.CreateTime) %>',
                    width: 120,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                }, {
                    field: 'CreatePerson',
                    title: '<%: Html.DisplayNameFor(model => model.CreatePerson) %>',
                    width: 120
                }, {
                    field: 'UpdateTime',
                    title: '<%: Html.DisplayNameFor(model => model.UpdateTime) %>',
                    width: 120,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                }, {
                    field: 'UpdatePerson',
                    title: '<%: Html.DisplayNameFor(model => model.UpdatePerson) %>',
                    width: 120
                }
            ]
        ],
                pagination: true,
                rownumbers: true

            });

            

            var parent = window.dialogArguments; //获取父页面
            if (parent == "undefined" || parent == null) {
                //    不是在iframe中打开的
            } else {
                //隐藏所有的按钮和分隔符
                $(".l-btn.l-btn-plain").hide();
                $(".datagrid-btn-separator").hide();
                //添加选择按钮
                $('#flexigridData').datagrid("addToolbarItem", [{
                    "text": "选择",
                    "iconCls": "icon-ok",
                    handler: function () {
                        flexiSelect();
                    }
                }]);
            }
        });
        

        //“查询”按钮，弹出查询框
        function flexiQuery() {

            //将查询条件按照分隔符拼接成字符串
            var search = "";
            $('#divQuery').find(":text,:selected,select,textarea,:hidden,:checked,:password").each(function () {
                search = search + this.id + "&" + this.value + "^";
            });
            //执行查询                        
            $('#flexigridData').datagrid('reload', {
                search: search
            });

        };
        //“导出”按钮     在6.0版本中修改
        function flexiExport() {

            //将查询条件按照分隔符拼接成字符串
            var search = "";
            $('#divQuery').find(":text,:selected,select,textarea,:hidden,:checked,:password").each(function () {
                search = search + this.id + "&" + this.value + "^";
            });

            var p = $('#flexigridData').datagrid('options').columns[0];
            var field = []; //所有的列名
            var title = []; //所有的标题名称
            $(p).each(function () {
                field.push(this.field);
                title.push(this.title);
            });

            $.post("../Notice/Export", {
                title: title.join(","),
                field: field.join(","),
                sortName: $('#flexigridData').datagrid('options').sortName,
                sortOrder: $('#flexigridData').datagrid('options').sortOrder,
                search: search
            }, function (res) {
                window.location.href = res;

            });
        };
        //“选择”按钮，在其他（与此页面有关联）的页面中，此页面以弹出框的形式出现，选择页面中的数据
        function flexiSelect() {

            var rows = $('#flexigridData').datagrid('getSelections');
            if (rows.length == 0) {
                $.messager.alert('操作提示', '请选择数据!', 'warning');
                return false;
            }

            var arr = [];
            for (var i = 0; i < rows.length; i++) {
                arr.push(rows[i].WorkFlowTypeGuid);
            }
            arr.push("^");
            for (var i = 0; i < rows.length; i++) {
                arr.push(rows[i].WorkFlowTypeName);
            }
            //主键列和显示列之间用 ^ 分割   每一项用 , 分割
            if (arr.length > 0) { //一条数据和多于一条
                returnParent(arr.join("&")); //每一项用 & 分割
            }
        }
        //导航到查看详细的按钮
        function getView() {

            var arr = $('#flexigridData').datagrid('getSelections');

            if (arr.length == 1) {
                window.location.href = "../Notice/Details/" + arr[0].ID;

            } else {
                $.messager.alert('操作提示', '请选择一条数据!', 'warning');
            }
            return false;
        }
        //导航到创建的按钮
        function flexiCreate() {

            window.location.href = "../Notice/Create";
            return false;
        }
        //导航到修改的按钮
        function flexiModify() {

            var arr = $('#flexigridData').datagrid('getSelections');

            if (arr.length == 1) {
                window.location.href = "../Notice/Edit/" + arr[0].ID;

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
                    $.post("../Notice/Delete", {
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
