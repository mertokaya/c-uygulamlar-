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
        IDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            string sqlc="select * from Admin where kullanici_ad='"+textBox1.Text+"' and sifre='"+textBox2.Text+"'";
            OleDbCommand cmnd = new OleDbCommand(sqlc, oleDbConnection1);
            oleDbConnection1.Open();
            dr = cmnd.ExecuteReader();
           
            if (dr.Read())
            {
                timer1.Enabled = true;
                Form1 f = new Form1();
                f.Show();
            }
                 
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            oleDbConnection1.Close();
        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}

