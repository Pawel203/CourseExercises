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
            Mag p1 = new Mag("Radagast", 150, 250);
            p1.Ruch();
            Console.ReadKey();
        }
    }

    abstract class Postac
    {
        public Postac(string imie, int HP)
        {
            this.imie = imie;
            this.HP = HP;
        }
        abstract public void Ruch();
        public string imie;
        public int HP;
    }

    sealed class Mag : Postac
    {
        public Mag(string imie, int HP, int mana) : base(imie, HP)
        {
            this.mana = mana;
        }
        public override void Ruch()
        {
            Console.WriteLine("Ruch Maga");
        }
        public int mana;


    }
    class SuperMag : Mag
    {

    }
}
