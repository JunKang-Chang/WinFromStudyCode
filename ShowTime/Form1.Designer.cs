
namespace ShowTime
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
            this.bt1 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(58, 42);
            this.bt1.Margin = new System.Windows.Forms.Padding(4);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(284, 93);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "显示当前时间";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.onButtonClicked);
            this.bt1.Click += new System.EventHandler(this.showMessage);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(484, 75);
            this.tb1.Margin = new System.Windows.Forms.Padding(4);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(282, 28);
            this.tb1.TabIndex = 1;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 178);
            this.button1.TabIndex = 2;
            this.button1.Text = "测试订阅同一事件处理器,功能同上:显示时间";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1959, 868);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.bt1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button button1;
    }
}
