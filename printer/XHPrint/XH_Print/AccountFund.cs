using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace XH_Print
{
    public partial class AccountFund : Form
    {
        
        /* 无用代码*/
      

        private int time = 90;
        // private String IdCard;
        private Person person;

        public AccountFund()
        {
           
            // this.IdCard = IdCard;
            InitializeComponent();
        }
        private int index = 0;
        

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            this.index = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.index = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetCode("1");
        }
        private void GetCode(String key)
        {
            if (this.index == 0)
            {
                String txtCode = this.textBox3.Text + key;
                this.textBox3.Text = txtCode;
            }
            if (this.index == 1)
            {
                String txtCode = this.textBox1.Text + key;
                this.textBox1.Text = txtCode;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetCode("2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetCode("3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetCode("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetCode("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetCode("6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetCode("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GetCode("8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GetCode("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GetCode("0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (this.index == 0)
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
            if (this.index == 1)
            {
                String txtCode = this.textBox1.Text;
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
                    this.textBox1.Text = txtCode;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountFund_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.textBox3.Focus();
            this.index = 0;
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
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                this.time = 60;
                accountFundSearch.ZFI02_WS_JFDD searchAccount = new accountFundSearch.ZFI02_WS_JFDD();

                accountFundSearch.Zfi02FmJfdd inputParam = new accountFundSearch.Zfi02FmJfdd();
                inputParam.ICardid = this.textBox3.Text;
                inputParam.IPasswd = this.textBox1.Text;
                accountFundSearch.Zfi02S026[] output = new accountFundSearch.Zfi02S026[10];
                inputParam.TAufk = output;
                var response = searchAccount.Zfi02FmJfdd(inputParam);
                if (response.OsMsg.Msgty == "E")
                {
                    MessageBox.Show(response.OsMsg.Msgtx);
                    this.Close();
                }
                else
                {
                    FundResult fundResult = new FundResult(response.TAufk);
                    fundResult.Show();
                    this.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("请联系管理员");
                this.Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time == 0)
            {
                this.timer1.Enabled = false;
                this.Close();
            }
            time = time - 1;
            this.lbltime.Text = time.ToString();
        }
    }
}