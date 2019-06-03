<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Create.Master" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.DisplayObject_SCM_B_SENDINFO>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
        <legend>
            <input class="a2 f2" type="submit" value="保存" />
            <input class="a2 f2" type="button" onclick="window.history.go(-1);" value="返回" />
        </legend>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    物料名称：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.MATNR)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    物料编码：
                </div>
                <div class="trendrt">
                    <input name="m_MATER_CODE" id="m_MATER_CODE" class="easyui-textbox" disabled />
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    送货院区：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.WERKS)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    送货科室：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.SEND_DEPART)%>
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    送货数量：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.AMOUNT)%>
                    <%: Html.ValidationMessageFor(model => model.AMOUNT)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    单价：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.PRICE)%>
                    <%: Html.ValidationMessageFor(model => model.PRICE)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    送货金额：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.MONEY)%>
                    <%: Html.ValidationMessageFor(model => model.MONEY)%>
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    联系人：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.LINK_PERSON)%>
                    <%: Html.ValidationMessageFor(model => model.LINK_PERSON)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    联系电话：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.LINK_TELEPHONE)%>
                    <%: Html.ValidationMessageFor(model => model.LINK_TELEPHONE)%>
                </div>
            </div>
            
        </div>
        <div class="laytrnew">
        <div class="leftside">
                <div class="trendlf">
                    商品条码：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.MATER_CODE)%>
                    <%: Html.ValidationMessageFor(model => model.MATER_CODE)%>
                </div>
            </div>
        </div>
    </fieldset>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">
    <script language="javascript" type="text/javascript">
        $(function () {
            $("#AMOUNT").change(function () {
                var amount = 0;
                if ($("#AMOUNT").val() != "" && $("#PRICE").val() != "") {
                    var amount = parseFloat($("#AMOUNT").val()) * parseFloat($("#PRICE").val());
                    $("#MONEY").val(amount);
                }
            });
            $("#PRICE").change(function (e) {
                var amount = 0;
                if ($("#AMOUNT").val() != "" && $("#PRICE").val() != "") {
                    var amount = parseFloat($("#AMOUNT").val()) * parseFloat($("#PRICE").val());
                    $("#MONEY").val(amount);
                }
            });
            $("#MATNR").combogrid({
                idField: 'MATNR',
                textField: 'MAKTX',
                method: 'post',
                striped: true,
                panelWidth: 800,
                pagination: true,
                required: true,
                rownumbers: true,
                url: '<%: Url.Content("~/System/SCM_D_HRPMATER/GetComBoxData")%>',

                columns: [[
	                                   { field: 'MATNR', title: '物料编码', width: 80 },
	                                   { field: 'MTART', title: '物料类型', width: 80 },
	                                   { field: 'MSEHT', title: '基本单位', width: 80 },
                                       { field: 'MAKTX', title: '物料描述', width: 120 },
                                       { field: 'ZEINR', title: '拼音码', width: 80 },
                                       { field: 'NORMT', title: '规格', width: 80 },
                                       { field: 'FREEUSE1', title: '厂家', width: 120 }
	                                ]],
                keyHandler: {
                    query: function (keyword) {

                        $(this).combogrid("grid").datagrid('clearSelections');
                        debugger
                        var queryParams = $(this).combogrid("grid").datagrid('options').queryParams;
                        queryParams.keyword = keyword;
                        $(this).combogrid("grid").datagrid('options').queryParams = queryParams;
                        $(this).combogrid("grid").datagrid("reload");
                        $(this).combogrid("setValue", keyword);
                    }
                },
                onLoadSuccess: function () {

                },
                onSelect: function (rowIndex, rowData) {
                    $("#m_MATER_CODE").val(rowData.MATNR);
                }
            });

//            $("#SEND_DEPART").combogrid({
//                idField: 'CODE',
//                textField: 'NAME',
//                method: 'post',
//                striped: true,
//                panelWidth: 400,
//                required: true,
//                pagination: true,
//                rownumbers: true,
//                url: '<%: Url.Content("~/System/SCM_D_SENDDEPART/GetComBoxData")%>',

//                columns: [[
//	                                   { field: 'CODE', title: '科室编码', width: 80 },
//	                                   { field: 'NAME', title: '科室名称', width: 200 },
//	                                   { field: 'SPELL_CODE', title: '拼音码', width: 80 }
//	                                ]],
//                keyHandler: {
//                    query: function (keyword) {

//                        $(this).combogrid("grid").datagrid('clearSelections');

//                        var queryParams = $(this).combogrid("grid").datagrid('options').queryParams;
//                        queryParams.keyword = keyword;
//                        $(this).combogrid("grid").datagrid('options').queryParams = queryParams;
//                        $(this).combogrid("grid").datagrid("reload");
//                        $(this).combogrid("setValue", keyword);
//                    }
//                },
//                onLoadSuccess: function () {

//                }
//            });

            $("#WERKS").combogrid({
                idField: 'id',
                textField: 'text',
                method: 'get',
                striped: true,
                panelWidth: 400,
                required: true,
                pagination: true,
                rownumbers: true,
                url: '<%: Url.Content("~/WERKS.json")%>',
                columns: [[
	                                   { field: 'text', title: '院区名称', width: 200 },
	                                   { field: 'id', title: '院区编码', width: 80 }
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
                },
                onLoadSuccess: function () {

                },
                onChange: function (now, old) {
                    var val = $('#WERKS').combogrid('getValue');
                    switch (val) {
                        case "2200":
                            var url = '<%: Url.Content("~/System/SCM_D_SENDDEPART/GetComBoxData?type=2200")%>';
                            break;
                        case "2100":
                            var url = '<%: Url.Content("~/System/SCM_D_SENDDEPART/GetComBoxData?type=2100")%>';
                            break;
                        default:
                            var url = '<%: Url.Content("~/System/SCM_D_SENDDEPART/GetComBoxData?type=2000")%>';
                    }
                    $("#SEND_DEPART").combogrid({
                        idField: 'CODE',
                        textField: 'NAME',
                        method: 'post',
                        striped: true,
                        panelWidth: 400,
                        required: true,
                        pagination: true,
                        rownumbers: true,
                        url: url,

                        columns: [[
	                                   { field: 'CODE', title: '科室编码', width: 80 },
	                                   { field: 'NAME', title: '科室名称', width: 200 },
	                                   { field: 'SPELL_CODE', title: '拼音码', width: 80 }
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
                        },
                        onLoadSuccess: function () {

                        }
                    });
                    $("#SEND_DEPART").combogrid('clear'); 
                },
                onSelect: function (rowIndex, rowData) {
                   
                }
            });
        });

    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CurentPlace" runat="server">
</asp:Content>
