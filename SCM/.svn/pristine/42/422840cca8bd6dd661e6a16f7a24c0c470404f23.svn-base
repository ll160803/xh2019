<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Common.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div id="e_all">
        <div id="e_top">
            <form method="post" action="" id="CXform" >
                <div style="padding:15px 0 10px 15px;">
                    <label for="TXZ01">药品名称：</label>
                    <input name="TXZ01" type="text" class="easyui-validatebox" style="margin-right: 90px;">
                    <label for="SPEC" >药品规格：</label>
                    <input name="SPEC" type="text" class="easyui-validatebox" style="margin-right: 90px;">
                    <label for="QUERY_STATE">询价状态：</label>
                    <select  style="border:1px solid #aaaaaa;" panelHeight="100px" class="easyui-combobox" id="QUERY_STATE">
                        <option value="">全部</option>
                        <option value="SCM000101">未询价</option>
                        <option value="SCM000102">询价中</option>
                        <option value="SCM000103">已结束</option>
                    </select>
               </div>
               <div style="padding:0 0 10px 15px;">
                    <label for="BEGIN_QUERY_DATE">询价时间：</label>
                    <input type="text" name="BEGIN_QUERY_DATE" class="easyui-datebox easyui-validatebox" data-options="formatter:myformatter,parser:myparser">-<input type="text" name="END_QUERY_DATE" class="easyui-datebox easyui-validatebox" data-options="formatter:myformatter,parser:myparser">
                    <label for="BEGIN_END_DATE" style="margin-left: 65px;">截止时间：</label>
                    <input type="text" name="BEGIN_END_DATE" class="easyui-datebox easyui-validatebox" data-options="formatter:myformatter,parser:myparser">-<input type="text" name="END_END_DATE" class="easyui-datebox easyui-validatebox" data-options="formatter:myformatter,parser:myparser">
                    <button  onclick="FormCX()" style="padding:0 15px;margin-left:50px;" type="button">查询</button>
                </div>

            </form>
        </div>
        <div id="e_next">
            <div id="e_next_button">
               <a href="#"> <button onclick="XZgride()">新增询价请求</button></a>
                <button onclick="tanchuang()" type="button">批量结束询价</button>
                <button onclick=" batchcancel()" type="button">批量撤销结束</button>
            </div>
            <div id="enquiryGrid">
                <table id="dg" class="easyui-datagrid" >

                </table>
            </div>
        </div>
        <!-- 弹出层单独撤销结束-->
        <div id="hid">
            <div id="bb" class="easyui-layout" style="height:60px;">
                <div data-options="region:'center'" style="padding:5px;text-align:center;width:300px;">
                   截止时间： <input  id="modalTime" type="time" class="easyui-datebox" data-options="formatter:myformatter,parser:myparser">
                   <input type="hidden"  id="hidden"/>
                </div>
            </div>
            <div>
                <div class="srcSetWindow-btn">
                    <button id="hidSubmit" class="myButton" type="button" onclick="chexiao()" style='margin-left:100px;'>确定</button>
                    <button id="hidCancel" class="myButton0" type="button" onclick="CClose()">取消</button>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" type="text/css" href="<%: Url.Content("~/Scripts/XJ/equiry.css") %>">
    <script >
        //询价信息列表调用
        var UrlGetDataList = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetDataList") %>";
        //询价信息修改状态调用
        var UrlUpdateType = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/UpdateType") %>";
        //询价信息删除调用
        var UrlDelete = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/Delete") %>";

        var UrlQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetQuotedDetail") %>";

        var UrlCreate = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/Create") %>";
        var UrlQuotedDetailList = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/QuotedDetailList") %>";

        var UrlExportQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/ExportQuotedDetail") %>";

        function create()
        {
           window.location.href = UrlCreate;
        };
    </script>
    <script src="<%: Url.Content("~/Scripts/XJ/equiry.js") %>" ></script>
</asp:Content>
