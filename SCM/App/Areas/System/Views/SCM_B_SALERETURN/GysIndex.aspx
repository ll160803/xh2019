<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tb" style="padding: 5px; height: auto">
        <div style="margin-bottom: 5px">
            药品名称：<input class="easyui-textbox" id="NAME" style="width: 120px" />
            药品代码：<input class="easyui-textbox" id="CODE" style="width: 120px" />
            批次号：<input class="easyui-textbox" id="CHARGE" style="width: 120px" />
             状态: <select class="easyui-combobox" id="STATE" style="width: 100px;">
                <option value="0">全部</option>
                <option value="3">信息发布</option>
                <option value="4">退回确认</option>
                <option value="5">已开发票</option>
            </select>
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
   

        var columns = [
            [
                 { field: 'ID',
                     title: 'ID',
                     width: 120,
                     hidden: true
                 }
                , {
                    field: 'TXZ01',
                    title: '药品名称',
                    width: 150,
                    sortable: true
                }, {
                    field: 'MATNR',
                    title: '药品编码',
                    width: 80, sortable: true

                }, {
                    field: 'GYSACCOUNT',
                    title: '供应商账号',
                    width: 80, sortable: true

                }, {
                    field: 'GYSNAME',
                    title: '供应商名称',
                    width: 120, sortable: true

                },{
                    field: 'CHARG',
                    title: '批次',
                    width: 80,
                    sortable: true
                }, {
                    field: 'AMOUNT',
                    title: '退货数量',
                    width: 80,
                    sortable: true
                }, {
                    field: 'SPEC',
                    title: '药品规格',
                    width: 120,
                    sortable: true
                }, {
                    field: 'SPELL_CODE',
                    title: '拼音码',
                    width: 80,
                    sortable: true
                },{
                    field: 'PRODUCE_AREA',
                    title: '生产厂家',
                    width: 120,
                    sortable: true
                }, {
                    field: 'DEPT_ID_NAME',
                    title: '所属药房',
                    width: 100,
                    sortable: true
                }, {
                    field: 'COMMENTS',
                    title: '退货原因',
                    width: 120,
                    sortable: true

                },
                {
                    field: 'STATE',
                    title: '审核',
                    width: 80,
                    formatter: function (value, rec) {
                        if (value == 1) {
                            return "未提交";
                        }
                        if (value == 2) {
                            return "待审核";
                        }
                        if (value == 3) {
                            return "已审核";
                        }
                        if (value == 4) {
                            return "药品已退";
                        }
                        if (value == 5) {
                            return "退票已开";
                        }
                        return "未提交";
                    }

                }
                ]];

              
                $(function () {
                    WCKJ.Format.baseGrid("flexigridData", "", '<%: Url.Content("~/System/SCM_B_SALERETURN/GetDataWithGys")%>', columns,
                         {
                             title: '退货信息', //列表的标题
                             iconCls: 'icon-site',
                             fit: true,
                             nowrap: false,
                             striped: true,
                             toolbar: '#tb',
                             collapsible: false,
                             //获取数据的url
                             sortName: 'STATE',
                             sortOrder: 'asc',
                             idField: 'ID',
                             pagination: true,
                             rownumbers: true,
                             singleSelect:true,
                             onLoadSuccess: function() {
                               WC_Common.Format.IconButton('.editcls', 'icon-search');
                              }
                           
                         }, "");


                     });
                     function btnSearch() {
                         $("#flexigridData").datagrid("reload", {
                             Name: $("#NAME").val(),
                             Code: $("#CODE").val(),
                             Charge: $("#CHARGE").val(), 
                             STATE: $("#STATE").combobox('getValue')
                         });
                         $("#flexigridData").datagrid("clearSelections");
                     }
                     
                    
                     

                       //导航到创建的按钮
   
    </script>
</asp:Content>
