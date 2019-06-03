<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Common.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    BazaarQuotedDetail
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<div id="factory">
    <div id="Ftop">
        <p>
            <a href="#" style="border-right: 1px solid #aaaaaa;" onclick="deln()">报价详情</a> 
            <strong><a href="javascript:void(0);" style="border-right: 1px solid #aaaaaa;">市场价格表</a></strong>
            <a href="#" id="linkhospital" onclick="hospital()">各医院价格表</a>
            <a href="#" id="linkpriceadjust" style="display:none" onclick="priceadjust()">供应商价格调整</a>
            <button onclick="DaoChu2()">导出</button>
            <a href="#"><button onclick="fanhui()">返回</button></a>
        </p>
    </div>

    <div id="Fdetal">

    </div>
    <div id="Fdatag">
        <!--<div id="Fdatag1">-->
            <!--<form>-->
                <!--<label for="Fname">供应商名称：</label>-->
                <!--<input type="text" name="Fname"/>-->
                <!--<label for="Dname">&nbsp;&nbsp;&nbsp;&nbsp;供应商名称：</label>-->
                <!--<input type="text" name="Dname"/>-->
                <!--<label for="Hname">&nbsp;&nbsp;&nbsp;&nbsp;供应商名称：</label>-->
                <!--<input type="text" name="Hname"/>&nbsp;&nbsp;&nbsp;&nbsp;-->
                <!--<button type="submit">查询</button>-->
            <!--</form>-->
        <!--</div>-->
        <div id="Fdatag2">
            <table class="easyui-datagrid" id="Fdg2" style="height:380px;">
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
<script src="<%: Url.Content("~/Scripts/XJ/price.js") %>" ></script>
<script>
    //获取市场价格数据接口
     var UrlBazaarQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetBazaarQuotedDetail") %>";
     //导出接口
     var UrlExportBazaarQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/ExportBazaarQuotedDetail") %>";
     //获取传入询价信息接口
     var UrlGetDataID = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetDataID") %>";
     var XJ_id="<%=ViewBag.ID %>";
     var adjust_id = "<%=ViewBag.ADJUSTPRICE_ID %>";
     //报价详情跳转
     var UrlQuotedDetailList = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/QuotedDetailList") %>";
     //各医院价格跳转
     var UrlHospitaQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/HospitaQuotedDetail") %>";
     //回到询价信息跳转
     var UrlIndex = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/Index") %>";
     //导出
function DaoChu2(){
    $.post(UrlExportBazaarQuotedDetail, {
        id: XJ_id,
        sort: "QUOTED_PRICE",
        order: "desc"
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
</asp:Content>
