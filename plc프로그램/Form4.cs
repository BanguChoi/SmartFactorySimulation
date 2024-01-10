using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace plc프로그램
{
    public partial class Form4 : MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string password = textBox2.Text;

            // 아이디와 비밀번호를 파일에 저장하고, 이를 기반으로 로그인 처리
            string filePath = "users.txt";
            string[] lines = File.ReadAllLines(filePath);
            bool isFound = false;
            foreach (string line in lines)
            {
                string[] userInfo = line.Split(',');
                if (userInfo[0] == id && userInfo[1] == password)
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                MessageBox.Show("로그인 성공");

                Form2 newform4 = new Form2();
                this.Hide();
                newform4.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form5 newform4 = new Form5();
            this.Hide();
            newform4.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    } }

