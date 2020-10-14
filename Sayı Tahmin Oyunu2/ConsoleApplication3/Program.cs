using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Random rst = new Random();
            int bts = rst.Next(0, 100);
            for (int a = 0; a < 8; a++)
            {   
                Console.Write("Tahmininizi giriniz: ");
                int kt = Convert.ToInt16(Console.ReadLine());

                if (kt == bts)
                {
                    Console.WriteLine("Tebrikler Doğru Bildiniz.");
                    Console.WriteLine("Çıkmak İçin Enter Tuşuna Basınız.");
                    break;

                }

                if (kt > bts)
                {
                    Console.WriteLine("Benim Tuttuğum Sayı Daha Küçüktü.");
                }
                else
                {
                    Console.WriteLine("Benim Tuttuğum Sayı Daha Büyüktü.");
                }
                if (a == 7)
                {
                    Console.WriteLine("Üzgünüm. Benim Tuttuğum sayı :"+bts);
                    Console.Write("Çıkmak için Enter Tuşuna Basınız...");
                   
                }
            }

            Console.ReadLine();
        }
    }
}
