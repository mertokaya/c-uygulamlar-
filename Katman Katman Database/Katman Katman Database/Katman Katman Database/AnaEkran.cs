using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Katman_Katman_Database
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BilgiGetir b = new BilgiGetir();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bilgi_Güncelle g = new Bilgi_Güncelle();
            g.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kullanıcı_Ekle k = new Kullanıcı_Ekle();
            k.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bilgi_Sil s = new Bilgi_Sil();
            s.Show();
        }
    }
}
