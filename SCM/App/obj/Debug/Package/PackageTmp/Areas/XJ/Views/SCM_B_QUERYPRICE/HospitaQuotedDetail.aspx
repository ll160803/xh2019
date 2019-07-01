<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Common.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    HospitaQuotedDetail
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="factory">
        <div id="Ftop">
            <!--<div id="Ftop1"><div style="border-right: 1px solid #aaaaaa;"><a href="factory.html">报价详情</a></div>-->
            <!--<div style="border-right: 1px solid #aaaaaa;"><a href="price.html">市场价格表</a></div>-->
            <!--<div><strong><a href="detail.html">各医院价格表</a></strong></div>-->
            <!--</div>-->
            <!--<div id="Ftop2">-->
            <!--<button onclick="DaoChu1()">导出</button>-->
            <!--<button>返回</button>-->
            <!--</div>-->
            <p>
                <a href="#" style="border-right: 1px solid #aaaaaa;" onclick="deln()">报价详情</a> 
                <a href="#" style="border-right: 1px solid #aaaaaa;" onclick="price()">市场价格表</a>
                <strong><a href="javascript:void(0);" id="linkhospital">各医院价格表</a></strong>
                <a href="#" id="linkpriceadjust" style="display:none" onclick="priceadjust()">供应商价格调整</a>
                <button onclick="DaoChu2()">
                    导出</button>
                <a href="#">
                    <button onclick="fanhui()">
                        返回</button></a>
            </p>
        </div>
        <div id="Fdetal">
        </div>
        <div id="Fdatag">
            <div id="Fdatag1">
                <!--<form>-->
                <!--<label for="Fname">供应商名称：</label>-->
                <!--<input type="text" name="Fname"/>-->
                <!--<label for="Dname">&nbsp;&nbsp;&nbsp;&nbsp;供应商名称：</label>-->
                <!--<input type="text" name="Dname"/>-->
                <!--<label for="Hname">&nbsp;&nbsp;&nbsp;&nbsp;供应商名称：</label>-->
                <!--<input type="text" name="Hname"/>&nbsp;&nbsp;&nbsp;&nbsp;-->
                <!--<button type="submit">查询</button>-->
                <!--</form>-->
            </div>
            <div id="Fdatag2">
                <table class="easyui-datagrid" id="Fdg1" style="height: 380px;">
                </table>
            </div>
        </div>
    </div>
    <script>
        if (adjust_id != "") {
            $("#linkpriceadjust").show();
            $("#linkhospital").css("border-right", "1px solid #aaaaaa");
        }
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" type="text/css" href="<%: Url.Content("~/Scripts/XJ/factory.css") %>">
    <script>
    //获取各医院价格数据接口
     var UrlHospitaQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetHospitaQuotedDetail") %>";
     //导出接口
     var UrlExportHospitaQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/ExportHospitaQuotedDetail") %>";
     //获取传入询价信息接口
     var UrlGetDataID = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetDataID") %>";
     var XJ_id="<%=ViewBag.ID %>";
     var adjust_id = "<%=ViewBag.ADJUSTPRICE_ID %>";
     //报价详情跳转
     var UrlQuotedDetailList = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/QuotedDetailList") %>";
     //市场价格表跳转
     var UrlBazaarQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/BazaarQuotedDetail") %>";

     //回到询价信息跳转
     var UrlIndex = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/Index") %>";
     function DaoChu2(){
        $.post(UrlExportHospitaQuotedDetail, {
            id: XJ_id,
            sort:"PRICE",
            order:"desc"
        }, function (res) {
            window.location.href = res;
        });  
    }
    //供应商价格调整
     var UrlPriceAdjustDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/PriceAdjustDetail") %>";
     
     function priceadjust() {
        window.location.href = UrlPriceAdjustDetail + "/" + XJ_id;
    }
    </script>
    <script src="<%: Url.Content("~/Scripts/XJ/detail.js") %>"></script>
</asp:Content>
