<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>打印控件升级</title>
    <script defer="defer1" type="text/javascript">
        function window.onload() {


            // -------------------控件检测-----------------------	
            if (!factory.object) {
                alert("MeadCo的ScriptX控件安装不正确！");

                return;
            }
            if (!secmgr.object) {
                alert("MeadCo的安全管理控件安装不正确！");

                return;
            }
            if (!secmgr.validLicense) {
                alert("授权许可证无效，或是用户无效！");

                return;
            }
            alert("MeadCo's ScriptX控件、安全管理控件、授权许可证 均检测正常! 欢迎使用 ScriptX7,0,0,8专业版 进行Web打印!")



            // -------------------基本功能，可免费使用-----------------------
            factory.printing.header = ""; //页眉
            factory.printing.footer = ""; //页脚
            factory.printing.SetMarginMeasure(1); //页边距单位，1为毫米，2为英寸
            //边距设置，需要注意大部分打印机都不能进行零边距打印，即有一个边距的最小值，一般都是6毫米以上
            //设置边距的时候时候如果设置为零，就会自动调整为它的最小边距
            factory.printing.leftMargin = 7; //左边距
            factory.printing.topMargin = 7; //上边距
            factory.printing.rightMargin = 7; //右边距
            factory.printing.bottomMargin = 7; //下边距
            factory.printing.portrait = false; //是否纵向打印，横向打印为false，纵向为True

            //--------------------高级功能---------------------------------------------
            factory.printing.printer = "pdfFactory Pro"; //指定使用的打印机，若指定的打印机不存在，则自动用默认打印机打印
            //factory.printing.printer = "\\\\cosa-data\\HPLaserJ";//如为网络打印机，则需要进行字符转义

            factory.printing.paperSize = "A4"; //指定使用的纸张
            factory.printing.paperSource = "Manual feed"; //进纸方式，这里是手动进纸
            factory.printing.copies = 1; //打印份数
            factory.printing.printBackground = false; //是否打印背景图片
            factory.printing.SetPageRange(false, 1, 3); //打印1至3页 
        }      
    </script>
</head>
<body>
    <object id="secmgr" codebase="<%:Url.Content("~/free/smsx7.cab")%>#Version=7,0,0,8"
        classid="clsid:5445BE81-B796-11D2-B931-002018654E2E" viewastext>
        <!--已自动更换为data.txt里自定义生成的GUID-->
        <param name="GUID" value="{4A2E612C-87E0-4A0B-BF5D-377956E97AD7}">
        <!--因为我的2003服务器不允许mlf文件，就改成jpg，结果不需要安装root.cer根证书就能直接安装许可证了。-->
        <param name="PATH" value="<%:Url.Content("~/free/sxlic.jpg")%>">
        <param name="REVISION" value="0">
        <param name="PerUser" value="true">
    </object>
    <object id="factory" classid="clsid:1663ED61-23EB-11D2-B92F-008048FDD814" viewastext>
    </object>
    <h1>
        打印控件升级页面</h1>
</body>
</html>
