using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using MetroFramework.Forms;
namespace plc프로그램
{
    public partial class Form5 : MetroForm
    {
        private const string FilePath = "users.txt";
        public Form5()
        {
            InitializeComponent();
           
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string email = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("모든 정보를 입력해주세요.");
                return;
            }

            if (File.Exists(FilePath))
            {
                // 이미 존재하는 파일이면 파일에 내용을 추가한다.
                using (StreamWriter writer = File.AppendText(FilePath))
                {
                    writer.WriteLine($"{username},{password},{email}");
                }
            }
            else
            {
                // 존재하지 않는 파일이면 새로 파일을 만들고 내용을 저장한다.
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    writer.WriteLine($"{username},{password},{email}");
                }
            }

            MessageBox.Show("회원가입이 완료되었습니다.");
            ClearInputs();
            Form4 newform5 = new Form4();
            this.Hide();          
            newform5.ShowDialog();
            this.Hide();
        }
        private void ClearInputs()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newform5 = new Form4();
            this.Hide();
            newform5.ShowDialog();
            this.Close();
        }
    }
}


