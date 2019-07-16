$.fn.jqGridTitleAndField = function () {
    var $grid = $(this);
    var columnNameList = $grid.jqGrid("getGridParam", "colModel");
    var arr = [];
    for (var i = 0; i < columnNameList.length; i++) {
        if (columnNameList[i].colmenu & !columnNameList[i].hidden) {
            arr.push({ Title: columnNameList[i].label, Field: columnNameList[i].name });
        }
    }
    return arr;
}

$.ExportExcel = function (gridId, url, postData) {//导出excel
    var $gridList = $("#" + gridId);
    var arr = $gridList.jqGridTitleAndField();
    var titleAndField = JSON.stringify(arr);
    var sidx = $gridList.jqGrid("getGridParam").postData.sidx;
    var sord = $gridList.jqGrid("getGridParam").postData.sord;
    if (postData == null || postData == undefined) {
        postData = {};
    }
    postData.titleAndField = JSON.stringify(arr);
    postData.sidx = $gridList.jqGrid("getGridParam").postData.sidx;
    postData.sord = $gridList.jqGrid("getGridParam").postData.sord;
    $.submitForm({
        url: url,
        param: postData,
        success: function (data) {
            location.href = data.data;
        },
        close: false
    })
}

