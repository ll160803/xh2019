$(function () {

    $.fn.datebox.defaults.formatter = function (date) {
        var y = date.getFullYear();
        var m = date.getMonth() + 1;
        var d = date.getDate();
        //var h = date.getHours() > 9 ? date.getHours() : '0' + date.getHours();
        //var mm = date.getMinutes() > 9 ? date.getMinutes() : '0' + date.getMinutes();
        //var s = date.getSeconds() > 9 ? date.getSeconds() : '0' + date.getSeconds();
        //return y + '-' + m + '-' + d + ' ' + h + ":" + mm + ":" + s;
        return y + '-' + m + '-' + d;
    }

    //时间格式化
    Date.prototype.format = function (format) {
        /*
        * eg:format="yyyy-MM-dd hh:mm:ss";
        */
        if (!format) {
            format = "yyyy-MM-dd hh:mm:ss";
        }

        var o = {
            "M+": this.getMonth() + 1, // month
            "d+": this.getDate(), // day
            "h+": this.getHours(), // hour
            "m+": this.getMinutes(), // minute
            "s+": this.getSeconds(), // second
            "q+": Math.floor((this.getMonth() + 3) / 3), // quarter
            "S": this.getMilliseconds()
            // millisecond
        };

        if (/(y+)/.test(format)) {
            format = format.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
        }

        for (var k in o) {
            if (new RegExp("(" + k + ")").test(format)) {
                format = format.replace(RegExp.$1, RegExp.$1.length == 1 ? o[k] : ("00" + o[k]).substr(("" + o[k]).length));
            }
        }
        return format;
    };


    /**  
 * 扩展两个方法  
 */
    $.extend($.fn.datagrid.methods, {
        /**
         * 开打提示功能  
         * @param {} jq  
         * @param {} params 提示消息框的样式  
         * @return {}  
         */
        doCellTip: function (jq, params) {
            function showTip(data, td, e) {
                if ($(td).text() == "")
                    return;
                data.tooltip.text($(td).text()).css({
                    top: (e.pageY + 10) + 'px',
                    left: (e.pageX + 20) + 'px',
                    'z-index': $.fn.window.defaults.zIndex,
                    display: 'block'
                });
            };
            return jq.each(function () {
                var grid = $(this);
                var options = $(this).data('datagrid');
                if (!options.tooltip) {
                    var panel = grid.datagrid('getPanel').panel('panel');
                    var defaultCls = {
                        'border': '1px solid #333',
                        'padding': '1px',
                        'color': '#333',
                        'background': '#f7f5d1',
                        'position': 'absolute',
                        'max-width': '200px',
                        'border-radius': '4px',
                        '-moz-border-radius': '4px',
                        '-webkit-border-radius': '4px',
                        'display': 'none'
                    }
                    var tooltip = $("<div id='celltip'></div>").appendTo('body');
                    tooltip.css($.extend({}, defaultCls, params.cls));
                    options.tooltip = tooltip;
                    panel.find('.datagrid-body').each(function () {
                        var delegateEle = $(this).find('> div.datagrid-body-inner').length
                                ? $(this).find('> div.datagrid-body-inner')[0]
                                : this;
                        $(delegateEle).undelegate('td', 'mouseover').undelegate(
                                'td', 'mouseout').undelegate('td', 'mousemove')
                                .delegate('td', {
                                    'mouseover': function (e) {
                                        if (params.delay) {
                                            if (options.tipDelayTime)
                                                clearTimeout(options.tipDelayTime);
                                            var that = this;
                                            options.tipDelayTime = setTimeout(
                                                    function () {
                                                        showTip(options, that, e);
                                                    }, params.delay);
                                        } else {
                                            showTip(options, this, e);
                                        }

                                    },
                                    'mouseout': function (e) {
                                        if (options.tipDelayTime)
                                            clearTimeout(options.tipDelayTime);
                                        options.tooltip.css({
                                            'display': 'none'
                                        });
                                    },
                                    'mousemove': function (e) {
                                        var that = this;
                                        if (options.tipDelayTime) {
                                            clearTimeout(options.tipDelayTime);
                                            options.tipDelayTime = setTimeout(
                                                    function () {
                                                        showTip(options, that, e);
                                                    }, params.delay);
                                        } else {
                                            showTip(options, that, e);
                                        }
                                    }
                                });
                    });

                }

            });
        },
        /**
         * 关闭消息提示功能  
         * @param {} jq  
         * @return {}  
         */
        cancelCellTip: function (jq) {
            return jq.each(function () {
                var data = $(this).data('datagrid');
                if (data.tooltip) {
                    data.tooltip.remove();
                    data.tooltip = null;
                    var panel = $(this).datagrid('getPanel').panel('panel');
                    panel.find('.datagrid-body').undelegate('td',
                            'mouseover').undelegate('td', 'mouseout')
                            .undelegate('td', 'mousemove')
                }
                if (data.tipDelayTime) {
                    clearTimeout(data.tipDelayTime);
                    data.tipDelayTime = null;
                }
            });
        }
    });

});