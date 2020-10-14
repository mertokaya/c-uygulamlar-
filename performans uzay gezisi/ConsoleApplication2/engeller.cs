using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class engeller
    {
        public int Genislik = 120;
        public int Yukseklik = 40;
        const Char dik = '║';
        const Char solalt = '╚';
        const Char sagalt = '╝';
        const Char solust = '╔';
        const Char sagust = '╗';
        const Char yatay = '═';
        const ConsoleColor zeminrengi = ConsoleColor.White;
        const ConsoleColor yazirengi = ConsoleColor.Blue;
        public static int rnd2 = 100;
        public int[] engelsat = new int[rnd2];
        public int[] engelsut = new int[rnd2];
        public void engelciz()
        {
            Random R = new Random();
            engelsat = new int[rnd2];
            engelsut = new int[rnd2];
            for (int a = 0; a < rnd2; a++)
            {
                int sat = R.Next(1, Yukseklik - 1);
                int sut = R.Next(5, Genislik - 2);
                engelsut[a] = sut;
                engelsat[a] = sat;
                Console.SetCursorPosition(sut, sat);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("■■");

            }
        }
    }
}
