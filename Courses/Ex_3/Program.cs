using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            if (a > 0) 
            {
                Console.WriteLine(a + " jest wieksze od 0");
            }
            else if (a == 0)
            {
                Console.WriteLine(a + " jest rowne 0");
            }
            else
            {
                Console.WriteLine(a + " jest mniejsze od 0");

            }

        }
    }
}
