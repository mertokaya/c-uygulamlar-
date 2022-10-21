using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oto_satış
{
   public class araba
    {
        
       public static List<araba> satılanaraba = new List<araba>();
        string açıklama;
        string marka;
        int plaka;
        int fiyat;
        public araba()
        {

        }
        public araba(string markası,int plakası , int fiyatı , string açıklaması)
        {
            this.açıklama = açıklaması;
            this.marka = markası;
            this.plaka = plakası;
            this.fiyat = fiyatı;
        }

        public static List<araba> arabagetir()
        {
            return satılanaraba;
        }
        public void arabaekle(araba arabaekleme)
        {
            satılanaraba.Add(arabaekleme);
        }
        public void Arababilgilerial(string açıklaması)
        {
            this.açıklama = açıklaması;
        }

        public string arababilgileriver()
        {
            return this.açıklama;
        }

        public void markaal(string markası)
        {
            this.marka = markası;
        }

        public string markaver()
        {
            return this.marka;
        }

        public void plakaal(int plakası)
        {
            this.plaka = plakası;
        }

        public int plakaver()
        {
            return this.plaka;
        }

        public void fiyatıal(int fiyatı)
        {
            this.fiyat = fiyatı;
        }

        public int fiyatıver()
        {
            return this.fiyat;
        }
    }
}
