using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm_ofass
{
    public partial class Form2 : Form
    {
        private Timer timer; // Declare a Timer object

        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 0, 0);
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += button10_Click; 
            timer.Start();
            button4.Text = DateTime.Now.Date.ToString("d");

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            string formattedTime = currentTime.ToString("HH:mm:ss");

         
            button10.Text = formattedTime;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now=
                DateTime.Now;
            Console.WriteLine(now);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            string formattedTime = currentTime.ToString("HH:mm:ss");

            button10.Text = formattedTime;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LibraryUserManagement libraryUserManagement = new LibraryUserManagement();
            libraryUserManagement.Show();
            
        }
    }
}
