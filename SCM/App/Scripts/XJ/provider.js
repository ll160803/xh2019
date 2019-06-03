var addbj;
var i;
var hs = document.getElementsByTagName("h4");
var bj_index=0;
$(function() {
	$("#tosearch").click(function() {
		tosearch();
	});
	$("#addhosp").click(function() {
		Addhosp();
	});

    document.onkeydown = function (event) {
        e = event ? event : (window.event ? window.event : null);
        if (e.keyCode == 13) {
            //执行的方法   
            tosearch();
            return false;
        }
    }

	$('#dataTable').datagrid({
		url:girdUrl,
		method: "post",
        toolbar:'#tb',
        fit:true,
		columns: [
			[
			{
				field: 'TXZ01',
				title: '药品名称',
				align: 'center',
				sortable: true,
				width: 150
					//order:'desc',
			}, {
				field: 'SPEC',
				title: '药品规格',
				sortable: true,
				align: 'center',
				width: 80
			}, {
				field: 'MSEHT',
				title: '计量单位',
				align: 'center',
				width: 80
			}, {
				field: 'AMOUNT',
				title: '采购数量',
				align: 'center',
				width: 80
			}, {
				field: 'QUOTEDPRICE_STATE',
				title: '报价状态',
				align: 'center',
				width: 80,
				formatter: function(value,row, rec) {
					if(row.STATE == "0"||row.STATE == "1") {
						return "待报价";
					}
					if(row.STATE== "2") {
						return "已报价";
					}
				}
			}, {
				field: 'QUERY_STATE_NAME',
				title: '询价状态',
				align: 'center',
				width: 80
			}, {
				field: 'QUERY_DATE',
				title: '询价时间',
				align: 'center',
				sortable: true,
				width: 100,
				formatter: function(value, rec) {
					if(value) {
						return dateConvert(value);
					}
				}
			}, {
				field: 'END_DATE',
				title: '截止时间',
				align: 'center',
				sortable: true,
				width: 100,
				formatter: function(value, rec) {
					if(value) {
						return dateConvert(value);
					}
				}
			}, {
				field: 'ID',
				title: '操作',
				align: 'center',
				width: 250,
				formatter: function(value, row, index) {
					if(row.STATE==0){//待报价
						if(row.QUERY_STATE_NAME=="已结束"){
							 return [
								'<a id="#bjadd" href="javascript:void(0)" style="float:left;color:#ccc;" onclick="gotobj(' + index + ')">我要报价</a>',
								'<a id="#bjlook" href="javascript:void(0)" style="color:#ccc;" onclick="Lookbj(' + index + ')">查看报价</a>',
								'<a id="#bjremove" href="javascript:void(0)" style="float:right;color:#ccc;" onclick="Removebj(' + index + ')">删除报价</a>'
							].join('');
						}else{
							 return [
								'<a id="#bjadd" href="javascript:void(0)" style="float:left;" onclick="gotobj(' + index + ')">我要报价</a>',
								'<a id="#bjlook" href="javascript:void(0)" style="color:#ccc;" onclick="Lookbj(' + index + ')">查看报价</a>',
								'<a id="#bjremove" href="javascript:void(0)" style="float:right;color:#ccc;" onclick="Removebj(' + index + ')">删除报价</a>'
							].join('');
						}  		
					}
					else if(row.STATE==1||row.STATE==2){//已保存或者提交报价
						if(row.QUERY_STATE_NAME=="已结束"){
							 return [
								'<a id="#bjadd" href="javascript:void(0)" style="float:left;color:#ccc;" onclick="gotobj(' + index + ')">我要报价</a>',
								'<a id="#bjlook" href="javascript:void(0)" onclick="Lookbj(' + index + ')">查看报价</a>',
								'<a id="#bjremove" href="javascript:void(0)" style="float:right;color:#ccc;" onclick="Removebj(' + index + ')">删除报价</a>'
							].join('');
						}else{
							 return [
								'<a id="#bjadd" href="javascript:void(0)" style="float:left;" onclick="gotobj(' + index + ')">我要报价</a>',
								'<a id="#bjlook" href="javascript:void(0)" onclick="Lookbj(' + index + ')">查看报价</a>',
								'<a id="#bjremove" href="javascript:void(0)" style="float:right;" onclick="Removebj(' + index + ')">删除报价</a>'
							].join('');
						}  	
					}
				}
			}]
		],
		pagination: true,
		pageSize: 10,
		pageList: [10, 20, 30, 40],
		nowrap: false,
		fitColumns: true,
		rownumbers: true,
		singleSelect: true,
		sortName: 'QUERY_DATE',
		sortOrder: 'desc'
	});
	for(i = 0; i < hs.length; i++) {
		hs[i].innerHTML = "报价" + (i + 1);
	}
    var newHeight = parent.$('#tabs').tabs('getSelected').panel('options').height - 130;
		$("#dataTable").datagrid('resize', {
			height: newHeight
	});

});

//查询询价信息
function tosearch() {
	var XtimeStart= new Date($('input[name="xj_from"]').val().replace(/-/g, "\/"));
    var XtimeEnd=new Date($('input[name="xj_to"]').val().replace(/-/g, "\/"));
    var JtimeStart=new Date($('input[name="jz_from"]').val().replace(/-/g, "\/"));
    var JtimeEnd=new Date($('input[name="jz_to"]').val().replace(/-/g, "\/"));
	if (XtimeStart > XtimeEnd) {
		$.messager.alert("提示", "截止时间不能小于开始时间");
		return false;
	}
	if (JtimeStart > JtimeEnd) {
		$.messager.alert("提示", "截止时间不能小于开始时间");
		return false;
	} 
	$('#dataTable').datagrid('load', {
		M_NAME: $.trim($('input[name="M_NAME"]').val()),
		M_STANDARD: $.trim($('input[name="M_STANDARD"]').val()),
		BJ_STATE:$('input[name="BJ_STATE"]').val(),
		XJ_STATE:$('input[name="XJ_STATE"]').val(),
		xj_from:$('input[name="xj_from"]').val(),
		xj_to:$('input[name="xj_to"]').val(),
		jz_from:$('input[name="jz_from"]').val(),
		jz_to:$('input[name="jz_to"]').val(),
	});

}

//返回按钮
function Closebj() {
	$("#toadd").css("display", "none");
	$('#dataTable').datagrid('load');
}
//我要报价
function gotobj(index) {
bj_index=0;
	var rowIndex = $('#dataTable').datagrid('getRowIndex', rows);
	$('#dataTable').datagrid('selectRow', index);
	var rows = $('#dataTable').datagrid('getSelected');
	if($.trim(rows.QUERY_STATE_NAME)== "已结束") {
		$.messager.alert("提示", "询价已结束");
	}
	else{
		$("#toadd").find(".title").find("span:first").html("询价信息");
		$("#toadd").find(".top").css("display","block");
		$("#toadd input").attr("readonly", "false").css({
		"border-width": "1px",
        "border-style": "solid",
        "border-color": "#ccc"
		});
   // $("#toadd a").css("display","inline-block");
    $(".bjdelete,.addhosp,.submitbjbtn,.updatebjbtn,.addbj").css("display","inline-block");
	// $("#toadd p").css("display","block");
	Mcontent(index);
	$.ajax({
		type: "post",
		url: bjUrl,
        data:{id:rows.ID},
		success: function(inputdata) {
			var QuotedList = inputdata.QuotedList;
			for(var i = 0; i < QuotedList.length; i++) {
                bj_index+=1;
				if(QuotedList[i].QUOTED_PRICE == null) {
					QuotedList[i].QUOTED_PRICE = "";
				}
				if( QuotedList[i].SUPPLY_AMOUNT == null){
					QuotedList[i].SUPPLY_AMOUNT = "";
				}
				if( QuotedList[i].COMMENTS == null){
					QuotedList[i].COMMENTS = "";
				}
				if( QuotedList[i].PRODUCT_NAME == null){
					QuotedList[i].PRODUCT_NAME = "";
				}
				if(QuotedList[i].PRODUCT_NAME != ""&&QuotedList[i].STATE==0){
					QuotedList[i].PRODUCT_NAME+="（协和指定报价厂家）";
				}
				var add_li = Quoted_li(QuotedList[i].PRODUCT_NAME, QuotedList[i].QUOTED_PRICE, QuotedList[i].SUPPLY_AMOUNT, QuotedList[i].COMMENTS);
				$("#bjul").append($(add_li));

				for(var j = 0; j < QuotedList[i].Hospitals.length; j++) {
					var hj = QuotedList[i].Hospitals[j];
					if(hj.PRICE == null) {
						hj.PRICE = "";
					}
					if(hj.COMMENTS_D == "null"||hj.COMMENTS_D == null) {
						hj.COMMENTS_D = "";
					}
					if(hj.HOSPITAL_NAME == null||hj.HOSPITAL_NAME == "null") {
						hj.HOSPITAL_NAME = "";
					}
					var add_hos = hospital_div(j + 1, hj.HOSPITAL_NAME, hj.PRICE, hj.COMMENTS_D,hj.COM_FILE_ID,hj.COM_FILE_ID_S_NAME,hj.COM_FILE_ID_NAME);
					$("#bjul").children("li:last").append(add_hos);
				}
				hs[i].innerHTML = "报价" + (i + 1);
			}
		}

	});
	}

	//保存报价
	Keepbj=function Keepbj() {
	if(rows.STATE== 2) {
		rows.STATE=2
	}if(rows.STATE==0) {
		rows.STATE=1
	}
	var limessages = "";
	$("#bjul li").each(function(index) {
		if($(this).find("input[name=provider]").val() == "") {
			limessages = "生产厂家不能为空;";
			return false;
		}
		if($(this).find("input[name=bjprice]").val() == "") {
			limessages = "报价价格不能为空;";
			return false;
		}
		if (!/^[+]{0,1}(\d+)$|^[+]{0,1}(\d+\.\d+)$/.test($(this).find("input[name=bjprice]").val())) {
			limessages = "报价价格格式不正确;";
			return false;
		}
		if($(this).find("input[name=bjamount]").val() == "") {
			limessages = "可供数量不能为空;";
			return false;
		}
		if (!/^\d+$/.test($(this).find("input[name=bjamount]").val())) {
			limessages = "可供数量必须是整数;";
			return false;
		}

		if($.trim($(this).find("input[name=provider]").val()) == $.trim($(this).siblings("li").find("input[name=provider]").val())) {
			limessages = "生产厂家不能相同;";
			return false;
		}
		$(this).find(".libottom").each(function(index) {
			var hospvala = $.trim($(this).find("input[name=offerhosp]").val());
			var hosvalb = $.trim($(this).siblings(".libottom").find("input[name=offerhosp]").val());
			if(hospvala != "" || hosvalb != "") {
				if(hospvala == hosvalb) {
					limessages = "医院不能相同;"
					return false;
				}
			}
//			if(hospvala==""){
//			limessages= "医院不能为空;";
//			return false;
//			}
//			if($.trim($(this).find("input[name=offerprice]").val())==""){
//			limessages= "供货价格不能为空;";
//			return false;
//			}
		});
	});
	if(limessages!= "") {
		$.messager.alert("提示", limessages);
	} else {
		var liarr = new Array();
		var inputarr = new Array();
		$("#bjul li").each(function() {
			var liobj = new Object();
			liobj.PRODUCT_NAME = $(this).find("input[name=provider]").val();
			liobj.PRODUCT_NAME=liobj.PRODUCT_NAME.replace("（协和指定报价厂家）","");
			liobj.QUOTED_PRICE = $(this).find("input[name=bjprice]").val();
			liobj.SUPPLY_AMOUNT = $(this).find("input[name=bjamount]").val();
			liobj.COMMENTS = $(this).find("input[name=markpro]").val();
			var hosparr = new Array();
			$(this).find(".libottom").each(function() {
				var hospobj = new Object();
				hospobj.HOSPITAL_NAME = $(this).find("input[name=offerhosp]").val();
				hospobj.PRICE = $(this).find("input[name=offerprice]").val()== "" ? 0 :$(this).find("input[name=offerprice]").val();
				hospobj.COMMENTS_D = $(this).find("input[name=markhosp]").val();
				hospobj.DISPLAY_INDEX = $(this).find("input[name=hidden_displayIndex]").val();
                hospobj.COM_FILE_ID = $(this).find("input[name=hide_file_id]").val();
				hosparr.push(hospobj);
			});
			liobj.Hospitals = hosparr;
			liarr.push(liobj);
		});
		liarr = JSON.stringify(liarr);
		$.ajax({
			type: "post",
			url:SaveUrl,
			data: {
				ID: $("input[name=hidden_XJID]").val(),
				data: liarr,
                state:rows.STATE
			},
			success: function(keepdata) {
					$.messager.alert("提示", "保存成功");
					$('#dataTable').datagrid('load');
			},
			error: function(keepdata) {
				
			}
		});
	}
}
	
}


//查看报价
function Lookbj(index) { 
 bj_index=0;
	var rowIndex = $('#dataTable').datagrid('getRowIndex', rows);
	$('#dataTable').datagrid('selectRow', index);
	var rows = $('#dataTable').datagrid('getSelected');
	if(rows.STATE==2||rows.STATE==1) {
	$("#toadd").css("display", "block");
	$(".M_NAME").html(rows.TXZ01);
	$(".M_STANDARD").html(rows.SPEC);
	$(".UNIT").html(rows.MSEHT);
	$(".WULIAO").html(rows.MATNR);
	$(".AMOUNT").html(rows.AMOUNT);
	$("input[name=hidden_XJID]").val(rows.ID);
	$("#bjul").empty();
	$("#toadd").find(".title").find("span:first").html("报价信息");
	$(".top").hide();
	$("#bjul input").attr("readonly", "true").css({
		"border": "none"
	});
		$.ajax({
			type: "post",
			url: bjUrl,
            data:{id:rows.ID},
			success: function(inputdata) {
				var QuotedList = inputdata.QuotedList;
				for(var i = 0; i < QuotedList.length; i++) {
                    bj_index+=1;
					if(QuotedList[i].QUOTED_PRICE == null) {
						QuotedList[i].QUOTED_PRICE = "";
					}
					if( QuotedList[i].SUPPLY_AMOUNT == null){
						QuotedList[i].SUPPLY_AMOUNT = "";
					}
					if( QuotedList[i].COMMENTS == null){
						QuotedList[i].COMMENTS = "";
					}
					if( QuotedList[i].PRODUCT_NAME == null){
						QuotedList[i].PRODUCT_NAME = "";
					}
											
					var add_li = Quoted_li(QuotedList[i].PRODUCT_NAME, QuotedList[i].QUOTED_PRICE, QuotedList[i].SUPPLY_AMOUNT, QuotedList[i].COMMENTS);
					$("#bjul").append($(add_li));
					for(var j = 0; j < QuotedList[i].Hospitals.length; j++) {
						var hj = QuotedList[i].Hospitals[j];
						if(hj.PRICE == null) {
							hj.PRICE = "";
						}
						if(hj.COMMENTS_D == "null"||hj.COMMENTS_D == null) {
							hj.COMMENTS_D = "";
						}
						if(hj.HOSPITAL_NAME == null||hj.HOSPITAL_NAME == "null") {
							hj.HOSPITAL_NAME = "";
						}	
						var add_hos = hospital_div(j + 1, hj.HOSPITAL_NAME, hj.PRICE, hj.COMMENTS_D,hj.COM_FILE_ID,hj.COM_FILE_ID_S_NAME,hj.COM_FILE_ID_NAME,0);						
						$(".bjdelete,.addhosp,.submitbjbtn,.updatebjbtn,.addbj").css("display","none");
						//$("#toadd p").css("display","none");
						$("#bjul").children("li:last").append(add_hos);
						$("#bjul input").attr("readonly", "true").css({
							"border": "none"
						});
					}
					hs[i].innerHTML = "报价" + (i + 1);	
				}
				
			}

		});
	} else {
		$.messager.alert("提示", "您尚未报价！");
	}
}

//删除全部报价
function Removebj(index) {
	var rowIndex = $('#dataTable').datagrid('getRowIndex', rows);
	$('#dataTable').datagrid('selectRow', index);
	var rows = $('#dataTable').datagrid('getSelected');
	if($.trim(rows.QUERY_STATE )== "SCM000103") {
		$.messager.alert("提示", "询价已结束,报价无法删除");
	}else{
		if(rows.STATE !== "0") {
			$.messager.confirm("提示", "您确定删除所有报价记录吗？", function(flag) {
				var ID = rows.ID;
				if(flag) {
					$.ajax({
						type: "post",
						data: {
							ID: ID
						},
						url: DeleteQuoted_Url,
						success: function(removedata) {
							if(removedata.Success == 1) {
								$.messager.alert("提示", "所有报价已删除");
								$('#dataTable').datagrid('load');								
							}
							else{
								if(removedata.Success == 0) {
									$.messager.alert("提示", "删除有误："+removedata.Message);
								} else {
									$.messager.alert("提示", "操作有误，请重新操作！");

								}
							}
						},
						error: function() {
							$.messager.alert("提示", "操作有误，请联系管理员！");
							$('#dataTable').datagrid('load');
						}
					});
				}
			});
		}else{
			$.messager.alert("提示", "您尚未报价");
		}
	}
	
}

//提交报价
function Submitbj() {
	var limessages = "";
	$("#bjul li").each(function(index) {
		if($(this).find("input[name=provider]").val() == "") {
			limessages = "生产厂家不能为空;";
			return false;
		}
		if($(this).find("input[name=bjprice]").val() == "") {
			limessages = "报价价格不能为空;";
			return false;
		}
		if (!/^[+]{0,1}(\d+)$|^[+]{0,1}(\d+\.\d+)$/.test($(this).find("input[name=bjprice]").val())) {
			limessages = "报价价格格式不正确;";
			return false;
		}
		if($(this).find("input[name=bjamount]").val() == "") {
			limessages = "可供数量不能为空;";
			return false;
		}
		if (!/^\d+$/.test($(this).find("input[name=bjamount]").val())) {
			limessages = "可供数量必须是整数;";
			return false;
		}

		if($.trim($(this).find("input[name=provider]").val()) == $.trim($(this).siblings("li").find("input[name=provider]").val())) {
			limessages = "生产厂家不能相同;";
			return false;
		}
		$(this).find(".libottom").each(function(index) {
			var hospvala = $.trim($(this).find("input[name=offerhosp]").val());
			var hosvalb = $.trim($(this).siblings(".libottom").find("input[name=offerhosp]").val());
			if(hospvala != "" || hosvalb != "") {
				if(hospvala == hosvalb) {
					limessages = "医院不能相同;"
					return false;
				}
			}
//			if(hospvala==""){
//				limessages= "医院不能为空;";
//				return false;
//			}
//			if($.trim($(this).find("input[name=offerprice]").val())==""){
//				limessages= "供货价格不能为空;";
//				return false;
//			}
		});
	});
	if(limessages != "") {
		$.messager.alert("提示", limessages);
	} else {
		var liarr = new Array();
		var inputarr = new Array();
		$("#bjul li").each(function() {
			var liobj = new Object();
			liobj.PRODUCT_NAME = $(this).find("input[name=provider]").val();
			liobj.PRODUCT_NAME=liobj.PRODUCT_NAME.replace("（协和指定报价厂家）","");
			liobj.QUOTED_PRICE = $(this).find("input[name=bjprice]").val();
			liobj.SUPPLY_AMOUNT = $(this).find("input[name=bjamount]").val();
			liobj.COMMENTS = $(this).find("input[name=markpro]").val();
			var hosparr = new Array();
			$(this).find(".libottom").each(function() {
				var hospobj = new Object();
				hospobj.HOSPITAL_NAME = $(this).find("input[name=offerhosp]").val();
				hospobj.PRICE = $(this).find("input[name=offerprice]").val()== "" ? 0 :$(this).find("input[name=offerprice]").val();
				hospobj.COMMENTS_D = $(this).find("input[name=markhosp]").val();
				hospobj.DISPLAY_INDEX = $(this).find("input[name=hidden_displayIndex]").val();
                hospobj.COM_FILE_ID = $(this).find("input[name=hide_file_id]").val();
				hosparr.push(hospobj);
			});
			liobj.Hospitals = hosparr;
			liarr.push(liobj);
		});
		liarr = JSON.stringify(liarr);
		$.ajax({
			type: "post",
			url:SaveUrl,
			data: {
				ID: $("input[name=hidden_XJID]").val(),
				data: liarr,
                state:2
			},
			success: function(data) {
				if(data.Success == "1") {
					$.messager.alert("提示", "提交成功");
					$("#toadd").css("display","none");
					$('#dataTable').datagrid('load');
				} else {
					$.messager.alert("提示", "提交失败," + data.Message);
				}
			},
			error: function(keepdata) {

			}
		});
	}
}

//新增报价
$(document).on('click', '#addbj', function() {
	var that = this;
    bj_index+=1;
	var clonediv = $("#bjul").children("li:last");
	clonediv.after(Quoted_li("", "", "", ""));
	var _div = hospital_div(1, "", "", "");
	$("#bjul").children("li:last").append(_div);
	for(var i = 0; i < hs.length; i++) {
		hs[i].innerHTML = "报价" + (i + 1);
	}
});
//删除报价
$(document).on('click', '.bjdelete', function() {
	var that = this;
	if(hs.length > 1) {
		$.messager.confirm("提示", "确定删除该报价吗？", function(flag) {
			if(flag) {
				$.messager.alert("提示", "删除成功！");
				$(that).parent().parent().remove();
				for(var i = 0; i < hs.length; i++) {
					hs[i].innerHTML = "报价" + (i + 1);
				}
			}
		});
	} else if(hs.length <= 1) {
		$.messager.alert("提示", "最少保留一次报价，若全部删除，请在首页列表进行删除")
	}

});
//新增医院
$(document).on('click', '.addhosp', function() {
	var that = this;
	var displayindex = 1;
	var clonediv = $(that).parent().parent().children(".libottom:last");
	if(clonediv.length != 0) {
		displayindex = parseInt(clonediv.children("input[name=hidden_displayIndex]").val()) + 1;
	}
	var _div = hospital_div(displayindex, "", "", "");
	$(that).parent().parent().append(_div);
});
//医院字符串
function hospital_div(displayindex2, hospital_name, hospital_price, hospital_mark,file_id,file_path,file_name,readOnly) {
    var displayindex=bj_index+"_"+displayindex2;
    var  filehtml='';
    if(readOnly==0)//查看报价
    {
       if(file_id!=undefined &&file_id!=null&&file_id!="null" && file_id!='')
       {
          filehtml='<span id="span_namefile'+displayindex+'">发票附件：<a target="_blank" href="' + fileurl + '?CLIENT_NAME='+file_name+'&SERVER_NAME='+file_path+'">'+file_name+'</a></span>';
       }
    }
    else{//我要报价
    if(file_id!=undefined &&file_id!=null&&file_id!="null" && file_id!='')
    {
      filehtml= '<a href="#" class="addfile" id="btnSave'+displayindex+'"  style="display: none;" onclick="UpLoad(\'hide_file_id'+ displayindex+'\',\''+displayindex+'\',\'btnSave'+ displayindex+'\')">上传发票附件</a><input name="hide_file_id" type="hidden" id="hide_file_id'+ displayindex+'" value="' + file_id + '" />';
      filehtml+='<span class="addfile" id="span_namefile'+displayindex+'">发票附件：<a target="_blank" href="' + fileurl + '?CLIENT_NAME='+file_name+'&SERVER_NAME='+file_path+'">'+file_name+'</a><a href="#" class="deleteFile" onclick="deleteAttach(\'span_namefile'+ displayindex+'\',\'hide_file_id'+ displayindex+'\',\'btnSave'+ displayindex+'\');"></a></span>';
    }
    else{
       filehtml= '<a href="#" class="addfile" id="btnSave'+displayindex+'"  onclick="UpLoad(\'hide_file_id'+ displayindex+'\',\''+displayindex+'\',\'btnSave'+ displayindex+'\')"">上传发票附件</a><input name="hide_file_id" type="hidden" id="hide_file_id'+ displayindex+'" />';
       filehtml+='<span id="span_namefile'+displayindex+'"></span>';
    }
    }
	var divhtml = '<div class="libottom"><span>该厂家其他供货医院：<input name="offerhosp" value="' + hospital_name + '" /></span><span>该医院目前供货价格：<input name="offerprice" value="' + hospital_price + '"/></span>RP<span class="mark">备注：<input name="markhosp" value="' + hospital_mark + '"/></span><input name="hidden_displayIndex" value="' + displayindex2 + '" type="hidden"></div>';
	return divhtml.replace(/RP/,filehtml);
}
//报价字符串
function Quoted_li(product_name, product_price, product_amount, mark) {
	var add_li = '<li>' +
		'<div class="lititle">' +
		'<h4></h4>' +
		'<a class="bjdelete" href="javascript:;" >删除该报价</a>' +
		'<a class="addhosp" href="javascript:;">添加更多参考医院</a>' +
		'</div>' +
		'<div class="litop">' +
		'<span>供货厂家：<input name="provider" value="' + product_name + '" placeholder="请输入厂家"/></span>' +
		'<span>报价价格：<input name="bjprice"  value="' + product_price + '" placeholder="请输入价格"/></span>' +
		'<span>可供货数量：<input name="bjamount" value="' + product_amount + '" placeholder="请输入数量"/></span>' +
		'<span>备注：<input value="' + mark + '" name="markpro"/></span>' +
		'</div>' +
		'</li>';
	return add_li;
}


//报价信息
function Mcontent(index) {
	$("#toadd").css("display", "block");
	var rowIndex = $('#dataTable').datagrid('getRowIndex', rows);
	$('#dataTable').datagrid('selectRow', index);
	var rows = $('#dataTable').datagrid('getSelected');
	$(".M_NAME").html(rows.TXZ01);
	$(".M_STANDARD").html(rows.SPEC);
	$(".UNIT").html(rows.MSEHT);
	$(".WULIAO").html(rows.MATNR);
	$(".AMOUNT").html(rows.AMOUNT);
	$("input[name=hidden_XJID]").val(rows.ID);
	$("#bjul").empty();
    return rows;
}
