using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm09
{
    public partial class Form1 : Form
    {
        public string str;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            
            f2.Owner = this;

            f2.str = this.textBox1.Text;

            if (f2.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = str;
            }
        }
    }
}
