using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Öğrenci_proje_aktarma_programı
{
    class Öğrenci
    {
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\lab4\Desktop\Öğrenci ve Proje uygulaması.mdb");
        public DataTable ogrgetir()
        {
            string cumle = "Select * from Öğrenci";
            OleDbDataAdapter komut = new OleDbDataAdapter(cumle, baglan);
            DataTable tablom = new DataTable();
            komut.Fill(tablom);
            return tablom;
        }
        public void ogrekle(string Ad, string Soyad, string Sınıf)
        {
            string sqlcumle = "insert into Öğrenci (ÖğrenciAdı,ÖğrenciSoyadı,Sınıfı) values ('" + Ad + "','" + Soyad + "','" + Sınıf + "')";
            OleDbCommand comm = new OleDbCommand(sqlcumle, baglan);
            baglan.Open();
            comm.ExecuteNonQuery();
            baglan.Close();
        }
        public void ogrsil(int id) 
        {
            string sqlcümlem = "delete  from Öğrenci  where id=" + id+"";
            OleDbCommand comm = new OleDbCommand(sqlcümlem, baglan);
            baglan.Open();
            comm.ExecuteNonQuery();
            baglan.Close();
        }
        public void ogrguncelle(string ad, string soyad, string sınıf) 
        {
            string sqlcümlem = "update Öğrenci set ÖğrenciAdı='"+ad+"',ÖğrenciSoyadı='"+soyad+"',Sınıfı='"+sınıf+"'";
            OleDbCommand comm = new OleDbCommand(sqlcümlem, baglan);
            baglan.Open();
            ogrgetir();
            comm.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
