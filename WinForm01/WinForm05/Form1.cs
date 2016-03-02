using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;  //파일 입출력용

namespace WinForm03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "*";
        }

        string filepath ="";
        string filename = "";

        bool hasFile = false;

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
//         private void button2_Click(object sender, EventArgs e)
//         {
//             //             //파일 오픈 다이얼로그
//             //             OpenFileDialog openPanel = new OpenFileDialog();
//             //             openPanel.InitialDirectory = "d:\\";
//             //             openPanel.Filter = "CustomFile (*.cus)|*.cus|txt (*.txt)|*.txt | All files (*.*)|(*.*)";
//             //             if (openPanel.ShowDialog() == DialogResult.OK)
//             //             {
//             //                 Trace.WriteLine("OK      " + openPanel.FileName + " "
//             //                                                                + openPanel.SafeFileName);
//             //             }
//         }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        

        private void textChanged(object sender, EventArgs e)
        {
            if (hasFile)
            {
                this.Text = this.filename + "*";
                //MessageBox.Show("변경되었습니다.");
            }
        }

        private void bt_filesave(object sender, EventArgs e)
        {
            if (this.Text == "*")
            {
                bt_filesaveas(sender,e);
            }
            else
            {
                StreamWriter sw = new StreamWriter(this.filepath);
                sw.Write(textBox1.Text);
                sw.Close();

                this.hasFile = true;
                this.Text = filename;  //별표 삭제
            }
        }

        private void bt_filenew(object sender, EventArgs e)
        {
            textBox1.Text = "";
            hasFile = false;
            this.Text = "*";
        }

        private void bt_fileopen(object sender, EventArgs e)
        {
            //openFileDialog1.InitialDirectory = "C:\\";  //초기 파일 위치

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                filename = filepath.Split('\\')[filepath.Split('\\').Length - 1];
                //  '//' 파일경로를 나타내는 백슬래쉬는 문자임에 유의하자
                //textBox1.Text = filepath + "\r\n" + filename;

                textBox1.Text = "";
                string str = "";

                //StreamReader sr = File.OpenText(filepath);     //방법1
                StreamReader sr = new StreamReader(filepath); //방법2

                while ((str = sr.ReadLine()) != null)
                {
                    textBox1.Text += str;
                    textBox1.Text += System.Environment.NewLine;
                }

                sr.Close();

                this.hasFile = true;
                this.Text = filename;
            }
        }

        private void bt_filesaveas(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog1.FileName;
                filename = filepath.Split('\\')[filepath.Split('\\').Length - 1];
                //  '//' 파일경로를 나타내는 백슬래쉬는 문자임에 유의하자

                StreamWriter sw = new StreamWriter(filepath);
                sw.Write(textBox1.Text);
                sw.Close();

                this.hasFile = true;
                this.Text = filename;
            }
        }

        private void saveToolStripMenuItem_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "www.hallym.ac.kr";

            System.Diagnostics.Process.Start(url);
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
        }

        private void MemoOpen(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }
    }
}
