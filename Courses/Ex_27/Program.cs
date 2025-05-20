using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Postac p1 = new Mag("Radagast", 150, 250);

            Console.ReadKey();
        }
    }

    class Postac
    {
        public Postac()
        {

        }
        public Postac(string imie, int HP)
        {
            this.imie = imie;
            this.HP = HP;
        }
        public string imie;
        public int HP;
    }

    class Mag : Postac
    {
        public Mag(string imie, int HP, int mana) : base(imie, HP)
        {
            this.mana = mana;
        }
        public int mana;


    }
}
