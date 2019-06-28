<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Create.Master" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.DisplayObject_SCM_COM_CODECOMPARE>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
        <legend>
            <input class="a2 f2" type="submit" value="创建" />
            <input class="a2 f2" type="button" onclick="window.history.go(-1);" value="返回" />
        </legend>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    药品编码：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.CODE)%>
                    <%: Html.ValidationMessageFor(model => model.CODE)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    药品名称：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.NAME)%>
                    <%: Html.ValidationMessageFor(model => model.NAME)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    药品规格：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.SPEC)%>
                    <%: Html.ValidationMessageFor(model => model.SPEC)%>
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    生产厂家：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.FACTORY)%>
                    <%: Html.ValidationMessageFor(model => model.FACTORY)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    HIS药品对应：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.BASE_ID)%>
                    <%: Html.ValidationMessageFor(model => model.BASE_ID)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                   
                </div>
                <div class="trendrt">
                   
                </div>
            </div>
        </div>
        
    </fieldset>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">
    <script language="javascript" type="text/javascript">
        $(function () {
            $("#BASE_ID").combogrid({
                idField: 'ID',
                textField: 'NAME',
                method: 'post',
                striped: true,
                panelWidth: 400,
                pagination: true,
                editable: true,
                rownumbers: true,
                url: '<%: Url.Content("~/System/SCM_COM_DRUG/GetComBoxData")%>',

                columns: [[
	                                   { field: 'CODE', title: '药品编码', width: 80 },
	                                   { field: 'NAME', title: '药品名称', width: 120 },
	                                   { field: 'SPEC', title: '规格', width: 80 },
	                                   { field: 'FACTORY', title: '生产工厂', width: 120 }
	                                ]],
                keyHandler: {
                    query: function (keyword) {

                        $(this).combogrid("grid").datagrid('clearSelections');

                        var queryParams = $(this).combogrid("grid").datagrid('options').queryParams;
                        queryParams.keyword = keyword;
                        $(this).combogrid("grid").datagrid('options').queryParams = queryParams;
                        $(this).combogrid("grid").datagrid("reload");
                        $(this).combogrid("setValue", keyword);
                    }
                }
            });

        });

    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CurentPlace" runat="server">
</asp:Content>
