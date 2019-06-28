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
        <input id="fileExcel" name="fileExcel" type="file" style="width: 300px;"
            class="easyui-validatebox" validtype="length[1,100]" />
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
				}]" style="width: 800px; height: 250px; padding: 10px">
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
                    <input name="CHARG" id="C_CHARG" class="easyui-validatebox textbox" required="true"
                        data-options="validType:'length[1,20]'" />
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
                    箱数：
                </div>
                <div class="trendrt">
                    <input name="PKG_NUMBER" id="C_PKG_NUMBER" class="easyui-validatebox easyui-numberbox"
                        required="true" data-options="min:0" title="请输入非负数" />
                </div>
            </div>
        </div>
        <input type="hidden" name="FREEUSE2" id="FREEUSE2" /><%--采购凭证项目号--%>
        <input type="hidden" name="FREEUSE1" id="FREEUSE1" /><%--备注--%>
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
				}]" style="width: 800px; height: 250px; padding: 10px">
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
                    <input name="CHARG" id="CHARG" data-options="validType:'length[1,20]'" class="easyui-validatebox textbox" required="true" />
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
                        onchange="SetPKG_AMOUNT();" required="true" data-options="min:1,onChange:function(newV,oldV){
                           SetPKG_AMOUNT2(newV,oldV);
                        }" title="请输入非负数" />
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
                    箱数：
                </div>
                <div class="trendrt">
                    <input name="PKG_NUMBER" id="PKG_NUMBER" class="easyui-validatebox easyui-numberbox"
                        required="true" data-options="min:0" title="请输入非负数" />
                </div>
            </div>
        </div>
        <input id="ID" type="hidden" name="ID" />
        </form>
    </div>
    <div id="tb">
        <div>
            <a href="#" class="easyui-linkbutton" onclick="flexiCreate();" iconcls="icon-add"
                plain="true">创建供应计划</a>  采购时间:
            <input class="easyui-datebox" id="lastDay" value="<%:ViewBag.LastDay%>" style="width: 100px" />
            -
            <input class="easyui-datebox" id="nowDay" value="<%:ViewBag.NowDay %>" style="width: 100px" />
            订单编号：<input class="easyui-textbox" id="txtEBELN" style="width: 100px" />
            药品名称：<input class="easyui-textbox" id="txtName" style="width: 100px" />
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
            fit:true,
            nowrap: false,
            singleSelect: true,
            pagination: true,
            rownumbers: true,
            sortName: 'CREATE_TIME desc,ID ',
            sortOrder: 'desc',
            rowStyler:function(index,row){
             if ((row.SUREMENGE!=row.MENGE)&&CompareDate(row.BEDAT)==true) {
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
                    hidden: true,
                    rowspan:2
                }, {
                    title: '中心医院',
                    halign: 'center',
                    align: 'center',
                    width: 200
                }, {
                    title: '供应商',
                    halign: 'center',
                    align: 'center',
                    width: 200,
                    colspan:2
                }, {
                    field: 'FREEUSE3',
                    title: '规格',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                    rowspan:2
                }, {
                    field: 'FREEUSE2',
                    title: '生产厂家',
                    halign: 'center',
                    align: 'center',
                    rowspan:2,
                    width: 100
                } ,{
                    field: 'MENGE',
                    title: '订单数量',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true,
                    rowspan:2
                }, {
                    field: 'MSEHT',
                    title: '计量单位',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true,
                    rowspan:2

                }, {
                    field: 'NETPR',
                    title: '进价',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true,
                    rowspan:2
                },  {
                    field: 'EINDT',
                    title: '交货日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true,
                    rowspan:2
                },{
                    field: 'EBELN',
                    title: '采购订单编号',
                    halign: 'center',
                    align: 'center',
                    width: 120,
                    sortable:true,
                    rowspan:2
                }
                , {
                    field: 'EBELP',
                    title: '项目编号',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                    sortable:true,
                     hidden: true,
                     rowspan:2
                }, {
                    field: 'LIFNR',
                    title: '供应商账号',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true,
                    rowspan:2
                }, {
                    field: 'WERKST',
                    title: '院区',
                    halign: 'center',
                    align: 'center',
                    width: 100,
                    sortable:true,
                    rowspan:2
                },{
                    field: 'ALLMENGE',
                    title: '供应数量',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true,
                    rowspan:2
                },{
                    field: 'SUREMENGE',
                    title: '收货数量',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true,
                    rowspan:2
                }, {
                    field: 'BEDAT',
                    title: '采购订单日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true,
                    rowspan:2
                }, {
                    field: 'FREEUSE1',
                    title: '备注',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    rowspan:2
                },{
                    field: 'MATNR',
                    title: '药品编码',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true,
                    rowspan:2,
                    hidden: true
                }
                ],
                [
                 {
                    field: 'TXZ01',
                    title: '药品名称',
                    halign: 'center',
                    align: 'center',
                    width: 120,
                    sortable:true
                },{
                    field: 'GYSDRUGCODE',
                    title: '物料号',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'GYSDRUGNAME',
                    title: '物料描述',
                    halign: 'center',
                    align: 'center',
                    width: 120,
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
    var sub_cols = [//供应计划
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
                }, {
                    field: 'FREEUSE1',
                    title: '备注',
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
                        return "<a class='details' href='#' onclick=EditSubPlan('" + rowData.ID + "','" + rowData.MENGE + "','" + $.trim(rowData.CHARG) + "','" + $.trim(rowData.MEINS) + "','" + HSDate + "','" + rowData.VFDAT + "','" + escape(rowData.FPBM) + "','" + escape(rowData.FPHM) + "','" + rowData.FPJR + "','" + rowData.FPRQ + "','" + rowData.PKG_AMOUNT + "','" + rowData.PKG_NUMBER + "','" + escape(COMMENTS) + "','" + rowData.NETPR + "')> </a>";
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
            }
        };
        return option;
    }

    $(function () {
        WCKJ.Format.SubGrid("flexigridData", toolbar, "<%: Url.Content("~/System/SupplyPlan/GetData")%>"+"?number=Math.random()", cols, data_opt, "", "<%: Url.Content("~/System/SupplyPlan/GetSubPlanData")%>", sub_toolBar, sub_cols, sub_data_opt, "");
    });
    //导航到创建的按钮
    function flexiCreate() {

        var arr = $('#flexigridData').datagrid('getSelections');

        if (arr.length == 1) {
            //清空编辑过的数据
            $("#C_MENGE").numberbox('reset');
            $("#C_CHARG").val("");
            $("#C_FPBM").val("");
            $("#C_FPRQ").datebox('setValue','');
            $("#C_VFDAT").datebox('setValue','');
            $("#C_HSDAT").datebox('setValue','');
            $("#C_FPHM").val("");
            $("#C_FPJR").numberbox('reset');
            $("#C_PKG_AMOUNT").numberbox('reset');
            $("#C_PKG_NUMBER").numberbox('reset');
            $("#C_COMMENTS").val("");

            //---采购订单
            $("#FREEUSE2").val(arr[0].EBELP); //采购凭证项目号
            $("#FREEUSE1").val(arr[0].FREEUSE1); //备注
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
            $("#dlg").dialog('open');

        } else {
            $.messager.alert('操作提示', '请选择一条采购订单数据!', 'warning');
        }

        return false;
    }
    function EditSubPlan(ID, MENGE, CHARG, MEINS, HSDAT, VFDAT,FPBM, FPHM, FPJR, FPRQ,PKG_AMOUNT,PKG_NUMBER,COMMENTS,NETPR) {
        $("#NETPR").val(NETPR);//单价
        $("#ID").val(ID);
        $("#MENGE").numberbox('setValue',MENGE);
        $("#CHARG").val(CHARG);
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
    function CompareDate(beginDate)
    {
      var d1=new Date(beginDate).getTime();
       var time = new Date();
       time.setDate(time.getDate() - time.getDay());
      var d2= time.getTime();
       if(d1<d2)
       {
          return true;
       }
       return false;
    }
    </script>
    <script language="javascript" type="text/javascript">
    
    var flagSubmit=0;//点击按钮后 防止连击
        $(function () {

            $("#HSDAT").datebox({});
            $("#VFDAT").datebox({});
            $("#FPRQ").datebox({});
            $("#C_HSDAT").datebox({});
            $("#C_VFDAT").datebox({});
            $("#C_FPRQ").datebox({});
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
                 txtEBELN:$("#txtEBELN").val()

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
        
    </script>
</asp:Content>
