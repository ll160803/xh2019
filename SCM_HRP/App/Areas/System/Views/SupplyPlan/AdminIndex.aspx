<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    采购订单
</asp:Content>
<asp:content id="Content2" contentplaceholderid="MainContent" runat="server">
    <div id="tb">
        <div>
            <a href="#" class="easyui-linkbutton" onclick="flexiExport();" iconcls="icon-save"
                plain="true">导出</a> 采购时间:
            <input class="easyui-datebox" id="lastDay" value="<%:ViewBag.LastDay%>" style="width: 100px" />
            -
            <input class="easyui-datebox" id="nowDay" value="<%:ViewBag.NowDay %>" style="width: 100px" />
            供应商名称：<input class="easyui-textbox" id="GYSNAME" style="width: 100px" />
            供应商账号：<input class="easyui-textbox" id="txtGysAccount" style="width: 100px" />
        </div>
        <div>
            订单编号：<input class="easyui-textbox" id="txtEBELN" style="width: 100px" />
            药品名称：<input class="easyui-textbox" id="txtName" style="width: 100px" />
            备注:
            <input class="easyui-textbox" id="txtComments" style="width: 100px" />
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
    </div>
</asp:content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="<%: Url.Content("~/Scripts/datagrid-detailview.js") %>" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
 var data_opt = {
            title: '采购订单列表',
            idField: 'ID',
            treeField: "ID",
            fit:true,
            nowrap: false,
            singleSelect: true,
            pagination: true,
            rownumbers: true,
            sortName: 'CREATE_TIME',
            sortOrder: 'desc'
        };
        var cols = [//采购订单
            [
                {
                    field: 'ID',
                    title: 'ID',
                    width: 120,
                    hidden: true
                }, {
                    field: 'TXZ01',
                    title: '药品名称',
                    halign: 'center',
                    align: 'center',
                    width: 200,
                    sortable:true
                }
                , {
                    field: 'EBELP',
                    title: '项目编号',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                    hidden: true,
                    sortable:true
                }, {
                    field: 'FREEUSE3',
                    title: '规格',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                    sortable:true
                }, {
                    field: 'FREEUSE2',
                    title: '生产厂家',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                    sortable:true
                }, {
                    field: 'MENGE',
                    title: '数量',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'LIFNR',
                    title: '供应商账号',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'MATNR',
                    title: '药品编码',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'WERKST',
                    title: '院区',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                    sortable:true
                },{
                    field: 'ALLMENGE',
                    title: '供应数量',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                },{
                    field: 'SUREMENGE',
                    title: '收货数量',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'MSEHT',
                    title: '计量单位',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true

                }, {
                    field: 'NETPR',
                    title: '净价',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'EINDT',
                    title: '交货日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'EBELN',
                    title: '采购订单编号',
                    halign: 'center',
                    align: 'center',
                    width: 120,
                    sortable:true
                }, {
                    field: 'BEDAT',
                    title: '采购订单日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'FREEUSE1',
                    title: '备注',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }
                ]
                ];
var toolbar='#tb';
        var sub_toolBar = "";
    var sub_cols = [//采购订单
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
                    width: 120
                }, {
                    field: 'MENGE',
                    title: '交货数量',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'CHARG',
                    title: '批次',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'HSDAT',
                    title: '生产日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                }, {
                    field: 'VFDAT',
                    title: '有效日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                }, {
                    field: 'FPHM',
                    title: '发票号码',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'FPJR',
                    title: '发票金额',
                    halign: 'center',
                    align: 'center',
                    width: 80
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
                    field: 'PKG_AMOUNT',
                    title: '包装数量',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'PKG_NUMBER',
                    title: '箱数',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }
                ]
                ];

    function sub_data_opt(index, row) {
        var option = {
            idField: 'ID',
            singleSelect: true,
            treeField: 'ID',
            sortName: 'CODE',
            queryParams: {
                EBELN: row.EBELN,
                EBELP: row.EBELP
            },
            onLoadSuccess: function () {
               
            }
        };
        return option;
    }

    $(function () {
        WCKJ.Format.SubGrid("flexigridData", toolbar, "<%: Url.Content("~/System/SupplyPlan/GetAllData")%>", cols, data_opt, "", "<%: Url.Content("~/System/SupplyPlan/GetSubPlanData")%>", sub_toolBar, sub_cols, sub_data_opt, "");
    });
     function btnSearch()
        {
            $("#flexigridData").datagrid("reload",{
                 startDate:$("#lastDay").datebox('getValue'),
                 endDate:$("#nowDay").datebox('getValue'),
                 txtName:$("#txtName").val(),
                 txtEBELN:$("#txtEBELN").val(),
                 txtGysAccount:$("#txtGysAccount").val(),
                 GYSNAME:$("#GYSNAME").val(),
                 WERKST:'全部',
                 Comments:$("#txtComments").val()
            });
            $("#flexigridData").datagrid("clearSelections");
        }
        function flexiExport()
        {
            $.post("../../SupplyPlan/ExportPurcharsePlan",
                {
                     startDate:$("#lastDay").datebox('getValue'),
                     endDate:$("#nowDay").datebox('getValue'),
                     txtName:$("#txtName").val(),
                     txtEBELN:$("#txtEBELN").val(),
                     txtGysAccount:$("#txtGysAccount").val(),
                     GYSNAME:$("#GYSNAME").val(),
                     WERKST:'全部',
                     Comments:$("#txtComments").val()
                }, function (res) {
                    window.location.href = res;
                });
        }
    </script>
</asp:Content>
