<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    IndexAdit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tb" style="padding: 5px; height: auto">
        <div style="margin-bottom: 5px">
            药品名称：<input class="easyui-textbox" id="NAME" style="width: 100px" />
            药品代码：<input class="easyui-textbox" id="CODE" style="width: 80px" />
            供应商名称：<input class="easyui-textbox" id="GYSNAME" style="width: 100px" />
            供应商账户：<input class="easyui-textbox" id="GYSACCOUNT" style="width: 80px" />
            是否询价：<select class="easyui-combobox" id="IS_QUERYPRICE" style="width: 100px;">
                <option value="">全部</option>
                <option value="1">是</option>
                <option value="2">否</option>
            </select>
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
        <div>
            <a href="#" class="easyui-linkbutton" iconcls="icon-edit" plain="true" onclick="AddQueryPrice();">
                            新增询价</a>
        </div>
    </div>
    <div id="dlg" class="easyui-dialog" title="附件浏览" data-options="iconCls:'icon-save',closed:true,"
        style="width: 700px; height: 250px; padding: 10px">
        <table id="grid_FileInfo">
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
    var UrlCreate = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/Create") %>";
    function XGgride(id) {
        window.location.href = UrlCreate + "/" + id; //跳转到新增页面
    }
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
                    field: 'OLD_PRICE',
                    title: '供货价格',
                    width: 80,
                    sortable: true
                }, {
                    field: 'ADJUST_PRICE',
                    title: '调整价格',
                    width: 80,
                    sortable: true
                },{
                    field: 'GYSNAME',
                    title: '供应商名称',
                    width: 150,
                    sortable: true
                },{
                    field: 'GYSACCOUNT',
                    title: '供应商账号',
                    width: 80,
                    sortable: true
                },{
                    field: 'COMMENTS',
                    title: '调整原因',
                    width: 120,
                    sortable: true

                },
                {
                    field: 'IS_QUERYPRICE',
                    title: '是否询价',
                    width: 60,
                    formatter: function(value, row) {
                        if (value == 0) {
                            return "否";
                        }
                       
                        return "是";
                    }

                },
                {
                    field: 'ck',
                    title: '附件查看',
                    width: 80,
                    formatter: function(value, rec) {
                       return "<a class='editcls' href='#' onclick=diaOpen('" + rec.ID + "')> </a>";
                    }

                }
                ]];

              
                $(function () {
                    WCKJ.Format.baseGrid("flexigridData", "", '<%: Url.Content("~/XJ/SCM_B_PRICEADJUST/GetDataAdit")%>', columns,
                         {
                             title: '药品价格调整', //列表的标题
                             iconCls: 'icon-site',
                             fit: true,
                             nowrap: false,
                             striped: true,
                             toolbar: '#tb',
                             collapsible: false,
                             //获取数据的url
                             sortName: 'IS_QUERYPRICE,CREATE_DATE DESC,STATE',
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
                             GysName: $("#GYSNAME").val(),
                             GysAccount: $("#GYSACCOUNT").val(),
                             IsQueryPrice: $("#IS_QUERYPRICE").combobox('getValue')
                         });
                         $("#flexigridData").datagrid("clearSelections");
                     }
    //新增询价
    function AddQueryPrice() {
        var rows = $('#flexigridData').datagrid('getSelections');
        if (rows.length == 0) {
            $.messager.alert('操作提示', '请选择数据!', 'warning');
            return false;
        }
        var arr = [];
        for (var i = 0; i < rows.length; i++) {
            if(rows[i].IS_QUERYPRICE==0)
            {
               arr.push(rows[i].ID);
            }
        }

        if(arr.length==0)
        {
            $.messager.alert('操作提示', '请选择有效的调价信息!', 'warning');
            return false;
        }
        /*
        if(rows.length==1)
        {
            if(rows[0].IS_QUERYPRICE==0)
            {
                ID = rows[0].ID;
                Name = rows[0].TXZ01
            }else{
                $.messager.alert('操作提示', '此药品调价信息已询价!', 'warning');
               return false;
            }
        }else{
            $.messager.alert('操作提示', '请选择 1 项调价信息进行询价!', 'warning');
               return false;
        }*/

        $.messager.confirm('操作提示', "确认新增药品询价信息吗？", function (r) {
            if (r) {
            $.post("<%: Url.Content("~/XJ/SCM_B_PRICEADJUST/CreateQueryPrice")%>", {
                    ids: arr.join(",")
                }, function (data) {
                    if (data.Success == 1) {
                        XGgride(data.Message);
                    } else {
                        $.messager.alert('操作提示', data.Message, 'info');
                    }
                });
            
            }
        });
    }
    
    </script>
    <script language="javascript" type="text/javascript">
    function diaOpen(id)
    {
        girdFile_load(id);
       $("#dlg").dialog("open");
    }

    function girdFile_load(perfGuid)
    {
     $('#grid_FileInfo').datagrid({
                url: '<%:Url.Content("~/system/COM_FILE/GetData/")%>' + perfGuid,
                singleSelect: true,
                sortName: 'ID',
                sortOrder: 'desc',
                idField: 'ID',
                pagination: true,
                rownumbers: true,
                columns: [
                [
                {
                    field: 'CLIENT_NAME',
                    title: '附件名称',
                    width: 200
                },
                {
                    field: 'CREATE_TIME',
                    title: '创建时间',
                    width: 200,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                        return '';
                    }
                },
         {
             field: 'ID',
             title: '操作',
             width: 150,
             formatter: function (value, rowData, rowIndex) {
                 return "<a id='a_delete' class='examinecls' title='查看附件' href='#' onclick='DownFile(\"" + rowData.SERVER_NAME + "\")'></a>";

             }
         }

                ]],
                onLoadSuccess: function () {
                    $('.examinecls').linkbutton(
                        {
                            text: '',
                            iconCls: 'icon-search',
                            plain: true
                        }),
                        $('.exa').linkbutton(
                        {
                            text: '',
                            iconCls: 'icon-cancel',
                            plain: true
                        });
                }


            });


}
        ///查看附件
        function DownFile(id) {
            window.open("<%:Url.Content("~/UploadFile/BaseInfo/")%>" + id, '_blank');
        }

    </script>
</asp:Content>
