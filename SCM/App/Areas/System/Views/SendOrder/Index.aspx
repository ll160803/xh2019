<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Index.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    供应计划
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="dlg" class="easyui-dialog" title="创建供应计划" data-options="iconCls:'icon-save',closed:true,toolbar: [{
					text:'引入送货单',
					iconCls:'icon-add',
					handler:function(){
                        QuoteSendInfo();
						$('#sendinfo').dialog('open');
					}
				}],buttons: [{
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
        <form id="SendOrder" method="post">
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    送货数量：
                </div>
                <div class="trendrt">
                    <input name="MENGE" id="C_MENGE" class="easyui-validatebox easyui-numberbox" required="true"
                        data-options="min:0.001,precision:3,onChange:function(newV,oldV){
                           SetFPJR_C(newV,oldV);
                        }" title="请输入非负数" />
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    送达科室：
                </div>
                <div class="trendrt">
                    <input name="SEND_DEPART_NAME" id="C_SEND_DEPART_NAME" class="easyui-textbox" disabled />
                    <input name="SEND_DEPART" id="C_SEND_DEPART" class="easyui-textbox" style="display: none;" />
                </div>
            </div>
            <div class="centerside">
                <div class="trendlf">
                    联系人：
                </div>
                <div class="trendrt">
                    <input name="LINK_PERSON" id="C_LINK_PERSON" class="easyui-validatebox textbox" required="true" />
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    联系方式：
                </div>
                <div class="trendrt">
                    <input name="LINK_TELEPHONE" id="C_LINK_TELEPHONE" class="easyui-validatebox textbox"
                        required="true" />
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    商品条码：
                </div>
                <div class="trendrt">
                    <input name="MATER_CODE" id="C_MATER_CODE" class="easyui-validatebox textbox" required="true" />
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
                    <input name="FPRQ" id="C_FPRQ"  />
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    发票号码：
                </div>
                <div class="trendrt">
                    <input name="FPHM" id="C_FPHM" class="easyui-validatebox textbox" data-options="validType:'length[1,15]'" />
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                </div>
                <div class="trendrt">
                    <input type="hidden" name="FREEUSE2" id="FREEUSE2" /><%--送货单号--%>
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
				}]" style="width: 800px; height: 200px; padding: 10px">
        <form id="editSubPlan" method="post">
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    送货数量：
                </div>
                <div class="trendrt">
                    <input name="MENGE" id="MENGE" class="easyui-validatebox easyui-numberbox" required="true"
                        data-options="min:0.001,precision:3,onChange:function(newV,oldV){
                           SetFPJR(newV,oldV);
                        }" title="请输入非负数" />
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    送达科室：
                </div>
                <div class="trendrt">
                    <input name="SEND_DEPART_NAME" id="SEND_DEPART_NAME" class="easyui-textbox" disabled />
                    <input name="SEND_DEPART" id="SEND_DEPART" class="easyui-textbox" style="display: none;" />
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    联系人：
                </div>
                <div class="trendrt">
                    <input name="LINK_PERSON" id="LINK_PERSON" class="easyui-validatebox textbox" required="true" />
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    联系方式：
                </div>
                <div class="trendrt">
                    <input name="LINK_TELEPHONE" id="LINK_TELEPHONE" required="true" class="easyui-validatebox textbox" />
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    商品条码：
                </div>
                <div class="trendrt">
                    <input name="MATER_CODE" id="MATER_CODE" class="easyui-validatebox textbox" required="true" />
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
                    <input name="FPRQ" id="FPRQ"  />
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    发票号码：
                </div>
                <div class="trendrt">
                    <input name="FPHM" id="FPHM" class="easyui-validatebox textbox" data-options="validType:'length[1,15]'" />
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
                plain="true">创建供应计划</a> 采购时间:
            <input class="easyui-datebox" id="lastDay" value="<%:ViewBag.LastDay%>" style="width: 100px" />
            -
            <input class="easyui-datebox" id="nowDay" value="<%:ViewBag.NowDay %>" style="width: 100px" />
            订单编号：<input class="easyui-textbox" id="txtEBELN" style="width: 100px" />
            物料名称：<input class="easyui-textbox" id="txtName" style="width: 100px" />
            送货科室：<input class="easyui-textbox" id="txtSEND_DEPART_NAME" style="width: 100px" />
            院区：
            <select class="easyui-combobox" id="com_WERKST" style="width: 100px;">
                <option value="全部">全部</option>
                <option value="武汉协和医院-本部">武汉协和医院-本部</option>
                <option value="武汉协和医院-西院">武汉协和医院-西院</option>
                <option value="武汉协和医院-肿瘤中心">武汉协和医院-肿瘤中心</option>
                <option value="武汉协和医院-金银湖院区">武汉协和医院-金银湖院区</option>
            </select>
            <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="btnSearch();">查询</a>
        </div>
    </div>
    <div id="sendinfo" class="easyui-dialog" title="选择送货单" data-options="closed:true"
        style="width: 900px; height: 350px; padding: 10px">
        <div id="senginfoGrid">
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="<%: Url.Content("~/Scripts/datagrid-detailview.js") %>" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
     function SetFPJR_C(newV,oldV)
    {
       var MENGE=newV;
     
        if($.trim(MENGE).length>0)
       {
           var price=$("#NETPR").val();
           var fpje=parseFloat(price)*parseFloat(MENGE);
           $("#C_FPJR").numberbox('setValue',fpje.toFixed(2));
       }
    }
     function SetFPJR(newV,oldV)
    {
       var MENGE=newV;
     
        if($.trim(MENGE).length>0)
       {
           var price=$("#NETPR").val();
           var fpje=parseFloat(price)*parseFloat(MENGE);
           $("#FPJR").numberbox('setValue',fpje.toFixed(2));
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
                    field: 'SEND_DEAPRT_NAME',
                    title: '送达科室',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'SEND_DEAPRT_CONTACT',
                    title: '联系人',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }
                , {
                    field: 'SEND_DEAPRT_PHONE',
                    title: '联系电话',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    sortable:true
                }, {
                    field: 'COMMENTS',
                    title: '备注',
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
                    title: '供应计划单号',
                    halign: 'center',
                    align: 'center',
                    width: 120
                }, {
                    field: 'MENGE',
                    title: '送货数量',
                    halign: 'center',
                    align: 'center',
                    width: 80
                }, {
                    field: 'LINK_PERSON',
                    title: '联系人',
                    halign: 'center',
                    align: 'center',
                    width: 100
                }, {
                    field: 'SEND_DEPART_NAME',
                    title: '送达科室',
                    halign: 'center',
                    align: 'center',
                    width: 100
                    
                }, {
                    field: 'LINK_TELEPHONE',
                    title: '联系方式',
                    halign: 'center',
                    align: 'center',
                    width: 100
                    
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
                    title: '发票日期',
                    halign: 'center',
                    align: 'center',
                    width: 80,
                    formatter: function (value, rec) {
                        if (value) {
                            return dateConvert(value);
                        }
                    }
                }, {
                    field: 'MATER_CODE',
                    title: '商品条码',
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
                      if(rowData.STATUS==0 && (rowData.SEND_ORDER_CODE == null || rowData.SEND_ORDER_CODE == ''))
                      {
                      var COMMENTS=rowData.COMMENTS;
                      if(COMMENTS==null){COMMENTS=""};
                      var HSDate=rowData.HSDAT;
                      if(HSDate==null) {HSDate=""};
                      var FPRQ=rowData.FPRQ;
                      if(FPRQ==null) {FPRQ=""};
                        return "<a class='details' href='#' onclick=EditSubPlan('" + rowData.ID + "','" + rowData.MENGE + "','" + $.trim(rowData.SEND_DEPART) + "','" + escape(rowData.LINK_PERSON) + "','" + escape(rowData.LINK_TELEPHONE) + "','" + escape(rowData.MATER_CODE) + "','" + escape(rowData.FPHM) + "','" + rowData.FPJR + "','" + FPRQ + "','" + rowData.NETPR + "','" +escape($.trim(rowData.SEND_DEPART_NAME)) + "')> </a>";
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
                    if(rowData.STATUS==0 && (rowData.SEND_ORDER_CODE == null || rowData.SEND_ORDER_CODE == ''))
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
                WC_Common.Format.IconButton('.searchcls', 'icon-search');
            }
        };
        return option;
    }

    $(function () {
        WCKJ.Format.SubGrid("flexigridData", toolbar, "<%: Url.Content("~/System/SendOrder/GetData")%>", cols, data_opt, "", "<%: Url.Content("~/System/SendOrder/GetSubPlanData")%>", sub_toolBar, sub_cols, sub_data_opt, "");
        resizeDataGrid(false);
    });

    function QuoteSendInfo()
    {
       var matnr=$("#MATNR").val();//物料号
       $('#senginfoGrid').datagrid({
                iconCls: 'icon-site',
                url: '<%: Url.Content("~/System/SCM_B_SENDINFO/GetData")%>',
                fitColumns: true,
                queryParams:{MATNR:matnr,IsInfo:'1' },
                idField: 'ID',
                sortName: 'CODE',
                sortOrder: 'desc',
                singleSelect: true,
                height:300,
                nowrap: false,
                rownumbers: true,
                toolbar: [{
                    text: '选择',
                    iconCls: 'icon-ok',
                    handler: function () {
                        return flexiSelect();
                    }
                }],
                columns: [
                    [{
                        field: 'ID',
                        title: 'ID',
                        width: 50,
                        halign: 'center',
                        align: 'center',
                        hidden: true
                    }, {
                        field: 'CODE',
                        title: '送货单号',
                        halign: 'center',
                        align: 'center',
                        sortable: true,
                        width: 100
                    }, {
                        field: 'MATNR',
                        title: '物料编码',
                        halign: 'center',
                        align: 'center',
                        sortable: true,
                        width: 80
                    }, {
                        field: 'TXZ01',
                        title: '物料描述',
                        width: 200,
                        halign: 'center',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'AMOUNT',
                        title: '送货数量',
                        width: 80,
                        halign: 'center',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'MSEHT',
                        title: '单位',
                        width: 60,
                        halign: 'center',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'LINK_PERSON',
                        title: '联系人',
                        width: 80,
                        halign: 'center',
                        align: 'center',
                        sortable: true
                    },
                     {
                         field: 'SEND_DEPART_NAME',
                         title: '送达部门',
                         width: 80,
                         halign: 'center',
                         align: 'center',
                         sortable: true
                     },
                     {
                         field: 'LINK_TELEPHONE',
                         title: '联系方式',
                         width: 80,
                         halign: 'center',
                         align: 'center',
                         sortable: true
                     },
                     {
                         field: 'MATER_CODE',
                         title: '商品条码',
                         width: 80,
                         halign: 'center',
                         align: 'center',
                         sortable: true
                     }
                    ]
		],
                pagination: true,
                rownumbers: true

            });
    }
    function flexiSelect()
    {
       var arr = $('#senginfoGrid').datagrid('getSelections');
       if(arr.length==1)
       {
            $("#C_MENGE").numberbox('setValue',arr[0].AMOUNT);
            $("#C_SEND_DEPART").val(arr[0].SEND_DEPART);
            $("#C_SEND_DEPART_NAME").val(arr[0].SEND_DEPART_NAME);
            $("#C_LINK_PERSON").val(arr[0].LINK_PERSON);
          
          //  $("#C_FPJR").numberbox('setValue',arr[0].MONEY);
            $("#C_LINK_TELEPHONE").val(arr[0].LINK_TELEPHONE);
            $("#C_MATER_CODE").val(arr[0].MATER_CODE);
            $("#FREEUSE2").val(arr[0].ID);//记录送货单单号
            $("#sendinfo").dialog('close');
       }
       else{
           $.messager.alert('操作提示', '请选择一条送货单数据!', 'warning');
       }
    }
    //导航到创建的按钮
    function flexiCreate() {

        var arr = $('#flexigridData').datagrid('getSelections');

        if (arr.length == 1) {
            //清空编辑过的数据
            $("#C_MENGE").numberbox('reset');
            $("#C_SEND_DEPART").val(arr[0].SEND_DEAPRT_ID);
            $("#C_SEND_DEPART_NAME").val(arr[0].SEND_DEAPRT_NAME);
            $("#C_LINK_PERSON").val(arr[0].SEND_DEAPRT_CONTACT)
            $("#C_FPRQ").datebox('setValue','');
            $("#C_FPHM").val("");
            $("#C_FPJR").numberbox('reset');
            $("#C_LINK_TELEPHONE").val(arr[0].SEND_DEAPRT_PHONE);
            $("#FREEUSE2").val("");
            $("#C_MATER_CODE").val("");

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

           

            $("#dlg").dialog('open');

        } else {
            $.messager.alert('操作提示', '请选择一条采购订单数据!', 'warning');
        }

        return false;
    }
    function EditSubPlan(ID, MENGE, SEND_DEPART, LINK_PERSON, LINK_TELEPHONE,MATER_CODE, FPHM, FPJR, FPRQ,NETPR,SEND_DEPART_NAME) {
        $("#NETPR").val(NETPR);//单价
        $("#ID").val(ID);
        $("#MENGE").numberbox('setValue',MENGE);
       
        if(unescape(FPHM)=='null')
        {
        $("#FPHM").val("");
        }
        else{
        $("#FPHM").val(unescape(FPHM));
        }
        $("#LINK_PERSON").val(unescape(LINK_PERSON));
        $("#LINK_TELEPHONE").val(unescape(LINK_TELEPHONE));
        $("#MATER_CODE").val(unescape(MATER_CODE));
        $("#FPJR").val(FPJR);
        if(FPRQ!="")
        {
         $("#FPRQ").datebox('setValue', dateConvert(FPRQ));
        }
        else{
           $("#FPRQ").datebox('setValue', "");
        }
        $("#SEND_DEPART").val($.trim(SEND_DEPART));
       // $("#SEND_DEPART").combogrid({onLoadSuccess:function(){
                        
        $("#SEND_DEPART_NAME").val(unescape(SEND_DEPART_NAME));
                    
                 //   });
        $("#editDlg").dialog('open');
    }
    function DeleteSubPlan(ID) {
        $.messager.confirm('操作提示', "确认删除这 1 项吗？", function (r) {
            if (r) {
                $.post("<%: Url.Content("~/System/SendOrder/Delete")%>", {
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
            $("#FPRQ").datebox({});
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
            $("#SendOrder").form("submit", {
                url: "<%: Url.Content("~/System/SendOrder/Create")%>",
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
                url: "<%: Url.Content("~/System/SendOrder/Edit")%>",
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
                txtEBELN: $("#txtEBELN").val(),
                txtSEND_DEPART_NAME: $("#txtSEND_DEPART_NAME").val(),
                 WERKST:$("#com_WERKST").combobox('getValue')

            });
            $("#flexigridData").datagrid("clearSelections");
        }
       
        
    </script>
</asp:Content>
