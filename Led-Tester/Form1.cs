using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Timer = System.Windows.Forms.Timer;

namespace Led_Tester
{
    public partial class EIS_LED_TESTER : Form
    {
    
        public EIS_LED_TESTER()
        {
            InitializeComponent();
            pictureBox5.Visible = true; // no Led
            pictureBox9.Visible = false; // yellow
            pictureBox6.Visible = false; // green
            pictureBox7.Visible = false; // blue
            pictureBox8.Visible = false; // red
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            InitTimer();
        }

        private Timer timer1;
        public void InitTimer()
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 500; //in miliseconds
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string A;
            SerialPort mySerialPort = new SerialPort();
            SerialPort sp = new SerialPort("COM5", 9600);
            sp.Open();
            Thread.Sleep(100);
            A = sp.ReadExisting();
            sp.Close();
            Program.übergabe = A;



                 if (Program.speicherung == "n")
                    {
                        if (Program.übergabe == "b")
                        {
                            pictureBox5.Visible = false; // no Led
                            pictureBox9.Visible = false; // yellow
                            pictureBox6.Visible = false; // green
                            pictureBox7.Visible = true; // blue
                            pictureBox8.Visible = false; // red
                            Program.blue += 1;
                            Program.speicherung = "";
                        }
                        else if (Program.übergabe == "r")
                        {
                            pictureBox5.Visible = false; // no Led
                            pictureBox9.Visible = false; // yellow
                            pictureBox6.Visible = false; // green
                            pictureBox7.Visible = false; // blue
                            pictureBox8.Visible = true; // red
                            Program.red += 1;
                            Program.speicherung = "";
                        }
                        else if (Program.übergabe == "g")
                        {
                            pictureBox5.Visible = false; // no Led
                            pictureBox9.Visible = false; // yellow
                            pictureBox6.Visible = true; // green
                            pictureBox7.Visible = false; // blue
                            pictureBox8.Visible = false; // red
                            Program.green += 1;
                            Program.speicherung = "";
                        }
                        else if (Program.übergabe == "y")
                        {
                            pictureBox5.Visible = false; // no Led
                            pictureBox9.Visible = true; // yellow
                            pictureBox6.Visible = false; // green
                            pictureBox7.Visible = false; // blue
                            pictureBox8.Visible = false; // red
                            Program.yellow += 1;
                            Program.speicherung = "";
                        }
                    }
                 else
                    {
                        if (Program.übergabe == "n")
                        {
                            pictureBox5.Visible = true; // no Led
                            pictureBox9.Visible = false; // yellow
                            pictureBox6.Visible = false; // green
                            pictureBox7.Visible = false; // blue
                            pictureBox8.Visible = false; // red
                            Program.speicherung = "n";
                        }
                    }
                    label6.Text = Convert.ToString(Program.red);
                    label7.Text = Convert.ToString(Program.blue);
                    label8.Text = Convert.ToString(Program.green);
                    label9.Text = Convert.ToString(Program.yellow);

        

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Starten_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
