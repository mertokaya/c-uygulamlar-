using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_Programı
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (ogretmen ogretmen1 in ogretmen.ogretmengetir())
            {
                comboBox1.Items.Add(ogretmen1.ogretmenadsoyadver());


            }

            listBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int comb = comboBox1.SelectedIndex;
            comboBox2.Items.Add(ogretmen.ogrencibilgileri[comb].ogrenciadsoyadver());

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int comb = comboBox2.SelectedIndex;
            comboBox3.Items.Add(ogrenci.ders[comb].gördüğüdersver());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comb = comboBox3.SelectedIndex;
            listBox1.Items.Add(dersler.not[comb].yazılınotuver());
            listBox1.Items.Add(dersler.not[comb].yazılınotu2ver());
            listBox1.Items.Add(dersler.not[comb].temrinnotuver());
            listBox1.Items.Add(dersler.not[comb].performansnotuver());
            listBox1.Items.Add(dersler.not[comb].performansnotu2ver());



        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
