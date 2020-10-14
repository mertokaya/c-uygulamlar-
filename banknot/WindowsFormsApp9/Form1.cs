using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxhesap.Items.Clear();
            textBoxsayı.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] banknot = { 200, 100, 50, 20, 10, 5, 1 };
            int para, adet, i;
            para = int.Parse(textBoxsayı.Text);
            for (i = 0; i <= 6; i++)
            {
                adet = para / banknot[i];
                if (adet != 0)
                {
                    listBoxhesap.Items.Add(adet.ToString() + " adet" + banknot[i] + "TL");
                    para %= banknot[i];
                }
            }


        }

        private void listBoxhesap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
