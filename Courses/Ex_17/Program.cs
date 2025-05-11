using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek czlowiek1 = new Czlowiek();
            czlowiek1.imie = "Paweł";
            //czlowiek1.setWiek(-20
            //czlowiek1.wiek = 20;
            czlowiek1.Wiek = 20;


            Console.WriteLine($"Jestem {czlowiek1.imie} lat {czlowiek1.Wiek}");


            Console.ReadKey();
        }
    }
}
