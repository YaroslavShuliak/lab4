using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class Menu
    {
        private int a;
        private int b;
        private string s = "";
        private string t = "";
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public string S
        {
            get { return s; }
            set { s = value; }
        }
        public string T
        {
            get { return t; }
            set { t = value; }
        }
        public Menu(string s, string t)
        {
            s = S;
            t = T;
        }
        public Menu(int a, int b)
        {
            a = A;
            b = B;
        }
        static void Main(string[] args)
        {
            Position position = new Position("Морозиво", "Солодощi");
            PricenWeight pricenWeight = new PricenWeight(210, 440);
            Console.WriteLine($"Позицiя:{position.S} Роздiл:{position.T} Цiна:{pricenWeight.A} Грами:{pricenWeight.B}");
        }
    }
}