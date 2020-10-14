using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Katman_Katman_Database
{
    public partial class Bilgi_Güncelle : Form
    {
        public Bilgi_Güncelle()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Veri_Katmanı veri = new Veri_Katmanı();
            veri.Guncelle(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,Convert.ToInt16(textBox11.Text));
            DataTable tablom = veri.Getir();
            dataGridView1.DataSource = tablom;
        }

        private void Bilgi_Güncelle_Load(object sender, EventArgs e)
        {
            Veri_Katmanı veri = new Veri_Katmanı();
            DataTable tablom = veri.Getir();
            dataGridView1.DataSource = tablom;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Veri_Katmanı veri = new Veri_Katmanı();
            DataTable tablom = veri.Getir();
            int seçilensatır = Convert.ToInt16(tablom.Rows[e.RowIndex]["ID"]);
            textBox11.Text = seçilensatır.ToString();
            textBox1.Text = tablom.Rows[e.RowIndex]["Ad"].ToString();
            textBox2.Text = tablom.Rows[e.RowIndex]["Soyad"].ToString();
            textBox3.Text = tablom.Rows[e.RowIndex]["KulAd"].ToString();
            textBox4.Text = tablom.Rows[e.RowIndex]["EPosta"].ToString();
            textBox5.Text = tablom.Rows[e.RowIndex]["Sifre"].ToString();
            textBox6.Text = tablom.Rows[e.RowIndex]["TelNum"].ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Veri_Katmanı verim = new Veri_Katmanı();
            DataTable tablo = verim.Ara(textBox9.Text);
            dataGridView1.DataSource = tablo;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
