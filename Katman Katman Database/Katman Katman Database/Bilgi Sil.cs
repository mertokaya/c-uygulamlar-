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
    public partial class Bilgi_Sil : Form
    {
        public Bilgi_Sil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veri_Katmanı veri = new Veri_Katmanı();
            veri.silme(textSil.Text);
        }
    }
}
