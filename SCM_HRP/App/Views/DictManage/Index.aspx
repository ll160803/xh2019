<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Dict.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">

    <script type="text/javascript">

        $(function () {

            $('#tree').tree({
                data: [
                    {
                        text: '项目来源'//WC_Common_ProjectSource
                    }
                    , {
                        text: '项目属性'
                    }
                    ,{
                        text: '采购方式'
                    }
                    , {
                        text: '资金来源'
                    }
                    , {
                        text: '功能科目'
                    }
                    , {
                        text: '计量单位'
                    }, {
                        text: '流程类别'
                    }
                ],

                onClick: function (node) {
                    onclcik(node.text);
                },

                onLoadSuccess: function (node, data) {
                    $("#tree li:eq(0)").find("div").addClass("tree-node-selected");   //设置第一个节点高亮  
                    var n = $("#tree").tree("getSelected");
                    if (n != null) {
                        $("#tree").tree("select", n.target);    //相当于默认点击了一下第一个节点，执行onSelect方法  
                    }
                }
            });

        });

        function onclcik(name) {

            $('#flexigridData').datagrid('clearSelections');

            switch (name) {

                case '流程类别':
                    _exportUrl = "../../WC_SYSTEM_WORKFLOWTYPE/Export";
                    _createUrl = "../../WC_SYSTEM_WORKFLOWTYPE/Create";
                    _modifyUrl = "../../WC_SYSTEM_WORKFLOWTYPE/Edit";
                    _deleteUrl = "../../WC_SYSTEM_WORKFLOWTYPE/Delete";
                    url = '../../WC_SYSTEM_WORKFLOWTYPE/GetData';
                    sortName = 'WorkFlowTypeCode';
                    idField = 'WorkFlowTypeGuid';
                    columns = [
                        [
                            { field: 'WorkFlowTypeCode', title: '编码', width: 400 }, { field: 'WorkFlowTypeName', title: '名称', width: 400 }
                        ]
                    ];
                    break;
                case '项目来源':
                    _exportUrl = "../../WC_Common_ProjectSource/Export";
                    _createUrl = "../../WC_Common_ProjectSource/Create";
                    _modifyUrl = "../../WC_Common_ProjectSource/Edit";
                    _deleteUrl = "../../WC_Common_ProjectSource/Delete";
                    url = '../../WC_Common_ProjectSource/GetData';
                    sortName = 'Code';
                    idField = 'ID';
                    columns = [
                        [
                            { field: 'Code', title: '编码', width: 400 }, { field: 'Name', title: '名称', width: 400 }
                        ]
                    ];
                    break;

                case '项目属性':
                    _exportUrl = "../../WC_Common_ProjectProperties/Export";
                    _createUrl = "../../WC_Common_ProjectProperties/Create";
                    _modifyUrl = "../../WC_Common_ProjectProperties/Edit";
                    _deleteUrl = "../../WC_Common_ProjectProperties/Delete";
                    url = '../../WC_Common_ProjectProperties/GetData';
                    sortName = 'Code';
                    idField = 'ID';
                    columns = [
                        [
                            { field: 'Code', title: '编码', width: 400 }, { field: 'Name', title: '名称', width: 400 }
                        ]
                    ];
                    break;
                case '采购方式':
                    _exportUrl = "../../WC_Common_PurchaseMethod/Export";
                    _createUrl = "../../WC_Common_PurchaseMethod/Create";
                    _modifyUrl = "../../WC_Common_PurchaseMethod/Edit";
                    _deleteUrl = "../../WC_Common_PurchaseMethod/Delete";
                    url = '../../WC_Common_PurchaseMethod/GetData';
                    sortName = 'Code';
                    idField = 'ID';
                    columns = [
                        [
                            { field: 'Code', title: '编码', width: 400 }, { field: 'Name', title: '名称', width: 400 }
                        ]
                    ];
                    break;
                case '资金来源':
                    _exportUrl = "../../WC_LX_ProjectFundSource/Export";
                    _createUrl = "../../WC_LX_ProjectFundSource/Create";
                    _modifyUrl = "../../WC_LX_ProjectFundSource/Edit";
                    _deleteUrl = "../../WC_LX_ProjectFundSource/Delete";
                    url = '../../WC_LX_ProjectFundSource/GetData';
                    sortName = 'Code';
                    idField = 'ID';
                    columns = [
                        [
                             { field: 'Code', title: '编码', width: 400 }, { field: 'Name', title: '名称', width: 400 }
                        ]
                    ];
                    break;
                case '功能科目':
                    _exportUrl = "../../WC_Common_FunctionSubject/Export";
                    _createUrl = "../../WC_Common_FunctionSubject/Create";
                    _modifyUrl = "../../WC_Common_FunctionSubject/Edit";
                    _deleteUrl = "../../WC_Common_FunctionSubject/Delete";
                    url = '../../WC_Common_FunctionSubject/GetData';
                    sortName = 'Code';
                    idField = 'ID';
                    columns = [
                        [
                            { field: 'Code', title: '编码', width: 400 }, { field: 'Name', title: '名称', width: 400 }
                        ]
                    ];
                    break;
                case '计量单位':
                    _exportUrl = "../../WC_Common_MeasureUnit/Export";
                    _createUrl = "../../WC_Common_MeasureUnit/Create";
                    _modifyUrl = "../../WC_Common_MeasureUnit/Edit";
                    _deleteUrl = "../../WC_Common_MeasureUnit/Delete";
                    url = '../../WC_Common_MeasureUnit/GetData';
                    sortName = 'MeasureUnitCode';
                    idField = 'ID';
                    columns = [
                        [
                            { field: 'MeasureUnitCode', title: '编码', width: 400 }, { field: 'MeasureUnitName', title: '名称', width: 400 }
                        ]
                    ];
                    break;

                default:
            }

            $('#flexigridData').datagrid({
                title: name,
                url: url,
                sortName: sortName,
                idField: idField,
                columns: columns
            });
        }

    </script>



</asp:Content>
