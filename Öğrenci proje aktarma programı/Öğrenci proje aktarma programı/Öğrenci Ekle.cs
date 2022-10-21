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
    public partial class Öğrenci_Ekle : Form
    {
        public Öğrenci_Ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Öğrenci ogr = new Öğrenci();
            AnaForm ana = new AnaForm();
            DataTable tablom = ogr.ogrgetir();
            ana.dataGridView1.DataSource = tablom;
            ogr.ogrekle(textBox1.Text, textBox2.Text, textBox3.Text);
        }
    }
}
