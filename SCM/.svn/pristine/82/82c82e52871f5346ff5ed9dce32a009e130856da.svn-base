<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

 <fieldset>
        <legend>附件</legend>
        <table id="grid_FileInfo">
        </table>
        <div id="uploadPannel" class="easyui-dialog" title="文件上传" style="width: 670px; height: 450px;"
            data-options="iconCls:'icon-save',resizable:true,modal:true,closed:true,buttons:[{
				text:'上传',
                iconCls:'icon-add',
				handler:function(){
                
                $('#FileUpload').uploadifyUpload();
                
                }
			},{
				text:'关闭',
                iconCls:'icon-cancel',
				handler:function(){$('#uploadPannel').dialog('close')}
			}]">
            <div class="editor-label">
                文件上传：
            </div>
            <div class="editor-field">
                <div style="font-size: 12px">
                    <div id="fileQueue" style="width: 450px; height: 300px; border: 1px solid #999; margin-bottom: 5px;
                        padding-left: 5px; overflow: auto;">
                    </div>
                    <div>
                        <input type="file" name="FileUpload" id="FileUpload" />
                    </div>
                </div>
            </div>
        </div>
       
    </fieldset>
    <link href="<%: Url.Content("~/Res/jquery.uploadify-v2.1.4/uploadify.css")%>" rel="stylesheet"
        type="text/css" />
    <script src="<%:Url.Content("~/Res/jquery.uploadify-v2.1.4/jquery.uploadify.v2.1.4.js")%>"
        type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/jquery.uploadify-v2.1.4/swfobject.js")%>" type="text/javascript"></script>
    <script type="text/javascript">
        var perfGuid = '<%:ViewBag.ID %>';

        $(function () {

            $("#FileUpload").uploadify({//上传文件
                'uploader': '<%: Url.Content("~/Res/jquery.uploadify-v2.1.4/uploadify.swf")%>',
                //进度条，Uploadify里面含有 
                'script': '<%: Url.Content("~/Codes/ImportPicture.ashx")%>',

                //一般处理程序 
                'cancelImg': '<%: Url.Content("~/Res/jquery.uploadify-v2.1.4/cancel.png")%>',
                //取消图片路径 
                'folder': '<%:Url.Content("~/UploadFile")%>',
                //上传文件夹名 
                'queueID': 'fileQueue',
                'scriptData': {
                    "En_ID": perfGuid
                },
                'fileDesc': '*.jpg;*.pdf;*.gif;*.png;*.xlsx;*.xls;*.doc;*.docx;*.ppt;',
                'fileExt': '*.jpg;*.pdf;*.gif;*.png;*.xlsx;*.xls;*.doc;*.docx;*.ppt;',
                'auto': false,
                'onComplete': function (event, queueID, fileObj, response, data) {
                    if (response == "0") {
                        alert("图片或视频格式错误");
                    } else {
                        $("#grid_FileInfo").datagrid("reload");
                        var value = response; self.close(); window.opener.unlockui(value);
                    }
                },
                'multi': true,
                'sizeLimit': 10737418240
                , 'onSelect': function (event, queueID, fileObj) {
                    $("#uploadify").uploadifySettings("scriptData", {
                        "En_ID": perfGuid
                    });
                }
            });

            $('#grid_FileInfo').datagrid({
                url: '<%:Url.Content("~/system/COM_FILE/GetData/")%>' + perfGuid,
                singleSelect: true,
                sortName: 'ID',
                sortOrder: 'desc',
                idField: 'ID',
                pagination: true,
                rownumbers: true,
                toolbar: [
                    {
                        iconCls: 'icon-add',
                        text: '上传附件',
                        handler: function () { $('#uploadPannel').dialog('open'); }
                    }
                ],
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
                 return "<a id='a_delete' class='examinecls' title='查看附件' href='#' onclick='DownFile(\"" + rowData.SERVER_NAME + "\")'></a><a id='a_delete' class='exa' title='删除附件' href='#' onclick='DeleteFile(\"" + rowData.ID + "\")'></a>";

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
        });






        function DeleteFile(id) {


            $.messager.confirm('操作提示', "确认删除这项吗？",
    function (r) {
        if (r) {
            $.post("<%:Url.Content("~/system/COM_FILE/Delete/")%>" + id,
            function (res) {
                if (res == "OK") {
                    //移除删除的数据
                    $("#grid_FileInfo").datagrid("reload");
                    $("#grid_FileInfo").datagrid("clearSelections");
                    $.messager.alert('操作提示', '删除成功!', 'info');
                } else {
                    if (res == "") {
                        $.messager.alert('操作提示', '删除失败!请查看该数据与其他模块下的信息的关联，或联系管理员。', 'info');
                    } else {
                        $.messager.alert('操作提示', res, 'info');
                    }
                }
            });
        }
    });

        }
        ///查看附件
        function DownFile(id) {

            window.open("<%:Url.Content("~/UploadFile/BaseInfo/")%>" + id, '_blank')

        }

       
    </script>