<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_SCM_B_SENDORDER>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    送货单
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="senginfoGrid" class="panel-body panel-body-noborder" data-options="style:{borderWidth:0}">
    <div id="tb">
        <div>
             
            发票号码：<input class="easyui-textbox" id="txtName" style="width: 200px" />
            <%: Html.HiddenFor(model => model.FPHM)%>
            <%: Html.HiddenFor(model => model.CODE)%>
            <%: Html.HiddenFor(model => model.ID)%>
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
              //$("#txtName").val('@model.FPHM');
         $("#txtName").val($("#FPHM").val());
         var toolbar = '#tb';
         var IsNull = $('#IsNull').prop('checked'); 
         var FPHM = $("#txtName").val();
         var SEND_ORDER_CODE = $("#CODE").val();
         var IsCheckFlag = true; //标示是否是勾选复选框选中行的，true - 是 , false - 否
         var datajson;
         var data = [];
         var arr = [];
            
     $(function () {
         var WERKST = $("#com_WERKST").combobox('getValue');
         BindGrid(SEND_ORDER_CODE,WERKST,FPHM,IsNull);
     });
         function BindGrid(SEND_ORDER_CODE,WERKST,FPHM,IsNull)
         {
         $.post('<%: Url.Content("~/System/SCM_B_SENDORDER/GetEditPlanData")%>', {
                page: 1,
                rows: 9007199,
                order : 'desc',
                sort: 'code',
                SEND_ORDER_CODE: SEND_ORDER_CODE,
                WERKST:WERKST,
                FPHM: FPHM,
                IsNull: IsNull
            }, function (datajson) {
            //debugger
               for (var i = 0; i < datajson.rows.length; ++i) { 
      data.push(datajson.rows[i]);
      var s1="";
      if(datajson.rows[i].SEND_ORDER_CODE != null)
      {
            s1= datajson.rows[i].SEND_ORDER_CODE.trim();
      }
      if(s1 == SEND_ORDER_CODE.trim())
      {
            arr.push(datajson.rows[i].ID);
      } 
      
    }
    console.log('1');
      console.log(arr);
               $('#senginfoGrid').datagrid({
             title: '创建送货清单',
             iconCls: 'icon-site',
             pagination:true, 
             data: datajson.rows.slice(0,10),
             fitColumns: true,
             idField: 'ID',
             singleSelect: false,
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
     var rows1 = $('#senginfoGrid').datagrid('getRows');
     console.log(rows1);
     if (rows1.length >0) {
            for (var i = 0; i < rows1.length; i++) 
            { 
                 if(arr.indexOf(rows1[i].ID) == -1)
                 {
                        arr.push(rows[i].ID);
                 }
             }
            }
            console.log(arr);
            sumRows(arr);
     },
     onUnselectAll :function (rowIndex, rowData) {
     var rows = $('#senginfoGrid').datagrid('getSelections');
     var rows1 = $('#senginfoGrid').datagrid('getRows');
     if (rows1.length >0) {
            for (var i = 0; i < rows1.length; i++) 
            { 
                 
                 for (var k = arr.length; k >=0; k--) 
                 {
                 if(arr[k] == rows1[i].ID)
                 {
                 arr.splice(k,1);
                 }
                 }
             }
            }
            console.log(arr);
            //console.log(rows);
            sumRows(arr);
     },
     onSelect: function (rowIndex, rowData) {

             IsCheckFlag = true;
            var rows = $('#senginfoGrid').datagrid('getSelections');
            if(arr.indexOf(rowData.ID) == -1)
                 {
                        arr.push(rowData.ID);
                 }
                 console.log(arr);
            sumRows(arr);

     },                    
     onUnselect: function (rowIndex, rowData) {
             IsCheckFlag = true;
            var rows = $('#senginfoGrid').datagrid('getSelections');
            for (var k = arr.length; k >=0; k--) 
                 {
                 if(arr[k] == rowData.ID)
                 {
                 arr.splice(k,1);
                 }
                 }
            console.log(arr);
            sumRows(arr);

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
                    title: '开票日期',
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
             rownumbers: true,
             onLoadSuccess:function(data){  
             var rowData = data.rows;
             //console.log(data);  
    $.each(rowData,function(index,row){//遍历JSON  
    if(row.SEND_ORDER_CODE != null)
    {
    var t1 = row.SEND_ORDER_CODE.toString();
    var t2 = $("#CODE").val().toString();
        if( t1.trim() == t2 ){ 
            //$("#dgSelectRoles").datagrid("selectRow", index); 
            $("#senginfoGrid").datagrid("selectRecord", row.ID); 
            $("#FPRQ").datebox('setValue', dateConvert(row.FPRQ)); 
        }  
        }
           
    });
             }

         });
         var pager = $("#senginfoGrid").datagrid("getPager");  
        pager.pagination({  
        total:datajson.rows.length,  
        onSelectPage:function (pageNo, pageSize) {  
          var start = (pageNo - 1) * pageSize;  
            var end = start + pageSize;  
            $("#senginfoGrid").datagrid("loadData", datajson.rows.slice(start, end));  
           pager.pagination('refresh', {  
                total:datajson.rows.length,  
                pageNumber:pageNo  
            });  
        }  
    });
    var rowData = datajson.rows;
    var fpjr = 0;   
    $.each(rowData,function(index,row){//遍历JSON  
    if(row.SEND_ORDER_CODE != null)
    {
    var t1 = row.SEND_ORDER_CODE.toString();
    var t2 = $("#CODE").val().toString();
        if( t1.trim() == t2 ){ 
            //$("#dgSelectRoles").datagrid("selectRow", index); 
            fpjr += row.FPJR; 
            $("#FPRQ").datebox('setValue', dateConvert(row.FPRQ)); 
        }  
        }
           
    });  
    $("#FPJR").text(fpjr);
            });
         }

         
         //ResizeGrid();
         
         function sumRows(rows) {
         var fpjr = 0;
            if (rows.length >0) {
            for (var i = 0; i < rows.length; i++) {
            for (var k = 0; k < data.length; k++) {
            if(rows[i] == data[k].ID)
            {
              fpjr += data[k].FPJR;
            }
            }
                 
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
            var rowsdata = data;
             if (rowsdata.length >0) {
            for (var i = 0; i < rowsdata.length-1; i++) {
                if (rowsdata[i].STATUS != '0' && $.trim(rowsdata[i].SEND_ORDER_CODE) == $("#CODE").val()){ 
                $.messager.alert('操作提示', '已经扫码入库的供应计划不能做更改!', 'warning');
                 return;
                }
            }
            }

//             $.ajax({ url: '<%: Url.Content("~/System/SCM_B_SENDORDER/CheckFP")%>', FPHM: $("#txtName").val(), success: function (data) {
//                 debugger;
//                 //$(this).addClass("done");
//             }

            $.ajax({
                 url: '<%: Url.Content("~/System/SCM_B_SENDORDER/CheckEditFP")%>',
                 type: 'POST', //GET
                 async: true,    //或false,是否异步
                 data: {
                     FPHM: $("#txtName").val(),CODE: $("#CODE").val()
                 },
                 timeout: 50000,    //超时时间
                 dataType: 'json',    //返回的数据格式：json/xml/html/script/jsonp/text
                 beforeSend: function (xhr) {

                 },
                 success: function (data, textStatus, jqXHR) {
                     //debugger;
                     if(data == "S")
                     {
                                     $.ajax({
                 url: '<%: Url.Content("~/System/SCM_B_SENDORDER/EidtFP")%>',
                 type: 'POST', //GET
                 async: true,    //或false,是否异步
                 data: {
                     FPHM: $("#txtName").val(),ID:$("#ID").val()
                 },
                 timeout: 50000,    //超时时间
                 dataType: 'json',    //返回的数据格式：json/xml/html/script/jsonp/text
                 beforeSend: function (xhr) {

                 },
                 success: function (data, textStatus, jqXHR) {
                     //debugger;
                     flexiSelect($("#CODE").val(), $("#txtName").val())
                     //$.messager.alert('操作提示', '创建成功!', 'success');
                     //window.location.href = '/App/System/scm_b_sendorder/Index';
                 },
                 error: function (xhr, textStatus) {
                    debugger
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
 //            var IsNull = $('#IsNull').prop('checked'); 
//             $("#senginfoGrid").datagrid("reload", {
//                 FPHM: $("#txtName").val(),WERKST:$("#com_WERKST").combobox('getValue'),IsNull:IsNull
//             });
//             $("#senginfoGrid").datagrid("clearSelections");
            var IsNull = $('#IsNull').prop('checked'); 
            var FPHM = $("#txtName").val();
            var SEND_ORDER_CODE = $("#CODE").val();
            var WERKST = $("#com_WERKST").combobox('getValue');
            debugger;
               BindGrid(SEND_ORDER_CODE,WERKST,FPHM,IsNull);
         }
         function flexiSelect(SEND_ORDER_CODE,FPHM) {
            var rows = $('#senginfoGrid').datagrid('getSelections');
            if (rows.length >0) {
//            for (var i = 0; i < rows.length-1; i++) {
//                if (rows[i].WERKST != rows[i+1].WERKST){ 
//                $.messager.alert('操作提示', '选择的供应计划不在同一院区!', 'warning');
//                 return;
//                }
//            }
            
            $.messager.progress({
                   title: '请稍等...',
                   msg: '数据处理中...',
                   text: '进度.......'
                });
                $.post("<%: Url.Content("~/System/SCM_B_SENDORDER/EditSupply")%>", {
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

