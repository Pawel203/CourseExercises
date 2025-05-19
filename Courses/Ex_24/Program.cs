using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "Program";
            //String s2 = new string("Program".ToArray());
            //Console.WriteLine(s1.Equals(s2));

            Auto auto1 = new Auto("FIAT", 1999);
            Auto auto2 = new Auto("FIAT", 1995);
            //Console.WriteLine(auto1 == auto2);
            Console.WriteLine(auto1.Equals(auto2));

            Console.ReadKey();
        }
    }
    class Auto
    {
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public Auto(string Model, int Rocznik)
        {
            this.Model = Model;
            this.Rocznik = Rocznik;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool Equals(Auto auto)
        { 
            return auto.Model == this.Model && auto.Rocznik == this.Rocznik;
        }

    }
}
