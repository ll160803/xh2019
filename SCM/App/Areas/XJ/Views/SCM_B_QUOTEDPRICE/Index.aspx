<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Common.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
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
                <input id="exportexcel" name="exportexcel" type="hidden" value="1" />
                <input id="hide_FielID" name="hide_FielID" type="hidden" /><!--（隐藏上传文件返回的ID的）文本框ID -->
                <input id="hide_ID" name="hide_ID" type="hidden" /><!--（隐藏上传文件返回的ID的)DISPLAY_INDEX -->
                <input id="hide_btn" name="hide_btn" type="hidden" /><!--上传按钮ID -->
                导入文件
                <input id="FileUpload" name="FileUpload" type="file" style="width: 400px; background: White"
                    class="easyui-validatebox" validtype="length[1,100]" />
                </form>
            </div>
        </div>
    </div>
    <div id="tb">
        <div class="tbtop">
            药品名称:<input name="M_NAME">
            药品规格:<input name="M_STANDARD">
            报价状态:<select name="BJ_STATE" class="easyui-combobox">
                <option value="">全部</option>
                <option value="0">待报价</option>
                <option value="1">已报价</option>
            </select>
            询价状态:
            <select name="XJ_STATE" class="easyui-combobox">
                <option value="">全部</option>
                <option value="SCM000102">询价中</option>
                <option value="SCM000103">已结束</option>
            </select>
        </div>
        <div class="tbbottom">
            询价时间：<input name="xj_from" class="easyui-datebox" />
            -
            <input name="xj_to" class="easyui-datebox" />
            <e></e>
            截止时间：
            <input name="jz_from" class="easyui-datebox" />
            -
            <input name="jz_to" class="easyui-datebox" />
            <a href="#" id="tosearch" class="icon-sousuo">查询</a>
        </div>
    </div>
    <div id="dataTable">
    </div>
    <div id="toadd" class="adddiv">
        <div class="title">
            <span>询价信息</span> <span class="icon-back" id="closeicon" onclick="Closebj()">返回</span>
        </div>
        <div class="content">
            <div class="top">
                <span class="wybj">我要报价</span> <a class="submitbjbtn" href="javascript:;" id="submitbj"
                    onclick="Submitbj()">保存并提交</a> <a class="updatebjbtn" href="javascript:;" id="keepbj"
                        onclick="Keepbj()">保存</a>
                <!--<a class="backbtn" href="javascript:;" onclick="Closebj()">返回</a>-->
            </div>
            <div class="nav">
                药品名称：<span class="M_NAME"></span> 物料号： <span class="WULIAO"></span>规格： <span class="M_STANDARD">
                </span>计量单位： <span class="UNIT"></span>采购数量： <span class="AMOUNT"></span>
            </div>
            <div class="main">
                <input type="hidden" name="hidden_XJID" />
                <ul id="bjul">
                </ul>
            </div>
            <a class="addbj" href="javascript:;" id="addbj"></a>
            <p class="padd">
                新增报价</p>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="<%: Url.Content("~/Scripts/XJ/bj.css") %>" />
    <script src="<%: Url.Content("~/Scripts/XJ/provider.js") %>"></script>
    <script src="<%: Url.Content("~/Scripts/JScriptIndex.js") %>" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
        var girdUrl = '<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetData")%>';
        var bjUrl = '<%: Url.Content("~/XJ/SCM_B_QUOTEDPRICE/GetQuotedPriceByQueryIndex")%>';
        var SaveUrl = '<%: Url.Content("~/XJ/SCM_B_QUOTEDPRICE/SAVE")%>';
        var DeleteQuoted_Url = '<%: Url.Content("~/XJ/SCM_B_QUOTEDPRICE/DeleteByQueryID")%>';
        var fileurl="<%: Url.Content("~/System/MDM/DownFile")%>";//文件下载路径
        //        $(function () {
        //            $("#XJ_STATE").combobox({
        //                url: '<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetQuotedStateCombobox")%>',
        //                valueField: 'value',
        //                textField: 'text'
        //            });
        //        });
     
    </script>
    <style type="text/css" >
    .datagrid-toolbar
    {
         background:#ffffff none repeat scroll 0 0;
    }
    </style>
    <script language="javascript" type="text/javascript">
        function resetFileInput() {
            var file = $("#FileUpload");
            file.after(file.clone().val(""));
            file.remove();
        }
        function UpLoad(hidefileID, displayIndex, savebtn_id) {
            resetFileInput();
            $("#userexport").dialog("open");
            $("#hide_FielID").val(hidefileID);
            $("#hide_ID").val(displayIndex);
            $("#hide_btn").val(savebtn_id);
        }

        var FileImport = function () { //点击确定按钮的时候  

            var fileID = $("#hide_FielID").val();
            var displayIndex = $("#hide_ID").val();
            var file = ($("#FileUpload").val());
            var btnSaveID = $("#hide_btn").val();
            if (file == "") {
                $.messager.alert('上传文件', '请选择将要上传的文件!');
            } else {
                var stuff = file.substring(file.length - 3).toLowerCase();
                if (stuff == 'jpg' || stuff == 'jpeg' || stuff == 'png' || stuff == "pdf" || stuff == "bmp" || stuff == "gif") {
                    WC_Common.Loading(true);
                    $('#userexport').dialog("close");
                    $('#uploadexcel').form('submit', {
                        onSubmit: function () {
                            return true;
                        },
                        success: function (data) {

                            if (data != "0") {
                                var jsonData = eval("(" + data + ")");
                                $("#span_namefile" + displayIndex).html("发票附件:<a  target='_blank' href='" + fileurl + "?CLIENT_NAME=" + jsonData.CLIENT_NAME + "&SERVER_NAME=" + jsonData.SERVER_NAME + "'>" + jsonData.CLIENT_NAME + "</a>  " + "<a href='#' class='deleteFile' onclick='deleteAttach(\"span_namefile" + displayIndex + "\",\"hide_file_id" + displayIndex + "\",\"btnSave" + displayIndex + "\")'></a>");
                                $("#" + fileID).val(jsonData.ID);
                                $("#" + btnSaveID).hide();
                            } else {

                                $.messager.alert('文件上传', data, 'info');

                            }
                            WC_Common.Loading(false);
                        }

                    });

                }
                else {
                    $.messager.alert('文件上传', "不支持此格式！", 'info');
                }
            }
        }

        var FileImportCancel = function () {
            $('#userexport').window("close");
        }
        function deleteAttach(spandeleteID, hidefile_ID, btnID) {
            $.messager.confirm('操作提示', "确认删除此附件吗？", function (r) {
                if (r) {

                    //移除删除的数据
                    $("#" + spandeleteID).empty();
                    $("#" + hidefile_ID).val("");
                    $("#" + btnID).show();
                    $.messager.alert('操作提示', '删除成功!', 'info');

                }
            });
        }
    </script>
</asp:Content>
