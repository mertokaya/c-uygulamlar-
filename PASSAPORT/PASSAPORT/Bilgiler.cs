using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;

namespace PASSAPORT
{
    class Bilgiler
    {
        public System.Drawing.Image resim;
        string ad;
        string soyad;
        decimal tcno;
        string gidilecekülke;
        int gidiştarih;
        int fiyat;
        string uyruk;
        string cinsiyet;
        public static List<Bilgiler> bilgilerim = new List<Bilgiler>();
        public Bilgiler() { }
        public Bilgiler(string adı, string soyadı, decimal tcnosu, string gidilecekülkesi, int gidiştarihi, int fiyatı, string cinsiteyi, string uyruğu,System.Drawing.Image resim)
        {
            this.ad = adı;
            this.soyad = soyadı;
            this.tcno = tcnosu;
            this.gidilecekülke = gidilecekülkesi;
            this.gidiştarih = gidiştarihi;
            this.fiyat = fiyatı;
            this.uyruk = uyruğu;
            this.cinsiyet = cinsiteyi;
            this.resim = resim;
        }
        public static List<Bilgiler> getir()
        {
            return Bilgiler.bilgilerim;
        }
        public static void ekleme(Bilgiler bilgilerim1)
        {
            Bilgiler.bilgilerim.Add(bilgilerim1);
        }
        public System.Drawing.Image getresim() { return this.resim; }
        public string getad() { return this.ad; }
        public string getsoyad() { return this.soyad; }
        public decimal gettcno() { return this.tcno; }
        public string getgidilecekülke() { return this.gidilecekülke; }
        public int getgidiştarih() { return this.gidiştarih; }
        public int getfiyat() { return this.fiyat; }
        public string getuyruk() { return this.uyruk; }
        public string getcinsiyet() { return this.cinsiyet; }

    }
}
