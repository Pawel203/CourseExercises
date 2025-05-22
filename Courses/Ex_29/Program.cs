using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Postac p1 = new Postac("Elf",200);
            IAtakMagiczny atak = (IAtakMagiczny)p1;
            atak.Atak(25);

        }
    }
    interface IAtakMagiczny
    {
        void Atak(int pkt);
    }
    interface IAtakMieczem
    {
        void Atak(int pkt);
    }
    class Postac : IAtakMagiczny, IAtakMieczem
    {
        public Postac(string imie, int HP)
        {
            this.imie = imie;
            this.HP = HP;
        }
        public string imie;
        public int HP;

        void IAtakMagiczny.Atak(int pkt)
        {
            Console.WriteLine();
        }
        void IAtakMieczem.Atak(int pkt)
        {
            Console.WriteLine();
        }
    }
}
