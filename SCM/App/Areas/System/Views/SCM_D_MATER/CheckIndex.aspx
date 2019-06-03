<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tb" style="padding: 5px; height: auto">
        <div style="margin-bottom: 5px">
            供应商账号：<input class="easyui-textbox" id="GYSACCOUNT" style="width: 80px" />
            供应商名称：<input class="easyui-textbox" id="GYSNAME" style="width: 100px" />
            药品名称：<input class="easyui-textbox" id="NAME" style="width: 100px" />
            药品代码：<input class="easyui-textbox" id="CODE" style="width: 80px" />
            批次号：<input class="easyui-textbox" id="CHARGE" style="width: 80px" />
            状态：<select class="easyui-combobox" id="com_State" style="width: 100px;">
                <option value="全部">全部</option>
                <option value="1">未审核</option>
                <option value="2">审核通过</option>
                <option value="3">未通过审核</option>
            </select>
            院区：
            <select class="easyui-combobox" id="com_WERKST" style="width: 100px;">
                <option value="">全部</option>
                <option value="武汉协和医院-本部">武汉协和医院-本部</option>
                <option value="武汉协和医院-西院">武汉协和医院-西院</option>
                <option value="武汉协和医院-肿瘤中心">武汉协和医院-肿瘤中心</option>
            </select>
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
        <div>
            <a href="#" class="easyui-linkbutton" iconcls="icon-save" plain="true" onclick="flexiAudit(2);">
                通过审核</a> <a href="#" class="easyui-linkbutton" iconcls="icon-save" plain="true" onclick="flexiAudit(3);">
                    审核不通过</a> <a href="#" class="easyui-linkbutton" iconcls="icon-remove" plain="true"
                        onclick="flexiDelete();">删除</a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
   

        var columns = [
            [   {
                    field: 'ck',
                    checkbox: true
                },
                 { field: 'ID',
                     title: 'ID',
                     width: 120,
                     hidden: true
                 } , {
                    field: 'GYSACCOUNT',
                    title: '供应商账号',
                    width: 100,
                    sortable: true
                }, {
                    field: 'GYSNAME',
                    title: '供应商名称',
                    width: 100,
                    sortable: true
                }
                , {
                    field: 'TXZ01',
                    title: '药品名称',
                    width: 150,
                    sortable: true
                }, {
                    field: 'MATNR',
                    title: '药品编码',
                    width: 80, sortable: true

                }, {
                    field: 'SPEC',
                    title: '药品规格',
                    width: 120,
                    sortable: true
                }, {
                    field: 'SPELL_CODE',
                    title: '拼音码',
                    width: 80,
                    sortable: true
                }, {
                    field: 'CHARGE',
                    title: '批次',
                    width: 80,
                    sortable: true
                },{
                    field: 'PRODUCE_AREA',
                    title: '生产厂家',
                    width: 120,
                    sortable: true
                },
                {
                    field: 'SERVER_NAME',
                    title: '物料检验证书',
                    width: 120,
                    formatter: function(value, rec) {
                        if (value != null) {
                            return "<a href='<%: Url.Content("~/System/SCM_D_MATER/DownFile")%>?CLIENT_NAME="+rec.CLIENT_NAME+"&SERVER_NAME="+value+"' class='editcls'  ></a>";
                        }
                    }
                },
                {
                    field: 'COMMENTS',
                    title: '审核原因',
                    width: 120,
                    editor: 'text',
                    sortable: true

                },
                {
                    field: 'STATE',
                    title: '审核',
                    width: 80,
                    formatter: function(value, rec) {
                        if (value == 2) {
                            return "审核通过";
                        }
                        if (value == 3) {
                            return "审核未通过";
                        }
                        return "未审核";
                    },
                    styler: function(value, row, index) {
                        if (value == 3) {
                            return 'color:red';
                        }
                        if (value == 2) {
                            return 'color:green';
                        }
                        
                    }

                }
                ]];

              
                $(function () {
                    WCKJ.Format.EditGrid("flexigridData", "", '<%: Url.Content("~/System/SCM_D_MATER/GetDataAll")%>', columns,
                         {
                             title: '检验证书与物料对应', //列表的标题
                             iconCls: 'icon-site',
                             fit: true,
                             nowrap: false,
                             striped: true,
                             toolbar: '#tb',
                             collapsible: false,
                             //获取数据的url
                             sortName: 'CREATE_TIME',
                             sortOrder: 'desc',
                             idField: 'ID',
                             pagination: true,
                             rownumbers: true,
                             onLoadSuccess: function() {
                               WC_Common.Format.IconButton('.editcls', 'icon-search');
                              }
                           
                         }, "",0);


                     });
                    
                     
                    
                     

                       //导航到创建的按钮
    function flexiCreate() {

        window.location.href = "<%: Url.Content("~/System/SCM_D_MATER/Create")%>";
        return false;
    }
    //导航到修改的按钮
    function flexiModify() {
        var arr = $('#flexigridData').datagrid('getSelections');

        if (arr.length == 1) {
            window.location.href = "<%: Url.Content("~/System/SCM_D_MATER/Edit/")%>" + arr[0].ID;

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
                $.post("<%: Url.Content("~/System/SCM_D_MATER/Delete")%>", {
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
    function down(filepath) {
    window.location.href = '<%:Url.Content("~/SAP/") %>' + filepath;
}
    </script>
    <script language="javascript" type="text/javascript">
    function flexiAudit(state) {
    // $('#flexigridData').datagrid('acceptChanges');
     endEditing('flexigridData');
    var rows = $('#flexigridData').datagrid('getSelections');
    if (rows.length == 0) {
        $.messager.alert('操作提示', '请选择数据!', 'warning');
        return false;
    }
     var arr = [];
      var arrCOMMENTS = [];
    for (var i = 0; i < rows.length; i++) {
        arr.push(rows[i].ID);
        arrCOMMENTS.push(rows[i].COMMENTS);
    }
    $.messager.confirm('操作提示', "确认更改这 " + arr.length + " 项吗？",
    function(r) {
        if (r) {
            $.post("<%: Url.Content("~/System/SCM_D_MATER/SaveState")%>", {
                IDS: arr.join(","),
                COMMENTS:arrCOMMENTS.join(","),
                state: state
            },
            function(res) {
                if (res == "OK") {
                    //移除删除的数据
                    $.messager.alert('操作提示', '操作成功!', 'info');
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

    return false;
}
 function btnSearch()
        {
            $("#flexigridData").datagrid("reload",{
                CHARGE:$("#CHARGE").val(),
                 Name:$("#NAME").val(),
                 Code:$("#CODE").val(),
                  GYSACCOUNT:$("#GYSACCOUNT").val(),
                 GYSNAME:$("#GYSNAME").val(),
                 STATE:$("#com_State").combobox('getValue'),
                 WERKST: $("#com_WERKST").combobox('getValue')

            });
            $("#flexigridData").datagrid("clearSelections");
        }
    </script>
</asp:Content>
