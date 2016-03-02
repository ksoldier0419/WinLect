using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;


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
            try
            {
                double tmp = 0;
                switch (comboBox1.Text)
                {
                    case "+":
                        tmp = double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
                        break;
                    case "-":
                        tmp = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
                        break;
                    case "*":
                        tmp = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
                        break;
                    case "/":
                        if (Convert.ToDouble(textBox2.Text) == 0)
                        {
                            MessageBox.Show("Dived 0 Error!");
                            break;
                        }
                        tmp = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                        break;
                }
                textBox3.Text = tmp.ToString();
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Debug" + ex);
            }
         
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
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                textBox2.SelectAll();
            }
            
            if (e.KeyCode == Keys.Subtract)
            {
                comboBox1.SelectedIndex = 1;
                textBox2.Focus();
                textBox2.SelectAll();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                comboBox1.SelectedIndex = 2;
                textBox2.Focus();
                textBox2.SelectAll();
            }
            if (e.KeyCode == Keys.Divide)
            {
                comboBox1.SelectedIndex = 3;
                textBox2.Focus();
                textBox2.SelectAll();
            }
            if (e.KeyCode == Keys.Add)
            {
                comboBox1.SelectedIndex = 0;
                textBox2.Focus();
                textBox2.SelectAll();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1_Click(sender, e);
                textBox1.Focus();
                textBox1.SelectAll();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                comboBox1.SelectedIndex = 1;
                textBox2.Focus();
                textBox2.SelectAll();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                comboBox1.SelectedIndex = 2;
                textBox2.Focus();
                textBox2.SelectAll();
            }
            if (e.KeyCode == Keys.Divide)
            {
                comboBox1.SelectedIndex = 3;
                textBox2.Focus();
                textBox2.SelectAll();
            }
            if (e.KeyCode == Keys.Add)
            {
                comboBox1.SelectedIndex = 0;
                textBox2.Focus();
                textBox2.SelectAll();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
                    if (!(e.KeyChar == Convert.ToChar(Keys.Delete)))
                    {
                        e.Handled = true;  //버블링 없음. 여기서 처리했음
                    }
            }
            if (textBox1.Text == "0")
            {
                if (!(e.KeyChar == Convert.ToChar(Keys.Delete)))
                {
                    textBox1.Text = "";// Convert.ToString(e.KeyChar);
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
                    if (!(e.KeyChar == Convert.ToChar(Keys.Delete)))
                    {
                        e.Handled = true;  //버블링 없음. 여기서 처리했음
                    }
            }
            if (textBox2.Text == "0")
            {
                if (!(e.KeyChar == Convert.ToChar(Keys.Delete)))
                {
                    textBox2.Text = "";// Convert.ToString(e.KeyChar);
                }
            }
        }
    }
}
