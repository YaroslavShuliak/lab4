using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    internal abstract class B
    {
        public virtual void Print()
        {
            Console.WriteLine($"Синий:");
        }
        public virtual int Sum(int a, int b)
        {
            return a + b;
        }
        public abstract double Math(int a, int b);
    }
}
