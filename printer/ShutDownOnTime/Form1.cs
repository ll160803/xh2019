using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShutDownOnTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime closedt = DateTime.Now;
            int hour = 17;
            int min = 30;

            //当时间小于当前时认为是第二天的时间
            if (hour < DateTime.Now.Hour)
            {
                string strdt = DateTime.Now.AddDays(1D).ToString("yyyy-MM-dd") + " " + hour.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0');
                closedt = Convert.ToDateTime(strdt);

            }
            else
            {
                string strdt = DateTime.Now.ToString("yyyy-MM-dd") + " " + hour.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0');
                closedt = Convert.ToDateTime(strdt);
            }
            //计算出时间差
            int total = Convert.ToInt32((closedt - DateTime.Now).TotalSeconds);
            OperateComputer("shutdown -s -f -t " + total); //-f 强制关机 而不提示关机时间
            this.timer1.Enabled = true;
        }
        /// <summary>
        /// 操作电脑命令
        /// </summary>
        /// <param name="command"></param>
        private void OperateComputer(string command)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            var myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo = startInfo;
            myProcess.Start();
            myProcess.StandardInput.WriteLine(command);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
