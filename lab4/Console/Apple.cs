using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Apple
    {
        protected int a = 10;
        protected string b = "parametr";
        public virtual void Print()
        {
            Console.WriteLine($"Перший агрумент {a}");
            Console.WriteLine($"Третій агрумент {b}");
        }
        static void Main(string[] args)
        {
            Potato potato = new Potato();
            potato.Print();
        }
    }
}
