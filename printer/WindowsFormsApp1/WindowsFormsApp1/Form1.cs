using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsApp1
{

    public partial class readCode : Form
    {
        private List<int> paperSourceList;
        private int iRetUSB;
        private int iRetCOM;
        AutoSizeFormClass asc = new AutoSizeFormClass();
        [DllImport("termb.DLL", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CVR_InitComm(int Port);
        public readCode()
        {
            InitializeComponent();

        }

        private void readCode_Load(object sender, EventArgs e)
        {
            //读取txt文件里的设置纸盒路径，txt文件要和exe执行文件在同一目录。这里在\WindowsFormsApp1\bin\Debug目录下
            readPaperSource();
            //读取到打印机连接的硬件接口并测试连接
            int iPort;
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
            }
            if ((iRetCOM == 1) || (iRetUSB == 1))
            { }
            else
            {
                MessageBox.Show("连接失败，请检查读卡器和主机的连接");
                this.Close();
            }
            InitInstance(this);
        }

        private void readCode_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //进入打印入职证书界面
            Console.WriteLine(paperSourceList[0]);
            Form2 nf = new Form2(1,iRetCOM,iRetUSB, paperSourceList[0]);
            nf.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static void InitInstance(System.Windows.Forms.Form form)
        {
            System.Drawing.Rectangle rect = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            int h = rect.Height; //高（像素）
            int w = rect.Width;  //宽（像素）
            foreach (Control c in form.Controls)
            {
                // 1920*1080  为当前窗体设计的尺寸
                c.Size = new Size((int)(c.Width * w / 1280), (int)(c.Height * h / 1024));
                c.Location = new Point((int)(c.Left * w / 1280), (int)(c.Top * h / 1024));
                Single size = Convert.ToSingle(c.Font.Size * h / 1024);
                c.Font = new Font(c.Font.Name, size, c.Font.Style, c.Font.Unit);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //进入打印在职证明界面
            Form2 nf = new Form2(2, iRetCOM, iRetUSB,paperSourceList[1]);
            nf.Show();
        }

        private void readPaperSource()
        { this.paperSourceList = new List<int>();
            StreamReader sr = new StreamReader("paper_source.txt", Encoding.Unicode);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                this.paperSourceList.Add(int.Parse(line));
            }
        }
    }

    class AutoSizeFormClass
    {
        //(1).声明结构,只记录窗体和其控件的初始位置和大小。  
        public struct controlRect
        {
            public int Left;
            public int Top;
            public int Width;
            public int Height;
        }
        //(2).声明 1个对象  
        //注意这里不能使用控件列表记录 List<Control> nCtrl;，因为控件的关联性，记录的始终是当前的大小。  
        public List<controlRect> oldCtrl;
        //int ctrl_first = 0;  
        //(3). 创建两个函数  
        //(3.1)记录窗体和其控件的初始位置和大小,  
        public void controllInitializeSize(Form mForm)
        {
            // if (ctrl_first == 0)  
            {
                //  ctrl_first = 1;  
                oldCtrl = new List<controlRect>();
                controlRect cR;
                cR.Left = mForm.Left; cR.Top = mForm.Top; cR.Width = mForm.Width; cR.Height = mForm.Height;
                oldCtrl.Add(cR);
                foreach (Control c in mForm.Controls)
                {
                    controlRect objCtrl;
                    objCtrl.Left = c.Left; objCtrl.Top = c.Top; objCtrl.Width = c.Width; objCtrl.Height = c.Height;
                    oldCtrl.Add(objCtrl);
                }
            }
            // this.WindowState = (System.Windows.Forms.FormWindowState)(2);//记录完控件的初始位置和大小后，再最大化  
            //0 - Normalize , 1 - Minimize,2- Maximize  
        }
        //(3.2)控件自适应大小,  
        public void controlAutoSize(Form mForm)
        {
            //int wLeft0 = oldCtrl[0].Left; ;//窗体最初的位置  
            //int wTop0 = oldCtrl[0].Top;  
            ////int wLeft1 = this.Left;//窗体当前的位置  
            //int wTop1 = this.Top;  
            float wScale = (float)mForm.Width / (float)oldCtrl[0].Width;//新旧窗体之间的比例，与最早的旧窗体  
            float hScale = (float)mForm.Height / (float)oldCtrl[0].Height;//.Height;  
            int ctrLeft0, ctrTop0, ctrWidth0, ctrHeight0;
            int ctrlNo = 1;//第1个是窗体自身的 Left,Top,Width,Height，所以窗体控件从ctrlNo=1开始  
            foreach (Control c in mForm.Controls)
            {
                ctrLeft0 = oldCtrl[ctrlNo].Left;
                ctrTop0 = oldCtrl[ctrlNo].Top;
                ctrWidth0 = oldCtrl[ctrlNo].Width;
                ctrHeight0 = oldCtrl[ctrlNo].Height;
                //c.Left = (int)((ctrLeft0 - wLeft0) * wScale) + wLeft1;//新旧控件之间的线性比例  
                //c.Top = (int)((ctrTop0 - wTop0) * h) + wTop1;  
                c.Left = (int)((ctrLeft0) * wScale);//新旧控件之间的线性比例。控件位置只相对于窗体，所以不能加 + wLeft1  
                c.Top = (int)((ctrTop0) * hScale);//  
                c.Width = (int)(ctrWidth0 * wScale);//只与最初的大小相关，所以不能与现在的宽度相乘 (int)(c.Width * w);  
                c.Height = (int)(ctrHeight0 * hScale);//  
                ctrlNo += 1;
            }
        }
    }

}
