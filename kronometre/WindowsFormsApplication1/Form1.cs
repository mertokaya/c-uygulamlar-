using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        int milisaniye = 0; int saniye = 0; int dakika = 0; int saat = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text=(Convert.ToString(milisaniye))+ " : "+(Convert.ToString(saniye))+ " : " +(Convert.ToString(dakika))+ " : "+(Convert.ToString(saat));
            if (milisaniye == 99)
            {
                milisaniye = 00;
                saniye = saniye + 1;
            }
            if (saniye == 59)
            {
                dakika = dakika + 1;
            }
            if (dakika == 60)
            {
                saat = saat + 1;
            }
            milisaniye = milisaniye + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text="0 : 0 : 0 : 0 :";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
