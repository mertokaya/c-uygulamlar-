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
    public partial class Ekleme : Form
    {
        public Ekleme()
        {
            InitializeComponent();
        }

        private void Ekleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bilgiler bilgi = new Bilgiler(textBox1.Text, textBox2.Text, Convert.ToDecimal(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), textBox7.Text, textBox8.Text, pictureBox1.Image);
            Bilgiler.ekleme(bilgi);
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
