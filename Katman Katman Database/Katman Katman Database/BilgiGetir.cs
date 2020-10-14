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
    public partial class BilgiGetir : Form
    {
        public BilgiGetir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veri_Katmanı veri = new Veri_Katmanı();
            DataTable tablom=veri.Getir();
            dataGridView1.DataSource = tablom;
        }
    }
}
