using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class kutuphane
    {

        List<kitap> kitaplarım = new List<kitap>();

        public kutuphane() { }

        public List<kitap> kitaplarıgetir() {
            return kitaplarım;
        }
        public void kitapekle(kitap kitabım) {
            kitaplarım.Add(kitabım);
        }

        public kitap kitapbilgisiniver(string kitapadı) {

           
            foreach (kitap eleman in kitaplarım) {

                if (eleman.kitapadınıver() == kitapadı) {

                   
                    return eleman;
                }
            }
            return null;



        }
    }
}
