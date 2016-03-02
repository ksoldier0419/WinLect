using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;  //파일 입출력용


namespace WinForm08
{
    public partial class Form1 : Form
    {
        string filepath = "";
        string filename = "";

        bool hasFile = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //도구상자툴 사용하지않고 직접입력
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); 

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                filename = filepath.Split('\\')[filepath.Split('\\').Length - 1];
                //  '//' 파일경로를 나타내는 백슬래쉬는 문자임에 유의하자
                //textBox1.Text = filepath + "\r\n" + filename;

                StreamReader sr = new StreamReader(filepath); //방법2

                string str = "";

                while ((str = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(str);
                }               

                sr.Close();

                this.hasFile = true;
                this.Text = filename;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            filepath = "C:\\db.txt";  //초기 파일 위치
            File_Open();
        }

        public void File_Open()
        {
            try
            {
                StreamReader sr = new StreamReader(filepath); //방법2
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(str);
                    comboBox1.Items.Add(str);
                }
            }
            catch (System.Exception ex)
            {
                if (MessageBox.Show("파일입력오류 db.txt 파일로 불러오시겠습니까?", "에러발생", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    filepath = "C:\\db.txt";  //초기 파일 위치         
                    File_Open();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
	            label1.Text = listBox1.SelectedItem.ToString();
	            comboBox1.SelectedItem = listBox1.SelectedItem;
            }
            catch (System.Exception ex)
            {
            	
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
	            label1.Text = comboBox1.SelectedItem.ToString();
	            listBox1.SelectedItem = comboBox1.SelectedItem;
            }
            catch (System.Exception ex)
            {
            	
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox1.Text == "")
                    return;
                if (comboBox1.Items.IndexOf(comboBox1.Text) >= 0)
                {
                    MessageBox.Show("중복입니다.");
                    return;
                }

                if (MessageBox.Show(comboBox1.Text + " 추가하시겠습니까?", "데이터추가", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    comboBox1.Items.Add(comboBox1.Text);
                    listBox1.Items.Add(comboBox1.Text);
                }
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show(listBox1.Text + " 삭제하시겠습니까?", "데이터삭제", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int p = listBox1.Items.IndexOf(listBox1.Text);

                    // listBox1.Items.Remove(listBox1.Text);  //방법1
                    // comboBox1.Items.Remove(listBox1.Text);
                    listBox1.Items.RemoveAt(p); //방법2
                    comboBox1.Items.RemoveAt(p);    
                    //??? 삭제하고 나면 comboBox1_SelectedIndexChanged 에서 위치값이 없어졌기에 에러가 발생한다. try 로 예외 처리하면 된다.
                    // 그런데 다음 값을 가리키게 할려면 어떻게 해야하나..
              
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
