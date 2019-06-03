<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    采购订单
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tb">
        <div>
            采购时间:
            <input class="easyui-datebox" id="lastDay" value="<%:ViewBag.LastDay%>" style="width: 100px" />
            -
            <input class="easyui-datebox" id="nowDay" value="<%:ViewBag.NowDay %>" style="width: 100px" />
            供应商账号：<input class="easyui-textbox" id="txtGysAccount" style="width: 100px" />
            订单编号：<input class="easyui-textbox" id="txtEBELN" style="width: 100px" />
            物料名称：<input class="easyui-textbox" id="txtName" style="width: 100px" />
             院区：
            <select class="easyui-combobox" id="com_WERKST" style="width: 100px;">
                <option value="全部">全部</option>
                <option value="武汉协和医院-本部">武汉协和医院-本部</option>
                <option value="武汉协和医院-西院">武汉协和医院-西院</option>
                <option value="武汉协和医院-肿瘤中心">武汉协和医院-肿瘤中心</option>
            </select>
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
    </div>
</asp:Content>
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
            sortName: 'EBELN,EBELP',
            sortOrder: 'asc'
        };
        var cols = [//采购订单
            [
                {
                    field: 'ID',
                    title: 'ID',
                    width: 120,
                    hidden: true
                }, {
                    field: 'EBELN',
                    title: '采购订单编号',
                    halign: 'center',
                    align: 'center',
                    width: 120,
                    sortable:true
                }
                , {
                    field: 'EBELP',
                    title: '项目编号',
                    halign: 'center',
                    align: 'center',
                    width: 100,
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
                    width: 200,
                    sortable:true
                }, {
                    field: 'WERKST',
                    title: '院区',
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
                    field: 'BEDAT',
                    title: '采购订单日期',
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
                    title: '供应计划单号',
                    halign: 'center',
                    align: 'center',
                    width: 120
                }, {
                    field: 'MENGE',
                    title: '送货数量',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'LINK_PERSON',
                    title: '联系人',
                    halign: 'center',
                    align: 'center',
                    width: 100
                }, {
                    field: 'SEND_DEPART_NAME',
                    title: '送达科室',
                    halign: 'center',
                    align: 'center',
                    width: 100
                    
                }, {
                    field: 'LINK_TELEPHONE',
                    title: '联系方式',
                    halign: 'center',
                    align: 'center',
                    width: 100
                    
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
                    field: 'MATER_CODE',
                    title: '商品条码',
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
        WCKJ.Format.SubGrid("flexigridData", toolbar, "<%: Url.Content("~/System/SENDORDER/GetAllData")%>", cols, data_opt, "", "<%: Url.Content("~/System/SENDORDER/GetSubPlanData")%>", sub_toolBar, sub_cols, sub_data_opt, "");
    });
     function btnSearch()
        {
            $("#flexigridData").datagrid("reload",{
                 startDate:$("#lastDay").datebox('getValue'),
                 endDate:$("#nowDay").datebox('getValue'),
                 txtName:$("#txtName").val(),
                 txtEBELN:$("#txtEBELN").val(),
                 txtGysAccount:$("#txtGysAccount").val(),
                 WERKST:$("#com_WERKST").combobox('getValue')
            });
            $("#flexigridData").datagrid("clearSelections");
        }
    </script>
</asp:Content>
