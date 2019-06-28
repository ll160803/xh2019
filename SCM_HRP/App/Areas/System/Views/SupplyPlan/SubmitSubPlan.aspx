<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tb">
        <div>
         <a href="#" class="easyui-linkbutton" onclick="UpToHis();" iconcls="icon-save"
                    plain="true">审核</a>
             创建时间:
            <input class="easyui-datebox" id="startDate" column="CREATE_TIME" style="width: 80px" />
            -
            <input class="easyui-datebox" id="endDate" column="CREATE_TIME" style="width: 80px" />
            药品名称：<input class="easyui-textbox" id="txtName" style="width: 80px" />
            供应商帐号：<input class="easyui-textbox" id="GYSAccount" style="width: 80px" />
            发票号码：<input class="easyui-textbox" id="txtFPHM" style="width: 80px" />
            备注: <input class="easyui-textbox" id="txtComments" style="width: 80px" />
             供应计划状态：
            <select class="easyui-combobox" id="com_Status" style="width: 80px;">
                <option value="2">全部</option>
                <option value="1">已收货</option>
                <option value="0">未收货</option>
            </select>
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
    </div>
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
   
    <script type="text/javascript" language="javascript">

        function UpToHis() {

        var rows = $('#flexigridData').datagrid('getSelections');
        if (rows.length == 0) {
            $.messager.alert('操作提示', '请选择数据!', 'warning');
            return false;
        }

        var arr = [];
        for (var i = 0; i < rows.length; i++) {
          if(rows[i].STATUS=="0")
            {
              arr.push(rows[i].ID);
            }
        }
        if(arr.length>0)
        {
        $.messager.confirm('操作提示', "确认这 " + arr.length + " 项收货吗？", function (r) {
            if (r) {
             $.messager.progress({
                 title: '请稍等...',
                 msg: '数据处理中...',
                 text: '进度.......'
               });
                $.post("<%: Url.Content("~/System/SupplyPlan/UpToHIS")%>", {
                    IDS: arr.join(",")
                }, function (res) {
                $.messager.progress('close');
                    if (res == "OK") {
                        //移除删除的数据

                        $.messager.alert('操作提示', '收货成功!', 'info');
                        $("#flexigridData").datagrid("reload");
                        $("#flexigridData").datagrid("clearSelections");
                    } else {
                        if (res == "") {
                            $.messager.alert('操作提示', '收货失败!请联系管理员。', 'info');
                        } else {
                            $.messager.alert('操作提示', res, 'info');
                        }
                    }
                });
            }
        });
        }
        else{
            $.messager.alert('操作提示', '你选择的数据已经收货!', 'warning');
        }

    };
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
                sortOrder: 'desc',
                idField: 'ID',
                toolbar: '#tb',
                columns: [[
                {
                    field: 'ID',
                    title: 'ID',
                    width: 120,

                    hidden: true,
                     rowspan:2
                }, {
                    field: 'ck',
                    checkbox: true,
                     rowspan:2
                }, {
                    title: '中心医院',
                    halign: 'center',
                    align: 'center',
                    width: 200,
                    colspan:2
                }, {
                    title: '供应商',
                    halign: 'center',
                    align: 'center',
                    width: 200,
                    colspan:2
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
                },{
                    field: 'MENGE',
                    title: '交货数量',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                     rowspan:2
                }, {
                    field: 'MSEHT',
                    title: '计量单位',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                     rowspan:2
                }, {
                    field: 'NETPR',
                    title: '进价',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                     rowspan:2
                },{
                    field: 'CHARG',
                    title: '批号',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                     rowspan:2
                },{
                    field: 'VFDAT',
                    title: '有效日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    },
                     rowspan:2
                }, {
                    field: 'FPJR',
                    title: '发票金额',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                     rowspan:2
                }, {
                    field: 'FPHM',
                    title: '发票号码',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                     rowspan:2
                }, {
                    field: 'GYSACCOUNT',
                    title: '供应商账号',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                     rowspan:2
                }, {
                    field: 'GYSNAME',
                    title: '供应商名称',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                     rowspan:2
                }, {
                    field: 'BEDAT',
                    title: '采购订单日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                     rowspan:2
                },  {
                    field: 'EEIND',
                    title: '交货日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                     rowspan:2
                },{
                    field: 'FREEUSE1',
                    title: '备注',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                     rowspan:2
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
                    },
                     rowspan:2
                },  {
                    field: 'HSDAT',
                    title: '生产日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    },
                     rowspan:2
                },  {
                    field: 'CODE',
                    title: '供应计划号',
                    halign: 'center',
                    align: 'center',
                    width: 120,
                    hidden:true,
                     rowspan:2
                }, {
                    field: 'EBELN',
                    title: '采购订单编号',
                    halign: 'center',
                    align: 'center',
                    width: 120,
                     rowspan:2
                }
                , {
                    field: 'GYJH',
                    title: '项目编号',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    hidden:true,
                     rowspan:2
                }, {
                    field: 'WERKST',
                    title: '院区',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                     rowspan:2
                }, {
                    field: 'NAME',
                    title: '库存地点',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                     rowspan:2
                },  {
                    field: 'ORDER_MENGE',
                    title: '订单数量',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                     rowspan:2
                },{
                    field: 'FPRQ',
                    title: '开票日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    },
                     rowspan:2
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
                    },
                     rowspan:2
                }

            ],
                [
                 {
                    field: 'MATNR',
                    title: '药品编码',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'TXZ01',
                    title: '药品名称',
                    halign: 'center',
                    align: 'center',
                    width: 120,
                    sortable:true
                },{
                    field: 'GYSDRUGCODE',
                    title: '药品编码',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'GYSDRUGNAME',
                    title: '药品名称',
                    halign: 'center',
                    align: 'center',
                    width: 120,
                    sortable:true
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
                Code: "",//供应计划号为空
                Status: "0",//未收货
                GysAccount: $("#GYSAccount").val(),
                Status: $("#com_Status").combobox('getValue'),
                txtName: $("#txtName").val(),
                txtFPHM: $("#txtFPHM").val(),
                txtComments: $("#txtComments").val()
            });
            $("#flexigridData").datagrid("clearSelections");
        }
       
    </script>
</asp:Content>
