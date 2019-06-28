<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tb">
        <div>
            创建时间:
            <input class="easyui-datebox" id="startDate" column="CREATE_TIME" style="width: 100px" />
            -
            <input class="easyui-datebox" id="endDate" column="CREATE_TIME" style="width: 100px" />
            药品名称：<input class="easyui-textbox" id="txtName" style="width: 100px" />
            供应计划号：<input class="easyui-textbox" id="Code" style="width: 100px" />
            供应商名称：<input class="easyui-textbox" id="GYSNAME" style="width: 100px" />
        </div>
        <div>
            供应商帐号：<input class="easyui-textbox" id="GYSAccount" style="width: 100px" />
            发票号码：<input class="easyui-textbox" id="txtFPHM" style="width: 100px" />
            供应计划状态：
            <select class="easyui-combobox" id="com_Status" style="width: 100px;">
                <option value="2">全部</option>
                <option value="1">已收货</option>
                <option value="0">未收货</option>
            </select>
            备注:
            <input class="easyui-textbox" id="txtComments" style="width: 100px" />
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">


        $(function () {
            $('#flexigridData').datagrid({
                title: '供应计划', //列表的标题
                iconCls: 'icon-site',
                fit: true,
                nowrap: false,
                striped: true,
                collapsible: false,
                url: '<%: Url.Content("~/System/SupplyPlan/GetAllSubPlanData_admin")%>', //获取数据的url
                sortName: 'CODE',
                sortOrder: 'asc',
                idField: 'ID',
                toolbar: '#tb',
                columns: [[
                {
                    field: 'ID',
                    title: 'ID',
                    width: 120,

                    hidden: true
                }, {
                    field: 'ck',
                    checkbox: true
                }, {
                    field: 'TXZ01',
                    title: '药品名称',
                    halign: 'center',
                    align: 'center',
                    width: 200
                }, {
                    field: 'SPEC',
                    title: '规格',
                    halign: 'center',
                    align: 'center',
                    width: 100
                }, {
                    field: 'FACTORY',
                    title: '生产厂家',
                    halign: 'center',
                    align: 'center',
                    width: 100
                }, {
                    field: 'MENGE',
                    title: '交货数量',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'MSEHT',
                    title: '计量单位',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'NETPR',
                    title: '进价',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'CHARG',
                    title: '批号',
                    halign: 'center',
                    align: 'center',
                    width: 80
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
                    field: 'FPJR',
                    title: '发票金额',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'FPHM',
                    title: '发票号码',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'GYSACCOUNT',
                    title: '供应商账号',
                    halign: 'center',
                    align: 'center',
                    width: 100
                }, {
                    field: 'GYSNAME',
                    title: '供应商名称',
                    halign: 'center',
                    align: 'center',
                    width: 100
                }, {
                    field: 'BEDAT',
                    title: '采购订单日期',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'EEIND',
                    title: '交货日期',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'FREEUSE1',
                    title: '备注',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'STATUS',
                    title: '状态',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rec) {
                        if (value == "0") {
                            return "未收货";
                        }
                        return "已收货";
                    }
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
                    field: 'MATNR',
                    title: '药品编码',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'CODE',
                    title: '供应计划号',
                    halign: 'center',
                    align: 'center',
                    width: 120
                }, {
                    field: 'EBELN',
                    title: '采购订单编号',
                    halign: 'center',
                    align: 'center',
                    width: 120
                }
                , {
                    field: 'GYJH',
                    title: '项目编号',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    hidden: true
                }, {
                    field: 'WERKST',
                    title: '院区',
                    halign: 'center',
                    align: 'center',
                    width: 100
                }, {
                    field: 'NAME',
                    title: '库存地点',
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
                    field: 'CREATE_TIME',
                    title: '创建时间',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                }

            ]
        ],
                pagination: true,
                rownumbers: true

            });



        });
        function btnSearch() {
            $("#flexigridData").datagrid("reload", {
                startDate: $("#startDate").datebox('getValue'),
                endDate: $("#endDate").datebox('getValue'),
                Code: $("#Code").val(),
                Status: $("#com_Status").combobox('getValue'),
                GysAccount: $("#GYSAccount").val(),
                GysNAME: $("#GYSNAME").val(),
                txtName: $("#txtName").val(),
                txtFPHM: $("#txtFPHM").val(),
                txtComments: $("#txtComments").val()
            });
            $("#flexigridData").datagrid("clearSelections");
        }
       
    </script>
</asp:Content>
