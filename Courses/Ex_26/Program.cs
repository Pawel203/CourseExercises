using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ziemia ziemia = new Ziemia();
            ziemia.Nazwa = "Ziemia";
            Console.WriteLine(ziemia.Nazwa);

            Console.ReadKey();
        }
    }

    abstract class CialoNiebieskie
    {
        public string Nazwa { get; set; }
        public void RuchObrotowy() 
        {
            Console.WriteLine("Kazde cialo niebieski posiada ruch obrotowy");
        }
    }
    abstract class Planeta : CialoNiebieskie
    {
        void PoraDniaINocy()
        {
            Console.WriteLine("Pory Dnia i Nocy");
        }
    }

    class Ziemia : Planeta
    {
        void Atmosfera()
        {
            Console.WriteLine("Atmosfera Ziemska");
        }
    }
}
