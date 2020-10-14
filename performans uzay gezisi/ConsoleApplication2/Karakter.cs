using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Karakter
    {
        public int sutun = 1;
        public int satir = 19;

        const Char k = '►';
        ConsoleKeyInfo basilantus;
        ConsoleColor renk = ConsoleColor.Green;

        public void ciz()
        {
            Console.ForegroundColor = renk;
            Console.SetCursorPosition(sutun, satir);
            Console.Write(k);
        }
        public void sil()
        {
            Console.ForegroundColor = renk;
            Console.SetCursorPosition(sutun, satir);
            Console.Write(" ");
            if (Console.KeyAvailable)
            {
                basilantus = Console.ReadKey(false);
                if (basilantus.Key == ConsoleKey.UpArrow)
                {
                    satir--;
                    Console.Beep(1000, 100);
                }
                if (basilantus.Key == ConsoleKey.DownArrow)
                {
                    satir++;
                    Console.Beep(1000, 100);
                }
            }
        }
     
    }
}
