using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31
{
    enum PoryRoku
    {
        Wiosna = 15, Lato= 25, Jesień= 5, Zima = -5
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PoryRoku poraRoku = PoryRoku.Zima;
            Console.WriteLine((int)poraRoku);
        }
    }
}
