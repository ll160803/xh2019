<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    送货单
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tb">
        <div>
            <a href="#" class="easyui-linkbutton" iconcls="icon-add" onclick="flexiCreate();"
                plain="true">创建</a> <a href="#" class="easyui-linkbutton" iconcls="icon-edit" onclick="flexiModify();"
                    plain="true">编辑</a> <a href="#" class="easyui-linkbutton" iconcls="icon-remove" onclick="flexiDelete();"
                        plain="true">删除</a> <a href="#" style="display:none;" class="easyui-linkbutton" iconcls="icon-add" onclick="OpenSupply();"
                            plain="true">引入供应计划</a> <a href="#" class="easyui-linkbutton" iconcls="icon-save"
                                onclick="GenerateSendInfo();" plain="true">送货清单打印</a><a href="#" class="easyui-linkbutton" onclick="Export();" iconcls="icon-save"
                    plain="true">导出送货清单</a>创建时间:
            <input class="easyui-datebox" id="startDate" style="width: 100px" />
            -
            <input class="easyui-datebox" id="endDate" style="width: 100px" />
            发票号码：<input class="easyui-textbox" id="txtName" style="width: 100px" />
            院区：
            <select class="easyui-combobox" id="com_WERKST" style="width: 150px;">
                <option value="">全部</option>
                <option value="武汉协和医院-本部">武汉协和医院-本部</option>
                <option value="武汉协和医院-西院">武汉协和医院-西院</option>
                <option value="武汉协和医院-肿瘤中心">武汉协和医院-肿瘤中心</option>
            </select>
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
    </div>
    <div id="sendinfo" class="easyui-dialog" title="选择供应计划单" data-options="closed:true"
        style="width: 1000px; height: 400px; padding: 10px">
        <div id="senginfoGrid">
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
        var data_opt = {
            title: '送货清单列表',
            idField: 'ID',
            nowrap: false,
            singleSelect: true,
            pagination: true,
            rownumbers: true,
            sortName: 'CODE',
            sortOrder: 'desc'
        };
        var cols = [
                    [{
                        field: 'ID',
                        title: 'ID',
                        width: 50,
                        halign: 'center',
                        align: 'center',
                        hidden: true
                    }, {
                        field: 'CODE',
                        title: '送货清单号',
                        halign: 'center',
                        align: 'center',
                        sortable: true,
                        width: 300
                    }, {
                        field: 'FPHM',
                        title: '发票号码',
                        halign: 'center',
                        align: 'center',
                        sortable: true,
                        width: 300
                    }, {
                        field: 'FPJR',
                        title: '发票金额',
                        width: 300,
                        halign: 'center',
                        align: 'center',
                        sortable: true
                    }, {
                    field: 'FPRQ',
                    title: '开票日期',
                    halign: 'center',
                    align: 'center',
                    width: 250,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                }
                    ]
		];
        var toolbar = '#tb';
        var sub_toolBar = "";
        var sub_cols = [//供应计划订单
            [
                {
                    field: 'ID',
                    title: 'ID',
                    width: 120,

                    hidden: true
                }, {
                    field: 'CODE',  
                    title: '供应计划号',
                    halign: 'center',
                    align: 'center',
                    width: 120,
                    sortable:true
                },{
                    field: 'MATNR',
                    title: '物料号',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'TXZ01',
                    title: '物料描述',
                    halign: 'center',
                    align: 'center',
                    width: 180,
                    sortable:true
                }, {
                    field: 'MENGE',
                    title: '送货数量',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'LINK_PERSON',
                    title: '联系人',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'SEND_DEPART_NAME',
                    title: '送达科室',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true

                }, {
                    field: 'WERKST',
                    title: '院区',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true

                }, {
                    field: 'LINK_TELEPHONE',
                    title: '联系方式',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'FPHM',
                    title: '发票号码',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'FPJR',
                    title: '送货金额',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'FPRQ',
                    title: '开票日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                }, {
                    field: 'MATER_CODE',
                    title: '商品条码',
                    halign: 'center',
                    align: 'center',
                    width: 80
                },
                {
                    field: 'isk2',
                    title: '删除',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rowData) {
                        if (rowData.STATUS == 0) {
                            return "<a class='canclels' href='#' onclick=DeleteSubPlan('" + rowData.ID + "')> </a>";
                        }
                        else {
                            return "";
                        }
                    }

                }
                ]
                ];
                function sub_data_opt(index, row) {
                    var option = {
                        idField: 'ID',
                        singleSelect: true,
                        treeField: 'ID',
                        sortName: 'CODE',
                         nowrap: false,
                        queryParams: {
                            SEND_ORDER_CODE: row.CODE//送货清单单号
                        },
                        onLoadSuccess: function () {
                            WC_Common.Format.IconButton('.details', 'icon-edit');
                            WC_Common.Format.IconButton('.canclels', 'icon-cancel');
                            WC_Common.Format.IconButton('.searchcls', 'icon-search');
                        }
                    };
                    return option;
                }
    $(function () {
        WCKJ.Format.SubGrid("flexigridData", toolbar, "<%: Url.Content("~/System/SCM_B_SENDORDER/GetData")%>", cols, data_opt, "", "<%: Url.Content("~/System/SCM_B_SENDORDER/GetSubPlanData")%>", sub_toolBar, sub_cols, sub_data_opt, "");
        resizeDataGrid(false);
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
        //导航到创建的按钮
        function flexiCreate() {

            window.location.href = '<%: Url.Content("~/System/SCM_B_SENDORDER/Create")%>';
            return false;
        }
        //导航到修改的按钮
        function flexiModify() {

            var arr = $('#flexigridData').datagrid('getSelections');

            if (arr.length == 1) {
//              if(arr[0].FPJR>0)
//                {
//                    $.messager.alert('操作提示', '送货清单含有供应计划，不能编辑!', 'warning');
//                    return false;
//                }
                if (arr[0].ID) {
                    window.location.href = '<%: Url.Content("~/System/SCM_B_SENDORDER/Edit/")%>' + arr[0].ID;
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
                if(rows[i].FPJR>0)
                {
                    $.messager.alert('操作提示', '送货清单含有供应计划，不能删除!', 'warning');
                    return false;
                   
                }else
                {
                   arr.push(rows[i].ID);
                }
                
                
            }

            $.messager.confirm('操作提示', "确认删除这 " + arr.length + " 项吗？", function (r) {
                if (r) {
                    $.post('<%: Url.Content("~/System/SCM_B_SENDORDER/Delete")%>', {
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
                startDate: $("#startDate").datebox('getValue'),
                endDate: $("#endDate").datebox('getValue'),
                FPHM: $("#txtName").val(),
                WERKST:$("#com_WERKST").combobox('getValue')
            });
            $("#flexigridData").datagrid("clearSelections");
        }
    </script>
    <script language="javascript" type="text/javascript">
        function DeleteSubPlan(ID) {
            $.messager.confirm('操作提示', "确认从送货清单移除这 1 项吗？", function (r) {
                if (r) {
                    $.post('<%: Url.Content("~/System/SCM_B_SENDORDER/DeleteSubPlan")%>', {
                        supplyID: ID
                    }, function (res) {
                        if (res == "OK") {
                            //移除删除的数据
                            $('#flexigridData').datagrid("reload");
                            $('#flexigridData').datagrid("clearSelections");
                            $.messager.alert('操作提示', '移除成功!', 'info');
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
    </script>
    <script language="javascript" type="text/javascript">
        function OpenSupply() {
            var arr = $('#flexigridData').datagrid('getSelections');

            if (arr.length == 1) {
                QuoteSendInfo(arr[0].FPHM, arr[0].CODE);
                $("#sendinfo").dialog('open');
            } else {
                $.messager.alert('操作提示', '请选择一条记录!', 'warning');
            }
            return false;
        }
        function flexiSelect(SEND_ORDER_CODE,FPHM) {
            var rows = $('#senginfoGrid').datagrid('getSelections');
            if (rows.length >0) {
            for (var i = 0; i < rows.length-1; i++) {
                if (rows[i].WERKST != rows[i+1].WERKST){ 
                $.messager.alert('操作提示', '选择的供应计划不在同一院区!', 'warning');
                 return;
                }
            }
            var arr = [];
            for (var i = 0; i < rows.length; i++) {
                arr.push(rows[i].ID);
            }
            $.messager.progress({
                   title: '请稍等...',
                   msg: '数据处理中...',
                   text: '进度.......'
                });
                $.post("<%: Url.Content("~/System/SCM_B_SENDORDER/SettingSupply")%>", {
                    SupplyIDs:arr.join(","),
                    SEND_ORDER_CODE:SEND_ORDER_CODE,
                    FPHM:FPHM
                }, function (res) {
                      $.messager.progress('close');
                    // var res=eval("("+data+")");
                    if (res == "OK") {
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
     
                $("#sendinfo").dialog('close');
            }
            else {
                $.messager.alert('操作提示', '请选择一条送货单数据!', 'warning');
            }
        }
        function QuoteSendInfo(FPHM, SEND_ORDER_CODE) {
            $('#senginfoGrid').datagrid({
                iconCls: 'icon-site',
                url: '<%: Url.Content("~/System/SCM_B_SENDORDER/GetSubPlanData")%>',
                fitColumns: true,
                queryParams: { FPHM: FPHM,SEND_ORDER_CODE:-1 },//-1代表是
                idField: 'ID',
                sortName: 'CODE',
                sortOrder: 'desc',
                singleSelect: false,
                height: 350,
                nowrap: false,
                rownumbers: true,
                selectOnCheck: true,
                checkOnSelect: true,
                toolbar: [{
                    text: '选择',
                    iconCls: 'icon-ok',
                    handler: function () {
                        return flexiSelect(SEND_ORDER_CODE,FPHM);
                    }
                }],
                columns: [
                    [{
                        field: 'ID',
                        title: 'ID',
                        width: 50,
                        halign: 'center',
                        align: 'center',
                        hidden: true
                    }, {
                        field: 'IsCheck',
                        checkbox: true

                    }, {
                        field: 'CODE',
                        title: '供应计划z号',
                        halign: 'center',
                        align: 'center',
                        sortable: true,
                        width: 100
                    }, {
                        field: 'MATNR',
                        title: '物料编码',
                        halign: 'center',
                        align: 'center',
                        sortable: true,
                        width: 80
                    }, {
                        field: 'TXZ01',
                        title: '物料描述',
                        width: 200,
                        halign: 'center',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'MENGE',
                        title: '送货数量',
                        width: 80,
                        halign: 'center',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'LINK_PERSON',
                        title: '联系人',
                        width: 80,
                        halign: 'center',
                        align: 'center',
                        sortable: true
                    },
                     {
                         field: 'SEND_DEPART_NAME',
                         title: '送达部门',
                         width: 80,
                         halign: 'center',
                         align: 'center',
                         sortable: true
                     }, {
                    field: 'WERKST',
                    title: '院区',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true

                },
                     {
                         field: 'LINK_TELEPHONE',
                         title: '联系方式',
                         width: 80,
                         halign: 'center',
                         align: 'center',
                         sortable: true
                     },
                     {
                         field: 'MATER_CODE',
                         title: '商品条码',
                         width: 80,
                         halign: 'center',
                         align: 'center',
                         sortable: true
                     }
                    ]
		],
                pagination: true,
                rownumbers: true

            });
        }
    </script>
    <script language="javascript" type="text/javascript">
        function GenerateSendInfo() {
            var rows = $('#flexigridData').datagrid('getSelections');
            if (rows.length == 1) {
                window.parent.addTab('送货清单打印', '<%: Url.Content("~/system/SCM_B_SENDORDER/PrintSendInfo/")%>' + rows[0].CODE, "icon-save", true)
               // window.location.href = '<%: Url.Content("~/system/SCM_B_SENDORDER/PrintSendInfo/")%>' + rows[0].CODE;
            }
            else {
                $.messager.alert('操作提示', '请选择一条送货清单数据!', 'warning');
                return false;
            }

        }

         //导出
         function Export() {
            var rows = $('#flexigridData').datagrid('getSelections');
            if (rows.length == 1) {
               $.post('<%: Url.Content("~/system/SCM_B_SENDORDER/Export/")%>' + rows[0].CODE,
                        {

                   }, function (res) {
                            console.log('<%: Url.Content("~/system/SCM_B_SENDORDER/")%>' + res)
                            window.location.href = '<%: Url.Content("~/system/SCM_B_SENDORDER/")%>' + res;
                        });
            }
            else {
                $.messager.alert('操作提示', '请选择一条送货清单数据!', 'warning');
                return false;
             }

     
            };
    </script>
</asp:Content>
