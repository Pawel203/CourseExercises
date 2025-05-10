using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int a = 5;
            //    Console.WriteLine("Przed " + a);
            //    Test(ref a);
            //    Console.WriteLine("Po " + a);
            //    Console.ReadKey();
            //}

            //static void Test(ref int a) //ref poznala na modyfikacje zmiennej przez funkcje
            //{
            //    a += 5;
            //    Console.WriteLine("W funkcji " + a);




            //    int a;
            //    //Console.WriteLine("Przed " + a);
            //    Test(out a);
            //    Console.WriteLine("Po " + a);
            //    Console.ReadKey();
            //}

            //static void Test(out int b)
            //{
            //    b = 5;
            //    b += 5;
            //    Console.WriteLine("W funkcji " + b);


            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 2;
            Console.WriteLine("Przed " + tab[0] + " " + tab[1]);
            Test(tab);
            Console.WriteLine("Po " + tab[0] + " " + tab[1]);
            Console.ReadKey();
        }

        static void Test(int[] tab)
        {
            //tab[0] = 522;
            //tab[1] = 324;
            tab = new int[2];
            tab[0] = 43;
            tab[1] = 41;
            Console.WriteLine("W funkcji " + tab[0] + " " + tab[1]);

        }
    }
}
