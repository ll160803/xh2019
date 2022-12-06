using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace XH_Print
{
    public partial class Form2 : Form
    {
        private int type = 0;
        private int time = 30;

        private String printId = "";//
        private String sex; //性别
        private String Nachn;//姓名
        private String pernr; //发薪号
        private String pffno;//公积金账号


        private String printDate = DateTime.Now.ToShortDateString().ToString();

        private int isFailure = 0;
        private int iRetCOM;
        private int iRetUSB;
        private int paperSourceIndex;
        private PrintDateParam printDateParam;

        private IDCardData iDCardData;


        public Form2(int type, int com, int usb, int paperSourceIndex)
        {
            this.iRetCOM = com;
            this.iRetUSB = usb;
            this.paperSourceIndex = paperSourceIndex;
            this.type = type;//type为1时，页面为打印收入证明的页面；TYPE为2时，页面为打印公积金缴存的页面
            InitializeComponent();
        }
        public Form2(int type, int com, int usb, int paperSourceIndex, PrintDateParam printDateParam2)
        {
            this.iRetCOM = com;
            this.iRetUSB = usb;
            this.paperSourceIndex = paperSourceIndex;
            this.type = type;//type为1时，页面为打印收入证明的页面；TYPE为2时，页面为打印公积金缴存的页面
            this.printDateParam = printDateParam2;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // GetInfo.Zhr00FmZcpsdyResponse res2 = WebRes.getInfo(printId, 2 + "");
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
                String errorStr = "";
            
               /**
                if (type == (int)TypeEnum.工资条打印)
                {
                    SalaryNote salaryNote = new SalaryNote(type, paperSourceIndex, new Person { idCard = "421302198908191260", sex = "女", Nachn = "测试人", pernr = "233", pffno = "324324" });
                    salaryNote.Show();
                    this.Close();
                    return;
                }
                if (type == (int)TypeEnum.绩效查询)
                {
                    Fund fund = new Fund(type, paperSourceIndex, new Person { idCard = "421302198908191260", sex = "女", Nachn = "测试人", pernr = "233", pffno = "324324" });
                    fund.Show();
                    this.Close();
                    return;
                }
               */

                if (ReadCard.FindDrivers(out errorStr))
                {
                    ReadCard.playVoice("voices/请刷您的二代身份证.wav");
                    label5.Visible = true;
                    label5.Text = "等待刷身份证";
                    try
                    {
                        Timer1_Tick(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("读卡失败！");
                    }
                }
                else
                {
                    MessageBox.Show("连接失败，请检查读卡器和主机的连接，" + errorStr);
                    this.Close();
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
                String error = "";
                bool IsSuccess = ReadCard.ReadIdCard(out iDCardData, out error);
                if (IsSuccess && time !=30)
                {

                    label5.Visible = false;

                    printId = iDCardData.IDCardNo;
                    code.Text = printId;

                    timer1.Enabled = false;
                    // 读卡操作成功;
                    waitMsg.Visible = true;//显示获取信息

                    if (type == (int)TypeEnum.工资条打印)
                    {
                        SearchMonthSalary.ZHR00_CW4 zHR00_CW4 = new SearchMonthSalary.ZHR00_CW4();
                        SearchMonthSalary.Zhr00FmGzdyj3 inputParam = new SearchMonthSalary.Zhr00FmGzdyj3();
                        inputParam.Icnum = printId;
                        inputParam.Year = DateTime.Now.Year.ToString();
                        inputParam.TNd = new SearchMonthSalary.Zhr00SXs[10];
                        inputParam.TGzt = new SearchMonthSalary.Zhr00SGztprint[10];
                        inputParam.Month = DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month : DateTime.Now.Month.ToString();

                        var res = zHR00_CW4.Zhr00FmGzdyj3(inputParam);
                        if (String.IsNullOrEmpty(res.EMessage))
                        {
                            Person person = new Person
                            {
                                idCard = printId,
                                Nachn = res.EHeader.Nachn,
                                pernr = res.EHeader.Pernr,
                                pffno = res.EHeader.Phfno,
                                sex = res.EHeader.Zhrxb
                            };
                            SalaryNote salaryNote = new SalaryNote(type, paperSourceIndex, person);
                            salaryNote.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(res.EMessage);
                            this.Close();
                            return;
                        }

                    }
                    else if (type == (int)TypeEnum.绩效查询)
                    {
                        SearchMonthSalary.ZHR00_CW4 zHR00_CW4 = new SearchMonthSalary.ZHR00_CW4();
                        SearchMonthSalary.Zhr00FmGzdyj3 inputParam = new SearchMonthSalary.Zhr00FmGzdyj3();
                        inputParam.Icnum = printId;
                        inputParam.Year = DateTime.Now.Year.ToString();
                        inputParam.Month = DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month : DateTime.Now.Month.ToString();
                        inputParam.TNd = new SearchMonthSalary.Zhr00SXs[10];
                        inputParam.TGzt = new SearchMonthSalary.Zhr00SGztprint[10];
                        var res = zHR00_CW4.Zhr00FmGzdyj3(inputParam);
                        if (String.IsNullOrEmpty(res.EMessage))
                        {
                            Person person = new Person
                            {
                                idCard = printId,
                                Nachn = res.EHeader.Nachn,
                                pernr = res.EHeader.Pernr,
                                pffno = res.EHeader.Phfno,
                                sex = res.EHeader.Zhrxb
                            };
                            Fund fund = new Fund(type, paperSourceIndex, person);
                            fund.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(res.EMessage);
                            this.Close();
                            return;
                        }

                    }
                    
                    else
                    {
                        time = 15;//重置定时器时间
                        Timer2_Tick(sender, e);
                        autoPrint();
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
        private void autoPrint()
        {
            List<infoposition> data = new List<infoposition>();
            TableInfo tableInfo = new TableInfo();

            var mess = GraphicsTable.getInfoByInput(type, "", printId, ref data, ref tableInfo, ref printDateParam);
            timer2.Enabled = false;
            waitMsg.Visible = false;
            if (!String.IsNullOrEmpty(mess))
            {
                MessageBox.Show(mess);
                this.Close();
                return;
            }
            /** 判断从邱晨处获取数据是否成功 timer2.Enabled = false; waitMsg.Visible = false;*/
            if (type == 1 || type == 2)
            {
                print printForm = new print(data, type, printId, paperSourceIndex);
                printForm.FormClosed += closeForm;
                printForm.Show();
            }
            if (type == (int)TypeEnum.工资条打印)
            {
                print printForm = new print(data, type, printId, paperSourceIndex, tableInfo);
                printForm.FormClosed += closeForm;
                printForm.Show();
            }

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



        /// <summary>
        /// 设置页面时间减少
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class WebRes
    {
        /**
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
        */
    }
}
