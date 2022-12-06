using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace XH_Print
{
    public partial class InputForm : Form
    {
        public String code;
        private int type = 0;
        private int paperSourceIndex = 1;
        private String printId = "";
        private int time = 30;
        public InputForm(int type,  int paperSourceIndex)
        {
            this.type = type;
            this.paperSourceIndex = paperSourceIndex;
           
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void autoPrint(int type, string code)
        {
            List<infoposition> data = new List<infoposition>();
          
           var mess= GraphicsTable.getInfoByInput(type, code, "", ref data);
            if (String.IsNullOrEmpty(mess))
            {
                this.timer1.Enabled = false;
                print printForm = new print(data, type, printId, paperSourceIndex);
                printForm.FormClosed += closeForm;
                printForm.Show();
            }
            else
            {
                MessageBox.Show(mess);
                this.Close();
            }
           
           
        }
        public void closeForm(Object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label3.Text = time.ToString();
            if (time == 0)
            {
                this.Close();
            }
            time = time - 1;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;//30秒内 必须完成操作 不然退回首届面
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
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(this.textBox3.Text))
                {
                    MessageBox.Show("请输入正确的识别码");
                }
                else
                {
                    time = 30;//重新回到30秒开始计时
                    autoPrint(type, this.textBox3.Text);
                }
            }

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(this.textBox3.Text))
                {
                    MessageBox.Show("请输入正确的识别码");
                }
                else
                {
                    time = 30;//重新回到30秒开始计时
                    autoPrint(type, this.textBox3.Text);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String txtCode = this.textBox3.Text;
            if (!String.IsNullOrEmpty(txtCode))
            {
                if (txtCode.Length == 1)
                {
                    txtCode = "";
                }
                else
                {
                    txtCode = txtCode.Substring(0, txtCode.Length - 1);
                }
                this.textBox3.Text = txtCode;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GetCode("1");
        }
        private void GetCode(String key)
        {
            String txtCode = this.textBox3.Text + key;
            this.textBox3.Text = txtCode ;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GetCode("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetCode("3");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetCode("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetCode("5");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetCode("6");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GetCode("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GetCode("8");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetCode("9");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GetCode("0");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox3.Text))
            {
                MessageBox.Show("请输入正确的识别码");
            }
            else
            {
                time = 30;//重新回到30秒开始计时
                autoPrint(type, this.textBox3.Text);
            }
        }
    }
}
