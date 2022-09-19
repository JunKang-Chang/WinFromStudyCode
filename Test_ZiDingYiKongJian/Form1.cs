using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_ZiDingYiKongJian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void myControl_ZiDingYiKongJian_MyEvent(object sender, EventArgs e)
        {
            MessageBox.Show("调用了自定义事件的方法!");
        }
    }
}
