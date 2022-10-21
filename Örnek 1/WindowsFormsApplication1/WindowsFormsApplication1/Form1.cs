using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\lab2-pc\Desktop\Database21.mdb");

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand sorgu = new OleDbCommand("Insert into Öğrenci(Ad,Soyad,Bolum,Sinif) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + Convert.ToInt16(comboBox2.SelectedItem.ToString()) +"')", baglan);
            sorgu.ExecuteNonQuery();
            MessageBox.Show("Kayıt Yapıldı");
            baglan.Close();
        }
    }
}
