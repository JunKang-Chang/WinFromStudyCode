using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
/*
 Anchor的英文意思是锚定。表示在窗体重置时控件与窗体(或者父控件)的
相对位置保持不变。控件变化要等到窗体重置的时候才能呈现。
 
Dock则是停泊的意思，表示控件的某个边与窗体重合（零距离）。控件的
变化则在设计的时候就能呈现。此外控件的DocK循序会影像到结果。
 */