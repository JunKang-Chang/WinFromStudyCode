//这里面写的是属性和事件的代码！！！！！！！！！
namespace Test1
{
    partial class MyForm
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
            this.but1 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(443, 96);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(245, 93);
            this.but1.TabIndex = 0;
            this.but1.Text = "testhello";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.testClick);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(443, 406);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(317, 156);
            this.bt3.TabIndex = 1;
            this.bt3.Text = "手动处理事件";
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "语文",
            "数学"});
            this.cb1.Location = new System.Drawing.Point(484, 351);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 20);
            this.cb1.TabIndex = 2;
            this.cb1.Text = "请选择下拉项";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 662);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.but1);
            this.Name = "MyForm";
            this.Text = "test123";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.ComboBox cb1;
    }
}

