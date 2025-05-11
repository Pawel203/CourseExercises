using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek adi = new Czlowiek("Dawid");
            adi.PrzedstawSie();
            adi.imie = "Bartek";
            adi.PrzedstawSie();


            Console.ReadKey();
        }
    }
}
