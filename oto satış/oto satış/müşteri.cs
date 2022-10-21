using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oto_satış
{
   
   public  class müşteri
    {
       public static List<müşteri> müşteribilgileri = new List<müşteri>();
        string adsoyad;
        string işler;

        public müşteri()
        {

        }

        public static List<müşteri> müşterigetir()
        {
            return müşteribilgileri;
        }

        public void müşteriekle(müşteri satınalıcı)
        {
            müşteribilgileri.Add(satınalıcı);
        }

        public müşteri(string adsoyadi , string işleri)
        {
            this.adsoyad = adsoyadi;
            this.işler = işleri;
        }

        public void adsoyadal(string adsoyadi)
        {
            this.adsoyad = adsoyadi;
        }
        public string adsoyadver()
        {
            return this.adsoyad;
        }

        public void yaptırdığıişleral(string işleri)
        {
            this.işler = işleri;
        }

        public  string yaptırdığıişlerver()
        {
            return this.işler;
        }
    }
}
