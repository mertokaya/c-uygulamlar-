using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int boş = 8;
        int dolu = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Green;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Green;
            label7.Text = boş.ToString();
            label8.Text = dolu.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            if (label6.Text == " ")
            {
                label6.Text = "A1";
            }
            else 
            {
                label6.Text = label6.Text + " " + "A1";
            }
            boş--;
            dolu++;
            label7.Text = boş.ToString();
            label8.Text = dolu.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.Enabled = false;
            if (label6.Text == " ")
            {
                label6.Text = "A2";
            }
            else
            {
                label6.Text = label6.Text + " " + "A2";
            }
            boş--;
            dolu++;
            label7.Text = boş.ToString();
            label8.Text = dolu.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            button3.Enabled = false;
            if (label6.Text == " ")
            {
                label6.Text = "A3";
            }
            else
            {
                label6.Text = label6.Text + " " + "A3";
            }
            boş--;
            dolu++;
            label7.Text = boş.ToString();
            label8.Text = dolu.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            button4.Enabled = false;
            if (label6.Text == " ")
            {
                label6.Text = "A4";
            }
            else
            {
                label6.Text = label6.Text + " " + "A4";
            }
            boş--;
            dolu++;
            label7.Text = boş.ToString();
            label8.Text = dolu.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button5.Enabled = false;
            if (label6.Text == " ")
            {
                label6.Text = "B1";
            }
            else
            {
                label6.Text = label6.Text + " " + "B1";
            }
            boş--;
            dolu++;
            label7.Text = boş.ToString();
            label8.Text = dolu.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
            button6.Enabled = false;
            if (label6.Text == " ")
            {
                label6.Text = "B2";
            }
            else
            {
                label6.Text = label6.Text + " " + "B2";
            }
            boş--;
            dolu++;
            label7.Text = boş.ToString();
            label8.Text = dolu.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            button7.Enabled = false;
            if (label6.Text == " ")
            {
                label6.Text = "B3";
            }
            else
            {
                label6.Text = label6.Text + " " + "B3";
            }
            boş--;
            dolu++;
            label7.Text = boş.ToString();
            label8.Text = dolu.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            button8.Enabled = false;
            if (label6.Text == " ")
            {
                label6.Text = "B4";
            }
            else
            {
                label6.Text = label6.Text + " " + "B4";
            }
            boş--;
            dolu++;
            label7.Text = boş.ToString();
            label8.Text = dolu.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            MessageBox.Show(ad + " " +soyad+ " " +label6.Text);
        }
    }
}
