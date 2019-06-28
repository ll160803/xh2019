<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <div id="tb" style="padding: 5px; height: auto">
        <div>
            药品名称：<input class="easyui-textbox" id="NAME" style="width: 120px" />
            药品代码：<input class="easyui-textbox" id="CODE" style="width: 120px" />
             <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
    var toolbar=
            [

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
        ];

        var columns = [
            [
                 { field: 'ID',
                     title: 'ID',
                     width: 120,
                     hidden: true
                 }
                , {
                    field: 'NAME',
                    title: '药品名称',
                    width: 150,
                    sortable: true
                }, {
                    field: 'CODE',
                    title: '药品编码',
                    width: 120, sortable: true

                }, {
                    field: 'SPEC',
                    title: '药品规格',
                    width: 120,
                    sortable: true
                }, {
                    field: 'FACTORY',
                    title: '生产厂家',
                    width: 120,
                    sortable: true
                }, {
                    field: 'HIS_NAME',
                    title: 'HIS药品名称',
                    width: 150,
                    sortable: true,
                    editor: {
                        type: 'combogrid',
                        options: {
                            idField: 'ID',
                            textField: 'NAME',
                            method: 'get',
                            striped: true,
                            panelWidth: 400,
                            pagination: true,
                            editable: true,
                            rownumbers: true,
                            url: '<%: Url.Content("~/System/SCM_COM_DRUG/GetComBoxData")%>',
                           
                            columns: [[
	                                   { field: 'CODE', title: '药品编码', width: 80,hidden: true },
	                                   { field: 'NAME', title: '药品名称', width: 120 },
	                                   { field: 'SPEC', title: '规格', width: 80 },
	                                   { field: 'FACTORY', title: '生产工厂', width: 120 }
	                                ]],
                            keyHandler: {
                                query: function (keyword) {

                                    $(this).combogrid("grid").datagrid('clearSelections');
                                   
                                    var queryParams = $(this).combogrid("grid").datagrid('options').queryParams;
                                    queryParams.keyword = keyword;
                                    $(this).combogrid("grid").datagrid('options').queryParams = queryParams;
                                    $(this).combogrid("grid").datagrid("reload");
                                    $(this).combogrid("setValue", keyword);
                                }
                            }

                        }
                    }
                }, {
                    field: 'HIS_CODE',
                    title: 'HIS药品编码',
                    width: 80,
                    sortable: true,
                    hidden: true
                }]];

                $(function () {



                    $.extend($.fn.datagrid.defaults.editors, {

                        combogrid: {

                            init: function (container, options) {

                                var input = $('<input type="text" class="datagrid-editable-input">').appendTo(container);

                                input.combogrid(options);

                                return input;

                            },

                            destroy: function (target) {

                                $(target).combogrid('destroy');

                            },

                            getValue: function (target) {

                                return $(target).combogrid('getValue');

                            },

                            setValue: function (target, value) {

                                $(target).combogrid('setValue', value);

                            },

                            resize: function (target, width) {

                                $(target).combogrid('resize', width);

                            }

                        }

                    });

                    WCKJ.Format.EditGrid("flexigridData", toolbar, '<%: Url.Content("~/System/SCM_COM_CODECOMPARE/GetData")%>', columns,
                         {
                             title: '药品信息对照表', //列表的标题
                             iconCls: 'icon-site',
                             fit: true,
                             nowrap: false,
                             striped: true,
                             toolbar: '#tb',
                             collapsible: false,
                             //获取数据的url
                             sortName: 'ID',
                             sortOrder: 'asc',
                             idField: 'ID',
                             pagination: true,
                             rownumbers: true,
                             onLoadSuccess:function()
                            {
                               WCKJ.Format.IconButton('.EditCls', 'icon-edit', '');
                            }
                         }, "", 1);


                     });
                     function btnSearch() {
                         $("#flexigridData").datagrid("reload", {
                             Name: $("#NAME").val(),
                             Code: $("#CODE").val()
                         });
                         $("#flexigridData").datagrid("clearSelections");
                     }
                     function saverow(editIndex2,ID,value) {
                         var ed = $('#flexigridData').datagrid('getEditor', { index: editIndex2, field: 'HIS_NAME' });
                         var His_ID = $(ed.target).combogrid('getValue');
                         $("#flexigridData").datagrid('endEdit', editIndex2);
                         editIndex = undefined;//设置全局变量
                         if(His_ID!=value&&ID!="")
                         {
                    $.post("<%: Url.Content("~/System/SCM_COM_CODECOMPARE/DoCompare")%>", {
                        ID:ID,
                        His_ID:His_ID
                    }, function (res) {
                        if (res == "OK") {
                            //移除删除的数据

                            $.messager.alert('操作提示', '匹配成功!', 'info');
                            setTimeout(function(){
                            $("#flexigridData").datagrid("reload");
                            $("#flexigridData").datagrid("clearSelections");
                            },200);
                        } else {
                            if (res == "") {
                                $.messager.alert('操作提示', '删除失败!请查看该数据与其他模块下的信息的关联，或联系管理员。', 'info');
                            } else {
                                $.messager.alert('操作提示', res, 'info');
                            }
                        }
                    });
                    }
                     }

                       //导航到创建的按钮
    function flexiCreate() {

        window.location.href = "<%: Url.Content("~/System/SCM_COM_CODECOMPARE/Create")%>";
        return false;
    }
    //导航到修改的按钮
    function flexiModify() {
        var arr = $('#flexigridData').datagrid('getSelections');

        if (arr.length == 1) {
            window.location.href = "<%: Url.Content("~/System/SCM_COM_CODECOMPARE/Edit/")%>" + arr[0].ID;

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
                $.post("<%: Url.Content("~/System/SCM_COM_CODECOMPARE/Delete")%>", {
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
