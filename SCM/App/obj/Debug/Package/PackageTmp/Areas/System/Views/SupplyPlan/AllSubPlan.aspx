<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tb">
        <div>
        <a href="#" class="easyui-linkbutton" onclick="Export();" iconcls="icon-save"
                    plain="true">导出</a>
             创建时间:
            <input class="easyui-datebox" id="startDate" column="CREATE_TIME" style="width: 100px" />
            -
            <input class="easyui-datebox" id="endDate" column="CREATE_TIME" style="width: 100px" />
            药品名称：<input class="easyui-textbox" id="txtName" style="width: 100px" />
            供应计划号：<input class="easyui-textbox" id="Code" style="width: 100px" />
            供应商帐号：<input class="easyui-textbox" id="GYSAccount" style="width: 100px" />
            发票号码：<input class="easyui-textbox" id="txtFPHM" style="width: 100px" />
             供应计划状态：
            <select class="easyui-combobox" id="com_Status" style="width: 100px;">
                <option value="2">全部</option>
                <option value="1">已收货</option>
                <option value="0">未收货</option>
            </select>
            药品类别：
            <select class="easyui-combobox" id="com_BKLAS" style="width: 100px;">
                <option value="全部">全部</option>
                <option value="3000">西药</option>
                <option value="3001">中成药</option>
                <option value="3002">中草药</option>
            </select>
            缺货原因：
            <select class="easyui-combobox" id="Out_Cause" style="width: 135px;">
                <option value="">全部</option>
                <option value="1">库存不足</option>
                <option value="2">厂家停产</option>
                <option value="3">补足上批交货</option>
                <option value="4">批次拆分</option>
            </select>
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
                    width: 80
                }, {
                    field: 'MATNR',
                    title: '物料号',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'TXZ01',
                    title: '物料描述',
                    halign: 'center',
                    align: 'center',
                    width: 200
                }, {
                    field: 'WERKST',
                    title: '院区',
                    halign: 'center',
                    align: 'center',
                    width: 100
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
                    field: 'MSEHT',
                    title: '计量单位',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'NETPR',
                    title: '净价',
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
                    field: 'BEDAT',
                    title: '采购订单日期',
                    halign: 'center',
                    align: 'center',
                    width: 80
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
                },
                {
                    field: 'SERVER_NAME',
                    title: '质量检验证书',
                    width: 80,
                    formatter: function(value, rec) {
                        if (value != null) {
                            return "<a href='<%: Url.Content("~/System/SCM_D_MATER/DownFile")%>?CLIENT_NAME=A&SERVER_NAME="+value+"' class='searchcls'  ></a>";
                        }
                    }
                },
                {
                    field: 'OUT_CAUSE',
                    title: '缺货原因',
                    width: 120
                },
                {
                    field: 'OUT_DATE',
                    title: '预计补货日期',
                    width: 80,
                    formatter: function (value, rec) {
//                       if(value = '/Date(-62135596800000)/')
//                       {
//                            return "";
//                       }
                        if (value) {
                        if (dateConvert(value) == "1-01-01")
                        {
                         return "";
                        }
                        else
                        {
                         return dateConvert(value);
                        }
                        }
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
            $("#flexigridData").datagrid("reload", {
                startDate: $("#startDate").datebox('getValue'),
                endDate: $("#endDate").datebox('getValue'),
                Code: $("#Code").val(),
                Status:$("#com_Status").combobox('getValue'),
                GysAccount: $("#GYSAccount").val(),
                txtName: $("#txtName").val(),
                txtFPHM: $("#txtFPHM").val(),
                BKLAS:$("#com_BKLAS").combobox('getValue'),
                OUT_CAUSE:$("#Out_Cause").combobox('getValue')
            });
            $("#flexigridData").datagrid("clearSelections");
        }
       function Export() {
       debugger;
            //将查询条件按照分隔符拼接成字符串
            $.post("../../SupplyPlan/ExportAll",
                {
                   startDate: $("#startDate").datebox('getValue'),
                   endDate: $("#endDate").datebox('getValue'),
                   Code: $("#Code").val(),
                   Status:$("#com_Status").combobox('getValue'),
                   txtName:$("#txtName").val(),
                   txtFPHM:$("#txtFPHM").val(),
                   OutCause:$("#Out_Cause").combobox('getValue')

                }, function (res) {
                    window.location.href = res;
                });
            };
    </script>
</asp:Content>
