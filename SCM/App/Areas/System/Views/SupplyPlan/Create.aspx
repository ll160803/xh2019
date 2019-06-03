<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Create.Master" Inherits="System.Web.Mvc.ViewPage<Ipedf.Web.Entity.DisplayObject_SCM_D_SUPPLYPLAN>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
        <legend>
            <input class="a2 f2" type="submit" value="创建" />
            <input class="a2 f2" type="button" onclick="window.history.go(-1);" value="返回" />
        </legend>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    交货数量：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.MENGE)%>
                    <%: Html.ValidationMessageFor(model => model.MENGE)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    计量单位：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.MEINS)%>
                    <%: Html.ValidationMessageFor(model => model.MEINS)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    批次编号：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.CHARG)%>
                    <%: Html.ValidationMessageFor(model => model.CHARG)%>
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    生产日期：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.HSDAT)%>
                    <%: Html.ValidationMessageFor(model => model.HSDAT)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    有效日期：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.VFDAT)%>
                    <%: Html.ValidationMessageFor(model => model.VFDAT)%>
                </div>
            </div>
            <div class="rightside">
                <div class="trendlf">
                    发票号码：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.FPHM)%>
                    <%: Html.ValidationMessageFor(model => model.FPHM)%>
                </div>
            </div>
        </div>
        <div class="laytrnew">
            <div class="leftside">
                <div class="trendlf">
                    发票金额：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.FPJR)%>
                    <%: Html.ValidationMessageFor(model => model.FPJR)%>
                </div>
            </div>
            <div class="centreside">
                <div class="trendlf">
                    开票日期：
                </div>
                <div class="trendrt">
                    <%: Html.EditorFor(model => model.FPRQ)%>
                    <%: Html.ValidationMessageFor(model => model.FPRQ)%>
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

            $("#HSDAT").datebox({});
            $("#VFDAT").datebox({});
            $("#FPRQ").datebox({});
        });

    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CurentPlace" runat="server">
</asp:Content>
