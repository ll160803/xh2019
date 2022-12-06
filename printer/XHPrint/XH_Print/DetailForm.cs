using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XH_Print
{
    public partial class DetailForm : Form
    {
        private int time = 60;
        private int page = 1;
        private int pageSize = 6;
        private int maxCount = 0;
        private detailFund.Zfi02S025[] result;
        public DetailForm(detailFund.Zfi02S025[] result2)
        {
            this.result = result2;
            InitializeComponent();
        }
        public void BindData()
        {
            this.dataGridView1.Rows.Clear();
            int num = 1;
            maxCount = this.result.Length;
            foreach (var item in this.result)
            {
                if (num <= page * pageSize && num > (page - 1) * pageSize)
                {
                    string[] row = new string[] { item.Zjfxb, item.Budat, item.Dmbtr.ToString("f2") ,item.Bktxt};
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
                this.button3.Enabled = false;
            }
            else
            {
                this.button3.Enabled = true;
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

           
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            BindData();
            this.timer1.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (time < 0)
            {
                this.timer1.Enabled = false;
                this.Close();
            }
            time = time - 1;
            this.lbltime.Text = time.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page = page - 1;
            }
            BindData();
            this.time = 30;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            page = page + 1;

            BindData();
            this.time = 30;
        }
    }
}