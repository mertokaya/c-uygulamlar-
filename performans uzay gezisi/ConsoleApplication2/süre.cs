using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class süre
    {
        public int i = 0, sat = 1;
        public void s()
        {
            for (i = 3; i >= 0; i--)
            {
                ConsoleColor sürer = ConsoleColor.Yellow;
                Console.ForegroundColor = sürer;
                Console.SetCursorPosition(1, sat);
                System.Threading.Thread.Sleep(1000);
                Console.Write(i + ">");
            }
        }
    }
}
