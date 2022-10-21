using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class kitap
    {
        string kitapadı;
        string yazar;
        string tur;
        ogrenci kitapkimde;
        List<ogrenci> okuyanlar = new List<ogrenci>();
        public kitap() { }
        public kitap(string ad, string yazar) {
            this.kitapadı = ad;
            this.yazar = yazar;
        }

        public string kitapadınıver() {
            return this.kitapadı;
        }
        public void kitabıoduncver(ogrenci kime) {
            this.kitapkimde = kime;
        }
        public void kitabgerigeldi() {

            okuyanlar.Add(kitapkimde);
            kitapkimde = null;
        }


    }
}
