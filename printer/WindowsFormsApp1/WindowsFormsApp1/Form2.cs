using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private int type = 0;
        private int time = 30;
        private bool printAddress = false;
        private String printName = "";
        private String printId = "";
        private String printSex = "";
        private String printDept = "";
        private String printPosition = "";
        private String printPernr = "";
        private String printDate = DateTime.Now.ToShortDateString().ToString();
        private int isError = 0;
        private int isException = 0;
        private int isFailure = 0;
        private int iRetCOM;
        private int iRetUSB;
        private int authenticate;
        private int paperSourceIndex;

        [DllImport("termb.DLL", CallingConvention = CallingConvention.StdCall)]
        public static extern int CVR_Read_Content(int active);
        [DllImport("Termb.dll", EntryPoint = "GetPeopleName", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern unsafe int GetPeopleName(ref byte strTmp, ref int strLen);
        [DllImport("Termb.dll", EntryPoint = "GetPeopleIDCode", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPeopleIDCode(ref byte strTmp, ref int strLen);
        [DllImport("termb.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int CVR_Authenticate();
        [DllImport("Termb.dll", EntryPoint = "GetBMPData", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetBMPData(ref byte btBmp, ref int nLen);
        [DllImport("Termb.dll", EntryPoint = "GetPeopleSex", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPeopleSex(ref byte strTmp, ref int strLen);

        public Form2(int type, int com, int usb, int paperSourceIndex)
        {
            this.iRetCOM = com;
            this.iRetUSB = usb;
            this.paperSourceIndex = paperSourceIndex;
            this.type = type;//type为1时，页面为打印聘书的页面；TYPE为2时，页面为打印在职凭证的页面
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetInfo.Zhr00FmZcpsdyResponse res2 = WebRes.getInfo(printId, 2 + "");
            //Console.WriteLine(res2.)
            string[] dateArray = Regex.Split(printDate, "/", RegexOptions.IgnoreCase);

            for (int i = 0; i < dateArray.Length; i++)
            {
                Console.WriteLine(dateArray[i]);
            }
            try
            {
                /*                int iPort;
                for (iPort = 1001; iPort <= 1016; iPort++)
                {
                    iRetUSB = CVR_InitComm(iPort);
                    if (iRetUSB == 1)
                    {
                        break;
                    }
                }
                if (iRetUSB != 1)
                {
                    for (iPort = 1; iPort <= 16; iPort++)
                    {
                        iRetCOM = CVR_InitComm(iPort);
                        if (iRetCOM == 1)
                        {
                            break;
                        }
                    }
                }*/
                if ((iRetCOM == 1) || (iRetUSB == 1))
                {
                    label5.Visible = true;
                    label5.Text = "等待刷身份证";
                    try
                    {
                        if ((iRetCOM == 1) || (iRetUSB == 1))
                        {
                            Timer1_Tick(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("初始化失败！");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("读卡失败！");
                    }
                }
                else
                {
                    MessageBox.Show("连接失败，请检查读卡器和主机的连接");
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //持续监测刷卡设备的状态，读取到信息后进行自动打印
        unsafe private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (time != 0)
            {
                authenticate = CVR_Authenticate();
                if (authenticate == 1)
                {
                    int readContent = CVR_Read_Content(4);
                    if (readContent == 1)
                    {
                        label5.Visible = false;
                        char[] nameByte = new char[30];
                        char[] codeByte = new char[30];
                        int length = 0;
                        label4.Visible = true;
                        label2.Visible = true;
                        byte[] name1 = new byte[128];
                        length = 128;
                        GetPeopleName(ref name1[0], ref length);//名字
                        printName = System.Text.Encoding.GetEncoding("GB2312").GetString(name1);
                        name.Text = printName;
                        byte[] number = new byte[128];
                        length = 128;
                        GetPeopleIDCode(ref number[0], ref length);
                        printId = System.Text.Encoding.GetEncoding("GB2312").GetString(number).Replace("\0", "").Trim();
                        code.Text = printId;
                        byte[] sex = new byte[128];
                        length = 128;
                        GetPeopleSex(ref sex[0], ref length);
                        printSex = System.Text.Encoding.GetEncoding("GB2312").GetString(sex).Replace("\0", "").Trim();
                        timer1.Enabled = false;
                        // 读卡操作成功;
                        waitMsg.Visible = true;//显示获取信息
                        time = 15;//重置定时器时间
                        Timer2_Tick(sender, e);
                        autoPrint(sender, e);
                    }
                    else if (readContent == 0)
                    {
                        //读卡操作失败
                        if (isError == 0)
                        {
                            MessageBox.Show("错误");
                            isError++;
                        }
                        timer1.Enabled = true;
                    }
                    else if (readContent == 99)
                    {
                        if (isException == 0)
                        {
                            MessageBox.Show("异常");
                            isException++;
                        }
                        timer1.Enabled = true;
                    }
                }
                else
                {
                    label5.Text = "卡片位置不正确或未放卡";
                    isFailure++;
                    timer1.Enabled = true;
                }
            }
            else
            {
                timer1.Enabled = false;
                this.Close();
            }
            time--;

        }



        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        //自动打印接口
        private void autoPrint(object sender, EventArgs e)
        {
            string[] dateArray = Regex.Split(printDate, "/", RegexOptions.IgnoreCase);
            string data = "";
            switch (type)
            {
                case 1:
                    GetInfo.Zhr00FmZcpsdyResponse res = WebRes.getInfo(printId, type + "");
                    timer2.Enabled = false;
                    waitMsg.Visible = false;
                    if (res.Mes != "")
                    {
                        MessageBox.Show(res.Mes);
                        this.Close();
                        return;
                    }
                    //waitMsg.Text = "获取信息成功，开始打印";
                    data = res.Nachn + "\n" + res.Orgtx + "\n" + res.Zhrzc + "\n" + res.Zhrpzh + "\n" + dateArray[0] + "     " + dateArray[1] + "     " + dateArray[2] + "\n" + "（" + res.Zpq + "）";
                    break;
                case 2:
                    //这里接口文档规定恒为一，传入参数为2
                    GetInfo.Zhr00FmZcpsdyResponse res2 = WebRes.getInfo(printId, 2 + "");

                    timer2.Enabled = false;
                    waitMsg.Visible = false;
                    if (res2.Mes != "")
                    {
                        MessageBox.Show(res2.Mes);
                        this.Close();
                        return;
                    }
                    printDate = dateArray[0] + "年" + dateArray[1] + "月" + dateArray[2] + "日";
                    data = "在职证明\n姓名：" + res2.Nachn + "，性别：" + res2.Gesctxt + "，身份证号：" + res2.Icnum + "，\n系我院职工。\n特此证明。\n联系电话：027-85726359\n" + (res2.Zhrbz != null ? "单位地址：" + res2.Zhrbz : "") + "\n华中科技大学同济医学院\n附属协和医院 人事处\n" + printDate + "\n本证明不作为我院对该职工任何形式的担保文件，自开具之日\n起三十天内有效。";
                    break;

            }
            //Timer3_Tick(sender, e);
            print printForm = new print(data, type, printId, paperSourceIndex);
            printForm.FormClosed += closeForm;
            printForm.Show();
        }


        public void closeForm(Object sender, EventArgs e)
        {
            this.Close();
        }




        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }




        private void Timer2_Tick(object sender, EventArgs e)
        {

            if (time != 0)
            {
                timer2.Enabled = true;
            }
            else
            {
                timer2.Enabled = false;
                waitMsg.Text = "获取信息失败,即将返回首页";
                Timer3_Tick(sender, e);
            }
            time--;
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            this.Close();
            timer3.Enabled = true;
        }

    }
    public class WebRes
    {
        public static GetInfo.Zhr00FmZcpsdyResponse getInfo(String idcard, String type)
        {
            System.Net.NetworkCredential c = new System.Net.NetworkCredential("hr_qiuc", "qc654321");
            GetInfo.ZHRWS_ZCPS zHRWS_ZCPS = new GetInfo.ZHRWS_ZCPS();
            zHRWS_ZCPS.Credentials = c;
            GetInfo.Zhr00FmZcpsdy zhr = new GetInfo.Zhr00FmZcpsdy();
            zhr.Icnum = idcard;
            zhr.Zhrzjlx = type;
            return zHRWS_ZCPS.Zhr00FmZcpsdy(zhr);
        }

        public static ChangeStatus.Zhr00FmZcpshxztResponse CompletePrint(String idcard, String type)
        {
            System.Net.NetworkCredential c = new System.Net.NetworkCredential("hr_qiuc", "qc654321");
            ChangeStatus.ZHRWS_PSHX zHRWS_PSHX = new ChangeStatus.ZHRWS_PSHX();
            zHRWS_PSHX.Credentials = c;
            ChangeStatus.Zhr00FmZcpshxzt zhr = new ChangeStatus.Zhr00FmZcpshxzt();
            zhr.Icnum = idcard;
            zhr.Zhrzjlx = type;

            return zHRWS_PSHX.Zhr00FmZcpshxzt(zhr);
        }
    }
}
