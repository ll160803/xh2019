WC_Common = {};
WC_Common.Format = {};
/* combotree生成*/
WC_Common.combotree = function (id, url, valueField, textField, option) {
    var defaultOption = {
        panelHeight: 'auto',
        url: url,
        width: '135',
        panelWidth: '300',
        valueField: valueField,
        textField: textField
    }
    if (option != undefined && option.length > 0) {
        $.extend(defaultOption, option);
    }

    $('#' + id).combotree(defaultOption);
}

WC_Common.Format.Editor = function () {
    return { type: "numberbox", options: { precision: 0} };
};

/*datebox默认值获取系统当前时间*/
WC_Common.Format.Initdatebox = function (id) {
    var curr_time = new Date();
    var strDate = curr_time.getFullYear() + "-";
    strDate += curr_time.getMonth() + 1 + "-";
    strDate += curr_time.getDate();
    $("#" + id).datebox('setValue', strDate);
}


Date.prototype.Format = function (format) {
    var o = {
        "M+": this.getMonth() + 1, //month
        "d+": this.getDate(), //day
        "h+": this.getHours(), //hour
        "m+": this.getMinutes(), //minute
        "s+": this.getSeconds(), //second
        "q+": Math.floor((this.getMonth() + 3) / 3), //quarter
        "S": this.getMilliseconds() //millisecond
    }

    if (/(y+)/.test(format)) {
        format = format.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    }

    for (var k in o) {
        if (new RegExp("(" + k + ")").test(format)) {
            format = format.replace(RegExp.$1, RegExp.$1.length == 1 ? o[k] : ("00" + o[k]).substr(("" + o[k]).length));
        }
    }
    return format;
}

WC_Common.Format.InitDateTimeBox = function (id) {
 
    var dateValue = $("#" + id).val();
    var currentTime = new Date().Format("MM/dd/yyyy hh:mm");
    if (dateValue != undefined) {
        if (dateValue.length > 0) {
            //            var date2 = dateValue.replace(/-/g, "/");
            //            var date = new Date(date2);
            //            if (!isNaN(date)) {
            //                currentTime = new Date(date).Format("MM/dd/yyyy hh:mm");
            //            }
            $('#' + id).datetimebox({
                showSeconds: false
            });
            return;
        }
    }

    //  $('#dt').datetimebox('setValue', '6/1/2012 12:30:56');
    $('#' + id).datetimebox({
        showSeconds: false,
        value: currentTime
    });
    // $('#' + id).val(currentTime);
}

WC_Common.Format.InitDateBox = function (id) {
    var dateValue = $("#" + id).val();
    var current = new Date().Format("yyyy/dd/MM");
    if (dateValue != undefined) {
        if (dateValue.length > 0) {
            var date2 = dateValue.replace(/-/g, "/");
            var date = new Date(date2);
            if (!isNaN(date)) {
                current = new Date(date).Format("yyyy/dd/MM");
            }
        }
    }

    //  $('#dt').datetimebox('setValue', '6/1/2012 12:30:56');
    $('#' + id).datebox({
        value: current
    });

}

/* combobox  开始*/
WC_Common.combobox = function (id, url, valueField, textField, option) {
    var defaultOption = {
        panelHeight: '300',
        url: url,
        width: '135',
        panelWidth: '300',
        valueField: valueField,
        textField: textField
    }

    if (option != undefined && option.length > 0) {
        $.extend(defaultOption, option);
    }

    $('#' + id).combobox(defaultOption);
}



WC_Common.combotree = function (id, url,option) {
    var defaultOption = {
        url: url,
        required: true
    }
    if (option != undefined && option.length > 0) {
        $.extend(defaultOption, option);
    }
    $('#' + id).combotree(defaultOption);
}
WC_Common.Format.DateBox = function (id) {
    var defaultOption = {
        width: 135
    };
    $('#' + id).datebox(defaultOption);
}

//设备详情
WC_Common.DetailsDevice = function (DeviceGuid) {
    window.location.href = "../../WC_Instore_InstorageRecord/Details/" + DeviceGuid;
    return false;
}
WC_Common.DetailsDevice_Base = function (DeviceGuid) {
    window.location.href = "../../WC_base_DeviceBaseInfo/Details/" + DeviceGuid;
    return false;
}
/* combobox  END */
/* 是否 选择的combobox*/
WC_Common.Format.IS_combobox = function (id) {
    var bool = $('#' + id).val();
    $('#' + id).combobox({
        valueField: 'id',
        textField: 'text',
        panelHeight: 'auto',
        data: [{
            "id": "是",
            "text": "是",
            "selected": true
        }, {
            "id": "否",
            "text": "否"
        }]
    });
    if (bool!="") {
        $('#' + id).combobox('setValue', bool);
    }
}
WC_Common.Format.IS_comboboxs = function (id) {
    $('#' + id).combobox({
        valueField: 'id',
        textField: 'text',
        panelHeight: 'auto',
        data: [{
            "id": "满意",
            "text": "满意",
            "selected": true

        }, {
            "id": "不满意",
            "text": "不满意"
        }]
    });
}
/* 获取当年审批年*/
function GetCurrentYear() {//只返回当前年
    var myDate = new Date();
    var currenYear = myDate.getFullYear();
    //    if (myDate.getMonth() + 1 < 7) {
    //        currenYear = myDate.getFullYear();
    //    }
    return currenYear;
}
WC_Common.Format.Year = function (id, options) {

    var defaults = {
        currenYear: GetCurrentYear(),
        spanStartYear: 10,
        spanEndYear: 10
    };
    $.extend(defaults, options);
    var items = [];
    for (var i = defaults.currenYear - defaults.spanStartYear; i <= defaults.currenYear + defaults.spanEndYear; i++) {
        items.push({ "id": i, "text": i });
    }

    $(id).combobox({
        data: items,
        valueField: 'id',
        textField: 'text',
        editable: false
    });

    $(id).combobox('setValue', [defaults.currenYear]);

};



WC_Common.Format.Date = function (value, format) {
    if (value == null) return "";
    format = 'yyyy-MM-dd hh:mm';
    var reg = new RegExp('/', 'g');
    var d = eval('new ' + value.replace(reg, ''));
    return new Date(d).format(format);
};
WC_Common.Format.Dates = function (value, format) {
    if (value == null) return "";
    format = 'yyyy-MM-dd';
    var reg = new RegExp('/', 'g');
    var d = eval('new ' + value.replace(reg, ''));
    return new Date(d).format(format);
};
/* 在操作时候页面显示 正在加载 */
WC_Common.Loading = function (isShow) {
    var display = "block";
    if (!isShow) {
        display = "none";
        $(".datagrid-mask-msg").remove();
        $(".datagrid-mask").remove();
    }
    $("<div class=\"datagrid-mask\"></div>")
            .css({ display: display, width: "100%", height: $(window).height() })
            .appendTo("body");
    $("<div class=\"datagrid-mask-msg\"></div>")
            .html("正在处理数据，请稍等。。。")
            .appendTo("body")
            .css({ display: display, left: ($(document.body).outerWidth(true) - 190) / 2, top: ($(window).height() - 45) / 2 });

}


/**
* 审核页面图片按钮
* 用法:WC.Check.Format.IconButton('detailcls','icon-tip');
*/
WC_Common.Format.IconButton = function (value, icon, text) {

    $(value).linkbutton(
                    {
                        text: text,
                        plain: true,
                        iconCls: icon
                    });

};
WC_Common.Format.Editor = function () {

    return { type: "numberbox" };
};