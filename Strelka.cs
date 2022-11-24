using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проводник
{
    internal class Strelka
    {
        public ConsoleKey StrlekD()
        {
            int dis = Write.Disk();
            int max = dis + 2; 
            int min = 1;

            int posa = 2;

            ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key != ConsoleKey.Escape)
            {

                Console.SetCursorPosition(0, posa);
                Console.Write("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, posa);
                    Console.WriteLine("  ");

                    posa--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, posa );
                    Console.WriteLine("  ");

                    posa++;
                }

                if (posa == min)
                {
                    posa = dis + 1;
                }
                else if (posa == max)
                {
                    posa = 2;
                }

                if (key.Key == ConsoleKey.Enter)
                {
                    return key.Key;
                }

                Console.SetCursorPosition(0, posa);
                Console.Write("->");
            }
            return key.Key;
        }
    }
}
