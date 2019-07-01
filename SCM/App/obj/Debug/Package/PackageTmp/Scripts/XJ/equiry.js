/**
* Created by 1 on 2017/7/10.
*/
function hands(id) { return "<a href='#'  style='margin-right: 10px;' onclick='Dialogs(\"" + id + "\")'>撤销结束</a>" + "<a  onclick='gover(\"" + id + "\")' href='#'>结束</a>"; }
function detal(id) { return "<a  style='margin-right: 10px;' onclick='detail(\"" + id + "\")' href='#'>查看</a>"; }
function hands0(id) { return "<a style='margin-right: 33px;'  href='#' onclick='XGgride(\"" + id + "\")' class='m1'>修改</a>" + "<a href='#' onclick='dell(\"" + id + "\")' class='m2'>删除</a>"; }
$(function () {
    $("#hid").window({
        title: '请重新选择时间', width: 330, top: 20,
        modal: true, collapsible: false, minimizable: false, maximizable: false, closed: true
    });
    biao();
    FormCX();

    document.onkeydown = function (event) {
        e = event ? event : (window.event ? window.event : null);
        if (e.keyCode == 13) {
            //执行的方法   
            FormCX();
            return false;
        }
    }

    var newHeight = parent.$('#tabs').tabs('getSelected').panel('options').height - 130;
    $("#dg").datagrid('resize', {
        height: newHeight
    });
});
function sort(obj, sortName, sortOrder) {
    var queryParams = $('#' + obj).datagrid('options').queryParams;
    queryParams.sortName = sortName;
    queryParams.sortOrder = sortOrder;
    $('#' + obj).datagrid('reload');
}
function biao() {
    $("#dg").datagrid({
        pagination: true,
        pageSize: 10,
        pageList: [10, 20, 30, 40],
        striped: true,
        checkOnSelect: false,
        selectOnCheck: true,
        rownumbers: true,
        queryParams: {
            sortName: 'QUERY_DATE',
            sortOrder: 'asc'
        },
        remoteSort: false,
        fit: true,
        columns: [[
            {
                field: 'box',
                checkbox: true
            },
            {
                field: 'CODE',
                title: '询价单号',
                width: 100,
                sortable: true
            },
            {
                field: 'TXZ01',
                title: '药品名称',
                width: 150,
                sortable: true
            },
            {
                field: 'SPEC',
                title: '药品规格',
                width: 90,
                sortable: true
            },
            {
                field: 'MSEHT',
                title: '计量单位',
                width: 70,
                sortable: true
            },
            {
                field: 'AMOUNT',
                title: '采购数量',
                width: 70,
                sortable: true
            },
            {
                field: 'ALLCOUNT',
                title: '询价供应商数量',
                width: 90
            },
            {
                field: 'ACTCOUNT',
                title: '已报数量',
                width: 70,
                sortable: true
            },
            {
                field: 'QUERY_DATES',

                title: '询价时间',
                width: 80,
                sortable: true
            },
            {
                field: 'END_DATES',
                title: '截止时间',
                width: 80,
                sortable: true
            },
            {
                field: 'QUERY_STATE_NAME',
                title: '询价状态',
                width: 70,
                sortable: true
            },
            {
                field: 'detail',
                title: '询价详情',
                formatter: function (value, row) {
                    if ($.trim(row.QUERY_STATE) == "SCM000102" || $.trim(row.QUERY_STATE) == "SCM000103") {
                        // return detal(row.ID);
                        return "<a  style='margin-right: 10px;' onclick='detail(\"" + row.ID + "\")' href='#'  class='kan1'>查看</a>";
                    } else {
                        return "<a  style='margin-right: 10px;color:grey;' onclick='javascript:void(0)'  class='kan2'>查看</a>";
                    }
                },
                width: 60,
                sortable: true
            },
            {
                field: 'hands',
                title: '操作',
                width: 100,
                formatter: function (value, row) {
                    if ($.trim(row.QUERY_STATE) == "SCM000102" || $.trim(row.QUERY_STATE) == "SCM000103") {
                        // return hands(row.ID);
                        if ($.trim(row.QUERY_STATE) == "SCM000102") {
                            return "<a   style='margin-right: 10px;color:grey;' onclick='javascript:void(0)' class='over1'>撤销结束</a>" + "<a  onclick='gover(\"" + row.ID + "\")' href='#' class='over2'>结束</a>";
                        } else {
                            return "<a href='#'  style='margin-right: 10px;' onclick='Dialogs(\"" + row.ID + "\")' class='over3'>撤销结束</a>" + "<a  onclick='javascript:void(0)'  style='color:grey;' class='over4'>结束</a>";
                        }
                    } else {
                        if ($.trim(row.QUERY_STATE) == "SCM000101") {
                            return hands0(row.ID);
                        }
                    }
                }
            }

        ]]
    });
    //gdata=newData;
    //$("#dg").datagrid('loadData',newData);
    var p = $('#dg').datagrid('getPager');
    $(p).pagination({
        pageSize: 10, //每页显示的记录条数，默认为10
        pageList: [10, 20, 30], //可以设置每页记录条数的列表
        beforePageText: '第', //页数文本框前显示的汉字
        afterPageText: '页    共 {pages} 页',
        displayMsg: '当前显示 {from} - {to} 条记录   共 {total} 条记录',
        onSelectPage: function (pageNumber, pageSize) {//点击下一页事件
            //console.log('pageNumber:' + pageNumber + ',pageSize:' + pageSize);
            var data = serializeForm('CXform');
            data.page = pageNumber;
            data.rows = pageSize;
            $.post(UrlGetDataList, data, function (data) {
                $('#dg').datagrid('loadData', data);
            });
        }
    });
}
//撤销结束,type=1
function batchcancel() {
    var rows = $('#dg').datagrid('getSelections');
    if (rows.length == 0) {
        $.messager.alert('操作提示', '请选择数据!', 'warning');
        return false;
    }
    var arr = [];
    for (var i = 0; i < rows.length; i++) {
        if ($.trim(rows[i].QUERY_STATE) == "SCM000103") {
            arr.push(rows[i].ID);
        }
    }
    Dialogs(arr.join(","));
}
function Dialogs(id) {
    $("#hid").window('open');
    $("#hid").window('center');
    $("#hidden").val(id);
    //console.log(id);
    var getrows = $('#dg').datagrid('getRows');
    // console.log(JSON.stringify(getrows));
    var d = new Date();
    for (var i = 0; i < getrows.length; i++) {
        if (getrows[i].ID == id) {
            var date = new Date();
            var y = date.getFullYear();
            var m = date.getMonth() + 1;
            var d = date.getDate();
            var Xtime = y + "-" + m + "-" + d;
            var Ntime = new Date(Xtime.replace(/-/g, "\/"));
            var y = getrows[i].END_DATES
            var yt = new Date(y.replace(/-/g, "\/"));
            if (yt < Ntime) {
                $("#modalTime").datebox("setValue", "");
            } else {
                $("#modalTime").datebox("setValue", getrows[i].END_DATES);
            }
        }
    }
}
function chexiao() {
    var modeltime = $("#modalTime").datebox('getValue');
    var date = new Date();
    var y = date.getFullYear();
    var m = date.getMonth() + 1;
    var d = date.getDate();
    var Xtime = y + "-" + m + "-" + d;
    if (modeltime == "") {
        $.messager.alert('操作提示', '请填写时间!', 'warning');
        return false;
    }
    else {
        var Ntime = new Date(Xtime.replace(/-/g, "\/"));
        var Ftime = new Date(modeltime.replace(/-/g, "\/"));
        if (Ftime < Ntime) {
            $.messager.alert('操作提示', '时间不能小于今天!', 'warning');
            return false;
        }
        else {
            var id = $("#hidden").val();
            var hh = { date: modeltime, type: 1, ids: id };
            //alert(JSON.stringify(hh));
            $.ajax({
                url: UrlUpdateType,
                type: "post",
                dataType: "JSON",
                data: { date: modeltime, type: 1, ids: id },
                success: function (response) {
                    if (response.Success) {
                        FormCX();
                    } else {
                        alert(response.Message);
                    }

                },
                error: function () {
                    //alert(JSON.stringify(Rowws(dg,1)));
                    alert("撤销错误");
                }
            });
            $("#hid").window('close');

        }
    }
}
function CClose() {
    $("#hid").window('close');
}

//结束,type=2
function gover(id) {
    var modeltime = $("#modalTime").datebox('getValue');
    $.messager.confirm('操作提示', "确认结束吗？", function (r) {
        if (r) {
            $.ajax({
                url: UrlUpdateType,
                type: "post",
                dataType: "JSON",
                data: { date: "", type: 2, ids: id },
                success: function (response) {
                    if (response.Success == 1) {
                        FormCX();
                    } else {
                        alert(response.Message);
                    }
                },
                error: function () {
                    alert("结束错误");
                }
            });
        }
    });
}
//批量结束
function tanchuang() {
    // $("#over").window('open');
    // $("#over").window('center');
    var rows = $('#dg').datagrid('getSelections');
    if (rows.length == 0) {
        $.messager.alert('操作提示', '请选择数据!', 'warning');
        return false;
    } else {
        var arr = [];
        for (var i = 0; i < rows.length; i++) {
            if ($.trim(rows[i].QUERY_STATE) == "SCM000102") {
                arr.push(rows[i].ID);
            }
        }
        gover(arr.join(","));
    }


}
function overS() {
    $.ajax({
        url: UrlUpdateType,
        type: "post",
        dataType: "JSON",
        data: Rowws(dg, 2),
        success: function (response) {
            if (response.Success == 1) {
                FormCX();
            } else {
                alert(response.Message);
            }
        },
        error: function () {
            alert("结束错误");
        }
    });
    $("#over").window('close');
}
function overC() {
    $("#over").window("close");
}
//获取easyui表格的多行一些数据
function Rowws(gid, type) {
    /// var modeltime = $("#modalTime").datebox('getValue');
    var ids = [];
    var rows = $(gid).datagrid('getSelections');
    for (var i = 0; i < rows.length; i++) {
        var id = rows[i].ID;
        ids.push(id);
    }
    var idt = ids.join(",");
    /// var row = { date: modeltime, type: type, ids: idt };
    //var gdat=idt;
    return idt;
}
//撤销结束弹出层提交时间
function SSubmit() {
    // var modeltime=$("#modalTime").datebox('getValue');//获取easyui的时间值string
    $.ajax({
        url: UrlUpdateType,
        type: "post",
        dataType: "JSON",
        data: Rowws(dg, 1),
        success: function (response) {
            if (response.Success == 1) {
                FormCX();
            } else {
                alert(response.Message);
            }

        },
        error: function () {
            //alert(JSON.stringify(Rowws(dg,1)));
            alert("撤销错误");
        }
    });
    $("#hid").window('close');
}
//删除
function dell(id) {
    $.messager.confirm('操作提示', "确认删除吗？", function (r) {
        if (r) {
            $.ajax({
                url: UrlDelete,
                type: "post",
                dataType: "JSON",
                data: { ids: id },
                success: function (response) {
                    if (response.Success == 1) {
                        FormCX();
                    } else {
                        alert(response.Message);
                    }

                },
                error: function () {
                    alert("删除错误");
                }
            });
        }
    });
    // return id;
}
function dellS() {
    // var ids = [];
    // var rows = $("#dg").datagrid('getSelections');
    // for (var i = 0; i < rows.length; i++) {
    //    var id = rows[i].ID;
    //    ids.push(id);
    // }
    // var idt = ids.join(",");
    var id = dell(id);
    var dat = { ids: id };
    $.ajax({
        url: UrlDelete,
        type: "post",
        dataType: "JSON",
        data: dat,
        success: function (response) {
            if (response.Success == 1) {
                FormCX();
            } else {
                alert(response.Message);
            }
        },
        error: function () {
            alert("删除错误");
        }
    });
}
function dellC() {
    $("#dell").window("close");
}
//修改
function XGgride(id) {
    window.location.href = UrlCreate + "/" + id; //跳转到新增页面
}
//详情
function detail(id) {
    window.location.href = UrlQuotedDetailList + "/" + id; //跳转到详情页面
}
//新增
function XZgride() {
    window.location.href = UrlCreate; //点击新增按钮跳转到新增页面
}
//查询表单提交
function serializeForm(formId) {
    var options = $('#dg').datagrid('options');
    var pageNumber = options.pageNumber;
    var pageSize = options.pageSize;
    var queryParams = $("#dg").datagrid('options').queryParams;
    var sortName = queryParams.sortName;
    var sortOrder = queryParams.sortOrder;
    var fdata = {
        TXZ01: $.trim($('input[name="TXZ01"]').val()),
        SPEC: $.trim($('input[name="SPEC"]').val()),
        QUERY_STATE: $.trim($("#QUERY_STATE").combobox('getValue')),
        BEGIN_QUERY_DATE: $.trim($('input[name="BEGIN_QUERY_DATE"]').val()),
        END_QUERY_DATE: $.trim($('input[name="END_QUERY_DATE"]').val()),
        BEGIN_END_DATE: $.trim($('input[name="BEGIN_END_DATE"]').val()),
        END_END_DATE: $.trim($('input[name="END_END_DATE"]').val()),
        page: pageNumber,
        rows: pageSize,
        sort: sortName,
        order: sortOrder
    };
    var XtimeStart = new Date(fdata.BEGIN_QUERY_DATE.replace(/-/g, "\/"));
    var XtimeEnd = new Date(fdata.END_QUERY_DATE.replace(/-/g, "\/"));
    var JtimeStart = new Date(fdata.BEGIN_END_DATE.replace(/-/g, "\/"));
    var JtimeEnd = new Date(fdata.END_END_DATE.replace(/-/g, "\/"));
    if (XtimeStart > XtimeEnd) {
        $.messager.alert("提示", "询价时间的截止时间小于开始时间！", "info");
        return false;
    }
    if (JtimeStart > JtimeEnd) {
        $.messager.alert("提示", "询价时间的截止时间小于开始时间！", "info");
        return false;
    } else {
        return fdata;
    }

}
//查询
function FormCX() {
    $.ajax({
        url: UrlGetDataList,
        type: "post",
        dataType: "JSON",
        data: serializeForm('CXform'),
        success: function (data) {
            $("#dg").datagrid('loadData', data);
        },
        error: function () {
            $.messager.alert("提示", "错误", "info");
        }
    })
}
//点击查看详情
function detaill() {
    var rows = $("#dg").datagrid('getSelections');
    var id = rows.ID;
    var options = $('#dg').datagrid('options');
    var pageNumber = options.pageNumber;
    var pageSize = options.pageSize;
    var queryParams = $("#dg").datagrid('options').queryParams;
    var sortName = queryParams.sortName;
    var sortOrder = queryParams.sortOrder;
    $.ajax({
        url: "",
        type: "",
        data: "",
        dataType: "",
        success: function () {

        }, error: function () {

        }
    })

}
//时间转换
function myformatter(date) {
    var y = date.getFullYear();
    var m = date.getMonth() + 1;
    var d = date.getDate();
    return y + '-' + (m < 10 ? ('0' + m) : m) + '-' + (d < 10 ? ('0' + d) : d);
}
function myparser(s) {
    if (!s) return new Date();
    var ss = (s.split('-'));
    var y = parseInt(ss[0], 10);
    var m = parseInt(ss[1], 10);
    var d = parseInt(ss[2], 10);
    if (!isNaN(y) && !isNaN(m) && !isNaN(d)) {
        return new Date(y, m - 1, d);
    } else {
        return new Date();
    }
}





