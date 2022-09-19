using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb1_Click(object sender, EventArgs e)
        {

        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked) { tb1.PasswordChar = '\0'; }
            else                     { tb1.PasswordChar = '*'; }
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
