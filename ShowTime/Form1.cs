using System;
using System.Windows.Forms;

namespace ShowTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onButtonClicked(object sender, EventArgs e)
        {//测试一个事件处理器可以被不同按钮的同一种事件订阅
            if (sender==this.bt1)
            {
                string showTimestr = DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss");
                tb1.Text = showTimestr;
            }

            if (sender == this.button1)
            {
                MessageBox.Show("和bt1订阅了同一个事件处理器,也能show时间");
                string showTimestr = DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss");
                tb1.Text = showTimestr;
            }
        }

        private void showMessage(object sender, EventArgs e)
        {
            MessageBox.Show("测试订阅了多个事件处理器！");
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}