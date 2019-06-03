<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    公告发布
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div id="tb">
        <div>
      
             创建时间:
            <input class="easyui-datebox" id="startDate"  column="CREATE_TIME" style="width: 100px" />
            -
            <input class="easyui-datebox" id="endDate"  column="CREATE_TIME" style="width: 100px" />
            主题：<input class="easyui-textbox" id="NAME" style="width: 100px" />
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
 </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
        $(function () {
            $('#flexigridData').datagrid({
                iconCls: 'icon-site',
                url: '<%: Url.Content("~/System/SCM_D_REPORT/GetData")%>',
                fitColumns: true,
                fit: true,
                idField: 'ID',
                sortName: 'CREATE_TIME',
                sortOrder: 'desc',
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
                }],
                columns: [
                    [{
                        field: 'ID',
                        title: 'ID',
                        width: 380,
                        hidden: true
                    }, {
                        field: 'NAME',
                        title: '标题',
                        width: 120
                    }
                    ]
		],
                    pagination: true,
                    rownumbers: true

            });
        });

        //调整表格高度
        function ResizeGrid() {

            var newHeight = parent.$('#tabs').tabs('getSelected').panel('options').height - 15;

            $("#flexigridData").treegrid('resize', {
                height: newHeight
            });

        }

        //“查询”按钮，弹出查询框
        function flexiQuery() {

            //将查询条件按照分隔符拼接成字符串
            var search = "";
            $('#divQuery').find(":text,:selected,select,textarea,:hidden,:checked,:password").each(function () {
                search = search + this.id + "&" + this.value + "^";
            });
            //执行查询                        
            $('#flexigridData').treegrid('reload', {
                search: search
            });

        };

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

            window.location.href = '<%: Url.Content("~/System/SCM_D_REPORT/Create")%>';
            return false;
        }
        //导航到修改的按钮
        function flexiModify() {

            var arr = $('#flexigridData').datagrid('getSelections');

            if (arr.length == 1) {
                if (arr[0].ID) {
                    window.location.href = '<%: Url.Content("~/System/SCM_D_REPORT/Edit/")%>' + arr[0].ID;
                } else {
                    $.messager.alert('操作提示', '请选择一条记录!', 'warning');
                    return false;
                }
            } else {
                $.messager.alert('操作提示', '请选择一条记录!', 'warning');
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
                    $.post('<%: Url.Content("~/System/SCM_D_REPORT/Delete")%>', {
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
        function btnSearch() {
            $("#flexigridData").datagrid("reload", {
                dtBeginTime: $("#startDate").datebox('getValue'),
                dtEndtime: $("#endDate").datebox('getValue'),
                NAME:$("#NAME").val()
            });
            $("#flexigridData").datagrid("clearSelections");
        }
    </script>
</asp:Content>
