using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.OutputEncoding = System.Text.Encoding.UTF8;
            saha alan = new saha();
            alan.sahaciz();
            engeller e = new engeller();
            e.engelciz();
            Console.CursorVisible = false;
            Karakter ucak = new Karakter();
            süre say = new süre();
            int toplam = 0, syc = 0, hafıza = 0;
            Random rasgele = new Random();
            Console.SetCursorPosition(ucak.sutun, ucak.satir);
            int son = 0, lvl = 0, yön = 0;
            say.sat = ucak.satir;
            say.s();
            while (1 < 2)
            {
                while (syc < 117 && son < 1)
                {
                    ucak.sil();
                    ucak.sutun++;
                    for (int a = 0; a < engeller.rnd2; a++)
                    {
                        if (e.engelsut[a] == ucak.sutun && e.engelsat[a] == ucak.satir)
                        {
                            break;
                        }
                    }
                    ucak.ciz();
                    System.Threading.Thread.Sleep(70);
                    syc++;
                    toplam++;
                    Console.SetCursorPosition(60, 0);
                    Console.Write("Level: " + lvl + " Skor:" + toplam + "Engel: " + engeller.rnd2);
                    for (int a = 0; a < engeller.rnd2; a++)
                    {
                        if (e.engelsut[a] == ucak.sutun && e.engelsat[a] == ucak.satir ||
                            e.engelsut[a] == ucak.sutun - 1 && e.engelsat[a] == ucak.satir)
                        {
                            son++;
                            Console.Beep(1500, 1000);
                        }
                    }
                }
                if (syc == 117)
                {
                    Console.Clear();
                    alan.sahaciz();
                    engeller.rnd2 = engeller.rnd2 + 10;
                    e.engelciz();
                    ucak.sutun = 1;
                    syc = 0;
                    say.sat = ucak.satir;
                    ucak.sil();
                    ucak.ciz();
                    say.s();
                    lvl++;
                }
            }
            Console.ReadLine();
        }
    }
}
