using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dodaj(2, 4)); 
            Console.ReadKey();
        }

        static int Dodaj(int a, int b)
        {
            return (a + b);
        }
    }
}
