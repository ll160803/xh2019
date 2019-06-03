﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_MDM_D_DEPT>" %>

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
    <title>供应商注册页面</title>
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
	            url: "<%: Url.Content("~/SCM_REGISTER/RegisterEdit/")%>",
                dataType: "html",
                onsubmit: function () {
                    return $(this).form("validate");
                },
                success: function (data1) {
             
                    var data=eval("("+data1+")");;
                    var msg = data.substring(0, 1);
                    if (msg == 'F') {
                         alert(data.Msg);
                        return false;
                    }
                    else{
                        alert('保存成功!');
                        return false;
                    }
                    
                }
	        });
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
            var btnID=$("#hide_btn").val();
            if (file == "") {
                $.messager.alert('上传文件', '请选择将要上传的文件!');
            } else {
                var stuff = file.substring(file.length - 3).toLowerCase();
                if (stuff == 'jpg'||stuff == 'jpeg'||stuff == 'png'||stuff=='obeg'||stuff == 'doc'||stuff=="docx"||stuff=="xlsx" ||stuff=="xls"||stuff=="pdf"||stuff=="bmp"||stuff=="gif") {
                     WC_Common.Loading(true);
                    $('#userexport').dialog("close");
                    $('#uploadexcel').form('submit', {
                        onSubmit: function () {
                            return true;
                        },
                        success: function (data) {
                            
                            if (data!="0") {
                                 var jsonData=eval("("+data+")"); 
                                 $("#"+fileID).html(jsonData.CLIENT_NAME+"  "+"<a href='#' onclick='deleteAttach(\""+jsonData.ID +"\",\""+fileID+"\",\""+hide_ID+"\",\""+btnID+"\")'>删除</a>");
                                 $("#"+hide_ID).val(jsonData.ID);
                                 $("#"+btnID).hide();
                            } else {

                                $.messager.alert('文件上传', data, 'info');

                            }
                            WC_Common.Loading(false);
                        }

                    });

                }
                else
                {
                   $.messager.alert('文件上传', "不支持此格式！", 'info');
                }
            }
        }

        var FileImportCancel = function () {
            $('#userexport').window("close");
        }
        function deleteAttach(ID,fileID,hide_ID,btnID)
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
                             $("#"+btnID).show();
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
            <input type="hidden" value="<%:Model.ID %>" id="hidID" name="hidID" />
            <%if (Model.STATE == 1)
                  { %><h4 style="color: Red">
                      尚未通过审核</h4>
            <%}
                  else if(Model.STATE == 2)
                  { %>
            <h4 style="color: Red">
                恭喜通过审核,账号为：<%:Model.CODE %></h4>
            <%} 
            else 
                  { %>
            <h4 style="color: Red">
                不存在的注册</h4>
            <%} %>
            <table cellpadding="5">
                <tr>
                    <td class="fTd">
                        <span style="color:Red">*</span>供应商名称:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" type="text" value="<%:Model.NAME %>"
                            name="NAME" data-options="required:true"></input>
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        <span style="color:Red">*</span>联系人:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" type="text" value="<%:Model.LINK_PERSON %>"
                            name="LINK_PERSON" data-options="required:true"></input>
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        <span style="color:Red">*</span>办公电话:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" type="text" value="<%:Model.PHONE %>"
                            name="PHONE" data-options="required:true"></input>
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                       <span style="color:Red">*</span>电子邮箱:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" type="text" value="<%:Model.EMAIL %>"
                            name="EMAIL" data-options="required:true,validType:'email'"></input>
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        <span style="color:Red">*</span>地址:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" name="ADDRESS" value="<%:Model.ADDRESS %>"
                            data-options="required:true"></input>
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        <span style="color:Red">*</span>企业法人营业执照:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" name="BANK_NAME" value="<%:Model.BANK_NAME %>"
                            data-options="required:true"></input>
                        <a href="#" class="easyui-linkbutton" name="btnSave" <%if(!string.IsNullOrEmpty(ViewBag.FName)){ %> style="display: none;"<%} %>;" id="btnSave1"
                            onclick="UpLoad(1,'BANK_NAME_Att','hide_BANK_NAME','btnSave1')">上传附件</a><span id="BANK_NAME_Att"><%:ViewBag.FName %><% if (Model.STATE == 1&&!string.IsNullOrEmpty(ViewBag.FName)){%><a
                                href="#" onclick="deleteAttach('<%:ViewBag.FID %>','BANK_NAME_Att','hide_BANK_NAME','btnSave1')">删除</a><%} %></span><input
                                    id="hide_BANK_NAME" type="hidden" name="hide_BANK_NAME" value="<%:ViewBag.FID %>" />
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        中华人民共和国组织结构代码证:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" name="BANK_ADDRESS" value="<%:Model.BANK_ADDRESS %>"
                            ></input>
                        <a href="#" class="easyui-linkbutton" name="btnSave2"  <%if(!string.IsNullOrEmpty(ViewBag.SName)){ %> style="display: none;"<%} %>;" id="btnSave2"
                            onclick="UpLoad(2,'BANK_ADDRESS_Att','hide_BANK_ADDRESS','btnSave2')">上传附件</a><span
                                id="BANK_ADDRESS_Att"><%:ViewBag.SName %><% if (Model.STATE == 1&&!string.IsNullOrEmpty(ViewBag.SName)){%><a href="#" onclick="deleteAttach('<%:ViewBag.SID %>','BANK_ADDRESS_Att','hide_BANK_ADDRESS','btnSave2')">删除</a><%} %></span><input
                                    id="hide_BANK_ADDRESS" type="hidden" name="hide_BANK_ADDRESS" value="<%:ViewBag.SID %>" />
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        税务登记证:
                    </td>
                    <td>
                        <input class="easyui-validatebox  textbox sTd" name="BANK_NUMBER" value="<%:Model.BANK_NUMBER %>"
                            ></input>
                        <a href="#" class="easyui-linkbutton" name="btnSave3" <%if(!string.IsNullOrEmpty(ViewBag.TName)){ %> style="display: none;"<%} %>;" id="btnSave3"
                            onclick="UpLoad(3,'BANK_NUMBER_Att','hide_BANK_NUMBER','btnSave3')">上传附件</a><span id="BANK_NUMBER_Att"><%:ViewBag.TName %><% if (Model.STATE == 1&&!string.IsNullOrEmpty(ViewBag.TName)){%><a
                                href="#" onclick="deleteAttach('<%:ViewBag.TID %>','BANK_NUMBER_Att','hide_BANK_NUMBER','btnSave3')">删除</a><%} %></span><input
                                    id="hide_BANK_NUMBER" type="hidden" name="hide_BANK_NUMBER" value="<%:ViewBag.TID %>" />
                    </td>
                </tr>
               
                <tr>
                    <td class="fTd">
                        中华人民共和国医疗器械经营企业许可证：
                    </td>
                    <td>
                        <a href="#" class="easyui-linkbutton" name="A3" id="A3" <%if(!string.IsNullOrEmpty(ViewBag.Name_7)){ %> style="display: none;"<%} %> onclick="UpLoad(7,'Span7','Hidden3','A3')">
                            上传附件</a><span id="Span7"><%:ViewBag.Name_7 %><% if (Model.STATE == 1&&!string.IsNullOrEmpty(ViewBag.Name_7)){%><a
                                href="#" onclick="deleteAttach('<%:ViewBag.ID_7 %>','Span7','Hidden3','A3')">删除</a><%} %></span><input id="Hidden3" type="hidden" name="Hidden3" value="<%:ViewBag.ID_7 %>" />
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        中华人民共和国危险化学品经营许可证：
                    </td>
                    <td>
                        <a href="#" class="easyui-linkbutton" name="A4" id="A4" <%if(!string.IsNullOrEmpty(ViewBag.Name_8)){ %> style="display: none;"<%} %> onclick="UpLoad(8,'Span8','Hidden4','A4')">
                            上传附件</a><span id="Span8"><%:ViewBag.Name_8 %><% if (Model.STATE == 1&&!string.IsNullOrEmpty(ViewBag.Name_8)){%><a
                                href="#" onclick="deleteAttach('<%:ViewBag.ID_8 %>','Span8','Hidden4','A4')">删除</a><%} %></span><input id="Hidden4" type="hidden" name="Hidden4" value="<%:ViewBag.ID_8 %>" />
                    </td>
                </tr>
               
                <tr>
                    <td class="fTd">
                        <span style="color: Red">*</span>开发票资料及银行账户信息：
                    </td>
                    <td>
                        <a href="#" class="easyui-linkbutton" name="A6" id="A6" <%if(!string.IsNullOrEmpty(ViewBag.Name_11)){ %> style="display: none;"<%} %> onclick="UpLoad(11,'Span11','Hidden6','A6')">
                            上传附件</a><span id="Span11"><%:ViewBag.Name_11 %><% if (Model.STATE == 1&&!string.IsNullOrEmpty(ViewBag.Name_11)){%><a
                                href="#" onclick="deleteAttach('<%:ViewBag.ID_11 %>','Span11','Hidden6','A6')">删除</a><%} %></span><input id="Hidden6" type="hidden" name="Hidden6" requiredh="true" value="<%:ViewBag.ID_11 %>" />
                    </td>
                </tr>
                <tr>
                    <td class="fTd">
                        企业税票模板：
                    </td>
                    <td>
                        <a href="#" class="easyui-linkbutton" name="A7" id="A7" <%if(!string.IsNullOrEmpty(ViewBag.Name_12)){ %> style="display: none;"<%} %> onclick="UpLoad(12,'Span12','Hidden7','A7')">
                            上传附件</a><span id="Span12"><%:ViewBag.Name_12 %><% if (Model.STATE == 1&&!string.IsNullOrEmpty(ViewBag.Name_12)){%><a
                                href="#" onclick="deleteAttach('<%:ViewBag.ID_12 %>','Span12','Hidden7','A7')">删除</a><%} %></span><input id="Hidden7" type="hidden" name="Hidden7"  value="<%:ViewBag.ID_12 %>" />
                    </td>
                </tr>
               
                <tr>
                    <td class="fTd">
                        企业样章备案：
                    </td>
                    <td>
                        <a href="#" class="easyui-linkbutton" name="A9" id="A9" <%if(!string.IsNullOrEmpty(ViewBag.Name_14)){ %> style="display: none;"<%} %> onclick="UpLoad(14,'Span14','Hidden9','A9')">
                            上传附件</a><span id="Span14"><%:ViewBag.Name_14 %><% if (Model.STATE == 1&&!string.IsNullOrEmpty(ViewBag.Name_14)){%><a
                                href="#" onclick="deleteAttach('<%:ViewBag.ID_14 %>','Span14','Hidden9','A9')">删除</a><%} %></span><input id="Hidden9" type="hidden" name="Hidden9"  value="<%:ViewBag.ID_14 %>" />
                    </td>
                </tr>
               
                <tr>
                    <td class="fTd">
                        <span style="color: Red">*</span>廉洁协议：
                    </td>
                    <td>
                        <a href="#" class="easyui-linkbutton" name="A13" id="A13" <%if(!string.IsNullOrEmpty(ViewBag.Name_18)){ %> style="display: none;"<%} %> onclick="UpLoad(18,'Span18','Hidden13','A13')">
                            上传附件</a><span id="Span18"><%:ViewBag.Name_18 %><% if (Model.STATE == 1 &&!string.IsNullOrEmpty(ViewBag.Name_18)){%><a
                                href="#" onclick="deleteAttach('<%:ViewBag.ID_18 %>','Span18','Hidden13','A13')">删除</a><%} %></span><input id="Hidden13" type="hidden" name="Hidden13"
                            value="<%:ViewBag.ID_18 %>"    requiredh="true" />
                    </td>
                </tr>
                
            </table>
            </form>
            <div style="text-align: center; padding: 5px">
                <% if (Model.STATE == 1)//没有通过的用户
                   {%>
                <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm()">保存</a>
                <% }%>
            </div>
            <div id="ShowCode" style="color: Red;">
            </div>
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
                <form id="uploadexcel" enctype="multipart/form-data" action="<%:Url.Content("~/Codes/ImportPicture_Reg.ashx")%>"
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
