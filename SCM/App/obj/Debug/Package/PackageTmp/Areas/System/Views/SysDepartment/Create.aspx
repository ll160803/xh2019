<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Create.Master" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.EntityObject_COM_DEPART>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
        <legend>
            <input class="a2 f2" type="submit" value="创建" />
            <input class="a2 f2" type="button" onclick="window.history.go(-1);" value="返回" />
        </legend>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    名称：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.NAME)%>
                    <%: Html.ValidationMessageFor(model => model.NAME)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    组织类型：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.TYPE)%>
                    <%: Html.ValidationMessageFor(model => model.TYPE)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    父部门：
                </div>
                <div class="trendrt">
                    <input id="checkPARENT_ID" type="text" disabled style="width: 110px;" />
                    <input type="button" value="..." onclick="showModalOnly_New('PARENT_ID','../../System/SysDepartment');" />
                    <%: Html.HiddenFor(model => model.PARENT_ID)%>
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    传真：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.FAX)%>
                    <%: Html.ValidationMessageFor(model => model.FAX)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    电话：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.PHONE)%>
                    <%: Html.ValidationMessageFor(model => model.PHONE)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    撤销日期：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.DROP_DATE)%>
                    <%: Html.ValidationMessageFor(model => model.DROP_DATE)%>
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    成立日期：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.CREATE_DATE)%>
                    <%: Html.ValidationMessageFor(model => model.CREATE_DATE)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    编码：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.CODE)%>
                    <%: Html.ValidationMessageFor(model => model.CODE)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    地址：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.ADDRESS)%>
                    <%: Html.ValidationMessageFor(model => model.ADDRESS)%>
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    邮政编码：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.POST_CODE)%>
                    <%: Html.ValidationMessageFor(model => model.POST_CODE)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                </div>
                <div class="trendrt">
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

            $("#CREATE_DATE").datebox({});
            $("#DROP_DATE").datebox({});
            $("#TYPE").combobox({
                url: '<%: Url.Content("~/System/SysDepartment/GetZZData")%>',
                valueField: 'value',
                textField: 'text'
            });
        });

    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CurentPlace" runat="server">
</asp:Content>
