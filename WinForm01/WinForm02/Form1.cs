using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm02
{
    public partial class Form1 : Form
    {
        bool bt_click = false;

        int bt_w, bt_h;
        int g2_left, g2_top;
        int g2_height;

        public Form1()
        {

            InitializeComponent();
            bt_w = button1.Width;
            bt_h = button1.Height;

            g2_left = groupBox2.Left;
            g2_top = groupBox2.Top;
            g2_height = groupBox2.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bt_click)
            {
                button1.Text = "Off";
                button1.BackColor = Color.DarkGray;
                bt_click = false;
            }
            else
            {
                button1.Text = "On";
                button1.BackColor = Color.Yellow;
                bt_click = true;
            }
        }

        private void radioBt1(object sender, EventArgs e)
        {
            button1.Width = bt_w + int.Parse(radioButton1.Text);
            groupBox2.Left = g2_left + int.Parse(radioButton1.Text);
        }

        private void radioBt2(object sender, EventArgs e)
        {
            button1.Width = bt_w + int.Parse(radioButton2.Text);
            groupBox2.Left = g2_left + int.Parse(radioButton2.Text); 
        }

        private void radioBt3(object sender, EventArgs e)
        {
            button1.Width = bt_w + int.Parse(radioButton3.Text);
            groupBox2.Left = g2_left + int.Parse(radioButton3.Text); 
        }

        private void radioBt4(object sender, EventArgs e)
        {
            button1.Height = bt_h + int.Parse(radioButton4.Text);
            groupBox2.Height = g2_height + int.Parse(radioButton4.Text);
        }

        private void radioBt5(object sender, EventArgs e)
        {
            button1.Height = bt_h + int.Parse(radioButton5.Text);
            groupBox2.Height = g2_height + int.Parse(radioButton5.Text);
        }

        private void radioBt6(object sender, EventArgs e)
        {
            button1.Height = bt_h + int.Parse(radioButton6.Text);
            groupBox2.Height = g2_height + int.Parse(radioButton6.Text);
        }
    }
}
