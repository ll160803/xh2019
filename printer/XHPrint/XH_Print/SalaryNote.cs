using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XH_Print
{
    public partial class SalaryNote : Form
    {
        private int type;
        /* 无用代码*/
        private int paperSourceIndex = 0;
        private int iRetCOM = 0;
        private int iRetUSB = 0;

        private int time = 30;
       // private String IdCard;
        private Person person;

        public SalaryNote(int type , int paperSourceIndex, Person person)
        {
            this.type = type;
            this.paperSourceIndex = paperSourceIndex;
            this.person = person;
           // this.IdCard = IdCard;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public void closeForm(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutoPrint(DateTime.Now.Year.ToString(), "LA");
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
        private void AutoPrint(String year, String month)
        {
            List<infoposition> data = new List<infoposition>();
            TableInfo tableInfo = new TableInfo();
            PrintDateParam printDateParam = new PrintDateParam();
            printDateParam.year = year;
            printDateParam.month = month;
            var mess = GraphicsTable.getInfoByInput(type, "", person.idCard, ref data, ref tableInfo, ref printDateParam);
            if (!String.IsNullOrEmpty(mess))
            {
                MessageBox.Show(mess);
                this.Close();
            }
            else
            {
                if (type == (int)TypeEnum.工资条打印)
                {
                    print printForm = new print(data, type, person.idCard, paperSourceIndex, tableInfo);
                    printForm.FormClosed += closeForm;
                    printForm.Show();
                }
                this.Close();
            }

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

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void SalaryNote_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HistorySalary historySalary = new HistorySalary(type,paperSourceIndex, person);
            historySalary.FormClosed += closeForm;
            historySalary.Show();
           // this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YearSalary yearSalary =new YearSalary(type, paperSourceIndex, person);
            yearSalary.FormClosed += closeForm;
            yearSalary.Show();
           // this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}