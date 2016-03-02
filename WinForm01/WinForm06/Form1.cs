using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics; //Trace 출력을 위해 추가

namespace WinForm06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //폼을 더블클릭하면 생성되는 함수
        private void Form1_Load(object sender, EventArgs e)
        {
            Trace.WriteLine("Form1_Load");           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trace.WriteLine("Form1_FormClosed");   
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Trace.WriteLine("Form1_FormClosing");   
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Trace.WriteLine("Form1_Shown");
        }

        private void Form1_ControlAdded(object sender, ControlEventArgs e)
        {
            Trace.WriteLine("Form1_ControlAdded");
        }

        private void Form1_ChangeUICues(object sender, UICuesEventArgs e)
        {
            Trace.WriteLine("Form1_ChangeUICues");
        }

        private void Form1_ControlRemoved(object sender, ControlEventArgs e)
        {
            Trace.WriteLine("Form1_ControlRemoved");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Trace.WriteLine("Form1_Paint");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Trace.WriteLine("Form1_Activated");
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            Trace.WriteLine("Form1_Layout");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
