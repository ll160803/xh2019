<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tb" style="padding: 5px; height: auto">
        <div style="margin-bottom: 5px">
            药品名称：<input class="easyui-textbox" id="NAME" style="width: 100px" />
            药品代码：<input class="easyui-textbox" id="CODE" style="width: 80px" />
            状态：<select class="easyui-combobox" id="STATE" style="width: 100px;">
                <option value="-1">全部</option>
                <option value="1">未提交</option>
                <option value="2">已提交</option>
            </select>
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
        <div>
            <a href="#" class="easyui-linkbutton" iconcls="icon-add" plain="true" onclick="flexiCreate();">
                创建</a> <a href="#" class="easyui-linkbutton" iconcls="icon-edit" plain="true" onclick="flexiModify();">
                    编辑</a> <a href="#" class="easyui-linkbutton" iconcls="icon-remove" plain="true" onclick="flexiDelete();">
                        删除</a><a href="#" class="easyui-linkbutton" iconcls="icon-edit" plain="true" onclick="Check(2);">
                            提交</a>
        </div>
    </div>
    <div id="dlg" class="easyui-dialog" title="附件浏览" data-options="iconCls:'icon-save',closed:true,"
        style="width: 700px; height: 250px; padding: 10px">
        <table id="grid_FileInfo">
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
    var UrlCreate = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/Create") %>";
    function XGgride(id) {
        window.location.href = UrlCreate + "/" + id; //跳转到新增页面
    }
        var columns = [
            [
                 { field: 'ID',
                     title: 'ID',
                     width: 120,
                     hidden: true
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
                    field: 'OLD_PRICE',
                    title: '供货价格',
                    width: 80,
                    sortable: true
                }, {
                    field: 'ADJUST_PRICE',
                    title: '调整价格',
                    width: 80,
                    sortable: true
                },{
                    field: 'COMMENTS',
                    title: '调整原因',
                    width: 120,
                    sortable: true

                },
                {
                    field: 'STATE',
                    title: '状态',
                    width: 80,
                    formatter: function(value, rec) {
                        if (value == 2) {
                            return "提交";
                        }
                       
                        return "未提交";
                    }

                },
                {
                    field: 'ck',
                    title: '附件查看',
                    width: 80,
                    formatter: function(value, rec) {
                       return "<a class='editcls' href='#' onclick=diaOpen('" + rec.ID + "')> </a>";
                    }

                }
                ]];

              
                $(function () {
                    WCKJ.Format.baseGrid("flexigridData", "", '<%: Url.Content("~/XJ/SCM_B_PRICEADJUST/GetData")%>', columns,
                         {
                             title: '药品价格调整', //列表的标题
                             iconCls: 'icon-site',
                             fit: true,
                             nowrap: false,
                             striped: true,
                             toolbar: '#tb',
                             collapsible: false,
                             //获取数据的url
                             sortName: 'CREATE_DATE DESC,STATE',
                             sortOrder: 'asc',
                             idField: 'ID',
                             pagination: true,
                             rownumbers: true,
                             singleSelect:true,
                             onLoadSuccess: function() {
                               WC_Common.Format.IconButton('.editcls', 'icon-search');
                              }
                           
                         }, "");


                     });
                     function btnSearch() {
                         $("#flexigridData").datagrid("reload", {
                             Name: $("#NAME").val(),
                             Code: $("#CODE").val(),
                             STATE:$("#STATE").combobox('getValue')
                         });
                         $("#flexigridData").datagrid("clearSelections");
                     }
                     
                    
                     

                       //导航到创建的按钮
    function flexiCreate() {

        window.location.href = "<%: Url.Content("~/XJ/SCM_B_PRICEADJUST/Create")%>";
        return false;
    }
    //导航到修改的按钮
    function flexiModify() {
        var arr = $('#flexigridData').datagrid('getSelections');

        if (arr.length == 1) {
            if(arr[0].STATE>=2)
            {
                 $.messager.alert('操作提示', '提交数据不能编辑!', 'warning');
                 return false;
            }
            else{
                 window.location.href = "<%: Url.Content("~/XJ/SCM_B_PRICEADJUST/Edit/")%>" + arr[0].ID;
            }

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
            if(rows[i].STATE>=2)
            {
               $.messager.alert('操作提示', '提交数据不能删除!', 'warning');
               return false;
            }
            arr.push(rows[i].ID);
        }

        $.messager.confirm('操作提示', "确认删除这 " + arr.length + " 项吗？", function (r) {
            if (r) {
                $.post("<%: Url.Content("~/XJ/SCM_B_PRICEADJUST/Delete")%>", {
                    query: arr.join(",")
                }, function (data) {
                    var res = data.substring(1, 3);
                    if (res == "OK") {
                        //移除删除的数据

                        $.messager.alert('操作提示', '删除成功!', 'info');
                        $("#flexigridData").datagrid("reload");
                        $("#flexigridData").datagrid("clearSelections");
                    } else {
                        if (res == "") {
                            $.messager.alert('操作提示', '删除失败!请查看该数据与其他模块下的信息的关联，或联系管理员。', 'info');
                        } else {
                            $.messager.alert('操作提示', data, 'info');
                        }
                    }
                });
            }
        });

    };
    
    //删除的按钮
    function Check(flag) {

        var rows = $('#flexigridData').datagrid('getSelections');
        if (rows.length == 0) {
            $.messager.alert('操作提示', '请选择数据!', 'warning');
            return false;
        }
        if (rows.length >1) {
            $.messager.alert('操作提示', '请选择一条数据!', 'warning');
            return false;
        }
       
        for (var i = 0; i < rows.length; i++) {
            
               if(rows[i].STATE>1)
                   {
                      $.messager.alert('操作提示', '提交数据不能操作!', 'warning');
                      return false;
                   }
            }
            
            

        $.messager.confirm('操作提示', "确认处理这 1 项吗？", function (r) {
            if (r) {
                $.post("<%: Url.Content("~/XJ/SCM_B_PRICEADJUST/UpdateState")%>", {
                    id: rows[0].ID,
                    state:flag
                }, function (data) {
                    var res = eval('(' + data + ')'); 
                    if (res == "OK") {
                        //移除删除的数据

                        $.messager.alert('操作提示', '处理成功!', 'info');
                        $("#flexigridData").datagrid("reload");
                        $("#flexigridData").datagrid("clearSelections");
                    } else {
                        if (res == "") {
                            $.messager.alert('操作提示', '删除失败!请查看该数据与其他模块下的信息的关联，或联系管理员。', 'info');
                        } else {
                            $.messager.alert('操作提示', data, 'info');
                        }
                    }
                });
            }
        });

    };
    </script>
    <script language="javascript" type="text/javascript">
    function diaOpen(id)
    {
        girdFile_load(id);
       $("#dlg").dialog("open");
    }

    function girdFile_load(perfGuid)
    {
     $('#grid_FileInfo').datagrid({
                url: '<%:Url.Content("~/system/COM_FILE/GetData/")%>' + perfGuid,
                singleSelect: true,
                sortName: 'ID',
                sortOrder: 'desc',
                idField: 'ID',
                pagination: true,
                rownumbers: true,
                columns: [
                [
                {
                    field: 'CLIENT_NAME',
                    title: '附件名称',
                    width: 200
                },
                {
                    field: 'CREATE_TIME',
                    title: '创建时间',
                    width: 200,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                        return '';
                    }
                },
         {
             field: 'ID',
             title: '操作',
             width: 150,
             formatter: function (value, rowData, rowIndex) {
                 return "<a id='a_delete' class='examinecls' title='查看附件' href='#' onclick='DownFile(\"" + rowData.SERVER_NAME + "\")'></a>";

             }
         }

                ]],
                onLoadSuccess: function () {
                    $('.examinecls').linkbutton(
                        {
                            text: '',
                            iconCls: 'icon-search',
                            plain: true
                        }),
                        $('.exa').linkbutton(
                        {
                            text: '',
                            iconCls: 'icon-cancel',
                            plain: true
                        });
                }


            });


}




        function DeleteFile(id) {


            $.messager.confirm('操作提示', "确认删除这项吗？",
    function (r) {
        if (r) {
            $.post("<%:Url.Content("~/system/COM_FILE/Delete/")%>" + id,
            function (res) {
                if (res == "OK") {
                    //移除删除的数据
                    $("#grid_FileInfo").datagrid("reload");
                    $("#grid_FileInfo").datagrid("clearSelections");
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
        ///查看附件
        function DownFile(id) {
            window.open("<%:Url.Content("~/UploadFile/BaseInfo/")%>" + id, '_blank');
        }

    </script>
</asp:Content>
