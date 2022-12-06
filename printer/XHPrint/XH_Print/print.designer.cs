namespace XH_Print
{
    partial class print
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(print));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tick = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(274, 230);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(735, 579);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // tick
            // 
            this.tick.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tick.BackgroundImage")));
            this.tick.Location = new System.Drawing.Point(556, 368);
            this.tick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tick.Name = "tick";
            this.tick.Size = new System.Drawing.Size(203, 185);
            this.tick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tick.TabIndex = 7;
            this.tick.TabStop = false;
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.message.Font = new System.Drawing.Font("宋体", 20F);
            this.message.Location = new System.Drawing.Point(274, 612);
            this.message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(735, 122);
            this.message.TabIndex = 11;
            this.message.Text = "  正在打印您的证明\r\n请稍后， 秒后返回主页";
            this.message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // error
            // 
            this.error.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.error.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("error.BackgroundImage")));
            this.error.Location = new System.Drawing.Point(556, 368);
            this.error.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(203, 185);
            this.error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.error.TabIndex = 13;
            this.error.TabStop = false;
            this.error.Click += new System.EventHandler(this.Error_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(960, 630);
            this.Controls.Add(this.error);
            this.Controls.Add(this.message);
            this.Controls.Add(this.tick);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "print";
            this.Text = "print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox tick;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.PictureBox error;
        private System.Windows.Forms.Timer timer2;
    }
}