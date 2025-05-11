using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek adi = new Czlowiek();
            Console.WriteLine(adi.imie);
            adi.imie = "Bartek";
            Console.WriteLine(adi.imie);

            Czlowiek adi2 = new Czlowiek();
            adi2.imie = "Adrian";
            Console.WriteLine(adi2.imie);

            adi.PrzedstawSie();
            adi2.PrzedstawSie();

            Console.ReadKey();
        }
    }
}
