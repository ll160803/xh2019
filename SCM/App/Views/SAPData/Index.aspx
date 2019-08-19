<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tb">
        <div>
            查询时间:
            <input class="easyui-datebox" id="lastDay" style="width: 100px" />
            -
            <input class="easyui-datebox" id="nowDay" style="width: 100px" />
            库房：<input class="easyui-combobox" id="I_LGORT" name="I_LGORT" style="width: 150px" data-options="valueField: 'value',textField: 'text',filter: function(q, row){ var opts = $(this).combobox('options'); q=$.trim(q); return row[opts.textField].indexOf(q) >= 0;},url:'<%: Url.Content("~/SAPDATA/GetKFDataForCombobox")%>'" />
            科室卡号：<input class="easyui-textbox" id="I_CARDNO" style="width: 100px" />
            院区：
            <select class="easyui-combobox" id="com_WERKST" style="width: 100px;">
                <option value="全部">全部</option>
                <option value="2000">武汉协和医院-本部</option>
                <option value="2200">武汉协和医院-西区</option>
                <option value="2100">武汉协和医院-肿瘤中心</option>
            </select>
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a> &nbsp;&nbsp;
            <a href="#" class="easyui-linkbutton" onclick="Export();" iconcls="icon-save"
                plain="true">导出</a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
        $(function () {

            $('#flexigridData').datagrid({
                title: '科室领用查询', //列表的标题
                iconCls: 'icon-site',
                fitColumns: true,
                nowrap: false,
                striped: true,
                collapsible: false,
                singleSelect: true,
                queryParams: {
                    I_DATEL: "",
                    I_DATEH: "",
                    I_LGORT: "",
                    I_CARDNO: "",
                    I_WERKS: ""
                },
                sortName: 'KOSTL',
                sortOrder: 'asc',
                loader: myLoader,
                showFooter: true,
                idField: 'ID',
                columns: [
                    [

                        {
                            field: 'ID',
                            title: 'ID',
                            width: 120,
                            hidden: true
                        }, {
                            field: 'EBELN',
                            title: '领物单号',
                            width: 80
                        }, {
                            field: 'CPUDT',
                            title: '领用日期',
                            width: 80

                        }, {
                            field: 'CPUTM',
                            title: '领用时间',
                            width: 80
                        }, {
                            field: 'MATNR',
                            title: '物料编码',
                            width: 100

                        }, {
                            field: 'MAKTX',
                            title: '物料描述',
                            width: 120
                        }, {
                            field: 'NORMT',
                            title: '规格',
                            width: 100
                        },
                        {
                            field: 'MSEHL',
                            title: '单位',
                            width: 80
                        },
                        {
                            field: 'MENGE',
                            title: '数量',
                            width: 60

                        },
                        {
                            field: 'BRTWR',
                            title: '单价',
                            width: 60,
                            formatter: function (value, rec) {
                                if (value == 0) {
                                    return "";
                                }
                                return value;
                            }
                        },
                        {
                            field: 'DMBTR',
                            title: '金额',
                            width: 60
                        }
                        ,
                        {
                            field: 'LTEXT',
                            title: '领用科室',
                            width: 80
                        }
                    ]
                ],
                pagination: true,
                rownumbers: true

            });



        });
        function myLoader(param, success, error) {
            var that = $(this);
            var opts = that.datagrid("options");
            if (!opts.url) {
                return false;
            }
            var cache = that.data().datagrid.cache;
            if (!cache) {
                $.ajax({
                    type: opts.method,
                    url: opts.url,
                    data: param,
                    dataType: "json",
                    success: function (data) {
                        that.data().datagrid['cache'] = data;
                        success(bulidData(data));
                    },
                    error: function () {
                        error.apply(this, arguments);
                    }
                });
            } else {
                success(bulidData(cache));
            }
            function bulidData(data) {
                var temp = $.extend({}, data);
                var tempRows = [];
                var start = (param.page - 1) * parseInt(param.rows);
                var end = start + parseInt(param.rows);
                var rows = data.rows;
                for (var i = start; i < end; i++) {
                    if (rows[i]) {
                        tempRows.push(rows[i]);
                    } else {
                        break;
                    }
                }
                temp.rows = tempRows;
                return temp;
            }
        }
        function btnSearch() {
            $("#flexigridData").data().datagrid.cache = null;
            var queryParams = $('#flexigridData').datagrid('options').queryParams;

            queryParams.I_DATEL = $("#lastDay").datebox('getValue');
            queryParams.I_DATEH = $("#nowDay").datebox('getValue');
            queryParams.I_LGORT = $("#I_LGORT").combobox('getValue');
            queryParams.I_CARDNO = $("#I_CARDNO").val();
            queryParams.I_WERKS = $("#com_WERKST").combobox('getValue');


            $('#flexigridData').datagrid('options').queryParams = queryParams;
            $('#flexigridData').datagrid({ url: '<%: Url.Content("~/SAPDATA/GetData")%>' });

            //            $("#flexigridData").datagrid("reload", {
            //                I_DATEL: $("#lastDay").datebox('getValue'),
            //                I_DATEH: $("#nowDay").datebox('getValue'),
            //                I_LGORT: $("#I_LGORT").combobox('getValue'),
            //                I_CARDNO: $("#I_CARDNO").val(),
            //                I_WERKS: $("#com_WERKST").combobox('getValue')
            //            });
            $("#flexigridData").datagrid("clearSelections");
        }
        //导出
        function Export() {
            //将查询条件按照分隔符拼接成字符串
            $.post('<%: Url.Content("~/SAPDATA/GetDataExport")%>',
                {
                    I_DATEL: $("#lastDay").datebox('getValue'),
                    I_DATEH: $("#nowDay").datebox('getValue'),
                    I_LGORT: $("#I_LGORT").combobox('getValue'),
                    I_CARDNO: $("#I_CARDNO").val(),
                    I_WERKS: $("#com_WERKST").combobox('getValue'),
                    I_LGORT_text:$("#I_LGORT").combobox('getText')

                }, function (res) {
                    window.location.href = res;
                });
        };
    </script>
</asp:Content>
