using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace pianotiles
{
    class Beninbutonum
    {
        int x = 0;
        int y = 0;
        Color renk;
        int genislik = 100;
        int yukseklık = 150;
        public Beninbutonum() { }
        public Beninbutonum(int x, int y, Color renk) {

            this.x = x;
            this.y = y;
            this.renk = renk;
        }
        public Button Butonver() {

            Button bt = new Button();
            bt.Size = new Size(this.genislik,this.yukseklık);
            bt.Location = new Point(this.x,this.y);
            bt.BackColor = this.renk;
            return bt;
        }
        public void beyazyap() { 
           
        }
    }
}
