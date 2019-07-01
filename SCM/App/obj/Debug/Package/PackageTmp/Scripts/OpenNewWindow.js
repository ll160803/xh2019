function openPostWindow(url, data) {//必须含有jquery

    var form = $("<form></form>");
    form.attr('target', '_blank');
    form.attr('action', url);
    form.attr('method', 'post');
    var input1 = $("<input type='hidden' name='hide_content' />");
    input1.attr('value', data);
    form.append(input1);
    form.appendTo("body");
    form.css('display', 'none');
    form.submit();

}