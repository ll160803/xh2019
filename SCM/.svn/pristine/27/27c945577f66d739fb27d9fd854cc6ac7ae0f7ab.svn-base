var InitDataConfig = {}

InitDataConfig.Company = 'WH';//更改为对应部门的样式文件夹名称

InitDataConfig.InitEntryDate = "1990-01-01";

InitDataConfig.PleaseSelect = "--请选择--";

InitDataConfig.OpenDeptSelect = true;//创建入库申请单，弹出部门选择对话框

InitDataConfig.CombotreeInit = function (id, url, defaultValue) {
    var target = '#' + id;
    $(target).combotree({
        url: url,
        panelWidth: '300',
        valueField: 'Id',
        textField: 'text',
        onLoadSuccess: function () {
            if (defaultValue == null || defaultValue == undefined || defaultValue == 'undefined' || defaultValue.length == 0) defaultValue = WC.PleaseSelect;
            $(target).combotree("setValue", defaultValue);
        }
    });
};

InitDataConfig.GetDate = function (date) {
    var day = date.getDate() > 9 ? date.getDate() : "0" + date.getDate();
    var month = (date.getMonth() + 1) > 9 ? (date.getMonth() + 1) : "0"
        + (date.getMonth() + 1);
    return date.getFullYear() + '-' + month + '-' + day;
};

InitDataConfig.Today = function () {
    var date = new Date();
    var day = date.getDate() > 9 ? date.getDate() : "0" + date.getDate();
    var month = (date.getMonth() + 1) > 9 ? (date.getMonth() + 1) : "0"
        + (date.getMonth() + 1);
    return date.getFullYear() + '-' + month + '-' + day;
};

InitDataConfig.SetStyle = function () {

    var css = "/Content/" + this.Company + "/StyleSheet.css";
    //$("<link>").attr({ rel: "stylesheet", type: "text/css", href: css }).appendTo("head");

    var link = document.createElement('link');
    link.type = 'text/css';
    link.rel = 'stylesheet';
    link.href = css;
    document.getElementsByTagName("head")[0].appendChild(link);
};

InitDataConfig.Combobox = {};

InitDataConfig.Combobox.YesNoNull = function (id, yesLabel, yesValue, noLabel, noValue, nullLabel, nullValue) {

    var target = "#" + id;

    $(target).combobox({
        valueField: 'id',
        textField: 'text',
        data: [{
            text: yesLabel,
            id: yesValue
        }, {
            text: noLabel,
            id: noValue
        }, {
            text: nullLabel,
            id: nullValue
        }]

    });
}

InitDataConfig.Combobox.YesNo = function (id, yesLabel, yesValue, noLabel, noValue) {

    var target = "#" + id;

    $(target).combobox({
        valueField: 'id',
        textField: 'text',
        data: [{
            text: yesLabel,
            id: yesValue
        }, {
            text: noLabel,
            id: noValue
        }]

    });
}

InitDataConfig.Format = {};

InitDataConfig.Format.Date = {};

InitDataConfig.Format.Date.YYYY_mm_dd = function (value, rec) {

    var result = '';

    var toDate = function (value1) {
        var reg = new RegExp('/', 'g');
        var d = eval('new ' + value1.replace(reg, ''));
        return new Date(d).format('yyyy-MM-dd');
    }

    if (value) {
        result = toDate(value);
    }

    return result;
};