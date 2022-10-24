using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class D : B
    {
        public override void Print()
        {
            Console.WriteLine($"Синий:");
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public override int Sum(int a, int b)
        {
            return base.Sum(a, b);
        }
        public override double Math(int a, int b)
        {
            return a * b;
        }
    }
}
