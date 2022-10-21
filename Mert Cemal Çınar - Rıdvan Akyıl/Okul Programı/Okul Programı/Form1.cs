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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<ogretmen> ogretmenbilgileri = new List<ogretmen>();
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogretmen ogretmen = new ogretmen(textBox1.Text , textBox3.Text);
            ogretmen.ogretmenekle(ogretmen);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                ogrenci ogrenci = new ogrenci(textBox4.Text , Convert.ToInt32(textBox6.Text) , textBox7.Text);
            ogrenci.ogrenciekle(ogrenci);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            foreach (ogretmen ogretmen in ogretmen.ogretmengetir())
            {
                f3.listBox1.Items.Add("Öğretmen Adı Soyadı :  " + ogretmen.ogretmenadsoyadver());
                f3.listBox1.Items.Add("Öğretmen'in Girdiği Sınıf :  " + ogretmen.ogretmengırsınıfver());
            }

            foreach (ogrenci ogrenci in ogrenci.ogrencigetir())
            {
                f3.listBox2.Items.Add("Öğrenci Adı Soyadı :  " + ogrenci.ogrenciadsoyadver());
                f3.listBox2.Items.Add("Öğrenci'nin Okul Numarası :  " + ogrenci.ogrenciokulnover());
                f3.listBox2.Items.Add("Öğrenci'nin Sınıfı :  " + ogrenci.ogrencisınıfver());
            }

            foreach (dersler ders in dersler.dersgetir())
            {
                f3.listBox1.Items.Add("Öğretmen'in Girdiği Dersler :  " + ders.gördüğüdersver());
                f3.listBox2.Items.Add("Öğrenci'nin Gördüğü Dersler :  " + ders.girdiğidersver());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dersler ders = new dersler(textBox5.Text , textBox2.Text);
            dersler.dersekle(ders);
        }
    }
}
