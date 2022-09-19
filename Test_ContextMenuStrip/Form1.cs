using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_ContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int i = lb1.IndexFromPoint(e.Location);
                if (i >= 0)
                {
                    lb1.SetSelected(i, true);
                    c1_show.Enabled = true;
                    c1_dontshow.Enabled = true;
                }
                else
                {
                    
                    c1_dontshow.Enabled = false;
                }



                c1.Show(lb1, e.Location);
            }
        }
    }
}
