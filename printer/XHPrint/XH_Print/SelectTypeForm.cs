
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace XH_Print
{
    public partial class SelectForm : Form
    {
        private int type = 0;
        private int time = 30;
        private String printDate = DateTime.Now.ToShortDateString().ToString();
        private int iRetCOM;
        private int iRetUSB;
        private int paperSourceIndex;

        public SelectForm(int type, int com, int usb, int paperSourceIndex)
        {
            this.iRetCOM = com;
            this.iRetUSB = usb;
            this.paperSourceIndex = paperSourceIndex;
            this.type = type;//type为1时，页面为打印聘书的页面；TYPE为2时，页面为打印在职凭证的页面
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
         
        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        



        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

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

        }

        private void Timer3_Tick(object sender, EventArgs e)
        {

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            
            Form2 nf = new Form2(type, iRetCOM, iRetUSB, paperSourceIndex);
            nf.FormClosed += closeForm;
            nf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            time = 30;
           
            InputForm inputForm = new InputForm(type,paperSourceIndex);
            inputForm.FormClosed += closeForm;
            inputForm.Show();
          //  this.Close();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.label1.Text = time.ToString();
            if (time == 0)
            {//30秒内不操作 关闭当前页面
                timer1.Enabled = false;
                this.Close();
            }
            time=time-1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
