using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Stok_uygulaması
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            label1.Text = "%" + progressBar1.Value.ToString();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Baraşılı Giriş Yaptınız.");
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlcml = "select (kullanici_ad,sifre,telefon) from Admin";
            OleDbCommand kmt = new OleDbCommand(sqlcml, oleDbConnection1);
            if (textBox1.Text == sqlcml && textBox2.Text == "1234")
            {
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Hatalı Admin Girişi");
            }
        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}

