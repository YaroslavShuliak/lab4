using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class ABCDE
    {
        static void Main(string[] args)
        {
            C c = new C();
            D d = new D();
            E e = new E();
            A a = new A(c, d, e);
            d.Print();
            double func = d.Math(3, 9);
            Console.WriteLine(func);
        }
    }
}
