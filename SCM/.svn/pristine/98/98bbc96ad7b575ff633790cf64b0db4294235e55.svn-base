/**
* Created by 1 on 2017/7/11.
*/
//var XQ_id;
$(function () {
    detal();
    dataG();
    document.onkeydown = function (event) {
        e = event ? event : (window.event ? window.event : null);
        if (e.keyCode == 13) {
            //执行的方法   
            Search("#Fdg");
            return false;
        }
    }
    var newHeight = parent.$('#tabs').tabs('getSelected').panel('options').height - 140;
    $("#Fdg").datagrid('resize', {
        height: newHeight
    });
});
function fanhui() {
    window.location.href = UrlIndex;
}
function price() {
    window.location.href = UrlBazaarQuotedDetail + "/" + XJ_id;
}
function hospital() {
    window.location.href = UrlHospitaQuotedDetail + "/" + XJ_id;
}
//详情表头信息
function detal() {
    $.ajax({
        url: UrlGetDataID,
        type: "post",
        data: { id: XJ_id },
        success: function (response) {
            if (response.TXZ01 == null) {
                response.TXZ01 = "";
            }
            if (response.CODE == null) {
                response.CODE = "";
            }
            if (response.SPEC == null) {
                response.SPEC = "";
            }

            // if(response.Succeed==1){
            var dtal = "<p style='line-height: 30px;min-width:940px;width:100%;'>药品名称：" + response.TXZ01 + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;物料号：" + response.CODE + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;规格：" + response.SPEC + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;计量单位：" + response.MSEHT + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;采购数量：" + response.AMOUNT + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;询价时间：" + response.QUERY_DATES + "</p>";
            document.getElementById("Fdetal").innerHTML = dtal;
            // console.log(response.QUERY_DATE);
            // }
        }, error: function () {
            $.messager.alert("提示", "表头服务错误", "info");
        }
    })
}
function dataG() {
    $("#Fdg").datagrid({
        url: UrlGetQuotedDetail,
        iconCls: 'icon-save',
        pagination: true,
        pageSize: 15,
        nowrap: false,
        pageList: [15, 30, 45, 60],
        fitColumn: false,
        sortName: 'ID',
        sortOrder: 'desc',
        rownumbers: true,
        queryParams: {
            id: XJ_id,
            GYSNAME: $.trim($("Fname").val()),
            PRODUCT_NAME: $.trim($("Dname").val()),
            HOSPITAL_NAME: $.trim($("Hname").val())
        },
        columns: [
            [
                {
                    "field": "GYSNAME", "title": "供应商名称", width: 150
                },
                {
                    "field": "GYSACCOUNT", "title": "供应商账号", width: 100
                },
                {
                    "field": "CREATE_TIMES", "title": "报价时间",
                    width: 100
                },
                {
                    "field": "PRODUCT_NAME", "title": "供货厂家", width: 150
                },
                {
                    "field": "QUOTED_PRICE_MSEHT", "title": "报价价格", width: 100
                },
                {
                    "field": "SUPPLY_AMOUNT_MSEHT", "title": "可供货数量", width: 100
                },
                {
                    "field": "HOSPITAL_NAME", "title": "报价医院", width: 150
                },
                {
                    "field": "PRICE_MSEHT", "title": "报价医院价格", width: 100
                },
                {
                  field: 'COM_FILE_ID_S_NAME',
                  title: '发票附件',
                  width: 80,
                   formatter: function(value, rec) {
                       if (value != null) {
                           return "<a target='_blank' href='" + fileurl + "?CLIENT_NAME=" + rec.COM_FILE_ID_NAME + "&SERVER_NAME=" + value + "' class='editcls'  ></a>";
                      }
                   }
                }
            ]
        ],
        onLoadSuccess: function (data) {
        WC_Common.Format.IconButton('.editcls', 'icon-search');
            if (data.rows.length > 0) {
                mergeCellsByField("Fdg", "GYSNAME,GYSACCOUNT");
            }
        }
    });
}

//查询
function Search(gid) {
    $(gid).datagrid('load', {
        GYSNAME: $('#Fname').val(),
        PRODUCT_NAME: $('#Dname').val(),
        HOSPITAL_NAME: $('#Hname').val(),
        ID: XJ_id
    });
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