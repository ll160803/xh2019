<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    页面权限
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript">
        var myDate = new Date();
        var currenYear = GetCurrentYear();
        $(function () {
            $('#flexigridData').datagrid({
                title: '[页面权限设置] 当前角色是：<%= ViewData["myname"] %>  ',
                iconCls: 'icon-site',
                url: '<%: Url.Content("~/System/Form/GetFormDataByRoleID/")%>' + $("#UserId").val(),
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
                     title: '页面名称',
                     width: 120
                 },
                 {
                     field: 'isk2',
                     title: '权限设置',
                     halign: 'center',
                     align: 'center',
                     width: 80,
                     formatter: function (value, rowData) {
                         return "<a class='details' href='#' onclick=SettingFunction('" + rowData.ID + "')> </a>";
                     }

                 }
		        ]],
                onLoadSuccess: function (data) {
                    if (data) {

                        $.each(data.rows, function (index, item) {

                            if (item.IsCheck == 1) {

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
            $.post('<%: Url.Content("~/system/Form/SaveRoleForm")%>', { id: $("#UserId").val(), formIds: arr.join(",") }, function (res) {
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
            window.location.href = '<%: Url.Content("~/system/SysRole")%>';
            return false;
        };

      
       
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <input type="hidden" id="UserId" value="<%= ViewData["myid"] %>" />
    <div id="divFunction" class="easyui-dialog" title="权限设置" style="width: 400px; height: 120px;
        padding: 10px" data-options="iconCls:'icon-save',closed:true,buttons: [{  
					text:'保存',
					iconCls:'icon-ok',
					handler:function(){
						fileUploadSubPlan();
					}
				}]">
        <div id="flexigridData">
        </div>
    </div>
</asp:Content>
