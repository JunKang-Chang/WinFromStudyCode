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
    public partial class MyControl_ZiDingYiKongJian_ : UserControl
    {
        public MyControl_ZiDingYiKongJian_()
        {
            InitializeComponent();


        }

        private string testZiDuan;
        //自定义属性
        public string TestZiDuan
        {
            get {
                return testZiDuan;
            }

            set {
                testZiDuan = value;
            }
        }


        //自定义事件
        public event EventHandler MyEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            if (MyEvent != null)
            {
                MyEvent.Invoke(this, e);
            }
        }
    }
}
