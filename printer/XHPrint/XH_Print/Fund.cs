using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XH_Print
{
    public partial class Fund : Form
    {
        private int type;
        /* 无用代码*/
        private int paperSourceIndex = 0;
        private int iRetCOM = 0;
        private int iRetUSB = 0;
        private int page = 1;
        private int pageSize = 10;
        private int maxCount = 0;
        private int time = 30;
        // private String IdCard;
        private Person person;
        private JxSearch.Zhr00SJxdy[] searchResult;

        public Fund(int type, int paperSourceIndex, Person person)
        {
            this.type = type;
            this.paperSourceIndex = paperSourceIndex;
            this.person = person;
            // this.IdCard = IdCard;
            InitializeComponent();
        }

        private void Fund_Load(object sender, EventArgs e)
        {
            lblName.Text = "姓名：  " + person.Nachn;
            lblpernr.Text = "发薪号：" + person.pernr;
            lblidcard.Text = "身份证号：" + person.idCard;
            lblgener.Text = "性别：" + person.sex;
            lblgjj.Text = "公积金号：" + person.pffno;
            DataBindCombox();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.timer1.Enabled = true;
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
        public void BindData()
        {
            // this.dataGridView1.Rows.Clear();
            int num = 1;
            DataTable dt = new DataTable();
            dt.Columns.Add("绩效项目");
            dt.Columns.Add("金额");

            foreach (var item in this.searchResult)
            {
                if (num <= page * pageSize && num > (page - 1) * pageSize)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = item.Lgtxt;
                    dr[1] = item.Betrg;
                    dt.Rows.Add(dr);
                }
                num++;
            }
            this.dataGridView1.DataSource = dt;
            //this.dataGridView1.Columns[0].Width = 150;
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
        public void DataBindCombox()
        {
            IList<string> list = new List<string>();




            list.Add((DateTime.Now.Year).ToString());
            list.Add((DateTime.Now.Year - 1).ToString());
            list.Add((DateTime.Now.Year - 3).ToString());
            list.Add((DateTime.Now.Year - 2).ToString());
            list.Add((DateTime.Now.Year - 4).ToString());
            comboBox1.DataSource = list;

            List<String> infoList = new List<String>();

            infoList.Add("01");
            infoList.Add("02");
            infoList.Add("03");
            infoList.Add("04");
            infoList.Add("05");
            infoList.Add("06");
            infoList.Add("07");
            infoList.Add("08");
            infoList.Add("09");
            infoList.Add("10");
            infoList.Add("11");
            infoList.Add("12");



            comboBox2.DataSource = infoList;
            int month = DateTime.Now.Month - 1;
            comboBox2.SelectedIndex = month;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.timer1.Enabled = false;
                JxSearch.ZHR00_CW5 zHR00_CW5 = new JxSearch.ZHR00_CW5();

                JxSearch.Zhr00FmLwfcxj inputParam = new JxSearch.Zhr00FmLwfcxj();
                inputParam.Icnum = person.idCard;
                inputParam.Month = this.comboBox2.SelectedValue.ToString();
                inputParam.Year = this.comboBox1.SelectedValue.ToString();
                inputParam.TCx = new JxSearch.Zhr00SJxdy[10];
                var res = zHR00_CW5.Zhr00FmLwfcxj(inputParam);



                if (String.IsNullOrEmpty(res.EMessage))
                {
                    time = 60;

                    maxCount = res.TCx.Length;
                    this.searchResult = res.TCx;
                    BindData();
                    lblName.Text = "姓名：  " + res.EHeader.Nachn;
                    lblpernr.Text = "发薪号：" + res.EHeader.Pernr;
                    lblidcard.Text = "身份证号：" + res.EHeader.Icnum;
                    lblgener.Text = "性别：" + res.EHeader.Zhrxb;
                    lblgjj.Text = "公积金号：" + res.EHeader.Phfno;


                }
                else
                {
                    MessageBox.Show(res.EMessage);
                }
                this.timer1.Enabled = true;
            }
            catch (Exception ex)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page = page - 1;
            }
            BindData();
            this.time = 60;
        }

        private void myFlatButton1_Click(object sender, EventArgs e)
        {
            page = page + 1;

            BindData();
            this.time = 60;
        }
    }
}