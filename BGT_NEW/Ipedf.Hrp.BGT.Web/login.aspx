<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Ipedf.Web.login_" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control"  TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="styles/sclm.css"  /> 
    <title>PAAS</title>
</head>
<body >  
    <form id="form1" runat="server"> 
<div id="top">
<div class="top">协和医院院内预算管理系统
</div>
</div>
<div id="center">
<div id="midd">
<div class="login">
<div class="title">登录平台</div>
<div class="inptit">科室：</div>
<div class="inp"><Com:ComDropDownList ID="ddlInputACCOUNT" Height="34" Width="213" runat="server"></Com:ComDropDownList> </div>
<div class="inptit">密&nbsp;&nbsp;码：</div>
<div class="inp"><asp:TextBox runat="server" ID="txtPassword" CssClass="input" TextMode="Password" /></div>
<div class="inptit">预算年度：</div>
<div class="inp"><Com:ComDropDownList ID="ddlInputYEAR" Height="34" Width="213" runat="server"></Com:ComDropDownList> </div>
<div class="submit"><asp:Button runat="server" ID="btnEntry" CssClass="submii" OnClick="btnEntry_Click" /></div>
</div>
</div>
</div>
<div id="bottom">
<div class="bott"></div>
</div>
    </form>   
</body>
</html>
