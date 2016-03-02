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
                    //tmp = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
                    tmp = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                    break;
            }            
            textBox3.Text = tmp.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //아직 폼에 컨트롤이 모두 올라오지 않은 시점
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("sd");
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                MessageBox.Show("sd");
            }
            if (e.KeyCode == Keys.F1)
                MessageBox.Show("sd");
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("+");
                this.button1_Click(sender, e);
            }
            if (e.KeyCode == Keys.D0)
                MessageBox.Show("+");
        }


        private void textBox1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
