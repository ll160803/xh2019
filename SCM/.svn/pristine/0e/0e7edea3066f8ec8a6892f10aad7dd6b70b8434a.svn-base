<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_SCM_B_SALERETURN>" %>

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
	            url: "<%: Url.Content("~/System/SCM_B_SALERETURN/Create/")%>",
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
                        window.location.href='<%: Url.Content("~/System/SCM_B_SALERETURN/Index")%>';
                        return false;
                    }
                    
                }
	        });
	    }
        $(function () {
            $("#MATNR_ID").combogrid({
                idField: 'ID',
                textField: 'TXZ01',
                method: 'post',
                striped: true,
                panelWidth: 600,
                pagination: true,
                editable: true,
                rownumbers: true,
                url: '<%: Url.Content("~/System/SCM_D_MATER/GetComBoxDataForReturn")%>',

                columns: [[         
	                                   { field: 'MATNR', title: '物料编码', width: 80 },
	                                   { field: 'TXZ01', title: '物料名称', width: 200 },
                                       { field: 'GYSACCOUNT', title: '供应账号', width: 80 },
                                       { field: 'GYS_NAME', title: '供应商', width: 150 },
	                                   { field: 'SPEC', title: '规格', width: 80 },
                                       { field: 'SPELL_CODE', title: '拼音码', width: 80 },
	                                   { field: 'PRODUCE_AREA', title: '生产工厂', width: 200 }
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
</head>
<body>
    <div class="easyui-panel" title="资质上传" style="width: 1000px">
        <div style="padding: 10px 60px 20px 60px">
            <form id="ff" method="post">
            <fieldset>
                <legend>
                    <input class="a2 f2" type="button" onclick="submitForm();" value="保存" />
                    <input class="a2 f2" type="button" onclick="window.location.href='<%: Url.Content("~/System/SCM_B_SALERETURN/Index")%>';"
                        value="返回" />
                </legend>
                <table cellpadding="5">
                    <tr>
                        <td class="fTd">
                            <input type="hidden" id="ID" name="ID" value="<%:Model.ID %>" />
                            <span style="color: Red">*</span>SCM药品:
                        </td>
                        <td>
                            <input type="text" value="<%:Model.MATNR_ID %>" id="MATNR_ID" name="MATNR_ID" data-options="required:true"></input>
                        </td>
                    </tr>
                    <tr>
                        <td class="fTd">
                            <span style="color: Red">*</span>批次:
                        </td>
                        <td>
                            <input type="text" class="easyui-validatebox  textbox sTd" value="<%:Model.CHARG %>"
                                id="CHARG" name="CHARG" data-options="required:true,validType:'length[1,10]'" />
                        </td>
                    </tr>
                    <tr>
                        <td class="fTd">
                            <span style="color: Red">*</span>退货数量:
                        </td>
                        <td>
                            <input type="text" class="easyui-validatebox  easyui-numberbox sTd" value="<%:Model.AMOUNT %>"
                                id="AMOUNT" name="AMOUNT" data-options="required:true" title="请输入非负数" />
                        </td>
                    </tr>
                    <tr>
                        <td class="fTd">
                            退货原因:
                        </td>
                        <td>
                            <select class="easyui-combobox" id="COMMENTS"  name="COMMENTS" style="width: 200px;">
                                <option value="">请选择</option>
                                <option value="药品呆滞">药品呆滞</option>
                                <option value="药品破损">药品破损</option>
                                <option value="药品近效期">药品近效期</option>
                                <option value="药品召回">药品召回</option>
                                <option value="其他">其他</option>
                            </select>
                        </td>
                    </tr>
                </table>
            </fieldset>
            </form>
        </div>
    </div>
</body>
</html>
