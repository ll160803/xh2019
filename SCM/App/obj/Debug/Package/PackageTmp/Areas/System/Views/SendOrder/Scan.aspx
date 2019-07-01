<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <script src="<%: Url.Content("~/Scripts/jquery.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/JScriptCommon.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/JScriptIndex.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/Utili.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/jquery.easyui.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Res/easyui/locale/easyui-lang-zh_CN.js") %>" type="text/javascript"></script>
    <link href="<%: Url.Content("~/Res/easyui/themes/icon.css") %>" rel="stylesheet"
        type="text/css" />
    <link href="<%: Url.Content("~/Res/easyui/themes/default/easyui.css") %>" rel="stylesheet"
        type="text/css" />
    <style type="text/css">
        .NameStyle
        {
            width: 100px;
        }
        .ValueStyle
        {
            width: 200px;
            height: 25px;
            float: left;
        }
    </style>
    <title>Scan</title>
    <script language="javascript" type="text/javascript">
    function DoneSupply()
    {
          var gyjh=$("#txt_yhjh").val();
          if ($.trim(gyjh).length == 12) {
              $.post("<%: Url.Content("~/System/SupplyPlan/DoneSupply")%>", {
                    gyjh: $.trim(gyjh),
                    gysAccount:$("#gysAccount").val(),
                    gysName:$("#gysName").val()
                },function(data)
                {
                  var MESS=eval("("+data+")");
                  if(MESS.IsSuccess)
                  {
                       $("#div_msg").html("已确认收货！");
                      // $.messager.alert('操作提示', "收货已确认！", 'info');
                  }
                  else{
                   $("#div_msg").html(MESS.Mess);
                   //  $.messager.alert('操作提示', MESS.Mess, 'info');
                  }
                });
          }
          else
          {
           $("#div_msg").html("请输入正确的供应计划号！");
           //  $.messager.alert('操作提示', "请输入正确的供应计划号！", 'info');
          }
       
    }
    function DoOperation()
    {
    $("#div_msg").empty();
        var gyjh=$("#txt_yhjh").val();
         if ($.trim(gyjh).length == 12) {
            $.post("<%: Url.Content("~/System/SupplyPlan/GetSUPPLYPLANBYGYJH")%>", {
                    GYJH: $.trim(gyjh)
                },function(data)
                {
                 if(data=="F"){
                      $.messager.alert('操作提示', "未能获取供应计划信息", 'info');
                 }
                 else{
                    var supply=eval(data);
                    $("#gysName").val(supply.GYSNAME);
                    $("#div_GYSNAME").html(supply.GYSNAME);
                    $("#div_TXZ01").html(supply.TXZ01);
                    $("#div_MATNR").html(supply.MATNR);
                    $("#div_CHARG").html(supply.CHARG);
                    $("#div_VFDAT").html(dateConvert(supply.VFDAT));
                    $("#div_MENGE").html(supply.MENGE);

                    $("#div_ORDER_MENGE").html(supply.ORDER_MENGE);
                    $("#div_PKG_NUMBER").html(supply.PKG_NUMBER);
                    $("#div_PKG_AMOUNT").html(supply.PKG_AMOUNT);
                    $("#gysAccount").val(supply.GYSACCOUNT);
                 }
                });
          }
    }
//    $(function(){
//        $("#txt_yhjh").on('input',function(e){  
//           var gyjh=$("#txt_yhjh").val();
//         if ($.trim(gyjh).length == 12) {
//            $.post("<%: Url.Content("~/System/SupplyPlan/GetSUPPLYPLANBYGYJH")%>", {
//                    GYJH: $.trim(gyjh)
//                },function(data)
//                {
//                 if(data=="F"){
//                      $.messager.alert('操作提示', "未能获取供应计划信息", 'info');
//                 }
//                 else{
//                    var supply=eval(data);
//                    $("#div_GYSNAME").html(supply.GYSNAME);
//                    $("#div_TXZ01").html(supply.TXZ01);
//                    $("#div_MATNR").html(supply.MATNR);
//                    $("#div_CHARG").html(supply.CHARG);
//                    $("#div_VFDAT").html(dateConvert(supply.VFDAT));
//                    $("#div_MENGE").html(supply.MENGE);
//                    $("#gysAccount").val(supply.GYSACCOUNT);
//                 }
//                });
//          }
//    });  
//      
    
  //  })
    </script>
</head>
<body>
    <input id="gysAccount" type="hidden" />
    <input id="gysName" type="hidden" />
    <div class="easyui-panel" title="收货确认" style="width: 500px; padding: 30px 60px">
        <table cellpadding="5">
            <tr>
                <td>
                    供应计划号:
                </td>
                <td>
                    <input class="easyui-textbox" data-options="prompt:'请输入供应计划号...'" id="txt_yhjh" onchange="DoOperation();"
                        style="width: 200px; height: 19px">
                </td>
            </tr>
            <tr>
                <td>
                    供应商名称:
                </td>
                <td>
                    <span id="div_GYSNAME"></span>
                </td>
            </tr>
            <tr>
                <td>
                    物料名称:
                </td>
                <td>
                    <span id="div_TXZ01"></span>
                </td>
            </tr>
            <tr>
                <td>
                    物料编码:
                </td>
                <td>
                    <span id="div_MATNR"></span>
                </td>
            </tr>
            <tr>
                <td>
                    批号:
                </td>
                <td>
                    <span id="div_CHARG"></span>
                </td>
            </tr>
            <tr>
                <td>
                    有效期:
                </td>
                <td>
                    <span id="div_VFDAT"></span>
                </td>
            </tr>
            <tr>
                <td>
                    数量:
                </td>
                <td>
                    <span id="div_MENGE"></span>
                </td>
            </tr>
            <tr>
                <td>
                    订单数量:
                </td>
                <td>
                    <span id="div_ORDER_MENGE"></span>
                </td>
            </tr>
            <tr>
                <td>
                    箱数:
                </td>
                <td>
                    <span id="div_PKG_NUMBER"></span>
                </td>
            </tr>
            <tr>
                <td>
                    包装数量:
                </td>
                <td>
                    <span id="div_PKG_AMOUNT"></span>
                </td>
            </tr>
        </table>
        <div style="text-align: center;">
            <a href="#" class="easyui-linkbutton" iconcls="icon-ok" onclick="DoneSupply();" style="height: 24px">
                收货确认</a>
        </div>
        <span id="div_msg" style="color: Red;"></span>
    </div>
</body>
</html>
