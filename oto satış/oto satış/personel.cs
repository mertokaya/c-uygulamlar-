using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oto_satış
{
  public  class personel
    {
        public static List<personel> çalışan = new List<personel>();
       public string cv;
        string perişleri;
       
        public personel()
        {

        }

        public static List<personel> personelgetir()
        {
            return çalışan;
        }

        public void çalışanekle(personel çalışanım)
        {
            çalışan.Add(çalışanım);
        }
        public personel(string cvsi, string pişleri)
        {
            this.cv = cvsi;
            this.perişleri = pişleri;
        }

        public void cval(string cvsi)
        {
            this.cv = cvsi;
        }
        public string cvver()
        {
            return this.cv;
        }

        public void yaptığıişleral(string pişleri)
        {
            this.perişleri = pişleri;
        }

        public string yaptığıişlerver()
        {
            return this.perişleri;
        }
    }
}
