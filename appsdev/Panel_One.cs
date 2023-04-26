using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appsdev
{
    public partial class Panel_One : UserControl
    {
        public Panel_One()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form1;
            parent.putValueFirst = textBox1.Text;
            parent.putValueSecond = textBox2.Text;
        }
    }
}
