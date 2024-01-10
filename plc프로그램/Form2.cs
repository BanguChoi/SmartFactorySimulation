using ActUtlTypeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // 직렬 포트 제어 클래스 포함
using MetroFramework.Forms;


namespace plc프로그램
{
    public partial class Form2 : MetroForm
    {
        public ActUtlType plc = new ActUtlType();

        
        public Form2()
        {

            InitializeComponent();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {


            // 여기의 Station 번호는 MX Component에서 설정한 번호를 정의 한다.

            plc.ActLogicalStationNumber = 1;
            int nRtn = plc.Open();
            if (nRtn == 0)
            {
                MessageBox.Show("plc 접속 성공!");
            }

            else
            {
                int nRTN = plc.Close();

                MessageBox.Show("plc 접속 실패!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int plcData = 0;

            // 스위치 "m0"값을 읽어 0인지 1인지 판단한다.
           
                plc.GetDevice("M0", out plcData);

            if (plcData == 0)
            {
                plc.SetDevice("M0", 1);
                checkBox1.BackColor = Color.Red;
            }
            else
            {
                plc.SetDevice("M0", 0);
                checkBox1.BackColor = Color.LightGoldenrodYellow;
            }







        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
                     
            
            int plcData = 0;

           
            plc.GetDevice("M1", out plcData);// 스위치 "m0"값을 읽어 0인지 1인지 판단한다.

            if (plcData == 0)
            {
                plc.SetDevice("M1", 1);
                checkBox2.BackColor = Color.Red;
            }
            else
            {
                plc.SetDevice("M1", 0);
                checkBox2.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
                                 
            int plcData = 0;

            plc.GetDevice("M2", out plcData);// 스위치 "m0"값을 읽어 0인지 1인지 판단한다.

            if (plcData == 0)
            {
                plc.SetDevice("M2", 1);
                checkBox3.BackColor = Color.Red;
            }
            else
            {
                plc.SetDevice("M2", 0);
                checkBox3.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {           
          
            
            int plcData = 0;

            plc.GetDevice("M3", out plcData);// 스위치 "m0"값을 읽어 0인지 1인지 판단한다.

            if (plcData == 0)
            {
                plc.SetDevice("M3", 1);
                checkBox4.BackColor = Color.Red;
            }
            else
            {
                plc.SetDevice("M3", 0);
                checkBox4.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {           
                     
            int plcData = 0;

            plc.GetDevice("M4", out plcData);// 스위치 "m0"값을 읽어 0인지 1인지 판단한다.

            if (plcData == 0)
            {
                plc.SetDevice("M4", 1);
                checkBox5.BackColor = Color.Red;
            }
            else
            {
                plc.SetDevice("M4", 0);
                checkBox5.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {          
            
            int plcData = 0;

            plc.GetDevice("M5", out plcData);// 스위치 "m0"값을 읽어 0인지 1인지 판단한다.

            if (plcData == 0)
            {
                plc.SetDevice("M5", 1);
                checkBox6.BackColor = Color.Red;
            }
            else
            {
                plc.SetDevice("M5", 0);
                checkBox6.BackColor = Color.LightGoldenrodYellow;
            }
        }
        private void checkBox8_CheckedChanged_1(object sender, EventArgs e)
        {
            int plcData = 0;

            plc.GetDevice("M6", out plcData);// 스위치 "m0"값을 읽어 0인지 1인지 판단한다.

            if (plcData == 0)
            {
                plc.SetDevice("M6", 1);
                checkBox8.BackColor = Color.Red;
            }
            else
            {
                plc.SetDevice("M6", 0);
                checkBox8.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            int plcData = 0;

            plc.GetDevice("M7", out plcData);// 스위치 "m0"값을 읽어 0인지 1인지 판단한다.

            if (plcData == 0)
            {
                plc.SetDevice("M7", 1);
                checkBox9.BackColor = Color.Red;
            }
            else
            {
                plc.SetDevice("M7", 0);
                checkBox9.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void checkBox10_CheckedChanged_1(object sender, EventArgs e)
        {
            int plcData = 0;

            plc.GetDevice("M8", out plcData);// 스위치 "m0"값을 읽어 0인지 1인지 판단한다.

            if (plcData == 0)
            {
                plc.SetDevice("M8", 1);
                checkBox10.BackColor = Color.Red;
            }
            else
            {
                plc.SetDevice("M8", 0);
                checkBox10.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void checkBox11_CheckedChanged_1(object sender, EventArgs e)
        {
            int plcData = 0;

            plc.GetDevice("M9", out plcData);// 스위치 "m0"값을 읽어 0인지 1인지 판단한다.

            if (plcData == 0)
            {
                plc.SetDevice("M9", 1);
                checkBox11.BackColor = Color.Red;
            }
            else
            {
                plc.SetDevice("M9", 0);
                checkBox11.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void checkBox12_CheckedChanged_1(object sender, EventArgs e)
        {
            int plcData = 0;

            plc.GetDevice("M10", out plcData);// 스위치 "m0"값을 읽어 0인지 1인지 판단한다.

            if (plcData == 0)
            {
                plc.SetDevice("M10", 1);
                checkBox12.BackColor = Color.Red;
            }
            else
            {
                plc.SetDevice("M10", 0);
                checkBox12.BackColor = Color.LightGoldenrodYellow;
            }
        }
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            int plcData = 0;

            plc.GetDevice("M11", out plcData);// 스위치 "m0"값을 읽어 0인지 1인지 판단한다.

            if (plcData == 0)
            {
                plc.SetDevice("M11", 1);
                checkBox13.BackColor = Color.Red;
            }
            else
            {
                plc.SetDevice("M11", 0);
                checkBox13.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {


            if (plc.ActLogicalStationNumber == 1)
            {
                plc.SetDevice("M0", 0);
                checkBox1.BackColor = Color.LightGoldenrodYellow;
                plc.SetDevice("M1", 0);
                checkBox2.BackColor = Color.LightGoldenrodYellow;
                plc.SetDevice("M2", 0);
                checkBox4.BackColor = Color.LightGoldenrodYellow;
                plc.SetDevice("M3", 0);
                checkBox3.BackColor = Color.LightGoldenrodYellow;
                plc.SetDevice("M4", 0);
                checkBox5.BackColor = Color.LightGoldenrodYellow;
                plc.SetDevice("M5", 0);
                checkBox6.BackColor = Color.LightGoldenrodYellow;
                plc.SetDevice("M6", 0);
                checkBox8.BackColor = Color.LightGoldenrodYellow;
                plc.SetDevice("M7", 0);
                checkBox9.BackColor = Color.LightGoldenrodYellow;
                plc.SetDevice("M8", 0);
                checkBox10.BackColor = Color.LightGoldenrodYellow;
                plc.SetDevice("M9", 0);
                checkBox11.BackColor = Color.LightGoldenrodYellow;
                plc.SetDevice("M10", 0);
                checkBox12.BackColor = Color.LightGoldenrodYellow;
                plc.SetDevice("M11", 0);
                checkBox13.BackColor = Color.LightGoldenrodYellow;

                MessageBox.Show("초기화 되었습니다");

            }
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {          
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {

            plc.ActLogicalStationNumber = 1;
            int nRtn = plc.Open();

            if (serialPort1.IsOpen == false)
                
            {
                
                
               
            }
            
            else
            {
               
            }
            

            
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void lable1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            Form4 newform2 = new Form4();
            this.Hide();
            newform2.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 newform2 = new Form1();
            this.Hide();
            newform2.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            plc.SetDevice("M0", 0);
            checkBox1.BackColor = Color.LightGoldenrodYellow;
            plc.SetDevice("M1", 0);
            checkBox2.BackColor = Color.LightGoldenrodYellow;
            plc.SetDevice("M2", 0);
            checkBox4.BackColor = Color.LightGoldenrodYellow;
            plc.SetDevice("M3", 0);
            checkBox3.BackColor = Color.LightGoldenrodYellow;
            MessageBox.Show("초기화 되었습니다");

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            plc.SetDevice("M4", 0);
            checkBox5.BackColor = Color.LightGoldenrodYellow;
            plc.SetDevice("M5", 0);
            checkBox6.BackColor = Color.LightGoldenrodYellow;
            plc.SetDevice("M6", 0);
            checkBox8.BackColor = Color.LightGoldenrodYellow;
            plc.SetDevice("M7", 0);
            checkBox9.BackColor = Color.LightGoldenrodYellow;
            MessageBox.Show("초기화 되었습니다");
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            plc.SetDevice("M8", 0);
            checkBox10.BackColor = Color.LightGoldenrodYellow;
            plc.SetDevice("M9", 0);
            checkBox11.BackColor = Color.LightGoldenrodYellow;
            plc.SetDevice("M10", 0);
            checkBox12.BackColor = Color.LightGoldenrodYellow;
            plc.SetDevice("M11", 0);
            checkBox13.BackColor = Color.LightGoldenrodYellow;
            MessageBox.Show("초기화 되었습니다");
        }
    }
}
