using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WHILE
            int a = 0;
            while (a < 5)
            {
                Console.WriteLine(a);
                a++;
            }

            Console.WriteLine();

            //FOR
            int i = 0;
            for (; i < 5; i++) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(i);

            //DO WHILE

            do
            {
                Console.WriteLine("hej");
                i++;
            }
            while (i < 10);
        }
    }
}

