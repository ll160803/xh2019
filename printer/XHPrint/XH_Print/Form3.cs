using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XH_Print
{
    public partial class Form3 : Form
    {
        private int time = 60;
        private int y = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time < 0)
            {
                this.timer1.Enabled = false;
                this.Close();
            }
            time = time - 1;
            this.lbltime.Text = time.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            this.timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Scroll(object sender, ScrollEventArgs e)
        {
            y = this.VerticalScroll.Value;
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            this.VerticalScroll.Value = y;
        }
    }
}
