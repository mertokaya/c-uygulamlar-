using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul_Programı
{
   public class dersler
    {
        string görders;
        string girders;

        public static List<notlar> not = new List<notlar>();

        public dersler()
        {

        }

        public dersler(string görders, string girders)
        {
            this.görders = görders;
            this.girders = girders;
        }


        public static List<dersler> dersgetir()
        {
            return ogrenci.ders;
        }

        public static void dersekle(dersler dersler)
        {
            ogrenci.ders.Add(dersler);
        }

        public void gördüğüdersal(string görders)
        {
            this.görders = görders;
        }

        public string gördüğüdersver()
        {
            return this.görders;
        }
        public void girdiğidersal(string girders)
        {
            this.girders = girders;
        }

        public string girdiğidersver()
        {
            return this.girders;
        }

      
    }
}
