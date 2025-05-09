using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            liczba = int.Parse(Console.ReadLine());

            switch (liczba)
            {
                case 1:
                    Console.WriteLine("jeden");
                    break;
                case 2:
                    Console.WriteLine("dwa");
                    break;
                case 3:
                    Console.WriteLine("trzy");
                    break;
                default:
                    Console.WriteLine("inna wartosc");
                    break;
            }

            Console.ReadKey();
        }
    }
}
