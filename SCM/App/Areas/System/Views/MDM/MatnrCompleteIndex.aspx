<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <div id="tb">
        <div>
            <a href="#" class="easyui-linkbutton" onclick="Export();" iconcls="icon-save"
                    plain="true">导出</a>
             创建时间:
            <input class="easyui-datebox" id="startDate" value="<%:ViewBag.LastDay%>" column="CREATE_TIME" style="width: 100px" />
            -
            <input class="easyui-datebox" id="endDate" value="<%:ViewBag.NowDay %>" column="CREATE_TIME" style="width: 100px" />
            供应商帐号：<input class="easyui-textbox" id="GYSAccount" style="width: 100px" />
            供应商名称：<input class="easyui-textbox" id="GYSName" style="width: 100px" />
            物料号：<input class="easyui-textbox" id="matnr" style="width: 100px" />
            物料名称：<input class="easyui-textbox" id="txz" style="width: 100px" />
            院区：
            <select class="easyui-combobox" id="com_WERKST" style="width: 100px;">
                <option value="">全部</option>
                <option value="武汉协和医院-本部">武汉协和医院-本部</option>
                <option value="武汉协和医院-西院">武汉协和医院-西院</option>
                <option value="武汉协和医院-肿瘤中心">武汉协和医院-肿瘤中心</option>
            </select>
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
 </div>
 <div id="show" class="easyui-dialog" title="详情" style="width: 800px; height: 300px;
        padding: 10px" data-options="iconCls:'icon-save',closed:true">
        <table id="subflexigridData"></table>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
 <script type="text/javascript" language="javascript">
     $(function () {

         $('#flexigridData').datagrid({
             title: '物料供货率', //列表的标题
             iconCls: 'icon-site',
             fit: true,
             nowrap: false,
             striped: true,
             collapsible: false,
             singleSelect: true,
             url: '<%: Url.Content("~/System/MDM/GetMatnrCompleteData")%>', //获取数据的url
             sortName: 'CODE',
             sortOrder: 'asc',
             idField: 'ID',
             toolbar: '#tb',
             columns: [
            [

                {
                    field: 'MATNR',
                    title: '物料号',
                    width: 100,
                    sortable: true
                }
                ,
                {
                    field: 'TXZ01',
                    title: '物料名称',
                    width: 300,
                    sortable: true
                }
                ,
                {
                    field: 'CODE',
                    title: '供应商账号',
                    width: 80,
                    sortable: true
                }
                , {
                    field: 'NAME',
                    title: '供应商名称',
                    width: 200,
                    sortable: true
                }, {
                    field: 'MENGE',
                    title: '采购数量',
                    width: 80,
                    sortable: true

                }, {
                    field: 'DONE_Menge',
                    title: '供应数量',
                    width: 80,
                    sortable: true

                }, {
                    field: 'Percent',
                    title: '供货率',
                    width: 80,
                    formatter: function (value, row) {
                        return value + "%";
                    },
                    sortable: true
                },
                {
                    field: 'lok',
                    title: '查看详情',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rowData) {

                        return "<a class='searchcls' href='#' onclick=ShowDetail('" + rowData.MATNR + "','" + rowData.CODE + "')> </a>";
                        
                    }

                }

            ]
        ],
             pagination: true,
             rownumbers: true,
              onLoadSuccess: function () {
                WC_Common.Format.IconButton('.searchcls', 'icon-search');
            }

         });


        

     });
    function btnSearch() {
        setFirstPage("#flexigridData");
         $("#flexigridData").datagrid("reload", {
             dtBeginTime: $("#startDate").datebox('getValue'),
             dtEndtime: $("#endDate").datebox('getValue'),
             GysAccount: $("#GYSAccount").val(),
             GysName: $("#GYSName").val(),
             matnr: $("#matnr").val(),
             txz01: $("#txz").val(),
             WERKST: $("#com_WERKST").combobox('getValue')
         });
         $("#flexigridData").datagrid("clearSelections");
     }
     function Export() {
         var opts = $("#flexigridData").datagrid('options');
         //将查询条件按照分隔符拼接成字符串
         $.post("../../MDM/Export",
                {
                    dtBeginTime: $("#startDate").datebox('getValue'),
                    dtEndtime: $("#endDate").datebox('getValue'),
                    GysAccount: $("#GYSAccount").val(),
                    GysName: $("#GYSName").val(),
                    matnr: $("#matnr").val(),
                    txz01: $("#txz").val(),
                    WERKST: $("#com_WERKST").combobox('getValue'),
                    sort: opts.sortName,
                    order: opts.sortOrder
                }, function (res) {
                    window.location.href = res;
                });
     };
     function ExportDetail(gysaccount, matnr) {
         $.post("../../MDM/ExportDetail",
                {
                    dtBeginTime: $("#startDate").datebox('getValue'),
                    dtEndtime: $("#endDate").datebox('getValue'),
                    GysAccount: gysaccount,
                    matnr: matnr
                }, function (res) {
                    window.location.href = res;
                });
     }
     function setFirstPage(ids) {
         var opts = $(ids).datagrid('options');
         var pager = $(ids).datagrid('getPager');
         opts.pageNumber = 1;
         opts.pageSize = opts.pageSize;
         pager.pagination('refresh', {
             pageNumber: 1,
             pageSize: opts.pageSize
         });
     }
     function ShowDetail(matnr, gysaccount) {
         $('#subflexigridData').datagrid({
             iconCls: 'icon-site',
             fit: true,
             nowrap: false,
             striped: true,
             collapsible: false,
             singleSelect: true,
             url: '<%: Url.Content("~/System/MDM/GetSupplyData")%>', //获取数据的url
             queryParams: { GysAccount: gysaccount, matnr: matnr,dtBeginTime: $("#startDate").datebox('getValue'),dtEndtime: $("#endDate").datebox('getValue') },
             sortName: 'BEDAT',
             sortOrder: 'asc',
             idField: 'ID',
              toolbar:[{
                text: '导出',
                iconCls: 'icon-excel',
                handler: function () {
                    return ExportDetail(gysaccount, matnr);
                }
            }],
             columns: [
            [

                {
                    field: 'MATNR',
                    title: '物料号',
                    width: 80
                }
                ,
                {
                    field: 'GYSACCOUNT',
                    title: '供应商账号',
                    width: 80
                }
                ,
                {
                    field: 'GYSNAME',
                    title: '供应商',
                    width: 80
                }, {
                    field: 'BEDAT',
                    title: '采购日期',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'EBELN',
                    title: '采购订单编号',
                    halign: 'center',
                    align: 'center',
                    width: 100
                }, {
                    field: 'ORDER_MENGE',
                    title: '订单数量',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'MENGE',
                    title: '交货数量',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }

            ]
        ],
             pagination: true,
             rownumbers: true


         });
         $("#show").dialog('open');
     }
</script>
</asp:Content>
