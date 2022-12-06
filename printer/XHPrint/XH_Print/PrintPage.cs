using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace XH_Print
{
   public class PrintPage
    {
        private static List<infoposition> dataqc;
        private static TableInfo tableInfo;

        public PrintPage(List<infoposition> data,TableInfo tableInfo2)
        {
            tableInfo = tableInfo2;
            dataqc = data;
        }
        /// <summary>
        /// 设置PrintDocument 的相关属性
        /// </summary>
        /// <param name="str">要打印的字符串</param>
        public static bool printMethod(int type, int paperSourceIndex)
        {
          
            try
            {
                System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
                pd.PrinterSettings.PrinterName = PrintPage.printerName;
                pd.DocumentName = pd.PrinterSettings.MaximumCopies.ToString();
               
               
                //MessageBox.Show(print.paperSourceIndex+ "         "+pd.DefaultPageSettings.PaperSource.SourceName);
                if (type == 1)
                {
                    pd.DefaultPageSettings.PaperSource = pd.PrinterSettings.PaperSources[paperSourceIndex];
                    pd.DefaultPageSettings.Landscape = false;
                    pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(pd_PrintProve);
                    
                }
                else if (type == 2)
                {
                    pd.DefaultPageSettings.PaperSource = pd.PrinterSettings.PaperSources[paperSourceIndex];
                    pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(pd_PrintContract);
                    pd.DefaultPageSettings.Landscape = false;
                }
                else if (type == 3)
                {
                    pd.DefaultPageSettings.PaperSource = pd.PrinterSettings.PaperSources[paperSourceIndex];
                    pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(pd_PrintMonthSalary);
                    if (tableInfo.IsHeng)
                    {
                        pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(pd_printImage2);//打印协和logo  年度工资打印
                    }
                    else
                    {
                        pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(pd_printImage);//打印协和logo
                    }
                   
                    pd.DefaultPageSettings.Landscape = tableInfo.IsHeng;
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
        private static void pd_printImage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            ev.Graphics.DrawImage(global::XH_Print.Properties.Resources.协和logo, 20, 20);
        }
        private static void pd_printImage2(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            ev.Graphics.DrawImage(global::XH_Print.Properties.Resources.协和logo, 20, 5);
        }
        //打印收入证明
        private static void pd_PrintProve(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            GraphicsTable.printWordInfo(dataqc, ev.Graphics);//收入证明
            GraphicsTable.drawWang(3, 5, ev.MarginBounds.Width, ev.MarginBounds.Height, ev.Graphics);//表格
        }

        //住房公积金缴存及收入证明
        private static void pd_PrintContract(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            GraphicsTable.printWordInfo(dataqc, ev.Graphics);// 住房公积金缴存及收入证明
            GraphicsTable.drawWang_gjj(2, 7, ev.MarginBounds.Width, ev.MarginBounds.Height, ev.Graphics);
        }
        //当月工资条
        private static void pd_PrintMonthSalary(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            GraphicsTable.printWordInfo(dataqc, ev.Graphics);// 当月工资条
            GraphicsTable.drawGrid(tableInfo.yc,tableInfo.xc,tableInfo.width,tableInfo.height,tableInfo.initX,tableInfo.initY, ev.Graphics,tableInfo.firstWidth);
        }
        public static string printerName
        {

            get
            {
                return readPaperPrinter();
            }
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
       
    }
}
