<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    公告发布
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tb">
        <div>
            创建时间:
            <input class="easyui-datebox" id="startDate" column="CREATE_TIME" style="width: 100px" />
            -
            <input class="easyui-datebox" id="endDate" column="CREATE_TIME" style="width: 100px" />
            主题：<input class="easyui-textbox" id="NAME" style="width: 100px" />
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" language="javascript">
        $(function () {
            $('#flexigridData').datagrid({
                title:'信息公告',
                iconCls: 'icon-site',
                url: '<%: Url.Content("~/System/SCM_D_REPORT/GetData")%>',
                fit: true,
                idField: 'ID',
                sortName: 'CREATE_TIME',
                sortOrder: 'desc',
                rownumbers: true,
                toolbar:'#tb',
                columns: [
                    [{
                        field: 'ID',
                        title: 'ID',
                        width: 380,
                        hidden: true
                    }, {
                        field: 'NAME',
                        title: '标题',
                        width: 600,
                         formatter: function(value, rec) {
                               if (value != null) {

                                   return "<a target='_blank' href='<%: Url.Content("~/System/SCM_D_REPORT/Detail/")%>"+rec.ID+"'  >"+value+"</a>";
                                          }
                                   }
                    }, {
                        field: 'CREATE_TIME',
                        title: '发布时间',
                        width: 100,
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
                dtBeginTime: $("#startDate").datebox('getValue'),
                dtEndtime: $("#endDate").datebox('getValue'),
                NAME: $("#NAME").val()
            });
            $("#flexigridData").datagrid("clearSelections");
        }
    </script>
</asp:Content>
