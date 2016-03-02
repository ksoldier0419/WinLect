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
    public partial class Form2 : Form
    {
        public string str;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)Owner;
            f1.str = this.textBox1.Text;
            this.Close();
        }
    }
}
