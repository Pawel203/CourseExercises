using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CzlowiekStatic.LiczbaLudnosci);  //do klasy statycznej mozna odwolac sie bez tworzenia obiektu
            CzlowiekStatic.LiczbaLudnosci = 10000;
            Console.WriteLine(CzlowiekStatic.LiczbaLudnosci);

            Czlowiek czlowiek = new Czlowiek();
            Console.WriteLine(czlowiek.imie); //do korzystania z klasy niestatycznej musimy utworzyc obiekt
            czlowiek.imie = "Marek";
            Console.WriteLine(czlowiek.imie);

            Czlowiek czlowiek2 = new Czlowiek();
            Console.WriteLine(czlowiek2.imie);

            Console.WriteLine(Czlowiek.liczbaLudnosci);

            Console.ReadKey();
        }
    }
}
