using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pianotiles
{
    public partial class Form1 : Form
    {
        Button[,] butondizim = new Button[4,4];
        int index;
        int kaydırılansatır = 0;
       
        

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        public void butonlarıformayerlestir()
        {

            for (int satır = 0; satır < 4; satır++)
            {
                for (int sutun = 0; sutun < 4; sutun++)
                {
                    this.Controls.Add(butondizim[satır,sutun]);
                }

            }
        }

        public void butonlarıdoldur() {
            for (int k = 0; k < 4; k++)
            {
                for (int i = 0; i < 4; i++)
                {

                    if (i == 0)
                    {
                        Beninbutonum btsınıfımu = new Beninbutonum(0, k * 150, Color.White);

                        Button butonum = btsınıfımu.Butonver();
                        butonum.Click += new EventHandler(butontıklandı);
                        butondizim[k,i] = butonum;
                    }
                    else
                    {
                        Beninbutonum btsınıfım = new Beninbutonum(i * 100, k * 150, Color.White);
                        Button butonum = btsınıfım.Butonver();
                        butonum.Click += new EventHandler(butontıklandı);
                        butondizim[k, i] = butonum;

                    }

                }
            }

        }

        public void butontıklandı(object sender, EventArgs e) {
            Button bt = (Button)sender;
         if (bt.BackColor == Color.Black) {
                timer1.Stop();
                
            
          }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Size = new Size(400,630);
            butonlarıdoldur();
            butonlarıformayerlestir();
             index = new Random().Next(0, 4);
            butondizim[kaydırılansatır, index].BackColor = Color.Black;
            timer1.Start();
            




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kaydırılansatır == butondizim[0, index].Location.X)
            {
                Button btn = new Button();
                btn.Name = butondizim[0, index].Location.X.ToString();
                butonlarıdoldur();
                Beninbutonum btsınıfımu = new Beninbutonum(0, kaydırılansatır * 150, Color.Black);
                this.Controls.Add(btn);
            }
            else 
            {
                Button btn = new Button();
                btn.Name = butondizim[1, index].Location.Y.ToString();
                Beninbutonum btsınıfımu = new Beninbutonum(0, kaydırılansatır * 150, Color.Black);
                this.Controls.Add(btn);
            }


            if (kaydırılansatır == 3)
            {
                butondizim[3, index].BackColor = Color.White;
                kaydırılansatır = 0;
                index = new Random().Next(0, 4);
                
                butondizim[0, index].BackColor = Color.Black;
            }
            else { 
                  butondizim[kaydırılansatır, index].BackColor = Color.White;
                kaydırılansatır = kaydırılansatır + 1;
            butondizim[kaydırılansatır, index].BackColor = Color.Black;
            }

      

          
          
          




        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
    }

