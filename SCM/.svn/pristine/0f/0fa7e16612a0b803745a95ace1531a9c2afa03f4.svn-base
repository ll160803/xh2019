/*version 1.0
*hsc 2015 07 10
*/

WCKJ = {};
WCKJ.Format = {};
WCKJ.Format.baseGrid = function (gridId, dg_toolbar, Url, cols, data_opt, frozenColumns) {
    var default_opt = SetDataOpt(dg_toolbar, Url, cols, data_opt, frozenColumns);
    $('#' + gridId).datagrid(default_opt);

}
/*设置DataGrid的配置选项*/
function SetDataOpt(dg_toolbar, Url, cols, data_opt, frozenColumns) {
    var default_opt = {
        border: false,
        rownumbers: true,
        singleSelect: false,
        checkOnSelect: true,
        selectOnCheck: true,
        pagination: true,
        pageList: [5, 10, 20, 30, 50],
        pageSize: 10
    };

    for (opt in data_opt) {
        default_opt[opt] = data_opt[opt];

    }
    if (dg_toolbar != "") {
        default_opt['toolbar'] = dg_toolbar;
    }
    default_opt['columns'] = cols;
    if (frozenColumns != undefined || frozenColumns != "") {
        default_opt['frozenColumns'] = frozenColumns;
    }
    default_opt['url'] = Url;
    return default_opt;
}
/*
点击列表下拉  含有子DataGrid*/
WCKJ.Format.SubGrid = function (gridId, dg_toolbar, Url, cols, data_opt, frozenColumns, sub_Url, sub_toolBar, sub_cols, sub_data_opt, sub_frozenColumns) {
    var default_opt = SetDataOpt(dg_toolbar, Url, cols, data_opt, frozenColumns);
    default_opt['view'] = detailview;
    default_opt['detailFormatter'] = function (index, row) {
        return '<div style="padding:2px"><table class="ddv"></table></div>';
    };

    default_opt['onExpandRow'] = function (index, row) {
        var ddv = $(this).datagrid('getRowDetail', index).find('table.ddv');
        var sub_data_optObj = sub_data_opt(index, row); //这里传递是个函数 返回子Grid的配置参数
        var onLoadSuccess = "";
        if (sub_data_optObj['onLoadSuccess'] != undefined) {
            onLoadSuccess = sub_data_optObj['onLoadSuccess'];
        }

        sub_data_optObj['onLoadSuccess'] = function () {
            setTimeout(function () {
                $('#' + gridId).datagrid('fixDetailRowHeight', index);
            },
            0);
            if (onLoadSuccess != "") {
                onLoadSuccess();
            }
        };
        var sub_default_opt = SetDataOpt(sub_toolBar, sub_Url, sub_cols, sub_data_optObj, sub_frozenColumns);

        ddv.datagrid(sub_default_opt);
        $('#' + gridId).datagrid('fixDetailRowHeight', index);
    }

    $('#' + gridId).datagrid(default_opt);
}

/*
点击列表下拉  含有子DataGrid 并且子gird可以编辑*/
WCKJ.Format.SubGrid_ForEdit = function (gridId, dg_toolbar, Url, cols, data_opt, frozenColumns, sub_Url, sub_toolBar, sub_cols, sub_data_opt, sub_frozenColumns) {
    var default_opt = SetDataOpt(dg_toolbar, Url, cols, data_opt, frozenColumns);
    default_opt['view'] = detailview;
    default_opt['detailFormatter'] = function (index, row) {
        return '<div style="padding:2px"><table class="ddv"></table></div>';
    };

    /*  peizhi  */




    /*-------------------*/
    default_opt['onExpandRow'] = function (index, row) {
        var ddv = $(this).datagrid('getRowDetail', index).find('table.ddv');
        var sub_data_optObj = sub_data_opt(index, row); //这里传递是个函数 返回子Grid的配置参数
        var onLoadSuccess = "";
        if (sub_data_optObj['onLoadSuccess'] != undefined) {
            onLoadSuccess = sub_data_optObj['onLoadSuccess'];
        }
        var editField = {
            field: 'action',
            title: '操作',
            width: 80,
            align: 'center',
            formatter: function (value, row, index2) {
                if (row.editing) {
                    var s = '<a href="#" class="UpdateCls" onclick="saverow2(\'' + index2 + '\',\'' + index + '\',\'' + gridId + '\')">更新</a> ';
                    var c = '<a href="#" class="CancelCls" onclick="cancelrow2(\'' + index2 + '\',\'' + index + '\',\'' + gridId + '\')">取消</a>';
                    return s + c;
                } else {
                    var e = '<a href="#" class="EditCls" onclick="editRow2(\'' + index2 + '\',\'' + index + '\',\'' + gridId + '\')">编辑</a> ';
                    return e;
                }
            }
        };
        var flag = 0;
        for (var i = 0; i < sub_cols[0].length; i++) {
            if (sub_cols[0][i].field == "action") {
                sub_cols[0].splice(i, 1);
                break;
            }

        }
        sub_cols[0].push(editField);



        var EditObj = {
            //双击事件
            onBeforeEdit: function (index3, row3) {
                row3.editing = true;
                ddv.datagrid('refreshRow', index3);
                WCKJ.Format.IconButton('.UpdateCls', 'icon-save', '');
                WCKJ.Format.IconButton('.CancelCls', 'icon-cancel', '');
                WCKJ.Format.IconButton('.addcl', 'icon-cut', "拆分");
            },
            onAfterEdit: function (index3, row3, changes) {
                row3.editing = false;
                UpdateAction(row3, changes,index);
                ddv.datagrid('refreshRow', index3);
                WCKJ.Format.IconButton('.EditCls', 'icon-edit', '');
                WCKJ.Format.IconButton('.addcl', 'icon-cut', "拆分");
            },
            onCancelEdit: function (index3, row3) {
                row3.editing = false;
                ddv.datagrid('refreshRow', index3);
                WCKJ.Format.IconButton('.EditCls', 'icon-edit', '');
                WCKJ.Format.IconButton('.addcl', 'icon-cut', "拆分");
            }
        }

        sub_data_optObj['onLoadSuccess'] = function () {
            WCKJ.Format.IconButton('.EditCls', 'icon-edit', '');
            WCKJ.Format.IconButton('.addcl', 'icon-cut', "拆分");
            setTimeout(function () {
                $('#' + gridId).datagrid('fixDetailRowHeight', index);
            },
                0);
            if (onLoadSuccess != "") {
                onLoadSuccess();
            }
        };
        sub_data_optObj['onResize'] = function () { $('#' + gridId).datagrid('fixDetailRowHeight', index); };
        var sub_default_opt = SetDataOpt(sub_toolBar, sub_Url, sub_cols, sub_data_optObj, sub_frozenColumns);
        for (var opt in EditObj) {
            sub_default_opt[opt] = EditObj[opt];
        }
        ddv.datagrid(sub_default_opt);
        $('#' + gridId).datagrid('fixDetailRowHeight', index);
    }

    $('#' + gridId).datagrid(default_opt);




}


/*可编辑DataGrid 
*EditType  0是双击编辑 1是点击行内按钮编辑，同时双击编辑
*/

WCKJ.Format.EditGrid = function (gridId, dg_toolbar, Url, cols, data_opt, frozenColumns, EditType) {

    var EditObj = {
        onDblClickRow: onDblClickRow,
        //双击事件
        onBeforeEdit: function (index, row) {
            row.editing = true;
            $('#' + gridId).datagrid('refreshRow', index);
            WCKJ.Format.IconButton('.UpdateCls', 'icon-save', '');
            WCKJ.Format.IconButton('.CancelCls', 'icon-cancel', '');
        },
        onAfterEdit: function (index, row, changes) {
            row.editing = false;

            $('#' + gridId).datagrid('refreshRow', index);
            WCKJ.Format.IconButton('.EditCls', 'icon-edit', '');
        },
        onCancelEdit: function (index, row) {
            row.editing = false;
            $('#' + gridId).datagrid('refreshRow', index);
            WCKJ.Format.IconButton('.EditCls', 'icon-edit', '');
        }
    }

    var editField = {
        field: 'action',
        title: '操作',
        width: 80,
        align: 'center',
        formatter: function (value, row, index) {
            if (row.editing) {
                var s = '<a href="#" class="UpdateCls" onclick="saverow(' + index + ')">更新</a> ';
                var c = '<a href="#" class="CancelCls" onclick="cancelrow(' + index + ',\'' + gridId + '\')">取消</a>';
                return s + c;
            } else {
                var e = '<a href="#" class="EditCls" onclick="editRow(' + index + ',\'' + gridId + '\')">编辑</a> ';
                return e;
            }
        }
    };
    if (EditType == 1) { //在每行的最右侧 有编辑按钮
        cols[0].push(editField);
    }
    var default_opt = SetDataOpt(dg_toolbar, Url, cols, data_opt, frozenColumns);

    for (var opt in EditObj) {
        default_opt[opt] = EditObj[opt];
    }
    //    if (EditType == 0) {
    //        default_opt["onDblClickRow"] = onDblClickRow; //当EditType为0时，是行内双击编辑
    //    }
    $('#' + gridId).datagrid(default_opt);

    function onDblClickRow(index) {
        if (editIndex != index) {
            if (endEditing(gridId)) {
                $('#' + gridId).datagrid('selectRow', index).datagrid('beginEdit', index);
                editIndex = index;

            } else {

                $('#' + gridId).datagrid('selectRow', editIndex);
            }
        }
    }
}



/* 编辑 */

var editIndex = undefined;
function endEditing(gridId) {

    if (editIndex == undefined) {
        return true;
    }
    if ($('#' + gridId).datagrid('validateRow', editIndex)) {
        $('#' + gridId).datagrid('endEdit', editIndex);
        editIndex = undefined;
        return true;
    } else {
        return false;
    }
}
function editRow(index, gridId) {

    if (editIndex != index) {
        if (endEditing(gridId)) {
            $('#' + gridId).datagrid('selectRow', index).datagrid('beginEdit', index);

            editIndex = index;

        } else {

            $('#' + gridId).datagrid('selectRow', editIndex);
        }
    }
}
function cancelrow(index, gridId) {
    $('#' + gridId).datagrid('cancelEdit', index); //调onCancelEdit函数
    editIndex = undefined;
}

function endEditing2(index, gridId) {
    var ddv = $('#' + gridId).datagrid('getRowDetail', index).find('table.ddv');
    if (editIndex == undefined) {
        return true;
    }
    if (ddv.datagrid('validateRow', editIndex)) {
        ddv.datagrid('endEdit', editIndex);
        editIndex = undefined;
        return true;
    } else {
        return false;
    }
}

function saverow2(index2, index, gridId) {
    var ddv = $('#' + gridId).datagrid('getRowDetail', index).find('table.ddv');
    ddv.datagrid('endEdit', index2);
}
function editRow2(index2, index, gridId) {
    var ddv = $('#' + gridId).datagrid('getRowDetail', index).find('table.ddv');

    ddv.datagrid('beginEdit', index2);


}
function cancelrow2(index2, index, gridId) {
    var ddv = $('#' + gridId).datagrid('getRowDetail', index).find('table.ddv');
    ddv.datagrid('cancelEdit', index2); //调onCancelEdit函数
    // editIndex = undefined;
}


//为日常维护做的特殊处理  在可以编辑的同时 支持合并
WCKJ.Format.EditGrid_Renovation = function (gridId, dg_toolbar, Url, cols, data_opt, frozenColumns, EditType) {

    var EditObj = {
        onDblClickRow: onDblClickRow,
        //双击事件
        onBeforeEdit: function (index, row) {
            row.editing = true;
            $('#' + gridId).datagrid('refreshRow', index);
            WCKJ.Format.IconButton('.UpdateCls', 'icon-save', '');
            WCKJ.Format.IconButton('.CancelCls', 'icon-cancel', '');
        },
        onAfterEdit: function (index, row) {
            row.editing = false;
            $('#' + gridId).datagrid('refreshRow', index);
            WCKJ.Format.IconButton('.EditCls', 'icon-edit', '');
        },
        onCancelEdit: function (index, row) {
            row.editing = false;
            $('#' + gridId).datagrid('refreshRow', index);
            WCKJ.Format.IconButton('.EditCls', 'icon-edit', '');
        }
    }

    var editField = {
        field: 'action',
        title: '操作',
        width: 80,
        align: 'center',
        formatter: function (value, row, index) {
            if (row.editing) {
                var s = '<a href="#" class="UpdateCls" onclick="saverow(' + index + ')">更新</a> ';
                var c = '<a href="#" class="CancelCls" onclick="cancelrow(' + index + ',\'' + gridId + '\')">取消</a>';
                return s + c;
            } else {
                var e = '<a href="#" class="EditCls" onclick="editRow(' + index + ',\'' + gridId + '\')">编辑</a> ';
                return e;
            }
        }
    };
    if (EditType == 1) { //在每行的最右侧 有编辑按钮
        cols[0].push(editField);
    }
    var default_opt = SetDataOpt(dg_toolbar, Url, cols, data_opt, frozenColumns);

    for (var opt in EditObj) {
        default_opt[opt] = EditObj[opt];
    }
    //    if (EditType == 0) {
    //        default_opt["onDblClickRow"] = onDblClickRow; //当EditType为0时，是行内双击编辑
    //    }
    $('#' + gridId).datagrid(default_opt);

    function onDblClickRow(index) {
        if (editIndex != index) {
            if (endEditing(gridId)) {
                $('#' + gridId).datagrid('selectRow', index).datagrid('beginEdit', index);
                editIndex = index;

            } else {

                $('#' + gridId).datagrid('selectRow', editIndex);
            }
        }
        MergeCells(gridId, 'DeviceName'); //此方法在页面里面 
    }
}
//Grid合并单元格
function MergeCells(tableID, fldList) {
    var Arr = fldList.split(",");
    var dg = $('#' + tableID);
    var fldName;
    var RowCount = dg.datagrid("getRows").length;
    var span;
    var PerValue = "";
    var CurValue = "";
    var length = Arr.length - 1;
    for (i = length; i >= 0; i--) {
        fldName = Arr[i];
        PerValue = "";
        span = 1;
        for (row = 0; row <= RowCount; row++) {
            if (row == RowCount) {
                CurValue = "";
            }
            else {
                CurValue = dg.datagrid("getRows")[row][fldName];
            }
            if (PerValue == CurValue) {
                span += 1;
            }
            else {
                var index = row - span;
                dg.datagrid('mergeCells', {
                    index: index,
                    field: fldName,
                    rowspan: span,
                    colspan: null
                });
                span = 1;
                PerValue = CurValue;
            }
        }
    }
}

/*设置按钮图片 */
WCKJ.Format.IconButton = function (value, icon, text) {

    $(value).linkbutton(
                    {
                        text: text,
                        plain: true,
                        iconCls: icon
                    });

};



WCKJ.Format.BaseTreeGrid = function (gridId, dg_toolbar, Url, cols, data_opt, frozenColumns) {
    var default_opt = SetTreeGridOpt(dg_toolbar, Url, cols, data_opt, frozenColumns);
    $('#' + gridId).treegrid(default_opt);
}
/*设置DataGrid的配置选项*/
function SetTreeGridOpt(dg_toolbar, Url, cols, data_opt, frozenColumns) {
    var default_opt = {
        border: false,
        fitColumns: true,
        rownumbers: true,
        singleSelect: false
    };

    for (opt in data_opt) {
        default_opt[opt] = data_opt[opt];

    }
    if (dg_toolbar != "") {
        default_opt['toolbar'] = dg_toolbar;
    }
    default_opt['columns'] = cols;
    if (frozenColumns != undefined || frozenColumns != "") {
        default_opt['frozenColumns'] = frozenColumns;
    }
    default_opt['url'] = Url;
    return default_opt;
}

/*
点击列表下拉  含有子DataGrid*/
WCKJ.Format.MainTreeAndSubGrid = function (gridId, dg_toolbar, Url, cols, data_opt, frozenColumns, sub_Url, sub_toolBar, sub_cols, sub_data_opt, sub_frozenColumns) {

    var default_opt = SetDataOpt(dg_toolbar, Url, cols, data_opt, frozenColumns); //主表配置
    default_opt['view'] = detailview;
    default_opt['detailFormatter'] = function (index, row) {
        return '<div style="padding:2px"><table class="ddv"></table></div>';
    };

    default_opt['onExpandRow'] = function (index, row) {
        var ddv = $(this).datagrid('getRowDetail', index).find('table.ddv');
        var sub_data_optObj = sub_data_opt(index, row); //这里传递是个函数 返回子Grid的配置参数
        var onLoadSuccess = "";
        if (sub_data_optObj['onLoadSuccess'] != undefined) {
            onLoadSuccess = sub_data_optObj['onLoadSuccess'];
        }
        sub_data_optObj['onExpand'] = function () {//展开时候需要重新设置高度
            setTimeout(function () {
                $('#' + gridId).datagrid('fixDetailRowHeight', index);
            },
            0);
        };
        sub_data_optObj['onCollapse'] = function () {//关闭时候需要重新设置高度
            setTimeout(function () {
                $('#' + gridId).datagrid('fixDetailRowHeight', index);
            },
            0);
        };
        sub_data_optObj['onLoadSuccess'] = function () {
            setTimeout(function () {
                $('#' + gridId).datagrid('fixDetailRowHeight', index);
            },
            0);
            if (onLoadSuccess != "") {
                onLoadSuccess();
            }
        };
        var sub_default_opt = SetTreeGridOpt(sub_toolBar, sub_Url, sub_cols, sub_data_optObj, sub_frozenColumns);

        ddv.treegrid(sub_default_opt);
        $('#' + gridId).datagrid('fixDetailRowHeight', index);
    }

    $('#' + gridId).datagrid(default_opt);
}

             
