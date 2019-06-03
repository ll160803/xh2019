/**
* Created by 1 on 2017/7/11.
*/

$(function () {
    detal();
    dataG();
    //MergeCells(Fdg,dat)
    var newHeight = parent.$('#tabs').tabs('getSelected').panel('options').height - 110;
    $("#Fdg2").datagrid('resize', {
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
function hospital() {
    window.location.href = UrlHospitaQuotedDetail + "/" + XJ_id;
}
function detal() {
    $.ajax({
        url: UrlGetDataID,
        type: "post",
        data: { id: XJ_id },
        success: function (response) {
            //if(response.Succeed==1){
            if (response.TXZ01 == null) {
                response.TXZ01 = "";
            }
            if (response.CODE == null) {
                response.CODE = "";
            }
            if (response.SPEC == null) {
                response.SPEC = "";
            }
            //var resdate = response.QUERY_DATE
            //timetostr(response.QUERY_DATE);
            var str = response.QUERY_DATE;

            var dtal = "<p style='line-height: 30px;min-width:940px;'>药品名称：" + response.TXZ01 + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;物料号：" + response.CODE + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;规格：" + response.SPEC + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;计量单位：" + response.MSEHT + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;采购数量：" + response.AMOUNT + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;询价时间：" + response.QUERY_DATES + "</p>";
            document.getElementById("Fdetal").innerHTML = dtal;
            //  }else{
            //     $.messager.alert("提示","表头请求错误","info");
            // }
        }, error: function () {
            $.messager.alert("提示", "表头服务错误", "info");
        }
    })
}
function timetostr(time) {
    var str = "";
    str = time.getFullYear() + "-" + time.getMonth() + "-" + time.getDate();
    return str;
}
function dataG() {
    $("#Fdg2").datagrid({
        url: UrlBazaarQuotedDetail,
        iconCls: 'icon-save',
        pagination: true,
        pageSize: 15,
        nowrap: false,
        pageList: [15, 30, 45, 60],
        fitColumn: false,
        sortName: "QUOTED_PRICE",
        sortOrder: "desc",
        queryParams: {
            id: XJ_id
        },
        rownumbers: true,
        columns: [
            [
                {
                    "field": "TXZ01", "title": "药品名称", width: 150
                },
                {
                    "field": "SPEC", "title": "规格", width: 120
                },
                {
                    "field": "PRODUCT_NAME", "title": "生产厂家", width: 150
                },
                {
                    "field": "GYSNAME", "title": "供应商", width: 150
                },
                {
                    "field": "QUOTED_PRICE_MSEHT", "title": "供货价格", width: 100
                },
                {
                    "field": "SUPPLY_AMOUNT_MSEHT", "title": "可供货数量", width: 100
                },
                {
                    "field": "COMMENTS", "title": "备注", width: 100
                }
            ]
        ], onLoadSuccess: function (data) {
            if (data.rows.length > 0) {
                mergeCellsByField("Fdg2", "TXZ01,SPEC");
            }
        }
    });
    //$("#Fdg2").datagrid('loadData',dat).datagrid("autoMergeCells",['TXZ01','SPEC']);

}
//合并表格的方法
function mergeCellsByField(tableID, colList) {
    var ColArray = colList.split(",");
    var tTable = $("#" + tableID);
    var TableRowCnts = tTable.datagrid("getRows").length;
    var tmpA;
    var tmpB;
    var PerTxt = "";
    var CurTxt = "";
    for (var j = ColArray.length - 1; j >= 0; j--) {
        PerTxt = "";
        tmpA = 1;
        tmpB = 0;
        for (var i = 0; i <= TableRowCnts; i++) {
            if (i == TableRowCnts) {
                CurTxt = "";
            } else {
                CurTxt = tTable.datagrid("getRows")[i][ColArray[j]];
            }
            if (PerTxt == CurTxt) {
                tmpA += 1;
            } else {
                tmpB += tmpA;
                tTable.datagrid("mergeCells", {
                    index: i - tmpA,
                    field: ColArray[j],
                    rowspan: tmpA,
                    colspan: null
                });
                tTable.datagrid("mergeCells", {
                    index: i - tmpA,
                    field: "Ideparture",
                    rowspan: tmpA,
                    colspan: null
                });
                tmpA = 1;
            }
            PerTxt = CurTxt;
        }
    }
}




