<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpFile_UpLoad.aspx.cs" Inherits="Ipedf.Hrp.Web.common.UpFile_UpLoad" %>
<%@ Register Assembly="Ipedf.Web.Control" Namespace="Ipedf.Web.Control" TagPrefix="Com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
    <link  href="<%=ResolveClientUrl("~/styles/common.css") %>" type="text/css" rel="stylesheet"/>
	<script src="<%=ResolveClientUrl("~/scripts/Input.js") %>" type="text/javascript"></script>
	<script src="<%=ResolveClientUrl("~/scripts/xmlHttp.js") %>" type="text/javascript"></script>
	<style>
			DIV { DISPLAY: none }
    </style>
	<script type="text/ecmascript">
			function XmlDom()
			{
				var _dom;
				if(typeof XmlDom._init != "undefined")
				{
					_dom = new ActiveXObject(XmlDom._init);
				}
				else
				{
					var arrSign = ["MSXML2.DOMDocument.5.0","MSXML2.DOMDocument.4.0","MSXML2.DOMDocument.3.0","MSXML2.DOMDocument","Microsoft.XMLDOM"];
					var i=0;
					for(;i<arrSign.length;i++)
					{
						try
						{
							_dom = new ActiveXObject(arrSign[i]);
							break;
						}
						catch(oErr){}
					}
					XmlDom._init = arrSign[i];
				}
				_dom.async = false;
				return _dom;
			}
	        function getUploadId() {
	            var uploadDiv = document.getElementById("divUploadID");
	            return Trim(uploadDiv.innerHTML);
	        }
			function getCurrentRoot()
			{
				var pos = window.location.pathname.lastIndexOf("/");
				return window.location.protocol + "//" + window.location.host + window.location.pathname.substr(0, pos) + "/";
			}
		    function initDocument() {
		        window.parent.document.uploadId =getUploadId();
		    }
		    function setComplete(CompleteState, UpMsg) {
		        window.parent.resetUpload();
		        if (CompleteState) {
		            var uploadMsg = window.parent.document.getElementById("uploadMsg");
		            uploadMsg.innerHTML = UpMsg;
		            if (arguments.length > 2) {
		                window.parent.addFileInfo(arguments[2], arguments[3], arguments[4], arguments[5]);
		            }
		        }
		        else {
		            alert(UpMsg);
		        }
		    }
		    function displayPath(path) {
		        window.parent.document.all.itbPath.value = path;
		    }
		    function saveFile() {
		        var reloadUrl = window.location;
				var doc = new XmlDom();
				doc.load(getCurrentRoot() + "UploadFinish.ashx?reloadUrl=" + reloadUrl+"&RND="+Math.random());
				if (doc.parseError.errorCode==0 && doc.documentElement.childNodes.length>0)
				{					
					var xmlRoot = doc.documentElement;
					var state = xmlRoot.selectSingleNode("//saveStatus/state").text;
					parseState(state);
			    }
		    }
		    function parseState(value) {
		        var array = value.split('^');
		        var enable = array[0] == 'true' ? true : false;
		        if (enable) {
		            var succeed = array[1] == 'true' ? true : false;
		            var message = array[2];
		            var upId = array[3];
		            var fileId = array[4];
		            var fileName = array[5];
		            var fileTitle = array[6];
		            var url = array[7];
		            if (!succeed)
		                setComplete(succeed, message);
		            else {
						setComplete(succeed, message, upId, fileId, fileName, fileTitle);
		                //window.location = url;
					}
		        }
				else				
				{
					var succeed = array[1] == 'true' ? true : false;
		            var message = array[2];
					setComplete(false, message);
				}
			
		    } 
		</script>
</head>		
    <body onload='initDocument();' >		
		<form id="uploadForm" method="post" enctype="multipart/form-data" runat="server">	
				<input id="inputUpFile" type="file" name="inputUpFile" onchange="displayPath(this.value);"/>
				<input id="btnBegin" type="submit" value="上传" />
				<input id="btnSave" type="button" value="上传"  onclick="saveFile();"/>
				<div id="divUploadID">
				    <asp:Literal id="literID" runat="server" EnableViewState="False"></asp:Literal>
				</div>					
		</form>
	</body>
</html>