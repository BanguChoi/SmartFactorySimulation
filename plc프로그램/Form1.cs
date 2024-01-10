using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace plc프로그램
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 newform1 = new Form4();
            this.Hide();
            newform1.ShowDialog();
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
