using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    
    public partial class Form1 : Form
    {

        kutuphane kutuphanem=new kutuphane();
        List<ogrenci> ogrlistem = new List<ogrenci>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            kitap kitabım = new kitap(textBox1.Text, textBox2.Text);
            kutuphanem.kitapekle(kitabım);
            comboBox2.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ogrenci eleman = new ogrenci(textBox3.Text, Convert.ToInt32(textBox4.Text));
            ogrlistem.Add(eleman);
            comboBox1.Items.Clear();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            foreach (kitap eleman in kutuphanem.kitaplarıgetir()) {

                comboBox1.Items.Add(eleman.kitapadınıver());
                
            }
            foreach (ogrenci ogr in ogrlistem) {
                comboBox2.Items.Add(ogr.ogradver());
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            foreach (ogrenci ogr in ogrlistem)
            {
                if (ogr.ogradver() == comboBox2.SelectedItem.ToString()) { 
                foreach (kitap eleman in kutuphanem.kitaplarıgetir())
                {
                    if (eleman.kitapadınıver() == comboBox1.SelectedItem.ToString())
                    {
                            eleman.kitabıoduncver(ogr);
                            MessageBox.Show("OGR AD:"+ogr.ogradver()+"KitapAdı:"+eleman.kitapadınıver());

                    }

                }
                }

            }
        }
    }
}
