using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oto_satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void textboxiçitemizleme()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

       public personel çalışanım = new personel();
       public müşteri alıcı = new müşteri();
       public araba arabalar = new araba();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            araba satılanaraba1 = new araba(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),textBox4.Text);
            arabalar.arabaekle(satılanaraba1);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            personel çalışanlar = new personel(textBox5.Text,textBox6.Text);
            çalışanım.çalışanekle(çalışanlar);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            müşteri müşteriler = new müşteri(textBox7.Text,textBox8.Text);
            alıcı.müşteriekle(müşteriler);
            
        }


        private void button4_Click(object sender, EventArgs e)
        {

            textboxiçitemizleme();

            Form2 f2 = new Form2();
            f2.Show();


          
            //// Araba 


            foreach (araba eleman in araba.arabagetir())
            {

                f2.comboBox1.Items.Add(eleman.markaver());

            }
            foreach (araba eleman in araba.arabagetir())
            {
                f2.comboBox2.Items.Add(eleman.plakaver());
            }
            foreach (araba eleman in araba.arabagetir())
            {

                f2.comboBox3.Items.Add(eleman.fiyatıver());

            }
           

   
            ////Personel


            foreach (personel eleman in personel.personelgetir())
            {

                f2.comboBox4.Items.Add(eleman.cvver());

            }
           


            ////Müşteri


            foreach (müşteri eleman in müşteri.müşterigetir())
            {

                f2.comboBox6.Items.Add(eleman.adsoyadver());

            }

         
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

      
        

    }
}
