using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oto_satış
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      
        

        
       
       
        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

  

        private void button2_Click_1(object sender, EventArgs e)
        {

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (personel eleman in personel.personelgetir())
            {
                listBox2.Items.Add(eleman.yaptığıişlerver());
            }

        }


        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (müşteri eleman in müşteri.müşterigetir())
            {
                listBox3.Items.Add(eleman.yaptırdığıişlerver());
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null)
            {
                foreach (araba araç in araba.arabagetir())
                {
                    listBox1.Items.Add(araç.arababilgileriver());
                }
            }
        }
    }
}
