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
    public partial class Bilgi_Sil : Form
    {
        public Bilgi_Sil()
        {
            InitializeComponent();
        }

        private void Bilgi_Sil_Load(object sender, EventArgs e)
        {
            Veri_Katmanı veri = new Veri_Katmanı();
            DataTable tablom = veri.Getir();
            dataGridView1.DataSource = tablom;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Veri_Katmanı veri = new Veri_Katmanı();
            DataTable tablom = veri.Getir();
            int seçilensatır = Convert.ToInt16(tablom.Rows[e.RowIndex]["ID"]);
            textBox7.Text = seçilensatır.ToString();
            textBox1.Text = tablom.Rows[e.RowIndex]["Ad"].ToString();
            textBox2.Text = tablom.Rows[e.RowIndex]["Soyad"].ToString();
            textBox3.Text = tablom.Rows[e.RowIndex]["KulAd"].ToString();
            textBox4.Text = tablom.Rows[e.RowIndex]["EPosta"].ToString();
            textBox5.Text = tablom.Rows[e.RowIndex]["Sifre"].ToString();
            textBox6.Text = tablom.Rows[e.RowIndex]["TelNum"].ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Veri_Katmanı veri = new Veri_Katmanı();
            veri.silme(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, Convert.ToInt16(textBox7.Text));
            DataTable tablom = veri.Getir();
            dataGridView1.DataSource = tablom;
        }
    }
}
