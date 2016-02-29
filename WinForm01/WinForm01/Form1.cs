using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float tmp=0;
            switch (comboBox1.Text)
            {
                case "+":
                    tmp = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                    break;
                case "-":
                    tmp = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                    break;
                case "*":
                    tmp = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                    break;
                case "/":
                    tmp = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
                    break;
            }            
            textBox3.Text = tmp.ToString();
        }
    }
}
