function printBase() {
    factory.printing.header = "指挥中心新指令";    //页眉
    factory.printing.footer = "                                                                         2010-5-21";     //页脚                        
    factory.printing.portrait = true; //true为纵向打印，flase为横向打印
    factory.printing.leftMargin = 1.5;    //左页边距
    factory.printing.topMargin = 1.0;      //上页边距
    factory.printing.rightMargin = 1.5;  //右页边距
    factory.printing.bottomMargin = 1.0; //下页边距
}

//用于调用设置打印参数的方法和显示预览界面
function printReport() {
    printBase();
    //printBase("&w&b页码，&p/&P","&u&b&d");//默认
    //window.print();
    factory.printing.Preview(); //预览
    //factory.printing.Print(false);  //false为默认打印机,true为选择打印机
}