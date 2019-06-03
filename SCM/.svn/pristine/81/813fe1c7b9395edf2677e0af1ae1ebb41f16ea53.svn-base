<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Common.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    QuotedDetailList
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<style>
form{
min-width:940px;
}
</style>

<div id="factory">
        <div id="Ftop">
            <p>
                <strong><a href="javascript:void(0);" style="border-right: 1px solid #aaaaaa;"><strong>报价详情</strong></a></strong>
                <a href="#" style="border-right: 1px solid #aaaaaa;" onclick="price()">市场价格表</a>
                <a href="#" id="linkhospital" onclick="hospital()">各医院价格表</a>
                <a href="#" id="linkpriceadjust" style="display:none" onclick="priceadjust()">供应商价格调整</a>
                <button onclick="DaoChu2()">导出</button>
                <button onclick="fanhui()">返回</button>
            </p>
        </div>
        <div id="Fdetal">

        </div>
        <div id="Fdatag">
            <!--<div id="Fdatag1">-->
                <form>
                    <label for="GYSNAME">供应商名称：</label>
                    <input type="text" name="GYSNAME" id="Fname"/>
                    <label for="PRODUCT_NAME">&nbsp;&nbsp;&nbsp;&nbsp;厂家名称：</label>
                    <input type="text" name="PRODUCT_NAME" id="Dname"/>
                    <label for="HOSPITAL_NAME">&nbsp;&nbsp;&nbsp;&nbsp;医院名称：</label>
                    <input type="text" name="HOSPITAL_NAME" id="Hname"/>&nbsp;&nbsp;&nbsp;&nbsp;
                    <button onclick="Search(Fdg)" type="button">查询</button>
                </form>
            <!--</div>-->
            <div id="Fdatag2">
                <table class="easyui-datagrid" id="Fdg" style="height:320px;">

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
    //导出接口
     var UrlExportQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/ExportQuotedDetail") %>";
     //获取报价详情接口
     var UrlGetQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetQuotedDetail") %>";
     //获取传入询价信息接口
     var UrlGetDataID = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/GetDataID") %>";
     //各医院报价跳转
     var UrlHospitaQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/HospitaQuotedDetail") %>";
     //市场报价跳转
     var UrlBazaarQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/BazaarQuotedDetail") %>";
     //回到询价信息跳转
     var UrlIndex = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/Index") %>";
     var fileurl="<%: Url.Content("~/System/MDM/DownFile")%>";
     var XJ_id="<%=ViewBag.ID %>";
     var adjust_id = "<%=ViewBag.ADJUSTPRICE_ID %>";
     
     //导出
function DaoChu2(){
    $.post(UrlExportQuotedDetail,
    {
        id: XJ_id,
        GYSNAME: $.trim($("Fname").val()),
        PRODUCT_NAME: $.trim($("Dname").val()),
        HOSPITAL_NAME: $.trim($("Hname").val())

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
<script src="<%: Url.Content("~/Scripts/XJ/factory.js") %>" ></script>
</asp:Content>
