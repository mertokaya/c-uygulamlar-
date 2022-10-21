using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PASSAPORT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Bilgiler b = new Bilgiler();
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Bilgiler bilgilerim in Bilgiler.getir())
            {
                textBox1.Text = bilgilerim.gettcno().ToString();
                textBox3.Text = bilgilerim.getad();
                textBox2.Text = bilgilerim.getsoyad();
                textBox4.Text = bilgilerim.getgidilecekülke();
                textBox5.Text = bilgilerim.getgidiştarih().ToString();
                textBox6.Text = bilgilerim.getfiyat().ToString();
                textBox8.Text = bilgilerim.getcinsiyet().ToString();
                textBox7.Text = bilgilerim.getuyruk();
                pictureBox1.Image = bilgilerim.getresim();
                pictureBox2.Image = bilgilerim.getresim();

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
