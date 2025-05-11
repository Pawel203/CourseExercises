using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerujTekst("Mam na imie #0 i mam #1 lat", "Adam", 22));
            Console.ReadKey();
        }
        public static string GenerujTekst(string tekst, params object[] args)
        {
            for (int i = 0; i < args.Length; i++) 
            {
                tekst = tekst.Replace("#" + i, args[i].ToString());
            }
            return tekst;
        }
    }
}
