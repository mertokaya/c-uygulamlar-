using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class saha
    {
        public int Genislik = 120;
        public int Yukseklik = 40;
        const Char dik = '║';
        const Char solalt = '╚';
        const Char sagalt = '╝';
        const Char solust = '╔';
        const Char sagust = '╗';
        const Char yatay = '═';
        const ConsoleColor zeminrengi = ConsoleColor.Black;
        const ConsoleColor yazirengi = ConsoleColor.DarkBlue;
        public void sahaciz()
        {
            Console.WindowWidth = Genislik;
            Console.WindowHeight = Yukseklik;
            Console.BackgroundColor = zeminrengi;
            Console.ForegroundColor = yazirengi;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write(solust);
            Console.SetCursorPosition(Genislik - 1, 0);
            Console.Write(sagust);
            Console.SetCursorPosition(0, Yukseklik - 1);
            Console.Write(solalt);
            Console.SetCursorPosition(Genislik - 1, Yukseklik - 1);
            Console.Write(sagalt);
            for (int sutun = 1; sutun < Genislik - 1; sutun++)
            {
                Console.SetCursorPosition(sutun, 0);
                Console.Write(yatay);

                Console.SetCursorPosition(sutun, Yukseklik - 1);
                Console.Write(yatay);
            }

            for (int satir = 1; satir < Yukseklik - 1; satir++)
            {
                Console.SetCursorPosition(0, satir);
                Console.Write(dik);

                Console.SetCursorPosition(Genislik - 1, satir);
                Console.Write(dik);

            }
        }

    }
}
