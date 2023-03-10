<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_SCM_D_GYS_MATER_PIC>" %>

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
    var flag = 0;
    $("input[requiredh='true']").each(function() {
        if ($(this).val().length == 0) {
            $.messager.alert('上传附件文件', '必须上传附物料检验证书!','warning');
            //alert($(this).attr("id"));
            flag = 1;
            return false;
        }
    });
    if (flag == 1) {
        return false;
    }
	        $('#ff').form('submit', {
	            url: "<%: Url.Content("~/System/SCM_D_MATER/Create/")%>",
                dataType: "html",
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
                        window.location.href='<%: Url.Content("~/System/SCM_D_MATER/Index")%>';
                        return false;
                    }
                    
                }
	        });
	    }
        $(function () {
            $("#MATER_ID").combogrid({
                idField: 'ID',
                textField: 'TXZ01',
                method: 'post',
                striped: true,
                panelWidth: 600,
                pagination: true,
                editable: true,
                rownumbers: true,
                url: '<%: Url.Content("~/System/SCM_D_MATER/GetComBoxData")%>',

                columns: [[
	                                   { field: 'MATNR', title: '物料编码', width: 80 },
	                                   { field: 'TXZ01', title: '物料名称', width: 200 },
	                                   { field: 'SPEC', title: '规格', width: 150 },
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
        function resetFileInput() {
            var file = $("#FileUpload");
            file.after(file.clone().val(""));
            file.remove();
        }
        function UpLoad(obj, fileID, hideID, btnID) {
            $("#exportexcel").val(obj);
            resetFileInput();
            $("#userexport").dialog("open");
            $("#hide_FielID").val(fileID);
            $("#hide_ID").val(hideID);
            $("#hide_btn").val(btnID);
        }

        var FileImport = function () { //点击确定按钮的时候  

            var fileID = $("#hide_FielID").val();
            var hide_ID = $("#hide_ID").val();
            var file = ($("#FileUpload").val());
            var btnID = $("#hide_btn").val();
            if (file == "") {
                $.messager.alert('上传文件', '请选择将要上传的文件!','warning');
            } else {
               
                 if(GetLength(file)>50)
                {
                   $.messager.alert('文件上传', '文件名太长！', 'info');
                }
                else 
                {
                 var stuff = file.substring(file.length - 3).toLowerCase();
                if (stuff == "pdf"||stuff == "xls") {
                    WC_Common.Loading(true);
                    $('#userexport').dialog("close");
                    $('#uploadexcel').form('submit', {
                        onSubmit: function () {
                            return true;
                        },
                        success: function (data) {

                            if (data != "0") {
                                var jsonData = eval("(" + data + ")");
                                $("#" + fileID).html(jsonData.CLIENT_NAME + "  " + "<a href='#' onclick='deleteAttach(\"" + jsonData.ID + "\",\"" + fileID + "\",\"" + hide_ID + "\",\"" + btnID + "\")'>删除</a>");
                                $("#" + hide_ID).val(jsonData.ID);
                                $("#" + btnID).hide();
                            } else {

                                $.messager.alert('文件上传', '最大上传文件大小为3M', 'info');

                            }
                            WC_Common.Loading(false);
                        }

                    });

                }
                else {
                    $.messager.alert('文件上传', "只支持PDF格式！", 'info');
                }
                
                }
            }
        }

        var FileImportCancel = function () {
            $('#userexport').window("close");
        }
        function deleteAttach(ID, fileID, hide_ID, btnID) {
            $.messager.confirm('操作提示', "确认删除此附件吗？", function (r) {
                if (r) {
                    $.post('<%: Url.Content("~/HOME/FileDelete")%>', {
                        ID: ID
                    }, function (res) {
                        if (res == "OK") {
                            //移除删除的数据
                            $("#" + fileID).empty();
                            $("#" + hide_ID).val("");
                            $("#" + btnID).show();
                            $.messager.alert('操作提示', '删除成功!', 'info');
                        } else {
                            $.messager.alert('操作提示', '删除失败!', 'info');
                        }
                    });
                }
            });
        }
         GetLength = function(str)   
{  
    var realLength = 0;  
    for (var i = 0; i < str.length; i++)   
    {  
        charCode = str.charCodeAt(i);  
        if (charCode >= 0 && charCode <= 128)   
        realLength += 1;  
        else   
        realLength += 2;  
    }  
    return realLength;  
}  
    </script>
</head>
<body>
    <div class="easyui-panel" title="资质上传" style="width: 1000px">
        <div style="padding: 10px 60px 20px 60px">
            <form id="ff" method="post">
            
            <fieldset>
                <legend>
                    <input class="a2 f2" type="button" onclick="submitForm();" value="保存" />
                    <input class="a2 f2" type="button" onclick="window.location.href='<%: Url.Content("~/System/SCM_D_MATER/Index")%>';" value="返回" />
                </legend>
                <table cellpadding="5">
                    <tr>
                        <td class="fTd">
                         <input type="hidden" id="ID"  name="ID"  value="<%:Model.ID %>" />
                            <span style="color: Red">*</span>SCM药品:
                        </td>
                        <td>
                            <input type="text" value="<%:Model.MATER_ID %>" id="MATER_ID" name="MATER_ID" data-options="required:true"></input>
                        </td>
                    </tr>
                    <tr>
                        <td class="fTd">
                            <span style="color: Red">*</span>批次:
                        </td>
                        <td>
                            <input type="text" class="easyui-validatebox  textbox sTd" value="<%:Model.CHARGE %>" id="CHARGE" name="CHARGE" data-options="required:true,validType:'length[1,20]'"></input>
                        </td>
                    </tr>
                    <tr>
                        <td class="fTd">
                           <span style="color: Red">*</span>物料检验证书上传:
                        </td>
                        <td>
                         <a href="#" class="easyui-linkbutton" name="btnSave" <%if(!string.IsNullOrEmpty(ViewBag.FName)){ %> style="display: none;"<%} %>;" id="btnSave1"
                            onclick="UpLoad(1,'BANK_NAME_Att','hide_BANK_NAME','btnSave1')">上传附件</a><span id="BANK_NAME_Att"><%:ViewBag.FName %><% if (!string.IsNullOrEmpty(ViewBag.FName)){%><a
                                href="#" onclick="deleteAttach('<%:ViewBag.FID %>','BANK_NAME_Att','hide_BANK_NAME','btnSave1')">删除</a><%} %></span><input
                                 requiredh="true"   id="hide_BANK_NAME" type="hidden" name="hide_BANK_NAME" value="<%:ViewBag.FID %>" />
                        </td>
                    </tr>
                </table>
            </fieldset>
            </form>
        </div>
    </div>
    <div id="userexport" class="easyui-dialog" title="文件上传" modal="true" minimizable="false"
                maximizable="false" collapsible="false" style="width: 500px; height: 200px; padding: 5px;
                background: #fafafa;" data-options="iconCls:'icon-save',resizable:false,closed:true,buttons:[{
				text:'上传',
				iconCls:'icon-save',
				handler:function(){FileImport();}
			},{
				text:'取消',
				iconCls:'icon-cancel',
				handler:function(){FileImportCancel();}
			}]">
                <div class="easyui-layout" fit="true">
                    <div region="center" border="false" style="padding: 10px; background: #fff; border: 1px solid #ccc;"
                        mce_style="padding:10px;background:#fff;border:1px solid #ccc;">
                        <form id="uploadexcel" enctype="multipart/form-data" action="<%:Url.Content("~/Codes/ScmUpload.ashx")%>"
                        method="post">
                        <input id="exportexcel" name="exportexcel" type="hidden" />
                        <input id="hide_FielID" name="hide_FielID" type="hidden" />
                        <input id="hide_ID" name="hide_ID" type="hidden" />
                        <input id="hide_btn" name="hide_btn" type="hidden" />
                        <input id="En_ID" name="En_ID" type="hidden" value="<%:Model.ID %>" />
                        导入文件
                        <input id="FileUpload" name="FileUpload" type="file" style="width: 400px; background: White"
                            class="easyui-validatebox" validtype="length[1,100]" />
                        </form>
                    </div>
                </div>
            </div>
</body>
</html>
