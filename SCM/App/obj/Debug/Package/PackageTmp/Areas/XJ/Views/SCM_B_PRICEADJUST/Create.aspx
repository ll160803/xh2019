<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_SCM_B_PRICEADJUST>" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width" />
    <script src="<%: Url.Content("~/Scripts/jquery.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/JScriptCommon.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/JScriptIndex.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/Utili.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/jquery.easyui.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/locale/easyui-lang-zh_CN.js") %>" type="text/javascript"></script>
    <link href="<%: Url.Content("~/Res/easyui/themes/icon.css") %>" rel="stylesheet"
        type="text/css" />
    <link href="<%: Url.Content("~/Res/easyui/themes/default/easyui.css") %>" rel="stylesheet"
        type="text/css" />
    <title>创建页面</title>
    <script language="javascript" type="text/javascript">
     function submitForm() {
	        $('#ff').form('submit', {
	            url: "<%: Url.Content("~/XJ/SCM_B_PRICEADJUST/Create/")%>",
                dataType: "json",
                onsubmit: function () {
                    return $(this).form("validate");
                },
                success: function (data) {
                    var msg = data.substring(1, 2);
                    if (msg == 'F') {
                        $.messager.alert('操作提示', data, 'error');
                        return false;
                    }
                    else{
                       $.messager.alert('操作提示', '保存成功', 'info');
                        window.location.href='<%: Url.Content("~/XJ/SCM_B_PRICEADJUST/Index")%>';
                        return false;
                    }
                    
                }
	        });
	    }
        $(function () {
            $("#MATNR_ID").combogrid({
                idField: 'ID',
                textField: 'MAKTX',
                method: 'post',
                striped: true,
                panelWidth: 600,
                pagination: true,
                editable: true,
                rownumbers: true,
                //url: '<%: Url.Content("~/System/SCM_D_MATER/GetComBoxDataForReturn")%>',
                url: '<%: Url.Content("~/System/SCM_D_HRPMATER/GetComBoxDataMedicine")%>', 

                columns: [[         
	                                   { field: 'MATNR', title: '物料编码', width: 80 },
	                                   //{ field: 'TXZ01', title: '物料名称', width: 200 },
                                       { field: 'MAKTX', title: '物料名称', width: 200 },
                                       //{ field: 'GYSACCOUNT', title: '供应账号', width: 80 },
                                       //{ field: 'GYS_NAME', title: '供应商', width: 150 },
	                                   { field: 'SPEC', title: '规格', width: 80 },
                                       //{ field: 'SPELL_CODE', title: '拼音码', width: 80 },
	                                   //{ field: 'PRODUCE_AREA', title: '生产工厂', width: 200 }
                                       { field: 'MSEHT', title: '物料单位', width: 80 },
                                       { field: 'ZEINR', title: '拼音码', width: 80 }
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
                onSelect: function (rowIndex, rowData)
                {
                    $("#MATNR").val(rowData.MATNR);
                    //$("#TXZ01").val(rowData.TXZ01);
                    $("#SPEC").val(rowData.SPEC);
                    $("#TXZ01").val(rowData.MAKTX);
                    $("#MSEHT").val(rowData.MSEHT);
                }
            });

        });
    </script>
</head>
<body>
    <div class="easyui-panel" title="资质上传" style="width: 1000px">
        <div style="padding: 10px 60px 20px 60px">
            <form id="ff" method="post">
            <fieldset>
                <legend>
                    <input class="a2 f2" type="button" onclick="submitForm();" value="保存" />
                    <input class="a2 f2" type="button" onclick="window.location.href='<%: Url.Content("~/XJ/SCM_B_PRICEADJUST/Index")%>';"
                        value="返回" />
                </legend>
                <table cellpadding="5">
                    <tr>
                        <td class="fTd">
                            <input type="hidden" id="ID" name="ID" value="<%:ViewBag.ID %>" />
                            <input type="hidden" id="MSEHT" name="MSEHT" />
                            <input type="hidden" id="MATNR" name="MATNR" />
                            <input type="hidden" id="TXZ01" name="TXZ01" />
                            <input type="hidden" id="SPEC" name="SPEC" />
                            <span style="color: Red">*</span>SCM药品:
                        </td>
                        <td>
                            <input type="text" value="<%:Model.MATNR_ID %>" id="MATNR_ID" name="MATNR_ID" data-options="required:true"></input>
                        </td>
                    </tr>
                    <tr>
                        <td class="fTd">
                            <span style="color: Red">*</span>当前价格:
                        </td>
                        <td>
                            <input type="text" class="easyui-validatebox  easyui-numberbox sTd" value="<%:Model.OLD_PRICE %>"
                                id="OLD_PRICE" name="OLD_PRICE" data-options="required:true" />
                        </td>
                    </tr>
                    <tr>
                        <td class="fTd">
                            <span style="color: Red">*</span>调整价格:
                        </td>
                        <td>
                            <input type="text" class="easyui-validatebox  easyui-numberbox sTd" value="<%:Model.ADJUST_PRICE %>"
                                id="ADJUST_PRICE" name="ADJUST_PRICE" data-options="required:true" title="请输入非负数" />
                        </td>
                    </tr>
                    <tr>
                        <td class="fTd">
                            调整原因:
                        </td>
                        <td>
                            <input type="text" class="easyui-validatebox" id="COMMENTS" name="COMMENTS" value="<%:Model.COMMENTS %>" />
                        </td>
                    </tr>
                </table>
            </fieldset>
            <%:Html.Partial("UploadFileView")%>
            </form>
        </div>
    </div>
</body>
</html>
