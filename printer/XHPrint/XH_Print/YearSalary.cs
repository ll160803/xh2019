using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XH_Print
{
    public partial class YearSalary :Form
    {
        private int type;
       // private String IdCard;
        /* 无用代码*/
        private int paperSourceIndex = 0;
        private int iRetCOM = 0;
        private int iRetUSB = 0;

        private int time = 60;
        private Person person;
        private int page = 1;
        private int pageSize = 10;
        private int maxCount = 0;
        private SearchMonthSalary.Zhr00SXs[] searchResult;

        public YearSalary()
        {
            InitializeComponent();
        }

        public YearSalary(int type, int paperSourceIndex, Person person)
        {
            this.type = type;
            this.paperSourceIndex = paperSourceIndex;
            this.person = person;

            InitializeComponent();
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
        private void YearSalary_Load(object sender, EventArgs e)
        {
            lblName.Text = "姓名：  " + person.Nachn;
            lblpernr.Text = "发薪号：" + person.pernr;
            lblidcard.Text = "身份证号：" + person.idCard;
            lblgener.Text = "性别：" + person.sex;
            lblgjj.Text = "公积金号：" + person.pffno;
            DataBindCombox();
           // dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.timer1.Enabled = true;
        }
        public void DataBindCombox()
        {
            IList<string> list = new List<string>();
            list.Add((DateTime.Now.Year).ToString());
            list.Add((DateTime.Now.Year - 1).ToString());
            list.Add((DateTime.Now.Year - 3).ToString());
            list.Add((DateTime.Now.Year - 2).ToString());
            list.Add((DateTime.Now.Year - 4).ToString());
            comboBox1.DataSource = list;
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
                tableInfo.IsHeng = true;
                if (type == (int)TypeEnum.工资条打印)
                {
                    print printForm = new print(data, type, person.idCard, paperSourceIndex, tableInfo);
                    printForm.Show();
                }
                this.Close();
            }

        }
        public void BindData()
        {
           // this.dataGridView1.Rows.Clear();
            int num = 1;
            DataTable dt = new DataTable();
            dt.Columns.Add("工资项目");
            dt.Columns.Add("一月");
            dt.Columns.Add("二月");
            dt.Columns.Add("三月");
            dt.Columns.Add("四月");
            dt.Columns.Add("五月");
            dt.Columns.Add("六月");
            dt.Columns.Add("七月");
            dt.Columns.Add("八月");
            dt.Columns.Add("九月");
            dt.Columns.Add("十月");
            dt.Columns.Add("十一月");
            dt.Columns.Add("十二月");

            foreach (var item in this.searchResult)
            {
                if (num <= page * pageSize && num > (page - 1) * pageSize)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = item.Lgtxt;
                    dr[1] = item.Wt1;
                    dr[2] = item.Wt2;
                    dr[3] = item.Wt3;
                    dr[4] = item.Wt4;
                    dr[5] = item.Wt5;
                    dr[6] = item.Wt6;
                    dr[7] = item.Wt7;
                    dr[8] = item.Wt8;
                    dr[9] = item.Wt9;
                    dr[10] = item.Wt10;
                    dr[11] = item.Wt11;
                    dr[12] = item.Wt12;
                    dt.Rows.Add(dr);
                }
                num++;
            }
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].Width = 150;
            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {
                this.dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            if (maxCount <= page * pageSize)
            {
                this.myFlatButton1.Enabled = false;
            }
            else
            {
                this.myFlatButton1.Enabled = true;
            }
            if (page > 1)
            {
                this.button4.Enabled = true;
            }
            else
            {
                this.button4.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            
            try
            {
                SearchMonthSalary.ZHR00_CW4 zHR00_CW4 = new SearchMonthSalary.ZHR00_CW4();
                SearchMonthSalary.Zhr00FmGzdyj3 inputParam = new SearchMonthSalary.Zhr00FmGzdyj3();
                inputParam.Icnum = person.idCard;
                inputParam.Year = this.comboBox1.SelectedValue.ToString();
                inputParam.Month = "00";
                inputParam.TNd = new SearchMonthSalary.Zhr00SXs[10];
                inputParam.TGzt = new SearchMonthSalary.Zhr00SGztprint[10];
                var res = zHR00_CW4.Zhr00FmGzdyj3(inputParam);
                searchResult = res.TNd;
               
                if (String.IsNullOrEmpty(res.EMessage))
                {
                    maxCount = res.TNd.Length;
                    BindData();
                    lblName.Text = "姓名：  " + res.EHeader.Nachn;
                    lblpernr.Text = "发薪号：" + res.EHeader.Pernr;
                    lblidcard.Text = "身份证号：" + res.EHeader.Icnum;
                    lblgener.Text = "性别：" + res.EHeader.Zhrxb;
                    lblgjj.Text = "公积金号：" + res.EHeader.Phfno;
                    time = 60;
                    
                }
                else
                {
                    MessageBox.Show(res.EMessage);
                }
                
                time = 60;
            }
            catch (Exception ex)
            {

            }
            this.timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.comboBox1.SelectedValue.ToString()))
            {
                MessageBox.Show("请选择年度");
            }
            else
            {
                AutoPrint(this.comboBox1.SelectedValue.ToString(),"00");
                this.timer1.Enabled = false;
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            //dataGridView1.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page = page - 1;
            }
            BindData();
            this.time = 90;
        }

        private void myFlatButton1_Click(object sender, EventArgs e)
        {
            page = page + 1;

            BindData();
            this.time = 90;
        }
    }
}