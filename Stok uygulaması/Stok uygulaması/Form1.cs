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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void guncelle()
        {
            string sqlcumlem = "select * from Stok";
            OleDbDataAdapter adap = new OleDbDataAdapter(sqlcumlem, oleDbConnection1);
            DataTable table = new DataTable();
            adap.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlcumle = "delete from Stok where Ürünler ='" + textBox2.Text + "'or Satıcı='"+textBox2.Text+ "'and ID="+textBox1.Text;
            oleDbConnection1.Open();
            OleDbCommand command = new OleDbCommand(sqlcumle, oleDbConnection1);
            command.ExecuteNonQuery();
            guncelle();
            oleDbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            string sqlcumle = "insert into Stok (Kategori,Ürünler,Satıcı,Alıcı,Satılan) values ('" + textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"')";
            OleDbCommand comm = new OleDbCommand(sqlcumle, oleDbConnection1);
            comm.ExecuteNonQuery();
            guncelle();
            oleDbConnection1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "update Stok set Satıcı='" + textBox9.Text + "',Alıcı='" + textBox10.Text + "' where ID=" + textBox8.Text;
            OleDbCommand comm = new OleDbCommand(sql, oleDbConnection1);
            oleDbConnection1.Open();
            comm.ExecuteNonQuery();
            guncelle();
            oleDbConnection1.Close();
        }
    }
}
