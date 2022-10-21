using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Öğrenci_proje_aktarma_programı
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Öğrenci ogr2 = new Öğrenci();
            Öğrenci_Ekle ogrek = new Öğrenci_Ekle();
            DataTable tablom = ogr2.ogrgetir();
            dataGridView1.DataSource = tablom;
            ogrek.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Öğrenci ogr2 = new Öğrenci();
            Öğrenci_Ekle ogrek = new Öğrenci_Ekle();
            DataTable tablom = ogr2.ogrgetir();
            dataGridView1.DataSource = tablom;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Öğrenci ogr2 = new Öğrenci();
            DataTable tablom = ogr2.ogrgetir();
            dataGridView1.DataSource = tablom;
            ogr2.ogrsil(Convert.ToInt32(textBox6.Text));
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Öğrenci ogr2 = new Öğrenci();
            DataTable tablom = ogr2.ogrgetir();
            dataGridView1.DataSource = tablom;
            ogr2.ogrguncelle(textBox2.Text,textBox3.Text,textBox5.Text);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Öğrenci ogr2 = new Öğrenci();
            DataTable tablom = ogr2.ogrgetir();
            int seçilensatır = Convert.ToInt16(tablom.Rows[e.RowIndex]["id"]);
            textBox7.Text = seçilensatır.ToString();
            textBox2.Text = tablom.Rows[e.RowIndex]["ÖğrenciAdı"].ToString();
            textBox3.Text = tablom.Rows[e.RowIndex]["ÖğrenciSoyadı"].ToString();
            textBox5.Text = tablom.Rows[e.RowIndex]["Sınıfı"].ToString();
            
        }
    }
}
