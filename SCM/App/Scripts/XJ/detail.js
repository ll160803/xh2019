/**
* Created by 1 on 2017/7/11.
*/

$(function () {
    detal();
    dataG();
    var newHeight = parent.$('#tabs').tabs('getSelected').panel('options').height - 110;
    $("#Fdg1").datagrid('resize', {
        height: newHeight
    });

});
//返回
function fanhui() {
    window.location.href = UrlIndex;
}
function deln() {
    window.location.href = UrlQuotedDetailList + "/" + XJ_id;
}

function price() {
    console.log(UrlBazaarQuotedDetail);
    window.location.href = UrlBazaarQuotedDetail + "/" + XJ_id;
}
function detal() {
    $.ajax({
        url: UrlGetDataID,
        type: "post",
        data: { id: XJ_id },
        success: function (response) {
            // if(response.Succeed==1){
            if (response.TXZ01 == null) {
                response.TXZ01 = "";
            }
            if (response.CODE == null) {
                response.CODE = "";
            }
            if (response.SPEC == null) {
                response.SPEC = "";
            }
            var dtal = "<p style='line-height: 30px;min-width:940px;'>药品名称：" + response.TXZ01 + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;物料号：" + response.CODE + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;规格：" + response.SPEC + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;计量单位：" + response.MSEHT + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;采购数量：" + response.AMOUNT + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;询价时间：" + response.QUERY_DATES + "</p>";
            document.getElementById("Fdetal").innerHTML = dtal;
            //   }else{
            //        $.messager.alert("提示","详情表头请求错误","info");
            //     }
        }, error: function () {
            $.messager.alert("提示", "详情表头服务器错误", "info");
        }
    })
}
function dataG() {
    $("#Fdg1").datagrid({
        url: UrlHospitaQuotedDetail,
        iconCls: 'icon-save',
        pagination: true,
        nowrap: false,
        pageSize: 15,
        pageList: [15, 30, 45, 60],
        fitColumn: false,
        sortName: "PRICE",
        sortOrder: "desc",
        queryParams: {
            id: XJ_id
        },
        rownumbers: true,
        columns: [
            [
                {
                    "field": "HOSPITAL_NAME", "title": "医院", width: 200
                },
                {
                    "field": "PRODUCT_NAME", "title": "药品生产厂家", width: 200
                },
                {
                    "field": "PRICE_MSEHT", "title": "进货价格", width: 120
                },
                {
                    "field": "COMMENTS_D", "title": "备注", width: 300
                }
            ]
        ]
    });
}
//导出



