using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Drawing.Printing;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Security;

namespace WindowsFormsApp1
{

    public partial class print : Form
    {
        private String data;
        private int type;
        private string id;
        private String printDate = DateTime.Now.ToShortDateString().ToString();
        private int time=30;
        private int completeTime = -1;
        public int paperSourceIndex;
        public print(String data, int type,String id,int paperSourceIndex)
        {
            this.id = id;
            this.type = type;
            this.paperSourceIndex = paperSourceIndex;
            this.data = data;
            InitializeComponent();
        }

        private void Print_Load(object sender, EventArgs e)
        {
            tick.Visible = true;
            error.Visible = false;
            message.Text = " 正在打印中，请稍后...";
            Timer1_Tick(sender, e);
            Timer2_Tick(sender, e);
        }

        #region
        protected override void OnShown(EventArgs e)
        {
           

           // Timer1_Tick(sender, e);
           // Timer2_Tick(sender, e);
        }
        #endregion

        private void againPrint(int type)
        {
            string[] dateArray = Regex.Split(printDate, "/", RegexOptions.IgnoreCase);
            string d = "";
            switch (type)
            {
                case 1:
                    
                    GetInfo.Zhr00FmZcpsdyResponse res = WebRes.getInfo(id, type + "");
                    if (res.Mes != "")
                    {
                        return;
                    }
                    d = res.Nachn + "\n" + res.Orgtx + "\n" + res.Zhrzc + "\n" + res.Zhrpzh + "\n" + dateArray[0] + "     " + dateArray[1] + "     " + dateArray[2];
                    break;
                case 2:
                    return;//只用打印一份
                    printDate = dateArray[0] + "年" + dateArray[1] + "月" + dateArray[2] + "日";

                    d = "工作证明\n张  一，男，身份证号：4201141211111111111，系我\n院职工。\n特此证明。\n联系电话：027-85726359\n单位地址：湖北省武汉市江汉区解放大道1277号\n华中科技大学同济医学院附属协和医院\n2019年3月29日\n本证明仅用于证明我院员工的工作，不作为我院对该员\n工任何形式的担保文件。";
                    //Application.Run(new print("工作证明\n张XX，男，身份证号：420114XXXXXXXXXXXXX，系我院职工。\n特此证明。\n联系电话：027 - 85726359\n单位地址：湖北省武汉市江汉区解放大道1277号\n华中科技大学同济医学院附属协和医院\n2019年3月29日\n本证明仅用于证明我院员工的工作，不作为我院对该员工任何形式的担保文件。", 2));
                    //data = "工作证明\n" + printName + "，" + printSex + "，身份证号：" + printId + "，系我院职工。\n特此证明。\n联系电话：027 - 85726359" + (printAddress ? "\n单位地址：湖北省武汉市江汉区解放大道1277号" : "") + "\n华中科技大学同济医学院附属协和医院\n" + printDate + "\n本证明仅用于证明我院员工的工作，不作为我院对该员工任何形式的担保文件。";
                    break;

            }

            if (Printer.printMethod(d, type,this))
            {
                WebRes.CompletePrint(id, type + "");
            }
        }

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
                if(time == 29)
                {
                    Console.WriteLine("shijian"+time + "");
                    System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
                    if (Printer.printMethod(this.data, this.type, this))
                    { 
                        WebRes.CompletePrint(id, type+ "");
                        againPrint(this.type);
                        tick.Visible = true;
                        error.Visible = false;

                    }
                    else
                    {
                        tick.Visible = false;
                        error.Visible = true;
                        //message.Text = "  打印未成功\n请稍后，  秒后返回主页";
                        return;
                    }
                   
                }
                if (time < 29)
                {
                    string path = @"win32_printer.DeviceId='" + "HP DeskJet 2130 series" + "'";
                    ManagementObject printer = new ManagementObject(path);
                    printer.Get();
                    Console.WriteLine("状态值：" + Convert.ToInt32(printer.Properties["PrinterStatus"].Value) + "");
                    if (Convert.ToInt32(printer.Properties["PrinterStatus"].Value) == 3)
                    {
                        if(completeTime < time)
                        {
                            completeTime = time;
                            
                        }
                        else if(completeTime >= time+10&& completeTime < time + 20)
                        {
                            message.Text = "打印已完成，请取打印证件\n\n" + (10 - (completeTime - time-10)) + "秒后跳转到主页";
                        }
                        else if (completeTime >= time + 20)
                        {
                            message.Text = "打印已完成，请取打印证件\n\n" + (10 - (completeTime - time-10)) + "秒后跳转到主页";
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
            if(time <= 14)
            {

            }
            timer2.Enabled = true;
        }

    }

    //打印类
    public class Printer
    {
        private static Font printFont;
        private static Font titleFont;
        private static StringReader streamToPrint;
        private static int leftMargin = 0;
        private static print print;
        private static Form2 form;
        //private static PrintEventHandler printDocument1_endPrint;



        /// <summary>
        /// 设置PrintDocument 的相关属性
        /// </summary>
        /// <param name="str">要打印的字符串</param>
        public static bool printMethod(string str,int type,print printFrom)
        {
            print = printFrom;
            try
            {
                streamToPrint = new StringReader(str);
                printFont = new Font("宋体", 16);
                titleFont = new Font("宋体", 24);
                System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
                pd.PrinterSettings.PrinterName = "HP DeskJet 2130 series";
                pd.DocumentName = pd.PrinterSettings.MaximumCopies.ToString();
                pd.DefaultPageSettings.PaperSource = pd.PrinterSettings.PaperSources[print.paperSourceIndex];
                pd.DefaultPageSettings.Landscape = true;
                //MessageBox.Show(print.paperSourceIndex+ "         "+pd.DefaultPageSettings.PaperSource.SourceName);
                if (type == 1) {
                    pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(pd_PrintContract);
                }
                else {
                    pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(pd_PrintProve);
                    pd.DefaultPageSettings.Landscape = false;
                }
                pd.PrintController = new System.Drawing.Printing.StandardPrintController();

                pd.Print();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }



//打印在职证明
        private static void pd_PrintProve(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            int count = 0;
            String line = null;

            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            while (count < linesPerPage &&
            ((line = streamToPrint.ReadLine()) != null))
            {
                if (count == 0)
                {
                    //MessageBox.Show(titleFont.Size + "");
                    ev.Graphics.DrawString(line, new Font(new FontFamily("黑体"), 22), System.Drawing.Brushes.Black, 345, 150, new StringFormat());
                    //ev.Graphics.DrawString(line, titleFont, Brushes.Black, 360, 296, new StringFormat());
                }
                else if (count == 1)
                {
                    //MessageBox.Show(printFont.GetHeight(ev.Graphics) + "");
                    ev.Graphics.DrawString(line, new Font(new FontFamily("宋体"), 16), System.Drawing.Brushes.Black, 130, 230, new StringFormat());
                }
                else if (count == 2)
                {
                    //MessageBox.Show(printFont.GetHeight(ev.Graphics) + "");
                    ev.Graphics.DrawString(line, new Font(new FontFamily("宋体"), 16), System.Drawing.Brushes.Black, 88, 280, new StringFormat());
                }
                else if (count == 3)
                {
                    //MessageBox.Show(printFont.GetHeight(ev.Graphics) + "");
                    ev.Graphics.DrawString(line, new Font(new FontFamily("宋体"), 16), System.Drawing.Brushes.Black, 130, 340, new StringFormat());
                }
                else if (count == 4)
                {
                    //MessageBox.Show(printFont.GetHeight(ev.Graphics) + "");
                    ev.Graphics.DrawString(line, new Font(new FontFamily("宋体"), 16), System.Drawing.Brushes.Black, 130, 430, new StringFormat());
                }
                else if (count == 5)
                {
                    ev.Graphics.DrawString(line, new Font(new FontFamily("宋体"), 16), System.Drawing.Brushes.Black, 130, 480, new StringFormat());//单位地址
                }
                else if (count == 6)
                {
                    ev.Graphics.DrawString(line, new Font(new FontFamily("宋体"), 16), System.Drawing.Brushes.Black, 450, 630, new StringFormat());
                }else if(count == 7)
                {
                    ev.Graphics.DrawString(line, new Font(new FontFamily("宋体"), 16), System.Drawing.Brushes.Black, 468, 680, new StringFormat());
                }
                else if (count == 8)
                {
                    ev.Graphics.DrawString(line, new Font(new FontFamily("宋体"), 16), System.Drawing.Brushes.Black, 500, 730, new StringFormat());
                }else if(count == 9)
                {
                    ev.Graphics.DrawString(line, new Font(new FontFamily("宋体"), 16), System.Drawing.Brushes.Black, 130, 830);
                }
                else if (count == 10)
                {
                    ev.Graphics.DrawString(line, new Font(new FontFamily("宋体"), 16), System.Drawing.Brushes.Black, 88, 880);
                }
                count++;
            }
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;

        }

        //打印聘书
        private static void pd_PrintContract(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            int count = 0;
            String line = null;
            
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
            
            while (count < linesPerPage &&
            ((line = streamToPrint.ReadLine()) != null))
            {
                if (count == 0)
                {   
                    //MessageBox.Show(titleFont.Size + "");
                    ev.Graphics.DrawString(line, titleFont, Brushes.Black, middle(360,line,110,(int)titleFont.Size), 305, new StringFormat());
                    //ev.Graphics.DrawString(line, titleFont, Brushes.Black, 360, 296, new StringFormat());
                }
                else if(count == 1)
                {
                    //MessageBox.Show(printFont.GetHeight(ev.Graphics) + "");
                    ev.Graphics.DrawString(line, titleFont, Brushes.Black,  middle(760, line, 125, (int)titleFont.Size), 305, new StringFormat());
                }else if (count == 2)
                {
                    //MessageBox.Show(printFont.GetHeight(ev.Graphics) + "");
                    ev.Graphics.DrawString(line, titleFont, Brushes.Black, middle(150, line, 340, (int)titleFont.Size), 370, new StringFormat());
                }
                else if (count == 3)
                {
                    //MessageBox.Show(printFont.GetHeight(ev.Graphics) + "");
                    ev.Graphics.DrawString(line, printFont, Brushes.Black, middle(290, line, 140, (int)printFont.Size), 625, new StringFormat());
                }
                else if (count == 4)
                {
                    
                    ev.Graphics.DrawString(line, printFont, Brushes.Black, 635, 625, new StringFormat());
                }
                count++;
            }
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;

        }
        public static int middle(int begin,String text,int length,int size)
        {
            char[] charArray = text.ToCharArray();
            
            return (begin+(length-charArray.Length*size)/2);
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
