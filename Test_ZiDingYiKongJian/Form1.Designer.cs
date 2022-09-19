
namespace Test_ZiDingYiKongJian
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myControl_ZiDingYiKongJian = new Test_ZiDingYiKongJian.MyControl_ZiDingYiKongJian_();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Test_ZiDingYiKongJian.Properties.Resources.fengjing;
            this.pictureBox1.Location = new System.Drawing.Point(382, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // myControl_ZiDingYiKongJian
            // 
            this.myControl_ZiDingYiKongJian.BackColor = System.Drawing.SystemColors.Info;
            this.myControl_ZiDingYiKongJian.Location = new System.Drawing.Point(84, 63);
            this.myControl_ZiDingYiKongJian.Name = "myControl_ZiDingYiKongJian";
            this.myControl_ZiDingYiKongJian.Size = new System.Drawing.Size(229, 100);
            this.myControl_ZiDingYiKongJian.TabIndex = 1;
            this.myControl_ZiDingYiKongJian.TestZiDuan = "这是自定义字段！！";
            this.myControl_ZiDingYiKongJian.MyEvent += new System.EventHandler(this.myControl_ZiDingYiKongJian_MyEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myControl_ZiDingYiKongJian);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

    
        private System.Windows.Forms.PictureBox pictureBox1;
        private MyControl_ZiDingYiKongJian_ myControl_ZiDingYiKongJian;
    }
}

