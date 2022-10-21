using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_Programı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int comb = comboBox1.SelectedIndex;
            comboBox2.Items.Add(ogretmen.ogrencibilgileri[comb].ogrenciadsoyadver());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            notlar notlar = new notlar(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            notlar.notekle(notlar);

            Form4 f4 = new Form4();
            f4.Show();
           

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
            int comb = comboBox2.SelectedIndex;
            comboBox3.Items.Add(ogrenci.ders[comb].gördüğüdersver());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }

        private void button2_Click(object sender, EventArgs e)
        {

            

        }
    }
}
