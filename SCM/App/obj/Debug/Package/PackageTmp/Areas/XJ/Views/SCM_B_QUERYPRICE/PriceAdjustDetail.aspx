<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Common.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    PriceAdjustDetail
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
                <a href="#" style="border-right: 1px solid #aaaaaa;" onclick="deln()">报价详情</a> 
                <a href="#" style="border-right: 1px solid #aaaaaa;" onclick="price()">市场价格表</a>
                <a href="#" style="border-right: 1px solid #aaaaaa;" onclick="hospital()">各医院价格表</a>
                <strong><a href="javascript:void(0);" >供应商价格调整</a></strong>
                <button onclick="fanhui()">返回</button>
            </p>
        </div>
        <div id="Fdetal">
            <div style="background-color:#F1F1F1; padding: 2px 10px 5px 10px;font-size: 14px;margin: 10px auto">
                <label id="lab_TXZ01" style="margin-right: 20px;line-height: 25px"></label>
                <label id="lab_MATNR" style="margin-right: 20px;line-height: 25px"></label>
                <label id="lab_SPEC" style="margin-right: 20px;line-height: 25px"></label>
                <label id="lab_MSEHT" style="margin-right: 20px;line-height: 25px"></label>
                <label id="lab_OLD_PRICE" style="margin-right: 20px;line-height: 25px"></label></br>
                <label id="lab_ADJUST_PRICE" style="margin-right: 20px;line-height: 25px"></label>
                <label id="lab_GYSNAME" style="margin-right: 20px;line-height: 25px"></label>
                <label id="lab_GYSACCOUNT" style="margin-right: 20px;line-height: 25px"></label></br>
                <label id="lab_COMMENTS" style="line-height: 25px"></label>
            </div>
            <table id="grid_FileInfo">
            </table>
        </div>
        <div id="Fdatag">
            
        </div>
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
<link rel="stylesheet" type="text/css" href="<%: Url.Content("~/Scripts/XJ/factory.css") %>">
<script>
    var adjust_id = "<%=ViewBag.ADJUSTPRICE_ID %>";
    var XJ_id="<%=ViewBag.ID %>";
    var UrlPriceAdjustQuery="<%:Url.Content("~/XJ/SCM_B_PRICEADJUST/QueryPriceAdjust")%>";
    var UrlPriceAdjustFile="<%:Url.Content("~/system/COM_FILE/GetData/")%>";
    
    //回到询价信息跳转
     var UrlIndex = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/Index") %>";
    //报价详情跳转
     var UrlQuotedDetailList = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/QuotedDetailList") %>";
     //各医院价格跳转
     var UrlHospitaQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/HospitaQuotedDetail") %>";
     //市场价格表跳转
     var UrlBazaarQuotedDetail = "<%: Url.Content("~/XJ/SCM_B_QUERYPRICE/BazaarQuotedDetail") %>";

    function deln() {
    window.location.href = UrlQuotedDetailList + "/" + XJ_id;
    }
    function hospital() {
        window.location.href = UrlHospitaQuotedDetail + "/" + XJ_id;
    }
    function fanhui() {
        window.location.href = UrlIndex;
    }
    function price() {
        window.location.href = UrlBazaarQuotedDetail + "/" + XJ_id;
    }

    $(function () {
        $.ajax({
            url: UrlPriceAdjustQuery,
            data: {
                "id": adjust_id
            },
            type: "post",
            dataType: "JSON",
            success: function (data) {
                if(data != null && data != undefined)
                {
                    $("#lab_TXZ01").html("药品名称：" + data.TXZ01);
                    $("#lab_MATNR").html("物料号：" + data.MATNR);
                    if(data.SPEC!=null && data.SPEC != undefined)
                    {
                        $("#lab_SPEC").html("规格：" + data.SPEC);
                    }else{
                        $("#lab_SPEC").html("规格：");
                    }
                    
                    if(data.MSEHT!=null && data.MSEHT != undefined)
                    {
                        $("#lab_MSEHT").html("计量单位：" + data.MSEHT);
                    }else{
                        $("#lab_MSEHT").html("计量单位：");
                    }
                    $("#lab_OLD_PRICE").html("供货价格：" + data.OLD_PRICE);
                    $("#lab_ADJUST_PRICE").html("调整价格：" + data.ADJUST_PRICE);
                    $("#lab_GYSNAME").html("供应商名称：" + data.GYSNAME);
                    $("#lab_GYSACCOUNT").html("供应商账户：" + data.GYSACCOUNT);
                    $("#lab_COMMENTS").html("调整原因：" + data.COMMENTS);
                }
            }, error: function () {
                $.messager.alert("提示", "获取数据失败", "info")
            }
        });

        $('#grid_FileInfo').datagrid({
            url: UrlPriceAdjustFile + adjust_id,
            singleSelect: true,
            sortName: 'ID',
            sortOrder: 'desc',
            height:350,
            idField: 'ID',
            pagination: true,
            rownumbers: true,
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
                 return "<a id='a_delete' class='examinecls' title='查看附件' href='#' onclick='DownFile(\"" + rowData.SERVER_NAME + "\")'></a>";

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
    ///查看附件
        function DownFile(id) {
            window.open("<%:Url.Content("~/UploadFile/BaseInfo/")%>" + id, '_blank');
        }
</script>
</asp:Content>
