using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Ana Yemekler");
            comboBox2.Items.Add("Çorba Çeşitleri");
            comboBox3.Items.Add("Tatlılar");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Köfte");
            listBox1.Items.Add("Pilav");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mercimek Çorbası");
            listBox1.Items.Add("Domates Çorbası");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Baklava");
            listBox1.Items.Add("Ekmek Kadayıfı");
        }
    }
}
