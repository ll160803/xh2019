JDWC = {};
JDWC.Format = {};
JDWC.Format.CheckSubmit = function (issubmit, dataGridId, auditId, CheckExamineId, ExamineSuggestionId, RequestNotesGuid, WorkFlowStatus, drdc, completeAction) {

    var assetGuid = [];
    var auditGuid = [];

    assetGuid.push(RequestNotesGuid); //获取所有的申请单号
    if (assetGuid.length == 0) {
        $.messager.alert('操作提示', '请选择数据！', 'info');
        return false;
    }

    var examineSuggestion = $('#' + ExamineSuggestionId).val();

    if (examineSuggestion.length <= 0) {
        //                $.messager.alert('操作提示', '请填写审核意见!', 'warning');
        //                return false;
        examineSuggestion = issubmit ? '同意' : '不同意';
    }
    if ($('#' + auditId).length > 0) {
        auditGuid = $('#' + auditId).combogrid('getValues');
    }

    var rqlist = assetGuid.join(",");
    var type = issubmit ? 1 : 0;

    if (type == 1 && auditGuid.length < 1 && drdc != 4 && $("#HiddenAudit").length<=0) {//提交 且审核人没有选 且不是完结 且会签是最后一人
        $.messager.alert('操作提示', '请选择下一步审核人', 'info');
        return false;
    }


    var msg = issubmit ? '提交' : '退单';
    WC_Common.Loading(true);
    $.post('../../WC_System_EXAMINESUGGESTION/Create', {
        audits: auditGuid.join(","), //下一个审批人
        requestNotesGuid: rqlist,
        examineSuggestion: examineSuggestion,
        workFlowStautsGuid: WorkFlowStatus,
        isSubmit: issubmit //1为提交，0为退单
    }, function (res) {
        if (res.substr(0, 2) == "OK") {
            //移除删除的数据

            $.messager.alert('操作提示', msg + '成功!', 'info');
            if (drdc == 4 && type == 1) {//完成时候去操作数据库 
                JDWC.Format.CommonCompleteAction[completeAction](RequestNotesGuid);
            }
            //  DataGridrefresh();
            $("#" + dataGridId).datagrid("clearSelections");
            $("#" + dataGridId).datagrid("reload");
            $("#" + CheckExamineId).dialog('close');
        } else if (res.startWidth("Error")) {
            $.messager.alert('操作提示', msg + '失败!请到异常页面参看相关的信息，或联系管理员。', 'info');
        } else {
            $.messager.alert('操作提示', res, 'info');
        }
        $('#' + ExamineSuggestionId).val("");
        WC_Common.Loading(false);
    });
    // TreeGridrefresh();
    return true;

}
function GetRequestGuids(dataGridId) {
    var checkedItems = $(dataGridId).datagrid('getChecked');

    var RequestGuids = [];

    $.each(checkedItems, function (index, item) {

        RequestGuids.push(item.RequestNoteGuid);

    });
    return RequestGuids;
}

JDWC.Format.CommonCompleteAction = {
    Instorage: function (requsetNoteGuid) {//入库在状态完成时候的操作
//        $.post("../../WC_Instore_InstorageRecord/CompleteAction", { requsetNoteGuid: requsetNoteGuid }, function (res) {
//            if (res == "OK") {
//                //移除删除的数据
//            }
//            else {

//            }
//        });
    },
    CFZH: function (requsetNoteGuid) {//拆分入库在状态完成时候的操作
        //$.post("../../wc_cfzh_instoragerecord/completeaction", { requsetnoteguid: requsetnoteguid }, function (res) {
        //    if (res == "ok") {
        //        //移除删除的数据
        //    }
        //    else {

        //    }
        //});
    },
    CollarBack: function (requsetNoteGuid) {//领用归还在状态完成时候的操作
        $.post("../../WC_Collar_DeviceCollarBack/CompleteAction", { requsetNoteGuid: requsetNoteGuid }, function (res) {
            if (res == "OK") {
                //移除删除的数据
            }
            else {

            }
        });
    },
    Collar: function (requsetNoteGuid) {//领用出库  在状态完成时候的操作
        $.post("../../WC_Collar_DeviceCollar/CompleteAction", { requsetNoteGuid: requsetNoteGuid }, function (res) {
            if (res == "OK") {
                //移除删除的数据
            }
            else {

            }
        });
    },
    Allot: function (requsetNoteGuid) {//调拨出库  在状态完成时候的操作
        $.post("../../WC_Allot_DeviceAllot/CompleteAction", { requsetNoteGuid: requsetNoteGuid }, function (res) {
            if (res == "OK") {
                //移除删除的数据
            }
            else {

            }
        });
    },
    RepaireBack: function (requsetNoteGuid) {//返修入库  在状态完成时候的操作
        $.post("../../WC_Repair_DeviceRpairBack/CompleteAction", { requsetNoteGuid: requsetNoteGuid }, function (res) {
            if (res == "OK") {
                //移除删除的数据
            }
            else {

            }
        });
    },
    Repaire: function (requsetNoteGuid) {//送修出库  在状态完成时候的操作
        $.post("../../WC_Repair_DeviceRepair/CompleteAction", { requsetNoteGuid: requsetNoteGuid }, function (res) {
            if (res == "OK") {
                //移除删除的数据
            }
            else {

            }
        });
    },
    Loan: function (requsetNoteGuid) {//借用出库  在状态完成时候的操作
        $.post("../../WC_Loan_DeviceLoan/CompleteAction", { requsetNoteGuid: requsetNoteGuid }, function (res) {
            if (res == "OK") {
                //移除删除的数据
            }
            else {

            }
        });
    },
    LoanBack: function (requsetNoteGuid) {//借用归还  在状态完成时候的操作
        $.post("../../WC_Loan_DeviceLoanBack/CompleteAction", { requsetNoteGuid: requsetNoteGuid }, function (res) {
            if (res == "OK") {
                //移除删除的数据
            }
            else {

            }
        });
    },
    Handle: function (requsetNoteGuid) {//处置出库  在状态完成时候的操作
        $.post("../../WC_Handle_DeviceHandle/CompleteAction", { requsetNoteGuid: requsetNoteGuid }, function (res) {
            if (res == "OK") {
                //移除删除的数据
            }
            else {

            }
        });
    }
}
