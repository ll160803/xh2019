<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.DisplayObject_SCM_B_SENDORDER>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    送货单
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="senginfoGrid" class="panel-body panel-body-noborder" data-options="style:{borderWidth:0}">
    <div id="tb">
        <div>
             
            发票号码：<input class="easyui-textbox" id="txtName" style="width: 200px" />
               发票日期:
            <input class="easyui-datebox" id="FPRQ" style="width: 100px" />
            发票总金额:
            <label id="FPJR" style="color:Red;"></label>
            院区：
            <select class="easyui-combobox" id="com_WERKST" style="width: 150px;">
                <option value="">全部</option>
                <option value="武汉协和医院-本部">武汉协和医院-本部</option>
                <option value="武汉协和医院-西院">武汉协和医院-西院</option>
                <option value="武汉协和医院-肿瘤中心">武汉协和医院-肿瘤中心</option>
            </select>
            <input id="IsNull" name="Id" type="checkbox" checked/>含空发票号
            <a href="#" class="easyui-linkbutton" iconcls="icon-search"
                                onclick="Search();" plain="true">查询</a>
                             
            <a href="#" class="easyui-linkbutton" iconcls="icon-save"
                                onclick="Save();" plain="true">保存</a>
            <a href="#" class="easyui-linkbutton" iconcls="icon-back"
                                onclick="window.history.go(-1);" plain="true">返回</a>
            
        </div>
    </div>
    </div>
     <script language="javascript" type="text/javascript">
         var toolbar = '#tb';
         var IsNull = $('#IsNull').prop('checked'); 
         var IsCheckFlag = true; //标示是否是勾选复选框选中行的，true - 是 , false - 否
         $('#senginfoGrid').datagrid({
             title: '创建送货清单',
             iconCls: 'icon-site',
             url: '<%: Url.Content("~/System/SCM_B_SENDORDER/GetSubPlanData")%>',
             fitColumns: true,
             queryParams: { FPHM: $("#txtName").val(), SEND_ORDER_CODE: -1 }, //-1代表是
             idField: 'ID',
             sortName: 'CODE',
             sortOrder: 'desc',
             singleSelect: false,
             height: 350,
             nowrap: false,
             rownumbers: true,
             selectOnCheck: true,
             checkOnSelect: true,
             toolbar: toolbar,
             headerCls: 'panel-header panel-header-noborder',
             bodyCls:'datagrid-wrap panel-body panel-body-noborder',
             onClickCell: function (rowIndex, field, value) {
         IsCheckFlag = false;
     },
     onSelectAll :function (rowIndex, rowData) {
     var rows = $('#senginfoGrid').datagrid('getSelections');
            //console.log(rows);
            sumRows(rows);
     },
     onUnselectAll :function (rowIndex, rowData) {
     var rows = $('#senginfoGrid').datagrid('getSelections');
            //console.log(rows);
            sumRows(rows);
     },
     onSelect: function (rowIndex, rowData) {

             IsCheckFlag = true;
            var rows = $('#senginfoGrid').datagrid('getSelections');
            //console.log(rows);
            sumRows(rows);

     },                    
     onUnselect: function (rowIndex, rowData) {

             IsCheckFlag = true;
            var rows = $('#senginfoGrid').datagrid('getSelections');
            //console.log(rows);
            sumRows(rows);

     },
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
                        title: '供应计划号',
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
                        field: 'FPHM',
                        title: '发票号码',
                        width: 100,
                        halign: 'center',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'FPJR',
                        title: '发票金额',
                        width: 100,
                        halign: 'center',
                        align: 'center',
                        sortable: true
                    }, {
                    field: 'FPRQ',
                    title: '发票日期',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                }, {
                        field: 'MENGE',
                        title: '送货数量',
                        width: 80,
                        halign: 'center',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'WERKST',
                        title: '院区',
                        width: 180,
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
         ResizeGrid();
         $("#FPJR").text(0);
         function sumRows(rows) {
         var fpjr = 0;
            if (rows.length >0) {
            for (var i = 0; i < rows.length; i++) {
                 fpjr += rows[i].FPJR;
             }
            }
            $("#FPJR").text(fpjr);
         }
         //“选择”按钮，在其他（与此页面有关联）的页面中，此页面以弹出框的形式出现，选择页面中的数据
         function flexiSelect() {

             var rows = $('#senginfoGrid').treegrid('getSelections');
//             if (rows.length == 0) {
//                 $.messager.alert('操作提示', '请选择数据!', 'warning');
//                 return false;'
//             }

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
         function Save() {
//             $.ajax({ url: <%: Url.Content("~/System/SCM_B_SENDORDER/CreateFP")%>, FPHM: $("#txtName").val(), success: function () {
//                 $(this).addClass("done");
//             } 
             //             });
             var content = $('#txtName').val();
             if (content.trim() == '') {
                 $.messager.alert('操作提示', '请输入发票号码!', 'error');
                 return;
             }
             var FPRQ = $("#FPRQ").datebox("getValue");
             if (FPRQ.trim() == '') {
                 $.messager.alert('操作提示', '请输入发票日期!', 'error');
                 return;
             }
           var rows = $('#senginfoGrid').datagrid('getSelections');
            if (rows.length >0) {
              for (var i = 0; i < rows.length-1; i++) {
                if (rows[i].WERKST != rows[i+1].WERKST){ 
                $.messager.alert('操作提示', '选择的供应计划不在同一院区!', 'warning');
                 return;
                }
            }
            }
//             $.ajax({ url: '<%: Url.Content("~/System/SCM_B_SENDORDER/CheckFP")%>', FPHM: $("#txtName").val(), success: function (data) {
//                 debugger;
//                 //$(this).addClass("done");
//             }

            $.ajax({
                 url: '<%: Url.Content("~/System/SCM_B_SENDORDER/CheckFP")%>',
                 type: 'POST', //GET
                 async: true,    //或false,是否异步
                 data: {
                     FPHM: $("#txtName").val()
                 },
                 timeout: 5000,    //超时时间
                 dataType: 'json',    //返回的数据格式：json/xml/html/script/jsonp/text
                 beforeSend: function (xhr) {

                 },
                 success: function (data, textStatus, jqXHR) {
                     debugger;
                     if(data == "S")
                     {
                                     $.ajax({
                 url: '<%: Url.Content("~/System/SCM_B_SENDORDER/CreateFP")%>',
                 type: 'POST', //GET
                 async: true,    //或false,是否异步
                 data: {
                     FPHM: $("#txtName").val()
                 },
                 timeout: 5000,    //超时时间
                 dataType: 'json',    //返回的数据格式：json/xml/html/script/jsonp/text
                 beforeSend: function (xhr) {

                 },
                 success: function (data, textStatus, jqXHR) {
                     debugger;
                     flexiSelect(data.CODE,data.FPHM)
                     //$.messager.alert('操作提示', '创建成功!', 'success');
                     //window.location.href = '/App/System/scm_b_sendorder/Index';
                 },
                 error: function (xhr, textStatus) {

                 },
                 complete: function () {

                 }
             });
                     }
                     else
                     {
                     $.messager.alert('操作提示', '系统已存在该发票号，请核实！', 'error');
                     }
                     //$.messager.alert('操作提示', '创建成功!', 'success');
                     //window.location.href = '/App/System/scm_b_sendorder/Index';
                 },
                 error: function (xhr, textStatus) {

                 },
                 complete: function () {

                 }
             });

             
         }
         function Search() {
             var IsNull = $('#IsNull').prop('checked'); 
             $("#senginfoGrid").datagrid("reload", {
                 FPHM: $("#txtName").val(),WERKST:$("#com_WERKST").combobox('getValue'),IsNull:IsNull, SEND_ORDER_CODE: -1
             });
             $("#senginfoGrid").datagrid("clearSelections");
         }
         function flexiSelect(SEND_ORDER_CODE,FPHM) {
            var rows = $('#senginfoGrid').datagrid('getSelections');
            if (rows.length >0) {
//              for (var i = 0; i < rows.length-1; i++) {
//                if (rows[i].WERKST != rows[i+1].WERKST){ 
//                $.messager.alert('操作提示', '选择的供应计划不在同一院区!', 'warning');
//                 return;
//                }
//            }
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
                    FPHM:FPHM,
                    FPRQ:$('#FPRQ').datebox('getValue')
                }, function (res) {
                      $.messager.progress('close');
                    // var res=eval("("+data+")");
                    if (res == "OK") {
                        $.messager.alert('操作提示', '操作成功!', 'info',function(){
                        window.location.href = '<%: Url.Content("~/System/SCM_B_SENDORDER/Index")%>';
                        });
                        $("#flexigridData").datagrid("reload");
                        $("#flexigridData").datagrid("clearSelections");
                    } else {
                        if (res == "") {
                            $.messager.alert('操作提示', '删除失败!请查看该数据与其他模块下的信息的关联，或联系管理员。', 'info');
                        } else {
                            $.messager.alert('操作提示', res, 'info',function(){
                            
                            window.location.href = '<%: Url.Content("~/System/SCM_B_SENDORDER/Index")%>';
                            });
                            
                        }
                    }
                });
     
                $("#sendinfo").dialog('close');
            }
            else {
                $.messager.alert('操作提示', '请选择一条送货单数据!', 'warning');
            }
        }
         //调整表格高度
        function ResizeGrid() {

            var newHeight = parent.$('#tabs').tabs('getSelected').panel('options').height - 35;

            $("#senginfoGrid").treegrid('resize', {
                height: newHeight
            });

        }
</script>
</asp:Content>

