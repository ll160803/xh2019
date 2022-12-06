using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XH_Print
{
    public partial class HistorySalary : Form
    {
        private int type;
        // private String IdCard;
        /* 无用代码*/
        private int paperSourceIndex = 0;
        private int iRetCOM = 0;
        private int iRetUSB = 0;
        private Person person;
        private int page = 1;
        private int pageSize = 8;
        private int maxCount = 0;
        private int time = 30;
        private SearchMonthSalary.Zhr00SGztprint[] searchResult;
        public HistorySalary(int type, int paperSourceIndex, Person person)
        {
            this.type = type;
            this.paperSourceIndex = paperSourceIndex;
            this.person = person;

            InitializeComponent();
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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void HistorySalary_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.comboBox1.SelectedValue.ToString()) || String.IsNullOrEmpty(this.comboBox2.SelectedValue.ToString()))
            {
                MessageBox.Show("请选择年月");
            }
            else
            {
                AutoPrint(this.comboBox1.SelectedValue.ToString(), this.comboBox2.SelectedValue.ToString());
                this.timer1.Enabled = false;
                this.Close();
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.timer1.Enabled = false;
                SearchMonthSalary.ZHR00_CW4 zHR00_CW4 = new SearchMonthSalary.ZHR00_CW4();
                SearchMonthSalary.Zhr00FmGzdyj3 inputParam = new SearchMonthSalary.Zhr00FmGzdyj3();
                inputParam.Icnum = person.idCard;
                inputParam.Month = this.comboBox2.SelectedValue.ToString();
                inputParam.Year = this.comboBox1.SelectedValue.ToString();
                inputParam.TGzt = new SearchMonthSalary.Zhr00SGztprint[10];
                var res = zHR00_CW4.Zhr00FmGzdyj3(inputParam);



                if (String.IsNullOrEmpty(res.EMessage))
                {
                    time = 60;
                    maxCount = res.TGzt.Length;
                    this.searchResult = res.TGzt;

                    lblName.Text = "姓名：  " + res.EHeader.Nachn;
                    lblpernr.Text = "发薪号：" + res.EHeader.Pernr;
                    lblidcard.Text = "身份证号：" + res.EHeader.Icnum;
                    lblgener.Text = "性别：" + res.EHeader.Zhrxb;
                    lblgjj.Text = "公积金号：" + res.EHeader.Phfno;



                    foreach (var item in this.comboBox1.Items)
                    {
                        if (item.ToString() == res.EHeader.Year)
                        {
                            this.comboBox1.SelectedItem = item;
                        }
                    }
                    foreach (var item2 in this.comboBox2.Items)
                    {
                        if (item2.ToString() == res.EHeader.Month)
                        {
                            this.comboBox2.SelectedItem = item2;
                        }
                    }
                    BindData();
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

    public class YearMonth
    {
        public string monthtext;
        public String month;
    }
}