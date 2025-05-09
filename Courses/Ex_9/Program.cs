using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[365];
            string[] dniTygodnia = {"poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "soobota", "niedziela"};

            tablica[0] = 22;

            for (int i = 0; i < dniTygodnia.Length; i++)
            {
                Console.WriteLine(dniTygodnia[i]);
            }

            Console.ReadKey();
        }
    }
}
