<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Create.Master" Inherits="System.Web.Mvc.ViewPage<WCJD.DAL.Notice>" %>

<%@ Import Namespace="Common" %>
<%@ Import Namespace="Models" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CurentPlace" runat="server">
      创建 公告管理
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
        <legend>
            <input class="a2 f2" type="submit" value="创建" />
            <input class="a2 f2" type="button" onclick="BackList('Notice')" value="返回" />
        </legend>
  
            <%--<%: Html.HiddenFor(model => model.ID) %>
            <%: Html.HiddenFor(model => model.CreateTime)%>
            <%: Html.HiddenFor(model => model.CreatePerson)%>
            <%: Html.HiddenFor(model => model.UpdateTime)%>
            <%: Html.HiddenFor(model => model.UpdatePerson)%>--%>
<!--一行开始-->
      
            <!--一行开始-->
            <div class="laytr">
                <div class="leftTD">
                    <div class="leftlabel">
                     <%: Html.LabelFor(model => model.Title) %>
                    </div>
                    <div class="righteditor">
                    <%: Html.EditorFor(model => model.Title)%>
                <%: Html.ValidationMessageFor(model => model.Title)%>
                    </div>
                </div>
                <div class="rightTD">
                    <div class="leftlabel">

                    </div>
                    <div class="righteditor">

                    </div>
                </div>
            </div>
            <!--一行结束-->


            <div class="bottom">
        <div class="bottomleft">
            <%: Html.LabelFor(model => model.Content) %>

            </div> 
            <div class="bottomright">
            <div class="textarea-box">
               <%: Html.TextAreaFor(model => model.Content)%>
                <%: Html.ValidationMessageFor(model => model.Content) %>

            </div>
            </div> 
        </div>



    </fieldset>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    
    <script type="text/javascript">

        $(function () {


        });
              

    </script>
</asp:Content>

