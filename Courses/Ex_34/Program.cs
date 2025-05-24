using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zwierze zwierze = new Zwierze();
            Kot kot = new Kot();
            zwierze = new Kot();

            Console.WriteLine(kot is Kot);

            Kot kot2 = zwierze as Kot;

            if (!(kot2 == null))
            {
                Console.WriteLine("Powiodlo sie");
            }
            else
            {
                Console.WriteLine("Nie powiodlo sie");
            }
        }
    }
    class Zwierze
    {
        public void DajGlos()
        {
            Console.WriteLine("Domyslny glos");
        }
    }
    class Kot : Zwierze
    {
        public void PijMleko()
        {
            Console.WriteLine("Piję mleko");
        }
    }
}
