var editRow = undefined;
$(function () {
    $("#Afactory").window({
        title: '药品添加', width: 830, top: 20, height: 350,
        modal: true, collapsible: false, minimizable: false, maximizable: false, closed: true
    });
    $("#Bfactory").window({
        title: '供应商添加', width: 830, top: 20, height: 350,
        modal: true, collapsible: false, minimizable: false, maximizable: false, closed: true
    });
    $('#modalName').bind('keypress', function (event) {
        if (event.keyCode == "13") {
            doSearch("#dd", "#modalName");
            return false;
        }
    });
    $('#Sou').bind('keypress', function (event) {
        if (event.keyCode == "13") {
            doSearch("#gg", "#Sou");
            return false;
        }
    });

    $("#Adg").datagrid({
        sortName: 'ID', //询价时间排序
        sortOrder: 'desc',
        striped: true,
        rownumbers: true,
        //toolbar: '#add_top',
        columns: [
            [
                { field: 'box', width: 100, checkbox: true },
                { field: 'TXZ01', title: '药品名称', width: 200 },
                { field: 'SPEC', title: '药品规格', width: 100 },
                { field: 'MSEHT', title: '计量单位', width: 80 },
                { field: 'AMOUNT', title: '采购数量*', width: 80, editor: 'text' },
                { field: 'PRODUCT_NAME', title: '指定厂家（选填）', width: 200, editor: 'text' },
                { field: 'QUERY_DATES',
                    title: '询价时间', width: 100
                },
                { field: 'END_DATES', editor: { type: 'datebox' },
                    title: '截止时间', width: 100
                },
                { field: 'ck',
                    title: '价格调整', width: 80,
                    formatter: function (value, row) {
                        //console.log(row)
                        if ($.trim(row.ADJUSTPRICE_ID) != "") {
                            return "<a class='examinecls' href='#' onclick=diaOpen('" + row.ADJUSTPRICE_ID + "')> </a>";
                        } else {
                            return "";
                        }
                    }
                }
            ]
        ],
        onLoadSuccess: function () {
            $('.examinecls').linkbutton(
                        {
                            text: '',
                            iconCls: 'icon-search',
                            plain: true
                        });
        },
        onClickCell: function (index, field) {
            editRow = index;
            if (endEditing("#Adg")) {
                $("#Adg").datagrid('selectRow', index)
                    .datagrid('editCell', { index: index, field: field });
                editIndex = index;
                $('.examinecls').linkbutton(
                        {
                            text: '',
                            iconCls: 'icon-search',
                            plain: true
                        });
            }
        }
    });
    $("#dt").datagrid({
        sortName: 'ID', //询价时间排序
        sortOrder: 'desc',
        striped: true,
        rownumbers: true,
        columns: [
            [
                { field: 'box', width: 100, checkbox: true },
                { field: 'GYSNAME', title: '供应商名称', width: 200 },
                { field: 'GYSACCOUNT', title: '供应商账号', width: 100 }
            ]
        ]
    });

    Market(Adg);
    Market1(dt);


});

function diaOpen(id) {
    girdFile_load(id);
    $("#dlg").dialog("open");
}

function girdFile_load(perfGuid) {

    $.ajax({
        url: UrlPriceAdjustQuery,
        data: {
            "id": perfGuid
        },
        type: "post",
        dataType: "JSON",
        success: function (data) {
            if (data != null && data != undefined) {
                $("#lab_TXZ01").html("<b>药品名称</b>：" + data.TXZ01);
                $("#lab_MATNR").html("<b>物料号</b>：" + data.MATNR);
                if (data.SPEC != null && data.SPEC != undefined) {
                    $("#lab_SPEC").html("<b>规格</b>：" + data.SPEC);
                } else {
                    $("#lab_SPEC").html("<b>规格</b>：");
                }

                if (data.MSEHT != null && data.MSEHT != undefined) {
                    $("#lab_MSEHT").html("<b>计量单位</b>：" + data.MSEHT);
                } else {
                    $("#lab_MSEHT").html("<b>计量单位</b>：");
                }
                $("#lab_OLD_PRICE").html("<b>供货价格</b>：" + data.OLD_PRICE);
                $("#lab_ADJUST_PRICE").html("<b>调整价格</b>：" + data.ADJUST_PRICE);
                $("#lab_GYSNAME").html("<b>供应商名称</b>：" + data.GYSNAME);
                $("#lab_GYSACCOUNT").html("<b>供应商账户</b>：" + data.GYSACCOUNT);
                $("#lab_COMMENTS").html("<b>调整原因</b>：" + data.COMMENTS);
            }

        }, error: function () {
            $.messager.alert("提示", "获取数据失败", "info")
        }
    });

    $('#grid_FileInfo').datagrid({
        url: UrlPriceAdjustFile + perfGuid,
        singleSelect: true,
        sortName: 'ID',
        height: 230,
        sortOrder: 'desc',
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
                        });
        }


    });
}

var editIndex = undefined;
function endEditing(sel) {
    if (editIndex == undefined) { return true }
    if ($(sel).datagrid('validateRow', editIndex)) {
        $(sel).datagrid('endEdit', editIndex);
        editIndex = undefined;
        return true;
    } else {
        return false;
    }
}
function onClickCell(index, field) {
    if (endEditing("#Adg")) {
        $("#Adg").datagrid('selectRow', index)
                    .datagrid('editCell', { index: index, field: field });
        editIndex = index;

        //$('#Adg').datagrid('updateColumn', { index: index },row:{TXZ01:TXZ01}); 
    }
}
$.extend($.fn.datagrid.methods, {
    editCell: function (jq, param) {
        return jq.each(function () {
            var opts = $(this).datagrid('options');
            var fields = $(this).datagrid('getColumnFields', true).concat($(this).datagrid('getColumnFields'));
            for (var i = 0; i < fields.length; i++) {
                var col = $(this).datagrid('getColumnOption', fields[i]);
                col.editor1 = col.editor;
                if (fields[i] != param.field) {
                    col.editor = null;
                }
            }
            $(this).datagrid('beginEdit', param.index);
            for (var i = 0; i < fields.length; i++) {
                var col = $(this).datagrid('getColumnOption', fields[i]);
                col.editor = col.editor1;
            }
        });
    }
});
//询价表
function Market(select) {
    if (XJ_id != "") {
        $.ajax({
            url: UrlDataEditList,
            type: "post",
            data: {
                "sort": "ID",
                "order": "desc",
                "id": XJ_id
            },
            success: function (response) {
                $(select).datagrid("loadData", response);
            }, error: function () {
                $.messager.alert("提示", "编辑获取失败", "info")
            }
        })
    }
}

//厂商表
function Market1(select) {
    if (XJ_id != "") {
        $.ajax({
            url: UrlDataEditSubData,
            type: "post",
            data: { "sort": "ID",
                "order": "desc",
                "id": XJ_id
            },
            success: function (response) {
                $(select).datagrid("loadData", response);
            }, error: function () {
                $.messager.alert("提示", "编辑获取失败", "info")
            }
        })
    }
}

//药品总表（弹窗）
function Market2(select) {
    $("#Afactory").window("refresh");
    //获取搜索input
    var name = $("#CX").val();
    $(select).datagrid({
        url: UrlMaterData,
        pagination: true,
        pageSize: 15,
        pageList: [15, 30, 45, 60],
        fitColumn: false,
        rownumbers: true,
        queryParams: {
            name: name
        },
        sortName: 'ID', //询价时间排序
        sortOrder: 'desc',
        striped: true,
        toolbar: "#bb",
        columns: [
            [
                { field: 'box', width: 100, checkbox: true },
                { field: 'MAKTX', title: '名称', width: 200 },
                { field: 'MATNR', title: '编码', width: 100 },
                { field: 'ZEINR', title: '拼音码', width: 100 },
                { field: 'NORMT', title: '规格', width: 100 },
                { field: 'MSEHT', title: '计量单位', width: 100 }
            ]
        ]
    });

}
//收索功能、
function doSearch(gid, id) {
    $(gid).datagrid('reload', {
        name: $(id).val()
    });
    // alert($(id).val());
}
//供应商总表（弹窗）
function Market3(select) {
    //获取搜索input
    var name = $("#DCX").val();
    $(select).datagrid({
        url: UrlMdmDeptData,
        fitColumn: false,
        striped: true,
        toolbar: "#toolbar",
        queryParams: {
            name: name
        },
        rownumbers: true,
        sortName: 'ID', //询价时间排序
        sortOrder: 'desc',
        columns: [
            [
                { field: 'box', width: 100, checkbox: true },
                { field: 'NAME', title: '供应商名称', width: 200 },
                { field: 'CODE', title: '供应商账号', width: 100 }
            ]
        ]
    });
}
//新增药品
function factoryadd() {
    $("#Afactory").window("open");
    $("#modalName").val("");
    $('#time').combo('setText', '');
    Market2(dd);
}
//新增供应商
function addhost() {
    $("#Bfactory").window("open");
    $("#Sou").val("");
    Market3(gg);

}
//药品弹出层确定
function addSubmit() {
    var rows = $("#dd").datagrid('getSelections');
    var rowsY = $("#Adg").datagrid('getData');
    var rowsD = rowsY.rows;
    //console.log(JSON.stringify(rowsD));
    var idm = [];
    var Ttime = $.trim($('input[name="END_DATE"]').val());
    var date = new Date();
    var y = date.getFullYear();
    var m = date.getMonth() + 1;
    var d = date.getDate();
    var Xtime = y + "-" + m + "-" + d;
    for (var n = 0; n < rows.length; n++) {
        var tt = {
            TXZ01: rows[n].MAKTX,
            SPEC: rows[n].NORMT,
            MSEHT: rows[n].MSEHT,
            END_DATES: Ttime,
            QUERY_DATES: Xtime,
            MATNR_ID: rows[n].ID,
            MATNR: rows[n].MATNR
        };
        // console.log(tt.TXZ01);
        for (var m = 0; m < rowsD.length; m++) {
            //  console.log(rowsD[m].TXZ01);
            if (tt.TXZ01 == rowsD[m].TXZ01) {
                $.messager.alert('操作提示', tt.TXZ01 + '已经存在！', 'warning');
                return false;
            }
        }
        $("#Adg").datagrid('appendRow', tt);
    }
    $("#Afactory").window("close");



    //alert(JSON.stringify(ids));
    //$("#Adg").datagrid('loadData', ids);

}
function addClose() {
    $("#Afactory").window("close");
}
//供应商确定和取消
function YPaddClose() {
    $("#Bfactory").window("close");
}
function YPaddSubmit() {

    var rows = $("#gg").datagrid('getSelections');
    var rowsY = $("#dt").datagrid('getData');
    var rowsD = rowsY.rows;
    for (var n = 0; n < rows.length; n++) {
        var ll = {
            GYSNAME: rows[n].NAME,
            GYSACCOUNT: rows[n].CODE,
            GYSLABEL: ""
        };
        for (var m = 0; m < rowsD.length; m++) {
            if (ll.GYSNAME == rowsD[m].GYSNAME) {
                $.messager.alert('操作提示', ll.GYSNAME + '已经存在！', 'warning');
                return false;
            }
        }

        $("#dt").datagrid('appendRow', ll);
    }

    $("#Bfactory").window("close");
}

//删除药品
function dell(gid) {
    var rows = $(gid).datagrid("getSelections");
    if (rows.length == 0) {
        $.messager.alert('操作提示', '请选择数据!', 'warning');
        return false;
    }
    $.messager.confirm('操作提示', "确认删除吗？", function (r) {
        if (r) {
            var copyRows = [];
            var copyRow = [];
            var ids = [];
            for (var j = 0; j < rows.length; j++) {
                if ($.trim(rows[j].QUERY_STATE) == "SCM000101") {
                    copyRows.push(rows[j]);
                } else {
                    if (rows[j].ID == undefined) {
                        copyRow.push(rows[j]);
                    }
                }
            }
            if (copyRows != "") {
                for (var k = 0; k < copyRows.length; k++) {
                    ids.push(copyRows[k].ID);
                }
                var idStr = ids.join(",");
                $.ajax({
                    url: UrlDelete,
                    type: "post",
                    dataType: "JSON",
                    data: { ids: idStr },
                    success: function (response) {
                        if (response.Success == 1) {
                            for (var i = 0; i < copyRows.length; i++) {
                                var index = $(gid).datagrid('getRowIndex', copyRows[i]);
                                $(gid).datagrid('deleteRow', index);
                            }
                            $.messager.alert("提示", "删除成功", "info");
                        } else {
                            $.messager.alert("提示", "删除失败", "info");
                        }

                    }, error: function () {
                        $.messager.alert("提示", "服务器失败", "info");
                    }
                });
            }

            for (var i = 0; i < copyRow.length; i++) {
                var index = $(gid).datagrid('getRowIndex', copyRow[i]);
                $(gid).datagrid('deleteRow', index);
            }
        }
    })

}
//删除供应商
function dellg(gid) {
    var rows = $(gid).datagrid("getSelections");
    if (rows.length == 0) {
        $.messager.alert('操作提示', '请选择数据!', 'warning');
        return false;
    }
    $.messager.confirm('操作提示', "确认删除吗？", function (r) {
        if (r) {
            var rows = $(gid).datagrid("getSelections");
            var copyRows = [];
            for (var j = 0; j < rows.length; j++) {
                copyRows.push(rows[j]);
            }
            for (var i = 0; i < copyRows.length; i++) {
                var index = $(gid).datagrid('getRowIndex', copyRows[i]);
                $(gid).datagrid('deleteRow', index);
            }

        }
    })
}
//保存
function exist() {
    if (editRow != undefined) {
        $("#Adg").datagrid("endEdit", editRow);
    }
    var Egride = $("#Adg").datagrid('getData');
    var Dgride = $("#dt").datagrid('getData');
    var EgrideR = Egride.rows;
    var DgrideR = Dgride.rows;
    if (EgrideR.length == 0 && DgrideR.length != 0) {
        $.messager.alert('操作提示', '选择药品!', 'warning');
        return false;
    }
    if (DgrideR.length == 0 && EgrideR.length != 0) {
        $.messager.alert('操作提示', '选择供应商!', 'warning');
        return false;
    }
    if (EgrideR.length == 0 && DgrideR.length == 0) {
        $.messager.alert('操作提示', '选择厂家和药品!', 'warning');
        return false;
    } else {
        var data0 = [];
        for (var m = 0; m < DgrideR.length; m++) {
            var nn = {
                GYSNAME: DgrideR[m].GYSNAME,
                GYSACCOUNT: DgrideR[m].GYSACCOUNT,
                GYSLABEL: DgrideR[m].GYSLABEL
            }
            data0.push(nn);
        }
        var data = [];
        for (var i = 0; i < EgrideR.length; i++) {
            if (EgrideR[i].ID == "" || EgrideR[i].ID == undefined) {
                var k = {
                    ID: "",
                    MATNR_ID: EgrideR[i].MATNR_ID,
                    CODE: '', //询价单号
                    TXZ01: EgrideR[i].TXZ01,
                    MATNR: EgrideR[i].MATNR,
                    SPEC: EgrideR[i].SPEC,
                    MSEHT: EgrideR[i].MSEHT,
                    AMOUNT: EgrideR[i].AMOUNT,
                    PRODUCT_NAME: EgrideR[i].PRODUCT_NAME,
                    QUERY_DATE: EgrideR[i].QUERY_DATES,
                    END_DATES: EgrideR[i].END_DATES,
                    ADJUSTPRICE_ID:EgrideR[i].ADJUSTPRICE_ID,
                    QUERY_STATE: '',
                    QUERY_TYPE: '',
                    QueryPriceDetailList: data0
                };
            } else {
                var k = {
                    ID: EgrideR[i].ID,
                    MATNR_ID: EgrideR[i].MATNR_ID,
                    CODE: EgrideR[i].CODE, //询价单号
                    TXZ01: EgrideR[i].TXZ01,
                    MATNR: EgrideR[i].MATNR,
                    SPEC: EgrideR[i].SPEC,
                    MSEHT: EgrideR[i].MSEHT,
                    AMOUNT: EgrideR[i].AMOUNT,
                    PRODUCT_NAME: EgrideR[i].PRODUCT_NAME,
                    QUERY_DATE: EgrideR[i].QUERY_DATES,
                    END_DATES: EgrideR[i].END_DATES,
                    ADJUSTPRICE_ID: EgrideR[i].ADJUSTPRICE_ID,
                    QUERY_STATE: EgrideR[i].QUERY_STATE,
                    QUERY_TYPE: '',
                    QueryPriceDetailList: data0
                };
            }

            data.push(k);
        }
        var Adata = { data: JSON.stringify(data), Submit: "false" };
        var dat = JSON.parse(Adata.data)
        for (var k = 0; k < dat.length; k++) {
            if (dat[k].AMOUNT == undefined) {
                $.messager.alert("提示", "采购数量不能为空", "info");
                return false;
            } else {
                if (parseInt(dat[k].AMOUNT) <= 0) {
                    $.messager.alert("提示", "采购数量不能小于0", "info");
                    return false;
                }
                if (!/^\d+$/.test(dat[k].AMOUNT)) {
                    $.messager.alert("提示", "采购数量必须是整数！", "info");
                    return false;
                }

                if (data[k].END_DATES != "" && data[k].END_DATES != null) {
                    var date = new Date();
                    var y = date.getFullYear();
                    var m = date.getMonth() + 1;
                    var d = date.getDate();
                    var Xtime = y + "-" + m + "-" + d;
                    var Ntime = new Date(Xtime.replace(/-/g, "\/"));
                    var jzt = data[k].END_DATES;
                    var JZ = new Date(jzt.replace(/-/g, "\/"));
                    if (JZ < Ntime) {
                        $.messager.alert("提示", "截止时间不能小于今天！", "info");
                        return false;
                    }
                }

            }
        }
        $.ajax({
            url: UrlUpdate,
            type: "post",
            dataType: "JSON",
            data: Adata,
            success: function (response) {
                if (response.total > 0) {
                    $("#Adg").datagrid("loadData", response);
                    $.messager.alert("提示", "保存成功", "info");
                } else {
                    $.messager.alert("提示", "保存失败", "info");
                }
            }, error: function () {
                $.messager.alert("提示", "保存失败", "info");
            }
        })
    }
}
//提交
function Texist() {
    if (editRow != undefined) {
        $("#Adg").datagrid("endEdit", editRow);
    }
    var Egride = $("#Adg").datagrid('getData');
    var Dgride = $("#dt").datagrid('getData');
    // alert(JSON.stringify(Egride));
    var EgrideR = Egride.rows;
    var DgrideR = Dgride.rows;
    if (EgrideR.length == 0 && DgrideR.length != 0) {
        $.messager.alert('操作提示', '选择药品!', 'warning');
        return false;
    }
    if (DgrideR.length == 0 && EgrideR.length != 0) {
        $.messager.alert('操作提示', '选择供应商!', 'warning');
        return false;
    }
    if (EgrideR.length == 0 && DgrideR.length == 0) {
        $.messager.alert('操作提示', '选择厂家和药品!', 'warning');
        return false;
    } else {
        var data0 = [];
        for (var m = 0; m < DgrideR.length; m++) {
            var nn = {
                GYSNAME: DgrideR[m].GYSNAME,
                GYSACCOUNT: DgrideR[m].GYSACCOUNT,
                GYSLABEL: DgrideR[m].GYSLABEL
            }
            data0.push(nn);
        }
        var data = [];
        for (var i = 0; i < EgrideR.length; i++) {
            if (EgrideR[i].ID == "" || EgrideR[i].ID == undefined) {
                var k = {
                    ID: "",
                    MATNR_ID: EgrideR[i].MATNR_ID,
                    CODE: '', //询价单号
                    TXZ01: EgrideR[i].TXZ01,
                    MATNR: EgrideR[i].MATNR,
                    SPEC: EgrideR[i].SPEC,
                    MSEHT: EgrideR[i].MSEHT,
                    AMOUNT: EgrideR[i].AMOUNT,
                    PRODUCT_NAME: EgrideR[i].PRODUCT_NAME,
                    QUERY_DATE: EgrideR[i].QUERY_DATES,
                    END_DATES: EgrideR[i].END_DATES,
                    ADJUSTPRICE_ID: EgrideR[i].ADJUSTPRICE_ID,
                    QUERY_STATE: '',
                    QUERY_TYPE: '',
                    QueryPriceDetailList: data0
                };
            } else {
                var k = {
                    ID: EgrideR[i].ID,
                    MATNR_ID: EgrideR[i].MATNR_ID,
                    CODE: EgrideR[i].CODE, //询价单号
                    TXZ01: EgrideR[i].TXZ01,
                    MATNR: EgrideR[i].MATNR,
                    SPEC: EgrideR[i].SPEC,
                    MSEHT: EgrideR[i].MSEHT,
                    AMOUNT: EgrideR[i].AMOUNT,
                    PRODUCT_NAME: EgrideR[i].PRODUCT_NAME,
                    QUERY_DATE: EgrideR[i].QUERY_DATE,
                    END_DATES: EgrideR[i].END_DATES,
                    ADJUSTPRICE_ID: EgrideR[i].ADJUSTPRICE_ID,
                    QUERY_STATE: EgrideR[i].QUERY_STATES,
                    QUERY_TYPE: '',
                    QueryPriceDetailList: data0
                };
            }

            data.push(k);
        }
        var Adata = { data: JSON.stringify(data), Submit: "true" };
        //alert(JSON.stringify(Adata));
        //var dat = JSON.parse(Adata.data);
        for (var k = 0; k < data.length; k++) {
            if (data[k].AMOUNT == undefined) {
                $.messager.alert("提示", "采购数量不能为空", "info");
                return false;
            } else {
                if (parseInt(data[k].AMOUNT) <= 0) {
                    $.messager.alert("提示", "采购数量不能小于0", "info");
                    return false;
                }
                if (!/^\d+$/.test(data[k].AMOUNT)) {
                    $.messager.alert("提示", "采购数量必须是整数！", "info");
                    return false;
                }
                if (data[k].END_DATES == "" || data[k].END_DATES == null) {
                    $.messager.alert("提示", "请填写截止时间！", "info");
                    return false;
                } else {
                    var date = new Date();
                    var y = date.getFullYear();
                    var m = date.getMonth() + 1;
                    var d = date.getDate();
                    var Xtime = y + "-" + m + "-" + d;
                    var Ntime = new Date(Xtime.replace(/-/g, "\/"));
                    var jzt = data[k].END_DATES;
                    var JZ = new Date(jzt.replace(/-/g, "\/"));
                    if (JZ < Ntime) {
                        $.messager.alert("提示", "截止时间不能小于今天！", "info");
                        return false;
                    }
                }
            }
        }
        $.ajax({
            url: UrlUpdate,
            type: "post",
            dataType: "JSON",
            data: Adata,
            success: function (response) {
                if (response.total > 0) {
                    //$("#Adg").datagrid("loadData", response);
                    $.messager.alert("提示", "提交成功", "info");
                    window.location.href = UrlIndex;
                } else {
                    $.messager.alert("提示", "提交失败", "info");
                }
            }, error: function () {
                $.messager.alert("提示", "提交失败", "info");
            }
        })
    }

}
//返回按钮
function back() {
    window.location.href = UrlIndex;
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
