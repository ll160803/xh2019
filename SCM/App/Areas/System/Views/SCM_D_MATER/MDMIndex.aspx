<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tb" style="padding: 5px; height: auto">
        <div style="margin-bottom: 5px">
            供应商账号：<input class="easyui-textbox" id="GYSACCOUNT" style="width: 80px" />
            供应商名称：<input class="easyui-textbox" id="GYSNAME" style="width: 100px" />
            药品名称：<input class="easyui-textbox" id="NAME" style="width: 100px" />
            药品代码：<input class="easyui-textbox" id="CODE" style="width: 80px" />
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
                 } , {
                    field: 'GYSACCOUNT',
                    title: '供应商账号',
                    width: 100,
                    sortable: true
                }, {
                    field: 'GYSNAME',
                    title: '供应商名称',
                    width: 100,
                    sortable: true
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
                    field: 'SPEC',
                    title: '药品规格',
                    width: 120,
                    sortable: true
                }, {
                    field: 'SPELL_CODE',
                    title: '拼音码',
                    width: 80,
                    sortable: true
                }, {
                    field: 'CHARGE',
                    title: '批次',
                    width: 80,
                    sortable: true
                },{
                    field: 'PRODUCE_AREA',
                    title: '生产厂家',
                    width: 120,
                    sortable: true
                },
                {
                    field: 'SERVER_NAME',
                    title: '物料检验证书',
                    width: 120,
                    formatter: function(value, rec) {
                        if (value != null) {
                            return "<a href='<%: Url.Content("~/System/SCM_D_MATER/DownFile")%>?CLIENT_NAME="+rec.CLIENT_NAME+"&SERVER_NAME="+value+"' class='editcls'  ></a>";
                        }
                    }
                },
                {
                    field: 'STATE',
                    title: '审核',
                    width: 80,
                    formatter: function(value, rec) {
                        if (value == 2) {
                            return "审核通过";
                        }
                        if (value == 3) {
                            return "审核未通过";
                        }
                        return "未审核";
                    },
                    styler: function(value, row, index) {
                        if (value == 3) {
                            return 'color:red';
                        }
                        if (value == 2) {
                            return 'color:green';
                        }
                        
                    }

                }
                ]];

              
                $(function () {
                    WCKJ.Format.EditGrid("flexigridData", "", '<%: Url.Content("~/System/SCM_D_MATER/GetDataByMdm")%>', columns,
                         {
                             title: '供应商对应物料', //列表的标题
                             iconCls: 'icon-site',
                             fit: true,
                             nowrap: false,
                             striped: true,
                             toolbar: '#tb',
                             collapsible: false,
                             //获取数据的url
                             sortName: 'CREATE_TIME',
                             sortOrder: 'desc',
                             idField: 'ID',
                             pagination: true,
                             rownumbers: true,
                             onLoadSuccess: function() {
                               WC_Common.Format.IconButton('.editcls', 'icon-search');
                              }
                           
                         }, "",0);


                     });
                     
                     
                    
                     

    function down(filepath) {
    window.location.href = '<%:Url.Content("~/SAP/") %>' + filepath;
}
    </script>
    <script language="javascript" type="text/javascript">
   
 function btnSearch()
        {
            $("#flexigridData").datagrid("reload",{
                 Name:$("#NAME").val(),
                 Code:$("#CODE").val(),
                  GYSACCOUNT:$("#GYSACCOUNT").val(),
                 GYSNAME:$("#GYSNAME").val()
            });
            $("#flexigridData").datagrid("clearSelections");
        }
    </script>
</asp:Content>
