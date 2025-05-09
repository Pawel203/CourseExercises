using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //break konczy kod i ignoruje reszte
        //int a = 0;
        //while (true)
        //{
        //    if (a == 10)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(a);
        //    a++;
        //}
        //Console.WriteLine(a);


        //continue pomija dalszy kod
        //for (int i = 0; i < 10; i++) 
        //{
        //    if (i % 2 == 1)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //}

        jeden:
            Console.WriteLine("Jeden");
            goto trzy;
        dwa:
            Console.WriteLine("Dwa");
        trzy:
            Console.WriteLine("Trzy");
            goto jeden;

            Console.ReadKey();
        }
    }
}


