<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Common.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        td[field="AMOUNT"] span{
                color:Red;
        }
       .datagrid-body  td[field="AMOUNT"]
        {
        	border:1px solid #ccc;
        	}
        	.datagrid-body  td[field="PRODUCT_NAME"]
        	{
        	border:1px solid #ccc;
        	}
        	.datagrid-body  td[field="END_DATES"]
        	{
        	border:1px solid #ccc;
        	}
    </style>
    <div id="dlg" class="easyui-dialog" title="浏览供应商价格调整" data-options="iconCls:'icon-save',closed:true,"
        style="width: 700px; height: 400px; padding: 5px;">
       <div style="width:650px;background-color:#F1F1F1; padding: 2px 10px 5px 10px;font-size: 14px;margin: 10px auto">
            <label id="lab_TXZ01" style="margin-right: 10px;line-height: 25px"></label>
            <label id="lab_MATNR" style="margin-right: 10px;line-height: 25px"></label>
            <label id="lab_SPEC" style="margin-right: 10px;line-height: 25px"></label>
            <label id="lab_MSEHT" style="margin-right: 10px;line-height: 25px"></label>
            <label id="lab_OLD_PRICE" style="margin-right: 10px;line-height: 25px"></label></br>
            <label id="lab_ADJUST_PRICE" style="margin-right: 10px;line-height: 25px"></label>
            <label id="lab_GYSNAME" style="margin-right: 10px;line-height: 25px"></label>
            <label id="lab_GYSACCOUNT" style="margin-right: 10px;line-height: 25px"></label></br>
            <label id="lab_COMMENTS" style="line-height: 25px"></label>
        </div>
        <table id="grid_FileInfo">
        </table>
    </div>
<div id="add">
          <div id="add_top">
              <p><i>新增询价请求</i>
              <button onclick="Texist()">保存并提交</button>
              <button type="button" onclick="exist()">保存</button>
              <button onclick="back()">返回</button></p>
              
          </div>
        
        <div id="add_middle">
            <div class="Amiddle_top">
                <button type="button" onclick="factoryadd()">新增药品</button>
                <button type="button" onclick="dell(Adg)">删除药品</button>
            </div>
            <div class="addDialog" style="height:260px;">
                <table id="Adg" class="easyui-datagrid" style="height:250px;">

                </table>
            </div>
        </div>
        <div id="add_last">
            <div class="Amiddle_top">
                <button type="button" onclick="addhost()">新增供应商</button>
                <button type="button" onclick="dellg(dt)">删除供应商</button>
            </div>
            <div class="addDialog">
                <table id="dt" class="easyui-datagrid" style="height:200px;">

                </table>
            </div>
        </div>
        <!-- 弹出层-->
        <div id="Afactory">
            <div id="bb"  style="height:60px;">
                <div data-options="region:'center'" style="padding:5px;" >
                    <div style="height:30px;margin-top: 15px;">
                        <input  id="modalName" type="text" />
                        <button  class="easyui-linkbutton" plain="true" onclick="doSearch(dd,modalName)" id="CX" style="margin-right:20px;">查询</button>
                       <b style="color:red">截止日期：</b><input id="time" type="time" class="easyui-datebox" data-options="formatter:myformatter,parser:myparser" name="END_DATE"/>
                       <button type="button" onclick="addSubmit()" style="margin-left:10px;">确定</button>
                       <button type="button" onclick="addClose()">取消</button>
                   </div>
                </div>
            </div>
            <div>
                <table class="easyui-datagrid" id="dd" style="height:300px;">

                </table>
            </div>
        </div>
        <!-- 供应商弹窗-->
        <div id="Bfactory">
            <div   style="height:60px;" id="toolbar">
                <div data-options="region:'center'" style="padding:5px;">
                    <div style="height:30px;margin-top: 15px;">
                        <input   type="text" id="Sou"/>
                        <button  class="easyui-linkbutton" plain="true" onclick="doSearch(gg,Sou)" id="DCX" class='button1'>查询</button>
                        <button type="button" onclick="YPaddSubmit()" style="margin-left:30px;">确定</button>
                        <button type="button" onclick="YPaddClose()">取消</button>
                    </div>
                </div>
            </div>
            <div>
                <table class="easyui-datagrid" id="gg" style="height:300px;">

                </table>
            </div>
        </div>
        
        
    </div>
    
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
<link rel="stylesheet" type="text/css" href="<%: Url.Content("~/Scripts/XJ/add.css") %>">
<script >
        //询价信息删除调用
        var UrlDelete = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/Delete") %>";
        var XJ_id="<%=ViewBag.ID %>";
        //询价信息修改调整调用
        var UrlDataEditList = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetDataEditList") %>";
        var UrlDataEditSubData = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetDataEditSubData") %>";
        var UrlMaterData = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetMaterData") %>";
        var UrlMdmDeptData = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetMdmDeptData") %>";
        var UrlUpdate = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/Update") %>";
        var UrlIndex = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/Index") %>";
        var UrlPriceAdjustFile="<%:Url.Content("~/system/COM_FILE/GetData/")%>";
        var UrlPriceAdjustQuery="<%:Url.Content("~/XJ/SCM_B_PRICEADJUST/QueryPriceAdjust")%>";
        ///查看附件
        function DownFile(id) {
            window.open("<%:Url.Content("~/UploadFile/BaseInfo/")%>" + id, '_blank');
        }
    </script>
<script src="<%: Url.Content("~/Scripts/XJ/add.js") %>" ></script>
</asp:Content>
