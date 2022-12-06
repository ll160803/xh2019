using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XH_Print
{
    public partial class FundResult : Form
    {
        private int time = 90;
        private int page = 1;
        private int pageSize = 8;
        private int maxCount = 0;
        private accountFundSearch.Zfi02S026[] result;

        private Button btn = new Button();

        public FundResult(accountFundSearch.Zfi02S026[] result2)
        {
            this.result = result2;
            this.maxCount = this.result.Length;
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
        public void BindData()
        {
            this.dataGridView1.Rows.Clear();
            int num = 1;
            foreach (var item in this.result)
            {
                if (num <= page * pageSize && num > (page - 1) * pageSize)
                {
                    string[] row = new string[] { item.Zjfid, item.Zltext, item.Dmbtr.ToString("f2") };
                    this.dataGridView1.Rows.Add(row);
                }
                num++;
            }
            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {
                this.dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            if (maxCount <= page * pageSize)
            {
                this.button2.Enabled = false;
            }
            else
            {
                this.button2.Enabled = true;
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
        private void button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.listView1.SelectedItems[0].SubItems[0].Text);
        }

        private void FundResult_Load(object sender, EventArgs e)
        {

            BindData();
            this.timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "cz" && e.RowIndex >= 0)
            {
                //说明点击的列是DataGridViewButtonColumn列
                try
                {
                    detailFund.ZFI02_WS_JFMX zFI02_WS_JFMX = new detailFund.ZFI02_WS_JFMX();
                    detailFund.Zfi02FmJfmx inputParam = new detailFund.Zfi02FmJfmx();
                    inputParam.IbBudat = "2018-01-01";
                    inputParam.IeBudat = DateTime.Now.ToString("yyyy-MM-dd");
                    inputParam.IAufex = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    detailFund.Zfi02S025[] output = new detailFund.Zfi02S025[10];
                    inputParam.EtSzmx = output;
                    var res = zFI02_WS_JFMX.Zfi02FmJfmx(inputParam);
                    this.time = 90;
                    DetailForm detailForm = new DetailForm(res.EtSzmx);
                    detailForm.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("请联系管理员");
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page = page - 1;
            }
            BindData();
            this.time = 90;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            page = page + 1;

            BindData();
            this.time = 90;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}