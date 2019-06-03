<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    用户角色权限
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
        var myDate = new Date();
        var currenYear = GetCurrentYear();
        $(function () {
            $('#flexigridData').datagrid({
                title: '[用户角色设置] 当前用户是：<%= ViewData["myname"] %>  ',
                iconCls: 'icon-site',
                url: '<%: Url.Content("~/System/SysRole/GetRoleDataByUserID/")%>' + $("#UserId").val(),
                idField: 'ID',
                sortName: 'ID',
                sortOrder: 'asc',
                animate: true,
                checkbox: true,
                rownumbers: true,
                fitColumns: true,
                fit: true,
                selectOnCheck: true,
                checkOnSelect: true,
                toolbar: [
					{
					    text: '保存',
					    iconCls: 'icon-save',
					    handler: function () {
					        return getSave();
					    }
					}, {
					    text: '返回',
					    iconCls: 'icon-undo',
					    handler: function () {
					        return flexiModify();
					    }
					}],

                columns: [[
                {
                    field: 'IsCheck',
                    checkbox: true,
                    formatter: function (value, rec) {
                        if (value == 1) {
                            $(this).attr("checked", true);
                        }
                    }

                },
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
                     width: '150'
                 }
		        ]],
                onLoadSuccess: function (data) {
                    if (data) {
                       
                        $.each(data.rows, function (index, item) {
                            
                            if (item.IsCheck==1) {

                                $('#flexigridData').datagrid('checkRow', index);
                                
                            }
                            
                        });
                        
                    }
                }
            });
        });


        //保存
        function getSave() {
            
            var rows = $('#flexigridData').datagrid('getSelections');
           
            var arr = [];
            for (var i = 0; i < rows.length; i++) {
                arr.push(rows[i].ID);
            }
            $.post('<%: Url.Content("~/system/SysRole/SaveRoleSubject")%>', { id: $("#UserId").val(), roleIds: arr.join(",") }, function (res) {
                if (res == "OK") {
                    $.messager.alert('操作提示', '保存成功!', 'info');
                }
                else {
                    if (res == "") {
                        $.messager.alert('操作提示', '保存失败!请联系管理员。', 'info');
                    }
                    else {
                        $.messager.alert('操作提示', res, 'info');
                    }
                }
            });
            return false;
        }

        

        //返回
        function flexiModify() {
            window.location.href = '<%: Url.Content("~/system/person")%>';
            return false;
        };

      
       
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <input type="hidden" id="UserId" value="<%= ViewData["myid"] %>" />
</asp:Content>
