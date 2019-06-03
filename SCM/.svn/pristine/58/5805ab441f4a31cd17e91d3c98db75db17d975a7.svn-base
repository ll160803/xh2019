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
            供应商名称：<input class="easyui-textbox" id="GYSNAME" style="width: 120px" />
            供应商帐号：<input class="easyui-textbox" id="GYSAccount" style="width: 120px" />
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
        <div>
           <a href="#" class="easyui-linkbutton" iconcls="icon-edit" plain="true" onclick="Check(5);">
                            开票确认</a>
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
                },{
                    field: 'DEPT_ID_NAME',
                    title: '所属药房',
                    width: 100,
                    sortable: true
                },{
                    field: 'COMMENTS',
                    title: '退货原因',
                    width: 120,
                    sortable: true

                },
                {
                    field: 'STATE',
                    title: '状态',
                    width: 80,
                    formatter: function(value, rec) {
                        if (value == 1) {
                            return "未提交";
                        }
                        if (value == 2) {
                            return "待审核";
                        }
                        if (value == 3) {
                            return "信息发布";
                        }
                        if (value == 4) {
                            return "实物退回";
                        }
                        if (value == 5) {
                            return "已开退票";
                        }
                        return "未审核";
                    }

                }
                ]];

              
                $(function () {
                    WCKJ.Format.baseGrid("flexigridData", "", '<%: Url.Content("~/System/SCM_B_SALERETURN/GetAdminData")%>', columns,
                         {
                             title: '退货信息', //列表的标题
                             iconCls: 'icon-site',
                             fit: true,
                             nowrap: false,
                             striped: true,
                             toolbar: '#tb',
                             collapsible: false,
                             queryParams:{STATE:'4'},
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
                             Charge:$("#CHARGE").val(),
                             GYSAccount:$("#GYSAccount").val(),
                             GYSNAME:$("#GYSNAME").val(),
                             STATE:'4'
                         });
                         $("#flexigridData").datagrid("clearSelections");
                     }
                     
                    
                     

   
    //删除的按钮
    function Check(flag) {

        var rows = $('#flexigridData').datagrid('getSelections');
        if (rows.length == 0) {
            $.messager.alert('操作提示', '请选择数据!', 'warning');
            return false;
        }
        if (rows.length >1) {
            $.messager.alert('操作提示', '请选择一条数据!', 'warning');
            return false;
        }
       
        for (var i = 0; i < rows.length; i++) {
            if(flag==1)
            {
               if(rows[i].STATE>2)
                   {
                      $.messager.alert('操作提示', '审核通过数据不能操作!', 'warning');
                      return false;
                   }
            }
            if(flag==3)
              {
                if(rows[i].STATE>3)
                   {
                      $.messager.alert('操作提示', '审核通过数据不能操作!', 'warning');
                      return false;
                   }
              } 
            if(flag==4)
              {
                  if(rows[i].STATE<3)
                   {
                      $.messager.alert('操作提示', '未审核数据不能操作!', 'warning');
                      return false;
                   }
                    if(rows[i].STATE>=4)
                   {
                      $.messager.alert('操作提示', '已退回数据不能操作!', 'warning');
                      return false;
                   }
              } 
              if(flag==5)
              {
                  if(rows[i].STATE<4)
                   {
                      $.messager.alert('操作提示', '未退回数据不能操作!', 'warning');
                      return false;
                   }
                   if(rows[i].STATE==5)
                   {
                      $.messager.alert('操作提示', '已开票数据不能操作!', 'warning');
                      return false;
                   }
              }
        }

        $.messager.confirm('操作提示', "确认处理这 1 项吗？", function (r) {
            if (r) {
                $.post("<%: Url.Content("~/System/SCM_B_SALERETURN/UpdateState")%>", {
                    Sid: rows[0].ID,
                    state:flag
                }, function (data) {
                    var res = data;
                    if (res == "OK") {
                        //移除删除的数据

                        $.messager.alert('操作提示', '处理成功!', 'info');
                        $("#flexigridData").datagrid("reload");
                        $("#flexigridData").datagrid("clearSelections");
                    } else {
                        if (res == "") {
                            $.messager.alert('操作提示', '删除失败!请查看该数据与其他模块下的信息的关联，或联系管理员。', 'info');
                        } else {
                            $.messager.alert('操作提示', data, 'info');
                        }
                    }
                });
            }
        });

    };
   
    </script>
</asp:Content>
