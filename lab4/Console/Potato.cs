using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Potato : Apple
    {
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Перший агрумент: {a} \n {a.GetType}");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Третій агрумент: {b} \n {b.GetType}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
