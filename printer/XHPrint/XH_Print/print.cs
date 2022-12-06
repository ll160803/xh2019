using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Drawing.Printing;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Security;

namespace XH_Print
{

    public partial class print : Form
    {
        private List<infoposition> data;
        private int type;
        private string id;
        private String printDate = DateTime.Now.ToShortDateString().ToString();
        private int time = 30;
        private int completeTime = -1;
        public int paperSourceIndex;
        private int flag = 0;
        private TableInfo tableInfo;
        public print(List<infoposition> data, int type, String id, int paperSourceIndex)
        {
            this.id = id;
            this.type = type;
            this.paperSourceIndex = paperSourceIndex;
            this.data = data;
            InitializeComponent();
        }
        public print(List<infoposition> data, int type, String id, int paperSourceIndex, TableInfo tableInfo)
        {
            this.id = id;
            this.type = type;
            this.paperSourceIndex = paperSourceIndex;
            this.data = data;
            this.tableInfo = tableInfo;
            InitializeComponent();
        }

        private void Print_Load(object sender, EventArgs e)
        {
            tick.Visible = true;
            error.Visible = false;
            message.Text = " 正在打印中，请稍后...";
            this.timer1.Enabled = true;
            this.timer2.Enabled = true;
        }

        #region
        protected override void OnShown(EventArgs e)
        {


            // Timer1_Tick(sender, e);
            // Timer2_Tick(sender, e);
        }
        #endregion


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            //Printer.printMethod("吴迪\n精神\n职业病人\n后勤部\n10967373\n2019     4     19");
        }

        private void PrintDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //监测打印状态并在打印完成后自动退出打印界面
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //.Text = time + "";
            if (time != 0)
            {
                if (time == 29)
                {
                    Console.WriteLine("shijian" + time + "");
                    System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
                    PrintPage printerObj = new PrintPage(data,tableInfo);//传递需要打印的内容
                    if (PrintPage.printMethod(this.type, this.paperSourceIndex))
                    {
                       // WebRes.CompletePrint(id, type + "");//回调邱晨的打印方法
                        tick.Visible = true;
                        error.Visible = false;

                    }
                    else
                    {
                        tick.Visible = false;
                        error.Visible = true;
                        flag = 1;
                        //message.Text = "  打印未成功\n请稍后，  秒后返回主页";
                        timer1.Enabled = true;
                        time = 10;
                        return;
                    }

                }
                if (time < 29 && flag==0)
                {
                    string path = @"win32_printer.DeviceId='" + Printer.printerName + "'";
                    ManagementObject printer = new ManagementObject(path);
                    printer.Get();
                    Console.WriteLine("状态值：" + Convert.ToInt32(printer.Properties["PrinterStatus"].Value) + "");
                    if (Convert.ToInt32(printer.Properties["PrinterStatus"].Value) == 3)
                    {
                        if (completeTime < time)
                        {
                            completeTime = time;

                        }
                        else if (completeTime >= time + 10 && completeTime < time + 20)
                        {
                            message.Text = "打印已完成，请取打印证件\n\n" + (10 - (completeTime - time - 10)) + "秒后跳转到主页";
                        }
                        else if (completeTime >= time + 20)
                        {
                            message.Text = "打印已完成，请取打印证件\n\n" + (10 - (completeTime - time - 10)) + "秒后跳转到主页";
                            if (time <= 25)
                            {
                                //message.Text = "      打印已完成";
                                this.Close();
                            }
                        }

                    }
                    //message.Text = "      打印已开始\n 请稍后，  秒后返回主页";
                    //second.Visible = true;
                }
                if(flag==1 && time ==1)
                {
                    timer1.Enabled = false;
                    this.Close();
                }
                /*if (time <= 3)
                {
                    string path = @"win32_printer.DeviceId='" + "HP DeskJet 2130 series" + "'";
                    ManagementObject printer = new ManagementObject(path);
                    printer.Get();
                    Console.WriteLine("状态值：" + Convert.ToInt32(printer.Properties["PrinterStatus"].Value) + "");
                    if (Convert.ToInt32(printer.Properties["PrinterStatus"].Value) == 3)
                    {
                        if (time <= 10)
                        {
                            this.Close();
                        }
                    }
                }*/
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                this.Close();
            }
            time--;

        }

        private void Message_Click(object sender, EventArgs e)
        {

        }

        private void Tick_Click(object sender, EventArgs e)
        {

        }
        public void printDocument1_endPrint(object sender, PrintEventArgs e)
        {
            MessageBox.Show("打印已完成");
            //ManagementClass mc = new ManagementClass(strPrinter);
            //print.Close();
            //form.Close();
        }
        public void printDocument1_beginPrint(object sender, PrintEventArgs e)
        {
            MessageBox.Show("打印开始");
            //ManagementClass mc = new ManagementClass(strPrinter);
            //print.Close();
            //form.Close();
        }

        private void Error_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            if (time <= 14)
            {

            }
            timer2.Enabled = true;
        }

    }

    //打印类
    public class Printer
    {
        private static Font printFont;
        private static Font printFont2;//打印聘任时间
        private static Font titleFont;
        private static StringReader streamToPrint;
        private static int leftMargin = 0;
        private static print print;
        private static Form2 form;
        private static List<infoposition> dataqc;

        public Printer(List<infoposition> data)
        {
            dataqc = data;
        }
        //private static PrintEventHandler printDocument1_endPrint;
        public static string printerName
        {

            get
            {
                return readPaperPrinter();
            }
        }
        public static string printerPos
        {

            get
            {
                return readPaperPos();
            }
        }
        private static string readPaperPos()
        {
            StreamReader sr = new StreamReader("position.txt", Encoding.Unicode);
            var printer = sr.ReadLine();
            if (string.IsNullOrEmpty(printer))
            {
                printer = "0,0";
            }
            sr.Dispose();
            sr.Close();

            return printer;
        }
        private static string readPaperPrinter()
        {
            StreamReader sr = new StreamReader("printer.txt", Encoding.Unicode);
            var printer = sr.ReadLine();
            if (string.IsNullOrEmpty(printer))
            {
                printer = "HP DeskJet 2130 series";
            }
            sr.Dispose();
            sr.Close();

            return printer;
        }
      



       
        public static int middle(int begin, String text, int length, int size)
        {
            char[] charArray = text.ToCharArray();

            return (begin + (length - charArray.Length * size) / 2);
        }
    }
    public class LocalPrinter
    {
        private static PrintDocument fPrintDocument = new PrintDocument();
        /// <summary>   
        /// 获取本机默认打印机名称   
        /// </summary>   
        public static String DefaultPrinter
        {
            get { return fPrintDocument.PrinterSettings.PrinterName; }
        }
        /// <summary>   
        /// 获取本机的打印机列表。列表中的第一项就是默认打印机。   
        /// </summary>   
        public static List<String> GetLocalPrinters()
        {
            List<String> fPrinters = new List<string>();
            fPrinters.Add(DefaultPrinter); // 默认打印机始终出现在列表的第一项   
            foreach (String fPrinterName in PrinterSettings.InstalledPrinters)
            {
                if (!fPrinters.Contains(fPrinterName))
                    fPrinters.Add(fPrinterName);
            }
            return fPrinters;
        }
    }



}
