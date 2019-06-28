<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Edit.Master" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_COM_FORM>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
        <legend>
            <input class="a2 f2" type="submit" value="保存" />
            <input class="a2 f2" type="button" onclick="window.history.go(-1);" value="返回" />
        </legend>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    编码：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.CODE)%>
                    <%: Html.ValidationMessageFor(model => model.CODE)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    名称：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.NAME)%>
                    <%: Html.ValidationMessageFor(model => model.NAME)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    地址：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.DEFAULT_PAGE_URL)%>
                    <%: Html.ValidationMessageFor(model => model.DEFAULT_PAGE_URL)%>
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    版本：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.VERSION)%>
                    <%: Html.ValidationMessageFor(model => model.VERSION)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    发布日期：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.DELIVER_DATE)%>
                    <%: Html.ValidationMessageFor(model => model.DELIVER_DATE)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    图片地址：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.IMG_URL)%>
                    <%: Html.ValidationMessageFor(model => model.IMG_URL)%>
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    显示索引：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.DISPLAY_INDEX)%>
                    <%: Html.ValidationMessageFor(model => model.DISPLAY_INDEX)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    所属功能：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.FUNCTION_ID)%>
                    <%: Html.ValidationMessageFor(model => model.FUNCTION_ID)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                </div>
                <div class="trendrt">
                </div>
            </div>
        </div>
    </fieldset>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">
    <script language="javascript" type="text/javascript">
        $(function () {
            $("#FUNCTION_ID").combobox({
                url: '<%: Url.Content("~/System/Functions/GetAppDataForCombobox")%>',
                valueField: 'value',
                textField: 'text'
            });
            $("#DELIVER_DATE").datebox({});

        });

    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CurentPlace" runat="server">
</asp:Content>
