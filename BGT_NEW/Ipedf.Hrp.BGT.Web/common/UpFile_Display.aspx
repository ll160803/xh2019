<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpFile_Display.aspx.cs" Inherits="Ipedf.Hrp.Web.common.UpFile_Display" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<HTML>
	<HEAD>
		<title>附件</title>
	</HEAD>
	<body>
		<form id="form1" method="post" runat="server">
				<TABLE id="tabList" style="WIDTH: 500px" cellSpacing="1" cellPadding="0" align="center" border="0" runat="server">
					<TR>
						<TD colspan="3">附件：</TD>
					</TR>
				</TABLE>
				<TABLE id="tabError" style="WIDTH: 500px" cellSpacing="1" cellPadding="0" align="center" border="0" runat="server">
					<TR>
						<TD align="left">文件下载</TD>
					</TR>
					<tr class="editrow">
						<td align="center"><br>
							<asp:Label Runat="server" ID="lblMsg"></asp:Label><br>
							<br>
						</td>
					</tr>
					<tr>
						<td align="center">
							<Com:ComButton  id="btnClose" runat="server" Text="关闭" ></Com:ComButton></td>
					</tr>
				</TABLE>
		</form>
	</body>
</HTML>