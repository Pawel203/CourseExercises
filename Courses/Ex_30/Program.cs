
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt2D punkt1 = new Punkt2D(9,4);
            punkt1.x = 10;
            punkt1.y = 5;
            Punkt2D punkt2;
            punkt2 = punkt1;
            punkt2.x = 7;
            Punkt2D punkt3 = punkt1 + punkt2;

            Console.WriteLine(punkt2.x);
            Console.WriteLine(punkt2.y);
            Console.WriteLine(punkt3.OdlegloscOdSrodka());

        }
    }

    struct Punkt2D
    {
        public static Punkt2D operator +(Punkt2D a, Punkt2D b)
        {
            return new Punkt2D(a.x + b.x, a.y + b.y);
        }
        public Punkt2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;
        public double OdlegloscOdSrodka()
        {
            return Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)),1);
        }
    }
}
