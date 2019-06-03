<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tb">
        <div>
            <a href="#" class="easyui-linkbutton" onclick="flexiCreate();" iconcls="icon-print"
                plain="true">打印</a> <a href="#" class="easyui-linkbutton" onclick="Export();" iconcls="icon-save"
                    plain="true">导出</a> 创建时间:
            <input class="easyui-datebox" id="startDate" column="CREATE_TIME" style="width: 100px" />
            -
            <input class="easyui-datebox" id="endDate" column="CREATE_TIME" style="width: 100px" />
            药品名称：<input class="easyui-textbox" id="txtName" style="width: 100px" />
            供应计划号：<input class="easyui-textbox" id="Code" style="width: 100px" />
        </div>
        <div>
            发票号码：<input class="easyui-textbox" id="txtFPHM" style="width: 100px" />
            院区：
            <select class="easyui-combobox" id="com_WERKST" style="width: 100px;">
                <option value="全部">全部</option>
                <option value="武汉协和医院-本部">武汉协和医院-本部</option>
                <option value="武汉协和医院-西院">武汉协和医院-西院</option>
                <option value="武汉协和医院-肿瘤中心">武汉协和医院-肿瘤中心</option>
            </select>
            供应计划状态：
            <select class="easyui-combobox" id="com_Status" style="width: 100px;">
                <option value="2">全部</option>
                <option value="1">已收货</option>
                <option value="0">未收货</option>
            </select>
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="<%: Url.Content("~/Scripts/jquery.jqprint-0.3.js")%>" type="text/javascript"></script>
    <script type="text/javascript" language="javascript">

        $(function () {
            $('#flexigridData').datagrid({
                title: '供应计划', //列表的标题
                iconCls: 'icon-site',
                fit: true,
                nowrap: false,
                striped: true,
                collapsible: false,
                url: '<%: Url.Content("~/System/SupplyPlan/GetAllSubPlanData")%>', //获取数据的url
                sortName: 'CODE',
                sortOrder: 'desc',
                singleSelect:false,
                idField: 'ID',
                toolbar: '#tb',
                queryParams:{
                  Status:0
                },
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
                    width: 120,
                    sortable:true
                }, {
                    field: 'EBELN',
                    title: '采购订单编号',
                    halign: 'center',
                    align: 'center',
                    width: 120,
                    sortable:true
                }
                , {
                    field: 'GYJH',
                    title: '项目编号',
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
                    width: 200
                }, {
                    field: 'WERKST',
                    title: '院区',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                    sortable:true
                }, {
                    field: 'NAME',
                    title: '库存地点',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                    sortable:true
                }, {
                    field: 'GYSACCOUNT',
                    title: '供应商账号',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                    sortable:true
                }, {
                    field: 'GYSNAME',
                    title: '供应商名称',
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
                    field: 'EEIND',
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
                }, {
                    field: 'MENGE',
                    title: '交货数量',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'CHARG',
                    title: '批次',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'HSDAT',
                    title: '生产日期',
                    halign: 'center',
                    align: 'center',
                    sortable:true,
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
                    sortable:true,
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
                    width: 80,
                    sortable:true
                }, {
                    field: 'FPJR',
                    title: '发票金额',
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
                    sortable:true,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                }
                , {
                    field: 'CREATE_TIME',
                    title: '创建时间',
                    halign: 'center',
                    align: 'center',
                    sortable:true,
                    width: 80,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                } , {
                    field: 'STATUS',
                    title: '状态',
                    halign: 'center',
                    align: 'center',
                    sortable:true,
                    width: 80,
                    formatter: function (value, rec) {
                        if (value=="0") {
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
                            return "<a href='<%: Url.Content("~/System/SCM_D_MATER/DownFile")%>?CLIENT_NAME=&SERVER_NAME="+value+"' class='searchcls'  ></a>";
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

$("#com_Status").combobox('setValue',0);

        });
        function btnSearch() {
            $("#flexigridData").datagrid("reload", {
                startDate: $("#startDate").datebox('getValue'),
                endDate: $("#endDate").datebox('getValue'),
                Code: $("#Code").val(),
                Status:$("#com_Status").combobox('getValue'),
                WERKST:$("#com_WERKST").combobox('getValue'),
                txtName:$("#txtName").val(),
                txtFPHM:$("#txtFPHM").val()
            });
            $("#flexigridData").datagrid("clearSelections");
        };
        //导出
         function Export() {
            //将查询条件按照分隔符拼接成字符串
            $.post("../../SupplyPlan/Export",
                {
                   startDate: $("#startDate").datebox('getValue'),
                   endDate: $("#endDate").datebox('getValue'),
                   Code: $("#Code").val(),
                   Status:$("#com_Status").combobox('getValue'),
                   WERKST:$("#com_WERKST").combobox('getValue'),
                   txtName:$("#txtName").val(),
                   txtFPHM:$("#txtFPHM").val()

                }, function (res) {
                    window.location.href = res;
                });
            };

        function flexiCreate() {
            var rows = $('#flexigridData').datagrid('getSelections');
             if (rows.length == 0) {
                $.messager.alert('操作提示', '请选择打印数据!', 'warning');
                return false;
            }
            var arr = [];

             for (var i = 0; i < rows.length; i++) {
                arr.push(rows[i].ID);
                }
          openPostWindow('<%: Url.Content("~/Home/PrintTest")%>',arr.join(','),'打印');
              
             //  window.open('<%: Url.Content("~/Home/PrintTest/")%>'+rows[0].ID,'打印','height=400,width=500,status=yes,toolbar=yes,scrollbars,menubar=no,location=no');
           
        };
        $.format = function(source, params) {
    if (arguments.length == 1) return function() {
        var args = $.makeArray(arguments);
        args.unshift(source);
        return $.format.apply(this, args);
    };
    if (arguments.length > 2 && params.constructor != Array) {
        params = $.makeArray(arguments).slice(1);
    }
    if (params.constructor != Array) {
        params = [params];
    }
    $.each(params,
    function(i, n) {
        source = source.replace(new RegExp("\\{" + i + "\\}", "g"), n);
    });
    return source;
};
      function GenerateCode(TXZ01,MATNR,CHARG,ORDER_MENGE,VFDAT,perPage,CREATENAME,GYJH,fenPage,MSEHT,PKG_AMOUNT,PKG_NUMBER,NUMBER) {
           var qCode=GYJH+","+PKG_NUMBER+","+NUMBER;//供应计划号+箱数+实收数量
            $.post("<%:Url.Content("~/System/SupplyPlan/GenerateMark/")%>"+qCode, function (data) {
                var str=ContractString();
               //printIFrame
               var addTR="";
               if(fenPage!="")//第一张上面空有20px，所以在之后每一张之前加20px
               {
                 addTR='<tr><td colspan="3" style="width:340px;height:27px;"></td></tr>';
               }
       $("#printIFrame").contents().find("div[id='print']").append($.format(str,TXZ01,MATNR,data,CHARG,ORDER_MENGE,VFDAT,perPage,GYJH,CREATENAME,fenPage,MSEHT,PKG_AMOUNT,PKG_NUMBER,NUMBER,addTR));
            });
        }

      function ContractString() {
           var reStr='<div style="width: 340px; margin: 0; padding: 0; font-family:宋体;font-size: 14px; {9}"><table cellpadding="0" cellspacing="0">{14}'+
                '<tr>'+
                    '<td colspan="2" style="width: 240px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '华中科技大学同济医学院附属协和医院'+
                    '</td>'+
                    '<td  style="width: 100px;height:16px;font-family:宋体;font-size: 12px;">'+
                        '{6}'+
                    '</td>'+
                '</tr>'+
                 '<tr>'+
                    '<td style="width: 70px;height:30px;font-family:宋体;font-size: 14px;">'+
                        '药品名称：'+
                    '</td>'+
                    '<td colspan="2" style="width: 270px;height:30px;font-family:宋体;font-size: 12px;">'+
                        '{0}'+
                    '</td>'+
                '</tr>'+
                '<tr>'+
                    '<td style="width: 70px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '物料号：'+
                   ' </td>'+
                    '<td style="width: 170px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '{1}'+
                    '</td>'+
                    '<td rowspan="6" style="width: 80px;height:80px;">'+
                        '<img alt="显示出错" id="im_1" src="..{2}"  style=" width:80px; height:80px;"/>'+
                    '</td>'+
                '</tr>'+
                '<tr>'+
                    '<td style="width:70px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '批号：'+
                    '</td>'+
                    '<td style="width: 170px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '{3}'+
                    '</td>'+
                '</tr>'+
               
                '<tr>'+
                    '<td style="width:70px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '有效日期：'+
                    '</td>'+
                    '<td style="width: 170px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '{5}'+
                    '</td>'+
               ' </tr>'+
                '<tr>'+
                    '<td style="width:70px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '包装数量：'+
                    '</td>'+
                    '<td style="width: 170px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '{11}{10}/箱'+
                    '</td>'+
                '</tr>'+
                '<tr>'+
                    '<td style="width:70px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '箱数：'+
                    '</td>'+
                    '<td style="width: 170px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '{12}'+
                    '</td>'+
                '</tr>'+
                '<tr>'+
                   ' <td style="width:70px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '实收数量：'+
                    '</td>'+
                    '<td style="width: 170px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '{13}{10}'+
                   ' </td>'+
                '</tr>'+
                '<tr>'+
                   ' <td style="width:70px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '订单数量：'+
                    '</td>'+
                    '<td  style="width: 170px;height:16px;font-family:宋体;font-size: 14px;">'+
                        '{4}{10}'+
                   ' </td>'+
                    '<td style="width:100px;height:16px;font-family:宋体;font-size: 12pt;">'+
                       '{7}'+
                    '</td>'+
                '</tr>'+
                '<tr>'+
                    '<td style="width:70px;height:30px;font-family:宋体;font-size: 14px;">'+
                        '供应商：'+
                    '</td>'+
                    '<td colspan="2" style="width: 270px;height:30px;font-family:宋体;font-size: 12px;">'+
                        '{8}'+
                    '</td>'+
                '</tr>'+
            '</table>'+
        '</div>';
                return reStr ;
        }
    </script>
    <script language="javascript" type="text/javascript">

        function openPostWindow(url, data, name) {

            var form = $("<form></form>");
            form.live('submit', function () {
                openWindow(name);
            });
            form.attr('action', url);
            form.attr('method', 'post');
            var input1 = $("<input type='hidden' name='content' />");
            input1.attr('value', data);
            form.append(input1);
            form.appendTo("body");
            form.css('display', 'none');
            form.submit();


        }



        function openWindow(name) {

            window.showModalDialog('about:blank', name, 'height=600, width=500, top=0, left=0, toolbar=yes, menubar=yes, scrollbars=yes, resizable=yes,location=yes, status=yes');

        }      
        
    </script>
</asp:Content>
