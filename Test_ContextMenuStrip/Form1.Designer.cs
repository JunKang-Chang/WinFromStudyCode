
namespace Test_ContextMenuStrip
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
            this.components = new System.ComponentModel.Container();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.c1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.测试右键菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c1_show = new System.Windows.Forms.ToolStripMenuItem();
            this.c1_dontshow = new System.Windows.Forms.ToolStripMenuItem();
            this.c1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 12;
            this.lb1.Items.AddRange(new object[] {
            "小明",
            "小红",
            "小李"});
            this.lb1.Location = new System.Drawing.Point(171, 105);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(285, 136);
            this.lb1.TabIndex = 0;
            this.lb1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lb1_MouseUp);
            // 
            // c1
            // 
            this.c1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试右键菜单ToolStripMenuItem,
            this.c1_show,
            this.c1_dontshow});
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(149, 70);
            // 
            // 测试右键菜单ToolStripMenuItem
            // 
            this.测试右键菜单ToolStripMenuItem.Name = "测试右键菜单ToolStripMenuItem";
            this.测试右键菜单ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.测试右键菜单ToolStripMenuItem.Text = "测试右键菜单";
            // 
            // c1_show
            // 
            this.c1_show.Name = "c1_show";
            this.c1_show.Size = new System.Drawing.Size(148, 22);
            this.c1_show.Text = "显示";
            // 
            // c1_dontshow
            // 
            this.c1_dontshow.Name = "c1_dontshow";
            this.c1_dontshow.Size = new System.Drawing.Size(148, 22);
            this.c1_dontshow.Text = "要隐藏";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 333);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.c1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ContextMenuStrip c1;
        private System.Windows.Forms.ToolStripMenuItem 测试右键菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c1_show;
        private System.Windows.Forms.ToolStripMenuItem c1_dontshow;
    }
}

