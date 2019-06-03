﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
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
    <title>总务供应商注册页面</title>
    <style type="text/css">
        .fTd
        {
            width: 400px;
        }
        .sTd
        {
            width: 300px;
        }
    </style>
    <script language="javascript" type="text/javascript">
function submitForm() {
    //        if($("#hide_BANK_NAME").val().length==0||$("#hide_BANK_ADDRESS").val()==""||$("#hide_BANK_NUMBER").val()==""||$("#Hide_SERVICES").val()=="")
    //                    {
    //                       $.messager.alert('上传附件文件', '所有证件必须上传附件!');
    //                       return false;
    //                    }
    var flag = 0;
    $("input[requiredh='true']").each(function() {
        if ($(this).val().length == 0) {
            $.messager.alert('上传附件文件', '所有标红附件必须上传附件!');
            flag = 1;
            return false;
        }
    });
    if (flag == 1) {
        return false;
    }
    $('#ff').form('submit', {
        url: "<%: Url.Content("~/SCM_REGISTER/Register/")%>",
        dataType: "json",
        onsubmit: function() {

            return $(this).form("validate");
        },
        success: function(data1) {

            var data = eval("(" + data1 + ")");;
            var msg = data.Msg.substring(0, 1);
            if (msg == 'F') {
                alert(data.Msg);
                return false;
            }
            if (data.Msg == 'S:创建成功') {
                $("#ShowCode").html("<h4>请记住此码：" + data.BackValue + "</h4>").show();

            } else {
                alert(data.Msg);
            }
        }
    });
}
	    function clearForm() {
	        $('#ff').form('clear');
	    }
        
    function resetFileInput(){   
    var file=$("#FileUpload");
        file.after(file.clone().val(""));   
       file.remove();   
    }  
        function UpLoad(obj,fileID,hideID,btnID)
        {
            $("#exportexcel").val(obj);
            resetFileInput();
            $("#userexport").dialog("open");
            $("#hide_FielID").val(fileID);
             $("#hide_ID").val(hideID);
             $("#hide_btn").val(btnID);
        }

        var FileImport = function () { //点击确定按钮的时候  

            var fileID=$("#hide_FielID").val();
            var hide_ID=$("#hide_ID").val();
            var file = ($("#FileUpload").val());
            var btnID = $("#hide_btn").val();
            var id = $("#exportexcel").val();

            if (file == "") {
                $.messager.alert('上传附件文件', '请选择将要上传附件的文件!');
            } else {
                var stuff = file.substring(file.length - 3).toLowerCase();
                if (stuff == 'jpg'||stuff == 'jpeg'||stuff == 'png'||stuff=='obeg'||stuff == 'doc'||stuff=="docx"||stuff=="xlsx"||stuff=="xls"||stuff=="pdf"||stuff=="bmp"||stuff=="gif") {
                                       WC_Common.Loading(true);
                    $('#userexport').dialog("close");
                    $('#uploadexcel').form('submit', {
                        onSubmit: function () {
                            return true;
                        },
                        success: function (data) {
                            
                            if (data!="0") {
                                 var jsonData=eval("("+data+")"); 
                                 $("#"+fileID).html(jsonData.CLIENT_NAME+"  "+"<a href='#' onclick='deleteAttach(\""+jsonData.ID +"\",\""+fileID+"\",\""+hide_ID+"\",\"" + btnID +"\",\""+id+"\")'>删除</a>");
                                 $("#"+hide_ID).val(jsonData.ID);
                                $("#" + btnID).hide();
                                if (id == 19) {
                                    $("#lastDay1").show();
                                    $("#nowDay1").show();
                                }
                            } else {

                                $.messager.alert('文件上传附件', data, 'info');

                            }
                            WC_Common.Loading(false);
                        }

                    });

                }
                else
                {
                   $.messager.alert('文件上传附件', "不支持此格式！", 'info');
                }
            }
        }

        var FileImportCancel = function () {
            $('#userexport').window("close");
        }
        function deleteAttach(ID,fileID,hide_ID,btnID, obj)
        {
            $.messager.confirm('操作提示', "确认删除此附件吗？", function (r) {
                if (r) {
                    $.post('<%: Url.Content("~/SCM_REGISTER/FileDelete")%>', {
                        ID: ID
                    }, function (res) {
                        if (res == "OK") {
                            //移除删除的数据
                            $("#"+fileID).empty();
                             $("#"+hide_ID).val("");
                            $("#" + btnID).show();
                            if (obj == 19) {
                                $("#lastDay1").hide();
                                $("#nowDay1").hide();
                            }
                            $.messager.alert('操作提示', '删除成功!', 'info');
                        } else {
                            $.messager.alert('操作提示', '删除失败!', 'info');
                        }
                    });
                }
            });
        }
    </script>
</head>
<body>
    <div class="easyui-panel" title="供应商注册" style="width: 1000px">
        <div style="padding: 10px 60px 20px 60px">
            <form id="ff" method="post">
            <table cellpadding="5">
                <tr>
                    <td class="fTd">
                        <span style="color: Red">*</span>供应商名称:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" type="text" name="NAME" data-options="required:true"></input>
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        <span style="color: Red">*</span>联系人:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" type="text" name="LINK_PERSON" data-options="required:true"></input>
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        <span style="color: Red">*</span>办公电话:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" type="text" name="PHONE" data-options="required:true"></input>
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        <span style="color: Red">*</span>电子邮箱:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" type="text" name="EMAIL" data-options="required:true,validType:'email'"></input>
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        <span style="color: Red">*</span>地址:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" name="ADDRESS" data-options="required:true"></input>
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        <span style="color: Red">*</span>企业法人营业执照:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" name="BANK_NAME" data-options="required:true"></input>
                        <a href="#" class="easyui-linkbutton" name="btnSave" id="btnSave1" onclick="UpLoad(1,'BANK_NAME_Att','hide_BANK_NAME','btnSave1')">
                            上传附件</a><span id="BANK_NAME_Att"></span><input id="hide_BANK_NAME" type="hidden"
                                name="hide_BANK_NAME" requiredh="true" />
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        中华人民共和国组织结构代码证:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" name="BANK_ADDRESS" ></input>
                        <a href="#" class="easyui-linkbutton" name="btnSave2" id="btnSave2" onclick="UpLoad(2,'BANK_ADDRESS_Att','hide_BANK_ADDRESS','btnSave2')">
                            上传附件</a><span id="BANK_ADDRESS_Att"></span><input id="hide_BANK_ADDRESS" type="hidden"
                                name="hide_BANK_ADDRESS" />
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        税务登记证:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" name="BANK_NUMBER" ></input>
                        <a href="#" class="easyui-linkbutton" name="btnSave3" id="btnSave3" onclick="UpLoad(3,'BANK_NUMBER_Att','hide_BANK_NUMBER','btnSave3')">
                            上传附件</a><span id="BANK_NUMBER_Att"></span><input id="hide_BANK_NUMBER" type="hidden"
                                name="hide_BANK_NUMBER" />
                    </td>
                </tr>
                
                <tr>
                    <td class="fTd">
                        中华人民共和国医疗器械经营企业许可证：
                    </td>
                    <td>
                        <a href="#" class="easyui-linkbutton" name="A3" id="A3" onclick="UpLoad(7,'Span7','Hidden3','A3')">
                            上传附件</a><span id="Span7"></span><input id="Hidden3" type="hidden" name="Hidden3" />
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        中华人民共和国危险化学品经营许可证：
                    </td>
                    <td>
                        <a href="#" class="easyui-linkbutton" name="A4" id="A4" onclick="UpLoad(8,'Span8','Hidden4','A4')">
                            上传附件</a><span id="Span8"></span><input id="Hidden4" type="hidden" name="Hidden4" />
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        <span style="color: Red">*</span>开发票资料及银行账户信息：
                    </td>
                    <td>
                        <a href="#" class="easyui-linkbutton" name="A6" id="A6" onclick="UpLoad(11,'Span11','Hidden6','A6')">
                            上传附件</a><span id="Span11"></span><input id="Hidden6" type="hidden" name="Hidden6"
                                requiredh="true" />
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        企业税票模板：
                    </td>
                    <td>
                        <a href="#" class="easyui-linkbutton" name="A7" id="A7" onclick="UpLoad(12,'Span12','Hidden7','A7')">
                            上传附件</a><span id="Span12"></span><input id="Hidden7" type="hidden" name="Hidden7"
                                 />
                    </td>
                </tr>
               
                <tr>
                    <td class="fTd">
                        企业样章备案：
                    </td>
                    <td>
                        <a href="#" class="easyui-linkbutton" name="A9" id="A9" onclick="UpLoad(14,'Span14','Hidden9','A9')">
                            上传附件</a><span id="Span14"></span><input id="Hidden9" type="hidden" name="Hidden9"
                                 />
                    </td>
                </tr>
               
                <tr>
                    <td class="fTd">
                        廉洁协议：
                    </td>
                    <td>
                        <a href="#" class="easyui-linkbutton" name="A13" id="A13" onclick="UpLoad(18,'Span18','Hidden13','A13')">
                            上传附件</a><span id="Span18"></span><input id="Hidden13" type="hidden" name="Hidden13"
                                 />
                    </td>
                </tr>

                             <tr>
                    <td class="fTd">
                        采购合同：
                    </td>
                    <td>
                        <a href="#" class="easyui-linkbutton" name="A19" id="A19" onclick="UpLoad(19,'Span19','Hidden19','A19')">
                            上传附件</a><span id="Span19"></span><input id="Hidden19" type="hidden" name="Hidden19"
                                 />
                    </td>
                </tr>
                
                             <tr>
                    <td class="fTd" id="lastDay1" style="display: none">
                        采购合同有效期：
                    </td>
                    <td id="nowDay1"  style="display: none">
                        <input class="easyui-datebox" id="lastDay" name="CONTRACT_START" style="width: 100px" value="2019-01-01" />
                        <span> 至 </span>
                        <input class="easyui-datebox" id="nowDay" name="CONTRACT_END" style="width: 100px" value="2020-01-01" />
                    </td>
                </tr>
               
            </table>
            </form>
            <div style="text-align: center; padding: 5px">
                <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm()">提交</a>
                <a href="javascript:void(0)" class="easyui-linkbutton" onclick="window.history.go(-1);">
                    返回登录</a>
            </div>
            <div id="ShowCode" style="color: Red;">
            </div>
        </div>
    </div>
    <div id="userexport" class="easyui-dialog" title="文件上传" modal="true" minimizable="false"
        maximizable="false" collapsible="false" style="width: 500px; height: 200px; padding: 5px;
        background: #fafafa;" data-options="iconCls:'icon-save',resizable:false,closed:true,buttons:[{
				text:'上传附件',
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
                <form id="uploadexcel" enctype="multipart/form-data" action="<%:Url.Content("~/Codes/ImportPicture_Reg.ashx")%>"
                method="post">
                <input id="exportexcel" name="exportexcel" type="hidden" />
                <input id="hide_FielID" name="hide_FielID" type="hidden" />
                <input id="hide_ID" name="hide_ID" type="hidden" />
                <input id="hide_btn" name="hide_btn" type="hidden" />
                导入文件
                <input id="FileUpload" name="FileUpload" type="file" style="width: 400px; background: White"
                    class="easyui-validatebox" validtype="length[1,100]" />
                </form>
            </div>
        </div>
    </div>
</body>
</html>
