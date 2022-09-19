//这里面写的是方法的代码(逻辑)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class MyForm : Form
    {
        private Button b2 = new Button();
        public MyForm()
        {
            InitializeComponent();//初始化

            
            
            //手动添加组件
            this.Text = "title";//标题
            this.Controls.Add(b2);
            b2.Text = "myButton";
            b2.Location = new Point(50, 50);
            b2.Size = new Size(100, 80);



           
            
            //事件+=委托(对事件的处理)                 （委托回调方法）
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
           

        }



        private void testClick(object sender, EventArgs e)
        {
            MessageBox.Show("hello!");
        }



        //回调的方法
        private void bt3_Click(object sender, EventArgs e)
        {
            if ((string)cb1.SelectedItem == "语文")
            {
                MessageBox.Show("手动show:  语文");

            }
            else if ((string)cb1.SelectedItem == "数学")
            {
                MessageBox.Show("手动show:  数学");
            }
        }
     
     
        }
    }

