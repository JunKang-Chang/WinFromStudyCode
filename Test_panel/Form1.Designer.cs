
namespace Test_panel
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pa1 = new System.Windows.Forms.Panel();
            this.pa2 = new System.Windows.Forms.Panel();
            this.pa3 = new System.Windows.Forms.Panel();
            this.bt1 = new System.Windows.Forms.Button();
            this.pa4 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pa3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pa1
            // 
            this.pa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pa1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pa1.Location = new System.Drawing.Point(0, 0);
            this.pa1.Name = "pa1";
            this.pa1.Size = new System.Drawing.Size(160, 615);
            this.pa1.TabIndex = 0;
            // 
            // pa2
            // 
            this.pa2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pa2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pa2.ForeColor = System.Drawing.Color.Black;
            this.pa2.Location = new System.Drawing.Point(160, 0);
            this.pa2.Name = "pa2";
            this.pa2.Size = new System.Drawing.Size(1144, 86);
            this.pa2.TabIndex = 1;
            // 
            // pa3
            // 
            this.pa3.BackColor = System.Drawing.Color.Aqua;
            this.pa3.Controls.Add(this.bt1);
            this.pa3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pa3.Location = new System.Drawing.Point(160, 86);
            this.pa3.Name = "pa3";
            this.pa3.Size = new System.Drawing.Size(986, 529);
            this.pa3.TabIndex = 2;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(49, 26);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(136, 54);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "button1";
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // pa4
            // 
            this.pa4.BackColor = System.Drawing.Color.LightPink;
            this.pa4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pa4.Location = new System.Drawing.Point(1146, 86);
            this.pa4.Name = "pa4";
            this.pa4.Size = new System.Drawing.Size(158, 529);
            this.pa4.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1310, 334);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 615);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pa4);
            this.Controls.Add(this.pa3);
            this.Controls.Add(this.pa2);
            this.Controls.Add(this.pa1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pa3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pa1;
        private System.Windows.Forms.Panel pa2;
        private System.Windows.Forms.Panel pa3;
        private System.Windows.Forms.Panel pa4;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

