using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul_Programı
{
   public class notlar
    {
       public int yazılınotu1;
        int yazılınotu2;
        int temrinnotu;
        int performansnotu;
        int performansnotu2;


        public notlar()
        {

        }

        public notlar(int yazılınotu1 , int yazılınotu2, int temrinnotu, int performansnotu , int performansnotu2)
        {
            this.yazılınotu1 = yazılınotu1;
            this.yazılınotu2 = yazılınotu2;
            this.temrinnotu = temrinnotu;
            this.performansnotu = performansnotu;
            this.performansnotu2 = performansnotu2;
        }

        public static List<notlar> notgetir()
        {
            return dersler.not;
        }

        public void notekle(notlar not)
        {
            dersler.not.Add(not);
        }

        public void yazılınotual(int yazılınotu1 ,int yazılınotu2)
        {
            this.yazılınotu1 = yazılınotu1;
            this.yazılınotu2 = yazılınotu2;
        }

        public int yazılınotuver()
        {
            return this.yazılınotu1;  
        }

        public int yazılınotu2ver()
        {
            return this.yazılınotu2;
        }

        public void temrinnotual(int temrinnotu)
        {
            this.temrinnotu = temrinnotu;
        }

        public int temrinnotuver()
        {
            return this.temrinnotu;
        }

        public void performansnotual(int performansnotu , int performansnotu2)
        {
            this.performansnotu = performansnotu;
            this.performansnotu2 = performansnotu2;
        }

        public int performansnotuver()
        {
            return this.performansnotu;
        }
        public int performansnotu2ver()
        {
            return this.performansnotu2;
        }
    }
}
