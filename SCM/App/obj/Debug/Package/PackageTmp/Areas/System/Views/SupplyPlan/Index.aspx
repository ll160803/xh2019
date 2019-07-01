<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    供应计划
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="addAttach" class="easyui-dialog" title="附件上传" style="width: 400px; height: 120px;
        padding: 10px" data-options="iconCls:'icon-save',closed:true,buttons: [{  
					text:'上传',
					iconCls:'icon-ok',
					handler:function(){
						fileUploadSubPlan();
					}
				}]">
        <form id="formUpload" method="post" enctype="multipart/form-data" action='<%:Url.Content("~/Codes/UploadSupplyPlan.ashx") %>'>
        <input id="fileExcel" name="fileExcel" type="file" style="width: 300px;" class="easyui-validatebox"
            validtype="length[1,100]" />
        </form>
    </div>
    <div id="dlg" class="easyui-dialog" title="创建供应计划" data-options="iconCls:'icon-save',closed:true,buttons: [{
					text:'保存',
					iconCls:'icon-ok',
					handler:function(){
						saveSubPlan();
					}
				},{
					text:'关闭',
					handler:function(){
						CloseDig('dlg');
					}
				}]" style="width: 800px; height: 280px; padding: 10px">
        <form id="supplyPlan" method="post">
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    交货数量：
                </div>
                <div class="trendrt">
                    <input name="MENGE" id="C_MENGE" class="easyui-validatebox easyui-numberbox" required="true"
                        data-options="min:0.001,precision:3,onChange:function(newV,oldV){
                           SetPKG_AMOUNT_C(newV,oldV);
                        }" title="请输入非负数" />
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    批次编号：
                </div>
                <div class="trendrt">
                    <input name="CHARG" id="C_CHARG" class="easyui-combobox" required="true" data-options="valueField: 'id',textField: 'text',required:true,editable:false" />
                </div>
            </div>
            <div class="centerside">
                <div class="trendlf">
                    发票条码：
                </div>
                <div class="trendrt">
                    <input name="FPBM" id="C_FPBM" class="easyui-validatebox textbox" required="true"
                        onchange="SettingCreateFP();" />
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    生产日期：
                </div>
                <div class="trendrt">
                    <input name="HSDAT" id="C_HSDAT" />
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    有效日期：
                </div>
                <div class="trendrt">
                    <input name="VFDAT" id="C_VFDAT" required="true" />
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    发票金额：
                </div>
                <div class="trendrt">
                    <input name="FPJR" id="C_FPJR" class="easyui-validatebox easyui-numberbox" data-options="min:0.01,precision:2,disabled:true"
                        title="请输入非负数" required="true" />
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    开票日期：
                </div>
                <div class="trendrt">
                    <input name="FPRQ" id="C_FPRQ" required="true" />
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    发票号码：
                </div>
                <div class="trendrt">
                    <input name="FPHM" id="C_FPHM" class="easyui-validatebox textbox" data-options="validType:'length[1,15]'"
                        required="true" />
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    包装数量
                </div>
                <div class="trendrt">
                    <input name="PKG_AMOUNT" id="C_PKG_AMOUNT" class="easyui-validatebox easyui-numberbox"
                        required="true" data-options="min:1,onChange:function(newV,oldV){
                           SetPKG_AMOUNT_C2(newV,oldV);
                        }" title="请输入非负数" />
                </div>
            </div>
        </div>
        <div class="laytrnew">
        <div class="leftside">
                <div class="trendlf">
                    缺货原因：
                </div>
                <div class="trendrt">
                    <select class="easyui-combobox" name="OUT_CAUSE" id="C_Out_Cause" style="width: 135px;">
                <option value=""> </option>
                <option value="1">库存不足</option>
                <option value="2">厂家停产</option>
                <option value="3">补足上批交货</option>
                <option value="4">批次拆分</option>
            </select>
                </div>
            </div>
        <div class="centreside">
                <div class="trendlf">
                    预计补货日期：
                </div>
                <div class="trendrt">
                    <input name="OUT_DATE" id="C_Out_Date" />
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    箱数：
                </div>
                <div class="trendrt">
                    <input name="PKG_NUMBER" id="C_PKG_NUMBER" class="easyui-validatebox easyui-numberbox"
                        required="true" data-options="min:0" title="请输入非负数" />
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="LeftTwoside">
                <div class="LeftTwotrendlf">
                    备注：
                </div>
                <div class="LeftTwotrendrt">
                    <input name="COMMENTS" id="C_COMMENTS" data-options="validType:'length[0,200]'" style="width: 384px;" />
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
    
                </div>
                <div class="trendrt">
                
                </div>
            </div>
        </div>
        <input type="hidden" name="GYJH" id="GYJH" /><%--采购凭证项目号--%>
        <input type="hidden" name="EBELN" id="EBELN" />
        <input type="hidden" name="LIFNR" id="LIFNR" />
        <input type="hidden" name="MATNR" id="MATNR" />
        <input type="hidden" name="TXZ01" id="TXZ01" />
        <input type="hidden" name="WERKS" id="WERKS" />
        <input type="hidden" name="LGORT" id="LGORT" />
        <input type="hidden" name="LGORTNAME" id="LGORTNAME" />
        <input type="hidden" name="NETPR" id="NETPR" />
        <input type="hidden" name="BEDAT" id="BEDAT" />
        <input type="hidden" name="MEINS" id="MEINS" />
        <input type="hidden" name="MSEHT" id="MSEHT" />
        <input type="hidden" name="WERKST" id="WERKST" />
        <input type="hidden" name="ORDER_MENGE" id="ORDER_MENGE" />
        <input type="hidden" name="EEIND" id="EEIND" />
        </form>
    </div>
    <div id="editDlg" class="easyui-dialog" title="编辑供应计划" data-options="iconCls:'icon-save',closed:true,buttons: [{
					text:'保存',
					iconCls:'icon-ok',
					handler:function(){
						editSubPlan();
					}
				},{
					text:'关闭',
					handler:function(){
						CloseDig('editDlg');
					}
				}]" style="width: 800px; height: 280px; padding: 10px">
        <form id="editSubPlan" method="post">
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    交货数量：
                </div>
                <div class="trendrt">
                    <input name="MENGE" id="MENGE" class="easyui-validatebox easyui-numberbox" required="true"
                        data-options="min:0.001,precision:3,onChange:function(newV,oldV){
                           SetPKG_AMOUNT(newV,oldV);
                        }" title="请输入非负数" />
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    批次编号：
                </div>
                <div class="trendrt">
                    <input name="CHARG" id="CHARG" class="easyui-combobox" required="true" data-options="valueField: 'id',textField: 'text',required:true,editable:false" />
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    发票条码：
                </div>
                <div class="trendrt">
                    <input name="FPBM" id="FPBM" class="easyui-validatebox textbox" onchange="SettingNumber();"
                        required="true" />
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    生产日期：
                </div>
                <div class="trendrt">
                    <input name="HSDAT" id="HSDAT" />
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    有效日期：
                </div>
                <div class="trendrt">
                    <input name="VFDAT" id="VFDAT" required="true" />
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    发票金额：
                </div>
                <div class="trendrt">
                    <input name="FPJR" id="FPJR" class="easyui-validatebox easyui-numberbox" data-options="min:0.01,precision:2,disabled:true"
                        title="请输入非负数" required="true" />
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    开票日期：
                </div>
                <div class="trendrt">
                    <input name="FPRQ" id="FPRQ" required="true" />
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    发票号码：
                </div>
                <div class="trendrt">
                    <input name="FPHM" id="FPHM" class="easyui-validatebox textbox" data-options="validType:'length[1,15]'"
                        required="true" />
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    包装数量
                </div>
                <div class="trendrt">
                    <input name="PKG_AMOUNT" id="PKG_AMOUNT" class="easyui-validatebox easyui-numberbox"
                        required="true" data-options="min:1,onChange:function(newV,oldV){
                           SetPKG_AMOUNT_C2(newV,oldV);
                        }" title="请输入非负数" />
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    缺货原因：
                </div>
                <div class="trendrt">
                    <select class="easyui-combobox" name="OUT_CAUSE" id="Out_Cause" style="width: 135px;">
                <option value=""></option>
                <option value="1">库存不足</option>
                <option value="2">厂家停产</option>
                <option value="3">补足上批交货</option>
                <option value="4">批次拆分</option>
            </select>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    预计补货日期：
                </div>
                <div class="trendrt">
                    <input name="OUT_DATE" id="Out_Date" />
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    箱数：
                </div>
                <div class="trendrt">
                    <input name="PKG_NUMBER" id="PKG_NUMBER" class="easyui-validatebox easyui-numberbox"
                        required="true" data-options="min:0" title="请输入非负数" />
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="LeftTwoside">
                <div class="LeftTwotrendlf">
                    备注：
                </div>
                <div class="LeftTwotrendrt">
                    <input name="COMMENTS" id="COMMENTS" data-options="validType:'length[0,200]'" style="width: 384px;" />
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    
                </div>
                <div class="trendrt">
                    
                </div>
            </div>
        </div>
        <input id="ID" type="hidden" name="ID" />
        </form>
    </div>
    <div id="tb">
        <div>
            <a href="#" class="easyui-linkbutton" onclick="flexiCreate();" iconcls="icon-add"
                plain="true">创建供应计划</a> <a href="<%:Url.Content("~/Up/供应计划模板.xls") %>" class="easyui-linkbutton"
                    onclick="javascript:void(0);" iconcls="icon-save" plain="true">下载模板</a>
            <a href="#" class="easyui-linkbutton" onclick="flexiExport();" iconcls="icon-save"
                plain="true">导入计划</a>
            采购时间:
            <input class="easyui-datebox" id="lastDay" value="<%:ViewBag.LastDay%>" style="width: 100px" />
            -
            <input class="easyui-datebox" id="nowDay" value="<%:ViewBag.NowDay %>" style="width: 100px" />
            订单编号：<input class="easyui-textbox" id="txtEBELN" style="width: 100px" />
            药品名称：<input class="easyui-textbox" id="txtName" style="width: 100px" />
            院区：
            <select class="easyui-combobox" id="com_WERKST" style="width: 100px;">
                <option value="全部">全部</option>
                <option value="武汉协和医院-本部">武汉协和医院-本部</option>
                <option value="武汉协和医院-西院">武汉协和医院-西院</option>
                <option value="武汉协和医院-肿瘤中心">武汉协和医院-肿瘤中心</option>
            </select>
            药品类别：
            <select class="easyui-combobox" id="com_BKLAS" style="width: 100px;">
                <option value="全部">全部</option>
                <option value="3000">西药</option>
                <option value="3001">中成药</option>
                <option value="3002">中草药</option>
            </select>
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="<%: Url.Content("~/Scripts/datagrid-detailview.js") %>" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
    function SetPKG_AMOUNT(newV,oldV)
    {
       var MENGE=newV;
       var PKG_AMOUNT=$("#PKG_AMOUNT").numberbox('getValue');
        if($.trim(MENGE).length>0)
       {
           var price=$("#NETPR").val();
           var fpje=parseFloat(price)*parseFloat(MENGE);
           $("#FPJR").numberbox('setValue',fpje.toFixed(2));
       }
       if($.trim(MENGE).length>0||$.trim(PKG_AMOUNT).length>0)
       {
          if($.trim(PKG_AMOUNT)==0)
          {
             $("#PKG_NUMBER").numberbox("setValue",0);
          }
          else{
        var PKG_NUMBER=  Math.floor(parseFloat(MENGE)/parseFloat(PKG_AMOUNT));
        $("#PKG_NUMBER").numberbox("setValue",PKG_NUMBER);
        }

       }
    }
        function SetPKG_AMOUNT_C(newV,oldV)
    {
       var MENGE=newV;
       var PKG_AMOUNT=$("#C_PKG_AMOUNT").numberbox('getValue');
       if($.trim(MENGE).length>0)
       {
           var price=$("#NETPR").val();
           var fpje=parseFloat(price)*parseFloat(MENGE);
           $("#C_FPJR").numberbox('setValue',fpje.toFixed(2));
       }

       if($.trim(MENGE).length>0||$.trim(PKG_AMOUNT).length>0)
       {
           if($.trim(PKG_AMOUNT)==0)
          {
             $("#C_PKG_NUMBER").numberbox("setValue",0);
          }
          else{
        var PKG_NUMBER=  Math.floor(parseFloat(MENGE)/parseFloat(PKG_AMOUNT));
        $("#C_PKG_NUMBER").numberbox("setValue",PKG_NUMBER);
        }

       }
    }
     function SetPKG_AMOUNT2(newV,oldV)
    {
       var MENGE=$("#MENGE").numberbox('getValue');
       var PKG_AMOUNT=newV;
        if($.trim(MENGE).length>0)
       {
           var price=$("#NETPR").val();
           var fpje=parseFloat(price)*parseFloat(MENGE);
           $("#FPJR").numberbox('setValue',fpje.toFixed(2));
       }
       if($.trim(MENGE).length>0||$.trim(PKG_AMOUNT).length>0)
       {
          if($.trim(PKG_AMOUNT)==0)
          {
             $("#PKG_NUMBER").numberbox("setValue",0);
          }
          else{
        var PKG_NUMBER=  Math.floor(parseFloat(MENGE)/parseFloat(PKG_AMOUNT));
        $("#PKG_NUMBER").numberbox("setValue",PKG_NUMBER);
        }

       }
    }
        function SetPKG_AMOUNT_C2(newV,oldV)
    {
        var MENGE=$("#C_MENGE").numberbox('getValue');
       var PKG_AMOUNT=newV;
       if($.trim(MENGE).length>0)
       {
           var price=$("#NETPR").val();
           var fpje=parseFloat(price)*parseFloat(MENGE);
           $("#C_FPJR").numberbox('setValue',fpje.toFixed(2));
       }

       if($.trim(MENGE).length>0||$.trim(PKG_AMOUNT).length>0)
       {
           if($.trim(PKG_AMOUNT)==0)
          {
             $("#C_PKG_NUMBER").numberbox("setValue",0);
          }
          else{
        var PKG_NUMBER=  Math.floor(parseFloat(MENGE)/parseFloat(PKG_AMOUNT));
        $("#C_PKG_NUMBER").numberbox("setValue",PKG_NUMBER);
        }

       }
    }

    function SettingNumber()
    {
        var Fpbm=$("#FPBM").val();
        if($.trim(Fpbm).length>0)
        {
           var arr=$.trim(Fpbm).split(",");
           for(var i=0;i<arr.length;i++)
           {
              if(i==3)
              {
                 $("#FPHM").val(arr[i]);
              }
              if(i==4)
              {
              //  var jr=parseFloat(arr[i]);
              //  var fpjr=jr*1.17;
              //  $("#FPJR").numberbox("setValue",fpjr.toFixed(2));
              
              }
               if(i==5)
              {
                var year=arr[i].substr(0,4);
                var month=arr[i].substr(4,2);
                var day=arr[i].substr(6,2);
                $("#FPRQ").datebox('setValue',year+"-"+month+"-"+day);
               
              }
           }
        }
    }
    function SettingCreateFP()
    {
        var Fpbm=$("#C_FPBM").val();
        if($.trim(Fpbm).length>0)
        {
           var arr=$.trim(Fpbm).split(",");
           for(var i=0;i<arr.length;i++)
           {
              if(i==3)
              {
                 $("#C_FPHM").val(arr[i]);
              }
              if(i==4)
              {
//                var jr=parseFloat(arr[i]);
//                var fpjr=jr*1.17;
//                $("#C_FPJR").numberbox("setValue",fpjr.toFixed(2));
              
              }
               if(i==5)
              {
              var year=arr[i].substr(0,4);
              var month=arr[i].substr(4,2);
               var day=arr[i].substr(6,2);
                $("#C_FPRQ").datebox('setValue',year+"-"+month+"-"+day);
              }
           }
        }
    }

    function CloseDig(id)
    {
       $("#"+id).dialog('close');
    }

        var data_opt = {
            title: '采购订单列表',
            idField: 'ID',
            treeField: "ID",
            nowrap: false,
            singleSelect: true,
            pagination: true,
            rownumbers: true,
            sortName: 'EBELN desc,EBELP',
            sortOrder: 'asc',
            rowStyler:function(index,row){
             if ((row.SUREMENGE!=row.MENGE)&&CompareDate(row.BEDAT)==true) {
             console.log("SUREMENGE:" + row.SUREMENGE);
             console.log("MENGE:" + row.MENGE);
                return 'background-color:red;';
               }
             }
        };
        var cols = [//采购订单
            [
                {
                    field: 'ID',
                    title: 'ID',
                    width: 120,
                    hidden: true
                }, {
                    field: 'EBELN',
                    title: '采购订单编号',
                    halign: 'center',
                    align: 'center',
                    width: 120,
                    sortable:true
                }
                , {
                    field: 'EBELP',
                    title: '项目编号',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                    sortable:true
                }, {
                    field: 'LIFNR',
                    title: '供应商账号',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'MATNR',
                    title: '物料号',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'TXZ01',
                    title: '物料描述',
                    halign: 'center',
                    align: 'center',
                    width: 200,
                    sortable:true
                }, {
                    field: 'WERKST',
                    title: '院区',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                    sortable:true
                }, {
                    field: 'MENGE',
                    title: '数量',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                },{
                    field: 'ALLMENGE',
                    title: '供应数量',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                },{
                    field: 'SUREMENGE',
                    title: '收货数量',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'MSEHT',
                    title: '计量单位',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true

                }, {
                    field: 'NETPR',
                    title: '净价',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'EINDT',
                    title: '交货日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'BEDAT',
                    title: '采购订单日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }
                ]
                ];
//        var toolbar = [//采购订单工具栏

//           {
//           text: '创建供应计划',
//           iconCls: 'icon-add',
//           handler: function () {
//               return flexiCreate();
//           }
//       }];
var toolbar='#tb';
        var sub_toolBar = "";
    var sub_cols = [//采购订单
            [
                {
                    field: 'ID',
                    title: 'ID',
                    width: 120,

                    hidden: true
                }, {
                    field: 'CODE',
                    title: '供应计划号',
                    halign: 'center',
                    align: 'center',
                    width: 120
                }, {
                    field: 'MENGE',
                    title: '交货数量',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'CHARG',
                    title: '批次',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'HSDAT',
                    title: '生产日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                }, {
                    field: 'VFDAT',
                    title: '有效日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                }, {
                    field: 'FPHM',
                    title: '发票号码',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'FPJR',
                    title: '发票金额',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'FPRQ',
                    title: '开票日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                }, {
                    field: 'PKG_AMOUNT',
                    title: '包装数量',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'PKG_NUMBER',
                    title: '箱数',
                    halign: 'center',
                    align: 'center',
                    width: 80
                },
                {
                    field: 'isk',
                    title: '编辑',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rowData) {
                      if(rowData.STATUS==0)
                      {
                      var COMMENTS=rowData.COMMENTS;
                      if(COMMENTS==null){COMMENTS=""};
                      var HSDate=rowData.HSDAT;
                      if(HSDate==null) {HSDate=""};
                        return "<a class='details' href='#' onclick=EditSubPlan('" + rowData.ID + "','" + rowData.MENGE + "','" + $.trim(rowData.CHARG) + "','" + $.trim(rowData.MEINS) + "','" + HSDate + "','" + rowData.VFDAT + "','" + escape(rowData.FPBM) + "','" + escape(rowData.FPHM) + "','" + rowData.FPJR + "','" + rowData.FPRQ + "','" + rowData.PKG_AMOUNT + "','" + rowData.PKG_NUMBER + "','" + escape(COMMENTS) + "','" + rowData.NETPR + "','" + rowData.MATNR + "','" + rowData.OUT_CAUSE + "','" + rowData.OUT_DATE + "')> </a>";
                    }
                    else{
                        return "";
                    }
                    }

                }, 
                {
                    field: 'isk2',
                    title: '删除',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rowData) {
                    if(rowData.STATUS==0)
                      {
                        return "<a class='canclels' href='#' onclick=DeleteSubPlan('" + rowData.ID + "')> </a>";
                        }
                        else
                        {
                          return "";
                        }
                    }

                },
                {
                    field: 'FREEUSE3',
                    title: '质量检验证书',
                    width: 80,
                    formatter: function(value, rec) {
                        if (value != null) {
                            return "<a href='<%: Url.Content("~/System/SCM_D_MATER/DownFile")%>?CLIENT_NAME=&SERVER_NAME="+value+"' class='searchcls'  ></a>";
                        }
                    }
                },
                {
                    field: 'OUT_CAUSE',
                    title: '缺货原因',
                    width: 120
                },
                {
                    field: 'OUT_DATE',
                    title: '预计补货日期',
                    width: 80,
                    formatter: function (value, rec) {
//                       if(value = '/Date(-62135596800000)/')
//                       {
//                            return "";
//                       }
                        if (value) {
                        if (dateConvert(value) == "1-01-01")
                        {
                         return "";
                        }
                        else
                        {
                         return dateConvert(value);
                        }
                        }
                    }
                }
                ]
                ];

    function sub_data_opt(index, row) {
        var option = {
            idField: 'ID',
            singleSelect: true,
            treeField: 'ID',
            sortName: 'CODE',
            queryParams: {
                EBELN: row.EBELN,
                EBELP: row.EBELP
            },
            onLoadSuccess: function () {
                WC_Common.Format.IconButton('.details', 'icon-edit');
                WC_Common.Format.IconButton('.canclels', 'icon-cancel');
                WC_Common.Format.IconButton('.searchcls', 'icon-search');
            }
        };
        return option;
    }

    $(function () {
        WCKJ.Format.SubGrid("flexigridData", toolbar, "<%: Url.Content("~/System/SupplyPlan/GetData")%>", cols, data_opt, "", "<%: Url.Content("~/System/SupplyPlan/GetSubPlanData")%>", sub_toolBar, sub_cols, sub_data_opt, "");
        resizeDataGrid(false);
    });
    //导航到创建的按钮
    function flexiCreate() {

        var arr = $('#flexigridData').datagrid('getSelections');

        if (arr.length == 1) {
            //清空编辑过的数据
            $("#C_MENGE").numberbox('reset');
            $("#C_CHARG").combobox('setValue','');
            $("#C_FPBM").val("");
            $("#C_FPRQ").datebox('setValue','');
            $("#C_VFDAT").datebox('setValue','');
            $("#C_HSDAT").datebox('setValue','');
            $("#C_FPHM").val("");
            $("#C_FPJR").numberbox('reset');
            $("#C_PKG_AMOUNT").numberbox('reset');
            $("#C_PKG_NUMBER").numberbox('reset');
            $("#C_COMMENTS").val("");
            $('#C_Out_Cause').combobox('select', '');
            $('#C_Out_Cause').combobox('setText', ''); 
            $("#C_Out_Date").datebox('setValue','');

            //---采购订单
            $("#GYJH").val(arr[0].EBELP); //采购凭证项目号
            $("#EBELN").val(arr[0].EBELN); //采购订单号
            $("#LIFNR").val(arr[0].LIFNR);
            $("#MATNR").val(arr[0].MATNR);
            $("#TXZ01").val(arr[0].TXZ01);
            $("#WERKS").val(arr[0].WERKS);
            $("#WERKST").val(arr[0].WERKST);
            $("#LGORT").val(arr[0].LGORT);
            $("#LGORTNAME").val(arr[0].NAME);
            $("#NETPR").val(arr[0].NETPR);
            $("#EEIND").val(arr[0].EINDT);//采购日期
            $("#BEDAT").val(arr[0].BEDAT);
            $("#MEINS").val(arr[0].MEINS);
            $("#MSEHT").val(arr[0].MSEHT);
            $("#ORDER_MENGE").val(arr[0].MENGE);

             var combourl="<%: Url.Content("~/System/SCM_D_REPORT/GetCharge/")%>"+arr[0].MATNR;
            $('#C_CHARG').combobox('reload', combourl);  

            $("#dlg").dialog('open');

        } else {
            $.messager.alert('操作提示', '请选择一条采购订单数据!', 'warning');
        }

        return false;
    }
    function EditSubPlan(ID, MENGE, CHARG, MEINS, HSDAT, VFDAT,FPBM, FPHM, FPJR, FPRQ,PKG_AMOUNT,PKG_NUMBER,COMMENTS,NETPR,MATNR,OUT_CAUSE,OUT_DATE) {
        $("#NETPR").val(NETPR);//单价
        $("#ID").val(ID);
        $("#MENGE").numberbox('setValue',MENGE);
       
        if(HSDAT!="")
        {
         $("#HSDAT").datebox('setValue', dateConvert(HSDAT));
        }
        else{
           $("#HSDAT").datebox('setValue','');
        }
        if(VFDAT!=null)
        {
        $("#VFDAT").datebox('setValue',dateConvert(VFDAT));
        }
        else{
           $("#VFDAT").datebox('setValue','');
        }
        $("#FPHM").val(unescape(FPHM));
        $("#FPBM").val(unescape(FPBM));
        $("#FPJR").val(FPJR);
        $("#FPRQ").datebox('setValue', dateConvert(FPRQ));
        $("#PKG_AMOUNT").numberbox('setValue',PKG_AMOUNT);
        $("#PKG_NUMBER").numberbox('setValue',PKG_NUMBER);
        $("#COMMENTS").val(unescape(COMMENTS));

        var combourl="<%: Url.Content("~/System/SCM_D_REPORT/GetCharge/")%>"+MATNR;
        $('#CHARG').combobox('reload', combourl);  
        $("#CHARG").combobox('setValue',CHARG);
        if(OUT_DATE!="" && OUT_DATE!=null && OUT_DATE != "/Date(-62135596800000)/")
        {
         $("#Out_Date").datebox('setValue', dateConvert(OUT_DATE));
        }
        else{
           $("#Out_Date").datebox('setValue','');
        }
        //$("#OUT_CAUSE").val(OUT_CAUSE);
        if(OUT_CAUSE!="" && OUT_CAUSE!="null")
        {
            //$("#OUT_CAUSE").find("option[text='"+ OUT_CAUSE +"']").attr("selected",true);
            $('#Out_Cause').combobox('select', OUT_CAUSE);
        }
        else
        {
            $('#Out_Cause').combobox('select', '');
            $('#Out_Cause').combobox('setText', '');  
        }
        $("#editDlg").dialog('open');
    }
    function DeleteSubPlan(ID) {
        $.messager.confirm('操作提示', "确认删除这 1 项吗？", function (r) {
            if (r) {
                $.post("<%: Url.Content("~/System/SupplyPlan/Delete")%>", {
                    query: ID
                }, function (data) {
                     var res=eval("("+data+")");
                    if (res == "OK") {
                        //移除删除的数据

                        $.messager.alert('操作提示', '删除成功!', 'info');
                        $("#flexigridData").datagrid("reload");
                        $("#flexigridData").datagrid("clearSelections");
                    } else {
                        if (res == "") {
                            $.messager.alert('操作提示', '删除失败!请查看该数据与其他模块下的信息的关联，或联系管理员。', 'info');
                        } else {
                            $.messager.alert('操作提示', res, 'info');
                        }
                    }
                });
            }
        });
    }
//    function CompareDate(beginDate)
//    {
//      var d1=new Date(beginDate).getTime();
//       var time = new Date();
//       time.setDate(time.getDate() - time.getDay());
//      var d2= time.getTime();
//       if(d1<d2)
//       {
//          return true;
//       }
//       return false;
//    }
function CompareDate(beginDate)
    {
      var d1=new Date(addDate(beginDate,7)).getTime();
       var time = new Date();
       //time.setDate(time.getDate() - time.getDay());
      var d2= time.getTime();
       if(d1<d2)
       {
          return true;
       }
       return false;
    }

    function addDate(date, days) {
                if(days == undefined || days == '') {
                    days = 1;
                }
                var date = new Date(date);
                date.setDate(date.getDate() + days);
                var month = date.getMonth() + 1;
                var day = date.getDate();
                var mm = "'" + month + "'";
                var dd = "'" + day + "'";
                
                //单位数前面加0
                if(mm.length == 3) {
                    month = "0" + month;
                }
                if(dd.length == 3) {
                    day = "0" + day;
                }

                var time = date.getFullYear() + "-" + month + "-" + day
                return time;
            }
    </script>
    <script language="javascript" type="text/javascript">
    
    var flagSubmit=0;//点击按钮后 防止连击
        $(function () {

            $("#HSDAT").datebox({});
            $("#VFDAT").datebox({});
            $("#FPRQ").datebox({});
            $("#Out_Date").datebox({});
            $("#C_HSDAT").datebox({});
            $("#C_VFDAT").datebox({});
            $("#C_FPRQ").datebox({});
            $("#C_Out_Date").datebox({});
        });
        function saveSubPlan() {
            if(flagSubmit==1)
            {
               return false;
            }
            else
            {
              flagSubmit=1;
            $("#supplyPlan").form("submit", {
                url: "<%: Url.Content("~/System/SupplyPlan/Create")%>",
                dataType: "json",
                onsubmit: function () {
                    return (this).form("validate");
                    
                },
                success: function (data) {
                 flagSubmit=0;
                 var msg = eval(data).substring(0, 1);
                    if (msg == "S") {
                        $.messager.alert("提示信息", "创建成功");
                        $("#dlg").dialog("close");
                       
                         btnSearch();
                        $("#flexigridData").datagrid("clearSelections");
                       }
                    else {
                        $.messager.alert("提示信息", eval(data));
                    }
                }
            });
            setTimeout(SetFlagSubmit,500);
            }
        }
         function editSubPlan() {
          if(flagSubmit==1)
            {
               return false;
            }
            else
            {
            flagSubmit=1;
            $("#editSubPlan").form("submit", {
                url: "<%: Url.Content("~/System/SupplyPlan/Edit")%>",
                dataType:"json",
                onsubmit: function () {
                    return (this).form("validate");
                },
                success: function (data) {
                flagSubmit=0;
                 var msg = eval(data).substring(0, 1);
                    if (msg == "S") {
                        $.messager.alert("提示信息", "保存成功");
                        $("#editDlg").dialog("close");
                         btnSearch();
                       }
                    else {
                        $.messager.alert("提示信息", eval(data));
                    }
                }
            });
            setTimeout(SetFlagSubmit,500);
            }
        }
        function SetFlagSubmit()
        {
          flagSubmit=0;
        }
        function btnSearch()
        {
            $("#flexigridData").datagrid("reload",{
                 startDate:$("#lastDay").datebox('getValue'),
                 endDate:$("#nowDay").datebox('getValue'),
                 txtName:$("#txtName").val(),
                 txtEBELN:$("#txtEBELN").val(),
                 WERKST:$("#com_WERKST").combobox('getValue'),
                 BKLAS:$("#com_BKLAS").combobox('getValue')

            });
            $("#flexigridData").datagrid("clearSelections");
        }
        function fileUploadSubPlan()
        {
            var file=$("#fileExcel").val();
            var ext = file.slice(file.lastIndexOf(".")+1).toLowerCase();  
            if(ext=="xls"||ext=="xlsx")
            {
            $.messager.progress({
    title: '请稍等...',
    msg: '数据处理中...',
    text: '进度.......'
});
             $("#formUpload").form("submit", {
               // url: "<%: Url.Content("~/System/SupplyPlan/ExportSupply")%>",
                dataType:"json",
                onsubmit: function () {
                   
                },
                success: function (data) {
               $.messager.progress('close');
                    if (data == "") {
                        $.messager.alert("提示信息", "上传成功");
                        $("#addAttach").dialog("close");
                       }
                    else {
                        $.messager.alert("提示信息", data);
                    }
                }
            });
            }
            else{
                $.messager.alert("提示信息", "请选择文件");
            }
        }
        function flexiExport()
        {
           $("#addAttach").dialog("open");
        }
                function GeneratePlan() {
            var rows = $('#flexigridData').datagrid('getSelections');
             if (rows.length == 0) {
                $.messager.alert('操作提示', '请选择打印数据!', 'warning');
                return false;
            }
            var arr = [];

             for (var i = 0; i < rows.length; i++) {
                arr.push(rows[i].ID);
                }
          openPostWindow('<%: Url.Content("~/System/SupplyPlan/PrintPlan/")%>',arr.join(','),'打印');
              
             //  window.open('<%: Url.Content("~/Home/PrintTest/")%>'+rows[0].ID,'打印','height=400,width=500,status=yes,toolbar=yes,scrollbars,menubar=no,location=no');
           
        };
        $.format = function(source, params) {
    if (arguments.length == 1) return function() {
        var args = $.makeArray(arguments);
        args.unshift(source);
        return $.format.apply(this, args);
    };
    if (arguments.length > 2 && params.constructor != Array) {
        params = $.makeArray(arguments).slice(1);
    }
    if (params.constructor != Array) {
        params = [params];
    }
    $.each(params,
    function(i, n) {
        source = source.replace(new RegExp("\\{" + i + "\\}", "g"), n);
    });
    return source;
};
  function openPostWindow(url, data, name) {

            var form = $("<form></form>");
            form.live('submit', function () {
                openWindow(name);
            });
            form.attr('action', url);
            form.attr('method', 'post');
            var input1 = $("<input type='hidden' name='content' />");
            input1.attr('value', data);
            form.append(input1);
            form.appendTo("body");
            form.css('display', 'none');
            form.submit();


        }
    </script>
</asp:Content>
